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

using Amazon.ElasticLoadBalancing.Model;

namespace Amazon.ElasticLoadBalancing
{
    /// <summary>
    /// AmazonElasticLoadBalancingClient is an implementation of AmazonElasticLoadBalancing
    /// Elastic Load Balancing automatically distributes incoming application traffic across multiple
    /// Amazon EC2 instances. It enables you to achieve even greater fault tolerance in your applications,
    /// seamlessly providing the amount of load balancing capacity needed in response to incoming application
    /// traffic. Elastic Load Balancing detects unhealthy instances within a pool and automatically reroutes
    /// traffic to healthy instances until the unhealthy instances have been restored. You can enable Elastic
    /// Load Balancing within a single Availability Zone or across multiple zones for even more consistent
    /// application performance. Amazon CloudWatch can be used to capture a specific Elastic Load Balancer’s
    /// operational metrics, such as request count and request latency, at no additional cost beyond Elastic
    /// Load Balancing fees.
    /// </summary>
    public class AmazonElasticLoadBalancingClient : AmazonElasticLoadBalancing
    {
        private string awsAccessKeyId;
        private SecureString awsSecretAccessKey;
        private AmazonElasticLoadBalancingConfig config;
        private bool disposed;

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern for the AmazonElasticLoadBalancingClient
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
        ~AmazonElasticLoadBalancingClient()
        {
            this.Dispose(false);
        }

        #endregion

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticLoadBalancingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticLoadBalancing Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="config">The AmazonElasticLoadBalancing Configuration Object</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticLoadBalancingConfig config)
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
        /// Constructs an AmazonElasticLoadBalancingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticLoadBalancing Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key as a SecureString</param>
        /// <param name="config">The AmazonElasticLoadBalancing Configuration Object</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, SecureString awsSecretAccessKey, AmazonElasticLoadBalancingConfig config)
        {
            this.awsAccessKeyId = awsAccessKeyId;
            this.awsSecretAccessKey = awsSecretAccessKey;
            this.config = config;
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.UseNagleAlgorithm = false;
        }

        #region Public API

