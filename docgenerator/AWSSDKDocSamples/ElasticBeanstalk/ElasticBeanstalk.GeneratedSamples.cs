using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.ElasticBeanstalk;
using Amazon.ElasticBeanstalk.Model;

namespace AWSSDKDocSamples.Amazon.ElasticBeanstalk.Generated
{
    class ElasticBeanstalkSamples : ISample
    {
        static IAmazonElasticBeanstalk client = new AmazonElasticBeanstalkClient();
        public void ElasticBeanstalkAbortEnvironmentUpdate()
        {
            #region to-abort-a-deployment-1456267848227

            var response = client.AbortEnvironmentUpdate(new AbortEnvironmentUpdateRequest 
            {
                EnvironmentName = "my-env"
            });


            #endregion
        }

        public void ElasticBeanstalkCheckDNSAvailability()
        {
            #region to-check-the-availability-of-a-cname-1456268589537

            var response = client.CheckDNSAvailability(new CheckDNSAvailabilityRequest 
            {
                CNAMEPrefix = "my-cname"
            });

            bool available = response.Available;
            string fullyQualifiedCNAME = response.FullyQualifiedCNAME;

            #endregion
        }

        public void ElasticBeanstalkCreateApplication()
        {
            #region to-create-a-new-application-1456268895683

            var response = client.CreateApplication(new CreateApplicationRequest 
            {
                ApplicationName = "my-app",
                Description = "my application"
            });

            ApplicationDescription application = response.Application;

            #endregion
        }

        public void ElasticBeanstalkCreateApplicationVersion()
        {
            #region to-create-a-new-application-1456268895683

            var response = client.CreateApplicationVersion(new CreateApplicationVersionRequest 
            {
                ApplicationName = "my-app",
                AutoCreateApplication = true,
                Description = "my-app-v1",
                Process = true,
                SourceBundle = new S3Location {
                    S3Bucket = "my-bucket",
                    S3Key = "sample.war"
                },
                VersionLabel = "v1"
            });

            ApplicationVersionDescription applicationVersion = response.ApplicationVersion;

            #endregion
        }

        public void ElasticBeanstalkCreateConfigurationTemplate()
        {
            #region to-create-a-configuration-template-1456269283586

            var response = client.CreateConfigurationTemplate(new CreateConfigurationTemplateRequest 
            {
                ApplicationName = "my-app",
                EnvironmentId = "e-rpqsewtp2j",
                TemplateName = "my-app-v1"
            });

            string applicationName = response.ApplicationName;
            DateTime dateCreated = response.DateCreated;
            DateTime dateUpdated = response.DateUpdated;
            string solutionStackName = response.SolutionStackName;
            string templateName = response.TemplateName;

            #endregion
        }

        public void ElasticBeanstalkCreateEnvironment()
        {
            #region to-create-a-new-environment-for-an-application-1456269380396

            var response = client.CreateEnvironment(new CreateEnvironmentRequest 
            {
                ApplicationName = "my-app",
                CNAMEPrefix = "my-app",
                EnvironmentName = "my-env",
                SolutionStackName = "64bit Amazon Linux 2015.03 v2.0.0 running Tomcat 8 Java 8",
                VersionLabel = "v1"
            });

            string applicationName = response.ApplicationName;
            string cname = response.CNAME;
            DateTime dateCreated = response.DateCreated;
            DateTime dateUpdated = response.DateUpdated;
            string environmentId = response.EnvironmentId;
            string environmentName = response.EnvironmentName;
            string health = response.Health;
            string solutionStackName = response.SolutionStackName;
            string status = response.Status;
            EnvironmentTier tier = response.Tier;
            string versionLabel = response.VersionLabel;

            #endregion
        }

        public void ElasticBeanstalkCreateStorageLocation()
        {
            #region to-create-a-new-environment-for-an-application-1456269380396

            var response = client.CreateStorageLocation(new CreateStorageLocationRequest 
            {
            });

            string s3Bucket = response.S3Bucket;

            #endregion
        }

        public void ElasticBeanstalkDeleteApplication()
        {
            #region to-delete-an-application-1456269699366

            var response = client.DeleteApplication(new DeleteApplicationRequest 
            {
                ApplicationName = "my-app"
            });


            #endregion
        }

        public void ElasticBeanstalkDeleteApplicationVersion()
        {
            #region to-delete-an-application-version-1456269792956

            var response = client.DeleteApplicationVersion(new DeleteApplicationVersionRequest 
            {
                ApplicationName = "my-app",
                DeleteSourceBundle = true,
                VersionLabel = "22a0-stage-150819_182129"
            });


            #endregion
        }

