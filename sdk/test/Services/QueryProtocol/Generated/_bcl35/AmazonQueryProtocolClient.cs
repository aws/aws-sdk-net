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
 * Do not modify this file. This file is generated from the query-protocol-2020-01-08.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.QueryProtocol.Model;
using Amazon.QueryProtocol.Model.Internal.MarshallTransformations;
using Amazon.QueryProtocol.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.QueryProtocol
{
    /// <summary>
    /// <para>Implementation for accessing QueryProtocol</para>
    ///
    /// A query service that sends query requests and XML responses.
    /// </summary>
    public partial class AmazonQueryProtocolClient : AmazonServiceClient, IAmazonQueryProtocol
    {
        private static IServiceMetadata serviceMetadata = new AmazonQueryProtocolMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with the credentials loaded from the application's
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
        public AmazonQueryProtocolClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQueryProtocolConfig()) { }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with the credentials loaded from the application's
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
        public AmazonQueryProtocolClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQueryProtocolConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonQueryProtocolClient Configuration Object</param>
        public AmazonQueryProtocolClient(AmazonQueryProtocolConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonQueryProtocolClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonQueryProtocolClient(AWSCredentials credentials)
            : this(credentials, new AmazonQueryProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQueryProtocolClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonQueryProtocolConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with AWS Credentials and an
        /// AmazonQueryProtocolClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonQueryProtocolClient Configuration Object</param>
        public AmazonQueryProtocolClient(AWSCredentials credentials, AmazonQueryProtocolConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonQueryProtocolClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQueryProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQueryProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQueryProtocolConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQueryProtocolClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonQueryProtocolClient Configuration Object</param>
        public AmazonQueryProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonQueryProtocolConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonQueryProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQueryProtocolConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQueryProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQueryProtocolConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQueryProtocolClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQueryProtocolClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonQueryProtocolClient Configuration Object</param>
        public AmazonQueryProtocolClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonQueryProtocolConfig clientConfig)
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


        #region  DatetimeOffsets

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DatetimeOffsets service method.</param>
        /// 
        /// <returns>The response from the DatetimeOffsets service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        public virtual DatetimeOffsetsResponse DatetimeOffsets(DatetimeOffsetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DatetimeOffsetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DatetimeOffsetsResponseUnmarshaller.Instance;

            return Invoke<DatetimeOffsetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DatetimeOffsets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DatetimeOffsets operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDatetimeOffsets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        public virtual IAsyncResult BeginDatetimeOffsets(DatetimeOffsetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DatetimeOffsetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DatetimeOffsetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DatetimeOffsets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDatetimeOffsets.</param>
        /// 
        /// <returns>Returns a  DatetimeOffsetsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        public virtual DatetimeOffsetsResponse EndDatetimeOffsets(IAsyncResult asyncResult)
        {
            return EndInvoke<DatetimeOffsetsResponse>(asyncResult);
        }

        #endregion
        
        #region  EmptyInputAndEmptyOutput

        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response members.
        /// 
        ///  
        /// <para>
        /// While this should be rare, code generators must support this.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputAndEmptyOutput service method.</param>
        /// 
        /// <returns>The response from the EmptyInputAndEmptyOutput service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        public virtual EmptyInputAndEmptyOutputResponse EmptyInputAndEmptyOutput(EmptyInputAndEmptyOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EmptyInputAndEmptyOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EmptyInputAndEmptyOutputResponseUnmarshaller.Instance;

            return Invoke<EmptyInputAndEmptyOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EmptyInputAndEmptyOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputAndEmptyOutput operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEmptyInputAndEmptyOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        public virtual IAsyncResult BeginEmptyInputAndEmptyOutput(EmptyInputAndEmptyOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EmptyInputAndEmptyOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EmptyInputAndEmptyOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EmptyInputAndEmptyOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEmptyInputAndEmptyOutput.</param>
        /// 
        /// <returns>Returns a  EmptyInputAndEmptyOutputResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        public virtual EmptyInputAndEmptyOutputResponse EndEmptyInputAndEmptyOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<EmptyInputAndEmptyOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  EndpointOperation

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation service method.</param>
        /// 
        /// <returns>The response from the EndpointOperation service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        public virtual EndpointOperationResponse EndpointOperation(EndpointOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndpointOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointOperationResponseUnmarshaller.Instance;

            return Invoke<EndpointOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EndpointOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        public virtual IAsyncResult BeginEndpointOperation(EndpointOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndpointOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EndpointOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEndpointOperation.</param>
        /// 
        /// <returns>Returns a  EndpointOperationResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        public virtual EndpointOperationResponse EndEndpointOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<EndpointOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  EndpointWithHostLabelOperation

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation service method.</param>
        /// 
        /// <returns>The response from the EndpointWithHostLabelOperation service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        public virtual EndpointWithHostLabelOperationResponse EndpointWithHostLabelOperation(EndpointWithHostLabelOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndpointWithHostLabelOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointWithHostLabelOperationResponseUnmarshaller.Instance;

            return Invoke<EndpointWithHostLabelOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EndpointWithHostLabelOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointWithHostLabelOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        public virtual IAsyncResult BeginEndpointWithHostLabelOperation(EndpointWithHostLabelOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EndpointWithHostLabelOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EndpointWithHostLabelOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EndpointWithHostLabelOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEndpointWithHostLabelOperation.</param>
        /// 
        /// <returns>Returns a  EndpointWithHostLabelOperationResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        public virtual EndpointWithHostLabelOperationResponse EndEndpointWithHostLabelOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<EndpointWithHostLabelOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  FlattenedXmlMap

        /// <summary>
        /// Flattened maps
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMap service method.</param>
        /// 
        /// <returns>The response from the FlattenedXmlMap service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMap">REST API Reference for FlattenedXmlMap Operation</seealso>
        public virtual FlattenedXmlMapResponse FlattenedXmlMap(FlattenedXmlMapRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapResponseUnmarshaller.Instance;

            return Invoke<FlattenedXmlMapResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the FlattenedXmlMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMap operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFlattenedXmlMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMap">REST API Reference for FlattenedXmlMap Operation</seealso>
        public virtual IAsyncResult BeginFlattenedXmlMap(FlattenedXmlMapRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  FlattenedXmlMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlattenedXmlMap.</param>
        /// 
        /// <returns>Returns a  FlattenedXmlMapResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMap">REST API Reference for FlattenedXmlMap Operation</seealso>
        public virtual FlattenedXmlMapResponse EndFlattenedXmlMap(IAsyncResult asyncResult)
        {
            return EndInvoke<FlattenedXmlMapResponse>(asyncResult);
        }

        #endregion
        
        #region  FlattenedXmlMapWithXmlName

        /// <summary>
        /// Flattened maps with @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlName service method.</param>
        /// 
        /// <returns>The response from the FlattenedXmlMapWithXmlName service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMapWithXmlName">REST API Reference for FlattenedXmlMapWithXmlName Operation</seealso>
        public virtual FlattenedXmlMapWithXmlNameResponse FlattenedXmlMapWithXmlName(FlattenedXmlMapWithXmlNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapWithXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapWithXmlNameResponseUnmarshaller.Instance;

            return Invoke<FlattenedXmlMapWithXmlNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the FlattenedXmlMapWithXmlName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlName operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFlattenedXmlMapWithXmlName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMapWithXmlName">REST API Reference for FlattenedXmlMapWithXmlName Operation</seealso>
        public virtual IAsyncResult BeginFlattenedXmlMapWithXmlName(FlattenedXmlMapWithXmlNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapWithXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapWithXmlNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  FlattenedXmlMapWithXmlName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlattenedXmlMapWithXmlName.</param>
        /// 
        /// <returns>Returns a  FlattenedXmlMapWithXmlNameResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMapWithXmlName">REST API Reference for FlattenedXmlMapWithXmlName Operation</seealso>
        public virtual FlattenedXmlMapWithXmlNameResponse EndFlattenedXmlMapWithXmlName(IAsyncResult asyncResult)
        {
            return EndInvoke<FlattenedXmlMapWithXmlNameResponse>(asyncResult);
        }

        #endregion
        
        #region  FlattenedXmlMapWithXmlNamespace

        /// <summary>
        /// Flattened maps with @xmlNamespace and @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlNamespace service method.</param>
        /// 
        /// <returns>The response from the FlattenedXmlMapWithXmlNamespace service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMapWithXmlNamespace">REST API Reference for FlattenedXmlMapWithXmlNamespace Operation</seealso>
        public virtual FlattenedXmlMapWithXmlNamespaceResponse FlattenedXmlMapWithXmlNamespace(FlattenedXmlMapWithXmlNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapWithXmlNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapWithXmlNamespaceResponseUnmarshaller.Instance;

            return Invoke<FlattenedXmlMapWithXmlNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the FlattenedXmlMapWithXmlNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlNamespace operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFlattenedXmlMapWithXmlNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMapWithXmlNamespace">REST API Reference for FlattenedXmlMapWithXmlNamespace Operation</seealso>
        public virtual IAsyncResult BeginFlattenedXmlMapWithXmlNamespace(FlattenedXmlMapWithXmlNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlattenedXmlMapWithXmlNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlattenedXmlMapWithXmlNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  FlattenedXmlMapWithXmlNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlattenedXmlMapWithXmlNamespace.</param>
        /// 
        /// <returns>Returns a  FlattenedXmlMapWithXmlNamespaceResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMapWithXmlNamespace">REST API Reference for FlattenedXmlMapWithXmlNamespace Operation</seealso>
        public virtual FlattenedXmlMapWithXmlNamespaceResponse EndFlattenedXmlMapWithXmlNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<FlattenedXmlMapWithXmlNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  FractionalSeconds

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds service method.</param>
        /// 
        /// <returns>The response from the FractionalSeconds service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        public virtual FractionalSecondsResponse FractionalSeconds(FractionalSecondsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FractionalSecondsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FractionalSecondsResponseUnmarshaller.Instance;

            return Invoke<FractionalSecondsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the FractionalSeconds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFractionalSeconds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        public virtual IAsyncResult BeginFractionalSeconds(FractionalSecondsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FractionalSecondsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FractionalSecondsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  FractionalSeconds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFractionalSeconds.</param>
        /// 
        /// <returns>Returns a  FractionalSecondsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        public virtual FractionalSecondsResponse EndFractionalSeconds(IAsyncResult asyncResult)
        {
            return EndInvoke<FractionalSecondsResponse>(asyncResult);
        }

        #endregion
        
        #region  GreetingWithErrors

        /// <summary>
        /// This operation has three possible return values:
        /// 
        ///  <ol> <li>A successful response in the form of GreetingWithErrorsOutput</li> <li>An
        /// InvalidGreeting error.</li> <li>A BadRequest error.</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors service method.</param>
        /// 
        /// <returns>The response from the GreetingWithErrors service method, as returned by QueryProtocol.</returns>
        /// <exception cref="Amazon.QueryProtocol.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.QueryProtocol.Model.CustomCodeErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.QueryProtocol.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        public virtual GreetingWithErrorsResponse GreetingWithErrors(GreetingWithErrorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GreetingWithErrorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GreetingWithErrorsResponseUnmarshaller.Instance;

            return Invoke<GreetingWithErrorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GreetingWithErrors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGreetingWithErrors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        public virtual IAsyncResult BeginGreetingWithErrors(GreetingWithErrorsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GreetingWithErrorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GreetingWithErrorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GreetingWithErrors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGreetingWithErrors.</param>
        /// 
        /// <returns>Returns a  GreetingWithErrorsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        public virtual GreetingWithErrorsResponse EndGreetingWithErrors(IAsyncResult asyncResult)
        {
            return EndInvoke<GreetingWithErrorsResponse>(asyncResult);
        }

        #endregion
        
        #region  HostWithPathOperation

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HostWithPathOperation service method.</param>
        /// 
        /// <returns>The response from the HostWithPathOperation service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        public virtual HostWithPathOperationResponse HostWithPathOperation(HostWithPathOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HostWithPathOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HostWithPathOperationResponseUnmarshaller.Instance;

            return Invoke<HostWithPathOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the HostWithPathOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HostWithPathOperation operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHostWithPathOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        public virtual IAsyncResult BeginHostWithPathOperation(HostWithPathOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = HostWithPathOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HostWithPathOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  HostWithPathOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHostWithPathOperation.</param>
        /// 
        /// <returns>Returns a  HostWithPathOperationResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        public virtual HostWithPathOperationResponse EndHostWithPathOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<HostWithPathOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  IgnoresWrappingXmlName

        /// <summary>
        /// The xmlName trait on the output structure is ignored in AWS Query.
        /// 
        ///  
        /// <para>
        /// The wrapping element is always operation name + &quot;Response&quot;, and inside of
        /// that wrapper is another wrapper named operation name + &quot;Result&quot;.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IgnoresWrappingXmlName service method.</param>
        /// 
        /// <returns>The response from the IgnoresWrappingXmlName service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/IgnoresWrappingXmlName">REST API Reference for IgnoresWrappingXmlName Operation</seealso>
        public virtual IgnoresWrappingXmlNameResponse IgnoresWrappingXmlName(IgnoresWrappingXmlNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IgnoresWrappingXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IgnoresWrappingXmlNameResponseUnmarshaller.Instance;

            return Invoke<IgnoresWrappingXmlNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the IgnoresWrappingXmlName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IgnoresWrappingXmlName operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIgnoresWrappingXmlName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/IgnoresWrappingXmlName">REST API Reference for IgnoresWrappingXmlName Operation</seealso>
        public virtual IAsyncResult BeginIgnoresWrappingXmlName(IgnoresWrappingXmlNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IgnoresWrappingXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IgnoresWrappingXmlNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  IgnoresWrappingXmlName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIgnoresWrappingXmlName.</param>
        /// 
        /// <returns>Returns a  IgnoresWrappingXmlNameResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/IgnoresWrappingXmlName">REST API Reference for IgnoresWrappingXmlName Operation</seealso>
        public virtual IgnoresWrappingXmlNameResponse EndIgnoresWrappingXmlName(IAsyncResult asyncResult)
        {
            return EndInvoke<IgnoresWrappingXmlNameResponse>(asyncResult);
        }

        #endregion
        
        #region  NoInputAndNoOutput

        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has no input or output.
        /// 
        ///  
        /// <para>
        /// While this should be rare, code generators must support this.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndNoOutput service method.</param>
        /// 
        /// <returns>The response from the NoInputAndNoOutput service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        public virtual NoInputAndNoOutputResponse NoInputAndNoOutput(NoInputAndNoOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoInputAndNoOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputAndNoOutputResponseUnmarshaller.Instance;

            return Invoke<NoInputAndNoOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the NoInputAndNoOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndNoOutput operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNoInputAndNoOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        public virtual IAsyncResult BeginNoInputAndNoOutput(NoInputAndNoOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoInputAndNoOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputAndNoOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  NoInputAndNoOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNoInputAndNoOutput.</param>
        /// 
        /// <returns>Returns a  NoInputAndNoOutputResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        public virtual NoInputAndNoOutputResponse EndNoInputAndNoOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<NoInputAndNoOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  NoInputAndOutput

        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// payload or response members.
        /// 
        ///  
        /// <para>
        /// While this should be rare, code generators must support this.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndOutput service method.</param>
        /// 
        /// <returns>The response from the NoInputAndOutput service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        public virtual NoInputAndOutputResponse NoInputAndOutput(NoInputAndOutputRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoInputAndOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputAndOutputResponseUnmarshaller.Instance;

            return Invoke<NoInputAndOutputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the NoInputAndOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndOutput operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNoInputAndOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        public virtual IAsyncResult BeginNoInputAndOutput(NoInputAndOutputRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = NoInputAndOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NoInputAndOutputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  NoInputAndOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNoInputAndOutput.</param>
        /// 
        /// <returns>Returns a  NoInputAndOutputResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        public virtual NoInputAndOutputResponse EndNoInputAndOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<NoInputAndOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  PutWithContentEncoding

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding service method.</param>
        /// 
        /// <returns>The response from the PutWithContentEncoding service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        public virtual PutWithContentEncodingResponse PutWithContentEncoding(PutWithContentEncodingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutWithContentEncodingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWithContentEncodingResponseUnmarshaller.Instance;

            return Invoke<PutWithContentEncodingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutWithContentEncoding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutWithContentEncoding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        public virtual IAsyncResult BeginPutWithContentEncoding(PutWithContentEncodingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutWithContentEncodingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWithContentEncodingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutWithContentEncoding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutWithContentEncoding.</param>
        /// 
        /// <returns>Returns a  PutWithContentEncodingResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        public virtual PutWithContentEncodingResponse EndPutWithContentEncoding(IAsyncResult asyncResult)
        {
            return EndInvoke<PutWithContentEncodingResponse>(asyncResult);
        }

        #endregion
        
        #region  QueryIdempotencyTokenAutoFill

        /// <summary>
        /// Automatically adds idempotency tokens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryIdempotencyTokenAutoFill service method.</param>
        /// 
        /// <returns>The response from the QueryIdempotencyTokenAutoFill service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        public virtual QueryIdempotencyTokenAutoFillResponse QueryIdempotencyTokenAutoFill(QueryIdempotencyTokenAutoFillRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryIdempotencyTokenAutoFillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryIdempotencyTokenAutoFillResponseUnmarshaller.Instance;

            return Invoke<QueryIdempotencyTokenAutoFillResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QueryIdempotencyTokenAutoFill operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryIdempotencyTokenAutoFill operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryIdempotencyTokenAutoFill
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        public virtual IAsyncResult BeginQueryIdempotencyTokenAutoFill(QueryIdempotencyTokenAutoFillRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryIdempotencyTokenAutoFillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryIdempotencyTokenAutoFillResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QueryIdempotencyTokenAutoFill operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryIdempotencyTokenAutoFill.</param>
        /// 
        /// <returns>Returns a  QueryIdempotencyTokenAutoFillResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        public virtual QueryIdempotencyTokenAutoFillResponse EndQueryIdempotencyTokenAutoFill(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryIdempotencyTokenAutoFillResponse>(asyncResult);
        }

        #endregion
        
        #region  QueryLists

        /// <summary>
        /// This test serializes simple and complex lists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryLists service method.</param>
        /// 
        /// <returns>The response from the QueryLists service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryLists">REST API Reference for QueryLists Operation</seealso>
        public virtual QueryListsResponse QueryLists(QueryListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryListsResponseUnmarshaller.Instance;

            return Invoke<QueryListsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QueryLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryLists operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryLists">REST API Reference for QueryLists Operation</seealso>
        public virtual IAsyncResult BeginQueryLists(QueryListsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryListsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QueryLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryLists.</param>
        /// 
        /// <returns>Returns a  QueryListsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryLists">REST API Reference for QueryLists Operation</seealso>
        public virtual QueryListsResponse EndQueryLists(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryListsResponse>(asyncResult);
        }

        #endregion
        
        #region  QueryMaps

        /// <summary>
        /// This test serializes simple and complex maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryMaps service method.</param>
        /// 
        /// <returns>The response from the QueryMaps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryMaps">REST API Reference for QueryMaps Operation</seealso>
        public virtual QueryMapsResponse QueryMaps(QueryMapsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryMapsResponseUnmarshaller.Instance;

            return Invoke<QueryMapsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QueryMaps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryMaps operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryMaps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryMaps">REST API Reference for QueryMaps Operation</seealso>
        public virtual IAsyncResult BeginQueryMaps(QueryMapsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryMapsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QueryMaps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryMaps.</param>
        /// 
        /// <returns>Returns a  QueryMapsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryMaps">REST API Reference for QueryMaps Operation</seealso>
        public virtual QueryMapsResponse EndQueryMaps(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryMapsResponse>(asyncResult);
        }

        #endregion
        
        #region  QueryTimestamps

        /// <summary>
        /// This test serializes timestamps.
        /// 
        ///  <ol> <li>Timestamps are serialized as RFC 3339 date-time values by default.</li>
        /// <li>A timestampFormat trait on a member changes the format.</li> <li>A timestampFormat
        /// trait on the shape targeted by the member changes the format.</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryTimestamps service method.</param>
        /// 
        /// <returns>The response from the QueryTimestamps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryTimestamps">REST API Reference for QueryTimestamps Operation</seealso>
        public virtual QueryTimestampsResponse QueryTimestamps(QueryTimestampsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryTimestampsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryTimestampsResponseUnmarshaller.Instance;

            return Invoke<QueryTimestampsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QueryTimestamps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryTimestamps operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryTimestamps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryTimestamps">REST API Reference for QueryTimestamps Operation</seealso>
        public virtual IAsyncResult BeginQueryTimestamps(QueryTimestampsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryTimestampsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryTimestampsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QueryTimestamps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryTimestamps.</param>
        /// 
        /// <returns>Returns a  QueryTimestampsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryTimestamps">REST API Reference for QueryTimestamps Operation</seealso>
        public virtual QueryTimestampsResponse EndQueryTimestamps(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryTimestampsResponse>(asyncResult);
        }

        #endregion
        
        #region  RecursiveXmlShapes

        /// <summary>
        /// Recursive shapes
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecursiveXmlShapes service method.</param>
        /// 
        /// <returns>The response from the RecursiveXmlShapes service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/RecursiveXmlShapes">REST API Reference for RecursiveXmlShapes Operation</seealso>
        public virtual RecursiveXmlShapesResponse RecursiveXmlShapes(RecursiveXmlShapesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RecursiveXmlShapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecursiveXmlShapesResponseUnmarshaller.Instance;

            return Invoke<RecursiveXmlShapesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RecursiveXmlShapes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecursiveXmlShapes operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRecursiveXmlShapes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/RecursiveXmlShapes">REST API Reference for RecursiveXmlShapes Operation</seealso>
        public virtual IAsyncResult BeginRecursiveXmlShapes(RecursiveXmlShapesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RecursiveXmlShapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecursiveXmlShapesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RecursiveXmlShapes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRecursiveXmlShapes.</param>
        /// 
        /// <returns>Returns a  RecursiveXmlShapesResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/RecursiveXmlShapes">REST API Reference for RecursiveXmlShapes Operation</seealso>
        public virtual RecursiveXmlShapesResponse EndRecursiveXmlShapes(IAsyncResult asyncResult)
        {
            return EndInvoke<RecursiveXmlShapesResponse>(asyncResult);
        }

        #endregion
        
        #region  SimpleInputParams

        /// <summary>
        /// This test serializes strings, numbers, and boolean values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleInputParams service method.</param>
        /// 
        /// <returns>The response from the SimpleInputParams service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/SimpleInputParams">REST API Reference for SimpleInputParams Operation</seealso>
        public virtual SimpleInputParamsResponse SimpleInputParams(SimpleInputParamsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SimpleInputParamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimpleInputParamsResponseUnmarshaller.Instance;

            return Invoke<SimpleInputParamsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SimpleInputParams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimpleInputParams operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSimpleInputParams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/SimpleInputParams">REST API Reference for SimpleInputParams Operation</seealso>
        public virtual IAsyncResult BeginSimpleInputParams(SimpleInputParamsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SimpleInputParamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimpleInputParamsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SimpleInputParams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSimpleInputParams.</param>
        /// 
        /// <returns>Returns a  SimpleInputParamsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/SimpleInputParams">REST API Reference for SimpleInputParams Operation</seealso>
        public virtual SimpleInputParamsResponse EndSimpleInputParams(IAsyncResult asyncResult)
        {
            return EndInvoke<SimpleInputParamsResponse>(asyncResult);
        }

        #endregion
        
        #region  SimpleScalarXmlProperties

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarXmlProperties service method.</param>
        /// 
        /// <returns>The response from the SimpleScalarXmlProperties service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/SimpleScalarXmlProperties">REST API Reference for SimpleScalarXmlProperties Operation</seealso>
        public virtual SimpleScalarXmlPropertiesResponse SimpleScalarXmlProperties(SimpleScalarXmlPropertiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SimpleScalarXmlPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimpleScalarXmlPropertiesResponseUnmarshaller.Instance;

            return Invoke<SimpleScalarXmlPropertiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SimpleScalarXmlProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarXmlProperties operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSimpleScalarXmlProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/SimpleScalarXmlProperties">REST API Reference for SimpleScalarXmlProperties Operation</seealso>
        public virtual IAsyncResult BeginSimpleScalarXmlProperties(SimpleScalarXmlPropertiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SimpleScalarXmlPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimpleScalarXmlPropertiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SimpleScalarXmlProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSimpleScalarXmlProperties.</param>
        /// 
        /// <returns>Returns a  SimpleScalarXmlPropertiesResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/SimpleScalarXmlProperties">REST API Reference for SimpleScalarXmlProperties Operation</seealso>
        public virtual SimpleScalarXmlPropertiesResponse EndSimpleScalarXmlProperties(IAsyncResult asyncResult)
        {
            return EndInvoke<SimpleScalarXmlPropertiesResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlBlobs

        /// <summary>
        /// Blobs are base64 encoded
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlBlobs service method.</param>
        /// 
        /// <returns>The response from the XmlBlobs service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlBlobs">REST API Reference for XmlBlobs Operation</seealso>
        public virtual XmlBlobsResponse XmlBlobs(XmlBlobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlBlobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlBlobsResponseUnmarshaller.Instance;

            return Invoke<XmlBlobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlBlobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlBlobs operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlBlobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlBlobs">REST API Reference for XmlBlobs Operation</seealso>
        public virtual IAsyncResult BeginXmlBlobs(XmlBlobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlBlobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlBlobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlBlobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlBlobs.</param>
        /// 
        /// <returns>Returns a  XmlBlobsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlBlobs">REST API Reference for XmlBlobs Operation</seealso>
        public virtual XmlBlobsResponse EndXmlBlobs(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlBlobsResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlEmptyBlobs

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyBlobs service method.</param>
        /// 
        /// <returns>The response from the XmlEmptyBlobs service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyBlobs">REST API Reference for XmlEmptyBlobs Operation</seealso>
        public virtual XmlEmptyBlobsResponse XmlEmptyBlobs(XmlEmptyBlobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyBlobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyBlobsResponseUnmarshaller.Instance;

            return Invoke<XmlEmptyBlobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlEmptyBlobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyBlobs operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlEmptyBlobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyBlobs">REST API Reference for XmlEmptyBlobs Operation</seealso>
        public virtual IAsyncResult BeginXmlEmptyBlobs(XmlEmptyBlobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyBlobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyBlobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlEmptyBlobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlEmptyBlobs.</param>
        /// 
        /// <returns>Returns a  XmlEmptyBlobsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyBlobs">REST API Reference for XmlEmptyBlobs Operation</seealso>
        public virtual XmlEmptyBlobsResponse EndXmlEmptyBlobs(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlEmptyBlobsResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlEmptyLists

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyLists service method.</param>
        /// 
        /// <returns>The response from the XmlEmptyLists service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyLists">REST API Reference for XmlEmptyLists Operation</seealso>
        public virtual XmlEmptyListsResponse XmlEmptyLists(XmlEmptyListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyListsResponseUnmarshaller.Instance;

            return Invoke<XmlEmptyListsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlEmptyLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyLists operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlEmptyLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyLists">REST API Reference for XmlEmptyLists Operation</seealso>
        public virtual IAsyncResult BeginXmlEmptyLists(XmlEmptyListsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyListsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlEmptyLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlEmptyLists.</param>
        /// 
        /// <returns>Returns a  XmlEmptyListsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyLists">REST API Reference for XmlEmptyLists Operation</seealso>
        public virtual XmlEmptyListsResponse EndXmlEmptyLists(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlEmptyListsResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlEmptyMaps

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyMaps service method.</param>
        /// 
        /// <returns>The response from the XmlEmptyMaps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyMaps">REST API Reference for XmlEmptyMaps Operation</seealso>
        public virtual XmlEmptyMapsResponse XmlEmptyMaps(XmlEmptyMapsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyMapsResponseUnmarshaller.Instance;

            return Invoke<XmlEmptyMapsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlEmptyMaps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyMaps operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlEmptyMaps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyMaps">REST API Reference for XmlEmptyMaps Operation</seealso>
        public virtual IAsyncResult BeginXmlEmptyMaps(XmlEmptyMapsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEmptyMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEmptyMapsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlEmptyMaps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlEmptyMaps.</param>
        /// 
        /// <returns>Returns a  XmlEmptyMapsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyMaps">REST API Reference for XmlEmptyMaps Operation</seealso>
        public virtual XmlEmptyMapsResponse EndXmlEmptyMaps(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlEmptyMapsResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlEnums

        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEnums service method.</param>
        /// 
        /// <returns>The response from the XmlEnums service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEnums">REST API Reference for XmlEnums Operation</seealso>
        public virtual XmlEnumsResponse XmlEnums(XmlEnumsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEnumsResponseUnmarshaller.Instance;

            return Invoke<XmlEnumsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlEnums operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlEnums operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlEnums
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEnums">REST API Reference for XmlEnums Operation</seealso>
        public virtual IAsyncResult BeginXmlEnums(XmlEnumsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlEnumsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlEnums operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlEnums.</param>
        /// 
        /// <returns>Returns a  XmlEnumsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEnums">REST API Reference for XmlEnums Operation</seealso>
        public virtual XmlEnumsResponse EndXmlEnums(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlEnumsResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlIntEnums

        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlIntEnums service method.</param>
        /// 
        /// <returns>The response from the XmlIntEnums service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlIntEnums">REST API Reference for XmlIntEnums Operation</seealso>
        public virtual XmlIntEnumsResponse XmlIntEnums(XmlIntEnumsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlIntEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlIntEnumsResponseUnmarshaller.Instance;

            return Invoke<XmlIntEnumsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlIntEnums operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlIntEnums operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlIntEnums
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlIntEnums">REST API Reference for XmlIntEnums Operation</seealso>
        public virtual IAsyncResult BeginXmlIntEnums(XmlIntEnumsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlIntEnumsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlIntEnumsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlIntEnums operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlIntEnums.</param>
        /// 
        /// <returns>Returns a  XmlIntEnumsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlIntEnums">REST API Reference for XmlIntEnums Operation</seealso>
        public virtual XmlIntEnumsResponse EndXmlIntEnums(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlIntEnumsResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlLists

        /// <summary>
        /// This test case serializes XML lists for the following cases for both input and output:
        /// 
        ///  <ol> <li>Normal XML lists.</li> <li>Normal XML sets.</li> <li>XML lists of lists.</li>
        /// <li>XML lists with @xmlName on its members</li> <li>Flattened XML lists.</li> <li>Flattened
        /// XML lists with @xmlName.</li> <li>Lists of structures.</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlLists service method.</param>
        /// 
        /// <returns>The response from the XmlLists service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlLists">REST API Reference for XmlLists Operation</seealso>
        public virtual XmlListsResponse XmlLists(XmlListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlListsResponseUnmarshaller.Instance;

            return Invoke<XmlListsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlLists operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlLists">REST API Reference for XmlLists Operation</seealso>
        public virtual IAsyncResult BeginXmlLists(XmlListsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlListsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlLists.</param>
        /// 
        /// <returns>Returns a  XmlListsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlLists">REST API Reference for XmlLists Operation</seealso>
        public virtual XmlListsResponse EndXmlLists(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlListsResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlMaps

        /// <summary>
        /// The example tests basic map serialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMaps service method.</param>
        /// 
        /// <returns>The response from the XmlMaps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlMaps">REST API Reference for XmlMaps Operation</seealso>
        public virtual XmlMapsResponse XmlMaps(XmlMapsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlMapsResponseUnmarshaller.Instance;

            return Invoke<XmlMapsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlMaps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlMaps operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlMaps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlMaps">REST API Reference for XmlMaps Operation</seealso>
        public virtual IAsyncResult BeginXmlMaps(XmlMapsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlMapsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlMapsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlMaps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlMaps.</param>
        /// 
        /// <returns>Returns a  XmlMapsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlMaps">REST API Reference for XmlMaps Operation</seealso>
        public virtual XmlMapsResponse EndXmlMaps(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlMapsResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlMapsXmlName

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMapsXmlName service method.</param>
        /// 
        /// <returns>The response from the XmlMapsXmlName service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlMapsXmlName">REST API Reference for XmlMapsXmlName Operation</seealso>
        public virtual XmlMapsXmlNameResponse XmlMapsXmlName(XmlMapsXmlNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlMapsXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlMapsXmlNameResponseUnmarshaller.Instance;

            return Invoke<XmlMapsXmlNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlMapsXmlName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlMapsXmlName operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlMapsXmlName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlMapsXmlName">REST API Reference for XmlMapsXmlName Operation</seealso>
        public virtual IAsyncResult BeginXmlMapsXmlName(XmlMapsXmlNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlMapsXmlNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlMapsXmlNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlMapsXmlName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlMapsXmlName.</param>
        /// 
        /// <returns>Returns a  XmlMapsXmlNameResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlMapsXmlName">REST API Reference for XmlMapsXmlName Operation</seealso>
        public virtual XmlMapsXmlNameResponse EndXmlMapsXmlName(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlMapsXmlNameResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlNamespaces

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlNamespaces service method.</param>
        /// 
        /// <returns>The response from the XmlNamespaces service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlNamespaces">REST API Reference for XmlNamespaces Operation</seealso>
        public virtual XmlNamespacesResponse XmlNamespaces(XmlNamespacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlNamespacesResponseUnmarshaller.Instance;

            return Invoke<XmlNamespacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlNamespaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlNamespaces operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlNamespaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlNamespaces">REST API Reference for XmlNamespaces Operation</seealso>
        public virtual IAsyncResult BeginXmlNamespaces(XmlNamespacesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlNamespacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlNamespaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlNamespaces.</param>
        /// 
        /// <returns>Returns a  XmlNamespacesResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlNamespaces">REST API Reference for XmlNamespaces Operation</seealso>
        public virtual XmlNamespacesResponse EndXmlNamespaces(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlNamespacesResponse>(asyncResult);
        }

        #endregion
        
        #region  XmlTimestamps

        /// <summary>
        /// This tests how timestamps are serialized, including using the default format of date-time
        /// and various @timestampFormat trait values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlTimestamps service method.</param>
        /// 
        /// <returns>The response from the XmlTimestamps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlTimestamps">REST API Reference for XmlTimestamps Operation</seealso>
        public virtual XmlTimestampsResponse XmlTimestamps(XmlTimestampsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlTimestampsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlTimestampsResponseUnmarshaller.Instance;

            return Invoke<XmlTimestampsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the XmlTimestamps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlTimestamps operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlTimestamps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlTimestamps">REST API Reference for XmlTimestamps Operation</seealso>
        public virtual IAsyncResult BeginXmlTimestamps(XmlTimestampsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = XmlTimestampsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = XmlTimestampsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  XmlTimestamps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlTimestamps.</param>
        /// 
        /// <returns>Returns a  XmlTimestampsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlTimestamps">REST API Reference for XmlTimestamps Operation</seealso>
        public virtual XmlTimestampsResponse EndXmlTimestamps(IAsyncResult asyncResult)
        {
            return EndInvoke<XmlTimestampsResponse>(asyncResult);
        }

        #endregion
        
    }
}