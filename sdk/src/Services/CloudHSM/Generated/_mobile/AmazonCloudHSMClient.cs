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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CloudHSM.Model;
using Amazon.CloudHSM.Model.Internal.MarshallTransformations;
using Amazon.CloudHSM.Internal;
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
        private static IServiceMetadata serviceMetadata = new AmazonCloudHSMMetadata();
        
        #region Constructors

#if CORECLR
    
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

#endif

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


        #region  AddTagsToResource

        internal virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateHapg

        internal virtual CreateHapgResponse CreateHapg(CreateHapgRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHapgRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHapgResponseUnmarshaller.Instance;

            return Invoke<CreateHapgResponse>(request, options);
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
        /// <param name="label">The label of the new high-availability partition group.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateHapgResponse> CreateHapgAsync(string label, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateHapgRequest();
            request.Label = label;
            return CreateHapgAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHapg operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateHapg">REST API Reference for CreateHapg Operation</seealso>
        public virtual Task<CreateHapgResponse> CreateHapgAsync(CreateHapgRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHapgRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHapgResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHapgResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateHsm

        internal virtual CreateHsmResponse CreateHsm(CreateHsmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHsmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHsmResponseUnmarshaller.Instance;

            return Invoke<CreateHsmResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsm operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateHsm">REST API Reference for CreateHsm Operation</seealso>
        public virtual Task<CreateHsmResponse> CreateHsmAsync(CreateHsmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateHsmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateHsmResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHsmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLunaClient

        internal virtual CreateLunaClientResponse CreateLunaClient(CreateLunaClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLunaClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLunaClientResponseUnmarshaller.Instance;

            return Invoke<CreateLunaClientResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLunaClient operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/CreateLunaClient">REST API Reference for CreateLunaClient Operation</seealso>
        public virtual Task<CreateLunaClientResponse> CreateLunaClientAsync(CreateLunaClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLunaClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLunaClientResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLunaClientResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteHapg

        internal virtual DeleteHapgResponse DeleteHapg(DeleteHapgRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHapgRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHapgResponseUnmarshaller.Instance;

            return Invoke<DeleteHapgResponse>(request, options);
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
        /// <param name="hapgArn">The ARN of the high-availability partition group to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteHapgResponse> DeleteHapgAsync(string hapgArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteHapgRequest();
            request.HapgArn = hapgArn;
            return DeleteHapgAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHapg operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteHapg">REST API Reference for DeleteHapg Operation</seealso>
        public virtual Task<DeleteHapgResponse> DeleteHapgAsync(DeleteHapgRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHapgRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHapgResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHapgResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteHsm

        internal virtual DeleteHsmResponse DeleteHsm(DeleteHsmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHsmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHsmResponseUnmarshaller.Instance;

            return Invoke<DeleteHsmResponse>(request, options);
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
        /// <param name="hsmArn">The ARN of the HSM to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteHsmResponse> DeleteHsmAsync(string hsmArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteHsmRequest();
            request.HsmArn = hsmArn;
            return DeleteHsmAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsm operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteHsm">REST API Reference for DeleteHsm Operation</seealso>
        public virtual Task<DeleteHsmResponse> DeleteHsmAsync(DeleteHsmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHsmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHsmResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHsmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLunaClient

        internal virtual DeleteLunaClientResponse DeleteLunaClient(DeleteLunaClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLunaClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLunaClientResponseUnmarshaller.Instance;

            return Invoke<DeleteLunaClientResponse>(request, options);
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
        /// <param name="clientArn">The ARN of the client to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteLunaClientResponse> DeleteLunaClientAsync(string clientArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteLunaClientRequest();
            request.ClientArn = clientArn;
            return DeleteLunaClientAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLunaClient operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DeleteLunaClient">REST API Reference for DeleteLunaClient Operation</seealso>
        public virtual Task<DeleteLunaClientResponse> DeleteLunaClientAsync(DeleteLunaClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLunaClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLunaClientResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLunaClientResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHapg

        internal virtual DescribeHapgResponse DescribeHapg(DescribeHapgRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHapgRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHapgResponseUnmarshaller.Instance;

            return Invoke<DescribeHapgResponse>(request, options);
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
        /// <param name="hapgArn">The ARN of the high-availability partition group to describe.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeHapgResponse> DescribeHapgAsync(string hapgArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeHapgRequest();
            request.HapgArn = hapgArn;
            return DescribeHapgAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHapg operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeHapg">REST API Reference for DescribeHapg Operation</seealso>
        public virtual Task<DescribeHapgResponse> DescribeHapgAsync(DescribeHapgRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHapgRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHapgResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHapgResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHsm

        internal virtual DescribeHsmResponse DescribeHsm(DescribeHsmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHsmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHsmResponseUnmarshaller.Instance;

            return Invoke<DescribeHsmResponse>(request, options);
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
        /// <param name="hsmArn">The ARN of the HSM. Either the <code>HsmArn</code> or the <code>SerialNumber</code> parameter must be specified.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeHsmResponse> DescribeHsmAsync(string hsmArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeHsmRequest();
            request.HsmArn = hsmArn;
            return DescribeHsmAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsm operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeHsm">REST API Reference for DescribeHsm Operation</seealso>
        public virtual Task<DescribeHsmResponse> DescribeHsmAsync(DescribeHsmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHsmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHsmResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHsmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLunaClient

        internal virtual DescribeLunaClientResponse DescribeLunaClient(DescribeLunaClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLunaClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLunaClientResponseUnmarshaller.Instance;

            return Invoke<DescribeLunaClientResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLunaClient operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/DescribeLunaClient">REST API Reference for DescribeLunaClient Operation</seealso>
        public virtual Task<DescribeLunaClientResponse> DescribeLunaClientAsync(DescribeLunaClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLunaClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLunaClientResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLunaClientResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConfig

        internal virtual GetConfigResponse GetConfig(GetConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigResponseUnmarshaller.Instance;

            return Invoke<GetConfigResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfig operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/GetConfig">REST API Reference for GetConfig Operation</seealso>
        public virtual Task<GetConfigResponse> GetConfigAsync(GetConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAvailableZones

        internal virtual ListAvailableZonesResponse ListAvailableZones(ListAvailableZonesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAvailableZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableZonesResponseUnmarshaller.Instance;

            return Invoke<ListAvailableZonesResponse>(request, options);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListAvailableZonesResponse> ListAvailableZonesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListAvailableZonesRequest();
            return ListAvailableZonesAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableZones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableZones operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListAvailableZones">REST API Reference for ListAvailableZones Operation</seealso>
        public virtual Task<ListAvailableZonesResponse> ListAvailableZonesAsync(ListAvailableZonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAvailableZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableZonesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAvailableZonesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHapgs

        internal virtual ListHapgsResponse ListHapgs(ListHapgsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHapgsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHapgsResponseUnmarshaller.Instance;

            return Invoke<ListHapgsResponse>(request, options);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListHapgsResponse> ListHapgsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListHapgsRequest();
            return ListHapgsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListHapgs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHapgs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListHapgs">REST API Reference for ListHapgs Operation</seealso>
        public virtual Task<ListHapgsResponse> ListHapgsAsync(ListHapgsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHapgsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHapgsResponseUnmarshaller.Instance;

            return InvokeAsync<ListHapgsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHsms

        internal virtual ListHsmsResponse ListHsms(ListHsmsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHsmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHsmsResponseUnmarshaller.Instance;

            return Invoke<ListHsmsResponse>(request, options);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListHsmsResponse> ListHsmsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListHsmsRequest();
            return ListHsmsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListHsms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHsms operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListHsms">REST API Reference for ListHsms Operation</seealso>
        public virtual Task<ListHsmsResponse> ListHsmsAsync(ListHsmsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHsmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHsmsResponseUnmarshaller.Instance;

            return InvokeAsync<ListHsmsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLunaClients

        internal virtual ListLunaClientsResponse ListLunaClients(ListLunaClientsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLunaClientsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLunaClientsResponseUnmarshaller.Instance;

            return Invoke<ListLunaClientsResponse>(request, options);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListLunaClientsResponse> ListLunaClientsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListLunaClientsRequest();
            return ListLunaClientsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListLunaClients operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLunaClients operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListLunaClients">REST API Reference for ListLunaClients Operation</seealso>
        public virtual Task<ListLunaClientsResponse> ListLunaClientsAsync(ListLunaClientsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLunaClientsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLunaClientsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLunaClientsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyHapg

        internal virtual ModifyHapgResponse ModifyHapg(ModifyHapgRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyHapgRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyHapgResponseUnmarshaller.Instance;

            return Invoke<ModifyHapgResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyHapg operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyHapg operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ModifyHapg">REST API Reference for ModifyHapg Operation</seealso>
        public virtual Task<ModifyHapgResponse> ModifyHapgAsync(ModifyHapgRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyHapgRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyHapgResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyHapgResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyHsm

        internal virtual ModifyHsmResponse ModifyHsm(ModifyHsmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyHsmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyHsmResponseUnmarshaller.Instance;

            return Invoke<ModifyHsmResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyHsm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyHsm operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ModifyHsm">REST API Reference for ModifyHsm Operation</seealso>
        public virtual Task<ModifyHsmResponse> ModifyHsmAsync(ModifyHsmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyHsmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyHsmResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyHsmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyLunaClient

        internal virtual ModifyLunaClientResponse ModifyLunaClient(ModifyLunaClientRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyLunaClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyLunaClientResponseUnmarshaller.Instance;

            return Invoke<ModifyLunaClientResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyLunaClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyLunaClient operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/ModifyLunaClient">REST API Reference for ModifyLunaClient Operation</seealso>
        public virtual Task<ModifyLunaClientResponse> ModifyLunaClientAsync(ModifyLunaClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyLunaClientRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyLunaClientResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyLunaClientResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        internal virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudhsm-2014-05-30/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}