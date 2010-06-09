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
 *  API Version: 2009-05-15
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Reflection;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Xml.Serialization;

using Amazon.Util;

using Amazon.AutoScaling.Model;

namespace Amazon.AutoScaling
{
    /// <summary>
    /// AmazonAutoScalingClient is an implementation of AmazonAutoScaling
    /// Auto Scaling allows you to automatically scale your Amazon EC2 capacity up or down
    /// according to conditions you define. With Auto Scaling, you can ensure that the number
    /// of Amazon EC2 instances you’re using scales up seamlessly during demand spikes
    /// to maintain performance, and scales down automatically during demand lulls to minimize costs.
    /// Auto Scaling is particularly well suited for applications that experience hourly, daily,
    /// or weekly variability in usage. Auto Scaling is enabled by Amazon CloudWatch and available
    /// at no additional charge beyond Amazon CloudWatch fees.
    /// </summary>
    public class AmazonAutoScalingClient : AmazonAutoScaling
    {
        private string awsAccessKeyId;
        private SecureString awsSecretAccessKey;
        private AmazonAutoScalingConfig config;
        private bool disposed;

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern for the AmazonAutoScalingClient
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
        ~AmazonAutoScalingClient()
        {
            this.Dispose(false);
        }

        #endregion

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAutoScaling Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="config">The AmazonAutoScaling Configuration Object</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAutoScalingConfig config)
        {
            if (awsSecretAccessKey != null)
            {
                this.awsSecretAccessKey = new SecureString();
                foreach (char ch in awsSecretAccessKey.ToCharArray())
                {
                    this.awsSecretAccessKey.AppendChar(ch);
                }
                this.awsSecretAccessKey.MakeReadOnly();
            }
            this.awsAccessKeyId = awsAccessKeyId;
            this.config = config;
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.UseNagleAlgorithm = false;
        }

        /// <summary>
        /// Constructs an AmazonAutoScalingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAutoScaling Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key as a SecureString</param>
        /// <param name="config">The AmazonAutoScaling Configuration Object</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, SecureString awsSecretAccessKey, AmazonAutoScalingConfig config)
        {
            this.awsAccessKeyId = awsAccessKeyId;
            this.awsSecretAccessKey = awsSecretAccessKey;
            this.config = config;
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.UseNagleAlgorithm = false;
        }

        #region Public API

        /// <summary>
        /// Delete Launch Configuration
        /// </summary>
        /// <param name="request">Delete Launch Configuration  request</param>
        /// <returns>Delete Launch Configuration  Response from the service</returns>
        public DeleteLaunchConfigurationResponse DeleteLaunchConfiguration(DeleteLaunchConfigurationRequest request)
        {
            return Invoke<DeleteLaunchConfigurationResponse>(ConvertDeleteLaunchConfiguration(request));
        }

        /// <summary>
        /// Describe Triggers
        /// </summary>
        /// <param name="request">Describe Triggers  request</param>
        /// <returns>Describe Triggers  Response from the service</returns>
        public DescribeTriggersResponse DescribeTriggers(DescribeTriggersRequest request)
        {
            return Invoke<DescribeTriggersResponse>(ConvertDescribeTriggers(request));
        }

        /// <summary>
        /// Update Auto Scaling Group
        /// </summary>
        /// <param name="request">Update Auto Scaling Group  request</param>
        /// <returns>Update Auto Scaling Group  Response from the service</returns>
        public UpdateAutoScalingGroupResponse UpdateAutoScalingGroup(UpdateAutoScalingGroupRequest request)
        {
            return Invoke<UpdateAutoScalingGroupResponse>(ConvertUpdateAutoScalingGroup(request));
        }

        /// <summary>
        /// Create Auto Scaling Group
        /// </summary>
        /// <param name="request">Create Auto Scaling Group  request</param>
        /// <returns>Create Auto Scaling Group  Response from the service</returns>
        public CreateAutoScalingGroupResponse CreateAutoScalingGroup(CreateAutoScalingGroupRequest request)
        {
            return Invoke<CreateAutoScalingGroupResponse>(ConvertCreateAutoScalingGroup(request));
        }

