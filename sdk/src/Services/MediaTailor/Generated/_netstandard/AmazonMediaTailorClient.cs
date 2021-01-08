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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MediaTailor.Model;
using Amazon.MediaTailor.Model.Internal.MarshallTransformations;
using Amazon.MediaTailor.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MediaTailor
{
    /// <summary>
    /// Implementation for accessing MediaTailor
    ///
    /// Use the AWS Elemental MediaTailor SDK to configure scalable ad insertion for your
    /// live and VOD content. With AWS Elemental MediaTailor, you can serve targeted ads to
    /// viewers while maintaining broadcast quality in over-the-top (OTT) video applications.
    /// For information about using the service, including detailed information about the
    /// settings covered in this guide, see the AWS Elemental MediaTailor User Guide.
    /// <para>
    /// Through the SDK, you manage AWS Elemental MediaTailor configurations the same as you
    /// do through the console. For example, you specify ad insertion behavior and mapping
    /// information for the origin server and the ad decision server (ADS).
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonMediaTailorClient : AmazonServiceClient, IAmazonMediaTailor
    {
        private static IServiceMetadata serviceMetadata = new AmazonMediaTailorMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonMediaTailorClient with the credentials loaded from the application's
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
        public AmazonMediaTailorClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaTailorConfig()) { }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with the credentials loaded from the application's
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
        public AmazonMediaTailorClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMediaTailorConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMediaTailorClient Configuration Object</param>
        public AmazonMediaTailorClient(AmazonMediaTailorConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonMediaTailorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMediaTailorClient(AWSCredentials credentials)
            : this(credentials, new AmazonMediaTailorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaTailorClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMediaTailorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with AWS Credentials and an
        /// AmazonMediaTailorClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMediaTailorClient Configuration Object</param>
        public AmazonMediaTailorClient(AWSCredentials credentials, AmazonMediaTailorConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMediaTailorClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaTailorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaTailorClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMediaTailorConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaTailorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMediaTailorClient Configuration Object</param>
        public AmazonMediaTailorClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMediaTailorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMediaTailorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaTailorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMediaTailorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMediaTailorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMediaTailorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMediaTailorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMediaTailorClient Configuration Object</param>
        public AmazonMediaTailorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMediaTailorConfig clientConfig)
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


        #region  DeletePlaybackConfiguration

        internal virtual DeletePlaybackConfigurationResponse DeletePlaybackConfiguration(DeletePlaybackConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlaybackConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeletePlaybackConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes the playback configuration for the specified name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaybackConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePlaybackConfiguration">REST API Reference for DeletePlaybackConfiguration Operation</seealso>
        public virtual Task<DeletePlaybackConfigurationResponse> DeletePlaybackConfigurationAsync(DeletePlaybackConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlaybackConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePlaybackConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPlaybackConfiguration

        internal virtual GetPlaybackConfigurationResponse GetPlaybackConfiguration(GetPlaybackConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaybackConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetPlaybackConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Returns the playback configuration for the specified name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlaybackConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPlaybackConfiguration">REST API Reference for GetPlaybackConfiguration Operation</seealso>
        public virtual Task<GetPlaybackConfigurationResponse> GetPlaybackConfigurationAsync(GetPlaybackConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaybackConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetPlaybackConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPlaybackConfigurations

        internal virtual ListPlaybackConfigurationsResponse ListPlaybackConfigurations(ListPlaybackConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlaybackConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlaybackConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListPlaybackConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the playback configurations defined in AWS Elemental MediaTailor.
        /// You can specify a maximum number of configurations to return at a time. The default
        /// maximum is 50. Results are returned in pagefuls. If MediaTailor has more configurations
        /// than the specified maximum, it provides parameters in the response that you can use
        /// to retrieve the next pageful.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlaybackConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPlaybackConfigurations service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPlaybackConfigurations">REST API Reference for ListPlaybackConfigurations Operation</seealso>
        public virtual Task<ListPlaybackConfigurationsResponse> ListPlaybackConfigurationsAsync(ListPlaybackConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlaybackConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlaybackConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPlaybackConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the tags assigned to the specified playback configuration resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// Invalid request parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutPlaybackConfiguration

        internal virtual PutPlaybackConfigurationResponse PutPlaybackConfiguration(PutPlaybackConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPlaybackConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutPlaybackConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Adds a new playback configuration to AWS Elemental MediaTailor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPlaybackConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutPlaybackConfiguration">REST API Reference for PutPlaybackConfiguration Operation</seealso>
        public virtual Task<PutPlaybackConfigurationResponse> PutPlaybackConfigurationAsync(PutPlaybackConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPlaybackConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutPlaybackConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds tags to the specified playback configuration resource. You can specify one or
        /// more tags to add.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// Invalid request parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes tags from the specified playback configuration resource. You can specify one
        /// or more tags to remove.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// Invalid request parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}