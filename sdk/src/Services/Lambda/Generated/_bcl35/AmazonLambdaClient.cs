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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Lambda.Model;
using Amazon.Lambda.Model.Internal.MarshallTransformations;
using Amazon.Lambda.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Lambda
{
    /// <summary>
    /// Implementation for accessing Lambda
    ///
    /// Lambda 
    /// <para>
    ///  <b>Overview</b> 
    /// </para>
    ///  
    /// <para>
    /// Lambda is a compute service that lets you run code without provisioning or managing
    /// servers. Lambda runs your code on a high-availability compute infrastructure and performs
    /// all of the administration of the compute resources, including server and operating
    /// system maintenance, capacity provisioning and automatic scaling, code monitoring and
    /// logging. With Lambda, you can run code for virtually any type of application or backend
    /// service. For more information about the Lambda service, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/welcome.html">What
    /// is Lambda</a> in the <b>Lambda Developer Guide</b>.
    /// </para>
    ///  
    /// <para>
    /// The <i>Lambda API Reference</i> provides information about each of the API methods,
    /// including details about the parameters in each API request and response. 
    /// </para>
    ///   
    /// <para>
    /// You can use Software Development Kits (SDKs), Integrated Development Environment (IDE)
    /// Toolkits, and command line tools to access the API. For installation instructions,
    /// see <a href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a>. 
    /// </para>
    ///  
    /// <para>
    /// For a list of Region-specific endpoints that Lambda supports, see <a href="https://docs.aws.amazon.com/general/latest/gr/lambda-service.html/">Lambda
    /// endpoints and quotas </a> in the <i>Amazon Web Services General Reference.</i>. 
    /// </para>
    ///  
    /// <para>
    /// When making the API calls, you will need to authenticate your request by providing
    /// a signature. Lambda supports signature version 4. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 signing process</a> in the <i>Amazon Web Services General Reference.</i>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>CA certificates</b> 
    /// </para>
    ///  
    /// <para>
    /// Because Amazon Web Services SDKs use the CA certificates from your computer, changes
    /// to the certificates on the Amazon Web Services servers can cause connection failures
    /// when you attempt to use an SDK. You can prevent these failures by keeping your computer's
    /// CA certificates and operating system up-to-date. If you encounter this issue in a
    /// corporate environment and do not manage your own computer, you might need to ask an
    /// administrator to assist with the update process. The following list shows minimum
    /// operating system and Java versions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Microsoft Windows versions that have updates from January 2005 or later installed
    /// contain at least one of the required CAs in their trust list. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Mac OS X 10.4 with Java for Mac OS X 10.4 Release 5 (February 2007), Mac OS X 10.5
    /// (October 2007), and later versions contain at least one of the required CAs in their
    /// trust list. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Red Hat Enterprise Linux 5 (March 2007), 6, and 7 and CentOS 5, 6, and 7 all contain
    /// at least one of the required CAs in their default trusted CA list. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Java 1.4.2_12 (May 2006), 5 Update 2 (March 2005), and all later versions, including
    /// Java 6 (December 2006), 7, and 8, contain at least one of the required CAs in their
    /// default trusted CA list. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When accessing the Lambda management console or Lambda API endpoints, whether through
    /// browsers or programmatically, you will need to ensure your client machines support
    /// any of the following CAs: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon Root CA 1
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Starfield Services Root Certificate Authority - G2
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Starfield Class 2 Certification Authority
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Root certificates from the first two authorities are available from <a href="https://www.amazontrust.com/repository/">Amazon
    /// trust services</a>, but keeping your computer up-to-date is the more straightforward
    /// solution. To learn more about ACM-provided certificates, see <a href="http://aws.amazon.com/certificate-manager/faqs/#certificates">Amazon
    /// Web Services Certificate Manager FAQs.</a> 
    /// </para>
    /// </summary>
    public partial class AmazonLambdaClient : AmazonServiceClient, IAmazonLambda
    {
        private static IServiceMetadata serviceMetadata = new AmazonLambdaMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ILambdaPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ILambdaPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new LambdaPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonLambdaClient with the credentials loaded from the application's
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
        public AmazonLambdaClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLambdaConfig()) { }

        /// <summary>
        /// Constructs AmazonLambdaClient with the credentials loaded from the application's
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
        public AmazonLambdaClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLambdaConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLambdaClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLambdaClient Configuration Object</param>
        public AmazonLambdaClient(AmazonLambdaConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLambdaClient(AWSCredentials credentials)
            : this(credentials, new AmazonLambdaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLambdaConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Credentials and an
        /// AmazonLambdaClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLambdaClient Configuration Object</param>
        public AmazonLambdaClient(AWSCredentials credentials, AmazonLambdaConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLambdaClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLambdaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLambdaConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLambdaClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLambdaClient Configuration Object</param>
        public AmazonLambdaClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLambdaConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLambdaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLambdaConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLambdaConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLambdaClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLambdaClient Configuration Object</param>
        public AmazonLambdaClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLambdaConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLambdaEndpointResolver());
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


        #region  AddLayerVersionPermission

        /// <summary>
        /// Adds permissions to the resource-based policy of a version of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>. Use this action to grant layer usage permission to other accounts. You
        /// can grant permission to a single account, all accounts in an organization, or all
        /// Amazon Web Services accounts. 
        /// 
        ///  
        /// <para>
        /// To revoke permission, call <a>RemoveLayerVersionPermission</a> with the statement
        /// ID that you specified when you added it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddLayerVersionPermission service method.</param>
        /// 
        /// <returns>The response from the AddLayerVersionPermission service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PolicyLengthExceededException">
        /// The permissions policy for the resource is too large. For more information, see <a
        /// href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddLayerVersionPermission">REST API Reference for AddLayerVersionPermission Operation</seealso>
        public virtual AddLayerVersionPermissionResponse AddLayerVersionPermission(AddLayerVersionPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddLayerVersionPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddLayerVersionPermissionResponseUnmarshaller.Instance;

            return Invoke<AddLayerVersionPermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddLayerVersionPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddLayerVersionPermission operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddLayerVersionPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddLayerVersionPermission">REST API Reference for AddLayerVersionPermission Operation</seealso>
        public virtual IAsyncResult BeginAddLayerVersionPermission(AddLayerVersionPermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddLayerVersionPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddLayerVersionPermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddLayerVersionPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddLayerVersionPermission.</param>
        /// 
        /// <returns>Returns a  AddLayerVersionPermissionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddLayerVersionPermission">REST API Reference for AddLayerVersionPermission Operation</seealso>
        public virtual AddLayerVersionPermissionResponse EndAddLayerVersionPermission(IAsyncResult asyncResult)
        {
            return EndInvoke<AddLayerVersionPermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  AddPermission

        /// <summary>
        /// Grants an Amazon Web Service, Amazon Web Services account, or Amazon Web Services
        /// organization permission to use a function. You can apply the policy at the function
        /// level, or specify a qualifier to restrict access to a single version or alias. If
        /// you use a qualifier, the invoker must use the full Amazon Resource Name (ARN) of that
        /// version or alias to invoke the function. Note: Lambda does not support adding policies
        /// to version $LATEST.
        /// 
        ///  
        /// <para>
        /// To grant permission to another account, specify the account ID as the <code>Principal</code>.
        /// To grant permission to an organization defined in Organizations, specify the organization
        /// ID as the <code>PrincipalOrgID</code>. For Amazon Web Services, the principal is a
        /// domain-style identifier that the service defines, such as <code>s3.amazonaws.com</code>
        /// or <code>sns.amazonaws.com</code>. For Amazon Web Services, you can also specify the
        /// ARN of the associated resource as the <code>SourceArn</code>. If you grant permission
        /// to a service principal without specifying the source, other accounts could potentially
        /// configure resources in their account to invoke your Lambda function.
        /// </para>
        ///  
        /// <para>
        /// This operation adds a statement to a resource-based permissions policy for the function.
        /// For more information about function policies, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/access-control-resource-based.html">Using
        /// resource-based policies for Lambda</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPermission service method.</param>
        /// 
        /// <returns>The response from the AddPermission service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PolicyLengthExceededException">
        /// The permissions policy for the resource is too large. For more information, see <a
        /// href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddPermission">REST API Reference for AddPermission Operation</seealso>
        public virtual AddPermissionResponse AddPermission(AddPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPermissionResponseUnmarshaller.Instance;

            return Invoke<AddPermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddPermission operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddPermission">REST API Reference for AddPermission Operation</seealso>
        public virtual IAsyncResult BeginAddPermission(AddPermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddPermission.</param>
        /// 
        /// <returns>Returns a  AddPermissionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddPermission">REST API Reference for AddPermission Operation</seealso>
        public virtual AddPermissionResponse EndAddPermission(IAsyncResult asyncResult)
        {
            return EndInvoke<AddPermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAlias

        /// <summary>
        /// Creates an <a href="https://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">alias</a>
        /// for a Lambda function version. Use aliases to provide clients with a function identifier
        /// that you can update to invoke a different version.
        /// 
        ///  
        /// <para>
        /// You can also map an alias to split invocation requests between two versions. Use the
        /// <code>RoutingConfig</code> parameter to specify a second version and the percentage
        /// of invocation requests that it receives.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual IAsyncResult BeginCreateAlias(CreateAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAlias.</param>
        /// 
        /// <returns>Returns a  CreateAliasResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual CreateAliasResponse EndCreateAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCodeSigningConfig

        /// <summary>
        /// Creates a code signing configuration. A <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-codesigning.html">code
        /// signing configuration</a> defines a list of allowed signing profiles and defines the
        /// code-signing validation policy (action to be taken if deployment validation checks
        /// fail).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeSigningConfig service method.</param>
        /// 
        /// <returns>The response from the CreateCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateCodeSigningConfig">REST API Reference for CreateCodeSigningConfig Operation</seealso>
        public virtual CreateCodeSigningConfigResponse CreateCodeSigningConfig(CreateCodeSigningConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCodeSigningConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeSigningConfigResponseUnmarshaller.Instance;

            return Invoke<CreateCodeSigningConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCodeSigningConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeSigningConfig operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCodeSigningConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateCodeSigningConfig">REST API Reference for CreateCodeSigningConfig Operation</seealso>
        public virtual IAsyncResult BeginCreateCodeSigningConfig(CreateCodeSigningConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCodeSigningConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCodeSigningConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCodeSigningConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCodeSigningConfig.</param>
        /// 
        /// <returns>Returns a  CreateCodeSigningConfigResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateCodeSigningConfig">REST API Reference for CreateCodeSigningConfig Operation</seealso>
        public virtual CreateCodeSigningConfigResponse EndCreateCodeSigningConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCodeSigningConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEventSourceMapping

        /// <summary>
        /// Creates a mapping between an event source and an Lambda function. Lambda reads items
        /// from the event source and invokes the function.
        /// 
        ///  
        /// <para>
        /// For details about how to configure different event sources, see the following topics.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html#services-dynamodb-eventsourcemapping">
        /// Amazon DynamoDB Streams</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html#services-kinesis-eventsourcemapping">
        /// Amazon Kinesis</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#events-sqs-eventsource">
        /// Amazon SQS</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-mq.html#services-mq-eventsourcemapping">
        /// Amazon MQ and RabbitMQ</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html"> Amazon MSK</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/kafka-smaa.html"> Apache Kafka</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following error handling options are available only for stream sources (DynamoDB
        /// and Kinesis):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BisectBatchOnFunctionError</code> – If the function returns an error, split
        /// the batch in two and retry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DestinationConfig</code> – Send discarded records to an Amazon SQS queue or
        /// Amazon SNS topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaximumRecordAgeInSeconds</code> – Discard records older than the specified
        /// age. The default value is infinite (-1). When set to infinite (-1), failed records
        /// are retried until the record expires
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaximumRetryAttempts</code> – Discard records after the specified number of
        /// retries. The default value is infinite (-1). When set to infinite (-1), failed records
        /// are retried until the record expires.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ParallelizationFactor</code> – Process multiple batches from each shard concurrently.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about which configuration parameters apply to each event source, see
        /// the following topics.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html#services-ddb-params">
        /// Amazon DynamoDB Streams</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html#services-kinesis-params">
        /// Amazon Kinesis</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#services-sqs-params">
        /// Amazon SQS</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-mq.html#services-mq-params">
        /// Amazon MQ and RabbitMQ</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html#services-msk-parms">
        /// Amazon MSK</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kafka.html#services-kafka-parms">
        /// Apache Kafka</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSourceMapping service method.</param>
        /// 
        /// <returns>The response from the CreateEventSourceMapping service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateEventSourceMapping">REST API Reference for CreateEventSourceMapping Operation</seealso>
        public virtual CreateEventSourceMappingResponse CreateEventSourceMapping(CreateEventSourceMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSourceMappingResponseUnmarshaller.Instance;

            return Invoke<CreateEventSourceMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSourceMapping operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventSourceMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateEventSourceMapping">REST API Reference for CreateEventSourceMapping Operation</seealso>
        public virtual IAsyncResult BeginCreateEventSourceMapping(CreateEventSourceMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSourceMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventSourceMapping.</param>
        /// 
        /// <returns>Returns a  CreateEventSourceMappingResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateEventSourceMapping">REST API Reference for CreateEventSourceMapping Operation</seealso>
        public virtual CreateEventSourceMappingResponse EndCreateEventSourceMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEventSourceMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFunction

        /// <summary>
        /// Creates a Lambda function. To create a function, you need a <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-package.html">deployment
        /// package</a> and an <a href="https://docs.aws.amazon.com/lambda/latest/dg/intro-permission-model.html#lambda-intro-execution-role">execution
        /// role</a>. The deployment package is a .zip file archive or container image that contains
        /// your function code. The execution role grants the function permission to use Amazon
        /// Web Services, such as Amazon CloudWatch Logs for log streaming and X-Ray for request
        /// tracing.
        /// 
        ///  
        /// <para>
        /// If the deployment package is a <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-images.html">container
        /// image</a>, then you set the package type to <code>Image</code>. For a container image,
        /// the code property must include the URI of a container image in the Amazon ECR registry.
        /// You do not need to specify the handler and runtime properties.
        /// </para>
        ///  
        /// <para>
        /// If the deployment package is a <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-package.html#gettingstarted-package-zip">.zip
        /// file archive</a>, then you set the package type to <code>Zip</code>. For a .zip file
        /// archive, the code property specifies the location of the .zip file. You must also
        /// specify the handler and runtime properties. The code in the deployment package must
        /// be compatible with the target instruction set architecture of the function (<code>x86-64</code>
        /// or <code>arm64</code>). If you do not specify the architecture, then the default value
        /// is <code>x86-64</code>.
        /// </para>
        ///  
        /// <para>
        /// When you create a function, Lambda provisions an instance of the function and its
        /// supporting resources. If your function connects to a VPC, this process can take a
        /// minute or so. During this time, you can't invoke or modify the function. The <code>State</code>,
        /// <code>StateReason</code>, and <code>StateReasonCode</code> fields in the response
        /// from <a>GetFunctionConfiguration</a> indicate when the function is ready to invoke.
        /// For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/functions-states.html">Lambda
        /// function states</a>.
        /// </para>
        ///  
        /// <para>
        /// A function has an unpublished version, and can have published versions and aliases.
        /// The unpublished version changes when you update your function's code and configuration.
        /// A published version is a snapshot of your function code and configuration that can't
        /// be changed. An alias is a named resource that maps to a version, and can be changed
        /// to map to a different version. Use the <code>Publish</code> parameter to create version
        /// <code>1</code> of your function from its initial configuration.
        /// </para>
        ///  
        /// <para>
        /// The other parameters let you configure version-specific and function-level settings.
        /// You can modify version-specific settings later with <a>UpdateFunctionConfiguration</a>.
        /// Function-level settings apply to both the unpublished and published versions of the
        /// function, and include tags (<a>TagResource</a>) and per-function concurrency limits
        /// (<a>PutFunctionConcurrency</a>).
        /// </para>
        ///  
        /// <para>
        /// You can use code signing if your deployment package is a .zip file archive. To enable
        /// code signing for this function, specify the ARN of a code-signing configuration. When
        /// a user attempts to deploy a code package with <a>UpdateFunctionCode</a>, Lambda checks
        /// that the code package has a valid signature from a trusted publisher. The code-signing
        /// configuration includes set of signing profiles, which define the trusted publishers
        /// for this function.
        /// </para>
        ///  
        /// <para>
        /// If another Amazon Web Services account or an Amazon Web Service invokes your function,
        /// use <a>AddPermission</a> to grant permission by creating a resource-based Identity
        /// and Access Management (IAM) policy. You can grant permissions at the function level,
        /// on a version, or on an alias.
        /// </para>
        ///  
        /// <para>
        /// To invoke your function directly, use <a>Invoke</a>. To invoke your function in response
        /// to events in other Amazon Web Services, create an event source mapping (<a>CreateEventSourceMapping</a>),
        /// or configure a function trigger in the other service. For more information, see <a
        /// href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-invocation.html">Invoking
        /// Lambda functions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFunction service method.</param>
        /// 
        /// <returns>The response from the CreateFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeSigningConfigNotFoundException">
        /// The specified code signing configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.CodeStorageExceededException">
        /// Your Amazon Web Services account has exceeded its maximum total code size. For more
        /// information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.CodeVerificationFailedException">
        /// The code signature failed one or more of the validation checks for signature mismatch
        /// or expiry, and the code signing policy is set to ENFORCE. Lambda blocks the deployment.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidCodeSignatureException">
        /// The code signature failed the integrity check. If the integrity check fails, then
        /// Lambda blocks deployment, even if the code signing policy is set to WARN.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        public virtual CreateFunctionResponse CreateFunction(CreateFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFunctionResponseUnmarshaller.Instance;

            return Invoke<CreateFunctionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFunction operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        public virtual IAsyncResult BeginCreateFunction(CreateFunctionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFunctionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFunction.</param>
        /// 
        /// <returns>Returns a  CreateFunctionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        public virtual CreateFunctionResponse EndCreateFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFunctionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFunctionUrlConfig

        /// <summary>
        /// Creates a Lambda function URL with the specified configuration parameters. A function
        /// URL is a dedicated HTTP(S) endpoint that you can use to invoke your function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFunctionUrlConfig service method.</param>
        /// 
        /// <returns>The response from the CreateFunctionUrlConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateFunctionUrlConfig">REST API Reference for CreateFunctionUrlConfig Operation</seealso>
        public virtual CreateFunctionUrlConfigResponse CreateFunctionUrlConfig(CreateFunctionUrlConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFunctionUrlConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFunctionUrlConfigResponseUnmarshaller.Instance;

            return Invoke<CreateFunctionUrlConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFunctionUrlConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFunctionUrlConfig operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFunctionUrlConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateFunctionUrlConfig">REST API Reference for CreateFunctionUrlConfig Operation</seealso>
        public virtual IAsyncResult BeginCreateFunctionUrlConfig(CreateFunctionUrlConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFunctionUrlConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFunctionUrlConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFunctionUrlConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFunctionUrlConfig.</param>
        /// 
        /// <returns>Returns a  CreateFunctionUrlConfigResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateFunctionUrlConfig">REST API Reference for CreateFunctionUrlConfig Operation</seealso>
        public virtual CreateFunctionUrlConfigResponse EndCreateFunctionUrlConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFunctionUrlConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAlias

        /// <summary>
        /// Deletes a Lambda function <a href="https://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">alias</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual IAsyncResult BeginDeleteAlias(DeleteAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlias.</param>
        /// 
        /// <returns>Returns a  DeleteAliasResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual DeleteAliasResponse EndDeleteAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCodeSigningConfig

        /// <summary>
        /// Deletes the code signing configuration. You can delete the code signing configuration
        /// only if no function is using it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeSigningConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteCodeSigningConfig">REST API Reference for DeleteCodeSigningConfig Operation</seealso>
        public virtual DeleteCodeSigningConfigResponse DeleteCodeSigningConfig(DeleteCodeSigningConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCodeSigningConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCodeSigningConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteCodeSigningConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCodeSigningConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeSigningConfig operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCodeSigningConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteCodeSigningConfig">REST API Reference for DeleteCodeSigningConfig Operation</seealso>
        public virtual IAsyncResult BeginDeleteCodeSigningConfig(DeleteCodeSigningConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCodeSigningConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCodeSigningConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCodeSigningConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCodeSigningConfig.</param>
        /// 
        /// <returns>Returns a  DeleteCodeSigningConfigResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteCodeSigningConfig">REST API Reference for DeleteCodeSigningConfig Operation</seealso>
        public virtual DeleteCodeSigningConfigResponse EndDeleteCodeSigningConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCodeSigningConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEventSourceMapping

        /// <summary>
        /// Deletes an <a href="https://docs.aws.amazon.com/lambda/latest/dg/intro-invocation-modes.html">event
        /// source mapping</a>. You can get the identifier of a mapping from the output of <a>ListEventSourceMappings</a>.
        /// 
        ///  
        /// <para>
        /// When you delete an event source mapping, it enters a <code>Deleting</code> state and
        /// might not be completely deleted for several seconds.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSourceMapping service method.</param>
        /// 
        /// <returns>The response from the DeleteEventSourceMapping service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example, you tried to
        /// update an event source mapping in the CREATING state, or you tried to delete an event
        /// source mapping currently UPDATING.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteEventSourceMapping">REST API Reference for DeleteEventSourceMapping Operation</seealso>
        public virtual DeleteEventSourceMappingResponse DeleteEventSourceMapping(DeleteEventSourceMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSourceMappingResponseUnmarshaller.Instance;

            return Invoke<DeleteEventSourceMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSourceMapping operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventSourceMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteEventSourceMapping">REST API Reference for DeleteEventSourceMapping Operation</seealso>
        public virtual IAsyncResult BeginDeleteEventSourceMapping(DeleteEventSourceMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSourceMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventSourceMapping.</param>
        /// 
        /// <returns>Returns a  DeleteEventSourceMappingResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteEventSourceMapping">REST API Reference for DeleteEventSourceMapping Operation</seealso>
        public virtual DeleteEventSourceMappingResponse EndDeleteEventSourceMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventSourceMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFunction

        /// <summary>
        /// Deletes a Lambda function. To delete a specific function version, use the <code>Qualifier</code>
        /// parameter. Otherwise, all versions and aliases are deleted.
        /// 
        ///  
        /// <para>
        /// To delete Lambda event source mappings that invoke a function, use <a>DeleteEventSourceMapping</a>.
        /// For Amazon Web Services and resources that invoke your function directly, delete the
        /// trigger in the service where you originally configured it.
        /// </para>
        /// </summary>
        /// <param name="functionName">The name of the Lambda function or version. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> – <code>my-function</code> (name-only), <code>my-function:1</code> (with version). </li> <li>  <b>Function ARN</b> – <code>arn:aws:lambda:us-west-2:123456789012:function:my-function</code>. </li> <li>  <b>Partial ARN</b> – <code>123456789012:function:my-function</code>. </li> </ul> You can append a version number or alias to any of the formats. The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
        /// 
        /// <returns>The response from the DeleteFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        public virtual DeleteFunctionResponse DeleteFunction(string functionName)
        {
            var request = new DeleteFunctionRequest();
            request.FunctionName = functionName;
            return DeleteFunction(request);
        }


        /// <summary>
        /// Deletes a Lambda function. To delete a specific function version, use the <code>Qualifier</code>
        /// parameter. Otherwise, all versions and aliases are deleted.
        /// 
        ///  
        /// <para>
        /// To delete Lambda event source mappings that invoke a function, use <a>DeleteEventSourceMapping</a>.
        /// For Amazon Web Services and resources that invoke your function directly, delete the
        /// trigger in the service where you originally configured it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction service method.</param>
        /// 
        /// <returns>The response from the DeleteFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        public virtual DeleteFunctionResponse DeleteFunction(DeleteFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionResponseUnmarshaller.Instance;

            return Invoke<DeleteFunctionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        public virtual IAsyncResult BeginDeleteFunction(DeleteFunctionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFunction.</param>
        /// 
        /// <returns>Returns a  DeleteFunctionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        public virtual DeleteFunctionResponse EndDeleteFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFunctionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFunctionCodeSigningConfig

        /// <summary>
        /// Removes the code signing configuration from the function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionCodeSigningConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteFunctionCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeSigningConfigNotFoundException">
        /// The specified code signing configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionCodeSigningConfig">REST API Reference for DeleteFunctionCodeSigningConfig Operation</seealso>
        public virtual DeleteFunctionCodeSigningConfigResponse DeleteFunctionCodeSigningConfig(DeleteFunctionCodeSigningConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFunctionCodeSigningConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionCodeSigningConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteFunctionCodeSigningConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFunctionCodeSigningConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionCodeSigningConfig operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFunctionCodeSigningConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionCodeSigningConfig">REST API Reference for DeleteFunctionCodeSigningConfig Operation</seealso>
        public virtual IAsyncResult BeginDeleteFunctionCodeSigningConfig(DeleteFunctionCodeSigningConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFunctionCodeSigningConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionCodeSigningConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFunctionCodeSigningConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFunctionCodeSigningConfig.</param>
        /// 
        /// <returns>Returns a  DeleteFunctionCodeSigningConfigResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionCodeSigningConfig">REST API Reference for DeleteFunctionCodeSigningConfig Operation</seealso>
        public virtual DeleteFunctionCodeSigningConfigResponse EndDeleteFunctionCodeSigningConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFunctionCodeSigningConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFunctionConcurrency

        /// <summary>
        /// Removes a concurrent execution limit from a function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionConcurrency service method.</param>
        /// 
        /// <returns>The response from the DeleteFunctionConcurrency service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionConcurrency">REST API Reference for DeleteFunctionConcurrency Operation</seealso>
        public virtual DeleteFunctionConcurrencyResponse DeleteFunctionConcurrency(DeleteFunctionConcurrencyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFunctionConcurrencyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionConcurrencyResponseUnmarshaller.Instance;

            return Invoke<DeleteFunctionConcurrencyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFunctionConcurrency operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionConcurrency operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFunctionConcurrency
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionConcurrency">REST API Reference for DeleteFunctionConcurrency Operation</seealso>
        public virtual IAsyncResult BeginDeleteFunctionConcurrency(DeleteFunctionConcurrencyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFunctionConcurrencyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionConcurrencyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFunctionConcurrency operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFunctionConcurrency.</param>
        /// 
        /// <returns>Returns a  DeleteFunctionConcurrencyResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionConcurrency">REST API Reference for DeleteFunctionConcurrency Operation</seealso>
        public virtual DeleteFunctionConcurrencyResponse EndDeleteFunctionConcurrency(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFunctionConcurrencyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFunctionEventInvokeConfig

        /// <summary>
        /// Deletes the configuration for asynchronous invocation for a function, version, or
        /// alias.
        /// 
        ///  
        /// <para>
        /// To configure options for asynchronous invocation, use <a>PutFunctionEventInvokeConfig</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionEventInvokeConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteFunctionEventInvokeConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionEventInvokeConfig">REST API Reference for DeleteFunctionEventInvokeConfig Operation</seealso>
        public virtual DeleteFunctionEventInvokeConfigResponse DeleteFunctionEventInvokeConfig(DeleteFunctionEventInvokeConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFunctionEventInvokeConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionEventInvokeConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteFunctionEventInvokeConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFunctionEventInvokeConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionEventInvokeConfig operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFunctionEventInvokeConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionEventInvokeConfig">REST API Reference for DeleteFunctionEventInvokeConfig Operation</seealso>
        public virtual IAsyncResult BeginDeleteFunctionEventInvokeConfig(DeleteFunctionEventInvokeConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFunctionEventInvokeConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionEventInvokeConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFunctionEventInvokeConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFunctionEventInvokeConfig.</param>
        /// 
        /// <returns>Returns a  DeleteFunctionEventInvokeConfigResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionEventInvokeConfig">REST API Reference for DeleteFunctionEventInvokeConfig Operation</seealso>
        public virtual DeleteFunctionEventInvokeConfigResponse EndDeleteFunctionEventInvokeConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFunctionEventInvokeConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFunctionUrlConfig

        /// <summary>
        /// Deletes a Lambda function URL. When you delete a function URL, you can't recover it.
        /// Creating a new function URL results in a different URL address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionUrlConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteFunctionUrlConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionUrlConfig">REST API Reference for DeleteFunctionUrlConfig Operation</seealso>
        public virtual DeleteFunctionUrlConfigResponse DeleteFunctionUrlConfig(DeleteFunctionUrlConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFunctionUrlConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionUrlConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteFunctionUrlConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFunctionUrlConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionUrlConfig operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFunctionUrlConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionUrlConfig">REST API Reference for DeleteFunctionUrlConfig Operation</seealso>
        public virtual IAsyncResult BeginDeleteFunctionUrlConfig(DeleteFunctionUrlConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFunctionUrlConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFunctionUrlConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFunctionUrlConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFunctionUrlConfig.</param>
        /// 
        /// <returns>Returns a  DeleteFunctionUrlConfigResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionUrlConfig">REST API Reference for DeleteFunctionUrlConfig Operation</seealso>
        public virtual DeleteFunctionUrlConfigResponse EndDeleteFunctionUrlConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFunctionUrlConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLayerVersion

        /// <summary>
        /// Deletes a version of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>. Deleted versions can no longer be viewed or added to functions. To avoid
        /// breaking functions, a copy of the version remains in Lambda until no functions refer
        /// to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLayerVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteLayerVersion service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteLayerVersion">REST API Reference for DeleteLayerVersion Operation</seealso>
        public virtual DeleteLayerVersionResponse DeleteLayerVersion(DeleteLayerVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLayerVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLayerVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteLayerVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLayerVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLayerVersion operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLayerVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteLayerVersion">REST API Reference for DeleteLayerVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteLayerVersion(DeleteLayerVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLayerVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLayerVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLayerVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLayerVersion.</param>
        /// 
        /// <returns>Returns a  DeleteLayerVersionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteLayerVersion">REST API Reference for DeleteLayerVersion Operation</seealso>
        public virtual DeleteLayerVersionResponse EndDeleteLayerVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLayerVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProvisionedConcurrencyConfig

        /// <summary>
        /// Deletes the provisioned concurrency configuration for a function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisionedConcurrencyConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteProvisionedConcurrencyConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteProvisionedConcurrencyConfig">REST API Reference for DeleteProvisionedConcurrencyConfig Operation</seealso>
        public virtual DeleteProvisionedConcurrencyConfigResponse DeleteProvisionedConcurrencyConfig(DeleteProvisionedConcurrencyConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisionedConcurrencyConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisionedConcurrencyConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteProvisionedConcurrencyConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProvisionedConcurrencyConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisionedConcurrencyConfig operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProvisionedConcurrencyConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteProvisionedConcurrencyConfig">REST API Reference for DeleteProvisionedConcurrencyConfig Operation</seealso>
        public virtual IAsyncResult BeginDeleteProvisionedConcurrencyConfig(DeleteProvisionedConcurrencyConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisionedConcurrencyConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisionedConcurrencyConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProvisionedConcurrencyConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProvisionedConcurrencyConfig.</param>
        /// 
        /// <returns>Returns a  DeleteProvisionedConcurrencyConfigResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteProvisionedConcurrencyConfig">REST API Reference for DeleteProvisionedConcurrencyConfig Operation</seealso>
        public virtual DeleteProvisionedConcurrencyConfigResponse EndDeleteProvisionedConcurrencyConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProvisionedConcurrencyConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccountSettings

        /// <summary>
        /// Retrieves details about your account's <a href="https://docs.aws.amazon.com/lambda/latest/dg/limits.html">limits</a>
        /// and usage in an Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<GetAccountSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual IAsyncResult BeginGetAccountSettings(GetAccountSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountSettings.</param>
        /// 
        /// <returns>Returns a  GetAccountSettingsResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual GetAccountSettingsResponse EndGetAccountSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccountSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAlias

        /// <summary>
        /// Returns details about a Lambda function <a href="https://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">alias</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAlias service method.</param>
        /// 
        /// <returns>The response from the GetAlias service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAlias">REST API Reference for GetAlias Operation</seealso>
        public virtual GetAliasResponse GetAlias(GetAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAliasResponseUnmarshaller.Instance;

            return Invoke<GetAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAlias operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAlias">REST API Reference for GetAlias Operation</seealso>
        public virtual IAsyncResult BeginGetAlias(GetAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAlias.</param>
        /// 
        /// <returns>Returns a  GetAliasResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAlias">REST API Reference for GetAlias Operation</seealso>
        public virtual GetAliasResponse EndGetAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCodeSigningConfig

        /// <summary>
        /// Returns information about the specified code signing configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSigningConfig service method.</param>
        /// 
        /// <returns>The response from the GetCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetCodeSigningConfig">REST API Reference for GetCodeSigningConfig Operation</seealso>
        public virtual GetCodeSigningConfigResponse GetCodeSigningConfig(GetCodeSigningConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCodeSigningConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeSigningConfigResponseUnmarshaller.Instance;

            return Invoke<GetCodeSigningConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCodeSigningConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCodeSigningConfig operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCodeSigningConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetCodeSigningConfig">REST API Reference for GetCodeSigningConfig Operation</seealso>
        public virtual IAsyncResult BeginGetCodeSigningConfig(GetCodeSigningConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCodeSigningConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCodeSigningConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCodeSigningConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCodeSigningConfig.</param>
        /// 
        /// <returns>Returns a  GetCodeSigningConfigResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetCodeSigningConfig">REST API Reference for GetCodeSigningConfig Operation</seealso>
        public virtual GetCodeSigningConfigResponse EndGetCodeSigningConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCodeSigningConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEventSourceMapping

        /// <summary>
        /// Returns details about an event source mapping. You can get the identifier of a mapping
        /// from the output of <a>ListEventSourceMappings</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventSourceMapping service method.</param>
        /// 
        /// <returns>The response from the GetEventSourceMapping service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetEventSourceMapping">REST API Reference for GetEventSourceMapping Operation</seealso>
        public virtual GetEventSourceMappingResponse GetEventSourceMapping(GetEventSourceMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventSourceMappingResponseUnmarshaller.Instance;

            return Invoke<GetEventSourceMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventSourceMapping operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventSourceMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetEventSourceMapping">REST API Reference for GetEventSourceMapping Operation</seealso>
        public virtual IAsyncResult BeginGetEventSourceMapping(GetEventSourceMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventSourceMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventSourceMapping.</param>
        /// 
        /// <returns>Returns a  GetEventSourceMappingResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetEventSourceMapping">REST API Reference for GetEventSourceMapping Operation</seealso>
        public virtual GetEventSourceMappingResponse EndGetEventSourceMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEventSourceMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFunction

        /// <summary>
        /// Returns information about the function or function version, with a link to download
        /// the deployment package that's valid for 10 minutes. If you specify a function version,
        /// only details that are specific to that version are returned.
        /// </summary>
        /// <param name="functionName">The name of the Lambda function, version, or alias. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> – <code>my-function</code> (name-only), <code>my-function:v1</code> (with alias). </li> <li>  <b>Function ARN</b> – <code>arn:aws:lambda:us-west-2:123456789012:function:my-function</code>. </li> <li>  <b>Partial ARN</b> – <code>123456789012:function:my-function</code>. </li> </ul> You can append a version number or alias to any of the formats. The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
        /// 
        /// <returns>The response from the GetFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        public virtual GetFunctionResponse GetFunction(string functionName)
        {
            var request = new GetFunctionRequest();
            request.FunctionName = functionName;
            return GetFunction(request);
        }


        /// <summary>
        /// Returns information about the function or function version, with a link to download
        /// the deployment package that's valid for 10 minutes. If you specify a function version,
        /// only details that are specific to that version are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunction service method.</param>
        /// 
        /// <returns>The response from the GetFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        public virtual GetFunctionResponse GetFunction(GetFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionResponseUnmarshaller.Instance;

            return Invoke<GetFunctionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunction operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        public virtual IAsyncResult BeginGetFunction(GetFunctionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFunction.</param>
        /// 
        /// <returns>Returns a  GetFunctionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        public virtual GetFunctionResponse EndGetFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFunctionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFunctionCodeSigningConfig

        /// <summary>
        /// Returns the code signing configuration for the specified function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionCodeSigningConfig service method.</param>
        /// 
        /// <returns>The response from the GetFunctionCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionCodeSigningConfig">REST API Reference for GetFunctionCodeSigningConfig Operation</seealso>
        public virtual GetFunctionCodeSigningConfigResponse GetFunctionCodeSigningConfig(GetFunctionCodeSigningConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionCodeSigningConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionCodeSigningConfigResponseUnmarshaller.Instance;

            return Invoke<GetFunctionCodeSigningConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFunctionCodeSigningConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionCodeSigningConfig operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFunctionCodeSigningConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionCodeSigningConfig">REST API Reference for GetFunctionCodeSigningConfig Operation</seealso>
        public virtual IAsyncResult BeginGetFunctionCodeSigningConfig(GetFunctionCodeSigningConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionCodeSigningConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionCodeSigningConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFunctionCodeSigningConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFunctionCodeSigningConfig.</param>
        /// 
        /// <returns>Returns a  GetFunctionCodeSigningConfigResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionCodeSigningConfig">REST API Reference for GetFunctionCodeSigningConfig Operation</seealso>
        public virtual GetFunctionCodeSigningConfigResponse EndGetFunctionCodeSigningConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFunctionCodeSigningConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFunctionConcurrency

        /// <summary>
        /// Returns details about the reserved concurrency configuration for a function. To set
        /// a concurrency limit for a function, use <a>PutFunctionConcurrency</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionConcurrency service method.</param>
        /// 
        /// <returns>The response from the GetFunctionConcurrency service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConcurrency">REST API Reference for GetFunctionConcurrency Operation</seealso>
        public virtual GetFunctionConcurrencyResponse GetFunctionConcurrency(GetFunctionConcurrencyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionConcurrencyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionConcurrencyResponseUnmarshaller.Instance;

            return Invoke<GetFunctionConcurrencyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFunctionConcurrency operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionConcurrency operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFunctionConcurrency
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConcurrency">REST API Reference for GetFunctionConcurrency Operation</seealso>
        public virtual IAsyncResult BeginGetFunctionConcurrency(GetFunctionConcurrencyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionConcurrencyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionConcurrencyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFunctionConcurrency operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFunctionConcurrency.</param>
        /// 
        /// <returns>Returns a  GetFunctionConcurrencyResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConcurrency">REST API Reference for GetFunctionConcurrency Operation</seealso>
        public virtual GetFunctionConcurrencyResponse EndGetFunctionConcurrency(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFunctionConcurrencyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFunctionConfiguration

        /// <summary>
        /// Returns the version-specific settings of a Lambda function or version. The output
        /// includes only options that can vary between versions of a function. To modify these
        /// settings, use <a>UpdateFunctionConfiguration</a>.
        /// 
        ///  
        /// <para>
        /// To get all of a function's details, including function-level settings, use <a>GetFunction</a>.
        /// </para>
        /// </summary>
        /// <param name="functionName">The name of the Lambda function, version, or alias. <p class="title"> <b>Name formats</b>  <ul> <li>  <b>Function name</b> – <code>my-function</code> (name-only), <code>my-function:v1</code> (with alias). </li> <li>  <b>Function ARN</b> – <code>arn:aws:lambda:us-west-2:123456789012:function:my-function</code>. </li> <li>  <b>Partial ARN</b> – <code>123456789012:function:my-function</code>. </li> </ul> You can append a version number or alias to any of the formats. The length constraint applies only to the full ARN. If you specify only the function name, it is limited to 64 characters in length.</param>
        /// 
        /// <returns>The response from the GetFunctionConfiguration service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConfiguration">REST API Reference for GetFunctionConfiguration Operation</seealso>
        public virtual GetFunctionConfigurationResponse GetFunctionConfiguration(string functionName)
        {
            var request = new GetFunctionConfigurationRequest();
            request.FunctionName = functionName;
            return GetFunctionConfiguration(request);
        }


        /// <summary>
        /// Returns the version-specific settings of a Lambda function or version. The output
        /// includes only options that can vary between versions of a function. To modify these
        /// settings, use <a>UpdateFunctionConfiguration</a>.
        /// 
        ///  
        /// <para>
        /// To get all of a function's details, including function-level settings, use <a>GetFunction</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetFunctionConfiguration service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConfiguration">REST API Reference for GetFunctionConfiguration Operation</seealso>
        public virtual GetFunctionConfigurationResponse GetFunctionConfiguration(GetFunctionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetFunctionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFunctionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionConfiguration operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFunctionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConfiguration">REST API Reference for GetFunctionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetFunctionConfiguration(GetFunctionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFunctionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFunctionConfiguration.</param>
        /// 
        /// <returns>Returns a  GetFunctionConfigurationResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConfiguration">REST API Reference for GetFunctionConfiguration Operation</seealso>
        public virtual GetFunctionConfigurationResponse EndGetFunctionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFunctionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFunctionEventInvokeConfig

        /// <summary>
        /// Retrieves the configuration for asynchronous invocation for a function, version, or
        /// alias.
        /// 
        ///  
        /// <para>
        /// To configure options for asynchronous invocation, use <a>PutFunctionEventInvokeConfig</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionEventInvokeConfig service method.</param>
        /// 
        /// <returns>The response from the GetFunctionEventInvokeConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionEventInvokeConfig">REST API Reference for GetFunctionEventInvokeConfig Operation</seealso>
        public virtual GetFunctionEventInvokeConfigResponse GetFunctionEventInvokeConfig(GetFunctionEventInvokeConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionEventInvokeConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionEventInvokeConfigResponseUnmarshaller.Instance;

            return Invoke<GetFunctionEventInvokeConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFunctionEventInvokeConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionEventInvokeConfig operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFunctionEventInvokeConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionEventInvokeConfig">REST API Reference for GetFunctionEventInvokeConfig Operation</seealso>
        public virtual IAsyncResult BeginGetFunctionEventInvokeConfig(GetFunctionEventInvokeConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionEventInvokeConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionEventInvokeConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFunctionEventInvokeConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFunctionEventInvokeConfig.</param>
        /// 
        /// <returns>Returns a  GetFunctionEventInvokeConfigResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionEventInvokeConfig">REST API Reference for GetFunctionEventInvokeConfig Operation</seealso>
        public virtual GetFunctionEventInvokeConfigResponse EndGetFunctionEventInvokeConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFunctionEventInvokeConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFunctionUrlConfig

        /// <summary>
        /// Returns details about a Lambda function URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionUrlConfig service method.</param>
        /// 
        /// <returns>The response from the GetFunctionUrlConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionUrlConfig">REST API Reference for GetFunctionUrlConfig Operation</seealso>
        public virtual GetFunctionUrlConfigResponse GetFunctionUrlConfig(GetFunctionUrlConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionUrlConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionUrlConfigResponseUnmarshaller.Instance;

            return Invoke<GetFunctionUrlConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFunctionUrlConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionUrlConfig operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFunctionUrlConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionUrlConfig">REST API Reference for GetFunctionUrlConfig Operation</seealso>
        public virtual IAsyncResult BeginGetFunctionUrlConfig(GetFunctionUrlConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFunctionUrlConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFunctionUrlConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFunctionUrlConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFunctionUrlConfig.</param>
        /// 
        /// <returns>Returns a  GetFunctionUrlConfigResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionUrlConfig">REST API Reference for GetFunctionUrlConfig Operation</seealso>
        public virtual GetFunctionUrlConfigResponse EndGetFunctionUrlConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFunctionUrlConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLayerVersion

        /// <summary>
        /// Returns information about a version of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>, with a link to download the layer archive that's valid for 10 minutes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLayerVersion service method.</param>
        /// 
        /// <returns>The response from the GetLayerVersion service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersion">REST API Reference for GetLayerVersion Operation</seealso>
        public virtual GetLayerVersionResponse GetLayerVersion(GetLayerVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLayerVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLayerVersionResponseUnmarshaller.Instance;

            return Invoke<GetLayerVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLayerVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLayerVersion operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLayerVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersion">REST API Reference for GetLayerVersion Operation</seealso>
        public virtual IAsyncResult BeginGetLayerVersion(GetLayerVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLayerVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLayerVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLayerVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLayerVersion.</param>
        /// 
        /// <returns>Returns a  GetLayerVersionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersion">REST API Reference for GetLayerVersion Operation</seealso>
        public virtual GetLayerVersionResponse EndGetLayerVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLayerVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLayerVersionByArn

        /// <summary>
        /// Returns information about a version of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>, with a link to download the layer archive that's valid for 10 minutes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLayerVersionByArn service method.</param>
        /// 
        /// <returns>The response from the GetLayerVersionByArn service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersionByArn">REST API Reference for GetLayerVersionByArn Operation</seealso>
        public virtual GetLayerVersionByArnResponse GetLayerVersionByArn(GetLayerVersionByArnRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLayerVersionByArnRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLayerVersionByArnResponseUnmarshaller.Instance;

            return Invoke<GetLayerVersionByArnResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLayerVersionByArn operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLayerVersionByArn operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLayerVersionByArn
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersionByArn">REST API Reference for GetLayerVersionByArn Operation</seealso>
        public virtual IAsyncResult BeginGetLayerVersionByArn(GetLayerVersionByArnRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLayerVersionByArnRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLayerVersionByArnResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLayerVersionByArn operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLayerVersionByArn.</param>
        /// 
        /// <returns>Returns a  GetLayerVersionByArnResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersionByArn">REST API Reference for GetLayerVersionByArn Operation</seealso>
        public virtual GetLayerVersionByArnResponse EndGetLayerVersionByArn(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLayerVersionByArnResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLayerVersionPolicy

        /// <summary>
        /// Returns the permission policy for a version of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>. For more information, see <a>AddLayerVersionPermission</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLayerVersionPolicy service method.</param>
        /// 
        /// <returns>The response from the GetLayerVersionPolicy service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersionPolicy">REST API Reference for GetLayerVersionPolicy Operation</seealso>
        public virtual GetLayerVersionPolicyResponse GetLayerVersionPolicy(GetLayerVersionPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLayerVersionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLayerVersionPolicyResponseUnmarshaller.Instance;

            return Invoke<GetLayerVersionPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLayerVersionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLayerVersionPolicy operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLayerVersionPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersionPolicy">REST API Reference for GetLayerVersionPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetLayerVersionPolicy(GetLayerVersionPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLayerVersionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLayerVersionPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLayerVersionPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLayerVersionPolicy.</param>
        /// 
        /// <returns>Returns a  GetLayerVersionPolicyResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetLayerVersionPolicy">REST API Reference for GetLayerVersionPolicy Operation</seealso>
        public virtual GetLayerVersionPolicyResponse EndGetLayerVersionPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLayerVersionPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPolicy

        /// <summary>
        /// Returns the <a href="https://docs.aws.amazon.com/lambda/latest/dg/access-control-resource-based.html">resource-based
        /// IAM policy</a> for a function, version, or alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse GetPolicy(GetPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetPolicy(GetPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicy.</param>
        /// 
        /// <returns>Returns a  GetPolicyResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual GetPolicyResponse EndGetPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProvisionedConcurrencyConfig

        /// <summary>
        /// Retrieves the provisioned concurrency configuration for a function's alias or version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProvisionedConcurrencyConfig service method.</param>
        /// 
        /// <returns>The response from the GetProvisionedConcurrencyConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ProvisionedConcurrencyConfigNotFoundException">
        /// The specified configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetProvisionedConcurrencyConfig">REST API Reference for GetProvisionedConcurrencyConfig Operation</seealso>
        public virtual GetProvisionedConcurrencyConfigResponse GetProvisionedConcurrencyConfig(GetProvisionedConcurrencyConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProvisionedConcurrencyConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProvisionedConcurrencyConfigResponseUnmarshaller.Instance;

            return Invoke<GetProvisionedConcurrencyConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProvisionedConcurrencyConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProvisionedConcurrencyConfig operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProvisionedConcurrencyConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetProvisionedConcurrencyConfig">REST API Reference for GetProvisionedConcurrencyConfig Operation</seealso>
        public virtual IAsyncResult BeginGetProvisionedConcurrencyConfig(GetProvisionedConcurrencyConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProvisionedConcurrencyConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProvisionedConcurrencyConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProvisionedConcurrencyConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProvisionedConcurrencyConfig.</param>
        /// 
        /// <returns>Returns a  GetProvisionedConcurrencyConfigResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetProvisionedConcurrencyConfig">REST API Reference for GetProvisionedConcurrencyConfig Operation</seealso>
        public virtual GetProvisionedConcurrencyConfigResponse EndGetProvisionedConcurrencyConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProvisionedConcurrencyConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  Invoke

        /// <summary>
        /// Invokes a Lambda function. You can invoke a function synchronously (and wait for the
        /// response), or asynchronously. To invoke a function asynchronously, set <code>InvocationType</code>
        /// to <code>Event</code>.
        /// 
        ///  
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-sync.html">synchronous
        /// invocation</a>, details about the function response, including errors, are included
        /// in the response body and headers. For either invocation type, you can find more information
        /// in the <a href="https://docs.aws.amazon.com/lambda/latest/dg/monitoring-functions.html">execution
        /// log</a> and <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-x-ray.html">trace</a>.
        /// </para>
        ///  
        /// <para>
        /// When an error occurs, your function may be invoked multiple times. Retry behavior
        /// varies by error type, client, event source, and invocation type. For example, if you
        /// invoke a function asynchronously and it returns an error, Lambda executes the function
        /// up to two more times. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-retries.html">Error
        /// handling and automatic retries in Lambda</a>.
        /// </para>
        ///  
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html">asynchronous
        /// invocation</a>, Lambda adds events to a queue before sending them to your function.
        /// If your function does not have enough capacity to keep up with the queue, events may
        /// be lost. Occasionally, your function may receive the same event multiple times, even
        /// if no error occurs. To retain events that were not processed, configure your function
        /// with a <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html#invocation-dlq">dead-letter
        /// queue</a>.
        /// </para>
        ///  
        /// <para>
        /// The status code in the API response doesn't reflect function errors. Error codes are
        /// reserved for errors that prevent your function from executing, such as permissions
        /// errors, <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">quota</a>
        /// errors, or issues with your function's code and configuration. For example, Lambda
        /// returns <code>TooManyRequestsException</code> if running the function would cause
        /// you to exceed a concurrency limit at either the account level (<code>ConcurrentInvocationLimitExceeded</code>)
        /// or function level (<code>ReservedFunctionConcurrentInvocationLimitExceeded</code>).
        /// </para>
        ///  
        /// <para>
        /// For functions with a long timeout, your client might disconnect during synchronous
        /// invocation while it waits for a response. Configure your HTTP client, SDK, firewall,
        /// proxy, or operating system to allow for long connections with timeout or keep-alive
        /// settings.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/list_awslambda.html">lambda:InvokeFunction</a>
        /// action. For details on how to set up permissions for cross-account invocations, see
        /// <a href="https://docs.aws.amazon.com/lambda/latest/dg/access-control-resource-based.html#permissions-resource-xaccountinvoke">Granting
        /// function access to other accounts</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Invoke service method.</param>
        /// 
        /// <returns>The response from the Invoke service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.EC2AccessDeniedException">
        /// Need additional permissions to configure VPC settings.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EC2ThrottledException">
        /// Amazon EC2 throttled Lambda during Lambda function initialization using the execution
        /// role provided for the function.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EC2UnexpectedException">
        /// Lambda received an unexpected Amazon EC2 client exception while setting up for the
        /// Lambda function.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EFSIOException">
        /// An error occurred when reading from or writing to a connected file system.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EFSMountConnectivityException">
        /// The Lambda function couldn't make a network connection to the configured file system.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EFSMountFailureException">
        /// The Lambda function couldn't mount the configured file system due to a permission
        /// or configuration issue.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.EFSMountTimeoutException">
        /// The Lambda function made a network connection to the configured file system, but the
        /// mount operation timed out.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ENILimitReachedException">
        /// Lambda couldn't create an elastic network interface in the VPC, specified as part
        /// of Lambda function configuration, because the limit for network interfaces has been
        /// reached. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidRequestContentException">
        /// The request body could not be parsed as JSON.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidRuntimeException">
        /// The runtime or runtime version specified is not supported.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidSecurityGroupIDException">
        /// The security group ID provided in the Lambda function VPC configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidSubnetIDException">
        /// The subnet ID provided in the Lambda function VPC configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidZipFileException">
        /// Lambda could not unzip the deployment package.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSAccessDeniedException">
        /// Lambda couldn't decrypt the environment variables because KMS access was denied. Check
        /// the Lambda function's KMS permissions.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSDisabledException">
        /// Lambda couldn't decrypt the environment variables because the KMS key used is disabled.
        /// Check the Lambda function's KMS key settings.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSInvalidStateException">
        /// Lambda couldn't decrypt the environment variables because the state of the KMS key
        /// used is not valid for Decrypt. Check the function's KMS key settings.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.KMSNotFoundException">
        /// Lambda couldn't decrypt the environment variables because the KMS key was not found.
        /// Check the function's KMS key settings.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.RequestTooLargeException">
        /// The request payload exceeded the <code>Invoke</code> request body JSON input quota.
        /// For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotReadyException">
        /// The function is inactive and its VPC connection is no longer available. Wait for the
        /// VPC connection to reestablish and try again.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.SnapStartException">
        /// The runtime restore hook encountered an error. For more information, check the Amazon
        /// CloudWatch logs.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.SnapStartNotReadyException">
        /// Lambda is initializing your function. You can invoke the function when the <a href="https://docs.aws.amazon.com/lambda/latest/dg/functions-states.html">function
        /// state</a> becomes <code>Active</code>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.SnapStartTimeoutException">
        /// The runtime restore hook failed to complete within the timeout limit (2 seconds).
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.SubnetIPAddressLimitReachedException">
        /// Lambda couldn't set up VPC access for the Lambda function because one or more configured
        /// subnets has no available IP addresses.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.UnsupportedMediaTypeException">
        /// The content type of the <code>Invoke</code> request body is not JSON.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/Invoke">REST API Reference for Invoke Operation</seealso>
        public virtual InvokeResponse Invoke(InvokeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeResponseUnmarshaller.Instance;

            return Invoke<InvokeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Invoke operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Invoke operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvoke
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/Invoke">REST API Reference for Invoke Operation</seealso>
        public virtual IAsyncResult BeginInvoke(InvokeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Invoke operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvoke.</param>
        /// 
        /// <returns>Returns a  InvokeResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/Invoke">REST API Reference for Invoke Operation</seealso>
        public virtual InvokeResponse EndInvoke(IAsyncResult asyncResult)
        {
            return EndInvoke<InvokeResponse>(asyncResult);
        }

        #endregion
        
        #region  InvokeAsync

        /// <summary>
        /// <important> 
        /// <para>
        /// For asynchronous function invocation, use <a>Invoke</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Invokes a function asynchronously.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeAsync service method.</param>
        /// 
        /// <returns>The response from the InvokeAsync service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidRequestContentException">
        /// The request body could not be parsed as JSON.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidRuntimeException">
        /// The runtime or runtime version specified is not supported.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/InvokeAsync">REST API Reference for InvokeAsync Operation</seealso>
        [Obsolete("For .NET 3.5/4.5, API InvokeAsyncResponse InvokeAsync(InvokeAsyncRequest) is deprecated, use InvokeResponse Invoke(InvokeRequest), or Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead. For .NET Core, Task<InvokeAsyncResponse> InvokeAsyncAsync(InvokeAsyncRequest, CancellationToken) is deprecated, use Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead.")]
        public virtual InvokeAsyncResponse InvokeAsync(InvokeAsyncRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeAsyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeAsyncResponseUnmarshaller.Instance;

            return Invoke<InvokeAsyncResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeAsync operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeAsync operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeAsync
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/InvokeAsync">REST API Reference for InvokeAsync Operation</seealso>
        [Obsolete("For .NET 3.5/4.5, API InvokeAsyncResponse InvokeAsync(InvokeAsyncRequest) is deprecated, use InvokeResponse Invoke(InvokeRequest), or Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead. For .NET Core, Task<InvokeAsyncResponse> InvokeAsyncAsync(InvokeAsyncRequest, CancellationToken) is deprecated, use Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead.")]
        public virtual IAsyncResult BeginInvokeAsync(InvokeAsyncRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeAsyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeAsyncResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeAsync operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeAsync.</param>
        /// 
        /// <returns>Returns a  InvokeAsyncResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/InvokeAsync">REST API Reference for InvokeAsync Operation</seealso>
        [Obsolete("For .NET 3.5/4.5, API InvokeAsyncResponse InvokeAsync(InvokeAsyncRequest) is deprecated, use InvokeResponse Invoke(InvokeRequest), or Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead. For .NET Core, Task<InvokeAsyncResponse> InvokeAsyncAsync(InvokeAsyncRequest, CancellationToken) is deprecated, use Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead.")]
        public virtual InvokeAsyncResponse EndInvokeAsync(IAsyncResult asyncResult)
        {
            return EndInvoke<InvokeAsyncResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAliases

        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">aliases</a>
        /// for a Lambda function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAliasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual IAsyncResult BeginListAliases(ListAliasesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAliases.</param>
        /// 
        /// <returns>Returns a  ListAliasesResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual ListAliasesResponse EndListAliases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAliasesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCodeSigningConfigs

        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuring-codesigning.html">code
        /// signing configurations</a>. A request returns up to 10,000 configurations per call.
        /// You can use the <code>MaxItems</code> parameter to return fewer configurations per
        /// call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSigningConfigs service method.</param>
        /// 
        /// <returns>The response from the ListCodeSigningConfigs service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListCodeSigningConfigs">REST API Reference for ListCodeSigningConfigs Operation</seealso>
        public virtual ListCodeSigningConfigsResponse ListCodeSigningConfigs(ListCodeSigningConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCodeSigningConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeSigningConfigsResponseUnmarshaller.Instance;

            return Invoke<ListCodeSigningConfigsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCodeSigningConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCodeSigningConfigs operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCodeSigningConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListCodeSigningConfigs">REST API Reference for ListCodeSigningConfigs Operation</seealso>
        public virtual IAsyncResult BeginListCodeSigningConfigs(ListCodeSigningConfigsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCodeSigningConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeSigningConfigsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCodeSigningConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCodeSigningConfigs.</param>
        /// 
        /// <returns>Returns a  ListCodeSigningConfigsResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListCodeSigningConfigs">REST API Reference for ListCodeSigningConfigs Operation</seealso>
        public virtual ListCodeSigningConfigsResponse EndListCodeSigningConfigs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCodeSigningConfigsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEventSourceMappings

        /// <summary>
        /// Lists event source mappings. Specify an <code>EventSourceArn</code> to show only event
        /// source mappings for a single event source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventSourceMappings service method.</param>
        /// 
        /// <returns>The response from the ListEventSourceMappings service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListEventSourceMappings">REST API Reference for ListEventSourceMappings Operation</seealso>
        public virtual ListEventSourceMappingsResponse ListEventSourceMappings(ListEventSourceMappingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventSourceMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventSourceMappingsResponseUnmarshaller.Instance;

            return Invoke<ListEventSourceMappingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventSourceMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventSourceMappings operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventSourceMappings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListEventSourceMappings">REST API Reference for ListEventSourceMappings Operation</seealso>
        public virtual IAsyncResult BeginListEventSourceMappings(ListEventSourceMappingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventSourceMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventSourceMappingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventSourceMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventSourceMappings.</param>
        /// 
        /// <returns>Returns a  ListEventSourceMappingsResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListEventSourceMappings">REST API Reference for ListEventSourceMappings Operation</seealso>
        public virtual ListEventSourceMappingsResponse EndListEventSourceMappings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEventSourceMappingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFunctionEventInvokeConfigs

        /// <summary>
        /// Retrieves a list of configurations for asynchronous invocation for a function.
        /// 
        ///  
        /// <para>
        /// To configure options for asynchronous invocation, use <a>PutFunctionEventInvokeConfig</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionEventInvokeConfigs service method.</param>
        /// 
        /// <returns>The response from the ListFunctionEventInvokeConfigs service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctionEventInvokeConfigs">REST API Reference for ListFunctionEventInvokeConfigs Operation</seealso>
        public virtual ListFunctionEventInvokeConfigsResponse ListFunctionEventInvokeConfigs(ListFunctionEventInvokeConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFunctionEventInvokeConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionEventInvokeConfigsResponseUnmarshaller.Instance;

            return Invoke<ListFunctionEventInvokeConfigsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFunctionEventInvokeConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionEventInvokeConfigs operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFunctionEventInvokeConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctionEventInvokeConfigs">REST API Reference for ListFunctionEventInvokeConfigs Operation</seealso>
        public virtual IAsyncResult BeginListFunctionEventInvokeConfigs(ListFunctionEventInvokeConfigsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFunctionEventInvokeConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionEventInvokeConfigsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFunctionEventInvokeConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFunctionEventInvokeConfigs.</param>
        /// 
        /// <returns>Returns a  ListFunctionEventInvokeConfigsResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctionEventInvokeConfigs">REST API Reference for ListFunctionEventInvokeConfigs Operation</seealso>
        public virtual ListFunctionEventInvokeConfigsResponse EndListFunctionEventInvokeConfigs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFunctionEventInvokeConfigsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFunctions

        /// <summary>
        /// Returns a list of Lambda functions, with the version-specific configuration of each.
        /// Lambda returns up to 50 functions per call.
        /// 
        ///  
        /// <para>
        /// Set <code>FunctionVersion</code> to <code>ALL</code> to include all published versions
        /// of each function in addition to the unpublished version.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>ListFunctions</code> operation returns a subset of the <a>FunctionConfiguration</a>
        /// fields. To get the additional fields (State, StateReasonCode, StateReason, LastUpdateStatus,
        /// LastUpdateStatusReason, LastUpdateStatusReasonCode) for a function or version, use
        /// <a>GetFunction</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the ListFunctions service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        public virtual ListFunctionsResponse ListFunctions()
        {
            var request = new ListFunctionsRequest();
            return ListFunctions(request);
        }


        /// <summary>
        /// Returns a list of Lambda functions, with the version-specific configuration of each.
        /// Lambda returns up to 50 functions per call.
        /// 
        ///  
        /// <para>
        /// Set <code>FunctionVersion</code> to <code>ALL</code> to include all published versions
        /// of each function in addition to the unpublished version.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>ListFunctions</code> operation returns a subset of the <a>FunctionConfiguration</a>
        /// fields. To get the additional fields (State, StateReasonCode, StateReason, LastUpdateStatus,
        /// LastUpdateStatusReason, LastUpdateStatusReasonCode) for a function or version, use
        /// <a>GetFunction</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions service method.</param>
        /// 
        /// <returns>The response from the ListFunctions service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        public virtual ListFunctionsResponse ListFunctions(ListFunctionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionsResponseUnmarshaller.Instance;

            return Invoke<ListFunctionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFunctions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFunctions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        public virtual IAsyncResult BeginListFunctions(ListFunctionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFunctions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFunctions.</param>
        /// 
        /// <returns>Returns a  ListFunctionsResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        public virtual ListFunctionsResponse EndListFunctions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFunctionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFunctionsByCodeSigningConfig

        /// <summary>
        /// List the functions that use the specified code signing configuration. You can use
        /// this method prior to deleting a code signing configuration, to verify that no functions
        /// are using it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionsByCodeSigningConfig service method.</param>
        /// 
        /// <returns>The response from the ListFunctionsByCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctionsByCodeSigningConfig">REST API Reference for ListFunctionsByCodeSigningConfig Operation</seealso>
        public virtual ListFunctionsByCodeSigningConfigResponse ListFunctionsByCodeSigningConfig(ListFunctionsByCodeSigningConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFunctionsByCodeSigningConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionsByCodeSigningConfigResponseUnmarshaller.Instance;

            return Invoke<ListFunctionsByCodeSigningConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFunctionsByCodeSigningConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionsByCodeSigningConfig operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFunctionsByCodeSigningConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctionsByCodeSigningConfig">REST API Reference for ListFunctionsByCodeSigningConfig Operation</seealso>
        public virtual IAsyncResult BeginListFunctionsByCodeSigningConfig(ListFunctionsByCodeSigningConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFunctionsByCodeSigningConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionsByCodeSigningConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFunctionsByCodeSigningConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFunctionsByCodeSigningConfig.</param>
        /// 
        /// <returns>Returns a  ListFunctionsByCodeSigningConfigResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctionsByCodeSigningConfig">REST API Reference for ListFunctionsByCodeSigningConfig Operation</seealso>
        public virtual ListFunctionsByCodeSigningConfigResponse EndListFunctionsByCodeSigningConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFunctionsByCodeSigningConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFunctionUrlConfigs

        /// <summary>
        /// Returns a list of Lambda function URLs for the specified function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionUrlConfigs service method.</param>
        /// 
        /// <returns>The response from the ListFunctionUrlConfigs service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctionUrlConfigs">REST API Reference for ListFunctionUrlConfigs Operation</seealso>
        public virtual ListFunctionUrlConfigsResponse ListFunctionUrlConfigs(ListFunctionUrlConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFunctionUrlConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionUrlConfigsResponseUnmarshaller.Instance;

            return Invoke<ListFunctionUrlConfigsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFunctionUrlConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFunctionUrlConfigs operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFunctionUrlConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctionUrlConfigs">REST API Reference for ListFunctionUrlConfigs Operation</seealso>
        public virtual IAsyncResult BeginListFunctionUrlConfigs(ListFunctionUrlConfigsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFunctionUrlConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFunctionUrlConfigsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFunctionUrlConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFunctionUrlConfigs.</param>
        /// 
        /// <returns>Returns a  ListFunctionUrlConfigsResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctionUrlConfigs">REST API Reference for ListFunctionUrlConfigs Operation</seealso>
        public virtual ListFunctionUrlConfigsResponse EndListFunctionUrlConfigs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFunctionUrlConfigsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLayers

        /// <summary>
        /// Lists <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-layers.html">Lambda
        /// layers</a> and shows information about the latest version of each. Specify a <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html">runtime
        /// identifier</a> to list only layers that indicate that they're compatible with that
        /// runtime. Specify a compatible architecture to include only layers that are compatible
        /// with that <a href="https://docs.aws.amazon.com/lambda/latest/dg/foundation-arch.html">instruction
        /// set architecture</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLayers service method.</param>
        /// 
        /// <returns>The response from the ListLayers service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListLayers">REST API Reference for ListLayers Operation</seealso>
        public virtual ListLayersResponse ListLayers(ListLayersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLayersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLayersResponseUnmarshaller.Instance;

            return Invoke<ListLayersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLayers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLayers operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLayers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListLayers">REST API Reference for ListLayers Operation</seealso>
        public virtual IAsyncResult BeginListLayers(ListLayersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLayersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLayersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLayers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLayers.</param>
        /// 
        /// <returns>Returns a  ListLayersResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListLayers">REST API Reference for ListLayers Operation</seealso>
        public virtual ListLayersResponse EndListLayers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLayersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLayerVersions

        /// <summary>
        /// Lists the versions of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>. Versions that have been deleted aren't listed. Specify a <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html">runtime
        /// identifier</a> to list only versions that indicate that they're compatible with that
        /// runtime. Specify a compatible architecture to include only layer versions that are
        /// compatible with that architecture.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLayerVersions service method.</param>
        /// 
        /// <returns>The response from the ListLayerVersions service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListLayerVersions">REST API Reference for ListLayerVersions Operation</seealso>
        public virtual ListLayerVersionsResponse ListLayerVersions(ListLayerVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLayerVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLayerVersionsResponseUnmarshaller.Instance;

            return Invoke<ListLayerVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLayerVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLayerVersions operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLayerVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListLayerVersions">REST API Reference for ListLayerVersions Operation</seealso>
        public virtual IAsyncResult BeginListLayerVersions(ListLayerVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLayerVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLayerVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLayerVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLayerVersions.</param>
        /// 
        /// <returns>Returns a  ListLayerVersionsResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListLayerVersions">REST API Reference for ListLayerVersions Operation</seealso>
        public virtual ListLayerVersionsResponse EndListLayerVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLayerVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProvisionedConcurrencyConfigs

        /// <summary>
        /// Retrieves a list of provisioned concurrency configurations for a function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedConcurrencyConfigs service method.</param>
        /// 
        /// <returns>The response from the ListProvisionedConcurrencyConfigs service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListProvisionedConcurrencyConfigs">REST API Reference for ListProvisionedConcurrencyConfigs Operation</seealso>
        public virtual ListProvisionedConcurrencyConfigsResponse ListProvisionedConcurrencyConfigs(ListProvisionedConcurrencyConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisionedConcurrencyConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisionedConcurrencyConfigsResponseUnmarshaller.Instance;

            return Invoke<ListProvisionedConcurrencyConfigsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProvisionedConcurrencyConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedConcurrencyConfigs operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProvisionedConcurrencyConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListProvisionedConcurrencyConfigs">REST API Reference for ListProvisionedConcurrencyConfigs Operation</seealso>
        public virtual IAsyncResult BeginListProvisionedConcurrencyConfigs(ListProvisionedConcurrencyConfigsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisionedConcurrencyConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisionedConcurrencyConfigsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProvisionedConcurrencyConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProvisionedConcurrencyConfigs.</param>
        /// 
        /// <returns>Returns a  ListProvisionedConcurrencyConfigsResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListProvisionedConcurrencyConfigs">REST API Reference for ListProvisionedConcurrencyConfigs Operation</seealso>
        public virtual ListProvisionedConcurrencyConfigsResponse EndListProvisionedConcurrencyConfigs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProvisionedConcurrencyConfigsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTags

        /// <summary>
        /// Returns a function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/tagging.html">tags</a>.
        /// You can also view tags with <a>GetFunction</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual IAsyncResult BeginListTags(ListTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTags.</param>
        /// 
        /// <returns>Returns a  ListTagsResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual ListTagsResponse EndListTags(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVersionsByFunction

        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">versions</a>,
        /// with the version-specific configuration of each. Lambda returns up to 50 versions
        /// per call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVersionsByFunction service method.</param>
        /// 
        /// <returns>The response from the ListVersionsByFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListVersionsByFunction">REST API Reference for ListVersionsByFunction Operation</seealso>
        public virtual ListVersionsByFunctionResponse ListVersionsByFunction(ListVersionsByFunctionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVersionsByFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVersionsByFunctionResponseUnmarshaller.Instance;

            return Invoke<ListVersionsByFunctionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVersionsByFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVersionsByFunction operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVersionsByFunction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListVersionsByFunction">REST API Reference for ListVersionsByFunction Operation</seealso>
        public virtual IAsyncResult BeginListVersionsByFunction(ListVersionsByFunctionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVersionsByFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVersionsByFunctionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVersionsByFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVersionsByFunction.</param>
        /// 
        /// <returns>Returns a  ListVersionsByFunctionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListVersionsByFunction">REST API Reference for ListVersionsByFunction Operation</seealso>
        public virtual ListVersionsByFunctionResponse EndListVersionsByFunction(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVersionsByFunctionResponse>(asyncResult);
        }

        #endregion
        
        #region  PublishLayerVersion

        /// <summary>
        /// Creates an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a> from a ZIP archive. Each time you call <code>PublishLayerVersion</code>
        /// with the same layer name, a new version is created.
        /// 
        ///  
        /// <para>
        /// Add layers to your function with <a>CreateFunction</a> or <a>UpdateFunctionConfiguration</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishLayerVersion service method.</param>
        /// 
        /// <returns>The response from the PublishLayerVersion service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeStorageExceededException">
        /// Your Amazon Web Services account has exceeded its maximum total code size. For more
        /// information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishLayerVersion">REST API Reference for PublishLayerVersion Operation</seealso>
        public virtual PublishLayerVersionResponse PublishLayerVersion(PublishLayerVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishLayerVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishLayerVersionResponseUnmarshaller.Instance;

            return Invoke<PublishLayerVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PublishLayerVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PublishLayerVersion operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublishLayerVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishLayerVersion">REST API Reference for PublishLayerVersion Operation</seealso>
        public virtual IAsyncResult BeginPublishLayerVersion(PublishLayerVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishLayerVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishLayerVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PublishLayerVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublishLayerVersion.</param>
        /// 
        /// <returns>Returns a  PublishLayerVersionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishLayerVersion">REST API Reference for PublishLayerVersion Operation</seealso>
        public virtual PublishLayerVersionResponse EndPublishLayerVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<PublishLayerVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  PublishVersion

        /// <summary>
        /// Creates a <a href="https://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">version</a>
        /// from the current code and configuration of a function. Use versions to create a snapshot
        /// of your function code and configuration that doesn't change.
        /// 
        ///  
        /// <para>
        /// Lambda doesn't publish a version if the function's configuration and code haven't
        /// changed since the last version. Use <a>UpdateFunctionCode</a> or <a>UpdateFunctionConfiguration</a>
        /// to update the function before publishing a version.
        /// </para>
        ///  
        /// <para>
        /// Clients can invoke versions directly or with an alias. To create an alias, use <a>CreateAlias</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishVersion service method.</param>
        /// 
        /// <returns>The response from the PublishVersion service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeStorageExceededException">
        /// Your Amazon Web Services account has exceeded its maximum total code size. For more
        /// information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishVersion">REST API Reference for PublishVersion Operation</seealso>
        public virtual PublishVersionResponse PublishVersion(PublishVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishVersionResponseUnmarshaller.Instance;

            return Invoke<PublishVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PublishVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PublishVersion operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublishVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishVersion">REST API Reference for PublishVersion Operation</seealso>
        public virtual IAsyncResult BeginPublishVersion(PublishVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PublishVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublishVersion.</param>
        /// 
        /// <returns>Returns a  PublishVersionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishVersion">REST API Reference for PublishVersion Operation</seealso>
        public virtual PublishVersionResponse EndPublishVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<PublishVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  PutFunctionCodeSigningConfig

        /// <summary>
        /// Update the code signing configuration for the function. Changes to the code signing
        /// configuration take effect the next time a user tries to deploy a code package to the
        /// function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFunctionCodeSigningConfig service method.</param>
        /// 
        /// <returns>The response from the PutFunctionCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeSigningConfigNotFoundException">
        /// The specified code signing configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionCodeSigningConfig">REST API Reference for PutFunctionCodeSigningConfig Operation</seealso>
        public virtual PutFunctionCodeSigningConfigResponse PutFunctionCodeSigningConfig(PutFunctionCodeSigningConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFunctionCodeSigningConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFunctionCodeSigningConfigResponseUnmarshaller.Instance;

            return Invoke<PutFunctionCodeSigningConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutFunctionCodeSigningConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutFunctionCodeSigningConfig operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutFunctionCodeSigningConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionCodeSigningConfig">REST API Reference for PutFunctionCodeSigningConfig Operation</seealso>
        public virtual IAsyncResult BeginPutFunctionCodeSigningConfig(PutFunctionCodeSigningConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFunctionCodeSigningConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFunctionCodeSigningConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutFunctionCodeSigningConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutFunctionCodeSigningConfig.</param>
        /// 
        /// <returns>Returns a  PutFunctionCodeSigningConfigResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionCodeSigningConfig">REST API Reference for PutFunctionCodeSigningConfig Operation</seealso>
        public virtual PutFunctionCodeSigningConfigResponse EndPutFunctionCodeSigningConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<PutFunctionCodeSigningConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  PutFunctionConcurrency

        /// <summary>
        /// Sets the maximum number of simultaneous executions for a function, and reserves capacity
        /// for that concurrency level.
        /// 
        ///  
        /// <para>
        /// Concurrency settings apply to the function as a whole, including all published versions
        /// and the unpublished version. Reserving concurrency both ensures that your function
        /// has capacity to process the specified number of events simultaneously, and prevents
        /// it from scaling beyond that level. Use <a>GetFunction</a> to see the current setting
        /// for a function.
        /// </para>
        ///  
        /// <para>
        /// Use <a>GetAccountSettings</a> to see your Regional concurrency limit. You can reserve
        /// concurrency for as many functions as you like, as long as you leave at least 100 simultaneous
        /// executions unreserved for functions that aren't configured with a per-function limit.
        /// For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-scaling.html">Lambda
        /// function scaling</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFunctionConcurrency service method.</param>
        /// 
        /// <returns>The response from the PutFunctionConcurrency service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionConcurrency">REST API Reference for PutFunctionConcurrency Operation</seealso>
        public virtual PutFunctionConcurrencyResponse PutFunctionConcurrency(PutFunctionConcurrencyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFunctionConcurrencyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFunctionConcurrencyResponseUnmarshaller.Instance;

            return Invoke<PutFunctionConcurrencyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutFunctionConcurrency operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutFunctionConcurrency operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutFunctionConcurrency
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionConcurrency">REST API Reference for PutFunctionConcurrency Operation</seealso>
        public virtual IAsyncResult BeginPutFunctionConcurrency(PutFunctionConcurrencyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFunctionConcurrencyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFunctionConcurrencyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutFunctionConcurrency operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutFunctionConcurrency.</param>
        /// 
        /// <returns>Returns a  PutFunctionConcurrencyResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionConcurrency">REST API Reference for PutFunctionConcurrency Operation</seealso>
        public virtual PutFunctionConcurrencyResponse EndPutFunctionConcurrency(IAsyncResult asyncResult)
        {
            return EndInvoke<PutFunctionConcurrencyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutFunctionEventInvokeConfig

        /// <summary>
        /// Configures options for <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html">asynchronous
        /// invocation</a> on a function, version, or alias. If a configuration already exists
        /// for a function, version, or alias, this operation overwrites it. If you exclude any
        /// settings, they are removed. To set one option without affecting existing settings
        /// for other options, use <a>UpdateFunctionEventInvokeConfig</a>.
        /// 
        ///  
        /// <para>
        /// By default, Lambda retries an asynchronous invocation twice if the function returns
        /// an error. It retains events in a queue for up to six hours. When an event fails all
        /// processing attempts or stays in the asynchronous invocation queue for too long, Lambda
        /// discards it. To retain discarded events, configure a dead-letter queue with <a>UpdateFunctionConfiguration</a>.
        /// </para>
        ///  
        /// <para>
        /// To send an invocation record to a queue, topic, function, or event bus, specify a
        /// <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async.html#invocation-async-destinations">destination</a>.
        /// You can configure separate destinations for successful invocations (on-success) and
        /// events that fail all processing attempts (on-failure). You can configure destinations
        /// in addition to or instead of a dead-letter queue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFunctionEventInvokeConfig service method.</param>
        /// 
        /// <returns>The response from the PutFunctionEventInvokeConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionEventInvokeConfig">REST API Reference for PutFunctionEventInvokeConfig Operation</seealso>
        public virtual PutFunctionEventInvokeConfigResponse PutFunctionEventInvokeConfig(PutFunctionEventInvokeConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFunctionEventInvokeConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFunctionEventInvokeConfigResponseUnmarshaller.Instance;

            return Invoke<PutFunctionEventInvokeConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutFunctionEventInvokeConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutFunctionEventInvokeConfig operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutFunctionEventInvokeConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionEventInvokeConfig">REST API Reference for PutFunctionEventInvokeConfig Operation</seealso>
        public virtual IAsyncResult BeginPutFunctionEventInvokeConfig(PutFunctionEventInvokeConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFunctionEventInvokeConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFunctionEventInvokeConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutFunctionEventInvokeConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutFunctionEventInvokeConfig.</param>
        /// 
        /// <returns>Returns a  PutFunctionEventInvokeConfigResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionEventInvokeConfig">REST API Reference for PutFunctionEventInvokeConfig Operation</seealso>
        public virtual PutFunctionEventInvokeConfigResponse EndPutFunctionEventInvokeConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<PutFunctionEventInvokeConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  PutProvisionedConcurrencyConfig

        /// <summary>
        /// Adds a provisioned concurrency configuration to a function's alias or version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProvisionedConcurrencyConfig service method.</param>
        /// 
        /// <returns>The response from the PutProvisionedConcurrencyConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutProvisionedConcurrencyConfig">REST API Reference for PutProvisionedConcurrencyConfig Operation</seealso>
        public virtual PutProvisionedConcurrencyConfigResponse PutProvisionedConcurrencyConfig(PutProvisionedConcurrencyConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutProvisionedConcurrencyConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProvisionedConcurrencyConfigResponseUnmarshaller.Instance;

            return Invoke<PutProvisionedConcurrencyConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutProvisionedConcurrencyConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutProvisionedConcurrencyConfig operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutProvisionedConcurrencyConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutProvisionedConcurrencyConfig">REST API Reference for PutProvisionedConcurrencyConfig Operation</seealso>
        public virtual IAsyncResult BeginPutProvisionedConcurrencyConfig(PutProvisionedConcurrencyConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutProvisionedConcurrencyConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProvisionedConcurrencyConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutProvisionedConcurrencyConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutProvisionedConcurrencyConfig.</param>
        /// 
        /// <returns>Returns a  PutProvisionedConcurrencyConfigResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutProvisionedConcurrencyConfig">REST API Reference for PutProvisionedConcurrencyConfig Operation</seealso>
        public virtual PutProvisionedConcurrencyConfigResponse EndPutProvisionedConcurrencyConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<PutProvisionedConcurrencyConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveLayerVersionPermission

        /// <summary>
        /// Removes a statement from the permissions policy for a version of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
        /// layer</a>. For more information, see <a>AddLayerVersionPermission</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveLayerVersionPermission service method.</param>
        /// 
        /// <returns>The response from the RemoveLayerVersionPermission service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemoveLayerVersionPermission">REST API Reference for RemoveLayerVersionPermission Operation</seealso>
        public virtual RemoveLayerVersionPermissionResponse RemoveLayerVersionPermission(RemoveLayerVersionPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveLayerVersionPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveLayerVersionPermissionResponseUnmarshaller.Instance;

            return Invoke<RemoveLayerVersionPermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveLayerVersionPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveLayerVersionPermission operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveLayerVersionPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemoveLayerVersionPermission">REST API Reference for RemoveLayerVersionPermission Operation</seealso>
        public virtual IAsyncResult BeginRemoveLayerVersionPermission(RemoveLayerVersionPermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveLayerVersionPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveLayerVersionPermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveLayerVersionPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveLayerVersionPermission.</param>
        /// 
        /// <returns>Returns a  RemoveLayerVersionPermissionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemoveLayerVersionPermission">REST API Reference for RemoveLayerVersionPermission Operation</seealso>
        public virtual RemoveLayerVersionPermissionResponse EndRemoveLayerVersionPermission(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveLayerVersionPermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  RemovePermission

        /// <summary>
        /// Revokes function-use permission from an Amazon Web Service or another Amazon Web Services
        /// account. You can get the ID of the statement from the output of <a>GetPolicy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemovePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return Invoke<RemovePermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemovePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemovePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual IAsyncResult BeginRemovePermission(RemovePermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemovePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemovePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemovePermission.</param>
        /// 
        /// <returns>Returns a  RemovePermissionResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual RemovePermissionResponse EndRemovePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<RemovePermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds <a href="https://docs.aws.amazon.com/lambda/latest/dg/tagging.html">tags</a>
        /// to a function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes <a href="https://docs.aws.amazon.com/lambda/latest/dg/tagging.html">tags</a>
        /// from a function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAlias

        /// <summary>
        /// Updates the configuration of a Lambda function <a href="https://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">alias</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual IAsyncResult BeginUpdateAlias(UpdateAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAlias.</param>
        /// 
        /// <returns>Returns a  UpdateAliasResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual UpdateAliasResponse EndUpdateAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAliasResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCodeSigningConfig

        /// <summary>
        /// Update the code signing configuration. Changes to the code signing configuration take
        /// effect the next time a user tries to deploy a code package to the function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeSigningConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateCodeSigningConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateCodeSigningConfig">REST API Reference for UpdateCodeSigningConfig Operation</seealso>
        public virtual UpdateCodeSigningConfigResponse UpdateCodeSigningConfig(UpdateCodeSigningConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCodeSigningConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCodeSigningConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateCodeSigningConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCodeSigningConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeSigningConfig operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCodeSigningConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateCodeSigningConfig">REST API Reference for UpdateCodeSigningConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateCodeSigningConfig(UpdateCodeSigningConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCodeSigningConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCodeSigningConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCodeSigningConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCodeSigningConfig.</param>
        /// 
        /// <returns>Returns a  UpdateCodeSigningConfigResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateCodeSigningConfig">REST API Reference for UpdateCodeSigningConfig Operation</seealso>
        public virtual UpdateCodeSigningConfigResponse EndUpdateCodeSigningConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCodeSigningConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEventSourceMapping

        /// <summary>
        /// Updates an event source mapping. You can change the function that Lambda invokes,
        /// or pause invocation and resume later from the same location.
        /// 
        ///  
        /// <para>
        /// For details about how to configure different event sources, see the following topics.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html#services-dynamodb-eventsourcemapping">
        /// Amazon DynamoDB Streams</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html#services-kinesis-eventsourcemapping">
        /// Amazon Kinesis</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#events-sqs-eventsource">
        /// Amazon SQS</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-mq.html#services-mq-eventsourcemapping">
        /// Amazon MQ and RabbitMQ</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html"> Amazon MSK</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/kafka-smaa.html"> Apache Kafka</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following error handling options are available only for stream sources (DynamoDB
        /// and Kinesis):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BisectBatchOnFunctionError</code> – If the function returns an error, split
        /// the batch in two and retry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DestinationConfig</code> – Send discarded records to an Amazon SQS queue or
        /// Amazon SNS topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaximumRecordAgeInSeconds</code> – Discard records older than the specified
        /// age. The default value is infinite (-1). When set to infinite (-1), failed records
        /// are retried until the record expires
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaximumRetryAttempts</code> – Discard records after the specified number of
        /// retries. The default value is infinite (-1). When set to infinite (-1), failed records
        /// are retried until the record expires.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ParallelizationFactor</code> – Process multiple batches from each shard concurrently.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about which configuration parameters apply to each event source, see
        /// the following topics.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html#services-ddb-params">
        /// Amazon DynamoDB Streams</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html#services-kinesis-params">
        /// Amazon Kinesis</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#services-sqs-params">
        /// Amazon SQS</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-mq.html#services-mq-params">
        /// Amazon MQ and RabbitMQ</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html#services-msk-parms">
        /// Amazon MSK</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kafka.html#services-kafka-parms">
        /// Apache Kafka</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventSourceMapping service method.</param>
        /// 
        /// <returns>The response from the UpdateEventSourceMapping service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example, you tried to
        /// update an event source mapping in the CREATING state, or you tried to delete an event
        /// source mapping currently UPDATING.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateEventSourceMapping">REST API Reference for UpdateEventSourceMapping Operation</seealso>
        public virtual UpdateEventSourceMappingResponse UpdateEventSourceMapping(UpdateEventSourceMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventSourceMappingResponseUnmarshaller.Instance;

            return Invoke<UpdateEventSourceMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventSourceMapping operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEventSourceMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateEventSourceMapping">REST API Reference for UpdateEventSourceMapping Operation</seealso>
        public virtual IAsyncResult BeginUpdateEventSourceMapping(UpdateEventSourceMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventSourceMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventSourceMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventSourceMapping.</param>
        /// 
        /// <returns>Returns a  UpdateEventSourceMappingResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateEventSourceMapping">REST API Reference for UpdateEventSourceMapping Operation</seealso>
        public virtual UpdateEventSourceMappingResponse EndUpdateEventSourceMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEventSourceMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFunctionCode

        /// <summary>
        /// Updates a Lambda function's code. If code signing is enabled for the function, the
        /// code package must be signed by a trusted publisher. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-codesigning.html">Configuring
        /// code signing for Lambda</a>.
        /// 
        ///  
        /// <para>
        /// If the function's package type is <code>Image</code>, then you must specify the code
        /// package in <code>ImageUri</code> as the URI of a <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-images.html">container
        /// image</a> in the Amazon ECR registry.
        /// </para>
        ///  
        /// <para>
        /// If the function's package type is <code>Zip</code>, then you must specify the deployment
        /// package as a <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-package.html#gettingstarted-package-zip">.zip
        /// file archive</a>. Enter the Amazon S3 bucket and key of the code .zip file location.
        /// You can also provide the function code inline using the <code>ZipFile</code> field.
        /// </para>
        ///  
        /// <para>
        /// The code in the deployment package must be compatible with the target instruction
        /// set architecture of the function (<code>x86-64</code> or <code>arm64</code>).
        /// </para>
        ///  
        /// <para>
        /// The function's code is locked when you publish a version. You can't modify the code
        /// of a published version, only the unpublished version.
        /// </para>
        ///  <note> 
        /// <para>
        /// For a function defined as a container image, Lambda resolves the image tag to an image
        /// digest. In Amazon ECR, if you update the image tag to a new image, Lambda does not
        /// automatically update the function.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionCode service method.</param>
        /// 
        /// <returns>The response from the UpdateFunctionCode service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeSigningConfigNotFoundException">
        /// The specified code signing configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.CodeStorageExceededException">
        /// Your Amazon Web Services account has exceeded its maximum total code size. For more
        /// information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html">Lambda
        /// quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.CodeVerificationFailedException">
        /// The code signature failed one or more of the validation checks for signature mismatch
        /// or expiry, and the code signing policy is set to ENFORCE. Lambda blocks the deployment.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidCodeSignatureException">
        /// The code signature failed the integrity check. If the integrity check fails, then
        /// Lambda blocks deployment, even if the code signing policy is set to WARN.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionCode">REST API Reference for UpdateFunctionCode Operation</seealso>
        public virtual UpdateFunctionCodeResponse UpdateFunctionCode(UpdateFunctionCodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFunctionCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionCodeResponseUnmarshaller.Instance;

            return Invoke<UpdateFunctionCodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFunctionCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionCode operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFunctionCode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionCode">REST API Reference for UpdateFunctionCode Operation</seealso>
        public virtual IAsyncResult BeginUpdateFunctionCode(UpdateFunctionCodeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFunctionCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionCodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFunctionCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFunctionCode.</param>
        /// 
        /// <returns>Returns a  UpdateFunctionCodeResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionCode">REST API Reference for UpdateFunctionCode Operation</seealso>
        public virtual UpdateFunctionCodeResponse EndUpdateFunctionCode(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFunctionCodeResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFunctionConfiguration

        /// <summary>
        /// Modify the version-specific settings of a Lambda function.
        /// 
        ///  
        /// <para>
        /// When you update a function, Lambda provisions an instance of the function and its
        /// supporting resources. If your function connects to a VPC, this process can take a
        /// minute. During this time, you can't modify the function, but you can still invoke
        /// it. The <code>LastUpdateStatus</code>, <code>LastUpdateStatusReason</code>, and <code>LastUpdateStatusReasonCode</code>
        /// fields in the response from <a>GetFunctionConfiguration</a> indicate when the update
        /// is complete and the function is processing events with the new configuration. For
        /// more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/functions-states.html">Lambda
        /// function states</a>.
        /// </para>
        ///  
        /// <para>
        /// These settings can vary between versions of a function and are locked when you publish
        /// a version. You can't modify the configuration of a published version, only the unpublished
        /// version.
        /// </para>
        ///  
        /// <para>
        /// To configure function concurrency, use <a>PutFunctionConcurrency</a>. To grant invoke
        /// permissions to an Amazon Web Services account or Amazon Web Service, use <a>AddPermission</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateFunctionConfiguration service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.CodeSigningConfigNotFoundException">
        /// The specified code signing configuration does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.CodeVerificationFailedException">
        /// The code signature failed one or more of the validation checks for signature mismatch
        /// or expiry, and the code signing policy is set to ENFORCE. Lambda blocks the deployment.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidCodeSignatureException">
        /// The code signature failed the integrity check. If the integrity check fails, then
        /// Lambda blocks deployment, even if the code signing policy is set to WARN.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.PreconditionFailedException">
        /// The RevisionId provided does not match the latest RevisionId for the Lambda function
        /// or alias. Call the <code>GetFunction</code> or the <code>GetAlias</code> API operation
        /// to retrieve the latest RevisionId for your resource.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionConfiguration">REST API Reference for UpdateFunctionConfiguration Operation</seealso>
        public virtual UpdateFunctionConfigurationResponse UpdateFunctionConfiguration(UpdateFunctionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFunctionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateFunctionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFunctionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionConfiguration operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFunctionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionConfiguration">REST API Reference for UpdateFunctionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateFunctionConfiguration(UpdateFunctionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFunctionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFunctionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFunctionConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateFunctionConfigurationResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionConfiguration">REST API Reference for UpdateFunctionConfiguration Operation</seealso>
        public virtual UpdateFunctionConfigurationResponse EndUpdateFunctionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFunctionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFunctionEventInvokeConfig

        /// <summary>
        /// Updates the configuration for asynchronous invocation for a function, version, or
        /// alias.
        /// 
        ///  
        /// <para>
        /// To configure options for asynchronous invocation, use <a>PutFunctionEventInvokeConfig</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionEventInvokeConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateFunctionEventInvokeConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionEventInvokeConfig">REST API Reference for UpdateFunctionEventInvokeConfig Operation</seealso>
        public virtual UpdateFunctionEventInvokeConfigResponse UpdateFunctionEventInvokeConfig(UpdateFunctionEventInvokeConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFunctionEventInvokeConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionEventInvokeConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateFunctionEventInvokeConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFunctionEventInvokeConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionEventInvokeConfig operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFunctionEventInvokeConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionEventInvokeConfig">REST API Reference for UpdateFunctionEventInvokeConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateFunctionEventInvokeConfig(UpdateFunctionEventInvokeConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFunctionEventInvokeConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionEventInvokeConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFunctionEventInvokeConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFunctionEventInvokeConfig.</param>
        /// 
        /// <returns>Returns a  UpdateFunctionEventInvokeConfigResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionEventInvokeConfig">REST API Reference for UpdateFunctionEventInvokeConfig Operation</seealso>
        public virtual UpdateFunctionEventInvokeConfigResponse EndUpdateFunctionEventInvokeConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFunctionEventInvokeConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFunctionUrlConfig

        /// <summary>
        /// Updates the configuration for a Lambda function URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionUrlConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateFunctionUrlConfig service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-limits.html#api-requests">Lambda
        /// quotas</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionUrlConfig">REST API Reference for UpdateFunctionUrlConfig Operation</seealso>
        public virtual UpdateFunctionUrlConfigResponse UpdateFunctionUrlConfig(UpdateFunctionUrlConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFunctionUrlConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionUrlConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateFunctionUrlConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFunctionUrlConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionUrlConfig operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFunctionUrlConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionUrlConfig">REST API Reference for UpdateFunctionUrlConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateFunctionUrlConfig(UpdateFunctionUrlConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFunctionUrlConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFunctionUrlConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFunctionUrlConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFunctionUrlConfig.</param>
        /// 
        /// <returns>Returns a  UpdateFunctionUrlConfigResult from Lambda.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionUrlConfig">REST API Reference for UpdateFunctionUrlConfig Operation</seealso>
        public virtual UpdateFunctionUrlConfigResponse EndUpdateFunctionUrlConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFunctionUrlConfigResponse>(asyncResult);
        }

        #endregion
        
    }
}