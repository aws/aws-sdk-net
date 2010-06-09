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
 *  API Version: 2009-02-01
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using Amazon.SQS.Model;
using Attribute = Amazon.SQS.Model.Attribute;

using Amazon.Util;

namespace Amazon.SQS
{
    /// <summary>
    /// AmazonSQSClient is an implementation of AmazonSQS
    /// Amazon Simple Queue Service (Amazon SQS) offers a reliable, highly scalable hosted queue for storing
    /// messages as they travel between computers. By using Amazon SQS, developers can simply move data between
    /// distributed application components performing different tasks, without losing messages or requiring each
    /// component to be always available.  Amazon SQS works by exposing Amazon's web-scale messaging infrastructure
    /// as a web service. Any computer on the Internet can add or read messages without any installed software or
    /// special firewall configurations. Components of applications using Amazon SQS can run independently, and do
    /// not need to be on the same network, developed with the same technologies, or running at the same time.
    /// </summary>
    public class AmazonSQSClient : AmazonSQS, IDisposable
    {
        private string awsAccessKeyId;
        private SecureString awsSecretAccessKey;
        private AmazonSQSConfig config;
        private bool disposed;

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern for the AmazonSQSClient
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
        ~AmazonSQSClient()
        {
            this.Dispose(false);
        }

        #endregion

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSQSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSQS Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="config">The AmazonSQS Configuration Object</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSQSConfig config)
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
        /// Constructs an AmazonSQSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSQS Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key as a SecureString</param>
        /// <param name="config">The AmazonSQS Configuration Object</param>
        public AmazonSQSClient(string awsAccessKeyId, SecureString awsSecretAccessKey, AmazonSQSConfig config)
        {
            this.awsAccessKeyId = awsAccessKeyId;
            this.awsSecretAccessKey = awsSecretAccessKey;
            this.config = config;
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.UseNagleAlgorithm = false;
        }

        #region Public API

        /// <summary>
        /// Create Queue
        /// </summary>
        /// <param name="request">Create Queue  request</param>
        /// <returns>Create Queue  Response from the service</returns>
        /// <remarks>
        /// The CreateQueue action creates a new queue, or returns the URL of an existing one.
        /// When you request CreateQueue, you provide a name for the queue. To successfully create
        /// a new queue, you must provide a name that is unique within the scope of your own queues.
        /// If you provide the name of an existing queue, a new queue isn't created and an error
        /// isn't returned. Instead, the request succeeds and the queue URL for the existing queue is
        /// returned. Exception: if you provide a value for DefaultVisibilityTimeout that is different
        /// from the value for the existing queue, you receive an error.
        /// </remarks>
        public CreateQueueResponse CreateQueue(CreateQueueRequest request)
        {
            return Invoke<CreateQueueResponse>(ConvertCreateQueue(request));
        }

        /// <summary>
        /// List Queues
        /// </summary>
        /// <param name="request">List Queues  request</param>
        /// <returns>List Queues  Response from the service</returns>
        /// <remarks>
        /// The ListQueues action returns a list of your queues.
        /// </remarks>
        public ListQueuesResponse ListQueues(ListQueuesRequest request)
        {
            return Invoke<ListQueuesResponse>(ConvertListQueues(request));
        }

        /// <summary>
        /// Add Permission
        /// </summary>
        /// <param name="request">Add Permission  request</param>
        /// <returns>Add Permission  Response from the service</returns>
        /// <remarks>
        /// Adds the specified permission(s) to a queue for the specified principal(s). This allows for sharing access to the queue.
        /// </remarks>
        public AddPermissionResponse AddPermission(AddPermissionRequest request)
        {
            return Invoke<AddPermissionResponse>(ConvertAddPermission(request));
        }

        /// <summary>
        /// Change Message Visibility
        /// </summary>
        /// <param name="request">Change Message Visibility  request</param>
        /// <returns>Change Message Visibility  Response from the service</returns>
        /// <remarks>
        /// The ChangeMessageVisibility action extends the read lock timeout of the specified message from the specified queue to the specified value.
        /// </remarks>
        public ChangeMessageVisibilityResponse ChangeMessageVisibility(ChangeMessageVisibilityRequest request)
        {
            return Invoke<ChangeMessageVisibilityResponse>(ConvertChangeMessageVisibility(request));
        }

