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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ControlTower.Model;
using Amazon.ControlTower.Model.Internal.MarshallTransformations;
using Amazon.ControlTower.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.ControlTower
{
    /// <summary>
    /// <para>Implementation for accessing ControlTower</para>
    ///
    /// These interfaces allow you to apply the Amazon Web Services library of pre-defined
    /// <i>controls</i> to your organizational units, programmatically. In Amazon Web Services
    /// Control Tower, the terms "control" and "guardrail" are synonyms.
    /// 
    ///  
    /// <para>
    /// To call these APIs, you'll need to know:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// the <c>controlIdentifier</c> for the control--or guardrail--you are targeting.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// the ARN associated with the target organizational unit (OU), which we call the <c>targetIdentifier</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// the ARN associated with a resource that you wish to tag or untag.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>To get the <c>controlIdentifier</c> for your Amazon Web Services Control Tower
    /// control:</b> 
    /// </para>
    ///  
    /// <para>
    /// The <c>controlIdentifier</c> is an ARN that is specified for each control. You can
    /// view the <c>controlIdentifier</c> in the console on the <b>Control details</b> page,
    /// as well as in the documentation.
    /// </para>
    ///  
    /// <para>
    /// The <c>controlIdentifier</c> is unique in each Amazon Web Services Region for each
    /// control. You can find the <c>controlIdentifier</c> for each Region and control in
    /// the <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-metadata-tables.html">Tables
    /// of control metadata</a> in the <i>Amazon Web Services Control Tower User Guide.</i>
    /// 
    /// </para>
    ///  
    /// <para>
    /// A quick-reference list of control identifers for the Amazon Web Services Control Tower
    /// legacy <i>Strongly recommended</i> and <i>Elective</i> controls is given in <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-identifiers.html.html">Resource
    /// identifiers for APIs and controls</a> in the <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-identifiers.html">Controls
    /// reference guide section</a> of the <i>Amazon Web Services Control Tower User Guide</i>.
    /// Remember that <i>Mandatory</i> controls cannot be added or removed.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>ARN format:</b> <c>arn:aws:controltower:{REGION}::control/{CONTROL_NAME}</c> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Example:</b> 
    /// </para>
    ///  
    /// <para>
    ///  <c>arn:aws:controltower:us-west-2::control/AWS-GR_AUTOSCALING_LAUNCH_CONFIG_PUBLIC_IP_DISABLED</c>
    /// 
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>To get the <c>targetIdentifier</c>:</b> 
    /// </para>
    ///  
    /// <para>
    /// The <c>targetIdentifier</c> is the ARN for an OU.
    /// </para>
    ///  
    /// <para>
    /// In the Amazon Web Services Organizations console, you can find the ARN for the OU
    /// on the <b>Organizational unit details</b> page associated with that OU.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>OU ARN format:</b> 
    /// </para>
    ///  
    /// <para>
    ///  <c>arn:${Partition}:organizations::${MasterAccountId}:ou/o-${OrganizationId}/ou-${OrganizationalUnitId}</c>
    /// 
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Details and examples</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">Control
    /// API input and output examples with CLI</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/enable-controls.html">Enable
    /// controls with CloudFormation</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-metadata-tables.html">Control
    /// metadata tables</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-identifiers.html">List
    /// of identifiers for legacy controls</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/controls.html">Controls
    /// reference guide</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/controls-reference.html">Controls
    /// library groupings</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/creating-resources-with-cloudformation.html">Creating
    /// Amazon Web Services Control Tower resources with Amazon Web Services CloudFormation</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To view the open source resource repository on GitHub, see <a href="https://github.com/aws-cloudformation/aws-cloudformation-resource-providers-controltower">aws-cloudformation/aws-cloudformation-resource-providers-controltower</a>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Recording API Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services Control Tower supports Amazon Web Services CloudTrail, a service
    /// that records Amazon Web Services API calls for your Amazon Web Services account and
    /// delivers log files to an Amazon S3 bucket. By using information collected by CloudTrail,
    /// you can determine which requests the Amazon Web Services Control Tower service received,
    /// who made the request and when, and so on. For more about Amazon Web Services Control
    /// Tower and its support for CloudTrail, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/logging-using-cloudtrail.html">Logging
    /// Amazon Web Services Control Tower Actions with Amazon Web Services CloudTrail</a>
    /// in the Amazon Web Services Control Tower User Guide. To learn more about CloudTrail,
    /// including how to turn it on and find your log files, see the Amazon Web Services CloudTrail
    /// User Guide.
    /// </para>
    /// </summary>
    public partial class AmazonControlTowerClient : AmazonServiceClient, IAmazonControlTower
    {
        private static IServiceMetadata serviceMetadata = new AmazonControlTowerMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonControlTowerClient with the credentials loaded from the application's
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
        public AmazonControlTowerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonControlTowerConfig()) { }

        /// <summary>
        /// Constructs AmazonControlTowerClient with the credentials loaded from the application's
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
        public AmazonControlTowerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonControlTowerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonControlTowerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonControlTowerClient Configuration Object</param>
        public AmazonControlTowerClient(AmazonControlTowerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonControlTowerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonControlTowerClient(AWSCredentials credentials)
            : this(credentials, new AmazonControlTowerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonControlTowerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonControlTowerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonControlTowerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonControlTowerClient with AWS Credentials and an
        /// AmazonControlTowerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonControlTowerClient Configuration Object</param>
        public AmazonControlTowerClient(AWSCredentials credentials, AmazonControlTowerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonControlTowerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonControlTowerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonControlTowerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonControlTowerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonControlTowerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonControlTowerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonControlTowerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonControlTowerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonControlTowerClient Configuration Object</param>
        public AmazonControlTowerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonControlTowerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonControlTowerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonControlTowerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonControlTowerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonControlTowerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonControlTowerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonControlTowerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonControlTowerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonControlTowerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonControlTowerClient Configuration Object</param>
        public AmazonControlTowerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonControlTowerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IControlTowerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IControlTowerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ControlTowerPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonControlTowerEndpointResolver());
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


        #region  CreateLandingZone

        internal virtual CreateLandingZoneResponse CreateLandingZone(CreateLandingZoneRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLandingZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLandingZoneResponseUnmarshaller.Instance;

            return Invoke<CreateLandingZoneResponse>(request, options);
        }



        /// <summary>
        /// Creates a new landing zone. This API call starts an asynchronous operation that creates
        /// and configures a landing zone, based on the parameters specified in the manifest JSON
        /// file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLandingZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLandingZone service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/CreateLandingZone">REST API Reference for CreateLandingZone Operation</seealso>
        public virtual Task<CreateLandingZoneResponse> CreateLandingZoneAsync(CreateLandingZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLandingZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLandingZoneResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLandingZoneResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLandingZone

        internal virtual DeleteLandingZoneResponse DeleteLandingZone(DeleteLandingZoneRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLandingZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLandingZoneResponseUnmarshaller.Instance;

            return Invoke<DeleteLandingZoneResponse>(request, options);
        }



        /// <summary>
        /// Decommissions a landing zone. This API call starts an asynchronous operation that
        /// deletes Amazon Web Services Control Tower resources deployed in accounts managed by
        /// Amazon Web Services Control Tower.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLandingZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLandingZone service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/DeleteLandingZone">REST API Reference for DeleteLandingZone Operation</seealso>
        public virtual Task<DeleteLandingZoneResponse> DeleteLandingZoneAsync(DeleteLandingZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLandingZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLandingZoneResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLandingZoneResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableBaseline

        internal virtual DisableBaselineResponse DisableBaseline(DisableBaselineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableBaselineResponseUnmarshaller.Instance;

            return Invoke<DisableBaselineResponse>(request, options);
        }



        /// <summary>
        /// Disable an <c>EnabledBaseline</c> resource on the specified Target. This API starts
        /// an asynchronous operation to remove all resources deployed as part of the baseline
        /// enablement. The resource will vary depending on the enabled baseline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableBaseline service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded. The limit is 10 concurrent
        /// operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/DisableBaseline">REST API Reference for DisableBaseline Operation</seealso>
        public virtual Task<DisableBaselineResponse> DisableBaselineAsync(DisableBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<DisableBaselineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableControl

        internal virtual DisableControlResponse DisableControl(DisableControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableControlResponseUnmarshaller.Instance;

            return Invoke<DisableControlResponse>(request, options);
        }



        /// <summary>
        /// This API call turns off a control. It starts an asynchronous operation that deletes
        /// AWS resources on the specified organizational unit and the accounts it contains. The
        /// resources will vary according to the control that you specify. For usage examples,
        /// see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded. The limit is 10 concurrent
        /// operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/DisableControl">REST API Reference for DisableControl Operation</seealso>
        public virtual Task<DisableControlResponse> DisableControlAsync(DisableControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableControlResponseUnmarshaller.Instance;

            return InvokeAsync<DisableControlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableBaseline

        internal virtual EnableBaselineResponse EnableBaseline(EnableBaselineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableBaselineResponseUnmarshaller.Instance;

            return Invoke<EnableBaselineResponse>(request, options);
        }



        /// <summary>
        /// Enable (apply) a <c>Baseline</c> to a Target. This API starts an asynchronous operation
        /// to deploy resources specified by the <c>Baseline</c> to the specified Target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableBaseline service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded. The limit is 10 concurrent
        /// operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/EnableBaseline">REST API Reference for EnableBaseline Operation</seealso>
        public virtual Task<EnableBaselineResponse> EnableBaselineAsync(EnableBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<EnableBaselineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableControl

        internal virtual EnableControlResponse EnableControl(EnableControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableControlResponseUnmarshaller.Instance;

            return Invoke<EnableControlResponse>(request, options);
        }



        /// <summary>
        /// This API call activates a control. It starts an asynchronous operation that creates
        /// Amazon Web Services resources on the specified organizational unit and the accounts
        /// it contains. The resources created will vary according to the control that you specify.
        /// For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded. The limit is 10 concurrent
        /// operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/EnableControl">REST API Reference for EnableControl Operation</seealso>
        public virtual Task<EnableControlResponse> EnableControlAsync(EnableControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableControlResponseUnmarshaller.Instance;

            return InvokeAsync<EnableControlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBaseline

        internal virtual GetBaselineResponse GetBaseline(GetBaselineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBaselineResponseUnmarshaller.Instance;

            return Invoke<GetBaselineResponse>(request, options);
        }



        /// <summary>
        /// Retrieve details about an existing <c>Baseline</c> resource by specifying its identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBaseline service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetBaseline">REST API Reference for GetBaseline Operation</seealso>
        public virtual Task<GetBaselineResponse> GetBaselineAsync(GetBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<GetBaselineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBaselineOperation

        internal virtual GetBaselineOperationResponse GetBaselineOperation(GetBaselineOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBaselineOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBaselineOperationResponseUnmarshaller.Instance;

            return Invoke<GetBaselineOperationResponse>(request, options);
        }



        /// <summary>
        /// Returns the details of an asynchronous baseline operation, as initiated by any of
        /// these APIs: <c>EnableBaseline</c>, <c>DisableBaseline</c>, <c>UpdateEnabledBaseline</c>,
        /// <c>ResetEnabledBaseline</c>. A status message is displayed in case of operation failure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBaselineOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBaselineOperation service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetBaselineOperation">REST API Reference for GetBaselineOperation Operation</seealso>
        public virtual Task<GetBaselineOperationResponse> GetBaselineOperationAsync(GetBaselineOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBaselineOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBaselineOperationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBaselineOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetControlOperation

        internal virtual GetControlOperationResponse GetControlOperation(GetControlOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetControlOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetControlOperationResponseUnmarshaller.Instance;

            return Invoke<GetControlOperationResponse>(request, options);
        }



        /// <summary>
        /// Returns the status of a particular <c>EnableControl</c> or <c>DisableControl</c> operation.
        /// Displays a message in case of error. Details for an operation are available for 90
        /// days. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetControlOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetControlOperation service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetControlOperation">REST API Reference for GetControlOperation Operation</seealso>
        public virtual Task<GetControlOperationResponse> GetControlOperationAsync(GetControlOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetControlOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetControlOperationResponseUnmarshaller.Instance;

            return InvokeAsync<GetControlOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEnabledBaseline

        internal virtual GetEnabledBaselineResponse GetEnabledBaseline(GetEnabledBaselineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnabledBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnabledBaselineResponseUnmarshaller.Instance;

            return Invoke<GetEnabledBaselineResponse>(request, options);
        }



        /// <summary>
        /// Retrieve details of an <c>EnabledBaseline</c> resource by specifying its identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnabledBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnabledBaseline service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetEnabledBaseline">REST API Reference for GetEnabledBaseline Operation</seealso>
        public virtual Task<GetEnabledBaselineResponse> GetEnabledBaselineAsync(GetEnabledBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnabledBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnabledBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnabledBaselineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEnabledControl

        internal virtual GetEnabledControlResponse GetEnabledControl(GetEnabledControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnabledControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnabledControlResponseUnmarshaller.Instance;

            return Invoke<GetEnabledControlResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details about an enabled control. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnabledControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnabledControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetEnabledControl">REST API Reference for GetEnabledControl Operation</seealso>
        public virtual Task<GetEnabledControlResponse> GetEnabledControlAsync(GetEnabledControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnabledControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnabledControlResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnabledControlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLandingZone

        internal virtual GetLandingZoneResponse GetLandingZone(GetLandingZoneRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLandingZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLandingZoneResponseUnmarshaller.Instance;

            return Invoke<GetLandingZoneResponse>(request, options);
        }



        /// <summary>
        /// Returns details about the landing zone. Displays a message in case of error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLandingZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLandingZone service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetLandingZone">REST API Reference for GetLandingZone Operation</seealso>
        public virtual Task<GetLandingZoneResponse> GetLandingZoneAsync(GetLandingZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLandingZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLandingZoneResponseUnmarshaller.Instance;

            return InvokeAsync<GetLandingZoneResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLandingZoneOperation

        internal virtual GetLandingZoneOperationResponse GetLandingZoneOperation(GetLandingZoneOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLandingZoneOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLandingZoneOperationResponseUnmarshaller.Instance;

            return Invoke<GetLandingZoneOperationResponse>(request, options);
        }



        /// <summary>
        /// Returns the status of the specified landing zone operation. Details for an operation
        /// are available for 60 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLandingZoneOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLandingZoneOperation service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetLandingZoneOperation">REST API Reference for GetLandingZoneOperation Operation</seealso>
        public virtual Task<GetLandingZoneOperationResponse> GetLandingZoneOperationAsync(GetLandingZoneOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLandingZoneOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLandingZoneOperationResponseUnmarshaller.Instance;

            return InvokeAsync<GetLandingZoneOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBaselines

        internal virtual ListBaselinesResponse ListBaselines(ListBaselinesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBaselinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBaselinesResponseUnmarshaller.Instance;

            return Invoke<ListBaselinesResponse>(request, options);
        }



        /// <summary>
        /// Returns a summary list of all available baselines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBaselines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBaselines service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListBaselines">REST API Reference for ListBaselines Operation</seealso>
        public virtual Task<ListBaselinesResponse> ListBaselinesAsync(ListBaselinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBaselinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBaselinesResponseUnmarshaller.Instance;

            return InvokeAsync<ListBaselinesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEnabledBaselines

        internal virtual ListEnabledBaselinesResponse ListEnabledBaselines(ListEnabledBaselinesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnabledBaselinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnabledBaselinesResponseUnmarshaller.Instance;

            return Invoke<ListEnabledBaselinesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of summaries describing <c>EnabledBaseline</c> resources. You can filter
        /// the list by the corresponding <c>Baseline</c> or <c>Target</c> of the <c>EnabledBaseline</c>
        /// resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnabledBaselines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnabledBaselines service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListEnabledBaselines">REST API Reference for ListEnabledBaselines Operation</seealso>
        public virtual Task<ListEnabledBaselinesResponse> ListEnabledBaselinesAsync(ListEnabledBaselinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnabledBaselinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnabledBaselinesResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnabledBaselinesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEnabledControls

        internal virtual ListEnabledControlsResponse ListEnabledControls(ListEnabledControlsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnabledControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnabledControlsResponseUnmarshaller.Instance;

            return Invoke<ListEnabledControlsResponse>(request, options);
        }



        /// <summary>
        /// Lists the controls enabled by Amazon Web Services Control Tower on the specified organizational
        /// unit and the accounts it contains. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnabledControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnabledControls service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListEnabledControls">REST API Reference for ListEnabledControls Operation</seealso>
        public virtual Task<ListEnabledControlsResponse> ListEnabledControlsAsync(ListEnabledControlsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnabledControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnabledControlsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnabledControlsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLandingZones

        internal virtual ListLandingZonesResponse ListLandingZones(ListLandingZonesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLandingZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLandingZonesResponseUnmarshaller.Instance;

            return Invoke<ListLandingZonesResponse>(request, options);
        }



        /// <summary>
        /// Returns the landing zone ARN for the landing zone deployed in your managed account.
        /// This API also creates an ARN for existing accounts that do not yet have a landing
        /// zone ARN. 
        /// 
        ///  
        /// <para>
        /// Returns one landing zone ARN.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLandingZones service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLandingZones service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListLandingZones">REST API Reference for ListLandingZones Operation</seealso>
        public virtual Task<ListLandingZonesResponse> ListLandingZonesAsync(ListLandingZonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLandingZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLandingZonesResponseUnmarshaller.Instance;

            return InvokeAsync<ListLandingZonesResponse>(request, options, cancellationToken);
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
        /// Returns a list of tags associated with the resource. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetEnabledBaseline

        internal virtual ResetEnabledBaselineResponse ResetEnabledBaseline(ResetEnabledBaselineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetEnabledBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetEnabledBaselineResponseUnmarshaller.Instance;

            return Invoke<ResetEnabledBaselineResponse>(request, options);
        }



        /// <summary>
        /// Re-enables an <c>EnabledBaseline</c> resource. For example, this API can re-apply
        /// the existing <c>Baseline</c> after a new member account is moved to the target OU.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetEnabledBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetEnabledBaseline service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded. The limit is 10 concurrent
        /// operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ResetEnabledBaseline">REST API Reference for ResetEnabledBaseline Operation</seealso>
        public virtual Task<ResetEnabledBaselineResponse> ResetEnabledBaselineAsync(ResetEnabledBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetEnabledBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetEnabledBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<ResetEnabledBaselineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetLandingZone

        internal virtual ResetLandingZoneResponse ResetLandingZone(ResetLandingZoneRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetLandingZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetLandingZoneResponseUnmarshaller.Instance;

            return Invoke<ResetLandingZoneResponse>(request, options);
        }



        /// <summary>
        /// This API call resets a landing zone. It starts an asynchronous operation that resets
        /// the landing zone to the parameters specified in its original configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetLandingZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetLandingZone service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ResetLandingZone">REST API Reference for ResetLandingZone Operation</seealso>
        public virtual Task<ResetLandingZoneResponse> ResetLandingZoneAsync(ResetLandingZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetLandingZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetLandingZoneResponseUnmarshaller.Instance;

            return InvokeAsync<ResetLandingZoneResponse>(request, options, cancellationToken);
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
        /// Applies tags to a resource. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from a resource. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEnabledBaseline

        internal virtual UpdateEnabledBaselineResponse UpdateEnabledBaseline(UpdateEnabledBaselineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnabledBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnabledBaselineResponseUnmarshaller.Instance;

            return Invoke<UpdateEnabledBaselineResponse>(request, options);
        }



        /// <summary>
        /// Updates an <c>EnabledBaseline</c> resource's applied parameters or version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnabledBaseline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnabledBaseline service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded. The limit is 10 concurrent
        /// operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/UpdateEnabledBaseline">REST API Reference for UpdateEnabledBaseline Operation</seealso>
        public virtual Task<UpdateEnabledBaselineResponse> UpdateEnabledBaselineAsync(UpdateEnabledBaselineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnabledBaselineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnabledBaselineResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnabledBaselineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEnabledControl

        internal virtual UpdateEnabledControlResponse UpdateEnabledControl(UpdateEnabledControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnabledControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnabledControlResponseUnmarshaller.Instance;

            return Invoke<UpdateEnabledControlResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of an already enabled control.
        /// 
        ///  
        /// <para>
        /// If the enabled control shows an <c>EnablementStatus</c> of SUCCEEDED, supply parameters
        /// that are different from the currently configured parameters. Otherwise, Amazon Web
        /// Services Control Tower will not accept the request.
        /// </para>
        ///  
        /// <para>
        /// If the enabled control shows an <c>EnablementStatus</c> of FAILED, Amazon Web Services
        /// Control Tower will update the control to match any valid parameters that you supply.
        /// </para>
        ///  
        /// <para>
        /// If the <c>DriftSummary</c> status for the control shows as DRIFTED, you cannot call
        /// this API. Instead, you can update the control by calling <c>DisableControl</c> and
        /// again calling <c>EnableControl</c>, or you can run an extending governance operation.
        /// For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnabledControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnabledControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded. The limit is 10 concurrent
        /// operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/UpdateEnabledControl">REST API Reference for UpdateEnabledControl Operation</seealso>
        public virtual Task<UpdateEnabledControlResponse> UpdateEnabledControlAsync(UpdateEnabledControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnabledControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnabledControlResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnabledControlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLandingZone

        internal virtual UpdateLandingZoneResponse UpdateLandingZone(UpdateLandingZoneRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLandingZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLandingZoneResponseUnmarshaller.Instance;

            return Invoke<UpdateLandingZoneResponse>(request, options);
        }



        /// <summary>
        /// This API call updates the landing zone. It starts an asynchronous operation that updates
        /// the landing zone based on the new landing zone version, or on the changed parameters
        /// specified in the updated manifest file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLandingZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLandingZone service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/UpdateLandingZone">REST API Reference for UpdateLandingZone Operation</seealso>
        public virtual Task<UpdateLandingZoneResponse> UpdateLandingZoneAsync(UpdateLandingZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLandingZoneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLandingZoneResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLandingZoneResponse>(request, options, cancellationToken);
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
            var resolver = new AmazonControlTowerEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}