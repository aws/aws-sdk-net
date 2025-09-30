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
 * Do not modify this file. This file is generated from the savingsplans-2019-06-28.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.SavingsPlans.Model;
using Amazon.SavingsPlans.Model.Internal.MarshallTransformations;
using Amazon.SavingsPlans.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.SavingsPlans
{
    /// <summary>
    /// <para>Implementation for accessing SavingsPlans</para>
    ///
    /// Savings Plans are a pricing model that offer significant savings on Amazon Web Services
    /// usage (for example, on Amazon EC2 instances). You commit to a consistent amount of
    /// usage per hour, in the specified currency, for a term of one or three years, and receive
    /// a lower price for that usage. For more information, see the <a href="https://docs.aws.amazon.com/savingsplans/latest/userguide/">Amazon
    /// Web Services Savings Plans User Guide</a>.
    /// </summary>
    public partial class AmazonSavingsPlansClient : AmazonServiceClient, IAmazonSavingsPlans
    {
        private static IServiceMetadata serviceMetadata = new AmazonSavingsPlansMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with the credentials loaded from the application's
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
        public AmazonSavingsPlansClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSavingsPlansConfig()) { }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with the credentials loaded from the application's
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
        public AmazonSavingsPlansClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSavingsPlansConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSavingsPlansClient Configuration Object</param>
        public AmazonSavingsPlansClient(AmazonSavingsPlansConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonSavingsPlansClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSavingsPlansClient(AWSCredentials credentials)
            : this(credentials, new AmazonSavingsPlansConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSavingsPlansClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSavingsPlansConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with AWS Credentials and an
        /// AmazonSavingsPlansClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSavingsPlansClient Configuration Object</param>
        public AmazonSavingsPlansClient(AWSCredentials credentials, AmazonSavingsPlansConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSavingsPlansClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSavingsPlansConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSavingsPlansClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSavingsPlansConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSavingsPlansClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSavingsPlansClient Configuration Object</param>
        public AmazonSavingsPlansClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSavingsPlansConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSavingsPlansClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSavingsPlansConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSavingsPlansClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSavingsPlansConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSavingsPlansClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSavingsPlansClient Configuration Object</param>
        public AmazonSavingsPlansClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSavingsPlansConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSavingsPlansEndpointResolver());
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


        #region  CreateSavingsPlan

        /// <summary>
        /// Creates a Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSavingsPlan service method.</param>
        /// 
        /// <returns>The response from the CreateSavingsPlan service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/CreateSavingsPlan">REST API Reference for CreateSavingsPlan Operation</seealso>
        public virtual CreateSavingsPlanResponse CreateSavingsPlan(CreateSavingsPlanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSavingsPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSavingsPlanResponseUnmarshaller.Instance;

            return Invoke<CreateSavingsPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSavingsPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSavingsPlan operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSavingsPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/CreateSavingsPlan">REST API Reference for CreateSavingsPlan Operation</seealso>
        public virtual IAsyncResult BeginCreateSavingsPlan(CreateSavingsPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSavingsPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSavingsPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSavingsPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSavingsPlan.</param>
        /// 
        /// <returns>Returns a  CreateSavingsPlanResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/CreateSavingsPlan">REST API Reference for CreateSavingsPlan Operation</seealso>
        public virtual CreateSavingsPlanResponse EndCreateSavingsPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSavingsPlanResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteQueuedSavingsPlan

        /// <summary>
        /// Deletes the queued purchase for the specified Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueuedSavingsPlan service method.</param>
        /// 
        /// <returns>The response from the DeleteQueuedSavingsPlan service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DeleteQueuedSavingsPlan">REST API Reference for DeleteQueuedSavingsPlan Operation</seealso>
        public virtual DeleteQueuedSavingsPlanResponse DeleteQueuedSavingsPlan(DeleteQueuedSavingsPlanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueuedSavingsPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueuedSavingsPlanResponseUnmarshaller.Instance;

            return Invoke<DeleteQueuedSavingsPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQueuedSavingsPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueuedSavingsPlan operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQueuedSavingsPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DeleteQueuedSavingsPlan">REST API Reference for DeleteQueuedSavingsPlan Operation</seealso>
        public virtual IAsyncResult BeginDeleteQueuedSavingsPlan(DeleteQueuedSavingsPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueuedSavingsPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueuedSavingsPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQueuedSavingsPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQueuedSavingsPlan.</param>
        /// 
        /// <returns>Returns a  DeleteQueuedSavingsPlanResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DeleteQueuedSavingsPlan">REST API Reference for DeleteQueuedSavingsPlan Operation</seealso>
        public virtual DeleteQueuedSavingsPlanResponse EndDeleteQueuedSavingsPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteQueuedSavingsPlanResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSavingsPlanRates

        /// <summary>
        /// Describes the rates for the specified Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlanRates service method.</param>
        /// 
        /// <returns>The response from the DescribeSavingsPlanRates service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlanRates">REST API Reference for DescribeSavingsPlanRates Operation</seealso>
        public virtual DescribeSavingsPlanRatesResponse DescribeSavingsPlanRates(DescribeSavingsPlanRatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSavingsPlanRatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSavingsPlanRatesResponseUnmarshaller.Instance;

            return Invoke<DescribeSavingsPlanRatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSavingsPlanRates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlanRates operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSavingsPlanRates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlanRates">REST API Reference for DescribeSavingsPlanRates Operation</seealso>
        public virtual IAsyncResult BeginDescribeSavingsPlanRates(DescribeSavingsPlanRatesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSavingsPlanRatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSavingsPlanRatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSavingsPlanRates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSavingsPlanRates.</param>
        /// 
        /// <returns>Returns a  DescribeSavingsPlanRatesResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlanRates">REST API Reference for DescribeSavingsPlanRates Operation</seealso>
        public virtual DescribeSavingsPlanRatesResponse EndDescribeSavingsPlanRates(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSavingsPlanRatesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSavingsPlans

        /// <summary>
        /// Describes the specified Savings Plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlans service method.</param>
        /// 
        /// <returns>The response from the DescribeSavingsPlans service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlans">REST API Reference for DescribeSavingsPlans Operation</seealso>
        public virtual DescribeSavingsPlansResponse DescribeSavingsPlans(DescribeSavingsPlansRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSavingsPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSavingsPlansResponseUnmarshaller.Instance;

            return Invoke<DescribeSavingsPlansResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSavingsPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlans operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSavingsPlans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlans">REST API Reference for DescribeSavingsPlans Operation</seealso>
        public virtual IAsyncResult BeginDescribeSavingsPlans(DescribeSavingsPlansRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSavingsPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSavingsPlansResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSavingsPlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSavingsPlans.</param>
        /// 
        /// <returns>Returns a  DescribeSavingsPlansResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlans">REST API Reference for DescribeSavingsPlans Operation</seealso>
        public virtual DescribeSavingsPlansResponse EndDescribeSavingsPlans(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSavingsPlansResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSavingsPlansOfferingRates

        /// <summary>
        /// Describes the offering rates for the specified Savings Plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlansOfferingRates service method.</param>
        /// 
        /// <returns>The response from the DescribeSavingsPlansOfferingRates service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlansOfferingRates">REST API Reference for DescribeSavingsPlansOfferingRates Operation</seealso>
        public virtual DescribeSavingsPlansOfferingRatesResponse DescribeSavingsPlansOfferingRates(DescribeSavingsPlansOfferingRatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSavingsPlansOfferingRatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSavingsPlansOfferingRatesResponseUnmarshaller.Instance;

            return Invoke<DescribeSavingsPlansOfferingRatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSavingsPlansOfferingRates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlansOfferingRates operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSavingsPlansOfferingRates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlansOfferingRates">REST API Reference for DescribeSavingsPlansOfferingRates Operation</seealso>
        public virtual IAsyncResult BeginDescribeSavingsPlansOfferingRates(DescribeSavingsPlansOfferingRatesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSavingsPlansOfferingRatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSavingsPlansOfferingRatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSavingsPlansOfferingRates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSavingsPlansOfferingRates.</param>
        /// 
        /// <returns>Returns a  DescribeSavingsPlansOfferingRatesResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlansOfferingRates">REST API Reference for DescribeSavingsPlansOfferingRates Operation</seealso>
        public virtual DescribeSavingsPlansOfferingRatesResponse EndDescribeSavingsPlansOfferingRates(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSavingsPlansOfferingRatesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSavingsPlansOfferings

        /// <summary>
        /// Describes the offerings for the specified Savings Plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlansOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeSavingsPlansOfferings service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlansOfferings">REST API Reference for DescribeSavingsPlansOfferings Operation</seealso>
        public virtual DescribeSavingsPlansOfferingsResponse DescribeSavingsPlansOfferings(DescribeSavingsPlansOfferingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSavingsPlansOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSavingsPlansOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeSavingsPlansOfferingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSavingsPlansOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlansOfferings operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSavingsPlansOfferings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlansOfferings">REST API Reference for DescribeSavingsPlansOfferings Operation</seealso>
        public virtual IAsyncResult BeginDescribeSavingsPlansOfferings(DescribeSavingsPlansOfferingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSavingsPlansOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSavingsPlansOfferingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSavingsPlansOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSavingsPlansOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeSavingsPlansOfferingsResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlansOfferings">REST API Reference for DescribeSavingsPlansOfferings Operation</seealso>
        public virtual DescribeSavingsPlansOfferingsResponse EndDescribeSavingsPlansOfferings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSavingsPlansOfferingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ReturnSavingsPlan

        /// <summary>
        /// Returns the specified Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReturnSavingsPlan service method.</param>
        /// 
        /// <returns>The response from the ReturnSavingsPlan service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/ReturnSavingsPlan">REST API Reference for ReturnSavingsPlan Operation</seealso>
        public virtual ReturnSavingsPlanResponse ReturnSavingsPlan(ReturnSavingsPlanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReturnSavingsPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReturnSavingsPlanResponseUnmarshaller.Instance;

            return Invoke<ReturnSavingsPlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReturnSavingsPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReturnSavingsPlan operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReturnSavingsPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/ReturnSavingsPlan">REST API Reference for ReturnSavingsPlan Operation</seealso>
        public virtual IAsyncResult BeginReturnSavingsPlan(ReturnSavingsPlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReturnSavingsPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReturnSavingsPlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReturnSavingsPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReturnSavingsPlan.</param>
        /// 
        /// <returns>Returns a  ReturnSavingsPlanResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/ReturnSavingsPlan">REST API Reference for ReturnSavingsPlan Operation</seealso>
        public virtual ReturnSavingsPlanResponse EndReturnSavingsPlan(IAsyncResult asyncResult)
        {
            return EndInvoke<ReturnSavingsPlanResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>The response from the UntagResource service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
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
            var resolver = new AmazonSavingsPlansEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}