        /// <summary>
        /// Delete Message
        /// </summary>
        /// <param name="request">Delete Message  request</param>
        /// <returns>Delete Message  Response from the service</returns>
        /// <remarks>
        /// The DeleteMessage action unconditionally removes the specified message from the specified queue. Even if the message is locked by another reader due to the visibility timeout setting, it is still deleted from the queue.
        /// </remarks>
        public DeleteMessageResponse DeleteMessage(DeleteMessageRequest request)
        {
            return Invoke<DeleteMessageResponse>(ConvertDeleteMessage(request));
        }

        /// <summary>
        /// Delete Queue
        /// </summary>
        /// <param name="request">Delete Queue  request</param>
        /// <returns>Delete Queue  Response from the service</returns>
        /// <remarks>
        /// This action unconditionally deletes the queue specified by the queue URL. Use this operation WITH CARE!  The queue is deleted even if it is NOT empty.
        /// </remarks>
        public DeleteQueueResponse DeleteQueue(DeleteQueueRequest request)
        {
            return Invoke<DeleteQueueResponse>(ConvertDeleteQueue(request));
        }

        /// <summary>
        /// Get Queue Attributes
        /// </summary>
        /// <param name="request">Get Queue Attributes  request</param>
        /// <returns>Get Queue Attributes  Response from the service</returns>
        /// <remarks>
        /// Gets one or all attributes of a queue. Queues currently have two attributes you can get: ApproximateNumberOfMessages and VisibilityTimeout.
        /// </remarks>
        public GetQueueAttributesResponse GetQueueAttributes(GetQueueAttributesRequest request)
        {
            return Invoke<GetQueueAttributesResponse>(ConvertGetQueueAttributes(request));
        }

