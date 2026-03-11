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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.FIS.Model;
using Amazon.FIS.Model.Internal.MarshallTransformations;
using Amazon.FIS.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.FIS
{
    /// <summary>
    /// <para>Implementation for accessing FIS</para>
    ///
    /// Amazon Web Services Fault Injection Service is a managed service that enables you
    /// to perform fault injection experiments on your Amazon Web Services workloads. For
    /// more information, see the <a href="https://docs.aws.amazon.com/fis/latest/userguide/">Fault
    /// Injection Service User Guide</a>.
    /// </summary>
    public partial class AmazonFISClient : AmazonServiceClient, IAmazonFIS
    {
        private static IServiceMetadata serviceMetadata = new AmazonFISMetadata();
        private IFISPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IFISPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new FISPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonFISClient with the credentials loaded from the application's
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
        public AmazonFISClient()
            : base(new AmazonFISConfig()) { }

        /// <summary>
        /// Constructs AmazonFISClient with the credentials loaded from the application's
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
        public AmazonFISClient(RegionEndpoint region)
            : base(new AmazonFISConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonFISClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonFISClient Configuration Object</param>
        public AmazonFISClient(AmazonFISConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonFISClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonFISClient(AWSCredentials credentials)
            : this(credentials, new AmazonFISConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFISClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFISClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonFISConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFISClient with AWS Credentials and an
        /// AmazonFISClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonFISClient Configuration Object</param>
        public AmazonFISClient(AWSCredentials credentials, AmazonFISConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFISClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonFISClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFISConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFISClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFISClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFISConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonFISClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFISClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonFISClient Configuration Object</param>
        public AmazonFISClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonFISConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFISClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonFISClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFISConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFISClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFISClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFISConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFISClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFISClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonFISClient Configuration Object</param>
        public AmazonFISClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonFISConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonFISEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonFISAuthSchemeHandler());
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


        #region  CreateExperimentTemplate


        /// <summary>
        /// Creates an experiment template. 
        /// 
        ///  
        /// <para>
        /// An experiment template includes the following components:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Targets</b>: A target can be a specific resource in your Amazon Web Services environment,
        /// or one or more resources that match criteria that you specify, for example, resources
        /// that have specific tags.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Actions</b>: The actions to carry out on the target. You can specify multiple
        /// actions, the duration of each action, and when to start each action during an experiment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Stop conditions</b>: If a stop condition is triggered while an experiment is running,
        /// the experiment is automatically stopped. You can define a stop condition as a CloudWatch
        /// alarm.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fis/latest/userguide/experiment-templates.html">experiment
        /// templates</a> in the <i>Fault Injection Service User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExperimentTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateExperimentTemplate service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ConflictException">
        /// The request could not be processed because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/CreateExperimentTemplate">REST API Reference for CreateExperimentTemplate Operation</seealso>
        public virtual CreateExperimentTemplateResponse CreateExperimentTemplate(CreateExperimentTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExperimentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExperimentTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateExperimentTemplateResponse>(request, options);
        }


        /// <summary>
        /// Creates an experiment template. 
        /// 
        ///  
        /// <para>
        /// An experiment template includes the following components:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Targets</b>: A target can be a specific resource in your Amazon Web Services environment,
        /// or one or more resources that match criteria that you specify, for example, resources
        /// that have specific tags.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Actions</b>: The actions to carry out on the target. You can specify multiple
        /// actions, the duration of each action, and when to start each action during an experiment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Stop conditions</b>: If a stop condition is triggered while an experiment is running,
        /// the experiment is automatically stopped. You can define a stop condition as a CloudWatch
        /// alarm.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/fis/latest/userguide/experiment-templates.html">experiment
        /// templates</a> in the <i>Fault Injection Service User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExperimentTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateExperimentTemplate service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ConflictException">
        /// The request could not be processed because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/CreateExperimentTemplate">REST API Reference for CreateExperimentTemplate Operation</seealso>
        public virtual Task<CreateExperimentTemplateResponse> CreateExperimentTemplateAsync(CreateExperimentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExperimentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExperimentTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateExperimentTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTargetAccountConfiguration


        /// <summary>
        /// Creates a target account configuration for the experiment template. A target account
        /// configuration is required when <c>accountTargeting</c> of <c>experimentOptions</c>
        /// is set to <c>multi-account</c>. For more information, see <a href="https://docs.aws.amazon.com/fis/latest/userguide/experiment-options.html">experiment
        /// options</a> in the <i>Fault Injection Service User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetAccountConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateTargetAccountConfiguration service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ConflictException">
        /// The request could not be processed because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/CreateTargetAccountConfiguration">REST API Reference for CreateTargetAccountConfiguration Operation</seealso>
        public virtual CreateTargetAccountConfigurationResponse CreateTargetAccountConfiguration(CreateTargetAccountConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTargetAccountConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTargetAccountConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateTargetAccountConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Creates a target account configuration for the experiment template. A target account
        /// configuration is required when <c>accountTargeting</c> of <c>experimentOptions</c>
        /// is set to <c>multi-account</c>. For more information, see <a href="https://docs.aws.amazon.com/fis/latest/userguide/experiment-options.html">experiment
        /// options</a> in the <i>Fault Injection Service User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetAccountConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTargetAccountConfiguration service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ConflictException">
        /// The request could not be processed because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/CreateTargetAccountConfiguration">REST API Reference for CreateTargetAccountConfiguration Operation</seealso>
        public virtual Task<CreateTargetAccountConfigurationResponse> CreateTargetAccountConfigurationAsync(CreateTargetAccountConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTargetAccountConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTargetAccountConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateTargetAccountConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteExperimentTemplate


        /// <summary>
        /// Deletes the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperimentTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteExperimentTemplate service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/DeleteExperimentTemplate">REST API Reference for DeleteExperimentTemplate Operation</seealso>
        public virtual DeleteExperimentTemplateResponse DeleteExperimentTemplate(DeleteExperimentTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteExperimentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExperimentTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteExperimentTemplateResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperimentTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteExperimentTemplate service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/DeleteExperimentTemplate">REST API Reference for DeleteExperimentTemplate Operation</seealso>
        public virtual Task<DeleteExperimentTemplateResponse> DeleteExperimentTemplateAsync(DeleteExperimentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteExperimentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExperimentTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteExperimentTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTargetAccountConfiguration


        /// <summary>
        /// Deletes the specified target account configuration of the experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetAccountConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteTargetAccountConfiguration service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/DeleteTargetAccountConfiguration">REST API Reference for DeleteTargetAccountConfiguration Operation</seealso>
        public virtual DeleteTargetAccountConfigurationResponse DeleteTargetAccountConfiguration(DeleteTargetAccountConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTargetAccountConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTargetAccountConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteTargetAccountConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified target account configuration of the experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetAccountConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTargetAccountConfiguration service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/DeleteTargetAccountConfiguration">REST API Reference for DeleteTargetAccountConfiguration Operation</seealso>
        public virtual Task<DeleteTargetAccountConfigurationResponse> DeleteTargetAccountConfigurationAsync(DeleteTargetAccountConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTargetAccountConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTargetAccountConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTargetAccountConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAction


        /// <summary>
        /// Gets information about the specified FIS action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAction service method.</param>
        /// 
        /// <returns>The response from the GetAction service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetAction">REST API Reference for GetAction Operation</seealso>
        public virtual GetActionResponse GetAction(GetActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetActionResponseUnmarshaller.Instance;

            return Invoke<GetActionResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified FIS action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAction service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetAction">REST API Reference for GetAction Operation</seealso>
        public virtual Task<GetActionResponse> GetActionAsync(GetActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetExperiment


        /// <summary>
        /// Gets information about the specified experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExperiment service method.</param>
        /// 
        /// <returns>The response from the GetExperiment service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperiment">REST API Reference for GetExperiment Operation</seealso>
        public virtual GetExperimentResponse GetExperiment(GetExperimentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExperimentResponseUnmarshaller.Instance;

            return Invoke<GetExperimentResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExperiment service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperiment">REST API Reference for GetExperiment Operation</seealso>
        public virtual Task<GetExperimentResponse> GetExperimentAsync(GetExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExperimentResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetExperimentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetExperimentTargetAccountConfiguration


        /// <summary>
        /// Gets information about the specified target account configuration of the experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExperimentTargetAccountConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetExperimentTargetAccountConfiguration service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperimentTargetAccountConfiguration">REST API Reference for GetExperimentTargetAccountConfiguration Operation</seealso>
        public virtual GetExperimentTargetAccountConfigurationResponse GetExperimentTargetAccountConfiguration(GetExperimentTargetAccountConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExperimentTargetAccountConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExperimentTargetAccountConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetExperimentTargetAccountConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified target account configuration of the experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExperimentTargetAccountConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExperimentTargetAccountConfiguration service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperimentTargetAccountConfiguration">REST API Reference for GetExperimentTargetAccountConfiguration Operation</seealso>
        public virtual Task<GetExperimentTargetAccountConfigurationResponse> GetExperimentTargetAccountConfigurationAsync(GetExperimentTargetAccountConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExperimentTargetAccountConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExperimentTargetAccountConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetExperimentTargetAccountConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetExperimentTemplate


        /// <summary>
        /// Gets information about the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExperimentTemplate service method.</param>
        /// 
        /// <returns>The response from the GetExperimentTemplate service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperimentTemplate">REST API Reference for GetExperimentTemplate Operation</seealso>
        public virtual GetExperimentTemplateResponse GetExperimentTemplate(GetExperimentTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExperimentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExperimentTemplateResponseUnmarshaller.Instance;

            return Invoke<GetExperimentTemplateResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExperimentTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExperimentTemplate service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperimentTemplate">REST API Reference for GetExperimentTemplate Operation</seealso>
        public virtual Task<GetExperimentTemplateResponse> GetExperimentTemplateAsync(GetExperimentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExperimentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExperimentTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetExperimentTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSafetyLever


        /// <summary>
        /// Gets information about the specified safety lever.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSafetyLever service method.</param>
        /// 
        /// <returns>The response from the GetSafetyLever service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetSafetyLever">REST API Reference for GetSafetyLever Operation</seealso>
        public virtual GetSafetyLeverResponse GetSafetyLever(GetSafetyLeverRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSafetyLeverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSafetyLeverResponseUnmarshaller.Instance;

            return Invoke<GetSafetyLeverResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified safety lever.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSafetyLever service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSafetyLever service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetSafetyLever">REST API Reference for GetSafetyLever Operation</seealso>
        public virtual Task<GetSafetyLeverResponse> GetSafetyLeverAsync(GetSafetyLeverRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSafetyLeverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSafetyLeverResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSafetyLeverResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTargetAccountConfiguration


        /// <summary>
        /// Gets information about the specified target account configuration of the experiment
        /// template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTargetAccountConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetTargetAccountConfiguration service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetTargetAccountConfiguration">REST API Reference for GetTargetAccountConfiguration Operation</seealso>
        public virtual GetTargetAccountConfigurationResponse GetTargetAccountConfiguration(GetTargetAccountConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTargetAccountConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTargetAccountConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetTargetAccountConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified target account configuration of the experiment
        /// template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTargetAccountConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTargetAccountConfiguration service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetTargetAccountConfiguration">REST API Reference for GetTargetAccountConfiguration Operation</seealso>
        public virtual Task<GetTargetAccountConfigurationResponse> GetTargetAccountConfigurationAsync(GetTargetAccountConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTargetAccountConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTargetAccountConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTargetAccountConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTargetResourceType


        /// <summary>
        /// Gets information about the specified resource type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTargetResourceType service method.</param>
        /// 
        /// <returns>The response from the GetTargetResourceType service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetTargetResourceType">REST API Reference for GetTargetResourceType Operation</seealso>
        public virtual GetTargetResourceTypeResponse GetTargetResourceType(GetTargetResourceTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTargetResourceTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTargetResourceTypeResponseUnmarshaller.Instance;

            return Invoke<GetTargetResourceTypeResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the specified resource type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTargetResourceType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTargetResourceType service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetTargetResourceType">REST API Reference for GetTargetResourceType Operation</seealso>
        public virtual Task<GetTargetResourceTypeResponse> GetTargetResourceTypeAsync(GetTargetResourceTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTargetResourceTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTargetResourceTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTargetResourceTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListActions


        /// <summary>
        /// Lists the available FIS actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActions service method.</param>
        /// 
        /// <returns>The response from the ListActions service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListActions">REST API Reference for ListActions Operation</seealso>
        public virtual ListActionsResponse ListActions(ListActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActionsResponseUnmarshaller.Instance;

            return Invoke<ListActionsResponse>(request, options);
        }


        /// <summary>
        /// Lists the available FIS actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListActions service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListActions">REST API Reference for ListActions Operation</seealso>
        public virtual Task<ListActionsResponse> ListActionsAsync(ListActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListExperimentResolvedTargets


        /// <summary>
        /// Lists the resolved targets information of the specified experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentResolvedTargets service method.</param>
        /// 
        /// <returns>The response from the ListExperimentResolvedTargets service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperimentResolvedTargets">REST API Reference for ListExperimentResolvedTargets Operation</seealso>
        public virtual ListExperimentResolvedTargetsResponse ListExperimentResolvedTargets(ListExperimentResolvedTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExperimentResolvedTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentResolvedTargetsResponseUnmarshaller.Instance;

            return Invoke<ListExperimentResolvedTargetsResponse>(request, options);
        }


        /// <summary>
        /// Lists the resolved targets information of the specified experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentResolvedTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExperimentResolvedTargets service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperimentResolvedTargets">REST API Reference for ListExperimentResolvedTargets Operation</seealso>
        public virtual Task<ListExperimentResolvedTargetsResponse> ListExperimentResolvedTargetsAsync(ListExperimentResolvedTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExperimentResolvedTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentResolvedTargetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListExperimentResolvedTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListExperiments


        /// <summary>
        /// Lists your experiments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperiments service method.</param>
        /// 
        /// <returns>The response from the ListExperiments service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        public virtual ListExperimentsResponse ListExperiments(ListExperimentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExperimentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentsResponseUnmarshaller.Instance;

            return Invoke<ListExperimentsResponse>(request, options);
        }


        /// <summary>
        /// Lists your experiments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperiments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExperiments service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        public virtual Task<ListExperimentsResponse> ListExperimentsAsync(ListExperimentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExperimentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListExperimentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListExperimentTargetAccountConfigurations


        /// <summary>
        /// Lists the target account configurations of the specified experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentTargetAccountConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListExperimentTargetAccountConfigurations service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperimentTargetAccountConfigurations">REST API Reference for ListExperimentTargetAccountConfigurations Operation</seealso>
        public virtual ListExperimentTargetAccountConfigurationsResponse ListExperimentTargetAccountConfigurations(ListExperimentTargetAccountConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExperimentTargetAccountConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentTargetAccountConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListExperimentTargetAccountConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Lists the target account configurations of the specified experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentTargetAccountConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExperimentTargetAccountConfigurations service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperimentTargetAccountConfigurations">REST API Reference for ListExperimentTargetAccountConfigurations Operation</seealso>
        public virtual Task<ListExperimentTargetAccountConfigurationsResponse> ListExperimentTargetAccountConfigurationsAsync(ListExperimentTargetAccountConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExperimentTargetAccountConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentTargetAccountConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListExperimentTargetAccountConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListExperimentTemplates


        /// <summary>
        /// Lists your experiment templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentTemplates service method.</param>
        /// 
        /// <returns>The response from the ListExperimentTemplates service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperimentTemplates">REST API Reference for ListExperimentTemplates Operation</seealso>
        public virtual ListExperimentTemplatesResponse ListExperimentTemplates(ListExperimentTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExperimentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListExperimentTemplatesResponse>(request, options);
        }


        /// <summary>
        /// Lists your experiment templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExperimentTemplates service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperimentTemplates">REST API Reference for ListExperimentTemplates Operation</seealso>
        public virtual Task<ListExperimentTemplatesResponse> ListExperimentTemplatesAsync(ListExperimentTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExperimentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentTemplatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListExperimentTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTargetAccountConfigurations


        /// <summary>
        /// Lists the target account configurations of the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetAccountConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListTargetAccountConfigurations service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTargetAccountConfigurations">REST API Reference for ListTargetAccountConfigurations Operation</seealso>
        public virtual ListTargetAccountConfigurationsResponse ListTargetAccountConfigurations(ListTargetAccountConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTargetAccountConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetAccountConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListTargetAccountConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Lists the target account configurations of the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetAccountConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTargetAccountConfigurations service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTargetAccountConfigurations">REST API Reference for ListTargetAccountConfigurations Operation</seealso>
        public virtual Task<ListTargetAccountConfigurationsResponse> ListTargetAccountConfigurationsAsync(ListTargetAccountConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTargetAccountConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetAccountConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTargetAccountConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTargetResourceTypes


        /// <summary>
        /// Lists the target resource types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetResourceTypes service method.</param>
        /// 
        /// <returns>The response from the ListTargetResourceTypes service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTargetResourceTypes">REST API Reference for ListTargetResourceTypes Operation</seealso>
        public virtual ListTargetResourceTypesResponse ListTargetResourceTypes(ListTargetResourceTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTargetResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetResourceTypesResponseUnmarshaller.Instance;

            return Invoke<ListTargetResourceTypesResponse>(request, options);
        }


        /// <summary>
        /// Lists the target resource types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetResourceTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTargetResourceTypes service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTargetResourceTypes">REST API Reference for ListTargetResourceTypes Operation</seealso>
        public virtual Task<ListTargetResourceTypesResponse> ListTargetResourceTypesAsync(ListTargetResourceTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTargetResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetResourceTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTargetResourceTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartExperiment


        /// <summary>
        /// Starts running an experiment from the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExperiment service method.</param>
        /// 
        /// <returns>The response from the StartExperiment service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ConflictException">
        /// The request could not be processed because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/StartExperiment">REST API Reference for StartExperiment Operation</seealso>
        public virtual StartExperimentResponse StartExperiment(StartExperimentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExperimentResponseUnmarshaller.Instance;

            return Invoke<StartExperimentResponse>(request, options);
        }


        /// <summary>
        /// Starts running an experiment from the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartExperiment service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ConflictException">
        /// The request could not be processed because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/StartExperiment">REST API Reference for StartExperiment Operation</seealso>
        public virtual Task<StartExperimentResponse> StartExperimentAsync(StartExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExperimentResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartExperimentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopExperiment


        /// <summary>
        /// Stops the specified experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopExperiment service method.</param>
        /// 
        /// <returns>The response from the StopExperiment service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/StopExperiment">REST API Reference for StopExperiment Operation</seealso>
        public virtual StopExperimentResponse StopExperiment(StopExperimentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopExperimentResponseUnmarshaller.Instance;

            return Invoke<StopExperimentResponse>(request, options);
        }


        /// <summary>
        /// Stops the specified experiment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopExperiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopExperiment service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/StopExperiment">REST API Reference for StopExperiment Operation</seealso>
        public virtual Task<StopExperimentResponse> StopExperimentAsync(StopExperimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopExperimentResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopExperimentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Applies the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Applies the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateExperimentTemplate


        /// <summary>
        /// Updates the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperimentTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateExperimentTemplate service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UpdateExperimentTemplate">REST API Reference for UpdateExperimentTemplate Operation</seealso>
        public virtual UpdateExperimentTemplateResponse UpdateExperimentTemplate(UpdateExperimentTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExperimentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExperimentTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateExperimentTemplateResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperimentTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateExperimentTemplate service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UpdateExperimentTemplate">REST API Reference for UpdateExperimentTemplate Operation</seealso>
        public virtual Task<UpdateExperimentTemplateResponse> UpdateExperimentTemplateAsync(UpdateExperimentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExperimentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExperimentTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateExperimentTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSafetyLeverState


        /// <summary>
        /// Updates the specified safety lever state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSafetyLeverState service method.</param>
        /// 
        /// <returns>The response from the UpdateSafetyLeverState service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ConflictException">
        /// The request could not be processed because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UpdateSafetyLeverState">REST API Reference for UpdateSafetyLeverState Operation</seealso>
        public virtual UpdateSafetyLeverStateResponse UpdateSafetyLeverState(UpdateSafetyLeverStateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSafetyLeverStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSafetyLeverStateResponseUnmarshaller.Instance;

            return Invoke<UpdateSafetyLeverStateResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified safety lever state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSafetyLeverState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSafetyLeverState service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ConflictException">
        /// The request could not be processed because of a conflict.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UpdateSafetyLeverState">REST API Reference for UpdateSafetyLeverState Operation</seealso>
        public virtual Task<UpdateSafetyLeverStateResponse> UpdateSafetyLeverStateAsync(UpdateSafetyLeverStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSafetyLeverStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSafetyLeverStateResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSafetyLeverStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTargetAccountConfiguration


        /// <summary>
        /// Updates the target account configuration for the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTargetAccountConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateTargetAccountConfiguration service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UpdateTargetAccountConfiguration">REST API Reference for UpdateTargetAccountConfiguration Operation</seealso>
        public virtual UpdateTargetAccountConfigurationResponse UpdateTargetAccountConfiguration(UpdateTargetAccountConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTargetAccountConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTargetAccountConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateTargetAccountConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Updates the target account configuration for the specified experiment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTargetAccountConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTargetAccountConfiguration service method, as returned by FIS.</returns>
        /// <exception cref="Amazon.FIS.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.FIS.Model.ValidationException">
        /// The specified input is not valid, or fails to satisfy the constraints for the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UpdateTargetAccountConfiguration">REST API Reference for UpdateTargetAccountConfiguration Operation</seealso>
        public virtual Task<UpdateTargetAccountConfigurationResponse> UpdateTargetAccountConfigurationAsync(UpdateTargetAccountConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTargetAccountConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTargetAccountConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateTargetAccountConfigurationResponse>(request, options, cancellationToken);
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