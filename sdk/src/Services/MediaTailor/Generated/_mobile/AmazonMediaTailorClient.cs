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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.MediaTailor.Model;
using Amazon.MediaTailor.Model.Internal.MarshallTransformations;
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
    public partial class AmazonMediaTailorClient : AmazonServiceClient, IAmazonMediaTailor
    {
        
        #region Constructors

#if CORECLR
    
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

#endif

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
            var marshaller = DeletePlaybackConfigurationRequestMarshaller.Instance;
            var unmarshaller = DeletePlaybackConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeletePlaybackConfigurationRequest,DeletePlaybackConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaybackConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePlaybackConfiguration">REST API Reference for DeletePlaybackConfiguration Operation</seealso>
        public virtual Task<DeletePlaybackConfigurationResponse> DeletePlaybackConfigurationAsync(DeletePlaybackConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeletePlaybackConfigurationRequestMarshaller.Instance;
            var unmarshaller = DeletePlaybackConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePlaybackConfigurationRequest,DeletePlaybackConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPlaybackConfiguration

        internal virtual GetPlaybackConfigurationResponse GetPlaybackConfiguration(GetPlaybackConfigurationRequest request)
        {
            var marshaller = GetPlaybackConfigurationRequestMarshaller.Instance;
            var unmarshaller = GetPlaybackConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetPlaybackConfigurationRequest,GetPlaybackConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetPlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlaybackConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPlaybackConfiguration">REST API Reference for GetPlaybackConfiguration Operation</seealso>
        public virtual Task<GetPlaybackConfigurationResponse> GetPlaybackConfigurationAsync(GetPlaybackConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetPlaybackConfigurationRequestMarshaller.Instance;
            var unmarshaller = GetPlaybackConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetPlaybackConfigurationRequest,GetPlaybackConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPlaybackConfigurations

        internal virtual ListPlaybackConfigurationsResponse ListPlaybackConfigurations(ListPlaybackConfigurationsRequest request)
        {
            var marshaller = ListPlaybackConfigurationsRequestMarshaller.Instance;
            var unmarshaller = ListPlaybackConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListPlaybackConfigurationsRequest,ListPlaybackConfigurationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPlaybackConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlaybackConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPlaybackConfigurations">REST API Reference for ListPlaybackConfigurations Operation</seealso>
        public virtual Task<ListPlaybackConfigurationsResponse> ListPlaybackConfigurationsAsync(ListPlaybackConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListPlaybackConfigurationsRequestMarshaller.Instance;
            var unmarshaller = ListPlaybackConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPlaybackConfigurationsRequest,ListPlaybackConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutPlaybackConfiguration

        internal virtual PutPlaybackConfigurationResponse PutPlaybackConfiguration(PutPlaybackConfigurationRequest request)
        {
            var marshaller = PutPlaybackConfigurationRequestMarshaller.Instance;
            var unmarshaller = PutPlaybackConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutPlaybackConfigurationRequest,PutPlaybackConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutPlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPlaybackConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutPlaybackConfiguration">REST API Reference for PutPlaybackConfiguration Operation</seealso>
        public virtual Task<PutPlaybackConfigurationResponse> PutPlaybackConfigurationAsync(PutPlaybackConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutPlaybackConfigurationRequestMarshaller.Instance;
            var unmarshaller = PutPlaybackConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutPlaybackConfigurationRequest,PutPlaybackConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}