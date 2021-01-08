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
 * Do not modify this file. This file is generated from the elastic-inference-2017-07-25.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ElasticInference.Model;
using Amazon.ElasticInference.Model.Internal.MarshallTransformations;
using Amazon.ElasticInference.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticInference
{
    /// <summary>
    /// Implementation for accessing ElasticInference
    ///
    /// Elastic Inference public APIs.
    /// </summary>
    public partial class AmazonElasticInferenceClient : AmazonServiceClient, IAmazonElasticInference
    {
        private static IServiceMetadata serviceMetadata = new AmazonElasticInferenceMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with the credentials loaded from the application's
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
        public AmazonElasticInferenceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticInferenceConfig()) { }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with the credentials loaded from the application's
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
        public AmazonElasticInferenceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticInferenceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElasticInferenceClient Configuration Object</param>
        public AmazonElasticInferenceClient(AmazonElasticInferenceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticInferenceClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticInferenceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticInferenceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticInferenceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with AWS Credentials and an
        /// AmazonElasticInferenceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticInferenceClient Configuration Object</param>
        public AmazonElasticInferenceClient(AWSCredentials credentials, AmazonElasticInferenceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticInferenceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticInferenceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticInferenceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticInferenceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticInferenceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticInferenceClient Configuration Object</param>
        public AmazonElasticInferenceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticInferenceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticInferenceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticInferenceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticInferenceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticInferenceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticInferenceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticInferenceClient Configuration Object</param>
        public AmazonElasticInferenceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticInferenceConfig clientConfig)
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


        #region  DescribeAcceleratorOfferings

        /// <summary>
        /// Describes the locations in which a given accelerator type or set of types is present
        /// in a given region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcceleratorOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeAcceleratorOfferings service method, as returned by ElasticInference.</returns>
        /// <exception cref="Amazon.ElasticInference.Model.BadRequestException">
        /// Raised when a malformed input has been provided to the API.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.InternalServerException">
        /// Raised when an unexpected error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.ResourceNotFoundException">
        /// Raised when the requested resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAcceleratorOfferings">REST API Reference for DescribeAcceleratorOfferings Operation</seealso>
        public virtual DescribeAcceleratorOfferingsResponse DescribeAcceleratorOfferings(DescribeAcceleratorOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAcceleratorOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcceleratorOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeAcceleratorOfferingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAcceleratorOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcceleratorOfferings operation on AmazonElasticInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAcceleratorOfferings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAcceleratorOfferings">REST API Reference for DescribeAcceleratorOfferings Operation</seealso>
        public virtual IAsyncResult BeginDescribeAcceleratorOfferings(DescribeAcceleratorOfferingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAcceleratorOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcceleratorOfferingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAcceleratorOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAcceleratorOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeAcceleratorOfferingsResult from ElasticInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAcceleratorOfferings">REST API Reference for DescribeAcceleratorOfferings Operation</seealso>
        public virtual DescribeAcceleratorOfferingsResponse EndDescribeAcceleratorOfferings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAcceleratorOfferingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccelerators

        /// <summary>
        /// Describes information over a provided set of accelerators belonging to an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccelerators service method.</param>
        /// 
        /// <returns>The response from the DescribeAccelerators service method, as returned by ElasticInference.</returns>
        /// <exception cref="Amazon.ElasticInference.Model.BadRequestException">
        /// Raised when a malformed input has been provided to the API.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.InternalServerException">
        /// Raised when an unexpected error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.ResourceNotFoundException">
        /// Raised when the requested resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAccelerators">REST API Reference for DescribeAccelerators Operation</seealso>
        public virtual DescribeAcceleratorsResponse DescribeAccelerators(DescribeAcceleratorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAcceleratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcceleratorsResponseUnmarshaller.Instance;

            return Invoke<DescribeAcceleratorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccelerators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccelerators operation on AmazonElasticInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccelerators
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAccelerators">REST API Reference for DescribeAccelerators Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccelerators(DescribeAcceleratorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAcceleratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcceleratorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccelerators operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccelerators.</param>
        /// 
        /// <returns>Returns a  DescribeAcceleratorsResult from ElasticInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAccelerators">REST API Reference for DescribeAccelerators Operation</seealso>
        public virtual DescribeAcceleratorsResponse EndDescribeAccelerators(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAcceleratorsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAcceleratorTypes

        /// <summary>
        /// Describes the accelerator types available in a given region, as well as their characteristics,
        /// such as memory and throughput.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcceleratorTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeAcceleratorTypes service method, as returned by ElasticInference.</returns>
        /// <exception cref="Amazon.ElasticInference.Model.InternalServerException">
        /// Raised when an unexpected error occurred during request processing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAcceleratorTypes">REST API Reference for DescribeAcceleratorTypes Operation</seealso>
        public virtual DescribeAcceleratorTypesResponse DescribeAcceleratorTypes(DescribeAcceleratorTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAcceleratorTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcceleratorTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeAcceleratorTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAcceleratorTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcceleratorTypes operation on AmazonElasticInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAcceleratorTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAcceleratorTypes">REST API Reference for DescribeAcceleratorTypes Operation</seealso>
        public virtual IAsyncResult BeginDescribeAcceleratorTypes(DescribeAcceleratorTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAcceleratorTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcceleratorTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAcceleratorTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAcceleratorTypes.</param>
        /// 
        /// <returns>Returns a  DescribeAcceleratorTypesResult from ElasticInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAcceleratorTypes">REST API Reference for DescribeAcceleratorTypes Operation</seealso>
        public virtual DescribeAcceleratorTypesResponse EndDescribeAcceleratorTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAcceleratorTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns all tags of an Elastic Inference Accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ElasticInference.</returns>
        /// <exception cref="Amazon.ElasticInference.Model.BadRequestException">
        /// Raised when a malformed input has been provided to the API.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.InternalServerException">
        /// Raised when an unexpected error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.ResourceNotFoundException">
        /// Raised when the requested resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonElasticInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from ElasticInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds the specified tags to an Elastic Inference Accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ElasticInference.</returns>
        /// <exception cref="Amazon.ElasticInference.Model.BadRequestException">
        /// Raised when a malformed input has been provided to the API.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.InternalServerException">
        /// Raised when an unexpected error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.ResourceNotFoundException">
        /// Raised when the requested resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonElasticInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from ElasticInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes the specified tags from an Elastic Inference Accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ElasticInference.</returns>
        /// <exception cref="Amazon.ElasticInference.Model.BadRequestException">
        /// Raised when a malformed input has been provided to the API.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.InternalServerException">
        /// Raised when an unexpected error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.ResourceNotFoundException">
        /// Raised when the requested resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonElasticInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from ElasticInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
    }
}