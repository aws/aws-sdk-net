using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.IoTManagedIntegrations;
using Amazon.IoTManagedIntegrations.Model;

namespace AWSSDKDocSamples.Amazon.IoTManagedIntegrations.Generated
{
    class IoTManagedIntegrationsSamples : ISample
    {
        public void IoTManagedIntegrationsGetSchemaVersion()
        {
            #region example-1

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.GetSchemaVersion(new GetSchemaVersionRequest 
            {
                SchemaVersionedId = "matter.ColorControl@$latest",
                Type = "capability"
            });

            string description = response.Description;
            string awsNamespace = response.Namespace;
            SchemaVersionSchema schema = response.Schema;
            string schemaId = response.SchemaId;
            string semanticVersion = response.SemanticVersion;
            string type = response.Type;

            #endregion
        }

        public void IoTManagedIntegrationsGetSchemaVersion()
        {
            #region example-2

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.GetSchemaVersion(new GetSchemaVersionRequest 
            {
                Format = "ZCL",
                SchemaVersionedId = "matter.ColorControl@1.3",
                Type = "capability"
            });

            string description = response.Description;
            string awsNamespace = response.Namespace;
            SchemaVersionSchema schema = response.Schema;
            string schemaId = response.SchemaId;
            string semanticVersion = response.SemanticVersion;
            string type = response.Type;

            #endregion
        }

        public void IoTManagedIntegrationsGetSchemaVersion()
        {
            #region example-3

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.GetSchemaVersion(new GetSchemaVersionRequest 
            {
                SchemaVersionedId = "matter.ColorControl@$latest",
                Type = "capability"
            });


            #endregion
        }

        public void IoTManagedIntegrationsListSchemaVersions()
        {
            #region example-1

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.ListSchemaVersions(new ListSchemaVersionsRequest 
            {
                SchemaId = "matter.ColorControl",
                Type = "capability"
            });

            List<SchemaVersionListItem> items = response.Items;

            #endregion
        }

        public void IoTManagedIntegrationsListSchemaVersions()
        {
            #region example-2

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.ListSchemaVersions(new ListSchemaVersionsRequest 
            {
                SemanticVersion = "34.56",
                Type = "capability"
            });

            List<SchemaVersionListItem> items = response.Items;

            #endregion
        }

        public void IoTManagedIntegrationsListSchemaVersions()
        {
            #region example-3

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.ListSchemaVersions(new ListSchemaVersionsRequest 
            {
                Namespace = "matter",
                SchemaId = "matter.ColorControl",
                Type = "capability"
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