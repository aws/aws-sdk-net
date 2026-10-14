using System;
using System.Collections.Generic;
using System.IO;
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
            #region CreateApplication-1

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
            #region CreateConfigurationProfile-1

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
            #region CreateDeploymentStrategy-1

            var client = new AmazonAppConfigClient();
            var response = client.CreateDeploymentStrategy(new CreateDeploymentStrategyRequest
            {
                DeploymentDurationInMinutes = 15,
                GrowthFactor = 25,
                Name = "Example-Deployment",
                ReplicateTo = "SSM_DOCUMENT"
            });

            int? deploymentDurationInMinutes = response.DeploymentDurationInMinutes;
            int? finalBakeTimeInMinutes = response.FinalBakeTimeInMinutes;
            float? growthFactor = response.GrowthFactor;
            GrowthType growthType = response.GrowthType;
            string id = response.Id;
            string name = response.Name;
            ReplicateTo replicateTo = response.ReplicateTo;

            #endregion
        }

        public void AppConfigCreateEnvironment()
        {
            #region CreateEnvironment-1

            var client = new AmazonAppConfigClient();
            var response = client.CreateEnvironment(new CreateEnvironmentRequest
            {
                ApplicationId = "339ohji",
                Name = "Example-Environment"
            });

            string applicationId = response.ApplicationId;
            string id = response.Id;
            string name = response.Name;
            EnvironmentState state = response.State;

            #endregion
        }

        public void AppConfigCreateExperimentDefinition()
        {
            #region CreateExperimentDefinition-1

            var client = new AmazonAppConfigClient();
            var response = client.CreateExperimentDefinition(new CreateExperimentDefinitionRequest
            {
                ApplicationIdentifier = "339ohji",
                AudienceRule = "(eq $country \"US\")",
                ConfigurationProfileIdentifier = "ur8hx2f",
                Control = new TreatmentInput {
                    FlagValue = new FlagValue { Enabled = false },
                    Weight = 50
                },
                EnvironmentIdentifier = "54j1r29",
                FlagKey = "my-feature-flag",
                Name = "Example-Experiment-Definition",
                Treatments = new List<TreatmentInput> {
                    new TreatmentInput {
                        FlagValue = new FlagValue { Enabled = true },
                        Weight = 50
                    }
                }
            });

            string applicationId = response.ApplicationId;
            string audienceRule = response.AudienceRule;
            string configurationProfileId = response.ConfigurationProfileId;
            Treatment control = response.Control;
            DateTime? createdAt = response.CreatedAt;
            string environmentId = response.EnvironmentId;
            string flagKey = response.FlagKey;
            string id = response.Id;
            string name = response.Name;
            ExperimentDefinitionStatus status = response.Status;
            List<Treatment> treatments = response.Treatments;
            DateTime? updatedAt = response.UpdatedAt;

            #endregion
        }

        public void AppConfigCreateHostedConfigurationVersion()
        {
            #region CreateHostedConfigurationVersion-1

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
            int? versionNumber = response.VersionNumber;

            #endregion
        }

        public void AppConfigDeleteApplication()
        {
            #region DeleteApplication-1

            var client = new AmazonAppConfigClient();
            var response = client.DeleteApplication(new DeleteApplicationRequest
            {
                ApplicationId = "339ohji"
            });


            #endregion
        }

        public void AppConfigDeleteConfigurationProfile()
        {
            #region DeleteConfigurationProfile-1

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
            #region DeleteDeploymentStrategy-1

            var client = new AmazonAppConfigClient();
            var response = client.DeleteDeploymentStrategy(new DeleteDeploymentStrategyRequest
            {
                DeploymentStrategyId = "1225qzk"
            });


            #endregion
        }

        public void AppConfigDeleteEnvironment()
        {
            #region DeleteEnvironment-1

            var client = new AmazonAppConfigClient();
            var response = client.DeleteEnvironment(new DeleteEnvironmentRequest
            {
                ApplicationId = "339ohji",
                EnvironmentId = "54j1r29"
            });


            #endregion
        }

        public void AppConfigDeleteExperimentDefinition()
        {
            #region DeleteExperimentDefinition-1

            var client = new AmazonAppConfigClient();
            var response = client.DeleteExperimentDefinition(new DeleteExperimentDefinitionRequest
            {
                ApplicationIdentifier = "339ohji",
                ExperimentDefinitionIdentifier = "bsxyd7k"
            });


            #endregion
        }

        public void AppConfigDeleteHostedConfigurationVersion()
        {
            #region DeleteHostedConfigurationVersion-1

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
            #region GetApplication-1

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
            #region GetConfiguration-1

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
            #region GetConfigurationProfile-1

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

        public void AppConfigGetDeploymentStrategy()
        {
            #region GetDeploymentStrategy-1

            var client = new AmazonAppConfigClient();
            var response = client.GetDeploymentStrategy(new GetDeploymentStrategyRequest
            {
                DeploymentStrategyId = "1225qzk"
            });

            int? deploymentDurationInMinutes = response.DeploymentDurationInMinutes;
            int? finalBakeTimeInMinutes = response.FinalBakeTimeInMinutes;
            float? growthFactor = response.GrowthFactor;
            GrowthType growthType = response.GrowthType;
            string id = response.Id;
            string name = response.Name;
            ReplicateTo replicateTo = response.ReplicateTo;

            #endregion
        }

        public void AppConfigGetEnvironment()
        {
            #region GetEnvironment-1

            var client = new AmazonAppConfigClient();
            var response = client.GetEnvironment(new GetEnvironmentRequest
            {
                ApplicationId = "339ohji",
                EnvironmentId = "54j1r29"
            });

            string applicationId = response.ApplicationId;
            string id = response.Id;
            string name = response.Name;
            EnvironmentState state = response.State;

            #endregion
        }

        public void AppConfigGetExperimentDefinition()
        {
            #region GetExperimentDefinition-1

            var client = new AmazonAppConfigClient();
            var response = client.GetExperimentDefinition(new GetExperimentDefinitionRequest
            {
                ApplicationIdentifier = "339ohji",
                ExperimentDefinitionIdentifier = "bsxyd7k"
            });

            string applicationId = response.ApplicationId;
            string audienceRule = response.AudienceRule;
            string configurationProfileId = response.ConfigurationProfileId;
            Treatment control = response.Control;
            DateTime? createdAt = response.CreatedAt;
            string environmentId = response.EnvironmentId;
            string flagKey = response.FlagKey;
            string id = response.Id;
            string name = response.Name;
            ExperimentDefinitionStatus status = response.Status;
            List<Treatment> treatments = response.Treatments;
            DateTime? updatedAt = response.UpdatedAt;

            #endregion
        }

        public void AppConfigGetExperimentRun()
        {
            #region GetExperimentRun-1

            var client = new AmazonAppConfigClient();
            var response = client.GetExperimentRun(new GetExperimentRunRequest
            {
                ApplicationIdentifier = "339ohji",
                ExperimentDefinitionIdentifier = "bsxyd7k",
                Run = 1
            });

            string applicationId = response.ApplicationId;
            string experimentDefinitionId = response.ExperimentDefinitionId;
            ExperimentDefinitionSnapshot experimentDefinitionSnapshot = response.ExperimentDefinitionSnapshot;
            float? exposurePercentage = response.ExposurePercentage;
            int? run = response.Run;
            DateTime? startedAt = response.StartedAt;
            ExperimentRunStatus status = response.Status;
            DateTime? updatedAt = response.UpdatedAt;

            #endregion
        }

        public void AppConfigGetHostedConfigurationVersion()
        {
            #region GetHostedConfigurationVersion-1

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
            int? versionNumber = response.VersionNumber;

            #endregion
        }

        public void AppConfigListApplications()
        {
            #region ListApplications-1

            var client = new AmazonAppConfigClient();
            var response = client.ListApplications(new ListApplicationsRequest
            {
            });

            List<Application> items = response.Items;

            #endregion
        }

        public void AppConfigListConfigurationProfiles()
        {
            #region ListConfigurationProfiles-1

            var client = new AmazonAppConfigClient();
            var response = client.ListConfigurationProfiles(new ListConfigurationProfilesRequest
            {
                ApplicationId = "339ohji"
            });

            List<ConfigurationProfileSummary> items = response.Items;

            #endregion
        }

        public void AppConfigListDeploymentStrategies()
        {
            #region ListDeploymentStrategies-1

            var client = new AmazonAppConfigClient();
            var response = client.ListDeploymentStrategies(new ListDeploymentStrategiesRequest
            {
            });

            List<DeploymentStrategy> items = response.Items;

            #endregion
        }

        public void AppConfigListEnvironments()
        {
            #region ListEnvironments-1

            var client = new AmazonAppConfigClient();
            var response = client.ListEnvironments(new ListEnvironmentsRequest
            {
                ApplicationId = "339ohji"
            });

            List<Environment> items = response.Items;

            #endregion
        }

        public void AppConfigListExperimentDefinitions()
        {
            #region ListExperimentDefinitions-1

            var client = new AmazonAppConfigClient();
            var response = client.ListExperimentDefinitions(new ListExperimentDefinitionsRequest
            {
                ApplicationIdentifier = "339ohji"
            });

            List<ExperimentDefinitionSummary> items = response.Items;

            #endregion
        }

        public void AppConfigListExperimentRunEvents()
        {
            #region ListExperimentRunEvents-1

            var client = new AmazonAppConfigClient();
            var response = client.ListExperimentRunEvents(new ListExperimentRunEventsRequest
            {
                ApplicationIdentifier = "339ohji",
                ExperimentDefinitionIdentifier = "bsxyd7k",
                Run = 1
            });

            List<ExperimentRunEvent> items = response.Items;

            #endregion
        }

        public void AppConfigListExperimentRuns()
        {
            #region ListExperimentRuns-1

            var client = new AmazonAppConfigClient();
            var response = client.ListExperimentRuns(new ListExperimentRunsRequest
            {
                ApplicationIdentifier = "339ohji",
                ExperimentDefinitionIdentifier = "bsxyd7k"
            });

            List<ExperimentRunSummary> items = response.Items;

            #endregion
        }

        public void AppConfigListHostedConfigurationVersions()
        {
            #region ListHostedConfigurationVersions-1

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
            #region ListTagsForResource-1

            var client = new AmazonAppConfigClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest
            {
                ResourceArn = "arn:aws:appconfig:us-east-1:111122223333:application/339ohji"
            });

            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void AppConfigStartExperimentRun()
        {
            #region StartExperimentRun-1

            var client = new AmazonAppConfigClient();
            var response = client.StartExperimentRun(new StartExperimentRunRequest
            {
                ApplicationIdentifier = "339ohji",
                ExperimentDefinitionIdentifier = "bsxyd7k",
                ExposurePercentage = 50
            });

            string applicationId = response.ApplicationId;
            string experimentDefinitionId = response.ExperimentDefinitionId;
            ExperimentDefinitionSnapshot experimentDefinitionSnapshot = response.ExperimentDefinitionSnapshot;
            float? exposurePercentage = response.ExposurePercentage;
            int? run = response.Run;
            DateTime? startedAt = response.StartedAt;
            ExperimentRunStatus status = response.Status;
            DateTime? updatedAt = response.UpdatedAt;

            #endregion
        }

        public void AppConfigStopDeployment()
        {
            #region StopDeployment-1

            var client = new AmazonAppConfigClient();
            var response = client.StopDeployment(new StopDeploymentRequest
            {
                ApplicationId = "339ohji",
                DeploymentNumber = 2,
                EnvironmentId = "54j1r29"
            });

            int? deploymentDurationInMinutes = response.DeploymentDurationInMinutes;
            int? deploymentNumber = response.DeploymentNumber;
            int? finalBakeTimeInMinutes = response.FinalBakeTimeInMinutes;
            float? growthFactor = response.GrowthFactor;
            float? percentageComplete = response.PercentageComplete;

            #endregion
        }

        public void AppConfigStopExperimentRun()
        {
            #region StopExperimentRun-1

            var client = new AmazonAppConfigClient();
            var response = client.StopExperimentRun(new StopExperimentRunRequest
            {
                ApplicationIdentifier = "339ohji",
                ExperimentDefinitionIdentifier = "bsxyd7k",
                Result = new ExperimentRunResult {
                    ExecutiveSummary = "t1 wins with 16% lift in conversion",
                    ReasonsToLaunch = "Significant improvement in key metric"
                },
                Run = 1
            });

            string applicationId = response.ApplicationId;
            DateTime? endedAt = response.EndedAt;
            string experimentDefinitionId = response.ExperimentDefinitionId;
            ExperimentDefinitionSnapshot experimentDefinitionSnapshot = response.ExperimentDefinitionSnapshot;
            float? exposurePercentage = response.ExposurePercentage;
            ExperimentRunResult result = response.Result;
            int? run = response.Run;
            DateTime? startedAt = response.StartedAt;
            ExperimentRunStatus status = response.Status;
            DateTime? updatedAt = response.UpdatedAt;

            #endregion
        }

        public void AppConfigTagResource()
        {
            #region TagResource-1

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
            #region UntagResource-1

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
            #region UpdateApplication-1

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
            #region UpdateConfigurationProfile-1

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
            #region UpdateDeploymentStrategy-1

            var client = new AmazonAppConfigClient();
            var response = client.UpdateDeploymentStrategy(new UpdateDeploymentStrategyRequest
            {
                DeploymentStrategyId = "1225qzk",
                FinalBakeTimeInMinutes = 20
            });

            int? deploymentDurationInMinutes = response.DeploymentDurationInMinutes;
            int? finalBakeTimeInMinutes = response.FinalBakeTimeInMinutes;
            float? growthFactor = response.GrowthFactor;
            GrowthType growthType = response.GrowthType;
            string id = response.Id;
            string name = response.Name;
            ReplicateTo replicateTo = response.ReplicateTo;

            #endregion
        }

        public void AppConfigUpdateEnvironment()
        {
            #region UpdateEnvironment-1

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
            EnvironmentState state = response.State;

            #endregion
        }

        public void AppConfigUpdateExperimentDefinition()
        {
            #region UpdateExperimentDefinition-1

            var client = new AmazonAppConfigClient();
            var response = client.UpdateExperimentDefinition(new UpdateExperimentDefinitionRequest
            {
                ApplicationIdentifier = "339ohji",
                AudienceRule = "(eq $country \"US\")",
                ExperimentDefinitionIdentifier = "bsxyd7k",
                Hypothesis = "Enabling the feature will increase conversion by 10%"
            });

            string applicationId = response.ApplicationId;
            string audienceRule = response.AudienceRule;
            string configurationProfileId = response.ConfigurationProfileId;
            Treatment control = response.Control;
            DateTime? createdAt = response.CreatedAt;
            string environmentId = response.EnvironmentId;
            string flagKey = response.FlagKey;
            string hypothesis = response.Hypothesis;
            string id = response.Id;
            string name = response.Name;
            ExperimentDefinitionStatus status = response.Status;
            List<Treatment> treatments = response.Treatments;
            DateTime? updatedAt = response.UpdatedAt;

            #endregion
        }

        public void AppConfigUpdateExperimentRun()
        {
            #region UpdateExperimentRun-1

            var client = new AmazonAppConfigClient();
            var response = client.UpdateExperimentRun(new UpdateExperimentRunRequest
            {
                ApplicationIdentifier = "339ohji",
                ExperimentDefinitionIdentifier = "bsxyd7k",
                ExposurePercentage = 75,
                Run = 1
            });

            string applicationId = response.ApplicationId;
            string experimentDefinitionId = response.ExperimentDefinitionId;
            ExperimentDefinitionSnapshot experimentDefinitionSnapshot = response.ExperimentDefinitionSnapshot;
            float? exposurePercentage = response.ExposurePercentage;
            int? run = response.Run;
            DateTime? startedAt = response.StartedAt;
            ExperimentRunStatus status = response.Status;
            DateTime? updatedAt = response.UpdatedAt;

            #endregion
        }

        public void AppConfigValidateConfiguration()
        {
            #region ValidateConfiguration-1

            var client = new AmazonAppConfigClient();
            var response = client.ValidateConfiguration(new ValidateConfigurationRequest
            {
                ApplicationId = "abc1234",
                ConfigurationProfileId = "ur8hx2f",
                ConfigurationVersion = "1"
            });


            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
