/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.LicenseManager.Model;
using Amazon.LicenseManager.Model.Internal.MarshallTransformations;
using Amazon.LicenseManager.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.LicenseManager
{
    /// <summary>
    /// Implementation for accessing LicenseManager
    ///
    /// AWS License Manager  
    /// <para>
    ///  <i>This is the AWS License Manager API Reference.</i> It provides descriptions, syntax,
    /// and usage examples for each of the actions and data types for License Manager. The
    /// topic for each action shows the Query API request parameters and the XML response.
    /// You can also view the XML request elements in the WSDL. 
    /// </para>
    ///  
    /// <para>
    ///  Alternatively, you can use one of the AWS SDKs to access an API that's tailored to
    /// the programming language or platform that you're using. For more information, see
    /// <a href="http://aws.amazon.com/tools/#SDKs">AWS SDKs</a>. 
    /// </para>
    /// </summary>
    public partial class AmazonLicenseManagerClient : AmazonServiceClient, IAmazonLicenseManager
    {
        private static IServiceMetadata serviceMetadata = new AmazonLicenseManagerMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonLicenseManagerClient with the credentials loaded from the application's
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
        public AmazonLicenseManagerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLicenseManagerConfig()) { }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with the credentials loaded from the application's
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
        public AmazonLicenseManagerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLicenseManagerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLicenseManagerClient Configuration Object</param>
        public AmazonLicenseManagerClient(AmazonLicenseManagerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLicenseManagerClient(AWSCredentials credentials)
            : this(credentials, new AmazonLicenseManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLicenseManagerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLicenseManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Credentials and an
        /// AmazonLicenseManagerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLicenseManagerClient Configuration Object</param>
        public AmazonLicenseManagerClient(AWSCredentials credentials, AmazonLicenseManagerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLicenseManagerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLicenseManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLicenseManagerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLicenseManagerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLicenseManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLicenseManagerClient Configuration Object</param>
        public AmazonLicenseManagerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLicenseManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLicenseManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLicenseManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLicenseManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLicenseManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLicenseManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLicenseManagerClient Configuration Object</param>
        public AmazonLicenseManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLicenseManagerConfig clientConfig)
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

        
        #region  CreateLicenseConfiguration

        internal virtual CreateLicenseConfigurationResponse CreateLicenseConfiguration(CreateLicenseConfigurationRequest request)
        {
            var marshaller = CreateLicenseConfigurationRequestMarshaller.Instance;
            var unmarshaller = CreateLicenseConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateLicenseConfigurationRequest,CreateLicenseConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseConfiguration">REST API Reference for CreateLicenseConfiguration Operation</seealso>
        public virtual Task<CreateLicenseConfigurationResponse> CreateLicenseConfigurationAsync(CreateLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateLicenseConfigurationRequestMarshaller.Instance;
            var unmarshaller = CreateLicenseConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLicenseConfigurationRequest,CreateLicenseConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLicenseConfiguration

        internal virtual DeleteLicenseConfigurationResponse DeleteLicenseConfiguration(DeleteLicenseConfigurationRequest request)
        {
            var marshaller = DeleteLicenseConfigurationRequestMarshaller.Instance;
            var unmarshaller = DeleteLicenseConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLicenseConfigurationRequest,DeleteLicenseConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicenseConfiguration">REST API Reference for DeleteLicenseConfiguration Operation</seealso>
        public virtual Task<DeleteLicenseConfigurationResponse> DeleteLicenseConfigurationAsync(DeleteLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteLicenseConfigurationRequestMarshaller.Instance;
            var unmarshaller = DeleteLicenseConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLicenseConfigurationRequest,DeleteLicenseConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetLicenseConfiguration

        internal virtual GetLicenseConfigurationResponse GetLicenseConfiguration(GetLicenseConfigurationRequest request)
        {
            var marshaller = GetLicenseConfigurationRequestMarshaller.Instance;
            var unmarshaller = GetLicenseConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetLicenseConfigurationRequest,GetLicenseConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseConfiguration">REST API Reference for GetLicenseConfiguration Operation</seealso>
        public virtual Task<GetLicenseConfigurationResponse> GetLicenseConfigurationAsync(GetLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetLicenseConfigurationRequestMarshaller.Instance;
            var unmarshaller = GetLicenseConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetLicenseConfigurationRequest,GetLicenseConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetServiceSettings

        internal virtual GetServiceSettingsResponse GetServiceSettings(GetServiceSettingsRequest request)
        {
            var marshaller = GetServiceSettingsRequestMarshaller.Instance;
            var unmarshaller = GetServiceSettingsResponseUnmarshaller.Instance;

            return Invoke<GetServiceSettingsRequest,GetServiceSettingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        public virtual Task<GetServiceSettingsResponse> GetServiceSettingsAsync(GetServiceSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetServiceSettingsRequestMarshaller.Instance;
            var unmarshaller = GetServiceSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceSettingsRequest,GetServiceSettingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAssociationsForLicenseConfiguration

        internal virtual ListAssociationsForLicenseConfigurationResponse ListAssociationsForLicenseConfiguration(ListAssociationsForLicenseConfigurationRequest request)
        {
            var marshaller = ListAssociationsForLicenseConfigurationRequestMarshaller.Instance;
            var unmarshaller = ListAssociationsForLicenseConfigurationResponseUnmarshaller.Instance;

            return Invoke<ListAssociationsForLicenseConfigurationRequest,ListAssociationsForLicenseConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociationsForLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociationsForLicenseConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListAssociationsForLicenseConfiguration">REST API Reference for ListAssociationsForLicenseConfiguration Operation</seealso>
        public virtual Task<ListAssociationsForLicenseConfigurationResponse> ListAssociationsForLicenseConfigurationAsync(ListAssociationsForLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAssociationsForLicenseConfigurationRequestMarshaller.Instance;
            var unmarshaller = ListAssociationsForLicenseConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssociationsForLicenseConfigurationRequest,ListAssociationsForLicenseConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListLicenseConfigurations

        internal virtual ListLicenseConfigurationsResponse ListLicenseConfigurations(ListLicenseConfigurationsRequest request)
        {
            var marshaller = ListLicenseConfigurationsRequestMarshaller.Instance;
            var unmarshaller = ListLicenseConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListLicenseConfigurationsRequest,ListLicenseConfigurationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListLicenseConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseConfigurations">REST API Reference for ListLicenseConfigurations Operation</seealso>
        public virtual Task<ListLicenseConfigurationsResponse> ListLicenseConfigurationsAsync(ListLicenseConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListLicenseConfigurationsRequestMarshaller.Instance;
            var unmarshaller = ListLicenseConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLicenseConfigurationsRequest,ListLicenseConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListLicenseSpecificationsForResource

        internal virtual ListLicenseSpecificationsForResourceResponse ListLicenseSpecificationsForResource(ListLicenseSpecificationsForResourceRequest request)
        {
            var marshaller = ListLicenseSpecificationsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListLicenseSpecificationsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListLicenseSpecificationsForResourceRequest,ListLicenseSpecificationsForResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListLicenseSpecificationsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseSpecificationsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseSpecificationsForResource">REST API Reference for ListLicenseSpecificationsForResource Operation</seealso>
        public virtual Task<ListLicenseSpecificationsForResourceResponse> ListLicenseSpecificationsForResourceAsync(ListLicenseSpecificationsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListLicenseSpecificationsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListLicenseSpecificationsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListLicenseSpecificationsForResourceRequest,ListLicenseSpecificationsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListResourceInventory

        internal virtual ListResourceInventoryResponse ListResourceInventory(ListResourceInventoryRequest request)
        {
            var marshaller = ListResourceInventoryRequestMarshaller.Instance;
            var unmarshaller = ListResourceInventoryResponseUnmarshaller.Instance;

            return Invoke<ListResourceInventoryRequest,ListResourceInventoryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceInventory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceInventory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListResourceInventory">REST API Reference for ListResourceInventory Operation</seealso>
        public virtual Task<ListResourceInventoryResponse> ListResourceInventoryAsync(ListResourceInventoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListResourceInventoryRequestMarshaller.Instance;
            var unmarshaller = ListResourceInventoryResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceInventoryRequest,ListResourceInventoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListUsageForLicenseConfiguration

        internal virtual ListUsageForLicenseConfigurationResponse ListUsageForLicenseConfiguration(ListUsageForLicenseConfigurationRequest request)
        {
            var marshaller = ListUsageForLicenseConfigurationRequestMarshaller.Instance;
            var unmarshaller = ListUsageForLicenseConfigurationResponseUnmarshaller.Instance;

            return Invoke<ListUsageForLicenseConfigurationRequest,ListUsageForLicenseConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListUsageForLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsageForLicenseConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListUsageForLicenseConfiguration">REST API Reference for ListUsageForLicenseConfiguration Operation</seealso>
        public virtual Task<ListUsageForLicenseConfigurationResponse> ListUsageForLicenseConfigurationAsync(ListUsageForLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListUsageForLicenseConfigurationRequestMarshaller.Instance;
            var unmarshaller = ListUsageForLicenseConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<ListUsageForLicenseConfigurationRequest,ListUsageForLicenseConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceRequest,TagResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceRequest,TagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceRequest,UntagResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceRequest,UntagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateLicenseConfiguration

        internal virtual UpdateLicenseConfigurationResponse UpdateLicenseConfiguration(UpdateLicenseConfigurationRequest request)
        {
            var marshaller = UpdateLicenseConfigurationRequestMarshaller.Instance;
            var unmarshaller = UpdateLicenseConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateLicenseConfigurationRequest,UpdateLicenseConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLicenseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseConfiguration">REST API Reference for UpdateLicenseConfiguration Operation</seealso>
        public virtual Task<UpdateLicenseConfigurationResponse> UpdateLicenseConfigurationAsync(UpdateLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateLicenseConfigurationRequestMarshaller.Instance;
            var unmarshaller = UpdateLicenseConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLicenseConfigurationRequest,UpdateLicenseConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateLicenseSpecificationsForResource

        internal virtual UpdateLicenseSpecificationsForResourceResponse UpdateLicenseSpecificationsForResource(UpdateLicenseSpecificationsForResourceRequest request)
        {
            var marshaller = UpdateLicenseSpecificationsForResourceRequestMarshaller.Instance;
            var unmarshaller = UpdateLicenseSpecificationsForResourceResponseUnmarshaller.Instance;

            return Invoke<UpdateLicenseSpecificationsForResourceRequest,UpdateLicenseSpecificationsForResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLicenseSpecificationsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseSpecificationsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseSpecificationsForResource">REST API Reference for UpdateLicenseSpecificationsForResource Operation</seealso>
        public virtual Task<UpdateLicenseSpecificationsForResourceResponse> UpdateLicenseSpecificationsForResourceAsync(UpdateLicenseSpecificationsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateLicenseSpecificationsForResourceRequestMarshaller.Instance;
            var unmarshaller = UpdateLicenseSpecificationsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLicenseSpecificationsForResourceRequest,UpdateLicenseSpecificationsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateServiceSettings

        internal virtual UpdateServiceSettingsResponse UpdateServiceSettings(UpdateServiceSettingsRequest request)
        {
            var marshaller = UpdateServiceSettingsRequestMarshaller.Instance;
            var unmarshaller = UpdateServiceSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceSettingsRequest,UpdateServiceSettingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        public virtual Task<UpdateServiceSettingsResponse> UpdateServiceSettingsAsync(UpdateServiceSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateServiceSettingsRequestMarshaller.Instance;
            var unmarshaller = UpdateServiceSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServiceSettingsRequest,UpdateServiceSettingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}