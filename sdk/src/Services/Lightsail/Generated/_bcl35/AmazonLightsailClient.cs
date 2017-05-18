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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Lightsail.Model;
using Amazon.Lightsail.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Lightsail
{
    /// <summary>
    /// Implementation for accessing Lightsail
    ///
    /// Amazon Lightsail is the easiest way to get started with AWS for developers who just
    /// need virtual private servers. Lightsail includes everything you need to launch your
    /// project quickly - a virtual machine, SSD-based storage, data transfer, DNS management,
    /// and a static IP - for a low, predictable price. You manage those Lightsail servers
    /// through the Lightsail console or by using the API or command-line interface (CLI).
    /// 
    ///  
    /// <para>
    /// For more information about Lightsail concepts and tasks, see the <a href="https://lightsail.aws.amazon.com/ls/docs/all">Lightsail
    /// Dev Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// To use the Lightsail API or the CLI, you will need to use AWS Identity and Access
    /// Management (IAM) to generate access keys. For details about how to set this up, see
    /// the <a href="http://lightsail.aws.amazon.com/ls/docs/how-to/article/lightsail-how-to-set-up-access-keys-to-use-sdk-api-cli">Lightsail
    /// Dev Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonLightsailClient : AmazonServiceClient, IAmazonLightsail
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonLightsailClient with the credentials loaded from the application's
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
        public AmazonLightsailClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLightsailConfig()) { }

        /// <summary>
        /// Constructs AmazonLightsailClient with the credentials loaded from the application's
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
        public AmazonLightsailClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLightsailConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLightsailClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLightsailClient Configuration Object</param>
        public AmazonLightsailClient(AmazonLightsailConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonLightsailClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLightsailClient(AWSCredentials credentials)
            : this(credentials, new AmazonLightsailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLightsailClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLightsailClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLightsailConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLightsailClient with AWS Credentials and an
        /// AmazonLightsailClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLightsailClient Configuration Object</param>
        public AmazonLightsailClient(AWSCredentials credentials, AmazonLightsailConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLightsailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLightsailClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLightsailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLightsailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLightsailClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLightsailConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLightsailClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLightsailClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLightsailClient Configuration Object</param>
        public AmazonLightsailClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLightsailConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLightsailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLightsailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLightsailConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLightsailClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLightsailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLightsailConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLightsailClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLightsailClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLightsailClient Configuration Object</param>
        public AmazonLightsailClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLightsailConfig clientConfig)
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

        
        #region  AllocateStaticIp

        /// <summary>
        /// Allocates a static IP address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateStaticIp service method.</param>
        /// 
        /// <returns>The response from the AllocateStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AllocateStaticIp">REST API Reference for AllocateStaticIp Operation</seealso>
        public AllocateStaticIpResponse AllocateStaticIp(AllocateStaticIpRequest request)
        {
            var marshaller = new AllocateStaticIpRequestMarshaller();
            var unmarshaller = AllocateStaticIpResponseUnmarshaller.Instance;

            return Invoke<AllocateStaticIpRequest,AllocateStaticIpResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateStaticIp operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAllocateStaticIp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AllocateStaticIp">REST API Reference for AllocateStaticIp Operation</seealso>
        public IAsyncResult BeginAllocateStaticIp(AllocateStaticIpRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AllocateStaticIpRequestMarshaller();
            var unmarshaller = AllocateStaticIpResponseUnmarshaller.Instance;

            return BeginInvoke<AllocateStaticIpRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AllocateStaticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocateStaticIp.</param>
        /// 
        /// <returns>Returns a  AllocateStaticIpResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AllocateStaticIp">REST API Reference for AllocateStaticIp Operation</seealso>
        public  AllocateStaticIpResponse EndAllocateStaticIp(IAsyncResult asyncResult)
        {
            return EndInvoke<AllocateStaticIpResponse>(asyncResult);
        }

        #endregion
        
        #region  AttachStaticIp

        /// <summary>
        /// Attaches a static IP address to a specific Amazon Lightsail instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachStaticIp service method.</param>
        /// 
        /// <returns>The response from the AttachStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachStaticIp">REST API Reference for AttachStaticIp Operation</seealso>
        public AttachStaticIpResponse AttachStaticIp(AttachStaticIpRequest request)
        {
            var marshaller = new AttachStaticIpRequestMarshaller();
            var unmarshaller = AttachStaticIpResponseUnmarshaller.Instance;

            return Invoke<AttachStaticIpRequest,AttachStaticIpResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachStaticIp operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachStaticIp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachStaticIp">REST API Reference for AttachStaticIp Operation</seealso>
        public IAsyncResult BeginAttachStaticIp(AttachStaticIpRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AttachStaticIpRequestMarshaller();
            var unmarshaller = AttachStaticIpResponseUnmarshaller.Instance;

            return BeginInvoke<AttachStaticIpRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachStaticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachStaticIp.</param>
        /// 
        /// <returns>Returns a  AttachStaticIpResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/AttachStaticIp">REST API Reference for AttachStaticIp Operation</seealso>
        public  AttachStaticIpResponse EndAttachStaticIp(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachStaticIpResponse>(asyncResult);
        }

        #endregion
        
        #region  CloseInstancePublicPorts

        /// <summary>
        /// Closes the public ports on a specific Amazon Lightsail instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloseInstancePublicPorts service method.</param>
        /// 
        /// <returns>The response from the CloseInstancePublicPorts service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CloseInstancePublicPorts">REST API Reference for CloseInstancePublicPorts Operation</seealso>
        public CloseInstancePublicPortsResponse CloseInstancePublicPorts(CloseInstancePublicPortsRequest request)
        {
            var marshaller = new CloseInstancePublicPortsRequestMarshaller();
            var unmarshaller = CloseInstancePublicPortsResponseUnmarshaller.Instance;

            return Invoke<CloseInstancePublicPortsRequest,CloseInstancePublicPortsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CloseInstancePublicPorts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CloseInstancePublicPorts operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCloseInstancePublicPorts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CloseInstancePublicPorts">REST API Reference for CloseInstancePublicPorts Operation</seealso>
        public IAsyncResult BeginCloseInstancePublicPorts(CloseInstancePublicPortsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CloseInstancePublicPortsRequestMarshaller();
            var unmarshaller = CloseInstancePublicPortsResponseUnmarshaller.Instance;

            return BeginInvoke<CloseInstancePublicPortsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CloseInstancePublicPorts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCloseInstancePublicPorts.</param>
        /// 
        /// <returns>Returns a  CloseInstancePublicPortsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CloseInstancePublicPorts">REST API Reference for CloseInstancePublicPorts Operation</seealso>
        public  CloseInstancePublicPortsResponse EndCloseInstancePublicPorts(IAsyncResult asyncResult)
        {
            return EndInvoke<CloseInstancePublicPortsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDomain

        /// <summary>
        /// Creates a domain resource for the specified domain (e.g., example.com).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var marshaller = new CreateDomainRequestMarshaller();
            var unmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainRequest,CreateDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public IAsyncResult BeginCreateDomain(CreateDomainRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateDomainRequestMarshaller();
            var unmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDomainRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomain.</param>
        /// 
        /// <returns>Returns a  CreateDomainResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public  CreateDomainResponse EndCreateDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDomainEntry

        /// <summary>
        /// Creates one of the following entry records associated with the domain: A record, CNAME
        /// record, TXT record, or MX record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainEntry service method.</param>
        /// 
        /// <returns>The response from the CreateDomainEntry service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomainEntry">REST API Reference for CreateDomainEntry Operation</seealso>
        public CreateDomainEntryResponse CreateDomainEntry(CreateDomainEntryRequest request)
        {
            var marshaller = new CreateDomainEntryRequestMarshaller();
            var unmarshaller = CreateDomainEntryResponseUnmarshaller.Instance;

            return Invoke<CreateDomainEntryRequest,CreateDomainEntryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomainEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainEntry operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomainEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomainEntry">REST API Reference for CreateDomainEntry Operation</seealso>
        public IAsyncResult BeginCreateDomainEntry(CreateDomainEntryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateDomainEntryRequestMarshaller();
            var unmarshaller = CreateDomainEntryResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDomainEntryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomainEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomainEntry.</param>
        /// 
        /// <returns>Returns a  CreateDomainEntryResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateDomainEntry">REST API Reference for CreateDomainEntry Operation</seealso>
        public  CreateDomainEntryResponse EndCreateDomainEntry(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDomainEntryResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInstances

        /// <summary>
        /// Creates one or more Amazon Lightsail virtual private servers, or <i>instances</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstances service method.</param>
        /// 
        /// <returns>The response from the CreateInstances service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstances">REST API Reference for CreateInstances Operation</seealso>
        public CreateInstancesResponse CreateInstances(CreateInstancesRequest request)
        {
            var marshaller = new CreateInstancesRequestMarshaller();
            var unmarshaller = CreateInstancesResponseUnmarshaller.Instance;

            return Invoke<CreateInstancesRequest,CreateInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstances operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstances">REST API Reference for CreateInstances Operation</seealso>
        public IAsyncResult BeginCreateInstances(CreateInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateInstancesRequestMarshaller();
            var unmarshaller = CreateInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<CreateInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstances.</param>
        /// 
        /// <returns>Returns a  CreateInstancesResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstances">REST API Reference for CreateInstances Operation</seealso>
        public  CreateInstancesResponse EndCreateInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInstancesFromSnapshot

        /// <summary>
        /// Uses a specific snapshot as a blueprint for creating one or more new instances that
        /// are based on that identical configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstancesFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateInstancesFromSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstancesFromSnapshot">REST API Reference for CreateInstancesFromSnapshot Operation</seealso>
        public CreateInstancesFromSnapshotResponse CreateInstancesFromSnapshot(CreateInstancesFromSnapshotRequest request)
        {
            var marshaller = new CreateInstancesFromSnapshotRequestMarshaller();
            var unmarshaller = CreateInstancesFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateInstancesFromSnapshotRequest,CreateInstancesFromSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstancesFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstancesFromSnapshot operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstancesFromSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstancesFromSnapshot">REST API Reference for CreateInstancesFromSnapshot Operation</seealso>
        public IAsyncResult BeginCreateInstancesFromSnapshot(CreateInstancesFromSnapshotRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateInstancesFromSnapshotRequestMarshaller();
            var unmarshaller = CreateInstancesFromSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke<CreateInstancesFromSnapshotRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstancesFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstancesFromSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateInstancesFromSnapshotResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstancesFromSnapshot">REST API Reference for CreateInstancesFromSnapshot Operation</seealso>
        public  CreateInstancesFromSnapshotResponse EndCreateInstancesFromSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInstancesFromSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInstanceSnapshot

        /// <summary>
        /// Creates a snapshot of a specific virtual private server, or <i>instance</i>. You can
        /// use a snapshot to create a new instance that is based on that snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateInstanceSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstanceSnapshot">REST API Reference for CreateInstanceSnapshot Operation</seealso>
        public CreateInstanceSnapshotResponse CreateInstanceSnapshot(CreateInstanceSnapshotRequest request)
        {
            var marshaller = new CreateInstanceSnapshotRequestMarshaller();
            var unmarshaller = CreateInstanceSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceSnapshotRequest,CreateInstanceSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceSnapshot operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstanceSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstanceSnapshot">REST API Reference for CreateInstanceSnapshot Operation</seealso>
        public IAsyncResult BeginCreateInstanceSnapshot(CreateInstanceSnapshotRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateInstanceSnapshotRequestMarshaller();
            var unmarshaller = CreateInstanceSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke<CreateInstanceSnapshotRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstanceSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstanceSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateInstanceSnapshotResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateInstanceSnapshot">REST API Reference for CreateInstanceSnapshot Operation</seealso>
        public  CreateInstanceSnapshotResponse EndCreateInstanceSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInstanceSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateKeyPair

        /// <summary>
        /// Creates sn SSH key pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair service method.</param>
        /// 
        /// <returns>The response from the CreateKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
        public CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
        {
            var marshaller = new CreateKeyPairRequestMarshaller();
            var unmarshaller = CreateKeyPairResponseUnmarshaller.Instance;

            return Invoke<CreateKeyPairRequest,CreateKeyPairResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKeyPair
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
        public IAsyncResult BeginCreateKeyPair(CreateKeyPairRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateKeyPairRequestMarshaller();
            var unmarshaller = CreateKeyPairResponseUnmarshaller.Instance;

            return BeginInvoke<CreateKeyPairRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKeyPair.</param>
        /// 
        /// <returns>Returns a  CreateKeyPairResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
        public  CreateKeyPairResponse EndCreateKeyPair(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateKeyPairResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDomain

        /// <summary>
        /// Deletes the specified domain recordset and all of its domain records.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var marshaller = new DeleteDomainRequestMarshaller();
            var unmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainRequest,DeleteDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public IAsyncResult BeginDeleteDomain(DeleteDomainRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteDomainRequestMarshaller();
            var unmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDomainRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// 
        /// <returns>Returns a  DeleteDomainResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public  DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDomainEntry

        /// <summary>
        /// Deletes a specific domain entry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainEntry service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainEntry service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomainEntry">REST API Reference for DeleteDomainEntry Operation</seealso>
        public DeleteDomainEntryResponse DeleteDomainEntry(DeleteDomainEntryRequest request)
        {
            var marshaller = new DeleteDomainEntryRequestMarshaller();
            var unmarshaller = DeleteDomainEntryResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainEntryRequest,DeleteDomainEntryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomainEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainEntry operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomainEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomainEntry">REST API Reference for DeleteDomainEntry Operation</seealso>
        public IAsyncResult BeginDeleteDomainEntry(DeleteDomainEntryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteDomainEntryRequestMarshaller();
            var unmarshaller = DeleteDomainEntryResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDomainEntryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomainEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomainEntry.</param>
        /// 
        /// <returns>Returns a  DeleteDomainEntryResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteDomainEntry">REST API Reference for DeleteDomainEntry Operation</seealso>
        public  DeleteDomainEntryResponse EndDeleteDomainEntry(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDomainEntryResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInstance

        /// <summary>
        /// Deletes a specific Amazon Lightsail virtual private server, or <i>instance</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            var marshaller = new DeleteInstanceRequestMarshaller();
            var unmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceRequest,DeleteInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstance operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        public IAsyncResult BeginDeleteInstance(DeleteInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteInstanceRequestMarshaller();
            var unmarshaller = DeleteInstanceResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteInstanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstance.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstance">REST API Reference for DeleteInstance Operation</seealso>
        public  DeleteInstanceResponse EndDeleteInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInstanceSnapshot

        /// <summary>
        /// Deletes a specific snapshot of a virtual private server (or <i>instance</i>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteInstanceSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstanceSnapshot">REST API Reference for DeleteInstanceSnapshot Operation</seealso>
        public DeleteInstanceSnapshotResponse DeleteInstanceSnapshot(DeleteInstanceSnapshotRequest request)
        {
            var marshaller = new DeleteInstanceSnapshotRequestMarshaller();
            var unmarshaller = DeleteInstanceSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteInstanceSnapshotRequest,DeleteInstanceSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceSnapshot operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstanceSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstanceSnapshot">REST API Reference for DeleteInstanceSnapshot Operation</seealso>
        public IAsyncResult BeginDeleteInstanceSnapshot(DeleteInstanceSnapshotRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteInstanceSnapshotRequestMarshaller();
            var unmarshaller = DeleteInstanceSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteInstanceSnapshotRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstanceSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstanceSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceSnapshotResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteInstanceSnapshot">REST API Reference for DeleteInstanceSnapshot Operation</seealso>
        public  DeleteInstanceSnapshotResponse EndDeleteInstanceSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInstanceSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteKeyPair

        /// <summary>
        /// Deletes a specific SSH key pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair service method.</param>
        /// 
        /// <returns>The response from the DeleteKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
        public DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request)
        {
            var marshaller = new DeleteKeyPairRequestMarshaller();
            var unmarshaller = DeleteKeyPairResponseUnmarshaller.Instance;

            return Invoke<DeleteKeyPairRequest,DeleteKeyPairResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKeyPair
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
        public IAsyncResult BeginDeleteKeyPair(DeleteKeyPairRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteKeyPairRequestMarshaller();
            var unmarshaller = DeleteKeyPairResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteKeyPairRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKeyPair.</param>
        /// 
        /// <returns>Returns a  DeleteKeyPairResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
        public  DeleteKeyPairResponse EndDeleteKeyPair(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteKeyPairResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachStaticIp

        /// <summary>
        /// Detaches a static IP from the Amazon Lightsail instance to which it is attached.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachStaticIp service method.</param>
        /// 
        /// <returns>The response from the DetachStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachStaticIp">REST API Reference for DetachStaticIp Operation</seealso>
        public DetachStaticIpResponse DetachStaticIp(DetachStaticIpRequest request)
        {
            var marshaller = new DetachStaticIpRequestMarshaller();
            var unmarshaller = DetachStaticIpResponseUnmarshaller.Instance;

            return Invoke<DetachStaticIpRequest,DetachStaticIpResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachStaticIp operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachStaticIp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachStaticIp">REST API Reference for DetachStaticIp Operation</seealso>
        public IAsyncResult BeginDetachStaticIp(DetachStaticIpRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetachStaticIpRequestMarshaller();
            var unmarshaller = DetachStaticIpResponseUnmarshaller.Instance;

            return BeginInvoke<DetachStaticIpRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachStaticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachStaticIp.</param>
        /// 
        /// <returns>Returns a  DetachStaticIpResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DetachStaticIp">REST API Reference for DetachStaticIp Operation</seealso>
        public  DetachStaticIpResponse EndDetachStaticIp(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachStaticIpResponse>(asyncResult);
        }

        #endregion
        
        #region  DownloadDefaultKeyPair

        /// <summary>
        /// Downloads the default SSH key pair from the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DownloadDefaultKeyPair service method.</param>
        /// 
        /// <returns>The response from the DownloadDefaultKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DownloadDefaultKeyPair">REST API Reference for DownloadDefaultKeyPair Operation</seealso>
        public DownloadDefaultKeyPairResponse DownloadDefaultKeyPair(DownloadDefaultKeyPairRequest request)
        {
            var marshaller = new DownloadDefaultKeyPairRequestMarshaller();
            var unmarshaller = DownloadDefaultKeyPairResponseUnmarshaller.Instance;

            return Invoke<DownloadDefaultKeyPairRequest,DownloadDefaultKeyPairResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DownloadDefaultKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DownloadDefaultKeyPair operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDownloadDefaultKeyPair
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DownloadDefaultKeyPair">REST API Reference for DownloadDefaultKeyPair Operation</seealso>
        public IAsyncResult BeginDownloadDefaultKeyPair(DownloadDefaultKeyPairRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DownloadDefaultKeyPairRequestMarshaller();
            var unmarshaller = DownloadDefaultKeyPairResponseUnmarshaller.Instance;

            return BeginInvoke<DownloadDefaultKeyPairRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DownloadDefaultKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDownloadDefaultKeyPair.</param>
        /// 
        /// <returns>Returns a  DownloadDefaultKeyPairResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/DownloadDefaultKeyPair">REST API Reference for DownloadDefaultKeyPair Operation</seealso>
        public  DownloadDefaultKeyPairResponse EndDownloadDefaultKeyPair(IAsyncResult asyncResult)
        {
            return EndInvoke<DownloadDefaultKeyPairResponse>(asyncResult);
        }

        #endregion
        
        #region  GetActiveNames

        /// <summary>
        /// Returns the names of all active (not deleted) resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetActiveNames service method.</param>
        /// 
        /// <returns>The response from the GetActiveNames service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetActiveNames">REST API Reference for GetActiveNames Operation</seealso>
        public GetActiveNamesResponse GetActiveNames(GetActiveNamesRequest request)
        {
            var marshaller = new GetActiveNamesRequestMarshaller();
            var unmarshaller = GetActiveNamesResponseUnmarshaller.Instance;

            return Invoke<GetActiveNamesRequest,GetActiveNamesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetActiveNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetActiveNames operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetActiveNames
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetActiveNames">REST API Reference for GetActiveNames Operation</seealso>
        public IAsyncResult BeginGetActiveNames(GetActiveNamesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetActiveNamesRequestMarshaller();
            var unmarshaller = GetActiveNamesResponseUnmarshaller.Instance;

            return BeginInvoke<GetActiveNamesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetActiveNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetActiveNames.</param>
        /// 
        /// <returns>Returns a  GetActiveNamesResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetActiveNames">REST API Reference for GetActiveNames Operation</seealso>
        public  GetActiveNamesResponse EndGetActiveNames(IAsyncResult asyncResult)
        {
            return EndInvoke<GetActiveNamesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBlueprints

        /// <summary>
        /// Returns the list of available instance images, or <i>blueprints</i>. You can use a
        /// blueprint to create a new virtual private server already running a specific operating
        /// system, as well as a preinstalled app or development stack. The software each instance
        /// is running depends on the blueprint image you choose.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprints service method.</param>
        /// 
        /// <returns>The response from the GetBlueprints service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBlueprints">REST API Reference for GetBlueprints Operation</seealso>
        public GetBlueprintsResponse GetBlueprints(GetBlueprintsRequest request)
        {
            var marshaller = new GetBlueprintsRequestMarshaller();
            var unmarshaller = GetBlueprintsResponseUnmarshaller.Instance;

            return Invoke<GetBlueprintsRequest,GetBlueprintsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBlueprints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlueprints operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBlueprints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBlueprints">REST API Reference for GetBlueprints Operation</seealso>
        public IAsyncResult BeginGetBlueprints(GetBlueprintsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetBlueprintsRequestMarshaller();
            var unmarshaller = GetBlueprintsResponseUnmarshaller.Instance;

            return BeginInvoke<GetBlueprintsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBlueprints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBlueprints.</param>
        /// 
        /// <returns>Returns a  GetBlueprintsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBlueprints">REST API Reference for GetBlueprints Operation</seealso>
        public  GetBlueprintsResponse EndGetBlueprints(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBlueprintsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBundles

        /// <summary>
        /// Returns the list of bundles that are available for purchase. A bundle describes the
        /// specs for your virtual private server (or <i>instance</i>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBundles service method.</param>
        /// 
        /// <returns>The response from the GetBundles service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBundles">REST API Reference for GetBundles Operation</seealso>
        public GetBundlesResponse GetBundles(GetBundlesRequest request)
        {
            var marshaller = new GetBundlesRequestMarshaller();
            var unmarshaller = GetBundlesResponseUnmarshaller.Instance;

            return Invoke<GetBundlesRequest,GetBundlesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBundles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBundles operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBundles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBundles">REST API Reference for GetBundles Operation</seealso>
        public IAsyncResult BeginGetBundles(GetBundlesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetBundlesRequestMarshaller();
            var unmarshaller = GetBundlesResponseUnmarshaller.Instance;

            return BeginInvoke<GetBundlesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBundles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBundles.</param>
        /// 
        /// <returns>Returns a  GetBundlesResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetBundles">REST API Reference for GetBundles Operation</seealso>
        public  GetBundlesResponse EndGetBundles(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBundlesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDomain

        /// <summary>
        /// Returns information about a specific domain recordset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomain">REST API Reference for GetDomain Operation</seealso>
        public GetDomainResponse GetDomain(GetDomainRequest request)
        {
            var marshaller = new GetDomainRequestMarshaller();
            var unmarshaller = GetDomainResponseUnmarshaller.Instance;

            return Invoke<GetDomainRequest,GetDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomain operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomain">REST API Reference for GetDomain Operation</seealso>
        public IAsyncResult BeginGetDomain(GetDomainRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetDomainRequestMarshaller();
            var unmarshaller = GetDomainResponseUnmarshaller.Instance;

            return BeginInvoke<GetDomainRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomain.</param>
        /// 
        /// <returns>Returns a  GetDomainResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomain">REST API Reference for GetDomain Operation</seealso>
        public  GetDomainResponse EndGetDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDomains

        /// <summary>
        /// Returns a list of all domains in the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomains service method.</param>
        /// 
        /// <returns>The response from the GetDomains service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomains">REST API Reference for GetDomains Operation</seealso>
        public GetDomainsResponse GetDomains(GetDomainsRequest request)
        {
            var marshaller = new GetDomainsRequestMarshaller();
            var unmarshaller = GetDomainsResponseUnmarshaller.Instance;

            return Invoke<GetDomainsRequest,GetDomainsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomains operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomains">REST API Reference for GetDomains Operation</seealso>
        public IAsyncResult BeginGetDomains(GetDomainsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetDomainsRequestMarshaller();
            var unmarshaller = GetDomainsResponseUnmarshaller.Instance;

            return BeginInvoke<GetDomainsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomains.</param>
        /// 
        /// <returns>Returns a  GetDomainsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetDomains">REST API Reference for GetDomains Operation</seealso>
        public  GetDomainsResponse EndGetDomains(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDomainsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInstance

        /// <summary>
        /// Returns information about a specific Amazon Lightsail instance, which is a virtual
        /// private server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstance service method.</param>
        /// 
        /// <returns>The response from the GetInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstance">REST API Reference for GetInstance Operation</seealso>
        public GetInstanceResponse GetInstance(GetInstanceRequest request)
        {
            var marshaller = new GetInstanceRequestMarshaller();
            var unmarshaller = GetInstanceResponseUnmarshaller.Instance;

            return Invoke<GetInstanceRequest,GetInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstance operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstance">REST API Reference for GetInstance Operation</seealso>
        public IAsyncResult BeginGetInstance(GetInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetInstanceRequestMarshaller();
            var unmarshaller = GetInstanceResponseUnmarshaller.Instance;

            return BeginInvoke<GetInstanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstance.</param>
        /// 
        /// <returns>Returns a  GetInstanceResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstance">REST API Reference for GetInstance Operation</seealso>
        public  GetInstanceResponse EndGetInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInstanceAccessDetails

        /// <summary>
        /// Returns temporary SSH keys you can use to connect to a specific virtual private server,
        /// or <i>instance</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceAccessDetails service method.</param>
        /// 
        /// <returns>The response from the GetInstanceAccessDetails service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceAccessDetails">REST API Reference for GetInstanceAccessDetails Operation</seealso>
        public GetInstanceAccessDetailsResponse GetInstanceAccessDetails(GetInstanceAccessDetailsRequest request)
        {
            var marshaller = new GetInstanceAccessDetailsRequestMarshaller();
            var unmarshaller = GetInstanceAccessDetailsResponseUnmarshaller.Instance;

            return Invoke<GetInstanceAccessDetailsRequest,GetInstanceAccessDetailsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceAccessDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceAccessDetails operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstanceAccessDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceAccessDetails">REST API Reference for GetInstanceAccessDetails Operation</seealso>
        public IAsyncResult BeginGetInstanceAccessDetails(GetInstanceAccessDetailsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetInstanceAccessDetailsRequestMarshaller();
            var unmarshaller = GetInstanceAccessDetailsResponseUnmarshaller.Instance;

            return BeginInvoke<GetInstanceAccessDetailsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceAccessDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceAccessDetails.</param>
        /// 
        /// <returns>Returns a  GetInstanceAccessDetailsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceAccessDetails">REST API Reference for GetInstanceAccessDetails Operation</seealso>
        public  GetInstanceAccessDetailsResponse EndGetInstanceAccessDetails(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInstanceAccessDetailsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInstanceMetricData

        /// <summary>
        /// Returns the data points for the specified Amazon Lightsail instance metric, given
        /// an instance name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceMetricData service method.</param>
        /// 
        /// <returns>The response from the GetInstanceMetricData service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceMetricData">REST API Reference for GetInstanceMetricData Operation</seealso>
        public GetInstanceMetricDataResponse GetInstanceMetricData(GetInstanceMetricDataRequest request)
        {
            var marshaller = new GetInstanceMetricDataRequestMarshaller();
            var unmarshaller = GetInstanceMetricDataResponseUnmarshaller.Instance;

            return Invoke<GetInstanceMetricDataRequest,GetInstanceMetricDataResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceMetricData operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstanceMetricData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceMetricData">REST API Reference for GetInstanceMetricData Operation</seealso>
        public IAsyncResult BeginGetInstanceMetricData(GetInstanceMetricDataRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetInstanceMetricDataRequestMarshaller();
            var unmarshaller = GetInstanceMetricDataResponseUnmarshaller.Instance;

            return BeginInvoke<GetInstanceMetricDataRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceMetricData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceMetricData.</param>
        /// 
        /// <returns>Returns a  GetInstanceMetricDataResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceMetricData">REST API Reference for GetInstanceMetricData Operation</seealso>
        public  GetInstanceMetricDataResponse EndGetInstanceMetricData(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInstanceMetricDataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInstancePortStates

        /// <summary>
        /// Returns the port states for a specific virtual private server, or <i>instance</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstancePortStates service method.</param>
        /// 
        /// <returns>The response from the GetInstancePortStates service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstancePortStates">REST API Reference for GetInstancePortStates Operation</seealso>
        public GetInstancePortStatesResponse GetInstancePortStates(GetInstancePortStatesRequest request)
        {
            var marshaller = new GetInstancePortStatesRequestMarshaller();
            var unmarshaller = GetInstancePortStatesResponseUnmarshaller.Instance;

            return Invoke<GetInstancePortStatesRequest,GetInstancePortStatesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstancePortStates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstancePortStates operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstancePortStates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstancePortStates">REST API Reference for GetInstancePortStates Operation</seealso>
        public IAsyncResult BeginGetInstancePortStates(GetInstancePortStatesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetInstancePortStatesRequestMarshaller();
            var unmarshaller = GetInstancePortStatesResponseUnmarshaller.Instance;

            return BeginInvoke<GetInstancePortStatesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstancePortStates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstancePortStates.</param>
        /// 
        /// <returns>Returns a  GetInstancePortStatesResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstancePortStates">REST API Reference for GetInstancePortStates Operation</seealso>
        public  GetInstancePortStatesResponse EndGetInstancePortStates(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInstancePortStatesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInstances

        /// <summary>
        /// Returns information about all Amazon Lightsail virtual private servers, or <i>instances</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstances service method.</param>
        /// 
        /// <returns>The response from the GetInstances service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstances">REST API Reference for GetInstances Operation</seealso>
        public GetInstancesResponse GetInstances(GetInstancesRequest request)
        {
            var marshaller = new GetInstancesRequestMarshaller();
            var unmarshaller = GetInstancesResponseUnmarshaller.Instance;

            return Invoke<GetInstancesRequest,GetInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstances operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstances">REST API Reference for GetInstances Operation</seealso>
        public IAsyncResult BeginGetInstances(GetInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetInstancesRequestMarshaller();
            var unmarshaller = GetInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<GetInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstances.</param>
        /// 
        /// <returns>Returns a  GetInstancesResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstances">REST API Reference for GetInstances Operation</seealso>
        public  GetInstancesResponse EndGetInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInstanceSnapshot

        /// <summary>
        /// Returns information about a specific instance snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceSnapshot service method.</param>
        /// 
        /// <returns>The response from the GetInstanceSnapshot service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshot">REST API Reference for GetInstanceSnapshot Operation</seealso>
        public GetInstanceSnapshotResponse GetInstanceSnapshot(GetInstanceSnapshotRequest request)
        {
            var marshaller = new GetInstanceSnapshotRequestMarshaller();
            var unmarshaller = GetInstanceSnapshotResponseUnmarshaller.Instance;

            return Invoke<GetInstanceSnapshotRequest,GetInstanceSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceSnapshot operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstanceSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshot">REST API Reference for GetInstanceSnapshot Operation</seealso>
        public IAsyncResult BeginGetInstanceSnapshot(GetInstanceSnapshotRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetInstanceSnapshotRequestMarshaller();
            var unmarshaller = GetInstanceSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke<GetInstanceSnapshotRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceSnapshot.</param>
        /// 
        /// <returns>Returns a  GetInstanceSnapshotResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshot">REST API Reference for GetInstanceSnapshot Operation</seealso>
        public  GetInstanceSnapshotResponse EndGetInstanceSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInstanceSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInstanceSnapshots

        /// <summary>
        /// Returns all instance snapshots for the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceSnapshots service method.</param>
        /// 
        /// <returns>The response from the GetInstanceSnapshots service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshots">REST API Reference for GetInstanceSnapshots Operation</seealso>
        public GetInstanceSnapshotsResponse GetInstanceSnapshots(GetInstanceSnapshotsRequest request)
        {
            var marshaller = new GetInstanceSnapshotsRequestMarshaller();
            var unmarshaller = GetInstanceSnapshotsResponseUnmarshaller.Instance;

            return Invoke<GetInstanceSnapshotsRequest,GetInstanceSnapshotsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceSnapshots operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstanceSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshots">REST API Reference for GetInstanceSnapshots Operation</seealso>
        public IAsyncResult BeginGetInstanceSnapshots(GetInstanceSnapshotsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetInstanceSnapshotsRequestMarshaller();
            var unmarshaller = GetInstanceSnapshotsResponseUnmarshaller.Instance;

            return BeginInvoke<GetInstanceSnapshotsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceSnapshots.</param>
        /// 
        /// <returns>Returns a  GetInstanceSnapshotsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceSnapshots">REST API Reference for GetInstanceSnapshots Operation</seealso>
        public  GetInstanceSnapshotsResponse EndGetInstanceSnapshots(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInstanceSnapshotsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInstanceState

        /// <summary>
        /// Returns the state of a specific instance. Works on one instance at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceState service method.</param>
        /// 
        /// <returns>The response from the GetInstanceState service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceState">REST API Reference for GetInstanceState Operation</seealso>
        public GetInstanceStateResponse GetInstanceState(GetInstanceStateRequest request)
        {
            var marshaller = new GetInstanceStateRequestMarshaller();
            var unmarshaller = GetInstanceStateResponseUnmarshaller.Instance;

            return Invoke<GetInstanceStateRequest,GetInstanceStateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceState operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstanceState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceState">REST API Reference for GetInstanceState Operation</seealso>
        public IAsyncResult BeginGetInstanceState(GetInstanceStateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetInstanceStateRequestMarshaller();
            var unmarshaller = GetInstanceStateResponseUnmarshaller.Instance;

            return BeginInvoke<GetInstanceStateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceState.</param>
        /// 
        /// <returns>Returns a  GetInstanceStateResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetInstanceState">REST API Reference for GetInstanceState Operation</seealso>
        public  GetInstanceStateResponse EndGetInstanceState(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInstanceStateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetKeyPair

        /// <summary>
        /// Returns information about a specific key pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPair service method.</param>
        /// 
        /// <returns>The response from the GetKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPair">REST API Reference for GetKeyPair Operation</seealso>
        public GetKeyPairResponse GetKeyPair(GetKeyPairRequest request)
        {
            var marshaller = new GetKeyPairRequestMarshaller();
            var unmarshaller = GetKeyPairResponseUnmarshaller.Instance;

            return Invoke<GetKeyPairRequest,GetKeyPairResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPair operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKeyPair
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPair">REST API Reference for GetKeyPair Operation</seealso>
        public IAsyncResult BeginGetKeyPair(GetKeyPairRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetKeyPairRequestMarshaller();
            var unmarshaller = GetKeyPairResponseUnmarshaller.Instance;

            return BeginInvoke<GetKeyPairRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKeyPair.</param>
        /// 
        /// <returns>Returns a  GetKeyPairResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPair">REST API Reference for GetKeyPair Operation</seealso>
        public  GetKeyPairResponse EndGetKeyPair(IAsyncResult asyncResult)
        {
            return EndInvoke<GetKeyPairResponse>(asyncResult);
        }

        #endregion
        
        #region  GetKeyPairs

        /// <summary>
        /// Returns information about all key pairs in the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPairs service method.</param>
        /// 
        /// <returns>The response from the GetKeyPairs service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPairs">REST API Reference for GetKeyPairs Operation</seealso>
        public GetKeyPairsResponse GetKeyPairs(GetKeyPairsRequest request)
        {
            var marshaller = new GetKeyPairsRequestMarshaller();
            var unmarshaller = GetKeyPairsResponseUnmarshaller.Instance;

            return Invoke<GetKeyPairsRequest,GetKeyPairsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyPairs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPairs operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKeyPairs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPairs">REST API Reference for GetKeyPairs Operation</seealso>
        public IAsyncResult BeginGetKeyPairs(GetKeyPairsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetKeyPairsRequestMarshaller();
            var unmarshaller = GetKeyPairsResponseUnmarshaller.Instance;

            return BeginInvoke<GetKeyPairsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetKeyPairs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKeyPairs.</param>
        /// 
        /// <returns>Returns a  GetKeyPairsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetKeyPairs">REST API Reference for GetKeyPairs Operation</seealso>
        public  GetKeyPairsResponse EndGetKeyPairs(IAsyncResult asyncResult)
        {
            return EndInvoke<GetKeyPairsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOperation

        /// <summary>
        /// Returns information about a specific operation. Operations include events such as
        /// when you create an instance, allocate a static IP, attach a static IP, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperation service method.</param>
        /// 
        /// <returns>The response from the GetOperation service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperation">REST API Reference for GetOperation Operation</seealso>
        public GetOperationResponse GetOperation(GetOperationRequest request)
        {
            var marshaller = new GetOperationRequestMarshaller();
            var unmarshaller = GetOperationResponseUnmarshaller.Instance;

            return Invoke<GetOperationRequest,GetOperationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperation operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperation">REST API Reference for GetOperation Operation</seealso>
        public IAsyncResult BeginGetOperation(GetOperationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetOperationRequestMarshaller();
            var unmarshaller = GetOperationResponseUnmarshaller.Instance;

            return BeginInvoke<GetOperationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOperation.</param>
        /// 
        /// <returns>Returns a  GetOperationResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperation">REST API Reference for GetOperation Operation</seealso>
        public  GetOperationResponse EndGetOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOperations

        /// <summary>
        /// Returns information about all operations.
        /// 
        ///  
        /// <para>
        /// Results are returned from oldest to newest, up to a maximum of 200. Results can be
        /// paged by making each subsequent call to <code>GetOperations</code> use the maximum
        /// (last) <code>statusChangedAt</code> value from the previous request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperations service method.</param>
        /// 
        /// <returns>The response from the GetOperations service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperations">REST API Reference for GetOperations Operation</seealso>
        public GetOperationsResponse GetOperations(GetOperationsRequest request)
        {
            var marshaller = new GetOperationsRequestMarshaller();
            var unmarshaller = GetOperationsResponseUnmarshaller.Instance;

            return Invoke<GetOperationsRequest,GetOperationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperations operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperations">REST API Reference for GetOperations Operation</seealso>
        public IAsyncResult BeginGetOperations(GetOperationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetOperationsRequestMarshaller();
            var unmarshaller = GetOperationsResponseUnmarshaller.Instance;

            return BeginInvoke<GetOperationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOperations.</param>
        /// 
        /// <returns>Returns a  GetOperationsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperations">REST API Reference for GetOperations Operation</seealso>
        public  GetOperationsResponse EndGetOperations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOperationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOperationsForResource

        /// <summary>
        /// Gets operations for a specific resource (e.g., an instance or a static IP).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperationsForResource service method.</param>
        /// 
        /// <returns>The response from the GetOperationsForResource service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperationsForResource">REST API Reference for GetOperationsForResource Operation</seealso>
        public GetOperationsForResourceResponse GetOperationsForResource(GetOperationsForResourceRequest request)
        {
            var marshaller = new GetOperationsForResourceRequestMarshaller();
            var unmarshaller = GetOperationsForResourceResponseUnmarshaller.Instance;

            return Invoke<GetOperationsForResourceRequest,GetOperationsForResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOperationsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOperationsForResource operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOperationsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperationsForResource">REST API Reference for GetOperationsForResource Operation</seealso>
        public IAsyncResult BeginGetOperationsForResource(GetOperationsForResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetOperationsForResourceRequestMarshaller();
            var unmarshaller = GetOperationsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke<GetOperationsForResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOperationsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOperationsForResource.</param>
        /// 
        /// <returns>Returns a  GetOperationsForResourceResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetOperationsForResource">REST API Reference for GetOperationsForResource Operation</seealso>
        public  GetOperationsForResourceResponse EndGetOperationsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOperationsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRegions

        /// <summary>
        /// Returns a list of all valid regions for Amazon Lightsail. Use the <code>include availability
        /// zones</code> parameter to also return the availability zones in a region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegions service method.</param>
        /// 
        /// <returns>The response from the GetRegions service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRegions">REST API Reference for GetRegions Operation</seealso>
        public GetRegionsResponse GetRegions(GetRegionsRequest request)
        {
            var marshaller = new GetRegionsRequestMarshaller();
            var unmarshaller = GetRegionsResponseUnmarshaller.Instance;

            return Invoke<GetRegionsRequest,GetRegionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRegions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRegions operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRegions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRegions">REST API Reference for GetRegions Operation</seealso>
        public IAsyncResult BeginGetRegions(GetRegionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetRegionsRequestMarshaller();
            var unmarshaller = GetRegionsResponseUnmarshaller.Instance;

            return BeginInvoke<GetRegionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRegions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRegions.</param>
        /// 
        /// <returns>Returns a  GetRegionsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetRegions">REST API Reference for GetRegions Operation</seealso>
        public  GetRegionsResponse EndGetRegions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRegionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStaticIp

        /// <summary>
        /// Returns information about a specific static IP.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStaticIp service method.</param>
        /// 
        /// <returns>The response from the GetStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIp">REST API Reference for GetStaticIp Operation</seealso>
        public GetStaticIpResponse GetStaticIp(GetStaticIpRequest request)
        {
            var marshaller = new GetStaticIpRequestMarshaller();
            var unmarshaller = GetStaticIpResponseUnmarshaller.Instance;

            return Invoke<GetStaticIpRequest,GetStaticIpResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStaticIp operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStaticIp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIp">REST API Reference for GetStaticIp Operation</seealso>
        public IAsyncResult BeginGetStaticIp(GetStaticIpRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetStaticIpRequestMarshaller();
            var unmarshaller = GetStaticIpResponseUnmarshaller.Instance;

            return BeginInvoke<GetStaticIpRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStaticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStaticIp.</param>
        /// 
        /// <returns>Returns a  GetStaticIpResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIp">REST API Reference for GetStaticIp Operation</seealso>
        public  GetStaticIpResponse EndGetStaticIp(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStaticIpResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStaticIps

        /// <summary>
        /// Returns information about all static IPs in the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStaticIps service method.</param>
        /// 
        /// <returns>The response from the GetStaticIps service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIps">REST API Reference for GetStaticIps Operation</seealso>
        public GetStaticIpsResponse GetStaticIps(GetStaticIpsRequest request)
        {
            var marshaller = new GetStaticIpsRequestMarshaller();
            var unmarshaller = GetStaticIpsResponseUnmarshaller.Instance;

            return Invoke<GetStaticIpsRequest,GetStaticIpsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStaticIps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStaticIps operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStaticIps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIps">REST API Reference for GetStaticIps Operation</seealso>
        public IAsyncResult BeginGetStaticIps(GetStaticIpsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetStaticIpsRequestMarshaller();
            var unmarshaller = GetStaticIpsResponseUnmarshaller.Instance;

            return BeginInvoke<GetStaticIpsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStaticIps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStaticIps.</param>
        /// 
        /// <returns>Returns a  GetStaticIpsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/GetStaticIps">REST API Reference for GetStaticIps Operation</seealso>
        public  GetStaticIpsResponse EndGetStaticIps(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStaticIpsResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportKeyPair

        /// <summary>
        /// Imports a public SSH key from a specific key pair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair service method.</param>
        /// 
        /// <returns>The response from the ImportKeyPair service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
        public ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
        {
            var marshaller = new ImportKeyPairRequestMarshaller();
            var unmarshaller = ImportKeyPairResponseUnmarshaller.Instance;

            return Invoke<ImportKeyPairRequest,ImportKeyPairResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportKeyPair
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
        public IAsyncResult BeginImportKeyPair(ImportKeyPairRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ImportKeyPairRequestMarshaller();
            var unmarshaller = ImportKeyPairResponseUnmarshaller.Instance;

            return BeginInvoke<ImportKeyPairRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportKeyPair.</param>
        /// 
        /// <returns>Returns a  ImportKeyPairResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
        public  ImportKeyPairResponse EndImportKeyPair(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportKeyPairResponse>(asyncResult);
        }

        #endregion
        
        #region  IsVpcPeered

        /// <summary>
        /// Returns a Boolean value indicating whether your Lightsail VPC is peered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IsVpcPeered service method.</param>
        /// 
        /// <returns>The response from the IsVpcPeered service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/IsVpcPeered">REST API Reference for IsVpcPeered Operation</seealso>
        public IsVpcPeeredResponse IsVpcPeered(IsVpcPeeredRequest request)
        {
            var marshaller = new IsVpcPeeredRequestMarshaller();
            var unmarshaller = IsVpcPeeredResponseUnmarshaller.Instance;

            return Invoke<IsVpcPeeredRequest,IsVpcPeeredResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the IsVpcPeered operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IsVpcPeered operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIsVpcPeered
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/IsVpcPeered">REST API Reference for IsVpcPeered Operation</seealso>
        public IAsyncResult BeginIsVpcPeered(IsVpcPeeredRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new IsVpcPeeredRequestMarshaller();
            var unmarshaller = IsVpcPeeredResponseUnmarshaller.Instance;

            return BeginInvoke<IsVpcPeeredRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  IsVpcPeered operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIsVpcPeered.</param>
        /// 
        /// <returns>Returns a  IsVpcPeeredResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/IsVpcPeered">REST API Reference for IsVpcPeered Operation</seealso>
        public  IsVpcPeeredResponse EndIsVpcPeered(IAsyncResult asyncResult)
        {
            return EndInvoke<IsVpcPeeredResponse>(asyncResult);
        }

        #endregion
        
        #region  OpenInstancePublicPorts

        /// <summary>
        /// Adds public ports to an Amazon Lightsail instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OpenInstancePublicPorts service method.</param>
        /// 
        /// <returns>The response from the OpenInstancePublicPorts service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/OpenInstancePublicPorts">REST API Reference for OpenInstancePublicPorts Operation</seealso>
        public OpenInstancePublicPortsResponse OpenInstancePublicPorts(OpenInstancePublicPortsRequest request)
        {
            var marshaller = new OpenInstancePublicPortsRequestMarshaller();
            var unmarshaller = OpenInstancePublicPortsResponseUnmarshaller.Instance;

            return Invoke<OpenInstancePublicPortsRequest,OpenInstancePublicPortsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the OpenInstancePublicPorts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the OpenInstancePublicPorts operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndOpenInstancePublicPorts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/OpenInstancePublicPorts">REST API Reference for OpenInstancePublicPorts Operation</seealso>
        public IAsyncResult BeginOpenInstancePublicPorts(OpenInstancePublicPortsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new OpenInstancePublicPortsRequestMarshaller();
            var unmarshaller = OpenInstancePublicPortsResponseUnmarshaller.Instance;

            return BeginInvoke<OpenInstancePublicPortsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  OpenInstancePublicPorts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginOpenInstancePublicPorts.</param>
        /// 
        /// <returns>Returns a  OpenInstancePublicPortsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/OpenInstancePublicPorts">REST API Reference for OpenInstancePublicPorts Operation</seealso>
        public  OpenInstancePublicPortsResponse EndOpenInstancePublicPorts(IAsyncResult asyncResult)
        {
            return EndInvoke<OpenInstancePublicPortsResponse>(asyncResult);
        }

        #endregion
        
        #region  PeerVpc

        /// <summary>
        /// Tries to peer the Lightsail VPC with the user's default VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PeerVpc service method.</param>
        /// 
        /// <returns>The response from the PeerVpc service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PeerVpc">REST API Reference for PeerVpc Operation</seealso>
        public PeerVpcResponse PeerVpc(PeerVpcRequest request)
        {
            var marshaller = new PeerVpcRequestMarshaller();
            var unmarshaller = PeerVpcResponseUnmarshaller.Instance;

            return Invoke<PeerVpcRequest,PeerVpcResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PeerVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PeerVpc operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPeerVpc
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PeerVpc">REST API Reference for PeerVpc Operation</seealso>
        public IAsyncResult BeginPeerVpc(PeerVpcRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PeerVpcRequestMarshaller();
            var unmarshaller = PeerVpcResponseUnmarshaller.Instance;

            return BeginInvoke<PeerVpcRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PeerVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPeerVpc.</param>
        /// 
        /// <returns>Returns a  PeerVpcResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PeerVpc">REST API Reference for PeerVpc Operation</seealso>
        public  PeerVpcResponse EndPeerVpc(IAsyncResult asyncResult)
        {
            return EndInvoke<PeerVpcResponse>(asyncResult);
        }

        #endregion
        
        #region  PutInstancePublicPorts

        /// <summary>
        /// Sets the specified open ports for an Amazon Lightsail instance, and closes all ports
        /// for every protocol not included in the current request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInstancePublicPorts service method.</param>
        /// 
        /// <returns>The response from the PutInstancePublicPorts service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PutInstancePublicPorts">REST API Reference for PutInstancePublicPorts Operation</seealso>
        public PutInstancePublicPortsResponse PutInstancePublicPorts(PutInstancePublicPortsRequest request)
        {
            var marshaller = new PutInstancePublicPortsRequestMarshaller();
            var unmarshaller = PutInstancePublicPortsResponseUnmarshaller.Instance;

            return Invoke<PutInstancePublicPortsRequest,PutInstancePublicPortsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutInstancePublicPorts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutInstancePublicPorts operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutInstancePublicPorts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PutInstancePublicPorts">REST API Reference for PutInstancePublicPorts Operation</seealso>
        public IAsyncResult BeginPutInstancePublicPorts(PutInstancePublicPortsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutInstancePublicPortsRequestMarshaller();
            var unmarshaller = PutInstancePublicPortsResponseUnmarshaller.Instance;

            return BeginInvoke<PutInstancePublicPortsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutInstancePublicPorts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutInstancePublicPorts.</param>
        /// 
        /// <returns>Returns a  PutInstancePublicPortsResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/PutInstancePublicPorts">REST API Reference for PutInstancePublicPorts Operation</seealso>
        public  PutInstancePublicPortsResponse EndPutInstancePublicPorts(IAsyncResult asyncResult)
        {
            return EndInvoke<PutInstancePublicPortsResponse>(asyncResult);
        }

        #endregion
        
        #region  RebootInstance

        /// <summary>
        /// Restarts a specific instance. When your Amazon Lightsail instance is finished rebooting,
        /// Lightsail assigns a new public IP address. To use the same IP address after restarting,
        /// create a static IP address and attach it to the instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootInstance service method.</param>
        /// 
        /// <returns>The response from the RebootInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/RebootInstance">REST API Reference for RebootInstance Operation</seealso>
        public RebootInstanceResponse RebootInstance(RebootInstanceRequest request)
        {
            var marshaller = new RebootInstanceRequestMarshaller();
            var unmarshaller = RebootInstanceResponseUnmarshaller.Instance;

            return Invoke<RebootInstanceRequest,RebootInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstance operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/RebootInstance">REST API Reference for RebootInstance Operation</seealso>
        public IAsyncResult BeginRebootInstance(RebootInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RebootInstanceRequestMarshaller();
            var unmarshaller = RebootInstanceResponseUnmarshaller.Instance;

            return BeginInvoke<RebootInstanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RebootInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootInstance.</param>
        /// 
        /// <returns>Returns a  RebootInstanceResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/RebootInstance">REST API Reference for RebootInstance Operation</seealso>
        public  RebootInstanceResponse EndRebootInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<RebootInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  ReleaseStaticIp

        /// <summary>
        /// Deletes a specific static IP from your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseStaticIp service method.</param>
        /// 
        /// <returns>The response from the ReleaseStaticIp service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ReleaseStaticIp">REST API Reference for ReleaseStaticIp Operation</seealso>
        public ReleaseStaticIpResponse ReleaseStaticIp(ReleaseStaticIpRequest request)
        {
            var marshaller = new ReleaseStaticIpRequestMarshaller();
            var unmarshaller = ReleaseStaticIpResponseUnmarshaller.Instance;

            return Invoke<ReleaseStaticIpRequest,ReleaseStaticIpResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReleaseStaticIp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleaseStaticIp operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReleaseStaticIp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ReleaseStaticIp">REST API Reference for ReleaseStaticIp Operation</seealso>
        public IAsyncResult BeginReleaseStaticIp(ReleaseStaticIpRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ReleaseStaticIpRequestMarshaller();
            var unmarshaller = ReleaseStaticIpResponseUnmarshaller.Instance;

            return BeginInvoke<ReleaseStaticIpRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReleaseStaticIp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReleaseStaticIp.</param>
        /// 
        /// <returns>Returns a  ReleaseStaticIpResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/ReleaseStaticIp">REST API Reference for ReleaseStaticIp Operation</seealso>
        public  ReleaseStaticIpResponse EndReleaseStaticIp(IAsyncResult asyncResult)
        {
            return EndInvoke<ReleaseStaticIpResponse>(asyncResult);
        }

        #endregion
        
        #region  StartInstance

        /// <summary>
        /// Starts a specific Amazon Lightsail instance from a stopped state. To restart an instance,
        /// use the reboot instance operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstance service method.</param>
        /// 
        /// <returns>The response from the StartInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StartInstance">REST API Reference for StartInstance Operation</seealso>
        public StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            var marshaller = new StartInstanceRequestMarshaller();
            var unmarshaller = StartInstanceResponseUnmarshaller.Instance;

            return Invoke<StartInstanceRequest,StartInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstance operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StartInstance">REST API Reference for StartInstance Operation</seealso>
        public IAsyncResult BeginStartInstance(StartInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StartInstanceRequestMarshaller();
            var unmarshaller = StartInstanceResponseUnmarshaller.Instance;

            return BeginInvoke<StartInstanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInstance.</param>
        /// 
        /// <returns>Returns a  StartInstanceResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StartInstance">REST API Reference for StartInstance Operation</seealso>
        public  StartInstanceResponse EndStartInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<StartInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  StopInstance

        /// <summary>
        /// Stops a specific Amazon Lightsail instance that is currently running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInstance service method.</param>
        /// 
        /// <returns>The response from the StopInstance service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StopInstance">REST API Reference for StopInstance Operation</seealso>
        public StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            var marshaller = new StopInstanceRequestMarshaller();
            var unmarshaller = StopInstanceResponseUnmarshaller.Instance;

            return Invoke<StopInstanceRequest,StopInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInstance operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StopInstance">REST API Reference for StopInstance Operation</seealso>
        public IAsyncResult BeginStopInstance(StopInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StopInstanceRequestMarshaller();
            var unmarshaller = StopInstanceResponseUnmarshaller.Instance;

            return BeginInvoke<StopInstanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopInstance.</param>
        /// 
        /// <returns>Returns a  StopInstanceResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/StopInstance">REST API Reference for StopInstance Operation</seealso>
        public  StopInstanceResponse EndStopInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<StopInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  UnpeerVpc

        /// <summary>
        /// Attempts to unpeer the Lightsail VPC from the user's default VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnpeerVpc service method.</param>
        /// 
        /// <returns>The response from the UnpeerVpc service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UnpeerVpc">REST API Reference for UnpeerVpc Operation</seealso>
        public UnpeerVpcResponse UnpeerVpc(UnpeerVpcRequest request)
        {
            var marshaller = new UnpeerVpcRequestMarshaller();
            var unmarshaller = UnpeerVpcResponseUnmarshaller.Instance;

            return Invoke<UnpeerVpcRequest,UnpeerVpcResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnpeerVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnpeerVpc operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnpeerVpc
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UnpeerVpc">REST API Reference for UnpeerVpc Operation</seealso>
        public IAsyncResult BeginUnpeerVpc(UnpeerVpcRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UnpeerVpcRequestMarshaller();
            var unmarshaller = UnpeerVpcResponseUnmarshaller.Instance;

            return BeginInvoke<UnpeerVpcRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UnpeerVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnpeerVpc.</param>
        /// 
        /// <returns>Returns a  UnpeerVpcResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UnpeerVpc">REST API Reference for UnpeerVpc Operation</seealso>
        public  UnpeerVpcResponse EndUnpeerVpc(IAsyncResult asyncResult)
        {
            return EndInvoke<UnpeerVpcResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDomainEntry

        /// <summary>
        /// Updates a domain recordset after it is created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainEntry service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainEntry service method, as returned by Lightsail.</returns>
        /// <exception cref="Amazon.Lightsail.Model.AccessDeniedException">
        /// Lightsail throws this exception when the user cannot be authenticated or uses invalid
        /// credentials to access a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.AccountSetupInProgressException">
        /// Lightsail throws this exception when an account is still in the setup in progress
        /// state.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.InvalidInputException">
        /// Lightsail throws this exception when user input does not conform to the validation
        /// rules of an input field.
        /// 
        ///  <note> 
        /// <para>
        /// Domain-related APIs are only available in the N. Virginia (us-east-1) Region. Please
        /// set your Region configuration to us-east-1 to create, view, or edit these resources.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.NotFoundException">
        /// Lightsail throws this exception when it cannot find a resource.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.OperationFailureException">
        /// Lightsail throws this exception when an operation fails to execute.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.ServiceException">
        /// A general service exception.
        /// </exception>
        /// <exception cref="Amazon.Lightsail.Model.UnauthenticatedException">
        /// Lightsail throws this exception when the user has not been authenticated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateDomainEntry">REST API Reference for UpdateDomainEntry Operation</seealso>
        public UpdateDomainEntryResponse UpdateDomainEntry(UpdateDomainEntryRequest request)
        {
            var marshaller = new UpdateDomainEntryRequestMarshaller();
            var unmarshaller = UpdateDomainEntryResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainEntryRequest,UpdateDomainEntryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainEntry operation on AmazonLightsailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateDomainEntry">REST API Reference for UpdateDomainEntry Operation</seealso>
        public IAsyncResult BeginUpdateDomainEntry(UpdateDomainEntryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateDomainEntryRequestMarshaller();
            var unmarshaller = UpdateDomainEntryResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDomainEntryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainEntry.</param>
        /// 
        /// <returns>Returns a  UpdateDomainEntryResult from Lightsail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lightsail-2016-11-28/UpdateDomainEntry">REST API Reference for UpdateDomainEntry Operation</seealso>
        public  UpdateDomainEntryResponse EndUpdateDomainEntry(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDomainEntryResponse>(asyncResult);
        }

        #endregion
        
    }
}