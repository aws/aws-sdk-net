/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.SecurityLake.Model;
using Amazon.SecurityLake.Model.Internal.MarshallTransformations;
using Amazon.SecurityLake.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.SecurityLake
{
    /// <summary>
    /// <para>Implementation for accessing SecurityLake</para>
    ///
    /// Amazon Security Lake is a fully managed security data lake service. You can use Security
    /// Lake to automatically centralize security data from cloud, on-premises, and custom
    /// sources into a data lake that's stored in your Amazon Web Services account. Amazon
    /// Web Services Organizations is an account management service that lets you consolidate
    /// multiple Amazon Web Services accounts into an organization that you create and centrally
    /// manage. With Organizations, you can create member accounts and invite existing accounts
    /// to join your organization. Security Lake helps you analyze security data for a more
    /// complete understanding of your security posture across the entire organization. It
    /// can also help you improve the protection of your workloads, applications, and data.
    /// 
    ///  
    /// <para>
    /// The data lake is backed by Amazon Simple Storage Service (Amazon S3) buckets, and
    /// you retain ownership over your data.
    /// </para>
    ///  
    /// <para>
    /// Amazon Security Lake integrates with CloudTrail, a service that provides a record
    /// of actions taken by a user, role, or an Amazon Web Services service. In Security Lake,
    /// CloudTrail captures API calls for Security Lake as events. The calls captured include
    /// calls from the Security Lake console and code calls to the Security Lake API operations.
    /// If you create a trail, you can enable continuous delivery of CloudTrail events to
    /// an Amazon S3 bucket, including events for Security Lake. If you don't configure a
    /// trail, you can still view the most recent events in the CloudTrail console in Event
    /// history. Using the information collected by CloudTrail you can determine the request
    /// that was made to Security Lake, the IP address from which the request was made, who
    /// made the request, when it was made, and additional details. To learn more about Security
    /// Lake information in CloudTrail, see the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/securitylake-cloudtrail.html">Amazon
    /// Security Lake User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// Security Lake automates the collection of security-related log and event data from
    /// integrated Amazon Web Services services and third-party services. It also helps you
    /// manage the lifecycle of data with customizable retention and replication settings.
    /// Security Lake converts ingested data into Apache Parquet format and a standard open-source
    /// schema called the Open Cybersecurity Schema Framework (OCSF).
    /// </para>
    ///  
    /// <para>
    /// Other Amazon Web Services services and third-party services can subscribe to the data
    /// that's stored in Security Lake for incident response and security data analytics.
    /// </para>
    /// </summary>
    public partial class AmazonSecurityLakeClient : AmazonServiceClient, IAmazonSecurityLake
    {
        private static IServiceMetadata serviceMetadata = new AmazonSecurityLakeMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ISecurityLakePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISecurityLakePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SecurityLakePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonSecurityLakeClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSecurityLakeClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSecurityLakeConfig()) { }

        /// <summary>
        /// Constructs AmazonSecurityLakeClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityLakeClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSecurityLakeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSecurityLakeClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonSecurityLakeClient Configuration Object</param>
        public AmazonSecurityLakeClient(AmazonSecurityLakeConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonSecurityLakeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSecurityLakeClient(AWSCredentials credentials)
            : this(credentials, new AmazonSecurityLakeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityLakeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityLakeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSecurityLakeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityLakeClient with AWS Credentials and an
        /// AmazonSecurityLakeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSecurityLakeClient Configuration Object</param>
        public AmazonSecurityLakeClient(AWSCredentials credentials, AmazonSecurityLakeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityLakeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSecurityLakeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityLakeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityLakeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityLakeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityLakeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityLakeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityLakeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSecurityLakeClient Configuration Object</param>
        public AmazonSecurityLakeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSecurityLakeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityLakeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSecurityLakeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecurityLakeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityLakeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityLakeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecurityLakeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityLakeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityLakeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSecurityLakeClient Configuration Object</param>
        public AmazonSecurityLakeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSecurityLakeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSecurityLakeEndpointResolver());
        }
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CreateAwsLogSource

        /// <summary>
        /// Adds a natively supported Amazon Web Services service as an Amazon Security Lake source.
        /// Enables source types for member accounts in required Amazon Web Services Regions,
        /// based on the parameters you specify. You can choose any source type in any Region
        /// for either accounts that are part of a trusted organization or standalone accounts.
        /// Once you add an Amazon Web Services service as a source, Security Lake starts collecting
        /// logs and events from it.
        /// 
        ///  
        /// <para>
        /// You can use this API only to enable natively supported Amazon Web Services services
        /// as a source. Use <c>CreateCustomLogSource</c> to enable data collection from a custom
        /// source.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAwsLogSource service method.</param>
        /// 
        /// <returns>The response from the CreateAwsLogSource service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateAwsLogSource">REST API Reference for CreateAwsLogSource Operation</seealso>
        public virtual CreateAwsLogSourceResponse CreateAwsLogSource(CreateAwsLogSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAwsLogSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAwsLogSourceResponseUnmarshaller.Instance;

            return Invoke<CreateAwsLogSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAwsLogSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAwsLogSource operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAwsLogSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateAwsLogSource">REST API Reference for CreateAwsLogSource Operation</seealso>
        public virtual IAsyncResult BeginCreateAwsLogSource(CreateAwsLogSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAwsLogSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAwsLogSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAwsLogSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAwsLogSource.</param>
        /// 
        /// <returns>Returns a  CreateAwsLogSourceResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateAwsLogSource">REST API Reference for CreateAwsLogSource Operation</seealso>
        public virtual CreateAwsLogSourceResponse EndCreateAwsLogSource(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAwsLogSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCustomLogSource

        /// <summary>
        /// Adds a third-party custom source in Amazon Security Lake, from the Amazon Web Services
        /// Region where you want to create a custom source. Security Lake can collect logs and
        /// events from third-party custom sources. After creating the appropriate IAM role to
        /// invoke Glue crawler, use this API to add a custom source name in Security Lake. This
        /// operation creates a partition in the Amazon S3 bucket for Security Lake as the target
        /// location for log files from the custom source. In addition, this operation also creates
        /// an associated Glue table and an Glue crawler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomLogSource service method.</param>
        /// 
        /// <returns>The response from the CreateCustomLogSource service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateCustomLogSource">REST API Reference for CreateCustomLogSource Operation</seealso>
        public virtual CreateCustomLogSourceResponse CreateCustomLogSource(CreateCustomLogSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomLogSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomLogSourceResponseUnmarshaller.Instance;

            return Invoke<CreateCustomLogSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomLogSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomLogSource operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomLogSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateCustomLogSource">REST API Reference for CreateCustomLogSource Operation</seealso>
        public virtual IAsyncResult BeginCreateCustomLogSource(CreateCustomLogSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomLogSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomLogSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomLogSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomLogSource.</param>
        /// 
        /// <returns>Returns a  CreateCustomLogSourceResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateCustomLogSource">REST API Reference for CreateCustomLogSource Operation</seealso>
        public virtual CreateCustomLogSourceResponse EndCreateCustomLogSource(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCustomLogSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataLake

        /// <summary>
        /// Initializes an Amazon Security Lake instance with the provided (or default) configuration.
        /// You can enable Security Lake in Amazon Web Services Regions with customized settings
        /// before enabling log collection in Regions. To specify particular Regions, configure
        /// these Regions using the <c>configurations</c> parameter. If you have already enabled
        /// Security Lake in a Region when you call this command, the command will update the
        /// Region if you provide new configuration parameters. If you have not already enabled
        /// Security Lake in the Region when you call this API, it will set up the data lake in
        /// the Region with the specified configurations.
        /// 
        ///  
        /// <para>
        /// When you enable Security Lake, it starts ingesting security data after the <c>CreateAwsLogSource</c>
        /// call and after you create subscribers using the <c>CreateSubscriber</c> API. This
        /// includes ingesting security data from sources, storing data, and making data accessible
        /// to subscribers. Security Lake also enables all the existing settings and resources
        /// that it stores or maintains for your Amazon Web Services account in the current Region,
        /// including security log and event data. For more information, see the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/what-is-security-lake.html">Amazon
        /// Security Lake User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataLake service method.</param>
        /// 
        /// <returns>The response from the CreateDataLake service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDataLake">REST API Reference for CreateDataLake Operation</seealso>
        public virtual CreateDataLakeResponse CreateDataLake(CreateDataLakeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataLakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataLakeResponseUnmarshaller.Instance;

            return Invoke<CreateDataLakeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataLake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataLake operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataLake
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDataLake">REST API Reference for CreateDataLake Operation</seealso>
        public virtual IAsyncResult BeginCreateDataLake(CreateDataLakeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataLakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataLakeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataLake operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataLake.</param>
        /// 
        /// <returns>Returns a  CreateDataLakeResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDataLake">REST API Reference for CreateDataLake Operation</seealso>
        public virtual CreateDataLakeResponse EndCreateDataLake(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataLakeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataLakeExceptionSubscription

        /// <summary>
        /// Creates the specified notification subscription in Amazon Security Lake for the organization
        /// you specify. The notification subscription is created for exceptions that cannot be
        /// resolved by Security Lake automatically.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataLakeExceptionSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateDataLakeExceptionSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDataLakeExceptionSubscription">REST API Reference for CreateDataLakeExceptionSubscription Operation</seealso>
        public virtual CreateDataLakeExceptionSubscriptionResponse CreateDataLakeExceptionSubscription(CreateDataLakeExceptionSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataLakeExceptionSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataLakeExceptionSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateDataLakeExceptionSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataLakeExceptionSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataLakeExceptionSubscription operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataLakeExceptionSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDataLakeExceptionSubscription">REST API Reference for CreateDataLakeExceptionSubscription Operation</seealso>
        public virtual IAsyncResult BeginCreateDataLakeExceptionSubscription(CreateDataLakeExceptionSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataLakeExceptionSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataLakeExceptionSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataLakeExceptionSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataLakeExceptionSubscription.</param>
        /// 
        /// <returns>Returns a  CreateDataLakeExceptionSubscriptionResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDataLakeExceptionSubscription">REST API Reference for CreateDataLakeExceptionSubscription Operation</seealso>
        public virtual CreateDataLakeExceptionSubscriptionResponse EndCreateDataLakeExceptionSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataLakeExceptionSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataLakeOrganizationConfiguration

        /// <summary>
        /// Automatically enables Amazon Security Lake for new member accounts in your organization.
        /// Security Lake is not automatically enabled for any existing member accounts in your
        /// organization.
        /// 
        ///  
        /// <para>
        /// This operation merges the new data lake organization configuration with the existing
        /// configuration for Security Lake in your organization. If you want to create a new
        /// data lake organization configuration, you must delete the existing one using <a href="https://docs.aws.amazon.com/security-lake/latest/APIReference/API_DeleteDataLakeOrganizationConfiguration.html">DeleteDataLakeOrganizationConfiguration</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataLakeOrganizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateDataLakeOrganizationConfiguration service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDataLakeOrganizationConfiguration">REST API Reference for CreateDataLakeOrganizationConfiguration Operation</seealso>
        public virtual CreateDataLakeOrganizationConfigurationResponse CreateDataLakeOrganizationConfiguration(CreateDataLakeOrganizationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataLakeOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataLakeOrganizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateDataLakeOrganizationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataLakeOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataLakeOrganizationConfiguration operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataLakeOrganizationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDataLakeOrganizationConfiguration">REST API Reference for CreateDataLakeOrganizationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateDataLakeOrganizationConfiguration(CreateDataLakeOrganizationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataLakeOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataLakeOrganizationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataLakeOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataLakeOrganizationConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateDataLakeOrganizationConfigurationResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDataLakeOrganizationConfiguration">REST API Reference for CreateDataLakeOrganizationConfiguration Operation</seealso>
        public virtual CreateDataLakeOrganizationConfigurationResponse EndCreateDataLakeOrganizationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataLakeOrganizationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSubscriber

        /// <summary>
        /// Creates a subscriber for accounts that are already enabled in Amazon Security Lake.
        /// You can create a subscriber with access to data in the current Amazon Web Services
        /// Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriber service method.</param>
        /// 
        /// <returns>The response from the CreateSubscriber service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateSubscriber">REST API Reference for CreateSubscriber Operation</seealso>
        public virtual CreateSubscriberResponse CreateSubscriber(CreateSubscriberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriberResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriber operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubscriber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateSubscriber">REST API Reference for CreateSubscriber Operation</seealso>
        public virtual IAsyncResult BeginCreateSubscriber(CreateSubscriberRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubscriber.</param>
        /// 
        /// <returns>Returns a  CreateSubscriberResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateSubscriber">REST API Reference for CreateSubscriber Operation</seealso>
        public virtual CreateSubscriberResponse EndCreateSubscriber(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSubscriberResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSubscriberNotification

        /// <summary>
        /// Notifies the subscriber when new data is written to the data lake for the sources
        /// that the subscriber consumes in Security Lake. You can create only one subscriber
        /// notification per subscriber.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriberNotification service method.</param>
        /// 
        /// <returns>The response from the CreateSubscriberNotification service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateSubscriberNotification">REST API Reference for CreateSubscriberNotification Operation</seealso>
        public virtual CreateSubscriberNotificationResponse CreateSubscriberNotification(CreateSubscriberNotificationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriberNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriberNotificationResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriberNotificationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubscriberNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriberNotification operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubscriberNotification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateSubscriberNotification">REST API Reference for CreateSubscriberNotification Operation</seealso>
        public virtual IAsyncResult BeginCreateSubscriberNotification(CreateSubscriberNotificationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriberNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriberNotificationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubscriberNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubscriberNotification.</param>
        /// 
        /// <returns>Returns a  CreateSubscriberNotificationResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateSubscriberNotification">REST API Reference for CreateSubscriberNotification Operation</seealso>
        public virtual CreateSubscriberNotificationResponse EndCreateSubscriberNotification(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSubscriberNotificationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAwsLogSource

        /// <summary>
        /// Removes a natively supported Amazon Web Services service as an Amazon Security Lake
        /// source. You can remove a source for one or more Regions. When you remove the source,
        /// Security Lake stops collecting data from that source in the specified Regions and
        /// accounts, and subscribers can no longer consume new data from the source. However,
        /// subscribers can still consume data that Security Lake collected from the source before
        /// removal.
        /// 
        ///  
        /// <para>
        /// You can choose any source type in any Amazon Web Services Region for either accounts
        /// that are part of a trusted organization or standalone accounts. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAwsLogSource service method.</param>
        /// 
        /// <returns>The response from the DeleteAwsLogSource service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteAwsLogSource">REST API Reference for DeleteAwsLogSource Operation</seealso>
        public virtual DeleteAwsLogSourceResponse DeleteAwsLogSource(DeleteAwsLogSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAwsLogSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAwsLogSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteAwsLogSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAwsLogSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAwsLogSource operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAwsLogSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteAwsLogSource">REST API Reference for DeleteAwsLogSource Operation</seealso>
        public virtual IAsyncResult BeginDeleteAwsLogSource(DeleteAwsLogSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAwsLogSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAwsLogSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAwsLogSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAwsLogSource.</param>
        /// 
        /// <returns>Returns a  DeleteAwsLogSourceResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteAwsLogSource">REST API Reference for DeleteAwsLogSource Operation</seealso>
        public virtual DeleteAwsLogSourceResponse EndDeleteAwsLogSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAwsLogSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCustomLogSource

        /// <summary>
        /// Removes a custom log source from Amazon Security Lake, to stop sending data from the
        /// custom source to Security Lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomLogSource service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomLogSource service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteCustomLogSource">REST API Reference for DeleteCustomLogSource Operation</seealso>
        public virtual DeleteCustomLogSourceResponse DeleteCustomLogSource(DeleteCustomLogSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomLogSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomLogSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomLogSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomLogSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomLogSource operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomLogSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteCustomLogSource">REST API Reference for DeleteCustomLogSource Operation</seealso>
        public virtual IAsyncResult BeginDeleteCustomLogSource(DeleteCustomLogSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomLogSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomLogSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomLogSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomLogSource.</param>
        /// 
        /// <returns>Returns a  DeleteCustomLogSourceResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteCustomLogSource">REST API Reference for DeleteCustomLogSource Operation</seealso>
        public virtual DeleteCustomLogSourceResponse EndDeleteCustomLogSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCustomLogSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataLake

        /// <summary>
        /// When you disable Amazon Security Lake from your account, Security Lake is disabled
        /// in all Amazon Web Services Regions and it stops collecting data from your sources.
        /// Also, this API automatically takes steps to remove the account from Security Lake.
        /// However, Security Lake retains all of your existing settings and the resources that
        /// it created in your Amazon Web Services account in the current Amazon Web Services
        /// Region.
        /// 
        ///  
        /// <para>
        /// The <c>DeleteDataLake</c> operation does not delete the data that is stored in your
        /// Amazon S3 bucket, which is owned by your Amazon Web Services account. For more information,
        /// see the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/disable-security-lake.html">Amazon
        /// Security Lake User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataLake service method.</param>
        /// 
        /// <returns>The response from the DeleteDataLake service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDataLake">REST API Reference for DeleteDataLake Operation</seealso>
        public virtual DeleteDataLakeResponse DeleteDataLake(DeleteDataLakeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataLakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataLakeResponseUnmarshaller.Instance;

            return Invoke<DeleteDataLakeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataLake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataLake operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataLake
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDataLake">REST API Reference for DeleteDataLake Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataLake(DeleteDataLakeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataLakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataLakeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataLake operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataLake.</param>
        /// 
        /// <returns>Returns a  DeleteDataLakeResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDataLake">REST API Reference for DeleteDataLake Operation</seealso>
        public virtual DeleteDataLakeResponse EndDeleteDataLake(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataLakeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataLakeExceptionSubscription

        /// <summary>
        /// Deletes the specified notification subscription in Amazon Security Lake for the organization
        /// you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataLakeExceptionSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteDataLakeExceptionSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDataLakeExceptionSubscription">REST API Reference for DeleteDataLakeExceptionSubscription Operation</seealso>
        public virtual DeleteDataLakeExceptionSubscriptionResponse DeleteDataLakeExceptionSubscription(DeleteDataLakeExceptionSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataLakeExceptionSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataLakeExceptionSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteDataLakeExceptionSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataLakeExceptionSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataLakeExceptionSubscription operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataLakeExceptionSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDataLakeExceptionSubscription">REST API Reference for DeleteDataLakeExceptionSubscription Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataLakeExceptionSubscription(DeleteDataLakeExceptionSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataLakeExceptionSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataLakeExceptionSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataLakeExceptionSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataLakeExceptionSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteDataLakeExceptionSubscriptionResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDataLakeExceptionSubscription">REST API Reference for DeleteDataLakeExceptionSubscription Operation</seealso>
        public virtual DeleteDataLakeExceptionSubscriptionResponse EndDeleteDataLakeExceptionSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataLakeExceptionSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataLakeOrganizationConfiguration

        /// <summary>
        /// Turns off automatic enablement of Amazon Security Lake for member accounts that are
        /// added to an organization in Organizations. Only the delegated Security Lake administrator
        /// for an organization can perform this operation. If the delegated Security Lake administrator
        /// performs this operation, new member accounts won't automatically contribute data to
        /// the data lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataLakeOrganizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteDataLakeOrganizationConfiguration service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDataLakeOrganizationConfiguration">REST API Reference for DeleteDataLakeOrganizationConfiguration Operation</seealso>
        public virtual DeleteDataLakeOrganizationConfigurationResponse DeleteDataLakeOrganizationConfiguration(DeleteDataLakeOrganizationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataLakeOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataLakeOrganizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteDataLakeOrganizationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataLakeOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataLakeOrganizationConfiguration operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataLakeOrganizationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDataLakeOrganizationConfiguration">REST API Reference for DeleteDataLakeOrganizationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataLakeOrganizationConfiguration(DeleteDataLakeOrganizationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataLakeOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataLakeOrganizationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataLakeOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataLakeOrganizationConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteDataLakeOrganizationConfigurationResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDataLakeOrganizationConfiguration">REST API Reference for DeleteDataLakeOrganizationConfiguration Operation</seealso>
        public virtual DeleteDataLakeOrganizationConfigurationResponse EndDeleteDataLakeOrganizationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataLakeOrganizationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSubscriber

        /// <summary>
        /// Deletes the subscription permission and all notification settings for accounts that
        /// are already enabled in Amazon Security Lake. When you run <c>DeleteSubscriber</c>,
        /// the subscriber will no longer consume data from Security Lake and the subscriber is
        /// removed. This operation deletes the subscriber and removes access to data in the current
        /// Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriber service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscriber service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteSubscriber">REST API Reference for DeleteSubscriber Operation</seealso>
        public virtual DeleteSubscriberResponse DeleteSubscriber(DeleteSubscriberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriberResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubscriber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriber operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSubscriber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteSubscriber">REST API Reference for DeleteSubscriber Operation</seealso>
        public virtual IAsyncResult BeginDeleteSubscriber(DeleteSubscriberRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubscriber.</param>
        /// 
        /// <returns>Returns a  DeleteSubscriberResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteSubscriber">REST API Reference for DeleteSubscriber Operation</seealso>
        public virtual DeleteSubscriberResponse EndDeleteSubscriber(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSubscriberResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSubscriberNotification

        /// <summary>
        /// Deletes the specified subscription notification in Amazon Security Lake for the organization
        /// you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriberNotification service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscriberNotification service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteSubscriberNotification">REST API Reference for DeleteSubscriberNotification Operation</seealso>
        public virtual DeleteSubscriberNotificationResponse DeleteSubscriberNotification(DeleteSubscriberNotificationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriberNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriberNotificationResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriberNotificationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubscriberNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriberNotification operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSubscriberNotification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteSubscriberNotification">REST API Reference for DeleteSubscriberNotification Operation</seealso>
        public virtual IAsyncResult BeginDeleteSubscriberNotification(DeleteSubscriberNotificationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriberNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriberNotificationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubscriberNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubscriberNotification.</param>
        /// 
        /// <returns>Returns a  DeleteSubscriberNotificationResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteSubscriberNotification">REST API Reference for DeleteSubscriberNotification Operation</seealso>
        public virtual DeleteSubscriberNotificationResponse EndDeleteSubscriberNotification(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSubscriberNotificationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterDataLakeDelegatedAdministrator

        /// <summary>
        /// Deletes the Amazon Security Lake delegated administrator account for the organization.
        /// This API can only be called by the organization management account. The organization
        /// management account cannot be the delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterDataLakeDelegatedAdministrator service method.</param>
        /// 
        /// <returns>The response from the DeregisterDataLakeDelegatedAdministrator service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeregisterDataLakeDelegatedAdministrator">REST API Reference for DeregisterDataLakeDelegatedAdministrator Operation</seealso>
        public virtual DeregisterDataLakeDelegatedAdministratorResponse DeregisterDataLakeDelegatedAdministrator(DeregisterDataLakeDelegatedAdministratorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterDataLakeDelegatedAdministratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterDataLakeDelegatedAdministratorResponseUnmarshaller.Instance;

            return Invoke<DeregisterDataLakeDelegatedAdministratorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterDataLakeDelegatedAdministrator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterDataLakeDelegatedAdministrator operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterDataLakeDelegatedAdministrator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeregisterDataLakeDelegatedAdministrator">REST API Reference for DeregisterDataLakeDelegatedAdministrator Operation</seealso>
        public virtual IAsyncResult BeginDeregisterDataLakeDelegatedAdministrator(DeregisterDataLakeDelegatedAdministratorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterDataLakeDelegatedAdministratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterDataLakeDelegatedAdministratorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterDataLakeDelegatedAdministrator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterDataLakeDelegatedAdministrator.</param>
        /// 
        /// <returns>Returns a  DeregisterDataLakeDelegatedAdministratorResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeregisterDataLakeDelegatedAdministrator">REST API Reference for DeregisterDataLakeDelegatedAdministrator Operation</seealso>
        public virtual DeregisterDataLakeDelegatedAdministratorResponse EndDeregisterDataLakeDelegatedAdministrator(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterDataLakeDelegatedAdministratorResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataLakeExceptionSubscription

        /// <summary>
        /// Retrieves the protocol and endpoint that were provided when subscribing to Amazon
        /// SNS topics for exception notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeExceptionSubscription service method.</param>
        /// 
        /// <returns>The response from the GetDataLakeExceptionSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDataLakeExceptionSubscription">REST API Reference for GetDataLakeExceptionSubscription Operation</seealso>
        public virtual GetDataLakeExceptionSubscriptionResponse GetDataLakeExceptionSubscription(GetDataLakeExceptionSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataLakeExceptionSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakeExceptionSubscriptionResponseUnmarshaller.Instance;

            return Invoke<GetDataLakeExceptionSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataLakeExceptionSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeExceptionSubscription operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataLakeExceptionSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDataLakeExceptionSubscription">REST API Reference for GetDataLakeExceptionSubscription Operation</seealso>
        public virtual IAsyncResult BeginGetDataLakeExceptionSubscription(GetDataLakeExceptionSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataLakeExceptionSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakeExceptionSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataLakeExceptionSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataLakeExceptionSubscription.</param>
        /// 
        /// <returns>Returns a  GetDataLakeExceptionSubscriptionResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDataLakeExceptionSubscription">REST API Reference for GetDataLakeExceptionSubscription Operation</seealso>
        public virtual GetDataLakeExceptionSubscriptionResponse EndGetDataLakeExceptionSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataLakeExceptionSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataLakeOrganizationConfiguration

        /// <summary>
        /// Retrieves the configuration that will be automatically set up for accounts added to
        /// the organization after the organization has onboarded to Amazon Security Lake. This
        /// API does not take input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeOrganizationConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetDataLakeOrganizationConfiguration service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDataLakeOrganizationConfiguration">REST API Reference for GetDataLakeOrganizationConfiguration Operation</seealso>
        public virtual GetDataLakeOrganizationConfigurationResponse GetDataLakeOrganizationConfiguration(GetDataLakeOrganizationConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataLakeOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakeOrganizationConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetDataLakeOrganizationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataLakeOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeOrganizationConfiguration operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataLakeOrganizationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDataLakeOrganizationConfiguration">REST API Reference for GetDataLakeOrganizationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetDataLakeOrganizationConfiguration(GetDataLakeOrganizationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataLakeOrganizationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakeOrganizationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataLakeOrganizationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataLakeOrganizationConfiguration.</param>
        /// 
        /// <returns>Returns a  GetDataLakeOrganizationConfigurationResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDataLakeOrganizationConfiguration">REST API Reference for GetDataLakeOrganizationConfiguration Operation</seealso>
        public virtual GetDataLakeOrganizationConfigurationResponse EndGetDataLakeOrganizationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataLakeOrganizationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataLakeSources

        /// <summary>
        /// Retrieves a snapshot of the current Region, including whether Amazon Security Lake
        /// is enabled for those accounts and which sources Security Lake is collecting data from.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeSources service method.</param>
        /// 
        /// <returns>The response from the GetDataLakeSources service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDataLakeSources">REST API Reference for GetDataLakeSources Operation</seealso>
        public virtual GetDataLakeSourcesResponse GetDataLakeSources(GetDataLakeSourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataLakeSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakeSourcesResponseUnmarshaller.Instance;

            return Invoke<GetDataLakeSourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataLakeSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataLakeSources operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataLakeSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDataLakeSources">REST API Reference for GetDataLakeSources Operation</seealso>
        public virtual IAsyncResult BeginGetDataLakeSources(GetDataLakeSourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataLakeSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataLakeSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataLakeSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataLakeSources.</param>
        /// 
        /// <returns>Returns a  GetDataLakeSourcesResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDataLakeSources">REST API Reference for GetDataLakeSources Operation</seealso>
        public virtual GetDataLakeSourcesResponse EndGetDataLakeSources(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataLakeSourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSubscriber

        /// <summary>
        /// Retrieves the subscription information for the specified subscription ID. You can
        /// get information about a specific subscriber.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriber service method.</param>
        /// 
        /// <returns>The response from the GetSubscriber service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetSubscriber">REST API Reference for GetSubscriber Operation</seealso>
        public virtual GetSubscriberResponse GetSubscriber(GetSubscriberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriberResponseUnmarshaller.Instance;

            return Invoke<GetSubscriberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscriber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriber operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSubscriber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetSubscriber">REST API Reference for GetSubscriber Operation</seealso>
        public virtual IAsyncResult BeginGetSubscriber(GetSubscriberRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSubscriber.</param>
        /// 
        /// <returns>Returns a  GetSubscriberResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetSubscriber">REST API Reference for GetSubscriber Operation</seealso>
        public virtual GetSubscriberResponse EndGetSubscriber(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSubscriberResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataLakeExceptions

        /// <summary>
        /// Lists the Amazon Security Lake exceptions that you can use to find the source of problems
        /// and fix them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataLakeExceptions service method.</param>
        /// 
        /// <returns>The response from the ListDataLakeExceptions service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListDataLakeExceptions">REST API Reference for ListDataLakeExceptions Operation</seealso>
        public virtual ListDataLakeExceptionsResponse ListDataLakeExceptions(ListDataLakeExceptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataLakeExceptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataLakeExceptionsResponseUnmarshaller.Instance;

            return Invoke<ListDataLakeExceptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataLakeExceptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataLakeExceptions operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataLakeExceptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListDataLakeExceptions">REST API Reference for ListDataLakeExceptions Operation</seealso>
        public virtual IAsyncResult BeginListDataLakeExceptions(ListDataLakeExceptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataLakeExceptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataLakeExceptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataLakeExceptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataLakeExceptions.</param>
        /// 
        /// <returns>Returns a  ListDataLakeExceptionsResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListDataLakeExceptions">REST API Reference for ListDataLakeExceptions Operation</seealso>
        public virtual ListDataLakeExceptionsResponse EndListDataLakeExceptions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataLakeExceptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataLakes

        /// <summary>
        /// Retrieves the Amazon Security Lake configuration object for the specified Amazon Web
        /// Services Regions. You can use this operation to determine whether Security Lake is
        /// enabled for a Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataLakes service method.</param>
        /// 
        /// <returns>The response from the ListDataLakes service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListDataLakes">REST API Reference for ListDataLakes Operation</seealso>
        public virtual ListDataLakesResponse ListDataLakes(ListDataLakesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataLakesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataLakesResponseUnmarshaller.Instance;

            return Invoke<ListDataLakesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataLakes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataLakes operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataLakes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListDataLakes">REST API Reference for ListDataLakes Operation</seealso>
        public virtual IAsyncResult BeginListDataLakes(ListDataLakesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataLakesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataLakesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataLakes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataLakes.</param>
        /// 
        /// <returns>Returns a  ListDataLakesResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListDataLakes">REST API Reference for ListDataLakes Operation</seealso>
        public virtual ListDataLakesResponse EndListDataLakes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataLakesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLogSources

        /// <summary>
        /// Retrieves the log sources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLogSources service method.</param>
        /// 
        /// <returns>The response from the ListLogSources service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListLogSources">REST API Reference for ListLogSources Operation</seealso>
        public virtual ListLogSourcesResponse ListLogSources(ListLogSourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLogSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogSourcesResponseUnmarshaller.Instance;

            return Invoke<ListLogSourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLogSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLogSources operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLogSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListLogSources">REST API Reference for ListLogSources Operation</seealso>
        public virtual IAsyncResult BeginListLogSources(ListLogSourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLogSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLogSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLogSources.</param>
        /// 
        /// <returns>Returns a  ListLogSourcesResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListLogSources">REST API Reference for ListLogSources Operation</seealso>
        public virtual ListLogSourcesResponse EndListLogSources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLogSourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSubscribers

        /// <summary>
        /// Lists all subscribers for the specific Amazon Security Lake account ID. You can retrieve
        /// a list of subscriptions associated with a specific organization or Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribers service method.</param>
        /// 
        /// <returns>The response from the ListSubscribers service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListSubscribers">REST API Reference for ListSubscribers Operation</seealso>
        public virtual ListSubscribersResponse ListSubscribers(ListSubscribersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscribersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscribersResponseUnmarshaller.Instance;

            return Invoke<ListSubscribersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscribers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribers operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscribers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListSubscribers">REST API Reference for ListSubscribers Operation</seealso>
        public virtual IAsyncResult BeginListSubscribers(ListSubscribersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscribersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscribersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscribers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscribers.</param>
        /// 
        /// <returns>Returns a  ListSubscribersResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListSubscribers">REST API Reference for ListSubscribers Operation</seealso>
        public virtual ListSubscribersResponse EndListSubscribers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSubscribersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Retrieves the tags (keys and values) that are associated with an Amazon Security Lake
        /// resource: a subscriber, or the data lake configuration for your Amazon Web Services
        /// account in a particular Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterDataLakeDelegatedAdministrator

        /// <summary>
        /// Designates the Amazon Security Lake delegated administrator account for the organization.
        /// This API can only be called by the organization management account. The organization
        /// management account cannot be the delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDataLakeDelegatedAdministrator service method.</param>
        /// 
        /// <returns>The response from the RegisterDataLakeDelegatedAdministrator service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/RegisterDataLakeDelegatedAdministrator">REST API Reference for RegisterDataLakeDelegatedAdministrator Operation</seealso>
        public virtual RegisterDataLakeDelegatedAdministratorResponse RegisterDataLakeDelegatedAdministrator(RegisterDataLakeDelegatedAdministratorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterDataLakeDelegatedAdministratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDataLakeDelegatedAdministratorResponseUnmarshaller.Instance;

            return Invoke<RegisterDataLakeDelegatedAdministratorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterDataLakeDelegatedAdministrator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterDataLakeDelegatedAdministrator operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterDataLakeDelegatedAdministrator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/RegisterDataLakeDelegatedAdministrator">REST API Reference for RegisterDataLakeDelegatedAdministrator Operation</seealso>
        public virtual IAsyncResult BeginRegisterDataLakeDelegatedAdministrator(RegisterDataLakeDelegatedAdministratorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterDataLakeDelegatedAdministratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDataLakeDelegatedAdministratorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterDataLakeDelegatedAdministrator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterDataLakeDelegatedAdministrator.</param>
        /// 
        /// <returns>Returns a  RegisterDataLakeDelegatedAdministratorResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/RegisterDataLakeDelegatedAdministrator">REST API Reference for RegisterDataLakeDelegatedAdministrator Operation</seealso>
        public virtual RegisterDataLakeDelegatedAdministratorResponse EndRegisterDataLakeDelegatedAdministrator(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterDataLakeDelegatedAdministratorResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds or updates one or more tags that are associated with an Amazon Security Lake
        /// resource: a subscriber, or the data lake configuration for your Amazon Web Services
        /// account in a particular Amazon Web Services Region. A <i>tag</i> is a label that you
        /// can define and associate with Amazon Web Services resources. Each tag consists of
        /// a required <i>tag key</i> and an associated <i>tag value</i>. A <i>tag key</i> is
        /// a general label that acts as a category for a more specific tag value. A <i>tag value</i>
        /// acts as a descriptor for a tag key. Tags can help you identify, categorize, and manage
        /// resources in different ways, such as by owner, environment, or other criteria. For
        /// more information, see <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/tagging-resources.html">Tagging
        /// Amazon Security Lake resources</a> in the <i>Amazon Security Lake User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags (keys and values) from an Amazon Security Lake resource:
        /// a subscriber, or the data lake configuration for your Amazon Web Services account
        /// in a particular Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataLake

        /// <summary>
        /// You can use <c>UpdateDataLake</c> to specify where to store your security data, how
        /// it should be encrypted at rest and for how long. You can add a <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/manage-regions.html#add-rollup-region">Rollup
        /// Region</a> to consolidate data from multiple Amazon Web Services Regions, replace
        /// default encryption (SSE-S3) with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">Customer
        /// Manged Key</a>, or specify transition and expiration actions through storage <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/lifecycle-management.html">Lifecycle
        /// management</a>. The <c>UpdateDataLake</c> API works as an "upsert" operation that
        /// performs an insert if the specified item or record does not exist, or an update if
        /// it already exists. Security Lake securely stores your data at rest using Amazon Web
        /// Services encryption solutions. For more details, see <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/data-protection.html">Data
        /// protection in Amazon Security Lake</a>.
        /// 
        ///  
        /// <para>
        /// For example, omitting the key <c>encryptionConfiguration</c> from a Region that is
        /// included in an update call that currently uses KMS will leave that Region's KMS key
        /// in place, but specifying <c>encryptionConfiguration: {kmsKeyId: 'S3_MANAGED_KEY'}</c>
        /// for that same Region will reset the key to <c>S3-managed</c>.
        /// </para>
        ///  
        /// <para>
        /// For more details about lifecycle management and how to update retention settings for
        /// one or more Regions after enabling Security Lake, see the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/lifecycle-management.html">Amazon
        /// Security Lake User Guide</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataLake service method.</param>
        /// 
        /// <returns>The response from the UpdateDataLake service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDataLake">REST API Reference for UpdateDataLake Operation</seealso>
        public virtual UpdateDataLakeResponse UpdateDataLake(UpdateDataLakeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataLakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataLakeResponseUnmarshaller.Instance;

            return Invoke<UpdateDataLakeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataLake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataLake operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataLake
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDataLake">REST API Reference for UpdateDataLake Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataLake(UpdateDataLakeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataLakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataLakeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataLake operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataLake.</param>
        /// 
        /// <returns>Returns a  UpdateDataLakeResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDataLake">REST API Reference for UpdateDataLake Operation</seealso>
        public virtual UpdateDataLakeResponse EndUpdateDataLake(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataLakeResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataLakeExceptionSubscription

        /// <summary>
        /// Updates the specified notification subscription in Amazon Security Lake for the organization
        /// you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataLakeExceptionSubscription service method.</param>
        /// 
        /// <returns>The response from the UpdateDataLakeExceptionSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDataLakeExceptionSubscription">REST API Reference for UpdateDataLakeExceptionSubscription Operation</seealso>
        public virtual UpdateDataLakeExceptionSubscriptionResponse UpdateDataLakeExceptionSubscription(UpdateDataLakeExceptionSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataLakeExceptionSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataLakeExceptionSubscriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateDataLakeExceptionSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataLakeExceptionSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataLakeExceptionSubscription operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataLakeExceptionSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDataLakeExceptionSubscription">REST API Reference for UpdateDataLakeExceptionSubscription Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataLakeExceptionSubscription(UpdateDataLakeExceptionSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataLakeExceptionSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataLakeExceptionSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataLakeExceptionSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataLakeExceptionSubscription.</param>
        /// 
        /// <returns>Returns a  UpdateDataLakeExceptionSubscriptionResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDataLakeExceptionSubscription">REST API Reference for UpdateDataLakeExceptionSubscription Operation</seealso>
        public virtual UpdateDataLakeExceptionSubscriptionResponse EndUpdateDataLakeExceptionSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataLakeExceptionSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSubscriber

        /// <summary>
        /// Updates an existing subscription for the given Amazon Security Lake account ID. You
        /// can update a subscriber by changing the sources that the subscriber consumes data
        /// from.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriber service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscriber service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateSubscriber">REST API Reference for UpdateSubscriber Operation</seealso>
        public virtual UpdateSubscriberResponse UpdateSubscriber(UpdateSubscriberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriberResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriber operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSubscriber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateSubscriber">REST API Reference for UpdateSubscriber Operation</seealso>
        public virtual IAsyncResult BeginUpdateSubscriber(UpdateSubscriberRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubscriber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubscriber.</param>
        /// 
        /// <returns>Returns a  UpdateSubscriberResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateSubscriber">REST API Reference for UpdateSubscriber Operation</seealso>
        public virtual UpdateSubscriberResponse EndUpdateSubscriber(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSubscriberResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSubscriberNotification

        /// <summary>
        /// Updates an existing notification method for the subscription (SQS or HTTPs endpoint)
        /// or switches the notification subscription endpoint for a subscriber.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriberNotification service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscriberNotification service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateSubscriberNotification">REST API Reference for UpdateSubscriberNotification Operation</seealso>
        public virtual UpdateSubscriberNotificationResponse UpdateSubscriberNotification(UpdateSubscriberNotificationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriberNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriberNotificationResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriberNotificationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubscriberNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriberNotification operation on AmazonSecurityLakeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSubscriberNotification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateSubscriberNotification">REST API Reference for UpdateSubscriberNotification Operation</seealso>
        public virtual IAsyncResult BeginUpdateSubscriberNotification(UpdateSubscriberNotificationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriberNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriberNotificationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubscriberNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubscriberNotification.</param>
        /// 
        /// <returns>Returns a  UpdateSubscriberNotificationResult from SecurityLake.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateSubscriberNotification">REST API Reference for UpdateSubscriberNotification Operation</seealso>
        public virtual UpdateSubscriberNotificationResponse EndUpdateSubscriberNotification(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSubscriberNotificationResponse>(asyncResult);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonSecurityLakeEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}