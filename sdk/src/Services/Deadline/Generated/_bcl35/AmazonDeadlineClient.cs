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
using System.Collections.Generic;
using System.Net;

using Amazon.Deadline.Model;
using Amazon.Deadline.Model.Internal.MarshallTransformations;
using Amazon.Deadline.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
#endif
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDeadlineConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDeadlineConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDeadlineEndpointResolver());
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
        /// Initiates the asynchronous execution of the AssociateMemberToFarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToFarm operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateMemberToFarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToFarm">REST API Reference for AssociateMemberToFarm Operation</seealso>
        public virtual IAsyncResult BeginAssociateMemberToFarm(AssociateMemberToFarmRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateMemberToFarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberToFarmResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateMemberToFarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateMemberToFarm.</param>
        /// 
        /// <returns>Returns a  AssociateMemberToFarmResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToFarm">REST API Reference for AssociateMemberToFarm Operation</seealso>
        public virtual AssociateMemberToFarmResponse EndAssociateMemberToFarm(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateMemberToFarmResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the AssociateMemberToFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToFleet operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateMemberToFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToFleet">REST API Reference for AssociateMemberToFleet Operation</seealso>
        public virtual IAsyncResult BeginAssociateMemberToFleet(AssociateMemberToFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateMemberToFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberToFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateMemberToFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateMemberToFleet.</param>
        /// 
        /// <returns>Returns a  AssociateMemberToFleetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToFleet">REST API Reference for AssociateMemberToFleet Operation</seealso>
        public virtual AssociateMemberToFleetResponse EndAssociateMemberToFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateMemberToFleetResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the AssociateMemberToJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToJob operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateMemberToJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToJob">REST API Reference for AssociateMemberToJob Operation</seealso>
        public virtual IAsyncResult BeginAssociateMemberToJob(AssociateMemberToJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateMemberToJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberToJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateMemberToJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateMemberToJob.</param>
        /// 
        /// <returns>Returns a  AssociateMemberToJobResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToJob">REST API Reference for AssociateMemberToJob Operation</seealso>
        public virtual AssociateMemberToJobResponse EndAssociateMemberToJob(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateMemberToJobResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the AssociateMemberToQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToQueue operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateMemberToQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToQueue">REST API Reference for AssociateMemberToQueue Operation</seealso>
        public virtual IAsyncResult BeginAssociateMemberToQueue(AssociateMemberToQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateMemberToQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMemberToQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateMemberToQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateMemberToQueue.</param>
        /// 
        /// <returns>Returns a  AssociateMemberToQueueResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToQueue">REST API Reference for AssociateMemberToQueue Operation</seealso>
        public virtual AssociateMemberToQueueResponse EndAssociateMemberToQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateMemberToQueueResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the AssumeFleetRoleForRead operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeFleetRoleForRead operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeFleetRoleForRead
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeFleetRoleForRead">REST API Reference for AssumeFleetRoleForRead Operation</seealso>
        public virtual IAsyncResult BeginAssumeFleetRoleForRead(AssumeFleetRoleForReadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssumeFleetRoleForReadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeFleetRoleForReadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssumeFleetRoleForRead operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeFleetRoleForRead.</param>
        /// 
        /// <returns>Returns a  AssumeFleetRoleForReadResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeFleetRoleForRead">REST API Reference for AssumeFleetRoleForRead Operation</seealso>
        public virtual AssumeFleetRoleForReadResponse EndAssumeFleetRoleForRead(IAsyncResult asyncResult)
        {
            return EndInvoke<AssumeFleetRoleForReadResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the AssumeFleetRoleForWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeFleetRoleForWorker operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeFleetRoleForWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeFleetRoleForWorker">REST API Reference for AssumeFleetRoleForWorker Operation</seealso>
        public virtual IAsyncResult BeginAssumeFleetRoleForWorker(AssumeFleetRoleForWorkerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssumeFleetRoleForWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeFleetRoleForWorkerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssumeFleetRoleForWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeFleetRoleForWorker.</param>
        /// 
        /// <returns>Returns a  AssumeFleetRoleForWorkerResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeFleetRoleForWorker">REST API Reference for AssumeFleetRoleForWorker Operation</seealso>
        public virtual AssumeFleetRoleForWorkerResponse EndAssumeFleetRoleForWorker(IAsyncResult asyncResult)
        {
            return EndInvoke<AssumeFleetRoleForWorkerResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the AssumeQueueRoleForRead operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeQueueRoleForRead operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeQueueRoleForRead
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForRead">REST API Reference for AssumeQueueRoleForRead Operation</seealso>
        public virtual IAsyncResult BeginAssumeQueueRoleForRead(AssumeQueueRoleForReadRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssumeQueueRoleForReadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeQueueRoleForReadResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssumeQueueRoleForRead operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeQueueRoleForRead.</param>
        /// 
        /// <returns>Returns a  AssumeQueueRoleForReadResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForRead">REST API Reference for AssumeQueueRoleForRead Operation</seealso>
        public virtual AssumeQueueRoleForReadResponse EndAssumeQueueRoleForRead(IAsyncResult asyncResult)
        {
            return EndInvoke<AssumeQueueRoleForReadResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the AssumeQueueRoleForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeQueueRoleForUser operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeQueueRoleForUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForUser">REST API Reference for AssumeQueueRoleForUser Operation</seealso>
        public virtual IAsyncResult BeginAssumeQueueRoleForUser(AssumeQueueRoleForUserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssumeQueueRoleForUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeQueueRoleForUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssumeQueueRoleForUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeQueueRoleForUser.</param>
        /// 
        /// <returns>Returns a  AssumeQueueRoleForUserResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForUser">REST API Reference for AssumeQueueRoleForUser Operation</seealso>
        public virtual AssumeQueueRoleForUserResponse EndAssumeQueueRoleForUser(IAsyncResult asyncResult)
        {
            return EndInvoke<AssumeQueueRoleForUserResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the AssumeQueueRoleForWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeQueueRoleForWorker operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeQueueRoleForWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForWorker">REST API Reference for AssumeQueueRoleForWorker Operation</seealso>
        public virtual IAsyncResult BeginAssumeQueueRoleForWorker(AssumeQueueRoleForWorkerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssumeQueueRoleForWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeQueueRoleForWorkerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssumeQueueRoleForWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeQueueRoleForWorker.</param>
        /// 
        /// <returns>Returns a  AssumeQueueRoleForWorkerResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForWorker">REST API Reference for AssumeQueueRoleForWorker Operation</seealso>
        public virtual AssumeQueueRoleForWorkerResponse EndAssumeQueueRoleForWorker(IAsyncResult asyncResult)
        {
            return EndInvoke<AssumeQueueRoleForWorkerResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the BatchGetJobEntity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetJobEntity operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetJobEntity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/BatchGetJobEntity">REST API Reference for BatchGetJobEntity Operation</seealso>
        public virtual IAsyncResult BeginBatchGetJobEntity(BatchGetJobEntityRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetJobEntityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetJobEntityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetJobEntity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetJobEntity.</param>
        /// 
        /// <returns>Returns a  BatchGetJobEntityResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/BatchGetJobEntity">REST API Reference for BatchGetJobEntity Operation</seealso>
        public virtual BatchGetJobEntityResponse EndBatchGetJobEntity(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetJobEntityResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CopyJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyJobTemplate operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyJobTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CopyJobTemplate">REST API Reference for CopyJobTemplate Operation</seealso>
        public virtual IAsyncResult BeginCopyJobTemplate(CopyJobTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyJobTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyJobTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyJobTemplate.</param>
        /// 
        /// <returns>Returns a  CopyJobTemplateResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CopyJobTemplate">REST API Reference for CopyJobTemplate Operation</seealso>
        public virtual CopyJobTemplateResponse EndCopyJobTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyJobTemplateResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBudget operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBudget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateBudget">REST API Reference for CreateBudget Operation</seealso>
        public virtual IAsyncResult BeginCreateBudget(CreateBudgetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBudgetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBudget.</param>
        /// 
        /// <returns>Returns a  CreateBudgetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateBudget">REST API Reference for CreateBudget Operation</seealso>
        public virtual CreateBudgetResponse EndCreateBudget(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBudgetResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateFarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFarm operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateFarm">REST API Reference for CreateFarm Operation</seealso>
        public virtual IAsyncResult BeginCreateFarm(CreateFarmRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFarmResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFarm.</param>
        /// 
        /// <returns>Returns a  CreateFarmResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateFarm">REST API Reference for CreateFarm Operation</seealso>
        public virtual CreateFarmResponse EndCreateFarm(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFarmResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public virtual IAsyncResult BeginCreateFleet(CreateFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFleet.</param>
        /// 
        /// <returns>Returns a  CreateFleetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public virtual CreateFleetResponse EndCreateFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFleetResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual IAsyncResult BeginCreateJob(CreateJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJob.</param>
        /// 
        /// <returns>Returns a  CreateJobResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual CreateJobResponse EndCreateJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateJobResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateLicenseEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseEndpoint operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLicenseEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateLicenseEndpoint">REST API Reference for CreateLicenseEndpoint Operation</seealso>
        public virtual IAsyncResult BeginCreateLicenseEndpoint(CreateLicenseEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLicenseEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLicenseEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLicenseEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLicenseEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateLicenseEndpointResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateLicenseEndpoint">REST API Reference for CreateLicenseEndpoint Operation</seealso>
        public virtual CreateLicenseEndpointResponse EndCreateLicenseEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLicenseEndpointResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLimit operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLimit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateLimit">REST API Reference for CreateLimit Operation</seealso>
        public virtual IAsyncResult BeginCreateLimit(CreateLimitRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLimitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLimit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLimit.</param>
        /// 
        /// <returns>Returns a  CreateLimitResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateLimit">REST API Reference for CreateLimit Operation</seealso>
        public virtual CreateLimitResponse EndCreateLimit(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLimitResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        public virtual IAsyncResult BeginCreateMonitor(CreateMonitorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMonitorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMonitor.</param>
        /// 
        /// <returns>Returns a  CreateMonitorResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        public virtual CreateMonitorResponse EndCreateMonitor(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMonitorResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        public virtual IAsyncResult BeginCreateQueue(CreateQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQueue.</param>
        /// 
        /// <returns>Returns a  CreateQueueResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        public virtual CreateQueueResponse EndCreateQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateQueueResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateQueueEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQueueEnvironment operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateQueueEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueEnvironment">REST API Reference for CreateQueueEnvironment Operation</seealso>
        public virtual IAsyncResult BeginCreateQueueEnvironment(CreateQueueEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQueueEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateQueueEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQueueEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateQueueEnvironmentResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueEnvironment">REST API Reference for CreateQueueEnvironment Operation</seealso>
        public virtual CreateQueueEnvironmentResponse EndCreateQueueEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateQueueEnvironmentResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateQueueFleetAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQueueFleetAssociation operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateQueueFleetAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueFleetAssociation">REST API Reference for CreateQueueFleetAssociation Operation</seealso>
        public virtual IAsyncResult BeginCreateQueueFleetAssociation(CreateQueueFleetAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQueueFleetAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueFleetAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateQueueFleetAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQueueFleetAssociation.</param>
        /// 
        /// <returns>Returns a  CreateQueueFleetAssociationResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueFleetAssociation">REST API Reference for CreateQueueFleetAssociation Operation</seealso>
        public virtual CreateQueueFleetAssociationResponse EndCreateQueueFleetAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateQueueFleetAssociationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateQueueLimitAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQueueLimitAssociation operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateQueueLimitAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueLimitAssociation">REST API Reference for CreateQueueLimitAssociation Operation</seealso>
        public virtual IAsyncResult BeginCreateQueueLimitAssociation(CreateQueueLimitAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateQueueLimitAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueLimitAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateQueueLimitAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQueueLimitAssociation.</param>
        /// 
        /// <returns>Returns a  CreateQueueLimitAssociationResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueLimitAssociation">REST API Reference for CreateQueueLimitAssociation Operation</seealso>
        public virtual CreateQueueLimitAssociationResponse EndCreateQueueLimitAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateQueueLimitAssociationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateStorageProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageProfile operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStorageProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateStorageProfile">REST API Reference for CreateStorageProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateStorageProfile(CreateStorageProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStorageProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStorageProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStorageProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStorageProfile.</param>
        /// 
        /// <returns>Returns a  CreateStorageProfileResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateStorageProfile">REST API Reference for CreateStorageProfile Operation</seealso>
        public virtual CreateStorageProfileResponse EndCreateStorageProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStorageProfileResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorker operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateWorker">REST API Reference for CreateWorker Operation</seealso>
        public virtual IAsyncResult BeginCreateWorker(CreateWorkerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorker.</param>
        /// 
        /// <returns>Returns a  CreateWorkerResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateWorker">REST API Reference for CreateWorker Operation</seealso>
        public virtual CreateWorkerResponse EndCreateWorker(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkerResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudget operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBudget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteBudget">REST API Reference for DeleteBudget Operation</seealso>
        public virtual IAsyncResult BeginDeleteBudget(DeleteBudgetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBudgetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBudget.</param>
        /// 
        /// <returns>Returns a  DeleteBudgetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteBudget">REST API Reference for DeleteBudget Operation</seealso>
        public virtual DeleteBudgetResponse EndDeleteBudget(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBudgetResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteFarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFarm operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteFarm">REST API Reference for DeleteFarm Operation</seealso>
        public virtual IAsyncResult BeginDeleteFarm(DeleteFarmRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFarmResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFarm.</param>
        /// 
        /// <returns>Returns a  DeleteFarmResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteFarm">REST API Reference for DeleteFarm Operation</seealso>
        public virtual DeleteFarmResponse EndDeleteFarm(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFarmResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public virtual IAsyncResult BeginDeleteFleet(DeleteFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFleet.</param>
        /// 
        /// <returns>Returns a  DeleteFleetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public virtual DeleteFleetResponse EndDeleteFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFleetResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteLicenseEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseEndpoint operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLicenseEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteLicenseEndpoint">REST API Reference for DeleteLicenseEndpoint Operation</seealso>
        public virtual IAsyncResult BeginDeleteLicenseEndpoint(DeleteLicenseEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLicenseEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLicenseEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLicenseEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLicenseEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteLicenseEndpointResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteLicenseEndpoint">REST API Reference for DeleteLicenseEndpoint Operation</seealso>
        public virtual DeleteLicenseEndpointResponse EndDeleteLicenseEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLicenseEndpointResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLimit operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLimit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteLimit">REST API Reference for DeleteLimit Operation</seealso>
        public virtual IAsyncResult BeginDeleteLimit(DeleteLimitRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLimitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLimit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLimit.</param>
        /// 
        /// <returns>Returns a  DeleteLimitResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteLimit">REST API Reference for DeleteLimit Operation</seealso>
        public virtual DeleteLimitResponse EndDeleteLimit(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLimitResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteMeteredProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMeteredProduct operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMeteredProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteMeteredProduct">REST API Reference for DeleteMeteredProduct Operation</seealso>
        public virtual IAsyncResult BeginDeleteMeteredProduct(DeleteMeteredProductRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMeteredProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMeteredProductResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMeteredProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMeteredProduct.</param>
        /// 
        /// <returns>Returns a  DeleteMeteredProductResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteMeteredProduct">REST API Reference for DeleteMeteredProduct Operation</seealso>
        public virtual DeleteMeteredProductResponse EndDeleteMeteredProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMeteredProductResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        public virtual IAsyncResult BeginDeleteMonitor(DeleteMonitorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMonitorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMonitor.</param>
        /// 
        /// <returns>Returns a  DeleteMonitorResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        public virtual DeleteMonitorResponse EndDeleteMonitor(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMonitorResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        public virtual IAsyncResult BeginDeleteQueue(DeleteQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQueue.</param>
        /// 
        /// <returns>Returns a  DeleteQueueResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        public virtual DeleteQueueResponse EndDeleteQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteQueueResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteQueueEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueueEnvironment operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQueueEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueEnvironment">REST API Reference for DeleteQueueEnvironment Operation</seealso>
        public virtual IAsyncResult BeginDeleteQueueEnvironment(DeleteQueueEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueueEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQueueEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQueueEnvironment.</param>
        /// 
        /// <returns>Returns a  DeleteQueueEnvironmentResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueEnvironment">REST API Reference for DeleteQueueEnvironment Operation</seealso>
        public virtual DeleteQueueEnvironmentResponse EndDeleteQueueEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteQueueEnvironmentResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteQueueFleetAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueueFleetAssociation operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQueueFleetAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueFleetAssociation">REST API Reference for DeleteQueueFleetAssociation Operation</seealso>
        public virtual IAsyncResult BeginDeleteQueueFleetAssociation(DeleteQueueFleetAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueueFleetAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueFleetAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQueueFleetAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQueueFleetAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteQueueFleetAssociationResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueFleetAssociation">REST API Reference for DeleteQueueFleetAssociation Operation</seealso>
        public virtual DeleteQueueFleetAssociationResponse EndDeleteQueueFleetAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteQueueFleetAssociationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteQueueLimitAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueueLimitAssociation operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQueueLimitAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueLimitAssociation">REST API Reference for DeleteQueueLimitAssociation Operation</seealso>
        public virtual IAsyncResult BeginDeleteQueueLimitAssociation(DeleteQueueLimitAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueueLimitAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueLimitAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQueueLimitAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQueueLimitAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteQueueLimitAssociationResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueLimitAssociation">REST API Reference for DeleteQueueLimitAssociation Operation</seealso>
        public virtual DeleteQueueLimitAssociationResponse EndDeleteQueueLimitAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteQueueLimitAssociationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteStorageProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageProfile operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStorageProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteStorageProfile">REST API Reference for DeleteStorageProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteStorageProfile(DeleteStorageProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStorageProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStorageProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStorageProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStorageProfile.</param>
        /// 
        /// <returns>Returns a  DeleteStorageProfileResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteStorageProfile">REST API Reference for DeleteStorageProfile Operation</seealso>
        public virtual DeleteStorageProfileResponse EndDeleteStorageProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStorageProfileResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorker operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteWorker">REST API Reference for DeleteWorker Operation</seealso>
        public virtual IAsyncResult BeginDeleteWorker(DeleteWorkerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorker.</param>
        /// 
        /// <returns>Returns a  DeleteWorkerResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteWorker">REST API Reference for DeleteWorker Operation</seealso>
        public virtual DeleteWorkerResponse EndDeleteWorker(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWorkerResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DisassociateMemberFromFarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromFarm operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMemberFromFarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromFarm">REST API Reference for DisassociateMemberFromFarm Operation</seealso>
        public virtual IAsyncResult BeginDisassociateMemberFromFarm(DisassociateMemberFromFarmRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateMemberFromFarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberFromFarmResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMemberFromFarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMemberFromFarm.</param>
        /// 
        /// <returns>Returns a  DisassociateMemberFromFarmResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromFarm">REST API Reference for DisassociateMemberFromFarm Operation</seealso>
        public virtual DisassociateMemberFromFarmResponse EndDisassociateMemberFromFarm(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateMemberFromFarmResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DisassociateMemberFromFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromFleet operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMemberFromFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromFleet">REST API Reference for DisassociateMemberFromFleet Operation</seealso>
        public virtual IAsyncResult BeginDisassociateMemberFromFleet(DisassociateMemberFromFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateMemberFromFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberFromFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMemberFromFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMemberFromFleet.</param>
        /// 
        /// <returns>Returns a  DisassociateMemberFromFleetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromFleet">REST API Reference for DisassociateMemberFromFleet Operation</seealso>
        public virtual DisassociateMemberFromFleetResponse EndDisassociateMemberFromFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateMemberFromFleetResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DisassociateMemberFromJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromJob operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMemberFromJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromJob">REST API Reference for DisassociateMemberFromJob Operation</seealso>
        public virtual IAsyncResult BeginDisassociateMemberFromJob(DisassociateMemberFromJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateMemberFromJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberFromJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMemberFromJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMemberFromJob.</param>
        /// 
        /// <returns>Returns a  DisassociateMemberFromJobResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromJob">REST API Reference for DisassociateMemberFromJob Operation</seealso>
        public virtual DisassociateMemberFromJobResponse EndDisassociateMemberFromJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateMemberFromJobResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DisassociateMemberFromQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromQueue operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMemberFromQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromQueue">REST API Reference for DisassociateMemberFromQueue Operation</seealso>
        public virtual IAsyncResult BeginDisassociateMemberFromQueue(DisassociateMemberFromQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateMemberFromQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMemberFromQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMemberFromQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMemberFromQueue.</param>
        /// 
        /// <returns>Returns a  DisassociateMemberFromQueueResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromQueue">REST API Reference for DisassociateMemberFromQueue Operation</seealso>
        public virtual DisassociateMemberFromQueueResponse EndDisassociateMemberFromQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateMemberFromQueueResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBudget operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBudget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetBudget">REST API Reference for GetBudget Operation</seealso>
        public virtual IAsyncResult BeginGetBudget(GetBudgetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBudgetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBudget.</param>
        /// 
        /// <returns>Returns a  GetBudgetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetBudget">REST API Reference for GetBudget Operation</seealso>
        public virtual GetBudgetResponse EndGetBudget(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBudgetResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetFarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFarm operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetFarm">REST API Reference for GetFarm Operation</seealso>
        public virtual IAsyncResult BeginGetFarm(GetFarmRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFarmResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFarm.</param>
        /// 
        /// <returns>Returns a  GetFarmResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetFarm">REST API Reference for GetFarm Operation</seealso>
        public virtual GetFarmResponse EndGetFarm(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFarmResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFleet operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetFleet">REST API Reference for GetFleet Operation</seealso>
        public virtual IAsyncResult BeginGetFleet(GetFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFleet.</param>
        /// 
        /// <returns>Returns a  GetFleetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetFleet">REST API Reference for GetFleet Operation</seealso>
        public virtual GetFleetResponse EndGetFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFleetResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJob operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual IAsyncResult BeginGetJob(GetJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJob.</param>
        /// 
        /// <returns>Returns a  GetJobResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual GetJobResponse EndGetJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJobResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetLicenseEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseEndpoint operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLicenseEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetLicenseEndpoint">REST API Reference for GetLicenseEndpoint Operation</seealso>
        public virtual IAsyncResult BeginGetLicenseEndpoint(GetLicenseEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLicenseEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLicenseEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLicenseEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLicenseEndpoint.</param>
        /// 
        /// <returns>Returns a  GetLicenseEndpointResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetLicenseEndpoint">REST API Reference for GetLicenseEndpoint Operation</seealso>
        public virtual GetLicenseEndpointResponse EndGetLicenseEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLicenseEndpointResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLimit operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLimit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetLimit">REST API Reference for GetLimit Operation</seealso>
        public virtual IAsyncResult BeginGetLimit(GetLimitRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLimitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLimit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLimit.</param>
        /// 
        /// <returns>Returns a  GetLimitResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetLimit">REST API Reference for GetLimit Operation</seealso>
        public virtual GetLimitResponse EndGetLimit(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLimitResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMonitor operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetMonitor">REST API Reference for GetMonitor Operation</seealso>
        public virtual IAsyncResult BeginGetMonitor(GetMonitorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMonitorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMonitor.</param>
        /// 
        /// <returns>Returns a  GetMonitorResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetMonitor">REST API Reference for GetMonitor Operation</seealso>
        public virtual GetMonitorResponse EndGetMonitor(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMonitorResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueue operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueue">REST API Reference for GetQueue Operation</seealso>
        public virtual IAsyncResult BeginGetQueue(GetQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueue.</param>
        /// 
        /// <returns>Returns a  GetQueueResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueue">REST API Reference for GetQueue Operation</seealso>
        public virtual GetQueueResponse EndGetQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<GetQueueResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetQueueEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueueEnvironment operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueueEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueEnvironment">REST API Reference for GetQueueEnvironment Operation</seealso>
        public virtual IAsyncResult BeginGetQueueEnvironment(GetQueueEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueueEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueueEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueueEnvironment.</param>
        /// 
        /// <returns>Returns a  GetQueueEnvironmentResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueEnvironment">REST API Reference for GetQueueEnvironment Operation</seealso>
        public virtual GetQueueEnvironmentResponse EndGetQueueEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetQueueEnvironmentResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetQueueFleetAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueueFleetAssociation operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueueFleetAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueFleetAssociation">REST API Reference for GetQueueFleetAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetQueueFleetAssociation(GetQueueFleetAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueueFleetAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueFleetAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueueFleetAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueueFleetAssociation.</param>
        /// 
        /// <returns>Returns a  GetQueueFleetAssociationResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueFleetAssociation">REST API Reference for GetQueueFleetAssociation Operation</seealso>
        public virtual GetQueueFleetAssociationResponse EndGetQueueFleetAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetQueueFleetAssociationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetQueueLimitAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueueLimitAssociation operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueueLimitAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueLimitAssociation">REST API Reference for GetQueueLimitAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetQueueLimitAssociation(GetQueueLimitAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueueLimitAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueLimitAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueueLimitAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueueLimitAssociation.</param>
        /// 
        /// <returns>Returns a  GetQueueLimitAssociationResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueLimitAssociation">REST API Reference for GetQueueLimitAssociation Operation</seealso>
        public virtual GetQueueLimitAssociationResponse EndGetQueueLimitAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetQueueLimitAssociationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSession operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual IAsyncResult BeginGetSession(GetSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSession.</param>
        /// 
        /// <returns>Returns a  GetSessionResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual GetSessionResponse EndGetSession(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSessionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetSessionAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSessionAction operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSessionAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSessionAction">REST API Reference for GetSessionAction Operation</seealso>
        public virtual IAsyncResult BeginGetSessionAction(GetSessionActionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSessionAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSessionAction.</param>
        /// 
        /// <returns>Returns a  GetSessionActionResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSessionAction">REST API Reference for GetSessionAction Operation</seealso>
        public virtual GetSessionActionResponse EndGetSessionAction(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSessionActionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetSessionsStatisticsAggregation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSessionsStatisticsAggregation operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSessionsStatisticsAggregation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSessionsStatisticsAggregation">REST API Reference for GetSessionsStatisticsAggregation Operation</seealso>
        public virtual IAsyncResult BeginGetSessionsStatisticsAggregation(GetSessionsStatisticsAggregationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionsStatisticsAggregationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionsStatisticsAggregationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSessionsStatisticsAggregation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSessionsStatisticsAggregation.</param>
        /// 
        /// <returns>Returns a  GetSessionsStatisticsAggregationResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSessionsStatisticsAggregation">REST API Reference for GetSessionsStatisticsAggregation Operation</seealso>
        public virtual GetSessionsStatisticsAggregationResponse EndGetSessionsStatisticsAggregation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSessionsStatisticsAggregationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetStep operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStep operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStep
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStep">REST API Reference for GetStep Operation</seealso>
        public virtual IAsyncResult BeginGetStep(GetStepRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStepResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStep operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStep.</param>
        /// 
        /// <returns>Returns a  GetStepResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStep">REST API Reference for GetStep Operation</seealso>
        public virtual GetStepResponse EndGetStep(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStepResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetStorageProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStorageProfile operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStorageProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStorageProfile">REST API Reference for GetStorageProfile Operation</seealso>
        public virtual IAsyncResult BeginGetStorageProfile(GetStorageProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStorageProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStorageProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStorageProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStorageProfile.</param>
        /// 
        /// <returns>Returns a  GetStorageProfileResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStorageProfile">REST API Reference for GetStorageProfile Operation</seealso>
        public virtual GetStorageProfileResponse EndGetStorageProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStorageProfileResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetStorageProfileForQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStorageProfileForQueue operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStorageProfileForQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStorageProfileForQueue">REST API Reference for GetStorageProfileForQueue Operation</seealso>
        public virtual IAsyncResult BeginGetStorageProfileForQueue(GetStorageProfileForQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStorageProfileForQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStorageProfileForQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStorageProfileForQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStorageProfileForQueue.</param>
        /// 
        /// <returns>Returns a  GetStorageProfileForQueueResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStorageProfileForQueue">REST API Reference for GetStorageProfileForQueue Operation</seealso>
        public virtual GetStorageProfileForQueueResponse EndGetStorageProfileForQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStorageProfileForQueueResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTask operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetTask">REST API Reference for GetTask Operation</seealso>
        public virtual IAsyncResult BeginGetTask(GetTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTask.</param>
        /// 
        /// <returns>Returns a  GetTaskResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetTask">REST API Reference for GetTask Operation</seealso>
        public virtual GetTaskResponse EndGetTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTaskResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorker operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetWorker">REST API Reference for GetWorker Operation</seealso>
        public virtual IAsyncResult BeginGetWorker(GetWorkerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorker.</param>
        /// 
        /// <returns>Returns a  GetWorkerResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetWorker">REST API Reference for GetWorker Operation</seealso>
        public virtual GetWorkerResponse EndGetWorker(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWorkerResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListAvailableMeteredProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableMeteredProducts operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAvailableMeteredProducts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListAvailableMeteredProducts">REST API Reference for ListAvailableMeteredProducts Operation</seealso>
        public virtual IAsyncResult BeginListAvailableMeteredProducts(ListAvailableMeteredProductsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAvailableMeteredProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableMeteredProductsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAvailableMeteredProducts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableMeteredProducts.</param>
        /// 
        /// <returns>Returns a  ListAvailableMeteredProductsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListAvailableMeteredProducts">REST API Reference for ListAvailableMeteredProducts Operation</seealso>
        public virtual ListAvailableMeteredProductsResponse EndListAvailableMeteredProducts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAvailableMeteredProductsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListBudgets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBudgets operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBudgets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListBudgets">REST API Reference for ListBudgets Operation</seealso>
        public virtual IAsyncResult BeginListBudgets(ListBudgetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBudgetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBudgetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListBudgets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBudgets.</param>
        /// 
        /// <returns>Returns a  ListBudgetsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListBudgets">REST API Reference for ListBudgets Operation</seealso>
        public virtual ListBudgetsResponse EndListBudgets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListBudgetsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListFarmMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFarmMembers operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFarmMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFarmMembers">REST API Reference for ListFarmMembers Operation</seealso>
        public virtual IAsyncResult BeginListFarmMembers(ListFarmMembersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFarmMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFarmMembersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFarmMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFarmMembers.</param>
        /// 
        /// <returns>Returns a  ListFarmMembersResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFarmMembers">REST API Reference for ListFarmMembers Operation</seealso>
        public virtual ListFarmMembersResponse EndListFarmMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFarmMembersResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListFarms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFarms operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFarms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFarms">REST API Reference for ListFarms Operation</seealso>
        public virtual IAsyncResult BeginListFarms(ListFarmsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFarmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFarmsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFarms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFarms.</param>
        /// 
        /// <returns>Returns a  ListFarmsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFarms">REST API Reference for ListFarms Operation</seealso>
        public virtual ListFarmsResponse EndListFarms(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFarmsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListFleetMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleetMembers operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFleetMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFleetMembers">REST API Reference for ListFleetMembers Operation</seealso>
        public virtual IAsyncResult BeginListFleetMembers(ListFleetMembersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFleetMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetMembersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFleetMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFleetMembers.</param>
        /// 
        /// <returns>Returns a  ListFleetMembersResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFleetMembers">REST API Reference for ListFleetMembers Operation</seealso>
        public virtual ListFleetMembersResponse EndListFleetMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFleetMembersResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleets operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFleets">REST API Reference for ListFleets Operation</seealso>
        public virtual IAsyncResult BeginListFleets(ListFleetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFleets.</param>
        /// 
        /// <returns>Returns a  ListFleetsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFleets">REST API Reference for ListFleets Operation</seealso>
        public virtual ListFleetsResponse EndListFleets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFleetsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListJobMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobMembers operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobMembers">REST API Reference for ListJobMembers Operation</seealso>
        public virtual IAsyncResult BeginListJobMembers(ListJobMembersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobMembersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobMembers.</param>
        /// 
        /// <returns>Returns a  ListJobMembersResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobMembers">REST API Reference for ListJobMembers Operation</seealso>
        public virtual ListJobMembersResponse EndListJobMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJobMembersResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListJobParameterDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobParameterDefinitions operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobParameterDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobParameterDefinitions">REST API Reference for ListJobParameterDefinitions Operation</seealso>
        public virtual IAsyncResult BeginListJobParameterDefinitions(ListJobParameterDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobParameterDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobParameterDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobParameterDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobParameterDefinitions.</param>
        /// 
        /// <returns>Returns a  ListJobParameterDefinitionsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobParameterDefinitions">REST API Reference for ListJobParameterDefinitions Operation</seealso>
        public virtual ListJobParameterDefinitionsResponse EndListJobParameterDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJobParameterDefinitionsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual IAsyncResult BeginListJobs(ListJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a  ListJobsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual ListJobsResponse EndListJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJobsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListLicenseEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseEndpoints operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLicenseEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListLicenseEndpoints">REST API Reference for ListLicenseEndpoints Operation</seealso>
        public virtual IAsyncResult BeginListLicenseEndpoints(ListLicenseEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLicenseEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLicenseEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLicenseEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLicenseEndpoints.</param>
        /// 
        /// <returns>Returns a  ListLicenseEndpointsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListLicenseEndpoints">REST API Reference for ListLicenseEndpoints Operation</seealso>
        public virtual ListLicenseEndpointsResponse EndListLicenseEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLicenseEndpointsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLimits operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListLimits">REST API Reference for ListLimits Operation</seealso>
        public virtual IAsyncResult BeginListLimits(ListLimitsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLimitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLimits.</param>
        /// 
        /// <returns>Returns a  ListLimitsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListLimits">REST API Reference for ListLimits Operation</seealso>
        public virtual ListLimitsResponse EndListLimits(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLimitsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListMeteredProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMeteredProducts operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMeteredProducts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListMeteredProducts">REST API Reference for ListMeteredProducts Operation</seealso>
        public virtual IAsyncResult BeginListMeteredProducts(ListMeteredProductsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMeteredProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMeteredProductsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMeteredProducts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMeteredProducts.</param>
        /// 
        /// <returns>Returns a  ListMeteredProductsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListMeteredProducts">REST API Reference for ListMeteredProducts Operation</seealso>
        public virtual ListMeteredProductsResponse EndListMeteredProducts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMeteredProductsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListMonitors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMonitors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        public virtual IAsyncResult BeginListMonitors(ListMonitorsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMonitorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMonitorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMonitors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMonitors.</param>
        /// 
        /// <returns>Returns a  ListMonitorsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        public virtual ListMonitorsResponse EndListMonitors(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMonitorsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListQueueEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueueEnvironments operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQueueEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueEnvironments">REST API Reference for ListQueueEnvironments Operation</seealso>
        public virtual IAsyncResult BeginListQueueEnvironments(ListQueueEnvironmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueueEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueueEnvironmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListQueueEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQueueEnvironments.</param>
        /// 
        /// <returns>Returns a  ListQueueEnvironmentsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueEnvironments">REST API Reference for ListQueueEnvironments Operation</seealso>
        public virtual ListQueueEnvironmentsResponse EndListQueueEnvironments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListQueueEnvironmentsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListQueueFleetAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueueFleetAssociations operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQueueFleetAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueFleetAssociations">REST API Reference for ListQueueFleetAssociations Operation</seealso>
        public virtual IAsyncResult BeginListQueueFleetAssociations(ListQueueFleetAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueueFleetAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueueFleetAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListQueueFleetAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQueueFleetAssociations.</param>
        /// 
        /// <returns>Returns a  ListQueueFleetAssociationsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueFleetAssociations">REST API Reference for ListQueueFleetAssociations Operation</seealso>
        public virtual ListQueueFleetAssociationsResponse EndListQueueFleetAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListQueueFleetAssociationsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListQueueLimitAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueueLimitAssociations operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQueueLimitAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueLimitAssociations">REST API Reference for ListQueueLimitAssociations Operation</seealso>
        public virtual IAsyncResult BeginListQueueLimitAssociations(ListQueueLimitAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueueLimitAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueueLimitAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListQueueLimitAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQueueLimitAssociations.</param>
        /// 
        /// <returns>Returns a  ListQueueLimitAssociationsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueLimitAssociations">REST API Reference for ListQueueLimitAssociations Operation</seealso>
        public virtual ListQueueLimitAssociationsResponse EndListQueueLimitAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListQueueLimitAssociationsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListQueueMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueueMembers operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQueueMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueMembers">REST API Reference for ListQueueMembers Operation</seealso>
        public virtual IAsyncResult BeginListQueueMembers(ListQueueMembersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueueMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueueMembersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListQueueMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQueueMembers.</param>
        /// 
        /// <returns>Returns a  ListQueueMembersResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueMembers">REST API Reference for ListQueueMembers Operation</seealso>
        public virtual ListQueueMembersResponse EndListQueueMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListQueueMembersResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueues operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQueues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueues">REST API Reference for ListQueues Operation</seealso>
        public virtual IAsyncResult BeginListQueues(ListQueuesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueuesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListQueues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQueues.</param>
        /// 
        /// <returns>Returns a  ListQueuesResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueues">REST API Reference for ListQueues Operation</seealso>
        public virtual ListQueuesResponse EndListQueues(IAsyncResult asyncResult)
        {
            return EndInvoke<ListQueuesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListSessionActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSessionActions operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSessionActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessionActions">REST API Reference for ListSessionActions Operation</seealso>
        public virtual IAsyncResult BeginListSessionActions(ListSessionActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSessionActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSessionActions.</param>
        /// 
        /// <returns>Returns a  ListSessionActionsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessionActions">REST API Reference for ListSessionActions Operation</seealso>
        public virtual ListSessionActionsResponse EndListSessionActions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSessionActionsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSessions operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual IAsyncResult BeginListSessions(ListSessionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSessions.</param>
        /// 
        /// <returns>Returns a  ListSessionsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual ListSessionsResponse EndListSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSessionsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListSessionsForWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSessionsForWorker operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSessionsForWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessionsForWorker">REST API Reference for ListSessionsForWorker Operation</seealso>
        public virtual IAsyncResult BeginListSessionsForWorker(ListSessionsForWorkerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionsForWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsForWorkerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSessionsForWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSessionsForWorker.</param>
        /// 
        /// <returns>Returns a  ListSessionsForWorkerResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessionsForWorker">REST API Reference for ListSessionsForWorker Operation</seealso>
        public virtual ListSessionsForWorkerResponse EndListSessionsForWorker(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSessionsForWorkerResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListStepConsumers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStepConsumers operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStepConsumers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStepConsumers">REST API Reference for ListStepConsumers Operation</seealso>
        public virtual IAsyncResult BeginListStepConsumers(ListStepConsumersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStepConsumersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStepConsumersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStepConsumers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStepConsumers.</param>
        /// 
        /// <returns>Returns a  ListStepConsumersResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStepConsumers">REST API Reference for ListStepConsumers Operation</seealso>
        public virtual ListStepConsumersResponse EndListStepConsumers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStepConsumersResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListStepDependencies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStepDependencies operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStepDependencies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStepDependencies">REST API Reference for ListStepDependencies Operation</seealso>
        public virtual IAsyncResult BeginListStepDependencies(ListStepDependenciesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStepDependenciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStepDependenciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStepDependencies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStepDependencies.</param>
        /// 
        /// <returns>Returns a  ListStepDependenciesResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStepDependencies">REST API Reference for ListStepDependencies Operation</seealso>
        public virtual ListStepDependenciesResponse EndListStepDependencies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStepDependenciesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListSteps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSteps operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSteps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSteps">REST API Reference for ListSteps Operation</seealso>
        public virtual IAsyncResult BeginListSteps(ListStepsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStepsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSteps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSteps.</param>
        /// 
        /// <returns>Returns a  ListStepsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSteps">REST API Reference for ListSteps Operation</seealso>
        public virtual ListStepsResponse EndListSteps(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStepsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListStorageProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStorageProfiles operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStorageProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStorageProfiles">REST API Reference for ListStorageProfiles Operation</seealso>
        public virtual IAsyncResult BeginListStorageProfiles(ListStorageProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStorageProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStorageProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStorageProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStorageProfiles.</param>
        /// 
        /// <returns>Returns a  ListStorageProfilesResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStorageProfiles">REST API Reference for ListStorageProfiles Operation</seealso>
        public virtual ListStorageProfilesResponse EndListStorageProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStorageProfilesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListStorageProfilesForQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStorageProfilesForQueue operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStorageProfilesForQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStorageProfilesForQueue">REST API Reference for ListStorageProfilesForQueue Operation</seealso>
        public virtual IAsyncResult BeginListStorageProfilesForQueue(ListStorageProfilesForQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStorageProfilesForQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStorageProfilesForQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStorageProfilesForQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStorageProfilesForQueue.</param>
        /// 
        /// <returns>Returns a  ListStorageProfilesForQueueResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStorageProfilesForQueue">REST API Reference for ListStorageProfilesForQueue Operation</seealso>
        public virtual ListStorageProfilesForQueueResponse EndListStorageProfilesForQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStorageProfilesForQueueResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTasks operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListTasks">REST API Reference for ListTasks Operation</seealso>
        public virtual IAsyncResult BeginListTasks(ListTasksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTasksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTasks.</param>
        /// 
        /// <returns>Returns a  ListTasksResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListTasks">REST API Reference for ListTasks Operation</seealso>
        public virtual ListTasksResponse EndListTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTasksResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListWorkers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkers operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListWorkers">REST API Reference for ListWorkers Operation</seealso>
        public virtual IAsyncResult BeginListWorkers(ListWorkersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkers.</param>
        /// 
        /// <returns>Returns a  ListWorkersResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListWorkers">REST API Reference for ListWorkers Operation</seealso>
        public virtual ListWorkersResponse EndListWorkers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWorkersResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the PutMeteredProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMeteredProduct operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMeteredProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/PutMeteredProduct">REST API Reference for PutMeteredProduct Operation</seealso>
        public virtual IAsyncResult BeginPutMeteredProduct(PutMeteredProductRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMeteredProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMeteredProductResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutMeteredProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMeteredProduct.</param>
        /// 
        /// <returns>Returns a  PutMeteredProductResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/PutMeteredProduct">REST API Reference for PutMeteredProduct Operation</seealso>
        public virtual PutMeteredProductResponse EndPutMeteredProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<PutMeteredProductResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the SearchJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchJobs operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchJobs">REST API Reference for SearchJobs Operation</seealso>
        public virtual IAsyncResult BeginSearchJobs(SearchJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchJobs.</param>
        /// 
        /// <returns>Returns a  SearchJobsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchJobs">REST API Reference for SearchJobs Operation</seealso>
        public virtual SearchJobsResponse EndSearchJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchJobsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the SearchSteps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchSteps operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchSteps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchSteps">REST API Reference for SearchSteps Operation</seealso>
        public virtual IAsyncResult BeginSearchSteps(SearchStepsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchStepsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchSteps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchSteps.</param>
        /// 
        /// <returns>Returns a  SearchStepsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchSteps">REST API Reference for SearchSteps Operation</seealso>
        public virtual SearchStepsResponse EndSearchSteps(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchStepsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the SearchTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchTasks operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchTasks">REST API Reference for SearchTasks Operation</seealso>
        public virtual IAsyncResult BeginSearchTasks(SearchTasksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTasksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchTasks.</param>
        /// 
        /// <returns>Returns a  SearchTasksResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchTasks">REST API Reference for SearchTasks Operation</seealso>
        public virtual SearchTasksResponse EndSearchTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchTasksResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the SearchWorkers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchWorkers operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchWorkers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchWorkers">REST API Reference for SearchWorkers Operation</seealso>
        public virtual IAsyncResult BeginSearchWorkers(SearchWorkersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchWorkersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchWorkersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchWorkers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchWorkers.</param>
        /// 
        /// <returns>Returns a  SearchWorkersResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchWorkers">REST API Reference for SearchWorkers Operation</seealso>
        public virtual SearchWorkersResponse EndSearchWorkers(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchWorkersResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the StartSessionsStatisticsAggregation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSessionsStatisticsAggregation operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSessionsStatisticsAggregation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/StartSessionsStatisticsAggregation">REST API Reference for StartSessionsStatisticsAggregation Operation</seealso>
        public virtual IAsyncResult BeginStartSessionsStatisticsAggregation(StartSessionsStatisticsAggregationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSessionsStatisticsAggregationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSessionsStatisticsAggregationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartSessionsStatisticsAggregation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSessionsStatisticsAggregation.</param>
        /// 
        /// <returns>Returns a  StartSessionsStatisticsAggregationResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/StartSessionsStatisticsAggregation">REST API Reference for StartSessionsStatisticsAggregation Operation</seealso>
        public virtual StartSessionsStatisticsAggregationResponse EndStartSessionsStatisticsAggregation(IAsyncResult asyncResult)
        {
            return EndInvoke<StartSessionsStatisticsAggregationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudget operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBudget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateBudget">REST API Reference for UpdateBudget Operation</seealso>
        public virtual IAsyncResult BeginUpdateBudget(UpdateBudgetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBudgetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBudgetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBudget.</param>
        /// 
        /// <returns>Returns a  UpdateBudgetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateBudget">REST API Reference for UpdateBudget Operation</seealso>
        public virtual UpdateBudgetResponse EndUpdateBudget(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBudgetResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateFarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFarm operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateFarm">REST API Reference for UpdateFarm Operation</seealso>
        public virtual IAsyncResult BeginUpdateFarm(UpdateFarmRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFarmResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFarm.</param>
        /// 
        /// <returns>Returns a  UpdateFarmResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateFarm">REST API Reference for UpdateFarm Operation</seealso>
        public virtual UpdateFarmResponse EndUpdateFarm(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFarmResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        public virtual IAsyncResult BeginUpdateFleet(UpdateFleetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFleet.</param>
        /// 
        /// <returns>Returns a  UpdateFleetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        public virtual UpdateFleetResponse EndUpdateFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFleetResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        public virtual IAsyncResult BeginUpdateJob(UpdateJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJob.</param>
        /// 
        /// <returns>Returns a  UpdateJobResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        public virtual UpdateJobResponse EndUpdateJob(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateJobResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateLimit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLimit operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLimit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateLimit">REST API Reference for UpdateLimit Operation</seealso>
        public virtual IAsyncResult BeginUpdateLimit(UpdateLimitRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLimitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLimit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLimit.</param>
        /// 
        /// <returns>Returns a  UpdateLimitResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateLimit">REST API Reference for UpdateLimit Operation</seealso>
        public virtual UpdateLimitResponse EndUpdateLimit(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLimitResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitor operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateMonitor">REST API Reference for UpdateMonitor Operation</seealso>
        public virtual IAsyncResult BeginUpdateMonitor(UpdateMonitorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMonitorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMonitor.</param>
        /// 
        /// <returns>Returns a  UpdateMonitorResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateMonitor">REST API Reference for UpdateMonitor Operation</seealso>
        public virtual UpdateMonitorResponse EndUpdateMonitor(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMonitorResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueue operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueue">REST API Reference for UpdateQueue Operation</seealso>
        public virtual IAsyncResult BeginUpdateQueue(UpdateQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQueue.</param>
        /// 
        /// <returns>Returns a  UpdateQueueResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueue">REST API Reference for UpdateQueue Operation</seealso>
        public virtual UpdateQueueResponse EndUpdateQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQueueResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateQueueEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueEnvironment operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQueueEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueEnvironment">REST API Reference for UpdateQueueEnvironment Operation</seealso>
        public virtual IAsyncResult BeginUpdateQueueEnvironment(UpdateQueueEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQueueEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQueueEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQueueEnvironment.</param>
        /// 
        /// <returns>Returns a  UpdateQueueEnvironmentResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueEnvironment">REST API Reference for UpdateQueueEnvironment Operation</seealso>
        public virtual UpdateQueueEnvironmentResponse EndUpdateQueueEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQueueEnvironmentResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateQueueFleetAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueFleetAssociation operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQueueFleetAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueFleetAssociation">REST API Reference for UpdateQueueFleetAssociation Operation</seealso>
        public virtual IAsyncResult BeginUpdateQueueFleetAssociation(UpdateQueueFleetAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQueueFleetAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueFleetAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQueueFleetAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQueueFleetAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateQueueFleetAssociationResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueFleetAssociation">REST API Reference for UpdateQueueFleetAssociation Operation</seealso>
        public virtual UpdateQueueFleetAssociationResponse EndUpdateQueueFleetAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQueueFleetAssociationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateQueueLimitAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueLimitAssociation operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQueueLimitAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueLimitAssociation">REST API Reference for UpdateQueueLimitAssociation Operation</seealso>
        public virtual IAsyncResult BeginUpdateQueueLimitAssociation(UpdateQueueLimitAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateQueueLimitAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueueLimitAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQueueLimitAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQueueLimitAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateQueueLimitAssociationResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueLimitAssociation">REST API Reference for UpdateQueueLimitAssociation Operation</seealso>
        public virtual UpdateQueueLimitAssociationResponse EndUpdateQueueLimitAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQueueLimitAssociationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSession operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateSession">REST API Reference for UpdateSession Operation</seealso>
        public virtual IAsyncResult BeginUpdateSession(UpdateSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSession.</param>
        /// 
        /// <returns>Returns a  UpdateSessionResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateSession">REST API Reference for UpdateSession Operation</seealso>
        public virtual UpdateSessionResponse EndUpdateSession(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSessionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateStep operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStep operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStep
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateStep">REST API Reference for UpdateStep Operation</seealso>
        public virtual IAsyncResult BeginUpdateStep(UpdateStepRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStepResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStep operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStep.</param>
        /// 
        /// <returns>Returns a  UpdateStepResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateStep">REST API Reference for UpdateStep Operation</seealso>
        public virtual UpdateStepResponse EndUpdateStep(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStepResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateStorageProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStorageProfile operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStorageProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateStorageProfile">REST API Reference for UpdateStorageProfile Operation</seealso>
        public virtual IAsyncResult BeginUpdateStorageProfile(UpdateStorageProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStorageProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStorageProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStorageProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStorageProfile.</param>
        /// 
        /// <returns>Returns a  UpdateStorageProfileResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateStorageProfile">REST API Reference for UpdateStorageProfile Operation</seealso>
        public virtual UpdateStorageProfileResponse EndUpdateStorageProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStorageProfileResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTask operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        public virtual IAsyncResult BeginUpdateTask(UpdateTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTask.</param>
        /// 
        /// <returns>Returns a  UpdateTaskResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        public virtual UpdateTaskResponse EndUpdateTask(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTaskResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorker operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateWorker">REST API Reference for UpdateWorker Operation</seealso>
        public virtual IAsyncResult BeginUpdateWorker(UpdateWorkerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorker.</param>
        /// 
        /// <returns>Returns a  UpdateWorkerResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateWorker">REST API Reference for UpdateWorker Operation</seealso>
        public virtual UpdateWorkerResponse EndUpdateWorker(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWorkerResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateWorkerSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkerSchedule operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkerSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateWorkerSchedule">REST API Reference for UpdateWorkerSchedule Operation</seealso>
        public virtual IAsyncResult BeginUpdateWorkerSchedule(UpdateWorkerScheduleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkerScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkerScheduleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkerSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkerSchedule.</param>
        /// 
        /// <returns>Returns a  UpdateWorkerScheduleResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateWorkerSchedule">REST API Reference for UpdateWorkerSchedule Operation</seealso>
        public virtual UpdateWorkerScheduleResponse EndUpdateWorkerSchedule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWorkerScheduleResponse>(asyncResult);
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
            var resolver = new AmazonDeadlineEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}