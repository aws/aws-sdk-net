using System;
using Microsoft.Build.Utilities;
using Amazon.DeviceFarm;
using System.IO;
using Amazon;
using Amazon.DeviceFarm.Model;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Text.RegularExpressions;

namespace OnDeviceTestingTasks
{
    public class TestAppWithCalibash : Task
    {
        public string ApplicationLocation { get; set; }
        public string CalabashZipLocation { get; set; }
        public string ArtifactDownloadLocation { get; set; }
        public string TestProjectName { get; set; }
        public string RunNamePrefix { get; set; }
        private string _devicePoolName = DefaultDevicePoolName;
        public string DevicePoolName { get { return _devicePoolName; } set { _devicePoolName = value; } }
        private int _testTimeoutMinutes = 70;
        public int TestTimeoutMinutes { get { return _testTimeoutMinutes; } set { _testTimeoutMinutes = value; } }

        // content type for presigned puts
        private static string ContentType = "application/octet-stream";
        // convert from supported application file extensions to UploadType
        private static Dictionary<string, UploadType> ExtentionToUploadType = new Dictionary<string, UploadType>(StringComparer.OrdinalIgnoreCase)
        {
            {".apk", UploadType.ANDROID_APP },
            {".ipa", UploadType.IOS_APP }
        };

