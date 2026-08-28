using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.HealthLake;
using Amazon.HealthLake.Model;

namespace AWSSDKDocSamples.Amazon.HealthLake.Generated
{
    class HealthLakeSamples : ISample
    {
        public void HealthLakeRestoreFHIRDatastore()
        {
            #region example-1

            var client = new AmazonHealthLakeClient();
            var response = client.RestoreFHIRDatastore(new RestoreFHIRDatastoreRequest 
            {
                DatastoreName = "RestoredFhirDatastore",
                RestoreConfiguration = new RestoreConfiguration { ContinuousBackupRestoreConfiguration = new ContinuousBackupRestoreConfiguration { RestorePointTime = new DateTime(2026, 8, 1, 12, 0, 0, DateTimeKind.Utc) } },
                SourceDatastoreId = "source-datastore-id"
            });

            string datastoreArn = response.DatastoreArn;
            string datastoreEndpoint = response.DatastoreEndpoint;
            string datastoreId = response.DatastoreId;
            string datastoreStatus = response.DatastoreStatus;

            #endregion
        }

        public void HealthLakeUpdateFHIRDatastore()
        {
            #region example-1

            var client = new AmazonHealthLakeClient();
            var response = client.UpdateFHIRDatastore(new UpdateFHIRDatastoreRequest 
            {
                AnalyticsConfiguration = new AnalyticsConfiguration { Status = "DISABLED" },
                DatastoreId = "datastore-id",
                DatastoreName = "RenamedFhirDatastore",
                IdentityProviderConfiguration = new IdentityProviderConfiguration {
                    AuthorizationStrategy = "SMART_ON_FHIR_V1",
                    FineGrainedAuthorizationEnabled = true
                },
                NlpConfiguration = new NlpConfiguration { Status = "ENABLED" },
                ProfileConfiguration = new ProfileConfiguration { DefaultProfiles = new List<string> {
                    "us-core-3.1.1",
                    "carin-bb-2.0.0"
                } }
            });

            DatastoreProperties datastoreProperties = response.DatastoreProperties;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}