        /// <summary>
        /// Remove Permission
        /// </summary>
        /// <param name="request">Remove Permission  request</param>
        /// <returns>Remove Permission  Response from the service</returns>
        /// <remarks>
        /// Removes the permission with the specified statement id from the queue.
        /// </remarks>
        public RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            return Invoke<RemovePermissionResponse>(ConvertRemovePermission(request));
        }

        /// <summary>
        /// Receive Message
        /// </summary>
        /// <param name="request">Receive Message  request</param>
        /// <returns>Receive Message  Response from the service</returns>
        /// <remarks>
        /// Retrieves one or more messages from the specified queue.  For each message returned, the response includes
        /// the message body; MD5 digest of the message body; receipt handle, which is the identifier you must provide
        /// when deleting the message; and message ID of each message. Messages returned by this action stay in the queue
        /// until you delete them. However, once a message is returned to a ReceiveMessage request, it is not returned
        /// on subsequent ReceiveMessage requests for the duration of the VisibilityTimeout. If you do not specify a
        /// VisibilityTimeout in the request, the overall visibility timeout for the queue is used for the returned messages.
        /// </remarks>
        public ReceiveMessageResponse ReceiveMessage(ReceiveMessageRequest request)
        {
            return Invoke<ReceiveMessageResponse>(ConvertReceiveMessage(request));
        }

        /// <summary>
        /// Send Message
        /// </summary>
        /// <param name="request">Send Message  request</param>
        /// <returns>Send Message  Response from the service</returns>
        /// <remarks>
        /// The SendMessage action delivers a message to the specified queue.
        /// </remarks>
        public SendMessageResponse SendMessage(SendMessageRequest request)
        {
            return Invoke<SendMessageResponse>(ConvertSendMessage(request));
        }

        /// <summary>
        /// Set Queue Attributes
        /// </summary>
        /// <param name="request">Set Queue Attributes  request</param>
        /// <returns>Set Queue Attributes  Response from the service</returns>
        /// <remarks>
        /// Sets an attribute of a queue. Currently, you can set only the VisibilityTimeout attribute for a queue.
        /// </remarks>
        public SetQueueAttributesResponse SetQueueAttributes(SetQueueAttributesRequest request)
        {
            return Invoke<SetQueueAttributesResponse>(ConvertSetQueueAttributes(request));
        }

        #endregion

        #region Private API

        /**
         * Configure HttpClient with set of defaults as well as configuration
         * from AmazonSQSConfig instance
         */
        private static HttpWebRequest ConfigureWebRequest(int contentLength, string queueUrl, AmazonSQSConfig config)
        {
            HttpWebRequest request = WebRequest.Create(queueUrl) as HttpWebRequest;
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
            string queueUrl = parameters.ContainsKey("QueueUrl") ? parameters["QueueUrl"] : config.ServiceURL;

            if (parameters.ContainsKey("QueueUrl"))
            {
                parameters.Remove("QueueUrl");
            }
            HttpStatusCode statusCode = default(HttpStatusCode);

            /* Add required request parameters */
            AddRequiredParameters(parameters, queueUrl);

            string queryString = GetParametersAsString(parameters);

            byte[] requestData = Encoding.UTF8.GetBytes(queryString);
            bool shouldRetry = true;
            int retries = 0;
            do
            {
                HttpWebRequest request = ConfigureWebRequest(requestData.Length, queueUrl, config);
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
                            throw new AmazonSQSException(we);
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
                                throw new AmazonSQSException(
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
                            if (e is AmazonSQSException)
                            {
                                throw;
                            }
                            else
                            {
                                AmazonSQSException se = ReportAnyErrors(responseBody, statusCode);
                                throw se;
                            }
                        }
                    }
                }
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
        private static AmazonSQSException ReportAnyErrors(string responseBody, HttpStatusCode status)
        {
            AmazonSQSException ex = null;

            if (responseBody != null && responseBody.StartsWith("<"))
            {
                Match errorMatcherOne = Regex.Match(
                    responseBody,
                    "<RequestId>(.*)</RequestId>.*<Error><Code>(.*)</Code><Message>(.*)</Message></Error>.*(<Error>)?",
                    RegexOptions.Multiline);
                Match errorMatcherTwo = Regex.Match(
                    responseBody,
                    "<Error><Code>(.*)</Code><Message>(.*)</Message></Error>.*(<Error>)?.*<RequestID>(.*)</RequestID>",
                    RegexOptions.Multiline);

                if (errorMatcherOne.Success)
                {
                    string requestId = errorMatcherOne.Groups[1].Value;
                    string code = errorMatcherOne.Groups[2].Value;
                    string message = errorMatcherOne.Groups[3].Value;

                    ex = new AmazonSQSException(message, status, code, "Unknown", requestId, responseBody);
                }
                else if (errorMatcherTwo.Success)
                {
                    string code = errorMatcherTwo.Groups[1].Value;
                    string message = errorMatcherTwo.Groups[2].Value;
                    string requestId = errorMatcherTwo.Groups[4].Value;

                    ex = new AmazonSQSException(message, status, code, "Unknown", requestId, responseBody);
                }
                else
                {
                    ex = new AmazonSQSException("Internal Error", status);
                }
            }
            else
            {
                ex = new AmazonSQSException("Internal Error", status);
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
                throw new AmazonSQSException("Maximum number of retry attempts reached : " + (retries - 1), status);
            }
        }

        /**
         * Add authentication related and version parameters
         */
        private void AddRequiredParameters(IDictionary<string, string> parameters, string queueUrl)
        {
            if (String.IsNullOrEmpty(this.awsAccessKeyId))
            {
                throw new AmazonSQSException("The AWS Access Key ID cannot be NULL or a Zero length string");
            }
            parameters.Add("AWSAccessKeyId", this.awsAccessKeyId);
            parameters.Add("Timestamp", AWSSDKUtils.FormattedCurrentTimestamp);
            parameters.Add("Version", config.ServiceVersion);
            parameters.Add("SignatureVersion", config.SignatureVersion);
            parameters.Add("Signature", SignParameters(parameters, queueUrl, this.awsSecretAccessKey, config));
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
        private static string SignParameters(IDictionary<string, string> parameters, string queueUrl, SecureString key, AmazonSQSConfig config)
        {
            string signatureVersion = parameters["SignatureVersion"];

            KeyedHashAlgorithm algorithm = new HMACSHA1();

            string stringToSign = null;
            if ("2".Equals(signatureVersion))
            {
                string signatureMethod = config.SignatureMethod;
                algorithm = KeyedHashAlgorithm.Create(signatureMethod.ToUpper());
                parameters.Add("SignatureMethod", signatureMethod);
                stringToSign = CalculateStringToSignV2(parameters, queueUrl);
            }
            else
            {
                throw new AmazonSQSException("Invalid Signature Version specified");
            }

            return Sign(stringToSign, key, algorithm);
        }

        private static string CalculateStringToSignV2(IDictionary<string, string> parameters, string queueUrl)
        {
            StringBuilder data = new StringBuilder(512);
            IDictionary<string, string> sorted =
                  new SortedDictionary<string, string>(parameters, StringComparer.Ordinal);
            data.Append("POST");
            data.Append("\n");
            Uri endpoint = new Uri(queueUrl);

            data.Append(endpoint.Host);
            data.Append("\n");
            string path = endpoint.AbsolutePath;
            if (String.IsNullOrEmpty(path))
            {
                path = "/";
            }

            data.Append(AWSSDKUtils.UrlEncode(path, true));
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
        /// <returns>A string representing the HMAC signature</returns>
        private static string Sign(string data, System.Security.SecureString key, KeyedHashAlgorithm algorithm)
        {
            if (key == null)
            {
                throw new AmazonSQSException("The AWS Secret Access Key specified is NULL");
            }

            return AWSSDKUtils.HMACSign(data, key, algorithm);
        }

        /**
         * Convert CreateQueueRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateQueue(CreateQueueRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "CreateQueue");
            if (request.IsSetQueueName())
            {
                parameters.Add("QueueName", request.QueueName);
            }
            if (request.IsSetDefaultVisibilityTimeout())
            {
                parameters.Add("DefaultVisibilityTimeout", (request.DefaultVisibilityTimeout + ""));
            }
            List<Attribute> createQueueRequestAttributeList = request.Attribute;
            int createQueueRequestAttributeListIndex = 1;
            foreach (Attribute createQueueRequestAttribute in createQueueRequestAttributeList)
            {
                if (createQueueRequestAttribute.IsSetName())
                {
                    parameters.Add("Attribute" + "."  + createQueueRequestAttributeListIndex + "." + "Name", createQueueRequestAttribute.Name);
                }
                if (createQueueRequestAttribute.IsSetValue())
                {
                    parameters.Add("Attribute" + "."  + createQueueRequestAttributeListIndex + "." + "Value", createQueueRequestAttribute.Value);
                }

                createQueueRequestAttributeListIndex++;
            }

            return parameters;
        }

        /**
         * Convert ListQueuesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertListQueues(ListQueuesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "ListQueues");
            if (request.IsSetQueueNamePrefix())
            {
                parameters.Add("QueueNamePrefix", request.QueueNamePrefix);
            }
            List<Attribute> listQueuesRequestAttributeList = request.Attribute;
            int listQueuesRequestAttributeListIndex = 1;
            foreach (Attribute listQueuesRequestAttribute in listQueuesRequestAttributeList)
            {
                if (listQueuesRequestAttribute.IsSetName())
                {
                    parameters.Add("Attribute" + "."  + listQueuesRequestAttributeListIndex + "." + "Name", listQueuesRequestAttribute.Name);
                }
                if (listQueuesRequestAttribute.IsSetValue())
                {
                    parameters.Add("Attribute" + "."  + listQueuesRequestAttributeListIndex + "." + "Value", listQueuesRequestAttribute.Value);
                }

                listQueuesRequestAttributeListIndex++;
            }

            return parameters;
        }

        /**
         * Convert ChangeMessageVisibilityRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertChangeMessageVisibility(ChangeMessageVisibilityRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "ChangeMessageVisibility");
            if (request.IsSetQueueUrl())
            {
                parameters.Add("QueueUrl", request.QueueUrl);
            }
            if (request.IsSetReceiptHandle())
            {
                parameters.Add("ReceiptHandle", request.ReceiptHandle);
            }
            if (request.IsSetVisibilityTimeout())
            {
                parameters.Add("VisibilityTimeout", (request.VisibilityTimeout + ""));
            }
            List<Attribute> changeMessageVisibilityRequestAttributeList = request.Attribute;
            int changeMessageVisibilityRequestAttributeListIndex = 1;
            foreach (Attribute changeMessageVisibilityRequestAttribute in changeMessageVisibilityRequestAttributeList)
            {
                if (changeMessageVisibilityRequestAttribute.IsSetName())
                {
                    parameters.Add("Attribute" + "."  + changeMessageVisibilityRequestAttributeListIndex + "." + "Name", changeMessageVisibilityRequestAttribute.Name);
                }
                if (changeMessageVisibilityRequestAttribute.IsSetValue())
                {
                    parameters.Add("Attribute" + "."  + changeMessageVisibilityRequestAttributeListIndex + "." + "Value", changeMessageVisibilityRequestAttribute.Value);
                }

                changeMessageVisibilityRequestAttributeListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DeleteMessageRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteMessage(DeleteMessageRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DeleteMessage");
            if (request.IsSetQueueUrl())
            {
                parameters.Add("QueueUrl", request.QueueUrl);
            }
            if (request.IsSetReceiptHandle())
            {
                parameters.Add("ReceiptHandle", request.ReceiptHandle);
            }
            List<Attribute> deleteMessageRequestAttributeList = request.Attribute;
            int deleteMessageRequestAttributeListIndex = 1;
            foreach (Attribute deleteMessageRequestAttribute in deleteMessageRequestAttributeList)
            {
                if (deleteMessageRequestAttribute.IsSetName())
                {
                    parameters.Add("Attribute" + "."  + deleteMessageRequestAttributeListIndex + "." + "Name", deleteMessageRequestAttribute.Name);
                }
                if (deleteMessageRequestAttribute.IsSetValue())
                {
                    parameters.Add("Attribute" + "."  + deleteMessageRequestAttributeListIndex + "." + "Value", deleteMessageRequestAttribute.Value);
                }

                deleteMessageRequestAttributeListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DeleteQueueRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteQueue(DeleteQueueRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DeleteQueue");
            if (request.IsSetQueueUrl())
            {
                parameters.Add("QueueUrl", request.QueueUrl);
            }
            List<Attribute> deleteQueueRequestAttributeList = request.Attribute;
            int deleteQueueRequestAttributeListIndex = 1;
            foreach (Attribute deleteQueueRequestAttribute in deleteQueueRequestAttributeList)
            {
                if (deleteQueueRequestAttribute.IsSetName())
                {
                    parameters.Add("Attribute" + "."  + deleteQueueRequestAttributeListIndex + "." + "Name", deleteQueueRequestAttribute.Name);
                }
                if (deleteQueueRequestAttribute.IsSetValue())
                {
                    parameters.Add("Attribute" + "."  + deleteQueueRequestAttributeListIndex + "." + "Value", deleteQueueRequestAttribute.Value);
                }

                deleteQueueRequestAttributeListIndex++;
            }

            return parameters;
        }

        /**
         * Convert GetQueueAttributesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertGetQueueAttributes(GetQueueAttributesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "GetQueueAttributes");
            if (request.IsSetQueueUrl())
            {
                parameters.Add("QueueUrl", request.QueueUrl);
            }
            List<string> getQueueAttributesRequestAttributeNameList  =  request.AttributeName;
            int getQueueAttributesRequestAttributeNameListIndex = 1;
            foreach  (string getQueueAttributesRequestAttributeName in getQueueAttributesRequestAttributeNameList)
            {
                parameters.Add("AttributeName" + "."  + getQueueAttributesRequestAttributeNameListIndex, getQueueAttributesRequestAttributeName);
                getQueueAttributesRequestAttributeNameListIndex++;
            }

            return parameters;
        }

        /**
         * Convert ReceiveMessageRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertReceiveMessage(ReceiveMessageRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "ReceiveMessage");
            if (request.IsSetQueueUrl())
            {
                parameters.Add("QueueUrl", request.QueueUrl);
            }
            if (request.IsSetMaxNumberOfMessages())
            {
                parameters.Add("MaxNumberOfMessages", (request.MaxNumberOfMessages + ""));
            }
            if (request.IsSetVisibilityTimeout())
            {
                parameters.Add("VisibilityTimeout", (request.VisibilityTimeout + ""));
            }
            List<string> receiveMessageRequestAttributeNameList  =  request.AttributeName;
            int receiveMessageRequestAttributeNameListIndex = 1;
            foreach  (string receiveMessageRequestAttributeName in receiveMessageRequestAttributeNameList)
            {
                parameters.Add("AttributeName" + "."  + receiveMessageRequestAttributeNameListIndex, receiveMessageRequestAttributeName);
                receiveMessageRequestAttributeNameListIndex++;
            }

            return parameters;
        }

        /**
         * Convert SendMessageRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertSendMessage(SendMessageRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "SendMessage");
            if (request.IsSetQueueUrl())
            {
                parameters.Add("QueueUrl", request.QueueUrl);
            }
            if (request.IsSetMessageBody())
            {
                parameters.Add("MessageBody", request.MessageBody);
            }
            List<Attribute> sendMessageRequestAttributeList = request.Attribute;
            int sendMessageRequestAttributeListIndex = 1;
            foreach (Attribute sendMessageRequestAttribute in sendMessageRequestAttributeList)
            {
                if (sendMessageRequestAttribute.IsSetName())
                {
                    parameters.Add("Attribute" + "."  + sendMessageRequestAttributeListIndex + "." + "Name", sendMessageRequestAttribute.Name);
                }
                if (sendMessageRequestAttribute.IsSetValue())
                {
                    parameters.Add("Attribute" + "."  + sendMessageRequestAttributeListIndex + "." + "Value", sendMessageRequestAttribute.Value);
                }

                sendMessageRequestAttributeListIndex++;
            }

            return parameters;
        }

        /**
         * Convert SetQueueAttributesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertSetQueueAttributes(SetQueueAttributesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "SetQueueAttributes");
            if (request.IsSetQueueUrl())
            {
                parameters.Add("QueueUrl", request.QueueUrl);
            }
            List<Attribute> setQueueAttributesRequestAttributeList = request.Attribute;
            int setQueueAttributesRequestAttributeListIndex = 1;
            foreach (Attribute setQueueAttributesRequestAttribute in setQueueAttributesRequestAttributeList)
            {
                if (setQueueAttributesRequestAttribute.IsSetName())
                {
                    parameters.Add("Attribute" + "."  + setQueueAttributesRequestAttributeListIndex + "." + "Name", setQueueAttributesRequestAttribute.Name);
                }
                if (setQueueAttributesRequestAttribute.IsSetValue())
                {
                    parameters.Add("Attribute" + "."  + setQueueAttributesRequestAttributeListIndex + "." + "Value", setQueueAttributesRequestAttribute.Value);
                }

                setQueueAttributesRequestAttributeListIndex++;
            }

            return parameters;
        }

        /**
         * Convert AddPermissionRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertAddPermission(AddPermissionRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "AddPermission");
            if (request.IsSetQueueUrl())
            {
                parameters.Add("QueueUrl", request.QueueUrl);
            }
            if (request.IsSetLabel())
            {
                parameters.Add("Label", request.Label);
            }
            List<string> addPermissionRequestAWSAccountIdList  =  request.AWSAccountId;
            int addPermissionRequestAWSAccountIdListIndex = 1;
            foreach  (string addPermissionRequestAWSAccountId in addPermissionRequestAWSAccountIdList)
            {
                parameters.Add("AWSAccountId" + "."  + addPermissionRequestAWSAccountIdListIndex, addPermissionRequestAWSAccountId);
                addPermissionRequestAWSAccountIdListIndex++;
            }
            List<string> addPermissionRequestActionNameList  =  request.ActionName;
            int addPermissionRequestActionNameListIndex = 1;
            foreach  (string addPermissionRequestActionName in addPermissionRequestActionNameList)
            {
                parameters.Add("ActionName" + "."  + addPermissionRequestActionNameListIndex, addPermissionRequestActionName);
                addPermissionRequestActionNameListIndex++;
            }

            return parameters;
        }

        /**
         * Convert RemovePermissionRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertRemovePermission(RemovePermissionRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "RemovePermission");
            if (request.IsSetQueueUrl())
            {
                parameters.Add("QueueUrl", request.QueueUrl);
            }
            if (request.IsSetLabel())
            {
                parameters.Add("Label", request.Label);
            }

            return parameters;
        }

        #endregion
    }
}
