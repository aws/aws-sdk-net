using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.ElasticBeanstalk;
using Amazon.ElasticBeanstalk.Model;

namespace AWSSDKDocSamples.Amazon.ElasticBeanstalk.Generated
{
    class ElasticBeanstalkSamples : ISample
    {
        public void ElasticBeanstalkAbortEnvironmentUpdate()
        {
            #region AbortEnvironmentUpdate-1

            var client = new AmazonElasticBeanstalkClient();
            var response = client.AbortEnvironmentUpdate(new AbortEnvironmentUpdateRequest
            {
                EnvironmentName = "my-env"
            });


            #endregion
        }

        public void ElasticBeanstalkCheckDNSAvailability()
        {
            #region CheckDNSAvailability-1

            var client = new AmazonElasticBeanstalkClient();
            var response = client.CheckDNSAvailability(new CheckDNSAvailabilityRequest
            {
                CNAMEPrefix = "my-cname"
            });

            bool? available = response.Available;
            string fullyQualifiedCNAME = response.FullyQualifiedCNAME;

            #endregion
        }

        public void ElasticBeanstalkCreateApplication()
        {
            #region CreateApplication-1

            var client = new AmazonElasticBeanstalkClient();
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
            #region CreateApplicationVersion-1

            var client = new AmazonElasticBeanstalkClient();
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
            #region CreateConfigurationTemplate-1

            var client = new AmazonElasticBeanstalkClient();
            var response = client.CreateConfigurationTemplate(new CreateConfigurationTemplateRequest
            {
                ApplicationName = "my-app",
                EnvironmentId = "e-rpqsewtp2j",
                TemplateName = "my-app-v1"
            });

            string applicationName = response.ApplicationName;
            DateTime? dateCreated = response.DateCreated;
            DateTime? dateUpdated = response.DateUpdated;
            string solutionStackName = response.SolutionStackName;
            string templateName = response.TemplateName;

            #endregion
        }

        public void ElasticBeanstalkCreateEnvironment()
        {
            #region CreateEnvironment-1

            var client = new AmazonElasticBeanstalkClient();
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
            DateTime? dateCreated = response.DateCreated;
            DateTime? dateUpdated = response.DateUpdated;
            string environmentId = response.EnvironmentId;
            string environmentName = response.EnvironmentName;
            EnvironmentHealth health = response.Health;
            string solutionStackName = response.SolutionStackName;
            EnvironmentStatus status = response.Status;
            EnvironmentTier tier = response.Tier;
            string versionLabel = response.VersionLabel;

            #endregion
        }

        public void ElasticBeanstalkCreateStorageLocation()
        {
            #region CreateStorageLocation-1

            var client = new AmazonElasticBeanstalkClient();
            var response = client.CreateStorageLocation(new CreateStorageLocationRequest
            {
            });

            string s3Bucket = response.S3Bucket;

            #endregion
        }

        public void ElasticBeanstalkDeleteApplication()
        {
            #region DeleteApplication-1

            var client = new AmazonElasticBeanstalkClient();
            var response = client.DeleteApplication(new DeleteApplicationRequest
            {
                ApplicationName = "my-app"
            });


            #endregion
        }

        public void ElasticBeanstalkDeleteApplicationVersion()
        {
            #region DeleteApplicationVersion-1

            var client = new AmazonElasticBeanstalkClient();
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
            #region DeleteConfigurationTemplate-1

            var client = new AmazonElasticBeanstalkClient();
            var response = client.DeleteConfigurationTemplate(new DeleteConfigurationTemplateRequest
            {
                ApplicationName = "my-app",
                TemplateName = "my-template"
            });


            #endregion
        }

        public void ElasticBeanstalkDeleteEnvironmentConfiguration()
        {
            #region DeleteEnvironmentConfiguration-1

            var client = new AmazonElasticBeanstalkClient();
            var response = client.DeleteEnvironmentConfiguration(new DeleteEnvironmentConfigurationRequest
            {
                ApplicationName = "my-app",
                EnvironmentName = "my-env"
            });


            #endregion
        }

