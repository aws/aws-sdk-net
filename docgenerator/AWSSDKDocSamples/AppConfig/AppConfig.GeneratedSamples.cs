using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.AppConfig;
using Amazon.AppConfig.Model;

namespace AWSSDKDocSamples.Amazon.AppConfig.Generated
{
    class AppConfigSamples : ISample
    {
        public void AppConfigCreateApplication()
        {
            #region to-create-an-application-1632264511615

            var client = new AmazonAppConfigClient();
            var response = client.CreateApplication(new CreateApplicationRequest 
            {
                Description = "An application used for creating an example.",
                Name = "example-application"
            });

            string description = response.Description;
            string id = response.Id;
            string name = response.Name;

            #endregion
        }

        public void AppConfigCreateConfigurationProfile()
        {
            #region to-create-a-configuration-profile-1632264580336

            var client = new AmazonAppConfigClient();
            var response = client.CreateConfigurationProfile(new CreateConfigurationProfileRequest 
            {
                ApplicationId = "339ohji",
                LocationUri = "ssm-parameter://Example-Parameter",
                Name = "Example-Configuration-Profile",
                RetrievalRoleArn = "arn:aws:iam::111122223333:role/Example-App-Config-Role"
            });

            string applicationId = response.ApplicationId;
            string id = response.Id;
            string locationUri = response.LocationUri;
            string name = response.Name;
            string retrievalRoleArn = response.RetrievalRoleArn;

            #endregion
        }

        public void AppConfigCreateDeploymentStrategy()
        {
            #region to-create-a-deployment-strategy-1632264783812

            var client = new AmazonAppConfigClient();
            var response = client.CreateDeploymentStrategy(new CreateDeploymentStrategyRequest 
            {
                DeploymentDurationInMinutes = 15,
                GrowthFactor = 25,
                Name = "Example-Deployment",
                ReplicateTo = "SSM_DOCUMENT"
            });

            int deploymentDurationInMinutes = response.DeploymentDurationInMinutes;
            int finalBakeTimeInMinutes = response.FinalBakeTimeInMinutes;
            float growthFactor = response.GrowthFactor;
            string growthType = response.GrowthType;
            string id = response.Id;
            string name = response.Name;
            string replicateTo = response.ReplicateTo;

            #endregion
        }

        public void AppConfigCreateEnvironment()
        {
            #region to-create-an-environment-1632265124975

            var client = new AmazonAppConfigClient();
            var response = client.CreateEnvironment(new CreateEnvironmentRequest 
            {
                ApplicationId = "339ohji",
                Name = "Example-Environment"
            });

            string applicationId = response.ApplicationId;
            string id = response.Id;
            string name = response.Name;
            string state = response.State;

            #endregion
        }

        public void AppConfigCreateHostedConfigurationVersion()
        {
            #region to-create-a-hosted-configuration-version-1632265196980

            var client = new AmazonAppConfigClient();
            var response = client.CreateHostedConfigurationVersion(new CreateHostedConfigurationVersionRequest 
            {
                ApplicationId = "339ohji",
                ConfigurationProfileId = "ur8hx2f",
                Content = new MemoryStream(eyAiTmFtZSI6ICJFeGFtcGxlQXBwbGljYXRpb24iLCAiSWQiOiBFeGFtcGxlSUQsICJSYW5rIjogNyB9),
                ContentType = "text",
                LatestVersionNumber = 1
            });

            string applicationId = response.ApplicationId;
            string configurationProfileId = response.ConfigurationProfileId;
            string contentType = response.ContentType;
            int versionNumber = response.VersionNumber;

            #endregion
        }

        public void AppConfigDeleteApplication()
        {
            #region to-delete-an-application-1632265343951

            var client = new AmazonAppConfigClient();
            var response = client.DeleteApplication(new DeleteApplicationRequest 
            {
                ApplicationId = "339ohji"
            });


            #endregion
        }

        public void AppConfigDeleteConfigurationProfile()
        {
            #region to-delete-a-configuration-profile-1632265401308

            var client = new AmazonAppConfigClient();
            var response = client.DeleteConfigurationProfile(new DeleteConfigurationProfileRequest 
            {
                ApplicationId = "339ohji",
                ConfigurationProfileId = "ur8hx2f"
            });


            #endregion
        }

        public void AppConfigDeleteDeploymentStrategy()
        {
            #region to-delete-a-deployment-strategy-1632265473708

            var client = new AmazonAppConfigClient();
            var response = client.DeleteDeploymentStrategy(new DeleteDeploymentStrategyRequest 
            {
                DeploymentStrategyId = "1225qzk"
            });


            #endregion
        }