        private static string UndesirableFilenameChars = "\\/\"&() ";
        private static string DefaultDevicePoolName = "DefaultDevicePool";
        private static Dictionary<string, string> DefaultDevices = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"Apple iPhone 6", "8.4"},
            {"Apple iPhone 5c", "8.4"},
            {"Apple iPad Air", "8.1.2"},
            {"Apple iPhone 5s", "8.3"},
            {"Apple iPhone 6 Plus", "8.3"},
            {"Samsung Galaxy Tab 4 10.1 Nook (WiFi)", "4.4.2"} ,
            {"Samsung Galaxy S5 (T-Mobile)", "4.4.2"},
            {"Samsung Galaxy S6 (Verizon)", "5.0.2"},
            {"Amazon Kindle Fire HDX 7 (WiFi)", "4.4.3"},
        };



        private AmazonDeviceFarmClient DFClient;

        public override bool Execute()
        {
            // Verify required parameters have been provided
            CheckParameters();

            DFClient = new AmazonDeviceFarmClient(RegionEndpoint.USWest2);

            string runName = RunNamePrefix + DateTime.Now.ToFileTime();
            string projectArn = GetProjectArn(TestProjectName);
            string devicePoolArn = GetDevicePool(projectArn, DevicePoolName).Arn;
            UploadType applicationUploadType = InferUploadTypeFromFilePath(ApplicationLocation);
            string appUploadArn = UploadApplication(projectArn, ApplicationLocation, applicationUploadType);
            string calibashUploadArn = UploadCalibashArchive(projectArn, CalabashZipLocation);

            // wait for all uploads to complete
            var uploadArns = new List<string>() { appUploadArn, calibashUploadArn };
            WaitForCompletion(
                TimeSpan.FromMinutes(5),
                TimeSpan.FromSeconds(10),
                () => { return CheckForUploadsSuccessful(uploadArns); });

            Log.LogMessage("Scheduling test run for {0}", runName);
            // Schedule test run
            var runArn = DFClient.ScheduleRun(new ScheduleRunRequest()
            {
                ProjectArn = projectArn,
                AppArn = appUploadArn,
                Name = runName,
                DevicePoolArn = devicePoolArn,
                Test = new ScheduleRunTest()
                {
                    TestPackageArn = calibashUploadArn,
                    Type = TestType.CALABASH
                }
            }).Run.Arn;

            // following operations will apply generically to all test runs, in case we
            // end up wanting to have multiple test runs executing in parallel
            var testRunArns = new List<string>() { runArn };

            // Wait for all test runs to finish
            WaitForCompletion(TimeSpan.FromMinutes(TestTimeoutMinutes), TimeSpan.FromMinutes(1), () => { return CheckForTestsCompleted(testRunArns); });

            // Gather the final results of all runs
            var runs = GetTestRuns(testRunArns);

            // Log test run results and determine if all were successful
            bool testsSuccessful = true;
            foreach (var run in runs)
            {
                Log.LogMessage("Run '{0}' completed with result '{1}'.", run.Name, run.Result);
                if (run.Result != ExecutionResult.PASSED && run.Result != ExecutionResult.SKIPPED)
                {
                    testsSuccessful = false;
                }
            }

            // Download artifacts for each test run and organize into directories
            DownloadArtifacts(runs, ArtifactDownloadLocation);

            if (!testsSuccessful)
            {
                Log.LogError("Some tests failed.");
            }

            return testsSuccessful;
        }

        private void CheckParameters()
        {
            if (string.IsNullOrEmpty(ApplicationLocation))
            {
                throw new ArgumentNullException("ApplicationLocation", "Please provide a location for the application file");
            }
            if (string.IsNullOrEmpty(CalabashZipLocation))
            {
                throw new ArgumentNullException("CalabashZipLocation", "Please provide a location for the Calabash zip archive");
            }
            if (string.IsNullOrEmpty(ArtifactDownloadLocation))
            {
                throw new ArgumentNullException("ArtifactDownloadLocation", "Please provide a location for downloading the artifactList");
            }
            if (string.IsNullOrEmpty(TestProjectName))
            {
                throw new ArgumentNullException("TestProjectName", "Please provide a name for the test project");
            }
            if (string.IsNullOrEmpty(RunNamePrefix))
            {
                throw new ArgumentNullException("RunNamePrefix", "Please provide a name for the test run");
            }
            if (!File.Exists(ApplicationLocation))
            {
                throw new FileNotFoundException("Application not found", ApplicationLocation);
            }
            if (!File.Exists(CalabashZipLocation))
            {
                throw new FileNotFoundException("Calibash Zip not found", CalabashZipLocation);
            }
        }

        private string GetProjectArn(string projectName)
        {
            Project project = null;
            string nextToken = null;
            do
            {
                var response = DFClient.ListProjects(new ListProjectsRequest() { NextToken = nextToken });
                nextToken = response.NextToken;
                foreach (var p in response.Projects)
                {
                    if (p.Name == projectName)
                    {
                        project = p;
                        break;
                    }
                }
            } while (project == null && !string.IsNullOrEmpty(nextToken));

            if (project != null)
            {
                Log.LogMessage("Found project named '{0}' with ARN '{1}'.", projectName, project.Arn);
            }
            else
            {
                project = DFClient.CreateProject(projectName).Project;
                Log.LogMessage("Created project named '{0}' with ARN '{1}'.", projectName, project.Arn);
            }

            return project.Arn;
        }

        private DevicePool GetDevicePool(string projectArn, string devicePoolName)
        {
            DevicePool devicePool = null;
            string nextToken = null;
            do
            {
                var response = DFClient.ListDevicePools(new ListDevicePoolsRequest()
                {
                    Arn = projectArn,
                    Type = DevicePoolType.CURATED,
                    NextToken = nextToken
                });
                nextToken = response.NextToken;
                foreach (var dp in response.DevicePools)
                {
                    if (dp.Name == devicePoolName)
                    {
                        devicePool = dp;
                        break;
                    }
                }
            } while (devicePool == null && !string.IsNullOrEmpty(nextToken));

            if (devicePool != null)
            {
                Log.LogMessage("Found device pool named '{0}' with ARN '{1}'.", devicePoolName, devicePool.Arn);
            }
            else if (devicePoolName == DefaultDevicePoolName)
            {
                return CreateDefaultDevicePool(projectArn);
            }
            else
            {
                throw new System.ArgumentException(string.Format("Cannot find device pool named '{0}'.", devicePoolName));
            }

            return devicePool;
        }

        private DevicePool CreateDefaultDevicePool(string projectArn)
        {
            Log.LogMessage("Creating device pool {0}.", DefaultDevicePoolName);
            string nextToken = null;
            List<Device> devices = new List<Device>();
            do
            {
                var resp = DFClient.ListDevices(new ListDevicesRequest() { NextToken = nextToken });
                nextToken = resp.NextToken;
                devices.AddRange(resp.Devices);
            } while (nextToken != null);

            List<string> deviceArns = new List<string>();

            foreach (var device in devices)
            {
                if (DefaultDevices.ContainsKey(device.Name) && DefaultDevices[device.Name] == device.Os)
                {
                    deviceArns.Add('"' + device.Arn + '"');
                }
            }
            Rule rule = new Rule()
            {
                Attribute = DeviceAttribute.ARN,
                Operator = RuleOperator.IN,
                Value = "[" + string.Join(",", deviceArns) + "]"
            };
            DevicePool devicePool = DFClient.CreateDevicePool(new CreateDevicePoolRequest()
            {
                ProjectArn = projectArn,
                Name = DefaultDevicePoolName,
                Rules = new List<Rule>() { rule }
            }).DevicePool;
            return devicePool;
        }

        private void PresignedPut(string url, string filePath, string ContentType)
        {
            HttpWebRequest httpRequest = WebRequest.Create(url) as HttpWebRequest;
            httpRequest.Method = "PUT";
            httpRequest.ContentType = ContentType;
            httpRequest.Timeout = (int)TimeSpan.FromSeconds(180).TotalMilliseconds;
            using (Stream requestStream = httpRequest.GetRequestStream())
            {
                byte[] buffer = new byte[8000];
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    int bytesRead = 0;
                    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        requestStream.Write(buffer, 0, bytesRead);
                    }
                }
            }
            HttpWebResponse response = httpRequest.GetResponse() as HttpWebResponse;
            if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 300)
            {
                Log.LogMessage("Uploaded '{0}' with StatusCode '{1}'.", filePath, response.StatusCode);
            }
            else
            {
                throw new Exception(string.Format("Failed to upload '{0}' to {1}. Got StatusCode '{2}'.", filePath, url, response.StatusCode));
            }
        }

        private void PresignedGet(string url, string filePath)
        {
            HttpWebRequest httpRequest = WebRequest.Create(url) as HttpWebRequest;
            httpRequest.Method = "GET";
            HttpWebResponse response = httpRequest.GetResponse() as HttpWebResponse;
            if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 300)
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[8000];
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        int bytesRead = 0;
                        while ((bytesRead = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fileStream.Write(buffer, 0, bytesRead);
                        }
                    }
                }
                Log.LogMessage("Downloaded '{0}' with StatusCode '{1}'.", filePath, response.StatusCode);
            }
            else
            {
                throw new Exception(string.Format("Failed to download '{0}' from {1}. Got StatusCode '{2}'.", filePath, url, response.StatusCode));
            }
        }

        private UploadType InferUploadTypeFromFilePath(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            UploadType uploadType;
            if (!ExtentionToUploadType.TryGetValue(extension, out uploadType))
            {
                throw new System.ArgumentException(string.Format("No corresponding application UploadType for extension '{0}', from file path '{1}'.", extension, filePath));
            }
            return uploadType;
        }

        private string UploadApplication(string projectArn, string applicationLocation, UploadType uploadType)
        {
            string applicationName = Path.GetFileName(applicationLocation);
            var uploadResponse = DFClient.CreateUpload(new CreateUploadRequest()
            {
                Name = applicationName,
                ProjectArn = projectArn,
                Type = uploadType,
                ContentType = ContentType
            });
            PresignedPut(uploadResponse.Upload.Url, applicationLocation, ContentType);
            return uploadResponse.Upload.Arn;
        }

        private string UploadCalibashArchive(string projectArn, string calabashZipLocation)
        {
            string calibashArchiveName = Path.GetFileName(calabashZipLocation);
            var uploadResponse = DFClient.CreateUpload(new CreateUploadRequest()
            {
                Name = calibashArchiveName,
                ProjectArn = projectArn,
                Type = UploadType.CALABASH_TEST_PACKAGE,
                ContentType = ContentType
            });
            PresignedPut(uploadResponse.Upload.Url, calabashZipLocation, ContentType);
            return uploadResponse.Upload.Arn;
        }

        private delegate bool Check();
        private bool WaitForCompletion(TimeSpan timeout, TimeSpan increment, Check check)
        {
            Log.LogMessage("Waiting for completion with polling increment {0} and timeout {1}.", increment.ToString(), timeout.ToString());
            DateTime end = DateTime.Now.Add(timeout);
            if (check())
            {
                return true;
            }
            while (DateTime.Now < end)
            {
                Log.LogMessage("Waiting for {0}. Will timeout in {1}.", increment.ToString(), (end - DateTime.Now).ToString());
                Thread.Sleep(increment);
                if (check())
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckForUploadsSuccessful(List<string> uploadArns)
        {
            var uploads = new List<Upload>();
            foreach (string arn in uploadArns)
            {
                uploads.Add(DFClient.GetUpload(arn).Upload);
            }
            bool finished = true;
            foreach (var upload in uploads)
            {
                Log.LogMessage("Upload '{0}' has status '{1}'.", upload.Name, upload.Status);
                if (upload.Status == UploadStatus.FAILED)
                {
                    throw new Exception(string.Format("Upload '{0}' failed with message '{1}'.", upload.Name, upload.Message));
                }
                if (upload.Status != UploadStatus.SUCCEEDED)
                {
                    finished = false;
                }
            }
            Log.LogMessage(finished ? "All uploads have finished." : "Upload(s) still in progress.");
            return finished;
        }

        private bool CheckForTestsCompleted(List<string> testArns)
        {
            var runs = GetTestRuns(testArns);
            bool finished = true;
            foreach (var run in runs)
            {
                Log.LogMessage("Run '{0}' has status '{1}'.", run.Name, run.Status);
                if (run.Status != ExecutionStatus.COMPLETED)
                {
                    finished = false;
                }
            }
            return finished;
        }

        private List<Run> GetTestRuns(List<string> testArns)
        {
            var runs = new List<Run>();
            foreach (string arn in testArns)
            {
                runs.Add(DFClient.GetRun(arn).Run);
            }
            return runs;
        }

        private static string StripFileLocationCharacters(string original, int maxLength = -1)
        {
            var stripped = original;
            foreach (char c in UndesirableFilenameChars)
            {
                stripped = stripped.Replace(c.ToString(), "");
            }

            if (maxLength != -1 && stripped.Length > maxLength)
            {
                stripped = stripped.Substring(0, maxLength);
            }

            return stripped;
        }

        private List<Job> GetJobs(Run run)
        {
            string nextToken = null;
            List<Job> jobs = new List<Job>();
            do
            {
                var resp = DFClient.ListJobs(new ListJobsRequest() { NextToken = nextToken, Arn = run.Arn });
                nextToken = resp.NextToken;
                jobs.AddRange(resp.Jobs);
            } while (nextToken != null);
            return jobs;
        }
        private List<Suite> GetSuites(Job job)
        {
            string nextToken = null;
            List<Suite> suites = new List<Suite>();
            do
            {
                var resp = DFClient.ListSuites(new ListSuitesRequest() { NextToken = nextToken, Arn = job.Arn });
                nextToken = resp.NextToken;
                suites.AddRange(resp.Suites);
            } while (nextToken != null);
            return suites;
        }
        private List<Test> GetTests(Suite suite)
        {
            string nextToken = null;
            List<Test> tests = new List<Test>();
            do
            {
                var resp = DFClient.ListTests(new ListTestsRequest() { NextToken = nextToken, Arn = suite.Arn });
                nextToken = resp.NextToken;
                tests.AddRange(resp.Tests);
            } while (nextToken != null);
            return tests;
        }
        private List<Artifact> GetArtifacts(Test test, ArtifactCategory artifactCategory)
        {
            string nextToken = null;
            List<Artifact> artifacts = new List<Artifact>();
            do
            {
                var resp = DFClient.ListArtifacts(new ListArtifactsRequest() { NextToken = nextToken, Arn = test.Arn, Type = artifactCategory });
                nextToken = resp.NextToken;
                artifacts.AddRange(resp.Artifacts);
            } while (nextToken != null);
            return artifacts;
        }

        private void DownloadArtifacts(List<Run> testRuns, string artifactDownloadLocation)
        {
            foreach (var run in testRuns)
            {
                Log.LogMessage("Retrieving Artifacts for test run '{0}'", run.Name);
                string runDir = Path.Combine(artifactDownloadLocation, StripFileLocationCharacters(run.Name));
                Directory.CreateDirectory(runDir);
                foreach (var job in GetJobs(run))
                {
                    string jobDir = Path.Combine(runDir, StripFileLocationCharacters(job.Name));
                    Directory.CreateDirectory(jobDir);

                    foreach (var suite in GetSuites(job))
                    {
                        string suiteDir = Path.Combine(jobDir, StripFileLocationCharacters(suite.Name, 8));
                        Directory.CreateDirectory(suiteDir);
                        foreach (var test in GetTests(suite))
                        {
                            string testDir = Path.Combine(suiteDir, StripFileLocationCharacters(test.Name, 5));
                            Directory.CreateDirectory(jobDir);

                            foreach (var category in new List<ArtifactCategory>() {
                                ArtifactCategory.FILE,
                                ArtifactCategory.LOG,
                                ArtifactCategory.SCREENSHOT })
                            {

                                string categoryDir = Path.Combine(testDir, category.ToString());
                                Directory.CreateDirectory(categoryDir);
                                foreach (var artifact in GetArtifacts(test, category))
                                {
                                    string artifactName = StripFileLocationCharacters(artifact.Name, 10);

                                    int filenameSuffix = 0;

                                    while (File.Exists(Path.Combine(categoryDir, artifactName + "." + artifact.Extension)))
                                    {
                                        artifactName = artifactName + filenameSuffix;
                                        filenameSuffix++;
                                    }

                                    string artifactFinalLocation = Path.Combine(categoryDir, artifactName + "." + artifact.Extension);

                                    Log.LogMessage("Attempting to download file from '{0}', to path '{1}'.", artifact.Url, artifactFinalLocation);
                                    PresignedGet(artifact.Url, artifactFinalLocation);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
