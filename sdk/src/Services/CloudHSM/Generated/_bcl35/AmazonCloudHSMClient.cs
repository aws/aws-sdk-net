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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.CloudHSM.Model;
using Amazon.CloudHSM.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudHSM
{
    /// <summary>
    /// Implementation for accessing CloudHSM
    ///
    /// AWS CloudHSM Service 
    /// <para>
    /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
    /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
    /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
    /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
    /// CloudHSM Classic API Reference</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
    /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
    /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
    /// CloudHSM API Reference</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCloudHSMClient : AmazonServiceClient, IAmazonCloudHSM
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudHSMClient with the credentials loaded from the application's
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
        public AmazonCloudHSMClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudHSMConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with the credentials loaded from the application's
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
        public AmazonCloudHSMClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudHSMConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudHSMClient Configuration Object</param>
        public AmazonCloudHSMClient(AmazonCloudHSMConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudHSMClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudHSMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudHSMClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudHSMConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with AWS Credentials and an
        /// AmazonCloudHSMClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudHSMClient Configuration Object</param>
        public AmazonCloudHSMClient(AWSCredentials credentials, AmazonCloudHSMConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudHSMClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudHSMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudHSMClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudHSMConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudHSMClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudHSMClient Configuration Object</param>
        public AmazonCloudHSMClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudHSMConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudHSMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudHSMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudHSMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudHSMConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudHSMClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudHSMClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudHSMClient Configuration Object</param>
        public AmazonCloudHSMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudHSMConfig clientConfig)
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

        
        #region  AddTagsToResource

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Adds or overwrites one or more tags for the specified AWS CloudHSM resource.
        /// </para>
        ///  
        /// <para>
        /// Each tag consists of a key and a value. Tag keys must be unique to each resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var marshaller = AddTagsToResourceRequestMarshaller.Instance;
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTagsToResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual IAsyncResult BeginAddTagsToResource(AddTagsToResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AddTagsToResourceRequestMarshaller.Instance;
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return BeginInvoke<AddTagsToResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTagsToResource.</param>
        /// 
        /// <returns>Returns a  AddTagsToResourceResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual AddTagsToResourceResponse EndAddTagsToResource(IAsyncResult asyncResult)
        {
            return EndInvoke<AddTagsToResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateHapg

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Creates a high-availability partition group. A high-availability partition group is
        /// a group of partitions that spans multiple physical HSMs.
        /// </para>
        /// </summary>
        /// <param name="label">The label of the new high-availability partition group.</param>
        /// 
        /// <returns>The response from the CreateHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateHapg">REST API Reference for CreateHapg Operation</seealso>
        public virtual CreateHapgResponse CreateHapg(string label)
        {
            var request = new CreateHapgRequest();
            request.Label = label;
            return CreateHapg(request);
        }


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Creates a high-availability partition group. A high-availability partition group is
        /// a group of partitions that spans multiple physical HSMs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHapg service method.</param>
        /// 
        /// <returns>The response from the CreateHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateHapg">REST API Reference for CreateHapg Operation</seealso>
        public virtual CreateHapgResponse CreateHapg(CreateHapgRequest request)
        {
            var marshaller = CreateHapgRequestMarshaller.Instance;
            var unmarshaller = CreateHapgResponseUnmarshaller.Instance;

            return Invoke<CreateHapgRequest,CreateHapgResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHapg operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHapg
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateHapg">REST API Reference for CreateHapg Operation</seealso>
        public virtual IAsyncResult BeginCreateHapg(CreateHapgRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateHapgRequestMarshaller.Instance;
            var unmarshaller = CreateHapgResponseUnmarshaller.Instance;

            return BeginInvoke<CreateHapgRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHapg operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHapg.</param>
        /// 
        /// <returns>Returns a  CreateHapgResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateHapg">REST API Reference for CreateHapg Operation</seealso>
        public virtual CreateHapgResponse EndCreateHapg(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateHapgResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateHsm

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Creates an uninitialized HSM instance.
        /// </para>
        ///  
        /// <para>
        /// There is an upfront fee charged for each HSM instance that you create with the <code>CreateHsm</code>
        /// operation. If you accidentally provision an HSM and want to request a refund, delete
        /// the instance using the <a>DeleteHsm</a> operation, go to the <a href="https://console.aws.amazon.com/support/home">AWS
        /// Support Center</a>, create a new case, and select <b>Account and Billing Support</b>.
        /// </para>
        ///  <important> 
        /// <para>
        /// It can take up to 20 minutes to create and provision an HSM. You can monitor the status
        /// of the HSM with the <a>DescribeHsm</a> operation. The HSM is ready to be initialized
        /// when the status changes to <code>RUNNING</code>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsm service method.</param>
        /// 
        /// <returns>The response from the CreateHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateHsm">REST API Reference for CreateHsm Operation</seealso>
        public virtual CreateHsmResponse CreateHsm(CreateHsmRequest request)
        {
            var marshaller = CreateHsmRequestMarshaller.Instance;
            var unmarshaller = CreateHsmResponseUnmarshaller.Instance;

            return Invoke<CreateHsmRequest,CreateHsmResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsm operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHsm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateHsm">REST API Reference for CreateHsm Operation</seealso>
        public virtual IAsyncResult BeginCreateHsm(CreateHsmRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateHsmRequestMarshaller.Instance;
            var unmarshaller = CreateHsmResponseUnmarshaller.Instance;

            return BeginInvoke<CreateHsmRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHsm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHsm.</param>
        /// 
        /// <returns>Returns a  CreateHsmResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateHsm">REST API Reference for CreateHsm Operation</seealso>
        public virtual CreateHsmResponse EndCreateHsm(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateHsmResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLunaClient

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Creates an HSM client.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLunaClient service method.</param>
        /// 
        /// <returns>The response from the CreateLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateLunaClient">REST API Reference for CreateLunaClient Operation</seealso>
        public virtual CreateLunaClientResponse CreateLunaClient(CreateLunaClientRequest request)
        {
            var marshaller = CreateLunaClientRequestMarshaller.Instance;
            var unmarshaller = CreateLunaClientResponseUnmarshaller.Instance;

            return Invoke<CreateLunaClientRequest,CreateLunaClientResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLunaClient operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLunaClient
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateLunaClient">REST API Reference for CreateLunaClient Operation</seealso>
        public virtual IAsyncResult BeginCreateLunaClient(CreateLunaClientRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateLunaClientRequestMarshaller.Instance;
            var unmarshaller = CreateLunaClientResponseUnmarshaller.Instance;

            return BeginInvoke<CreateLunaClientRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLunaClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLunaClient.</param>
        /// 
        /// <returns>Returns a  CreateLunaClientResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateLunaClient">REST API Reference for CreateLunaClient Operation</seealso>
        public virtual CreateLunaClientResponse EndCreateLunaClient(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLunaClientResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteHapg

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Deletes a high-availability partition group.
        /// </para>
        /// </summary>
        /// <param name="hapgArn">The ARN of the high-availability partition group to delete.</param>
        /// 
        /// <returns>The response from the DeleteHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteHapg">REST API Reference for DeleteHapg Operation</seealso>
        public virtual DeleteHapgResponse DeleteHapg(string hapgArn)
        {
            var request = new DeleteHapgRequest();
            request.HapgArn = hapgArn;
            return DeleteHapg(request);
        }


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Deletes a high-availability partition group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHapg service method.</param>
        /// 
        /// <returns>The response from the DeleteHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteHapg">REST API Reference for DeleteHapg Operation</seealso>
        public virtual DeleteHapgResponse DeleteHapg(DeleteHapgRequest request)
        {
            var marshaller = DeleteHapgRequestMarshaller.Instance;
            var unmarshaller = DeleteHapgResponseUnmarshaller.Instance;

            return Invoke<DeleteHapgRequest,DeleteHapgResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHapg operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHapg
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteHapg">REST API Reference for DeleteHapg Operation</seealso>
        public virtual IAsyncResult BeginDeleteHapg(DeleteHapgRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteHapgRequestMarshaller.Instance;
            var unmarshaller = DeleteHapgResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteHapgRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHapg operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHapg.</param>
        /// 
        /// <returns>Returns a  DeleteHapgResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteHapg">REST API Reference for DeleteHapg Operation</seealso>
        public virtual DeleteHapgResponse EndDeleteHapg(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteHapgResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteHsm

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Deletes an HSM. After completion, this operation cannot be undone and your key material
        /// cannot be recovered.
        /// </para>
        /// </summary>
        /// <param name="hsmArn">The ARN of the HSM to delete.</param>
        /// 
        /// <returns>The response from the DeleteHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteHsm">REST API Reference for DeleteHsm Operation</seealso>
        public virtual DeleteHsmResponse DeleteHsm(string hsmArn)
        {
            var request = new DeleteHsmRequest();
            request.HsmArn = hsmArn;
            return DeleteHsm(request);
        }


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Deletes an HSM. After completion, this operation cannot be undone and your key material
        /// cannot be recovered.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsm service method.</param>
        /// 
        /// <returns>The response from the DeleteHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteHsm">REST API Reference for DeleteHsm Operation</seealso>
        public virtual DeleteHsmResponse DeleteHsm(DeleteHsmRequest request)
        {
            var marshaller = DeleteHsmRequestMarshaller.Instance;
            var unmarshaller = DeleteHsmResponseUnmarshaller.Instance;

            return Invoke<DeleteHsmRequest,DeleteHsmResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsm operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHsm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteHsm">REST API Reference for DeleteHsm Operation</seealso>
        public virtual IAsyncResult BeginDeleteHsm(DeleteHsmRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteHsmRequestMarshaller.Instance;
            var unmarshaller = DeleteHsmResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteHsmRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHsm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHsm.</param>
        /// 
        /// <returns>Returns a  DeleteHsmResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteHsm">REST API Reference for DeleteHsm Operation</seealso>
        public virtual DeleteHsmResponse EndDeleteHsm(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteHsmResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLunaClient

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Deletes a client.
        /// </para>
        /// </summary>
        /// <param name="clientArn">The ARN of the client to delete.</param>
        /// 
        /// <returns>The response from the DeleteLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteLunaClient">REST API Reference for DeleteLunaClient Operation</seealso>
        public virtual DeleteLunaClientResponse DeleteLunaClient(string clientArn)
        {
            var request = new DeleteLunaClientRequest();
            request.ClientArn = clientArn;
            return DeleteLunaClient(request);
        }


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Deletes a client.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLunaClient service method.</param>
        /// 
        /// <returns>The response from the DeleteLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteLunaClient">REST API Reference for DeleteLunaClient Operation</seealso>
        public virtual DeleteLunaClientResponse DeleteLunaClient(DeleteLunaClientRequest request)
        {
            var marshaller = DeleteLunaClientRequestMarshaller.Instance;
            var unmarshaller = DeleteLunaClientResponseUnmarshaller.Instance;

            return Invoke<DeleteLunaClientRequest,DeleteLunaClientResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLunaClient operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLunaClient
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteLunaClient">REST API Reference for DeleteLunaClient Operation</seealso>
        public virtual IAsyncResult BeginDeleteLunaClient(DeleteLunaClientRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteLunaClientRequestMarshaller.Instance;
            var unmarshaller = DeleteLunaClientResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteLunaClientRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLunaClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLunaClient.</param>
        /// 
        /// <returns>Returns a  DeleteLunaClientResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteLunaClient">REST API Reference for DeleteLunaClient Operation</seealso>
        public virtual DeleteLunaClientResponse EndDeleteLunaClient(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLunaClientResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeHapg

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Retrieves information about a high-availability partition group.
        /// </para>
        /// </summary>
        /// <param name="hapgArn">The ARN of the high-availability partition group to describe.</param>
        /// 
        /// <returns>The response from the DescribeHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeHapg">REST API Reference for DescribeHapg Operation</seealso>
        public virtual DescribeHapgResponse DescribeHapg(string hapgArn)
        {
            var request = new DescribeHapgRequest();
            request.HapgArn = hapgArn;
            return DescribeHapg(request);
        }


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Retrieves information about a high-availability partition group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHapg service method.</param>
        /// 
        /// <returns>The response from the DescribeHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeHapg">REST API Reference for DescribeHapg Operation</seealso>
        public virtual DescribeHapgResponse DescribeHapg(DescribeHapgRequest request)
        {
            var marshaller = DescribeHapgRequestMarshaller.Instance;
            var unmarshaller = DescribeHapgResponseUnmarshaller.Instance;

            return Invoke<DescribeHapgRequest,DescribeHapgResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHapg operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHapg
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeHapg">REST API Reference for DescribeHapg Operation</seealso>
        public virtual IAsyncResult BeginDescribeHapg(DescribeHapgRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeHapgRequestMarshaller.Instance;
            var unmarshaller = DescribeHapgResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeHapgRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHapg operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHapg.</param>
        /// 
        /// <returns>Returns a  DescribeHapgResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeHapg">REST API Reference for DescribeHapg Operation</seealso>
        public virtual DescribeHapgResponse EndDescribeHapg(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeHapgResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeHsm

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Retrieves information about an HSM. You can identify the HSM by its ARN or its serial
        /// number.
        /// </para>
        /// </summary>
        /// <param name="hsmArn">The ARN of the HSM. Either the <code>HsmArn</code> or the <code>SerialNumber</code> parameter must be specified.</param>
        /// 
        /// <returns>The response from the DescribeHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeHsm">REST API Reference for DescribeHsm Operation</seealso>
        public virtual DescribeHsmResponse DescribeHsm(string hsmArn)
        {
            var request = new DescribeHsmRequest();
            request.HsmArn = hsmArn;
            return DescribeHsm(request);
        }


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Retrieves information about an HSM. You can identify the HSM by its ARN or its serial
        /// number.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsm service method.</param>
        /// 
        /// <returns>The response from the DescribeHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeHsm">REST API Reference for DescribeHsm Operation</seealso>
        public virtual DescribeHsmResponse DescribeHsm(DescribeHsmRequest request)
        {
            var marshaller = DescribeHsmRequestMarshaller.Instance;
            var unmarshaller = DescribeHsmResponseUnmarshaller.Instance;

            return Invoke<DescribeHsmRequest,DescribeHsmResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsm operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHsm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeHsm">REST API Reference for DescribeHsm Operation</seealso>
        public virtual IAsyncResult BeginDescribeHsm(DescribeHsmRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeHsmRequestMarshaller.Instance;
            var unmarshaller = DescribeHsmResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeHsmRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHsm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHsm.</param>
        /// 
        /// <returns>Returns a  DescribeHsmResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeHsm">REST API Reference for DescribeHsm Operation</seealso>
        public virtual DescribeHsmResponse EndDescribeHsm(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeHsmResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLunaClient

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Retrieves information about an HSM client.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLunaClient service method.</param>
        /// 
        /// <returns>The response from the DescribeLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeLunaClient">REST API Reference for DescribeLunaClient Operation</seealso>
        public virtual DescribeLunaClientResponse DescribeLunaClient(DescribeLunaClientRequest request)
        {
            var marshaller = DescribeLunaClientRequestMarshaller.Instance;
            var unmarshaller = DescribeLunaClientResponseUnmarshaller.Instance;

            return Invoke<DescribeLunaClientRequest,DescribeLunaClientResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLunaClient operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLunaClient
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeLunaClient">REST API Reference for DescribeLunaClient Operation</seealso>
        public virtual IAsyncResult BeginDescribeLunaClient(DescribeLunaClientRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeLunaClientRequestMarshaller.Instance;
            var unmarshaller = DescribeLunaClientResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeLunaClientRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLunaClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLunaClient.</param>
        /// 
        /// <returns>Returns a  DescribeLunaClientResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeLunaClient">REST API Reference for DescribeLunaClient Operation</seealso>
        public virtual DescribeLunaClientResponse EndDescribeLunaClient(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLunaClientResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConfig

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Gets the configuration files necessary to connect to all high availability partition
        /// groups the client is associated with.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfig service method.</param>
        /// 
        /// <returns>The response from the GetConfig service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/GetConfig">REST API Reference for GetConfig Operation</seealso>
        public virtual GetConfigResponse GetConfig(GetConfigRequest request)
        {
            var marshaller = GetConfigRequestMarshaller.Instance;
            var unmarshaller = GetConfigResponseUnmarshaller.Instance;

            return Invoke<GetConfigRequest,GetConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfig operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/GetConfig">REST API Reference for GetConfig Operation</seealso>
        public virtual IAsyncResult BeginGetConfig(GetConfigRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetConfigRequestMarshaller.Instance;
            var unmarshaller = GetConfigResponseUnmarshaller.Instance;

            return BeginInvoke<GetConfigRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfig.</param>
        /// 
        /// <returns>Returns a  GetConfigResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/GetConfig">REST API Reference for GetConfig Operation</seealso>
        public virtual GetConfigResponse EndGetConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAvailableZones

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Lists the Availability Zones that have available AWS CloudHSM capacity.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListAvailableZones service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListAvailableZones">REST API Reference for ListAvailableZones Operation</seealso>
        public virtual ListAvailableZonesResponse ListAvailableZones()
        {
            var request = new ListAvailableZonesRequest();
            return ListAvailableZones(request);
        }


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Lists the Availability Zones that have available AWS CloudHSM capacity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableZones service method.</param>
        /// 
        /// <returns>The response from the ListAvailableZones service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListAvailableZones">REST API Reference for ListAvailableZones Operation</seealso>
        public virtual ListAvailableZonesResponse ListAvailableZones(ListAvailableZonesRequest request)
        {
            var marshaller = ListAvailableZonesRequestMarshaller.Instance;
            var unmarshaller = ListAvailableZonesResponseUnmarshaller.Instance;

            return Invoke<ListAvailableZonesRequest,ListAvailableZonesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableZones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableZones operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAvailableZones
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListAvailableZones">REST API Reference for ListAvailableZones Operation</seealso>
        public virtual IAsyncResult BeginListAvailableZones(ListAvailableZonesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListAvailableZonesRequestMarshaller.Instance;
            var unmarshaller = ListAvailableZonesResponseUnmarshaller.Instance;

            return BeginInvoke<ListAvailableZonesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAvailableZones operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableZones.</param>
        /// 
        /// <returns>Returns a  ListAvailableZonesResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListAvailableZones">REST API Reference for ListAvailableZones Operation</seealso>
        public virtual ListAvailableZonesResponse EndListAvailableZones(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAvailableZonesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListHapgs

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Lists the high-availability partition groups for the account.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> member.
        /// If more results are available, the <code>NextToken</code> member of the response contains
        /// a token that you pass in the next call to <code>ListHapgs</code> to retrieve the next
        /// set of items.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListHapgs service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListHapgs">REST API Reference for ListHapgs Operation</seealso>
        public virtual ListHapgsResponse ListHapgs()
        {
            var request = new ListHapgsRequest();
            return ListHapgs(request);
        }


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Lists the high-availability partition groups for the account.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> member.
        /// If more results are available, the <code>NextToken</code> member of the response contains
        /// a token that you pass in the next call to <code>ListHapgs</code> to retrieve the next
        /// set of items.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHapgs service method.</param>
        /// 
        /// <returns>The response from the ListHapgs service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListHapgs">REST API Reference for ListHapgs Operation</seealso>
        public virtual ListHapgsResponse ListHapgs(ListHapgsRequest request)
        {
            var marshaller = ListHapgsRequestMarshaller.Instance;
            var unmarshaller = ListHapgsResponseUnmarshaller.Instance;

            return Invoke<ListHapgsRequest,ListHapgsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListHapgs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHapgs operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHapgs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListHapgs">REST API Reference for ListHapgs Operation</seealso>
        public virtual IAsyncResult BeginListHapgs(ListHapgsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListHapgsRequestMarshaller.Instance;
            var unmarshaller = ListHapgsResponseUnmarshaller.Instance;

            return BeginInvoke<ListHapgsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListHapgs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHapgs.</param>
        /// 
        /// <returns>Returns a  ListHapgsResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListHapgs">REST API Reference for ListHapgs Operation</seealso>
        public virtual ListHapgsResponse EndListHapgs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListHapgsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListHsms

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Retrieves the identifiers of all of the HSMs provisioned for the current customer.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> member.
        /// If more results are available, the <code>NextToken</code> member of the response contains
        /// a token that you pass in the next call to <code>ListHsms</code> to retrieve the next
        /// set of items.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListHsms service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListHsms">REST API Reference for ListHsms Operation</seealso>
        public virtual ListHsmsResponse ListHsms()
        {
            var request = new ListHsmsRequest();
            return ListHsms(request);
        }


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Retrieves the identifiers of all of the HSMs provisioned for the current customer.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> member.
        /// If more results are available, the <code>NextToken</code> member of the response contains
        /// a token that you pass in the next call to <code>ListHsms</code> to retrieve the next
        /// set of items.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHsms service method.</param>
        /// 
        /// <returns>The response from the ListHsms service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListHsms">REST API Reference for ListHsms Operation</seealso>
        public virtual ListHsmsResponse ListHsms(ListHsmsRequest request)
        {
            var marshaller = ListHsmsRequestMarshaller.Instance;
            var unmarshaller = ListHsmsResponseUnmarshaller.Instance;

            return Invoke<ListHsmsRequest,ListHsmsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListHsms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHsms operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHsms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListHsms">REST API Reference for ListHsms Operation</seealso>
        public virtual IAsyncResult BeginListHsms(ListHsmsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListHsmsRequestMarshaller.Instance;
            var unmarshaller = ListHsmsResponseUnmarshaller.Instance;

            return BeginInvoke<ListHsmsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListHsms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHsms.</param>
        /// 
        /// <returns>Returns a  ListHsmsResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListHsms">REST API Reference for ListHsms Operation</seealso>
        public virtual ListHsmsResponse EndListHsms(IAsyncResult asyncResult)
        {
            return EndInvoke<ListHsmsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLunaClients

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Lists all of the clients.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> member.
        /// If more results are available, the <code>NextToken</code> member of the response contains
        /// a token that you pass in the next call to <code>ListLunaClients</code> to retrieve
        /// the next set of items.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListLunaClients service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListLunaClients">REST API Reference for ListLunaClients Operation</seealso>
        public virtual ListLunaClientsResponse ListLunaClients()
        {
            var request = new ListLunaClientsRequest();
            return ListLunaClients(request);
        }


        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Lists all of the clients.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> member.
        /// If more results are available, the <code>NextToken</code> member of the response contains
        /// a token that you pass in the next call to <code>ListLunaClients</code> to retrieve
        /// the next set of items.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLunaClients service method.</param>
        /// 
        /// <returns>The response from the ListLunaClients service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListLunaClients">REST API Reference for ListLunaClients Operation</seealso>
        public virtual ListLunaClientsResponse ListLunaClients(ListLunaClientsRequest request)
        {
            var marshaller = ListLunaClientsRequestMarshaller.Instance;
            var unmarshaller = ListLunaClientsResponseUnmarshaller.Instance;

            return Invoke<ListLunaClientsRequest,ListLunaClientsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLunaClients operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLunaClients operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLunaClients
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListLunaClients">REST API Reference for ListLunaClients Operation</seealso>
        public virtual IAsyncResult BeginListLunaClients(ListLunaClientsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListLunaClientsRequestMarshaller.Instance;
            var unmarshaller = ListLunaClientsResponseUnmarshaller.Instance;

            return BeginInvoke<ListLunaClientsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLunaClients operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLunaClients.</param>
        /// 
        /// <returns>Returns a  ListLunaClientsResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListLunaClients">REST API Reference for ListLunaClients Operation</seealso>
        public virtual ListLunaClientsResponse EndListLunaClients(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLunaClientsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Returns a list of all tags for the specified AWS CloudHSM resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke<ListTagsForResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyHapg

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Modifies an existing high-availability partition group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyHapg service method.</param>
        /// 
        /// <returns>The response from the ModifyHapg service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ModifyHapg">REST API Reference for ModifyHapg Operation</seealso>
        public virtual ModifyHapgResponse ModifyHapg(ModifyHapgRequest request)
        {
            var marshaller = ModifyHapgRequestMarshaller.Instance;
            var unmarshaller = ModifyHapgResponseUnmarshaller.Instance;

            return Invoke<ModifyHapgRequest,ModifyHapgResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyHapg operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyHapg
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ModifyHapg">REST API Reference for ModifyHapg Operation</seealso>
        public virtual IAsyncResult BeginModifyHapg(ModifyHapgRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ModifyHapgRequestMarshaller.Instance;
            var unmarshaller = ModifyHapgResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyHapgRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyHapg operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyHapg.</param>
        /// 
        /// <returns>Returns a  ModifyHapgResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ModifyHapg">REST API Reference for ModifyHapg Operation</seealso>
        public virtual ModifyHapgResponse EndModifyHapg(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyHapgResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyHsm

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Modifies an HSM.
        /// </para>
        ///  <important> 
        /// <para>
        /// This operation can result in the HSM being offline for up to 15 minutes while the
        /// AWS CloudHSM service is reconfigured. If you are modifying a production HSM, you should
        /// ensure that your AWS CloudHSM service is configured for high availability, and consider
        /// executing this operation during a maintenance window.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyHsm service method.</param>
        /// 
        /// <returns>The response from the ModifyHsm service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ModifyHsm">REST API Reference for ModifyHsm Operation</seealso>
        public virtual ModifyHsmResponse ModifyHsm(ModifyHsmRequest request)
        {
            var marshaller = ModifyHsmRequestMarshaller.Instance;
            var unmarshaller = ModifyHsmResponseUnmarshaller.Instance;

            return Invoke<ModifyHsmRequest,ModifyHsmResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyHsm operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyHsm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ModifyHsm">REST API Reference for ModifyHsm Operation</seealso>
        public virtual IAsyncResult BeginModifyHsm(ModifyHsmRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ModifyHsmRequestMarshaller.Instance;
            var unmarshaller = ModifyHsmResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyHsmRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyHsm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyHsm.</param>
        /// 
        /// <returns>Returns a  ModifyHsmResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ModifyHsm">REST API Reference for ModifyHsm Operation</seealso>
        public virtual ModifyHsmResponse EndModifyHsm(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyHsmResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyLunaClient

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Modifies the certificate used by the client.
        /// </para>
        ///  
        /// <para>
        /// This action can potentially start a workflow to install the new certificate on the
        /// client's HSMs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyLunaClient service method.</param>
        /// 
        /// <returns>The response from the ModifyLunaClient service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ModifyLunaClient">REST API Reference for ModifyLunaClient Operation</seealso>
        public virtual ModifyLunaClientResponse ModifyLunaClient(ModifyLunaClientRequest request)
        {
            var marshaller = ModifyLunaClientRequestMarshaller.Instance;
            var unmarshaller = ModifyLunaClientResponseUnmarshaller.Instance;

            return Invoke<ModifyLunaClientRequest,ModifyLunaClientResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyLunaClient operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyLunaClient
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ModifyLunaClient">REST API Reference for ModifyLunaClient Operation</seealso>
        public virtual IAsyncResult BeginModifyLunaClient(ModifyLunaClientRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ModifyLunaClientRequestMarshaller.Instance;
            var unmarshaller = ModifyLunaClientResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyLunaClientRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyLunaClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyLunaClient.</param>
        /// 
        /// <returns>Returns a  ModifyLunaClientResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ModifyLunaClient">REST API Reference for ModifyLunaClient Operation</seealso>
        public virtual ModifyLunaClientResponse EndModifyLunaClient(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyLunaClientResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        /// <summary>
        /// This is documentation for <b>AWS CloudHSM Classic</b>. For more information, see <a
        /// href="http://aws.amazon.com/cloudhsm/faqs-classic/">AWS CloudHSM Classic FAQs</a>,
        /// the <a href="http://docs.aws.amazon.com/cloudhsm/classic/userguide/">AWS CloudHSM
        /// Classic User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/classic/APIReference/">AWS
        /// CloudHSM Classic API Reference</a>.
        /// 
        ///  
        /// <para>
        ///  <b>For information about the current version of AWS CloudHSM</b>, see <a href="http://aws.amazon.com/cloudhsm/">AWS
        /// CloudHSM</a>, the <a href="http://docs.aws.amazon.com/cloudhsm/latest/userguide/">AWS
        /// CloudHSM User Guide</a>, and the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/">AWS
        /// CloudHSM API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// Removes one or more tags from the specified AWS CloudHSM resource.
        /// </para>
        ///  
        /// <para>
        /// To remove a tag, specify only the tag key to remove (not the value). To overwrite
        /// the value for an existing tag, use <a>AddTagsToResource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by CloudHSM.</returns>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmInternalException">
        /// Indicates that an internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.CloudHsmServiceException">
        /// Indicates that an exception occurred in the AWS CloudHSM service.
        /// </exception>
        /// <exception cref="Amazon.CloudHSM.Model.InvalidRequestException">
        /// Indicates that one or more of the request parameters are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var marshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation on AmazonCloudHSMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTagsFromResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual IAsyncResult BeginRemoveTagsFromResource(RemoveTagsFromResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveTagsFromResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTagsFromResource.</param>
        /// 
        /// <returns>Returns a  RemoveTagsFromResourceResult from CloudHSM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual RemoveTagsFromResourceResponse EndRemoveTagsFromResource(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveTagsFromResourceResponse>(asyncResult);
        }

        #endregion
        
    }
}