        public void AppConfigDeleteEnvironment()
        {
            #region to-delete-an-environment-1632265641044

            var client = new AmazonAppConfigClient();
            var response = client.DeleteEnvironment(new DeleteEnvironmentRequest 
            {
                ApplicationId = "339ohji",
                EnvironmentId = "54j1r29"
            });


            #endregion
        }

        public void AppConfigDeleteHostedConfigurationVersion()
        {
            #region to-delete-a-hosted-configuration-version-1632265720740

            var client = new AmazonAppConfigClient();
            var response = client.DeleteHostedConfigurationVersion(new DeleteHostedConfigurationVersionRequest 
            {
                ApplicationId = "339ohji",
                ConfigurationProfileId = "ur8hx2f",
                VersionNumber = 1
            });


            #endregion
        }

        public void AppConfigGetApplication()
        {
            #region to-list-details-of-an-application-1632265864702

            var client = new AmazonAppConfigClient();
            var response = client.GetApplication(new GetApplicationRequest 
            {
                ApplicationId = "339ohji"
            });

            string id = response.Id;
            string name = response.Name;

            #endregion
        }

        public void AppConfigGetConfiguration()
        {
            #region to-retrieve-configuration-details-1632265954314

            var client = new AmazonAppConfigClient();
            var response = client.GetConfiguration(new GetConfigurationRequest 
            {
                Application = "example-application",
                ClientId = "example-id",
                Configuration = "Example-Configuration-Profile",
                Environment = "Example-Environment"
            });

            string configurationVersion = response.ConfigurationVersion;
            string contentType = response.ContentType;

            #endregion
        }

        public void AppConfigGetConfigurationProfile()
        {
            #region to-retrieve-configuration-profile-details-1632266081013

            var client = new AmazonAppConfigClient();
            var response = client.GetConfigurationProfile(new GetConfigurationProfileRequest 
            {
                ApplicationId = "339ohji",
                ConfigurationProfileId = "ur8hx2f"
            });

            string applicationId = response.ApplicationId;
            string id = response.Id;
            string locationUri = response.LocationUri;
            string name = response.Name;
            string retrievalRoleArn = response.RetrievalRoleArn;

            #endregion
        }

        public void AppConfigGetDeployment()
        {
            #region to-retrieve-deployment-details-1633976766883

            var client = new AmazonAppConfigClient();
            var response = client.GetDeployment(new GetDeploymentRequest 
            {
                ApplicationId = "339ohji",
                DeploymentNumber = 1,
                EnvironmentId = "54j1r29"
            });

            string applicationId = response.ApplicationId;
            DateTime completedAt = response.CompletedAt;
            string configurationLocationUri = response.ConfigurationLocationUri;
            string configurationName = response.ConfigurationName;
            string configurationProfileId = response.ConfigurationProfileId;
            string configurationVersion = response.ConfigurationVersion;
            int deploymentDurationInMinutes = response.DeploymentDurationInMinutes;
            int deploymentNumber = response.DeploymentNumber;
            string deploymentStrategyId = response.DeploymentStrategyId;
            string environmentId = response.EnvironmentId;
            List<DeploymentEvent> eventLog = response.EventLog;
            int finalBakeTimeInMinutes = response.FinalBakeTimeInMinutes;
            float growthFactor = response.GrowthFactor;
            string growthType = response.GrowthType;
            float percentageComplete = response.PercentageComplete;
            DateTime startedAt = response.StartedAt;
            string state = response.State;

            #endregion
        }

        public void AppConfigGetDeploymentStrategy()
        {
            #region to-retrieve-details-of-a-deployment-strategy-1632266385805

            var client = new AmazonAppConfigClient();
            var response = client.GetDeploymentStrategy(new GetDeploymentStrategyRequest 
            {
                DeploymentStrategyId = "1225qzk"
            });

            int deploymentDurationInMinutes = response.DeploymentDurationInMinutes;
            int finalBakeTimeInMinutes = response.FinalBakeTimeInMinutes;
            float growthFactor = response.GrowthFactor;
            string growthType = response.GrowthType;
            string id = response.Id;
            string name = response.Name;
            string replicateTo = response.ReplicateTo;

            #endregion
        }

