using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EMRServiceModels.Models;
using RestSharp;

namespace EMRSampleClient
{
    public partial class PhysicianExample : System.Web.UI.Page
    {
        // RestSharp library object uses service url string from web.config
        RestClient client = new RestClient(ConfigurationManager.AppSettings["ServiceURL"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ClearData();

            #region Request Physician using RestSharp library

            RestRequest request = new RestRequest("physician/{id}", Method.GET);
            request.AddUrlSegment("id", txtSearch.Text);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("key", "f81d4fae-7dec-11d0-a765-00a0c91e6bf6");
            IRestResponse<Physician> response = client.Execute<Physician>(request);

            #endregion

            #region Fill in UI objects
            if (response.Data != null)
            {
                txtID.Text = response.Data.Id;

                if (response.Data.PhysicianAddress != null)
                {
                    txtStreet1.Text = response.Data.PhysicianAddress.Street;
                    txtStreet2.Text = response.Data.PhysicianAddress.Street2;
                    txtCity.Text = response.Data.PhysicianAddress.City;
                    txtState.Text = response.Data.PhysicianAddress.State;
                    txtZip.Text = response.Data.PhysicianAddress.ZipCode;
                }

                if (response.Data.PhysicianName != null)
                {
                    txtFirst.Text = response.Data.PhysicianName.FirstName;
                    txtLast.Text = response.Data.PhysicianName.LastName;
                    txtMiddle.Text = response.Data.PhysicianName.MiddleInitial;
                    txtSuffix.Text = response.Data.PhysicianName.Suffix;
                }

                txtNumber.Text = response.Data.PhoneNumber;

                txtSpeciality.Text = response.Data.Speciality;
            }
            #endregion
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {

            #region Create Physician object based on UI values

            Physician physician = new Physician();
            Address address = new Address();
            Name name = new Name();

            address.Street = txtStreet1.Text;
            address.Street2 = txtStreet2.Text;
            address.City = txtCity.Text;
            address.State = txtState.Text;
            address.ZipCode = txtZip.Text;
            physician.PhysicianAddress = address;

            name.FirstName = txtFirst.Text;
            name.LastName = txtLast.Text;
            name.MiddleInitial = txtMiddle.Text;
            name.Suffix = txtSuffix.Text;
            physician.PhysicianName = name;

            physician.PhoneNumber = txtNumber.Text;

            physician.Speciality = txtSpeciality.Text;

            #endregion

            #region Post Physician object using RestSharp library

            RestRequest request = new RestRequest("physician", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(physician);           
            request.AddHeader("key", "f81d4fae-7dec-11d0-a765-00a0c91e6bf6");
            IRestResponse<Physician> response = client.Execute<Physician>(request);

            #endregion

            // Display ID created by service for Physician
            if (response.Data != null)
            {
                txtID.Text = response.Data.Id;
            }

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Create Physician object based on UI values

            Physician physician = new Physician();
            Address address = new Address();
            Name name = new Name();

            physician.Id = txtID.Text;
            address.Street = txtStreet1.Text;
            address.Street2 = txtStreet2.Text;
            address.City = txtCity.Text;
            address.State = txtState.Text;
            address.ZipCode = txtZip.Text;
            physician.PhysicianAddress = address;

            name.FirstName = txtFirst.Text;
            name.LastName = txtLast.Text;
            name.MiddleInitial = txtMiddle.Text;
            name.Suffix = txtSuffix.Text;
            physician.PhysicianName = name;

            physician.PhoneNumber = txtNumber.Text;

            physician.Speciality = txtSpeciality.Text;

            #endregion

            #region Put Physician object using RestSharp library

            RestRequest request = new RestRequest("physician", Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(physician);
            request.AddHeader("key", "f81d4fae-7dec-11d0-a765-00a0c91e6bf6");
            IRestResponse<Physician> response = client.Execute<Physician>(request);

            #endregion
        }

        // helper method for clearing UI
        private void ClearData()
        {
            txtID.Text = string.Empty;
            txtStreet1.Text = string.Empty;
            txtStreet2.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtState.Text = string.Empty;
            txtZip.Text = string.Empty;
            txtFirst.Text = string.Empty;
            txtLast.Text = string.Empty;
            txtMiddle.Text = string.Empty;
            txtSuffix.Text = string.Empty;
            txtNumber.Text = string.Empty;
            txtSpeciality.Text = string.Empty;
        }

    }
}