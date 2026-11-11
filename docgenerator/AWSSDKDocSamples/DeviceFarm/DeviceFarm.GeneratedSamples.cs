using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.DeviceFarm;
using Amazon.DeviceFarm.Model;

namespace AWSSDKDocSamples.Amazon.DeviceFarm.Generated
{
    class DeviceFarmSamples : ISample
    {
        public void DeviceFarmCreateDevicePool()
        {
            #region CreateDevicePool-1

            var client = new AmazonDeviceFarmClient();
            var response = client.CreateDevicePool(new CreateDevicePoolRequest
            {
                Description = "My Android devices",
                Name = "MyDevicePool",
                ProjectArn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456",
                Rules = new List<Rule> {
                }
            });

            DevicePool devicePool = response.DevicePool;

            #endregion
        }

        public void DeviceFarmCreateRemoteAccessSession()
        {
            #region CreateRemoteAccessSession-1

            var client = new AmazonDeviceFarmClient();
            var response = client.CreateRemoteAccessSession(new CreateRemoteAccessSessionRequest
            {
                Configuration = new CreateRemoteAccessSessionConfiguration { BillingMethod = "METERED" },
                DeviceArn = "arn:aws:devicefarm:us-west-2::device:123EXAMPLE",
                Name = "MySession",
                ProjectArn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456"
            });

            RemoteAccessSession remoteAccessSession = response.RemoteAccessSession;

            #endregion
        }

        public void DeviceFarmDeleteDevicePool()
        {
            #region DeleteDevicePool-1

            var client = new AmazonDeviceFarmClient();
            var response = client.DeleteDevicePool(new DeleteDevicePoolRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2::devicepool:123-456-EXAMPLE-GUID"
            });


            #endregion
        }

        public void DeviceFarmDeleteProject()
        {
            #region DeleteProject-1

            var client = new AmazonDeviceFarmClient();
            var response = client.DeleteProject(new DeleteProjectRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456"
            });


