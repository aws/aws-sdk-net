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
using System.Collections.Generic;
using System.Net;

using Amazon.FIS.Model;
using Amazon.FIS.Model.Internal.MarshallTransformations;
using Amazon.FIS.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
#endif
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFISConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFISConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonFISEndpointResolver());
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
        /// Initiates the asynchronous execution of the CreateExperimentTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExperimentTemplate operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExperimentTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/CreateExperimentTemplate">REST API Reference for CreateExperimentTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateExperimentTemplate(CreateExperimentTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExperimentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExperimentTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExperimentTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExperimentTemplate.</param>
        /// 
        /// <returns>Returns a  CreateExperimentTemplateResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/CreateExperimentTemplate">REST API Reference for CreateExperimentTemplate Operation</seealso>
        public virtual CreateExperimentTemplateResponse EndCreateExperimentTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateExperimentTemplateResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateTargetAccountConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetAccountConfiguration operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTargetAccountConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/CreateTargetAccountConfiguration">REST API Reference for CreateTargetAccountConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateTargetAccountConfiguration(CreateTargetAccountConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTargetAccountConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTargetAccountConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTargetAccountConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTargetAccountConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateTargetAccountConfigurationResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/CreateTargetAccountConfiguration">REST API Reference for CreateTargetAccountConfiguration Operation</seealso>
        public virtual CreateTargetAccountConfigurationResponse EndCreateTargetAccountConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTargetAccountConfigurationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteExperimentTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteExperimentTemplate operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteExperimentTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/DeleteExperimentTemplate">REST API Reference for DeleteExperimentTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteExperimentTemplate(DeleteExperimentTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteExperimentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExperimentTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteExperimentTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteExperimentTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteExperimentTemplateResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/DeleteExperimentTemplate">REST API Reference for DeleteExperimentTemplate Operation</seealso>
        public virtual DeleteExperimentTemplateResponse EndDeleteExperimentTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteExperimentTemplateResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteTargetAccountConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetAccountConfiguration operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTargetAccountConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/DeleteTargetAccountConfiguration">REST API Reference for DeleteTargetAccountConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteTargetAccountConfiguration(DeleteTargetAccountConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTargetAccountConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTargetAccountConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTargetAccountConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTargetAccountConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteTargetAccountConfigurationResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/DeleteTargetAccountConfiguration">REST API Reference for DeleteTargetAccountConfiguration Operation</seealso>
        public virtual DeleteTargetAccountConfigurationResponse EndDeleteTargetAccountConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTargetAccountConfigurationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAction operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetAction">REST API Reference for GetAction Operation</seealso>
        public virtual IAsyncResult BeginGetAction(GetActionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAction.</param>
        /// 
        /// <returns>Returns a  GetActionResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetAction">REST API Reference for GetAction Operation</seealso>
        public virtual GetActionResponse EndGetAction(IAsyncResult asyncResult)
        {
            return EndInvoke<GetActionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExperiment operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperiment">REST API Reference for GetExperiment Operation</seealso>
        public virtual IAsyncResult BeginGetExperiment(GetExperimentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExperimentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExperiment.</param>
        /// 
        /// <returns>Returns a  GetExperimentResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperiment">REST API Reference for GetExperiment Operation</seealso>
        public virtual GetExperimentResponse EndGetExperiment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetExperimentResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetExperimentTargetAccountConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExperimentTargetAccountConfiguration operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExperimentTargetAccountConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperimentTargetAccountConfiguration">REST API Reference for GetExperimentTargetAccountConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetExperimentTargetAccountConfiguration(GetExperimentTargetAccountConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExperimentTargetAccountConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExperimentTargetAccountConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetExperimentTargetAccountConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExperimentTargetAccountConfiguration.</param>
        /// 
        /// <returns>Returns a  GetExperimentTargetAccountConfigurationResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperimentTargetAccountConfiguration">REST API Reference for GetExperimentTargetAccountConfiguration Operation</seealso>
        public virtual GetExperimentTargetAccountConfigurationResponse EndGetExperimentTargetAccountConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetExperimentTargetAccountConfigurationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetExperimentTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExperimentTemplate operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExperimentTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperimentTemplate">REST API Reference for GetExperimentTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetExperimentTemplate(GetExperimentTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExperimentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExperimentTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetExperimentTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExperimentTemplate.</param>
        /// 
        /// <returns>Returns a  GetExperimentTemplateResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetExperimentTemplate">REST API Reference for GetExperimentTemplate Operation</seealso>
        public virtual GetExperimentTemplateResponse EndGetExperimentTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetExperimentTemplateResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetSafetyLever operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSafetyLever operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSafetyLever
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetSafetyLever">REST API Reference for GetSafetyLever Operation</seealso>
        public virtual IAsyncResult BeginGetSafetyLever(GetSafetyLeverRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSafetyLeverRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSafetyLeverResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSafetyLever operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSafetyLever.</param>
        /// 
        /// <returns>Returns a  GetSafetyLeverResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetSafetyLever">REST API Reference for GetSafetyLever Operation</seealso>
        public virtual GetSafetyLeverResponse EndGetSafetyLever(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSafetyLeverResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetTargetAccountConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTargetAccountConfiguration operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTargetAccountConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetTargetAccountConfiguration">REST API Reference for GetTargetAccountConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetTargetAccountConfiguration(GetTargetAccountConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTargetAccountConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTargetAccountConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTargetAccountConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTargetAccountConfiguration.</param>
        /// 
        /// <returns>Returns a  GetTargetAccountConfigurationResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetTargetAccountConfiguration">REST API Reference for GetTargetAccountConfiguration Operation</seealso>
        public virtual GetTargetAccountConfigurationResponse EndGetTargetAccountConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTargetAccountConfigurationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetTargetResourceType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTargetResourceType operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTargetResourceType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetTargetResourceType">REST API Reference for GetTargetResourceType Operation</seealso>
        public virtual IAsyncResult BeginGetTargetResourceType(GetTargetResourceTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTargetResourceTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTargetResourceTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTargetResourceType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTargetResourceType.</param>
        /// 
        /// <returns>Returns a  GetTargetResourceTypeResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/GetTargetResourceType">REST API Reference for GetTargetResourceType Operation</seealso>
        public virtual GetTargetResourceTypeResponse EndGetTargetResourceType(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTargetResourceTypeResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActions operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListActions">REST API Reference for ListActions Operation</seealso>
        public virtual IAsyncResult BeginListActions(ListActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListActions.</param>
        /// 
        /// <returns>Returns a  ListActionsResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListActions">REST API Reference for ListActions Operation</seealso>
        public virtual ListActionsResponse EndListActions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListActionsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListExperimentResolvedTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentResolvedTargets operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExperimentResolvedTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperimentResolvedTargets">REST API Reference for ListExperimentResolvedTargets Operation</seealso>
        public virtual IAsyncResult BeginListExperimentResolvedTargets(ListExperimentResolvedTargetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExperimentResolvedTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentResolvedTargetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListExperimentResolvedTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExperimentResolvedTargets.</param>
        /// 
        /// <returns>Returns a  ListExperimentResolvedTargetsResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperimentResolvedTargets">REST API Reference for ListExperimentResolvedTargets Operation</seealso>
        public virtual ListExperimentResolvedTargetsResponse EndListExperimentResolvedTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListExperimentResolvedTargetsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListExperiments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExperiments operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExperiments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        public virtual IAsyncResult BeginListExperiments(ListExperimentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExperimentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListExperiments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExperiments.</param>
        /// 
        /// <returns>Returns a  ListExperimentsResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperiments">REST API Reference for ListExperiments Operation</seealso>
        public virtual ListExperimentsResponse EndListExperiments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListExperimentsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListExperimentTargetAccountConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentTargetAccountConfigurations operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExperimentTargetAccountConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperimentTargetAccountConfigurations">REST API Reference for ListExperimentTargetAccountConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListExperimentTargetAccountConfigurations(ListExperimentTargetAccountConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExperimentTargetAccountConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentTargetAccountConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListExperimentTargetAccountConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExperimentTargetAccountConfigurations.</param>
        /// 
        /// <returns>Returns a  ListExperimentTargetAccountConfigurationsResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperimentTargetAccountConfigurations">REST API Reference for ListExperimentTargetAccountConfigurations Operation</seealso>
        public virtual ListExperimentTargetAccountConfigurationsResponse EndListExperimentTargetAccountConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListExperimentTargetAccountConfigurationsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListExperimentTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExperimentTemplates operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExperimentTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperimentTemplates">REST API Reference for ListExperimentTemplates Operation</seealso>
        public virtual IAsyncResult BeginListExperimentTemplates(ListExperimentTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExperimentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExperimentTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListExperimentTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExperimentTemplates.</param>
        /// 
        /// <returns>Returns a  ListExperimentTemplatesResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListExperimentTemplates">REST API Reference for ListExperimentTemplates Operation</seealso>
        public virtual ListExperimentTemplatesResponse EndListExperimentTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListExperimentTemplatesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListTargetAccountConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTargetAccountConfigurations operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTargetAccountConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTargetAccountConfigurations">REST API Reference for ListTargetAccountConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListTargetAccountConfigurations(ListTargetAccountConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTargetAccountConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetAccountConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTargetAccountConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTargetAccountConfigurations.</param>
        /// 
        /// <returns>Returns a  ListTargetAccountConfigurationsResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTargetAccountConfigurations">REST API Reference for ListTargetAccountConfigurations Operation</seealso>
        public virtual ListTargetAccountConfigurationsResponse EndListTargetAccountConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTargetAccountConfigurationsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListTargetResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTargetResourceTypes operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTargetResourceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTargetResourceTypes">REST API Reference for ListTargetResourceTypes Operation</seealso>
        public virtual IAsyncResult BeginListTargetResourceTypes(ListTargetResourceTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTargetResourceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetResourceTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTargetResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTargetResourceTypes.</param>
        /// 
        /// <returns>Returns a  ListTargetResourceTypesResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/ListTargetResourceTypes">REST API Reference for ListTargetResourceTypes Operation</seealso>
        public virtual ListTargetResourceTypesResponse EndListTargetResourceTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTargetResourceTypesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the StartExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartExperiment operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/StartExperiment">REST API Reference for StartExperiment Operation</seealso>
        public virtual IAsyncResult BeginStartExperiment(StartExperimentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExperimentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartExperiment.</param>
        /// 
        /// <returns>Returns a  StartExperimentResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/StartExperiment">REST API Reference for StartExperiment Operation</seealso>
        public virtual StartExperimentResponse EndStartExperiment(IAsyncResult asyncResult)
        {
            return EndInvoke<StartExperimentResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the StopExperiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopExperiment operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopExperiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/StopExperiment">REST API Reference for StopExperiment Operation</seealso>
        public virtual IAsyncResult BeginStopExperiment(StopExperimentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopExperimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopExperimentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopExperiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopExperiment.</param>
        /// 
        /// <returns>Returns a  StopExperimentResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/StopExperiment">REST API Reference for StopExperiment Operation</seealso>
        public virtual StopExperimentResponse EndStopExperiment(IAsyncResult asyncResult)
        {
            return EndInvoke<StopExperimentResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateExperimentTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateExperimentTemplate operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateExperimentTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UpdateExperimentTemplate">REST API Reference for UpdateExperimentTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdateExperimentTemplate(UpdateExperimentTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateExperimentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateExperimentTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateExperimentTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateExperimentTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateExperimentTemplateResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UpdateExperimentTemplate">REST API Reference for UpdateExperimentTemplate Operation</seealso>
        public virtual UpdateExperimentTemplateResponse EndUpdateExperimentTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateExperimentTemplateResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateSafetyLeverState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSafetyLeverState operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSafetyLeverState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UpdateSafetyLeverState">REST API Reference for UpdateSafetyLeverState Operation</seealso>
        public virtual IAsyncResult BeginUpdateSafetyLeverState(UpdateSafetyLeverStateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSafetyLeverStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSafetyLeverStateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSafetyLeverState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSafetyLeverState.</param>
        /// 
        /// <returns>Returns a  UpdateSafetyLeverStateResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UpdateSafetyLeverState">REST API Reference for UpdateSafetyLeverState Operation</seealso>
        public virtual UpdateSafetyLeverStateResponse EndUpdateSafetyLeverState(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSafetyLeverStateResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateTargetAccountConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTargetAccountConfiguration operation on AmazonFISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTargetAccountConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UpdateTargetAccountConfiguration">REST API Reference for UpdateTargetAccountConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateTargetAccountConfiguration(UpdateTargetAccountConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTargetAccountConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTargetAccountConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTargetAccountConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTargetAccountConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateTargetAccountConfigurationResult from FIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fis-2020-12-01/UpdateTargetAccountConfiguration">REST API Reference for UpdateTargetAccountConfiguration Operation</seealso>
        public virtual UpdateTargetAccountConfigurationResponse EndUpdateTargetAccountConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTargetAccountConfigurationResponse>(asyncResult);
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
            var resolver = new AmazonFISEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}