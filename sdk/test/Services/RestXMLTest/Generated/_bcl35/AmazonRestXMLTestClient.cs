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
 * Do not modify this file. This file is generated from the rest-xml-test-2014-01-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.RestXMLTest.Model;
using Amazon.RestXMLTest.Model.Internal.MarshallTransformations;
using Amazon.RestXMLTest.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.RestXMLTest
{
    /// <summary>
    /// <para>Implementation for accessing RestXMLTest</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonRestXMLTestClient : AmazonServiceClient, IAmazonRestXMLTest
    {
        private static IServiceMetadata serviceMetadata = new AmazonRestXMLTestMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonRestXMLTestClient with the credentials loaded from the application's
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
        public AmazonRestXMLTestClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRestXMLTestConfig()) { }

        /// <summary>
        /// Constructs AmazonRestXMLTestClient with the credentials loaded from the application's
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
        public AmazonRestXMLTestClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRestXMLTestConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRestXMLTestClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRestXMLTestClient Configuration Object</param>
        public AmazonRestXMLTestClient(AmazonRestXMLTestConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonRestXMLTestClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRestXMLTestClient(AWSCredentials credentials)
            : this(credentials, new AmazonRestXMLTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestXMLTestClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestXMLTestClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRestXMLTestConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestXMLTestClient with AWS Credentials and an
        /// AmazonRestXMLTestClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRestXMLTestClient Configuration Object</param>
        public AmazonRestXMLTestClient(AWSCredentials credentials, AmazonRestXMLTestConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRestXMLTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRestXMLTestClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRestXMLTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestXMLTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestXMLTestClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRestXMLTestConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestXMLTestClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRestXMLTestClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRestXMLTestClient Configuration Object</param>
        public AmazonRestXMLTestClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRestXMLTestConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRestXMLTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRestXMLTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRestXMLTestConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestXMLTestClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestXMLTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRestXMLTestConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestXMLTestClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRestXMLTestClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRestXMLTestClient Configuration Object</param>
        public AmazonRestXMLTestClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRestXMLTestConfig clientConfig)
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


        #region  MemberRefOp

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MemberRefOp service method.</param>
        /// 
        /// <returns>The response from the MemberRefOp service method, as returned by RestXMLTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2014-01-01/MemberRefOp">REST API Reference for MemberRefOp Operation</seealso>
        public virtual MemberRefOpResponse MemberRefOp(MemberRefOpRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MemberRefOpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MemberRefOpResponseUnmarshaller.Instance;

            return Invoke<MemberRefOpResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the MemberRefOp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MemberRefOp operation on AmazonRestXMLTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMemberRefOp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2014-01-01/MemberRefOp">REST API Reference for MemberRefOp Operation</seealso>
        public virtual IAsyncResult BeginMemberRefOp(MemberRefOpRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MemberRefOpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MemberRefOpResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  MemberRefOp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMemberRefOp.</param>
        /// 
        /// <returns>Returns a  MemberRefOpResult from RestXMLTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2014-01-01/MemberRefOp">REST API Reference for MemberRefOp Operation</seealso>
        public virtual MemberRefOpResponse EndMemberRefOp(IAsyncResult asyncResult)
        {
            return EndInvoke<MemberRefOpResponse>(asyncResult);
        }

        #endregion
        
        #region  StaticOp

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StaticOp service method.</param>
        /// 
        /// <returns>The response from the StaticOp service method, as returned by RestXMLTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2014-01-01/StaticOp">REST API Reference for StaticOp Operation</seealso>
        public virtual StaticOpResponse StaticOp(StaticOpRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StaticOpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StaticOpResponseUnmarshaller.Instance;

            return Invoke<StaticOpResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StaticOp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StaticOp operation on AmazonRestXMLTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStaticOp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2014-01-01/StaticOp">REST API Reference for StaticOp Operation</seealso>
        public virtual IAsyncResult BeginStaticOp(StaticOpRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StaticOpRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StaticOpResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StaticOp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStaticOp.</param>
        /// 
        /// <returns>Returns a  StaticOpResult from RestXMLTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2014-01-01/StaticOp">REST API Reference for StaticOp Operation</seealso>
        public virtual StaticOpResponse EndStaticOp(IAsyncResult asyncResult)
        {
            return EndInvoke<StaticOpResponse>(asyncResult);
        }

        #endregion
        
        #region  TestOperation

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestOperation service method.</param>
        /// 
        /// <returns>The response from the TestOperation service method, as returned by RestXMLTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2014-01-01/TestOperation">REST API Reference for TestOperation Operation</seealso>
        public virtual TestOperationResponse TestOperation(TestOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestOperationResponseUnmarshaller.Instance;

            return Invoke<TestOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestOperation operation on AmazonRestXMLTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2014-01-01/TestOperation">REST API Reference for TestOperation Operation</seealso>
        public virtual IAsyncResult BeginTestOperation(TestOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestOperation.</param>
        /// 
        /// <returns>Returns a  TestOperationResult from RestXMLTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2014-01-01/TestOperation">REST API Reference for TestOperation Operation</seealso>
        public virtual TestOperationResponse EndTestOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<TestOperationResponse>(asyncResult);
        }

        #endregion
        
    }
}