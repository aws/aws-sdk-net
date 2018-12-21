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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.DLM.Model;
using Amazon.DLM.Model.Internal.MarshallTransformations;
using Amazon.DLM.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DLM
{
    /// <summary>
    /// Implementation for accessing DLM
    ///
    /// Amazon Data Lifecycle Manager 
    /// <para>
    /// With Amazon Data Lifecycle Manager, you can manage the lifecycle of your AWS resources.
    /// You create lifecycle policies, which are used to automate operations on the specified
    /// resources.
    /// </para>
    ///  
    /// <para>
    /// Amazon DLM supports Amazon EBS volumes and snapshots. For information about using
    /// Amazon DLM with Amazon EBS, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/snapshot-lifecycle.html">Automating
    /// the Amazon EBS Snapshot Lifecycle</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonDLMClient : AmazonServiceClient, IAmazonDLM
    {
        private static IServiceMetadata serviceMetadata = new AmazonDLMMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonDLMClient with the credentials loaded from the application's
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
        public AmazonDLMClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDLMConfig()) { }

        /// <summary>
        /// Constructs AmazonDLMClient with the credentials loaded from the application's
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
        public AmazonDLMClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDLMConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDLMClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDLMClient Configuration Object</param>
        public AmazonDLMClient(AmazonDLMConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonDLMClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDLMClient(AWSCredentials credentials)
            : this(credentials, new AmazonDLMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDLMClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDLMClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDLMConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDLMClient with AWS Credentials and an
        /// AmazonDLMClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDLMClient Configuration Object</param>
        public AmazonDLMClient(AWSCredentials credentials, AmazonDLMConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDLMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDLMClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDLMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDLMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDLMClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDLMConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDLMClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDLMClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDLMClient Configuration Object</param>
        public AmazonDLMClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDLMConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDLMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDLMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDLMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDLMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDLMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDLMConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDLMClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDLMClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDLMClient Configuration Object</param>
        public AmazonDLMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDLMConfig clientConfig)
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


        #region  CreateLifecyclePolicy

        /// <summary>
        /// Creates a policy to manage the lifecycle of the specified AWS resources. You can create
        /// up to 100 lifecycle policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLifecyclePolicy service method.</param>
        /// 
        /// <returns>The response from the CreateLifecyclePolicy service method, as returned by DLM.</returns>
        /// <exception cref="Amazon.DLM.Model.InternalServerException">
        /// The service failed in an unexpected way.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.InvalidRequestException">
        /// Bad request. The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.LimitExceededException">
        /// The request failed because a limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/CreateLifecyclePolicy">REST API Reference for CreateLifecyclePolicy Operation</seealso>
        public virtual CreateLifecyclePolicyResponse CreateLifecyclePolicy(CreateLifecyclePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<CreateLifecyclePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLifecyclePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLifecyclePolicy operation on AmazonDLMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLifecyclePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/CreateLifecyclePolicy">REST API Reference for CreateLifecyclePolicy Operation</seealso>
        public virtual IAsyncResult BeginCreateLifecyclePolicy(CreateLifecyclePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLifecyclePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLifecyclePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLifecyclePolicy.</param>
        /// 
        /// <returns>Returns a  CreateLifecyclePolicyResult from DLM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/CreateLifecyclePolicy">REST API Reference for CreateLifecyclePolicy Operation</seealso>
        public virtual CreateLifecyclePolicyResponse EndCreateLifecyclePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLifecyclePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLifecyclePolicy

        /// <summary>
        /// Deletes the specified lifecycle policy and halts the automated operations that the
        /// policy specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecyclePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteLifecyclePolicy service method, as returned by DLM.</returns>
        /// <exception cref="Amazon.DLM.Model.InternalServerException">
        /// The service failed in an unexpected way.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.LimitExceededException">
        /// The request failed because a limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.ResourceNotFoundException">
        /// A requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/DeleteLifecyclePolicy">REST API Reference for DeleteLifecyclePolicy Operation</seealso>
        public virtual DeleteLifecyclePolicyResponse DeleteLifecyclePolicy(DeleteLifecyclePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteLifecyclePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecyclePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecyclePolicy operation on AmazonDLMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLifecyclePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/DeleteLifecyclePolicy">REST API Reference for DeleteLifecyclePolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteLifecyclePolicy(DeleteLifecyclePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecyclePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLifecyclePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLifecyclePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteLifecyclePolicyResult from DLM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/DeleteLifecyclePolicy">REST API Reference for DeleteLifecyclePolicy Operation</seealso>
        public virtual DeleteLifecyclePolicyResponse EndDeleteLifecyclePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLifecyclePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLifecyclePolicies

        /// <summary>
        /// Gets summary information about all or the specified data lifecycle policies.
        /// 
        ///  
        /// <para>
        /// To get complete information about a policy, use <a>GetLifecyclePolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicies service method.</param>
        /// 
        /// <returns>The response from the GetLifecyclePolicies service method, as returned by DLM.</returns>
        /// <exception cref="Amazon.DLM.Model.InternalServerException">
        /// The service failed in an unexpected way.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.InvalidRequestException">
        /// Bad request. The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.LimitExceededException">
        /// The request failed because a limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.ResourceNotFoundException">
        /// A requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/GetLifecyclePolicies">REST API Reference for GetLifecyclePolicies Operation</seealso>
        public virtual GetLifecyclePoliciesResponse GetLifecyclePolicies(GetLifecyclePoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecyclePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecyclePoliciesResponseUnmarshaller.Instance;

            return Invoke<GetLifecyclePoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLifecyclePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicies operation on AmazonDLMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLifecyclePolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/GetLifecyclePolicies">REST API Reference for GetLifecyclePolicies Operation</seealso>
        public virtual IAsyncResult BeginGetLifecyclePolicies(GetLifecyclePoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecyclePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecyclePoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLifecyclePolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLifecyclePolicies.</param>
        /// 
        /// <returns>Returns a  GetLifecyclePoliciesResult from DLM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/GetLifecyclePolicies">REST API Reference for GetLifecyclePolicies Operation</seealso>
        public virtual GetLifecyclePoliciesResponse EndGetLifecyclePolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLifecyclePoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLifecyclePolicy

        /// <summary>
        /// Gets detailed information about the specified lifecycle policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicy service method.</param>
        /// 
        /// <returns>The response from the GetLifecyclePolicy service method, as returned by DLM.</returns>
        /// <exception cref="Amazon.DLM.Model.InternalServerException">
        /// The service failed in an unexpected way.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.LimitExceededException">
        /// The request failed because a limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.ResourceNotFoundException">
        /// A requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/GetLifecyclePolicy">REST API Reference for GetLifecyclePolicy Operation</seealso>
        public virtual GetLifecyclePolicyResponse GetLifecyclePolicy(GetLifecyclePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<GetLifecyclePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLifecyclePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicy operation on AmazonDLMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLifecyclePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/GetLifecyclePolicy">REST API Reference for GetLifecyclePolicy Operation</seealso>
        public virtual IAsyncResult BeginGetLifecyclePolicy(GetLifecyclePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecyclePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLifecyclePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLifecyclePolicy.</param>
        /// 
        /// <returns>Returns a  GetLifecyclePolicyResult from DLM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/GetLifecyclePolicy">REST API Reference for GetLifecyclePolicy Operation</seealso>
        public virtual GetLifecyclePolicyResponse EndGetLifecyclePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLifecyclePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLifecyclePolicy

        /// <summary>
        /// Updates the specified lifecycle policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLifecyclePolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateLifecyclePolicy service method, as returned by DLM.</returns>
        /// <exception cref="Amazon.DLM.Model.InternalServerException">
        /// The service failed in an unexpected way.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.InvalidRequestException">
        /// Bad request. The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.LimitExceededException">
        /// The request failed because a limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DLM.Model.ResourceNotFoundException">
        /// A requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/UpdateLifecyclePolicy">REST API Reference for UpdateLifecyclePolicy Operation</seealso>
        public virtual UpdateLifecyclePolicyResponse UpdateLifecyclePolicy(UpdateLifecyclePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateLifecyclePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLifecyclePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLifecyclePolicy operation on AmazonDLMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLifecyclePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/UpdateLifecyclePolicy">REST API Reference for UpdateLifecyclePolicy Operation</seealso>
        public virtual IAsyncResult BeginUpdateLifecyclePolicy(UpdateLifecyclePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLifecyclePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLifecyclePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLifecyclePolicy.</param>
        /// 
        /// <returns>Returns a  UpdateLifecyclePolicyResult from DLM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/UpdateLifecyclePolicy">REST API Reference for UpdateLifecyclePolicy Operation</seealso>
        public virtual UpdateLifecyclePolicyResponse EndUpdateLifecyclePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLifecyclePolicyResponse>(asyncResult);
        }

        #endregion
        
    }
}