        /// <summary>
        /// Delete Trigger
        /// </summary>
        /// <param name="request">Delete Trigger  request</param>
        /// <returns>Delete Trigger  Response from the service</returns>
        public DeleteTriggerResponse DeleteTrigger(DeleteTriggerRequest request)
        {
            return Invoke<DeleteTriggerResponse>(ConvertDeleteTrigger(request));
        }

        /// <summary>
        /// Terminate Instance In Auto Scaling Group
        /// </summary>
        /// <param name="request">Terminate Instance In Auto Scaling Group  request</param>
        /// <returns>Terminate Instance In Auto Scaling Group  Response from the service</returns>
        public TerminateInstanceInAutoScalingGroupResponse TerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest request)
        {
            return Invoke<TerminateInstanceInAutoScalingGroupResponse>(ConvertTerminateInstanceInAutoScalingGroup(request));
        }

        /// <summary>
        /// Create Or Update Scaling Trigger
        /// </summary>
        /// <param name="request">Create Or Update Scaling Trigger  request</param>
        /// <returns>Create Or Update Scaling Trigger  Response from the service</returns>
        public CreateOrUpdateScalingTriggerResponse CreateOrUpdateScalingTrigger(CreateOrUpdateScalingTriggerRequest request)
        {
            return Invoke<CreateOrUpdateScalingTriggerResponse>(ConvertCreateOrUpdateScalingTrigger(request));
        }

        /// <summary>
        /// Describe Auto Scaling Groups
        /// </summary>
        /// <param name="request">Describe Auto Scaling Groups  request</param>
        /// <returns>Describe Auto Scaling Groups  Response from the service</returns>
        public DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest request)
        {
            return Invoke<DescribeAutoScalingGroupsResponse>(ConvertDescribeAutoScalingGroups(request));
        }

        /// <summary>
        /// Create Launch Configuration
        /// </summary>
        /// <param name="request">Create Launch Configuration  request</param>
        /// <returns>Create Launch Configuration  Response from the service</returns>
        public CreateLaunchConfigurationResponse CreateLaunchConfiguration(CreateLaunchConfigurationRequest request)
        {
            return Invoke<CreateLaunchConfigurationResponse>(ConvertCreateLaunchConfiguration(request));
        }

        /// <summary>
        /// Describe Launch Configurations
        /// </summary>
        /// <param name="request">Describe Launch Configurations  request</param>
        /// <returns>Describe Launch Configurations  Response from the service</returns>
        public DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest request)
        {
            return Invoke<DescribeLaunchConfigurationsResponse>(ConvertDescribeLaunchConfigurations(request));
        }

        /// <summary>
        /// Describe Scaling Activities
        /// </summary>
        /// <param name="request">Describe Scaling Activities  request</param>
        /// <returns>Describe Scaling Activities  Response from the service</returns>
        public DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest request)
        {
            return Invoke<DescribeScalingActivitiesResponse>(ConvertDescribeScalingActivities(request));
        }

        /// <summary>
        /// Set Desired Capacity
        /// </summary>
        /// <param name="request">Set Desired Capacity  request</param>
        /// <returns>Set Desired Capacity  Response from the service</returns>
        public SetDesiredCapacityResponse SetDesiredCapacity(SetDesiredCapacityRequest request)
        {
            return Invoke<SetDesiredCapacityResponse>(ConvertSetDesiredCapacity(request));
        }

        /// <summary>
        /// Delete Auto Scaling Group
        /// </summary>
        /// <param name="request">Delete Auto Scaling Group  request</param>
        /// <returns>Delete Auto Scaling Group  Response from the service</returns>
        public DeleteAutoScalingGroupResponse DeleteAutoScalingGroup(DeleteAutoScalingGroupRequest request)
        {
            return Invoke<DeleteAutoScalingGroupResponse>(ConvertDeleteAutoScalingGroup(request));
        }

        #endregion

        #region Private API

        /**
         * Configure HttpClient with set of defaults as well as configuration
         * from AmazonAutoScalingConfig instance
         */
        private static HttpWebRequest ConfigureWebRequest(int contentLength, AmazonAutoScalingConfig config)
        {
            HttpWebRequest request = WebRequest.Create(config.ServiceURL) as HttpWebRequest;

            if (config.IsSetProxyHost())
            {
                request.Proxy = new WebProxy(config.ProxyHost, config.ProxyPort);
            }
            request.UserAgent = config.UserAgent;
            request.Method = "POST";
            request.Timeout = 50000;
            request.ContentType = AWSSDKUtils.UrlEncodedContent;
            request.ContentLength = contentLength;

            return request;
        }

        /**
         * Invoke request and return response
         */
        private T Invoke<T>(IDictionary<string, string> parameters)
        {
            string actionName = parameters["Action"];
            T response = default(T);
            string responseBody = null;
            HttpStatusCode statusCode = default(HttpStatusCode);

            /* Add required request parameters */
            AddRequiredParameters(parameters);

            string queryString = GetParametersAsString(parameters);

            byte[] requestData = Encoding.UTF8.GetBytes(queryString);
            bool shouldRetry = true;
            int retries = 0;
            do
            {
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
                        statusCode = httpResponse.StatusCode;
                        using (StreamReader reader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8))
                        {
                            responseBody = reader.ReadToEnd();
                        }
                    }

                    /* Perform response transformation */
                    if (responseBody != null &&
                        responseBody.Trim().EndsWith(String.Concat(actionName, "Response>")))
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
                            throw new AmazonAutoScalingException(we);
                        }
                        statusCode = httpErrorResponse.StatusCode;
                        using (StreamReader reader = new StreamReader(httpErrorResponse.GetResponseStream(), Encoding.UTF8))
                        {
                            responseBody = reader.ReadToEnd();
                        }

                        // Abort the unsuccessful request
                        request.Abort();
                    }

                    if (statusCode == HttpStatusCode.InternalServerError || statusCode == HttpStatusCode.ServiceUnavailable)
                    {
                        shouldRetry = true;
                        PauseOnRetry(++retries, config.MaxErrorRetry, statusCode);
                    }
                    else
                    {
                        /* Attempt to deserialize response into ErrorResponse type */
                        try
                        {
                            using (XmlTextReader sr = new XmlTextReader(new StringReader(responseBody)))
                            {
                                XmlSerializer serializer = new XmlSerializer(typeof(ErrorResponse));
                                ErrorResponse errorResponse = (ErrorResponse) serializer.Deserialize(sr);
                                Error error = errorResponse.Error[0];

                                /* Throw formatted exception with information available from the error response */
                                throw new AmazonAutoScalingException(
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
                            if (e is AmazonAutoScalingException)
                            {
                                throw;
                            }
                            else
                            {
                                AmazonAutoScalingException se = ReportAnyErrors(responseBody, statusCode);
                                throw se;
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
        private static AmazonAutoScalingException ReportAnyErrors(string responseBody, HttpStatusCode status)
        {
            AmazonAutoScalingException ex = null;

            if (responseBody != null && responseBody.StartsWith("<"))
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

                    ex = new AmazonAutoScalingException(message, status, code, "Unknown", requestId, responseBody);
                }
                else if (errorMatcherTwo.Success)
                {
                    string code = errorMatcherTwo.Groups[1].Value;
                    string message = errorMatcherTwo.Groups[2].Value;
                    string requestId = errorMatcherTwo.Groups[4].Value;

                    ex = new AmazonAutoScalingException(message, status, code, "Unknown", requestId, responseBody);
                }
                else
                {
                    ex = new AmazonAutoScalingException("Internal Error", status);
                }
            }
            else
            {
                ex = new AmazonAutoScalingException("Internal Error", status);
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
                throw new AmazonAutoScalingException("Maximum number of retry attempts reached : " + (retries - 1), status);
            }
        }

        /**
         * Add authentication related and version parameters
         */
        private void AddRequiredParameters(IDictionary<string, string> parameters)
        {
            if (String.IsNullOrEmpty(this.awsAccessKeyId))
            {
                throw new AmazonAutoScalingException("The AWS Access Key ID cannot be NULL or a Zero length string");
            }
            parameters.Add("AWSAccessKeyId", this.awsAccessKeyId);
            parameters.Add("Timestamp", AWSSDKUtils.FormattedCurrentTimestampISO8601);
            parameters.Add("Version", config.ServiceVersion);
            parameters.Add("SignatureVersion", config.SignatureVersion);
            parameters.Add("Signature", SignParameters(parameters, this.awsSecretAccessKey, config));
        }

        /**
         * Convert Dictionary of paremeters to Url encoded query string
         */
        private static string GetParametersAsString(IDictionary<string, string> parameters)
        {
            StringBuilder data = new StringBuilder(512);
            foreach (string key in (IEnumerable<string>)parameters.Keys)
            {
                string value = parameters[key];
                if (value != null)
                {
                    data.Append(key);
                    data.Append('=');
                    data.Append(AWSSDKUtils.UrlEncode(value, false));
                    data.Append('&');
                }
            }
            string result = data.ToString();
            return result.Remove(result.Length - 1);
        }

        /**
         * Computes RFC 2104-compliant HMAC signature for request parameters
         * Implements AWS Signature, as per following spec:
         *
         * If Signature Version is 0, it signs concatenated Action and Timestamp
         *
         * If Signature Version is 1, it performs the following:
         *
         * Sorts all  parameters (including SignatureVersion and excluding Signature,
         * the value of which is being created), ignoring case.
         *
         * Iterate over the sorted list and append the parameter name (in original case)
         * and then its value. It will not URL-encode the parameter values before
         * constructing this string. There are no separators.
         *
         * If Signature Version is 2, string to sign is based on following:
         *
         *    1. The HTTP Request Method followed by an ASCII newline (%0A)
         *    2. The HTTP Host header in the form of lowercase host, followed by an ASCII newline.
         *    3. The URL encoded HTTP absolute path component of the URI
         *       (up to but not including the query string parameters);
         *       if this is empty use a forward '/'. This parameter is followed by an ASCII newline.
         *    4. The concatenation of all query string components (names and values)
         *       as UTF-8 characters which are URL encoded as per RFC 3986
         *       (hex characters MUST be uppercase), sorted using lexicographic byte ordering.
         *       Parameter names are separated from their values by the '=' character
         *       (ASCII character 61), even if the value is empty.
         *       Pairs of parameter and values are separated by the ampersand character (ASCII code 38).
         *
         */
        private static string SignParameters(IDictionary<string, string> parameters, SecureString key, AmazonAutoScalingConfig config)
        {
            string signatureVersion = parameters["SignatureVersion"];

            KeyedHashAlgorithm algorithm = new HMACSHA1();

            string stringToSign = null;
            if ("2".Equals(signatureVersion))
            {
                string signatureMethod = config.SignatureMethod;
                algorithm = KeyedHashAlgorithm.Create(signatureMethod.ToUpper());
                parameters.Add("SignatureMethod", signatureMethod);
                stringToSign = CalculateStringToSignV2(parameters, config);
            }
            else
            {
                throw new AmazonAutoScalingException("Invalid Signature Version specified");
            }

            return Sign(stringToSign, key, algorithm);
        }

        private static string CalculateStringToSignV2(IDictionary<string, string> parameters, AmazonAutoScalingConfig config)
        {
            StringBuilder data = new StringBuilder(512);
            IDictionary<string, string> sorted =
                  new SortedDictionary<string, string>(parameters, StringComparer.Ordinal);
            data.Append("POST");
            data.Append("\n");
            Uri endpoint = new Uri(config.ServiceURL.ToLower());

            data.Append(endpoint.Host);
            data.Append("\n");
            string uri = endpoint.AbsolutePath;
            if (uri == null || uri.Length == 0)
            {
                uri = "/";
            }
            data.Append(AWSSDKUtils.UrlEncode(uri, true));
            data.Append("\n");
            foreach (KeyValuePair<string, string> pair in sorted)
            {
                if (pair.Value != null)
                {
                    data.Append(AWSSDKUtils.UrlEncode(pair.Key, false));
                    data.Append("=");
                    data.Append(AWSSDKUtils.UrlEncode(pair.Value, false));
                    data.Append("&");
                }
            }

            string result = data.ToString();
            return result.Remove(result.Length - 1);
        }

        /// <summary>
        /// Computes RFC 2104-compliant HMAC signature
        /// </summary>
        /// <param name="data">The data to be signed</param>
        /// <param name="key">The secret signing key</param>
        /// <param name="algorithm">The algorithm to sign the data with</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:Amazon.AutoScaling.AmazonAutoScalingException"></exception>
        /// <returns>A string representing the HMAC signature</returns>
        private static string Sign(string data, System.Security.SecureString key, KeyedHashAlgorithm algorithm)
        {
            if (key == null)
            {
                throw new AmazonAutoScalingException("The AWS Secret Access Key specified is NULL");
            }

            return AWSSDKUtils.HMACSign(data, key, algorithm);
        }

        /**
         * Convert DeleteLaunchConfigurationRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteLaunchConfiguration(DeleteLaunchConfigurationRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DeleteLaunchConfiguration");
            if (request.IsSetLaunchConfigurationName())
            {
                parameters.Add("LaunchConfigurationName", request.LaunchConfigurationName);
            }

            return parameters;
        }

        /**
         * Convert DescribeTriggersRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeTriggers(DescribeTriggersRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DescribeTriggers");
            if (request.IsSetAutoScalingGroupName())
            {
                parameters.Add("AutoScalingGroupName", request.AutoScalingGroupName);
            }

            return parameters;
        }

        /**
         * Convert UpdateAutoScalingGroupRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertUpdateAutoScalingGroup(UpdateAutoScalingGroupRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "UpdateAutoScalingGroup");
            if (request.IsSetAutoScalingGroupName())
            {
                parameters.Add("AutoScalingGroupName", request.AutoScalingGroupName);
            }
            if (request.IsSetLaunchConfigurationName())
            {
                parameters.Add("LaunchConfigurationName", request.LaunchConfigurationName);
            }
            if (request.IsSetMinSize())
            {
                parameters.Add("MinSize", (request.MinSize + ""));
            }
            if (request.IsSetMaxSize())
            {
                parameters.Add("MaxSize", (request.MaxSize + ""));
            }
            if (request.IsSetCooldown())
            {
                parameters.Add("Cooldown", (request.Cooldown + ""));
            }
            List<string> updateAutoScalingGroupRequestAvailabilityZonesList  =  request.AvailabilityZones;
            int updateAutoScalingGroupRequestAvailabilityZonesListIndex = 1;
            foreach  (string updateAutoScalingGroupRequestAvailabilityZones in updateAutoScalingGroupRequestAvailabilityZonesList)
            {
                parameters.Add("AvailabilityZones" + ".member."  + updateAutoScalingGroupRequestAvailabilityZonesListIndex, updateAutoScalingGroupRequestAvailabilityZones);
                updateAutoScalingGroupRequestAvailabilityZonesListIndex++;
            }

            return parameters;
        }

        /**
         * Convert CreateAutoScalingGroupRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateAutoScalingGroup(CreateAutoScalingGroupRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "CreateAutoScalingGroup");
            if (request.IsSetAutoScalingGroupName())
            {
                parameters.Add("AutoScalingGroupName", request.AutoScalingGroupName);
            }
            if (request.IsSetLaunchConfigurationName())
            {
                parameters.Add("LaunchConfigurationName", request.LaunchConfigurationName);
            }
            if (request.IsSetMinSize())
            {
                parameters.Add("MinSize", (request.MinSize + ""));
            }
            if (request.IsSetMaxSize())
            {
                parameters.Add("MaxSize", (request.MaxSize + ""));
            }
            if (request.IsSetCooldown())
            {
                parameters.Add("Cooldown", (request.Cooldown + ""));
            }
            List<string> createAutoScalingGroupRequestAvailabilityZonesList  =  request.AvailabilityZones;
            int createAutoScalingGroupRequestAvailabilityZonesListIndex = 1;
            foreach  (string createAutoScalingGroupRequestAvailabilityZones in createAutoScalingGroupRequestAvailabilityZonesList)
            {
                parameters.Add("AvailabilityZones" + ".member."  + createAutoScalingGroupRequestAvailabilityZonesListIndex, createAutoScalingGroupRequestAvailabilityZones);
                createAutoScalingGroupRequestAvailabilityZonesListIndex++;
            }
            List<string> createAutoScalingGroupRequestLoadBalancerNamesList  =  request.LoadBalancerNames;
            int createAutoScalingGroupRequestLoadBalancerNamesListIndex = 1;
            foreach  (string createAutoScalingGroupRequestLoadBalancerNames in createAutoScalingGroupRequestLoadBalancerNamesList)
            {
                parameters.Add("LoadBalancerNames" + ".member."  + createAutoScalingGroupRequestLoadBalancerNamesListIndex, createAutoScalingGroupRequestLoadBalancerNames);
                createAutoScalingGroupRequestLoadBalancerNamesListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DeleteTriggerRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteTrigger(DeleteTriggerRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DeleteTrigger");
            if (request.IsSetAutoScalingGroupName())
            {
                parameters.Add("AutoScalingGroupName", request.AutoScalingGroupName);
            }
            if (request.IsSetTriggerName())
            {
                parameters.Add("TriggerName", request.TriggerName);
            }

            return parameters;
        }

        /**
         * Convert TerminateInstanceInAutoScalingGroupRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertTerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "TerminateInstanceInAutoScalingGroup");
            if (request.IsSetInstanceId())
            {
                parameters.Add("InstanceId", request.InstanceId);
            }
            if (request.IsSetShouldDecrementDesiredCapacity())
            {
                parameters.Add("ShouldDecrementDesiredCapacity", (request.ShouldDecrementDesiredCapacity + "").ToLower());
            }

            return parameters;
        }

        /**
         * Convert CreateOrUpdateScalingTriggerRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateOrUpdateScalingTrigger(CreateOrUpdateScalingTriggerRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "CreateOrUpdateScalingTrigger");
            if (request.IsSetTriggerName())
            {
                parameters.Add("TriggerName", request.TriggerName);
            }
            if (request.IsSetAutoScalingGroupName())
            {
                parameters.Add("AutoScalingGroupName", request.AutoScalingGroupName);
            }
            if (request.IsSetMeasureName())
            {
                parameters.Add("MeasureName", request.MeasureName);
            }
            if (request.IsSetStatistic())
            {
                parameters.Add("Statistic", request.Statistic);
            }
            List<Dimension> createOrUpdateScalingTriggerRequestDimensionsList = request.Dimensions;
            int createOrUpdateScalingTriggerRequestDimensionsListIndex = 1;
            foreach (Dimension createOrUpdateScalingTriggerRequestDimensions in createOrUpdateScalingTriggerRequestDimensionsList)
            {
                if (createOrUpdateScalingTriggerRequestDimensions.IsSetName())
                {
                    parameters.Add("Dimensions" + ".member."  + createOrUpdateScalingTriggerRequestDimensionsListIndex + "." + "Name", createOrUpdateScalingTriggerRequestDimensions.Name);
                }
                if (createOrUpdateScalingTriggerRequestDimensions.IsSetValue())
                {
                    parameters.Add("Dimensions" + ".member."  + createOrUpdateScalingTriggerRequestDimensionsListIndex + "." + "Value", createOrUpdateScalingTriggerRequestDimensions.Value);
                }

                createOrUpdateScalingTriggerRequestDimensionsListIndex++;
            }
            if (request.IsSetPeriod())
            {
                parameters.Add("Period", (request.Period + ""));
            }
            if (request.IsSetUnit())
            {
                parameters.Add("Unit", request.Unit);
            }
            if (request.IsSetCustomUnit())
            {
                parameters.Add("CustomUnit", request.CustomUnit);
            }
            if (request.IsSetNamespace())
            {
                parameters.Add("Namespace", request.Namespace);
            }
            if (request.IsSetLowerThreshold())
            {
                parameters.Add("LowerThreshold", (request.LowerThreshold + ""));
            }
            if (request.IsSetLowerBreachScaleIncrement())
            {
                parameters.Add("LowerBreachScaleIncrement", request.LowerBreachScaleIncrement);
            }
            if (request.IsSetUpperThreshold())
            {
                parameters.Add("UpperThreshold", (request.UpperThreshold + ""));
            }
            if (request.IsSetUpperBreachScaleIncrement())
            {
                parameters.Add("UpperBreachScaleIncrement", request.UpperBreachScaleIncrement);
            }
            if (request.IsSetBreachDuration())
            {
                parameters.Add("BreachDuration", (request.BreachDuration + ""));
            }

            return parameters;
        }

        /**
         * Convert DescribeAutoScalingGroupsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DescribeAutoScalingGroups");
            List<string> describeAutoScalingGroupsRequestAutoScalingGroupNamesList  =  request.AutoScalingGroupNames;
            int describeAutoScalingGroupsRequestAutoScalingGroupNamesListIndex = 1;
            foreach  (string describeAutoScalingGroupsRequestAutoScalingGroupNames in describeAutoScalingGroupsRequestAutoScalingGroupNamesList)
            {
                parameters.Add("AutoScalingGroupNames" + ".member."  + describeAutoScalingGroupsRequestAutoScalingGroupNamesListIndex, describeAutoScalingGroupsRequestAutoScalingGroupNames);
                describeAutoScalingGroupsRequestAutoScalingGroupNamesListIndex++;
            }

            return parameters;
        }

        /**
         * Convert CreateLaunchConfigurationRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateLaunchConfiguration(CreateLaunchConfigurationRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "CreateLaunchConfiguration");
            if (request.IsSetLaunchConfigurationName())
            {
                parameters.Add("LaunchConfigurationName", request.LaunchConfigurationName);
            }
            if (request.IsSetImageId())
            {
                parameters.Add("ImageId", request.ImageId);
            }
            if (request.IsSetKeyName())
            {
                parameters.Add("KeyName", request.KeyName);
            }
            List<string> createLaunchConfigurationRequestSecurityGroupsList  =  request.SecurityGroups;
            int createLaunchConfigurationRequestSecurityGroupsListIndex = 1;
            foreach  (string createLaunchConfigurationRequestSecurityGroups in createLaunchConfigurationRequestSecurityGroupsList)
            {
                parameters.Add("SecurityGroups" + ".member."  + createLaunchConfigurationRequestSecurityGroupsListIndex, createLaunchConfigurationRequestSecurityGroups);
                createLaunchConfigurationRequestSecurityGroupsListIndex++;
            }
            if (request.IsSetUserData())
            {
                parameters.Add("UserData", request.UserData);
            }
            if (request.IsSetInstanceType())
            {
                parameters.Add("InstanceType", request.InstanceType);
            }
            if (request.IsSetKernelId())
            {
                parameters.Add("KernelId", request.KernelId);
            }
            if (request.IsSetRamdiskId())
            {
                parameters.Add("RamdiskId", request.RamdiskId);
            }
            List<BlockDeviceMapping> createLaunchConfigurationRequestBlockDeviceMappingsList = request.BlockDeviceMappings;
            int createLaunchConfigurationRequestBlockDeviceMappingsListIndex = 1;
            foreach (BlockDeviceMapping createLaunchConfigurationRequestBlockDeviceMappings in createLaunchConfigurationRequestBlockDeviceMappingsList)
            {
                if (createLaunchConfigurationRequestBlockDeviceMappings.IsSetVirtualName())
                {
                    parameters.Add("BlockDeviceMappings" + ".member."  + createLaunchConfigurationRequestBlockDeviceMappingsListIndex + "." + "VirtualName", createLaunchConfigurationRequestBlockDeviceMappings.VirtualName);
                }
                if (createLaunchConfigurationRequestBlockDeviceMappings.IsSetDeviceName())
                {
                    parameters.Add("BlockDeviceMappings" + ".member."  + createLaunchConfigurationRequestBlockDeviceMappingsListIndex + "." + "DeviceName", createLaunchConfigurationRequestBlockDeviceMappings.DeviceName);
                }

                createLaunchConfigurationRequestBlockDeviceMappingsListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribeLaunchConfigurationsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DescribeLaunchConfigurations");
            List<string> describeLaunchConfigurationsRequestLaunchConfigurationNamesList  =  request.LaunchConfigurationNames;
            int describeLaunchConfigurationsRequestLaunchConfigurationNamesListIndex = 1;
            foreach  (string describeLaunchConfigurationsRequestLaunchConfigurationNames in describeLaunchConfigurationsRequestLaunchConfigurationNamesList)
            {
                parameters.Add("LaunchConfigurationNames" + ".member."  + describeLaunchConfigurationsRequestLaunchConfigurationNamesListIndex, describeLaunchConfigurationsRequestLaunchConfigurationNames);
                describeLaunchConfigurationsRequestLaunchConfigurationNamesListIndex++;
            }
            if (request.IsSetNextToken())
            {
                parameters.Add("NextToken", request.NextToken);
            }
            if (request.IsSetMaxRecords())
            {
                parameters.Add("MaxRecords", (request.MaxRecords + ""));
            }

            return parameters;
        }

        /**
         * Convert DescribeScalingActivitiesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeScalingActivities(DescribeScalingActivitiesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DescribeScalingActivities");
            List<string> describeScalingActivitiesRequestActivityIdsList  =  request.ActivityIds;
            int describeScalingActivitiesRequestActivityIdsListIndex = 1;
            foreach  (string describeScalingActivitiesRequestActivityIds in describeScalingActivitiesRequestActivityIdsList)
            {
                parameters.Add("ActivityIds" + ".member."  + describeScalingActivitiesRequestActivityIdsListIndex, describeScalingActivitiesRequestActivityIds);
                describeScalingActivitiesRequestActivityIdsListIndex++;
            }
            if (request.IsSetAutoScalingGroupName())
            {
                parameters.Add("AutoScalingGroupName", request.AutoScalingGroupName);
            }
            if (request.IsSetMaxRecords())
            {
                parameters.Add("MaxRecords", (request.MaxRecords + ""));
            }
            if (request.IsSetNextToken())
            {
                parameters.Add("NextToken", request.NextToken);
            }

            return parameters;
        }

        /**
         * Convert SetDesiredCapacityRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertSetDesiredCapacity(SetDesiredCapacityRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "SetDesiredCapacity");
            if (request.IsSetAutoScalingGroupName())
            {
                parameters.Add("AutoScalingGroupName", request.AutoScalingGroupName);
            }
            if (request.IsSetDesiredCapacity())
            {
                parameters.Add("DesiredCapacity", (request.DesiredCapacity + ""));
            }

            return parameters;
        }

        /**
         * Convert DeleteAutoScalingGroupRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteAutoScalingGroup(DeleteAutoScalingGroupRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DeleteAutoScalingGroup");
            if (request.IsSetAutoScalingGroupName())
            {
                parameters.Add("AutoScalingGroupName", request.AutoScalingGroupName);
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