        public void ElasticBeanstalkDeleteConfigurationTemplate()
        {
            #region to-delete-a-configuration-template-1456269836701

            var response = client.DeleteConfigurationTemplate(new DeleteConfigurationTemplateRequest 
            {
                ApplicationName = "my-app",
                TemplateName = "my-template"
            });


            #endregion
        }

        public void ElasticBeanstalkDeleteEnvironmentConfiguration()
        {
            #region to-delete-a-draft-configuration-1456269886654

            var response = client.DeleteEnvironmentConfiguration(new DeleteEnvironmentConfigurationRequest 
            {
                ApplicationName = "my-app",
                EnvironmentName = "my-env"
            });


            #endregion
        }

        public void ElasticBeanstalkDescribeApplications()
        {
            #region to-view-a-list-of-applications-1456270027373

            var response = client.DescribeApplications(new DescribeApplicationsRequest 
            {
            });

            List<ApplicationDescription> applications = response.Applications;

            #endregion
        }

        public void ElasticBeanstalkDescribeApplicationVersions()
        {
            #region to-view-information-about-an-application-version-1456269947428

            var response = client.DescribeApplicationVersions(new DescribeApplicationVersionsRequest 
            {
                ApplicationName = "my-app",
                VersionLabels = new List<string> {
                    "v2"
                }
            });

            List<ApplicationVersionDescription> applicationVersions = response.ApplicationVersions;

            #endregion
        }

        public void ElasticBeanstalkDescribeConfigurationOptions()
        {
            #region to-view-configuration-options-for-an-environment-1456276763917

            var response = client.DescribeConfigurationOptions(new DescribeConfigurationOptionsRequest 
            {
                ApplicationName = "my-app",
                EnvironmentName = "my-env"
            });

            List<ConfigurationOptionDescription> options = response.Options;

            #endregion
        }

        public void ElasticBeanstalkDescribeConfigurationSettings()
        {
            #region to-view-configurations-settings-for-an-environment-1456276924537

            var response = client.DescribeConfigurationSettings(new DescribeConfigurationSettingsRequest 
            {
                ApplicationName = "my-app",
                EnvironmentName = "my-env"
            });

            List<ConfigurationSettingsDescription> configurationSettings = response.ConfigurationSettings;

            #endregion
        }

        public void ElasticBeanstalkDescribeEnvironmentHealth()
        {
            #region to-view-environment-health-1456277109510

            var response = client.DescribeEnvironmentHealth(new DescribeEnvironmentHealthRequest 
            {
                AttributeNames = new List<string> {
                    "All"
                },
                EnvironmentName = "my-env"
            });

            ApplicationMetrics applicationMetrics = response.ApplicationMetrics;
            List<string> causes = response.Causes;
            string color = response.Color;
            string environmentName = response.EnvironmentName;
            string healthStatus = response.HealthStatus;
            InstanceHealthSummary instancesHealth = response.InstancesHealth;
            DateTime refreshedAt = response.RefreshedAt;

            #endregion
        }

        public void ElasticBeanstalkDescribeEnvironmentResources()
        {
            #region to-view-information-about-the-aws-resources-in-your-environment-1456277206232

            var response = client.DescribeEnvironmentResources(new DescribeEnvironmentResourcesRequest 
            {
                EnvironmentName = "my-env"
            });

            EnvironmentResourceDescription environmentResources = response.EnvironmentResources;

            #endregion
        }

        public void ElasticBeanstalkDescribeEnvironments()
        {
            #region to-view-information-about-an-environment-1456277288662

            var response = client.DescribeEnvironments(new DescribeEnvironmentsRequest 
            {
                EnvironmentNames = new List<string> {
                    "my-env"
                }
            });

            List<EnvironmentDescription> environments = response.Environments;

            #endregion
        }

        public void ElasticBeanstalkDescribeEvents()
        {
            #region to-view-events-for-an-environment-1456277367589

            var response = client.DescribeEvents(new DescribeEventsRequest 
            {
                EnvironmentName = "my-env"
            });

            List<EventDescription> events = response.Events;

            #endregion
        }

        public void ElasticBeanstalkDescribeInstancesHealth()
        {
            #region to-view-environment-health-1456277424757

            var response = client.DescribeInstancesHealth(new DescribeInstancesHealthRequest 
            {
                AttributeNames = new List<string> {
                    "All"
                },
                EnvironmentName = "my-env"
            });

            List<SingleInstanceHealth> instanceHealthList = response.InstanceHealthList;
            DateTime refreshedAt = response.RefreshedAt;

            #endregion
        }

