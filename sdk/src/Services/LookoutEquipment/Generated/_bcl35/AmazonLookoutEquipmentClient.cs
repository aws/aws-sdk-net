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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.LookoutEquipment.Model;
using Amazon.LookoutEquipment.Model.Internal.MarshallTransformations;
using Amazon.LookoutEquipment.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.LookoutEquipment
{
    /// <summary>
    /// Implementation for accessing LookoutEquipment
    ///
    /// Amazon Lookout for Equipment is a machine learning service that uses advanced analytics
    /// to identify anomalies in machines from sensor data for use in predictive maintenance.
    /// </summary>
    public partial class AmazonLookoutEquipmentClient : AmazonServiceClient, IAmazonLookoutEquipment
    {
        private static IServiceMetadata serviceMetadata = new AmazonLookoutEquipmentMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ILookoutEquipmentPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ILookoutEquipmentPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new LookoutEquipmentPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with the credentials loaded from the application's
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
        public AmazonLookoutEquipmentClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLookoutEquipmentConfig()) { }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with the credentials loaded from the application's
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
        public AmazonLookoutEquipmentClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLookoutEquipmentConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLookoutEquipmentClient Configuration Object</param>
        public AmazonLookoutEquipmentClient(AmazonLookoutEquipmentConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLookoutEquipmentClient(AWSCredentials credentials)
            : this(credentials, new AmazonLookoutEquipmentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLookoutEquipmentClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLookoutEquipmentConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with AWS Credentials and an
        /// AmazonLookoutEquipmentClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLookoutEquipmentClient Configuration Object</param>
        public AmazonLookoutEquipmentClient(AWSCredentials credentials, AmazonLookoutEquipmentConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLookoutEquipmentClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLookoutEquipmentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLookoutEquipmentClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLookoutEquipmentConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLookoutEquipmentClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLookoutEquipmentClient Configuration Object</param>
        public AmazonLookoutEquipmentClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLookoutEquipmentConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLookoutEquipmentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLookoutEquipmentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLookoutEquipmentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLookoutEquipmentConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLookoutEquipmentClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLookoutEquipmentClient Configuration Object</param>
        public AmazonLookoutEquipmentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLookoutEquipmentConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLookoutEquipmentEndpointResolver());
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


        #region  CreateDataset

        /// <summary>
        /// Creates a container for a collection of data being ingested for analysis. The dataset
        /// contains the metadata describing where the data is and what the data actually looks
        /// like. In other words, it contains the location of the data source, the data schema,
        /// and other information. A dataset also contains any tags associated with the ingested
        /// data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ServiceQuotaExceededException">
        /// Resource limitations have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual CreateDatasetResponse CreateDataset(CreateDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual IAsyncResult BeginCreateDataset(CreateDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataset.</param>
        /// 
        /// <returns>Returns a  CreateDatasetResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual CreateDatasetResponse EndCreateDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInferenceScheduler

        /// <summary>
        /// Creates a scheduled inference. Scheduling an inference is setting up a continuous
        /// real-time inference plan to analyze new measurement data. When setting up the schedule,
        /// you provide an S3 bucket location for the input data, assign it a delimiter between
        /// separate entries in the data, set an offset delay if desired, and set the frequency
        /// of inferencing. You must also provide an S3 bucket location for the output data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInferenceScheduler service method.</param>
        /// 
        /// <returns>The response from the CreateInferenceScheduler service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ServiceQuotaExceededException">
        /// Resource limitations have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateInferenceScheduler">REST API Reference for CreateInferenceScheduler Operation</seealso>
        public virtual CreateInferenceSchedulerResponse CreateInferenceScheduler(CreateInferenceSchedulerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInferenceSchedulerResponseUnmarshaller.Instance;

            return Invoke<CreateInferenceSchedulerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInferenceScheduler operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInferenceScheduler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateInferenceScheduler">REST API Reference for CreateInferenceScheduler Operation</seealso>
        public virtual IAsyncResult BeginCreateInferenceScheduler(CreateInferenceSchedulerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInferenceSchedulerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInferenceScheduler.</param>
        /// 
        /// <returns>Returns a  CreateInferenceSchedulerResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateInferenceScheduler">REST API Reference for CreateInferenceScheduler Operation</seealso>
        public virtual CreateInferenceSchedulerResponse EndCreateInferenceScheduler(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInferenceSchedulerResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLabel

        /// <summary>
        /// Creates a label for an event.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLabel service method.</param>
        /// 
        /// <returns>The response from the CreateLabel service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ServiceQuotaExceededException">
        /// Resource limitations have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateLabel">REST API Reference for CreateLabel Operation</seealso>
        public virtual CreateLabelResponse CreateLabel(CreateLabelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLabelResponseUnmarshaller.Instance;

            return Invoke<CreateLabelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLabel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLabel operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLabel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateLabel">REST API Reference for CreateLabel Operation</seealso>
        public virtual IAsyncResult BeginCreateLabel(CreateLabelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLabelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLabel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLabel.</param>
        /// 
        /// <returns>Returns a  CreateLabelResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateLabel">REST API Reference for CreateLabel Operation</seealso>
        public virtual CreateLabelResponse EndCreateLabel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLabelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLabelGroup

        /// <summary>
        /// Creates a group of labels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLabelGroup service method.</param>
        /// 
        /// <returns>The response from the CreateLabelGroup service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ServiceQuotaExceededException">
        /// Resource limitations have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateLabelGroup">REST API Reference for CreateLabelGroup Operation</seealso>
        public virtual CreateLabelGroupResponse CreateLabelGroup(CreateLabelGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLabelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLabelGroupResponseUnmarshaller.Instance;

            return Invoke<CreateLabelGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLabelGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLabelGroup operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLabelGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateLabelGroup">REST API Reference for CreateLabelGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateLabelGroup(CreateLabelGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLabelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLabelGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLabelGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLabelGroup.</param>
        /// 
        /// <returns>Returns a  CreateLabelGroupResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateLabelGroup">REST API Reference for CreateLabelGroup Operation</seealso>
        public virtual CreateLabelGroupResponse EndCreateLabelGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLabelGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateModel

        /// <summary>
        /// Creates an ML model for data inference. 
        /// 
        ///  
        /// <para>
        /// A machine-learning (ML) model is a mathematical model that finds patterns in your
        /// data. In Amazon Lookout for Equipment, the model learns the patterns of normal behavior
        /// and detects abnormal behavior that could be potential equipment failure (or maintenance
        /// events). The models are made by analyzing normal data and abnormalities in machine
        /// behavior that have already occurred.
        /// </para>
        ///  
        /// <para>
        /// Your model is trained using a portion of the data from your dataset and uses that
        /// data to learn patterns of normal behavior and abnormal patterns that lead to equipment
        /// failure. Another portion of the data is used to evaluate the model's accuracy. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// 
        /// <returns>The response from the CreateModel service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ServiceQuotaExceededException">
        /// Resource limitations have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual CreateModelResponse CreateModel(CreateModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return Invoke<CreateModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModel operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual IAsyncResult BeginCreateModel(CreateModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModel.</param>
        /// 
        /// <returns>Returns a  CreateModelResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual CreateModelResponse EndCreateModel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataset

        /// <summary>
        /// Deletes a dataset and associated artifacts. The operation will check to see if any
        /// inference scheduler or data ingestion job is currently using the dataset, and if there
        /// isn't, the dataset, its metadata, and any associated data stored in S3 will be deleted.
        /// This does not affect any models that used this dataset for training and evaluation,
        /// but does prevent it from being used in the future.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataset(DeleteDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataset.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual DeleteDatasetResponse EndDeleteDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInferenceScheduler

        /// <summary>
        /// Deletes an inference scheduler that has been set up. Already processed output results
        /// are not affected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInferenceScheduler service method.</param>
        /// 
        /// <returns>The response from the DeleteInferenceScheduler service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteInferenceScheduler">REST API Reference for DeleteInferenceScheduler Operation</seealso>
        public virtual DeleteInferenceSchedulerResponse DeleteInferenceScheduler(DeleteInferenceSchedulerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInferenceSchedulerResponseUnmarshaller.Instance;

            return Invoke<DeleteInferenceSchedulerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInferenceScheduler operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInferenceScheduler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteInferenceScheduler">REST API Reference for DeleteInferenceScheduler Operation</seealso>
        public virtual IAsyncResult BeginDeleteInferenceScheduler(DeleteInferenceSchedulerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInferenceSchedulerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInferenceScheduler.</param>
        /// 
        /// <returns>Returns a  DeleteInferenceSchedulerResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteInferenceScheduler">REST API Reference for DeleteInferenceScheduler Operation</seealso>
        public virtual DeleteInferenceSchedulerResponse EndDeleteInferenceScheduler(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInferenceSchedulerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLabel

        /// <summary>
        /// Deletes a label.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabel service method.</param>
        /// 
        /// <returns>The response from the DeleteLabel service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteLabel">REST API Reference for DeleteLabel Operation</seealso>
        public virtual DeleteLabelResponse DeleteLabel(DeleteLabelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLabelResponseUnmarshaller.Instance;

            return Invoke<DeleteLabelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLabel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabel operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLabel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteLabel">REST API Reference for DeleteLabel Operation</seealso>
        public virtual IAsyncResult BeginDeleteLabel(DeleteLabelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLabelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLabel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLabel.</param>
        /// 
        /// <returns>Returns a  DeleteLabelResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteLabel">REST API Reference for DeleteLabel Operation</seealso>
        public virtual DeleteLabelResponse EndDeleteLabel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLabelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLabelGroup

        /// <summary>
        /// Deletes a group of labels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabelGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteLabelGroup service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteLabelGroup">REST API Reference for DeleteLabelGroup Operation</seealso>
        public virtual DeleteLabelGroupResponse DeleteLabelGroup(DeleteLabelGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLabelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLabelGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteLabelGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLabelGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabelGroup operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLabelGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteLabelGroup">REST API Reference for DeleteLabelGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteLabelGroup(DeleteLabelGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLabelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLabelGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLabelGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLabelGroup.</param>
        /// 
        /// <returns>Returns a  DeleteLabelGroupResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteLabelGroup">REST API Reference for DeleteLabelGroup Operation</seealso>
        public virtual DeleteLabelGroupResponse EndDeleteLabelGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLabelGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteModel

        /// <summary>
        /// Deletes an ML model currently available for Amazon Lookout for Equipment. This will
        /// prevent it from being used with an inference scheduler, even one that is already set
        /// up.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return Invoke<DeleteModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual IAsyncResult BeginDeleteModel(DeleteModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModel.</param>
        /// 
        /// <returns>Returns a  DeleteModelResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual DeleteModelResponse EndDeleteModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDataIngestionJob

        /// <summary>
        /// Provides information on a specific data ingestion job such as creation time, dataset
        /// ARN, and status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataIngestionJob service method.</param>
        /// 
        /// <returns>The response from the DescribeDataIngestionJob service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeDataIngestionJob">REST API Reference for DescribeDataIngestionJob Operation</seealso>
        public virtual DescribeDataIngestionJobResponse DescribeDataIngestionJob(DescribeDataIngestionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataIngestionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataIngestionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDataIngestionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataIngestionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataIngestionJob operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataIngestionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeDataIngestionJob">REST API Reference for DescribeDataIngestionJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeDataIngestionJob(DescribeDataIngestionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDataIngestionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataIngestionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataIngestionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataIngestionJob.</param>
        /// 
        /// <returns>Returns a  DescribeDataIngestionJobResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeDataIngestionJob">REST API Reference for DescribeDataIngestionJob Operation</seealso>
        public virtual DescribeDataIngestionJobResponse EndDescribeDataIngestionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDataIngestionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDataset

        /// <summary>
        /// Provides a JSON description of the data in each time series dataset, including names,
        /// column names, and data types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual IAsyncResult BeginDescribeDataset(DescribeDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataset.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual DescribeDatasetResponse EndDescribeDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInferenceScheduler

        /// <summary>
        /// Specifies information about the inference scheduler being used, including name, model,
        /// status, and associated metadata
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInferenceScheduler service method.</param>
        /// 
        /// <returns>The response from the DescribeInferenceScheduler service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeInferenceScheduler">REST API Reference for DescribeInferenceScheduler Operation</seealso>
        public virtual DescribeInferenceSchedulerResponse DescribeInferenceScheduler(DescribeInferenceSchedulerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInferenceSchedulerResponseUnmarshaller.Instance;

            return Invoke<DescribeInferenceSchedulerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInferenceScheduler operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInferenceScheduler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeInferenceScheduler">REST API Reference for DescribeInferenceScheduler Operation</seealso>
        public virtual IAsyncResult BeginDescribeInferenceScheduler(DescribeInferenceSchedulerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInferenceSchedulerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInferenceScheduler.</param>
        /// 
        /// <returns>Returns a  DescribeInferenceSchedulerResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeInferenceScheduler">REST API Reference for DescribeInferenceScheduler Operation</seealso>
        public virtual DescribeInferenceSchedulerResponse EndDescribeInferenceScheduler(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInferenceSchedulerResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLabel

        /// <summary>
        /// Returns the name of the label.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLabel service method.</param>
        /// 
        /// <returns>The response from the DescribeLabel service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeLabel">REST API Reference for DescribeLabel Operation</seealso>
        public virtual DescribeLabelResponse DescribeLabel(DescribeLabelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLabelResponseUnmarshaller.Instance;

            return Invoke<DescribeLabelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLabel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLabel operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLabel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeLabel">REST API Reference for DescribeLabel Operation</seealso>
        public virtual IAsyncResult BeginDescribeLabel(DescribeLabelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLabelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLabel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLabel.</param>
        /// 
        /// <returns>Returns a  DescribeLabelResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeLabel">REST API Reference for DescribeLabel Operation</seealso>
        public virtual DescribeLabelResponse EndDescribeLabel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLabelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLabelGroup

        /// <summary>
        /// Returns information about the label group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLabelGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeLabelGroup service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeLabelGroup">REST API Reference for DescribeLabelGroup Operation</seealso>
        public virtual DescribeLabelGroupResponse DescribeLabelGroup(DescribeLabelGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLabelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLabelGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeLabelGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLabelGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLabelGroup operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLabelGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeLabelGroup">REST API Reference for DescribeLabelGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeLabelGroup(DescribeLabelGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLabelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLabelGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLabelGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLabelGroup.</param>
        /// 
        /// <returns>Returns a  DescribeLabelGroupResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeLabelGroup">REST API Reference for DescribeLabelGroup Operation</seealso>
        public virtual DescribeLabelGroupResponse EndDescribeLabelGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLabelGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeModel

        /// <summary>
        /// Provides a JSON containing the overall information about a specific ML model, including
        /// model name and ARN, dataset, training and evaluation information, status, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel service method.</param>
        /// 
        /// <returns>The response from the DescribeModel service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        public virtual DescribeModelResponse DescribeModel(DescribeModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelResponseUnmarshaller.Instance;

            return Invoke<DescribeModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        public virtual IAsyncResult BeginDescribeModel(DescribeModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeModel.</param>
        /// 
        /// <returns>Returns a  DescribeModelResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        public virtual DescribeModelResponse EndDescribeModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeModelResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataIngestionJobs

        /// <summary>
        /// Provides a list of all data ingestion jobs, including dataset name and ARN, S3 location
        /// of the input data, status, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIngestionJobs service method.</param>
        /// 
        /// <returns>The response from the ListDataIngestionJobs service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListDataIngestionJobs">REST API Reference for ListDataIngestionJobs Operation</seealso>
        public virtual ListDataIngestionJobsResponse ListDataIngestionJobs(ListDataIngestionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataIngestionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataIngestionJobsResponseUnmarshaller.Instance;

            return Invoke<ListDataIngestionJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataIngestionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataIngestionJobs operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataIngestionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListDataIngestionJobs">REST API Reference for ListDataIngestionJobs Operation</seealso>
        public virtual IAsyncResult BeginListDataIngestionJobs(ListDataIngestionJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataIngestionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataIngestionJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataIngestionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataIngestionJobs.</param>
        /// 
        /// <returns>Returns a  ListDataIngestionJobsResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListDataIngestionJobs">REST API Reference for ListDataIngestionJobs Operation</seealso>
        public virtual ListDataIngestionJobsResponse EndListDataIngestionJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataIngestionJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDatasets

        /// <summary>
        /// Lists all datasets currently available in your account, filtering on the dataset name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual IAsyncResult BeginListDatasets(ListDatasetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasets.</param>
        /// 
        /// <returns>Returns a  ListDatasetsResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual ListDatasetsResponse EndListDatasets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDatasetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInferenceEvents

        /// <summary>
        /// Lists all inference events that have been found for the specified inference scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceEvents service method.</param>
        /// 
        /// <returns>The response from the ListInferenceEvents service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceEvents">REST API Reference for ListInferenceEvents Operation</seealso>
        public virtual ListInferenceEventsResponse ListInferenceEvents(ListInferenceEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInferenceEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceEventsResponseUnmarshaller.Instance;

            return Invoke<ListInferenceEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInferenceEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceEvents operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInferenceEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceEvents">REST API Reference for ListInferenceEvents Operation</seealso>
        public virtual IAsyncResult BeginListInferenceEvents(ListInferenceEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInferenceEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInferenceEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInferenceEvents.</param>
        /// 
        /// <returns>Returns a  ListInferenceEventsResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceEvents">REST API Reference for ListInferenceEvents Operation</seealso>
        public virtual ListInferenceEventsResponse EndListInferenceEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInferenceEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInferenceExecutions

        /// <summary>
        /// Lists all inference executions that have been performed by the specified inference
        /// scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceExecutions service method.</param>
        /// 
        /// <returns>The response from the ListInferenceExecutions service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceExecutions">REST API Reference for ListInferenceExecutions Operation</seealso>
        public virtual ListInferenceExecutionsResponse ListInferenceExecutions(ListInferenceExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInferenceExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListInferenceExecutionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInferenceExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceExecutions operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInferenceExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceExecutions">REST API Reference for ListInferenceExecutions Operation</seealso>
        public virtual IAsyncResult BeginListInferenceExecutions(ListInferenceExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInferenceExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInferenceExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInferenceExecutions.</param>
        /// 
        /// <returns>Returns a  ListInferenceExecutionsResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceExecutions">REST API Reference for ListInferenceExecutions Operation</seealso>
        public virtual ListInferenceExecutionsResponse EndListInferenceExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInferenceExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInferenceSchedulers

        /// <summary>
        /// Retrieves a list of all inference schedulers currently available for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceSchedulers service method.</param>
        /// 
        /// <returns>The response from the ListInferenceSchedulers service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceSchedulers">REST API Reference for ListInferenceSchedulers Operation</seealso>
        public virtual ListInferenceSchedulersResponse ListInferenceSchedulers(ListInferenceSchedulersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInferenceSchedulersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceSchedulersResponseUnmarshaller.Instance;

            return Invoke<ListInferenceSchedulersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInferenceSchedulers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceSchedulers operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInferenceSchedulers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceSchedulers">REST API Reference for ListInferenceSchedulers Operation</seealso>
        public virtual IAsyncResult BeginListInferenceSchedulers(ListInferenceSchedulersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInferenceSchedulersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceSchedulersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInferenceSchedulers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInferenceSchedulers.</param>
        /// 
        /// <returns>Returns a  ListInferenceSchedulersResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceSchedulers">REST API Reference for ListInferenceSchedulers Operation</seealso>
        public virtual ListInferenceSchedulersResponse EndListInferenceSchedulers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInferenceSchedulersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLabelGroups

        /// <summary>
        /// Returns a list of the label groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLabelGroups service method.</param>
        /// 
        /// <returns>The response from the ListLabelGroups service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListLabelGroups">REST API Reference for ListLabelGroups Operation</seealso>
        public virtual ListLabelGroupsResponse ListLabelGroups(ListLabelGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLabelGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelGroupsResponseUnmarshaller.Instance;

            return Invoke<ListLabelGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLabelGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLabelGroups operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLabelGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListLabelGroups">REST API Reference for ListLabelGroups Operation</seealso>
        public virtual IAsyncResult BeginListLabelGroups(ListLabelGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLabelGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLabelGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLabelGroups.</param>
        /// 
        /// <returns>Returns a  ListLabelGroupsResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListLabelGroups">REST API Reference for ListLabelGroups Operation</seealso>
        public virtual ListLabelGroupsResponse EndListLabelGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLabelGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLabels

        /// <summary>
        /// Provides a list of labels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLabels service method.</param>
        /// 
        /// <returns>The response from the ListLabels service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListLabels">REST API Reference for ListLabels Operation</seealso>
        public virtual ListLabelsResponse ListLabels(ListLabelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelsResponseUnmarshaller.Instance;

            return Invoke<ListLabelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLabels operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLabels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListLabels">REST API Reference for ListLabels Operation</seealso>
        public virtual IAsyncResult BeginListLabels(ListLabelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLabels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLabels.</param>
        /// 
        /// <returns>Returns a  ListLabelsResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListLabels">REST API Reference for ListLabels Operation</seealso>
        public virtual ListLabelsResponse EndListLabels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLabelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListModels

        /// <summary>
        /// Generates a list of all models in the account, including model name and ARN, dataset,
        /// and status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModels service method.</param>
        /// 
        /// <returns>The response from the ListModels service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListModels">REST API Reference for ListModels Operation</seealso>
        public virtual ListModelsResponse ListModels(ListModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelsResponseUnmarshaller.Instance;

            return Invoke<ListModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModels operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListModels">REST API Reference for ListModels Operation</seealso>
        public virtual IAsyncResult BeginListModels(ListModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModels.</param>
        /// 
        /// <returns>Returns a  ListModelsResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListModels">REST API Reference for ListModels Operation</seealso>
        public virtual ListModelsResponse EndListModels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSensorStatistics

        /// <summary>
        /// Lists statistics about the data collected for each of the sensors that have been
        /// successfully ingested in the particular dataset. Can also be used to retreive Sensor
        /// Statistics for a previous ingestion job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSensorStatistics service method.</param>
        /// 
        /// <returns>The response from the ListSensorStatistics service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListSensorStatistics">REST API Reference for ListSensorStatistics Operation</seealso>
        public virtual ListSensorStatisticsResponse ListSensorStatistics(ListSensorStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSensorStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSensorStatisticsResponseUnmarshaller.Instance;

            return Invoke<ListSensorStatisticsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSensorStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSensorStatistics operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSensorStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListSensorStatistics">REST API Reference for ListSensorStatistics Operation</seealso>
        public virtual IAsyncResult BeginListSensorStatistics(ListSensorStatisticsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSensorStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSensorStatisticsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSensorStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSensorStatistics.</param>
        /// 
        /// <returns>Returns a  ListSensorStatisticsResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListSensorStatistics">REST API Reference for ListSensorStatistics Operation</seealso>
        public virtual ListSensorStatisticsResponse EndListSensorStatistics(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSensorStatisticsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all the tags for a specified resource, including key and value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDataIngestionJob

        /// <summary>
        /// Starts a data ingestion job. Amazon Lookout for Equipment returns the job status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataIngestionJob service method.</param>
        /// 
        /// <returns>The response from the StartDataIngestionJob service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ServiceQuotaExceededException">
        /// Resource limitations have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StartDataIngestionJob">REST API Reference for StartDataIngestionJob Operation</seealso>
        public virtual StartDataIngestionJobResponse StartDataIngestionJob(StartDataIngestionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDataIngestionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataIngestionJobResponseUnmarshaller.Instance;

            return Invoke<StartDataIngestionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDataIngestionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataIngestionJob operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDataIngestionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StartDataIngestionJob">REST API Reference for StartDataIngestionJob Operation</seealso>
        public virtual IAsyncResult BeginStartDataIngestionJob(StartDataIngestionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDataIngestionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataIngestionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDataIngestionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDataIngestionJob.</param>
        /// 
        /// <returns>Returns a  StartDataIngestionJobResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StartDataIngestionJob">REST API Reference for StartDataIngestionJob Operation</seealso>
        public virtual StartDataIngestionJobResponse EndStartDataIngestionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDataIngestionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartInferenceScheduler

        /// <summary>
        /// Starts an inference scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInferenceScheduler service method.</param>
        /// 
        /// <returns>The response from the StartInferenceScheduler service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StartInferenceScheduler">REST API Reference for StartInferenceScheduler Operation</seealso>
        public virtual StartInferenceSchedulerResponse StartInferenceScheduler(StartInferenceSchedulerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInferenceSchedulerResponseUnmarshaller.Instance;

            return Invoke<StartInferenceSchedulerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInferenceScheduler operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartInferenceScheduler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StartInferenceScheduler">REST API Reference for StartInferenceScheduler Operation</seealso>
        public virtual IAsyncResult BeginStartInferenceScheduler(StartInferenceSchedulerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInferenceSchedulerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInferenceScheduler.</param>
        /// 
        /// <returns>Returns a  StartInferenceSchedulerResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StartInferenceScheduler">REST API Reference for StartInferenceScheduler Operation</seealso>
        public virtual StartInferenceSchedulerResponse EndStartInferenceScheduler(IAsyncResult asyncResult)
        {
            return EndInvoke<StartInferenceSchedulerResponse>(asyncResult);
        }

        #endregion
        
        #region  StopInferenceScheduler

        /// <summary>
        /// Stops an inference scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInferenceScheduler service method.</param>
        /// 
        /// <returns>The response from the StopInferenceScheduler service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StopInferenceScheduler">REST API Reference for StopInferenceScheduler Operation</seealso>
        public virtual StopInferenceSchedulerResponse StopInferenceScheduler(StopInferenceSchedulerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopInferenceSchedulerResponseUnmarshaller.Instance;

            return Invoke<StopInferenceSchedulerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInferenceScheduler operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopInferenceScheduler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StopInferenceScheduler">REST API Reference for StopInferenceScheduler Operation</seealso>
        public virtual IAsyncResult BeginStopInferenceScheduler(StopInferenceSchedulerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopInferenceSchedulerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopInferenceScheduler.</param>
        /// 
        /// <returns>Returns a  StopInferenceSchedulerResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StopInferenceScheduler">REST API Reference for StopInferenceScheduler Operation</seealso>
        public virtual StopInferenceSchedulerResponse EndStopInferenceScheduler(IAsyncResult asyncResult)
        {
            return EndInvoke<StopInferenceSchedulerResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associates a given tag to a resource in your account. A tag is a key-value pair which
        /// can be added to an Amazon Lookout for Equipment resource as metadata. Tags can be
        /// used for organizing your resources as well as helping you to search and filter by
        /// tag. Multiple tags can be added to a resource, either when you create it, or later.
        /// Up to 50 tags can be associated with each resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ServiceQuotaExceededException">
        /// Resource limitations have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a specific tag from a given resource. The tag is specified by its key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateInferenceScheduler

        /// <summary>
        /// Updates an inference scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInferenceScheduler service method.</param>
        /// 
        /// <returns>The response from the UpdateInferenceScheduler service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateInferenceScheduler">REST API Reference for UpdateInferenceScheduler Operation</seealso>
        public virtual UpdateInferenceSchedulerResponse UpdateInferenceScheduler(UpdateInferenceSchedulerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInferenceSchedulerResponseUnmarshaller.Instance;

            return Invoke<UpdateInferenceSchedulerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInferenceScheduler operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInferenceScheduler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateInferenceScheduler">REST API Reference for UpdateInferenceScheduler Operation</seealso>
        public virtual IAsyncResult BeginUpdateInferenceScheduler(UpdateInferenceSchedulerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInferenceSchedulerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInferenceScheduler.</param>
        /// 
        /// <returns>Returns a  UpdateInferenceSchedulerResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateInferenceScheduler">REST API Reference for UpdateInferenceScheduler Operation</seealso>
        public virtual UpdateInferenceSchedulerResponse EndUpdateInferenceScheduler(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateInferenceSchedulerResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLabelGroup

        /// <summary>
        /// Updates the label group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLabelGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateLabelGroup service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateLabelGroup">REST API Reference for UpdateLabelGroup Operation</seealso>
        public virtual UpdateLabelGroupResponse UpdateLabelGroup(UpdateLabelGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLabelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLabelGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateLabelGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLabelGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLabelGroup operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLabelGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateLabelGroup">REST API Reference for UpdateLabelGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateLabelGroup(UpdateLabelGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLabelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLabelGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLabelGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLabelGroup.</param>
        /// 
        /// <returns>Returns a  UpdateLabelGroupResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateLabelGroup">REST API Reference for UpdateLabelGroup Operation</seealso>
        public virtual UpdateLabelGroupResponse EndUpdateLabelGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLabelGroupResponse>(asyncResult);
        }

        #endregion
        
    }
}