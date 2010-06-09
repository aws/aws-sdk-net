/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-03-31
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.Serialization;

using Amazon.Util;

using Amazon.ElasticMapReduce.Model;

namespace Amazon.ElasticMapReduce
{
    /// <summary>
    /// AmazonElasticMapReduceClient is an implementation of AmazonElasticMapReduce;
    /// the client allows you to manage your AmazonElasticMapReduce resources.<br />
    /// If you want to use the AmazonElasticMapReduceClient from a Medium Trust
    /// hosting environment, please create the client with an
    /// AmazonElasticMapReduceConfig object whose UseSecureStringForAwsSecretKey
    /// property is false.
    /// </summary>
    /// <remarks>
    /// Amazon Elastic MapReduce is a web service that enables businesses, researchers,
    /// data analysts, and developers to easily and cost-effectively process vast amounts
    /// of data. It utilizes a hosted Hadoop framework running on the web-scale infrastructure
    /// of Amazon Elastic Compute Cloud (Amazon EC2) and Amazon Simple Storage Service (Amazon S3).
    /// </remarks>
    /// <seealso cref="P:Amazon.ElasticMapReduce.AmazonElasticMapReduceConfig.UseSecureStringForAwsSecretKey"/>
    public class AmazonElasticMapReduceClient : AmazonElasticMapReduce
    {
        private string awsAccessKeyId;
        private SecureString awsSecretAccessKey;
        private AmazonElasticMapReduceConfig config;
        private bool disposed;
        private string clearAwsSecretAccessKey;

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern for the AmazonElasticMapReduceClient
        /// </summary>
        /// <param name="fDisposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool fDisposing)
        {
            if (!this.disposed)
            {
                if (fDisposing)
                {
                    //Remove Unmanaged Resources
                    // I.O.W. remove resources that have to be explicitly
                    // "Dispose"d or Closed
                    if (awsSecretAccessKey != null)
                    {
                        awsSecretAccessKey.Dispose();
                        awsSecretAccessKey = null;
                    }
                }
                this.disposed = true;
            }
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// The destructor for the client class.
        /// </summary>
        ~AmazonElasticMapReduceClient()
        {
            this.Dispose(false);
        }

        #endregion

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticMapReduceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticMapReduce Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="config">The AmazonElasticMapReduce Configuration Object</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticMapReduceConfig config)
        {
            if (!String.IsNullOrEmpty(awsSecretAccessKey))
            {
                if (config.UseSecureStringForAwsSecretKey)
                {
                    this.awsSecretAccessKey = new SecureString();
                    foreach (char ch in awsSecretAccessKey.ToCharArray())
                    {
                        this.awsSecretAccessKey.AppendChar(ch);
                    }
                    this.awsSecretAccessKey.MakeReadOnly();
                }
                else
                {
                    clearAwsSecretAccessKey = awsSecretAccessKey;
                }
            }
            this.awsAccessKeyId = awsAccessKeyId;
            this.config = config;
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.UseNagleAlgorithm = false;
        }

        /// <summary>
        /// Constructs an AmazonElasticMapReduceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticMapReduce Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key as a SecureString</param>
        /// <param name="config">The AmazonElasticMapReduce Configuration Object</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, SecureString awsSecretAccessKey, AmazonElasticMapReduceConfig config)
        {
            this.awsAccessKeyId = awsAccessKeyId;
            this.awsSecretAccessKey = awsSecretAccessKey;
            this.config = config;
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.UseNagleAlgorithm = false;
        }

        #region Public API

        /// <summary>
        /// Add Job Flow Steps
        /// </summary>
        /// <param name="request">Add Job Flow Steps  request</param>
        /// <returns>Add Job Flow Steps  Response from the service</returns>
        public AddJobFlowStepsResponse AddJobFlowSteps(AddJobFlowStepsRequest request)
        {
            return Invoke<AddJobFlowStepsResponse>(ConvertAddJobFlowSteps(request));
        }

        /// <summary>
        /// Terminate Job Flows
        /// </summary>
        /// <param name="request">Terminate Job Flows  request</param>
        /// <returns>Terminate Job Flows  Response from the service</returns>
        public TerminateJobFlowsResponse TerminateJobFlows(TerminateJobFlowsRequest request)
        {
            return Invoke<TerminateJobFlowsResponse>(ConvertTerminateJobFlows(request));
        }