        public void ElasticBeanstalkListAvailableSolutionStacks()
        {
            #region to-view-solution-stacks-1456277504811

            var response = client.ListAvailableSolutionStacks(new ListAvailableSolutionStacksRequest 
            {
            });

            List<SolutionStackDescription> solutionStackDetails = response.SolutionStackDetails;
            List<string> solutionStacks = response.SolutionStacks;

            #endregion
        }

        public void ElasticBeanstalkRebuildEnvironment()
        {
            #region to-rebuild-an-environment-1456277600918

            var response = client.RebuildEnvironment(new RebuildEnvironmentRequest 
            {
                EnvironmentName = "my-env"
            });


            #endregion
        }

        public void ElasticBeanstalkRequestEnvironmentInfo()
        {
            #region to-request-tailed-logs-1456277657045

            var response = client.RequestEnvironmentInfo(new RequestEnvironmentInfoRequest 
            {
                EnvironmentName = "my-env",
                InfoType = "tail"
            });


            #endregion
        }

        public void ElasticBeanstalkRestartAppServer()
        {
            #region to-restart-application-servers-1456277739302

            var response = client.RestartAppServer(new RestartAppServerRequest 
            {
                EnvironmentName = "my-env"
            });


            #endregion
        }

        public void ElasticBeanstalkRetrieveEnvironmentInfo()
        {
            #region to-retrieve-tailed-logs-1456277792734

            var response = client.RetrieveEnvironmentInfo(new RetrieveEnvironmentInfoRequest 
            {
                EnvironmentName = "my-env",
                InfoType = "tail"
            });

            List<EnvironmentInfoDescription> environmentInfo = response.EnvironmentInfo;

            #endregion
        }

        public void ElasticBeanstalkSwapEnvironmentCNAMEs()
        {
            #region to-swap-environment-cnames-1456277839438

            var response = client.SwapEnvironmentCNAMEs(new SwapEnvironmentCNAMEsRequest 
            {
                DestinationEnvironmentName = "my-env-green",
                SourceEnvironmentName = "my-env-blue"
            });


            #endregion
        }

        public void ElasticBeanstalkTerminateEnvironment()
        {
            #region to-terminate-an-environment-1456277888556

            var response = client.TerminateEnvironment(new TerminateEnvironmentRequest 
            {
                EnvironmentName = "my-env"
            });

            bool abortableOperationInProgress = response.AbortableOperationInProgress;
            string applicationName = response.ApplicationName;
            string cname = response.CNAME;
            DateTime dateCreated = response.DateCreated;
            DateTime dateUpdated = response.DateUpdated;
            string endpointURL = response.EndpointURL;
            string environmentId = response.EnvironmentId;
            string environmentName = response.EnvironmentName;
            string health = response.Health;
            string solutionStackName = response.SolutionStackName;
            string status = response.Status;
            EnvironmentTier tier = response.Tier;

            #endregion
        }

        public void ElasticBeanstalkUpdateApplication()
        {
            #region to-change-an-applications-description-1456277957075

            var response = client.UpdateApplication(new UpdateApplicationRequest 
            {
                ApplicationName = "my-app",
                Description = "my Elastic Beanstalk application"
            });

            ApplicationDescription application = response.Application;

            #endregion
        }

        public void ElasticBeanstalkUpdateApplicationVersion()
        {
            #region to-change-an-application-versions-description-1456278019237

            var response = client.UpdateApplicationVersion(new UpdateApplicationVersionRequest 
            {
                ApplicationName = "my-app",
                Description = "new description",
                VersionLabel = "22a0-stage-150819_185942"
            });

            ApplicationVersionDescription applicationVersion = response.ApplicationVersion;

            #endregion
        }

        public void ElasticBeanstalkUpdateConfigurationTemplate()
        {
            #region to-update-a-configuration-template-1456278075300

            var response = client.UpdateConfigurationTemplate(new UpdateConfigurationTemplateRequest 
            {
                ApplicationName = "my-app",
                OptionsToRemove = new List<OptionSpecification> {
                    new OptionSpecification {
                        Namespace = "aws:elasticbeanstalk:healthreporting:system",
                        OptionName = "ConfigDocument"
                    }
                },
                TemplateName = "my-template"
            });

            string applicationName = response.ApplicationName;
            DateTime dateCreated = response.DateCreated;
            DateTime dateUpdated = response.DateUpdated;
            string solutionStackName = response.SolutionStackName;
            string templateName = response.TemplateName;

            #endregion
        }

