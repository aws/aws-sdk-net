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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.EMRServerlessWebService.Model;
using Amazon.EMRServerlessWebService.Model.Internal.MarshallTransformations;
using Amazon.EMRServerlessWebService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EMRServerlessWebService
{
    /// <summary>
    /// Implementation for accessing EMRServerlessWebService
    ///
    /// Amazon EMR Serverless is a new deployment option for Amazon EMR. EMR Serverless provides
    /// a serverless runtime environment that simplifies running analytics applications using
    /// the latest open source frameworks such as Apache Spark and Apache Hive. With EMR Serverless,
    /// you don’t have to configure, optimize, secure, or operate clusters to run applications
    /// with these frameworks.
    /// 
    ///  
    /// <para>
    /// The API reference to Amazon EMR Serverless is <code>emr-serverless</code>. The <code>emr-serverless</code>
    /// prefix is used in the following scenarios: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// It is the prefix in the CLI commands for Amazon EMR Serverless. For example, <code>aws
    /// emr-serverless start-job-run</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// It is the prefix before IAM policy actions for Amazon EMR Serverless. For example,
    /// <code>"Action": ["emr-serverless:StartJobRun"]</code>. For more information, see <a
    /// href="https://docs.aws.amazon.com/emr/latest/EMR-Serverless-UserGuide/security_iam_service-with-iam.html#security_iam_service-with-iam-id-based-policies-actions">Policy
    /// actions for Amazon EMR Serverless</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// It is the prefix used in Amazon EMR Serverless service endpoints. For example, <code>emr-serverless.us-east-2.amazonaws.com</code>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonEMRServerlessWebServiceClient : AmazonServiceClient, IAmazonEMRServerlessWebService
    {
        private static IServiceMetadata serviceMetadata = new AmazonEMRServerlessWebServiceMetadata();
        private IEMRServerlessWebServicePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IEMRServerlessWebServicePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new EMRServerlessWebServicePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonEMRServerlessWebServiceClient with the credentials loaded from the application's
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
        public AmazonEMRServerlessWebServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEMRServerlessWebServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonEMRServerlessWebServiceClient with the credentials loaded from the application's
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
        public AmazonEMRServerlessWebServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEMRServerlessWebServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEMRServerlessWebServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEMRServerlessWebServiceClient Configuration Object</param>
        public AmazonEMRServerlessWebServiceClient(AmazonEMRServerlessWebServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonEMRServerlessWebServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEMRServerlessWebServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonEMRServerlessWebServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEMRServerlessWebServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEMRServerlessWebServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEMRServerlessWebServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEMRServerlessWebServiceClient with AWS Credentials and an
        /// AmazonEMRServerlessWebServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEMRServerlessWebServiceClient Configuration Object</param>
        public AmazonEMRServerlessWebServiceClient(AWSCredentials credentials, AmazonEMRServerlessWebServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEMRServerlessWebServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEMRServerlessWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEMRServerlessWebServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEMRServerlessWebServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEMRServerlessWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEMRServerlessWebServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEMRServerlessWebServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEMRServerlessWebServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEMRServerlessWebServiceClient Configuration Object</param>
        public AmazonEMRServerlessWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonEMRServerlessWebServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEMRServerlessWebServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEMRServerlessWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEMRServerlessWebServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEMRServerlessWebServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEMRServerlessWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEMRServerlessWebServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEMRServerlessWebServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEMRServerlessWebServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEMRServerlessWebServiceClient Configuration Object</param>
        public AmazonEMRServerlessWebServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEMRServerlessWebServiceConfig clientConfig)
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


        #region  CancelJobRun


        /// <summary>
        /// Cancels a job run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJobRun service method.</param>
        /// 
        /// <returns>The response from the CancelJobRun service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/CancelJobRun">REST API Reference for CancelJobRun Operation</seealso>
        public virtual CancelJobRunResponse CancelJobRun(CancelJobRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobRunResponseUnmarshaller.Instance;

            return Invoke<CancelJobRunResponse>(request, options);
        }


        /// <summary>
        /// Cancels a job run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJobRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelJobRun service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/CancelJobRun">REST API Reference for CancelJobRun Operation</seealso>
        public virtual Task<CancelJobRunResponse> CancelJobRunAsync(CancelJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobRunResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelJobRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApplication


        /// <summary>
        /// Creates an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }


        /// <summary>
        /// Creates an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplication


        /// <summary>
        /// Deletes an application. An application has to be in a stopped or created state in
        /// order to be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }


        /// <summary>
        /// Deletes an application. An application has to be in a stopped or created state in
        /// order to be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApplication


        /// <summary>
        /// Displays detailed information about a specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return Invoke<GetApplicationResponse>(request, options);
        }


        /// <summary>
        /// Displays detailed information about a specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJobRun


        /// <summary>
        /// Displays detailed information about a job run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobRun service method.</param>
        /// 
        /// <returns>The response from the GetJobRun service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/GetJobRun">REST API Reference for GetJobRun Operation</seealso>
        public virtual GetJobRunResponse GetJobRun(GetJobRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobRunResponseUnmarshaller.Instance;

            return Invoke<GetJobRunResponse>(request, options);
        }


        /// <summary>
        /// Displays detailed information about a job run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJobRun service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/GetJobRun">REST API Reference for GetJobRun Operation</seealso>
        public virtual Task<GetJobRunResponse> GetJobRunAsync(GetJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobRunResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetJobRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApplications


        /// <summary>
        /// Lists applications based on a set of parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsResponse>(request, options);
        }


        /// <summary>
        /// Lists applications based on a set of parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListApplicationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobRuns


        /// <summary>
        /// Lists job runs based on a set of parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobRuns service method.</param>
        /// 
        /// <returns>The response from the ListJobRuns service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/ListJobRuns">REST API Reference for ListJobRuns Operation</seealso>
        public virtual ListJobRunsResponse ListJobRuns(ListJobRunsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobRunsResponseUnmarshaller.Instance;

            return Invoke<ListJobRunsResponse>(request, options);
        }


        /// <summary>
        /// Lists job runs based on a set of parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobRuns service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/ListJobRuns">REST API Reference for ListJobRuns Operation</seealso>
        public virtual Task<ListJobRunsResponse> ListJobRunsAsync(ListJobRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobRunsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListJobRunsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags assigned to the resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags assigned to the resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartApplication


        /// <summary>
        /// Starts a specified application and initializes initial capacity if configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartApplication service method.</param>
        /// 
        /// <returns>The response from the StartApplication service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ServiceQuotaExceededException">
        /// The maximum number of resources per account has been reached.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/StartApplication">REST API Reference for StartApplication Operation</seealso>
        public virtual StartApplicationResponse StartApplication(StartApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartApplicationResponseUnmarshaller.Instance;

            return Invoke<StartApplicationResponse>(request, options);
        }


        /// <summary>
        /// Starts a specified application and initializes initial capacity if configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartApplication service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ServiceQuotaExceededException">
        /// The maximum number of resources per account has been reached.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/StartApplication">REST API Reference for StartApplication Operation</seealso>
        public virtual Task<StartApplicationResponse> StartApplicationAsync(StartApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartJobRun


        /// <summary>
        /// Starts a job run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJobRun service method.</param>
        /// 
        /// <returns>The response from the StartJobRun service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        public virtual StartJobRunResponse StartJobRun(StartJobRunRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobRunResponseUnmarshaller.Instance;

            return Invoke<StartJobRunResponse>(request, options);
        }


        /// <summary>
        /// Starts a job run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJobRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartJobRun service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/StartJobRun">REST API Reference for StartJobRun Operation</seealso>
        public virtual Task<StartJobRunResponse> StartJobRunAsync(StartJobRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobRunResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartJobRunResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopApplication


        /// <summary>
        /// Stops a specified application and releases initial capacity if configured. All scheduled
        /// and running jobs must be completed or cancelled before stopping an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopApplication service method.</param>
        /// 
        /// <returns>The response from the StopApplication service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/StopApplication">REST API Reference for StopApplication Operation</seealso>
        public virtual StopApplicationResponse StopApplication(StopApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopApplicationResponseUnmarshaller.Instance;

            return Invoke<StopApplicationResponse>(request, options);
        }


        /// <summary>
        /// Stops a specified application and releases initial capacity if configured. All scheduled
        /// and running jobs must be completed or cancelled before stopping an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopApplication service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/StopApplication">REST API Reference for StopApplication Operation</seealso>
        public virtual Task<StopApplicationResponse> StopApplicationAsync(StopApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns tags to resources. A tag is a label that you assign to an AWS resource. Each
        /// tag consists of a key and an optional value, both of which you define. Tags enable
        /// you to categorize your AWS resources by attributes such as purpose, owner, or environment.
        /// When you have many resources of the same type, you can quickly identify a specific
        /// resource based on the tags you've assigned to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Assigns tags to resources. A tag is a label that you assign to an AWS resource. Each
        /// tag consists of a key and an optional value, both of which you define. Tags enable
        /// you to categorize your AWS resources by attributes such as purpose, owner, or environment.
        /// When you have many resources of the same type, you can quickly identify a specific
        /// resource based on the tags you've assigned to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplication


        /// <summary>
        /// Updates a specified application. An application has to be in a stopped or created
        /// state in order to be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResponse>(request, options);
        }


        /// <summary>
        /// Updates a specified application. An application has to be in a stopped or created
        /// state in order to be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by EMRServerlessWebService.</returns>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.EMRServerlessWebService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/emr-serverless-2021-07-13/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}