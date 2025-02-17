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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Invoicing.Model;
using Amazon.Invoicing.Model.Internal.MarshallTransformations;
using Amazon.Invoicing.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Invoicing
{
    /// <summary>
    /// <para>Implementation for accessing Invoicing</para>
    ///
    /// <b>Amazon Web Services Invoice Configuration</b> 
    /// 
    ///  
    /// <para>
    /// You can use Amazon Web Services Invoice Configuration APIs to programmatically create,
    /// update, delete, get, and list invoice units. You can also programmatically fetch the
    /// information of the invoice receiver. For example, business legal name, address, and
    /// invoicing contacts. 
    /// </para>
    ///  
    /// <para>
    /// You can use Amazon Web Services Invoice Configuration to receive separate Amazon Web
    /// Services invoices based your organizational needs. By using Amazon Web Services Invoice
    /// Configuration, you can configure invoice units that are groups of Amazon Web Services
    /// accounts that represent your business entities, and receive separate invoices for
    /// each business entity. You can also assign a unique member or payer account as the
    /// invoice receiver for each invoice unit. As you create new accounts within your Organizations
    /// using Amazon Web Services Invoice Configuration APIs, you can automate the creation
    /// of new invoice units and subsequently automate the addition of new accounts to your
    /// invoice units.
    /// </para>
    ///  
    /// <para>
    /// Service endpoint
    /// </para>
    ///  
    /// <para>
    /// You can use the following endpoints for Amazon Web Services Invoice Configuration:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>https://invoicing.us-east-1.api.aws</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonInvoicingClient : AmazonServiceClient, IAmazonInvoicing
    {
        private static IServiceMetadata serviceMetadata = new AmazonInvoicingMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IInvoicingPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IInvoicingPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new InvoicingPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonInvoicingClient with the credentials loaded from the application's
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
        public AmazonInvoicingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonInvoicingConfig()) { }

        /// <summary>
        /// Constructs AmazonInvoicingClient with the credentials loaded from the application's
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
        public AmazonInvoicingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonInvoicingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonInvoicingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonInvoicingClient Configuration Object</param>
        public AmazonInvoicingClient(AmazonInvoicingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonInvoicingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonInvoicingClient(AWSCredentials credentials)
            : this(credentials, new AmazonInvoicingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonInvoicingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInvoicingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonInvoicingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonInvoicingClient with AWS Credentials and an
        /// AmazonInvoicingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonInvoicingClient Configuration Object</param>
        public AmazonInvoicingClient(AWSCredentials credentials, AmazonInvoicingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonInvoicingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonInvoicingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonInvoicingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonInvoicingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInvoicingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonInvoicingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonInvoicingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonInvoicingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonInvoicingClient Configuration Object</param>
        public AmazonInvoicingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonInvoicingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonInvoicingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonInvoicingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonInvoicingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonInvoicingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonInvoicingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonInvoicingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonInvoicingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonInvoicingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonInvoicingClient Configuration Object</param>
        public AmazonInvoicingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonInvoicingConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonInvoicingEndpointResolver());
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


        #region  BatchGetInvoiceProfile

        /// <summary>
        /// This gets the invoice profile associated with a set of accounts. The accounts must
        /// be linked accounts under the requester management account organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetInvoiceProfile service method.</param>
        /// 
        /// <returns>The response from the BatchGetInvoiceProfile service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/BatchGetInvoiceProfile">REST API Reference for BatchGetInvoiceProfile Operation</seealso>
        public virtual BatchGetInvoiceProfileResponse BatchGetInvoiceProfile(BatchGetInvoiceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetInvoiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetInvoiceProfileResponseUnmarshaller.Instance;

            return Invoke<BatchGetInvoiceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetInvoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetInvoiceProfile operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetInvoiceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/BatchGetInvoiceProfile">REST API Reference for BatchGetInvoiceProfile Operation</seealso>
        public virtual IAsyncResult BeginBatchGetInvoiceProfile(BatchGetInvoiceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetInvoiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetInvoiceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetInvoiceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetInvoiceProfile.</param>
        /// 
        /// <returns>Returns a  BatchGetInvoiceProfileResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/BatchGetInvoiceProfile">REST API Reference for BatchGetInvoiceProfile Operation</seealso>
        public virtual BatchGetInvoiceProfileResponse EndBatchGetInvoiceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetInvoiceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInvoiceUnit

        /// <summary>
        /// This creates a new invoice unit with the provided definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInvoiceUnit service method.</param>
        /// 
        /// <returns>The response from the CreateInvoiceUnit service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/CreateInvoiceUnit">REST API Reference for CreateInvoiceUnit Operation</seealso>
        public virtual CreateInvoiceUnitResponse CreateInvoiceUnit(CreateInvoiceUnitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInvoiceUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInvoiceUnitResponseUnmarshaller.Instance;

            return Invoke<CreateInvoiceUnitResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInvoiceUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInvoiceUnit operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInvoiceUnit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/CreateInvoiceUnit">REST API Reference for CreateInvoiceUnit Operation</seealso>
        public virtual IAsyncResult BeginCreateInvoiceUnit(CreateInvoiceUnitRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInvoiceUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInvoiceUnitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInvoiceUnit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInvoiceUnit.</param>
        /// 
        /// <returns>Returns a  CreateInvoiceUnitResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/CreateInvoiceUnit">REST API Reference for CreateInvoiceUnit Operation</seealso>
        public virtual CreateInvoiceUnitResponse EndCreateInvoiceUnit(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInvoiceUnitResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInvoiceUnit

        /// <summary>
        /// This deletes an invoice unit with the provided invoice unit ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvoiceUnit service method.</param>
        /// 
        /// <returns>The response from the DeleteInvoiceUnit service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/DeleteInvoiceUnit">REST API Reference for DeleteInvoiceUnit Operation</seealso>
        public virtual DeleteInvoiceUnitResponse DeleteInvoiceUnit(DeleteInvoiceUnitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInvoiceUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInvoiceUnitResponseUnmarshaller.Instance;

            return Invoke<DeleteInvoiceUnitResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInvoiceUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvoiceUnit operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInvoiceUnit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/DeleteInvoiceUnit">REST API Reference for DeleteInvoiceUnit Operation</seealso>
        public virtual IAsyncResult BeginDeleteInvoiceUnit(DeleteInvoiceUnitRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInvoiceUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInvoiceUnitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInvoiceUnit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInvoiceUnit.</param>
        /// 
        /// <returns>Returns a  DeleteInvoiceUnitResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/DeleteInvoiceUnit">REST API Reference for DeleteInvoiceUnit Operation</seealso>
        public virtual DeleteInvoiceUnitResponse EndDeleteInvoiceUnit(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInvoiceUnitResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInvoiceUnit

        /// <summary>
        /// This retrieves the invoice unit definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvoiceUnit service method.</param>
        /// 
        /// <returns>The response from the GetInvoiceUnit service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/GetInvoiceUnit">REST API Reference for GetInvoiceUnit Operation</seealso>
        public virtual GetInvoiceUnitResponse GetInvoiceUnit(GetInvoiceUnitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInvoiceUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvoiceUnitResponseUnmarshaller.Instance;

            return Invoke<GetInvoiceUnitResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInvoiceUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvoiceUnit operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInvoiceUnit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/GetInvoiceUnit">REST API Reference for GetInvoiceUnit Operation</seealso>
        public virtual IAsyncResult BeginGetInvoiceUnit(GetInvoiceUnitRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInvoiceUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInvoiceUnitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInvoiceUnit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInvoiceUnit.</param>
        /// 
        /// <returns>Returns a  GetInvoiceUnitResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/GetInvoiceUnit">REST API Reference for GetInvoiceUnit Operation</seealso>
        public virtual GetInvoiceUnitResponse EndGetInvoiceUnit(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInvoiceUnitResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInvoiceUnits

        /// <summary>
        /// This fetches a list of all invoice unit definitions for a given account, as of the
        /// provided <c>AsOf</c> date.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvoiceUnits service method.</param>
        /// 
        /// <returns>The response from the ListInvoiceUnits service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/ListInvoiceUnits">REST API Reference for ListInvoiceUnits Operation</seealso>
        public virtual ListInvoiceUnitsResponse ListInvoiceUnits(ListInvoiceUnitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInvoiceUnitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvoiceUnitsResponseUnmarshaller.Instance;

            return Invoke<ListInvoiceUnitsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInvoiceUnits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvoiceUnits operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInvoiceUnits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/ListInvoiceUnits">REST API Reference for ListInvoiceUnits Operation</seealso>
        public virtual IAsyncResult BeginListInvoiceUnits(ListInvoiceUnitsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInvoiceUnitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInvoiceUnitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInvoiceUnits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInvoiceUnits.</param>
        /// 
        /// <returns>Returns a  ListInvoiceUnitsResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/ListInvoiceUnits">REST API Reference for ListInvoiceUnits Operation</seealso>
        public virtual ListInvoiceUnitsResponse EndListInvoiceUnits(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInvoiceUnitsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ServiceQuotaExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateInvoiceUnit

        /// <summary>
        /// You can update the invoice unit configuration at any time, and Amazon Web Services
        /// will use the latest configuration at the end of the month.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInvoiceUnit service method.</param>
        /// 
        /// <returns>The response from the UpdateInvoiceUnit service method, as returned by Invoicing.</returns>
        /// <exception cref="Amazon.Invoicing.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.InternalServerException">
        /// The processing request failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Invoicing.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/UpdateInvoiceUnit">REST API Reference for UpdateInvoiceUnit Operation</seealso>
        public virtual UpdateInvoiceUnitResponse UpdateInvoiceUnit(UpdateInvoiceUnitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInvoiceUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInvoiceUnitResponseUnmarshaller.Instance;

            return Invoke<UpdateInvoiceUnitResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInvoiceUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInvoiceUnit operation on AmazonInvoicingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInvoiceUnit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/UpdateInvoiceUnit">REST API Reference for UpdateInvoiceUnit Operation</seealso>
        public virtual IAsyncResult BeginUpdateInvoiceUnit(UpdateInvoiceUnitRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateInvoiceUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInvoiceUnitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInvoiceUnit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInvoiceUnit.</param>
        /// 
        /// <returns>Returns a  UpdateInvoiceUnitResult from Invoicing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/invoicing-2024-12-01/UpdateInvoiceUnit">REST API Reference for UpdateInvoiceUnit Operation</seealso>
        public virtual UpdateInvoiceUnitResponse EndUpdateInvoiceUnit(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateInvoiceUnitResponse>(asyncResult);
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
            var resolver = new AmazonInvoicingEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}