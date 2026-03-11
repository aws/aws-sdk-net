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
 * Do not modify this file. This file is generated from the ssm-guiconnect-2021-05-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SSMGuiConnect.Model;
using Amazon.SSMGuiConnect.Model.Internal.MarshallTransformations;
using Amazon.SSMGuiConnect.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.SSMGuiConnect
{
    /// <summary>
    /// <para>Implementation for accessing SSMGuiConnect</para>
    ///
    /// AWS Systems Manager GUI Connect 
    /// <para>
    /// Systems Manager GUI Connect, a component of Fleet Manager, lets you connect to your
    /// Window Server-type Amazon Elastic Compute Cloud (Amazon EC2) instances using the Remote
    /// Desktop Protocol (RDP). GUI Connect, which is powered by <a href="https://docs.aws.amazon.com/dcv/latest/adminguide/what-is-dcv.html">Amazon
    /// DCV</a>, provides you with secure connectivity to your Windows Server instances directly
    /// from the Systems Manager console. You can have up to four simultaneous connections
    /// in a single browser window. In the console, GUI Connect is also referred to as Fleet
    /// Manager Remote Desktop.
    /// 
    ///  
    /// <para>
    /// This reference is intended to be used with the <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/">
    /// <i>Amazon Web Services Systems Manager User Guide</i> </a>. To get started, see the
    /// following user guide topics:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-setting-up.html">Setting
    /// up Amazon Web Services Systems Manager</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/fleet-rdp.html">Connect
    /// to a Windows Server managed instance using Remote Desktop</a> 
    /// </para>
    ///  </li> </ul>
    /// </para>
    /// </summary>
    public partial class AmazonSSMGuiConnectClient : AmazonServiceClient, IAmazonSSMGuiConnect
    {
        private static IServiceMetadata serviceMetadata = new AmazonSSMGuiConnectMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonSSMGuiConnectClient with the credentials loaded from the application's
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
        public AmazonSSMGuiConnectClient()
            : base(new AmazonSSMGuiConnectConfig()) { }

        /// <summary>
        /// Constructs AmazonSSMGuiConnectClient with the credentials loaded from the application's
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
        public AmazonSSMGuiConnectClient(RegionEndpoint region)
            : base(new AmazonSSMGuiConnectConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSSMGuiConnectClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSSMGuiConnectClient Configuration Object</param>
        public AmazonSSMGuiConnectClient(AmazonSSMGuiConnectConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonSSMGuiConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSSMGuiConnectClient(AWSCredentials credentials)
            : this(credentials, new AmazonSSMGuiConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSMGuiConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSMGuiConnectClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSSMGuiConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSMGuiConnectClient with AWS Credentials and an
        /// AmazonSSMGuiConnectClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSSMGuiConnectClient Configuration Object</param>
        public AmazonSSMGuiConnectClient(AWSCredentials credentials, AmazonSSMGuiConnectConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSSMGuiConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSSMGuiConnectClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSSMGuiConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSMGuiConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSMGuiConnectClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSSMGuiConnectConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSMGuiConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSSMGuiConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSSMGuiConnectClient Configuration Object</param>
        public AmazonSSMGuiConnectClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSSMGuiConnectConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSSMGuiConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSSMGuiConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSSMGuiConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSSMGuiConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSSMGuiConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSSMGuiConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSSMGuiConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSSMGuiConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSSMGuiConnectClient Configuration Object</param>
        public AmazonSSMGuiConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSSMGuiConnectConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSSMGuiConnectEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSSMGuiConnectAuthSchemeHandler());
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


        #region  DeleteConnectionRecordingPreferences


        /// <summary>
        /// Deletes the preferences for recording RDP connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectionRecordingPreferences service method.</param>
        /// 
        /// <returns>The response from the DeleteConnectionRecordingPreferences service method, as returned by SSMGuiConnect.</returns>
        /// <exception cref="Amazon.SSMGuiConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ConflictException">
        /// An error occurred due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-guiconnect-2021-05-01/DeleteConnectionRecordingPreferences">REST API Reference for DeleteConnectionRecordingPreferences Operation</seealso>
        public virtual DeleteConnectionRecordingPreferencesResponse DeleteConnectionRecordingPreferences(DeleteConnectionRecordingPreferencesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRecordingPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionRecordingPreferencesResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectionRecordingPreferencesResponse>(request, options);
        }


        /// <summary>
        /// Deletes the preferences for recording RDP connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectionRecordingPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnectionRecordingPreferences service method, as returned by SSMGuiConnect.</returns>
        /// <exception cref="Amazon.SSMGuiConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ConflictException">
        /// An error occurred due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-guiconnect-2021-05-01/DeleteConnectionRecordingPreferences">REST API Reference for DeleteConnectionRecordingPreferences Operation</seealso>
        public virtual Task<DeleteConnectionRecordingPreferencesResponse> DeleteConnectionRecordingPreferencesAsync(DeleteConnectionRecordingPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRecordingPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionRecordingPreferencesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteConnectionRecordingPreferencesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConnectionRecordingPreferences


        /// <summary>
        /// Returns the preferences specified for recording RDP connections in the requesting
        /// Amazon Web Services account and Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionRecordingPreferences service method.</param>
        /// 
        /// <returns>The response from the GetConnectionRecordingPreferences service method, as returned by SSMGuiConnect.</returns>
        /// <exception cref="Amazon.SSMGuiConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ConflictException">
        /// An error occurred due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-guiconnect-2021-05-01/GetConnectionRecordingPreferences">REST API Reference for GetConnectionRecordingPreferences Operation</seealso>
        public virtual GetConnectionRecordingPreferencesResponse GetConnectionRecordingPreferences(GetConnectionRecordingPreferencesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionRecordingPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionRecordingPreferencesResponseUnmarshaller.Instance;

            return Invoke<GetConnectionRecordingPreferencesResponse>(request, options);
        }


        /// <summary>
        /// Returns the preferences specified for recording RDP connections in the requesting
        /// Amazon Web Services account and Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionRecordingPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnectionRecordingPreferences service method, as returned by SSMGuiConnect.</returns>
        /// <exception cref="Amazon.SSMGuiConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ConflictException">
        /// An error occurred due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-guiconnect-2021-05-01/GetConnectionRecordingPreferences">REST API Reference for GetConnectionRecordingPreferences Operation</seealso>
        public virtual Task<GetConnectionRecordingPreferencesResponse> GetConnectionRecordingPreferencesAsync(GetConnectionRecordingPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionRecordingPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionRecordingPreferencesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetConnectionRecordingPreferencesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConnectionRecordingPreferences


        /// <summary>
        /// Updates the preferences for recording RDP connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectionRecordingPreferences service method.</param>
        /// 
        /// <returns>The response from the UpdateConnectionRecordingPreferences service method, as returned by SSMGuiConnect.</returns>
        /// <exception cref="Amazon.SSMGuiConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ConflictException">
        /// An error occurred due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-guiconnect-2021-05-01/UpdateConnectionRecordingPreferences">REST API Reference for UpdateConnectionRecordingPreferences Operation</seealso>
        public virtual UpdateConnectionRecordingPreferencesResponse UpdateConnectionRecordingPreferences(UpdateConnectionRecordingPreferencesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectionRecordingPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionRecordingPreferencesResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectionRecordingPreferencesResponse>(request, options);
        }


        /// <summary>
        /// Updates the preferences for recording RDP connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectionRecordingPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnectionRecordingPreferences service method, as returned by SSMGuiConnect.</returns>
        /// <exception cref="Amazon.SSMGuiConnect.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ConflictException">
        /// An error occurred due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SSMGuiConnect.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ssm-guiconnect-2021-05-01/UpdateConnectionRecordingPreferences">REST API Reference for UpdateConnectionRecordingPreferences Operation</seealso>
        public virtual Task<UpdateConnectionRecordingPreferencesResponse> UpdateConnectionRecordingPreferencesAsync(UpdateConnectionRecordingPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectionRecordingPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionRecordingPreferencesResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateConnectionRecordingPreferencesResponse>(request, options, cancellationToken);
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