        /// <summary>
        /// Describe Job Flows
        /// </summary>
        /// <param name="request">Describe Job Flows  request</param>
        /// <returns>Describe Job Flows  Response from the service</returns>
        public DescribeJobFlowsResponse DescribeJobFlows(DescribeJobFlowsRequest request)
        {
            return Invoke<DescribeJobFlowsResponse>(ConvertDescribeJobFlows(request));
        }

        /// <summary>
        /// Run Job Flow
        /// </summary>
        /// <param name="request">Run Job Flow  request</param>
        /// <returns>Run Job Flow  Response from the service</returns>
        public RunJobFlowResponse RunJobFlow(RunJobFlowRequest request)
        {
            return Invoke<RunJobFlowResponse>(ConvertRunJobFlow(request));
        }

        #endregion

        #region Private API

        /**
         * Configure HttpClient with set of defaults as well as configuration
         * from AmazonElasticMapReduceConfig instance
         */
        private static HttpWebRequest ConfigureWebRequest(int contentLength, AmazonElasticMapReduceConfig config)
        {
            HttpWebRequest request = WebRequest.Create(config.ServiceURL) as HttpWebRequest;
            if (request != null)
            {
                if (config.IsSetProxyHost())
                {
                    request.Proxy = new WebProxy(config.ProxyHost, config.ProxyPort);
                }
                request.UserAgent = config.UserAgent;
                request.Method = "POST";
                request.Timeout = 50000;
                request.ContentType = AWSSDKUtils.UrlEncodedContent;
                request.ContentLength = contentLength;
            }

            return request;
        }

        /**
         * Invoke request and return response
         */
        private T Invoke<T>(IDictionary<string, string> parameters)
        {
            string actionName = parameters["Action"];
            T response = default(T);
            HttpStatusCode statusCode = default(HttpStatusCode);

            /* Add required request parameters */
            AddRequiredParameters(parameters);

            string queryString = AWSSDKUtils.GetParametersAsString(parameters);

            byte[] requestData = Encoding.UTF8.GetBytes(queryString);
            bool shouldRetry = true;
            int retries = 0;
            int maxRetries = config.IsSetMaxErrorRetry() ? config.MaxErrorRetry : AWSSDKUtils.DefaultMaxRetry;

            do
            {
                string responseBody = null;
                HttpWebRequest request = ConfigureWebRequest(requestData.Length, config);
                /* Submit the request and read response body */
                try
                {
                    using (Stream requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(requestData, 0, requestData.Length);
                    }
                    using (HttpWebResponse httpResponse = request.GetResponse() as HttpWebResponse)
                    {
                        if (httpResponse == null)
                        {
                            throw new WebException(
                                "The Web Response for a successful request is null!",
                                WebExceptionStatus.ProtocolError
                                );
                        }

                        statusCode = httpResponse.StatusCode;
                        using (StreamReader reader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8))
                        {
                            responseBody = reader.ReadToEnd();
                        }
                    }

                    /* Perform response transformation */
                    if (responseBody.Trim().EndsWith(String.Concat(actionName, "Response>")))
                    {
                        responseBody = Transform(responseBody, this.GetType());
                    }
                    /* Attempt to deserialize response into <Action> Response type */
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    using (XmlTextReader sr = new XmlTextReader(new StringReader(responseBody)))
                    {
                        response = (T)serializer.Deserialize(sr);
                    }
                    shouldRetry = false;
                }
                /* Web exception is thrown on unsucessful responses */
                catch (WebException we)
                {
                    shouldRetry = false;
                    using (HttpWebResponse httpErrorResponse = we.Response as HttpWebResponse)
                    {
                        if (httpErrorResponse == null)
                        {
                            // Abort the unsuccessful request
                            request.Abort();
                            throw we;
                        }
                        statusCode = httpErrorResponse.StatusCode;
                        using (StreamReader reader = new StreamReader(httpErrorResponse.GetResponseStream(), Encoding.UTF8))
                        {
                            responseBody = reader.ReadToEnd();
                        }

                        // Abort the unsuccessful request
                        request.Abort();
                    }

                    if (statusCode == HttpStatusCode.InternalServerError ||
                        statusCode == HttpStatusCode.ServiceUnavailable)
                    {
                        shouldRetry = true;
                        PauseOnRetry(++retries, maxRetries, statusCode);
                    }
                    else
                    {
                        /* Attempt to deserialize response into ErrorResponse type */
                        try
                        {
                            using (XmlTextReader sr = new XmlTextReader(new StringReader(responseBody)))
                            {
                                XmlSerializer serializer = new XmlSerializer(typeof(ErrorResponse));
                                ErrorResponse errorResponse = (ErrorResponse)serializer.Deserialize(sr);
                                Error error = errorResponse.Error[0];

                                /* Throw formatted exception with information available from the error response */
                                throw new AmazonElasticMapReduceException(
                                    error.Message,
                                    statusCode,
                                    error.Code,
                                    error.Type,
                                    errorResponse.RequestId,
                                    errorResponse.ToXML()
                                    );
                            }
                        }
                        /* Rethrow on deserializer error */
                        catch (Exception e)
                        {
                            if (e is AmazonElasticMapReduceException)
                            {
                                throw;
                            }
                            else
                            {
                                throw ReportAnyErrors(responseBody, statusCode);
                            }
                        }
                    }
                }
                /* Catch other exceptions, attempt to convert to formatted exception,
                 * else rethrow wrapped exception */
                catch (Exception)
                {
                    // Abort the unsuccessful request
                    request.Abort();
                    throw;
                }
            } while (shouldRetry);

