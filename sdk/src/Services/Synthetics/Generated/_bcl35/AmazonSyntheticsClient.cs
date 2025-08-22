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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Synthetics.Model;
using Amazon.Synthetics.Model.Internal.MarshallTransformations;
using Amazon.Synthetics.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Synthetics
{
    /// <summary>
    /// <para>Implementation for accessing Synthetics</para>
    ///
    /// Amazon CloudWatch Synthetics 
    /// <para>
    /// You can use Amazon CloudWatch Synthetics to continually monitor your services. You
    /// can create and manage <i>canaries</i>, which are modular, lightweight scripts that
    /// monitor your endpoints and APIs from the outside-in. You can set up your canaries
    /// to run 24 hours a day, once per minute. The canaries help you check the availability
    /// and latency of your web services and troubleshoot anomalies by investigating load
    /// time data, screenshots of the UI, logs, and metrics. The canaries seamlessly integrate
    /// with CloudWatch ServiceLens to help you trace the causes of impacted nodes in your
    /// applications. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/ServiceLens.html">Using
    /// ServiceLens to Monitor the Health of Your Applications</a> in the <i>Amazon CloudWatch
    /// User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Before you create and manage canaries, be aware of the security considerations. For
    /// more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/servicelens_canaries_security.html">Security
    /// Considerations for Synthetics Canaries</a>.
    /// </para>
    /// </summary>
    public partial class AmazonSyntheticsClient : AmazonServiceClient, IAmazonSynthetics
    {
        private static IServiceMetadata serviceMetadata = new AmazonSyntheticsMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ISyntheticsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISyntheticsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SyntheticsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonSyntheticsClient with the credentials loaded from the application's
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
        public AmazonSyntheticsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSyntheticsConfig()) { }

        /// <summary>
        /// Constructs AmazonSyntheticsClient with the credentials loaded from the application's
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
        public AmazonSyntheticsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSyntheticsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSyntheticsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSyntheticsClient Configuration Object</param>
        public AmazonSyntheticsClient(AmazonSyntheticsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonSyntheticsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSyntheticsClient(AWSCredentials credentials)
            : this(credentials, new AmazonSyntheticsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSyntheticsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSyntheticsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSyntheticsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSyntheticsClient with AWS Credentials and an
        /// AmazonSyntheticsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSyntheticsClient Configuration Object</param>
        public AmazonSyntheticsClient(AWSCredentials credentials, AmazonSyntheticsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSyntheticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSyntheticsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSyntheticsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSyntheticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSyntheticsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSyntheticsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSyntheticsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSyntheticsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSyntheticsClient Configuration Object</param>
        public AmazonSyntheticsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSyntheticsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSyntheticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSyntheticsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSyntheticsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSyntheticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSyntheticsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSyntheticsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSyntheticsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSyntheticsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSyntheticsClient Configuration Object</param>
        public AmazonSyntheticsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSyntheticsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSyntheticsEndpointResolver());
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


        #region  AssociateResource

        /// <summary>
        /// Associates a canary with a group. Using groups can help you with managing and automating
        /// your canaries, and you can also view aggregated run results and statistics for all
        /// canaries in a group. 
        /// 
        ///  
        /// <para>
        /// You must run this operation in the Region where the canary exists.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResource service method.</param>
        /// 
        /// <returns>The response from the AssociateResource service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota value.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/AssociateResource">REST API Reference for AssociateResource Operation</seealso>
        public virtual AssociateResourceResponse AssociateResource(AssociateResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourceResponseUnmarshaller.Instance;

            return Invoke<AssociateResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateResource operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/AssociateResource">REST API Reference for AssociateResource Operation</seealso>
        public virtual IAsyncResult BeginAssociateResource(AssociateResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateResource.</param>
        /// 
        /// <returns>Returns a  AssociateResourceResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/AssociateResource">REST API Reference for AssociateResource Operation</seealso>
        public virtual AssociateResourceResponse EndAssociateResource(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCanary

        /// <summary>
        /// Creates a canary. Canaries are scripts that monitor your endpoints and APIs from the
        /// outside-in. Canaries help you check the availability and latency of your web services
        /// and troubleshoot anomalies by investigating load time data, screenshots of the UI,
        /// logs, and metrics. You can set up a canary to run continuously or just once. 
        /// 
        ///  
        /// <para>
        /// Do not use <c>CreateCanary</c> to modify an existing canary. Use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_UpdateCanary.html">UpdateCanary</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// To create canaries, you must have the <c>CloudWatchSyntheticsFullAccess</c> policy.
        /// If you are creating a new IAM role for the canary, you also need the <c>iam:CreateRole</c>,
        /// <c>iam:CreatePolicy</c> and <c>iam:AttachRolePolicy</c> permissions. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Roles">Necessary
        /// Roles and Permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// Do not include secrets or proprietary information in your canary names. The canary
        /// name makes up part of the Amazon Resource Name (ARN) for the canary, and the ARN is
        /// included in outbound calls over the internet. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/servicelens_canaries_security.html">Security
        /// Considerations for Synthetics Canaries</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCanary service method.</param>
        /// 
        /// <returns>The response from the CreateCanary service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.RequestEntityTooLargeException">
        /// One of the input resources is larger than is allowed.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/CreateCanary">REST API Reference for CreateCanary Operation</seealso>
        public virtual CreateCanaryResponse CreateCanary(CreateCanaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCanaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCanaryResponseUnmarshaller.Instance;

            return Invoke<CreateCanaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCanary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCanary operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCanary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/CreateCanary">REST API Reference for CreateCanary Operation</seealso>
        public virtual IAsyncResult BeginCreateCanary(CreateCanaryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCanaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCanaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCanary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCanary.</param>
        /// 
        /// <returns>Returns a  CreateCanaryResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/CreateCanary">REST API Reference for CreateCanary Operation</seealso>
        public virtual CreateCanaryResponse EndCreateCanary(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCanaryResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGroup

        /// <summary>
        /// Creates a group which you can use to associate canaries with each other, including
        /// cross-Region canaries. Using groups can help you with managing and automating your
        /// canaries, and you can also view aggregated run results and statistics for all canaries
        /// in a group. 
        /// 
        ///  
        /// <para>
        /// Groups are global resources. When you create a group, it is replicated across Amazon
        /// Web Services Regions, and you can view it and add canaries to it from any Region.
        /// Although the group ARN format reflects the Region name where it was created, a group
        /// is not constrained to any Region. This means that you can put canaries from multiple
        /// Regions into the same group, and then use that group to view and manage all of those
        /// canaries in a single view.
        /// </para>
        ///  
        /// <para>
        /// Groups are supported in all Regions except the Regions that are disabled by default.
        /// For more information about these Regions, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande-manage.html#rande-manage-enable">Enabling
        /// a Region</a>.
        /// </para>
        ///  
        /// <para>
        /// Each group can contain as many as 10 canaries. You can have as many as 20 groups in
        /// your account. Any single canary can be a member of up to 10 groups.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ServiceQuotaExceededException">
        /// The request exceeded a service quota value.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCanary

        /// <summary>
        /// Permanently deletes the specified canary.
        /// 
        ///  
        /// <para>
        /// If the canary's <c>ProvisionedResourceCleanup</c> field is set to <c>AUTOMATIC</c>
        /// or you specify <c>DeleteLambda</c> in this operation as <c>true</c>, CloudWatch Synthetics
        /// also deletes the Lambda functions and layers that are used by the canary.
        /// </para>
        ///  
        /// <para>
        /// Other resources used and created by the canary are not automatically deleted. After
        /// you delete a canary, you should also delete the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The CloudWatch alarms created for this canary. These alarms have a name of <c>Synthetics-Alarm-<i>first-198-characters-of-canary-name</i>-<i>canaryId</i>-<i>alarm
        /// number</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon S3 objects and buckets, such as the canary's artifact location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IAM roles created for the canary. If they were created in the console, these roles
        /// have the name <c> role/service-role/CloudWatchSyntheticsRole-<i>First-21-Characters-of-CanaryName</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CloudWatch Logs log groups created for the canary. These logs groups have the name
        /// <c>/aws/lambda/cwsyn-<i>First-21-Characters-of-CanaryName</i> </c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Before you delete a canary, you might want to use <c>GetCanary</c> to display the
        /// information about this canary. Make note of the information returned by this operation
        /// so that you can delete these resources after you delete the canary.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCanary service method.</param>
        /// 
        /// <returns>The response from the DeleteCanary service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DeleteCanary">REST API Reference for DeleteCanary Operation</seealso>
        public virtual DeleteCanaryResponse DeleteCanary(DeleteCanaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCanaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCanaryResponseUnmarshaller.Instance;

            return Invoke<DeleteCanaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCanary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCanary operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCanary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DeleteCanary">REST API Reference for DeleteCanary Operation</seealso>
        public virtual IAsyncResult BeginDeleteCanary(DeleteCanaryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCanaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCanaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCanary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCanary.</param>
        /// 
        /// <returns>Returns a  DeleteCanaryResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DeleteCanary">REST API Reference for DeleteCanary Operation</seealso>
        public virtual DeleteCanaryResponse EndDeleteCanary(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCanaryResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGroup

        /// <summary>
        /// Deletes a group. The group doesn't need to be empty to be deleted. If there are canaries
        /// in the group, they are not deleted when you delete the group. 
        /// 
        ///  
        /// <para>
        /// Groups are a global resource that appear in all Regions, but the request to delete
        /// a group must be made from its home Region. You can find the home Region of a group
        /// within its ARN.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCanaries

        /// <summary>
        /// This operation returns a list of the canaries in your account, along with full details
        /// about each canary.
        /// 
        ///  
        /// <para>
        /// This operation supports resource-level authorization using an IAM policy and the <c>Names</c>
        /// parameter. If you specify the <c>Names</c> parameter, the operation is successful
        /// only if you have authorization to view all the canaries that you specify in your request.
        /// If you do not have permission to view any of the canaries, the request fails with
        /// a 403 response.
        /// </para>
        ///  
        /// <para>
        /// You are required to use the <c>Names</c> parameter if you are logged on to a user
        /// or role that has an IAM policy that restricts which canaries that you are allowed
        /// to view. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Restricted.html">
        /// Limiting a user to viewing specific canaries</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCanaries service method.</param>
        /// 
        /// <returns>The response from the DescribeCanaries service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DescribeCanaries">REST API Reference for DescribeCanaries Operation</seealso>
        public virtual DescribeCanariesResponse DescribeCanaries(DescribeCanariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCanariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCanariesResponseUnmarshaller.Instance;

            return Invoke<DescribeCanariesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCanaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCanaries operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCanaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DescribeCanaries">REST API Reference for DescribeCanaries Operation</seealso>
        public virtual IAsyncResult BeginDescribeCanaries(DescribeCanariesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCanariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCanariesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCanaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCanaries.</param>
        /// 
        /// <returns>Returns a  DescribeCanariesResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DescribeCanaries">REST API Reference for DescribeCanaries Operation</seealso>
        public virtual DescribeCanariesResponse EndDescribeCanaries(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCanariesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCanariesLastRun

        /// <summary>
        /// Use this operation to see information from the most recent run of each canary that
        /// you have created.
        /// 
        ///  
        /// <para>
        /// This operation supports resource-level authorization using an IAM policy and the <c>Names</c>
        /// parameter. If you specify the <c>Names</c> parameter, the operation is successful
        /// only if you have authorization to view all the canaries that you specify in your request.
        /// If you do not have permission to view any of the canaries, the request fails with
        /// a 403 response.
        /// </para>
        ///  
        /// <para>
        /// You are required to use the <c>Names</c> parameter if you are logged on to a user
        /// or role that has an IAM policy that restricts which canaries that you are allowed
        /// to view. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Restricted.html">
        /// Limiting a user to viewing specific canaries</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCanariesLastRun service method.</param>
        /// 
        /// <returns>The response from the DescribeCanariesLastRun service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DescribeCanariesLastRun">REST API Reference for DescribeCanariesLastRun Operation</seealso>
        public virtual DescribeCanariesLastRunResponse DescribeCanariesLastRun(DescribeCanariesLastRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCanariesLastRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCanariesLastRunResponseUnmarshaller.Instance;

            return Invoke<DescribeCanariesLastRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCanariesLastRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCanariesLastRun operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCanariesLastRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DescribeCanariesLastRun">REST API Reference for DescribeCanariesLastRun Operation</seealso>
        public virtual IAsyncResult BeginDescribeCanariesLastRun(DescribeCanariesLastRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCanariesLastRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCanariesLastRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCanariesLastRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCanariesLastRun.</param>
        /// 
        /// <returns>Returns a  DescribeCanariesLastRunResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DescribeCanariesLastRun">REST API Reference for DescribeCanariesLastRun Operation</seealso>
        public virtual DescribeCanariesLastRunResponse EndDescribeCanariesLastRun(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCanariesLastRunResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRuntimeVersions

        /// <summary>
        /// Returns a list of Synthetics canary runtime versions. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Library.html">
        /// Canary Runtime Versions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuntimeVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeRuntimeVersions service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DescribeRuntimeVersions">REST API Reference for DescribeRuntimeVersions Operation</seealso>
        public virtual DescribeRuntimeVersionsResponse DescribeRuntimeVersions(DescribeRuntimeVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRuntimeVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuntimeVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeRuntimeVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRuntimeVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuntimeVersions operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRuntimeVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DescribeRuntimeVersions">REST API Reference for DescribeRuntimeVersions Operation</seealso>
        public virtual IAsyncResult BeginDescribeRuntimeVersions(DescribeRuntimeVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRuntimeVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuntimeVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRuntimeVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRuntimeVersions.</param>
        /// 
        /// <returns>Returns a  DescribeRuntimeVersionsResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DescribeRuntimeVersions">REST API Reference for DescribeRuntimeVersions Operation</seealso>
        public virtual DescribeRuntimeVersionsResponse EndDescribeRuntimeVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRuntimeVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateResource

        /// <summary>
        /// Removes a canary from a group. You must run this operation in the Region where the
        /// canary exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResource service method.</param>
        /// 
        /// <returns>The response from the DisassociateResource service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DisassociateResource">REST API Reference for DisassociateResource Operation</seealso>
        public virtual DisassociateResourceResponse DisassociateResource(DisassociateResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceResponseUnmarshaller.Instance;

            return Invoke<DisassociateResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResource operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DisassociateResource">REST API Reference for DisassociateResource Operation</seealso>
        public virtual IAsyncResult BeginDisassociateResource(DisassociateResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateResource.</param>
        /// 
        /// <returns>Returns a  DisassociateResourceResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/DisassociateResource">REST API Reference for DisassociateResource Operation</seealso>
        public virtual DisassociateResourceResponse EndDisassociateResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCanary

        /// <summary>
        /// Retrieves complete information about one canary. You must specify the name of the
        /// canary that you want. To get a list of canaries and their names, use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_DescribeCanaries.html">DescribeCanaries</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCanary service method.</param>
        /// 
        /// <returns>The response from the GetCanary service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/GetCanary">REST API Reference for GetCanary Operation</seealso>
        public virtual GetCanaryResponse GetCanary(GetCanaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCanaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCanaryResponseUnmarshaller.Instance;

            return Invoke<GetCanaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCanary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCanary operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCanary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/GetCanary">REST API Reference for GetCanary Operation</seealso>
        public virtual IAsyncResult BeginGetCanary(GetCanaryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCanaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCanaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCanary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCanary.</param>
        /// 
        /// <returns>Returns a  GetCanaryResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/GetCanary">REST API Reference for GetCanary Operation</seealso>
        public virtual GetCanaryResponse EndGetCanary(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCanaryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCanaryRuns

        /// <summary>
        /// Retrieves a list of runs for a specified canary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCanaryRuns service method.</param>
        /// 
        /// <returns>The response from the GetCanaryRuns service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/GetCanaryRuns">REST API Reference for GetCanaryRuns Operation</seealso>
        public virtual GetCanaryRunsResponse GetCanaryRuns(GetCanaryRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCanaryRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCanaryRunsResponseUnmarshaller.Instance;

            return Invoke<GetCanaryRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCanaryRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCanaryRuns operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCanaryRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/GetCanaryRuns">REST API Reference for GetCanaryRuns Operation</seealso>
        public virtual IAsyncResult BeginGetCanaryRuns(GetCanaryRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCanaryRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCanaryRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCanaryRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCanaryRuns.</param>
        /// 
        /// <returns>Returns a  GetCanaryRunsResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/GetCanaryRuns">REST API Reference for GetCanaryRuns Operation</seealso>
        public virtual GetCanaryRunsResponse EndGetCanaryRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCanaryRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGroup

        /// <summary>
        /// Returns information about one group. Groups are a global resource, so you can use
        /// this operation from any Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return Invoke<GetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual IAsyncResult BeginGetGroup(GetGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroup.</param>
        /// 
        /// <returns>Returns a  GetGroupResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual GetGroupResponse EndGetGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssociatedGroups

        /// <summary>
        /// Returns a list of the groups that the specified canary is associated with. The canary
        /// that you specify must be in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedGroups service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedGroups service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListAssociatedGroups">REST API Reference for ListAssociatedGroups Operation</seealso>
        public virtual ListAssociatedGroupsResponse ListAssociatedGroups(ListAssociatedGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociatedGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedGroupsResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociatedGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedGroups operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssociatedGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListAssociatedGroups">REST API Reference for ListAssociatedGroups Operation</seealso>
        public virtual IAsyncResult BeginListAssociatedGroups(ListAssociatedGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociatedGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssociatedGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssociatedGroups.</param>
        /// 
        /// <returns>Returns a  ListAssociatedGroupsResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListAssociatedGroups">REST API Reference for ListAssociatedGroups Operation</seealso>
        public virtual ListAssociatedGroupsResponse EndListAssociatedGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssociatedGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroupResources

        /// <summary>
        /// This operation returns a list of the ARNs of the canaries that are associated with
        /// the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupResources service method.</param>
        /// 
        /// <returns>The response from the ListGroupResources service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListGroupResources">REST API Reference for ListGroupResources Operation</seealso>
        public virtual ListGroupResourcesResponse ListGroupResources(ListGroupResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupResourcesResponseUnmarshaller.Instance;

            return Invoke<ListGroupResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupResources operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListGroupResources">REST API Reference for ListGroupResources Operation</seealso>
        public virtual IAsyncResult BeginListGroupResources(ListGroupResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupResources.</param>
        /// 
        /// <returns>Returns a  ListGroupResourcesResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListGroupResources">REST API Reference for ListGroupResources Operation</seealso>
        public virtual ListGroupResourcesResponse EndListGroupResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroups

        /// <summary>
        /// Returns a list of all groups in the account, displaying their names, unique IDs, and
        /// ARNs. The groups from all Regions are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual ListGroupsResponse EndListGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Displays the tags associated with a canary or group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.BadRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalFailureException">
        /// An internal failure occurred. Try the operation again.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.NotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.TooManyRequestsException">
        /// There were too many simultaneous requests. Try the operation again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  StartCanary

        /// <summary>
        /// Use this operation to run a canary that has already been created. The frequency of
        /// the canary runs is determined by the value of the canary's <c>Schedule</c>. To see
        /// a canary's schedule, use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_GetCanary.html">GetCanary</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCanary service method.</param>
        /// 
        /// <returns>The response from the StartCanary service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/StartCanary">REST API Reference for StartCanary Operation</seealso>
        public virtual StartCanaryResponse StartCanary(StartCanaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCanaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCanaryResponseUnmarshaller.Instance;

            return Invoke<StartCanaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartCanary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCanary operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCanary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/StartCanary">REST API Reference for StartCanary Operation</seealso>
        public virtual IAsyncResult BeginStartCanary(StartCanaryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCanaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCanaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartCanary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCanary.</param>
        /// 
        /// <returns>Returns a  StartCanaryResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/StartCanary">REST API Reference for StartCanary Operation</seealso>
        public virtual StartCanaryResponse EndStartCanary(IAsyncResult asyncResult)
        {
            return EndInvoke<StartCanaryResponse>(asyncResult);
        }

        #endregion
        
        #region  StartCanaryDryRun

        /// <summary>
        /// Use this operation to start a dry run for a canary that has already been created
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCanaryDryRun service method.</param>
        /// 
        /// <returns>The response from the StartCanaryDryRun service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.AccessDeniedException">
        /// You don't have permission to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/StartCanaryDryRun">REST API Reference for StartCanaryDryRun Operation</seealso>
        public virtual StartCanaryDryRunResponse StartCanaryDryRun(StartCanaryDryRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCanaryDryRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCanaryDryRunResponseUnmarshaller.Instance;

            return Invoke<StartCanaryDryRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartCanaryDryRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCanaryDryRun operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCanaryDryRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/StartCanaryDryRun">REST API Reference for StartCanaryDryRun Operation</seealso>
        public virtual IAsyncResult BeginStartCanaryDryRun(StartCanaryDryRunRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCanaryDryRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCanaryDryRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartCanaryDryRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCanaryDryRun.</param>
        /// 
        /// <returns>Returns a  StartCanaryDryRunResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/StartCanaryDryRun">REST API Reference for StartCanaryDryRun Operation</seealso>
        public virtual StartCanaryDryRunResponse EndStartCanaryDryRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StartCanaryDryRunResponse>(asyncResult);
        }

        #endregion
        
        #region  StopCanary

        /// <summary>
        /// Stops the canary to prevent all future runs. If the canary is currently running,the
        /// run that is in progress completes on its own, publishes metrics, and uploads artifacts,
        /// but it is not recorded in Synthetics as a completed run.
        /// 
        ///  
        /// <para>
        /// You can use <c>StartCanary</c> to start it running again with the canary’s current
        /// schedule at any point in the future. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCanary service method.</param>
        /// 
        /// <returns>The response from the StopCanary service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/StopCanary">REST API Reference for StopCanary Operation</seealso>
        public virtual StopCanaryResponse StopCanary(StopCanaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCanaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCanaryResponseUnmarshaller.Instance;

            return Invoke<StopCanaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopCanary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCanary operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopCanary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/StopCanary">REST API Reference for StopCanary Operation</seealso>
        public virtual IAsyncResult BeginStopCanary(StopCanaryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCanaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCanaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopCanary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopCanary.</param>
        /// 
        /// <returns>Returns a  StopCanaryResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/StopCanary">REST API Reference for StopCanary Operation</seealso>
        public virtual StopCanaryResponse EndStopCanary(IAsyncResult asyncResult)
        {
            return EndInvoke<StopCanaryResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified canary or group. 
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions, by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>TagResource</c> action with a resource that already has tags. If
        /// you specify a new tag key for the resource, this tag is appended to the list of tags
        /// associated with the resource. If you specify a tag key that is already associated
        /// with the resource, the new tag value that you specify replaces the previous value
        /// for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a canary or group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.BadRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalFailureException">
        /// An internal failure occurred. Try the operation again.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.NotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.TooManyRequestsException">
        /// There were too many simultaneous requests. Try the operation again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>The response from the UntagResource service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.BadRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalFailureException">
        /// An internal failure occurred. Try the operation again.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.NotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.TooManyRequestsException">
        /// There were too many simultaneous requests. Try the operation again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCanary

        /// <summary>
        /// Updates the configuration of a canary that has already been created.
        /// 
        ///  
        /// <para>
        /// For multibrowser canaries, you can add or remove browsers by updating the browserConfig
        /// list in the update call. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To add Firefox to a canary that currently uses Chrome, specify browserConfigs as [CHROME,
        /// FIREFOX]
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To remove Firefox and keep only Chrome, specify browserConfigs as [CHROME]
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can't use this operation to update the tags of an existing canary. To change the
        /// tags of an existing canary, use <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_TagResource.html">TagResource</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you use the <c>dryRunId</c> field when updating a canary, the only other field
        /// you can provide is the <c>Schedule</c>. Adding any other field will thrown an exception.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCanary service method.</param>
        /// 
        /// <returns>The response from the UpdateCanary service method, as returned by Synthetics.</returns>
        /// <exception cref="Amazon.Synthetics.Model.AccessDeniedException">
        /// You don't have permission to perform this operation on this resource.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ConflictException">
        /// A conflicting operation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.InternalServerException">
        /// An unknown internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.RequestEntityTooLargeException">
        /// One of the input resources is larger than is allowed.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ResourceNotFoundException">
        /// One of the specified resources was not found.
        /// </exception>
        /// <exception cref="Amazon.Synthetics.Model.ValidationException">
        /// A parameter could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/UpdateCanary">REST API Reference for UpdateCanary Operation</seealso>
        public virtual UpdateCanaryResponse UpdateCanary(UpdateCanaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCanaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCanaryResponseUnmarshaller.Instance;

            return Invoke<UpdateCanaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCanary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCanary operation on AmazonSyntheticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCanary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/UpdateCanary">REST API Reference for UpdateCanary Operation</seealso>
        public virtual IAsyncResult BeginUpdateCanary(UpdateCanaryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCanaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCanaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCanary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCanary.</param>
        /// 
        /// <returns>Returns a  UpdateCanaryResult from Synthetics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/synthetics-2017-10-11/UpdateCanary">REST API Reference for UpdateCanary Operation</seealso>
        public virtual UpdateCanaryResponse EndUpdateCanary(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCanaryResponse>(asyncResult);
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
            var resolver = new AmazonSyntheticsEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}