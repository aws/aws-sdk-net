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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ConnectCases.Model;
using Amazon.ConnectCases.Model.Internal.MarshallTransformations;
using Amazon.ConnectCases.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ConnectCases
{
    /// <summary>
    /// Implementation for accessing ConnectCases
    ///
    /// With Amazon Connect Cases, your agents can track and manage customer issues that require
    /// multiple interactions, follow-up tasks, and teams in your contact center. A case represents
    /// a customer issue. It records the issue, the steps and interactions taken to resolve
    /// the issue, and the outcome. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/cases.html">Amazon
    /// Connect Cases</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// </summary>
    public partial class AmazonConnectCasesClient : AmazonServiceClient, IAmazonConnectCases
    {
        private static IServiceMetadata serviceMetadata = new AmazonConnectCasesMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IConnectCasesPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IConnectCasesPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ConnectCasesPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonConnectCasesClient with the credentials loaded from the application's
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
        public AmazonConnectCasesClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConnectCasesConfig()) { }

        /// <summary>
        /// Constructs AmazonConnectCasesClient with the credentials loaded from the application's
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
        public AmazonConnectCasesClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConnectCasesConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonConnectCasesClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonConnectCasesClient Configuration Object</param>
        public AmazonConnectCasesClient(AmazonConnectCasesConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonConnectCasesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonConnectCasesClient(AWSCredentials credentials)
            : this(credentials, new AmazonConnectCasesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCasesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectCasesClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonConnectCasesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCasesClient with AWS Credentials and an
        /// AmazonConnectCasesClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonConnectCasesClient Configuration Object</param>
        public AmazonConnectCasesClient(AWSCredentials credentials, AmazonConnectCasesConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCasesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonConnectCasesClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConnectCasesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCasesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectCasesClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConnectCasesConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCasesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConnectCasesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonConnectCasesClient Configuration Object</param>
        public AmazonConnectCasesClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonConnectCasesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCasesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonConnectCasesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConnectCasesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCasesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectCasesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConnectCasesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectCasesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConnectCasesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonConnectCasesClient Configuration Object</param>
        public AmazonConnectCasesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonConnectCasesConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonConnectCasesEndpointResolver());
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


        #region  BatchGetField

        /// <summary>
        /// Returns the description for the list of fields in the request parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetField service method.</param>
        /// 
        /// <returns>The response from the BatchGetField service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/BatchGetField">REST API Reference for BatchGetField Operation</seealso>
        public virtual BatchGetFieldResponse BatchGetField(BatchGetFieldRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetFieldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetFieldResponseUnmarshaller.Instance;

            return Invoke<BatchGetFieldResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetField operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetField operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetField
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/BatchGetField">REST API Reference for BatchGetField Operation</seealso>
        public virtual IAsyncResult BeginBatchGetField(BatchGetFieldRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetFieldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetFieldResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetField operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetField.</param>
        /// 
        /// <returns>Returns a  BatchGetFieldResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/BatchGetField">REST API Reference for BatchGetField Operation</seealso>
        public virtual BatchGetFieldResponse EndBatchGetField(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetFieldResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchPutFieldOptions

        /// <summary>
        /// Creates and updates a set of field options for a single select field in a Cases domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutFieldOptions service method.</param>
        /// 
        /// <returns>The response from the BatchPutFieldOptions service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/BatchPutFieldOptions">REST API Reference for BatchPutFieldOptions Operation</seealso>
        public virtual BatchPutFieldOptionsResponse BatchPutFieldOptions(BatchPutFieldOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutFieldOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutFieldOptionsResponseUnmarshaller.Instance;

            return Invoke<BatchPutFieldOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutFieldOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutFieldOptions operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchPutFieldOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/BatchPutFieldOptions">REST API Reference for BatchPutFieldOptions Operation</seealso>
        public virtual IAsyncResult BeginBatchPutFieldOptions(BatchPutFieldOptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutFieldOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutFieldOptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchPutFieldOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchPutFieldOptions.</param>
        /// 
        /// <returns>Returns a  BatchPutFieldOptionsResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/BatchPutFieldOptions">REST API Reference for BatchPutFieldOptions Operation</seealso>
        public virtual BatchPutFieldOptionsResponse EndBatchPutFieldOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchPutFieldOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCase

        /// <summary>
        /// Creates a case in the specified Cases domain. Case system and custom fields are taken
        /// as an array id/value pairs with a declared data types.
        /// 
        ///  <note> 
        /// <para>
        /// The following fields are required when creating a case:
        /// </para>
        ///  <pre><code> &lt;ul&gt; &lt;li&gt; &lt;p&gt; &lt;code&gt;customer_id&lt;/code&gt;
        /// - You must provide the full customer profile ARN in this format: &lt;code&gt;arn:aws:profile:your
        /// AWS Region:your AWS account ID:domains/profiles domain name/profiles/profile ID&lt;/code&gt;
        /// &lt;/p&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;code&gt;title&lt;/code&gt; &lt;/p&gt;
        /// &lt;/li&gt; &lt;/ul&gt; &lt;/note&gt; </code></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCase service method.</param>
        /// 
        /// <returns>The response from the CreateCase service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateCase">REST API Reference for CreateCase Operation</seealso>
        public virtual CreateCaseResponse CreateCase(CreateCaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCaseResponseUnmarshaller.Instance;

            return Invoke<CreateCaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCase operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateCase">REST API Reference for CreateCase Operation</seealso>
        public virtual IAsyncResult BeginCreateCase(CreateCaseRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCase.</param>
        /// 
        /// <returns>Returns a  CreateCaseResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateCase">REST API Reference for CreateCase Operation</seealso>
        public virtual CreateCaseResponse EndCreateCase(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCaseResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDomain

        /// <summary>
        /// Creates a domain, which is a container for all case data, such as cases, fields, templates
        /// and layouts. Each Amazon Connect instance can be associated with only one Cases domain.
        /// 
        ///  <important> 
        /// <para>
        /// This will not associate your connect instance to Cases domain. Instead, use the Amazon
        /// Connect <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_CreateIntegrationAssociation.html">CreateIntegrationAssociation</a>
        /// API. You need specific IAM permissions to successfully associate the Cases domain.
        /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/required-permissions-iam-cases.html#onboard-cases-iam">Onboard
        /// to Cases</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual IAsyncResult BeginCreateDomain(CreateDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomain.</param>
        /// 
        /// <returns>Returns a  CreateDomainResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual CreateDomainResponse EndCreateDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateField

        /// <summary>
        /// Creates a field in the Cases domain. This field is used to define the case object
        /// model (that is, defines what data can be captured on cases) in a Cases domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateField service method.</param>
        /// 
        /// <returns>The response from the CreateField service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateField">REST API Reference for CreateField Operation</seealso>
        public virtual CreateFieldResponse CreateField(CreateFieldRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFieldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFieldResponseUnmarshaller.Instance;

            return Invoke<CreateFieldResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateField operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateField operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateField
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateField">REST API Reference for CreateField Operation</seealso>
        public virtual IAsyncResult BeginCreateField(CreateFieldRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFieldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFieldResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateField operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateField.</param>
        /// 
        /// <returns>Returns a  CreateFieldResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateField">REST API Reference for CreateField Operation</seealso>
        public virtual CreateFieldResponse EndCreateField(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFieldResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLayout

        /// <summary>
        /// Creates a layout in the Cases domain. Layouts define the following configuration in
        /// the top section and More Info tab of the Cases user interface:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Fields to display to the users
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Field ordering
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Title and Status fields cannot be part of layouts since they are not configurable.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLayout service method.</param>
        /// 
        /// <returns>The response from the CreateLayout service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateLayout">REST API Reference for CreateLayout Operation</seealso>
        public virtual CreateLayoutResponse CreateLayout(CreateLayoutRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLayoutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLayoutResponseUnmarshaller.Instance;

            return Invoke<CreateLayoutResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLayout operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLayout operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLayout
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateLayout">REST API Reference for CreateLayout Operation</seealso>
        public virtual IAsyncResult BeginCreateLayout(CreateLayoutRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLayoutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLayoutResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLayout operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLayout.</param>
        /// 
        /// <returns>Returns a  CreateLayoutResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateLayout">REST API Reference for CreateLayout Operation</seealso>
        public virtual CreateLayoutResponse EndCreateLayout(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLayoutResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRelatedItem

        /// <summary>
        /// Creates a related item (comments, tasks, and contacts) and associates it with a case.
        /// 
        ///  <note> 
        /// <para>
        /// A Related Item is a resource that is associated with a case. It may or may not have
        /// an external identifier linking it to an external resource (for example, a <code>contactArn</code>).
        /// All Related Items have their own internal identifier, the <code>relatedItemArn</code>.
        /// Examples of related items include <code>comments</code> and <code>contacts</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRelatedItem service method.</param>
        /// 
        /// <returns>The response from the CreateRelatedItem service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateRelatedItem">REST API Reference for CreateRelatedItem Operation</seealso>
        public virtual CreateRelatedItemResponse CreateRelatedItem(CreateRelatedItemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRelatedItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelatedItemResponseUnmarshaller.Instance;

            return Invoke<CreateRelatedItemResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRelatedItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRelatedItem operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRelatedItem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateRelatedItem">REST API Reference for CreateRelatedItem Operation</seealso>
        public virtual IAsyncResult BeginCreateRelatedItem(CreateRelatedItemRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRelatedItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelatedItemResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRelatedItem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRelatedItem.</param>
        /// 
        /// <returns>Returns a  CreateRelatedItemResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateRelatedItem">REST API Reference for CreateRelatedItem Operation</seealso>
        public virtual CreateRelatedItemResponse EndCreateRelatedItem(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRelatedItemResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTemplate

        /// <summary>
        /// Creates a template in the Cases domain. This template is used to define the case object
        /// model (that is, to define what data can be captured on cases) in a Cases domain. A
        /// template must have a unique name within a domain, and it must reference existing field
        /// IDs and layout IDs. Additionally, multiple fields with same IDs are not allowed within
        /// the same Template. A template can be either Active or Inactive, as indicated by its
        /// status. Inactive templates cannot be used to create cases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        public virtual CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateTemplate(CreateTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTemplate.</param>
        /// 
        /// <returns>Returns a  CreateTemplateResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        public virtual CreateTemplateResponse EndCreateTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDomain

        /// <summary>
        /// Deletes a domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual IAsyncResult BeginDeleteDomain(DeleteDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// 
        /// <returns>Returns a  DeleteDomainResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCase

        /// <summary>
        /// Returns information about a specific case if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCase service method.</param>
        /// 
        /// <returns>The response from the GetCase service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetCase">REST API Reference for GetCase Operation</seealso>
        public virtual GetCaseResponse GetCase(GetCaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCaseResponseUnmarshaller.Instance;

            return Invoke<GetCaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCase operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetCase">REST API Reference for GetCase Operation</seealso>
        public virtual IAsyncResult BeginGetCase(GetCaseRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCase.</param>
        /// 
        /// <returns>Returns a  GetCaseResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetCase">REST API Reference for GetCase Operation</seealso>
        public virtual GetCaseResponse EndGetCase(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCaseResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCaseEventConfiguration

        /// <summary>
        /// Returns the case event publishing configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCaseEventConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetCaseEventConfiguration service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetCaseEventConfiguration">REST API Reference for GetCaseEventConfiguration Operation</seealso>
        public virtual GetCaseEventConfigurationResponse GetCaseEventConfiguration(GetCaseEventConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCaseEventConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCaseEventConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetCaseEventConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCaseEventConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCaseEventConfiguration operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCaseEventConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetCaseEventConfiguration">REST API Reference for GetCaseEventConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetCaseEventConfiguration(GetCaseEventConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCaseEventConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCaseEventConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCaseEventConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCaseEventConfiguration.</param>
        /// 
        /// <returns>Returns a  GetCaseEventConfigurationResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetCaseEventConfiguration">REST API Reference for GetCaseEventConfiguration Operation</seealso>
        public virtual GetCaseEventConfigurationResponse EndGetCaseEventConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCaseEventConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDomain

        /// <summary>
        /// Returns information about a specific domain if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetDomain">REST API Reference for GetDomain Operation</seealso>
        public virtual GetDomainResponse GetDomain(GetDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainResponseUnmarshaller.Instance;

            return Invoke<GetDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomain operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetDomain">REST API Reference for GetDomain Operation</seealso>
        public virtual IAsyncResult BeginGetDomain(GetDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomain.</param>
        /// 
        /// <returns>Returns a  GetDomainResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetDomain">REST API Reference for GetDomain Operation</seealso>
        public virtual GetDomainResponse EndGetDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLayout

        /// <summary>
        /// Returns the details for the requested layout.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLayout service method.</param>
        /// 
        /// <returns>The response from the GetLayout service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetLayout">REST API Reference for GetLayout Operation</seealso>
        public virtual GetLayoutResponse GetLayout(GetLayoutRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLayoutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLayoutResponseUnmarshaller.Instance;

            return Invoke<GetLayoutResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLayout operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLayout operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLayout
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetLayout">REST API Reference for GetLayout Operation</seealso>
        public virtual IAsyncResult BeginGetLayout(GetLayoutRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLayoutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLayoutResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLayout operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLayout.</param>
        /// 
        /// <returns>Returns a  GetLayoutResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetLayout">REST API Reference for GetLayout Operation</seealso>
        public virtual GetLayoutResponse EndGetLayout(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLayoutResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTemplate

        /// <summary>
        /// Returns the details for the requested template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return Invoke<GetTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetTemplate(GetTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemplate.</param>
        /// 
        /// <returns>Returns a  GetTemplateResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual GetTemplateResponse EndGetTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCasesForContact

        /// <summary>
        /// Lists cases for a given contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCasesForContact service method.</param>
        /// 
        /// <returns>The response from the ListCasesForContact service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListCasesForContact">REST API Reference for ListCasesForContact Operation</seealso>
        public virtual ListCasesForContactResponse ListCasesForContact(ListCasesForContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCasesForContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCasesForContactResponseUnmarshaller.Instance;

            return Invoke<ListCasesForContactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCasesForContact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCasesForContact operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCasesForContact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListCasesForContact">REST API Reference for ListCasesForContact Operation</seealso>
        public virtual IAsyncResult BeginListCasesForContact(ListCasesForContactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCasesForContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCasesForContactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCasesForContact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCasesForContact.</param>
        /// 
        /// <returns>Returns a  ListCasesForContactResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListCasesForContact">REST API Reference for ListCasesForContact Operation</seealso>
        public virtual ListCasesForContactResponse EndListCasesForContact(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCasesForContactResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDomains

        /// <summary>
        /// Lists all cases domains in the Amazon Web Services account. Each list item is a condensed
        /// summary object of the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual IAsyncResult BeginListDomains(ListDomainsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomains.</param>
        /// 
        /// <returns>Returns a  ListDomainsResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual ListDomainsResponse EndListDomains(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDomainsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFieldOptions

        /// <summary>
        /// Lists all of the field options for a field identifier in the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFieldOptions service method.</param>
        /// 
        /// <returns>The response from the ListFieldOptions service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListFieldOptions">REST API Reference for ListFieldOptions Operation</seealso>
        public virtual ListFieldOptionsResponse ListFieldOptions(ListFieldOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFieldOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFieldOptionsResponseUnmarshaller.Instance;

            return Invoke<ListFieldOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFieldOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFieldOptions operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFieldOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListFieldOptions">REST API Reference for ListFieldOptions Operation</seealso>
        public virtual IAsyncResult BeginListFieldOptions(ListFieldOptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFieldOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFieldOptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFieldOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFieldOptions.</param>
        /// 
        /// <returns>Returns a  ListFieldOptionsResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListFieldOptions">REST API Reference for ListFieldOptions Operation</seealso>
        public virtual ListFieldOptionsResponse EndListFieldOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFieldOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFields

        /// <summary>
        /// Lists all fields in a Cases domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFields service method.</param>
        /// 
        /// <returns>The response from the ListFields service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListFields">REST API Reference for ListFields Operation</seealso>
        public virtual ListFieldsResponse ListFields(ListFieldsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFieldsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFieldsResponseUnmarshaller.Instance;

            return Invoke<ListFieldsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFields operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFields operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFields
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListFields">REST API Reference for ListFields Operation</seealso>
        public virtual IAsyncResult BeginListFields(ListFieldsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFieldsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFieldsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFields operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFields.</param>
        /// 
        /// <returns>Returns a  ListFieldsResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListFields">REST API Reference for ListFields Operation</seealso>
        public virtual ListFieldsResponse EndListFields(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFieldsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLayouts

        /// <summary>
        /// Lists all layouts in the given cases domain. Each list item is a condensed summary
        /// object of the layout.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLayouts service method.</param>
        /// 
        /// <returns>The response from the ListLayouts service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListLayouts">REST API Reference for ListLayouts Operation</seealso>
        public virtual ListLayoutsResponse ListLayouts(ListLayoutsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLayoutsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLayoutsResponseUnmarshaller.Instance;

            return Invoke<ListLayoutsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLayouts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLayouts operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLayouts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListLayouts">REST API Reference for ListLayouts Operation</seealso>
        public virtual IAsyncResult BeginListLayouts(ListLayoutsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLayoutsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLayoutsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLayouts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLayouts.</param>
        /// 
        /// <returns>Returns a  ListLayoutsResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListLayouts">REST API Reference for ListLayouts Operation</seealso>
        public virtual ListLayoutsResponse EndListLayouts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLayoutsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTemplates

        /// <summary>
        /// Lists all of the templates in a Cases domain. Each list item is a condensed summary
        /// object of the template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual IAsyncResult BeginListTemplates(ListTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplates.</param>
        /// 
        /// <returns>Returns a  ListTemplatesResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual ListTemplatesResponse EndListTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  PutCaseEventConfiguration

        /// <summary>
        /// API for adding case event publishing configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCaseEventConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutCaseEventConfiguration service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/PutCaseEventConfiguration">REST API Reference for PutCaseEventConfiguration Operation</seealso>
        public virtual PutCaseEventConfigurationResponse PutCaseEventConfiguration(PutCaseEventConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutCaseEventConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCaseEventConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutCaseEventConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutCaseEventConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutCaseEventConfiguration operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutCaseEventConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/PutCaseEventConfiguration">REST API Reference for PutCaseEventConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutCaseEventConfiguration(PutCaseEventConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutCaseEventConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCaseEventConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutCaseEventConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutCaseEventConfiguration.</param>
        /// 
        /// <returns>Returns a  PutCaseEventConfigurationResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/PutCaseEventConfiguration">REST API Reference for PutCaseEventConfiguration Operation</seealso>
        public virtual PutCaseEventConfigurationResponse EndPutCaseEventConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutCaseEventConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchCases

        /// <summary>
        /// Searches for cases within their associated Cases domain. Search results are returned
        /// as a paginated list of abridged case documents.
        /// 
        ///  <note> 
        /// <para>
        /// For <code>customer_id</code> you must provide the full customer profile ARN in this
        /// format: <code> arn:aws:profile:your AWS Region:your AWS account ID:domains/profiles
        /// domain name/profiles/profile ID</code>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchCases service method.</param>
        /// 
        /// <returns>The response from the SearchCases service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/SearchCases">REST API Reference for SearchCases Operation</seealso>
        public virtual SearchCasesResponse SearchCases(SearchCasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchCasesResponseUnmarshaller.Instance;

            return Invoke<SearchCasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchCases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchCases operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchCases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/SearchCases">REST API Reference for SearchCases Operation</seealso>
        public virtual IAsyncResult BeginSearchCases(SearchCasesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchCasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchCases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchCases.</param>
        /// 
        /// <returns>Returns a  SearchCasesResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/SearchCases">REST API Reference for SearchCases Operation</seealso>
        public virtual SearchCasesResponse EndSearchCases(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchCasesResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchRelatedItems

        /// <summary>
        /// Searches for related items that are associated with a case.
        /// 
        ///  <note> 
        /// <para>
        /// If no filters are provided, this returns all related items associated with a case.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchRelatedItems service method.</param>
        /// 
        /// <returns>The response from the SearchRelatedItems service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/SearchRelatedItems">REST API Reference for SearchRelatedItems Operation</seealso>
        public virtual SearchRelatedItemsResponse SearchRelatedItems(SearchRelatedItemsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRelatedItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchRelatedItemsResponseUnmarshaller.Instance;

            return Invoke<SearchRelatedItemsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchRelatedItems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchRelatedItems operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchRelatedItems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/SearchRelatedItems">REST API Reference for SearchRelatedItems Operation</seealso>
        public virtual IAsyncResult BeginSearchRelatedItems(SearchRelatedItemsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRelatedItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchRelatedItemsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchRelatedItems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchRelatedItems.</param>
        /// 
        /// <returns>Returns a  SearchRelatedItemsResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/SearchRelatedItems">REST API Reference for SearchRelatedItems Operation</seealso>
        public virtual SearchRelatedItemsResponse EndSearchRelatedItems(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchRelatedItemsResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Untags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCase

        /// <summary>
        /// Updates the values of fields on a case. Fields to be updated are received as an array
        /// of id/value pairs identical to the <code>CreateCase</code> input .
        /// 
        ///  
        /// <para>
        /// If the action is successful, the service sends back an HTTP 200 response with an empty
        /// HTTP body.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCase service method.</param>
        /// 
        /// <returns>The response from the UpdateCase service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateCase">REST API Reference for UpdateCase Operation</seealso>
        public virtual UpdateCaseResponse UpdateCase(UpdateCaseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCaseResponseUnmarshaller.Instance;

            return Invoke<UpdateCaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCase operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateCase">REST API Reference for UpdateCase Operation</seealso>
        public virtual IAsyncResult BeginUpdateCase(UpdateCaseRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCase.</param>
        /// 
        /// <returns>Returns a  UpdateCaseResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateCase">REST API Reference for UpdateCase Operation</seealso>
        public virtual UpdateCaseResponse EndUpdateCase(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCaseResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateField

        /// <summary>
        /// Updates the properties of an existing field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateField service method.</param>
        /// 
        /// <returns>The response from the UpdateField service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateField">REST API Reference for UpdateField Operation</seealso>
        public virtual UpdateFieldResponse UpdateField(UpdateFieldRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFieldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFieldResponseUnmarshaller.Instance;

            return Invoke<UpdateFieldResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateField operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateField operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateField
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateField">REST API Reference for UpdateField Operation</seealso>
        public virtual IAsyncResult BeginUpdateField(UpdateFieldRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFieldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFieldResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateField operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateField.</param>
        /// 
        /// <returns>Returns a  UpdateFieldResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateField">REST API Reference for UpdateField Operation</seealso>
        public virtual UpdateFieldResponse EndUpdateField(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFieldResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLayout

        /// <summary>
        /// Updates the attributes of an existing layout.
        /// 
        ///  
        /// <para>
        /// If the action is successful, the service sends back an HTTP 200 response with an empty
        /// HTTP body.
        /// </para>
        ///  
        /// <para>
        /// A <code>ValidationException</code> is returned when you add non-existent <code>fieldIds</code>
        /// to a layout.
        /// </para>
        ///  <note> 
        /// <para>
        /// Title and Status fields cannot be part of layouts because they are not configurable.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLayout service method.</param>
        /// 
        /// <returns>The response from the UpdateLayout service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ServiceQuotaExceededException">
        /// The service quota has been exceeded. For a list of service quotas, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">Amazon
        /// Connect Service Quotas</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateLayout">REST API Reference for UpdateLayout Operation</seealso>
        public virtual UpdateLayoutResponse UpdateLayout(UpdateLayoutRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLayoutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLayoutResponseUnmarshaller.Instance;

            return Invoke<UpdateLayoutResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLayout operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLayout operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLayout
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateLayout">REST API Reference for UpdateLayout Operation</seealso>
        public virtual IAsyncResult BeginUpdateLayout(UpdateLayoutRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLayoutRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLayoutResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLayout operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLayout.</param>
        /// 
        /// <returns>Returns a  UpdateLayoutResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateLayout">REST API Reference for UpdateLayout Operation</seealso>
        public virtual UpdateLayoutResponse EndUpdateLayout(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLayoutResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTemplate

        /// <summary>
        /// Updates the attributes of an existing template. The template attributes that can be
        /// modified include <code>name</code>, <code>description</code>, <code>layoutConfiguration</code>,
        /// <code>requiredFields</code>, and <code>status</code>. At least one of these attributes
        /// must not be null. If a null value is provided for a given attribute, that attribute
        /// is ignored and its current value is preserved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by ConnectCases.</returns>
        /// <exception cref="Amazon.ConnectCases.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource. Check that your resources exists and were
        /// created in the same Amazon Web Services Region as your request, and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ThrottlingException">
        /// The rate has been exceeded for this API. Please try again after a few minutes.
        /// </exception>
        /// <exception cref="Amazon.ConnectCases.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        public virtual UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate operation on AmazonConnectCasesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdateTemplate(UpdateTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateTemplateResult from ConnectCases.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcases-2022-10-03/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        public virtual UpdateTemplateResponse EndUpdateTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTemplateResponse>(asyncResult);
        }

        #endregion
        
    }
}