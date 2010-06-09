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
 *  API Version: 2009-10-16
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

using Amazon.RDS.Model;

namespace Amazon.RDS
{
    /// <summary>
    /// AmazonRDSClient is an implementation of AmazonRDS
    /// Amazon Relational Database Service (Amazon RDS) is a web service that makes it easier to set up, operate, and scale a relational
    /// database in the cloud. It provides cost-efficient, resizable capacity for an industry-standard relational database and manages common
    /// database administration tasks, freeing up developers to focus on what makes their applications and businesses unique.
    /// Amazon RDS gives you access to the capabilities of a familiar MySQL database server. This means the code, applications, and tools you
    /// already use today with your existing MySQL databases work with Amazon RDS without modification. Amazon RDS automatically backs up your
    /// database and maintains the database software that powers your DB Instance. Amazon RDS is flexible: you can scale your database
    /// instance’s compute resources and storage capacity to meet your application’s demand. As with all Amazon Web Services, there are no
    /// up-front investments, and you pay only for the resources you use.
    /// </summary>
    public class AmazonRDSClient : AmazonRDS
    {
        private string awsAccessKeyId;
        private SecureString awsSecretAccessKey;
        private AmazonRDSConfig config;
        private bool disposed;

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern for the AmazonRDSClient
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
        ~AmazonRDSClient()
        {
            this.Dispose(false);
        }

        #endregion

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRDSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRDS Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="config">The AmazonRDS Configuration Object</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRDSConfig config)
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
        /// Constructs an AmazonRDSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRDS Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key as a SecureString</param>
        /// <param name="config">The AmazonRDS Configuration Object</param>
        public AmazonRDSClient(string awsAccessKeyId, SecureString awsSecretAccessKey, AmazonRDSConfig config)
        {
            this.awsAccessKeyId = awsAccessKeyId;
            this.awsSecretAccessKey = awsSecretAccessKey;
            this.config = config;
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.UseNagleAlgorithm = false;
        }

        #region Public API

        /// <summary>
        /// Delete DB Snapshot
        /// </summary>
        /// <param name="request">Delete DB Snapshot  request</param>
        /// <returns>Delete DB Snapshot  Response from the service</returns>
        /// <remarks>
        /// This API is used to delete a DBSnapshot. The DBSnapshot must be in the &quot;available&quot; state to be
        /// deleted.
        /// </remarks>
        public DeleteDBSnapshotResponse DeleteDBSnapshot(DeleteDBSnapshotRequest request)
        {
            return Invoke<DeleteDBSnapshotResponse>(ConvertDeleteDBSnapshot(request));
        }

