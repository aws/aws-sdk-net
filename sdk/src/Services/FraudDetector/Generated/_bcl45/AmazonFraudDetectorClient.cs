/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        
        #region  CreateModelVersion


        /// <summary>
        /// Creates a version of the model using the specified model type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelVersion service method.</param>
        /// 
        /// <returns>The response from the CreateModelVersion service method, as returned by FraudDetector.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateModelVersion">REST API Reference for CreateModelVersion Operation</seealso>
        public virtual CreateModelVersionResponse CreateModelVersion(CreateModelVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelVersionResponseUnmarshaller.Instance;

            return Invoke<CreateModelVersionResponse>(request, options);
        }


        /// <summary>
        /// Creates a version of the model using the specified model type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelVersion service method, as returned by FraudDetector.</returns>
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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetector service method.</param>
        /// 
        /// <returns>The response from the DeleteDetector service method, as returned by FraudDetector.</returns>
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
        /// DeleteRuleVersion: A conflict exception will occur if the <code>RuleVersion</code>
        /// is in use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDetector service method, as returned by FraudDetector.</returns>
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
        /// DeleteRuleVersion: A conflict exception will occur if the <code>RuleVersion</code>
        /// is in use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetectorVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteDetectorVersion service method, as returned by FraudDetector.</returns>
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
        /// DeleteRuleVersion: A conflict exception will occur if the <code>RuleVersion</code>
        /// is in use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetectorVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDetectorVersion service method, as returned by FraudDetector.</returns>
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
        /// DeleteRuleVersion: A conflict exception will occur if the <code>RuleVersion</code>
        /// is in use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
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
        
        #region  DeleteEvent


        /// <summary>
        /// Deletes the specified event.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvent service method.</param>
        /// 
        /// <returns>The response from the DeleteEvent service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEvent service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
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
        
        #region  DeleteRuleVersion


        /// <summary>
        /// Deletes the rule version. You cannot delete a rule version if it is used by an <code>ACTIVE</code>
        /// or <code>INACTIVE</code> detector version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteRuleVersion service method, as returned by FraudDetector.</returns>
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
        /// DeleteRuleVersion: A conflict exception will occur if the <code>RuleVersion</code>
        /// is in use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteRuleVersion">REST API Reference for DeleteRuleVersion Operation</seealso>
        public virtual DeleteRuleVersionResponse DeleteRuleVersion(DeleteRuleVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleVersionResponse>(request, options);
        }


        /// <summary>
        /// Deletes the rule version. You cannot delete a rule version if it is used by an <code>ACTIVE</code>
        /// or <code>INACTIVE</code> detector version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRuleVersion service method, as returned by FraudDetector.</returns>
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
        /// DeleteRuleVersion: A conflict exception will occur if the <code>RuleVersion</code>
        /// is in use by an associated <code>ACTIVE</code> or <code>INACTIVE DetectorVersion</code>.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteRuleVersion">REST API Reference for DeleteRuleVersion Operation</seealso>
        public virtual Task<DeleteRuleVersionResponse> DeleteRuleVersionAsync(DeleteRuleVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRuleVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDetector


        /// <summary>
        /// Gets all versions for a specified detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetector service method.</param>
        /// 
        /// <returns>The response from the DescribeDetector service method, as returned by FraudDetector.</returns>
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
        /// Gets all of detectors. This is a paginated API. If you provide a null <code>maxSizePerPage</code>,
        /// this actions retrieves a maximum of 10 records per page. If you provide a <code>maxSizePerPage</code>,
        /// the value must be between 5 and 10. To get the next page results, provide the pagination
        /// token from the <code>GetEventTypesResponse</code> as part of your request. A null
        /// pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDetectors service method.</param>
        /// 
        /// <returns>The response from the GetDetectors service method, as returned by FraudDetector.</returns>
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
        /// Gets all of detectors. This is a paginated API. If you provide a null <code>maxSizePerPage</code>,
        /// this actions retrieves a maximum of 10 records per page. If you provide a <code>maxSizePerPage</code>,
        /// the value must be between 5 and 10. To get the next page results, provide the pagination
        /// token from the <code>GetEventTypesResponse</code> as part of your request. A null
        /// pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDetectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDetectors service method, as returned by FraudDetector.</returns>
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
        
        #region  GetExternalModels


        /// <summary>
        /// Gets the details for one or more Amazon SageMaker models that have been imported into
        /// the service. This is a paginated API. If you provide a null <code>maxSizePerPage</code>,
        /// this actions retrieves a maximum of 10 records per page. If you provide a <code>maxSizePerPage</code>,
        /// the value must be between 5 and 10. To get the next page results, provide the pagination
        /// token from the <code>GetExternalModelsResult</code> as part of your request. A null
        /// pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExternalModels service method.</param>
        /// 
        /// <returns>The response from the GetExternalModels service method, as returned by FraudDetector.</returns>
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
        /// the service. This is a paginated API. If you provide a null <code>maxSizePerPage</code>,
        /// this actions retrieves a maximum of 10 records per page. If you provide a <code>maxSizePerPage</code>,
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
        
        #region  GetModels


        /// <summary>
        /// Gets all of the models for the AWS account, or the specified model type, or gets a
        /// single model for the specified model type, model ID combination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModels service method.</param>
        /// 
        /// <returns>The response from the GetModels service method, as returned by FraudDetector.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModels">REST API Reference for GetModels Operation</seealso>
        public virtual GetModelsResponse GetModels(GetModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelsResponseUnmarshaller.Instance;

            return Invoke<GetModelsResponse>(request, options);
        }


        /// <summary>
        /// Gets all of the models for the AWS account, or the specified model type, or gets a
        /// single model for the specified model type, model ID combination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetModels service method, as returned by FraudDetector.</returns>
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
        /// Gets a model version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelVersion service method.</param>
        /// 
        /// <returns>The response from the GetModelVersion service method, as returned by FraudDetector.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModelVersion">REST API Reference for GetModelVersion Operation</seealso>
        public virtual GetModelVersionResponse GetModelVersion(GetModelVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelVersionResponseUnmarshaller.Instance;

            return Invoke<GetModelVersionResponse>(request, options);
        }


        /// <summary>
        /// Gets a model version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetModelVersion service method, as returned by FraudDetector.</returns>
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
        /// Gets one or more outcomes. This is a paginated API. If you provide a null <code>maxSizePerPage</code>,
        /// this actions retrieves a maximum of 10 records per page. If you provide a <code>maxSizePerPage</code>,
        /// the value must be between 50 and 100. To get the next page results, provide the pagination
        /// token from the <code>GetOutcomesResult</code> as part of your request. A null pagination
        /// token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutcomes service method.</param>
        /// 
        /// <returns>The response from the GetOutcomes service method, as returned by FraudDetector.</returns>
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
        /// Gets one or more outcomes. This is a paginated API. If you provide a null <code>maxSizePerPage</code>,
        /// this actions retrieves a maximum of 10 records per page. If you provide a <code>maxSizePerPage</code>,
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
        
        #region  GetPrediction


        /// <summary>
        /// Evaluates an event against a detector version. If a version ID is not provided, the
        /// detector’s (<code>ACTIVE</code>) version is used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPrediction service method.</param>
        /// 
        /// <returns>The response from the GetPrediction service method, as returned by FraudDetector.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetPrediction">REST API Reference for GetPrediction Operation</seealso>
        public virtual GetPredictionResponse GetPrediction(GetPredictionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPredictionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPredictionResponseUnmarshaller.Instance;

            return Invoke<GetPredictionResponse>(request, options);
        }


        /// <summary>
        /// Evaluates an event against a detector version. If a version ID is not provided, the
        /// detector’s (<code>ACTIVE</code>) version is used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPrediction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPrediction service method, as returned by FraudDetector.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetPrediction">REST API Reference for GetPrediction Operation</seealso>
        public virtual Task<GetPredictionResponse> GetPredictionAsync(GetPredictionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPredictionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPredictionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPredictionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRules


        /// <summary>
        /// Gets all rules available for the specified detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRules service method.</param>
        /// 
        /// <returns>The response from the GetRules service method, as returned by FraudDetector.</returns>
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
        /// Gets all rules available for the specified detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRules service method, as returned by FraudDetector.</returns>
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
        
        #region  PutDetector


        /// <summary>
        /// Creates or updates a detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDetector service method.</param>
        /// 
        /// <returns>The response from the PutDetector service method, as returned by FraudDetector.</returns>
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
        
        #region  PutExternalModel


        /// <summary>
        /// Creates or updates an Amazon SageMaker model endpoint. You can also use this action
        /// to update the configuration of the model endpoint, including the IAM role and/or the
        /// mapped variables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutExternalModel service method.</param>
        /// 
        /// <returns>The response from the PutExternalModel service method, as returned by FraudDetector.</returns>
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
        
        #region  PutModel


        /// <summary>
        /// Creates or updates a model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutModel service method.</param>
        /// 
        /// <returns>The response from the PutModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutModel">REST API Reference for PutModel Operation</seealso>
        public virtual PutModelResponse PutModel(PutModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutModelResponseUnmarshaller.Instance;

            return Invoke<PutModelResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates a model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutModel">REST API Reference for PutModel Operation</seealso>
        public virtual Task<PutModelResponse> PutModelAsync(PutModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutOutcome


        /// <summary>
        /// Creates or updates an outcome.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOutcome service method.</param>
        /// 
        /// <returns>The response from the PutOutcome service method, as returned by FraudDetector.</returns>
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
        
        #region  UpdateDetectorVersion


        /// <summary>
        /// Updates a detector version. The detector version attributes that you can update include
        /// models, external model endpoints, rules, and description. You can only update a <code>DRAFT</code>
        /// detector version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateDetectorVersion service method, as returned by FraudDetector.</returns>
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
        /// models, external model endpoints, rules, and description. You can only update a <code>DRAFT</code>
        /// detector version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDetectorVersion service method, as returned by FraudDetector.</returns>
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
        
        #region  UpdateModelVersion


        /// <summary>
        /// Updates a model version. You can update the description and status attributes using
        /// this action. You can perform the following status updates: 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// Change the <code>TRAINING_COMPLETE</code> status to <code>ACTIVE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change <code>ACTIVE</code> back to <code>TRAINING_COMPLETE</code> 
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateModelVersion service method, as returned by FraudDetector.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersion">REST API Reference for UpdateModelVersion Operation</seealso>
        public virtual UpdateModelVersionResponse UpdateModelVersion(UpdateModelVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateModelVersionResponse>(request, options);
        }


        /// <summary>
        /// Updates a model version. You can update the description and status attributes using
        /// this action. You can perform the following status updates: 
        /// 
        ///  <ol> <li> 
        /// <para>
        /// Change the <code>TRAINING_COMPLETE</code> status to <code>ACTIVE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change <code>ACTIVE</code> back to <code>TRAINING_COMPLETE</code> 
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateModelVersion service method, as returned by FraudDetector.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersion">REST API Reference for UpdateModelVersion Operation</seealso>
        public virtual Task<UpdateModelVersionResponse> UpdateModelVersionAsync(UpdateModelVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateModelVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRuleMetadata


        /// <summary>
        /// Updates a rule's metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateRuleMetadata service method, as returned by FraudDetector.</returns>
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
        /// Updates a rule's metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRuleMetadata service method, as returned by FraudDetector.</returns>
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
        /// Updates a rule version resulting in a new rule version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateRuleVersion service method, as returned by FraudDetector.</returns>
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
        /// Updates a rule version resulting in a new rule version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRuleVersion service method, as returned by FraudDetector.</returns>
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