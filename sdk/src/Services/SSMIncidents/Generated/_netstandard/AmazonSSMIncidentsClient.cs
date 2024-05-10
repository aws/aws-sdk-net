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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SSMIncidents.Model;
using Amazon.SSMIncidents.Model.Internal.MarshallTransformations;
using Amazon.SSMIncidents.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.SSMIncidents
{
    /// <summary>
    /// <para>Implementation for accessing SSMIncidents</para>
    ///
    /// Systems Manager Incident Manager is an incident management console designed to help
    /// users mitigate and recover from incidents affecting their Amazon Web Services-hosted
    /// applications. An incident is any unplanned interruption or reduction in quality of
    /// services. 
    /// 
    ///  
    /// <para>
    /// Incident Manager increases incident resolution by notifying responders of impact,
    /// highlighting relevant troubleshooting data, and providing collaboration tools to get
    /// services back up and running. To achieve the primary goal of reducing the time-to-resolution
    /// of critical incidents, Incident Manager automates response plans and enables responder
    /// team escalation. 
    /// </para>
    /// </summary>
    public partial class AmazonSSMIncidentsClient : AmazonServiceClient, IAmazonSSMIncidents
    {
        private static IServiceMetadata serviceMetadata = new AmazonSSMIncidentsMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSSMIncidentsClient with the credentials loaded from the application's
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
        public AmazonSSMIncidentsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSSMIncidentsConfig()) { }

        /// <summary>
        /// Constructs AmazonSSMIncidentsClient with the credentials loaded from the application's
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
        public AmazonSSMIncidentsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSSMIncidentsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSSMIncidentsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSSMIncidentsClient Configuration Object</param>
        public AmazonSSMIncidentsClient(AmazonSSMIncidentsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonSSMIncidentsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSSMIncidentsClient(AWSCredentials credentials)
            : this(credentials, new AmazonSSMIncidentsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSMIncidentsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSMIncidentsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSSMIncidentsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSMIncidentsClient with AWS Credentials and an
        /// AmazonSSMIncidentsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSSMIncidentsClient Configuration Object</param>
        public AmazonSSMIncidentsClient(AWSCredentials credentials, AmazonSSMIncidentsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSSMIncidentsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSSMIncidentsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSSMIncidentsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSMIncidentsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSMIncidentsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSSMIncidentsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSMIncidentsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSSMIncidentsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSSMIncidentsClient Configuration Object</param>
        public AmazonSSMIncidentsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSSMIncidentsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSSMIncidentsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSSMIncidentsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSSMIncidentsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSMIncidentsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSMIncidentsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSSMIncidentsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSMIncidentsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSSMIncidentsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSSMIncidentsClient Configuration Object</param>
        public AmazonSSMIncidentsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSSMIncidentsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISSMIncidentsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISSMIncidentsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SSMIncidentsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSSMIncidentsEndpointResolver());
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


        #region  BatchGetIncidentFindings

        internal virtual BatchGetIncidentFindingsResponse BatchGetIncidentFindings(BatchGetIncidentFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetIncidentFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetIncidentFindingsResponseUnmarshaller.Instance;

            return Invoke<BatchGetIncidentFindingsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details about all specified findings for an incident, including descriptive
        /// details about each finding. A finding represents a recent application environment
        /// change made by an CodeDeploy deployment or an CloudFormation stack creation or update
        /// that can be investigated as a potential cause of the incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetIncidentFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetIncidentFindings service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/BatchGetIncidentFindings">REST API Reference for BatchGetIncidentFindings Operation</seealso>
        public virtual Task<BatchGetIncidentFindingsResponse> BatchGetIncidentFindingsAsync(BatchGetIncidentFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetIncidentFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetIncidentFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetIncidentFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateReplicationSet

        internal virtual CreateReplicationSetResponse CreateReplicationSet(CreateReplicationSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationSetResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationSetResponse>(request, options);
        }



        /// <summary>
        /// A replication set replicates and encrypts your data to the provided Regions with the
        /// provided KMS key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReplicationSet service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/CreateReplicationSet">REST API Reference for CreateReplicationSet Operation</seealso>
        public virtual Task<CreateReplicationSetResponse> CreateReplicationSetAsync(CreateReplicationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReplicationSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateResponsePlan

        internal virtual CreateResponsePlanResponse CreateResponsePlan(CreateResponsePlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResponsePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResponsePlanResponseUnmarshaller.Instance;

            return Invoke<CreateResponsePlanResponse>(request, options);
        }



        /// <summary>
        /// Creates a response plan that automates the initial response to incidents. A response
        /// plan engages contacts, starts chat channel collaboration, and initiates runbooks at
        /// the beginning of an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResponsePlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResponsePlan service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/CreateResponsePlan">REST API Reference for CreateResponsePlan Operation</seealso>
        public virtual Task<CreateResponsePlanResponse> CreateResponsePlanAsync(CreateResponsePlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResponsePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResponsePlanResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResponsePlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTimelineEvent

        internal virtual CreateTimelineEventResponse CreateTimelineEvent(CreateTimelineEventRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTimelineEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTimelineEventResponseUnmarshaller.Instance;

            return Invoke<CreateTimelineEventResponse>(request, options);
        }



        /// <summary>
        /// Creates a custom timeline event on the incident details page of an incident record.
        /// Incident Manager automatically creates timeline events that mark key moments during
        /// an incident. You can create custom timeline events to mark important events that Incident
        /// Manager can detect automatically.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTimelineEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTimelineEvent service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/CreateTimelineEvent">REST API Reference for CreateTimelineEvent Operation</seealso>
        public virtual Task<CreateTimelineEventResponse> CreateTimelineEventAsync(CreateTimelineEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTimelineEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTimelineEventResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTimelineEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIncidentRecord

        internal virtual DeleteIncidentRecordResponse DeleteIncidentRecord(DeleteIncidentRecordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIncidentRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIncidentRecordResponseUnmarshaller.Instance;

            return Invoke<DeleteIncidentRecordResponse>(request, options);
        }



        /// <summary>
        /// Delete an incident record from Incident Manager.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIncidentRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIncidentRecord service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteIncidentRecord">REST API Reference for DeleteIncidentRecord Operation</seealso>
        public virtual Task<DeleteIncidentRecordResponse> DeleteIncidentRecordAsync(DeleteIncidentRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIncidentRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIncidentRecordResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIncidentRecordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteReplicationSet

        internal virtual DeleteReplicationSetResponse DeleteReplicationSet(DeleteReplicationSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationSetResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationSetResponse>(request, options);
        }



        /// <summary>
        /// Deletes all Regions in your replication set. Deleting the replication set deletes
        /// all Incident Manager data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReplicationSet service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteReplicationSet">REST API Reference for DeleteReplicationSet Operation</seealso>
        public virtual Task<DeleteReplicationSetResponse> DeleteReplicationSetAsync(DeleteReplicationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReplicationSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourcePolicy

        internal virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the resource policy that Resource Access Manager uses to share your Incident
        /// Manager resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResponsePlan

        internal virtual DeleteResponsePlanResponse DeleteResponsePlan(DeleteResponsePlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResponsePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResponsePlanResponseUnmarshaller.Instance;

            return Invoke<DeleteResponsePlanResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified response plan. Deleting a response plan stops all linked CloudWatch
        /// alarms and EventBridge events from creating an incident with this response plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResponsePlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResponsePlan service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteResponsePlan">REST API Reference for DeleteResponsePlan Operation</seealso>
        public virtual Task<DeleteResponsePlanResponse> DeleteResponsePlanAsync(DeleteResponsePlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResponsePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResponsePlanResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResponsePlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTimelineEvent

        internal virtual DeleteTimelineEventResponse DeleteTimelineEvent(DeleteTimelineEventRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTimelineEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTimelineEventResponseUnmarshaller.Instance;

            return Invoke<DeleteTimelineEventResponse>(request, options);
        }



        /// <summary>
        /// Deletes a timeline event from an incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTimelineEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTimelineEvent service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/DeleteTimelineEvent">REST API Reference for DeleteTimelineEvent Operation</seealso>
        public virtual Task<DeleteTimelineEventResponse> DeleteTimelineEventAsync(DeleteTimelineEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTimelineEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTimelineEventResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTimelineEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIncidentRecord

        internal virtual GetIncidentRecordResponse GetIncidentRecord(GetIncidentRecordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIncidentRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIncidentRecordResponseUnmarshaller.Instance;

            return Invoke<GetIncidentRecordResponse>(request, options);
        }



        /// <summary>
        /// Returns the details for the specified incident record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIncidentRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIncidentRecord service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetIncidentRecord">REST API Reference for GetIncidentRecord Operation</seealso>
        public virtual Task<GetIncidentRecordResponse> GetIncidentRecordAsync(GetIncidentRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIncidentRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIncidentRecordResponseUnmarshaller.Instance;

            return InvokeAsync<GetIncidentRecordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetReplicationSet

        internal virtual GetReplicationSetResponse GetReplicationSet(GetReplicationSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReplicationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReplicationSetResponseUnmarshaller.Instance;

            return Invoke<GetReplicationSetResponse>(request, options);
        }



        /// <summary>
        /// Retrieve your Incident Manager replication set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReplicationSet service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetReplicationSet">REST API Reference for GetReplicationSet Operation</seealso>
        public virtual Task<GetReplicationSetResponse> GetReplicationSetAsync(GetReplicationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReplicationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReplicationSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetReplicationSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourcePolicies

        internal virtual GetResourcePoliciesResponse GetResourcePolicies(GetResourcePoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePoliciesResponseUnmarshaller.Instance;

            return Invoke<GetResourcePoliciesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the resource policies attached to the specified response plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicies service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        public virtual Task<GetResourcePoliciesResponse> GetResourcePoliciesAsync(GetResourcePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResponsePlan

        internal virtual GetResponsePlanResponse GetResponsePlan(GetResponsePlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResponsePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResponsePlanResponseUnmarshaller.Instance;

            return Invoke<GetResponsePlanResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of the specified response plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResponsePlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResponsePlan service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetResponsePlan">REST API Reference for GetResponsePlan Operation</seealso>
        public virtual Task<GetResponsePlanResponse> GetResponsePlanAsync(GetResponsePlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResponsePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResponsePlanResponseUnmarshaller.Instance;

            return InvokeAsync<GetResponsePlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTimelineEvent

        internal virtual GetTimelineEventResponse GetTimelineEvent(GetTimelineEventRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTimelineEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTimelineEventResponseUnmarshaller.Instance;

            return Invoke<GetTimelineEventResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a timeline event based on its ID and incident record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTimelineEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTimelineEvent service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/GetTimelineEvent">REST API Reference for GetTimelineEvent Operation</seealso>
        public virtual Task<GetTimelineEventResponse> GetTimelineEventAsync(GetTimelineEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTimelineEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTimelineEventResponseUnmarshaller.Instance;

            return InvokeAsync<GetTimelineEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIncidentFindings

        internal virtual ListIncidentFindingsResponse ListIncidentFindings(ListIncidentFindingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIncidentFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIncidentFindingsResponseUnmarshaller.Instance;

            return Invoke<ListIncidentFindingsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of the IDs of findings, plus their last modified times, that have
        /// been identified for a specified incident. A finding represents a recent application
        /// environment change made by an CloudFormation stack creation or update or an CodeDeploy
        /// deployment that can be investigated as a potential cause of the incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIncidentFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIncidentFindings service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListIncidentFindings">REST API Reference for ListIncidentFindings Operation</seealso>
        public virtual Task<ListIncidentFindingsResponse> ListIncidentFindingsAsync(ListIncidentFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIncidentFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIncidentFindingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIncidentFindingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIncidentRecords

        internal virtual ListIncidentRecordsResponse ListIncidentRecords(ListIncidentRecordsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIncidentRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIncidentRecordsResponseUnmarshaller.Instance;

            return Invoke<ListIncidentRecordsResponse>(request, options);
        }



        /// <summary>
        /// Lists all incident records in your account. Use this command to retrieve the Amazon
        /// Resource Name (ARN) of the incident record you want to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIncidentRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIncidentRecords service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListIncidentRecords">REST API Reference for ListIncidentRecords Operation</seealso>
        public virtual Task<ListIncidentRecordsResponse> ListIncidentRecordsAsync(ListIncidentRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIncidentRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIncidentRecordsResponseUnmarshaller.Instance;

            return InvokeAsync<ListIncidentRecordsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRelatedItems

        internal virtual ListRelatedItemsResponse ListRelatedItems(ListRelatedItemsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRelatedItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRelatedItemsResponseUnmarshaller.Instance;

            return Invoke<ListRelatedItemsResponse>(request, options);
        }



        /// <summary>
        /// List all related items for an incident record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRelatedItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRelatedItems service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListRelatedItems">REST API Reference for ListRelatedItems Operation</seealso>
        public virtual Task<ListRelatedItemsResponse> ListRelatedItemsAsync(ListRelatedItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRelatedItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRelatedItemsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRelatedItemsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListReplicationSets

        internal virtual ListReplicationSetsResponse ListReplicationSets(ListReplicationSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReplicationSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReplicationSetsResponseUnmarshaller.Instance;

            return Invoke<ListReplicationSetsResponse>(request, options);
        }



        /// <summary>
        /// Lists details about the replication set configured in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReplicationSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReplicationSets service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListReplicationSets">REST API Reference for ListReplicationSets Operation</seealso>
        public virtual Task<ListReplicationSetsResponse> ListReplicationSetsAsync(ListReplicationSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReplicationSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReplicationSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReplicationSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResponsePlans

        internal virtual ListResponsePlansResponse ListResponsePlans(ListResponsePlansRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResponsePlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResponsePlansResponseUnmarshaller.Instance;

            return Invoke<ListResponsePlansResponse>(request, options);
        }



        /// <summary>
        /// Lists all response plans in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResponsePlans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResponsePlans service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListResponsePlans">REST API Reference for ListResponsePlans Operation</seealso>
        public virtual Task<ListResponsePlansResponse> ListResponsePlansAsync(ListResponsePlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResponsePlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResponsePlansResponseUnmarshaller.Instance;

            return InvokeAsync<ListResponsePlansResponse>(request, options, cancellationToken);
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
        /// Lists the tags that are attached to the specified response plan or incident.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTimelineEvents

        internal virtual ListTimelineEventsResponse ListTimelineEvents(ListTimelineEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTimelineEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTimelineEventsResponseUnmarshaller.Instance;

            return Invoke<ListTimelineEventsResponse>(request, options);
        }



        /// <summary>
        /// Lists timeline events for the specified incident record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTimelineEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTimelineEvents service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/ListTimelineEvents">REST API Reference for ListTimelineEvents Operation</seealso>
        public virtual Task<ListTimelineEventsResponse> ListTimelineEventsAsync(ListTimelineEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTimelineEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTimelineEventsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTimelineEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResourcePolicy

        internal virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Adds a resource policy to the specified response plan. The resource policy is used
        /// to share the response plan using Resource Access Manager (RAM). For more information
        /// about cross-account sharing, see <a href="https://docs.aws.amazon.com/incident-manager/latest/userguide/incident-manager-cross-account-cross-region.html">Cross-Region
        /// and cross-account incident management</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartIncident

        internal virtual StartIncidentResponse StartIncident(StartIncidentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartIncidentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartIncidentResponseUnmarshaller.Instance;

            return Invoke<StartIncidentResponse>(request, options);
        }



        /// <summary>
        /// Used to start an incident from CloudWatch alarms, EventBridge events, or manually.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartIncident service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartIncident service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/StartIncident">REST API Reference for StartIncident Operation</seealso>
        public virtual Task<StartIncidentResponse> StartIncidentAsync(StartIncidentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartIncidentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartIncidentResponseUnmarshaller.Instance;

            return InvokeAsync<StartIncidentResponse>(request, options, cancellationToken);
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
        /// Adds a tag to a response plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDeletionProtection

        internal virtual UpdateDeletionProtectionResponse UpdateDeletionProtection(UpdateDeletionProtectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeletionProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeletionProtectionResponseUnmarshaller.Instance;

            return Invoke<UpdateDeletionProtectionResponse>(request, options);
        }



        /// <summary>
        /// Update deletion protection to either allow or deny deletion of the final Region in
        /// a replication set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeletionProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDeletionProtection service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateDeletionProtection">REST API Reference for UpdateDeletionProtection Operation</seealso>
        public virtual Task<UpdateDeletionProtectionResponse> UpdateDeletionProtectionAsync(UpdateDeletionProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeletionProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeletionProtectionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeletionProtectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateIncidentRecord

        internal virtual UpdateIncidentRecordResponse UpdateIncidentRecord(UpdateIncidentRecordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIncidentRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIncidentRecordResponseUnmarshaller.Instance;

            return Invoke<UpdateIncidentRecordResponse>(request, options);
        }



        /// <summary>
        /// Update the details of an incident record. You can use this operation to update an
        /// incident record from the defined chat channel. For more information about using actions
        /// in chat channels, see <a href="https://docs.aws.amazon.com/incident-manager/latest/userguide/chat.html#chat-interact">Interacting
        /// through chat</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIncidentRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIncidentRecord service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateIncidentRecord">REST API Reference for UpdateIncidentRecord Operation</seealso>
        public virtual Task<UpdateIncidentRecordResponse> UpdateIncidentRecordAsync(UpdateIncidentRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIncidentRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIncidentRecordResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIncidentRecordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRelatedItems

        internal virtual UpdateRelatedItemsResponse UpdateRelatedItems(UpdateRelatedItemsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRelatedItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRelatedItemsResponseUnmarshaller.Instance;

            return Invoke<UpdateRelatedItemsResponse>(request, options);
        }



        /// <summary>
        /// Add or remove related items from the related items tab of an incident record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelatedItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRelatedItems service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateRelatedItems">REST API Reference for UpdateRelatedItems Operation</seealso>
        public virtual Task<UpdateRelatedItemsResponse> UpdateRelatedItemsAsync(UpdateRelatedItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRelatedItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRelatedItemsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRelatedItemsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateReplicationSet

        internal virtual UpdateReplicationSetResponse UpdateReplicationSet(UpdateReplicationSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReplicationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationSetResponseUnmarshaller.Instance;

            return Invoke<UpdateReplicationSetResponse>(request, options);
        }



        /// <summary>
        /// Add or delete Regions from your replication set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateReplicationSet service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateReplicationSet">REST API Reference for UpdateReplicationSet Operation</seealso>
        public virtual Task<UpdateReplicationSetResponse> UpdateReplicationSetAsync(UpdateReplicationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateReplicationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReplicationSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateReplicationSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateResponsePlan

        internal virtual UpdateResponsePlanResponse UpdateResponsePlan(UpdateResponsePlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResponsePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResponsePlanResponseUnmarshaller.Instance;

            return Invoke<UpdateResponsePlanResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified response plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResponsePlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResponsePlan service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateResponsePlan">REST API Reference for UpdateResponsePlan Operation</seealso>
        public virtual Task<UpdateResponsePlanResponse> UpdateResponsePlanAsync(UpdateResponsePlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResponsePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResponsePlanResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResponsePlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTimelineEvent

        internal virtual UpdateTimelineEventResponse UpdateTimelineEvent(UpdateTimelineEventRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTimelineEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTimelineEventResponseUnmarshaller.Instance;

            return Invoke<UpdateTimelineEventResponse>(request, options);
        }



        /// <summary>
        /// Updates a timeline event. You can update events of type <c>Custom Event</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTimelineEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTimelineEvent service method, as returned by SSMIncidents.</returns>
        /// <exception cref="Amazon.SSMIncidents.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ConflictException">
        /// Updating or deleting a resource causes an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ResourceNotFoundException">
        /// Request references a resource which doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMIncidents.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-incidents-2018-05-10/UpdateTimelineEvent">REST API Reference for UpdateTimelineEvent Operation</seealso>
        public virtual Task<UpdateTimelineEventResponse> UpdateTimelineEventAsync(UpdateTimelineEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTimelineEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTimelineEventResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTimelineEventResponse>(request, options, cancellationToken);
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
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonSSMIncidentsEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}