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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.MailManager.Model;
using Amazon.MailManager.Model.Internal.MarshallTransformations;
using Amazon.MailManager.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.MailManager
{
    /// <summary>
    /// <para>Implementation for accessing MailManager</para>
    ///
    /// Amazon SES Mail Manager API 
    /// <para>
    /// The Amazon SES Mail Manager API contains operations and data types that comprise the
    /// Mail Manager feature of <a href="http://aws.amazon.com/ses">Amazon Simple Email Service
    /// (SES)</a>.
    /// 
    ///  
    /// <para>
    /// Mail Manager is a set of Amazon SES email gateway features designed to help you strengthen
    /// your organization's email infrastructure, simplify email workflow management, and
    /// streamline email compliance control. To learn more, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/eb.html">Mail
    /// Manager chapter</a> in the <i>Amazon SES Developer Guide</i>.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class AmazonMailManagerClient : AmazonServiceClient, IAmazonMailManager
    {
        private static IServiceMetadata serviceMetadata = new AmazonMailManagerMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IMailManagerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMailManagerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MailManagerPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonMailManagerClient with the credentials loaded from the application's
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
        public AmazonMailManagerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMailManagerConfig()) { }

        /// <summary>
        /// Constructs AmazonMailManagerClient with the credentials loaded from the application's
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
        public AmazonMailManagerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMailManagerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMailManagerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMailManagerClient Configuration Object</param>
        public AmazonMailManagerClient(AmazonMailManagerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonMailManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMailManagerClient(AWSCredentials credentials)
            : this(credentials, new AmazonMailManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMailManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMailManagerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMailManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMailManagerClient with AWS Credentials and an
        /// AmazonMailManagerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMailManagerClient Configuration Object</param>
        public AmazonMailManagerClient(AWSCredentials credentials, AmazonMailManagerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMailManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMailManagerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMailManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMailManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMailManagerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMailManagerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMailManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMailManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMailManagerClient Configuration Object</param>
        public AmazonMailManagerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMailManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMailManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMailManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMailManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMailManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMailManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMailManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMailManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMailManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMailManagerClient Configuration Object</param>
        public AmazonMailManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMailManagerConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMailManagerEndpointResolver());
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


        #region  CreateAddonInstance

        /// <summary>
        /// Creates an Add On instance for the subscription indicated in the request. The resulting
        /// Amazon Resource Name (ARN) can be used in a conditional statement for a rule set or
        /// traffic policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAddonInstance service method.</param>
        /// 
        /// <returns>The response from the CreateAddonInstance service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddonInstance">REST API Reference for CreateAddonInstance Operation</seealso>
        public virtual CreateAddonInstanceResponse CreateAddonInstance(CreateAddonInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAddonInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddonInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateAddonInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAddonInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAddonInstance operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAddonInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddonInstance">REST API Reference for CreateAddonInstance Operation</seealso>
        public virtual IAsyncResult BeginCreateAddonInstance(CreateAddonInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAddonInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddonInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAddonInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAddonInstance.</param>
        /// 
        /// <returns>Returns a  CreateAddonInstanceResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddonInstance">REST API Reference for CreateAddonInstance Operation</seealso>
        public virtual CreateAddonInstanceResponse EndCreateAddonInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAddonInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAddonSubscription

        /// <summary>
        /// Creates a subscription for an Add On representing the acceptance of its terms of use
        /// and additional pricing. The subscription can then be used to create an instance for
        /// use in rule sets or traffic policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAddonSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateAddonSubscription service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddonSubscription">REST API Reference for CreateAddonSubscription Operation</seealso>
        public virtual CreateAddonSubscriptionResponse CreateAddonSubscription(CreateAddonSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAddonSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddonSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateAddonSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAddonSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAddonSubscription operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAddonSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddonSubscription">REST API Reference for CreateAddonSubscription Operation</seealso>
        public virtual IAsyncResult BeginCreateAddonSubscription(CreateAddonSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAddonSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddonSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAddonSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAddonSubscription.</param>
        /// 
        /// <returns>Returns a  CreateAddonSubscriptionResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddonSubscription">REST API Reference for CreateAddonSubscription Operation</seealso>
        public virtual CreateAddonSubscriptionResponse EndCreateAddonSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAddonSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAddressList

        /// <summary>
        /// Creates a new address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAddressList service method.</param>
        /// 
        /// <returns>The response from the CreateAddressList service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddressList">REST API Reference for CreateAddressList Operation</seealso>
        public virtual CreateAddressListResponse CreateAddressList(CreateAddressListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddressListResponseUnmarshaller.Instance;

            return Invoke<CreateAddressListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAddressList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAddressList operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAddressList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddressList">REST API Reference for CreateAddressList Operation</seealso>
        public virtual IAsyncResult BeginCreateAddressList(CreateAddressListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddressListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAddressList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAddressList.</param>
        /// 
        /// <returns>Returns a  CreateAddressListResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddressList">REST API Reference for CreateAddressList Operation</seealso>
        public virtual CreateAddressListResponse EndCreateAddressList(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAddressListResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAddressListImportJob

        /// <summary>
        /// Creates an import job for an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAddressListImportJob service method.</param>
        /// 
        /// <returns>The response from the CreateAddressListImportJob service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddressListImportJob">REST API Reference for CreateAddressListImportJob Operation</seealso>
        public virtual CreateAddressListImportJobResponse CreateAddressListImportJob(CreateAddressListImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAddressListImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddressListImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateAddressListImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAddressListImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAddressListImportJob operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAddressListImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddressListImportJob">REST API Reference for CreateAddressListImportJob Operation</seealso>
        public virtual IAsyncResult BeginCreateAddressListImportJob(CreateAddressListImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAddressListImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAddressListImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAddressListImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAddressListImportJob.</param>
        /// 
        /// <returns>Returns a  CreateAddressListImportJobResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateAddressListImportJob">REST API Reference for CreateAddressListImportJob Operation</seealso>
        public virtual CreateAddressListImportJobResponse EndCreateAddressListImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAddressListImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateArchive

        /// <summary>
        /// Creates a new email archive resource for storing and retaining emails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateArchive service method.</param>
        /// 
        /// <returns>The response from the CreateArchive service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateArchive">REST API Reference for CreateArchive Operation</seealso>
        public virtual CreateArchiveResponse CreateArchive(CreateArchiveRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateArchiveResponseUnmarshaller.Instance;

            return Invoke<CreateArchiveResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateArchive operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateArchive
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateArchive">REST API Reference for CreateArchive Operation</seealso>
        public virtual IAsyncResult BeginCreateArchive(CreateArchiveRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateArchiveResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateArchive.</param>
        /// 
        /// <returns>Returns a  CreateArchiveResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateArchive">REST API Reference for CreateArchive Operation</seealso>
        public virtual CreateArchiveResponse EndCreateArchive(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateArchiveResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIngressPoint

        /// <summary>
        /// Provision a new ingress endpoint resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIngressPoint service method.</param>
        /// 
        /// <returns>The response from the CreateIngressPoint service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateIngressPoint">REST API Reference for CreateIngressPoint Operation</seealso>
        public virtual CreateIngressPointResponse CreateIngressPoint(CreateIngressPointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIngressPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIngressPointResponseUnmarshaller.Instance;

            return Invoke<CreateIngressPointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIngressPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIngressPoint operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIngressPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateIngressPoint">REST API Reference for CreateIngressPoint Operation</seealso>
        public virtual IAsyncResult BeginCreateIngressPoint(CreateIngressPointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIngressPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIngressPointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIngressPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIngressPoint.</param>
        /// 
        /// <returns>Returns a  CreateIngressPointResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateIngressPoint">REST API Reference for CreateIngressPoint Operation</seealso>
        public virtual CreateIngressPointResponse EndCreateIngressPoint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIngressPointResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRelay

        /// <summary>
        /// Creates a relay resource which can be used in rules to relay incoming emails to defined
        /// relay destinations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRelay service method.</param>
        /// 
        /// <returns>The response from the CreateRelay service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateRelay">REST API Reference for CreateRelay Operation</seealso>
        public virtual CreateRelayResponse CreateRelay(CreateRelayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRelayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelayResponseUnmarshaller.Instance;

            return Invoke<CreateRelayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRelay operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRelay operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRelay
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateRelay">REST API Reference for CreateRelay Operation</seealso>
        public virtual IAsyncResult BeginCreateRelay(CreateRelayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRelayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRelayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRelay operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRelay.</param>
        /// 
        /// <returns>Returns a  CreateRelayResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateRelay">REST API Reference for CreateRelay Operation</seealso>
        public virtual CreateRelayResponse EndCreateRelay(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRelayResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRuleSet

        /// <summary>
        /// Provision a new rule set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleSet service method.</param>
        /// 
        /// <returns>The response from the CreateRuleSet service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateRuleSet">REST API Reference for CreateRuleSet Operation</seealso>
        public virtual CreateRuleSetResponse CreateRuleSet(CreateRuleSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleSetResponseUnmarshaller.Instance;

            return Invoke<CreateRuleSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleSet operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateRuleSet">REST API Reference for CreateRuleSet Operation</seealso>
        public virtual IAsyncResult BeginCreateRuleSet(CreateRuleSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRuleSet.</param>
        /// 
        /// <returns>Returns a  CreateRuleSetResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateRuleSet">REST API Reference for CreateRuleSet Operation</seealso>
        public virtual CreateRuleSetResponse EndCreateRuleSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRuleSetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTrafficPolicy

        /// <summary>
        /// Provision a new traffic policy resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateTrafficPolicy service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateTrafficPolicy">REST API Reference for CreateTrafficPolicy Operation</seealso>
        public virtual CreateTrafficPolicyResponse CreateTrafficPolicy(CreateTrafficPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateTrafficPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrafficPolicy operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrafficPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateTrafficPolicy">REST API Reference for CreateTrafficPolicy Operation</seealso>
        public virtual IAsyncResult BeginCreateTrafficPolicy(CreateTrafficPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrafficPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrafficPolicy.</param>
        /// 
        /// <returns>Returns a  CreateTrafficPolicyResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/CreateTrafficPolicy">REST API Reference for CreateTrafficPolicy Operation</seealso>
        public virtual CreateTrafficPolicyResponse EndCreateTrafficPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTrafficPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAddonInstance

        /// <summary>
        /// Deletes an Add On instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddonInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteAddonInstance service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddonInstance">REST API Reference for DeleteAddonInstance Operation</seealso>
        public virtual DeleteAddonInstanceResponse DeleteAddonInstance(DeleteAddonInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAddonInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAddonInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteAddonInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAddonInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddonInstance operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAddonInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddonInstance">REST API Reference for DeleteAddonInstance Operation</seealso>
        public virtual IAsyncResult BeginDeleteAddonInstance(DeleteAddonInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAddonInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAddonInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAddonInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAddonInstance.</param>
        /// 
        /// <returns>Returns a  DeleteAddonInstanceResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddonInstance">REST API Reference for DeleteAddonInstance Operation</seealso>
        public virtual DeleteAddonInstanceResponse EndDeleteAddonInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAddonInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAddonSubscription

        /// <summary>
        /// Deletes an Add On subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddonSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteAddonSubscription service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddonSubscription">REST API Reference for DeleteAddonSubscription Operation</seealso>
        public virtual DeleteAddonSubscriptionResponse DeleteAddonSubscription(DeleteAddonSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAddonSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAddonSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteAddonSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAddonSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddonSubscription operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAddonSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddonSubscription">REST API Reference for DeleteAddonSubscription Operation</seealso>
        public virtual IAsyncResult BeginDeleteAddonSubscription(DeleteAddonSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAddonSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAddonSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAddonSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAddonSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteAddonSubscriptionResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddonSubscription">REST API Reference for DeleteAddonSubscription Operation</seealso>
        public virtual DeleteAddonSubscriptionResponse EndDeleteAddonSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAddonSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAddressList

        /// <summary>
        /// Deletes an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddressList service method.</param>
        /// 
        /// <returns>The response from the DeleteAddressList service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddressList">REST API Reference for DeleteAddressList Operation</seealso>
        public virtual DeleteAddressListResponse DeleteAddressList(DeleteAddressListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAddressListResponseUnmarshaller.Instance;

            return Invoke<DeleteAddressListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAddressList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAddressList operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAddressList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddressList">REST API Reference for DeleteAddressList Operation</seealso>
        public virtual IAsyncResult BeginDeleteAddressList(DeleteAddressListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAddressListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAddressList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAddressList.</param>
        /// 
        /// <returns>Returns a  DeleteAddressListResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteAddressList">REST API Reference for DeleteAddressList Operation</seealso>
        public virtual DeleteAddressListResponse EndDeleteAddressList(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAddressListResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteArchive

        /// <summary>
        /// Initiates deletion of an email archive. This changes the archive state to pending
        /// deletion. In this state, no new emails can be added, and existing archived emails
        /// become inaccessible (search, export, download). The archive and all of its contents
        /// will be permanently deleted 30 days after entering the pending deletion state, regardless
        /// of the configured retention period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchive service method.</param>
        /// 
        /// <returns>The response from the DeleteArchive service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteArchive">REST API Reference for DeleteArchive Operation</seealso>
        public virtual DeleteArchiveResponse DeleteArchive(DeleteArchiveRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteArchiveResponseUnmarshaller.Instance;

            return Invoke<DeleteArchiveResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteArchive operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteArchive
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteArchive">REST API Reference for DeleteArchive Operation</seealso>
        public virtual IAsyncResult BeginDeleteArchive(DeleteArchiveRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteArchiveResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteArchive.</param>
        /// 
        /// <returns>Returns a  DeleteArchiveResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteArchive">REST API Reference for DeleteArchive Operation</seealso>
        public virtual DeleteArchiveResponse EndDeleteArchive(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteArchiveResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIngressPoint

        /// <summary>
        /// Delete an ingress endpoint resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIngressPoint service method.</param>
        /// 
        /// <returns>The response from the DeleteIngressPoint service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteIngressPoint">REST API Reference for DeleteIngressPoint Operation</seealso>
        public virtual DeleteIngressPointResponse DeleteIngressPoint(DeleteIngressPointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIngressPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIngressPointResponseUnmarshaller.Instance;

            return Invoke<DeleteIngressPointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIngressPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIngressPoint operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIngressPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteIngressPoint">REST API Reference for DeleteIngressPoint Operation</seealso>
        public virtual IAsyncResult BeginDeleteIngressPoint(DeleteIngressPointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIngressPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIngressPointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIngressPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIngressPoint.</param>
        /// 
        /// <returns>Returns a  DeleteIngressPointResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteIngressPoint">REST API Reference for DeleteIngressPoint Operation</seealso>
        public virtual DeleteIngressPointResponse EndDeleteIngressPoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIngressPointResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRelay

        /// <summary>
        /// Deletes an existing relay resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelay service method.</param>
        /// 
        /// <returns>The response from the DeleteRelay service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteRelay">REST API Reference for DeleteRelay Operation</seealso>
        public virtual DeleteRelayResponse DeleteRelay(DeleteRelayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRelayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRelayResponseUnmarshaller.Instance;

            return Invoke<DeleteRelayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRelay operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelay operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRelay
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteRelay">REST API Reference for DeleteRelay Operation</seealso>
        public virtual IAsyncResult BeginDeleteRelay(DeleteRelayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRelayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRelayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRelay operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRelay.</param>
        /// 
        /// <returns>Returns a  DeleteRelayResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteRelay">REST API Reference for DeleteRelay Operation</seealso>
        public virtual DeleteRelayResponse EndDeleteRelay(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRelayResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRuleSet

        /// <summary>
        /// Delete a rule set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleSet service method.</param>
        /// 
        /// <returns>The response from the DeleteRuleSet service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteRuleSet">REST API Reference for DeleteRuleSet Operation</seealso>
        public virtual DeleteRuleSetResponse DeleteRuleSet(DeleteRuleSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleSetResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleSet operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteRuleSet">REST API Reference for DeleteRuleSet Operation</seealso>
        public virtual IAsyncResult BeginDeleteRuleSet(DeleteRuleSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRuleSet.</param>
        /// 
        /// <returns>Returns a  DeleteRuleSetResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteRuleSet">REST API Reference for DeleteRuleSet Operation</seealso>
        public virtual DeleteRuleSetResponse EndDeleteRuleSet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRuleSetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTrafficPolicy

        /// <summary>
        /// Delete a traffic policy resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteTrafficPolicy service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteTrafficPolicy">REST API Reference for DeleteTrafficPolicy Operation</seealso>
        public virtual DeleteTrafficPolicyResponse DeleteTrafficPolicy(DeleteTrafficPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteTrafficPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrafficPolicy operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTrafficPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteTrafficPolicy">REST API Reference for DeleteTrafficPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteTrafficPolicy(DeleteTrafficPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrafficPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTrafficPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteTrafficPolicyResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeleteTrafficPolicy">REST API Reference for DeleteTrafficPolicy Operation</seealso>
        public virtual DeleteTrafficPolicyResponse EndDeleteTrafficPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTrafficPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterMemberFromAddressList

        /// <summary>
        /// Removes a member from an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterMemberFromAddressList service method.</param>
        /// 
        /// <returns>The response from the DeregisterMemberFromAddressList service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeregisterMemberFromAddressList">REST API Reference for DeregisterMemberFromAddressList Operation</seealso>
        public virtual DeregisterMemberFromAddressListResponse DeregisterMemberFromAddressList(DeregisterMemberFromAddressListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterMemberFromAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterMemberFromAddressListResponseUnmarshaller.Instance;

            return Invoke<DeregisterMemberFromAddressListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterMemberFromAddressList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterMemberFromAddressList operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterMemberFromAddressList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeregisterMemberFromAddressList">REST API Reference for DeregisterMemberFromAddressList Operation</seealso>
        public virtual IAsyncResult BeginDeregisterMemberFromAddressList(DeregisterMemberFromAddressListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterMemberFromAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterMemberFromAddressListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterMemberFromAddressList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterMemberFromAddressList.</param>
        /// 
        /// <returns>Returns a  DeregisterMemberFromAddressListResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/DeregisterMemberFromAddressList">REST API Reference for DeregisterMemberFromAddressList Operation</seealso>
        public virtual DeregisterMemberFromAddressListResponse EndDeregisterMemberFromAddressList(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterMemberFromAddressListResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAddonInstance

        /// <summary>
        /// Gets detailed information about an Add On instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAddonInstance service method.</param>
        /// 
        /// <returns>The response from the GetAddonInstance service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddonInstance">REST API Reference for GetAddonInstance Operation</seealso>
        public virtual GetAddonInstanceResponse GetAddonInstance(GetAddonInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAddonInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAddonInstanceResponseUnmarshaller.Instance;

            return Invoke<GetAddonInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAddonInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAddonInstance operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAddonInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddonInstance">REST API Reference for GetAddonInstance Operation</seealso>
        public virtual IAsyncResult BeginGetAddonInstance(GetAddonInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAddonInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAddonInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAddonInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAddonInstance.</param>
        /// 
        /// <returns>Returns a  GetAddonInstanceResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddonInstance">REST API Reference for GetAddonInstance Operation</seealso>
        public virtual GetAddonInstanceResponse EndGetAddonInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAddonInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAddonSubscription

        /// <summary>
        /// Gets detailed information about an Add On subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAddonSubscription service method.</param>
        /// 
        /// <returns>The response from the GetAddonSubscription service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddonSubscription">REST API Reference for GetAddonSubscription Operation</seealso>
        public virtual GetAddonSubscriptionResponse GetAddonSubscription(GetAddonSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAddonSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAddonSubscriptionResponseUnmarshaller.Instance;

            return Invoke<GetAddonSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAddonSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAddonSubscription operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAddonSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddonSubscription">REST API Reference for GetAddonSubscription Operation</seealso>
        public virtual IAsyncResult BeginGetAddonSubscription(GetAddonSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAddonSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAddonSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAddonSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAddonSubscription.</param>
        /// 
        /// <returns>Returns a  GetAddonSubscriptionResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddonSubscription">REST API Reference for GetAddonSubscription Operation</seealso>
        public virtual GetAddonSubscriptionResponse EndGetAddonSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAddonSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAddressList

        /// <summary>
        /// Fetch attributes of an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAddressList service method.</param>
        /// 
        /// <returns>The response from the GetAddressList service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddressList">REST API Reference for GetAddressList Operation</seealso>
        public virtual GetAddressListResponse GetAddressList(GetAddressListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAddressListResponseUnmarshaller.Instance;

            return Invoke<GetAddressListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAddressList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAddressList operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAddressList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddressList">REST API Reference for GetAddressList Operation</seealso>
        public virtual IAsyncResult BeginGetAddressList(GetAddressListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAddressListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAddressList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAddressList.</param>
        /// 
        /// <returns>Returns a  GetAddressListResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddressList">REST API Reference for GetAddressList Operation</seealso>
        public virtual GetAddressListResponse EndGetAddressList(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAddressListResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAddressListImportJob

        /// <summary>
        /// Fetch attributes of an import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAddressListImportJob service method.</param>
        /// 
        /// <returns>The response from the GetAddressListImportJob service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddressListImportJob">REST API Reference for GetAddressListImportJob Operation</seealso>
        public virtual GetAddressListImportJobResponse GetAddressListImportJob(GetAddressListImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAddressListImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAddressListImportJobResponseUnmarshaller.Instance;

            return Invoke<GetAddressListImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAddressListImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAddressListImportJob operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAddressListImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddressListImportJob">REST API Reference for GetAddressListImportJob Operation</seealso>
        public virtual IAsyncResult BeginGetAddressListImportJob(GetAddressListImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAddressListImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAddressListImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAddressListImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAddressListImportJob.</param>
        /// 
        /// <returns>Returns a  GetAddressListImportJobResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetAddressListImportJob">REST API Reference for GetAddressListImportJob Operation</seealso>
        public virtual GetAddressListImportJobResponse EndGetAddressListImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAddressListImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetArchive

        /// <summary>
        /// Retrieves the full details and current state of a specified email archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchive service method.</param>
        /// 
        /// <returns>The response from the GetArchive service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchive">REST API Reference for GetArchive Operation</seealso>
        public virtual GetArchiveResponse GetArchive(GetArchiveRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveResponseUnmarshaller.Instance;

            return Invoke<GetArchiveResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetArchive operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetArchive
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchive">REST API Reference for GetArchive Operation</seealso>
        public virtual IAsyncResult BeginGetArchive(GetArchiveRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetArchive.</param>
        /// 
        /// <returns>Returns a  GetArchiveResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchive">REST API Reference for GetArchive Operation</seealso>
        public virtual GetArchiveResponse EndGetArchive(IAsyncResult asyncResult)
        {
            return EndInvoke<GetArchiveResponse>(asyncResult);
        }

        #endregion
        
        #region  GetArchiveExport

        /// <summary>
        /// Retrieves the details and current status of a specific email archive export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveExport service method.</param>
        /// 
        /// <returns>The response from the GetArchiveExport service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveExport">REST API Reference for GetArchiveExport Operation</seealso>
        public virtual GetArchiveExportResponse GetArchiveExport(GetArchiveExportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveExportResponseUnmarshaller.Instance;

            return Invoke<GetArchiveExportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetArchiveExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveExport operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetArchiveExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveExport">REST API Reference for GetArchiveExport Operation</seealso>
        public virtual IAsyncResult BeginGetArchiveExport(GetArchiveExportRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveExportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetArchiveExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetArchiveExport.</param>
        /// 
        /// <returns>Returns a  GetArchiveExportResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveExport">REST API Reference for GetArchiveExport Operation</seealso>
        public virtual GetArchiveExportResponse EndGetArchiveExport(IAsyncResult asyncResult)
        {
            return EndInvoke<GetArchiveExportResponse>(asyncResult);
        }

        #endregion
        
        #region  GetArchiveMessage

        /// <summary>
        /// Returns a pre-signed URL that provides temporary download access to the specific email
        /// message stored in the archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveMessage service method.</param>
        /// 
        /// <returns>The response from the GetArchiveMessage service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveMessage">REST API Reference for GetArchiveMessage Operation</seealso>
        public virtual GetArchiveMessageResponse GetArchiveMessage(GetArchiveMessageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveMessageResponseUnmarshaller.Instance;

            return Invoke<GetArchiveMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetArchiveMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveMessage operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetArchiveMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveMessage">REST API Reference for GetArchiveMessage Operation</seealso>
        public virtual IAsyncResult BeginGetArchiveMessage(GetArchiveMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetArchiveMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetArchiveMessage.</param>
        /// 
        /// <returns>Returns a  GetArchiveMessageResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveMessage">REST API Reference for GetArchiveMessage Operation</seealso>
        public virtual GetArchiveMessageResponse EndGetArchiveMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<GetArchiveMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetArchiveMessageContent

        /// <summary>
        /// Returns the textual content of a specific email message stored in the archive. Attachments
        /// are not included.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveMessageContent service method.</param>
        /// 
        /// <returns>The response from the GetArchiveMessageContent service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveMessageContent">REST API Reference for GetArchiveMessageContent Operation</seealso>
        public virtual GetArchiveMessageContentResponse GetArchiveMessageContent(GetArchiveMessageContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveMessageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveMessageContentResponseUnmarshaller.Instance;

            return Invoke<GetArchiveMessageContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetArchiveMessageContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveMessageContent operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetArchiveMessageContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveMessageContent">REST API Reference for GetArchiveMessageContent Operation</seealso>
        public virtual IAsyncResult BeginGetArchiveMessageContent(GetArchiveMessageContentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveMessageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveMessageContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetArchiveMessageContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetArchiveMessageContent.</param>
        /// 
        /// <returns>Returns a  GetArchiveMessageContentResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveMessageContent">REST API Reference for GetArchiveMessageContent Operation</seealso>
        public virtual GetArchiveMessageContentResponse EndGetArchiveMessageContent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetArchiveMessageContentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetArchiveSearch

        /// <summary>
        /// Retrieves the details and current status of a specific email archive search job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveSearch service method.</param>
        /// 
        /// <returns>The response from the GetArchiveSearch service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveSearch">REST API Reference for GetArchiveSearch Operation</seealso>
        public virtual GetArchiveSearchResponse GetArchiveSearch(GetArchiveSearchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveSearchResponseUnmarshaller.Instance;

            return Invoke<GetArchiveSearchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetArchiveSearch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveSearch operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetArchiveSearch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveSearch">REST API Reference for GetArchiveSearch Operation</seealso>
        public virtual IAsyncResult BeginGetArchiveSearch(GetArchiveSearchRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveSearchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetArchiveSearch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetArchiveSearch.</param>
        /// 
        /// <returns>Returns a  GetArchiveSearchResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveSearch">REST API Reference for GetArchiveSearch Operation</seealso>
        public virtual GetArchiveSearchResponse EndGetArchiveSearch(IAsyncResult asyncResult)
        {
            return EndInvoke<GetArchiveSearchResponse>(asyncResult);
        }

        #endregion
        
        #region  GetArchiveSearchResults

        /// <summary>
        /// Returns the results of a completed email archive search job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveSearchResults service method.</param>
        /// 
        /// <returns>The response from the GetArchiveSearchResults service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveSearchResults">REST API Reference for GetArchiveSearchResults Operation</seealso>
        public virtual GetArchiveSearchResultsResponse GetArchiveSearchResults(GetArchiveSearchResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveSearchResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveSearchResultsResponseUnmarshaller.Instance;

            return Invoke<GetArchiveSearchResultsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetArchiveSearchResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetArchiveSearchResults operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetArchiveSearchResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveSearchResults">REST API Reference for GetArchiveSearchResults Operation</seealso>
        public virtual IAsyncResult BeginGetArchiveSearchResults(GetArchiveSearchResultsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetArchiveSearchResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArchiveSearchResultsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetArchiveSearchResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetArchiveSearchResults.</param>
        /// 
        /// <returns>Returns a  GetArchiveSearchResultsResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetArchiveSearchResults">REST API Reference for GetArchiveSearchResults Operation</seealso>
        public virtual GetArchiveSearchResultsResponse EndGetArchiveSearchResults(IAsyncResult asyncResult)
        {
            return EndInvoke<GetArchiveSearchResultsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIngressPoint

        /// <summary>
        /// Fetch ingress endpoint resource attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIngressPoint service method.</param>
        /// 
        /// <returns>The response from the GetIngressPoint service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetIngressPoint">REST API Reference for GetIngressPoint Operation</seealso>
        public virtual GetIngressPointResponse GetIngressPoint(GetIngressPointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIngressPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIngressPointResponseUnmarshaller.Instance;

            return Invoke<GetIngressPointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIngressPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIngressPoint operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIngressPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetIngressPoint">REST API Reference for GetIngressPoint Operation</seealso>
        public virtual IAsyncResult BeginGetIngressPoint(GetIngressPointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIngressPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIngressPointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIngressPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIngressPoint.</param>
        /// 
        /// <returns>Returns a  GetIngressPointResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetIngressPoint">REST API Reference for GetIngressPoint Operation</seealso>
        public virtual GetIngressPointResponse EndGetIngressPoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIngressPointResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMemberOfAddressList

        /// <summary>
        /// Fetch attributes of a member in an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMemberOfAddressList service method.</param>
        /// 
        /// <returns>The response from the GetMemberOfAddressList service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetMemberOfAddressList">REST API Reference for GetMemberOfAddressList Operation</seealso>
        public virtual GetMemberOfAddressListResponse GetMemberOfAddressList(GetMemberOfAddressListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMemberOfAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMemberOfAddressListResponseUnmarshaller.Instance;

            return Invoke<GetMemberOfAddressListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMemberOfAddressList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMemberOfAddressList operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMemberOfAddressList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetMemberOfAddressList">REST API Reference for GetMemberOfAddressList Operation</seealso>
        public virtual IAsyncResult BeginGetMemberOfAddressList(GetMemberOfAddressListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMemberOfAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMemberOfAddressListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMemberOfAddressList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMemberOfAddressList.</param>
        /// 
        /// <returns>Returns a  GetMemberOfAddressListResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetMemberOfAddressList">REST API Reference for GetMemberOfAddressList Operation</seealso>
        public virtual GetMemberOfAddressListResponse EndGetMemberOfAddressList(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMemberOfAddressListResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRelay

        /// <summary>
        /// Fetch the relay resource and it's attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelay service method.</param>
        /// 
        /// <returns>The response from the GetRelay service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetRelay">REST API Reference for GetRelay Operation</seealso>
        public virtual GetRelayResponse GetRelay(GetRelayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRelayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelayResponseUnmarshaller.Instance;

            return Invoke<GetRelayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRelay operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRelay operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRelay
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetRelay">REST API Reference for GetRelay Operation</seealso>
        public virtual IAsyncResult BeginGetRelay(GetRelayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRelayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRelayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRelay operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRelay.</param>
        /// 
        /// <returns>Returns a  GetRelayResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetRelay">REST API Reference for GetRelay Operation</seealso>
        public virtual GetRelayResponse EndGetRelay(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRelayResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRuleSet

        /// <summary>
        /// Fetch attributes of a rule set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRuleSet service method.</param>
        /// 
        /// <returns>The response from the GetRuleSet service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetRuleSet">REST API Reference for GetRuleSet Operation</seealso>
        public virtual GetRuleSetResponse GetRuleSet(GetRuleSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleSetResponseUnmarshaller.Instance;

            return Invoke<GetRuleSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRuleSet operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetRuleSet">REST API Reference for GetRuleSet Operation</seealso>
        public virtual IAsyncResult BeginGetRuleSet(GetRuleSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRuleSet.</param>
        /// 
        /// <returns>Returns a  GetRuleSetResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetRuleSet">REST API Reference for GetRuleSet Operation</seealso>
        public virtual GetRuleSetResponse EndGetRuleSet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRuleSetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTrafficPolicy

        /// <summary>
        /// Fetch attributes of a traffic policy resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicy service method.</param>
        /// 
        /// <returns>The response from the GetTrafficPolicy service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetTrafficPolicy">REST API Reference for GetTrafficPolicy Operation</seealso>
        public virtual GetTrafficPolicyResponse GetTrafficPolicy(GetTrafficPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<GetTrafficPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrafficPolicy operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTrafficPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetTrafficPolicy">REST API Reference for GetTrafficPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetTrafficPolicy(GetTrafficPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrafficPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTrafficPolicy.</param>
        /// 
        /// <returns>Returns a  GetTrafficPolicyResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/GetTrafficPolicy">REST API Reference for GetTrafficPolicy Operation</seealso>
        public virtual GetTrafficPolicyResponse EndGetTrafficPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTrafficPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAddonInstances

        /// <summary>
        /// Lists all Add On instances in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAddonInstances service method.</param>
        /// 
        /// <returns>The response from the ListAddonInstances service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddonInstances">REST API Reference for ListAddonInstances Operation</seealso>
        public virtual ListAddonInstancesResponse ListAddonInstances(ListAddonInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAddonInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddonInstancesResponseUnmarshaller.Instance;

            return Invoke<ListAddonInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAddonInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAddonInstances operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAddonInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddonInstances">REST API Reference for ListAddonInstances Operation</seealso>
        public virtual IAsyncResult BeginListAddonInstances(ListAddonInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAddonInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddonInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAddonInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAddonInstances.</param>
        /// 
        /// <returns>Returns a  ListAddonInstancesResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddonInstances">REST API Reference for ListAddonInstances Operation</seealso>
        public virtual ListAddonInstancesResponse EndListAddonInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAddonInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAddonSubscriptions

        /// <summary>
        /// Lists all Add On subscriptions in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAddonSubscriptions service method.</param>
        /// 
        /// <returns>The response from the ListAddonSubscriptions service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddonSubscriptions">REST API Reference for ListAddonSubscriptions Operation</seealso>
        public virtual ListAddonSubscriptionsResponse ListAddonSubscriptions(ListAddonSubscriptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAddonSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddonSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListAddonSubscriptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAddonSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAddonSubscriptions operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAddonSubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddonSubscriptions">REST API Reference for ListAddonSubscriptions Operation</seealso>
        public virtual IAsyncResult BeginListAddonSubscriptions(ListAddonSubscriptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAddonSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddonSubscriptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAddonSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAddonSubscriptions.</param>
        /// 
        /// <returns>Returns a  ListAddonSubscriptionsResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddonSubscriptions">REST API Reference for ListAddonSubscriptions Operation</seealso>
        public virtual ListAddonSubscriptionsResponse EndListAddonSubscriptions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAddonSubscriptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAddressListImportJobs

        /// <summary>
        /// Lists jobs for an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAddressListImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListAddressListImportJobs service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddressListImportJobs">REST API Reference for ListAddressListImportJobs Operation</seealso>
        public virtual ListAddressListImportJobsResponse ListAddressListImportJobs(ListAddressListImportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAddressListImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddressListImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListAddressListImportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAddressListImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAddressListImportJobs operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAddressListImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddressListImportJobs">REST API Reference for ListAddressListImportJobs Operation</seealso>
        public virtual IAsyncResult BeginListAddressListImportJobs(ListAddressListImportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAddressListImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddressListImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAddressListImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAddressListImportJobs.</param>
        /// 
        /// <returns>Returns a  ListAddressListImportJobsResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddressListImportJobs">REST API Reference for ListAddressListImportJobs Operation</seealso>
        public virtual ListAddressListImportJobsResponse EndListAddressListImportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAddressListImportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAddressLists

        /// <summary>
        /// Lists address lists for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAddressLists service method.</param>
        /// 
        /// <returns>The response from the ListAddressLists service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddressLists">REST API Reference for ListAddressLists Operation</seealso>
        public virtual ListAddressListsResponse ListAddressLists(ListAddressListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAddressListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddressListsResponseUnmarshaller.Instance;

            return Invoke<ListAddressListsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAddressLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAddressLists operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAddressLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddressLists">REST API Reference for ListAddressLists Operation</seealso>
        public virtual IAsyncResult BeginListAddressLists(ListAddressListsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAddressListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAddressListsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAddressLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAddressLists.</param>
        /// 
        /// <returns>Returns a  ListAddressListsResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListAddressLists">REST API Reference for ListAddressLists Operation</seealso>
        public virtual ListAddressListsResponse EndListAddressLists(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAddressListsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListArchiveExports

        /// <summary>
        /// Returns a list of email archive export jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArchiveExports service method.</param>
        /// 
        /// <returns>The response from the ListArchiveExports service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchiveExports">REST API Reference for ListArchiveExports Operation</seealso>
        public virtual ListArchiveExportsResponse ListArchiveExports(ListArchiveExportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListArchiveExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArchiveExportsResponseUnmarshaller.Instance;

            return Invoke<ListArchiveExportsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListArchiveExports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListArchiveExports operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListArchiveExports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchiveExports">REST API Reference for ListArchiveExports Operation</seealso>
        public virtual IAsyncResult BeginListArchiveExports(ListArchiveExportsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListArchiveExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArchiveExportsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListArchiveExports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListArchiveExports.</param>
        /// 
        /// <returns>Returns a  ListArchiveExportsResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchiveExports">REST API Reference for ListArchiveExports Operation</seealso>
        public virtual ListArchiveExportsResponse EndListArchiveExports(IAsyncResult asyncResult)
        {
            return EndInvoke<ListArchiveExportsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListArchives

        /// <summary>
        /// Returns a list of all email archives in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArchives service method.</param>
        /// 
        /// <returns>The response from the ListArchives service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchives">REST API Reference for ListArchives Operation</seealso>
        public virtual ListArchivesResponse ListArchives(ListArchivesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListArchivesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArchivesResponseUnmarshaller.Instance;

            return Invoke<ListArchivesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListArchives operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListArchives operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListArchives
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchives">REST API Reference for ListArchives Operation</seealso>
        public virtual IAsyncResult BeginListArchives(ListArchivesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListArchivesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArchivesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListArchives operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListArchives.</param>
        /// 
        /// <returns>Returns a  ListArchivesResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchives">REST API Reference for ListArchives Operation</seealso>
        public virtual ListArchivesResponse EndListArchives(IAsyncResult asyncResult)
        {
            return EndInvoke<ListArchivesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListArchiveSearches

        /// <summary>
        /// Returns a list of email archive search jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArchiveSearches service method.</param>
        /// 
        /// <returns>The response from the ListArchiveSearches service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchiveSearches">REST API Reference for ListArchiveSearches Operation</seealso>
        public virtual ListArchiveSearchesResponse ListArchiveSearches(ListArchiveSearchesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListArchiveSearchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArchiveSearchesResponseUnmarshaller.Instance;

            return Invoke<ListArchiveSearchesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListArchiveSearches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListArchiveSearches operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListArchiveSearches
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchiveSearches">REST API Reference for ListArchiveSearches Operation</seealso>
        public virtual IAsyncResult BeginListArchiveSearches(ListArchiveSearchesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListArchiveSearchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArchiveSearchesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListArchiveSearches operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListArchiveSearches.</param>
        /// 
        /// <returns>Returns a  ListArchiveSearchesResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListArchiveSearches">REST API Reference for ListArchiveSearches Operation</seealso>
        public virtual ListArchiveSearchesResponse EndListArchiveSearches(IAsyncResult asyncResult)
        {
            return EndInvoke<ListArchiveSearchesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIngressPoints

        /// <summary>
        /// List all ingress endpoint resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngressPoints service method.</param>
        /// 
        /// <returns>The response from the ListIngressPoints service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListIngressPoints">REST API Reference for ListIngressPoints Operation</seealso>
        public virtual ListIngressPointsResponse ListIngressPoints(ListIngressPointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIngressPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIngressPointsResponseUnmarshaller.Instance;

            return Invoke<ListIngressPointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIngressPoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIngressPoints operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIngressPoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListIngressPoints">REST API Reference for ListIngressPoints Operation</seealso>
        public virtual IAsyncResult BeginListIngressPoints(ListIngressPointsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIngressPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIngressPointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIngressPoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIngressPoints.</param>
        /// 
        /// <returns>Returns a  ListIngressPointsResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListIngressPoints">REST API Reference for ListIngressPoints Operation</seealso>
        public virtual ListIngressPointsResponse EndListIngressPoints(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIngressPointsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMembersOfAddressList

        /// <summary>
        /// Lists members of an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembersOfAddressList service method.</param>
        /// 
        /// <returns>The response from the ListMembersOfAddressList service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListMembersOfAddressList">REST API Reference for ListMembersOfAddressList Operation</seealso>
        public virtual ListMembersOfAddressListResponse ListMembersOfAddressList(ListMembersOfAddressListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMembersOfAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersOfAddressListResponseUnmarshaller.Instance;

            return Invoke<ListMembersOfAddressListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMembersOfAddressList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMembersOfAddressList operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMembersOfAddressList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListMembersOfAddressList">REST API Reference for ListMembersOfAddressList Operation</seealso>
        public virtual IAsyncResult BeginListMembersOfAddressList(ListMembersOfAddressListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMembersOfAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMembersOfAddressListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMembersOfAddressList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMembersOfAddressList.</param>
        /// 
        /// <returns>Returns a  ListMembersOfAddressListResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListMembersOfAddressList">REST API Reference for ListMembersOfAddressList Operation</seealso>
        public virtual ListMembersOfAddressListResponse EndListMembersOfAddressList(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMembersOfAddressListResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRelays

        /// <summary>
        /// Lists all the existing relay resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRelays service method.</param>
        /// 
        /// <returns>The response from the ListRelays service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListRelays">REST API Reference for ListRelays Operation</seealso>
        public virtual ListRelaysResponse ListRelays(ListRelaysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRelaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRelaysResponseUnmarshaller.Instance;

            return Invoke<ListRelaysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRelays operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRelays operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRelays
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListRelays">REST API Reference for ListRelays Operation</seealso>
        public virtual IAsyncResult BeginListRelays(ListRelaysRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRelaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRelaysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRelays operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRelays.</param>
        /// 
        /// <returns>Returns a  ListRelaysResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListRelays">REST API Reference for ListRelays Operation</seealso>
        public virtual ListRelaysResponse EndListRelays(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRelaysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRuleSets

        /// <summary>
        /// List rule sets for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleSets service method.</param>
        /// 
        /// <returns>The response from the ListRuleSets service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListRuleSets">REST API Reference for ListRuleSets Operation</seealso>
        public virtual ListRuleSetsResponse ListRuleSets(ListRuleSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuleSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleSetsResponseUnmarshaller.Instance;

            return Invoke<ListRuleSetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRuleSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuleSets operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRuleSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListRuleSets">REST API Reference for ListRuleSets Operation</seealso>
        public virtual IAsyncResult BeginListRuleSets(ListRuleSetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuleSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleSetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuleSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuleSets.</param>
        /// 
        /// <returns>Returns a  ListRuleSetsResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListRuleSets">REST API Reference for ListRuleSets Operation</seealso>
        public virtual ListRuleSetsResponse EndListRuleSets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRuleSetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Retrieves the list of tags (keys and values) assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTrafficPolicies

        /// <summary>
        /// List traffic policy resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicies service method.</param>
        /// 
        /// <returns>The response from the ListTrafficPolicies service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListTrafficPolicies">REST API Reference for ListTrafficPolicies Operation</seealso>
        public virtual ListTrafficPoliciesResponse ListTrafficPolicies(ListTrafficPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrafficPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrafficPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListTrafficPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrafficPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrafficPolicies operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrafficPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListTrafficPolicies">REST API Reference for ListTrafficPolicies Operation</seealso>
        public virtual IAsyncResult BeginListTrafficPolicies(ListTrafficPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrafficPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrafficPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrafficPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrafficPolicies.</param>
        /// 
        /// <returns>Returns a  ListTrafficPoliciesResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/ListTrafficPolicies">REST API Reference for ListTrafficPolicies Operation</seealso>
        public virtual ListTrafficPoliciesResponse EndListTrafficPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTrafficPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterMemberToAddressList

        /// <summary>
        /// Adds a member to an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterMemberToAddressList service method.</param>
        /// 
        /// <returns>The response from the RegisterMemberToAddressList service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/RegisterMemberToAddressList">REST API Reference for RegisterMemberToAddressList Operation</seealso>
        public virtual RegisterMemberToAddressListResponse RegisterMemberToAddressList(RegisterMemberToAddressListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterMemberToAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterMemberToAddressListResponseUnmarshaller.Instance;

            return Invoke<RegisterMemberToAddressListResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterMemberToAddressList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterMemberToAddressList operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterMemberToAddressList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/RegisterMemberToAddressList">REST API Reference for RegisterMemberToAddressList Operation</seealso>
        public virtual IAsyncResult BeginRegisterMemberToAddressList(RegisterMemberToAddressListRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterMemberToAddressListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterMemberToAddressListResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterMemberToAddressList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterMemberToAddressList.</param>
        /// 
        /// <returns>Returns a  RegisterMemberToAddressListResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/RegisterMemberToAddressList">REST API Reference for RegisterMemberToAddressList Operation</seealso>
        public virtual RegisterMemberToAddressListResponse EndRegisterMemberToAddressList(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterMemberToAddressListResponse>(asyncResult);
        }

        #endregion
        
        #region  StartAddressListImportJob

        /// <summary>
        /// Starts an import job for an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAddressListImportJob service method.</param>
        /// 
        /// <returns>The response from the StartAddressListImportJob service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartAddressListImportJob">REST API Reference for StartAddressListImportJob Operation</seealso>
        public virtual StartAddressListImportJobResponse StartAddressListImportJob(StartAddressListImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAddressListImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAddressListImportJobResponseUnmarshaller.Instance;

            return Invoke<StartAddressListImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartAddressListImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAddressListImportJob operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAddressListImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartAddressListImportJob">REST API Reference for StartAddressListImportJob Operation</seealso>
        public virtual IAsyncResult BeginStartAddressListImportJob(StartAddressListImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAddressListImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAddressListImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartAddressListImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAddressListImportJob.</param>
        /// 
        /// <returns>Returns a  StartAddressListImportJobResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartAddressListImportJob">REST API Reference for StartAddressListImportJob Operation</seealso>
        public virtual StartAddressListImportJobResponse EndStartAddressListImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartAddressListImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartArchiveExport

        /// <summary>
        /// Initiates an export of emails from the specified archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartArchiveExport service method.</param>
        /// 
        /// <returns>The response from the StartArchiveExport service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartArchiveExport">REST API Reference for StartArchiveExport Operation</seealso>
        public virtual StartArchiveExportResponse StartArchiveExport(StartArchiveExportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartArchiveExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartArchiveExportResponseUnmarshaller.Instance;

            return Invoke<StartArchiveExportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartArchiveExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartArchiveExport operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartArchiveExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartArchiveExport">REST API Reference for StartArchiveExport Operation</seealso>
        public virtual IAsyncResult BeginStartArchiveExport(StartArchiveExportRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartArchiveExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartArchiveExportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartArchiveExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartArchiveExport.</param>
        /// 
        /// <returns>Returns a  StartArchiveExportResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartArchiveExport">REST API Reference for StartArchiveExport Operation</seealso>
        public virtual StartArchiveExportResponse EndStartArchiveExport(IAsyncResult asyncResult)
        {
            return EndInvoke<StartArchiveExportResponse>(asyncResult);
        }

        #endregion
        
        #region  StartArchiveSearch

        /// <summary>
        /// Initiates a search across emails in the specified archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartArchiveSearch service method.</param>
        /// 
        /// <returns>The response from the StartArchiveSearch service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartArchiveSearch">REST API Reference for StartArchiveSearch Operation</seealso>
        public virtual StartArchiveSearchResponse StartArchiveSearch(StartArchiveSearchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartArchiveSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartArchiveSearchResponseUnmarshaller.Instance;

            return Invoke<StartArchiveSearchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartArchiveSearch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartArchiveSearch operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartArchiveSearch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartArchiveSearch">REST API Reference for StartArchiveSearch Operation</seealso>
        public virtual IAsyncResult BeginStartArchiveSearch(StartArchiveSearchRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartArchiveSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartArchiveSearchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartArchiveSearch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartArchiveSearch.</param>
        /// 
        /// <returns>Returns a  StartArchiveSearchResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StartArchiveSearch">REST API Reference for StartArchiveSearch Operation</seealso>
        public virtual StartArchiveSearchResponse EndStartArchiveSearch(IAsyncResult asyncResult)
        {
            return EndInvoke<StartArchiveSearchResponse>(asyncResult);
        }

        #endregion
        
        #region  StopAddressListImportJob

        /// <summary>
        /// Stops an ongoing import job for an address list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopAddressListImportJob service method.</param>
        /// 
        /// <returns>The response from the StopAddressListImportJob service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopAddressListImportJob">REST API Reference for StopAddressListImportJob Operation</seealso>
        public virtual StopAddressListImportJobResponse StopAddressListImportJob(StopAddressListImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopAddressListImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAddressListImportJobResponseUnmarshaller.Instance;

            return Invoke<StopAddressListImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopAddressListImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopAddressListImportJob operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopAddressListImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopAddressListImportJob">REST API Reference for StopAddressListImportJob Operation</seealso>
        public virtual IAsyncResult BeginStopAddressListImportJob(StopAddressListImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopAddressListImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAddressListImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopAddressListImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopAddressListImportJob.</param>
        /// 
        /// <returns>Returns a  StopAddressListImportJobResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopAddressListImportJob">REST API Reference for StopAddressListImportJob Operation</seealso>
        public virtual StopAddressListImportJobResponse EndStopAddressListImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopAddressListImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopArchiveExport

        /// <summary>
        /// Stops an in-progress export of emails from an archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopArchiveExport service method.</param>
        /// 
        /// <returns>The response from the StopArchiveExport service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopArchiveExport">REST API Reference for StopArchiveExport Operation</seealso>
        public virtual StopArchiveExportResponse StopArchiveExport(StopArchiveExportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopArchiveExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopArchiveExportResponseUnmarshaller.Instance;

            return Invoke<StopArchiveExportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopArchiveExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopArchiveExport operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopArchiveExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopArchiveExport">REST API Reference for StopArchiveExport Operation</seealso>
        public virtual IAsyncResult BeginStopArchiveExport(StopArchiveExportRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopArchiveExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopArchiveExportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopArchiveExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopArchiveExport.</param>
        /// 
        /// <returns>Returns a  StopArchiveExportResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopArchiveExport">REST API Reference for StopArchiveExport Operation</seealso>
        public virtual StopArchiveExportResponse EndStopArchiveExport(IAsyncResult asyncResult)
        {
            return EndInvoke<StopArchiveExportResponse>(asyncResult);
        }

        #endregion
        
        #region  StopArchiveSearch

        /// <summary>
        /// Stops an in-progress archive search job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopArchiveSearch service method.</param>
        /// 
        /// <returns>The response from the StopArchiveSearch service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopArchiveSearch">REST API Reference for StopArchiveSearch Operation</seealso>
        public virtual StopArchiveSearchResponse StopArchiveSearch(StopArchiveSearchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopArchiveSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopArchiveSearchResponseUnmarshaller.Instance;

            return Invoke<StopArchiveSearchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopArchiveSearch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopArchiveSearch operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopArchiveSearch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopArchiveSearch">REST API Reference for StopArchiveSearch Operation</seealso>
        public virtual IAsyncResult BeginStopArchiveSearch(StopArchiveSearchRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopArchiveSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopArchiveSearchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopArchiveSearch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopArchiveSearch.</param>
        /// 
        /// <returns>Returns a  StopArchiveSearchResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/StopArchiveSearch">REST API Reference for StopArchiveSearch Operation</seealso>
        public virtual StopArchiveSearchResponse EndStopArchiveSearch(IAsyncResult asyncResult)
        {
            return EndInvoke<StopArchiveSearchResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds one or more tags (keys and values) to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Remove one or more tags (keys and values) from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateArchive

        /// <summary>
        /// Updates the attributes of an existing email archive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateArchive service method.</param>
        /// 
        /// <returns>The response from the UpdateArchive service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.AccessDeniedException">
        /// Occurs when a user is denied access to a specific resource or action.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ServiceQuotaExceededException">
        /// Occurs when an operation exceeds a predefined service quota or limit.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ThrottlingException">
        /// Occurs when a service's request rate limit is exceeded, resulting in throttling of
        /// further requests.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateArchive">REST API Reference for UpdateArchive Operation</seealso>
        public virtual UpdateArchiveResponse UpdateArchive(UpdateArchiveRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateArchiveResponseUnmarshaller.Instance;

            return Invoke<UpdateArchiveResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateArchive operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateArchive operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateArchive
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateArchive">REST API Reference for UpdateArchive Operation</seealso>
        public virtual IAsyncResult BeginUpdateArchive(UpdateArchiveRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateArchiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateArchiveResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateArchive operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateArchive.</param>
        /// 
        /// <returns>Returns a  UpdateArchiveResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateArchive">REST API Reference for UpdateArchive Operation</seealso>
        public virtual UpdateArchiveResponse EndUpdateArchive(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateArchiveResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIngressPoint

        /// <summary>
        /// Update attributes of a provisioned ingress endpoint resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIngressPoint service method.</param>
        /// 
        /// <returns>The response from the UpdateIngressPoint service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateIngressPoint">REST API Reference for UpdateIngressPoint Operation</seealso>
        public virtual UpdateIngressPointResponse UpdateIngressPoint(UpdateIngressPointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIngressPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIngressPointResponseUnmarshaller.Instance;

            return Invoke<UpdateIngressPointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIngressPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIngressPoint operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIngressPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateIngressPoint">REST API Reference for UpdateIngressPoint Operation</seealso>
        public virtual IAsyncResult BeginUpdateIngressPoint(UpdateIngressPointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIngressPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIngressPointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIngressPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIngressPoint.</param>
        /// 
        /// <returns>Returns a  UpdateIngressPointResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateIngressPoint">REST API Reference for UpdateIngressPoint Operation</seealso>
        public virtual UpdateIngressPointResponse EndUpdateIngressPoint(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIngressPointResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRelay

        /// <summary>
        /// Updates the attributes of an existing relay resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelay service method.</param>
        /// 
        /// <returns>The response from the UpdateRelay service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateRelay">REST API Reference for UpdateRelay Operation</seealso>
        public virtual UpdateRelayResponse UpdateRelay(UpdateRelayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRelayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRelayResponseUnmarshaller.Instance;

            return Invoke<UpdateRelayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRelay operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelay operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRelay
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateRelay">REST API Reference for UpdateRelay Operation</seealso>
        public virtual IAsyncResult BeginUpdateRelay(UpdateRelayRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRelayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRelayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRelay operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRelay.</param>
        /// 
        /// <returns>Returns a  UpdateRelayResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateRelay">REST API Reference for UpdateRelay Operation</seealso>
        public virtual UpdateRelayResponse EndUpdateRelay(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRelayResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRuleSet

        /// <summary>
        /// Update attributes of an already provisioned rule set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleSet service method.</param>
        /// 
        /// <returns>The response from the UpdateRuleSet service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateRuleSet">REST API Reference for UpdateRuleSet Operation</seealso>
        public virtual UpdateRuleSetResponse UpdateRuleSet(UpdateRuleSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleSetResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleSet operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRuleSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateRuleSet">REST API Reference for UpdateRuleSet Operation</seealso>
        public virtual IAsyncResult BeginUpdateRuleSet(UpdateRuleSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRuleSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRuleSet.</param>
        /// 
        /// <returns>Returns a  UpdateRuleSetResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateRuleSet">REST API Reference for UpdateRuleSet Operation</seealso>
        public virtual UpdateRuleSetResponse EndUpdateRuleSet(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRuleSetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTrafficPolicy

        /// <summary>
        /// Update attributes of an already provisioned traffic policy resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateTrafficPolicy service method, as returned by MailManager.</returns>
        /// <exception cref="Amazon.MailManager.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ResourceNotFoundException">
        /// Occurs when a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.MailManager.Model.ValidationException">
        /// The request validation has failed. For details, see the accompanying error message.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateTrafficPolicy">REST API Reference for UpdateTrafficPolicy Operation</seealso>
        public virtual UpdateTrafficPolicyResponse UpdateTrafficPolicy(UpdateTrafficPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrafficPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateTrafficPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrafficPolicy operation on AmazonMailManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTrafficPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateTrafficPolicy">REST API Reference for UpdateTrafficPolicy Operation</seealso>
        public virtual IAsyncResult BeginUpdateTrafficPolicy(UpdateTrafficPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTrafficPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrafficPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTrafficPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTrafficPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateTrafficPolicyResult from MailManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mailmanager-2023-10-17/UpdateTrafficPolicy">REST API Reference for UpdateTrafficPolicy Operation</seealso>
        public virtual UpdateTrafficPolicyResponse EndUpdateTrafficPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTrafficPolicyResponse>(asyncResult);
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
            var resolver = new AmazonMailManagerEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}