        public void ElasticBeanstalkDescribeApplications()
        {
            #region DescribeApplications-1

            var client = new AmazonElasticBeanstalkClient();
            var response = client.DescribeApplications(new DescribeApplicationsRequest
            {
            });

            List<ApplicationDescription> applications = response.Applications;

            #endregion
        }

        public void ElasticBeanstalkDescribeApplicationVersions()
        {
            #region DescribeApplicationVersions-1

            var client = new AmazonElasticBeanstalkClient();
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
            #region DescribeConfigurationOptions-1

            var client = new AmazonElasticBeanstalkClient();
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
            #region DescribeConfigurationSettings-1

            var client = new AmazonElasticBeanstalkClient();
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
            #region DescribeEnvironmentHealth-1

            var client = new AmazonElasticBeanstalkClient();
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
            DateTime? refreshedAt = response.RefreshedAt;

            #endregion
        }

        public void ElasticBeanstalkDescribeEnvironmentResources()
        {
            #region DescribeEnvironmentResources-1

            var client = new AmazonElasticBeanstalkClient();
            var response = client.DescribeEnvironmentResources(new DescribeEnvironmentResourcesRequest
            {
                EnvironmentName = "my-env"
            });

            EnvironmentResourceDescription environmentResources = response.EnvironmentResources;

            #endregion
        }

        public void ElasticBeanstalkDescribeEnvironments()
        {
            #region DescribeEnvironments-1

            var client = new AmazonElasticBeanstalkClient();
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
            #region DescribeEvents-1

            var client = new AmazonElasticBeanstalkClient();
            var response = client.DescribeEvents(new DescribeEventsRequest
            {
                EnvironmentName = "my-env"
            });

            List<EventDescription> events = response.Events;

            #endregion
        }

        public void ElasticBeanstalkDescribeInstancesHealth()
        {
            #region DescribeInstancesHealth-1

            var client = new AmazonElasticBeanstalkClient();
            var response = client.DescribeInstancesHealth(new DescribeInstancesHealthRequest
            {
                AttributeNames = new List<string> {
                    "All"
                },
                EnvironmentName = "my-env"
            });

            List<SingleInstanceHealth> instanceHealthList = response.InstanceHealthList;
            DateTime? refreshedAt = response.RefreshedAt;

            #endregion
        }

        public void ElasticBeanstalkListAvailableSolutionStacks()
        {
            #region ListAvailableSolutionStacks-1

            var client = new AmazonElasticBeanstalkClient();
            var response = client.ListAvailableSolutionStacks(new ListAvailableSolutionStacksRequest
            {
            });

            List<SolutionStackDescription> solutionStackDetails = response.SolutionStackDetails;
            List<string> solutionStacks = response.SolutionStacks;

            #endregion
        }

        public void ElasticBeanstalkRebuildEnvironment()
        {
            #region RebuildEnvironment-1

            var client = new AmazonElasticBeanstalkClient();
            var response = client.RebuildEnvironment(new RebuildEnvironmentRequest
            {
                EnvironmentName = "my-env"
            });


            #endregion
        }

        public void ElasticBeanstalkRequestEnvironmentInfo()
        {
            #region RequestEnvironmentInfo-1

            var client = new AmazonElasticBeanstalkClient();
            var response = client.RequestEnvironmentInfo(new RequestEnvironmentInfoRequest
            {
                EnvironmentName = "my-env",
                InfoType = "tail"
            });


            #endregion
        }

        public void ElasticBeanstalkRestartAppServer()
        {
            #region RestartAppServer-1

            var client = new AmazonElasticBeanstalkClient();
            var response = client.RestartAppServer(new RestartAppServerRequest
            {
                EnvironmentName = "my-env"
            });


            #endregion
        }

