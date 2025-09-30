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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Deadline.Model;
using Amazon.Deadline.Model.Internal.MarshallTransformations;
using Amazon.Deadline.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Deadline
{
    /// <summary>
    /// <para>Implementation for accessing Deadline</para>
    ///
    /// The Amazon Web Services Deadline Cloud API provides infrastructure and centralized
    /// management for your projects. Use the Deadline Cloud API to onboard users, assign
    /// projects, and attach permissions specific to their job function.
    /// 
    ///  
    /// <para>
    /// With Deadline Cloud, content production teams can deploy resources for their workforce
    /// securely in the cloud, reducing the costs of added physical infrastructure. Keep your
    /// content production operations secure, while allowing your contributors to access the
    /// tools they need, such as scalable high-speed storage, licenses, and cost management
    /// services.
    /// </para>
    /// </summary>
    public partial class AmazonDeadlineClient : AmazonServiceClient, IAmazonDeadline
    {
        private static IServiceMetadata serviceMetadata = new AmazonDeadlineMetadata();
        private IDeadlinePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDeadlinePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DeadlinePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonDeadlineClient with the credentials loaded from the application's
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
        public AmazonDeadlineClient()
            : base(new AmazonDeadlineConfig()) { }

        /// <summary>
        /// Constructs AmazonDeadlineClient with the credentials loaded from the application's
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
        public AmazonDeadlineClient(RegionEndpoint region)
            : base(new AmazonDeadlineConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDeadlineClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDeadlineClient Configuration Object</param>
        public AmazonDeadlineClient(AmazonDeadlineConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonDeadlineClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDeadlineClient(AWSCredentials credentials)
            : this(credentials, new AmazonDeadlineConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDeadlineClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDeadlineClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDeadlineConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDeadlineClient with AWS Credentials and an
        /// AmazonDeadlineClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDeadlineClient Configuration Object</param>
        public AmazonDeadlineClient(AWSCredentials credentials, AmazonDeadlineConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDeadlineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDeadlineClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDeadlineConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDeadlineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDeadlineClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDeadlineConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDeadlineClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDeadlineClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDeadlineClient Configuration Object</param>
        public AmazonDeadlineClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDeadlineConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDeadlineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDeadlineClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDeadlineConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDeadlineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDeadlineClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDeadlineConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDeadlineClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDeadlineClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDeadlineClient Configuration Object</param>
        public AmazonDeadlineClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDeadlineConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDeadlineEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDeadlineAuthSchemeHandler());
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


        #region  AssociateMemberToFarm


        /// <summary>
        /// Assigns a farm membership level to a member.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToFarm service method.</param>
        /// 
        /// <returns>The response from the AssociateMemberToFarm service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToFarm">REST API Reference for AssociateMemberToFarm Operation</seealso>
        public virtual AssociateMemberToFarmResponse AssociateMemberToFarm(AssociateMemberToFarmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateMemberToFarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberToFarmResponseUnmarshaller.Instance;

            return Invoke<AssociateMemberToFarmResponse>(request, options);
        }


        /// <summary>
        /// Assigns a farm membership level to a member.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToFarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateMemberToFarm service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToFarm">REST API Reference for AssociateMemberToFarm Operation</seealso>
        public virtual Task<AssociateMemberToFarmResponse> AssociateMemberToFarmAsync(AssociateMemberToFarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateMemberToFarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberToFarmResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateMemberToFarmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateMemberToFleet


        /// <summary>
        /// Assigns a fleet membership level to a member.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToFleet service method.</param>
        /// 
        /// <returns>The response from the AssociateMemberToFleet service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToFleet">REST API Reference for AssociateMemberToFleet Operation</seealso>
        public virtual AssociateMemberToFleetResponse AssociateMemberToFleet(AssociateMemberToFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateMemberToFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberToFleetResponseUnmarshaller.Instance;

            return Invoke<AssociateMemberToFleetResponse>(request, options);
        }


        /// <summary>
        /// Assigns a fleet membership level to a member.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateMemberToFleet service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToFleet">REST API Reference for AssociateMemberToFleet Operation</seealso>
        public virtual Task<AssociateMemberToFleetResponse> AssociateMemberToFleetAsync(AssociateMemberToFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateMemberToFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberToFleetResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateMemberToFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateMemberToJob


        /// <summary>
        /// Assigns a job membership level to a member
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToJob service method.</param>
        /// 
        /// <returns>The response from the AssociateMemberToJob service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToJob">REST API Reference for AssociateMemberToJob Operation</seealso>
        public virtual AssociateMemberToJobResponse AssociateMemberToJob(AssociateMemberToJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateMemberToJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberToJobResponseUnmarshaller.Instance;

            return Invoke<AssociateMemberToJobResponse>(request, options);
        }


        /// <summary>
        /// Assigns a job membership level to a member
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateMemberToJob service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToJob">REST API Reference for AssociateMemberToJob Operation</seealso>
        public virtual Task<AssociateMemberToJobResponse> AssociateMemberToJobAsync(AssociateMemberToJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateMemberToJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberToJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateMemberToJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateMemberToQueue


        /// <summary>
        /// Assigns a queue membership level to a member
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToQueue service method.</param>
        /// 
        /// <returns>The response from the AssociateMemberToQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToQueue">REST API Reference for AssociateMemberToQueue Operation</seealso>
        public virtual AssociateMemberToQueueResponse AssociateMemberToQueue(AssociateMemberToQueueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateMemberToQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberToQueueResponseUnmarshaller.Instance;

            return Invoke<AssociateMemberToQueueResponse>(request, options);
        }


        /// <summary>
        /// Assigns a queue membership level to a member
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateMemberToQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToQueue">REST API Reference for AssociateMemberToQueue Operation</seealso>
        public virtual Task<AssociateMemberToQueueResponse> AssociateMemberToQueueAsync(AssociateMemberToQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateMemberToQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberToQueueResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateMemberToQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssumeFleetRoleForRead


        /// <summary>
        /// Get Amazon Web Services credentials from the fleet role. The IAM permissions of the
        /// credentials are scoped down to have read-only access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeFleetRoleForRead service method.</param>
        /// 
        /// <returns>The response from the AssumeFleetRoleForRead service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeFleetRoleForRead">REST API Reference for AssumeFleetRoleForRead Operation</seealso>
        public virtual AssumeFleetRoleForReadResponse AssumeFleetRoleForRead(AssumeFleetRoleForReadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssumeFleetRoleForReadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeFleetRoleForReadResponseUnmarshaller.Instance;

            return Invoke<AssumeFleetRoleForReadResponse>(request, options);
        }


        /// <summary>
        /// Get Amazon Web Services credentials from the fleet role. The IAM permissions of the
        /// credentials are scoped down to have read-only access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeFleetRoleForRead service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssumeFleetRoleForRead service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeFleetRoleForRead">REST API Reference for AssumeFleetRoleForRead Operation</seealso>
        public virtual Task<AssumeFleetRoleForReadResponse> AssumeFleetRoleForReadAsync(AssumeFleetRoleForReadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssumeFleetRoleForReadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeFleetRoleForReadResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssumeFleetRoleForReadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssumeFleetRoleForWorker


        /// <summary>
        /// Get credentials from the fleet role for a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeFleetRoleForWorker service method.</param>
        /// 
        /// <returns>The response from the AssumeFleetRoleForWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeFleetRoleForWorker">REST API Reference for AssumeFleetRoleForWorker Operation</seealso>
        public virtual AssumeFleetRoleForWorkerResponse AssumeFleetRoleForWorker(AssumeFleetRoleForWorkerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssumeFleetRoleForWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeFleetRoleForWorkerResponseUnmarshaller.Instance;

            return Invoke<AssumeFleetRoleForWorkerResponse>(request, options);
        }


        /// <summary>
        /// Get credentials from the fleet role for a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeFleetRoleForWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssumeFleetRoleForWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeFleetRoleForWorker">REST API Reference for AssumeFleetRoleForWorker Operation</seealso>
        public virtual Task<AssumeFleetRoleForWorkerResponse> AssumeFleetRoleForWorkerAsync(AssumeFleetRoleForWorkerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssumeFleetRoleForWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeFleetRoleForWorkerResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssumeFleetRoleForWorkerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssumeQueueRoleForRead


        /// <summary>
        /// Gets Amazon Web Services credentials from the queue role. The IAM permissions of the
        /// credentials are scoped down to have read-only access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeQueueRoleForRead service method.</param>
        /// 
        /// <returns>The response from the AssumeQueueRoleForRead service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForRead">REST API Reference for AssumeQueueRoleForRead Operation</seealso>
        public virtual AssumeQueueRoleForReadResponse AssumeQueueRoleForRead(AssumeQueueRoleForReadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssumeQueueRoleForReadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeQueueRoleForReadResponseUnmarshaller.Instance;

            return Invoke<AssumeQueueRoleForReadResponse>(request, options);
        }


        /// <summary>
        /// Gets Amazon Web Services credentials from the queue role. The IAM permissions of the
        /// credentials are scoped down to have read-only access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeQueueRoleForRead service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssumeQueueRoleForRead service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForRead">REST API Reference for AssumeQueueRoleForRead Operation</seealso>
        public virtual Task<AssumeQueueRoleForReadResponse> AssumeQueueRoleForReadAsync(AssumeQueueRoleForReadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssumeQueueRoleForReadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeQueueRoleForReadResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssumeQueueRoleForReadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssumeQueueRoleForUser


        /// <summary>
        /// Allows a user to assume a role for a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeQueueRoleForUser service method.</param>
        /// 
        /// <returns>The response from the AssumeQueueRoleForUser service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForUser">REST API Reference for AssumeQueueRoleForUser Operation</seealso>
        public virtual AssumeQueueRoleForUserResponse AssumeQueueRoleForUser(AssumeQueueRoleForUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssumeQueueRoleForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeQueueRoleForUserResponseUnmarshaller.Instance;

            return Invoke<AssumeQueueRoleForUserResponse>(request, options);
        }


        /// <summary>
        /// Allows a user to assume a role for a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeQueueRoleForUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssumeQueueRoleForUser service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForUser">REST API Reference for AssumeQueueRoleForUser Operation</seealso>
        public virtual Task<AssumeQueueRoleForUserResponse> AssumeQueueRoleForUserAsync(AssumeQueueRoleForUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssumeQueueRoleForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeQueueRoleForUserResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssumeQueueRoleForUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssumeQueueRoleForWorker


        /// <summary>
        /// Allows a worker to assume a queue role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeQueueRoleForWorker service method.</param>
        /// 
        /// <returns>The response from the AssumeQueueRoleForWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForWorker">REST API Reference for AssumeQueueRoleForWorker Operation</seealso>
        public virtual AssumeQueueRoleForWorkerResponse AssumeQueueRoleForWorker(AssumeQueueRoleForWorkerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssumeQueueRoleForWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeQueueRoleForWorkerResponseUnmarshaller.Instance;

            return Invoke<AssumeQueueRoleForWorkerResponse>(request, options);
        }


        /// <summary>
        /// Allows a worker to assume a queue role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeQueueRoleForWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssumeQueueRoleForWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForWorker">REST API Reference for AssumeQueueRoleForWorker Operation</seealso>
        public virtual Task<AssumeQueueRoleForWorkerResponse> AssumeQueueRoleForWorkerAsync(AssumeQueueRoleForWorkerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssumeQueueRoleForWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeQueueRoleForWorkerResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssumeQueueRoleForWorkerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetJobEntity


        /// <summary>
        /// Get batched job details for a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetJobEntity service method.</param>
        /// 
        /// <returns>The response from the BatchGetJobEntity service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/BatchGetJobEntity">REST API Reference for BatchGetJobEntity Operation</seealso>
        public virtual BatchGetJobEntityResponse BatchGetJobEntity(BatchGetJobEntityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetJobEntityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetJobEntityResponseUnmarshaller.Instance;

            return Invoke<BatchGetJobEntityResponse>(request, options);
        }


        /// <summary>
        /// Get batched job details for a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetJobEntity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetJobEntity service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/BatchGetJobEntity">REST API Reference for BatchGetJobEntity Operation</seealso>
        public virtual Task<BatchGetJobEntityResponse> BatchGetJobEntityAsync(BatchGetJobEntityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetJobEntityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetJobEntityResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetJobEntityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyJobTemplate


        /// <summary>
        /// Copies a job template to an Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyJobTemplate service method.</param>
        /// 
        /// <returns>The response from the CopyJobTemplate service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CopyJobTemplate">REST API Reference for CopyJobTemplate Operation</seealso>
        public virtual CopyJobTemplateResponse CopyJobTemplate(CopyJobTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyJobTemplateResponseUnmarshaller.Instance;

            return Invoke<CopyJobTemplateResponse>(request, options);
        }


        /// <summary>
        /// Copies a job template to an Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyJobTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyJobTemplate service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CopyJobTemplate">REST API Reference for CopyJobTemplate Operation</seealso>
        public virtual Task<CopyJobTemplateResponse> CopyJobTemplateAsync(CopyJobTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyJobTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<CopyJobTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBudget


        /// <summary>
        /// Creates a budget to set spending thresholds for your rendering activity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBudget service method.</param>
        /// 
        /// <returns>The response from the CreateBudget service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateBudget">REST API Reference for CreateBudget Operation</seealso>
        public virtual CreateBudgetResponse CreateBudget(CreateBudgetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBudgetResponseUnmarshaller.Instance;

            return Invoke<CreateBudgetResponse>(request, options);
        }


        /// <summary>
        /// Creates a budget to set spending thresholds for your rendering activity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBudget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBudget service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateBudget">REST API Reference for CreateBudget Operation</seealso>
        public virtual Task<CreateBudgetResponse> CreateBudgetAsync(CreateBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBudgetResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateBudgetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFarm


        /// <summary>
        /// Creates a farm to allow space for queues and fleets. Farms are the space where the
        /// components of your renders gather and are pieced together in the cloud. Farms contain
        /// budgets and allow you to enforce permissions. Deadline Cloud farms are a useful container
        /// for large projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFarm service method.</param>
        /// 
        /// <returns>The response from the CreateFarm service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateFarm">REST API Reference for CreateFarm Operation</seealso>
        public virtual CreateFarmResponse CreateFarm(CreateFarmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFarmResponseUnmarshaller.Instance;

            return Invoke<CreateFarmResponse>(request, options);
        }


        /// <summary>
        /// Creates a farm to allow space for queues and fleets. Farms are the space where the
        /// components of your renders gather and are pieced together in the cloud. Farms contain
        /// budgets and allow you to enforce permissions. Deadline Cloud farms are a useful container
        /// for large projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFarm service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateFarm">REST API Reference for CreateFarm Operation</seealso>
        public virtual Task<CreateFarmResponse> CreateFarmAsync(CreateFarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFarmResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFarmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFleet


        /// <summary>
        /// Creates a fleet. Fleets gather information relating to compute, or capacity, for renders
        /// within your farms. You can choose to manage your own capacity or opt to have fleets
        /// fully managed by Deadline Cloud.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public virtual CreateFleetResponse CreateFleet(CreateFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return Invoke<CreateFleetResponse>(request, options);
        }


        /// <summary>
        /// Creates a fleet. Fleets gather information relating to compute, or capacity, for renders
        /// within your farms. You can choose to manage your own capacity or opt to have fleets
        /// fully managed by Deadline Cloud.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public virtual Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateJob


        /// <summary>
        /// Creates a job. A job is a set of instructions that Deadline Cloud uses to schedule
        /// and run work on available workers. For more information, see <a href="https://docs.aws.amazon.com/deadline-cloud/latest/userguide/deadline-cloud-jobs.html">Deadline
        /// Cloud jobs</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return Invoke<CreateJobResponse>(request, options);
        }


        /// <summary>
        /// Creates a job. A job is a set of instructions that Deadline Cloud uses to schedule
        /// and run work on available workers. For more information, see <a href="https://docs.aws.amazon.com/deadline-cloud/latest/userguide/deadline-cloud-jobs.html">Deadline
        /// Cloud jobs</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLicenseEndpoint


        /// <summary>
        /// Creates a license endpoint to integrate your various licensed software used for rendering
        /// on Deadline Cloud.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateLicenseEndpoint service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateLicenseEndpoint">REST API Reference for CreateLicenseEndpoint Operation</seealso>
        public virtual CreateLicenseEndpointResponse CreateLicenseEndpoint(CreateLicenseEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLicenseEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLicenseEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateLicenseEndpointResponse>(request, options);
        }


        /// <summary>
        /// Creates a license endpoint to integrate your various licensed software used for rendering
        /// on Deadline Cloud.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLicenseEndpoint service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateLicenseEndpoint">REST API Reference for CreateLicenseEndpoint Operation</seealso>
        public virtual Task<CreateLicenseEndpointResponse> CreateLicenseEndpointAsync(CreateLicenseEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLicenseEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLicenseEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateLicenseEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLimit


        /// <summary>
        /// Creates a limit that manages the distribution of shared resources, such as floating
        /// licenses. A limit can throttle work assignments, help manage workloads, and track
        /// current usage. Before you use a limit, you must associate the limit with one or more
        /// queues. 
        /// 
        ///  
        /// <para>
        /// You must add the <c>amountRequirementName</c> to a step in a job template to declare
        /// the limit requirement.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLimit service method.</param>
        /// 
        /// <returns>The response from the CreateLimit service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateLimit">REST API Reference for CreateLimit Operation</seealso>
        public virtual CreateLimitResponse CreateLimit(CreateLimitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLimitResponseUnmarshaller.Instance;

            return Invoke<CreateLimitResponse>(request, options);
        }


        /// <summary>
        /// Creates a limit that manages the distribution of shared resources, such as floating
        /// licenses. A limit can throttle work assignments, help manage workloads, and track
        /// current usage. Before you use a limit, you must associate the limit with one or more
        /// queues. 
        /// 
        ///  
        /// <para>
        /// You must add the <c>amountRequirementName</c> to a step in a job template to declare
        /// the limit requirement.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLimit service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateLimit">REST API Reference for CreateLimit Operation</seealso>
        public virtual Task<CreateLimitResponse> CreateLimitAsync(CreateLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLimitResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateLimitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMonitor


        /// <summary>
        /// Creates an Amazon Web Services Deadline Cloud monitor that you can use to view your
        /// farms, queues, and fleets. After you submit a job, you can track the progress of the
        /// tasks and steps that make up the job, and then download the job's results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor service method.</param>
        /// 
        /// <returns>The response from the CreateMonitor service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        public virtual CreateMonitorResponse CreateMonitor(CreateMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMonitorResponseUnmarshaller.Instance;

            return Invoke<CreateMonitorResponse>(request, options);
        }


        /// <summary>
        /// Creates an Amazon Web Services Deadline Cloud monitor that you can use to view your
        /// farms, queues, and fleets. After you submit a job, you can track the progress of the
        /// tasks and steps that make up the job, and then download the job's results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMonitor service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        public virtual Task<CreateMonitorResponse> CreateMonitorAsync(CreateMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMonitorResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMonitorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateQueue


        /// <summary>
        /// Creates a queue to coordinate the order in which jobs run on a farm. A queue can also
        /// specify where to pull resources and indicate where to output completed jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue service method.</param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        public virtual CreateQueueResponse CreateQueue(CreateQueueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueResponseUnmarshaller.Instance;

            return Invoke<CreateQueueResponse>(request, options);
        }


        /// <summary>
        /// Creates a queue to coordinate the order in which jobs run on a farm. A queue can also
        /// specify where to pull resources and indicate where to output completed jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        public virtual Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateQueueEnvironment


        /// <summary>
        /// Creates an environment for a queue that defines how jobs in the queue run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueueEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateQueueEnvironment service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueEnvironment">REST API Reference for CreateQueueEnvironment Operation</seealso>
        public virtual CreateQueueEnvironmentResponse CreateQueueEnvironment(CreateQueueEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQueueEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateQueueEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Creates an environment for a queue that defines how jobs in the queue run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueueEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQueueEnvironment service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueEnvironment">REST API Reference for CreateQueueEnvironment Operation</seealso>
        public virtual Task<CreateQueueEnvironmentResponse> CreateQueueEnvironmentAsync(CreateQueueEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQueueEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateQueueEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateQueueFleetAssociation


        /// <summary>
        /// Creates an association between a queue and a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueueFleetAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateQueueFleetAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueFleetAssociation">REST API Reference for CreateQueueFleetAssociation Operation</seealso>
        public virtual CreateQueueFleetAssociationResponse CreateQueueFleetAssociation(CreateQueueFleetAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQueueFleetAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueFleetAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateQueueFleetAssociationResponse>(request, options);
        }


        /// <summary>
        /// Creates an association between a queue and a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueueFleetAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQueueFleetAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueFleetAssociation">REST API Reference for CreateQueueFleetAssociation Operation</seealso>
        public virtual Task<CreateQueueFleetAssociationResponse> CreateQueueFleetAssociationAsync(CreateQueueFleetAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQueueFleetAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueFleetAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateQueueFleetAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateQueueLimitAssociation


        /// <summary>
        /// Associates a limit with a particular queue. After the limit is associated, all workers
        /// for jobs that specify the limit associated with the queue are subject to the limit.
        /// You can't associate two limits with the same <c>amountRequirementName</c> to the same
        /// queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueueLimitAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateQueueLimitAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueLimitAssociation">REST API Reference for CreateQueueLimitAssociation Operation</seealso>
        public virtual CreateQueueLimitAssociationResponse CreateQueueLimitAssociation(CreateQueueLimitAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQueueLimitAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueLimitAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateQueueLimitAssociationResponse>(request, options);
        }


        /// <summary>
        /// Associates a limit with a particular queue. After the limit is associated, all workers
        /// for jobs that specify the limit associated with the queue are subject to the limit.
        /// You can't associate two limits with the same <c>amountRequirementName</c> to the same
        /// queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueueLimitAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQueueLimitAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueLimitAssociation">REST API Reference for CreateQueueLimitAssociation Operation</seealso>
        public virtual Task<CreateQueueLimitAssociationResponse> CreateQueueLimitAssociationAsync(CreateQueueLimitAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQueueLimitAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueLimitAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateQueueLimitAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStorageProfile


        /// <summary>
        /// Creates a storage profile that specifies the operating system, file type, and file
        /// location of resources used on a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageProfile service method.</param>
        /// 
        /// <returns>The response from the CreateStorageProfile service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateStorageProfile">REST API Reference for CreateStorageProfile Operation</seealso>
        public virtual CreateStorageProfileResponse CreateStorageProfile(CreateStorageProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStorageProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStorageProfileResponseUnmarshaller.Instance;

            return Invoke<CreateStorageProfileResponse>(request, options);
        }


        /// <summary>
        /// Creates a storage profile that specifies the operating system, file type, and file
        /// location of resources used on a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStorageProfile service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateStorageProfile">REST API Reference for CreateStorageProfile Operation</seealso>
        public virtual Task<CreateStorageProfileResponse> CreateStorageProfileAsync(CreateStorageProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStorageProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStorageProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateStorageProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWorker


        /// <summary>
        /// Creates a worker. A worker tells your instance how much processing power (vCPU), and
        /// memory (GiB) you’ll need to assemble the digital assets held within a particular instance.
        /// You can specify certain instance types to use, or let the worker know which instances
        /// types to exclude.
        /// 
        ///  
        /// <para>
        /// Deadline Cloud limits the number of workers to less than or equal to the fleet's maximum
        /// worker count. The service maintains eventual consistency for the worker count. If
        /// you make multiple rapid calls to <c>CreateWorker</c> before the field updates, you
        /// might exceed your fleet's maximum worker count. For example, if your <c>maxWorkerCount</c>
        /// is 10 and you currently have 9 workers, making two quick <c>CreateWorker</c> calls
        /// might successfully create 2 workers instead of 1, resulting in 11 total workers.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorker service method.</param>
        /// 
        /// <returns>The response from the CreateWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateWorker">REST API Reference for CreateWorker Operation</seealso>
        public virtual CreateWorkerResponse CreateWorker(CreateWorkerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkerResponseUnmarshaller.Instance;

            return Invoke<CreateWorkerResponse>(request, options);
        }


        /// <summary>
        /// Creates a worker. A worker tells your instance how much processing power (vCPU), and
        /// memory (GiB) you’ll need to assemble the digital assets held within a particular instance.
        /// You can specify certain instance types to use, or let the worker know which instances
        /// types to exclude.
        /// 
        ///  
        /// <para>
        /// Deadline Cloud limits the number of workers to less than or equal to the fleet's maximum
        /// worker count. The service maintains eventual consistency for the worker count. If
        /// you make multiple rapid calls to <c>CreateWorker</c> before the field updates, you
        /// might exceed your fleet's maximum worker count. For example, if your <c>maxWorkerCount</c>
        /// is 10 and you currently have 9 workers, making two quick <c>CreateWorker</c> calls
        /// might successfully create 2 workers instead of 1, resulting in 11 total workers.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateWorker">REST API Reference for CreateWorker Operation</seealso>
        public virtual Task<CreateWorkerResponse> CreateWorkerAsync(CreateWorkerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkerResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateWorkerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBudget


        /// <summary>
        /// Deletes a budget.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudget service method.</param>
        /// 
        /// <returns>The response from the DeleteBudget service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteBudget">REST API Reference for DeleteBudget Operation</seealso>
        public virtual DeleteBudgetResponse DeleteBudget(DeleteBudgetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBudgetResponseUnmarshaller.Instance;

            return Invoke<DeleteBudgetResponse>(request, options);
        }


        /// <summary>
        /// Deletes a budget.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBudget service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteBudget">REST API Reference for DeleteBudget Operation</seealso>
        public virtual Task<DeleteBudgetResponse> DeleteBudgetAsync(DeleteBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBudgetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBudgetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFarm


        /// <summary>
        /// Deletes a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFarm service method.</param>
        /// 
        /// <returns>The response from the DeleteFarm service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteFarm">REST API Reference for DeleteFarm Operation</seealso>
        public virtual DeleteFarmResponse DeleteFarm(DeleteFarmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFarmResponseUnmarshaller.Instance;

            return Invoke<DeleteFarmResponse>(request, options);
        }


        /// <summary>
        /// Deletes a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFarm service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteFarm">REST API Reference for DeleteFarm Operation</seealso>
        public virtual Task<DeleteFarmResponse> DeleteFarmAsync(DeleteFarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFarmResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFarmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFleet


        /// <summary>
        /// Deletes a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public virtual DeleteFleetResponse DeleteFleet(DeleteFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetResponse>(request, options);
        }


        /// <summary>
        /// Deletes a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public virtual Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLicenseEndpoint


        /// <summary>
        /// Deletes a license endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteLicenseEndpoint service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteLicenseEndpoint">REST API Reference for DeleteLicenseEndpoint Operation</seealso>
        public virtual DeleteLicenseEndpointResponse DeleteLicenseEndpoint(DeleteLicenseEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLicenseEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLicenseEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteLicenseEndpointResponse>(request, options);
        }


        /// <summary>
        /// Deletes a license endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLicenseEndpoint service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteLicenseEndpoint">REST API Reference for DeleteLicenseEndpoint Operation</seealso>
        public virtual Task<DeleteLicenseEndpointResponse> DeleteLicenseEndpointAsync(DeleteLicenseEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLicenseEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLicenseEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteLicenseEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLimit


        /// <summary>
        /// Removes a limit from the specified farm. Before you delete a limit you must use the
        /// <c>DeleteQueueLimitAssociation</c> operation to remove the association with any queues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLimit service method.</param>
        /// 
        /// <returns>The response from the DeleteLimit service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteLimit">REST API Reference for DeleteLimit Operation</seealso>
        public virtual DeleteLimitResponse DeleteLimit(DeleteLimitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLimitResponseUnmarshaller.Instance;

            return Invoke<DeleteLimitResponse>(request, options);
        }


        /// <summary>
        /// Removes a limit from the specified farm. Before you delete a limit you must use the
        /// <c>DeleteQueueLimitAssociation</c> operation to remove the association with any queues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLimit service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteLimit">REST API Reference for DeleteLimit Operation</seealso>
        public virtual Task<DeleteLimitResponse> DeleteLimitAsync(DeleteLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLimitResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteLimitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMeteredProduct


        /// <summary>
        /// Deletes a metered product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMeteredProduct service method.</param>
        /// 
        /// <returns>The response from the DeleteMeteredProduct service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteMeteredProduct">REST API Reference for DeleteMeteredProduct Operation</seealso>
        public virtual DeleteMeteredProductResponse DeleteMeteredProduct(DeleteMeteredProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMeteredProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMeteredProductResponseUnmarshaller.Instance;

            return Invoke<DeleteMeteredProductResponse>(request, options);
        }


        /// <summary>
        /// Deletes a metered product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMeteredProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMeteredProduct service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteMeteredProduct">REST API Reference for DeleteMeteredProduct Operation</seealso>
        public virtual Task<DeleteMeteredProductResponse> DeleteMeteredProductAsync(DeleteMeteredProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMeteredProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMeteredProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMeteredProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMonitor


        /// <summary>
        /// Removes a Deadline Cloud monitor. After you delete a monitor, you can create a new
        /// one and attach farms to the monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor service method.</param>
        /// 
        /// <returns>The response from the DeleteMonitor service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        public virtual DeleteMonitorResponse DeleteMonitor(DeleteMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMonitorResponseUnmarshaller.Instance;

            return Invoke<DeleteMonitorResponse>(request, options);
        }


        /// <summary>
        /// Removes a Deadline Cloud monitor. After you delete a monitor, you can create a new
        /// one and attach farms to the monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMonitor service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        public virtual Task<DeleteMonitorResponse> DeleteMonitorAsync(DeleteMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMonitorResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMonitorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteQueue


        /// <summary>
        /// Deletes a queue.
        /// 
        ///  <important> 
        /// <para>
        /// You can't recover the jobs in a queue if you delete the queue. Deleting the queue
        /// also deletes the jobs in that queue.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue service method.</param>
        /// 
        /// <returns>The response from the DeleteQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        public virtual DeleteQueueResponse DeleteQueue(DeleteQueueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueResponseUnmarshaller.Instance;

            return Invoke<DeleteQueueResponse>(request, options);
        }


        /// <summary>
        /// Deletes a queue.
        /// 
        ///  <important> 
        /// <para>
        /// You can't recover the jobs in a queue if you delete the queue. Deleting the queue
        /// also deletes the jobs in that queue.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        public virtual Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteQueueEnvironment


        /// <summary>
        /// Deletes a queue environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueueEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteQueueEnvironment service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueEnvironment">REST API Reference for DeleteQueueEnvironment Operation</seealso>
        public virtual DeleteQueueEnvironmentResponse DeleteQueueEnvironment(DeleteQueueEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueueEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteQueueEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Deletes a queue environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueueEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQueueEnvironment service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueEnvironment">REST API Reference for DeleteQueueEnvironment Operation</seealso>
        public virtual Task<DeleteQueueEnvironmentResponse> DeleteQueueEnvironmentAsync(DeleteQueueEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueueEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteQueueEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteQueueFleetAssociation


        /// <summary>
        /// Deletes a queue-fleet association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueueFleetAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteQueueFleetAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueFleetAssociation">REST API Reference for DeleteQueueFleetAssociation Operation</seealso>
        public virtual DeleteQueueFleetAssociationResponse DeleteQueueFleetAssociation(DeleteQueueFleetAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueueFleetAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueFleetAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteQueueFleetAssociationResponse>(request, options);
        }


        /// <summary>
        /// Deletes a queue-fleet association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueueFleetAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQueueFleetAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueFleetAssociation">REST API Reference for DeleteQueueFleetAssociation Operation</seealso>
        public virtual Task<DeleteQueueFleetAssociationResponse> DeleteQueueFleetAssociationAsync(DeleteQueueFleetAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueueFleetAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueFleetAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteQueueFleetAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteQueueLimitAssociation


        /// <summary>
        /// Removes the association between a queue and a limit. You must use the <c>UpdateQueueLimitAssociation</c>
        /// operation to set the status to <c>STOP_LIMIT_USAGE_AND_COMPLETE_TASKS</c> or <c>STOP_LIMIT_USAGE_AND_CANCEL_TASKS</c>.
        /// The status does not change immediately. Use the <c>GetQueueLimitAssociation</c> operation
        /// to see if the status changed to <c>STOPPED</c> before deleting the association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueueLimitAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteQueueLimitAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueLimitAssociation">REST API Reference for DeleteQueueLimitAssociation Operation</seealso>
        public virtual DeleteQueueLimitAssociationResponse DeleteQueueLimitAssociation(DeleteQueueLimitAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueueLimitAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueLimitAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteQueueLimitAssociationResponse>(request, options);
        }


        /// <summary>
        /// Removes the association between a queue and a limit. You must use the <c>UpdateQueueLimitAssociation</c>
        /// operation to set the status to <c>STOP_LIMIT_USAGE_AND_COMPLETE_TASKS</c> or <c>STOP_LIMIT_USAGE_AND_CANCEL_TASKS</c>.
        /// The status does not change immediately. Use the <c>GetQueueLimitAssociation</c> operation
        /// to see if the status changed to <c>STOPPED</c> before deleting the association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueueLimitAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQueueLimitAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueLimitAssociation">REST API Reference for DeleteQueueLimitAssociation Operation</seealso>
        public virtual Task<DeleteQueueLimitAssociationResponse> DeleteQueueLimitAssociationAsync(DeleteQueueLimitAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueueLimitAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueLimitAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteQueueLimitAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStorageProfile


        /// <summary>
        /// Deletes a storage profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteStorageProfile service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteStorageProfile">REST API Reference for DeleteStorageProfile Operation</seealso>
        public virtual DeleteStorageProfileResponse DeleteStorageProfile(DeleteStorageProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStorageProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStorageProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteStorageProfileResponse>(request, options);
        }


        /// <summary>
        /// Deletes a storage profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStorageProfile service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteStorageProfile">REST API Reference for DeleteStorageProfile Operation</seealso>
        public virtual Task<DeleteStorageProfileResponse> DeleteStorageProfileAsync(DeleteStorageProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStorageProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStorageProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteStorageProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorker


        /// <summary>
        /// Deletes a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorker service method.</param>
        /// 
        /// <returns>The response from the DeleteWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteWorker">REST API Reference for DeleteWorker Operation</seealso>
        public virtual DeleteWorkerResponse DeleteWorker(DeleteWorkerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkerResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkerResponse>(request, options);
        }


        /// <summary>
        /// Deletes a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteWorker">REST API Reference for DeleteWorker Operation</seealso>
        public virtual Task<DeleteWorkerResponse> DeleteWorkerAsync(DeleteWorkerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteWorkerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateMemberFromFarm


        /// <summary>
        /// Disassociates a member from a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromFarm service method.</param>
        /// 
        /// <returns>The response from the DisassociateMemberFromFarm service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromFarm">REST API Reference for DisassociateMemberFromFarm Operation</seealso>
        public virtual DisassociateMemberFromFarmResponse DisassociateMemberFromFarm(DisassociateMemberFromFarmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateMemberFromFarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberFromFarmResponseUnmarshaller.Instance;

            return Invoke<DisassociateMemberFromFarmResponse>(request, options);
        }


        /// <summary>
        /// Disassociates a member from a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromFarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateMemberFromFarm service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromFarm">REST API Reference for DisassociateMemberFromFarm Operation</seealso>
        public virtual Task<DisassociateMemberFromFarmResponse> DisassociateMemberFromFarmAsync(DisassociateMemberFromFarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateMemberFromFarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberFromFarmResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateMemberFromFarmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateMemberFromFleet


        /// <summary>
        /// Disassociates a member from a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromFleet service method.</param>
        /// 
        /// <returns>The response from the DisassociateMemberFromFleet service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromFleet">REST API Reference for DisassociateMemberFromFleet Operation</seealso>
        public virtual DisassociateMemberFromFleetResponse DisassociateMemberFromFleet(DisassociateMemberFromFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateMemberFromFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberFromFleetResponseUnmarshaller.Instance;

            return Invoke<DisassociateMemberFromFleetResponse>(request, options);
        }


        /// <summary>
        /// Disassociates a member from a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateMemberFromFleet service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromFleet">REST API Reference for DisassociateMemberFromFleet Operation</seealso>
        public virtual Task<DisassociateMemberFromFleetResponse> DisassociateMemberFromFleetAsync(DisassociateMemberFromFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateMemberFromFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberFromFleetResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateMemberFromFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateMemberFromJob


        /// <summary>
        /// Disassociates a member from a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromJob service method.</param>
        /// 
        /// <returns>The response from the DisassociateMemberFromJob service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromJob">REST API Reference for DisassociateMemberFromJob Operation</seealso>
        public virtual DisassociateMemberFromJobResponse DisassociateMemberFromJob(DisassociateMemberFromJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateMemberFromJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberFromJobResponseUnmarshaller.Instance;

            return Invoke<DisassociateMemberFromJobResponse>(request, options);
        }


        /// <summary>
        /// Disassociates a member from a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateMemberFromJob service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromJob">REST API Reference for DisassociateMemberFromJob Operation</seealso>
        public virtual Task<DisassociateMemberFromJobResponse> DisassociateMemberFromJobAsync(DisassociateMemberFromJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateMemberFromJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberFromJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateMemberFromJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateMemberFromQueue


        /// <summary>
        /// Disassociates a member from a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromQueue service method.</param>
        /// 
        /// <returns>The response from the DisassociateMemberFromQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromQueue">REST API Reference for DisassociateMemberFromQueue Operation</seealso>
        public virtual DisassociateMemberFromQueueResponse DisassociateMemberFromQueue(DisassociateMemberFromQueueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateMemberFromQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberFromQueueResponseUnmarshaller.Instance;

            return Invoke<DisassociateMemberFromQueueResponse>(request, options);
        }


        /// <summary>
        /// Disassociates a member from a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateMemberFromQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromQueue">REST API Reference for DisassociateMemberFromQueue Operation</seealso>
        public virtual Task<DisassociateMemberFromQueueResponse> DisassociateMemberFromQueueAsync(DisassociateMemberFromQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateMemberFromQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberFromQueueResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateMemberFromQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBudget


        /// <summary>
        /// Get a budget.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBudget service method.</param>
        /// 
        /// <returns>The response from the GetBudget service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetBudget">REST API Reference for GetBudget Operation</seealso>
        public virtual GetBudgetResponse GetBudget(GetBudgetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBudgetResponseUnmarshaller.Instance;

            return Invoke<GetBudgetResponse>(request, options);
        }


        /// <summary>
        /// Get a budget.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBudget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBudget service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetBudget">REST API Reference for GetBudget Operation</seealso>
        public virtual Task<GetBudgetResponse> GetBudgetAsync(GetBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBudgetResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBudgetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFarm


        /// <summary>
        /// Get a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFarm service method.</param>
        /// 
        /// <returns>The response from the GetFarm service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetFarm">REST API Reference for GetFarm Operation</seealso>
        public virtual GetFarmResponse GetFarm(GetFarmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFarmResponseUnmarshaller.Instance;

            return Invoke<GetFarmResponse>(request, options);
        }


        /// <summary>
        /// Get a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFarm service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetFarm">REST API Reference for GetFarm Operation</seealso>
        public virtual Task<GetFarmResponse> GetFarmAsync(GetFarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFarmResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFarmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFleet


        /// <summary>
        /// Get a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFleet service method.</param>
        /// 
        /// <returns>The response from the GetFleet service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetFleet">REST API Reference for GetFleet Operation</seealso>
        public virtual GetFleetResponse GetFleet(GetFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFleetResponseUnmarshaller.Instance;

            return Invoke<GetFleetResponse>(request, options);
        }


        /// <summary>
        /// Get a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFleet service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetFleet">REST API Reference for GetFleet Operation</seealso>
        public virtual Task<GetFleetResponse> GetFleetAsync(GetFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFleetResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJob


        /// <summary>
        /// Gets a Deadline Cloud job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual GetJobResponse GetJob(GetJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return Invoke<GetJobResponse>(request, options);
        }


        /// <summary>
        /// Gets a Deadline Cloud job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual Task<GetJobResponse> GetJobAsync(GetJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLicenseEndpoint


        /// <summary>
        /// Gets a licence endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetLicenseEndpoint service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetLicenseEndpoint">REST API Reference for GetLicenseEndpoint Operation</seealso>
        public virtual GetLicenseEndpointResponse GetLicenseEndpoint(GetLicenseEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLicenseEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLicenseEndpointResponseUnmarshaller.Instance;

            return Invoke<GetLicenseEndpointResponse>(request, options);
        }


        /// <summary>
        /// Gets a licence endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLicenseEndpoint service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetLicenseEndpoint">REST API Reference for GetLicenseEndpoint Operation</seealso>
        public virtual Task<GetLicenseEndpointResponse> GetLicenseEndpointAsync(GetLicenseEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLicenseEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLicenseEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLicenseEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLimit


        /// <summary>
        /// Gets information about a specific limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLimit service method.</param>
        /// 
        /// <returns>The response from the GetLimit service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetLimit">REST API Reference for GetLimit Operation</seealso>
        public virtual GetLimitResponse GetLimit(GetLimitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLimitResponseUnmarshaller.Instance;

            return Invoke<GetLimitResponse>(request, options);
        }


        /// <summary>
        /// Gets information about a specific limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLimit service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetLimit">REST API Reference for GetLimit Operation</seealso>
        public virtual Task<GetLimitResponse> GetLimitAsync(GetLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLimitResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLimitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMonitor


        /// <summary>
        /// Gets information about the specified monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMonitor service method.</param>
        /// 
        /// <returns>The response from the GetMonitor service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetMonitor">REST API Reference for GetMonitor Operation</seealso>
        public virtual GetMonitorResponse GetMonitor(GetMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMonitorResponseUnmarshaller.Instance;

            return Invoke<GetMonitorResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMonitor service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetMonitor">REST API Reference for GetMonitor Operation</seealso>
        public virtual Task<GetMonitorResponse> GetMonitorAsync(GetMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMonitorResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMonitorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetQueue


        /// <summary>
        /// Gets a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueue service method.</param>
        /// 
        /// <returns>The response from the GetQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueue">REST API Reference for GetQueue Operation</seealso>
        public virtual GetQueueResponse GetQueue(GetQueueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueResponseUnmarshaller.Instance;

            return Invoke<GetQueueResponse>(request, options);
        }


        /// <summary>
        /// Gets a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueue">REST API Reference for GetQueue Operation</seealso>
        public virtual Task<GetQueueResponse> GetQueueAsync(GetQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetQueueEnvironment


        /// <summary>
        /// Gets a queue environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueueEnvironment service method.</param>
        /// 
        /// <returns>The response from the GetQueueEnvironment service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueEnvironment">REST API Reference for GetQueueEnvironment Operation</seealso>
        public virtual GetQueueEnvironmentResponse GetQueueEnvironment(GetQueueEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueueEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetQueueEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Gets a queue environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueueEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueueEnvironment service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueEnvironment">REST API Reference for GetQueueEnvironment Operation</seealso>
        public virtual Task<GetQueueEnvironmentResponse> GetQueueEnvironmentAsync(GetQueueEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueueEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetQueueEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetQueueFleetAssociation


        /// <summary>
        /// Gets a queue-fleet association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueueFleetAssociation service method.</param>
        /// 
        /// <returns>The response from the GetQueueFleetAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueFleetAssociation">REST API Reference for GetQueueFleetAssociation Operation</seealso>
        public virtual GetQueueFleetAssociationResponse GetQueueFleetAssociation(GetQueueFleetAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueueFleetAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueFleetAssociationResponseUnmarshaller.Instance;

            return Invoke<GetQueueFleetAssociationResponse>(request, options);
        }


        /// <summary>
        /// Gets a queue-fleet association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueueFleetAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueueFleetAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueFleetAssociation">REST API Reference for GetQueueFleetAssociation Operation</seealso>
        public virtual Task<GetQueueFleetAssociationResponse> GetQueueFleetAssociationAsync(GetQueueFleetAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueueFleetAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueFleetAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetQueueFleetAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetQueueLimitAssociation


        /// <summary>
        /// Gets information about a specific association between a queue and a limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueueLimitAssociation service method.</param>
        /// 
        /// <returns>The response from the GetQueueLimitAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueLimitAssociation">REST API Reference for GetQueueLimitAssociation Operation</seealso>
        public virtual GetQueueLimitAssociationResponse GetQueueLimitAssociation(GetQueueLimitAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueueLimitAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueLimitAssociationResponseUnmarshaller.Instance;

            return Invoke<GetQueueLimitAssociationResponse>(request, options);
        }


        /// <summary>
        /// Gets information about a specific association between a queue and a limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueueLimitAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueueLimitAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueLimitAssociation">REST API Reference for GetQueueLimitAssociation Operation</seealso>
        public virtual Task<GetQueueLimitAssociationResponse> GetQueueLimitAssociationAsync(GetQueueLimitAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueueLimitAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueLimitAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetQueueLimitAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSession


        /// <summary>
        /// Gets a session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual GetSessionResponse GetSession(GetSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return Invoke<GetSessionResponse>(request, options);
        }


        /// <summary>
        /// Gets a session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual Task<GetSessionResponse> GetSessionAsync(GetSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSessionAction


        /// <summary>
        /// Gets a session action for the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionAction service method.</param>
        /// 
        /// <returns>The response from the GetSessionAction service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSessionAction">REST API Reference for GetSessionAction Operation</seealso>
        public virtual GetSessionActionResponse GetSessionAction(GetSessionActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionActionResponseUnmarshaller.Instance;

            return Invoke<GetSessionActionResponse>(request, options);
        }


        /// <summary>
        /// Gets a session action for the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSessionAction service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSessionAction">REST API Reference for GetSessionAction Operation</seealso>
        public virtual Task<GetSessionActionResponse> GetSessionActionAsync(GetSessionActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSessionActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSessionsStatisticsAggregation


        /// <summary>
        /// Gets a set of statistics for queues or farms. Before you can call the <c>GetSessionStatisticsAggregation</c>
        /// operation, you must first call the <c>StartSessionsStatisticsAggregation</c> operation.
        /// Statistics are available for 1 hour after you call the <c>StartSessionsStatisticsAggregation</c>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionsStatisticsAggregation service method.</param>
        /// 
        /// <returns>The response from the GetSessionsStatisticsAggregation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSessionsStatisticsAggregation">REST API Reference for GetSessionsStatisticsAggregation Operation</seealso>
        public virtual GetSessionsStatisticsAggregationResponse GetSessionsStatisticsAggregation(GetSessionsStatisticsAggregationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionsStatisticsAggregationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionsStatisticsAggregationResponseUnmarshaller.Instance;

            return Invoke<GetSessionsStatisticsAggregationResponse>(request, options);
        }


        /// <summary>
        /// Gets a set of statistics for queues or farms. Before you can call the <c>GetSessionStatisticsAggregation</c>
        /// operation, you must first call the <c>StartSessionsStatisticsAggregation</c> operation.
        /// Statistics are available for 1 hour after you call the <c>StartSessionsStatisticsAggregation</c>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionsStatisticsAggregation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSessionsStatisticsAggregation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSessionsStatisticsAggregation">REST API Reference for GetSessionsStatisticsAggregation Operation</seealso>
        public virtual Task<GetSessionsStatisticsAggregationResponse> GetSessionsStatisticsAggregationAsync(GetSessionsStatisticsAggregationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionsStatisticsAggregationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionsStatisticsAggregationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSessionsStatisticsAggregationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStep


        /// <summary>
        /// Gets a step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStep service method.</param>
        /// 
        /// <returns>The response from the GetStep service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStep">REST API Reference for GetStep Operation</seealso>
        public virtual GetStepResponse GetStep(GetStepRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStepResponseUnmarshaller.Instance;

            return Invoke<GetStepResponse>(request, options);
        }


        /// <summary>
        /// Gets a step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStep service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStep">REST API Reference for GetStep Operation</seealso>
        public virtual Task<GetStepResponse> GetStepAsync(GetStepRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStepResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetStepResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStorageProfile


        /// <summary>
        /// Gets a storage profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStorageProfile service method.</param>
        /// 
        /// <returns>The response from the GetStorageProfile service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStorageProfile">REST API Reference for GetStorageProfile Operation</seealso>
        public virtual GetStorageProfileResponse GetStorageProfile(GetStorageProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStorageProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStorageProfileResponseUnmarshaller.Instance;

            return Invoke<GetStorageProfileResponse>(request, options);
        }


        /// <summary>
        /// Gets a storage profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStorageProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStorageProfile service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStorageProfile">REST API Reference for GetStorageProfile Operation</seealso>
        public virtual Task<GetStorageProfileResponse> GetStorageProfileAsync(GetStorageProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStorageProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStorageProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetStorageProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStorageProfileForQueue


        /// <summary>
        /// Gets a storage profile for a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStorageProfileForQueue service method.</param>
        /// 
        /// <returns>The response from the GetStorageProfileForQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStorageProfileForQueue">REST API Reference for GetStorageProfileForQueue Operation</seealso>
        public virtual GetStorageProfileForQueueResponse GetStorageProfileForQueue(GetStorageProfileForQueueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStorageProfileForQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStorageProfileForQueueResponseUnmarshaller.Instance;

            return Invoke<GetStorageProfileForQueueResponse>(request, options);
        }


        /// <summary>
        /// Gets a storage profile for a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStorageProfileForQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStorageProfileForQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStorageProfileForQueue">REST API Reference for GetStorageProfileForQueue Operation</seealso>
        public virtual Task<GetStorageProfileForQueueResponse> GetStorageProfileForQueueAsync(GetStorageProfileForQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStorageProfileForQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStorageProfileForQueueResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetStorageProfileForQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTask


        /// <summary>
        /// Gets a task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTask service method.</param>
        /// 
        /// <returns>The response from the GetTask service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetTask">REST API Reference for GetTask Operation</seealso>
        public virtual GetTaskResponse GetTask(GetTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTaskResponseUnmarshaller.Instance;

            return Invoke<GetTaskResponse>(request, options);
        }


        /// <summary>
        /// Gets a task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTask service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetTask">REST API Reference for GetTask Operation</seealso>
        public virtual Task<GetTaskResponse> GetTaskAsync(GetTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWorker


        /// <summary>
        /// Gets a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorker service method.</param>
        /// 
        /// <returns>The response from the GetWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetWorker">REST API Reference for GetWorker Operation</seealso>
        public virtual GetWorkerResponse GetWorker(GetWorkerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkerResponseUnmarshaller.Instance;

            return Invoke<GetWorkerResponse>(request, options);
        }


        /// <summary>
        /// Gets a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetWorker">REST API Reference for GetWorker Operation</seealso>
        public virtual Task<GetWorkerResponse> GetWorkerAsync(GetWorkerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkerResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetWorkerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAvailableMeteredProducts


        /// <summary>
        /// A list of the available metered products.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableMeteredProducts service method.</param>
        /// 
        /// <returns>The response from the ListAvailableMeteredProducts service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListAvailableMeteredProducts">REST API Reference for ListAvailableMeteredProducts Operation</seealso>
        public virtual ListAvailableMeteredProductsResponse ListAvailableMeteredProducts(ListAvailableMeteredProductsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAvailableMeteredProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableMeteredProductsResponseUnmarshaller.Instance;

            return Invoke<ListAvailableMeteredProductsResponse>(request, options);
        }


        /// <summary>
        /// A list of the available metered products.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableMeteredProducts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAvailableMeteredProducts service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListAvailableMeteredProducts">REST API Reference for ListAvailableMeteredProducts Operation</seealso>
        public virtual Task<ListAvailableMeteredProductsResponse> ListAvailableMeteredProductsAsync(ListAvailableMeteredProductsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAvailableMeteredProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableMeteredProductsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAvailableMeteredProductsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBudgets


        /// <summary>
        /// A list of budgets in a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBudgets service method.</param>
        /// 
        /// <returns>The response from the ListBudgets service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListBudgets">REST API Reference for ListBudgets Operation</seealso>
        public virtual ListBudgetsResponse ListBudgets(ListBudgetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBudgetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBudgetsResponseUnmarshaller.Instance;

            return Invoke<ListBudgetsResponse>(request, options);
        }


        /// <summary>
        /// A list of budgets in a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBudgets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBudgets service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListBudgets">REST API Reference for ListBudgets Operation</seealso>
        public virtual Task<ListBudgetsResponse> ListBudgetsAsync(ListBudgetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBudgetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBudgetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBudgetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFarmMembers


        /// <summary>
        /// Lists the members of a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFarmMembers service method.</param>
        /// 
        /// <returns>The response from the ListFarmMembers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFarmMembers">REST API Reference for ListFarmMembers Operation</seealso>
        public virtual ListFarmMembersResponse ListFarmMembers(ListFarmMembersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFarmMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFarmMembersResponseUnmarshaller.Instance;

            return Invoke<ListFarmMembersResponse>(request, options);
        }


        /// <summary>
        /// Lists the members of a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFarmMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFarmMembers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFarmMembers">REST API Reference for ListFarmMembers Operation</seealso>
        public virtual Task<ListFarmMembersResponse> ListFarmMembersAsync(ListFarmMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFarmMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFarmMembersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFarmMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFarms


        /// <summary>
        /// Lists farms.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFarms service method.</param>
        /// 
        /// <returns>The response from the ListFarms service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFarms">REST API Reference for ListFarms Operation</seealso>
        public virtual ListFarmsResponse ListFarms(ListFarmsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFarmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFarmsResponseUnmarshaller.Instance;

            return Invoke<ListFarmsResponse>(request, options);
        }


        /// <summary>
        /// Lists farms.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFarms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFarms service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFarms">REST API Reference for ListFarms Operation</seealso>
        public virtual Task<ListFarmsResponse> ListFarmsAsync(ListFarmsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFarmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFarmsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFarmsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFleetMembers


        /// <summary>
        /// Lists fleet members.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleetMembers service method.</param>
        /// 
        /// <returns>The response from the ListFleetMembers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFleetMembers">REST API Reference for ListFleetMembers Operation</seealso>
        public virtual ListFleetMembersResponse ListFleetMembers(ListFleetMembersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFleetMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetMembersResponseUnmarshaller.Instance;

            return Invoke<ListFleetMembersResponse>(request, options);
        }


        /// <summary>
        /// Lists fleet members.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleetMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFleetMembers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFleetMembers">REST API Reference for ListFleetMembers Operation</seealso>
        public virtual Task<ListFleetMembersResponse> ListFleetMembersAsync(ListFleetMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFleetMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetMembersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFleetMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFleets


        /// <summary>
        /// Lists fleets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFleets">REST API Reference for ListFleets Operation</seealso>
        public virtual ListFleetsResponse ListFleets(ListFleetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return Invoke<ListFleetsResponse>(request, options);
        }


        /// <summary>
        /// Lists fleets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFleets">REST API Reference for ListFleets Operation</seealso>
        public virtual Task<ListFleetsResponse> ListFleetsAsync(ListFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFleetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobMembers


        /// <summary>
        /// Lists members on a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobMembers service method.</param>
        /// 
        /// <returns>The response from the ListJobMembers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobMembers">REST API Reference for ListJobMembers Operation</seealso>
        public virtual ListJobMembersResponse ListJobMembers(ListJobMembersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobMembersResponseUnmarshaller.Instance;

            return Invoke<ListJobMembersResponse>(request, options);
        }


        /// <summary>
        /// Lists members on a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobMembers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobMembers">REST API Reference for ListJobMembers Operation</seealso>
        public virtual Task<ListJobMembersResponse> ListJobMembersAsync(ListJobMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobMembersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListJobMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobParameterDefinitions


        /// <summary>
        /// Lists parameter definitions of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobParameterDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListJobParameterDefinitions service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobParameterDefinitions">REST API Reference for ListJobParameterDefinitions Operation</seealso>
        public virtual ListJobParameterDefinitionsResponse ListJobParameterDefinitions(ListJobParameterDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobParameterDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobParameterDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListJobParameterDefinitionsResponse>(request, options);
        }


        /// <summary>
        /// Lists parameter definitions of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobParameterDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobParameterDefinitions service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobParameterDefinitions">REST API Reference for ListJobParameterDefinitions Operation</seealso>
        public virtual Task<ListJobParameterDefinitionsResponse> ListJobParameterDefinitionsAsync(ListJobParameterDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobParameterDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobParameterDefinitionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListJobParameterDefinitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// Lists jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }


        /// <summary>
        /// Lists jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLicenseEndpoints


        /// <summary>
        /// Lists license endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListLicenseEndpoints service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListLicenseEndpoints">REST API Reference for ListLicenseEndpoints Operation</seealso>
        public virtual ListLicenseEndpointsResponse ListLicenseEndpoints(ListLicenseEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLicenseEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLicenseEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListLicenseEndpointsResponse>(request, options);
        }


        /// <summary>
        /// Lists license endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLicenseEndpoints service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListLicenseEndpoints">REST API Reference for ListLicenseEndpoints Operation</seealso>
        public virtual Task<ListLicenseEndpointsResponse> ListLicenseEndpointsAsync(ListLicenseEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLicenseEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLicenseEndpointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListLicenseEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLimits


        /// <summary>
        /// Gets a list of limits defined in the specified farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLimits service method.</param>
        /// 
        /// <returns>The response from the ListLimits service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListLimits">REST API Reference for ListLimits Operation</seealso>
        public virtual ListLimitsResponse ListLimits(ListLimitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLimitsResponseUnmarshaller.Instance;

            return Invoke<ListLimitsResponse>(request, options);
        }


        /// <summary>
        /// Gets a list of limits defined in the specified farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLimits service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListLimits">REST API Reference for ListLimits Operation</seealso>
        public virtual Task<ListLimitsResponse> ListLimitsAsync(ListLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLimitsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMeteredProducts


        /// <summary>
        /// Lists metered products.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMeteredProducts service method.</param>
        /// 
        /// <returns>The response from the ListMeteredProducts service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListMeteredProducts">REST API Reference for ListMeteredProducts Operation</seealso>
        public virtual ListMeteredProductsResponse ListMeteredProducts(ListMeteredProductsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMeteredProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMeteredProductsResponseUnmarshaller.Instance;

            return Invoke<ListMeteredProductsResponse>(request, options);
        }


        /// <summary>
        /// Lists metered products.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMeteredProducts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMeteredProducts service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListMeteredProducts">REST API Reference for ListMeteredProducts Operation</seealso>
        public virtual Task<ListMeteredProductsResponse> ListMeteredProductsAsync(ListMeteredProductsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMeteredProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMeteredProductsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMeteredProductsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMonitors


        /// <summary>
        /// Gets a list of your monitors in Deadline Cloud.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors service method.</param>
        /// 
        /// <returns>The response from the ListMonitors service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        public virtual ListMonitorsResponse ListMonitors(ListMonitorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMonitorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitorsResponseUnmarshaller.Instance;

            return Invoke<ListMonitorsResponse>(request, options);
        }


        /// <summary>
        /// Gets a list of your monitors in Deadline Cloud.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMonitors service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        public virtual Task<ListMonitorsResponse> ListMonitorsAsync(ListMonitorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMonitorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitorsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMonitorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListQueueEnvironments


        /// <summary>
        /// Lists queue environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueEnvironments service method.</param>
        /// 
        /// <returns>The response from the ListQueueEnvironments service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueEnvironments">REST API Reference for ListQueueEnvironments Operation</seealso>
        public virtual ListQueueEnvironmentsResponse ListQueueEnvironments(ListQueueEnvironmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueueEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueueEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListQueueEnvironmentsResponse>(request, options);
        }


        /// <summary>
        /// Lists queue environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueueEnvironments service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueEnvironments">REST API Reference for ListQueueEnvironments Operation</seealso>
        public virtual Task<ListQueueEnvironmentsResponse> ListQueueEnvironmentsAsync(ListQueueEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueueEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueueEnvironmentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListQueueEnvironmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListQueueFleetAssociations


        /// <summary>
        /// Lists queue-fleet associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueFleetAssociations service method.</param>
        /// 
        /// <returns>The response from the ListQueueFleetAssociations service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueFleetAssociations">REST API Reference for ListQueueFleetAssociations Operation</seealso>
        public virtual ListQueueFleetAssociationsResponse ListQueueFleetAssociations(ListQueueFleetAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueueFleetAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueueFleetAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListQueueFleetAssociationsResponse>(request, options);
        }


        /// <summary>
        /// Lists queue-fleet associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueFleetAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueueFleetAssociations service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueFleetAssociations">REST API Reference for ListQueueFleetAssociations Operation</seealso>
        public virtual Task<ListQueueFleetAssociationsResponse> ListQueueFleetAssociationsAsync(ListQueueFleetAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueueFleetAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueueFleetAssociationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListQueueFleetAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListQueueLimitAssociations


        /// <summary>
        /// Gets a list of the associations between queues and limits defined in a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueLimitAssociations service method.</param>
        /// 
        /// <returns>The response from the ListQueueLimitAssociations service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueLimitAssociations">REST API Reference for ListQueueLimitAssociations Operation</seealso>
        public virtual ListQueueLimitAssociationsResponse ListQueueLimitAssociations(ListQueueLimitAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueueLimitAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueueLimitAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListQueueLimitAssociationsResponse>(request, options);
        }


        /// <summary>
        /// Gets a list of the associations between queues and limits defined in a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueLimitAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueueLimitAssociations service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueLimitAssociations">REST API Reference for ListQueueLimitAssociations Operation</seealso>
        public virtual Task<ListQueueLimitAssociationsResponse> ListQueueLimitAssociationsAsync(ListQueueLimitAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueueLimitAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueueLimitAssociationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListQueueLimitAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListQueueMembers


        /// <summary>
        /// Lists the members in a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueMembers service method.</param>
        /// 
        /// <returns>The response from the ListQueueMembers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueMembers">REST API Reference for ListQueueMembers Operation</seealso>
        public virtual ListQueueMembersResponse ListQueueMembers(ListQueueMembersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueueMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueueMembersResponseUnmarshaller.Instance;

            return Invoke<ListQueueMembersResponse>(request, options);
        }


        /// <summary>
        /// Lists the members in a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueueMembers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueMembers">REST API Reference for ListQueueMembers Operation</seealso>
        public virtual Task<ListQueueMembersResponse> ListQueueMembersAsync(ListQueueMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueueMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueueMembersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListQueueMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListQueues


        /// <summary>
        /// Lists queues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueues service method.</param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueues">REST API Reference for ListQueues Operation</seealso>
        public virtual ListQueuesResponse ListQueues(ListQueuesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueuesResponseUnmarshaller.Instance;

            return Invoke<ListQueuesResponse>(request, options);
        }


        /// <summary>
        /// Lists queues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueues">REST API Reference for ListQueues Operation</seealso>
        public virtual Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueuesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListQueuesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSessionActions


        /// <summary>
        /// Lists session actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessionActions service method.</param>
        /// 
        /// <returns>The response from the ListSessionActions service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessionActions">REST API Reference for ListSessionActions Operation</seealso>
        public virtual ListSessionActionsResponse ListSessionActions(ListSessionActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionActionsResponseUnmarshaller.Instance;

            return Invoke<ListSessionActionsResponse>(request, options);
        }


        /// <summary>
        /// Lists session actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessionActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSessionActions service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessionActions">REST API Reference for ListSessionActions Operation</seealso>
        public virtual Task<ListSessionActionsResponse> ListSessionActionsAsync(ListSessionActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionActionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSessionActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSessions


        /// <summary>
        /// Lists sessions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// 
        /// <returns>The response from the ListSessions service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual ListSessionsResponse ListSessions(ListSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;

            return Invoke<ListSessionsResponse>(request, options);
        }


        /// <summary>
        /// Lists sessions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSessions service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual Task<ListSessionsResponse> ListSessionsAsync(ListSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSessionsForWorker


        /// <summary>
        /// Lists sessions for a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessionsForWorker service method.</param>
        /// 
        /// <returns>The response from the ListSessionsForWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessionsForWorker">REST API Reference for ListSessionsForWorker Operation</seealso>
        public virtual ListSessionsForWorkerResponse ListSessionsForWorker(ListSessionsForWorkerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionsForWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsForWorkerResponseUnmarshaller.Instance;

            return Invoke<ListSessionsForWorkerResponse>(request, options);
        }


        /// <summary>
        /// Lists sessions for a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessionsForWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSessionsForWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessionsForWorker">REST API Reference for ListSessionsForWorker Operation</seealso>
        public virtual Task<ListSessionsForWorkerResponse> ListSessionsForWorkerAsync(ListSessionsForWorkerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionsForWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsForWorkerResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSessionsForWorkerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStepConsumers


        /// <summary>
        /// Lists step consumers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStepConsumers service method.</param>
        /// 
        /// <returns>The response from the ListStepConsumers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStepConsumers">REST API Reference for ListStepConsumers Operation</seealso>
        public virtual ListStepConsumersResponse ListStepConsumers(ListStepConsumersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStepConsumersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStepConsumersResponseUnmarshaller.Instance;

            return Invoke<ListStepConsumersResponse>(request, options);
        }


        /// <summary>
        /// Lists step consumers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStepConsumers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStepConsumers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStepConsumers">REST API Reference for ListStepConsumers Operation</seealso>
        public virtual Task<ListStepConsumersResponse> ListStepConsumersAsync(ListStepConsumersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStepConsumersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStepConsumersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListStepConsumersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStepDependencies


        /// <summary>
        /// Lists the dependencies for a step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStepDependencies service method.</param>
        /// 
        /// <returns>The response from the ListStepDependencies service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStepDependencies">REST API Reference for ListStepDependencies Operation</seealso>
        public virtual ListStepDependenciesResponse ListStepDependencies(ListStepDependenciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStepDependenciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStepDependenciesResponseUnmarshaller.Instance;

            return Invoke<ListStepDependenciesResponse>(request, options);
        }


        /// <summary>
        /// Lists the dependencies for a step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStepDependencies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStepDependencies service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStepDependencies">REST API Reference for ListStepDependencies Operation</seealso>
        public virtual Task<ListStepDependenciesResponse> ListStepDependenciesAsync(ListStepDependenciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStepDependenciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStepDependenciesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListStepDependenciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSteps


        /// <summary>
        /// Lists steps for a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSteps service method.</param>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSteps">REST API Reference for ListSteps Operation</seealso>
        public virtual ListStepsResponse ListSteps(ListStepsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStepsResponseUnmarshaller.Instance;

            return Invoke<ListStepsResponse>(request, options);
        }


        /// <summary>
        /// Lists steps for a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSteps">REST API Reference for ListSteps Operation</seealso>
        public virtual Task<ListStepsResponse> ListStepsAsync(ListStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStepsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListStepsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStorageProfiles


        /// <summary>
        /// Lists storage profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStorageProfiles service method.</param>
        /// 
        /// <returns>The response from the ListStorageProfiles service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStorageProfiles">REST API Reference for ListStorageProfiles Operation</seealso>
        public virtual ListStorageProfilesResponse ListStorageProfiles(ListStorageProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStorageProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStorageProfilesResponseUnmarshaller.Instance;

            return Invoke<ListStorageProfilesResponse>(request, options);
        }


        /// <summary>
        /// Lists storage profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStorageProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStorageProfiles service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStorageProfiles">REST API Reference for ListStorageProfiles Operation</seealso>
        public virtual Task<ListStorageProfilesResponse> ListStorageProfilesAsync(ListStorageProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStorageProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStorageProfilesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListStorageProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStorageProfilesForQueue


        /// <summary>
        /// Lists storage profiles for a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStorageProfilesForQueue service method.</param>
        /// 
        /// <returns>The response from the ListStorageProfilesForQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStorageProfilesForQueue">REST API Reference for ListStorageProfilesForQueue Operation</seealso>
        public virtual ListStorageProfilesForQueueResponse ListStorageProfilesForQueue(ListStorageProfilesForQueueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStorageProfilesForQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStorageProfilesForQueueResponseUnmarshaller.Instance;

            return Invoke<ListStorageProfilesForQueueResponse>(request, options);
        }


        /// <summary>
        /// Lists storage profiles for a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStorageProfilesForQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStorageProfilesForQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStorageProfilesForQueue">REST API Reference for ListStorageProfilesForQueue Operation</seealso>
        public virtual Task<ListStorageProfilesForQueueResponse> ListStorageProfilesForQueueAsync(ListStorageProfilesForQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStorageProfilesForQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStorageProfilesForQueueResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListStorageProfilesForQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTasks


        /// <summary>
        /// Lists tasks for a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTasks service method.</param>
        /// 
        /// <returns>The response from the ListTasks service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListTasks">REST API Reference for ListTasks Operation</seealso>
        public virtual ListTasksResponse ListTasks(ListTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTasksResponseUnmarshaller.Instance;

            return Invoke<ListTasksResponse>(request, options);
        }


        /// <summary>
        /// Lists tasks for a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTasks service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListTasks">REST API Reference for ListTasks Operation</seealso>
        public virtual Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTasksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkers


        /// <summary>
        /// Lists workers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkers service method.</param>
        /// 
        /// <returns>The response from the ListWorkers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListWorkers">REST API Reference for ListWorkers Operation</seealso>
        public virtual ListWorkersResponse ListWorkers(ListWorkersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkersResponseUnmarshaller.Instance;

            return Invoke<ListWorkersResponse>(request, options);
        }


        /// <summary>
        /// Lists workers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListWorkers">REST API Reference for ListWorkers Operation</seealso>
        public virtual Task<ListWorkersResponse> ListWorkersAsync(ListWorkersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListWorkersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutMeteredProduct


        /// <summary>
        /// Adds a metered product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMeteredProduct service method.</param>
        /// 
        /// <returns>The response from the PutMeteredProduct service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/PutMeteredProduct">REST API Reference for PutMeteredProduct Operation</seealso>
        public virtual PutMeteredProductResponse PutMeteredProduct(PutMeteredProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMeteredProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMeteredProductResponseUnmarshaller.Instance;

            return Invoke<PutMeteredProductResponse>(request, options);
        }


        /// <summary>
        /// Adds a metered product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMeteredProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMeteredProduct service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/PutMeteredProduct">REST API Reference for PutMeteredProduct Operation</seealso>
        public virtual Task<PutMeteredProductResponse> PutMeteredProductAsync(PutMeteredProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMeteredProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMeteredProductResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutMeteredProductResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchJobs


        /// <summary>
        /// Searches for jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchJobs service method.</param>
        /// 
        /// <returns>The response from the SearchJobs service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchJobs">REST API Reference for SearchJobs Operation</seealso>
        public virtual SearchJobsResponse SearchJobs(SearchJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchJobsResponseUnmarshaller.Instance;

            return Invoke<SearchJobsResponse>(request, options);
        }


        /// <summary>
        /// Searches for jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchJobs service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchJobs">REST API Reference for SearchJobs Operation</seealso>
        public virtual Task<SearchJobsResponse> SearchJobsAsync(SearchJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchSteps


        /// <summary>
        /// Searches for steps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSteps service method.</param>
        /// 
        /// <returns>The response from the SearchSteps service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchSteps">REST API Reference for SearchSteps Operation</seealso>
        public virtual SearchStepsResponse SearchSteps(SearchStepsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchStepsResponseUnmarshaller.Instance;

            return Invoke<SearchStepsResponse>(request, options);
        }


        /// <summary>
        /// Searches for steps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchSteps service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchSteps">REST API Reference for SearchSteps Operation</seealso>
        public virtual Task<SearchStepsResponse> SearchStepsAsync(SearchStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchStepsResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchStepsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchTasks


        /// <summary>
        /// Searches for tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTasks service method.</param>
        /// 
        /// <returns>The response from the SearchTasks service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchTasks">REST API Reference for SearchTasks Operation</seealso>
        public virtual SearchTasksResponse SearchTasks(SearchTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTasksResponseUnmarshaller.Instance;

            return Invoke<SearchTasksResponse>(request, options);
        }


        /// <summary>
        /// Searches for tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchTasks service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchTasks">REST API Reference for SearchTasks Operation</seealso>
        public virtual Task<SearchTasksResponse> SearchTasksAsync(SearchTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTasksResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchWorkers


        /// <summary>
        /// Searches for workers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchWorkers service method.</param>
        /// 
        /// <returns>The response from the SearchWorkers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchWorkers">REST API Reference for SearchWorkers Operation</seealso>
        public virtual SearchWorkersResponse SearchWorkers(SearchWorkersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchWorkersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchWorkersResponseUnmarshaller.Instance;

            return Invoke<SearchWorkersResponse>(request, options);
        }


        /// <summary>
        /// Searches for workers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchWorkers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchWorkers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchWorkers">REST API Reference for SearchWorkers Operation</seealso>
        public virtual Task<SearchWorkersResponse> SearchWorkersAsync(SearchWorkersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchWorkersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchWorkersResponseUnmarshaller.Instance;
            
            return InvokeAsync<SearchWorkersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartSessionsStatisticsAggregation


        /// <summary>
        /// Starts an asynchronous request for getting aggregated statistics about queues and
        /// farms. Get the statistics using the <c>GetSessionsStatisticsAggregation</c> operation.
        /// You can only have one running aggregation for your Deadline Cloud farm. Call the <c>GetSessionsStatisticsAggregation</c>
        /// operation and check the <c>status</c> field to see if an aggregation is running. Statistics
        /// are available for 1 hour after you call the <c>StartSessionsStatisticsAggregation</c>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSessionsStatisticsAggregation service method.</param>
        /// 
        /// <returns>The response from the StartSessionsStatisticsAggregation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/StartSessionsStatisticsAggregation">REST API Reference for StartSessionsStatisticsAggregation Operation</seealso>
        public virtual StartSessionsStatisticsAggregationResponse StartSessionsStatisticsAggregation(StartSessionsStatisticsAggregationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSessionsStatisticsAggregationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSessionsStatisticsAggregationResponseUnmarshaller.Instance;

            return Invoke<StartSessionsStatisticsAggregationResponse>(request, options);
        }


        /// <summary>
        /// Starts an asynchronous request for getting aggregated statistics about queues and
        /// farms. Get the statistics using the <c>GetSessionsStatisticsAggregation</c> operation.
        /// You can only have one running aggregation for your Deadline Cloud farm. Call the <c>GetSessionsStatisticsAggregation</c>
        /// operation and check the <c>status</c> field to see if an aggregation is running. Statistics
        /// are available for 1 hour after you call the <c>StartSessionsStatisticsAggregation</c>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSessionsStatisticsAggregation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSessionsStatisticsAggregation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/StartSessionsStatisticsAggregation">REST API Reference for StartSessionsStatisticsAggregation Operation</seealso>
        public virtual Task<StartSessionsStatisticsAggregationResponse> StartSessionsStatisticsAggregationAsync(StartSessionsStatisticsAggregationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSessionsStatisticsAggregationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSessionsStatisticsAggregationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartSessionsStatisticsAggregationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags a resource using the resource's ARN and desired tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Tags a resource using the resource's ARN and desired tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from a resource using the resource's ARN and tag to remove.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes a tag from a resource using the resource's ARN and tag to remove.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBudget


        /// <summary>
        /// Updates a budget that sets spending thresholds for rendering activity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudget service method.</param>
        /// 
        /// <returns>The response from the UpdateBudget service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateBudget">REST API Reference for UpdateBudget Operation</seealso>
        public virtual UpdateBudgetResponse UpdateBudget(UpdateBudgetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBudgetResponseUnmarshaller.Instance;

            return Invoke<UpdateBudgetResponse>(request, options);
        }


        /// <summary>
        /// Updates a budget that sets spending thresholds for rendering activity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBudget service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateBudget">REST API Reference for UpdateBudget Operation</seealso>
        public virtual Task<UpdateBudgetResponse> UpdateBudgetAsync(UpdateBudgetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBudgetResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateBudgetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFarm


        /// <summary>
        /// Updates a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFarm service method.</param>
        /// 
        /// <returns>The response from the UpdateFarm service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateFarm">REST API Reference for UpdateFarm Operation</seealso>
        public virtual UpdateFarmResponse UpdateFarm(UpdateFarmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFarmResponseUnmarshaller.Instance;

            return Invoke<UpdateFarmResponse>(request, options);
        }


        /// <summary>
        /// Updates a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFarm service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateFarm">REST API Reference for UpdateFarm Operation</seealso>
        public virtual Task<UpdateFarmResponse> UpdateFarmAsync(UpdateFarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFarmResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFarmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFleet


        /// <summary>
        /// Updates a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet service method.</param>
        /// 
        /// <returns>The response from the UpdateFleet service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        public virtual UpdateFleetResponse UpdateFleet(UpdateFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetResponse>(request, options);
        }


        /// <summary>
        /// Updates a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFleet service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        public virtual Task<UpdateFleetResponse> UpdateFleetAsync(UpdateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateJob


        /// <summary>
        /// Updates a job. 
        /// 
        ///  
        /// <para>
        /// When you change the status of the job to <c>ARCHIVED</c>, the job can't be scheduled
        /// or archived.
        /// </para>
        ///  <important> 
        /// <para>
        /// An archived jobs and its steps and tasks are deleted after 120 days. The job can't
        /// be recovered.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob service method.</param>
        /// 
        /// <returns>The response from the UpdateJob service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        public virtual UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return Invoke<UpdateJobResponse>(request, options);
        }


        /// <summary>
        /// Updates a job. 
        /// 
        ///  
        /// <para>
        /// When you change the status of the job to <c>ARCHIVED</c>, the job can't be scheduled
        /// or archived.
        /// </para>
        ///  <important> 
        /// <para>
        /// An archived jobs and its steps and tasks are deleted after 120 days. The job can't
        /// be recovered.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateJob service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        public virtual Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLimit


        /// <summary>
        /// Updates the properties of the specified limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLimit service method.</param>
        /// 
        /// <returns>The response from the UpdateLimit service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateLimit">REST API Reference for UpdateLimit Operation</seealso>
        public virtual UpdateLimitResponse UpdateLimit(UpdateLimitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLimitResponseUnmarshaller.Instance;

            return Invoke<UpdateLimitResponse>(request, options);
        }


        /// <summary>
        /// Updates the properties of the specified limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLimit service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateLimit">REST API Reference for UpdateLimit Operation</seealso>
        public virtual Task<UpdateLimitResponse> UpdateLimitAsync(UpdateLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLimitResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateLimitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMonitor


        /// <summary>
        /// Modifies the settings for a Deadline Cloud monitor. You can modify one or all of the
        /// settings when you call <c>UpdateMonitor</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitor service method.</param>
        /// 
        /// <returns>The response from the UpdateMonitor service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateMonitor">REST API Reference for UpdateMonitor Operation</seealso>
        public virtual UpdateMonitorResponse UpdateMonitor(UpdateMonitorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMonitorResponseUnmarshaller.Instance;

            return Invoke<UpdateMonitorResponse>(request, options);
        }


        /// <summary>
        /// Modifies the settings for a Deadline Cloud monitor. You can modify one or all of the
        /// settings when you call <c>UpdateMonitor</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMonitor service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateMonitor">REST API Reference for UpdateMonitor Operation</seealso>
        public virtual Task<UpdateMonitorResponse> UpdateMonitorAsync(UpdateMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMonitorResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateMonitorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateQueue


        /// <summary>
        /// Updates a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueue service method.</param>
        /// 
        /// <returns>The response from the UpdateQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueue">REST API Reference for UpdateQueue Operation</seealso>
        public virtual UpdateQueueResponse UpdateQueue(UpdateQueueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueResponseUnmarshaller.Instance;

            return Invoke<UpdateQueueResponse>(request, options);
        }


        /// <summary>
        /// Updates a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueue">REST API Reference for UpdateQueue Operation</seealso>
        public virtual Task<UpdateQueueResponse> UpdateQueueAsync(UpdateQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateQueueEnvironment


        /// <summary>
        /// Updates the queue environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateQueueEnvironment service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueEnvironment">REST API Reference for UpdateQueueEnvironment Operation</seealso>
        public virtual UpdateQueueEnvironmentResponse UpdateQueueEnvironment(UpdateQueueEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQueueEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateQueueEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Updates the queue environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQueueEnvironment service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueEnvironment">REST API Reference for UpdateQueueEnvironment Operation</seealso>
        public virtual Task<UpdateQueueEnvironmentResponse> UpdateQueueEnvironmentAsync(UpdateQueueEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQueueEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateQueueEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateQueueFleetAssociation


        /// <summary>
        /// Updates a queue-fleet association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueFleetAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateQueueFleetAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueFleetAssociation">REST API Reference for UpdateQueueFleetAssociation Operation</seealso>
        public virtual UpdateQueueFleetAssociationResponse UpdateQueueFleetAssociation(UpdateQueueFleetAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQueueFleetAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueFleetAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateQueueFleetAssociationResponse>(request, options);
        }


        /// <summary>
        /// Updates a queue-fleet association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueFleetAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQueueFleetAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueFleetAssociation">REST API Reference for UpdateQueueFleetAssociation Operation</seealso>
        public virtual Task<UpdateQueueFleetAssociationResponse> UpdateQueueFleetAssociationAsync(UpdateQueueFleetAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQueueFleetAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueFleetAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateQueueFleetAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateQueueLimitAssociation


        /// <summary>
        /// Updates the status of the queue. If you set the status to one of the <c>STOP_LIMIT_USAGE*</c>
        /// values, there will be a delay before the status transitions to the <c>STOPPED</c>
        /// state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueLimitAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateQueueLimitAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueLimitAssociation">REST API Reference for UpdateQueueLimitAssociation Operation</seealso>
        public virtual UpdateQueueLimitAssociationResponse UpdateQueueLimitAssociation(UpdateQueueLimitAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQueueLimitAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueLimitAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateQueueLimitAssociationResponse>(request, options);
        }


        /// <summary>
        /// Updates the status of the queue. If you set the status to one of the <c>STOP_LIMIT_USAGE*</c>
        /// values, there will be a delay before the status transitions to the <c>STOPPED</c>
        /// state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueLimitAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQueueLimitAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueLimitAssociation">REST API Reference for UpdateQueueLimitAssociation Operation</seealso>
        public virtual Task<UpdateQueueLimitAssociationResponse> UpdateQueueLimitAssociationAsync(UpdateQueueLimitAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQueueLimitAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueLimitAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateQueueLimitAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSession


        /// <summary>
        /// Updates a session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSession service method.</param>
        /// 
        /// <returns>The response from the UpdateSession service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateSession">REST API Reference for UpdateSession Operation</seealso>
        public virtual UpdateSessionResponse UpdateSession(UpdateSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSessionResponseUnmarshaller.Instance;

            return Invoke<UpdateSessionResponse>(request, options);
        }


        /// <summary>
        /// Updates a session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSession service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateSession">REST API Reference for UpdateSession Operation</seealso>
        public virtual Task<UpdateSessionResponse> UpdateSessionAsync(UpdateSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStep


        /// <summary>
        /// Updates a step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStep service method.</param>
        /// 
        /// <returns>The response from the UpdateStep service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateStep">REST API Reference for UpdateStep Operation</seealso>
        public virtual UpdateStepResponse UpdateStep(UpdateStepRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStepResponseUnmarshaller.Instance;

            return Invoke<UpdateStepResponse>(request, options);
        }


        /// <summary>
        /// Updates a step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStep service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateStep">REST API Reference for UpdateStep Operation</seealso>
        public virtual Task<UpdateStepResponse> UpdateStepAsync(UpdateStepRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStepResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateStepResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStorageProfile


        /// <summary>
        /// Updates a storage profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStorageProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateStorageProfile service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateStorageProfile">REST API Reference for UpdateStorageProfile Operation</seealso>
        public virtual UpdateStorageProfileResponse UpdateStorageProfile(UpdateStorageProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStorageProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStorageProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateStorageProfileResponse>(request, options);
        }


        /// <summary>
        /// Updates a storage profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStorageProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStorageProfile service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateStorageProfile">REST API Reference for UpdateStorageProfile Operation</seealso>
        public virtual Task<UpdateStorageProfileResponse> UpdateStorageProfileAsync(UpdateStorageProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStorageProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStorageProfileResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateStorageProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTask


        /// <summary>
        /// Updates a task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTask service method.</param>
        /// 
        /// <returns>The response from the UpdateTask service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        public virtual UpdateTaskResponse UpdateTask(UpdateTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskResponseUnmarshaller.Instance;

            return Invoke<UpdateTaskResponse>(request, options);
        }


        /// <summary>
        /// Updates a task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTask service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        public virtual Task<UpdateTaskResponse> UpdateTaskAsync(UpdateTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWorker


        /// <summary>
        /// Updates a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorker service method.</param>
        /// 
        /// <returns>The response from the UpdateWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateWorker">REST API Reference for UpdateWorker Operation</seealso>
        public virtual UpdateWorkerResponse UpdateWorker(UpdateWorkerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkerResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkerResponse>(request, options);
        }


        /// <summary>
        /// Updates a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateWorker">REST API Reference for UpdateWorker Operation</seealso>
        public virtual Task<UpdateWorkerResponse> UpdateWorkerAsync(UpdateWorkerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkerResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateWorkerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWorkerSchedule


        /// <summary>
        /// Updates the schedule for a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkerSchedule service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkerSchedule service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateWorkerSchedule">REST API Reference for UpdateWorkerSchedule Operation</seealso>
        public virtual UpdateWorkerScheduleResponse UpdateWorkerSchedule(UpdateWorkerScheduleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkerScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkerScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkerScheduleResponse>(request, options);
        }


        /// <summary>
        /// Updates the schedule for a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkerSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkerSchedule service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateWorkerSchedule">REST API Reference for UpdateWorkerSchedule Operation</seealso>
        public virtual Task<UpdateWorkerScheduleResponse> UpdateWorkerScheduleAsync(UpdateWorkerScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkerScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkerScheduleResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateWorkerScheduleResponse>(request, options, cancellationToken);
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