        /// <summary>
        /// Deregister Instances From Load Balancer
        /// </summary>
        /// <param name="request">Deregister Instances From Load Balancer  request</param>
        /// <returns>Deregister Instances From Load Balancer  Response from the service</returns>
        public DeregisterInstancesFromLoadBalancerResponse DeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest request)
        {
            return Invoke<DeregisterInstancesFromLoadBalancerResponse>(ConvertDeregisterInstancesFromLoadBalancer(request));
        }

        /// <summary>
        /// Configure Health Check
        /// </summary>
        /// <param name="request">Configure Health Check  request</param>
        /// <returns>Configure Health Check  Response from the service</returns>
        public ConfigureHealthCheckResponse ConfigureHealthCheck(ConfigureHealthCheckRequest request)
        {
            return Invoke<ConfigureHealthCheckResponse>(ConvertConfigureHealthCheck(request));
        }

        /// <summary>
        /// Delete Load Balancer
        /// </summary>
        /// <param name="request">Delete Load Balancer  request</param>
        /// <returns>Delete Load Balancer  Response from the service</returns>
        public DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request)
        {
            return Invoke<DeleteLoadBalancerResponse>(ConvertDeleteLoadBalancer(request));
        }

        /// <summary>
        /// Register Instances With Load Balancer
        /// </summary>
        /// <param name="request">Register Instances With Load Balancer  request</param>
        /// <returns>Register Instances With Load Balancer  Response from the service</returns>
        public RegisterInstancesWithLoadBalancerResponse RegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest request)
        {
            return Invoke<RegisterInstancesWithLoadBalancerResponse>(ConvertRegisterInstancesWithLoadBalancer(request));
        }

        /// <summary>
        /// Create Load Balancer
        /// </summary>
        /// <param name="request">Create Load Balancer  request</param>
        /// <returns>Create Load Balancer  Response from the service</returns>
        public CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request)
        {
            return Invoke<CreateLoadBalancerResponse>(ConvertCreateLoadBalancer(request));
        }

        /// <summary>
        /// Enable Availability Zones For Load Balancer
        /// </summary>
        /// <param name="request">Enable Availability Zones For Load Balancer  request</param>
        /// <returns>Enable Availability Zones For Load Balancer  Response from the service</returns>
        public EnableAvailabilityZonesForLoadBalancerResponse EnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest request)
        {
            return Invoke<EnableAvailabilityZonesForLoadBalancerResponse>(ConvertEnableAvailabilityZonesForLoadBalancer(request));
        }

        /// <summary>
        /// Disable Availability Zones For Load Balancer
        /// </summary>
        /// <param name="request">Disable Availability Zones For Load Balancer  request</param>
        /// <returns>Disable Availability Zones For Load Balancer  Response from the service</returns>
        public DisableAvailabilityZonesForLoadBalancerResponse DisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest request)
        {
            return Invoke<DisableAvailabilityZonesForLoadBalancerResponse>(ConvertDisableAvailabilityZonesForLoadBalancer(request));
        }

        /// <summary>
        /// Describe Instance Health
        /// </summary>
        /// <param name="request">Describe Instance Health  request</param>
        /// <returns>Describe Instance Health  Response from the service</returns>
        public DescribeInstanceHealthResponse DescribeInstanceHealth(DescribeInstanceHealthRequest request)
        {
            return Invoke<DescribeInstanceHealthResponse>(ConvertDescribeInstanceHealth(request));
        }

        /// <summary>
        /// Describe Load Balancers
        /// </summary>
        /// <param name="request">Describe Load Balancers  request</param>
        /// <returns>Describe Load Balancers  Response from the service</returns>
        public DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request)
        {
            return Invoke<DescribeLoadBalancersResponse>(ConvertDescribeLoadBalancers(request));
        }

        #endregion

        #region Private API

        /**
         * Configure HttpClient with set of defaults as well as configuration
         * from AmazonElasticLoadBalancingConfig instance
         */
        private static HttpWebRequest ConfigureWebRequest(int contentLength, AmazonElasticLoadBalancingConfig config)
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
                            throw new AmazonElasticLoadBalancingException(we);
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
                                throw new AmazonElasticLoadBalancingException(
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
                            if (e is AmazonElasticLoadBalancingException)
                            {
                                throw;
                            }
                            else
                            {
                                AmazonElasticLoadBalancingException se = ReportAnyErrors(responseBody, statusCode);
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
        private static AmazonElasticLoadBalancingException ReportAnyErrors(string responseBody, HttpStatusCode status)
        {
            AmazonElasticLoadBalancingException ex = null;

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

                    ex = new AmazonElasticLoadBalancingException(message, status, code, "Unknown", requestId, responseBody);
                }
                else if (errorMatcherTwo.Success)
                {
                    string code = errorMatcherTwo.Groups[1].Value;
                    string message = errorMatcherTwo.Groups[2].Value;
                    string requestId = errorMatcherTwo.Groups[4].Value;

                    ex = new AmazonElasticLoadBalancingException(message, status, code, "Unknown", requestId, responseBody);
                }
                else
                {
                    ex = new AmazonElasticLoadBalancingException("Internal Error", status);
                }
            }
            else
            {
                ex = new AmazonElasticLoadBalancingException("Internal Error", status);
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
                throw new AmazonElasticLoadBalancingException("Maximum number of retry attempts reached : " + (retries - 1), status);
            }
        }

        /**
         * Add authentication related and version parameters
         */
        private void AddRequiredParameters(IDictionary<string, string> parameters)
        {
            if (String.IsNullOrEmpty(this.awsAccessKeyId))
            {
                throw new AmazonElasticLoadBalancingException("The AWS Access Key ID cannot be NULL or a Zero length string");
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
        private static string SignParameters(IDictionary<string, string> parameters, SecureString key, AmazonElasticLoadBalancingConfig config)
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
                throw new AmazonElasticLoadBalancingException("Invalid Signature Version specified");
            }

            return Sign(stringToSign, key, algorithm);
        }

        private static string CalculateStringToSignV2(IDictionary<string, string> parameters, AmazonElasticLoadBalancingConfig config)
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
        /// <exception cref="T:Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancingException"></exception>
        /// <returns>A string representing the HMAC signature</returns>
        private static string Sign(string data, System.Security.SecureString key, KeyedHashAlgorithm algorithm)
        {
            if (key == null)
            {
                throw new AmazonElasticLoadBalancingException("The AWS Secret Access Key specified is NULL");
            }

            return AWSSDKUtils.HMACSign(data, key, algorithm);
        }

        /**
         * Convert DeregisterInstancesFromLoadBalancerRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DeregisterInstancesFromLoadBalancer");
            if (request.IsSetLoadBalancerName())
            {
                parameters.Add("LoadBalancerName", request.LoadBalancerName);
            }
            List<Instance> deregisterInstancesFromLoadBalancerRequestInstancesList = request.Instances;
            int deregisterInstancesFromLoadBalancerRequestInstancesListIndex = 1;
            foreach (Instance deregisterInstancesFromLoadBalancerRequestInstances in deregisterInstancesFromLoadBalancerRequestInstancesList)
            {
                if (deregisterInstancesFromLoadBalancerRequestInstances.IsSetInstanceId())
                {
                    parameters.Add("Instances" + ".member."  + deregisterInstancesFromLoadBalancerRequestInstancesListIndex + "." + "InstanceId", deregisterInstancesFromLoadBalancerRequestInstances.InstanceId);
                }

                deregisterInstancesFromLoadBalancerRequestInstancesListIndex++;
            }

            return parameters;
        }

        /**
         * Convert ConfigureHealthCheckRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertConfigureHealthCheck(ConfigureHealthCheckRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "ConfigureHealthCheck");
            if (request.IsSetLoadBalancerName())
            {
                parameters.Add("LoadBalancerName", request.LoadBalancerName);
            }
            if (request.IsSetHealthCheck())
            {
                HealthCheck  configureHealthCheckRequestHealthCheck = request.HealthCheck;
                if (configureHealthCheckRequestHealthCheck.IsSetTarget())
                {
                    parameters.Add("HealthCheck" + "." + "Target", configureHealthCheckRequestHealthCheck.Target);
                }
                if (configureHealthCheckRequestHealthCheck.IsSetInterval())
                {
                    parameters.Add("HealthCheck" + "." + "Interval", (configureHealthCheckRequestHealthCheck.Interval + ""));
                }
                if (configureHealthCheckRequestHealthCheck.IsSetTimeout())
                {
                    parameters.Add("HealthCheck" + "." + "Timeout", (configureHealthCheckRequestHealthCheck.Timeout + ""));
                }
                if (configureHealthCheckRequestHealthCheck.IsSetUnhealthyThreshold())
                {
                    parameters.Add("HealthCheck" + "." + "UnhealthyThreshold", (configureHealthCheckRequestHealthCheck.UnhealthyThreshold + ""));
                }
                if (configureHealthCheckRequestHealthCheck.IsSetHealthyThreshold())
                {
                    parameters.Add("HealthCheck" + "." + "HealthyThreshold", (configureHealthCheckRequestHealthCheck.HealthyThreshold + ""));
                }
            }

            return parameters;
        }

        /**
         * Convert DeleteLoadBalancerRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteLoadBalancer(DeleteLoadBalancerRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DeleteLoadBalancer");
            if (request.IsSetLoadBalancerName())
            {
                parameters.Add("LoadBalancerName", request.LoadBalancerName);
            }

            return parameters;
        }

        /**
         * Convert RegisterInstancesWithLoadBalancerRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertRegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "RegisterInstancesWithLoadBalancer");
            if (request.IsSetLoadBalancerName())
            {
                parameters.Add("LoadBalancerName", request.LoadBalancerName);
            }
            List<Instance> registerInstancesWithLoadBalancerRequestInstancesList = request.Instances;
            int registerInstancesWithLoadBalancerRequestInstancesListIndex = 1;
            foreach (Instance registerInstancesWithLoadBalancerRequestInstances in registerInstancesWithLoadBalancerRequestInstancesList)
            {
                if (registerInstancesWithLoadBalancerRequestInstances.IsSetInstanceId())
                {
                    parameters.Add("Instances" + ".member."  + registerInstancesWithLoadBalancerRequestInstancesListIndex + "." + "InstanceId", registerInstancesWithLoadBalancerRequestInstances.InstanceId);
                }

                registerInstancesWithLoadBalancerRequestInstancesListIndex++;
            }

            return parameters;
        }

        /**
         * Convert CreateLoadBalancerRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateLoadBalancer(CreateLoadBalancerRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "CreateLoadBalancer");
            if (request.IsSetLoadBalancerName())
            {
                parameters.Add("LoadBalancerName", request.LoadBalancerName);
            }
            List<Listener> createLoadBalancerRequestListenersList = request.Listeners;
            int createLoadBalancerRequestListenersListIndex = 1;
            foreach (Listener createLoadBalancerRequestListeners in createLoadBalancerRequestListenersList)
            {
                if (createLoadBalancerRequestListeners.IsSetProtocol())
                {
                    parameters.Add("Listeners" + ".member."  + createLoadBalancerRequestListenersListIndex + "." + "Protocol", createLoadBalancerRequestListeners.Protocol);
                }
                if (createLoadBalancerRequestListeners.IsSetLoadBalancerPort())
                {
                    parameters.Add("Listeners" + ".member."  + createLoadBalancerRequestListenersListIndex + "." + "LoadBalancerPort", (createLoadBalancerRequestListeners.LoadBalancerPort + ""));
                }
                if (createLoadBalancerRequestListeners.IsSetInstancePort())
                {
                    parameters.Add("Listeners" + ".member."  + createLoadBalancerRequestListenersListIndex + "." + "InstancePort", (createLoadBalancerRequestListeners.InstancePort + ""));
                }

                createLoadBalancerRequestListenersListIndex++;
            }
            List<string> createLoadBalancerRequestAvailabilityZonesList  =  request.AvailabilityZones;
            int createLoadBalancerRequestAvailabilityZonesListIndex = 1;
            foreach  (string createLoadBalancerRequestAvailabilityZones in createLoadBalancerRequestAvailabilityZonesList)
            {
                parameters.Add("AvailabilityZones" + ".member."  + createLoadBalancerRequestAvailabilityZonesListIndex, createLoadBalancerRequestAvailabilityZones);
                createLoadBalancerRequestAvailabilityZonesListIndex++;
            }

            return parameters;
        }

        /**
         * Convert EnableAvailabilityZonesForLoadBalancerRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertEnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "EnableAvailabilityZonesForLoadBalancer");
            if (request.IsSetLoadBalancerName())
            {
                parameters.Add("LoadBalancerName", request.LoadBalancerName);
            }
            List<string> enableAvailabilityZonesForLoadBalancerRequestAvailabilityZonesList  =  request.AvailabilityZones;
            int enableAvailabilityZonesForLoadBalancerRequestAvailabilityZonesListIndex = 1;
            foreach  (string enableAvailabilityZonesForLoadBalancerRequestAvailabilityZones in enableAvailabilityZonesForLoadBalancerRequestAvailabilityZonesList)
            {
                parameters.Add("AvailabilityZones" + ".member."  + enableAvailabilityZonesForLoadBalancerRequestAvailabilityZonesListIndex, enableAvailabilityZonesForLoadBalancerRequestAvailabilityZones);
                enableAvailabilityZonesForLoadBalancerRequestAvailabilityZonesListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DisableAvailabilityZonesForLoadBalancerRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DisableAvailabilityZonesForLoadBalancer");
            if (request.IsSetLoadBalancerName())
            {
                parameters.Add("LoadBalancerName", request.LoadBalancerName);
            }
            List<string> disableAvailabilityZonesForLoadBalancerRequestAvailabilityZonesList  =  request.AvailabilityZones;
            int disableAvailabilityZonesForLoadBalancerRequestAvailabilityZonesListIndex = 1;
            foreach  (string disableAvailabilityZonesForLoadBalancerRequestAvailabilityZones in disableAvailabilityZonesForLoadBalancerRequestAvailabilityZonesList)
            {
                parameters.Add("AvailabilityZones" + ".member."  + disableAvailabilityZonesForLoadBalancerRequestAvailabilityZonesListIndex, disableAvailabilityZonesForLoadBalancerRequestAvailabilityZones);
                disableAvailabilityZonesForLoadBalancerRequestAvailabilityZonesListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribeInstanceHealthRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeInstanceHealth(DescribeInstanceHealthRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DescribeInstanceHealth");
            if (request.IsSetLoadBalancerName())
            {
                parameters.Add("LoadBalancerName", request.LoadBalancerName);
            }
            List<Instance> describeInstanceHealthRequestInstancesList = request.Instances;
            int describeInstanceHealthRequestInstancesListIndex = 1;
            foreach (Instance describeInstanceHealthRequestInstances in describeInstanceHealthRequestInstancesList)
            {
                if (describeInstanceHealthRequestInstances.IsSetInstanceId())
                {
                    parameters.Add("Instances" + ".member."  + describeInstanceHealthRequestInstancesListIndex + "." + "InstanceId", describeInstanceHealthRequestInstances.InstanceId);
                }

                describeInstanceHealthRequestInstancesListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribeLoadBalancersRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeLoadBalancers(DescribeLoadBalancersRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DescribeLoadBalancers");
            List<string> describeLoadBalancersRequestLoadBalancerNamesList  =  request.LoadBalancerNames;
            int describeLoadBalancersRequestLoadBalancerNamesListIndex = 1;
            foreach  (string describeLoadBalancersRequestLoadBalancerNames in describeLoadBalancersRequestLoadBalancerNamesList)
            {
                parameters.Add("LoadBalancerNames" + ".member."  + describeLoadBalancersRequestLoadBalancerNamesListIndex, describeLoadBalancersRequestLoadBalancerNames);
                describeLoadBalancersRequestLoadBalancerNamesListIndex++;
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