            return response;
        }

        /**
         * Look for additional error strings in the response and return formatted exception
         */
        private static AmazonElasticMapReduceException ReportAnyErrors(string responseBody, HttpStatusCode status)
        {
            AmazonElasticMapReduceException ex = null;

            if (responseBody != null &&
                responseBody.StartsWith("<"))
            {
                Match errorMatcherOne = Regex.Match(
                    responseBody,
                    "<RequestId>(.*)</RequestId>.*<Error><Code>(.*)</Code><Message>(.*)</Message></Error>.*(<Error>)?",
                    RegexOptions.Multiline
                    );
                Match errorMatcherTwo = Regex.Match(
                    responseBody,
                    "<Error><Code>(.*)</Code><Message>(.*)</Message></Error>.*(<Error>)?.*<RequestID>(.*)</RequestID>",
                    RegexOptions.Multiline
                    );

                if (errorMatcherOne.Success)
                {
                    string requestId = errorMatcherOne.Groups[1].Value;
                    string code = errorMatcherOne.Groups[2].Value;
                    string message = errorMatcherOne.Groups[3].Value;

                    ex = new AmazonElasticMapReduceException(message, status, code, "Unknown", requestId, responseBody);
                }
                else if (errorMatcherTwo.Success)
                {
                    string code = errorMatcherTwo.Groups[1].Value;
                    string message = errorMatcherTwo.Groups[2].Value;
                    string requestId = errorMatcherTwo.Groups[4].Value;

                    ex = new AmazonElasticMapReduceException(message, status, code, "Unknown", requestId, responseBody);
                }
                else
                {
                    ex = new AmazonElasticMapReduceException("Internal Error", status);
                }
            }
            else
            {
                ex = new AmazonElasticMapReduceException("Internal Error", status);
            }
            return ex;
        }

        /**
         * Exponential sleep on failed request
         */
        private static void PauseOnRetry(int retries, int maxRetries, HttpStatusCode status)
        {
            if (retries <= maxRetries)
            {
                int delay = (int)Math.Pow(4, retries) * 100;
                System.Threading.Thread.Sleep(delay);
            }
            else
            {
                throw new AmazonElasticMapReduceException(
                    "Maximum number of retry attempts reached : " + (retries - 1),
                    status
                    );
            }
        }