        public void AppConfigGetEnvironment()
        {
            #region to-retrieve-environment-details-1632266924806

            var client = new AmazonAppConfigClient();
            var response = client.GetEnvironment(new GetEnvironmentRequest 
            {
                ApplicationId = "339ohji",
                EnvironmentId = "54j1r29"
            });

            string applicationId = response.ApplicationId;
            string id = response.Id;
            string name = response.Name;
            string state = response.State;

            #endregion
        }

        public void AppConfigGetHostedConfigurationVersion()
        {
            #region to-retrieve-hosted-configuration-details-1632267003527

            var client = new AmazonAppConfigClient();
            var response = client.GetHostedConfigurationVersion(new GetHostedConfigurationVersionRequest 
            {
                ApplicationId = "339ohji",
                ConfigurationProfileId = "ur8hx2f",
                VersionNumber = 1
            });

            string applicationId = response.ApplicationId;
            string configurationProfileId = response.ConfigurationProfileId;
            string contentType = response.ContentType;
            int versionNumber = response.VersionNumber;

            #endregion
        }

        public void AppConfigListApplications()
        {
            #region to-list-the-available-applications-1632267111131

            var client = new AmazonAppConfigClient();
            var response = client.ListApplications(new ListApplicationsRequest 
            {
            });

            List<Application> items = response.Items;

            #endregion
        }

        public void AppConfigListConfigurationProfiles()
        {
            #region to-list-the-available-configuration-profiles-1632267193265

            var client = new AmazonAppConfigClient();
            var response = client.ListConfigurationProfiles(new ListConfigurationProfilesRequest 
            {
                ApplicationId = "339ohji"
            });

            List<ConfigurationProfileSummary> items = response.Items;

            #endregion
        }

        public void AppConfigListDeployments()
        {
            #region to-list-the-available-deployments-1632267282025

            var client = new AmazonAppConfigClient();
            var response = client.ListDeployments(new ListDeploymentsRequest 
            {
                ApplicationId = "339ohji",
                EnvironmentId = "54j1r29"
            });

            List<DeploymentSummary> items = response.Items;

            #endregion
        }

        public void AppConfigListDeploymentStrategies()
        {
            #region to-list-the-available-deployment-strategies-1632267364180

            var client = new AmazonAppConfigClient();
            var response = client.ListDeploymentStrategies(new ListDeploymentStrategiesRequest 
            {
            });

            List<DeploymentStrategy> items = response.Items;

            #endregion
        }

        public void AppConfigListEnvironments()
        {
            #region to-list-the-available-environments-1632267474389

            var client = new AmazonAppConfigClient();
            var response = client.ListEnvironments(new ListEnvironmentsRequest 
            {
                ApplicationId = "339ohji"
            });

            List<Environment> items = response.Items;

            #endregion
        }

        public void AppConfigListHostedConfigurationVersions()
        {
            #region to-list-the-available-hosted-configuration-versions-1632267647667

            var client = new AmazonAppConfigClient();
            var response = client.ListHostedConfigurationVersions(new ListHostedConfigurationVersionsRequest 
            {
                ApplicationId = "339ohji",
                ConfigurationProfileId = "ur8hx2f"
            });

            List<HostedConfigurationVersionSummary> items = response.Items;

            #endregion
        }

        public void AppConfigListTagsForResource()
        {
            #region to-list-the-tags-of-an-application-1632328796560

            var client = new AmazonAppConfigClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceArn = "arn:aws:appconfig:us-east-1:111122223333:application/339ohji"
            });

            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void AppConfigStartDeployment()
        {
            #region to-start-a-configuration-deployment-1632328956790

            var client = new AmazonAppConfigClient();
            var response = client.StartDeployment(new StartDeploymentRequest 
            {
                ApplicationId = "339ohji",
                ConfigurationProfileId = "ur8hx2f",
                ConfigurationVersion = "1",
                DeploymentStrategyId = "1225qzk",
                Description = "",
                EnvironmentId = "54j1r29",
                Tags = new Dictionary<string, string> {
                    
                }
            });

            string applicationId = response.ApplicationId;
            string configurationLocationUri = response.ConfigurationLocationUri;
            string configurationName = response.ConfigurationName;
            string configurationProfileId = response.ConfigurationProfileId;
            string configurationVersion = response.ConfigurationVersion;
            int deploymentDurationInMinutes = response.DeploymentDurationInMinutes;
            int deploymentNumber = response.DeploymentNumber;
            string deploymentStrategyId = response.DeploymentStrategyId;
            string environmentId = response.EnvironmentId;
            List<DeploymentEvent> eventLog = response.EventLog;
            int finalBakeTimeInMinutes = response.FinalBakeTimeInMinutes;
            float growthFactor = response.GrowthFactor;
            string growthType = response.GrowthType;
            float percentageComplete = response.PercentageComplete;
            DateTime startedAt = response.StartedAt;
            string state = response.State;

            #endregion
        }