        public void ElasticBeanstalkRetrieveEnvironmentInfo()
        {
            #region RetrieveEnvironmentInfo-1

            var client = new AmazonElasticBeanstalkClient();
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
            #region SwapEnvironmentCNAMEs-1

            var client = new AmazonElasticBeanstalkClient();
            var response = client.SwapEnvironmentCNAMEs(new SwapEnvironmentCNAMEsRequest
            {
                DestinationEnvironmentName = "my-env-green",
                SourceEnvironmentName = "my-env-blue"
            });


            #endregion
        }

        public void ElasticBeanstalkTerminateEnvironment()
        {
            #region TerminateEnvironment-1

            var client = new AmazonElasticBeanstalkClient();
            var response = client.TerminateEnvironment(new TerminateEnvironmentRequest
            {
                EnvironmentName = "my-env"
            });

            bool? abortableOperationInProgress = response.AbortableOperationInProgress;
            string applicationName = response.ApplicationName;
            string cname = response.CNAME;
            DateTime? dateCreated = response.DateCreated;
            DateTime? dateUpdated = response.DateUpdated;
            string endpointURL = response.EndpointURL;
            string environmentId = response.EnvironmentId;
            string environmentName = response.EnvironmentName;
            EnvironmentHealth health = response.Health;
            string solutionStackName = response.SolutionStackName;
            EnvironmentStatus status = response.Status;
            EnvironmentTier tier = response.Tier;

            #endregion
        }

        public void ElasticBeanstalkUpdateApplication()
        {
            #region UpdateApplication-1

            var client = new AmazonElasticBeanstalkClient();
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
            #region UpdateApplicationVersion-1

            var client = new AmazonElasticBeanstalkClient();
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
            #region UpdateConfigurationTemplate-1

            var client = new AmazonElasticBeanstalkClient();
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
            DateTime? dateCreated = response.DateCreated;
            DateTime? dateUpdated = response.DateUpdated;
            string solutionStackName = response.SolutionStackName;
            string templateName = response.TemplateName;

            #endregion
        }

        public void ElasticBeanstalkUpdateEnvironment()
        {
            #region UpdateEnvironment-1

            var client = new AmazonElasticBeanstalkClient();
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

            bool? abortableOperationInProgress = response.AbortableOperationInProgress;
            string applicationName = response.ApplicationName;
            string cname = response.CNAME;
            DateTime? dateCreated = response.DateCreated;
            DateTime? dateUpdated = response.DateUpdated;
            string endpointURL = response.EndpointURL;
            string environmentId = response.EnvironmentId;
            string environmentName = response.EnvironmentName;
            EnvironmentHealth health = response.Health;
            string solutionStackName = response.SolutionStackName;
            EnvironmentStatus status = response.Status;
            EnvironmentTier tier = response.Tier;
            string versionLabel = response.VersionLabel;

            #endregion
        }

        public void ElasticBeanstalkUpdateEnvironment()
        {
            #region UpdateEnvironment-2

            var client = new AmazonElasticBeanstalkClient();
            var response = client.UpdateEnvironment(new UpdateEnvironmentRequest
            {
                EnvironmentName = "my-env",
                VersionLabel = "v2"
            });

            string applicationName = response.ApplicationName;
            string cname = response.CNAME;
            DateTime? dateCreated = response.DateCreated;
            DateTime? dateUpdated = response.DateUpdated;
            string endpointURL = response.EndpointURL;
            string environmentId = response.EnvironmentId;
            string environmentName = response.EnvironmentName;
            EnvironmentHealth health = response.Health;
            string solutionStackName = response.SolutionStackName;
            EnvironmentStatus status = response.Status;
            EnvironmentTier tier = response.Tier;
            string versionLabel = response.VersionLabel;

            #endregion
        }

        public void ElasticBeanstalkValidateConfigurationSettings()
        {
            #region ValidateConfigurationSettings-1

            var client = new AmazonElasticBeanstalkClient();
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

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
