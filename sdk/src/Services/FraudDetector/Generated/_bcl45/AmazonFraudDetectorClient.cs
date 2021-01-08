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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.FraudDetector.Model;
using Amazon.FraudDetector.Model.Internal.MarshallTransformations;
using Amazon.FraudDetector.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.FraudDetector
{
    /// <summary>
    /// Implementation for accessing FraudDetector
    ///
    /// This is the Amazon Fraud Detector API Reference. This guide is for developers who
    /// need detailed information about Amazon Fraud Detector API actions, data types, and
    /// errors. For more information about Amazon Fraud Detector features, see the <a href="https://docs.aws.amazon.com/frauddetector/latest/ug/">Amazon
    /// Fraud Detector User Guide</a>.
    /// </summary>
    public partial class AmazonFraudDetectorClient : AmazonServiceClient, IAmazonFraudDetector
    {
        private static IServiceMetadata serviceMetadata = new AmazonFraudDetectorMetadata();
        private IFraudDetectorPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IFraudDetectorPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new FraudDetectorPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with the credentials loaded from the application's
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
        public AmazonFraudDetectorClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFraudDetectorConfig()) { }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with the credentials loaded from the application's
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
        public AmazonFraudDetectorClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFraudDetectorConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonFraudDetectorClient Configuration Object</param>
        public AmazonFraudDetectorClient(AmazonFraudDetectorConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonFraudDetectorClient(AWSCredentials credentials)
            : this(credentials, new AmazonFraudDetectorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFraudDetectorClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonFraudDetectorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with AWS Credentials and an
        /// AmazonFraudDetectorClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonFraudDetectorClient Configuration Object</param>
        public AmazonFraudDetectorClient(AWSCredentials credentials, AmazonFraudDetectorConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonFraudDetectorClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFraudDetectorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFraudDetectorClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFraudDetectorConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFraudDetectorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonFraudDetectorClient Configuration Object</param>
        public AmazonFraudDetectorClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonFraudDetectorConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonFraudDetectorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFraudDetectorConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFraudDetectorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFraudDetectorConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFraudDetectorClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFraudDetectorClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonFraudDetectorClient Configuration Object</param>
        public AmazonFraudDetectorClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonFraudDetectorConfig clientConfig)
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


        #region  BatchCreateVariable


        /// <summary>
        /// Creates a batch of variables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateVariable service method.</param>
        /// 
        /// <returns>The response from the BatchCreateVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchCreateVariable">REST API Reference for BatchCreateVariable Operation</seealso>
        public virtual BatchCreateVariableResponse BatchCreateVariable(BatchCreateVariableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateVariableResponseUnmarshaller.Instance;

            return Invoke<BatchCreateVariableResponse>(request, options);
        }


        /// <summary>
        /// Creates a batch of variables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateVariable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchCreateVariable">REST API Reference for BatchCreateVariable Operation</seealso>
        public virtual Task<BatchCreateVariableResponse> BatchCreateVariableAsync(BatchCreateVariableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateVariableResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchCreateVariableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetVariable


        /// <summary>
        /// Gets a batch of variables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetVariable service method.</param>
        /// 
        /// <returns>The response from the BatchGetVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchGetVariable">REST API Reference for BatchGetVariable Operation</seealso>
        public virtual BatchGetVariableResponse BatchGetVariable(BatchGetVariableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetVariableResponseUnmarshaller.Instance;

            return Invoke<BatchGetVariableResponse>(request, options);
        }


        /// <summary>
        /// Gets a batch of variables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetVariable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchGetVariable">REST API Reference for BatchGetVariable Operation</seealso>
        public virtual Task<BatchGetVariableResponse> BatchGetVariableAsync(BatchGetVariableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetVariableResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetVariableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDetectorVersion


        /// <summary>
        /// Creates a detector version. The detector version starts in a <code>DRAFT</code> status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDetectorVersion service method.</param>
        /// 
        /// <returns>The response from the CreateDetectorVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateDetectorVersion">REST API Reference for CreateDetectorVersion Operation</seealso>
        public virtual CreateDetectorVersionResponse CreateDetectorVersion(CreateDetectorVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDetectorVersionResponseUnmarshaller.Instance;

            return Invoke<CreateDetectorVersionResponse>(request, options);
        }


        /// <summary>
        /// Creates a detector version. The detector version starts in a <code>DRAFT</code> status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDetectorVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDetectorVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateDetectorVersion">REST API Reference for CreateDetectorVersion Operation</seealso>
        public virtual Task<CreateDetectorVersionResponse> CreateDetectorVersionAsync(CreateDetectorVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDetectorVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDetectorVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateModel


        /// <summary>
        /// Creates a model using the specified model type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// 
        /// <returns>The response from the CreateModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual CreateModelResponse CreateModel(CreateModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return Invoke<CreateModelResponse>(request, options);
        }


        /// <summary>
        /// Creates a model using the specified model type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateModelVersion


        /// <summary>
        /// Creates a version of the model using the specified model type and model id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelVersion service method.</param>
        /// 
        /// <returns>The response from the CreateModelVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateModelVersion">REST API Reference for CreateModelVersion Operation</seealso>
        public virtual CreateModelVersionResponse CreateModelVersion(CreateModelVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelVersionResponseUnmarshaller.Instance;

            return Invoke<CreateModelVersionResponse>(request, options);
        }


        /// <summary>
        /// Creates a version of the model using the specified model type and model id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateModelVersion">REST API Reference for CreateModelVersion Operation</seealso>
        public virtual Task<CreateModelVersionResponse> CreateModelVersionAsync(CreateModelVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateModelVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRule


        /// <summary>
        /// Creates a rule for use with the specified detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return Invoke<CreateRuleResponse>(request, options);
        }


        /// <summary>
        /// Creates a rule for use with the specified detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVariable


        /// <summary>
        /// Creates a variable.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVariable service method.</param>
        /// 
        /// <returns>The response from the CreateVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateVariable">REST API Reference for CreateVariable Operation</seealso>
        public virtual CreateVariableResponse CreateVariable(CreateVariableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVariableResponseUnmarshaller.Instance;

            return Invoke<CreateVariableResponse>(request, options);
        }


        /// <summary>
        /// Creates a variable.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVariable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateVariable">REST API Reference for CreateVariable Operation</seealso>
        public virtual Task<CreateVariableResponse> CreateVariableAsync(CreateVariableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVariableResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateVariableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDetector


        /// <summary>
        /// Deletes the detector. Before deleting a detector, you must first delete all detector
        /// versions and rule versions associated with the detector.
        /// 
        ///  
        /// <para>
        /// When you delete a detector, Amazon Fraud Detector permanently deletes the detector
        /// and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetector service method.</param>
        /// 
        /// <returns>The response from the DeleteDetector service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteDetector">REST API Reference for DeleteDetector Operation</seealso>
        public virtual DeleteDetectorResponse DeleteDetector(DeleteDetectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDetectorResponseUnmarshaller.Instance;

            return Invoke<DeleteDetectorResponse>(request, options);
        }


        /// <summary>
        /// Deletes the detector. Before deleting a detector, you must first delete all detector
        /// versions and rule versions associated with the detector.
        /// 
        ///  
        /// <para>
        /// When you delete a detector, Amazon Fraud Detector permanently deletes the detector
        /// and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDetector service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteDetector">REST API Reference for DeleteDetector Operation</seealso>
        public virtual Task<DeleteDetectorResponse> DeleteDetectorAsync(DeleteDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDetectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDetectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDetectorVersion


        /// <summary>
        /// Deletes the detector version. You cannot delete detector versions that are in <code>ACTIVE</code>
        /// status.
        /// 
        ///  
        /// <para>
        /// When you delete a detector version, Amazon Fraud Detector permanently deletes the
        /// detector and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetectorVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteDetectorVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteDetectorVersion">REST API Reference for DeleteDetectorVersion Operation</seealso>
        public virtual DeleteDetectorVersionResponse DeleteDetectorVersion(DeleteDetectorVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDetectorVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteDetectorVersionResponse>(request, options);
        }


        /// <summary>
        /// Deletes the detector version. You cannot delete detector versions that are in <code>ACTIVE</code>
        /// status.
        /// 
        ///  
        /// <para>
        /// When you delete a detector version, Amazon Fraud Detector permanently deletes the
        /// detector and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetectorVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDetectorVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteDetectorVersion">REST API Reference for DeleteDetectorVersion Operation</seealso>
        public virtual Task<DeleteDetectorVersionResponse> DeleteDetectorVersionAsync(DeleteDetectorVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDetectorVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDetectorVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEntityType


        /// <summary>
        /// Deletes an entity type.
        /// 
        ///  
        /// <para>
        /// You cannot delete an entity type that is included in an event type.
        /// </para>
        ///  
        /// <para>
        /// When you delete an entity type, Amazon Fraud Detector permanently deletes that entity
        /// type from the evaluation history, and the data is no longer stored in Amazon Fraud
        /// Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEntityType service method.</param>
        /// 
        /// <returns>The response from the DeleteEntityType service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEntityType">REST API Reference for DeleteEntityType Operation</seealso>
        public virtual DeleteEntityTypeResponse DeleteEntityType(DeleteEntityTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEntityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEntityTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteEntityTypeResponse>(request, options);
        }


        /// <summary>
        /// Deletes an entity type.
        /// 
        ///  
        /// <para>
        /// You cannot delete an entity type that is included in an event type.
        /// </para>
        ///  
        /// <para>
        /// When you delete an entity type, Amazon Fraud Detector permanently deletes that entity
        /// type from the evaluation history, and the data is no longer stored in Amazon Fraud
        /// Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEntityType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEntityType service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEntityType">REST API Reference for DeleteEntityType Operation</seealso>
        public virtual Task<DeleteEntityTypeResponse> DeleteEntityTypeAsync(DeleteEntityTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEntityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEntityTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEntityTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEvent


        /// <summary>
        /// Deletes the specified event.
        /// 
        ///  
        /// <para>
        /// When you delete an event, Amazon Fraud Detector permanently deletes that event from
        /// the evaluation history, and the event data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvent service method.</param>
        /// 
        /// <returns>The response from the DeleteEvent service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEvent">REST API Reference for DeleteEvent Operation</seealso>
        public virtual DeleteEventResponse DeleteEvent(DeleteEventRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventResponseUnmarshaller.Instance;

            return Invoke<DeleteEventResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified event.
        /// 
        ///  
        /// <para>
        /// When you delete an event, Amazon Fraud Detector permanently deletes that event from
        /// the evaluation history, and the event data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEvent service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEvent">REST API Reference for DeleteEvent Operation</seealso>
        public virtual Task<DeleteEventResponse> DeleteEventAsync(DeleteEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEventResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEventType


        /// <summary>
        /// Deletes an event type.
        /// 
        ///  
        /// <para>
        /// You cannot delete an event type that is used in a detector or a model.
        /// </para>
        ///  
        /// <para>
        /// When you delete an entity type, Amazon Fraud Detector permanently deletes that entity
        /// type from the evaluation history, and the data is no longer stored in Amazon Fraud
        /// Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventType service method.</param>
        /// 
        /// <returns>The response from the DeleteEventType service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEventType">REST API Reference for DeleteEventType Operation</seealso>
        public virtual DeleteEventTypeResponse DeleteEventType(DeleteEventTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteEventTypeResponse>(request, options);
        }


        /// <summary>
        /// Deletes an event type.
        /// 
        ///  
        /// <para>
        /// You cannot delete an event type that is used in a detector or a model.
        /// </para>
        ///  
        /// <para>
        /// When you delete an entity type, Amazon Fraud Detector permanently deletes that entity
        /// type from the evaluation history, and the data is no longer stored in Amazon Fraud
        /// Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventType service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEventType">REST API Reference for DeleteEventType Operation</seealso>
        public virtual Task<DeleteEventTypeResponse> DeleteEventTypeAsync(DeleteEventTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEventTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteExternalModel


        /// <summary>
        /// Removes a SageMaker model from Amazon Fraud Detector.
        /// 
        ///  
        /// <para>
        /// You can remove an Amazon SageMaker model if it is not associated with a detector version.
        /// Removing a SageMaker model disconnects it from Amazon Fraud Detector, but the model
        /// remains available in SageMaker.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExternalModel service method.</param>
        /// 
        /// <returns>The response from the DeleteExternalModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteExternalModel">REST API Reference for DeleteExternalModel Operation</seealso>
        public virtual DeleteExternalModelResponse DeleteExternalModel(DeleteExternalModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteExternalModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExternalModelResponseUnmarshaller.Instance;

            return Invoke<DeleteExternalModelResponse>(request, options);
        }


        /// <summary>
        /// Removes a SageMaker model from Amazon Fraud Detector.
        /// 
        ///  
        /// <para>
        /// You can remove an Amazon SageMaker model if it is not associated with a detector version.
        /// Removing a SageMaker model disconnects it from Amazon Fraud Detector, but the model
        /// remains available in SageMaker.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExternalModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteExternalModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteExternalModel">REST API Reference for DeleteExternalModel Operation</seealso>
        public virtual Task<DeleteExternalModelResponse> DeleteExternalModelAsync(DeleteExternalModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteExternalModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteExternalModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteExternalModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLabel


        /// <summary>
        /// Deletes a label.
        /// 
        ///  
        /// <para>
        /// You cannot delete labels that are included in an event type in Amazon Fraud Detector.
        /// </para>
        ///  
        /// <para>
        /// You cannot delete a label assigned to an event ID. You must first delete the relevant
        /// event ID.
        /// </para>
        ///  
        /// <para>
        /// When you delete a label, Amazon Fraud Detector permanently deletes that label from
        /// the evaluation history, and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabel service method.</param>
        /// 
        /// <returns>The response from the DeleteLabel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteLabel">REST API Reference for DeleteLabel Operation</seealso>
        public virtual DeleteLabelResponse DeleteLabel(DeleteLabelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLabelResponseUnmarshaller.Instance;

            return Invoke<DeleteLabelResponse>(request, options);
        }


        /// <summary>
        /// Deletes a label.
        /// 
        ///  
        /// <para>
        /// You cannot delete labels that are included in an event type in Amazon Fraud Detector.
        /// </para>
        ///  
        /// <para>
        /// You cannot delete a label assigned to an event ID. You must first delete the relevant
        /// event ID.
        /// </para>
        ///  
        /// <para>
        /// When you delete a label, Amazon Fraud Detector permanently deletes that label from
        /// the evaluation history, and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLabel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteLabel">REST API Reference for DeleteLabel Operation</seealso>
        public virtual Task<DeleteLabelResponse> DeleteLabelAsync(DeleteLabelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLabelResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteLabelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteModel


        /// <summary>
        /// Deletes a model.
        /// 
        ///  
        /// <para>
        /// You can delete models and model versions in Amazon Fraud Detector, provided that they
        /// are not associated with a detector version.
        /// </para>
        ///  
        /// <para>
        ///  When you delete a model, Amazon Fraud Detector permanently deletes that model from
        /// the evaluation history, and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return Invoke<DeleteModelResponse>(request, options);
        }


        /// <summary>
        /// Deletes a model.
        /// 
        ///  
        /// <para>
        /// You can delete models and model versions in Amazon Fraud Detector, provided that they
        /// are not associated with a detector version.
        /// </para>
        ///  
        /// <para>
        ///  When you delete a model, Amazon Fraud Detector permanently deletes that model from
        /// the evaluation history, and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteModelVersion


        /// <summary>
        /// Deletes a model version.
        /// 
        ///  
        /// <para>
        /// You can delete models and model versions in Amazon Fraud Detector, provided that they
        /// are not associated with a detector version.
        /// </para>
        ///  
        /// <para>
        ///  When you delete a model version, Amazon Fraud Detector permanently deletes that model
        /// version from the evaluation history, and the data is no longer stored in Amazon Fraud
        /// Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteModelVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteModelVersion">REST API Reference for DeleteModelVersion Operation</seealso>
        public virtual DeleteModelVersionResponse DeleteModelVersion(DeleteModelVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteModelVersionResponse>(request, options);
        }


        /// <summary>
        /// Deletes a model version.
        /// 
        ///  
        /// <para>
        /// You can delete models and model versions in Amazon Fraud Detector, provided that they
        /// are not associated with a detector version.
        /// </para>
        ///  
        /// <para>
        ///  When you delete a model version, Amazon Fraud Detector permanently deletes that model
        /// version from the evaluation history, and the data is no longer stored in Amazon Fraud
        /// Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModelVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteModelVersion">REST API Reference for DeleteModelVersion Operation</seealso>
        public virtual Task<DeleteModelVersionResponse> DeleteModelVersionAsync(DeleteModelVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteModelVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteOutcome


        /// <summary>
        /// Deletes an outcome.
        /// 
        ///  
        /// <para>
        /// You cannot delete an outcome that is used in a rule version.
        /// </para>
        ///  
        /// <para>
        /// When you delete an outcome, Amazon Fraud Detector permanently deletes that outcome
        /// from the evaluation history, and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutcome service method.</param>
        /// 
        /// <returns>The response from the DeleteOutcome service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteOutcome">REST API Reference for DeleteOutcome Operation</seealso>
        public virtual DeleteOutcomeResponse DeleteOutcome(DeleteOutcomeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOutcomeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOutcomeResponseUnmarshaller.Instance;

            return Invoke<DeleteOutcomeResponse>(request, options);
        }


        /// <summary>
        /// Deletes an outcome.
        /// 
        ///  
        /// <para>
        /// You cannot delete an outcome that is used in a rule version.
        /// </para>
        ///  
        /// <para>
        /// When you delete an outcome, Amazon Fraud Detector permanently deletes that outcome
        /// from the evaluation history, and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutcome service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOutcome service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteOutcome">REST API Reference for DeleteOutcome Operation</seealso>
        public virtual Task<DeleteOutcomeResponse> DeleteOutcomeAsync(DeleteOutcomeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOutcomeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOutcomeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteOutcomeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRule


        /// <summary>
        /// Deletes the rule. You cannot delete a rule if it is used by an <code>ACTIVE</code>
        /// or <code>INACTIVE</code> detector version.
        /// 
        ///  
        /// <para>
        /// When you delete a rule, Amazon Fraud Detector permanently deletes that rule from the
        /// evaluation history, and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleResponse>(request, options);
        }


        /// <summary>
        /// Deletes the rule. You cannot delete a rule if it is used by an <code>ACTIVE</code>
        /// or <code>INACTIVE</code> detector version.
        /// 
        ///  
        /// <para>
        /// When you delete a rule, Amazon Fraud Detector permanently deletes that rule from the
        /// evaluation history, and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVariable


        /// <summary>
        /// Deletes a variable.
        /// 
        ///  
        /// <para>
        /// You can't delete variables that are included in an event type in Amazon Fraud Detector.
        /// </para>
        ///  
        /// <para>
        /// Amazon Fraud Detector automatically deletes model output variables and SageMaker model
        /// output variables when you delete the model. You can't delete these variables manually.
        /// </para>
        ///  
        /// <para>
        /// When you delete a variable, Amazon Fraud Detector permanently deletes that variable
        /// from the evaluation history, and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVariable service method.</param>
        /// 
        /// <returns>The response from the DeleteVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteVariable">REST API Reference for DeleteVariable Operation</seealso>
        public virtual DeleteVariableResponse DeleteVariable(DeleteVariableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVariableResponseUnmarshaller.Instance;

            return Invoke<DeleteVariableResponse>(request, options);
        }


        /// <summary>
        /// Deletes a variable.
        /// 
        ///  
        /// <para>
        /// You can't delete variables that are included in an event type in Amazon Fraud Detector.
        /// </para>
        ///  
        /// <para>
        /// Amazon Fraud Detector automatically deletes model output variables and SageMaker model
        /// output variables when you delete the model. You can't delete these variables manually.
        /// </para>
        ///  
        /// <para>
        /// When you delete a variable, Amazon Fraud Detector permanently deletes that variable
        /// from the evaluation history, and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVariable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteVariable">REST API Reference for DeleteVariable Operation</seealso>
        public virtual Task<DeleteVariableResponse> DeleteVariableAsync(DeleteVariableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVariableResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteVariableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDetector


        /// <summary>
        /// Gets all versions for a specified detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetector service method.</param>
        /// 
        /// <returns>The response from the DescribeDetector service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        public virtual DescribeDetectorResponse DescribeDetector(DescribeDetectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDetectorResponseUnmarshaller.Instance;

            return Invoke<DescribeDetectorResponse>(request, options);
        }


        /// <summary>
        /// Gets all versions for a specified detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDetector service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        public virtual Task<DescribeDetectorResponse> DescribeDetectorAsync(DescribeDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDetectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDetectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeModelVersions


        /// <summary>
        /// Gets all of the model versions for the specified model type or for the specified model
        /// type and model ID. You can also get details for a single, specified model version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeModelVersions service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeModelVersions">REST API Reference for DescribeModelVersions Operation</seealso>
        public virtual DescribeModelVersionsResponse DescribeModelVersions(DescribeModelVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeModelVersionsResponse>(request, options);
        }


        /// <summary>
        /// Gets all of the model versions for the specified model type or for the specified model
        /// type and model ID. You can also get details for a single, specified model version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModelVersions service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeModelVersions">REST API Reference for DescribeModelVersions Operation</seealso>
        public virtual Task<DescribeModelVersionsResponse> DescribeModelVersionsAsync(DescribeModelVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelVersionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeModelVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDetectors


        /// <summary>
        /// Gets all detectors or a single detector if a <code>detectorId</code> is specified.
        /// This is a paginated API. If you provide a null <code>maxResults</code>, this action
        /// retrieves a maximum of 10 records per page. If you provide a <code>maxResults</code>,
        /// the value must be between 5 and 10. To get the next page results, provide the pagination
        /// token from the <code>GetDetectorsResponse</code> as part of your request. A null pagination
        /// token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDetectors service method.</param>
        /// 
        /// <returns>The response from the GetDetectors service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectors">REST API Reference for GetDetectors Operation</seealso>
        public virtual GetDetectorsResponse GetDetectors(GetDetectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDetectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDetectorsResponseUnmarshaller.Instance;

            return Invoke<GetDetectorsResponse>(request, options);
        }


        /// <summary>
        /// Gets all detectors or a single detector if a <code>detectorId</code> is specified.
        /// This is a paginated API. If you provide a null <code>maxResults</code>, this action
        /// retrieves a maximum of 10 records per page. If you provide a <code>maxResults</code>,
        /// the value must be between 5 and 10. To get the next page results, provide the pagination
        /// token from the <code>GetDetectorsResponse</code> as part of your request. A null pagination
        /// token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDetectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDetectors service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectors">REST API Reference for GetDetectors Operation</seealso>
        public virtual Task<GetDetectorsResponse> GetDetectorsAsync(GetDetectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDetectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDetectorsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDetectorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDetectorVersion


        /// <summary>
        /// Gets a particular detector version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDetectorVersion service method.</param>
        /// 
        /// <returns>The response from the GetDetectorVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectorVersion">REST API Reference for GetDetectorVersion Operation</seealso>
        public virtual GetDetectorVersionResponse GetDetectorVersion(GetDetectorVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDetectorVersionResponseUnmarshaller.Instance;

            return Invoke<GetDetectorVersionResponse>(request, options);
        }


        /// <summary>
        /// Gets a particular detector version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDetectorVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDetectorVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectorVersion">REST API Reference for GetDetectorVersion Operation</seealso>
        public virtual Task<GetDetectorVersionResponse> GetDetectorVersionAsync(GetDetectorVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDetectorVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDetectorVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEntityTypes


        /// <summary>
        /// Gets all entity types or a specific entity type if a name is specified. This is a
        /// paginated API. If you provide a null <code>maxResults</code>, this action retrieves
        /// a maximum of 10 records per page. If you provide a <code>maxResults</code>, the value
        /// must be between 5 and 10. To get the next page results, provide the pagination token
        /// from the <code>GetEntityTypesResponse</code> as part of your request. A null pagination
        /// token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEntityTypes service method.</param>
        /// 
        /// <returns>The response from the GetEntityTypes service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEntityTypes">REST API Reference for GetEntityTypes Operation</seealso>
        public virtual GetEntityTypesResponse GetEntityTypes(GetEntityTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEntityTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEntityTypesResponseUnmarshaller.Instance;

            return Invoke<GetEntityTypesResponse>(request, options);
        }


        /// <summary>
        /// Gets all entity types or a specific entity type if a name is specified. This is a
        /// paginated API. If you provide a null <code>maxResults</code>, this action retrieves
        /// a maximum of 10 records per page. If you provide a <code>maxResults</code>, the value
        /// must be between 5 and 10. To get the next page results, provide the pagination token
        /// from the <code>GetEntityTypesResponse</code> as part of your request. A null pagination
        /// token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEntityTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEntityTypes service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEntityTypes">REST API Reference for GetEntityTypes Operation</seealso>
        public virtual Task<GetEntityTypesResponse> GetEntityTypesAsync(GetEntityTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEntityTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEntityTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEntityTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEventPrediction


        /// <summary>
        /// Evaluates an event against a detector version. If a version ID is not provided, the
        /// detector’s (<code>ACTIVE</code>) version is used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventPrediction service method.</param>
        /// 
        /// <returns>The response from the GetEventPrediction service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventPrediction">REST API Reference for GetEventPrediction Operation</seealso>
        public virtual GetEventPredictionResponse GetEventPrediction(GetEventPredictionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventPredictionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventPredictionResponseUnmarshaller.Instance;

            return Invoke<GetEventPredictionResponse>(request, options);
        }


        /// <summary>
        /// Evaluates an event against a detector version. If a version ID is not provided, the
        /// detector’s (<code>ACTIVE</code>) version is used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventPrediction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventPrediction service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation. The following
        /// delete operations can cause a conflict exception:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DeleteDetector: A conflict exception will occur if the detector has associated <code>Rules</code>
        /// or <code>DetectorVersions</code>. You can only delete a detector if it has no <code>Rules</code>
        /// or <code>DetectorVersions</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteDetectorVersion: A conflict exception will occur if the <code>DetectorVersion</code>
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DeleteRule: A conflict exception will occur if the <code>RuleVersion</code> is in
        /// use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventPrediction">REST API Reference for GetEventPrediction Operation</seealso>
        public virtual Task<GetEventPredictionResponse> GetEventPredictionAsync(GetEventPredictionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventPredictionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventPredictionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEventPredictionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEventTypes


        /// <summary>
        /// Gets all event types or a specific event type if name is provided. This is a paginated
        /// API. If you provide a null <code>maxResults</code>, this action retrieves a maximum
        /// of 10 records per page. If you provide a <code>maxResults</code>, the value must be
        /// between 5 and 10. To get the next page results, provide the pagination token from
        /// the <code>GetEventTypesResponse</code> as part of your request. A null pagination
        /// token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventTypes service method.</param>
        /// 
        /// <returns>The response from the GetEventTypes service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventTypes">REST API Reference for GetEventTypes Operation</seealso>
        public virtual GetEventTypesResponse GetEventTypes(GetEventTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventTypesResponseUnmarshaller.Instance;

            return Invoke<GetEventTypesResponse>(request, options);
        }


        /// <summary>
        /// Gets all event types or a specific event type if name is provided. This is a paginated
        /// API. If you provide a null <code>maxResults</code>, this action retrieves a maximum
        /// of 10 records per page. If you provide a <code>maxResults</code>, the value must be
        /// between 5 and 10. To get the next page results, provide the pagination token from
        /// the <code>GetEventTypesResponse</code> as part of your request. A null pagination
        /// token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventTypes service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventTypes">REST API Reference for GetEventTypes Operation</seealso>
        public virtual Task<GetEventTypesResponse> GetEventTypesAsync(GetEventTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEventTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetExternalModels


        /// <summary>
        /// Gets the details for one or more Amazon SageMaker models that have been imported into
        /// the service. This is a paginated API. If you provide a null <code>maxResults</code>,
        /// this actions retrieves a maximum of 10 records per page. If you provide a <code>maxResults</code>,
        /// the value must be between 5 and 10. To get the next page results, provide the pagination
        /// token from the <code>GetExternalModelsResult</code> as part of your request. A null
        /// pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExternalModels service method.</param>
        /// 
        /// <returns>The response from the GetExternalModels service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetExternalModels">REST API Reference for GetExternalModels Operation</seealso>
        public virtual GetExternalModelsResponse GetExternalModels(GetExternalModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExternalModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExternalModelsResponseUnmarshaller.Instance;

            return Invoke<GetExternalModelsResponse>(request, options);
        }


        /// <summary>
        /// Gets the details for one or more Amazon SageMaker models that have been imported into
        /// the service. This is a paginated API. If you provide a null <code>maxResults</code>,
        /// this actions retrieves a maximum of 10 records per page. If you provide a <code>maxResults</code>,
        /// the value must be between 5 and 10. To get the next page results, provide the pagination
        /// token from the <code>GetExternalModelsResult</code> as part of your request. A null
        /// pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExternalModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExternalModels service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetExternalModels">REST API Reference for GetExternalModels Operation</seealso>
        public virtual Task<GetExternalModelsResponse> GetExternalModelsAsync(GetExternalModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExternalModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExternalModelsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetExternalModelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetKMSEncryptionKey


        /// <summary>
        /// Gets the encryption key if a Key Management Service (KMS) customer master key (CMK)
        /// has been specified to be used to encrypt content in Amazon Fraud Detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKMSEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the GetKMSEncryptionKey service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetKMSEncryptionKey">REST API Reference for GetKMSEncryptionKey Operation</seealso>
        public virtual GetKMSEncryptionKeyResponse GetKMSEncryptionKey(GetKMSEncryptionKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKMSEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKMSEncryptionKeyResponseUnmarshaller.Instance;

            return Invoke<GetKMSEncryptionKeyResponse>(request, options);
        }


        /// <summary>
        /// Gets the encryption key if a Key Management Service (KMS) customer master key (CMK)
        /// has been specified to be used to encrypt content in Amazon Fraud Detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKMSEncryptionKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKMSEncryptionKey service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetKMSEncryptionKey">REST API Reference for GetKMSEncryptionKey Operation</seealso>
        public virtual Task<GetKMSEncryptionKeyResponse> GetKMSEncryptionKeyAsync(GetKMSEncryptionKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKMSEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKMSEncryptionKeyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetKMSEncryptionKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLabels


        /// <summary>
        /// Gets all labels or a specific label if name is provided. This is a paginated API.
        /// If you provide a null <code>maxResults</code>, this action retrieves a maximum of
        /// 50 records per page. If you provide a <code>maxResults</code>, the value must be between
        /// 10 and 50. To get the next page results, provide the pagination token from the <code>GetGetLabelsResponse</code>
        /// as part of your request. A null pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLabels service method.</param>
        /// 
        /// <returns>The response from the GetLabels service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetLabels">REST API Reference for GetLabels Operation</seealso>
        public virtual GetLabelsResponse GetLabels(GetLabelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLabelsResponseUnmarshaller.Instance;

            return Invoke<GetLabelsResponse>(request, options);
        }


        /// <summary>
        /// Gets all labels or a specific label if name is provided. This is a paginated API.
        /// If you provide a null <code>maxResults</code>, this action retrieves a maximum of
        /// 50 records per page. If you provide a <code>maxResults</code>, the value must be between
        /// 10 and 50. To get the next page results, provide the pagination token from the <code>GetGetLabelsResponse</code>
        /// as part of your request. A null pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLabels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLabels service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetLabels">REST API Reference for GetLabels Operation</seealso>
        public virtual Task<GetLabelsResponse> GetLabelsAsync(GetLabelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLabelsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLabelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetModels


        /// <summary>
        /// Gets one or more models. Gets all models for the AWS account if no model type and
        /// no model id provided. Gets all models for the AWS account and model type, if the model
        /// type is specified but model id is not provided. Gets a specific model if (model type,
        /// model id) tuple is specified. 
        /// 
        ///  
        /// <para>
        /// This is a paginated API. If you provide a null <code>maxResults</code>, this action
        /// retrieves a maximum of 10 records per page. If you provide a <code>maxResults</code>,
        /// the value must be between 1 and 10. To get the next page results, provide the pagination
        /// token from the response as part of your request. A null pagination token fetches the
        /// records from the beginning.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModels service method.</param>
        /// 
        /// <returns>The response from the GetModels service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModels">REST API Reference for GetModels Operation</seealso>
        public virtual GetModelsResponse GetModels(GetModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelsResponseUnmarshaller.Instance;

            return Invoke<GetModelsResponse>(request, options);
        }


        /// <summary>
        /// Gets one or more models. Gets all models for the AWS account if no model type and
        /// no model id provided. Gets all models for the AWS account and model type, if the model
        /// type is specified but model id is not provided. Gets a specific model if (model type,
        /// model id) tuple is specified. 
        /// 
        ///  
        /// <para>
        /// This is a paginated API. If you provide a null <code>maxResults</code>, this action
        /// retrieves a maximum of 10 records per page. If you provide a <code>maxResults</code>,
        /// the value must be between 1 and 10. To get the next page results, provide the pagination
        /// token from the response as part of your request. A null pagination token fetches the
        /// records from the beginning.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetModels service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModels">REST API Reference for GetModels Operation</seealso>
        public virtual Task<GetModelsResponse> GetModelsAsync(GetModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetModelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetModelVersion


        /// <summary>
        /// Gets the details of the specified model version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelVersion service method.</param>
        /// 
        /// <returns>The response from the GetModelVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModelVersion">REST API Reference for GetModelVersion Operation</seealso>
        public virtual GetModelVersionResponse GetModelVersion(GetModelVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelVersionResponseUnmarshaller.Instance;

            return Invoke<GetModelVersionResponse>(request, options);
        }


        /// <summary>
        /// Gets the details of the specified model version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetModelVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModelVersion">REST API Reference for GetModelVersion Operation</seealso>
        public virtual Task<GetModelVersionResponse> GetModelVersionAsync(GetModelVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetModelVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOutcomes


        /// <summary>
        /// Gets one or more outcomes. This is a paginated API. If you provide a null <code>maxResults</code>,
        /// this actions retrieves a maximum of 100 records per page. If you provide a <code>maxResults</code>,
        /// the value must be between 50 and 100. To get the next page results, provide the pagination
        /// token from the <code>GetOutcomesResult</code> as part of your request. A null pagination
        /// token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutcomes service method.</param>
        /// 
        /// <returns>The response from the GetOutcomes service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetOutcomes">REST API Reference for GetOutcomes Operation</seealso>
        public virtual GetOutcomesResponse GetOutcomes(GetOutcomesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOutcomesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutcomesResponseUnmarshaller.Instance;

            return Invoke<GetOutcomesResponse>(request, options);
        }


        /// <summary>
        /// Gets one or more outcomes. This is a paginated API. If you provide a null <code>maxResults</code>,
        /// this actions retrieves a maximum of 100 records per page. If you provide a <code>maxResults</code>,
        /// the value must be between 50 and 100. To get the next page results, provide the pagination
        /// token from the <code>GetOutcomesResult</code> as part of your request. A null pagination
        /// token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutcomes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOutcomes service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetOutcomes">REST API Reference for GetOutcomes Operation</seealso>
        public virtual Task<GetOutcomesResponse> GetOutcomesAsync(GetOutcomesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOutcomesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutcomesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOutcomesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRules


        /// <summary>
        /// Get all rules for a detector (paginated) if <code>ruleId</code> and <code>ruleVersion</code>
        /// are not specified. Gets all rules for the detector and the <code>ruleId</code> if
        /// present (paginated). Gets a specific rule if both the <code>ruleId</code> and the
        /// <code>ruleVersion</code> are specified.
        /// 
        ///  
        /// <para>
        /// This is a paginated API. Providing null maxResults results in retrieving maximum of
        /// 100 records per page. If you provide maxResults the value must be between 50 and 100.
        /// To get the next page result, a provide a pagination token from GetRulesResult as part
        /// of your request. Null pagination token fetches the records from the beginning.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRules service method.</param>
        /// 
        /// <returns>The response from the GetRules service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetRules">REST API Reference for GetRules Operation</seealso>
        public virtual GetRulesResponse GetRules(GetRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRulesResponseUnmarshaller.Instance;

            return Invoke<GetRulesResponse>(request, options);
        }


        /// <summary>
        /// Get all rules for a detector (paginated) if <code>ruleId</code> and <code>ruleVersion</code>
        /// are not specified. Gets all rules for the detector and the <code>ruleId</code> if
        /// present (paginated). Gets a specific rule if both the <code>ruleId</code> and the
        /// <code>ruleVersion</code> are specified.
        /// 
        ///  
        /// <para>
        /// This is a paginated API. Providing null maxResults results in retrieving maximum of
        /// 100 records per page. If you provide maxResults the value must be between 50 and 100.
        /// To get the next page result, a provide a pagination token from GetRulesResult as part
        /// of your request. Null pagination token fetches the records from the beginning.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRules service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetRules">REST API Reference for GetRules Operation</seealso>
        public virtual Task<GetRulesResponse> GetRulesAsync(GetRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRulesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVariables


        /// <summary>
        /// Gets all of the variables or the specific variable. This is a paginated API. Providing
        /// null <code>maxSizePerPage</code> results in retrieving maximum of 100 records per
        /// page. If you provide <code>maxSizePerPage</code> the value must be between 50 and
        /// 100. To get the next page result, a provide a pagination token from <code>GetVariablesResult</code>
        /// as part of your request. Null pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVariables service method.</param>
        /// 
        /// <returns>The response from the GetVariables service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetVariables">REST API Reference for GetVariables Operation</seealso>
        public virtual GetVariablesResponse GetVariables(GetVariablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVariablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVariablesResponseUnmarshaller.Instance;

            return Invoke<GetVariablesResponse>(request, options);
        }


        /// <summary>
        /// Gets all of the variables or the specific variable. This is a paginated API. Providing
        /// null <code>maxSizePerPage</code> results in retrieving maximum of 100 records per
        /// page. If you provide <code>maxSizePerPage</code> the value must be between 50 and
        /// 100. To get the next page result, a provide a pagination token from <code>GetVariablesResult</code>
        /// as part of your request. Null pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVariables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVariables service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetVariables">REST API Reference for GetVariables Operation</seealso>
        public virtual Task<GetVariablesResponse> GetVariablesAsync(GetVariablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVariablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVariablesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetVariablesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags associated with the resource. This is a paginated API. To get the next
        /// page results, provide the pagination token from the response as part of your request.
        /// A null pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists all tags associated with the resource. This is a paginated API. To get the next
        /// page results, provide the pagination token from the response as part of your request.
        /// A null pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutDetector


        /// <summary>
        /// Creates or updates a detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDetector service method.</param>
        /// 
        /// <returns>The response from the PutDetector service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutDetector">REST API Reference for PutDetector Operation</seealso>
        public virtual PutDetectorResponse PutDetector(PutDetectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDetectorResponseUnmarshaller.Instance;

            return Invoke<PutDetectorResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates a detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDetector service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutDetector">REST API Reference for PutDetector Operation</seealso>
        public virtual Task<PutDetectorResponse> PutDetectorAsync(PutDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDetectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutDetectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutEntityType


        /// <summary>
        /// Creates or updates an entity type. An entity represents who is performing the event.
        /// As part of a fraud prediction, you pass the entity ID to indicate the specific entity
        /// who performed the event. An entity type classifies the entity. Example classifications
        /// include customer, merchant, or account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEntityType service method.</param>
        /// 
        /// <returns>The response from the PutEntityType service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutEntityType">REST API Reference for PutEntityType Operation</seealso>
        public virtual PutEntityTypeResponse PutEntityType(PutEntityTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEntityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEntityTypeResponseUnmarshaller.Instance;

            return Invoke<PutEntityTypeResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates an entity type. An entity represents who is performing the event.
        /// As part of a fraud prediction, you pass the entity ID to indicate the specific entity
        /// who performed the event. An entity type classifies the entity. Example classifications
        /// include customer, merchant, or account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEntityType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEntityType service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutEntityType">REST API Reference for PutEntityType Operation</seealso>
        public virtual Task<PutEntityTypeResponse> PutEntityTypeAsync(PutEntityTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEntityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEntityTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutEntityTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutEventType


        /// <summary>
        /// Creates or updates an event type. An event is a business activity that is evaluated
        /// for fraud risk. With Amazon Fraud Detector, you generate fraud predictions for events.
        /// An event type defines the structure for an event sent to Amazon Fraud Detector. This
        /// includes the variables sent as part of the event, the entity performing the event
        /// (such as a customer), and the labels that classify the event. Example event types
        /// include online payment transactions, account registrations, and authentications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventType service method.</param>
        /// 
        /// <returns>The response from the PutEventType service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutEventType">REST API Reference for PutEventType Operation</seealso>
        public virtual PutEventTypeResponse PutEventType(PutEventTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventTypeResponseUnmarshaller.Instance;

            return Invoke<PutEventTypeResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates an event type. An event is a business activity that is evaluated
        /// for fraud risk. With Amazon Fraud Detector, you generate fraud predictions for events.
        /// An event type defines the structure for an event sent to Amazon Fraud Detector. This
        /// includes the variables sent as part of the event, the entity performing the event
        /// (such as a customer), and the labels that classify the event. Example event types
        /// include online payment transactions, account registrations, and authentications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEventType service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutEventType">REST API Reference for PutEventType Operation</seealso>
        public virtual Task<PutEventTypeResponse> PutEventTypeAsync(PutEventTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEventTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutEventTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutExternalModel


        /// <summary>
        /// Creates or updates an Amazon SageMaker model endpoint. You can also use this action
        /// to update the configuration of the model endpoint, including the IAM role and/or the
        /// mapped variables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutExternalModel service method.</param>
        /// 
        /// <returns>The response from the PutExternalModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutExternalModel">REST API Reference for PutExternalModel Operation</seealso>
        public virtual PutExternalModelResponse PutExternalModel(PutExternalModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutExternalModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutExternalModelResponseUnmarshaller.Instance;

            return Invoke<PutExternalModelResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates an Amazon SageMaker model endpoint. You can also use this action
        /// to update the configuration of the model endpoint, including the IAM role and/or the
        /// mapped variables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutExternalModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutExternalModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutExternalModel">REST API Reference for PutExternalModel Operation</seealso>
        public virtual Task<PutExternalModelResponse> PutExternalModelAsync(PutExternalModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutExternalModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutExternalModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutExternalModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutKMSEncryptionKey


        /// <summary>
        /// Specifies the Key Management Service (KMS) customer master key (CMK) to be used to
        /// encrypt content in Amazon Fraud Detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKMSEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the PutKMSEncryptionKey service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutKMSEncryptionKey">REST API Reference for PutKMSEncryptionKey Operation</seealso>
        public virtual PutKMSEncryptionKeyResponse PutKMSEncryptionKey(PutKMSEncryptionKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutKMSEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutKMSEncryptionKeyResponseUnmarshaller.Instance;

            return Invoke<PutKMSEncryptionKeyResponse>(request, options);
        }


        /// <summary>
        /// Specifies the Key Management Service (KMS) customer master key (CMK) to be used to
        /// encrypt content in Amazon Fraud Detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKMSEncryptionKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutKMSEncryptionKey service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutKMSEncryptionKey">REST API Reference for PutKMSEncryptionKey Operation</seealso>
        public virtual Task<PutKMSEncryptionKeyResponse> PutKMSEncryptionKeyAsync(PutKMSEncryptionKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutKMSEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutKMSEncryptionKeyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutKMSEncryptionKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutLabel


        /// <summary>
        /// Creates or updates label. A label classifies an event as fraudulent or legitimate.
        /// Labels are associated with event types and used to train supervised machine learning
        /// models in Amazon Fraud Detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLabel service method.</param>
        /// 
        /// <returns>The response from the PutLabel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutLabel">REST API Reference for PutLabel Operation</seealso>
        public virtual PutLabelResponse PutLabel(PutLabelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLabelResponseUnmarshaller.Instance;

            return Invoke<PutLabelResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates label. A label classifies an event as fraudulent or legitimate.
        /// Labels are associated with event types and used to train supervised machine learning
        /// models in Amazon Fraud Detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLabel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLabel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutLabel">REST API Reference for PutLabel Operation</seealso>
        public virtual Task<PutLabelResponse> PutLabelAsync(PutLabelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLabelResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutLabelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutOutcome


        /// <summary>
        /// Creates or updates an outcome.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOutcome service method.</param>
        /// 
        /// <returns>The response from the PutOutcome service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutOutcome">REST API Reference for PutOutcome Operation</seealso>
        public virtual PutOutcomeResponse PutOutcome(PutOutcomeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutOutcomeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutOutcomeResponseUnmarshaller.Instance;

            return Invoke<PutOutcomeResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates an outcome.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOutcome service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutOutcome service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutOutcome">REST API Reference for PutOutcome Operation</seealso>
        public virtual Task<PutOutcomeResponse> PutOutcomeAsync(PutOutcomeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutOutcomeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutOutcomeResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutOutcomeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Assigns tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDetectorVersion


        /// <summary>
        /// Updates a detector version. The detector version attributes that you can update include
        /// models, external model endpoints, rules, rule execution mode, and description. You
        /// can only update a <code>DRAFT</code> detector version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateDetectorVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersion">REST API Reference for UpdateDetectorVersion Operation</seealso>
        public virtual UpdateDetectorVersionResponse UpdateDetectorVersion(UpdateDetectorVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateDetectorVersionResponse>(request, options);
        }


        /// <summary>
        /// Updates a detector version. The detector version attributes that you can update include
        /// models, external model endpoints, rules, rule execution mode, and description. You
        /// can only update a <code>DRAFT</code> detector version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDetectorVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersion">REST API Reference for UpdateDetectorVersion Operation</seealso>
        public virtual Task<UpdateDetectorVersionResponse> UpdateDetectorVersionAsync(UpdateDetectorVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDetectorVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDetectorVersionMetadata


        /// <summary>
        /// Updates the detector version's description. You can update the metadata for any detector
        /// version (<code>DRAFT, ACTIVE,</code> or <code>INACTIVE</code>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersionMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateDetectorVersionMetadata service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionMetadata">REST API Reference for UpdateDetectorVersionMetadata Operation</seealso>
        public virtual UpdateDetectorVersionMetadataResponse UpdateDetectorVersionMetadata(UpdateDetectorVersionMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDetectorVersionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorVersionMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateDetectorVersionMetadataResponse>(request, options);
        }


        /// <summary>
        /// Updates the detector version's description. You can update the metadata for any detector
        /// version (<code>DRAFT, ACTIVE,</code> or <code>INACTIVE</code>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersionMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDetectorVersionMetadata service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionMetadata">REST API Reference for UpdateDetectorVersionMetadata Operation</seealso>
        public virtual Task<UpdateDetectorVersionMetadataResponse> UpdateDetectorVersionMetadataAsync(UpdateDetectorVersionMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDetectorVersionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorVersionMetadataResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDetectorVersionMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDetectorVersionStatus


        /// <summary>
        /// Updates the detector version’s status. You can perform the following promotions or
        /// demotions using <code>UpdateDetectorVersionStatus</code>: <code>DRAFT</code> to <code>ACTIVE</code>,
        /// <code>ACTIVE</code> to <code>INACTIVE</code>, and <code>INACTIVE</code> to <code>ACTIVE</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersionStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateDetectorVersionStatus service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionStatus">REST API Reference for UpdateDetectorVersionStatus Operation</seealso>
        public virtual UpdateDetectorVersionStatusResponse UpdateDetectorVersionStatus(UpdateDetectorVersionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDetectorVersionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorVersionStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateDetectorVersionStatusResponse>(request, options);
        }


        /// <summary>
        /// Updates the detector version’s status. You can perform the following promotions or
        /// demotions using <code>UpdateDetectorVersionStatus</code>: <code>DRAFT</code> to <code>ACTIVE</code>,
        /// <code>ACTIVE</code> to <code>INACTIVE</code>, and <code>INACTIVE</code> to <code>ACTIVE</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDetectorVersionStatus service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionStatus">REST API Reference for UpdateDetectorVersionStatus Operation</seealso>
        public virtual Task<UpdateDetectorVersionStatusResponse> UpdateDetectorVersionStatusAsync(UpdateDetectorVersionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDetectorVersionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorVersionStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDetectorVersionStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateModel


        /// <summary>
        /// Updates a model. You can update the description attribute using this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel service method.</param>
        /// 
        /// <returns>The response from the UpdateModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        public virtual UpdateModelResponse UpdateModel(UpdateModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return Invoke<UpdateModelResponse>(request, options);
        }


        /// <summary>
        /// Updates a model. You can update the description attribute using this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        public virtual Task<UpdateModelResponse> UpdateModelAsync(UpdateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateModelVersion


        /// <summary>
        /// Updates a model version. Updating a model version retrains an existing model version
        /// using updated training data and produces a new minor version of the model. You can
        /// update the training data set location and data access role attributes using this action.
        /// This action creates and trains a new minor version of the model, for example version
        /// 1.01, 1.02, 1.03.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateModelVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersion">REST API Reference for UpdateModelVersion Operation</seealso>
        public virtual UpdateModelVersionResponse UpdateModelVersion(UpdateModelVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateModelVersionResponse>(request, options);
        }


        /// <summary>
        /// Updates a model version. Updating a model version retrains an existing model version
        /// using updated training data and produces a new minor version of the model. You can
        /// update the training data set location and data access role attributes using this action.
        /// This action creates and trains a new minor version of the model, for example version
        /// 1.01, 1.02, 1.03.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateModelVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersion">REST API Reference for UpdateModelVersion Operation</seealso>
        public virtual Task<UpdateModelVersionResponse> UpdateModelVersionAsync(UpdateModelVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateModelVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateModelVersionStatus


        /// <summary>
        /// Updates the status of a model version.
        /// 
        ///  
        /// <para>
        /// You can perform the following status updates:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Change the <code>TRAINING_COMPLETE</code> status to <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change <code>ACTIVE</code>to <code>INACTIVE</code>.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelVersionStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateModelVersionStatus service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersionStatus">REST API Reference for UpdateModelVersionStatus Operation</seealso>
        public virtual UpdateModelVersionStatusResponse UpdateModelVersionStatus(UpdateModelVersionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelVersionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelVersionStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateModelVersionStatusResponse>(request, options);
        }


        /// <summary>
        /// Updates the status of a model version.
        /// 
        ///  
        /// <para>
        /// You can perform the following status updates:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Change the <code>TRAINING_COMPLETE</code> status to <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change <code>ACTIVE</code>to <code>INACTIVE</code>.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelVersionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateModelVersionStatus service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersionStatus">REST API Reference for UpdateModelVersionStatus Operation</seealso>
        public virtual Task<UpdateModelVersionStatusResponse> UpdateModelVersionStatusAsync(UpdateModelVersionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelVersionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelVersionStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateModelVersionStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRuleMetadata


        /// <summary>
        /// Updates a rule's metadata. The description attribute can be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateRuleMetadata service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleMetadata">REST API Reference for UpdateRuleMetadata Operation</seealso>
        public virtual UpdateRuleMetadataResponse UpdateRuleMetadata(UpdateRuleMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleMetadataResponse>(request, options);
        }


        /// <summary>
        /// Updates a rule's metadata. The description attribute can be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRuleMetadata service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleMetadata">REST API Reference for UpdateRuleMetadata Operation</seealso>
        public virtual Task<UpdateRuleMetadataResponse> UpdateRuleMetadataAsync(UpdateRuleMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleMetadataResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRuleMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRuleVersion


        /// <summary>
        /// Updates a rule version resulting in a new rule version. Updates a rule version resulting
        /// in a new rule version (version 1, 2, 3 ...).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateRuleVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleVersion">REST API Reference for UpdateRuleVersion Operation</seealso>
        public virtual UpdateRuleVersionResponse UpdateRuleVersion(UpdateRuleVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleVersionResponse>(request, options);
        }


        /// <summary>
        /// Updates a rule version resulting in a new rule version. Updates a rule version resulting
        /// in a new rule version (version 1, 2, 3 ...).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRuleVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleVersion">REST API Reference for UpdateRuleVersion Operation</seealso>
        public virtual Task<UpdateRuleVersionResponse> UpdateRuleVersionAsync(UpdateRuleVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRuleVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateVariable


        /// <summary>
        /// Updates a variable.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVariable service method.</param>
        /// 
        /// <returns>The response from the UpdateVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateVariable">REST API Reference for UpdateVariable Operation</seealso>
        public virtual UpdateVariableResponse UpdateVariable(UpdateVariableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVariableResponseUnmarshaller.Instance;

            return Invoke<UpdateVariableResponse>(request, options);
        }


        /// <summary>
        /// Updates a variable.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVariable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateVariable">REST API Reference for UpdateVariable Operation</seealso>
        public virtual Task<UpdateVariableResponse> UpdateVariableAsync(UpdateVariableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVariableResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateVariableResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}