        public void AppConfigStopDeployment()
        {
            #region to-stop-configuration-deployment-1632329139126

            var client = new AmazonAppConfigClient();
            var response = client.StopDeployment(new StopDeploymentRequest 
            {
                ApplicationId = "339ohji",
                DeploymentNumber = 2,
                EnvironmentId = "54j1r29"
            });

            int deploymentDurationInMinutes = response.DeploymentDurationInMinutes;
            int deploymentNumber = response.DeploymentNumber;
            int finalBakeTimeInMinutes = response.FinalBakeTimeInMinutes;
            float growthFactor = response.GrowthFactor;
            float percentageComplete = response.PercentageComplete;

            #endregion
        }

        public void AppConfigTagResource()
        {
            #region to-tag-an-application-1632330350645

            var client = new AmazonAppConfigClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                ResourceArn = "arn:aws:appconfig:us-east-1:111122223333:application/339ohji",
                Tags = new Dictionary<string, string> {
                    { "group1", "1" }
                }
            });


            #endregion
        }

        public void AppConfigUntagResource()
        {
            #region to-remove-a-tag-from-an-application-1632330429881

            var client = new AmazonAppConfigClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                ResourceArn = "arn:aws:appconfig:us-east-1:111122223333:application/339ohji",
                TagKeys = new List<string> {
                    "group1"
                }
            });


            #endregion
        }

        public void AppConfigUpdateApplication()
        {
            #region to-update-an-application-1632330585893

            var client = new AmazonAppConfigClient();
            var response = client.UpdateApplication(new UpdateApplicationRequest 
            {
                ApplicationId = "339ohji",
                Description = "",
                Name = "Example-Application"
            });

            string description = response.Description;
            string id = response.Id;
            string name = response.Name;

            #endregion
        }

        public void AppConfigUpdateConfigurationProfile()
        {
            #region to-update-a-configuration-profile-1632330721974

            var client = new AmazonAppConfigClient();
            var response = client.UpdateConfigurationProfile(new UpdateConfigurationProfileRequest 
            {
                ApplicationId = "339ohji",
                ConfigurationProfileId = "ur8hx2f",
                Description = "Configuration profile used for examples."
            });

            string applicationId = response.ApplicationId;
            string description = response.Description;
            string id = response.Id;
            string locationUri = response.LocationUri;
            string name = response.Name;
            string retrievalRoleArn = response.RetrievalRoleArn;

            #endregion
        }

        public void AppConfigUpdateDeploymentStrategy()
        {
            #region to-update-a-deployment-strategy-1632330896602

            var client = new AmazonAppConfigClient();
            var response = client.UpdateDeploymentStrategy(new UpdateDeploymentStrategyRequest 
            {
                DeploymentStrategyId = "1225qzk",
                FinalBakeTimeInMinutes = 20
            });

            int deploymentDurationInMinutes = response.DeploymentDurationInMinutes;
            int finalBakeTimeInMinutes = response.FinalBakeTimeInMinutes;
            float growthFactor = response.GrowthFactor;
            string growthType = response.GrowthType;
            string id = response.Id;
            string name = response.Name;
            string replicateTo = response.ReplicateTo;

            #endregion
        }

        public void AppConfigUpdateEnvironment()
        {
            #region to-update-an-environment-1632331382428

            var client = new AmazonAppConfigClient();
            var response = client.UpdateEnvironment(new UpdateEnvironmentRequest 
            {
                ApplicationId = "339ohji",
                Description = "An environment for examples.",
                EnvironmentId = "54j1r29"
            });

            string applicationId = response.ApplicationId;
            string description = response.Description;
            string id = response.Id;
            string name = response.Name;
            string state = response.State;

            #endregion
        }

        public void AppConfigValidateConfiguration()
        {
            #region to-validate-a-configuration-1632331491365

            var client = new AmazonAppConfigClient();
            var response = client.ValidateConfiguration(new ValidateConfigurationRequest 
            {
                ApplicationId = "abc1234",
                ConfigurationProfileId = "ur8hx2f",
                ConfigurationVersion = "1"
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