using GsisServicesLib.Greek;
using GsisServicesLib.GreekLegalEntityInfoService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GsisServiceWin
{
    public partial class MainForm : Form
    {


        private IGreekLegalEntityInfoInvoker _greekLegalEntityInfoInvoker;


        public MainForm()
        {
            InitializeComponent();



            _greekLegalEntityInfoInvoker = new GreekLegalEntityInfoInvoker();

            this.CallServiceViewModelBindingSource.DataSource = new CallServiceViewModel();

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultsTextBox.Clear();
        }



        private async void GetEntityVatInfoButton_Click(object sender, EventArgs e)
        {
          
            try
            {
                this.Validate();

                this.ResultsTextBox.Clear();

                var info=this.CallServiceViewModelBindingSource.DataSource as CallServiceViewModel;

                if(!info.IsValid())
                {
                    var validationResults= info.GetValidationErrors();
                    throw new ValidationException("Validation Errors", validationResults);
                }


                var response = await _greekLegalEntityInfoInvoker.GetLegalEntityInfoAsync(info.UserName, info.Password, info.AuthVatNumber, info.SearchForVatNumber);

                PresentVatSearchResults(response);


            }
            catch (ValidationException vex)
            {

                var errors=  string.Join(Environment.NewLine, vex.ValidationErrors);

                this.ResultsTextBox.Text = $"{vex.Message}{Environment.NewLine}{string.Empty.PadLeft(80,'-')}{Environment.NewLine}{errors}";
            }
            catch (GreekLegalEntityServiceException glex)
            {
                this.ResultsTextBox.Text = glex.Message;
            }
            catch (Exception ex)
            {
                this.ResultsTextBox.Text = ex.ToString();
            }
        }

        public void PresentVatSearchResults(RgWsPublicBasicRtUser info)
        {


            var result = $@"
          Search results for vatNumber {info.afm}
--------------------------------------------------------------------------------
          Discrete Title: {info.commerTitle}
                    Name: {info.onomasia}
              Vat Number: {info.afm}
         IRS Description: {info.doyDescr}
                 Address: {info.postalAddress}
              Address No: {info.postalAddressNo}
                    Area: {info.postalAreaDescription}
                 ZipCode: {info.postalZipCode}
       Registration Date: {info.registDate}
Deactivation Description: {info.deactivationFlagDescr}
                        : {info.INiFlagDescr}
Legal Status Description: {info.legalStatusDescr}
        Deactivated Date: {info.stopDate}
";

            this.ResultsTextBox.Text = result;
        }


    }

}