        /**
         * Add authentication related and version parameters
         */
        private void AddRequiredParameters(IDictionary<string, string> parameters)
        {
            if (String.IsNullOrEmpty(this.awsAccessKeyId))
            {
                throw new AmazonElasticMapReduceException("The AWS Access Key ID cannot be NULL or a Zero length string");
            }

            parameters["AWSAccessKeyId"] = this.awsAccessKeyId;
            parameters["SignatureVersion"] = config.SignatureVersion;
            parameters["SignatureMethod"] = config.SignatureMethod;
            parameters["Timestamp"] = AWSSDKUtils.FormattedCurrentTimestampISO8601;
            parameters["Version"] = config.ServiceVersion;
            if (!config.SignatureVersion.Equals("2"))
            {
                throw new AmazonElasticMapReduceException("Invalid Signature Version specified");
            }
            string toSign = AWSSDKUtils.CalculateStringToSignV2(parameters, config.ServiceURL);

            KeyedHashAlgorithm algorithm = KeyedHashAlgorithm.Create(config.SignatureMethod.ToUpper());
            string auth;

            if (config.UseSecureStringForAwsSecretKey)
            {
                auth = AWSSDKUtils.HMACSign(toSign, awsSecretAccessKey, algorithm);
            }
            else
            {
                auth = AWSSDKUtils.HMACSign(toSign, clearAwsSecretAccessKey, algorithm);
            }
            parameters["Signature"] = auth;
        }

