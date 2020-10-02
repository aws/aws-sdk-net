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
 * Do not modify this file. This file is generated from the personalize-events-2018-03-22.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.PersonalizeEvents.Model;
using Amazon.PersonalizeEvents.Model.Internal.MarshallTransformations;
using Amazon.PersonalizeEvents.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.PersonalizeEvents
{
    /// <summary>
    /// Implementation for accessing PersonalizeEvents
    ///
    /// Amazon Personalize can consume real-time user event data, such as <i>stream</i> or
    /// <i>click</i> data, and use it for model training either alone or combined with historical
    /// data. For more information see <a>recording-events</a>.
    /// </summary>
    public partial class AmazonPersonalizeEventsClient : AmazonServiceClient, IAmazonPersonalizeEvents
    {
        private static IServiceMetadata serviceMetadata = new AmazonPersonalizeEventsMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with the credentials loaded from the application's
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
        public AmazonPersonalizeEventsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPersonalizeEventsConfig()) { }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with the credentials loaded from the application's
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
        public AmazonPersonalizeEventsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPersonalizeEventsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPersonalizeEventsClient Configuration Object</param>
        public AmazonPersonalizeEventsClient(AmazonPersonalizeEventsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPersonalizeEventsClient(AWSCredentials credentials)
            : this(credentials, new AmazonPersonalizeEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPersonalizeEventsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPersonalizeEventsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Credentials and an
        /// AmazonPersonalizeEventsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPersonalizeEventsClient Configuration Object</param>
        public AmazonPersonalizeEventsClient(AWSCredentials credentials, AmazonPersonalizeEventsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPersonalizeEventsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPersonalizeEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPersonalizeEventsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPersonalizeEventsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPersonalizeEventsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPersonalizeEventsClient Configuration Object</param>
        public AmazonPersonalizeEventsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPersonalizeEventsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPersonalizeEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPersonalizeEventsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPersonalizeEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPersonalizeEventsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPersonalizeEventsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPersonalizeEventsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPersonalizeEventsClient Configuration Object</param>
        public AmazonPersonalizeEventsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPersonalizeEventsConfig clientConfig)
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


        #region  PutEvents

        /// <summary>
        /// Records user interaction event data. For more information see <a>event-record-api</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by PersonalizeEvents.</returns>
        /// <exception cref="Amazon.PersonalizeEvents.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutEvents">REST API Reference for PutEvents Operation</seealso>
        public virtual PutEventsResponse PutEvents(PutEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsResponseUnmarshaller.Instance;

            return Invoke<PutEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEvents operation on AmazonPersonalizeEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutEvents">REST API Reference for PutEvents Operation</seealso>
        public virtual IAsyncResult BeginPutEvents(PutEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEvents.</param>
        /// 
        /// <returns>Returns a  PutEventsResult from PersonalizeEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutEvents">REST API Reference for PutEvents Operation</seealso>
        public virtual PutEventsResponse EndPutEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<PutEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutItems

        /// <summary>
        /// Adds one or more items to an Items dataset. For more information see <a>importing-items</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutItems service method.</param>
        /// 
        /// <returns>The response from the PutItems service method, as returned by PersonalizeEvents.</returns>
        /// <exception cref="Amazon.PersonalizeEvents.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeEvents.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutItems">REST API Reference for PutItems Operation</seealso>
        public virtual PutItemsResponse PutItems(PutItemsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutItemsResponseUnmarshaller.Instance;

            return Invoke<PutItemsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutItems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutItems operation on AmazonPersonalizeEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutItems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutItems">REST API Reference for PutItems Operation</seealso>
        public virtual IAsyncResult BeginPutItems(PutItemsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutItemsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutItems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutItems.</param>
        /// 
        /// <returns>Returns a  PutItemsResult from PersonalizeEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutItems">REST API Reference for PutItems Operation</seealso>
        public virtual PutItemsResponse EndPutItems(IAsyncResult asyncResult)
        {
            return EndInvoke<PutItemsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutUsers

        /// <summary>
        /// Adds one or more users to a Users dataset. For more information see <a>importing-users</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutUsers service method.</param>
        /// 
        /// <returns>The response from the PutUsers service method, as returned by PersonalizeEvents.</returns>
        /// <exception cref="Amazon.PersonalizeEvents.Model.InvalidInputException">
        /// Provide a valid value for the field or parameter.
        /// </exception>
        /// <exception cref="Amazon.PersonalizeEvents.Model.ResourceNotFoundException">
        /// Could not find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutUsers">REST API Reference for PutUsers Operation</seealso>
        public virtual PutUsersResponse PutUsers(PutUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutUsersResponseUnmarshaller.Instance;

            return Invoke<PutUsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutUsers operation on AmazonPersonalizeEventsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutUsers">REST API Reference for PutUsers Operation</seealso>
        public virtual IAsyncResult BeginPutUsers(PutUsersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutUsersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutUsers.</param>
        /// 
        /// <returns>Returns a  PutUsersResult from PersonalizeEvents.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/personalize-events-2018-03-22/PutUsers">REST API Reference for PutUsers Operation</seealso>
        public virtual PutUsersResponse EndPutUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<PutUsersResponse>(asyncResult);
        }

        #endregion
        
    }
}