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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTWireless.Model;
using Amazon.IoTWireless.Model.Internal.MarshallTransformations;
using Amazon.IoTWireless.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IoTWireless
{
    /// <summary>
    /// Implementation for accessing IoTWireless
    ///
    /// AWS IoT Wireless API documentation
    /// </summary>
    public partial class AmazonIoTWirelessClient : AmazonServiceClient, IAmazonIoTWireless
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTWirelessMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with the credentials loaded from the application's
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
        public AmazonIoTWirelessClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTWirelessConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with the credentials loaded from the application's
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
        public AmazonIoTWirelessClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTWirelessConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTWirelessClient Configuration Object</param>
        public AmazonIoTWirelessClient(AmazonIoTWirelessConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTWirelessClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTWirelessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTWirelessClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTWirelessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with AWS Credentials and an
        /// AmazonIoTWirelessClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTWirelessClient Configuration Object</param>
        public AmazonIoTWirelessClient(AWSCredentials credentials, AmazonIoTWirelessConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTWirelessClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTWirelessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTWirelessClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTWirelessConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTWirelessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTWirelessClient Configuration Object</param>
        public AmazonIoTWirelessClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTWirelessConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTWirelessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTWirelessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTWirelessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTWirelessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTWirelessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTWirelessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTWirelessClient Configuration Object</param>
        public AmazonIoTWirelessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTWirelessConfig clientConfig)
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


        #region  AssociateAwsAccountWithPartnerAccount

        /// <summary>
        /// Associates a partner account with your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAwsAccountWithPartnerAccount service method.</param>
        /// 
        /// <returns>The response from the AssociateAwsAccountWithPartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateAwsAccountWithPartnerAccount">REST API Reference for AssociateAwsAccountWithPartnerAccount Operation</seealso>
        public virtual AssociateAwsAccountWithPartnerAccountResponse AssociateAwsAccountWithPartnerAccount(AssociateAwsAccountWithPartnerAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAwsAccountWithPartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAwsAccountWithPartnerAccountResponseUnmarshaller.Instance;

            return Invoke<AssociateAwsAccountWithPartnerAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAwsAccountWithPartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAwsAccountWithPartnerAccount operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAwsAccountWithPartnerAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateAwsAccountWithPartnerAccount">REST API Reference for AssociateAwsAccountWithPartnerAccount Operation</seealso>
        public virtual IAsyncResult BeginAssociateAwsAccountWithPartnerAccount(AssociateAwsAccountWithPartnerAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAwsAccountWithPartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAwsAccountWithPartnerAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAwsAccountWithPartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAwsAccountWithPartnerAccount.</param>
        /// 
        /// <returns>Returns a  AssociateAwsAccountWithPartnerAccountResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateAwsAccountWithPartnerAccount">REST API Reference for AssociateAwsAccountWithPartnerAccount Operation</seealso>
        public virtual AssociateAwsAccountWithPartnerAccountResponse EndAssociateAwsAccountWithPartnerAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateAwsAccountWithPartnerAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateWirelessDeviceWithThing

        /// <summary>
        /// Associates a wireless device with a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithThing service method.</param>
        /// 
        /// <returns>The response from the AssociateWirelessDeviceWithThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithThing">REST API Reference for AssociateWirelessDeviceWithThing Operation</seealso>
        public virtual AssociateWirelessDeviceWithThingResponse AssociateWirelessDeviceWithThing(AssociateWirelessDeviceWithThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessDeviceWithThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessDeviceWithThingResponseUnmarshaller.Instance;

            return Invoke<AssociateWirelessDeviceWithThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWirelessDeviceWithThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithThing operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWirelessDeviceWithThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithThing">REST API Reference for AssociateWirelessDeviceWithThing Operation</seealso>
        public virtual IAsyncResult BeginAssociateWirelessDeviceWithThing(AssociateWirelessDeviceWithThingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessDeviceWithThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessDeviceWithThingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWirelessDeviceWithThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWirelessDeviceWithThing.</param>
        /// 
        /// <returns>Returns a  AssociateWirelessDeviceWithThingResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithThing">REST API Reference for AssociateWirelessDeviceWithThing Operation</seealso>
        public virtual AssociateWirelessDeviceWithThingResponse EndAssociateWirelessDeviceWithThing(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateWirelessDeviceWithThingResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateWirelessGatewayWithCertificate

        /// <summary>
        /// Associates a wireless gateway with a certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessGatewayWithCertificate service method.</param>
        /// 
        /// <returns>The response from the AssociateWirelessGatewayWithCertificate service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithCertificate">REST API Reference for AssociateWirelessGatewayWithCertificate Operation</seealso>
        public virtual AssociateWirelessGatewayWithCertificateResponse AssociateWirelessGatewayWithCertificate(AssociateWirelessGatewayWithCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessGatewayWithCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessGatewayWithCertificateResponseUnmarshaller.Instance;

            return Invoke<AssociateWirelessGatewayWithCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWirelessGatewayWithCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessGatewayWithCertificate operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWirelessGatewayWithCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithCertificate">REST API Reference for AssociateWirelessGatewayWithCertificate Operation</seealso>
        public virtual IAsyncResult BeginAssociateWirelessGatewayWithCertificate(AssociateWirelessGatewayWithCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessGatewayWithCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessGatewayWithCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWirelessGatewayWithCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWirelessGatewayWithCertificate.</param>
        /// 
        /// <returns>Returns a  AssociateWirelessGatewayWithCertificateResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithCertificate">REST API Reference for AssociateWirelessGatewayWithCertificate Operation</seealso>
        public virtual AssociateWirelessGatewayWithCertificateResponse EndAssociateWirelessGatewayWithCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateWirelessGatewayWithCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateWirelessGatewayWithThing

        /// <summary>
        /// Associates a wireless gateway with a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessGatewayWithThing service method.</param>
        /// 
        /// <returns>The response from the AssociateWirelessGatewayWithThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithThing">REST API Reference for AssociateWirelessGatewayWithThing Operation</seealso>
        public virtual AssociateWirelessGatewayWithThingResponse AssociateWirelessGatewayWithThing(AssociateWirelessGatewayWithThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessGatewayWithThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessGatewayWithThingResponseUnmarshaller.Instance;

            return Invoke<AssociateWirelessGatewayWithThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWirelessGatewayWithThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessGatewayWithThing operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWirelessGatewayWithThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithThing">REST API Reference for AssociateWirelessGatewayWithThing Operation</seealso>
        public virtual IAsyncResult BeginAssociateWirelessGatewayWithThing(AssociateWirelessGatewayWithThingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWirelessGatewayWithThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWirelessGatewayWithThingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWirelessGatewayWithThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWirelessGatewayWithThing.</param>
        /// 
        /// <returns>Returns a  AssociateWirelessGatewayWithThingResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithThing">REST API Reference for AssociateWirelessGatewayWithThing Operation</seealso>
        public virtual AssociateWirelessGatewayWithThingResponse EndAssociateWirelessGatewayWithThing(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateWirelessGatewayWithThingResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDestination

        /// <summary>
        /// Creates a new destination that maps a device message to an AWS IoT rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDestination service method.</param>
        /// 
        /// <returns>The response from the CreateDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        public virtual CreateDestinationResponse CreateDestination(CreateDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDestinationResponseUnmarshaller.Instance;

            return Invoke<CreateDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDestination operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        public virtual IAsyncResult BeginCreateDestination(CreateDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDestination.</param>
        /// 
        /// <returns>Returns a  CreateDestinationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        public virtual CreateDestinationResponse EndCreateDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDeviceProfile

        /// <summary>
        /// Creates a new device profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceProfile service method.</param>
        /// 
        /// <returns>The response from the CreateDeviceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDeviceProfile">REST API Reference for CreateDeviceProfile Operation</seealso>
        public virtual CreateDeviceProfileResponse CreateDeviceProfile(CreateDeviceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeviceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeviceProfileResponseUnmarshaller.Instance;

            return Invoke<CreateDeviceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeviceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceProfile operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeviceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDeviceProfile">REST API Reference for CreateDeviceProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateDeviceProfile(CreateDeviceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeviceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeviceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeviceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeviceProfile.</param>
        /// 
        /// <returns>Returns a  CreateDeviceProfileResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDeviceProfile">REST API Reference for CreateDeviceProfile Operation</seealso>
        public virtual CreateDeviceProfileResponse EndCreateDeviceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDeviceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateServiceProfile

        /// <summary>
        /// Creates a new service profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceProfile service method.</param>
        /// 
        /// <returns>The response from the CreateServiceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateServiceProfile">REST API Reference for CreateServiceProfile Operation</seealso>
        public virtual CreateServiceProfileResponse CreateServiceProfile(CreateServiceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceProfileResponseUnmarshaller.Instance;

            return Invoke<CreateServiceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceProfile operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateServiceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateServiceProfile">REST API Reference for CreateServiceProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateServiceProfile(CreateServiceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateServiceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateServiceProfile.</param>
        /// 
        /// <returns>Returns a  CreateServiceProfileResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateServiceProfile">REST API Reference for CreateServiceProfile Operation</seealso>
        public virtual CreateServiceProfileResponse EndCreateServiceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateServiceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWirelessDevice

        /// <summary>
        /// Provisions a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the CreateWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessDevice">REST API Reference for CreateWirelessDevice Operation</seealso>
        public virtual CreateWirelessDeviceResponse CreateWirelessDevice(CreateWirelessDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessDeviceResponseUnmarshaller.Instance;

            return Invoke<CreateWirelessDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessDevice">REST API Reference for CreateWirelessDevice Operation</seealso>
        public virtual IAsyncResult BeginCreateWirelessDevice(CreateWirelessDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWirelessDevice.</param>
        /// 
        /// <returns>Returns a  CreateWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessDevice">REST API Reference for CreateWirelessDevice Operation</seealso>
        public virtual CreateWirelessDeviceResponse EndCreateWirelessDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWirelessDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWirelessGateway

        /// <summary>
        /// Provisions a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGateway service method.</param>
        /// 
        /// <returns>The response from the CreateWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGateway">REST API Reference for CreateWirelessGateway Operation</seealso>
        public virtual CreateWirelessGatewayResponse CreateWirelessGateway(CreateWirelessGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateWirelessGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGateway operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWirelessGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGateway">REST API Reference for CreateWirelessGateway Operation</seealso>
        public virtual IAsyncResult BeginCreateWirelessGateway(CreateWirelessGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWirelessGateway.</param>
        /// 
        /// <returns>Returns a  CreateWirelessGatewayResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGateway">REST API Reference for CreateWirelessGateway Operation</seealso>
        public virtual CreateWirelessGatewayResponse EndCreateWirelessGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWirelessGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWirelessGatewayTask

        /// <summary>
        /// Creates a task for a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGatewayTask service method.</param>
        /// 
        /// <returns>The response from the CreateWirelessGatewayTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTask">REST API Reference for CreateWirelessGatewayTask Operation</seealso>
        public virtual CreateWirelessGatewayTaskResponse CreateWirelessGatewayTask(CreateWirelessGatewayTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessGatewayTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessGatewayTaskResponseUnmarshaller.Instance;

            return Invoke<CreateWirelessGatewayTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWirelessGatewayTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGatewayTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWirelessGatewayTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTask">REST API Reference for CreateWirelessGatewayTask Operation</seealso>
        public virtual IAsyncResult BeginCreateWirelessGatewayTask(CreateWirelessGatewayTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessGatewayTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessGatewayTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWirelessGatewayTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWirelessGatewayTask.</param>
        /// 
        /// <returns>Returns a  CreateWirelessGatewayTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTask">REST API Reference for CreateWirelessGatewayTask Operation</seealso>
        public virtual CreateWirelessGatewayTaskResponse EndCreateWirelessGatewayTask(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWirelessGatewayTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWirelessGatewayTaskDefinition

        /// <summary>
        /// Creates a gateway task definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGatewayTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateWirelessGatewayTaskDefinition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTaskDefinition">REST API Reference for CreateWirelessGatewayTaskDefinition Operation</seealso>
        public virtual CreateWirelessGatewayTaskDefinitionResponse CreateWirelessGatewayTaskDefinition(CreateWirelessGatewayTaskDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessGatewayTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessGatewayTaskDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateWirelessGatewayTaskDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWirelessGatewayTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGatewayTaskDefinition operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWirelessGatewayTaskDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTaskDefinition">REST API Reference for CreateWirelessGatewayTaskDefinition Operation</seealso>
        public virtual IAsyncResult BeginCreateWirelessGatewayTaskDefinition(CreateWirelessGatewayTaskDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWirelessGatewayTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWirelessGatewayTaskDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWirelessGatewayTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWirelessGatewayTaskDefinition.</param>
        /// 
        /// <returns>Returns a  CreateWirelessGatewayTaskDefinitionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTaskDefinition">REST API Reference for CreateWirelessGatewayTaskDefinition Operation</seealso>
        public virtual CreateWirelessGatewayTaskDefinitionResponse EndCreateWirelessGatewayTaskDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWirelessGatewayTaskDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDestination

        /// <summary>
        /// Deletes a destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        public virtual DeleteDestinationResponse DeleteDestination(DeleteDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        public virtual IAsyncResult BeginDeleteDestination(DeleteDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDestination.</param>
        /// 
        /// <returns>Returns a  DeleteDestinationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        public virtual DeleteDestinationResponse EndDeleteDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDeviceProfile

        /// <summary>
        /// Deletes a device profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteDeviceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDeviceProfile">REST API Reference for DeleteDeviceProfile Operation</seealso>
        public virtual DeleteDeviceProfileResponse DeleteDeviceProfile(DeleteDeviceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteDeviceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeviceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceProfile operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeviceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDeviceProfile">REST API Reference for DeleteDeviceProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteDeviceProfile(DeleteDeviceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeviceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeviceProfile.</param>
        /// 
        /// <returns>Returns a  DeleteDeviceProfileResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDeviceProfile">REST API Reference for DeleteDeviceProfile Operation</seealso>
        public virtual DeleteDeviceProfileResponse EndDeleteDeviceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeviceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteServiceProfile

        /// <summary>
        /// Deletes a service profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteServiceProfile">REST API Reference for DeleteServiceProfile Operation</seealso>
        public virtual DeleteServiceProfileResponse DeleteServiceProfile(DeleteServiceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceProfile operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServiceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteServiceProfile">REST API Reference for DeleteServiceProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteServiceProfile(DeleteServiceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServiceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServiceProfile.</param>
        /// 
        /// <returns>Returns a  DeleteServiceProfileResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteServiceProfile">REST API Reference for DeleteServiceProfile Operation</seealso>
        public virtual DeleteServiceProfileResponse EndDeleteServiceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteServiceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWirelessDevice

        /// <summary>
        /// Deletes a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the DeleteWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessDevice">REST API Reference for DeleteWirelessDevice Operation</seealso>
        public virtual DeleteWirelessDeviceResponse DeleteWirelessDevice(DeleteWirelessDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessDeviceResponseUnmarshaller.Instance;

            return Invoke<DeleteWirelessDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessDevice">REST API Reference for DeleteWirelessDevice Operation</seealso>
        public virtual IAsyncResult BeginDeleteWirelessDevice(DeleteWirelessDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWirelessDevice.</param>
        /// 
        /// <returns>Returns a  DeleteWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessDevice">REST API Reference for DeleteWirelessDevice Operation</seealso>
        public virtual DeleteWirelessDeviceResponse EndDeleteWirelessDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWirelessDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWirelessGateway

        /// <summary>
        /// Deletes a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGateway">REST API Reference for DeleteWirelessGateway Operation</seealso>
        public virtual DeleteWirelessGatewayResponse DeleteWirelessGateway(DeleteWirelessGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteWirelessGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGateway operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWirelessGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGateway">REST API Reference for DeleteWirelessGateway Operation</seealso>
        public virtual IAsyncResult BeginDeleteWirelessGateway(DeleteWirelessGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWirelessGateway.</param>
        /// 
        /// <returns>Returns a  DeleteWirelessGatewayResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGateway">REST API Reference for DeleteWirelessGateway Operation</seealso>
        public virtual DeleteWirelessGatewayResponse EndDeleteWirelessGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWirelessGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWirelessGatewayTask

        /// <summary>
        /// Deletes a wireless gateway task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGatewayTask service method.</param>
        /// 
        /// <returns>The response from the DeleteWirelessGatewayTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTask">REST API Reference for DeleteWirelessGatewayTask Operation</seealso>
        public virtual DeleteWirelessGatewayTaskResponse DeleteWirelessGatewayTask(DeleteWirelessGatewayTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessGatewayTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessGatewayTaskResponseUnmarshaller.Instance;

            return Invoke<DeleteWirelessGatewayTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWirelessGatewayTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGatewayTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWirelessGatewayTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTask">REST API Reference for DeleteWirelessGatewayTask Operation</seealso>
        public virtual IAsyncResult BeginDeleteWirelessGatewayTask(DeleteWirelessGatewayTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessGatewayTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessGatewayTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWirelessGatewayTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWirelessGatewayTask.</param>
        /// 
        /// <returns>Returns a  DeleteWirelessGatewayTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTask">REST API Reference for DeleteWirelessGatewayTask Operation</seealso>
        public virtual DeleteWirelessGatewayTaskResponse EndDeleteWirelessGatewayTask(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWirelessGatewayTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWirelessGatewayTaskDefinition

        /// <summary>
        /// Deletes a wireless gateway task definition. Deleting this task definition does not
        /// affect tasks that are currently in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGatewayTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteWirelessGatewayTaskDefinition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTaskDefinition">REST API Reference for DeleteWirelessGatewayTaskDefinition Operation</seealso>
        public virtual DeleteWirelessGatewayTaskDefinitionResponse DeleteWirelessGatewayTaskDefinition(DeleteWirelessGatewayTaskDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessGatewayTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessGatewayTaskDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteWirelessGatewayTaskDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWirelessGatewayTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGatewayTaskDefinition operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWirelessGatewayTaskDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTaskDefinition">REST API Reference for DeleteWirelessGatewayTaskDefinition Operation</seealso>
        public virtual IAsyncResult BeginDeleteWirelessGatewayTaskDefinition(DeleteWirelessGatewayTaskDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWirelessGatewayTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWirelessGatewayTaskDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWirelessGatewayTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWirelessGatewayTaskDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteWirelessGatewayTaskDefinitionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTaskDefinition">REST API Reference for DeleteWirelessGatewayTaskDefinition Operation</seealso>
        public virtual DeleteWirelessGatewayTaskDefinitionResponse EndDeleteWirelessGatewayTaskDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWirelessGatewayTaskDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateAwsAccountFromPartnerAccount

        /// <summary>
        /// Disassociates your AWS account from a partner account. If <code>PartnerAccountId</code>
        /// and <code>PartnerType</code> are <code>null</code>, disassociates your AWS account
        /// from all partner accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAwsAccountFromPartnerAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateAwsAccountFromPartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateAwsAccountFromPartnerAccount">REST API Reference for DisassociateAwsAccountFromPartnerAccount Operation</seealso>
        public virtual DisassociateAwsAccountFromPartnerAccountResponse DisassociateAwsAccountFromPartnerAccount(DisassociateAwsAccountFromPartnerAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAwsAccountFromPartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAwsAccountFromPartnerAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateAwsAccountFromPartnerAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAwsAccountFromPartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAwsAccountFromPartnerAccount operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateAwsAccountFromPartnerAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateAwsAccountFromPartnerAccount">REST API Reference for DisassociateAwsAccountFromPartnerAccount Operation</seealso>
        public virtual IAsyncResult BeginDisassociateAwsAccountFromPartnerAccount(DisassociateAwsAccountFromPartnerAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAwsAccountFromPartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAwsAccountFromPartnerAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateAwsAccountFromPartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAwsAccountFromPartnerAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateAwsAccountFromPartnerAccountResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateAwsAccountFromPartnerAccount">REST API Reference for DisassociateAwsAccountFromPartnerAccount Operation</seealso>
        public virtual DisassociateAwsAccountFromPartnerAccountResponse EndDisassociateAwsAccountFromPartnerAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateAwsAccountFromPartnerAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateWirelessDeviceFromThing

        /// <summary>
        /// Disassociates a wireless device from its currently associated thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromThing service method.</param>
        /// 
        /// <returns>The response from the DisassociateWirelessDeviceFromThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromThing">REST API Reference for DisassociateWirelessDeviceFromThing Operation</seealso>
        public virtual DisassociateWirelessDeviceFromThingResponse DisassociateWirelessDeviceFromThing(DisassociateWirelessDeviceFromThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessDeviceFromThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessDeviceFromThingResponseUnmarshaller.Instance;

            return Invoke<DisassociateWirelessDeviceFromThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWirelessDeviceFromThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromThing operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWirelessDeviceFromThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromThing">REST API Reference for DisassociateWirelessDeviceFromThing Operation</seealso>
        public virtual IAsyncResult BeginDisassociateWirelessDeviceFromThing(DisassociateWirelessDeviceFromThingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessDeviceFromThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessDeviceFromThingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWirelessDeviceFromThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWirelessDeviceFromThing.</param>
        /// 
        /// <returns>Returns a  DisassociateWirelessDeviceFromThingResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromThing">REST API Reference for DisassociateWirelessDeviceFromThing Operation</seealso>
        public virtual DisassociateWirelessDeviceFromThingResponse EndDisassociateWirelessDeviceFromThing(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateWirelessDeviceFromThingResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateWirelessGatewayFromCertificate

        /// <summary>
        /// Disassociates a wireless gateway from its currently associated certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessGatewayFromCertificate service method.</param>
        /// 
        /// <returns>The response from the DisassociateWirelessGatewayFromCertificate service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromCertificate">REST API Reference for DisassociateWirelessGatewayFromCertificate Operation</seealso>
        public virtual DisassociateWirelessGatewayFromCertificateResponse DisassociateWirelessGatewayFromCertificate(DisassociateWirelessGatewayFromCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessGatewayFromCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessGatewayFromCertificateResponseUnmarshaller.Instance;

            return Invoke<DisassociateWirelessGatewayFromCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWirelessGatewayFromCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessGatewayFromCertificate operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWirelessGatewayFromCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromCertificate">REST API Reference for DisassociateWirelessGatewayFromCertificate Operation</seealso>
        public virtual IAsyncResult BeginDisassociateWirelessGatewayFromCertificate(DisassociateWirelessGatewayFromCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessGatewayFromCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessGatewayFromCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWirelessGatewayFromCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWirelessGatewayFromCertificate.</param>
        /// 
        /// <returns>Returns a  DisassociateWirelessGatewayFromCertificateResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromCertificate">REST API Reference for DisassociateWirelessGatewayFromCertificate Operation</seealso>
        public virtual DisassociateWirelessGatewayFromCertificateResponse EndDisassociateWirelessGatewayFromCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateWirelessGatewayFromCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateWirelessGatewayFromThing

        /// <summary>
        /// Disassociates a wireless gateway from its currently associated thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessGatewayFromThing service method.</param>
        /// 
        /// <returns>The response from the DisassociateWirelessGatewayFromThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromThing">REST API Reference for DisassociateWirelessGatewayFromThing Operation</seealso>
        public virtual DisassociateWirelessGatewayFromThingResponse DisassociateWirelessGatewayFromThing(DisassociateWirelessGatewayFromThingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessGatewayFromThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessGatewayFromThingResponseUnmarshaller.Instance;

            return Invoke<DisassociateWirelessGatewayFromThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWirelessGatewayFromThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessGatewayFromThing operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWirelessGatewayFromThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromThing">REST API Reference for DisassociateWirelessGatewayFromThing Operation</seealso>
        public virtual IAsyncResult BeginDisassociateWirelessGatewayFromThing(DisassociateWirelessGatewayFromThingRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWirelessGatewayFromThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWirelessGatewayFromThingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWirelessGatewayFromThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWirelessGatewayFromThing.</param>
        /// 
        /// <returns>Returns a  DisassociateWirelessGatewayFromThingResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromThing">REST API Reference for DisassociateWirelessGatewayFromThing Operation</seealso>
        public virtual DisassociateWirelessGatewayFromThingResponse EndDisassociateWirelessGatewayFromThing(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateWirelessGatewayFromThingResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDestination

        /// <summary>
        /// Gets information about a destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDestination service method.</param>
        /// 
        /// <returns>The response from the GetDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDestination">REST API Reference for GetDestination Operation</seealso>
        public virtual GetDestinationResponse GetDestination(GetDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDestinationResponseUnmarshaller.Instance;

            return Invoke<GetDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDestination operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDestination">REST API Reference for GetDestination Operation</seealso>
        public virtual IAsyncResult BeginGetDestination(GetDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDestination.</param>
        /// 
        /// <returns>Returns a  GetDestinationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDestination">REST API Reference for GetDestination Operation</seealso>
        public virtual GetDestinationResponse EndGetDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDeviceProfile

        /// <summary>
        /// Gets information about a device profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceProfile service method.</param>
        /// 
        /// <returns>The response from the GetDeviceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDeviceProfile">REST API Reference for GetDeviceProfile Operation</seealso>
        public virtual GetDeviceProfileResponse GetDeviceProfile(GetDeviceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceProfileResponseUnmarshaller.Instance;

            return Invoke<GetDeviceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeviceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceProfile operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeviceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDeviceProfile">REST API Reference for GetDeviceProfile Operation</seealso>
        public virtual IAsyncResult BeginGetDeviceProfile(GetDeviceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeviceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeviceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeviceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeviceProfile.</param>
        /// 
        /// <returns>Returns a  GetDeviceProfileResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDeviceProfile">REST API Reference for GetDeviceProfile Operation</seealso>
        public virtual GetDeviceProfileResponse EndGetDeviceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeviceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPartnerAccount

        /// <summary>
        /// Gets information about a partner account. If <code>PartnerAccountId</code> and <code>PartnerType</code>
        /// are <code>null</code>, returns all partner accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartnerAccount service method.</param>
        /// 
        /// <returns>The response from the GetPartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPartnerAccount">REST API Reference for GetPartnerAccount Operation</seealso>
        public virtual GetPartnerAccountResponse GetPartnerAccount(GetPartnerAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartnerAccountResponseUnmarshaller.Instance;

            return Invoke<GetPartnerAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPartnerAccount operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPartnerAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPartnerAccount">REST API Reference for GetPartnerAccount Operation</seealso>
        public virtual IAsyncResult BeginGetPartnerAccount(GetPartnerAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPartnerAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPartnerAccount.</param>
        /// 
        /// <returns>Returns a  GetPartnerAccountResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPartnerAccount">REST API Reference for GetPartnerAccount Operation</seealso>
        public virtual GetPartnerAccountResponse EndGetPartnerAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPartnerAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  GetServiceEndpoint

        /// <summary>
        /// Gets the account-specific endpoint for Configuration and Update Server (CUPS) protocol
        /// or LoRaWAN Network Server (LNS) connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetServiceEndpoint service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceEndpoint">REST API Reference for GetServiceEndpoint Operation</seealso>
        public virtual GetServiceEndpointResponse GetServiceEndpoint(GetServiceEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceEndpointResponseUnmarshaller.Instance;

            return Invoke<GetServiceEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceEndpoint operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceEndpoint">REST API Reference for GetServiceEndpoint Operation</seealso>
        public virtual IAsyncResult BeginGetServiceEndpoint(GetServiceEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceEndpoint.</param>
        /// 
        /// <returns>Returns a  GetServiceEndpointResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceEndpoint">REST API Reference for GetServiceEndpoint Operation</seealso>
        public virtual GetServiceEndpointResponse EndGetServiceEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServiceEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  GetServiceProfile

        /// <summary>
        /// Gets information about a service profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceProfile service method.</param>
        /// 
        /// <returns>The response from the GetServiceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceProfile">REST API Reference for GetServiceProfile Operation</seealso>
        public virtual GetServiceProfileResponse GetServiceProfile(GetServiceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceProfileResponseUnmarshaller.Instance;

            return Invoke<GetServiceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceProfile operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceProfile">REST API Reference for GetServiceProfile Operation</seealso>
        public virtual IAsyncResult BeginGetServiceProfile(GetServiceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceProfile.</param>
        /// 
        /// <returns>Returns a  GetServiceProfileResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceProfile">REST API Reference for GetServiceProfile Operation</seealso>
        public virtual GetServiceProfileResponse EndGetServiceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServiceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWirelessDevice

        /// <summary>
        /// Gets information about a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the GetWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDevice">REST API Reference for GetWirelessDevice Operation</seealso>
        public virtual GetWirelessDeviceResponse GetWirelessDevice(GetWirelessDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessDeviceResponseUnmarshaller.Instance;

            return Invoke<GetWirelessDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDevice">REST API Reference for GetWirelessDevice Operation</seealso>
        public virtual IAsyncResult BeginGetWirelessDevice(GetWirelessDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessDevice.</param>
        /// 
        /// <returns>Returns a  GetWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDevice">REST API Reference for GetWirelessDevice Operation</seealso>
        public virtual GetWirelessDeviceResponse EndGetWirelessDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWirelessDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWirelessDeviceStatistics

        /// <summary>
        /// Gets operating information about a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDeviceStatistics service method.</param>
        /// 
        /// <returns>The response from the GetWirelessDeviceStatistics service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDeviceStatistics">REST API Reference for GetWirelessDeviceStatistics Operation</seealso>
        public virtual GetWirelessDeviceStatisticsResponse GetWirelessDeviceStatistics(GetWirelessDeviceStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessDeviceStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessDeviceStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetWirelessDeviceStatisticsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessDeviceStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDeviceStatistics operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessDeviceStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDeviceStatistics">REST API Reference for GetWirelessDeviceStatistics Operation</seealso>
        public virtual IAsyncResult BeginGetWirelessDeviceStatistics(GetWirelessDeviceStatisticsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessDeviceStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessDeviceStatisticsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessDeviceStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessDeviceStatistics.</param>
        /// 
        /// <returns>Returns a  GetWirelessDeviceStatisticsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDeviceStatistics">REST API Reference for GetWirelessDeviceStatistics Operation</seealso>
        public virtual GetWirelessDeviceStatisticsResponse EndGetWirelessDeviceStatistics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWirelessDeviceStatisticsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWirelessGateway

        /// <summary>
        /// Gets information about a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGateway service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGateway">REST API Reference for GetWirelessGateway Operation</seealso>
        public virtual GetWirelessGatewayResponse GetWirelessGateway(GetWirelessGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayResponseUnmarshaller.Instance;

            return Invoke<GetWirelessGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGateway operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGateway">REST API Reference for GetWirelessGateway Operation</seealso>
        public virtual IAsyncResult BeginGetWirelessGateway(GetWirelessGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessGateway.</param>
        /// 
        /// <returns>Returns a  GetWirelessGatewayResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGateway">REST API Reference for GetWirelessGateway Operation</seealso>
        public virtual GetWirelessGatewayResponse EndGetWirelessGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWirelessGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWirelessGatewayCertificate

        /// <summary>
        /// Gets the ID of the certificate that is currently associated with a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayCertificate service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayCertificate service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayCertificate">REST API Reference for GetWirelessGatewayCertificate Operation</seealso>
        public virtual GetWirelessGatewayCertificateResponse GetWirelessGatewayCertificate(GetWirelessGatewayCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayCertificateResponseUnmarshaller.Instance;

            return Invoke<GetWirelessGatewayCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessGatewayCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayCertificate operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessGatewayCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayCertificate">REST API Reference for GetWirelessGatewayCertificate Operation</seealso>
        public virtual IAsyncResult BeginGetWirelessGatewayCertificate(GetWirelessGatewayCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessGatewayCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessGatewayCertificate.</param>
        /// 
        /// <returns>Returns a  GetWirelessGatewayCertificateResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayCertificate">REST API Reference for GetWirelessGatewayCertificate Operation</seealso>
        public virtual GetWirelessGatewayCertificateResponse EndGetWirelessGatewayCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWirelessGatewayCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWirelessGatewayFirmwareInformation

        /// <summary>
        /// Gets the firmware version and other information about a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayFirmwareInformation service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayFirmwareInformation service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayFirmwareInformation">REST API Reference for GetWirelessGatewayFirmwareInformation Operation</seealso>
        public virtual GetWirelessGatewayFirmwareInformationResponse GetWirelessGatewayFirmwareInformation(GetWirelessGatewayFirmwareInformationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayFirmwareInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayFirmwareInformationResponseUnmarshaller.Instance;

            return Invoke<GetWirelessGatewayFirmwareInformationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessGatewayFirmwareInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayFirmwareInformation operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessGatewayFirmwareInformation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayFirmwareInformation">REST API Reference for GetWirelessGatewayFirmwareInformation Operation</seealso>
        public virtual IAsyncResult BeginGetWirelessGatewayFirmwareInformation(GetWirelessGatewayFirmwareInformationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayFirmwareInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayFirmwareInformationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessGatewayFirmwareInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessGatewayFirmwareInformation.</param>
        /// 
        /// <returns>Returns a  GetWirelessGatewayFirmwareInformationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayFirmwareInformation">REST API Reference for GetWirelessGatewayFirmwareInformation Operation</seealso>
        public virtual GetWirelessGatewayFirmwareInformationResponse EndGetWirelessGatewayFirmwareInformation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWirelessGatewayFirmwareInformationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWirelessGatewayStatistics

        /// <summary>
        /// Gets operating information about a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayStatistics service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayStatistics service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayStatistics">REST API Reference for GetWirelessGatewayStatistics Operation</seealso>
        public virtual GetWirelessGatewayStatisticsResponse GetWirelessGatewayStatistics(GetWirelessGatewayStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetWirelessGatewayStatisticsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessGatewayStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayStatistics operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessGatewayStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayStatistics">REST API Reference for GetWirelessGatewayStatistics Operation</seealso>
        public virtual IAsyncResult BeginGetWirelessGatewayStatistics(GetWirelessGatewayStatisticsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayStatisticsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessGatewayStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessGatewayStatistics.</param>
        /// 
        /// <returns>Returns a  GetWirelessGatewayStatisticsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayStatistics">REST API Reference for GetWirelessGatewayStatistics Operation</seealso>
        public virtual GetWirelessGatewayStatisticsResponse EndGetWirelessGatewayStatistics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWirelessGatewayStatisticsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWirelessGatewayTask

        /// <summary>
        /// Gets information about a wireless gateway task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayTask service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTask">REST API Reference for GetWirelessGatewayTask Operation</seealso>
        public virtual GetWirelessGatewayTaskResponse GetWirelessGatewayTask(GetWirelessGatewayTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayTaskResponseUnmarshaller.Instance;

            return Invoke<GetWirelessGatewayTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessGatewayTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessGatewayTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTask">REST API Reference for GetWirelessGatewayTask Operation</seealso>
        public virtual IAsyncResult BeginGetWirelessGatewayTask(GetWirelessGatewayTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessGatewayTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessGatewayTask.</param>
        /// 
        /// <returns>Returns a  GetWirelessGatewayTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTask">REST API Reference for GetWirelessGatewayTask Operation</seealso>
        public virtual GetWirelessGatewayTaskResponse EndGetWirelessGatewayTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWirelessGatewayTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWirelessGatewayTaskDefinition

        /// <summary>
        /// Gets information about a wireless gateway task definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayTaskDefinition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTaskDefinition">REST API Reference for GetWirelessGatewayTaskDefinition Operation</seealso>
        public virtual GetWirelessGatewayTaskDefinitionResponse GetWirelessGatewayTaskDefinition(GetWirelessGatewayTaskDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayTaskDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetWirelessGatewayTaskDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessGatewayTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayTaskDefinition operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessGatewayTaskDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTaskDefinition">REST API Reference for GetWirelessGatewayTaskDefinition Operation</seealso>
        public virtual IAsyncResult BeginGetWirelessGatewayTaskDefinition(GetWirelessGatewayTaskDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWirelessGatewayTaskDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWirelessGatewayTaskDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessGatewayTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessGatewayTaskDefinition.</param>
        /// 
        /// <returns>Returns a  GetWirelessGatewayTaskDefinitionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTaskDefinition">REST API Reference for GetWirelessGatewayTaskDefinition Operation</seealso>
        public virtual GetWirelessGatewayTaskDefinitionResponse EndGetWirelessGatewayTaskDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWirelessGatewayTaskDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDestinations

        /// <summary>
        /// Lists the destinations registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDestinations service method.</param>
        /// 
        /// <returns>The response from the ListDestinations service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        public virtual ListDestinationsResponse ListDestinations(ListDestinationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDestinationsResponseUnmarshaller.Instance;

            return Invoke<ListDestinationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDestinations operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDestinations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        public virtual IAsyncResult BeginListDestinations(ListDestinationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDestinationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDestinations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDestinations.</param>
        /// 
        /// <returns>Returns a  ListDestinationsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        public virtual ListDestinationsResponse EndListDestinations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDestinationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDeviceProfiles

        /// <summary>
        /// Lists the device profiles registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceProfiles service method.</param>
        /// 
        /// <returns>The response from the ListDeviceProfiles service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDeviceProfiles">REST API Reference for ListDeviceProfiles Operation</seealso>
        public virtual ListDeviceProfilesResponse ListDeviceProfiles(ListDeviceProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeviceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceProfilesResponseUnmarshaller.Instance;

            return Invoke<ListDeviceProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeviceProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceProfiles operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeviceProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDeviceProfiles">REST API Reference for ListDeviceProfiles Operation</seealso>
        public virtual IAsyncResult BeginListDeviceProfiles(ListDeviceProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeviceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeviceProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeviceProfiles.</param>
        /// 
        /// <returns>Returns a  ListDeviceProfilesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDeviceProfiles">REST API Reference for ListDeviceProfiles Operation</seealso>
        public virtual ListDeviceProfilesResponse EndListDeviceProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDeviceProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPartnerAccounts

        /// <summary>
        /// Lists the partner accounts associated with your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerAccounts service method.</param>
        /// 
        /// <returns>The response from the ListPartnerAccounts service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListPartnerAccounts">REST API Reference for ListPartnerAccounts Operation</seealso>
        public virtual ListPartnerAccountsResponse ListPartnerAccounts(ListPartnerAccountsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartnerAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartnerAccountsResponseUnmarshaller.Instance;

            return Invoke<ListPartnerAccountsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPartnerAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerAccounts operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPartnerAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListPartnerAccounts">REST API Reference for ListPartnerAccounts Operation</seealso>
        public virtual IAsyncResult BeginListPartnerAccounts(ListPartnerAccountsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartnerAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartnerAccountsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPartnerAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPartnerAccounts.</param>
        /// 
        /// <returns>Returns a  ListPartnerAccountsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListPartnerAccounts">REST API Reference for ListPartnerAccounts Operation</seealso>
        public virtual ListPartnerAccountsResponse EndListPartnerAccounts(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPartnerAccountsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServiceProfiles

        /// <summary>
        /// Lists the service profiles registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceProfiles service method.</param>
        /// 
        /// <returns>The response from the ListServiceProfiles service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListServiceProfiles">REST API Reference for ListServiceProfiles Operation</seealso>
        public virtual ListServiceProfilesResponse ListServiceProfiles(ListServiceProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceProfilesResponseUnmarshaller.Instance;

            return Invoke<ListServiceProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceProfiles operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListServiceProfiles">REST API Reference for ListServiceProfiles Operation</seealso>
        public virtual IAsyncResult BeginListServiceProfiles(ListServiceProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceProfiles.</param>
        /// 
        /// <returns>Returns a  ListServiceProfilesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListServiceProfiles">REST API Reference for ListServiceProfiles Operation</seealso>
        public virtual ListServiceProfilesResponse EndListServiceProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServiceProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags (metadata) you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWirelessDevices

        /// <summary>
        /// Lists the wireless devices registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessDevices service method.</param>
        /// 
        /// <returns>The response from the ListWirelessDevices service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessDevices">REST API Reference for ListWirelessDevices Operation</seealso>
        public virtual ListWirelessDevicesResponse ListWirelessDevices(ListWirelessDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessDevicesResponseUnmarshaller.Instance;

            return Invoke<ListWirelessDevicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWirelessDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessDevices operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWirelessDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessDevices">REST API Reference for ListWirelessDevices Operation</seealso>
        public virtual IAsyncResult BeginListWirelessDevices(ListWirelessDevicesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessDevicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWirelessDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWirelessDevices.</param>
        /// 
        /// <returns>Returns a  ListWirelessDevicesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessDevices">REST API Reference for ListWirelessDevices Operation</seealso>
        public virtual ListWirelessDevicesResponse EndListWirelessDevices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWirelessDevicesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWirelessGateways

        /// <summary>
        /// Lists the wireless gateways registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessGateways service method.</param>
        /// 
        /// <returns>The response from the ListWirelessGateways service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGateways">REST API Reference for ListWirelessGateways Operation</seealso>
        public virtual ListWirelessGatewaysResponse ListWirelessGateways(ListWirelessGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessGatewaysResponseUnmarshaller.Instance;

            return Invoke<ListWirelessGatewaysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWirelessGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessGateways operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWirelessGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGateways">REST API Reference for ListWirelessGateways Operation</seealso>
        public virtual IAsyncResult BeginListWirelessGateways(ListWirelessGatewaysRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessGatewaysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWirelessGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWirelessGateways.</param>
        /// 
        /// <returns>Returns a  ListWirelessGatewaysResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGateways">REST API Reference for ListWirelessGateways Operation</seealso>
        public virtual ListWirelessGatewaysResponse EndListWirelessGateways(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWirelessGatewaysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWirelessGatewayTaskDefinitions

        /// <summary>
        /// List the wireless gateway tasks definitions registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessGatewayTaskDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListWirelessGatewayTaskDefinitions service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGatewayTaskDefinitions">REST API Reference for ListWirelessGatewayTaskDefinitions Operation</seealso>
        public virtual ListWirelessGatewayTaskDefinitionsResponse ListWirelessGatewayTaskDefinitions(ListWirelessGatewayTaskDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessGatewayTaskDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessGatewayTaskDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListWirelessGatewayTaskDefinitionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWirelessGatewayTaskDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessGatewayTaskDefinitions operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWirelessGatewayTaskDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGatewayTaskDefinitions">REST API Reference for ListWirelessGatewayTaskDefinitions Operation</seealso>
        public virtual IAsyncResult BeginListWirelessGatewayTaskDefinitions(ListWirelessGatewayTaskDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWirelessGatewayTaskDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWirelessGatewayTaskDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWirelessGatewayTaskDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWirelessGatewayTaskDefinitions.</param>
        /// 
        /// <returns>Returns a  ListWirelessGatewayTaskDefinitionsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGatewayTaskDefinitions">REST API Reference for ListWirelessGatewayTaskDefinitions Operation</seealso>
        public virtual ListWirelessGatewayTaskDefinitionsResponse EndListWirelessGatewayTaskDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWirelessGatewayTaskDefinitionsResponse>(asyncResult);
        }

        #endregion
        
        #region  SendDataToWirelessDevice

        /// <summary>
        /// Sends a decrypted application data frame to a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendDataToWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the SendDataToWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/SendDataToWirelessDevice">REST API Reference for SendDataToWirelessDevice Operation</seealso>
        public virtual SendDataToWirelessDeviceResponse SendDataToWirelessDevice(SendDataToWirelessDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendDataToWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendDataToWirelessDeviceResponseUnmarshaller.Instance;

            return Invoke<SendDataToWirelessDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendDataToWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendDataToWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendDataToWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/SendDataToWirelessDevice">REST API Reference for SendDataToWirelessDevice Operation</seealso>
        public virtual IAsyncResult BeginSendDataToWirelessDevice(SendDataToWirelessDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendDataToWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendDataToWirelessDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendDataToWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendDataToWirelessDevice.</param>
        /// 
        /// <returns>Returns a  SendDataToWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/SendDataToWirelessDevice">REST API Reference for SendDataToWirelessDevice Operation</seealso>
        public virtual SendDataToWirelessDeviceResponse EndSendDataToWirelessDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<SendDataToWirelessDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.TooManyTagsException">
        /// The request was denied because the resource can't have any more tags.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TestWirelessDevice

        /// <summary>
        /// Simulates a provisioned device by sending an uplink data payload of <code>Hello</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the TestWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TestWirelessDevice">REST API Reference for TestWirelessDevice Operation</seealso>
        public virtual TestWirelessDeviceResponse TestWirelessDevice(TestWirelessDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestWirelessDeviceResponseUnmarshaller.Instance;

            return Invoke<TestWirelessDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TestWirelessDevice">REST API Reference for TestWirelessDevice Operation</seealso>
        public virtual IAsyncResult BeginTestWirelessDevice(TestWirelessDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestWirelessDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestWirelessDevice.</param>
        /// 
        /// <returns>Returns a  TestWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TestWirelessDevice">REST API Reference for TestWirelessDevice Operation</seealso>
        public virtual TestWirelessDeviceResponse EndTestWirelessDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<TestWirelessDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDestination

        /// <summary>
        /// Updates properties of a destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        public virtual UpdateDestinationResponse UpdateDestination(UpdateDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        public virtual IAsyncResult BeginUpdateDestination(UpdateDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDestination.</param>
        /// 
        /// <returns>Returns a  UpdateDestinationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        public virtual UpdateDestinationResponse EndUpdateDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDestinationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePartnerAccount

        /// <summary>
        /// Updates properties of a partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartnerAccount service method.</param>
        /// 
        /// <returns>The response from the UpdatePartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdatePartnerAccount">REST API Reference for UpdatePartnerAccount Operation</seealso>
        public virtual UpdatePartnerAccountResponse UpdatePartnerAccount(UpdatePartnerAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePartnerAccountResponseUnmarshaller.Instance;

            return Invoke<UpdatePartnerAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartnerAccount operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePartnerAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdatePartnerAccount">REST API Reference for UpdatePartnerAccount Operation</seealso>
        public virtual IAsyncResult BeginUpdatePartnerAccount(UpdatePartnerAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePartnerAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePartnerAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePartnerAccount.</param>
        /// 
        /// <returns>Returns a  UpdatePartnerAccountResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdatePartnerAccount">REST API Reference for UpdatePartnerAccount Operation</seealso>
        public virtual UpdatePartnerAccountResponse EndUpdatePartnerAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePartnerAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWirelessDevice

        /// <summary>
        /// Updates properties of a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the UpdateWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessDevice">REST API Reference for UpdateWirelessDevice Operation</seealso>
        public virtual UpdateWirelessDeviceResponse UpdateWirelessDevice(UpdateWirelessDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWirelessDeviceResponseUnmarshaller.Instance;

            return Invoke<UpdateWirelessDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessDevice">REST API Reference for UpdateWirelessDevice Operation</seealso>
        public virtual IAsyncResult BeginUpdateWirelessDevice(UpdateWirelessDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWirelessDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWirelessDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWirelessDevice.</param>
        /// 
        /// <returns>Returns a  UpdateWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessDevice">REST API Reference for UpdateWirelessDevice Operation</seealso>
        public virtual UpdateWirelessDeviceResponse EndUpdateWirelessDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWirelessDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWirelessGateway

        /// <summary>
        /// Updates properties of a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessGateway service method.</param>
        /// 
        /// <returns>The response from the UpdateWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessGateway">REST API Reference for UpdateWirelessGateway Operation</seealso>
        public virtual UpdateWirelessGatewayResponse UpdateWirelessGateway(UpdateWirelessGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWirelessGatewayResponseUnmarshaller.Instance;

            return Invoke<UpdateWirelessGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessGateway operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWirelessGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessGateway">REST API Reference for UpdateWirelessGateway Operation</seealso>
        public virtual IAsyncResult BeginUpdateWirelessGateway(UpdateWirelessGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWirelessGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWirelessGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWirelessGateway.</param>
        /// 
        /// <returns>Returns a  UpdateWirelessGatewayResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessGateway">REST API Reference for UpdateWirelessGateway Operation</seealso>
        public virtual UpdateWirelessGatewayResponse EndUpdateWirelessGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWirelessGatewayResponse>(asyncResult);
        }

        #endregion
        
    }
}