        /**
         * Convert AddJobFlowStepsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertAddJobFlowSteps(AddJobFlowStepsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "AddJobFlowSteps";
            if (request.IsSetJobFlowId())
            {
                parameters["JobFlowId"] = request.JobFlowId;
            }
            List<StepConfig> addJobFlowStepsRequestStepsList = request.Steps;
            int addJobFlowStepsRequestStepsListIndex = 1;
            foreach (StepConfig addJobFlowStepsRequestSteps in addJobFlowStepsRequestStepsList)
            {
                if (addJobFlowStepsRequestSteps.IsSetName())
                {
                    parameters[String.Concat("Steps", ".member.", addJobFlowStepsRequestStepsListIndex, ".", "Name")] = addJobFlowStepsRequestSteps.Name;
                }
                if (addJobFlowStepsRequestSteps.IsSetActionOnFailure())
                {
                    parameters[String.Concat("Steps", ".member.", addJobFlowStepsRequestStepsListIndex, ".", "ActionOnFailure")] = addJobFlowStepsRequestSteps.ActionOnFailure;
                }
                if (addJobFlowStepsRequestSteps.IsSetHadoopJarStep())
                {
                    HadoopJarStepConfig stepsHadoopJarStep = addJobFlowStepsRequestSteps.HadoopJarStep;
                    List<KeyValue> hadoopJarStepPropertiesList = stepsHadoopJarStep.Properties;
                    int hadoopJarStepPropertiesListIndex = 1;
                    foreach (KeyValue hadoopJarStepProperties in hadoopJarStepPropertiesList)
                    {
                        if (hadoopJarStepProperties.IsSetKey())
                        {
                            parameters[String.Concat("Steps", ".member.", addJobFlowStepsRequestStepsListIndex, ".", "HadoopJarStep", ".", "Properties", ".member.", hadoopJarStepPropertiesListIndex, ".", "Key")] = hadoopJarStepProperties.Key;
                        }
                        if (hadoopJarStepProperties.IsSetValue())
                        {
                            parameters[String.Concat("Steps", ".member.", addJobFlowStepsRequestStepsListIndex, ".", "HadoopJarStep", ".", "Properties", ".member.", hadoopJarStepPropertiesListIndex, ".", "Value")] = hadoopJarStepProperties.Value;
                        }

                        hadoopJarStepPropertiesListIndex++;
                    }
                    if (stepsHadoopJarStep.IsSetJar())
                    {
                        parameters[String.Concat("Steps", ".member.", addJobFlowStepsRequestStepsListIndex, ".", "HadoopJarStep", ".", "Jar")] = stepsHadoopJarStep.Jar;
                    }
                    if (stepsHadoopJarStep.IsSetMainClass())
                    {
                        parameters[String.Concat("Steps", ".member.", addJobFlowStepsRequestStepsListIndex, ".", "HadoopJarStep", ".", "MainClass")] = stepsHadoopJarStep.MainClass;
                    }
                    List<string> hadoopJarStepArgsList = stepsHadoopJarStep.Args;
                    int hadoopJarStepArgsListIndex = 1;
                    foreach (string hadoopJarStepArgs in hadoopJarStepArgsList)
                    {
                        parameters[String.Concat("Steps", ".member.", addJobFlowStepsRequestStepsListIndex, ".", "HadoopJarStep", ".", "Args", ".member.", hadoopJarStepArgsListIndex)] = hadoopJarStepArgs;
                        hadoopJarStepArgsListIndex++;
                    }
                }

                addJobFlowStepsRequestStepsListIndex++;
            }

            return parameters;
        }

        /**
         * Convert TerminateJobFlowsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertTerminateJobFlows(TerminateJobFlowsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "TerminateJobFlows";
            List<string> terminateJobFlowsRequestJobFlowIdsList = request.JobFlowIds;
            int terminateJobFlowsRequestJobFlowIdsListIndex = 1;
            foreach (string terminateJobFlowsRequestJobFlowIds in terminateJobFlowsRequestJobFlowIdsList)
            {
                parameters[String.Concat("JobFlowIds", ".member.", terminateJobFlowsRequestJobFlowIdsListIndex)] = terminateJobFlowsRequestJobFlowIds;
                terminateJobFlowsRequestJobFlowIdsListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribeJobFlowsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeJobFlows(DescribeJobFlowsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DescribeJobFlows";
            if (request.IsSetCreatedAfter())
            {
                parameters["CreatedAfter"] = request.CreatedAfter;
            }
            if (request.IsSetCreatedBefore())
            {
                parameters["CreatedBefore"] = request.CreatedBefore;
            }
            List<string> describeJobFlowsRequestJobFlowIdsList = request.JobFlowIds;
            int describeJobFlowsRequestJobFlowIdsListIndex = 1;
            foreach (string describeJobFlowsRequestJobFlowIds in describeJobFlowsRequestJobFlowIdsList)
            {
                parameters[String.Concat("JobFlowIds", ".member.", describeJobFlowsRequestJobFlowIdsListIndex)] = describeJobFlowsRequestJobFlowIds;
                describeJobFlowsRequestJobFlowIdsListIndex++;
            }
            List<string> describeJobFlowsRequestJobFlowStatesList = request.JobFlowStates;
            int describeJobFlowsRequestJobFlowStatesListIndex = 1;
            foreach (string describeJobFlowsRequestJobFlowStates in describeJobFlowsRequestJobFlowStatesList)
            {
                parameters[String.Concat("JobFlowStates", ".member.", describeJobFlowsRequestJobFlowStatesListIndex)] = describeJobFlowsRequestJobFlowStates;
                describeJobFlowsRequestJobFlowStatesListIndex++;
            }

            return parameters;
        }

        /**
         * Convert RunJobFlowRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertRunJobFlow(RunJobFlowRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "RunJobFlow";
            if (request.IsSetName())
            {
                parameters["Name"] = request.Name;
            }
            if (request.IsSetLogUri())
            {
                parameters["LogUri"] = request.LogUri;
            }
            if (request.IsSetInstances())
            {
                JobFlowInstancesConfig runJobFlowRequestInstances = request.Instances;
                if (runJobFlowRequestInstances.IsSetMasterInstanceType())
                {
                    parameters[String.Concat("Instances", ".", "MasterInstanceType")] = runJobFlowRequestInstances.MasterInstanceType;
                }
                if (runJobFlowRequestInstances.IsSetSlaveInstanceType())
                {
                    parameters[String.Concat("Instances", ".", "SlaveInstanceType")] = runJobFlowRequestInstances.SlaveInstanceType;
                }
                if (runJobFlowRequestInstances.IsSetInstanceCount())
                {
                    parameters[String.Concat("Instances", ".", "InstanceCount")] = runJobFlowRequestInstances.InstanceCount.ToString();
                }
                if (runJobFlowRequestInstances.IsSetEc2KeyName())
                {
                    parameters[String.Concat("Instances", ".", "Ec2KeyName")] = runJobFlowRequestInstances.Ec2KeyName;
                }
                if (runJobFlowRequestInstances.IsSetPlacement())
                {
                    PlacementType instancesPlacement = runJobFlowRequestInstances.Placement;
                    if (instancesPlacement.IsSetAvailabilityZone())
                    {
                        parameters[String.Concat("Instances", ".", "Placement", ".", "AvailabilityZone")] = instancesPlacement.AvailabilityZone;
                    }
                }
                if (runJobFlowRequestInstances.IsSetKeepJobFlowAliveWhenNoSteps())
                {
                    parameters[String.Concat("Instances", ".", "KeepJobFlowAliveWhenNoSteps")] = runJobFlowRequestInstances.KeepJobFlowAliveWhenNoSteps.ToString().ToLower();
                }
            }
            List<StepConfig> runJobFlowRequestStepsList = request.Steps;
            int runJobFlowRequestStepsListIndex = 1;
            foreach (StepConfig runJobFlowRequestSteps in runJobFlowRequestStepsList)
            {
                if (runJobFlowRequestSteps.IsSetName())
                {
                    parameters[String.Concat("Steps", ".member.", runJobFlowRequestStepsListIndex, ".", "Name")] = runJobFlowRequestSteps.Name;
                }
                if (runJobFlowRequestSteps.IsSetActionOnFailure())
                {
                    parameters[String.Concat("Steps", ".member.", runJobFlowRequestStepsListIndex, ".", "ActionOnFailure")] = runJobFlowRequestSteps.ActionOnFailure;
                }
                if (runJobFlowRequestSteps.IsSetHadoopJarStep())
                {
                    HadoopJarStepConfig stepsHadoopJarStep = runJobFlowRequestSteps.HadoopJarStep;
                    List<KeyValue> hadoopJarStepPropertiesList = stepsHadoopJarStep.Properties;
                    int hadoopJarStepPropertiesListIndex = 1;
                    foreach (KeyValue hadoopJarStepProperties in hadoopJarStepPropertiesList)
                    {
                        if (hadoopJarStepProperties.IsSetKey())
                        {
                            parameters[String.Concat("Steps", ".member.", runJobFlowRequestStepsListIndex, ".", "HadoopJarStep", ".", "Properties", ".member.", hadoopJarStepPropertiesListIndex, ".", "Key")] = hadoopJarStepProperties.Key;
                        }
                        if (hadoopJarStepProperties.IsSetValue())
                        {
                            parameters[String.Concat("Steps", ".member.", runJobFlowRequestStepsListIndex, ".", "HadoopJarStep", ".", "Properties", ".member.", hadoopJarStepPropertiesListIndex, ".", "Value")] = hadoopJarStepProperties.Value;
                        }

                        hadoopJarStepPropertiesListIndex++;
                    }
                    if (stepsHadoopJarStep.IsSetJar())
                    {
                        parameters[String.Concat("Steps", ".member.", runJobFlowRequestStepsListIndex, ".", "HadoopJarStep", ".", "Jar")] = stepsHadoopJarStep.Jar;
                    }
                    if (stepsHadoopJarStep.IsSetMainClass())
                    {
                        parameters[String.Concat("Steps", ".member.", runJobFlowRequestStepsListIndex, ".", "HadoopJarStep", ".", "MainClass")] = stepsHadoopJarStep.MainClass;
                    }
                    List<string> hadoopJarStepArgsList = stepsHadoopJarStep.Args;
                    int hadoopJarStepArgsListIndex = 1;
                    foreach (string hadoopJarStepArgs in hadoopJarStepArgsList)
                    {
                        parameters[String.Concat("Steps", ".member.", runJobFlowRequestStepsListIndex, ".", "HadoopJarStep", ".", "Args", ".member.", hadoopJarStepArgsListIndex)] = hadoopJarStepArgs;
                        hadoopJarStepArgsListIndex++;
                    }
                }

                runJobFlowRequestStepsListIndex++;
            }

            return parameters;
        }

        /*
         *  Transforms response based on xslt template
         */
        private static string Transform(string responseBody, Type t)
        {
            XslCompiledTransform transformer = new XslCompiledTransform();

            // Build the name of the xslt transform to apply to the response
            char[] seps = { ',' };

            Assembly assembly = Assembly.GetAssembly(t);
            string assemblyName = assembly.FullName;
            assemblyName = assemblyName.Split(seps)[0];

            string ns = t.Namespace;
            string resourceName = String.Concat(
                assemblyName,
                ".",
                ns,
                ".Model.",
                "ResponseTransformer.xslt"
                );
            using (XmlTextReader xmlReader = new XmlTextReader(assembly.GetManifestResourceStream(resourceName)))
            {
                transformer.Load(xmlReader);

                StringBuilder sb = new StringBuilder(1024);
                using (XmlTextReader xmlR = new XmlTextReader(new StringReader(responseBody)))
                {
                    using (StringWriter sw = new StringWriter(sb))
                    {
                        transformer.Transform(xmlR, null, sw);
                        return sb.ToString();
                    }
                }
            }
        }

        #endregion
    }
}
