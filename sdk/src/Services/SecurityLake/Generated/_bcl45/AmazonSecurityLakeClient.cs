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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SecurityLake.Model;
using Amazon.SecurityLake.Model.Internal.MarshallTransformations;
using Amazon.SecurityLake.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SecurityLake
{
    /// <summary>
    /// Implementation for accessing SecurityLake
    ///
    /// <note> 
    /// <para>
    /// Amazon Security Lake is in preview release. Your use of the Amazon Security Lake preview
    /// is subject to Section 2 of the <a href="http://aws.amazon.com/service-terms/">Amazon
    /// Web Services Service Terms</a>("Betas and Previews").
    /// </para>
    ///  </note> 
    /// <para>
    /// Amazon Security Lake is a fully-managed security data lake service. You can use Security
    /// Lake to automatically centralize security data from cloud, on-premises, and custom
    /// sources into a data lake that's stored in your account. Security Lake helps you analyze
    /// security data, so you can get a more complete understanding of your security posture
    /// across the entire organization and improve the protection of your workloads, applications,
    /// and data.
    /// </para>
    ///  
    /// <para>
    /// The data lake is backed by Amazon Simple Storage Service (Amazon S3) buckets, and
    /// you retain ownership over your data.
    /// </para>
    ///  
    /// <para>
    /// Security Lake automates the collection of security-related log and event data from
    /// integrated Amazon Web Services. and third-party services and manages the lifecycle
    /// of data with customizable retention and replication settings. Security Lake also converts
    /// ingested data into Apache Parquet format and a standard open-source schema called
    /// the Open Cybersecurity Schema Framework (OCSF).
    /// </para>
    ///  
    /// <para>
    /// Other Amazon Web Services and third-party services can subscribe to the data that's
    /// stored in Security Lake for incident response and security data analytics.
    /// </para>
    /// </summary>
    public partial class AmazonSecurityLakeClient : AmazonServiceClient, IAmazonSecurityLake
    {
        private static IServiceMetadata serviceMetadata = new AmazonSecurityLakeMetadata();
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
        /// Adds a natively-supported Amazon Web Services service as a Security Lake source. Enables
        /// source types for member accounts in required Regions, based on specified parameters.
        /// You can choose any source type in any Region for accounts that are either part of
        /// a trusted organization or standalone accounts. At least one of the three dimensions
        /// is a mandatory input to this API. However, any combination of the three dimensions
        /// can be supplied to this API. 
        /// 
        ///  
        /// <para>
        /// By default, dimension refers to the entire set. When you don't provide a dimension,
        /// Security Lake assumes that the missing dimension refers to the entire set. This is
        /// overridden when you supply any one of the inputs. For instance, when members is not
        /// specified, the API disables all Security Lake member accounts for sources. Similarly,
        /// when Regions are not specified, Security Lake is disabled for all the Regions where
        /// Security Lake is available as a service.
        /// </para>
        ///  
        /// <para>
        /// You can use this API only to enable a natively-supported Amazon Web Services services
        /// as a source. Use <code>CreateCustomLogSource</code> to enable data collection from
        /// a custom source. 
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
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.S3Exception">
        /// Provides an extension of the AmazonServiceException for errors reported by Amazon
        /// S3 while processing a request. In particular, this class provides access to Amazon
        /// S3's extended request ID. This ID is required debugging information in the case the
        /// user needs to contact Amazon about an issue where Amazon S3 is incorrectly handling
        /// a request.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateAwsLogSource">REST API Reference for CreateAwsLogSource Operation</seealso>
        public virtual CreateAwsLogSourceResponse CreateAwsLogSource(CreateAwsLogSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAwsLogSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAwsLogSourceResponseUnmarshaller.Instance;

            return Invoke<CreateAwsLogSourceResponse>(request, options);
        }


        /// <summary>
        /// Adds a natively-supported Amazon Web Services service as a Security Lake source. Enables
        /// source types for member accounts in required Regions, based on specified parameters.
        /// You can choose any source type in any Region for accounts that are either part of
        /// a trusted organization or standalone accounts. At least one of the three dimensions
        /// is a mandatory input to this API. However, any combination of the three dimensions
        /// can be supplied to this API. 
        /// 
        ///  
        /// <para>
        /// By default, dimension refers to the entire set. When you don't provide a dimension,
        /// Security Lake assumes that the missing dimension refers to the entire set. This is
        /// overridden when you supply any one of the inputs. For instance, when members is not
        /// specified, the API disables all Security Lake member accounts for sources. Similarly,
        /// when Regions are not specified, Security Lake is disabled for all the Regions where
        /// Security Lake is available as a service.
        /// </para>
        ///  
        /// <para>
        /// You can use this API only to enable a natively-supported Amazon Web Services services
        /// as a source. Use <code>CreateCustomLogSource</code> to enable data collection from
        /// a custom source. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAwsLogSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAwsLogSource service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.S3Exception">
        /// Provides an extension of the AmazonServiceException for errors reported by Amazon
        /// S3 while processing a request. In particular, this class provides access to Amazon
        /// S3's extended request ID. This ID is required debugging information in the case the
        /// user needs to contact Amazon about an issue where Amazon S3 is incorrectly handling
        /// a request.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateAwsLogSource">REST API Reference for CreateAwsLogSource Operation</seealso>
        public virtual Task<CreateAwsLogSourceResponse> CreateAwsLogSourceAsync(CreateAwsLogSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAwsLogSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAwsLogSourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAwsLogSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomLogSource


        /// <summary>
        /// Adds a third-party custom source in Amazon Security Lake, from the Region where you
        /// want to create a custom source. Security Lake can collect logs and events from third-party
        /// custom sources. After creating the appropriate API roles, use this API to add a custom
        /// source name in Security Lake. This operation creates a partition in the Security Lake
        /// S3 bucket as the target location for log files from the custom source, an associated
        /// Glue table, and an Glue crawler.
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
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BucketNotFoundException">
        /// Amazon Security Lake generally returns 404 errors if the requested object is missing
        /// from the bucket.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictSourceNamesException">
        /// There was a conflict when you attempted to modify a Security Lake source name.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateCustomLogSource">REST API Reference for CreateCustomLogSource Operation</seealso>
        public virtual CreateCustomLogSourceResponse CreateCustomLogSource(CreateCustomLogSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomLogSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomLogSourceResponseUnmarshaller.Instance;

            return Invoke<CreateCustomLogSourceResponse>(request, options);
        }


        /// <summary>
        /// Adds a third-party custom source in Amazon Security Lake, from the Region where you
        /// want to create a custom source. Security Lake can collect logs and events from third-party
        /// custom sources. After creating the appropriate API roles, use this API to add a custom
        /// source name in Security Lake. This operation creates a partition in the Security Lake
        /// S3 bucket as the target location for log files from the custom source, an associated
        /// Glue table, and an Glue crawler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomLogSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomLogSource service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BucketNotFoundException">
        /// Amazon Security Lake generally returns 404 errors if the requested object is missing
        /// from the bucket.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictSourceNamesException">
        /// There was a conflict when you attempted to modify a Security Lake source name.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateCustomLogSource">REST API Reference for CreateCustomLogSource Operation</seealso>
        public virtual Task<CreateCustomLogSourceResponse> CreateCustomLogSourceAsync(CreateCustomLogSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomLogSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomLogSourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCustomLogSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDatalake


        /// <summary>
        /// Initializes an Amazon Security Lake instance with the provided (or default) configuration.
        /// You can enable Security Lake in Regions with customized settings in advance before
        /// enabling log collection in Regions. You can either use the <code>enableAll</code>
        /// parameter to specify all Regions or you can specify the Regions you want to enable
        /// Security Lake using the <code>Regions</code> parameter and configure these Regions
        /// using the <code>configurations</code> parameter. When the <code>CreateDataLake</code>
        /// API is called multiple times, if that Region is already enabled, it will update the
        /// Region if configuration for that Region is provided. If that Region is a new Region,
        /// it will be set up with the customized configurations if it is specified. 
        /// 
        ///  
        /// <para>
        /// When you enable Security Lake, it starts ingesting security data after the <code>CreateAwsLogSource</code>
        /// call. This includes ingesting security data from sources, storing data, and making
        /// data accessible to subscribers. Security Lake also enables all the existing settings
        /// and resources that it stores or maintains for your account in the current Region,
        /// including security log and event data. For more information, see the Amazon Security
        /// Lake User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalake service method.</param>
        /// 
        /// <returns>The response from the CreateDatalake service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
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
        /// <exception cref="Amazon.SecurityLake.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalake">REST API Reference for CreateDatalake Operation</seealso>
        public virtual CreateDatalakeResponse CreateDatalake(CreateDatalakeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatalakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatalakeResponseUnmarshaller.Instance;

            return Invoke<CreateDatalakeResponse>(request, options);
        }


        /// <summary>
        /// Initializes an Amazon Security Lake instance with the provided (or default) configuration.
        /// You can enable Security Lake in Regions with customized settings in advance before
        /// enabling log collection in Regions. You can either use the <code>enableAll</code>
        /// parameter to specify all Regions or you can specify the Regions you want to enable
        /// Security Lake using the <code>Regions</code> parameter and configure these Regions
        /// using the <code>configurations</code> parameter. When the <code>CreateDataLake</code>
        /// API is called multiple times, if that Region is already enabled, it will update the
        /// Region if configuration for that Region is provided. If that Region is a new Region,
        /// it will be set up with the customized configurations if it is specified. 
        /// 
        ///  
        /// <para>
        /// When you enable Security Lake, it starts ingesting security data after the <code>CreateAwsLogSource</code>
        /// call. This includes ingesting security data from sources, storing data, and making
        /// data accessible to subscribers. Security Lake also enables all the existing settings
        /// and resources that it stores or maintains for your account in the current Region,
        /// including security log and event data. For more information, see the Amazon Security
        /// Lake User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDatalake service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
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
        /// <exception cref="Amazon.SecurityLake.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalake">REST API Reference for CreateDatalake Operation</seealso>
        public virtual Task<CreateDatalakeResponse> CreateDatalakeAsync(CreateDatalakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatalakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatalakeResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDatalakeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDatalakeAutoEnable


        /// <summary>
        /// Automatically enable Security Lake in the specified Regions to begin ingesting security
        /// data. When you choose to enable organization accounts automatically, then Security
        /// Lake begins to enable new accounts as member accounts as they are added to the organization.
        /// Security Lake does not enable existing organization accounts that are not yet enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalakeAutoEnable service method.</param>
        /// 
        /// <returns>The response from the CreateDatalakeAutoEnable service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalakeAutoEnable">REST API Reference for CreateDatalakeAutoEnable Operation</seealso>
        public virtual CreateDatalakeAutoEnableResponse CreateDatalakeAutoEnable(CreateDatalakeAutoEnableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatalakeAutoEnableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatalakeAutoEnableResponseUnmarshaller.Instance;

            return Invoke<CreateDatalakeAutoEnableResponse>(request, options);
        }


        /// <summary>
        /// Automatically enable Security Lake in the specified Regions to begin ingesting security
        /// data. When you choose to enable organization accounts automatically, then Security
        /// Lake begins to enable new accounts as member accounts as they are added to the organization.
        /// Security Lake does not enable existing organization accounts that are not yet enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalakeAutoEnable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDatalakeAutoEnable service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalakeAutoEnable">REST API Reference for CreateDatalakeAutoEnable Operation</seealso>
        public virtual Task<CreateDatalakeAutoEnableResponse> CreateDatalakeAutoEnableAsync(CreateDatalakeAutoEnableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatalakeAutoEnableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatalakeAutoEnableResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDatalakeAutoEnableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDatalakeDelegatedAdmin


        /// <summary>
        /// Designates the Security Lake administrator account for the organization. This API
        /// can only be called by the organization management account. The organization management
        /// account cannot be the delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalakeDelegatedAdmin service method.</param>
        /// 
        /// <returns>The response from the CreateDatalakeDelegatedAdmin service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalakeDelegatedAdmin">REST API Reference for CreateDatalakeDelegatedAdmin Operation</seealso>
        public virtual CreateDatalakeDelegatedAdminResponse CreateDatalakeDelegatedAdmin(CreateDatalakeDelegatedAdminRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatalakeDelegatedAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatalakeDelegatedAdminResponseUnmarshaller.Instance;

            return Invoke<CreateDatalakeDelegatedAdminResponse>(request, options);
        }


        /// <summary>
        /// Designates the Security Lake administrator account for the organization. This API
        /// can only be called by the organization management account. The organization management
        /// account cannot be the delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalakeDelegatedAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDatalakeDelegatedAdmin service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalakeDelegatedAdmin">REST API Reference for CreateDatalakeDelegatedAdmin Operation</seealso>
        public virtual Task<CreateDatalakeDelegatedAdminResponse> CreateDatalakeDelegatedAdminAsync(CreateDatalakeDelegatedAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatalakeDelegatedAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatalakeDelegatedAdminResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDatalakeDelegatedAdminResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDatalakeExceptionsSubscription


        /// <summary>
        /// Creates the specified notification subscription in Security Lake. Creates the specified
        /// subscription notifications in the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalakeExceptionsSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateDatalakeExceptionsSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalakeExceptionsSubscription">REST API Reference for CreateDatalakeExceptionsSubscription Operation</seealso>
        public virtual CreateDatalakeExceptionsSubscriptionResponse CreateDatalakeExceptionsSubscription(CreateDatalakeExceptionsSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatalakeExceptionsSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatalakeExceptionsSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateDatalakeExceptionsSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Creates the specified notification subscription in Security Lake. Creates the specified
        /// subscription notifications in the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatalakeExceptionsSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDatalakeExceptionsSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateDatalakeExceptionsSubscription">REST API Reference for CreateDatalakeExceptionsSubscription Operation</seealso>
        public virtual Task<CreateDatalakeExceptionsSubscriptionResponse> CreateDatalakeExceptionsSubscriptionAsync(CreateDatalakeExceptionsSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatalakeExceptionsSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatalakeExceptionsSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDatalakeExceptionsSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSubscriber


        /// <summary>
        /// Creates a subscription permission for accounts that are already enabled in Security
        /// Lake.
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
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BucketNotFoundException">
        /// Amazon Security Lake generally returns 404 errors if the requested object is missing
        /// from the bucket.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictSubscriptionException">
        /// A conflicting subscription exception operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateSubscriber">REST API Reference for CreateSubscriber Operation</seealso>
        public virtual CreateSubscriberResponse CreateSubscriber(CreateSubscriberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriberResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriberResponse>(request, options);
        }


        /// <summary>
        /// Creates a subscription permission for accounts that are already enabled in Security
        /// Lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscriber service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BucketNotFoundException">
        /// Amazon Security Lake generally returns 404 errors if the requested object is missing
        /// from the bucket.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictSubscriptionException">
        /// A conflicting subscription exception operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateSubscriber">REST API Reference for CreateSubscriber Operation</seealso>
        public virtual Task<CreateSubscriberResponse> CreateSubscriberAsync(CreateSubscriberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriberResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSubscriberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSubscriptionNotificationConfiguration


        /// <summary>
        /// Creates the specified notification subscription in Security Lake. Creates the specified
        /// subscription notifications from the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateSubscriptionNotificationConfiguration service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateSubscriptionNotificationConfiguration">REST API Reference for CreateSubscriptionNotificationConfiguration Operation</seealso>
        public virtual CreateSubscriptionNotificationConfigurationResponse CreateSubscriptionNotificationConfiguration(CreateSubscriptionNotificationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionNotificationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Creates the specified notification subscription in Security Lake. Creates the specified
        /// subscription notifications from the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscriptionNotificationConfiguration service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/CreateSubscriptionNotificationConfiguration">REST API Reference for CreateSubscriptionNotificationConfiguration Operation</seealso>
        public virtual Task<CreateSubscriptionNotificationConfigurationResponse> CreateSubscriptionNotificationConfigurationAsync(CreateSubscriptionNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionNotificationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSubscriptionNotificationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAwsLogSource


        /// <summary>
        /// Removes a natively-supported Amazon Web Services service as a Amazon Security Lake
        /// source. When you remove the source, Security Lake stops collecting data from that
        /// source, and subscribers can no longer consume new data from the source. Subscribers
        /// can still consume data that Amazon Security Lake collected from the source before
        /// disablement.
        /// 
        ///  
        /// <para>
        /// You can choose any source type in any Region for accounts that are either part of
        /// a trusted organization or standalone accounts. At least one of the three dimensions
        /// is a mandatory input to this API. However, any combination of the three dimensions
        /// can be supplied to this API. 
        /// </para>
        ///  
        /// <para>
        /// By default, dimension refers to the entire set. This is overridden when you supply
        /// any one of the inputs. For instance, when members is not specified, the API disables
        /// all Security Lake member accounts for sources. Similarly, when Regions are not specified,
        /// Security Lake is disabled for all the Regions where Security Lake is available as
        /// a service.
        /// </para>
        ///  
        /// <para>
        /// You can use this API to remove a natively-supported Amazon Web Services service as
        /// a source. Use <code>DeregisterCustomData</code> to remove a custom source.
        /// </para>
        ///  
        /// <para>
        /// When you don't provide a dimension, Security Lake assumes that the missing dimension
        /// refers to the entire set. For example, if you don't provide specific accounts, the
        /// API applies to the entire set of accounts in your organization.
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
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteAwsLogSource">REST API Reference for DeleteAwsLogSource Operation</seealso>
        public virtual DeleteAwsLogSourceResponse DeleteAwsLogSource(DeleteAwsLogSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAwsLogSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAwsLogSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteAwsLogSourceResponse>(request, options);
        }


        /// <summary>
        /// Removes a natively-supported Amazon Web Services service as a Amazon Security Lake
        /// source. When you remove the source, Security Lake stops collecting data from that
        /// source, and subscribers can no longer consume new data from the source. Subscribers
        /// can still consume data that Amazon Security Lake collected from the source before
        /// disablement.
        /// 
        ///  
        /// <para>
        /// You can choose any source type in any Region for accounts that are either part of
        /// a trusted organization or standalone accounts. At least one of the three dimensions
        /// is a mandatory input to this API. However, any combination of the three dimensions
        /// can be supplied to this API. 
        /// </para>
        ///  
        /// <para>
        /// By default, dimension refers to the entire set. This is overridden when you supply
        /// any one of the inputs. For instance, when members is not specified, the API disables
        /// all Security Lake member accounts for sources. Similarly, when Regions are not specified,
        /// Security Lake is disabled for all the Regions where Security Lake is available as
        /// a service.
        /// </para>
        ///  
        /// <para>
        /// You can use this API to remove a natively-supported Amazon Web Services service as
        /// a source. Use <code>DeregisterCustomData</code> to remove a custom source.
        /// </para>
        ///  
        /// <para>
        /// When you don't provide a dimension, Security Lake assumes that the missing dimension
        /// refers to the entire set. For example, if you don't provide specific accounts, the
        /// API applies to the entire set of accounts in your organization.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAwsLogSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAwsLogSource service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteAwsLogSource">REST API Reference for DeleteAwsLogSource Operation</seealso>
        public virtual Task<DeleteAwsLogSourceResponse> DeleteAwsLogSourceAsync(DeleteAwsLogSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAwsLogSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAwsLogSourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAwsLogSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomLogSource


        /// <summary>
        /// Removes a custom log source from Security Lake.
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
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BucketNotFoundException">
        /// Amazon Security Lake generally returns 404 errors if the requested object is missing
        /// from the bucket.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictSourceNamesException">
        /// There was a conflict when you attempted to modify a Security Lake source name.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteCustomLogSource">REST API Reference for DeleteCustomLogSource Operation</seealso>
        public virtual DeleteCustomLogSourceResponse DeleteCustomLogSource(DeleteCustomLogSourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomLogSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomLogSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomLogSourceResponse>(request, options);
        }


        /// <summary>
        /// Removes a custom log source from Security Lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomLogSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomLogSource service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BucketNotFoundException">
        /// Amazon Security Lake generally returns 404 errors if the requested object is missing
        /// from the bucket.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictSourceNamesException">
        /// There was a conflict when you attempted to modify a Security Lake source name.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteCustomLogSource">REST API Reference for DeleteCustomLogSource Operation</seealso>
        public virtual Task<DeleteCustomLogSourceResponse> DeleteCustomLogSourceAsync(DeleteCustomLogSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomLogSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomLogSourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCustomLogSourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDatalake


        /// <summary>
        /// When you delete Amazon Security Lake from your account, Security Lake is disabled
        /// in all Regions. Also, this API automatically performs the off-boarding steps to off-board
        /// the account from Security Lake . This includes ingesting security data from sources,
        /// storing data, and making data accessible to subscribers. Security Lake also deletes
        /// all the existing settings and resources that it stores or maintains for your account
        /// in the current Region, including security log and event data. <code>DeleteDatalake</code>
        /// does not delete the S3 bucket which is owned by the Amazon Web Services account. For
        /// more information, see the Amazon Security Lake User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalake service method.</param>
        /// 
        /// <returns>The response from the DeleteDatalake service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
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
        /// <exception cref="Amazon.SecurityLake.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalake">REST API Reference for DeleteDatalake Operation</seealso>
        public virtual DeleteDatalakeResponse DeleteDatalake(DeleteDatalakeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatalakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatalakeResponseUnmarshaller.Instance;

            return Invoke<DeleteDatalakeResponse>(request, options);
        }


        /// <summary>
        /// When you delete Amazon Security Lake from your account, Security Lake is disabled
        /// in all Regions. Also, this API automatically performs the off-boarding steps to off-board
        /// the account from Security Lake . This includes ingesting security data from sources,
        /// storing data, and making data accessible to subscribers. Security Lake also deletes
        /// all the existing settings and resources that it stores or maintains for your account
        /// in the current Region, including security log and event data. <code>DeleteDatalake</code>
        /// does not delete the S3 bucket which is owned by the Amazon Web Services account. For
        /// more information, see the Amazon Security Lake User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDatalake service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
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
        /// <exception cref="Amazon.SecurityLake.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalake">REST API Reference for DeleteDatalake Operation</seealso>
        public virtual Task<DeleteDatalakeResponse> DeleteDatalakeAsync(DeleteDatalakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatalakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatalakeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDatalakeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDatalakeAutoEnable


        /// <summary>
        /// Automatically delete Security Lake in the specified Regions to stop ingesting security
        /// data. When you delete Amazon Security Lake from your account, Security Lake is disabled
        /// in all Regions. Also, this API automatically performs the off-boarding steps to off-board
        /// the account from Security Lake . This includes ingesting security data from sources,
        /// storing data, and making data accessible to subscribers. Security Lake also deletes
        /// all the existing settings and resources that it stores or maintains for your account
        /// in the current Region, including security log and event data. For more information,
        /// see the Amazon Security Lake User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalakeAutoEnable service method.</param>
        /// 
        /// <returns>The response from the DeleteDatalakeAutoEnable service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalakeAutoEnable">REST API Reference for DeleteDatalakeAutoEnable Operation</seealso>
        public virtual DeleteDatalakeAutoEnableResponse DeleteDatalakeAutoEnable(DeleteDatalakeAutoEnableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatalakeAutoEnableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatalakeAutoEnableResponseUnmarshaller.Instance;

            return Invoke<DeleteDatalakeAutoEnableResponse>(request, options);
        }


        /// <summary>
        /// Automatically delete Security Lake in the specified Regions to stop ingesting security
        /// data. When you delete Amazon Security Lake from your account, Security Lake is disabled
        /// in all Regions. Also, this API automatically performs the off-boarding steps to off-board
        /// the account from Security Lake . This includes ingesting security data from sources,
        /// storing data, and making data accessible to subscribers. Security Lake also deletes
        /// all the existing settings and resources that it stores or maintains for your account
        /// in the current Region, including security log and event data. For more information,
        /// see the Amazon Security Lake User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalakeAutoEnable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDatalakeAutoEnable service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalakeAutoEnable">REST API Reference for DeleteDatalakeAutoEnable Operation</seealso>
        public virtual Task<DeleteDatalakeAutoEnableResponse> DeleteDatalakeAutoEnableAsync(DeleteDatalakeAutoEnableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatalakeAutoEnableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatalakeAutoEnableResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDatalakeAutoEnableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDatalakeDelegatedAdmin


        /// <summary>
        /// Deletes the Security Lake administrator account for the organization. This API can
        /// only be called by the organization management account. The organization management
        /// account cannot be the delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalakeDelegatedAdmin service method.</param>
        /// 
        /// <returns>The response from the DeleteDatalakeDelegatedAdmin service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalakeDelegatedAdmin">REST API Reference for DeleteDatalakeDelegatedAdmin Operation</seealso>
        public virtual DeleteDatalakeDelegatedAdminResponse DeleteDatalakeDelegatedAdmin(DeleteDatalakeDelegatedAdminRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatalakeDelegatedAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatalakeDelegatedAdminResponseUnmarshaller.Instance;

            return Invoke<DeleteDatalakeDelegatedAdminResponse>(request, options);
        }


        /// <summary>
        /// Deletes the Security Lake administrator account for the organization. This API can
        /// only be called by the organization management account. The organization management
        /// account cannot be the delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalakeDelegatedAdmin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDatalakeDelegatedAdmin service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalakeDelegatedAdmin">REST API Reference for DeleteDatalakeDelegatedAdmin Operation</seealso>
        public virtual Task<DeleteDatalakeDelegatedAdminResponse> DeleteDatalakeDelegatedAdminAsync(DeleteDatalakeDelegatedAdminRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatalakeDelegatedAdminRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatalakeDelegatedAdminResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDatalakeDelegatedAdminResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDatalakeExceptionsSubscription


        /// <summary>
        /// Deletes the specified notification subscription in Security Lake. Deletes the specified
        /// subscription notifications in the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalakeExceptionsSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteDatalakeExceptionsSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalakeExceptionsSubscription">REST API Reference for DeleteDatalakeExceptionsSubscription Operation</seealso>
        public virtual DeleteDatalakeExceptionsSubscriptionResponse DeleteDatalakeExceptionsSubscription(DeleteDatalakeExceptionsSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatalakeExceptionsSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatalakeExceptionsSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteDatalakeExceptionsSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified notification subscription in Security Lake. Deletes the specified
        /// subscription notifications in the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatalakeExceptionsSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDatalakeExceptionsSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteDatalakeExceptionsSubscription">REST API Reference for DeleteDatalakeExceptionsSubscription Operation</seealso>
        public virtual Task<DeleteDatalakeExceptionsSubscriptionResponse> DeleteDatalakeExceptionsSubscriptionAsync(DeleteDatalakeExceptionsSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatalakeExceptionsSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatalakeExceptionsSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDatalakeExceptionsSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSubscriber


        /// <summary>
        /// Deletes the specified subscription permissions to Security Lake. Deletes the specified
        /// subscription permissions from the specified organization.
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
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BucketNotFoundException">
        /// Amazon Security Lake generally returns 404 errors if the requested object is missing
        /// from the bucket.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteSubscriber">REST API Reference for DeleteSubscriber Operation</seealso>
        public virtual DeleteSubscriberResponse DeleteSubscriber(DeleteSubscriberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriberResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriberResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified subscription permissions to Security Lake. Deletes the specified
        /// subscription permissions from the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubscriber service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.BucketNotFoundException">
        /// Amazon Security Lake generally returns 404 errors if the requested object is missing
        /// from the bucket.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteSubscriber">REST API Reference for DeleteSubscriber Operation</seealso>
        public virtual Task<DeleteSubscriberResponse> DeleteSubscriberAsync(DeleteSubscriberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriberResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSubscriberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSubscriptionNotificationConfiguration


        /// <summary>
        /// Deletes the specified notification subscription in Security Lake. Deletes the specified
        /// subscription notifications from the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscriptionNotificationConfiguration service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteSubscriptionNotificationConfiguration">REST API Reference for DeleteSubscriptionNotificationConfiguration Operation</seealso>
        public virtual DeleteSubscriptionNotificationConfigurationResponse DeleteSubscriptionNotificationConfiguration(DeleteSubscriptionNotificationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriptionNotificationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified notification subscription in Security Lake. Deletes the specified
        /// subscription notifications from the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubscriptionNotificationConfiguration service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/DeleteSubscriptionNotificationConfiguration">REST API Reference for DeleteSubscriptionNotificationConfiguration Operation</seealso>
        public virtual Task<DeleteSubscriptionNotificationConfigurationResponse> DeleteSubscriptionNotificationConfigurationAsync(DeleteSubscriptionNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionNotificationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSubscriptionNotificationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDatalake


        /// <summary>
        /// Retrieve the Security Lake configuration object for the specified account ID. This
        /// API does not take input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalake service method.</param>
        /// 
        /// <returns>The response from the GetDatalake service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalake">REST API Reference for GetDatalake Operation</seealso>
        public virtual GetDatalakeResponse GetDatalake(GetDatalakeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatalakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatalakeResponseUnmarshaller.Instance;

            return Invoke<GetDatalakeResponse>(request, options);
        }


        /// <summary>
        /// Retrieve the Security Lake configuration object for the specified account ID. This
        /// API does not take input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDatalake service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalake">REST API Reference for GetDatalake Operation</seealso>
        public virtual Task<GetDatalakeResponse> GetDatalakeAsync(GetDatalakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatalakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatalakeResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDatalakeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDatalakeAutoEnable


        /// <summary>
        /// Retrieves the configuration that will be automatically set up for accounts added to
        /// the organization after the organization has on boarded to Amazon Security Lake. This
        /// API does not take input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeAutoEnable service method.</param>
        /// 
        /// <returns>The response from the GetDatalakeAutoEnable service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeAutoEnable">REST API Reference for GetDatalakeAutoEnable Operation</seealso>
        public virtual GetDatalakeAutoEnableResponse GetDatalakeAutoEnable(GetDatalakeAutoEnableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatalakeAutoEnableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatalakeAutoEnableResponseUnmarshaller.Instance;

            return Invoke<GetDatalakeAutoEnableResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the configuration that will be automatically set up for accounts added to
        /// the organization after the organization has on boarded to Amazon Security Lake. This
        /// API does not take input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeAutoEnable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDatalakeAutoEnable service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeAutoEnable">REST API Reference for GetDatalakeAutoEnable Operation</seealso>
        public virtual Task<GetDatalakeAutoEnableResponse> GetDatalakeAutoEnableAsync(GetDatalakeAutoEnableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatalakeAutoEnableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatalakeAutoEnableResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDatalakeAutoEnableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDatalakeExceptionsExpiry


        /// <summary>
        /// Retrieves the expiration period and time-to-live (TTL) for which the exception message
        /// will remain. Exceptions are stored by default, for a 2 week period of time from when
        /// a record was created in Security Lake. This API does not take input parameters. This
        /// API does not take input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeExceptionsExpiry service method.</param>
        /// 
        /// <returns>The response from the GetDatalakeExceptionsExpiry service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeExceptionsExpiry">REST API Reference for GetDatalakeExceptionsExpiry Operation</seealso>
        public virtual GetDatalakeExceptionsExpiryResponse GetDatalakeExceptionsExpiry(GetDatalakeExceptionsExpiryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatalakeExceptionsExpiryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatalakeExceptionsExpiryResponseUnmarshaller.Instance;

            return Invoke<GetDatalakeExceptionsExpiryResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the expiration period and time-to-live (TTL) for which the exception message
        /// will remain. Exceptions are stored by default, for a 2 week period of time from when
        /// a record was created in Security Lake. This API does not take input parameters. This
        /// API does not take input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeExceptionsExpiry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDatalakeExceptionsExpiry service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeExceptionsExpiry">REST API Reference for GetDatalakeExceptionsExpiry Operation</seealso>
        public virtual Task<GetDatalakeExceptionsExpiryResponse> GetDatalakeExceptionsExpiryAsync(GetDatalakeExceptionsExpiryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatalakeExceptionsExpiryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatalakeExceptionsExpiryResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDatalakeExceptionsExpiryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDatalakeExceptionsSubscription


        /// <summary>
        /// Retrieves the details of exception notifications for the account in Amazon Security
        /// Lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeExceptionsSubscription service method.</param>
        /// 
        /// <returns>The response from the GetDatalakeExceptionsSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeExceptionsSubscription">REST API Reference for GetDatalakeExceptionsSubscription Operation</seealso>
        public virtual GetDatalakeExceptionsSubscriptionResponse GetDatalakeExceptionsSubscription(GetDatalakeExceptionsSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatalakeExceptionsSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatalakeExceptionsSubscriptionResponseUnmarshaller.Instance;

            return Invoke<GetDatalakeExceptionsSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the details of exception notifications for the account in Amazon Security
        /// Lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeExceptionsSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDatalakeExceptionsSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeExceptionsSubscription">REST API Reference for GetDatalakeExceptionsSubscription Operation</seealso>
        public virtual Task<GetDatalakeExceptionsSubscriptionResponse> GetDatalakeExceptionsSubscriptionAsync(GetDatalakeExceptionsSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatalakeExceptionsSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatalakeExceptionsSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDatalakeExceptionsSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDatalakeStatus


        /// <summary>
        /// Retrieve the Security Lake configuration object for the specified account ID. This
        /// API does not take input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeStatus service method.</param>
        /// 
        /// <returns>The response from the GetDatalakeStatus service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeStatus">REST API Reference for GetDatalakeStatus Operation</seealso>
        public virtual GetDatalakeStatusResponse GetDatalakeStatus(GetDatalakeStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatalakeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatalakeStatusResponseUnmarshaller.Instance;

            return Invoke<GetDatalakeStatusResponse>(request, options);
        }


        /// <summary>
        /// Retrieve the Security Lake configuration object for the specified account ID. This
        /// API does not take input parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatalakeStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDatalakeStatus service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetDatalakeStatus">REST API Reference for GetDatalakeStatus Operation</seealso>
        public virtual Task<GetDatalakeStatusResponse> GetDatalakeStatusAsync(GetDatalakeStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatalakeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatalakeStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDatalakeStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSubscriber


        /// <summary>
        /// Retrieves subscription information for the specified subscription ID.
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
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetSubscriber">REST API Reference for GetSubscriber Operation</seealso>
        public virtual GetSubscriberResponse GetSubscriber(GetSubscriberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriberResponseUnmarshaller.Instance;

            return Invoke<GetSubscriberResponse>(request, options);
        }


        /// <summary>
        /// Retrieves subscription information for the specified subscription ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscriber service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/GetSubscriber">REST API Reference for GetSubscriber Operation</seealso>
        public virtual Task<GetSubscriberResponse> GetSubscriberAsync(GetSubscriberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriberResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSubscriberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDatalakeExceptions


        /// <summary>
        /// List the Amazon Security Lake exceptions that you can use to find the source of problems
        /// and fix them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatalakeExceptions service method.</param>
        /// 
        /// <returns>The response from the ListDatalakeExceptions service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListDatalakeExceptions">REST API Reference for ListDatalakeExceptions Operation</seealso>
        public virtual ListDatalakeExceptionsResponse ListDatalakeExceptions(ListDatalakeExceptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatalakeExceptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatalakeExceptionsResponseUnmarshaller.Instance;

            return Invoke<ListDatalakeExceptionsResponse>(request, options);
        }


        /// <summary>
        /// List the Amazon Security Lake exceptions that you can use to find the source of problems
        /// and fix them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatalakeExceptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatalakeExceptions service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListDatalakeExceptions">REST API Reference for ListDatalakeExceptions Operation</seealso>
        public virtual Task<ListDatalakeExceptionsResponse> ListDatalakeExceptionsAsync(ListDatalakeExceptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatalakeExceptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatalakeExceptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDatalakeExceptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLogSources


        /// <summary>
        /// Lists the log sources in the current region.
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
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListLogSources">REST API Reference for ListLogSources Operation</seealso>
        public virtual ListLogSourcesResponse ListLogSources(ListLogSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLogSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogSourcesResponseUnmarshaller.Instance;

            return Invoke<ListLogSourcesResponse>(request, options);
        }


        /// <summary>
        /// Lists the log sources in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLogSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLogSources service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListLogSources">REST API Reference for ListLogSources Operation</seealso>
        public virtual Task<ListLogSourcesResponse> ListLogSourcesAsync(ListLogSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLogSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogSourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListLogSourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSubscribers


        /// <summary>
        /// List all subscribers for the specific Security Lake account ID.
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
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListSubscribers">REST API Reference for ListSubscribers Operation</seealso>
        public virtual ListSubscribersResponse ListSubscribers(ListSubscribersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscribersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscribersResponseUnmarshaller.Instance;

            return Invoke<ListSubscribersResponse>(request, options);
        }


        /// <summary>
        /// List all subscribers for the specific Security Lake account ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscribers service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/ListSubscribers">REST API Reference for ListSubscribers Operation</seealso>
        public virtual Task<ListSubscribersResponse> ListSubscribersAsync(ListSubscribersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSubscribersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscribersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSubscribersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDatalake


        /// <summary>
        /// Amazon Security Lake allows you to specify where to store your security data and for
        /// how long. You can specify a rollup Region to consolidate data from multiple regions.
        /// 
        /// 
        ///  
        /// <para>
        /// You can update the properties of a Region or source. Input can either be directly
        /// specified to the API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatalake service method.</param>
        /// 
        /// <returns>The response from the UpdateDatalake service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.EventBridgeException">
        /// Represents an error interacting with the Amazon EventBridge service.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDatalake">REST API Reference for UpdateDatalake Operation</seealso>
        public virtual UpdateDatalakeResponse UpdateDatalake(UpdateDatalakeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatalakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatalakeResponseUnmarshaller.Instance;

            return Invoke<UpdateDatalakeResponse>(request, options);
        }


        /// <summary>
        /// Amazon Security Lake allows you to specify where to store your security data and for
        /// how long. You can specify a rollup Region to consolidate data from multiple regions.
        /// 
        /// 
        ///  
        /// <para>
        /// You can update the properties of a Region or source. Input can either be directly
        /// specified to the API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatalake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDatalake service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.EventBridgeException">
        /// Represents an error interacting with the Amazon EventBridge service.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDatalake">REST API Reference for UpdateDatalake Operation</seealso>
        public virtual Task<UpdateDatalakeResponse> UpdateDatalakeAsync(UpdateDatalakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatalakeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatalakeResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDatalakeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDatalakeExceptionsExpiry


        /// <summary>
        /// Update the expiration period for the exception message to your preferred time, and
        /// control the time-to-live (TTL) for the exception message to remain. Exceptions are
        /// stored by default, for a 2 week period of time from when a record was created in Security
        /// Lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatalakeExceptionsExpiry service method.</param>
        /// 
        /// <returns>The response from the UpdateDatalakeExceptionsExpiry service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDatalakeExceptionsExpiry">REST API Reference for UpdateDatalakeExceptionsExpiry Operation</seealso>
        public virtual UpdateDatalakeExceptionsExpiryResponse UpdateDatalakeExceptionsExpiry(UpdateDatalakeExceptionsExpiryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatalakeExceptionsExpiryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatalakeExceptionsExpiryResponseUnmarshaller.Instance;

            return Invoke<UpdateDatalakeExceptionsExpiryResponse>(request, options);
        }


        /// <summary>
        /// Update the expiration period for the exception message to your preferred time, and
        /// control the time-to-live (TTL) for the exception message to remain. Exceptions are
        /// stored by default, for a 2 week period of time from when a record was created in Security
        /// Lake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatalakeExceptionsExpiry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDatalakeExceptionsExpiry service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDatalakeExceptionsExpiry">REST API Reference for UpdateDatalakeExceptionsExpiry Operation</seealso>
        public virtual Task<UpdateDatalakeExceptionsExpiryResponse> UpdateDatalakeExceptionsExpiryAsync(UpdateDatalakeExceptionsExpiryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatalakeExceptionsExpiryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatalakeExceptionsExpiryResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDatalakeExceptionsExpiryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDatalakeExceptionsSubscription


        /// <summary>
        /// Update the subscription notification for exception notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatalakeExceptionsSubscription service method.</param>
        /// 
        /// <returns>The response from the UpdateDatalakeExceptionsSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDatalakeExceptionsSubscription">REST API Reference for UpdateDatalakeExceptionsSubscription Operation</seealso>
        public virtual UpdateDatalakeExceptionsSubscriptionResponse UpdateDatalakeExceptionsSubscription(UpdateDatalakeExceptionsSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatalakeExceptionsSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatalakeExceptionsSubscriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateDatalakeExceptionsSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Update the subscription notification for exception notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatalakeExceptionsSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDatalakeExceptionsSubscription service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateDatalakeExceptionsSubscription">REST API Reference for UpdateDatalakeExceptionsSubscription Operation</seealso>
        public virtual Task<UpdateDatalakeExceptionsSubscriptionResponse> UpdateDatalakeExceptionsSubscriptionAsync(UpdateDatalakeExceptionsSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatalakeExceptionsSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatalakeExceptionsSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDatalakeExceptionsSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSubscriber


        /// <summary>
        /// Update the subscription permission for the given Security Lake account ID.
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
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictSubscriptionException">
        /// A conflicting subscription exception operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateSubscriber">REST API Reference for UpdateSubscriber Operation</seealso>
        public virtual UpdateSubscriberResponse UpdateSubscriber(UpdateSubscriberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriberResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriberResponse>(request, options);
        }


        /// <summary>
        /// Update the subscription permission for the given Security Lake account ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubscriber service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConflictSubscriptionException">
        /// A conflicting subscription exception operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateSubscriber">REST API Reference for UpdateSubscriber Operation</seealso>
        public virtual Task<UpdateSubscriberResponse> UpdateSubscriberAsync(UpdateSubscriberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubscriberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriberResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSubscriberResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSubscriptionNotificationConfiguration


        /// <summary>
        /// Create a new subscription notification or add the existing subscription notification
        /// setting for the specified subscription ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscriptionNotificationConfiguration service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateSubscriptionNotificationConfiguration">REST API Reference for UpdateSubscriptionNotificationConfiguration Operation</seealso>
        public virtual UpdateSubscriptionNotificationConfigurationResponse UpdateSubscriptionNotificationConfiguration(UpdateSubscriptionNotificationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriptionNotificationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Create a new subscription notification or add the existing subscription notification
        /// setting for the specified subscription ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubscriptionNotificationConfiguration service method, as returned by SecurityLake.</returns>
        /// <exception cref="Amazon.SecurityLake.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Access denied errors appear
        /// when Amazon Security Lake explicitly or implicitly denies an authorization request.
        /// An explicit denial occurs when a policy contains a Deny statement for the specific
        /// Amazon Web Services action. An implicit denial occurs when there is no applicable
        /// Deny statement and also no applicable Allow statement.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.AccountNotFoundException">
        /// Amazon Security Lake can't find an Amazon Web Services account with the accountID
        /// that you specified, or the account whose credentials you used to make this request
        /// isn't a member of an organization.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InternalServerException">
        /// Internal service exceptions are sometimes caused by transient issues. Before you start
        /// troubleshooting, perform the operation again.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SecurityLake.Model.ValidationException">
        /// Your signing certificate could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securitylake-2018-05-10/UpdateSubscriptionNotificationConfiguration">REST API Reference for UpdateSubscriptionNotificationConfiguration Operation</seealso>
        public virtual Task<UpdateSubscriptionNotificationConfigurationResponse> UpdateSubscriptionNotificationConfigurationAsync(UpdateSubscriptionNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionNotificationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSubscriptionNotificationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}