        /// <summary>
        /// Describe DB Parameter Groups
        /// </summary>
        /// <param name="request">Describe DB Parameter Groups  request</param>
        /// <returns>Describe DB Parameter Groups  Response from the service</returns>
        /// <remarks>
        /// This API returns a list of DBParameterGroup descriptions. If a DBParameterGroupName is specified,
        /// the list will contain only the descriptions of the specified DBParameterGroup.
        /// </remarks>
        public DescribeDBParameterGroupsResponse DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request)
        {
            return Invoke<DescribeDBParameterGroupsResponse>(ConvertDescribeDBParameterGroups(request));
        }

        /// <summary>
        /// Delete DB Security Group
        /// </summary>
        /// <param name="request">Delete DB Security Group  request</param>
        /// <returns>Delete DB Security Group  Response from the service</returns>
        /// <remarks>
        /// This API deletes a database security group. Database security group must not be associated with any
        /// RDS Instances.
        /// </remarks>
        public DeleteDBSecurityGroupResponse DeleteDBSecurityGroup(DeleteDBSecurityGroupRequest request)
        {
            return Invoke<DeleteDBSecurityGroupResponse>(ConvertDeleteDBSecurityGroup(request));
        }

        /// <summary>
        /// Create DB Security Group
        /// </summary>
        /// <param name="request">Create DB Security Group  request</param>
        /// <returns>Create DB Security Group  Response from the service</returns>
        /// <remarks>
        /// This API creates a new database security group. Database Security groups control access to a database instance.
        /// </remarks>
        public CreateDBSecurityGroupResponse CreateDBSecurityGroup(CreateDBSecurityGroupRequest request)
        {
            return Invoke<CreateDBSecurityGroupResponse>(ConvertCreateDBSecurityGroup(request));
        }

        /// <summary>
        /// Restore DB Instance From DB Snapshot
        /// </summary>
        /// <param name="request">Restore DB Instance From DB Snapshot  request</param>
        /// <returns>Restore DB Instance From DB Snapshot  Response from the service</returns>
        /// <remarks>
        /// This API creates a new DB Instance to an arbitrary point-in-time. Users can restore to any point in
        /// time before the latestRestorableTime for up to backupRetentionPeriod days. The target database is created
        /// from the source database with the same configuration as the original database except that the DB instance
        /// is created with the default DB security group.
        /// </remarks>
        public RestoreDBInstanceFromDBSnapshotResponse RestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest request)
        {
            return Invoke<RestoreDBInstanceFromDBSnapshotResponse>(ConvertRestoreDBInstanceFromDBSnapshot(request));
        }

        /// <summary>
        /// Describe Events
        /// </summary>
        /// <param name="request">Describe Events  request</param>
        /// <returns>Describe Events  Response from the service</returns>
        /// <remarks>
        /// This API returns events related to DB Instances, DB Security Groups, DB Snapshots and DB Parameter
        /// Groups for the past 14 das. Events specific to a particular DB Instance, database security group,
        /// database snapshot or database parameter group can be obtained by providing the name as a parameter.
        /// By default, the past hour of events are returned.
        /// </remarks>
        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            return Invoke<DescribeEventsResponse>(ConvertDescribeEvents(request));
        }

        /// <summary>
        /// Delete DB Parameter Group
        /// </summary>
        /// <param name="request">Delete DB Parameter Group  request</param>
        /// <returns>Delete DB Parameter Group  Response from the service</returns>
        /// <remarks>
        /// This API deletes a particular DBParameterGroup. The DBParameterGroup cannot be associated with
        /// any RDS instances to be deleted.
        /// </remarks>
        public DeleteDBParameterGroupResponse DeleteDBParameterGroup(DeleteDBParameterGroupRequest request)
        {
            return Invoke<DeleteDBParameterGroupResponse>(ConvertDeleteDBParameterGroup(request));
        }

        /// <summary>
        /// Create DB Parameter Group
        /// </summary>
        /// <param name="request">Create DB Parameter Group  request</param>
        /// <returns>Create DB Parameter Group  Response from the service</returns>
        /// <remarks>
        /// This API creates a new database parameter group.
        /// </remarks>
        public CreateDBParameterGroupResponse CreateDBParameterGroup(CreateDBParameterGroupRequest request)
        {
            return Invoke<CreateDBParameterGroupResponse>(ConvertCreateDBParameterGroup(request));
        }

        /// <summary>
        /// Restore DB Instance To Point In Time
        /// </summary>
        /// <param name="request">Restore DB Instance To Point In Time  request</param>
        /// <returns>Restore DB Instance To Point In Time  Response from the service</returns>
        /// <remarks>
        /// This API creates a new RDS instance from a point-in-time system snapshot. The target database is created
        /// from the source database restore point with the same configuration as the original source database,
        /// except that the new RDS instance is created with the default security group.
        /// </remarks>
        public RestoreDBInstanceToPointInTimeResponse RestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest request)
        {
            return Invoke<RestoreDBInstanceToPointInTimeResponse>(ConvertRestoreDBInstanceToPointInTime(request));
        }

        /// <summary>
        /// Modify DB Instance
        /// </summary>
        /// <param name="request">Modify DB Instance  request</param>
        /// <returns>Modify DB Instance  Response from the service</returns>
        /// <remarks>
        /// This API is used to change RDS Instance settings. Users call the ModifyDBInstance API to change one
        /// or more database configuration parameters by specifying these parameters and the new values in the
        /// request.
        /// </remarks>
        public ModifyDBInstanceResponse ModifyDBInstance(ModifyDBInstanceRequest request)
        {
            return Invoke<ModifyDBInstanceResponse>(ConvertModifyDBInstance(request));
        }

        /// <summary>
        /// Revoke DB Security Group Ingress
        /// </summary>
        /// <param name="request">Revoke DB Security Group Ingress  request</param>
        /// <returns>Revoke DB Security Group Ingress  Response from the service</returns>
        /// <remarks>
        /// This API revokes ingress from a DBSecurityGroup for previously authorized IP ranges or EC2 Security
        /// Groups. Required parameters for this API are one of CIDRIP or (EC2SecurityGroupName AND
        /// EC2SecurityGroupOwnerId).
        /// </remarks>
        public RevokeDBSecurityGroupIngressResponse RevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest request)
        {
            return Invoke<RevokeDBSecurityGroupIngressResponse>(ConvertRevokeDBSecurityGroupIngress(request));
        }

        /// <summary>
        /// Authorize DB Security Group Ingress
        /// </summary>
        /// <param name="request">Authorize DB Security Group Ingress  request</param>
        /// <returns>Authorize DB Security Group Ingress  Response from the service</returns>
        /// <remarks>
        /// This API allows for ingress to a DBSecurityGroup using one of two forms of authorization. First,
        /// EC2 Security Groups can be added to the DBSecurityGroup if the application using the database
        /// is running on EC2 instances. Second, IP ranges are available if the application accessing your
        /// database is running on the Internet. Required parameters for this API are one of CIDR range or
        /// (EC2SecurityGroupName AND EC2SecurityGroupOwnerId).
        /// </remarks>
        public AuthorizeDBSecurityGroupIngressResponse AuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest request)
        {
            return Invoke<AuthorizeDBSecurityGroupIngressResponse>(ConvertAuthorizeDBSecurityGroupIngress(request));
        }

        /// <summary>
        /// Create DB Snapshot
        /// </summary>
        /// <param name="request">Create DB Snapshot  request</param>
        /// <returns>Create DB Snapshot  Response from the service</returns>
        /// <remarks>
        /// This API is used to create a DBSnapshot. The source DBInstance must be in &quot;available&quot; state.
        /// </remarks>
        public CreateDBSnapshotResponse CreateDBSnapshot(CreateDBSnapshotRequest request)
        {
            return Invoke<CreateDBSnapshotResponse>(ConvertCreateDBSnapshot(request));
        }

        /// <summary>
        /// Describe DB Snapshots
        /// </summary>
        /// <param name="request">Describe DB Snapshots  request</param>
        /// <returns>Describe DB Snapshots  Response from the service</returns>
        /// <remarks>
        /// This API is used to retrieve information about DBSnapshots. This API supports pagination.
        /// </remarks>
        public DescribeDBSnapshotsResponse DescribeDBSnapshots(DescribeDBSnapshotsRequest request)
        {
            return Invoke<DescribeDBSnapshotsResponse>(ConvertDescribeDBSnapshots(request));
        }

        /// <summary>
        /// Describe DB Instances
        /// </summary>
        /// <param name="request">Describe DB Instances  request</param>
        /// <returns>Describe DB Instances  Response from the service</returns>
        /// <remarks>
        /// This API is used to retrieve information about provisioned RDS instances. DescribeDBInstances
        /// supports pagination.
        /// </remarks>
        public DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest request)
        {
            return Invoke<DescribeDBInstancesResponse>(ConvertDescribeDBInstances(request));
        }

        /// <summary>
        /// Describe DB Security Groups
        /// </summary>
        /// <param name="request">Describe DB Security Groups  request</param>
        /// <returns>Describe DB Security Groups  Response from the service</returns>
        /// <remarks>
        /// This API returns a list of DBSecurityGroup descriptions. If a DBSecurityGroupName is specified,
        /// the list will contain only the descriptions of the specified DBSecurityGroup.
        /// </remarks>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest request)
        {
            return Invoke<DescribeDBSecurityGroupsResponse>(ConvertDescribeDBSecurityGroups(request));
        }

        /// <summary>
        /// Reset DB Parameter Group
        /// </summary>
        /// <param name="request">Reset DB Parameter Group  request</param>
        /// <returns>Reset DB Parameter Group  Response from the service</returns>
        /// <remarks>
        /// This API modifies the parameters of a DBParameterGroup to the engine/system default value. To
        /// reset specific parameters submit a list of the following: ParameterName and ApplyMethod. To reset the
        /// entire DBParameterGroup specify the DBParameterGroup name and ResetAllParameters parameters.
        /// When resetting the entire group, dynamic parameters are updated immediately and static parameters
        /// are set to pending-reboot to take effect on the next MySQL reboot or RebootDBInstance request.
        /// </remarks>
        public ResetDBParameterGroupResponse ResetDBParameterGroup(ResetDBParameterGroupRequest request)
        {
            return Invoke<ResetDBParameterGroupResponse>(ConvertResetDBParameterGroup(request));
        }

        /// <summary>
        /// Describe Engine Default Parameters
        /// </summary>
        /// <param name="request">Describe Engine Default Parameters  request</param>
        /// <returns>Describe Engine Default Parameters  Response from the service</returns>
        /// <remarks>
        /// This API returns the default engine and system parameter information for the specified database engine.
        /// </remarks>
        public DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request)
        {
            return Invoke<DescribeEngineDefaultParametersResponse>(ConvertDescribeEngineDefaultParameters(request));
        }

        /// <summary>
        /// Reboot DB Instance
        /// </summary>
        /// <param name="request">Reboot DB Instance  request</param>
        /// <returns>Reboot DB Instance  Response from the service</returns>
        /// <remarks>
        /// The RebootDBInstance API reboots a previously provisioned RDS instance. This API results in the
        /// application of modified DBParameterGroup parameters with ApplyStatus of pending-reboot to the
        /// RDS instance. This action is taken as soon as possible, and results in a momentary outage to the RDS
        /// instance during which the RDS instance status is set to rebooting. A DBInstance event is created
        /// when the reboot is completed.
        /// </remarks>
        public RebootDBInstanceResponse RebootDBInstance(RebootDBInstanceRequest request)
        {
            return Invoke<RebootDBInstanceResponse>(ConvertRebootDBInstance(request));
        }

        /// <summary>
        /// Describe DB Parameters
        /// </summary>
        /// <param name="request">Describe DB Parameters  request</param>
        /// <returns>Describe DB Parameters  Response from the service</returns>
        /// <remarks>
        /// This API returns the detailed parameter list for a particular DBParameterGroup.
        /// </remarks>
        public DescribeDBParametersResponse DescribeDBParameters(DescribeDBParametersRequest request)
        {
            return Invoke<DescribeDBParametersResponse>(ConvertDescribeDBParameters(request));
        }

        /// <summary>
        /// Delete DB Instance
        /// </summary>
        /// <param name="request">Delete DB Instance  request</param>
        /// <returns>Delete DB Instance  Response from the service</returns>
        /// <remarks>
        /// The DeleteDBInstance API deletes a previously provisioned RDS instance. A successful response
        /// from the web service indicates the request was received correctly. If a final DBSnapshot is requested
        /// the status of the RDS instance will be &quot;deleting&quot; until the DBSnapshot is created. DescribeDBInstance
        /// is used to monitor the status of this operation. This cannot be canceled or reverted once submitted.
        /// </remarks>
        public DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest request)
        {
            return Invoke<DeleteDBInstanceResponse>(ConvertDeleteDBInstance(request));
        }

        /// <summary>
        /// Create DB Instance
        /// </summary>
        /// <param name="request">Create DB Instance  request</param>
        /// <returns>Create DB Instance  Response from the service</returns>
        /// <remarks>
        /// This API creates a new DB instance.
        /// </remarks>
        public CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest request)
        {
            return Invoke<CreateDBInstanceResponse>(ConvertCreateDBInstance(request));
        }

        /// <summary>
        /// Modify DB Parameter Group
        /// </summary>
        /// <param name="request">Modify DB Parameter Group  request</param>
        /// <returns>Modify DB Parameter Group  Response from the service</returns>
        /// <remarks>
        /// This API modifies the parameters of a DBParameterGroup. To modify more than one parameter
        /// submit a list of the following: ParameterName, ParameterValue, and ApplyMethod. A maximum of 20
        /// parameters can be modified in a single request.
        /// </remarks>
        public ModifyDBParameterGroupResponse ModifyDBParameterGroup(ModifyDBParameterGroupRequest request)
        {
            return Invoke<ModifyDBParameterGroupResponse>(ConvertModifyDBParameterGroup(request));
        }

        #endregion

        #region Private API

        /**
         * Configure HttpClient with set of defaults as well as configuration
         * from AmazonRDSConfig instance
         */
        private static HttpWebRequest ConfigureWebRequest(int contentLength, AmazonRDSConfig config)
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
                            throw new AmazonRDSException(we);
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
                                throw new AmazonRDSException(
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
                            if (e is AmazonRDSException)
                            {
                                throw;
                            }
                            else
                            {
                                AmazonRDSException se = ReportAnyErrors(responseBody, statusCode);
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
        private static AmazonRDSException ReportAnyErrors(string responseBody, HttpStatusCode status)
        {
            AmazonRDSException ex = null;

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

                    ex = new AmazonRDSException(message, status, code, "Unknown", requestId, responseBody);
                }
                else if (errorMatcherTwo.Success)
                {
                    string code = errorMatcherTwo.Groups[1].Value;
                    string message = errorMatcherTwo.Groups[2].Value;
                    string requestId = errorMatcherTwo.Groups[4].Value;

                    ex = new AmazonRDSException(message, status, code, "Unknown", requestId, responseBody);
                }
                else
                {
                    ex = new AmazonRDSException("Internal Error", status);
                }
            }
            else
            {
                ex = new AmazonRDSException("Internal Error", status);
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
                throw new AmazonRDSException("Maximum number of retry attempts reached : " + (retries - 1), status);
            }
        }

        /**
         * Add authentication related and version parameters
         */
        private void AddRequiredParameters(IDictionary<string, string> parameters)
        {
            if (String.IsNullOrEmpty(this.awsAccessKeyId))
            {
                throw new AmazonRDSException("The AWS Access Key ID cannot be NULL or a Zero length string");
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
        private static string SignParameters(IDictionary<string, string> parameters, SecureString key, AmazonRDSConfig config)
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
                throw new AmazonRDSException("Invalid Signature Version specified");
            }

            return Sign(stringToSign, key, algorithm);
        }

        private static string CalculateStringToSignV2(IDictionary<string, string> parameters, AmazonRDSConfig config)
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
        /// <exception cref="T:Amazon.RDS.AmazonRDSException"></exception>
        /// <returns>A string representing the HMAC signature</returns>
        private static string Sign(string data, System.Security.SecureString key, KeyedHashAlgorithm algorithm)
        {
            if (key == null)
            {
                throw new AmazonRDSException("The AWS Secret Access Key specified is NULL");
            }

            return AWSSDKUtils.HMACSign(data, key, algorithm);
        }

        /**
         * Convert DeleteDBSnapshotRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteDBSnapshot(DeleteDBSnapshotRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DeleteDBSnapshot");
            if (request.IsSetDBSnapshotIdentifier())
            {
                parameters.Add("DBSnapshotIdentifier", request.DBSnapshotIdentifier);
            }

            return parameters;
        }

        /**
         * Convert DescribeDBParameterGroupsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeDBParameterGroups(DescribeDBParameterGroupsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DescribeDBParameterGroups");
            if (request.IsSetDBParameterGroupName())
            {
                parameters.Add("DBParameterGroupName", request.DBParameterGroupName);
            }
            if (request.IsSetMaxRecords())
            {
                parameters.Add("MaxRecords", (request.MaxRecords + ""));
            }
            if (request.IsSetMarker())
            {
                parameters.Add("Marker", request.Marker);
            }

            return parameters;
        }

        /**
         * Convert DeleteDBSecurityGroupRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteDBSecurityGroup(DeleteDBSecurityGroupRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DeleteDBSecurityGroup");
            if (request.IsSetDBSecurityGroupName())
            {
                parameters.Add("DBSecurityGroupName", request.DBSecurityGroupName);
            }

            return parameters;
        }

        /**
         * Convert CreateDBSecurityGroupRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateDBSecurityGroup(CreateDBSecurityGroupRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "CreateDBSecurityGroup");
            if (request.IsSetDBSecurityGroupName())
            {
                parameters.Add("DBSecurityGroupName", request.DBSecurityGroupName);
            }
            if (request.IsSetDBSecurityGroupDescription())
            {
                parameters.Add("DBSecurityGroupDescription", request.DBSecurityGroupDescription);
            }

            return parameters;
        }

        /**
         * Convert RestoreDBInstanceFromDBSnapshotRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertRestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "RestoreDBInstanceFromDBSnapshot");
            if (request.IsSetDBInstanceIdentifier())
            {
                parameters.Add("DBInstanceIdentifier", request.DBInstanceIdentifier);
            }
            if (request.IsSetDBSnapshotIdentifier())
            {
                parameters.Add("DBSnapshotIdentifier", request.DBSnapshotIdentifier);
            }
            if (request.IsSetDBInstanceClass())
            {
                parameters.Add("DBInstanceClass", request.DBInstanceClass);
            }
            if (request.IsSetPort())
            {
                parameters.Add("Port", (request.Port + ""));
            }
            if (request.IsSetAvailabilityZone())
            {
                parameters.Add("AvailabilityZone", request.AvailabilityZone);
            }

            return parameters;
        }

        /**
         * Convert DescribeEventsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeEvents(DescribeEventsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DescribeEvents");
            if (request.IsSetSourceIdentifier())
            {
                parameters.Add("SourceIdentifier", request.SourceIdentifier);
            }
            if (request.IsSetSourceType())
            {
                parameters.Add("SourceType", request.SourceType);
            }
            if (request.IsSetStartTime())
            {
                parameters.Add("StartTime", (request.StartTime + ""));
            }
            if (request.IsSetEndTime())
            {
                parameters.Add("EndTime", (request.EndTime + ""));
            }
            if (request.IsSetDuration())
            {
                parameters.Add("Duration", (request.Duration + ""));
            }
            if (request.IsSetMaxRecords())
            {
                parameters.Add("MaxRecords", (request.MaxRecords + ""));
            }
            if (request.IsSetMarker())
            {
                parameters.Add("Marker", request.Marker);
            }

            return parameters;
        }

        /**
         * Convert DeleteDBParameterGroupRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteDBParameterGroup(DeleteDBParameterGroupRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DeleteDBParameterGroup");
            if (request.IsSetDBParameterGroupName())
            {
                parameters.Add("DBParameterGroupName", request.DBParameterGroupName);
            }

            return parameters;
        }

        /**
         * Convert CreateDBParameterGroupRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateDBParameterGroup(CreateDBParameterGroupRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "CreateDBParameterGroup");
            if (request.IsSetDBParameterGroupName())
            {
                parameters.Add("DBParameterGroupName", request.DBParameterGroupName);
            }
            if (request.IsSetEngine())
            {
                parameters.Add("Engine", request.Engine);
            }
            if (request.IsSetDescription())
            {
                parameters.Add("Description", request.Description);
            }

            return parameters;
        }

        /**
         * Convert RestoreDBInstanceToPointInTimeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertRestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "RestoreDBInstanceToPointInTime");
            if (request.IsSetSourceDBInstanceIdentifier())
            {
                parameters.Add("SourceDBInstanceIdentifier", request.SourceDBInstanceIdentifier);
            }
            if (request.IsSetTargetDBInstanceIdentifier())
            {
                parameters.Add("TargetDBInstanceIdentifier", request.TargetDBInstanceIdentifier);
            }
            if (request.IsSetRestoreTime())
            {
                parameters.Add("RestoreTime", (request.RestoreTime + ""));
            }
            if (request.IsSetUseLatestRestorableTime())
            {
                parameters.Add("UseLatestRestorableTime", (request.UseLatestRestorableTime + "").ToLower());
            }
            if (request.IsSetDBInstanceClass())
            {
                parameters.Add("DBInstanceClass", request.DBInstanceClass);
            }
            if (request.IsSetPort())
            {
                parameters.Add("Port", (request.Port + ""));
            }
            if (request.IsSetAvailabilityZone())
            {
                parameters.Add("AvailabilityZone", request.AvailabilityZone);
            }

            return parameters;
        }

        /**
         * Convert ModifyDBInstanceRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertModifyDBInstance(ModifyDBInstanceRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "ModifyDBInstance");
            if (request.IsSetDBInstanceIdentifier())
            {
                parameters.Add("DBInstanceIdentifier", request.DBInstanceIdentifier);
            }
            if (request.IsSetAllocatedStorage())
            {
                parameters.Add("AllocatedStorage", (request.AllocatedStorage + ""));
            }
            if (request.IsSetDBInstanceClass())
            {
                parameters.Add("DBInstanceClass", request.DBInstanceClass);
            }
            List<string> modifyDBInstanceRequestDBSecurityGroupsList  =  request.DBSecurityGroups;
            int modifyDBInstanceRequestDBSecurityGroupsListIndex = 1;
            foreach  (string modifyDBInstanceRequestDBSecurityGroups in modifyDBInstanceRequestDBSecurityGroupsList)
            {
                parameters.Add("DBSecurityGroups" + ".member."  + modifyDBInstanceRequestDBSecurityGroupsListIndex, modifyDBInstanceRequestDBSecurityGroups);
                modifyDBInstanceRequestDBSecurityGroupsListIndex++;
            }
            if (request.IsSetApplyImmediately())
            {
                parameters.Add("ApplyImmediately", (request.ApplyImmediately + "").ToLower());
            }
            if (request.IsSetMasterUserPassword())
            {
                parameters.Add("MasterUserPassword", request.MasterUserPassword);
            }
            if (request.IsSetDBParameterGroupName())
            {
                parameters.Add("DBParameterGroupName", request.DBParameterGroupName);
            }
            if (request.IsSetBackupRetentionPeriod())
            {
                parameters.Add("BackupRetentionPeriod", (request.BackupRetentionPeriod + ""));
            }
            if (request.IsSetPreferredBackupWindow())
            {
                parameters.Add("PreferredBackupWindow", request.PreferredBackupWindow);
            }
            if (request.IsSetPreferredMaintenanceWindow())
            {
                parameters.Add("PreferredMaintenanceWindow", request.PreferredMaintenanceWindow);
            }

            return parameters;
        }

        /**
         * Convert RevokeDBSecurityGroupIngressRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertRevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "RevokeDBSecurityGroupIngress");
            if (request.IsSetDBSecurityGroupName())
            {
                parameters.Add("DBSecurityGroupName", request.DBSecurityGroupName);
            }
            if (request.IsSetCIDRIP())
            {
                parameters.Add("CIDRIP", request.CIDRIP);
            }
            if (request.IsSetEC2SecurityGroupName())
            {
                parameters.Add("EC2SecurityGroupName", request.EC2SecurityGroupName);
            }
            if (request.IsSetEC2SecurityGroupOwnerId())
            {
                parameters.Add("EC2SecurityGroupOwnerId", request.EC2SecurityGroupOwnerId);
            }

            return parameters;
        }

        /**
         * Convert AuthorizeDBSecurityGroupIngressRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertAuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "AuthorizeDBSecurityGroupIngress");
            if (request.IsSetDBSecurityGroupName())
            {
                parameters.Add("DBSecurityGroupName", request.DBSecurityGroupName);
            }
            if (request.IsSetCIDRIP())
            {
                parameters.Add("CIDRIP", request.CIDRIP);
            }
            if (request.IsSetEC2SecurityGroupName())
            {
                parameters.Add("EC2SecurityGroupName", request.EC2SecurityGroupName);
            }
            if (request.IsSetEC2SecurityGroupOwnerId())
            {
                parameters.Add("EC2SecurityGroupOwnerId", request.EC2SecurityGroupOwnerId);
            }

            return parameters;
        }

        /**
         * Convert CreateDBSnapshotRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateDBSnapshot(CreateDBSnapshotRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "CreateDBSnapshot");
            if (request.IsSetDBSnapshotIdentifier())
            {
                parameters.Add("DBSnapshotIdentifier", request.DBSnapshotIdentifier);
            }
            if (request.IsSetDBInstanceIdentifier())
            {
                parameters.Add("DBInstanceIdentifier", request.DBInstanceIdentifier);
            }

            return parameters;
        }

        /**
         * Convert DescribeDBSnapshotsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeDBSnapshots(DescribeDBSnapshotsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DescribeDBSnapshots");
            if (request.IsSetDBInstanceIdentifier())
            {
                parameters.Add("DBInstanceIdentifier", request.DBInstanceIdentifier);
            }
            if (request.IsSetDBSnapshotIdentifier())
            {
                parameters.Add("DBSnapshotIdentifier", request.DBSnapshotIdentifier);
            }
            if (request.IsSetMaxRecords())
            {
                parameters.Add("MaxRecords", (request.MaxRecords + ""));
            }
            if (request.IsSetMarker())
            {
                parameters.Add("Marker", request.Marker);
            }

            return parameters;
        }

        /**
         * Convert DescribeDBInstancesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeDBInstances(DescribeDBInstancesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DescribeDBInstances");
            if (request.IsSetDBInstanceIdentifier())
            {
                parameters.Add("DBInstanceIdentifier", request.DBInstanceIdentifier);
            }
            if (request.IsSetMaxRecords())
            {
                parameters.Add("MaxRecords", (request.MaxRecords + ""));
            }
            if (request.IsSetMarker())
            {
                parameters.Add("Marker", request.Marker);
            }

            return parameters;
        }

        /**
         * Convert DescribeDBSecurityGroupsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DescribeDBSecurityGroups");
            if (request.IsSetDBSecurityGroupName())
            {
                parameters.Add("DBSecurityGroupName", request.DBSecurityGroupName);
            }
            if (request.IsSetMaxRecords())
            {
                parameters.Add("MaxRecords", (request.MaxRecords + ""));
            }
            if (request.IsSetMarker())
            {
                parameters.Add("Marker", request.Marker);
            }

            return parameters;
        }

        /**
         * Convert ResetDBParameterGroupRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertResetDBParameterGroup(ResetDBParameterGroupRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "ResetDBParameterGroup");
            if (request.IsSetDBParameterGroupName())
            {
                parameters.Add("DBParameterGroupName", request.DBParameterGroupName);
            }
            if (request.IsSetResetAllParameters())
            {
                parameters.Add("ResetAllParameters", (request.ResetAllParameters + "").ToLower());
            }
            List<Parameter> resetDBParameterGroupRequestParametersList = request.Parameters;
            int resetDBParameterGroupRequestParametersListIndex = 1;
            foreach (Parameter resetDBParameterGroupRequestParameters in resetDBParameterGroupRequestParametersList)
            {
                if (resetDBParameterGroupRequestParameters.IsSetParameterName())
                {
                    parameters.Add("Parameters" + ".member."  + resetDBParameterGroupRequestParametersListIndex + "." + "ParameterName", resetDBParameterGroupRequestParameters.ParameterName);
                }
                if (resetDBParameterGroupRequestParameters.IsSetParameterValue())
                {
                    parameters.Add("Parameters" + ".member."  + resetDBParameterGroupRequestParametersListIndex + "." + "ParameterValue", resetDBParameterGroupRequestParameters.ParameterValue);
                }
                if (resetDBParameterGroupRequestParameters.IsSetDescription())
                {
                    parameters.Add("Parameters" + ".member."  + resetDBParameterGroupRequestParametersListIndex + "." + "Description", resetDBParameterGroupRequestParameters.Description);
                }
                if (resetDBParameterGroupRequestParameters.IsSetSource())
                {
                    parameters.Add("Parameters" + ".member."  + resetDBParameterGroupRequestParametersListIndex + "." + "Source", resetDBParameterGroupRequestParameters.Source);
                }
                if (resetDBParameterGroupRequestParameters.IsSetApplyType())
                {
                    parameters.Add("Parameters" + ".member."  + resetDBParameterGroupRequestParametersListIndex + "." + "ApplyType", resetDBParameterGroupRequestParameters.ApplyType);
                }
                if (resetDBParameterGroupRequestParameters.IsSetDataType())
                {
                    parameters.Add("Parameters" + ".member."  + resetDBParameterGroupRequestParametersListIndex + "." + "DataType", resetDBParameterGroupRequestParameters.DataType);
                }
                if (resetDBParameterGroupRequestParameters.IsSetAllowedValues())
                {
                    parameters.Add("Parameters" + ".member."  + resetDBParameterGroupRequestParametersListIndex + "." + "AllowedValues", resetDBParameterGroupRequestParameters.AllowedValues);
                }
                if (resetDBParameterGroupRequestParameters.IsSetIsModifiable())
                {
                    parameters.Add("Parameters" + ".member."  + resetDBParameterGroupRequestParametersListIndex + "." + "IsModifiable", (resetDBParameterGroupRequestParameters.IsModifiable + "").ToLower());
                }
                if (resetDBParameterGroupRequestParameters.IsSetApplyMethod())
                {
                    parameters.Add("Parameters" + ".member."  + resetDBParameterGroupRequestParametersListIndex + "." + "ApplyMethod", resetDBParameterGroupRequestParameters.ApplyMethod);
                }

                resetDBParameterGroupRequestParametersListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DescribeEngineDefaultParametersRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DescribeEngineDefaultParameters");
            if (request.IsSetEngine())
            {
                parameters.Add("Engine", request.Engine);
            }
            if (request.IsSetMaxRecords())
            {
                parameters.Add("MaxRecords", (request.MaxRecords + ""));
            }
            if (request.IsSetMarker())
            {
                parameters.Add("Marker", request.Marker);
            }

            return parameters;
        }

        /**
         * Convert RebootDBInstanceRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertRebootDBInstance(RebootDBInstanceRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "RebootDBInstance");
            if (request.IsSetDBInstanceIdentifier())
            {
                parameters.Add("DBInstanceIdentifier", request.DBInstanceIdentifier);
            }

            return parameters;
        }

        /**
         * Convert DescribeDBParametersRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDescribeDBParameters(DescribeDBParametersRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DescribeDBParameters");
            if (request.IsSetDBParameterGroupName())
            {
                parameters.Add("DBParameterGroupName", request.DBParameterGroupName);
            }
            if (request.IsSetSource())
            {
                parameters.Add("Source", request.Source);
            }
            if (request.IsSetMaxRecords())
            {
                parameters.Add("MaxRecords", (request.MaxRecords + ""));
            }
            if (request.IsSetMarker())
            {
                parameters.Add("Marker", request.Marker);
            }

            return parameters;
        }

        /**
         * Convert DeleteDBInstanceRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteDBInstance(DeleteDBInstanceRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "DeleteDBInstance");
            if (request.IsSetDBInstanceIdentifier())
            {
                parameters.Add("DBInstanceIdentifier", request.DBInstanceIdentifier);
            }
            if (request.IsSetSkipFinalSnapshot())
            {
                parameters.Add("SkipFinalSnapshot", (request.SkipFinalSnapshot + "").ToLower());
            }
            if (request.IsSetFinalDBSnapshotIdentifier())
            {
                parameters.Add("FinalDBSnapshotIdentifier", request.FinalDBSnapshotIdentifier);
            }

            return parameters;
        }

        /**
         * Convert CreateDBInstanceRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateDBInstance(CreateDBInstanceRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "CreateDBInstance");
            if (request.IsSetDBName())
            {
                parameters.Add("DBName", request.DBName);
            }
            if (request.IsSetDBInstanceIdentifier())
            {
                parameters.Add("DBInstanceIdentifier", request.DBInstanceIdentifier);
            }
            if (request.IsSetAllocatedStorage())
            {
                parameters.Add("AllocatedStorage", (request.AllocatedStorage + ""));
            }
            if (request.IsSetDBInstanceClass())
            {
                parameters.Add("DBInstanceClass", request.DBInstanceClass);
            }
            if (request.IsSetEngine())
            {
                parameters.Add("Engine", request.Engine);
            }
            if (request.IsSetMasterUsername())
            {
                parameters.Add("MasterUsername", request.MasterUsername);
            }
            if (request.IsSetMasterUserPassword())
            {
                parameters.Add("MasterUserPassword", request.MasterUserPassword);
            }
            List<string> createDBInstanceRequestDBSecurityGroupsList  =  request.DBSecurityGroups;
            int createDBInstanceRequestDBSecurityGroupsListIndex = 1;
            foreach  (string createDBInstanceRequestDBSecurityGroups in createDBInstanceRequestDBSecurityGroupsList)
            {
                parameters.Add("DBSecurityGroups" + ".member."  + createDBInstanceRequestDBSecurityGroupsListIndex, createDBInstanceRequestDBSecurityGroups);
                createDBInstanceRequestDBSecurityGroupsListIndex++;
            }
            if (request.IsSetAvailabilityZone())
            {
                parameters.Add("AvailabilityZone", request.AvailabilityZone);
            }
            if (request.IsSetPreferredMaintenanceWindow())
            {
                parameters.Add("PreferredMaintenanceWindow", request.PreferredMaintenanceWindow);
            }
            if (request.IsSetDBParameterGroupName())
            {
                parameters.Add("DBParameterGroupName", request.DBParameterGroupName);
            }
            if (request.IsSetBackupRetentionPeriod())
            {
                parameters.Add("BackupRetentionPeriod", (request.BackupRetentionPeriod + ""));
            }
            if (request.IsSetPreferredBackupWindow())
            {
                parameters.Add("PreferredBackupWindow", request.PreferredBackupWindow);
            }
            if (request.IsSetPort())
            {
                parameters.Add("Port", (request.Port + ""));
            }

            return parameters;
        }

        /**
         * Convert ModifyDBParameterGroupRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertModifyDBParameterGroup(ModifyDBParameterGroupRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("Action", "ModifyDBParameterGroup");
            if (request.IsSetDBParameterGroupName())
            {
                parameters.Add("DBParameterGroupName", request.DBParameterGroupName);
            }
            List<Parameter> modifyDBParameterGroupRequestParametersList = request.Parameters;
            int modifyDBParameterGroupRequestParametersListIndex = 1;
            foreach (Parameter modifyDBParameterGroupRequestParameters in modifyDBParameterGroupRequestParametersList)
            {
                if (modifyDBParameterGroupRequestParameters.IsSetParameterName())
                {
                    parameters.Add("Parameters" + ".member."  + modifyDBParameterGroupRequestParametersListIndex + "." + "ParameterName", modifyDBParameterGroupRequestParameters.ParameterName);
                }
                if (modifyDBParameterGroupRequestParameters.IsSetParameterValue())
                {
                    parameters.Add("Parameters" + ".member."  + modifyDBParameterGroupRequestParametersListIndex + "." + "ParameterValue", modifyDBParameterGroupRequestParameters.ParameterValue);
                }
                if (modifyDBParameterGroupRequestParameters.IsSetDescription())
                {
                    parameters.Add("Parameters" + ".member."  + modifyDBParameterGroupRequestParametersListIndex + "." + "Description", modifyDBParameterGroupRequestParameters.Description);
                }
                if (modifyDBParameterGroupRequestParameters.IsSetSource())
                {
                    parameters.Add("Parameters" + ".member."  + modifyDBParameterGroupRequestParametersListIndex + "." + "Source", modifyDBParameterGroupRequestParameters.Source);
                }
                if (modifyDBParameterGroupRequestParameters.IsSetApplyType())
                {
                    parameters.Add("Parameters" + ".member."  + modifyDBParameterGroupRequestParametersListIndex + "." + "ApplyType", modifyDBParameterGroupRequestParameters.ApplyType);
                }
                if (modifyDBParameterGroupRequestParameters.IsSetDataType())
                {
                    parameters.Add("Parameters" + ".member."  + modifyDBParameterGroupRequestParametersListIndex + "." + "DataType", modifyDBParameterGroupRequestParameters.DataType);
                }
                if (modifyDBParameterGroupRequestParameters.IsSetAllowedValues())
                {
                    parameters.Add("Parameters" + ".member."  + modifyDBParameterGroupRequestParametersListIndex + "." + "AllowedValues", modifyDBParameterGroupRequestParameters.AllowedValues);
                }
                if (modifyDBParameterGroupRequestParameters.IsSetIsModifiable())
                {
                    parameters.Add("Parameters" + ".member."  + modifyDBParameterGroupRequestParametersListIndex + "." + "IsModifiable", (modifyDBParameterGroupRequestParameters.IsModifiable + "").ToLower());
                }
                if (modifyDBParameterGroupRequestParameters.IsSetApplyMethod())
                {
                    parameters.Add("Parameters" + ".member."  + modifyDBParameterGroupRequestParametersListIndex + "." + "ApplyMethod", modifyDBParameterGroupRequestParameters.ApplyMethod);
                }

                modifyDBParameterGroupRequestParametersListIndex++;
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
