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

        /// <summary>
        /// Deletes the playback configuration for the specified name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaybackConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeletePlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePlaybackConfiguration">REST API Reference for DeletePlaybackConfiguration Operation</seealso>
        public virtual DeletePlaybackConfigurationResponse DeletePlaybackConfiguration(DeletePlaybackConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlaybackConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeletePlaybackConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaybackConfiguration operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePlaybackConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePlaybackConfiguration">REST API Reference for DeletePlaybackConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeletePlaybackConfiguration(DeletePlaybackConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlaybackConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlaybackConfiguration.</param>
        /// 
        /// <returns>Returns a  DeletePlaybackConfigurationResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/DeletePlaybackConfiguration">REST API Reference for DeletePlaybackConfiguration Operation</seealso>
        public virtual DeletePlaybackConfigurationResponse EndDeletePlaybackConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePlaybackConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPlaybackConfiguration

        /// <summary>
        /// Returns the playback configuration for the specified name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlaybackConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPlaybackConfiguration">REST API Reference for GetPlaybackConfiguration Operation</seealso>
        public virtual GetPlaybackConfigurationResponse GetPlaybackConfiguration(GetPlaybackConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaybackConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetPlaybackConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlaybackConfiguration operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPlaybackConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPlaybackConfiguration">REST API Reference for GetPlaybackConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetPlaybackConfiguration(GetPlaybackConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaybackConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlaybackConfiguration.</param>
        /// 
        /// <returns>Returns a  GetPlaybackConfigurationResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/GetPlaybackConfiguration">REST API Reference for GetPlaybackConfiguration Operation</seealso>
        public virtual GetPlaybackConfigurationResponse EndGetPlaybackConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPlaybackConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPlaybackConfigurations

        /// <summary>
        /// Returns a list of the playback configurations defined in AWS Elemental MediaTailor.
        /// You can specify a maximum number of configurations to return at a time. The default
        /// maximum is 50. Results are returned in pagefuls. If MediaTailor has more configurations
        /// than the specified maximum, it provides parameters in the response that you can use
        /// to retrieve the next pageful.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlaybackConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListPlaybackConfigurations service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPlaybackConfigurations">REST API Reference for ListPlaybackConfigurations Operation</seealso>
        public virtual ListPlaybackConfigurationsResponse ListPlaybackConfigurations(ListPlaybackConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlaybackConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlaybackConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListPlaybackConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPlaybackConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlaybackConfigurations operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPlaybackConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPlaybackConfigurations">REST API Reference for ListPlaybackConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListPlaybackConfigurations(ListPlaybackConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlaybackConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlaybackConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPlaybackConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPlaybackConfigurations.</param>
        /// 
        /// <returns>Returns a  ListPlaybackConfigurationsResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListPlaybackConfigurations">REST API Reference for ListPlaybackConfigurations Operation</seealso>
        public virtual ListPlaybackConfigurationsResponse EndListPlaybackConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPlaybackConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns a list of the tags assigned to the specified playback configuration resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// Invalid request parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutPlaybackConfiguration

        /// <summary>
        /// Adds a new playback configuration to AWS Elemental MediaTailor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPlaybackConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutPlaybackConfiguration service method, as returned by MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutPlaybackConfiguration">REST API Reference for PutPlaybackConfiguration Operation</seealso>
        public virtual PutPlaybackConfigurationResponse PutPlaybackConfiguration(PutPlaybackConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPlaybackConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutPlaybackConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutPlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPlaybackConfiguration operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPlaybackConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutPlaybackConfiguration">REST API Reference for PutPlaybackConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutPlaybackConfiguration(PutPlaybackConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPlaybackConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPlaybackConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutPlaybackConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPlaybackConfiguration.</param>
        /// 
        /// <returns>Returns a  PutPlaybackConfigurationResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/PutPlaybackConfiguration">REST API Reference for PutPlaybackConfiguration Operation</seealso>
        public virtual PutPlaybackConfigurationResponse EndPutPlaybackConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutPlaybackConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds tags to the specified playback configuration resource. You can specify one or
        /// more tags to add.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// Invalid request parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from the specified playback configuration resource. You can specify one
        /// or more tags to remove.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MediaTailor.</returns>
        /// <exception cref="Amazon.MediaTailor.Model.BadRequestException">
        /// Invalid request parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMediaTailorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from MediaTailor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediatailor-2018-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
    }
}