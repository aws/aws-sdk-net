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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ObservabilityAdmin.Model;
using Amazon.ObservabilityAdmin.Model.Internal.MarshallTransformations;
using Amazon.ObservabilityAdmin.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.ObservabilityAdmin
{
    /// <summary>
    /// <para>Implementation for accessing ObservabilityAdmin</para>
    ///
    /// Amazon CloudWatch Obsersavability Admin to control temletry config for your AWS Organization
    /// or account. Telemetry config conﬁg to discover and understand the state of telemetry
    /// conﬁguration for your AWS resources from a central view in the CloudWatch console.
    /// Telemetry conﬁg simpliﬁes the process of auditing your telemetry collection conﬁgurations
    /// across multiple resource types across your AWS Organization or account. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/telemetry-config-cloudwatch.html">Auditing
    /// CloudWatch telemetry conﬁgurations</a> in the CloudWatch User Guide.
    /// 
    ///  
    /// <para>
    /// For information on the permissions you need to use this API, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/auth-and-access-control-cw.html">Identity
    /// and access management for Amazon CloudWatch</a> in the CloudWatch User Guide.
    /// </para>
    /// </summary>
    public partial class AmazonObservabilityAdminClient : AmazonServiceClient, IAmazonObservabilityAdmin
    {
        private static IServiceMetadata serviceMetadata = new AmazonObservabilityAdminMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IObservabilityAdminPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IObservabilityAdminPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ObservabilityAdminPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with the credentials loaded from the application's
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
        public AmazonObservabilityAdminClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonObservabilityAdminConfig()) { }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with the credentials loaded from the application's
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
        public AmazonObservabilityAdminClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonObservabilityAdminConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonObservabilityAdminClient Configuration Object</param>
        public AmazonObservabilityAdminClient(AmazonObservabilityAdminConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonObservabilityAdminClient(AWSCredentials credentials)
            : this(credentials, new AmazonObservabilityAdminConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonObservabilityAdminClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonObservabilityAdminConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with AWS Credentials and an
        /// AmazonObservabilityAdminClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonObservabilityAdminClient Configuration Object</param>
        public AmazonObservabilityAdminClient(AWSCredentials credentials, AmazonObservabilityAdminConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonObservabilityAdminClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonObservabilityAdminConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonObservabilityAdminClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonObservabilityAdminConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonObservabilityAdminClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonObservabilityAdminClient Configuration Object</param>
        public AmazonObservabilityAdminClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonObservabilityAdminConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonObservabilityAdminClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonObservabilityAdminConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonObservabilityAdminClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonObservabilityAdminConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonObservabilityAdminClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonObservabilityAdminClient Configuration Object</param>
        public AmazonObservabilityAdminClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonObservabilityAdminConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonObservabilityAdminEndpointResolver());
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


        #region  GetTelemetryEvaluationStatus

        /// <summary>
        /// Returns the current onboarding status of the telemetry config feature, including
        /// the status of the feature and reason the feature failed to start or stop.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryEvaluationStatus service method.</param>
        /// 
        /// <returns>The response from the GetTelemetryEvaluationStatus service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for AWS resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatus">REST API Reference for GetTelemetryEvaluationStatus Operation</seealso>
        public virtual GetTelemetryEvaluationStatusResponse GetTelemetryEvaluationStatus(GetTelemetryEvaluationStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTelemetryEvaluationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryEvaluationStatusResponseUnmarshaller.Instance;

            return Invoke<GetTelemetryEvaluationStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTelemetryEvaluationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryEvaluationStatus operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTelemetryEvaluationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatus">REST API Reference for GetTelemetryEvaluationStatus Operation</seealso>
        public virtual IAsyncResult BeginGetTelemetryEvaluationStatus(GetTelemetryEvaluationStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTelemetryEvaluationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryEvaluationStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTelemetryEvaluationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTelemetryEvaluationStatus.</param>
        /// 
        /// <returns>Returns a  GetTelemetryEvaluationStatusResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatus">REST API Reference for GetTelemetryEvaluationStatus Operation</seealso>
        public virtual GetTelemetryEvaluationStatusResponse EndGetTelemetryEvaluationStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTelemetryEvaluationStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTelemetryEvaluationStatusForOrganization

        /// <summary>
        /// This returns the onboarding status of the telemetry configuration feature for the
        /// organization. It can only be called by a Management Account of an AWS Organization
        /// or an assigned Delegated Admin Account of AWS CloudWatch telemetry config.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryEvaluationStatusForOrganization service method.</param>
        /// 
        /// <returns>The response from the GetTelemetryEvaluationStatusForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for AWS resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatusForOrganization">REST API Reference for GetTelemetryEvaluationStatusForOrganization Operation</seealso>
        public virtual GetTelemetryEvaluationStatusForOrganizationResponse GetTelemetryEvaluationStatusForOrganization(GetTelemetryEvaluationStatusForOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTelemetryEvaluationStatusForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryEvaluationStatusForOrganizationResponseUnmarshaller.Instance;

            return Invoke<GetTelemetryEvaluationStatusForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTelemetryEvaluationStatusForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryEvaluationStatusForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTelemetryEvaluationStatusForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatusForOrganization">REST API Reference for GetTelemetryEvaluationStatusForOrganization Operation</seealso>
        public virtual IAsyncResult BeginGetTelemetryEvaluationStatusForOrganization(GetTelemetryEvaluationStatusForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTelemetryEvaluationStatusForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryEvaluationStatusForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTelemetryEvaluationStatusForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTelemetryEvaluationStatusForOrganization.</param>
        /// 
        /// <returns>Returns a  GetTelemetryEvaluationStatusForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatusForOrganization">REST API Reference for GetTelemetryEvaluationStatusForOrganization Operation</seealso>
        public virtual GetTelemetryEvaluationStatusForOrganizationResponse EndGetTelemetryEvaluationStatusForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTelemetryEvaluationStatusForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResourceTelemetry

        /// <summary>
        /// Returns a list of telemetry configurations for AWS resources supported by telemetry
        /// config. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/telemetry-config-cloudwatch.html">Auditing
        /// CloudWatch telemetry configurations</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTelemetry service method.</param>
        /// 
        /// <returns>The response from the ListResourceTelemetry service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for AWS resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetry">REST API Reference for ListResourceTelemetry Operation</seealso>
        public virtual ListResourceTelemetryResponse ListResourceTelemetry(ListResourceTelemetryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceTelemetryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTelemetryResponseUnmarshaller.Instance;

            return Invoke<ListResourceTelemetryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceTelemetry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTelemetry operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceTelemetry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetry">REST API Reference for ListResourceTelemetry Operation</seealso>
        public virtual IAsyncResult BeginListResourceTelemetry(ListResourceTelemetryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceTelemetryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTelemetryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceTelemetry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceTelemetry.</param>
        /// 
        /// <returns>Returns a  ListResourceTelemetryResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetry">REST API Reference for ListResourceTelemetry Operation</seealso>
        public virtual ListResourceTelemetryResponse EndListResourceTelemetry(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourceTelemetryResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResourceTelemetryForOrganization

        /// <summary>
        /// Returns a list of telemetry configurations for AWS resources supported by telemetry
        /// config in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTelemetryForOrganization service method.</param>
        /// 
        /// <returns>The response from the ListResourceTelemetryForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for AWS resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetryForOrganization">REST API Reference for ListResourceTelemetryForOrganization Operation</seealso>
        public virtual ListResourceTelemetryForOrganizationResponse ListResourceTelemetryForOrganization(ListResourceTelemetryForOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceTelemetryForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTelemetryForOrganizationResponseUnmarshaller.Instance;

            return Invoke<ListResourceTelemetryForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceTelemetryForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTelemetryForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceTelemetryForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetryForOrganization">REST API Reference for ListResourceTelemetryForOrganization Operation</seealso>
        public virtual IAsyncResult BeginListResourceTelemetryForOrganization(ListResourceTelemetryForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceTelemetryForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTelemetryForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceTelemetryForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceTelemetryForOrganization.</param>
        /// 
        /// <returns>Returns a  ListResourceTelemetryForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetryForOrganization">REST API Reference for ListResourceTelemetryForOrganization Operation</seealso>
        public virtual ListResourceTelemetryForOrganizationResponse EndListResourceTelemetryForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourceTelemetryForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTelemetryEvaluation

        /// <summary>
        /// This action begins onboarding onboarding the caller AWS account to the telemetry
        /// config feature.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryEvaluation service method.</param>
        /// 
        /// <returns>The response from the StartTelemetryEvaluation service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for AWS resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluation">REST API Reference for StartTelemetryEvaluation Operation</seealso>
        public virtual StartTelemetryEvaluationResponse StartTelemetryEvaluation(StartTelemetryEvaluationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTelemetryEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTelemetryEvaluationResponseUnmarshaller.Instance;

            return Invoke<StartTelemetryEvaluationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTelemetryEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryEvaluation operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTelemetryEvaluation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluation">REST API Reference for StartTelemetryEvaluation Operation</seealso>
        public virtual IAsyncResult BeginStartTelemetryEvaluation(StartTelemetryEvaluationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTelemetryEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTelemetryEvaluationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTelemetryEvaluation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTelemetryEvaluation.</param>
        /// 
        /// <returns>Returns a  StartTelemetryEvaluationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluation">REST API Reference for StartTelemetryEvaluation Operation</seealso>
        public virtual StartTelemetryEvaluationResponse EndStartTelemetryEvaluation(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTelemetryEvaluationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTelemetryEvaluationForOrganization

        /// <summary>
        /// This actions begins onboarding the organization and all member accounts to the telemetry
        /// config feature.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryEvaluationForOrganization service method.</param>
        /// 
        /// <returns>The response from the StartTelemetryEvaluationForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for AWS resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluationForOrganization">REST API Reference for StartTelemetryEvaluationForOrganization Operation</seealso>
        public virtual StartTelemetryEvaluationForOrganizationResponse StartTelemetryEvaluationForOrganization(StartTelemetryEvaluationForOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTelemetryEvaluationForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTelemetryEvaluationForOrganizationResponseUnmarshaller.Instance;

            return Invoke<StartTelemetryEvaluationForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTelemetryEvaluationForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryEvaluationForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTelemetryEvaluationForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluationForOrganization">REST API Reference for StartTelemetryEvaluationForOrganization Operation</seealso>
        public virtual IAsyncResult BeginStartTelemetryEvaluationForOrganization(StartTelemetryEvaluationForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTelemetryEvaluationForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTelemetryEvaluationForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTelemetryEvaluationForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTelemetryEvaluationForOrganization.</param>
        /// 
        /// <returns>Returns a  StartTelemetryEvaluationForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluationForOrganization">REST API Reference for StartTelemetryEvaluationForOrganization Operation</seealso>
        public virtual StartTelemetryEvaluationForOrganizationResponse EndStartTelemetryEvaluationForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTelemetryEvaluationForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  StopTelemetryEvaluation

        /// <summary>
        /// This action begins offboarding the caller AWS account from the telemetry config feature.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryEvaluation service method.</param>
        /// 
        /// <returns>The response from the StopTelemetryEvaluation service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for AWS resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluation">REST API Reference for StopTelemetryEvaluation Operation</seealso>
        public virtual StopTelemetryEvaluationResponse StopTelemetryEvaluation(StopTelemetryEvaluationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTelemetryEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTelemetryEvaluationResponseUnmarshaller.Instance;

            return Invoke<StopTelemetryEvaluationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopTelemetryEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryEvaluation operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTelemetryEvaluation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluation">REST API Reference for StopTelemetryEvaluation Operation</seealso>
        public virtual IAsyncResult BeginStopTelemetryEvaluation(StopTelemetryEvaluationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTelemetryEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTelemetryEvaluationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopTelemetryEvaluation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTelemetryEvaluation.</param>
        /// 
        /// <returns>Returns a  StopTelemetryEvaluationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluation">REST API Reference for StopTelemetryEvaluation Operation</seealso>
        public virtual StopTelemetryEvaluationResponse EndStopTelemetryEvaluation(IAsyncResult asyncResult)
        {
            return EndInvoke<StopTelemetryEvaluationResponse>(asyncResult);
        }

        #endregion
        
        #region  StopTelemetryEvaluationForOrganization

        /// <summary>
        /// This action offboards the Organization of the caller AWS account from thef telemetry
        /// config feature.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryEvaluationForOrganization service method.</param>
        /// 
        /// <returns>The response from the StopTelemetryEvaluationForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for AWS resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluationForOrganization">REST API Reference for StopTelemetryEvaluationForOrganization Operation</seealso>
        public virtual StopTelemetryEvaluationForOrganizationResponse StopTelemetryEvaluationForOrganization(StopTelemetryEvaluationForOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTelemetryEvaluationForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTelemetryEvaluationForOrganizationResponseUnmarshaller.Instance;

            return Invoke<StopTelemetryEvaluationForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopTelemetryEvaluationForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryEvaluationForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTelemetryEvaluationForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluationForOrganization">REST API Reference for StopTelemetryEvaluationForOrganization Operation</seealso>
        public virtual IAsyncResult BeginStopTelemetryEvaluationForOrganization(StopTelemetryEvaluationForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTelemetryEvaluationForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTelemetryEvaluationForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopTelemetryEvaluationForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTelemetryEvaluationForOrganization.</param>
        /// 
        /// <returns>Returns a  StopTelemetryEvaluationForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluationForOrganization">REST API Reference for StopTelemetryEvaluationForOrganization Operation</seealso>
        public virtual StopTelemetryEvaluationForOrganizationResponse EndStopTelemetryEvaluationForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<StopTelemetryEvaluationForOrganizationResponse>(asyncResult);
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
            var resolver = new AmazonObservabilityAdminEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}