            #endregion
        }

        public void DeviceFarmDeleteRemoteAccessSession()
        {
            #region DeleteRemoteAccessSession-1

            var client = new AmazonDeviceFarmClient();
            var response = client.DeleteRemoteAccessSession(new DeleteRemoteAccessSessionRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:session:EXAMPLE-GUID-123-456"
            });


            #endregion
        }

        public void DeviceFarmDeleteRun()
        {
            #region DeleteRun-1

            var client = new AmazonDeviceFarmClient();
            var response = client.DeleteRun(new DeleteRunRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:run:EXAMPLE-GUID-123-456"
            });


            #endregion
        }

        public void DeviceFarmDeleteUpload()
        {
            #region DeleteUpload-1

            var client = new AmazonDeviceFarmClient();
            var response = client.DeleteUpload(new DeleteUploadRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:upload:EXAMPLE-GUID-123-456"
            });


            #endregion
        }

        public void DeviceFarmGetAccountSettings()
        {
            #region GetAccountSettings-1

            var client = new AmazonDeviceFarmClient();
            var response = client.GetAccountSettings(new GetAccountSettingsRequest
            {
            });

            AccountSettings accountSettings = response.AccountSettings;

            #endregion
        }

        public void DeviceFarmGetDevice()
        {
            #region GetDevice-1

            var client = new AmazonDeviceFarmClient();
            var response = client.GetDevice(new GetDeviceRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2::device:123EXAMPLE"
            });

            Device device = response.Device;

            #endregion
        }

        public void DeviceFarmGetDevicePool()
        {
            #region GetDevicePool-1

            var client = new AmazonDeviceFarmClient();
            var response = client.GetDevicePool(new GetDevicePoolRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456"
            });

            DevicePool devicePool = response.DevicePool;

            #endregion
        }

        public void DeviceFarmGetDevicePoolCompatibility()
        {
            #region GetDevicePoolCompatibility-1

            var client = new AmazonDeviceFarmClient();
            var response = client.GetDevicePoolCompatibility(new GetDevicePoolCompatibilityRequest
            {
                AppArn = "arn:aws:devicefarm:us-west-2::app:123-456-EXAMPLE-GUID",
                DevicePoolArn = "arn:aws:devicefarm:us-west-2::devicepool:123-456-EXAMPLE-GUID",
                TestType = "APPIUM_PYTHON"
            });

            List<DevicePoolCompatibilityResult> compatibleDevices = response.CompatibleDevices;
            List<DevicePoolCompatibilityResult> incompatibleDevices = response.IncompatibleDevices;

            #endregion
        }

        public void DeviceFarmGetJob()
        {
            #region GetJob-1

            var client = new AmazonDeviceFarmClient();
            var response = client.GetJob(new GetJobRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2::job:123-456-EXAMPLE-GUID"
            });

            Job job = response.Job;

            #endregion
        }

        public void DeviceFarmGetRemoteAccessSession()
        {
            #region GetRemoteAccessSession-1

            var client = new AmazonDeviceFarmClient();
            var response = client.GetRemoteAccessSession(new GetRemoteAccessSessionRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:session:EXAMPLE-GUID-123-456"
            });

            RemoteAccessSession remoteAccessSession = response.RemoteAccessSession;

            #endregion
        }

        public void DeviceFarmGetSuite()
        {
            #region GetSuite-1

            var client = new AmazonDeviceFarmClient();
            var response = client.GetSuite(new GetSuiteRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:suite:EXAMPLE-GUID-123-456"
            });

            Suite suite = response.Suite;

            #endregion
        }

        public void DeviceFarmGetTest()
        {
            #region GetTest-1

            var client = new AmazonDeviceFarmClient();
            var response = client.GetTest(new GetTestRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:test:EXAMPLE-GUID-123-456"
            });

            Test test = response.Test;

            #endregion
        }

        public void DeviceFarmGetUpload()
        {
            #region GetUpload-1

            var client = new AmazonDeviceFarmClient();
            var response = client.GetUpload(new GetUploadRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:upload:EXAMPLE-GUID-123-456"
            });

            Upload upload = response.Upload;

            #endregion
        }

        public void DeviceFarmInstallToRemoteAccessSession()
        {
            #region InstallToRemoteAccessSession-1

            var client = new AmazonDeviceFarmClient();
            var response = client.InstallToRemoteAccessSession(new InstallToRemoteAccessSessionRequest
            {
                AppArn = "arn:aws:devicefarm:us-west-2:123456789101:app:EXAMPLE-GUID-123-456",
                RemoteAccessSessionArn = "arn:aws:devicefarm:us-west-2:123456789101:session:EXAMPLE-GUID-123-456"
            });

            Upload appUpload = response.AppUpload;

            #endregion
        }

        public void DeviceFarmListArtifacts()
        {
            #region ListArtifacts-1

            var client = new AmazonDeviceFarmClient();
            var response = client.ListArtifacts(new ListArtifactsRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:run:EXAMPLE-GUID-123-456",
                Type = "SCREENSHOT"
            });


            #endregion
        }

        public void DeviceFarmListDevicePools()
        {
            #region ListDevicePools-1

            var client = new AmazonDeviceFarmClient();
            var response = client.ListDevicePools(new ListDevicePoolsRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456",
                Type = "PRIVATE"
            });

            List<DevicePool> devicePools = response.DevicePools;

            #endregion
        }

        public void DeviceFarmListDevices()
        {
            #region ListDevices-1

            var client = new AmazonDeviceFarmClient();
            var response = client.ListDevices(new ListDevicesRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456"
            });


            #endregion
        }

        public void DeviceFarmListJobs()
        {
            #region ListJobs-1

            var client = new AmazonDeviceFarmClient();
            var response = client.ListJobs(new ListJobsRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456"
            });


            #endregion
        }

        public void DeviceFarmListOfferings()
        {
            #region ListOfferings-1

            var client = new AmazonDeviceFarmClient();
            var response = client.ListOfferings(new ListOfferingsRequest
            {
                NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE="
            });

            List<Offering> offerings = response.Offerings;

            #endregion
        }

        public void DeviceFarmListRemoteAccessSessions()
        {
            #region ListRemoteAccessSessions-1

            var client = new AmazonDeviceFarmClient();
            var response = client.ListRemoteAccessSessions(new ListRemoteAccessSessionsRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:session:EXAMPLE-GUID-123-456",
                NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE="
            });

            List<RemoteAccessSession> remoteAccessSessions = response.RemoteAccessSessions;

            #endregion
        }

        public void DeviceFarmListSamples()
        {
            #region ListSamples-1

            var client = new AmazonDeviceFarmClient();
            var response = client.ListSamples(new ListSamplesRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456",
                NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE"
            });

            List<Sample> samples = response.Samples;

            #endregion
        }

        public void DeviceFarmListSuites()
        {
            #region ListSuites-1

            var client = new AmazonDeviceFarmClient();
            var response = client.ListSuites(new ListSuitesRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:job:EXAMPLE-GUID-123-456",
                NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE"
            });

            List<Suite> suites = response.Suites;

            #endregion
        }

        public void DeviceFarmListTests()
        {
            #region ListTests-1

            var client = new AmazonDeviceFarmClient();
            var response = client.ListTests(new ListTestsRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456",
                NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE"
            });

            List<Test> tests = response.Tests;

            #endregion
        }

        public void DeviceFarmListUniqueProblems()
        {
            #region ListUniqueProblems-1

            var client = new AmazonDeviceFarmClient();
            var response = client.ListUniqueProblems(new ListUniqueProblemsRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456",
                NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE"
            });

            Dictionary<string, List<UniqueProblem>> uniqueProblems = response.UniqueProblems;

            #endregion
        }

        public void DeviceFarmListUploads()
        {
            #region ListUploads-1

            var client = new AmazonDeviceFarmClient();
            var response = client.ListUploads(new ListUploadsRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456",
                NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE"
            });

            List<Upload> uploads = response.Uploads;

            #endregion
        }

        public void DeviceFarmScheduleRun()
        {
            #region ScheduleRun-1

            var client = new AmazonDeviceFarmClient();
            var response = client.ScheduleRun(new ScheduleRunRequest
            {
                DevicePoolArn = "arn:aws:devicefarm:us-west-2:123456789101:pool:EXAMPLE-GUID-123-456",
                Name = "MyRun",
                ProjectArn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456",
                Test = new ScheduleRunTest {
                    TestPackageArn = "arn:aws:devicefarm:us-west-2:123456789101:test:EXAMPLE-GUID-123-456",
                    Type = "APPIUM_JAVA_JUNIT"
                }
            });

            Run run = response.Run;

            #endregion
        }

        public void DeviceFarmStopRun()
        {
            #region StopRun-1

            var client = new AmazonDeviceFarmClient();
            var response = client.StopRun(new StopRunRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:run:EXAMPLE-GUID-123-456"
            });

            Run run = response.Run;

            #endregion
        }

        public void DeviceFarmUpdateDevicePool()
        {
            #region UpdateDevicePool-1

            var client = new AmazonDeviceFarmClient();
            var response = client.UpdateDevicePool(new UpdateDevicePoolRequest
            {
                Arn = "arn:aws:devicefarm:us-west-2::devicepool:082d10e5-d7d7-48a5-ba5c-12345EXAMPLE",
                Description = "NewDescription",
                Name = "NewName",
                Rules = new List<Rule> {
                    new Rule {
                        Attribute = "REMOTE_ACCESS_ENABLED",
                        Operator = "EQUALS",
                        Value = "True"
                    }
                }
            });

            DevicePool devicePool = response.DevicePool;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
