using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.AppIntegrationsService;
using Amazon.AppIntegrationsService.Model;

namespace AWSSDKDocSamples.Amazon.AppIntegrationsService.Generated
{
    class AppIntegrationsServiceSamples : ISample
    {
        public void AppIntegrationsServiceCreateApplication()
        {
            #region create-an-application

            var client = new AmazonAppIntegrationsServiceClient();
            var response = client.CreateApplication(new CreateApplicationRequest 
            {
                ApplicationSourceConfig = new ApplicationSourceConfig { ExternalUrlConfig = new ExternalUrlConfig { AccessUrl = "https://example.com" } },
                Description = "My first application.",
                Name = "My Application",
                Namespace = "myapplication"
            });

            string arn = response.Arn;
            string id = response.Id;

            #endregion
        }

        public void AppIntegrationsServiceDeleteApplication()
        {
            #region delete-an-application

            var client = new AmazonAppIntegrationsServiceClient();
            var response = client.DeleteApplication(new DeleteApplicationRequest 
            {
                Arn = "arn:aws:app-integrations:us-west-2:0123456789012:application/98542c53-e8ac-4570-9c85-c6552c8d9c5e"
            });


            #endregion
        }

        public void AppIntegrationsServiceGetApplication()
        {
            #region get-an-application

            var client = new AmazonAppIntegrationsServiceClient();
            var response = client.GetApplication(new GetApplicationRequest 
            {
                Arn = "arn:aws:app-integrations:us-west-2:0123456789012:application/98542c53-e8ac-4570-9c85-c6552c8d9c5e"
            });

            ApplicationSourceConfig applicationSourceConfig = response.ApplicationSourceConfig;
            string description = response.Description;
            string name = response.Name;
            string awsNamespace = response.Namespace;

            #endregion
        }

        public void AppIntegrationsServiceListApplicationAssociations()
        {
            #region list-application-associations

            var client = new AmazonAppIntegrationsServiceClient();
            var response = client.ListApplicationAssociations(new ListApplicationAssociationsRequest 
            {
                ApplicationId = "98542c53-e8ac-4570-9c85-c6552c8d9c5e"
            });

            List<ApplicationAssociationSummary> applicationAssociations = response.ApplicationAssociations;
            string nextToken = response.NextToken;

            #endregion
        }

        public void AppIntegrationsServiceListApplications()
        {
            #region list-applications

            var client = new AmazonAppIntegrationsServiceClient();
            var response = client.ListApplications(new ListApplicationsRequest 
            {
                MaxResults = 1
            });

            List<ApplicationSummary> applications = response.Applications;
            string nextToken = response.NextToken;

            #endregion
        }

        public void AppIntegrationsServiceUpdateApplication()
        {
            #region update-an-application

            var client = new AmazonAppIntegrationsServiceClient();
            var response = client.UpdateApplication(new UpdateApplicationRequest 
            {
                Arn = "arn:aws:app-integrations:us-west-2:0123456789012:application/98542c53-e8ac-4570-9c85-c6552c8d9c5e",
                Name = "My New Application Name"
            });


            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}