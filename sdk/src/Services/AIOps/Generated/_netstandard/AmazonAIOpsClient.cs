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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AIOps.Model;
using Amazon.AIOps.Model.Internal.MarshallTransformations;
using Amazon.AIOps.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

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
            : base(new AmazonAIOpsConfig()) { }

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
            : base(new AmazonAIOpsConfig{RegionEndpoint = region}) { }

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
            : base(config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
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

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAIOpsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAIOpsAuthSchemeHandler());
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

        internal virtual CreateInvestigationGroupResponse CreateInvestigationGroup(CreateInvestigationGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInvestigationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInvestigationGroupResponseUnmarshaller.Instance;

            return Invoke<CreateInvestigationGroupResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateInvestigationGroupResponse> CreateInvestigationGroupAsync(CreateInvestigationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInvestigationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInvestigationGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInvestigationGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteInvestigationGroup

        internal virtual DeleteInvestigationGroupResponse DeleteInvestigationGroup(DeleteInvestigationGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInvestigationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInvestigationGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteInvestigationGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified investigation group from your account. You can currently have
        /// one investigation group per Region in your account. After you delete an investigation
        /// group, you can later create a new investigation group in the same Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvestigationGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteInvestigationGroupResponse> DeleteInvestigationGroupAsync(DeleteInvestigationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInvestigationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInvestigationGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInvestigationGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteInvestigationGroupPolicy

        internal virtual DeleteInvestigationGroupPolicyResponse DeleteInvestigationGroupPolicy(DeleteInvestigationGroupPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInvestigationGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInvestigationGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteInvestigationGroupPolicyResponse>(request, options);
        }



        /// <summary>
        /// Removes the IAM resource policy from being associated with the investigation group
        /// that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvestigationGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteInvestigationGroupPolicyResponse> DeleteInvestigationGroupPolicyAsync(DeleteInvestigationGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInvestigationGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInvestigationGroupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInvestigationGroupPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetInvestigationGroup

        internal virtual GetInvestigationGroupResponse GetInvestigationGroup(GetInvestigationGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInvestigationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvestigationGroupResponseUnmarshaller.Instance;

            return Invoke<GetInvestigationGroupResponse>(request, options);
        }



        /// <summary>
        /// Returns the configuration information for the specified investigation group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvestigationGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetInvestigationGroupResponse> GetInvestigationGroupAsync(GetInvestigationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInvestigationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvestigationGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetInvestigationGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetInvestigationGroupPolicy

        internal virtual GetInvestigationGroupPolicyResponse GetInvestigationGroupPolicy(GetInvestigationGroupPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInvestigationGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvestigationGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<GetInvestigationGroupPolicyResponse>(request, options);
        }



        /// <summary>
        /// Returns the JSON of the IAM resource policy associated with the specified investigation
        /// group in a string. For example, <c>{\"Version\":\"2012-10-17\",\"Statement\":[{\"Effect\":\"Allow\",\"Principal\":{\"Service\":\"aiops.alarms.cloudwatch.amazonaws.com\"},\"Action\":[\"aiops:CreateInvestigation\",\"aiops:CreateInvestigationEvent\"],\"Resource\":\"*\",\"Condition\":{\"StringEquals\":{\"aws:SourceAccount\":\"111122223333\"},\"ArnLike\":{\"aws:SourceArn\":\"arn:aws:cloudwatch:us-east-1:111122223333:alarm:*\"}}}]}</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvestigationGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetInvestigationGroupPolicyResponse> GetInvestigationGroupPolicyAsync(GetInvestigationGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInvestigationGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvestigationGroupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetInvestigationGroupPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListInvestigationGroups

        internal virtual ListInvestigationGroupsResponse ListInvestigationGroups(ListInvestigationGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInvestigationGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvestigationGroupsResponseUnmarshaller.Instance;

            return Invoke<ListInvestigationGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns the ARN and name of each investigation group in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvestigationGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListInvestigationGroupsResponse> ListInvestigationGroupsAsync(ListInvestigationGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInvestigationGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvestigationGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInvestigationGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Displays the tags associated with a CloudWatch investigations resource. Currently,
        /// investigation groups support tagging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutInvestigationGroupPolicy

        internal virtual PutInvestigationGroupPolicyResponse PutInvestigationGroupPolicy(PutInvestigationGroupPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutInvestigationGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInvestigationGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<PutInvestigationGroupPolicyResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<PutInvestigationGroupPolicyResponse> PutInvestigationGroupPolicyAsync(PutInvestigationGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutInvestigationGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInvestigationGroupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutInvestigationGroupPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateInvestigationGroup

        internal virtual UpdateInvestigationGroupResponse UpdateInvestigationGroup(UpdateInvestigationGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateInvestigationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInvestigationGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateInvestigationGroupResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of the specified investigation group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInvestigationGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateInvestigationGroupResponse> UpdateInvestigationGroupAsync(UpdateInvestigationGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateInvestigationGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInvestigationGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateInvestigationGroupResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}