        public void ElasticBeanstalkUpdateEnvironment()
        {
            #region to-update-an-environment-to-a-new-version-1456278210718

            var response = client.UpdateEnvironment(new UpdateEnvironmentRequest 
            {
                EnvironmentName = "my-env",
                VersionLabel = "v2"
            });

            string applicationName = response.ApplicationName;
            string cname = response.CNAME;
            DateTime dateCreated = response.DateCreated;
            DateTime dateUpdated = response.DateUpdated;
            string endpointURL = response.EndpointURL;
            string environmentId = response.EnvironmentId;
            string environmentName = response.EnvironmentName;
            string health = response.Health;
            string solutionStackName = response.SolutionStackName;
            string status = response.Status;
            EnvironmentTier tier = response.Tier;
            string versionLabel = response.VersionLabel;

            #endregion
        }

        public void ElasticBeanstalkUpdateEnvironment()
        {
            #region to-configure-option-settings-1456278286349

            var response = client.UpdateEnvironment(new UpdateEnvironmentRequest 
            {
                EnvironmentName = "my-env",
                OptionSettings = new List<ConfigurationOptionSetting> {
                    new ConfigurationOptionSetting {
                        Namespace = "aws:elb:healthcheck",
                        OptionName = "Interval",
                        Value = "15"
                    },
                    new ConfigurationOptionSetting {
                        Namespace = "aws:elb:healthcheck",
                        OptionName = "Timeout",
                        Value = "8"
                    },
                    new ConfigurationOptionSetting {
                        Namespace = "aws:elb:healthcheck",
                        OptionName = "HealthyThreshold",
                        Value = "2"
                    },
                    new ConfigurationOptionSetting {
                        Namespace = "aws:elb:healthcheck",
                        OptionName = "UnhealthyThreshold",
                        Value = "3"
                    }
                }
            });

            bool abortableOperationInProgress = response.AbortableOperationInProgress;
            string applicationName = response.ApplicationName;
            string cname = response.CNAME;
            DateTime dateCreated = response.DateCreated;
            DateTime dateUpdated = response.DateUpdated;
            string endpointURL = response.EndpointURL;
            string environmentId = response.EnvironmentId;
            string environmentName = response.EnvironmentName;
            string health = response.Health;
            string solutionStackName = response.SolutionStackName;
            string status = response.Status;
            EnvironmentTier tier = response.Tier;
            string versionLabel = response.VersionLabel;

            #endregion
        }

        public void ElasticBeanstalkValidateConfigurationSettings()
        {
            #region to-validate-configuration-settings-1456278393654

            var response = client.ValidateConfigurationSettings(new ValidateConfigurationSettingsRequest 
            {
                ApplicationName = "my-app",
                EnvironmentName = "my-env",
                OptionSettings = new List<ConfigurationOptionSetting> {
                    new ConfigurationOptionSetting {
                        Namespace = "aws:elasticbeanstalk:healthreporting:system",
                        OptionName = "ConfigDocument",
                        Value = "{\"CloudWatchMetrics\": {\"Environment\": {\"ApplicationLatencyP99.9\": null,\"InstancesSevere\": 60,\"ApplicationLatencyP90\": 60,\"ApplicationLatencyP99\": null,\"ApplicationLatencyP95\": 60,\"InstancesUnknown\": 60,\"ApplicationLatencyP85\": 60,\"InstancesInfo\": null,\"ApplicationRequests2xx\": null,\"InstancesDegraded\": null,\"InstancesWarning\": 60,\"ApplicationLatencyP50\": 60,\"ApplicationRequestsTotal\": null,\"InstancesNoData\": null,\"InstancesPending\": 60,\"ApplicationLatencyP10\": null,\"ApplicationRequests5xx\": null,\"ApplicationLatencyP75\": null,\"InstancesOk\": 60,\"ApplicationRequests3xx\": null,\"ApplicationRequests4xx\": null},\"Instance\": {\"ApplicationLatencyP99.9\": null,\"ApplicationLatencyP90\": 60,\"ApplicationLatencyP99\": null,\"ApplicationLatencyP95\": null,\"ApplicationLatencyP85\": null,\"CPUUser\": 60,\"ApplicationRequests2xx\": null,\"CPUIdle\": null,\"ApplicationLatencyP50\": null,\"ApplicationRequestsTotal\": 60,\"RootFilesystemUtil\": null,\"LoadAverage1min\": null,\"CPUIrq\": null,\"CPUNice\": 60,\"CPUIowait\": 60,\"ApplicationLatencyP10\": null,\"LoadAverage5min\": null,\"ApplicationRequests5xx\": null,\"ApplicationLatencyP75\": 60,\"CPUSystem\": 60,\"ApplicationRequests3xx\": 60,\"ApplicationRequests4xx\": null,\"InstanceHealth\": null,\"CPUSoftirq\": 60}},\"Version\": 1}"
                    }
                }
            });

            List<ValidationMessage> messages = response.Messages;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}