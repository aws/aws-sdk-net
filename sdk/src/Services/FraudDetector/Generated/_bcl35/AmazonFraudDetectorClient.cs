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
        /// Initiates the asynchronous execution of the BatchCreateVariable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateVariable operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateVariable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchCreateVariable">REST API Reference for BatchCreateVariable Operation</seealso>
        public virtual IAsyncResult BeginBatchCreateVariable(BatchCreateVariableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateVariableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateVariable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateVariable.</param>
        /// 
        /// <returns>Returns a  BatchCreateVariableResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchCreateVariable">REST API Reference for BatchCreateVariable Operation</seealso>
        public virtual BatchCreateVariableResponse EndBatchCreateVariable(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchCreateVariableResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the BatchGetVariable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetVariable operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetVariable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchGetVariable">REST API Reference for BatchGetVariable Operation</seealso>
        public virtual IAsyncResult BeginBatchGetVariable(BatchGetVariableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetVariableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetVariable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetVariable.</param>
        /// 
        /// <returns>Returns a  BatchGetVariableResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchGetVariable">REST API Reference for BatchGetVariable Operation</seealso>
        public virtual BatchGetVariableResponse EndBatchGetVariable(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetVariableResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDetectorVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDetectorVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateDetectorVersion">REST API Reference for CreateDetectorVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateDetectorVersion(CreateDetectorVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDetectorVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDetectorVersion.</param>
        /// 
        /// <returns>Returns a  CreateDetectorVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateDetectorVersion">REST API Reference for CreateDetectorVersion Operation</seealso>
        public virtual CreateDetectorVersionResponse EndCreateDetectorVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDetectorVersionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateModelVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModelVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModelVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateModelVersion">REST API Reference for CreateModelVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateModelVersion(CreateModelVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModelVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModelVersion.</param>
        /// 
        /// <returns>Returns a  CreateModelVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateModelVersion">REST API Reference for CreateModelVersion Operation</seealso>
        public virtual CreateModelVersionResponse EndCreateModelVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateModelVersionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRule operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual IAsyncResult BeginCreateRule(CreateRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRule.</param>
        /// 
        /// <returns>Returns a  CreateRuleResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual CreateRuleResponse EndCreateRule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRuleResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateVariable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVariable operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVariable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateVariable">REST API Reference for CreateVariable Operation</seealso>
        public virtual IAsyncResult BeginCreateVariable(CreateVariableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVariableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVariable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVariable.</param>
        /// 
        /// <returns>Returns a  CreateVariableResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateVariable">REST API Reference for CreateVariable Operation</seealso>
        public virtual CreateVariableResponse EndCreateVariable(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVariableResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDetectorVersion

        /// <summary>
        /// Deletes the detector version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetectorVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteDetectorVersion service method, as returned by FraudDetector.</returns>
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
        /// Initiates the asynchronous execution of the DeleteDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetectorVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDetectorVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteDetectorVersion">REST API Reference for DeleteDetectorVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteDetectorVersion(DeleteDetectorVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDetectorVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDetectorVersion.</param>
        /// 
        /// <returns>Returns a  DeleteDetectorVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteDetectorVersion">REST API Reference for DeleteDetectorVersion Operation</seealso>
        public virtual DeleteDetectorVersionResponse EndDeleteDetectorVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDetectorVersionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvent operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEvent">REST API Reference for DeleteEvent Operation</seealso>
        public virtual IAsyncResult BeginDeleteEvent(DeleteEventRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEvent.</param>
        /// 
        /// <returns>Returns a  DeleteEventResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEvent">REST API Reference for DeleteEvent Operation</seealso>
        public virtual DeleteEventResponse EndDeleteEvent(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetector operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        public virtual IAsyncResult BeginDescribeDetector(DescribeDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDetector.</param>
        /// 
        /// <returns>Returns a  DescribeDetectorResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        public virtual DescribeDetectorResponse EndDescribeDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDetectorResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeModelVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelVersions operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeModelVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeModelVersions">REST API Reference for DescribeModelVersions Operation</seealso>
        public virtual IAsyncResult BeginDescribeModelVersions(DescribeModelVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeModelVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeModelVersions.</param>
        /// 
        /// <returns>Returns a  DescribeModelVersionsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeModelVersions">REST API Reference for DescribeModelVersions Operation</seealso>
        public virtual DescribeModelVersionsResponse EndDescribeModelVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeModelVersionsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetDetectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDetectors operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDetectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectors">REST API Reference for GetDetectors Operation</seealso>
        public virtual IAsyncResult BeginGetDetectors(GetDetectorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDetectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDetectorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDetectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDetectors.</param>
        /// 
        /// <returns>Returns a  GetDetectorsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectors">REST API Reference for GetDetectors Operation</seealso>
        public virtual GetDetectorsResponse EndGetDetectors(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDetectorsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDetectorVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDetectorVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectorVersion">REST API Reference for GetDetectorVersion Operation</seealso>
        public virtual IAsyncResult BeginGetDetectorVersion(GetDetectorVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDetectorVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDetectorVersion.</param>
        /// 
        /// <returns>Returns a  GetDetectorVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectorVersion">REST API Reference for GetDetectorVersion Operation</seealso>
        public virtual GetDetectorVersionResponse EndGetDetectorVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDetectorVersionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetExternalModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExternalModels operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExternalModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetExternalModels">REST API Reference for GetExternalModels Operation</seealso>
        public virtual IAsyncResult BeginGetExternalModels(GetExternalModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExternalModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExternalModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetExternalModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExternalModels.</param>
        /// 
        /// <returns>Returns a  GetExternalModelsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetExternalModels">REST API Reference for GetExternalModels Operation</seealso>
        public virtual GetExternalModelsResponse EndGetExternalModels(IAsyncResult asyncResult)
        {
            return EndInvoke<GetExternalModelsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModels operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModels">REST API Reference for GetModels Operation</seealso>
        public virtual IAsyncResult BeginGetModels(GetModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModels.</param>
        /// 
        /// <returns>Returns a  GetModelsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModels">REST API Reference for GetModels Operation</seealso>
        public virtual GetModelsResponse EndGetModels(IAsyncResult asyncResult)
        {
            return EndInvoke<GetModelsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetModelVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModelVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModelVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModelVersion">REST API Reference for GetModelVersion Operation</seealso>
        public virtual IAsyncResult BeginGetModelVersion(GetModelVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModelVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModelVersion.</param>
        /// 
        /// <returns>Returns a  GetModelVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModelVersion">REST API Reference for GetModelVersion Operation</seealso>
        public virtual GetModelVersionResponse EndGetModelVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetModelVersionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetOutcomes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOutcomes operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOutcomes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetOutcomes">REST API Reference for GetOutcomes Operation</seealso>
        public virtual IAsyncResult BeginGetOutcomes(GetOutcomesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOutcomesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOutcomesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOutcomes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOutcomes.</param>
        /// 
        /// <returns>Returns a  GetOutcomesResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetOutcomes">REST API Reference for GetOutcomes Operation</seealso>
        public virtual GetOutcomesResponse EndGetOutcomes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOutcomesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetPrediction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPrediction operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPrediction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetPrediction">REST API Reference for GetPrediction Operation</seealso>
        public virtual IAsyncResult BeginGetPrediction(GetPredictionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPredictionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPredictionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPrediction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPrediction.</param>
        /// 
        /// <returns>Returns a  GetPredictionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetPrediction">REST API Reference for GetPrediction Operation</seealso>
        public virtual GetPredictionResponse EndGetPrediction(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPredictionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRules operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetRules">REST API Reference for GetRules Operation</seealso>
        public virtual IAsyncResult BeginGetRules(GetRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRules.</param>
        /// 
        /// <returns>Returns a  GetRulesResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetRules">REST API Reference for GetRules Operation</seealso>
        public virtual GetRulesResponse EndGetRules(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRulesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetVariables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVariables operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVariables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetVariables">REST API Reference for GetVariables Operation</seealso>
        public virtual IAsyncResult BeginGetVariables(GetVariablesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVariablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVariablesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVariables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVariables.</param>
        /// 
        /// <returns>Returns a  GetVariablesResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetVariables">REST API Reference for GetVariables Operation</seealso>
        public virtual GetVariablesResponse EndGetVariables(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVariablesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the PutDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDetector operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutDetector">REST API Reference for PutDetector Operation</seealso>
        public virtual IAsyncResult BeginPutDetector(PutDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDetector.</param>
        /// 
        /// <returns>Returns a  PutDetectorResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutDetector">REST API Reference for PutDetector Operation</seealso>
        public virtual PutDetectorResponse EndPutDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<PutDetectorResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the PutExternalModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutExternalModel operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutExternalModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutExternalModel">REST API Reference for PutExternalModel Operation</seealso>
        public virtual IAsyncResult BeginPutExternalModel(PutExternalModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutExternalModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutExternalModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutExternalModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutExternalModel.</param>
        /// 
        /// <returns>Returns a  PutExternalModelResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutExternalModel">REST API Reference for PutExternalModel Operation</seealso>
        public virtual PutExternalModelResponse EndPutExternalModel(IAsyncResult asyncResult)
        {
            return EndInvoke<PutExternalModelResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the PutModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutModel operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutModel">REST API Reference for PutModel Operation</seealso>
        public virtual IAsyncResult BeginPutModel(PutModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutModel.</param>
        /// 
        /// <returns>Returns a  PutModelResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutModel">REST API Reference for PutModel Operation</seealso>
        public virtual PutModelResponse EndPutModel(IAsyncResult asyncResult)
        {
            return EndInvoke<PutModelResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the PutOutcome operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutOutcome operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutOutcome
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutOutcome">REST API Reference for PutOutcome Operation</seealso>
        public virtual IAsyncResult BeginPutOutcome(PutOutcomeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutOutcomeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutOutcomeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutOutcome operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutOutcome.</param>
        /// 
        /// <returns>Returns a  PutOutcomeResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutOutcome">REST API Reference for PutOutcome Operation</seealso>
        public virtual PutOutcomeResponse EndPutOutcome(IAsyncResult asyncResult)
        {
            return EndInvoke<PutOutcomeResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDetectorVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersion">REST API Reference for UpdateDetectorVersion Operation</seealso>
        public virtual IAsyncResult BeginUpdateDetectorVersion(UpdateDetectorVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDetectorVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDetectorVersion.</param>
        /// 
        /// <returns>Returns a  UpdateDetectorVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersion">REST API Reference for UpdateDetectorVersion Operation</seealso>
        public virtual UpdateDetectorVersionResponse EndUpdateDetectorVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDetectorVersionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateDetectorVersionMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersionMetadata operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDetectorVersionMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionMetadata">REST API Reference for UpdateDetectorVersionMetadata Operation</seealso>
        public virtual IAsyncResult BeginUpdateDetectorVersionMetadata(UpdateDetectorVersionMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDetectorVersionMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorVersionMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDetectorVersionMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDetectorVersionMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateDetectorVersionMetadataResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionMetadata">REST API Reference for UpdateDetectorVersionMetadata Operation</seealso>
        public virtual UpdateDetectorVersionMetadataResponse EndUpdateDetectorVersionMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDetectorVersionMetadataResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateDetectorVersionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersionStatus operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDetectorVersionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionStatus">REST API Reference for UpdateDetectorVersionStatus Operation</seealso>
        public virtual IAsyncResult BeginUpdateDetectorVersionStatus(UpdateDetectorVersionStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDetectorVersionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDetectorVersionStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDetectorVersionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDetectorVersionStatus.</param>
        /// 
        /// <returns>Returns a  UpdateDetectorVersionStatusResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionStatus">REST API Reference for UpdateDetectorVersionStatus Operation</seealso>
        public virtual UpdateDetectorVersionStatusResponse EndUpdateDetectorVersionStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDetectorVersionStatusResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateModelVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateModelVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersion">REST API Reference for UpdateModelVersion Operation</seealso>
        public virtual IAsyncResult BeginUpdateModelVersion(UpdateModelVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateModelVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateModelVersion.</param>
        /// 
        /// <returns>Returns a  UpdateModelVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersion">REST API Reference for UpdateModelVersion Operation</seealso>
        public virtual UpdateModelVersionResponse EndUpdateModelVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateModelVersionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateRuleMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleMetadata operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRuleMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleMetadata">REST API Reference for UpdateRuleMetadata Operation</seealso>
        public virtual IAsyncResult BeginUpdateRuleMetadata(UpdateRuleMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRuleMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRuleMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateRuleMetadataResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleMetadata">REST API Reference for UpdateRuleMetadata Operation</seealso>
        public virtual UpdateRuleMetadataResponse EndUpdateRuleMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRuleMetadataResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateRuleVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRuleVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleVersion">REST API Reference for UpdateRuleVersion Operation</seealso>
        public virtual IAsyncResult BeginUpdateRuleVersion(UpdateRuleVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRuleVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRuleVersion.</param>
        /// 
        /// <returns>Returns a  UpdateRuleVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleVersion">REST API Reference for UpdateRuleVersion Operation</seealso>
        public virtual UpdateRuleVersionResponse EndUpdateRuleVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRuleVersionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateVariable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVariable operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVariable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateVariable">REST API Reference for UpdateVariable Operation</seealso>
        public virtual IAsyncResult BeginUpdateVariable(UpdateVariableRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVariableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVariableResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVariable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVariable.</param>
        /// 
        /// <returns>Returns a  UpdateVariableResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateVariable">REST API Reference for UpdateVariable Operation</seealso>
        public virtual UpdateVariableResponse EndUpdateVariable(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVariableResponse>(asyncResult);
        }

        #endregion
        
    }
}