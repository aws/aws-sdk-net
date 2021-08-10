using System;
using System.Collections.Generic;
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
            #region createdevicepool-example-1470862210860

            var client = new AmazonDeviceFarmClient();
            var response = client.CreateDevicePool(new CreateDevicePoolRequest 
            {
                Name = "MyDevicePool", // A device pool contains related devices, such as devices that run only on Android or that run only on iOS.
                Description = "My Android devices",
                ProjectArn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456", // You can get the project ARN by using the list-projects CLI command.
                Rules = new List<Rule> {
                    
                }
            });

            DevicePool devicePool = response.DevicePool;

            #endregion
        }

        public void DeviceFarmCreateProject()
        {
            #region createproject-example-1470862210860

            var client = new AmazonDeviceFarmClient();
            var response = client.CreateProject(new CreateProjectRequest 
            {
                Name = "MyProject" // A project in Device Farm is a workspace that contains test runs. A run is a test of a single app against one or more devices.
            });

            Project project = response.Project;

            #endregion
        }

        public void DeviceFarmCreateRemoteAccessSession()
        {
            #region to-create-a-remote-access-session-1470970668274

            var client = new AmazonDeviceFarmClient();
            var response = client.CreateRemoteAccessSession(new CreateRemoteAccessSessionRequest 
            {
                Name = "MySession",
                Configuration = new CreateRemoteAccessSessionConfiguration { BillingMethod = "METERED" },
                DeviceArn = "arn:aws:devicefarm:us-west-2::device:123EXAMPLE", // You can get the device ARN by using the list-devices CLI command.
                ProjectArn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456" // You can get the project ARN by using the list-projects CLI command.
            });

            RemoteAccessSession remoteAccessSession = response.RemoteAccessSession;

            #endregion
        }

        public void DeviceFarmCreateUpload()
        {
            #region createupload-example-1470864711775

            var client = new AmazonDeviceFarmClient();
            var response = client.CreateUpload(new CreateUploadRequest 
            {
                Name = "MyAppiumPythonUpload",
                Type = "APPIUM_PYTHON_TEST_PACKAGE",
                ProjectArn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456" // You can get the project ARN by using the list-projects CLI command.
            });

            Upload upload = response.Upload;

            #endregion
        }

        public void DeviceFarmDeleteDevicePool()
        {
            #region deletedevicepool-example-1470866975494

            var client = new AmazonDeviceFarmClient();
            var response = client.DeleteDevicePool(new DeleteDevicePoolRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2::devicepool:123-456-EXAMPLE-GUID" // You can get the device pool ARN by using the list-device-pools CLI command.
            });


            #endregion
        }

        public void DeviceFarmDeleteProject()
        {
            #region deleteproject-example-1470867374212

            var client = new AmazonDeviceFarmClient();
            var response = client.DeleteProject(new DeleteProjectRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456" // You can get the project ARN by using the list-projects CLI command.
            });


            #endregion
        }

        public void DeviceFarmDeleteRemoteAccessSession()
        {
            #region to-delete-a-specific-remote-access-session-1470971431677

            var client = new AmazonDeviceFarmClient();
            var response = client.DeleteRemoteAccessSession(new DeleteRemoteAccessSessionRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:session:EXAMPLE-GUID-123-456" // You can get the remote access session ARN by using the list-remote-access-sessions CLI command.
            });


            #endregion
        }

        public void DeviceFarmDeleteRun()
        {
            #region deleterun-example-1470867905129

            var client = new AmazonDeviceFarmClient();
            var response = client.DeleteRun(new DeleteRunRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:run:EXAMPLE-GUID-123-456" // You can get the run ARN by using the list-runs CLI command.
            });


            #endregion
        }

        public void DeviceFarmDeleteUpload()
        {
            #region deleteupload-example-1470868363942

            var client = new AmazonDeviceFarmClient();
            var response = client.DeleteUpload(new DeleteUploadRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:upload:EXAMPLE-GUID-123-456" // You can get the upload ARN by using the list-uploads CLI command.
            });


            #endregion
        }

        public void DeviceFarmGetAccountSettings()
        {
            #region to-get-information-about-account-settings-1472567568189

            var client = new AmazonDeviceFarmClient();
            var response = client.GetAccountSettings(new GetAccountSettingsRequest 
            {
            });

            AccountSettings accountSettings = response.AccountSettings;

            #endregion
        }

        public void DeviceFarmGetDevice()
        {
            #region getdevice-example-1470870602173

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
            #region getdevicepool-example-1470870873136

            var client = new AmazonDeviceFarmClient();
            var response = client.GetDevicePool(new GetDevicePoolRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456" // You can obtain the project ARN by using the list-projects CLI command.
            });

            DevicePool devicePool = response.DevicePool;

            #endregion
        }

        public void DeviceFarmGetDevicePoolCompatibility()
        {
            #region getdevicepoolcompatibility-example-1470925003466

            var client = new AmazonDeviceFarmClient();
            var response = client.GetDevicePoolCompatibility(new GetDevicePoolCompatibilityRequest 
            {
                AppArn = "arn:aws:devicefarm:us-west-2::app:123-456-EXAMPLE-GUID",
                DevicePoolArn = "arn:aws:devicefarm:us-west-2::devicepool:123-456-EXAMPLE-GUID", // You can get the device pool ARN by using the list-device-pools CLI command.
                TestType = "APPIUM_PYTHON"
            });

            List<DevicePoolCompatibilityResult> compatibleDevices = response.CompatibleDevices;
            List<DevicePoolCompatibilityResult> incompatibleDevices = response.IncompatibleDevices;

            #endregion
        }

        public void DeviceFarmGetJob()
        {
            #region getjob-example-1470928294268

            var client = new AmazonDeviceFarmClient();
            var response = client.GetJob(new GetJobRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2::job:123-456-EXAMPLE-GUID" // You can get the job ARN by using the list-jobs CLI command.
            });

            Job job = response.Job;

            #endregion
        }

        public void DeviceFarmGetOfferingStatus()
        {
            #region to-get-status-information-about-device-offerings-1472568124402

            var client = new AmazonDeviceFarmClient();
            var response = client.GetOfferingStatus(new GetOfferingStatusRequest 
            {
                NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE=" // A dynamically generated value, used for paginating results.
            });

            Dictionary<string, OfferingStatus> current = response.Current;
            Dictionary<string, OfferingStatus> nextPeriod = response.NextPeriod;

            #endregion
        }

        public void DeviceFarmGetProject()
        {
            #region to-get-a-project-1470975038449

            var client = new AmazonDeviceFarmClient();
            var response = client.GetProject(new GetProjectRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:5e01a8c7-c861-4c0a-b1d5-12345EXAMPLE" // You can get the project ARN by using the list-projects CLI command.
            });

            Project project = response.Project;

            #endregion
        }

        public void DeviceFarmGetRemoteAccessSession()
        {
            #region to-get-a-remote-access-session-1471014119414

            var client = new AmazonDeviceFarmClient();
            var response = client.GetRemoteAccessSession(new GetRemoteAccessSessionRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:session:EXAMPLE-GUID-123-456" // You can get the remote access session ARN by using the list-remote-access-sessions CLI command.
            });

            RemoteAccessSession remoteAccessSession = response.RemoteAccessSession;

            #endregion
        }

        public void DeviceFarmGetRun()
        {
            #region to-get-a-test-run-1471015895657

            var client = new AmazonDeviceFarmClient();
            var response = client.GetRun(new GetRunRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:run:5e01a8c7-c861-4c0a-b1d5-5ec6e6c6dd23/0fcac17b-6122-44d7-ae5a-12345EXAMPLE" // You can get the run ARN by using the list-runs CLI command.
            });

            Run run = response.Run;

            #endregion
        }

        public void DeviceFarmGetSuite()
        {
            #region to-get-information-about-a-test-suite-1471016525008

            var client = new AmazonDeviceFarmClient();
            var response = client.GetSuite(new GetSuiteRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:suite:EXAMPLE-GUID-123-456" // You can get the suite ARN by using the list-suites CLI command.
            });

            Suite suite = response.Suite;

            #endregion
        }

        public void DeviceFarmGetTest()
        {
            #region to-get-information-about-a-specific-test-1471025744238

            var client = new AmazonDeviceFarmClient();
            var response = client.GetTest(new GetTestRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:test:EXAMPLE-GUID-123-456" // You can get the test ARN by using the list-tests CLI command.
            });

            Test test = response.Test;

            #endregion
        }

        public void DeviceFarmGetUpload()
        {
            #region to-get-information-about-a-specific-upload-1471025996221

            var client = new AmazonDeviceFarmClient();
            var response = client.GetUpload(new GetUploadRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:upload:EXAMPLE-GUID-123-456" // You can get the test ARN by using the list-uploads CLI command.
            });

            Upload upload = response.Upload;

            #endregion
        }

        public void DeviceFarmInstallToRemoteAccessSession()
        {
            #region to-install-to-a-remote-access-session-1471634453818

            var client = new AmazonDeviceFarmClient();
            var response = client.InstallToRemoteAccessSession(new InstallToRemoteAccessSessionRequest 
            {
                AppArn = "arn:aws:devicefarm:us-west-2:123456789101:app:EXAMPLE-GUID-123-456",
                RemoteAccessSessionArn = "arn:aws:devicefarm:us-west-2:123456789101:session:EXAMPLE-GUID-123-456" // You can get the remote access session ARN by using the list-remote-access-sessions CLI command.
            });

            Upload appUpload = response.AppUpload;

            #endregion
        }

        public void DeviceFarmListArtifacts()
        {
            #region to-list-artifacts-for-a-resource-1471635409527

            var client = new AmazonDeviceFarmClient();
            var response = client.ListArtifacts(new ListArtifactsRequest 
            {
                Type = "SCREENSHOT",
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:run:EXAMPLE-GUID-123-456" // Can also be used to list artifacts for a Job, Suite, or Test ARN.
            });


            #endregion
        }

        public void DeviceFarmListDevicePools()
        {
            #region to-get-information-about-device-pools-1471635745170

            var client = new AmazonDeviceFarmClient();
            var response = client.ListDevicePools(new ListDevicePoolsRequest 
            {
                Type = "PRIVATE",
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456" // You can get the project ARN by using the list-projects CLI command.
            });

            List<DevicePool> devicePools = response.DevicePools;

            #endregion
        }

        public void DeviceFarmListDevices()
        {
            #region to-get-information-about-devices-1471641699344

            var client = new AmazonDeviceFarmClient();
            var response = client.ListDevices(new ListDevicesRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456" // You can get the project ARN by using the list-projects CLI command.
            });


            #endregion
        }

        public void DeviceFarmListJobs()
        {
            #region to-get-information-about-jobs-1471642228071

            var client = new AmazonDeviceFarmClient();
            var response = client.ListJobs(new ListJobsRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456" // You can get the project ARN by using the list-jobs CLI command.
            });


            #endregion
        }

        public void DeviceFarmListOfferings()
        {
            #region to-get-information-about-device-offerings-1472562810999

            var client = new AmazonDeviceFarmClient();
            var response = client.ListOfferings(new ListOfferingsRequest 
            {
                NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE=" // A dynamically generated value, used for paginating results.
            });

            List<Offering> offerings = response.Offerings;

            #endregion
        }

        public void DeviceFarmListOfferingTransactions()
        {
            #region to-get-information-about-device-offering-transactions-1472561712315

            var client = new AmazonDeviceFarmClient();
            var response = client.ListOfferingTransactions(new ListOfferingTransactionsRequest 
            {
                NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE=" // A dynamically generated value, used for paginating results.
            });

            List<OfferingTransaction> offeringTransactions = response.OfferingTransactions;

            #endregion
        }

        public void DeviceFarmListProjects()
        {
            #region to-get-information-about-a-device-farm-project-1472564014388

            var client = new AmazonDeviceFarmClient();
            var response = client.ListProjects(new ListProjectsRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:7ad300ed-8183-41a7-bf94-12345EXAMPLE",
                NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE" // A dynamically generated value, used for paginating results.
            });

            List<Project> projects = response.Projects;

            #endregion
        }

        public void DeviceFarmListRemoteAccessSessions()
        {
            #region to-get-information-about-a-remote-access-session-1472581144803

            var client = new AmazonDeviceFarmClient();
            var response = client.ListRemoteAccessSessions(new ListRemoteAccessSessionsRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:session:EXAMPLE-GUID-123-456", // You can get the Amazon Resource Name (ARN) of the session by using the list-sessions CLI command.
                NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE=" // A dynamically generated value, used for paginating results.
            });

            List<RemoteAccessSession> remoteAccessSessions = response.RemoteAccessSessions;

            #endregion
        }

        public void DeviceFarmListRuns()
        {
            #region to-get-information-about-test-runs-1472582711069

            var client = new AmazonDeviceFarmClient();
            var response = client.ListRuns(new ListRunsRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:run:5e01a8c7-c861-4c0a-b1d5-5ec6e6c6dd23/0fcac17b-6122-44d7-ae5a-12345EXAMPLE", // You can get the Amazon Resource Name (ARN) of the run by using the list-runs CLI command.
                NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE" // A dynamically generated value, used for paginating results.
            });

            List<Run> runs = response.Runs;

            #endregion
        }

        public void DeviceFarmListSamples()
        {
            #region to-get-information-about-samples-1472582847534

            var client = new AmazonDeviceFarmClient();
            var response = client.ListSamples(new ListSamplesRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456", // You can get the Amazon Resource Name (ARN) of the project by using the list-projects CLI command.
                NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE" // A dynamically generated value, used for paginating results.
            });

            List<Sample> samples = response.Samples;

            #endregion
        }

        public void DeviceFarmListSuites()
        {
            #region to-get-information-about-suites-1472583038218

            var client = new AmazonDeviceFarmClient();
            var response = client.ListSuites(new ListSuitesRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:job:EXAMPLE-GUID-123-456", // You can get the Amazon Resource Name (ARN) of the job by using the list-jobs CLI command.
                NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE" // A dynamically generated value, used for paginating results.
            });

            List<Suite> suites = response.Suites;

            #endregion
        }

        public void DeviceFarmListTests()
        {
            #region to-get-information-about-tests-1472617372212

            var client = new AmazonDeviceFarmClient();
            var response = client.ListTests(new ListTestsRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456", // You can get the Amazon Resource Name (ARN) of the project by using the list-projects CLI command.
                NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE" // A dynamically generated value, used for paginating results.
            });

            List<Test> tests = response.Tests;

            #endregion
        }

        public void DeviceFarmListUniqueProblems()
        {
            #region to-get-information-about-unique-problems-1472617781008

            var client = new AmazonDeviceFarmClient();
            var response = client.ListUniqueProblems(new ListUniqueProblemsRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456", // You can get the Amazon Resource Name (ARN) of the project by using the list-projects CLI command.
                NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE" // A dynamically generated value, used for paginating results.
            });

            Dictionary<string, List<UniqueProblem>> uniqueProblems = response.UniqueProblems;

            #endregion
        }

        public void DeviceFarmListUploads()
        {
            #region to-get-information-about-uploads-1472617943090

            var client = new AmazonDeviceFarmClient();
            var response = client.ListUploads(new ListUploadsRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456", // You can get the Amazon Resource Name (ARN) of the project by using the list-projects CLI command.
                NextToken = "RW5DdDJkMWYwZjM2MzM2VHVpOHJIUXlDUXlhc2QzRGViYnc9SEXAMPLE" // A dynamically generated value, used for paginating results.
            });

            List<Upload> uploads = response.Uploads;

            #endregion
        }

        public void DeviceFarmPurchaseOffering()
        {
            #region to-purchase-a-device-slot-offering-1472648146343

            var client = new AmazonDeviceFarmClient();
            var response = client.PurchaseOffering(new PurchaseOfferingRequest 
            {
                OfferingId = "D68B3C05-1BA6-4360-BC69-12345EXAMPLE", // You can get the offering ID by using the list-offerings CLI command.
                Quantity = 1
            });

            OfferingTransaction offeringTransaction = response.OfferingTransaction;

            #endregion
        }

        public void DeviceFarmRenewOffering()
        {
            #region to-renew-a-device-slot-offering-1472648899785

            var client = new AmazonDeviceFarmClient();
            var response = client.RenewOffering(new RenewOfferingRequest 
            {
                OfferingId = "D68B3C05-1BA6-4360-BC69-12345EXAMPLE", // You can get the offering ID by using the list-offerings CLI command.
                Quantity = 1
            });

            OfferingTransaction offeringTransaction = response.OfferingTransaction;

            #endregion
        }

        public void DeviceFarmScheduleRun()
        {
            #region to-schedule-a-test-run-1472652429636

            var client = new AmazonDeviceFarmClient();
            var response = client.ScheduleRun(new ScheduleRunRequest 
            {
                Name = "MyRun",
                DevicePoolArn = "arn:aws:devicefarm:us-west-2:123456789101:pool:EXAMPLE-GUID-123-456", // You can get the Amazon Resource Name (ARN) of the device pool by using the list-pools CLI command.
                ProjectArn = "arn:aws:devicefarm:us-west-2:123456789101:project:EXAMPLE-GUID-123-456", // You can get the Amazon Resource Name (ARN) of the project by using the list-projects CLI command.
                Test = new ScheduleRunTest {
                    Type = "APPIUM_JAVA_JUNIT",
                    TestPackageArn = "arn:aws:devicefarm:us-west-2:123456789101:test:EXAMPLE-GUID-123-456"
                }
            });

            Run run = response.Run;

            #endregion
        }

        public void DeviceFarmStopRun()
        {
            #region to-stop-a-test-run-1472653770340

            var client = new AmazonDeviceFarmClient();
            var response = client.StopRun(new StopRunRequest 
            {
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:run:EXAMPLE-GUID-123-456" // You can get the Amazon Resource Name (ARN) of the test run by using the list-runs CLI command.
            });

            Run run = response.Run;

            #endregion
        }

        public void DeviceFarmUpdateDevicePool()
        {
            #region to-update-a-device-pool-1472653887677

            var client = new AmazonDeviceFarmClient();
            var response = client.UpdateDevicePool(new UpdateDevicePoolRequest 
            {
                Name = "NewName",
                Arn = "arn:aws:devicefarm:us-west-2::devicepool:082d10e5-d7d7-48a5-ba5c-12345EXAMPLE", // You can get the Amazon Resource Name (ARN) of the device pool by using the list-pools CLI command.
                Description = "NewDescription",
                Rules = new List<Rule> {
                    new Rule {
                        Value = "True",
                        Attribute = "REMOTE_ACCESS_ENABLED",
                        Operator = "EQUALS"
                    }
                }
            });

            DevicePool devicePool = response.DevicePool; // Note: you cannot update curated device pools.

            #endregion
        }

        public void DeviceFarmUpdateProject()
        {
            #region to-update-a-device-pool-1472653887677

            var client = new AmazonDeviceFarmClient();
            var response = client.UpdateProject(new UpdateProjectRequest 
            {
                Name = "NewName",
                Arn = "arn:aws:devicefarm:us-west-2:123456789101:project:8f75187d-101e-4625-accc-12345EXAMPLE" // You can get the Amazon Resource Name (ARN) of the project by using the list-projects CLI command.
            });

            Project project = response.Project;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}