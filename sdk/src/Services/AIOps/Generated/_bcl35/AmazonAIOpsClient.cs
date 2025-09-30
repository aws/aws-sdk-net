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
 * Do not modify this file. This file is generated from the aiops-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.AIOps.Model;
using Amazon.AIOps.Model.Internal.MarshallTransformations;
using Amazon.AIOps.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.AIOps
{
    /// <summary>
    /// <para>Implementation for accessing AIOps</para>
    ///
    /// The CloudWatch investigations feature is a generative AI-powered assistant that can
    /// help you respond to incidents in your system. It uses generative AI to scan your system's
    /// telemetry and quickly surface suggestions that might be related to your issue. These
    /// suggestions include metrics, logs, deployment events, and root-cause hypotheses. 
    /// 
    ///  
    /// <para>
    /// You can use API actions to create, manage, and delete investigation groups and investigation
    /// group policies. To start and manage investigations, you must use the CloudWatch console.
    /// </para>
    /// </summary>
    public partial class AmazonAIOpsClient : AmazonServiceClient, IAmazonAIOps
    {
        private static IServiceMetadata serviceMetadata = new AmazonAIOpsMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IAIOpsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAIOpsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AIOpsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonAIOpsClient with the credentials loaded from the application's
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
        public AmazonAIOpsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAIOpsConfig()) { }

        /// <summary>
        /// Constructs AmazonAIOpsClient with the credentials loaded from the application's
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
        public AmazonAIOpsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAIOpsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAIOpsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAIOpsClient Configuration Object</param>
        public AmazonAIOpsClient(AmazonAIOpsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonAIOpsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAIOpsClient(AWSCredentials credentials)
            : this(credentials, new AmazonAIOpsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAIOpsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAIOpsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAIOpsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAIOpsClient with AWS Credentials and an
        /// AmazonAIOpsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAIOpsClient Configuration Object</param>
        public AmazonAIOpsClient(AWSCredentials credentials, AmazonAIOpsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAIOpsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAIOpsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAIOpsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAIOpsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAIOpsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAIOpsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAIOpsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAIOpsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAIOpsClient Configuration Object</param>
        public AmazonAIOpsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAIOpsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAIOpsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAIOpsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAIOpsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAIOpsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAIOpsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAIOpsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAIOpsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAIOpsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAIOpsClient Configuration Object</param>
        public AmazonAIOpsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAIOpsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAIOpsEndpointResolver());
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


        #region  CreateInvestigationGroup

        /// <summary>
        /// Creates an <i>investigation group</i> in your account. Creating an investigation group
        /// is a one-time setup task for each Region in your account. It is a necessary task to
        /// be able to perform investigations.
        /// 
        ///  
        /// <para>
        /// Settings in the investigation group help you centrally manage the common properties
        /// of your investigations, such as the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Who can access the investigations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether investigation data is encrypted with a customer managed Key Management Service
        /// key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// How long investigations and their data are retained by default.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Currently, you can have one investigation group in each Region in your account. Each
        /// investigation in a Region is a part of the investigation group in that Region
        /// </para>
        ///  
        /// <para>
        /// To create an investigation group and set up CloudWatch investigations, you must be
        /// signed in to an IAM principal that has either the <c>AIOpsConsoleAdminPolicy</c> or
        /// the <c>AdministratorAccess</c> IAM policy attached, or to an account that has similar
        /// permissions.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can configure CloudWatch alarms to start investigations and add events to investigations.
        /// If you create your investigation group with <c>CreateInvestigationGroup</c> and you
        /// want to enable alarms to do this, you must use <c>PutInvestigationGroupPolicy</c>
        /// to create a resource policy that grants this permission to CloudWatch alarms. 
        /// </para>
        ///  
        /// <para>
        /// For more information about configuring CloudWatch alarms, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/AlarmThatSendsEmail.html">Using
        /// Amazon CloudWatch alarms</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvestigationGroup service method.</param>
        /// 
        /// <returns>The response from the CreateInvestigationGroup service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/CreateInvestigationGroup">REST API Reference for CreateInvestigationGroup Operation</seealso>
        public virtual CreateInvestigationGroupResponse CreateInvestigationGroup(CreateInvestigationGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInvestigationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInvestigationGroupResponseUnmarshaller.Instance;

            return Invoke<CreateInvestigationGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInvestigationGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInvestigationGroup operation on AmazonAIOpsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInvestigationGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/CreateInvestigationGroup">REST API Reference for CreateInvestigationGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateInvestigationGroup(CreateInvestigationGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInvestigationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInvestigationGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInvestigationGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInvestigationGroup.</param>
        /// 
        /// <returns>Returns a  CreateInvestigationGroupResult from AIOps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/CreateInvestigationGroup">REST API Reference for CreateInvestigationGroup Operation</seealso>
        public virtual CreateInvestigationGroupResponse EndCreateInvestigationGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInvestigationGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInvestigationGroup

        /// <summary>
        /// Deletes the specified investigation group from your account. You can currently have
        /// one investigation group per Region in your account. After you delete an investigation
        /// group, you can later create a new investigation group in the same Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvestigationGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteInvestigationGroup service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/DeleteInvestigationGroup">REST API Reference for DeleteInvestigationGroup Operation</seealso>
        public virtual DeleteInvestigationGroupResponse DeleteInvestigationGroup(DeleteInvestigationGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInvestigationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInvestigationGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteInvestigationGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInvestigationGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvestigationGroup operation on AmazonAIOpsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInvestigationGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/DeleteInvestigationGroup">REST API Reference for DeleteInvestigationGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteInvestigationGroup(DeleteInvestigationGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInvestigationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInvestigationGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInvestigationGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInvestigationGroup.</param>
        /// 
        /// <returns>Returns a  DeleteInvestigationGroupResult from AIOps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/DeleteInvestigationGroup">REST API Reference for DeleteInvestigationGroup Operation</seealso>
        public virtual DeleteInvestigationGroupResponse EndDeleteInvestigationGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInvestigationGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInvestigationGroupPolicy

        /// <summary>
        /// Removes the IAM resource policy from being associated with the investigation group
        /// that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvestigationGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteInvestigationGroupPolicy service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/DeleteInvestigationGroupPolicy">REST API Reference for DeleteInvestigationGroupPolicy Operation</seealso>
        public virtual DeleteInvestigationGroupPolicyResponse DeleteInvestigationGroupPolicy(DeleteInvestigationGroupPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInvestigationGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInvestigationGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteInvestigationGroupPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInvestigationGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvestigationGroupPolicy operation on AmazonAIOpsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInvestigationGroupPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/DeleteInvestigationGroupPolicy">REST API Reference for DeleteInvestigationGroupPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteInvestigationGroupPolicy(DeleteInvestigationGroupPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInvestigationGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInvestigationGroupPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInvestigationGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInvestigationGroupPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteInvestigationGroupPolicyResult from AIOps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/DeleteInvestigationGroupPolicy">REST API Reference for DeleteInvestigationGroupPolicy Operation</seealso>
        public virtual DeleteInvestigationGroupPolicyResponse EndDeleteInvestigationGroupPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInvestigationGroupPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInvestigationGroup

        /// <summary>
        /// Returns the configuration information for the specified investigation group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvestigationGroup service method.</param>
        /// 
        /// <returns>The response from the GetInvestigationGroup service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/GetInvestigationGroup">REST API Reference for GetInvestigationGroup Operation</seealso>
        public virtual GetInvestigationGroupResponse GetInvestigationGroup(GetInvestigationGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInvestigationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvestigationGroupResponseUnmarshaller.Instance;

            return Invoke<GetInvestigationGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInvestigationGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvestigationGroup operation on AmazonAIOpsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInvestigationGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/GetInvestigationGroup">REST API Reference for GetInvestigationGroup Operation</seealso>
        public virtual IAsyncResult BeginGetInvestigationGroup(GetInvestigationGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInvestigationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvestigationGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInvestigationGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInvestigationGroup.</param>
        /// 
        /// <returns>Returns a  GetInvestigationGroupResult from AIOps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/GetInvestigationGroup">REST API Reference for GetInvestigationGroup Operation</seealso>
        public virtual GetInvestigationGroupResponse EndGetInvestigationGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInvestigationGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInvestigationGroupPolicy

        /// <summary>
        /// Returns the JSON of the IAM resource policy associated with the specified investigation
        /// group in a string. For example, <c>{\"Version\":\"2012-10-17\",\"Statement\":[{\"Effect\":\"Allow\",\"Principal\":{\"Service\":\"aiops.alarms.cloudwatch.amazonaws.com\"},\"Action\":[\"aiops:CreateInvestigation\",\"aiops:CreateInvestigationEvent\"],\"Resource\":\"*\",\"Condition\":{\"StringEquals\":{\"aws:SourceAccount\":\"111122223333\"},\"ArnLike\":{\"aws:SourceArn\":\"arn:aws:cloudwatch:us-east-1:111122223333:alarm:*\"}}}]}</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvestigationGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the GetInvestigationGroupPolicy service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/GetInvestigationGroupPolicy">REST API Reference for GetInvestigationGroupPolicy Operation</seealso>
        public virtual GetInvestigationGroupPolicyResponse GetInvestigationGroupPolicy(GetInvestigationGroupPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInvestigationGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvestigationGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<GetInvestigationGroupPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInvestigationGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvestigationGroupPolicy operation on AmazonAIOpsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInvestigationGroupPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/GetInvestigationGroupPolicy">REST API Reference for GetInvestigationGroupPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetInvestigationGroupPolicy(GetInvestigationGroupPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInvestigationGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvestigationGroupPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInvestigationGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInvestigationGroupPolicy.</param>
        /// 
        /// <returns>Returns a  GetInvestigationGroupPolicyResult from AIOps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/GetInvestigationGroupPolicy">REST API Reference for GetInvestigationGroupPolicy Operation</seealso>
        public virtual GetInvestigationGroupPolicyResponse EndGetInvestigationGroupPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInvestigationGroupPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInvestigationGroups

        /// <summary>
        /// Returns the ARN and name of each investigation group in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvestigationGroups service method.</param>
        /// 
        /// <returns>The response from the ListInvestigationGroups service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/ListInvestigationGroups">REST API Reference for ListInvestigationGroups Operation</seealso>
        public virtual ListInvestigationGroupsResponse ListInvestigationGroups(ListInvestigationGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInvestigationGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvestigationGroupsResponseUnmarshaller.Instance;

            return Invoke<ListInvestigationGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInvestigationGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvestigationGroups operation on AmazonAIOpsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInvestigationGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/ListInvestigationGroups">REST API Reference for ListInvestigationGroups Operation</seealso>
        public virtual IAsyncResult BeginListInvestigationGroups(ListInvestigationGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInvestigationGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvestigationGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInvestigationGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInvestigationGroups.</param>
        /// 
        /// <returns>Returns a  ListInvestigationGroupsResult from AIOps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/ListInvestigationGroups">REST API Reference for ListInvestigationGroups Operation</seealso>
        public virtual ListInvestigationGroupsResponse EndListInvestigationGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInvestigationGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Displays the tags associated with a CloudWatch investigations resource. Currently,
        /// investigation groups support tagging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonAIOpsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from AIOps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutInvestigationGroupPolicy

        /// <summary>
        /// Creates an IAM resource policy and assigns it to the specified investigation group.
        /// 
        ///  
        /// <para>
        /// If you create your investigation group with <c>CreateInvestigationGroup</c> and you
        /// want to enable CloudWatch alarms to create investigations and add events to investigations,
        /// you must use this operation to create a policy similar to this example.
        /// </para>
        ///  
        /// <para>
        ///  <c> { "Version": "2008-10-17", "Statement": [ { "Effect": "Allow", "Principal": {
        /// "Service": "aiops.alarms.cloudwatch.amazonaws.com" }, "Action": [ "aiops:CreateInvestigation",
        /// "aiops:CreateInvestigationEvent" ], "Resource": "*", "Condition": { "StringEquals":
        /// { "aws:SourceAccount": "account-id" }, "ArnLike": { "aws:SourceArn": "arn:aws:cloudwatch:region:account-id:alarm:*"
        /// } } } ] } </c> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInvestigationGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the PutInvestigationGroupPolicy service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/PutInvestigationGroupPolicy">REST API Reference for PutInvestigationGroupPolicy Operation</seealso>
        public virtual PutInvestigationGroupPolicyResponse PutInvestigationGroupPolicy(PutInvestigationGroupPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutInvestigationGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInvestigationGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<PutInvestigationGroupPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutInvestigationGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutInvestigationGroupPolicy operation on AmazonAIOpsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutInvestigationGroupPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/PutInvestigationGroupPolicy">REST API Reference for PutInvestigationGroupPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutInvestigationGroupPolicy(PutInvestigationGroupPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutInvestigationGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInvestigationGroupPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutInvestigationGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutInvestigationGroupPolicy.</param>
        /// 
        /// <returns>Returns a  PutInvestigationGroupPolicyResult from AIOps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/PutInvestigationGroupPolicy">REST API Reference for PutInvestigationGroupPolicy Operation</seealso>
        public virtual PutInvestigationGroupPolicyResponse EndPutInvestigationGroupPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutInvestigationGroupPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified resource.
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonAIOpsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from AIOps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonAIOpsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from AIOps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateInvestigationGroup

        /// <summary>
        /// Updates the configuration of the specified investigation group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInvestigationGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateInvestigationGroup service method, as returned by AIOps.</returns>
        /// <exception cref="Amazon.AIOps.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ConflictException">
        /// This operation couldn't be completed because of a conflict in resource states.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ForbiddenException">
        /// Access id denied for this operation, or this operation is not valid for the specified
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.InternalServerException">
        /// An internal server error occurred. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ThrottlingException">
        /// The request was throttled because of quota limits. You can try again later.
        /// </exception>
        /// <exception cref="Amazon.AIOps.Model.ValidationException">
        /// This operation or its parameters aren't formatted correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/UpdateInvestigationGroup">REST API Reference for UpdateInvestigationGroup Operation</seealso>
        public virtual UpdateInvestigationGroupResponse UpdateInvestigationGroup(UpdateInvestigationGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateInvestigationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInvestigationGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateInvestigationGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInvestigationGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInvestigationGroup operation on AmazonAIOpsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInvestigationGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/UpdateInvestigationGroup">REST API Reference for UpdateInvestigationGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateInvestigationGroup(UpdateInvestigationGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateInvestigationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInvestigationGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInvestigationGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInvestigationGroup.</param>
        /// 
        /// <returns>Returns a  UpdateInvestigationGroupResult from AIOps.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aiops-2018-05-10/UpdateInvestigationGroup">REST API Reference for UpdateInvestigationGroup Operation</seealso>
        public virtual UpdateInvestigationGroupResponse EndUpdateInvestigationGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateInvestigationGroupResponse>(asyncResult);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonAIOpsEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}