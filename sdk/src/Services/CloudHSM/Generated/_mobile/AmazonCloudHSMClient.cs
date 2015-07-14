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
    /// </summary>
    public partial class AmazonCloudHSMClient : AmazonServiceClient, IAmazonCloudHSM
    {
        
        #region Constructors

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

        
        #region  CreateHapg

        internal CreateHapgResponse CreateHapg(CreateHapgRequest request)
        {
            var marshaller = new CreateHapgRequestMarshaller();
            var unmarshaller = CreateHapgResponseUnmarshaller.Instance;

            return Invoke<CreateHapgRequest,CreateHapgResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Creates a high-availability partition group. A high-availability partition group is
        /// a group of partitions that spans multiple physical HSMs.
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
        public Task<CreateHapgResponse> CreateHapgAsync(string label, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<CreateHapgResponse> CreateHapgAsync(CreateHapgRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateHapgRequestMarshaller();
            var unmarshaller = CreateHapgResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHapgRequest,CreateHapgResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateHsm

        internal CreateHsmResponse CreateHsm(CreateHsmRequest request)
        {
            var marshaller = new CreateHsmRequestMarshaller();
            var unmarshaller = CreateHsmResponseUnmarshaller.Instance;

            return Invoke<CreateHsmRequest,CreateHsmResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateHsmResponse> CreateHsmAsync(CreateHsmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateHsmRequestMarshaller();
            var unmarshaller = CreateHsmResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHsmRequest,CreateHsmResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLunaClient

        internal CreateLunaClientResponse CreateLunaClient(CreateLunaClientRequest request)
        {
            var marshaller = new CreateLunaClientRequestMarshaller();
            var unmarshaller = CreateLunaClientResponseUnmarshaller.Instance;

            return Invoke<CreateLunaClientRequest,CreateLunaClientResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateLunaClientResponse> CreateLunaClientAsync(CreateLunaClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLunaClientRequestMarshaller();
            var unmarshaller = CreateLunaClientResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLunaClientRequest,CreateLunaClientResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteHapg

        internal DeleteHapgResponse DeleteHapg(DeleteHapgRequest request)
        {
            var marshaller = new DeleteHapgRequestMarshaller();
            var unmarshaller = DeleteHapgResponseUnmarshaller.Instance;

            return Invoke<DeleteHapgRequest,DeleteHapgResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes a high-availability partition group.
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
        public Task<DeleteHapgResponse> DeleteHapgAsync(string hapgArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DeleteHapgResponse> DeleteHapgAsync(DeleteHapgRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteHapgRequestMarshaller();
            var unmarshaller = DeleteHapgResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHapgRequest,DeleteHapgResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteHsm

        internal DeleteHsmResponse DeleteHsm(DeleteHsmRequest request)
        {
            var marshaller = new DeleteHsmRequestMarshaller();
            var unmarshaller = DeleteHsmResponseUnmarshaller.Instance;

            return Invoke<DeleteHsmRequest,DeleteHsmResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes an HSM. Once complete, this operation cannot be undone and your key material
        /// cannot be recovered.
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
        public Task<DeleteHsmResponse> DeleteHsmAsync(string hsmArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DeleteHsmResponse> DeleteHsmAsync(DeleteHsmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteHsmRequestMarshaller();
            var unmarshaller = DeleteHsmResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHsmRequest,DeleteHsmResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLunaClient

        internal DeleteLunaClientResponse DeleteLunaClient(DeleteLunaClientRequest request)
        {
            var marshaller = new DeleteLunaClientRequestMarshaller();
            var unmarshaller = DeleteLunaClientResponseUnmarshaller.Instance;

            return Invoke<DeleteLunaClientRequest,DeleteLunaClientResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes a client.
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
        public Task<DeleteLunaClientResponse> DeleteLunaClientAsync(string clientArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DeleteLunaClientResponse> DeleteLunaClientAsync(DeleteLunaClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLunaClientRequestMarshaller();
            var unmarshaller = DeleteLunaClientResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLunaClientRequest,DeleteLunaClientResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeHapg

        internal DescribeHapgResponse DescribeHapg(DescribeHapgRequest request)
        {
            var marshaller = new DescribeHapgRequestMarshaller();
            var unmarshaller = DescribeHapgResponseUnmarshaller.Instance;

            return Invoke<DescribeHapgRequest,DescribeHapgResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves information about a high-availability partition group.
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
        public Task<DescribeHapgResponse> DescribeHapgAsync(string hapgArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeHapgResponse> DescribeHapgAsync(DescribeHapgRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeHapgRequestMarshaller();
            var unmarshaller = DescribeHapgResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHapgRequest,DescribeHapgResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeHsm

        internal DescribeHsmResponse DescribeHsm(DescribeHsmRequest request)
        {
            var marshaller = new DescribeHsmRequestMarshaller();
            var unmarshaller = DescribeHsmResponseUnmarshaller.Instance;

            return Invoke<DescribeHsmRequest,DescribeHsmResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves information about an HSM. You can identify the HSM by its ARN or its serial
        /// number.
        /// </summary>
        /// <param name="hsmArn">The ARN of the HSM. Either the <i>HsmArn</i> or the <i>SerialNumber</i> parameter must be specified.</param>
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
        public Task<DescribeHsmResponse> DescribeHsmAsync(string hsmArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeHsmResponse> DescribeHsmAsync(DescribeHsmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeHsmRequestMarshaller();
            var unmarshaller = DescribeHsmResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHsmRequest,DescribeHsmResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLunaClient

        internal DescribeLunaClientResponse DescribeLunaClient(DescribeLunaClientRequest request)
        {
            var marshaller = new DescribeLunaClientRequestMarshaller();
            var unmarshaller = DescribeLunaClientResponseUnmarshaller.Instance;

            return Invoke<DescribeLunaClientRequest,DescribeLunaClientResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeLunaClientResponse> DescribeLunaClientAsync(DescribeLunaClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLunaClientRequestMarshaller();
            var unmarshaller = DescribeLunaClientResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLunaClientRequest,DescribeLunaClientResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetConfig

        internal GetConfigResponse GetConfig(GetConfigRequest request)
        {
            var marshaller = new GetConfigRequestMarshaller();
            var unmarshaller = GetConfigResponseUnmarshaller.Instance;

            return Invoke<GetConfigRequest,GetConfigResponse>(request, marshaller, unmarshaller);
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
        public Task<GetConfigResponse> GetConfigAsync(GetConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetConfigRequestMarshaller();
            var unmarshaller = GetConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfigRequest,GetConfigResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAvailableZones

        internal ListAvailableZonesResponse ListAvailableZones(ListAvailableZonesRequest request)
        {
            var marshaller = new ListAvailableZonesRequestMarshaller();
            var unmarshaller = ListAvailableZonesResponseUnmarshaller.Instance;

            return Invoke<ListAvailableZonesRequest,ListAvailableZonesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists the Availability Zones that have available AWS CloudHSM capacity.
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
        public Task<ListAvailableZonesResponse> ListAvailableZonesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<ListAvailableZonesResponse> ListAvailableZonesAsync(ListAvailableZonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAvailableZonesRequestMarshaller();
            var unmarshaller = ListAvailableZonesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAvailableZonesRequest,ListAvailableZonesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListHapgs

        internal ListHapgsResponse ListHapgs(ListHapgsRequest request)
        {
            var marshaller = new ListHapgsRequestMarshaller();
            var unmarshaller = ListHapgsResponseUnmarshaller.Instance;

            return Invoke<ListHapgsRequest,ListHapgsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists the high-availability partition groups for the account.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> member. If
        /// more results are available, the <i>NextToken</i> member of the response contains a
        /// token that you pass in the next call to <a>ListHapgs</a> to retrieve the next set
        /// of items.
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
        public Task<ListHapgsResponse> ListHapgsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<ListHapgsResponse> ListHapgsAsync(ListHapgsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListHapgsRequestMarshaller();
            var unmarshaller = ListHapgsResponseUnmarshaller.Instance;

            return InvokeAsync<ListHapgsRequest,ListHapgsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListHsms

        internal ListHsmsResponse ListHsms(ListHsmsRequest request)
        {
            var marshaller = new ListHsmsRequestMarshaller();
            var unmarshaller = ListHsmsResponseUnmarshaller.Instance;

            return Invoke<ListHsmsRequest,ListHsmsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves the identifiers of all of the HSMs provisioned for the current customer.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> member. If
        /// more results are available, the <i>NextToken</i> member of the response contains a
        /// token that you pass in the next call to <a>ListHsms</a> to retrieve the next set of
        /// items.
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
        public Task<ListHsmsResponse> ListHsmsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<ListHsmsResponse> ListHsmsAsync(ListHsmsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListHsmsRequestMarshaller();
            var unmarshaller = ListHsmsResponseUnmarshaller.Instance;

            return InvokeAsync<ListHsmsRequest,ListHsmsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListLunaClients

        internal ListLunaClientsResponse ListLunaClients(ListLunaClientsRequest request)
        {
            var marshaller = new ListLunaClientsRequestMarshaller();
            var unmarshaller = ListLunaClientsResponseUnmarshaller.Instance;

            return Invoke<ListLunaClientsRequest,ListLunaClientsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists all of the clients.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> member. If
        /// more results are available, the <i>NextToken</i> member of the response contains a
        /// token that you pass in the next call to <a>ListLunaClients</a> to retrieve the next
        /// set of items.
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
        public Task<ListLunaClientsResponse> ListLunaClientsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<ListLunaClientsResponse> ListLunaClientsAsync(ListLunaClientsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListLunaClientsRequestMarshaller();
            var unmarshaller = ListLunaClientsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLunaClientsRequest,ListLunaClientsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyHapg

        internal ModifyHapgResponse ModifyHapg(ModifyHapgRequest request)
        {
            var marshaller = new ModifyHapgRequestMarshaller();
            var unmarshaller = ModifyHapgResponseUnmarshaller.Instance;

            return Invoke<ModifyHapgRequest,ModifyHapgResponse>(request, marshaller, unmarshaller);
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
        public Task<ModifyHapgResponse> ModifyHapgAsync(ModifyHapgRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyHapgRequestMarshaller();
            var unmarshaller = ModifyHapgResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyHapgRequest,ModifyHapgResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyHsm

        internal ModifyHsmResponse ModifyHsm(ModifyHsmRequest request)
        {
            var marshaller = new ModifyHsmRequestMarshaller();
            var unmarshaller = ModifyHsmResponseUnmarshaller.Instance;

            return Invoke<ModifyHsmRequest,ModifyHsmResponse>(request, marshaller, unmarshaller);
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
        public Task<ModifyHsmResponse> ModifyHsmAsync(ModifyHsmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyHsmRequestMarshaller();
            var unmarshaller = ModifyHsmResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyHsmRequest,ModifyHsmResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyLunaClient

        internal ModifyLunaClientResponse ModifyLunaClient(ModifyLunaClientRequest request)
        {
            var marshaller = new ModifyLunaClientRequestMarshaller();
            var unmarshaller = ModifyLunaClientResponseUnmarshaller.Instance;

            return Invoke<ModifyLunaClientRequest,ModifyLunaClientResponse>(request, marshaller, unmarshaller);
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
        public Task<ModifyLunaClientResponse> ModifyLunaClientAsync(ModifyLunaClientRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyLunaClientRequestMarshaller();
            var unmarshaller = ModifyLunaClientResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyLunaClientRequest,ModifyLunaClientResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}