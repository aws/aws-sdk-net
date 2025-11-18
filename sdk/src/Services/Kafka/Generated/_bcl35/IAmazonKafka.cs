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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Kafka.Model;

#pragma warning disable CS1570
namespace Amazon.Kafka
{
    /// <summary>
    /// <para>Interface for accessing Kafka</para>
    ///
    /// The operations for managing an Amazon MSK cluster.
    /// </summary>
    public partial interface IAmazonKafka : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IKafkaPaginatorFactory Paginators { get; }
#endif


        
        #region  BatchAssociateScramSecret


        /// <summary>
        /// Associates one or more Scram Secrets with an Amazon MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateScramSecret service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateScramSecret service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/BatchAssociateScramSecret">REST API Reference for BatchAssociateScramSecret Operation</seealso>
        BatchAssociateScramSecretResponse BatchAssociateScramSecret(BatchAssociateScramSecretRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchAssociateScramSecret operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateScramSecret operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchAssociateScramSecret
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/BatchAssociateScramSecret">REST API Reference for BatchAssociateScramSecret Operation</seealso>
        IAsyncResult BeginBatchAssociateScramSecret(BatchAssociateScramSecretRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchAssociateScramSecret operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchAssociateScramSecret.</param>
        /// 
        /// <returns>Returns a  BatchAssociateScramSecretResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/BatchAssociateScramSecret">REST API Reference for BatchAssociateScramSecret Operation</seealso>
        BatchAssociateScramSecretResponse EndBatchAssociateScramSecret(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDisassociateScramSecret


        /// <summary>
        /// Disassociates one or more Scram Secrets from an Amazon MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateScramSecret service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateScramSecret service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/BatchDisassociateScramSecret">REST API Reference for BatchDisassociateScramSecret Operation</seealso>
        BatchDisassociateScramSecretResponse BatchDisassociateScramSecret(BatchDisassociateScramSecretRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisassociateScramSecret operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateScramSecret operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDisassociateScramSecret
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/BatchDisassociateScramSecret">REST API Reference for BatchDisassociateScramSecret Operation</seealso>
        IAsyncResult BeginBatchDisassociateScramSecret(BatchDisassociateScramSecretRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDisassociateScramSecret operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDisassociateScramSecret.</param>
        /// 
        /// <returns>Returns a  BatchDisassociateScramSecretResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/BatchDisassociateScramSecret">REST API Reference for BatchDisassociateScramSecret Operation</seealso>
        BatchDisassociateScramSecretResponse EndBatchDisassociateScramSecret(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCluster


        /// <summary>
        /// Creates a new MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        CreateClusterResponse CreateCluster(CreateClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        IAsyncResult BeginCreateCluster(CreateClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCluster.</param>
        /// 
        /// <returns>Returns a  CreateClusterResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        CreateClusterResponse EndCreateCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateClusterV2


        /// <summary>
        /// Creates a new MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterV2 service method.</param>
        /// 
        /// <returns>The response from the CreateClusterV2 service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateClusterV2">REST API Reference for CreateClusterV2 Operation</seealso>
        CreateClusterV2Response CreateClusterV2(CreateClusterV2Request request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterV2 operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateClusterV2
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateClusterV2">REST API Reference for CreateClusterV2 Operation</seealso>
        IAsyncResult BeginCreateClusterV2(CreateClusterV2Request request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateClusterV2 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterV2.</param>
        /// 
        /// <returns>Returns a  CreateClusterV2Result from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateClusterV2">REST API Reference for CreateClusterV2 Operation</seealso>
        CreateClusterV2Response EndCreateClusterV2(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConfiguration


        /// <summary>
        /// Creates a new MSK configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateConfiguration service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateConfiguration">REST API Reference for CreateConfiguration Operation</seealso>
        CreateConfigurationResponse CreateConfiguration(CreateConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguration operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateConfiguration">REST API Reference for CreateConfiguration Operation</seealso>
        IAsyncResult BeginCreateConfiguration(CreateConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateConfiguration">REST API Reference for CreateConfiguration Operation</seealso>
        CreateConfigurationResponse EndCreateConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateReplicator


        /// <summary>
        /// Creates the replicator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicator service method.</param>
        /// 
        /// <returns>The response from the CreateReplicator service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateReplicator">REST API Reference for CreateReplicator Operation</seealso>
        CreateReplicatorResponse CreateReplicator(CreateReplicatorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicator operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReplicator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateReplicator">REST API Reference for CreateReplicator Operation</seealso>
        IAsyncResult BeginCreateReplicator(CreateReplicatorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReplicator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicator.</param>
        /// 
        /// <returns>Returns a  CreateReplicatorResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateReplicator">REST API Reference for CreateReplicator Operation</seealso>
        CreateReplicatorResponse EndCreateReplicator(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpcConnection


        /// <summary>
        /// Creates a new MSK VPC connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcConnection service method.</param>
        /// 
        /// <returns>The response from the CreateVpcConnection service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateVpcConnection">REST API Reference for CreateVpcConnection Operation</seealso>
        CreateVpcConnectionResponse CreateVpcConnection(CreateVpcConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcConnection operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateVpcConnection">REST API Reference for CreateVpcConnection Operation</seealso>
        IAsyncResult BeginCreateVpcConnection(CreateVpcConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcConnection.</param>
        /// 
        /// <returns>Returns a  CreateVpcConnectionResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/CreateVpcConnection">REST API Reference for CreateVpcConnection Operation</seealso>
        CreateVpcConnectionResponse EndCreateVpcConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCluster


        /// <summary>
        /// Deletes the MSK cluster specified by the Amazon Resource Name (ARN) in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        DeleteClusterResponse DeleteCluster(DeleteClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        IAsyncResult BeginDeleteCluster(DeleteClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCluster.</param>
        /// 
        /// <returns>Returns a  DeleteClusterResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        DeleteClusterResponse EndDeleteCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteClusterPolicy


        /// <summary>
        /// Deletes the MSK cluster policy specified by the Amazon Resource Name (ARN) in the
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterPolicy service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteClusterPolicy">REST API Reference for DeleteClusterPolicy Operation</seealso>
        DeleteClusterPolicyResponse DeleteClusterPolicy(DeleteClusterPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterPolicy operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClusterPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteClusterPolicy">REST API Reference for DeleteClusterPolicy Operation</seealso>
        IAsyncResult BeginDeleteClusterPolicy(DeleteClusterPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClusterPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteClusterPolicyResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteClusterPolicy">REST API Reference for DeleteClusterPolicy Operation</seealso>
        DeleteClusterPolicyResponse EndDeleteClusterPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConfiguration


        /// <summary>
        /// Deletes an MSK Configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteConfiguration service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteConfiguration">REST API Reference for DeleteConfiguration Operation</seealso>
        DeleteConfigurationResponse DeleteConfiguration(DeleteConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguration operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteConfiguration">REST API Reference for DeleteConfiguration Operation</seealso>
        IAsyncResult BeginDeleteConfiguration(DeleteConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteConfiguration">REST API Reference for DeleteConfiguration Operation</seealso>
        DeleteConfigurationResponse EndDeleteConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteReplicator


        /// <summary>
        /// Deletes a replicator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicator service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicator service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteReplicator">REST API Reference for DeleteReplicator Operation</seealso>
        DeleteReplicatorResponse DeleteReplicator(DeleteReplicatorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicator operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReplicator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteReplicator">REST API Reference for DeleteReplicator Operation</seealso>
        IAsyncResult BeginDeleteReplicator(DeleteReplicatorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReplicator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicator.</param>
        /// 
        /// <returns>Returns a  DeleteReplicatorResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteReplicator">REST API Reference for DeleteReplicator Operation</seealso>
        DeleteReplicatorResponse EndDeleteReplicator(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVpcConnection


        /// <summary>
        /// Deletes a MSK VPC connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcConnection service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteVpcConnection">REST API Reference for DeleteVpcConnection Operation</seealso>
        DeleteVpcConnectionResponse DeleteVpcConnection(DeleteVpcConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcConnection operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteVpcConnection">REST API Reference for DeleteVpcConnection Operation</seealso>
        IAsyncResult BeginDeleteVpcConnection(DeleteVpcConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcConnection.</param>
        /// 
        /// <returns>Returns a  DeleteVpcConnectionResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DeleteVpcConnection">REST API Reference for DeleteVpcConnection Operation</seealso>
        DeleteVpcConnectionResponse EndDeleteVpcConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCluster


        /// <summary>
        /// Returns a description of the MSK cluster whose Amazon Resource Name (ARN) is specified
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        DescribeClusterResponse DescribeCluster(DescribeClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        IAsyncResult BeginDescribeCluster(DescribeClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCluster.</param>
        /// 
        /// <returns>Returns a  DescribeClusterResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        DescribeClusterResponse EndDescribeCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeClusterOperation


        /// <summary>
        /// Returns a description of the cluster operation specified by the ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterOperation service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterOperation service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeClusterOperation">REST API Reference for DescribeClusterOperation Operation</seealso>
        DescribeClusterOperationResponse DescribeClusterOperation(DescribeClusterOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterOperation operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeClusterOperation">REST API Reference for DescribeClusterOperation Operation</seealso>
        IAsyncResult BeginDescribeClusterOperation(DescribeClusterOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterOperation.</param>
        /// 
        /// <returns>Returns a  DescribeClusterOperationResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeClusterOperation">REST API Reference for DescribeClusterOperation Operation</seealso>
        DescribeClusterOperationResponse EndDescribeClusterOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeClusterOperationV2


        /// <summary>
        /// Returns a description of the cluster operation specified by the ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterOperationV2 service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterOperationV2 service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeClusterOperationV2">REST API Reference for DescribeClusterOperationV2 Operation</seealso>
        DescribeClusterOperationV2Response DescribeClusterOperationV2(DescribeClusterOperationV2Request request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterOperationV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterOperationV2 operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterOperationV2
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeClusterOperationV2">REST API Reference for DescribeClusterOperationV2 Operation</seealso>
        IAsyncResult BeginDescribeClusterOperationV2(DescribeClusterOperationV2Request request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterOperationV2 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterOperationV2.</param>
        /// 
        /// <returns>Returns a  DescribeClusterOperationV2Result from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeClusterOperationV2">REST API Reference for DescribeClusterOperationV2 Operation</seealso>
        DescribeClusterOperationV2Response EndDescribeClusterOperationV2(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeClusterV2


        /// <summary>
        /// Returns a description of the MSK cluster whose Amazon Resource Name (ARN) is specified
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterV2 service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterV2 service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeClusterV2">REST API Reference for DescribeClusterV2 Operation</seealso>
        DescribeClusterV2Response DescribeClusterV2(DescribeClusterV2Request request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterV2 operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterV2
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeClusterV2">REST API Reference for DescribeClusterV2 Operation</seealso>
        IAsyncResult BeginDescribeClusterV2(DescribeClusterV2Request request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterV2 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterV2.</param>
        /// 
        /// <returns>Returns a  DescribeClusterV2Result from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeClusterV2">REST API Reference for DescribeClusterV2 Operation</seealso>
        DescribeClusterV2Response EndDescribeClusterV2(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeConfiguration


        /// <summary>
        /// Returns a description of this MSK configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeConfiguration service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeConfiguration">REST API Reference for DescribeConfiguration Operation</seealso>
        DescribeConfigurationResponse DescribeConfiguration(DescribeConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfiguration operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeConfiguration">REST API Reference for DescribeConfiguration Operation</seealso>
        IAsyncResult BeginDescribeConfiguration(DescribeConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeConfiguration">REST API Reference for DescribeConfiguration Operation</seealso>
        DescribeConfigurationResponse EndDescribeConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeConfigurationRevision


        /// <summary>
        /// Returns a description of this revision of the configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRevision service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationRevision service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeConfigurationRevision">REST API Reference for DescribeConfigurationRevision Operation</seealso>
        DescribeConfigurationRevisionResponse DescribeConfigurationRevision(DescribeConfigurationRevisionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRevision operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigurationRevision
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeConfigurationRevision">REST API Reference for DescribeConfigurationRevision Operation</seealso>
        IAsyncResult BeginDescribeConfigurationRevision(DescribeConfigurationRevisionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigurationRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationRevision.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationRevisionResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeConfigurationRevision">REST API Reference for DescribeConfigurationRevision Operation</seealso>
        DescribeConfigurationRevisionResponse EndDescribeConfigurationRevision(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReplicator


        /// <summary>
        /// Describes a replicator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicator service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicator service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeReplicator">REST API Reference for DescribeReplicator Operation</seealso>
        DescribeReplicatorResponse DescribeReplicator(DescribeReplicatorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicator operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplicator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeReplicator">REST API Reference for DescribeReplicator Operation</seealso>
        IAsyncResult BeginDescribeReplicator(DescribeReplicatorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplicator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicator.</param>
        /// 
        /// <returns>Returns a  DescribeReplicatorResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeReplicator">REST API Reference for DescribeReplicator Operation</seealso>
        DescribeReplicatorResponse EndDescribeReplicator(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTopic


        /// <summary>
        /// Returns topic details of this topic on a MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopic service method.</param>
        /// 
        /// <returns>The response from the DescribeTopic service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeTopic">REST API Reference for DescribeTopic Operation</seealso>
        DescribeTopicResponse DescribeTopic(DescribeTopicRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTopic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopic operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTopic
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeTopic">REST API Reference for DescribeTopic Operation</seealso>
        IAsyncResult BeginDescribeTopic(DescribeTopicRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTopic operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTopic.</param>
        /// 
        /// <returns>Returns a  DescribeTopicResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeTopic">REST API Reference for DescribeTopic Operation</seealso>
        DescribeTopicResponse EndDescribeTopic(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTopicPartitions


        /// <summary>
        /// Returns partition details of this topic on a MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopicPartitions service method.</param>
        /// 
        /// <returns>The response from the DescribeTopicPartitions service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeTopicPartitions">REST API Reference for DescribeTopicPartitions Operation</seealso>
        DescribeTopicPartitionsResponse DescribeTopicPartitions(DescribeTopicPartitionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTopicPartitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopicPartitions operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTopicPartitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeTopicPartitions">REST API Reference for DescribeTopicPartitions Operation</seealso>
        IAsyncResult BeginDescribeTopicPartitions(DescribeTopicPartitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTopicPartitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTopicPartitions.</param>
        /// 
        /// <returns>Returns a  DescribeTopicPartitionsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeTopicPartitions">REST API Reference for DescribeTopicPartitions Operation</seealso>
        DescribeTopicPartitionsResponse EndDescribeTopicPartitions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcConnection


        /// <summary>
        /// Returns a description of this MSK VPC connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcConnection service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcConnection service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeVpcConnection">REST API Reference for DescribeVpcConnection Operation</seealso>
        DescribeVpcConnectionResponse DescribeVpcConnection(DescribeVpcConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcConnection operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeVpcConnection">REST API Reference for DescribeVpcConnection Operation</seealso>
        IAsyncResult BeginDescribeVpcConnection(DescribeVpcConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcConnection.</param>
        /// 
        /// <returns>Returns a  DescribeVpcConnectionResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/DescribeVpcConnection">REST API Reference for DescribeVpcConnection Operation</seealso>
        DescribeVpcConnectionResponse EndDescribeVpcConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBootstrapBrokers


        /// <summary>
        /// A list of brokers that a client application can use to bootstrap. This list doesn't
        /// necessarily include all of the brokers in the cluster. The following Python 3.6 example
        /// shows how you can use the Amazon Resource Name (ARN) of a cluster to get its bootstrap
        /// brokers. If you don't know the ARN of your cluster, you can use the <c>ListClusters</c>
        /// operation to get the ARNs of all the clusters in this account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBootstrapBrokers service method.</param>
        /// 
        /// <returns>The response from the GetBootstrapBrokers service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/GetBootstrapBrokers">REST API Reference for GetBootstrapBrokers Operation</seealso>
        GetBootstrapBrokersResponse GetBootstrapBrokers(GetBootstrapBrokersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBootstrapBrokers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBootstrapBrokers operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBootstrapBrokers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/GetBootstrapBrokers">REST API Reference for GetBootstrapBrokers Operation</seealso>
        IAsyncResult BeginGetBootstrapBrokers(GetBootstrapBrokersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBootstrapBrokers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBootstrapBrokers.</param>
        /// 
        /// <returns>Returns a  GetBootstrapBrokersResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/GetBootstrapBrokers">REST API Reference for GetBootstrapBrokers Operation</seealso>
        GetBootstrapBrokersResponse EndGetBootstrapBrokers(IAsyncResult asyncResult);

        #endregion
        
        #region  GetClusterPolicy


        /// <summary>
        /// Get the MSK cluster policy specified by the Amazon Resource Name (ARN) in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClusterPolicy service method.</param>
        /// 
        /// <returns>The response from the GetClusterPolicy service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/GetClusterPolicy">REST API Reference for GetClusterPolicy Operation</seealso>
        GetClusterPolicyResponse GetClusterPolicy(GetClusterPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetClusterPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClusterPolicy operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetClusterPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/GetClusterPolicy">REST API Reference for GetClusterPolicy Operation</seealso>
        IAsyncResult BeginGetClusterPolicy(GetClusterPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetClusterPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClusterPolicy.</param>
        /// 
        /// <returns>Returns a  GetClusterPolicyResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/GetClusterPolicy">REST API Reference for GetClusterPolicy Operation</seealso>
        GetClusterPolicyResponse EndGetClusterPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCompatibleKafkaVersions


        /// <summary>
        /// Gets the Apache Kafka versions to which you can update the MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCompatibleKafkaVersions service method.</param>
        /// 
        /// <returns>The response from the GetCompatibleKafkaVersions service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/GetCompatibleKafkaVersions">REST API Reference for GetCompatibleKafkaVersions Operation</seealso>
        GetCompatibleKafkaVersionsResponse GetCompatibleKafkaVersions(GetCompatibleKafkaVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCompatibleKafkaVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCompatibleKafkaVersions operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCompatibleKafkaVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/GetCompatibleKafkaVersions">REST API Reference for GetCompatibleKafkaVersions Operation</seealso>
        IAsyncResult BeginGetCompatibleKafkaVersions(GetCompatibleKafkaVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCompatibleKafkaVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCompatibleKafkaVersions.</param>
        /// 
        /// <returns>Returns a  GetCompatibleKafkaVersionsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/GetCompatibleKafkaVersions">REST API Reference for GetCompatibleKafkaVersions Operation</seealso>
        GetCompatibleKafkaVersionsResponse EndGetCompatibleKafkaVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListClientVpcConnections


        /// <summary>
        /// Returns a list of all the VPC connections in this Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClientVpcConnections service method.</param>
        /// 
        /// <returns>The response from the ListClientVpcConnections service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClientVpcConnections">REST API Reference for ListClientVpcConnections Operation</seealso>
        ListClientVpcConnectionsResponse ListClientVpcConnections(ListClientVpcConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListClientVpcConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClientVpcConnections operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClientVpcConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClientVpcConnections">REST API Reference for ListClientVpcConnections Operation</seealso>
        IAsyncResult BeginListClientVpcConnections(ListClientVpcConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListClientVpcConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClientVpcConnections.</param>
        /// 
        /// <returns>Returns a  ListClientVpcConnectionsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClientVpcConnections">REST API Reference for ListClientVpcConnections Operation</seealso>
        ListClientVpcConnectionsResponse EndListClientVpcConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  ListClusterOperations


        /// <summary>
        /// Returns a list of all the operations that have been performed on the specified MSK
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusterOperations service method.</param>
        /// 
        /// <returns>The response from the ListClusterOperations service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClusterOperations">REST API Reference for ListClusterOperations Operation</seealso>
        ListClusterOperationsResponse ListClusterOperations(ListClusterOperationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListClusterOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusterOperations operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusterOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClusterOperations">REST API Reference for ListClusterOperations Operation</seealso>
        IAsyncResult BeginListClusterOperations(ListClusterOperationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusterOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusterOperations.</param>
        /// 
        /// <returns>Returns a  ListClusterOperationsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClusterOperations">REST API Reference for ListClusterOperations Operation</seealso>
        ListClusterOperationsResponse EndListClusterOperations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListClusterOperationsV2


        /// <summary>
        /// Returns a list of all the operations that have been performed on the specified MSK
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusterOperationsV2 service method.</param>
        /// 
        /// <returns>The response from the ListClusterOperationsV2 service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClusterOperationsV2">REST API Reference for ListClusterOperationsV2 Operation</seealso>
        ListClusterOperationsV2Response ListClusterOperationsV2(ListClusterOperationsV2Request request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListClusterOperationsV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusterOperationsV2 operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusterOperationsV2
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClusterOperationsV2">REST API Reference for ListClusterOperationsV2 Operation</seealso>
        IAsyncResult BeginListClusterOperationsV2(ListClusterOperationsV2Request request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusterOperationsV2 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusterOperationsV2.</param>
        /// 
        /// <returns>Returns a  ListClusterOperationsV2Result from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClusterOperationsV2">REST API Reference for ListClusterOperationsV2 Operation</seealso>
        ListClusterOperationsV2Response EndListClusterOperationsV2(IAsyncResult asyncResult);

        #endregion
        
        #region  ListClusters


        /// <summary>
        /// Returns a list of all the MSK clusters in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClusters">REST API Reference for ListClusters Operation</seealso>
        ListClustersResponse ListClusters(ListClustersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusters operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClusters">REST API Reference for ListClusters Operation</seealso>
        IAsyncResult BeginListClusters(ListClustersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusters.</param>
        /// 
        /// <returns>Returns a  ListClustersResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClusters">REST API Reference for ListClusters Operation</seealso>
        ListClustersResponse EndListClusters(IAsyncResult asyncResult);

        #endregion
        
        #region  ListClustersV2


        /// <summary>
        /// Returns a list of all the MSK clusters in the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClustersV2 service method.</param>
        /// 
        /// <returns>The response from the ListClustersV2 service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClustersV2">REST API Reference for ListClustersV2 Operation</seealso>
        ListClustersV2Response ListClustersV2(ListClustersV2Request request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListClustersV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClustersV2 operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClustersV2
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClustersV2">REST API Reference for ListClustersV2 Operation</seealso>
        IAsyncResult BeginListClustersV2(ListClustersV2Request request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListClustersV2 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClustersV2.</param>
        /// 
        /// <returns>Returns a  ListClustersV2Result from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListClustersV2">REST API Reference for ListClustersV2 Operation</seealso>
        ListClustersV2Response EndListClustersV2(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConfigurationRevisions


        /// <summary>
        /// Returns a list of all the MSK configurations in this Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationRevisions service method.</param>
        /// 
        /// <returns>The response from the ListConfigurationRevisions service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListConfigurationRevisions">REST API Reference for ListConfigurationRevisions Operation</seealso>
        ListConfigurationRevisionsResponse ListConfigurationRevisions(ListConfigurationRevisionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurationRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationRevisions operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurationRevisions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListConfigurationRevisions">REST API Reference for ListConfigurationRevisions Operation</seealso>
        IAsyncResult BeginListConfigurationRevisions(ListConfigurationRevisionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurationRevisions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurationRevisions.</param>
        /// 
        /// <returns>Returns a  ListConfigurationRevisionsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListConfigurationRevisions">REST API Reference for ListConfigurationRevisions Operation</seealso>
        ListConfigurationRevisionsResponse EndListConfigurationRevisions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConfigurations


        /// <summary>
        /// Returns a list of all the MSK configurations in this Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListConfigurations service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        ListConfigurationsResponse ListConfigurations(ListConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        IAsyncResult BeginListConfigurations(ListConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurations.</param>
        /// 
        /// <returns>Returns a  ListConfigurationsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        ListConfigurationsResponse EndListConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListKafkaVersions


        /// <summary>
        /// Returns a list of Apache Kafka versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKafkaVersions service method.</param>
        /// 
        /// <returns>The response from the ListKafkaVersions service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListKafkaVersions">REST API Reference for ListKafkaVersions Operation</seealso>
        ListKafkaVersionsResponse ListKafkaVersions(ListKafkaVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListKafkaVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKafkaVersions operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKafkaVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListKafkaVersions">REST API Reference for ListKafkaVersions Operation</seealso>
        IAsyncResult BeginListKafkaVersions(ListKafkaVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKafkaVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKafkaVersions.</param>
        /// 
        /// <returns>Returns a  ListKafkaVersionsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListKafkaVersions">REST API Reference for ListKafkaVersions Operation</seealso>
        ListKafkaVersionsResponse EndListKafkaVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNodes


        /// <summary>
        /// Returns a list of the broker nodes in the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNodes service method.</param>
        /// 
        /// <returns>The response from the ListNodes service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListNodes">REST API Reference for ListNodes Operation</seealso>
        ListNodesResponse ListNodes(ListNodesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNodes operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNodes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListNodes">REST API Reference for ListNodes Operation</seealso>
        IAsyncResult BeginListNodes(ListNodesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNodes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNodes.</param>
        /// 
        /// <returns>Returns a  ListNodesResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListNodes">REST API Reference for ListNodes Operation</seealso>
        ListNodesResponse EndListNodes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReplicators


        /// <summary>
        /// Lists the replicators.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReplicators service method.</param>
        /// 
        /// <returns>The response from the ListReplicators service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListReplicators">REST API Reference for ListReplicators Operation</seealso>
        ListReplicatorsResponse ListReplicators(ListReplicatorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReplicators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReplicators operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReplicators
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListReplicators">REST API Reference for ListReplicators Operation</seealso>
        IAsyncResult BeginListReplicators(ListReplicatorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReplicators operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReplicators.</param>
        /// 
        /// <returns>Returns a  ListReplicatorsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListReplicators">REST API Reference for ListReplicators Operation</seealso>
        ListReplicatorsResponse EndListReplicators(IAsyncResult asyncResult);

        #endregion
        
        #region  ListScramSecrets


        /// <summary>
        /// Returns a list of the Scram Secrets associated with an Amazon MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScramSecrets service method.</param>
        /// 
        /// <returns>The response from the ListScramSecrets service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListScramSecrets">REST API Reference for ListScramSecrets Operation</seealso>
        ListScramSecretsResponse ListScramSecrets(ListScramSecretsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListScramSecrets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListScramSecrets operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListScramSecrets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListScramSecrets">REST API Reference for ListScramSecrets Operation</seealso>
        IAsyncResult BeginListScramSecrets(ListScramSecretsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListScramSecrets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListScramSecrets.</param>
        /// 
        /// <returns>Returns a  ListScramSecretsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListScramSecrets">REST API Reference for ListScramSecrets Operation</seealso>
        ListScramSecretsResponse EndListScramSecrets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of the tags associated with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTopics


        /// <summary>
        /// List topics in a MSK cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopics service method.</param>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListTopics">REST API Reference for ListTopics Operation</seealso>
        ListTopicsResponse ListTopics(ListTopicsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTopics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTopics operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTopics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListTopics">REST API Reference for ListTopics Operation</seealso>
        IAsyncResult BeginListTopics(ListTopicsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTopics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTopics.</param>
        /// 
        /// <returns>Returns a  ListTopicsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListTopics">REST API Reference for ListTopics Operation</seealso>
        ListTopicsResponse EndListTopics(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVpcConnections


        /// <summary>
        /// Returns a list of all the VPC connections in this Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcConnections service method.</param>
        /// 
        /// <returns>The response from the ListVpcConnections service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListVpcConnections">REST API Reference for ListVpcConnections Operation</seealso>
        ListVpcConnectionsResponse ListVpcConnections(ListVpcConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVpcConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVpcConnections operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVpcConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListVpcConnections">REST API Reference for ListVpcConnections Operation</seealso>
        IAsyncResult BeginListVpcConnections(ListVpcConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVpcConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVpcConnections.</param>
        /// 
        /// <returns>Returns a  ListVpcConnectionsResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/ListVpcConnections">REST API Reference for ListVpcConnections Operation</seealso>
        ListVpcConnectionsResponse EndListVpcConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  PutClusterPolicy


        /// <summary>
        /// Creates or updates the MSK cluster policy specified by the cluster Amazon Resource
        /// Name (ARN) in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutClusterPolicy service method.</param>
        /// 
        /// <returns>The response from the PutClusterPolicy service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/PutClusterPolicy">REST API Reference for PutClusterPolicy Operation</seealso>
        PutClusterPolicyResponse PutClusterPolicy(PutClusterPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutClusterPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutClusterPolicy operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutClusterPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/PutClusterPolicy">REST API Reference for PutClusterPolicy Operation</seealso>
        IAsyncResult BeginPutClusterPolicy(PutClusterPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutClusterPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutClusterPolicy.</param>
        /// 
        /// <returns>Returns a  PutClusterPolicyResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/PutClusterPolicy">REST API Reference for PutClusterPolicy Operation</seealso>
        PutClusterPolicyResponse EndPutClusterPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  RebootBroker


        /// <summary>
        /// Reboots brokers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootBroker service method.</param>
        /// 
        /// <returns>The response from the RebootBroker service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/RebootBroker">REST API Reference for RebootBroker Operation</seealso>
        RebootBrokerResponse RebootBroker(RebootBrokerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RebootBroker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootBroker operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootBroker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/RebootBroker">REST API Reference for RebootBroker Operation</seealso>
        IAsyncResult BeginRebootBroker(RebootBrokerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RebootBroker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootBroker.</param>
        /// 
        /// <returns>Returns a  RebootBrokerResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/RebootBroker">REST API Reference for RebootBroker Operation</seealso>
        RebootBrokerResponse EndRebootBroker(IAsyncResult asyncResult);

        #endregion
        
        #region  RejectClientVpcConnection


        /// <summary>
        /// Returns empty response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectClientVpcConnection service method.</param>
        /// 
        /// <returns>The response from the RejectClientVpcConnection service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/RejectClientVpcConnection">REST API Reference for RejectClientVpcConnection Operation</seealso>
        RejectClientVpcConnectionResponse RejectClientVpcConnection(RejectClientVpcConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RejectClientVpcConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectClientVpcConnection operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectClientVpcConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/RejectClientVpcConnection">REST API Reference for RejectClientVpcConnection Operation</seealso>
        IAsyncResult BeginRejectClientVpcConnection(RejectClientVpcConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RejectClientVpcConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectClientVpcConnection.</param>
        /// 
        /// <returns>Returns a  RejectClientVpcConnectionResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/RejectClientVpcConnection">REST API Reference for RejectClientVpcConnection Operation</seealso>
        RejectClientVpcConnectionResponse EndRejectClientVpcConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to the specified MSK resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the tags associated with the keys that are provided in the query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBrokerCount


        /// <summary>
        /// Updates the number of broker nodes in the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrokerCount service method.</param>
        /// 
        /// <returns>The response from the UpdateBrokerCount service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateBrokerCount">REST API Reference for UpdateBrokerCount Operation</seealso>
        UpdateBrokerCountResponse UpdateBrokerCount(UpdateBrokerCountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBrokerCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrokerCount operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBrokerCount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateBrokerCount">REST API Reference for UpdateBrokerCount Operation</seealso>
        IAsyncResult BeginUpdateBrokerCount(UpdateBrokerCountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBrokerCount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBrokerCount.</param>
        /// 
        /// <returns>Returns a  UpdateBrokerCountResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateBrokerCount">REST API Reference for UpdateBrokerCount Operation</seealso>
        UpdateBrokerCountResponse EndUpdateBrokerCount(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBrokerStorage


        /// <summary>
        /// Updates the EBS storage associated with MSK brokers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrokerStorage service method.</param>
        /// 
        /// <returns>The response from the UpdateBrokerStorage service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateBrokerStorage">REST API Reference for UpdateBrokerStorage Operation</seealso>
        UpdateBrokerStorageResponse UpdateBrokerStorage(UpdateBrokerStorageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBrokerStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrokerStorage operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBrokerStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateBrokerStorage">REST API Reference for UpdateBrokerStorage Operation</seealso>
        IAsyncResult BeginUpdateBrokerStorage(UpdateBrokerStorageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBrokerStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBrokerStorage.</param>
        /// 
        /// <returns>Returns a  UpdateBrokerStorageResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateBrokerStorage">REST API Reference for UpdateBrokerStorage Operation</seealso>
        UpdateBrokerStorageResponse EndUpdateBrokerStorage(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBrokerType


        /// <summary>
        /// Updates EC2 instance type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrokerType service method.</param>
        /// 
        /// <returns>The response from the UpdateBrokerType service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateBrokerType">REST API Reference for UpdateBrokerType Operation</seealso>
        UpdateBrokerTypeResponse UpdateBrokerType(UpdateBrokerTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBrokerType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrokerType operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBrokerType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateBrokerType">REST API Reference for UpdateBrokerType Operation</seealso>
        IAsyncResult BeginUpdateBrokerType(UpdateBrokerTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBrokerType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBrokerType.</param>
        /// 
        /// <returns>Returns a  UpdateBrokerTypeResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateBrokerType">REST API Reference for UpdateBrokerType Operation</seealso>
        UpdateBrokerTypeResponse EndUpdateBrokerType(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateClusterConfiguration


        /// <summary>
        /// Updates the cluster with the configuration that is specified in the request body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateClusterConfiguration service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateClusterConfiguration">REST API Reference for UpdateClusterConfiguration Operation</seealso>
        UpdateClusterConfigurationResponse UpdateClusterConfiguration(UpdateClusterConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClusterConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterConfiguration operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateClusterConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateClusterConfiguration">REST API Reference for UpdateClusterConfiguration Operation</seealso>
        IAsyncResult BeginUpdateClusterConfiguration(UpdateClusterConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateClusterConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateClusterConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateClusterConfigurationResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateClusterConfiguration">REST API Reference for UpdateClusterConfiguration Operation</seealso>
        UpdateClusterConfigurationResponse EndUpdateClusterConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateClusterKafkaVersion


        /// <summary>
        /// Updates the Apache Kafka version for the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterKafkaVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateClusterKafkaVersion service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateClusterKafkaVersion">REST API Reference for UpdateClusterKafkaVersion Operation</seealso>
        UpdateClusterKafkaVersionResponse UpdateClusterKafkaVersion(UpdateClusterKafkaVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClusterKafkaVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClusterKafkaVersion operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateClusterKafkaVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateClusterKafkaVersion">REST API Reference for UpdateClusterKafkaVersion Operation</seealso>
        IAsyncResult BeginUpdateClusterKafkaVersion(UpdateClusterKafkaVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateClusterKafkaVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateClusterKafkaVersion.</param>
        /// 
        /// <returns>Returns a  UpdateClusterKafkaVersionResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateClusterKafkaVersion">REST API Reference for UpdateClusterKafkaVersion Operation</seealso>
        UpdateClusterKafkaVersionResponse EndUpdateClusterKafkaVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConfiguration


        /// <summary>
        /// Updates an MSK configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateConfiguration service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateConfiguration">REST API Reference for UpdateConfiguration Operation</seealso>
        UpdateConfigurationResponse UpdateConfiguration(UpdateConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguration operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateConfiguration">REST API Reference for UpdateConfiguration Operation</seealso>
        IAsyncResult BeginUpdateConfiguration(UpdateConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateConfiguration">REST API Reference for UpdateConfiguration Operation</seealso>
        UpdateConfigurationResponse EndUpdateConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConnectivity


        /// <summary>
        /// Updates the cluster's connectivity configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectivity service method.</param>
        /// 
        /// <returns>The response from the UpdateConnectivity service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateConnectivity">REST API Reference for UpdateConnectivity Operation</seealso>
        UpdateConnectivityResponse UpdateConnectivity(UpdateConnectivityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnectivity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectivity operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnectivity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateConnectivity">REST API Reference for UpdateConnectivity Operation</seealso>
        IAsyncResult BeginUpdateConnectivity(UpdateConnectivityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnectivity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnectivity.</param>
        /// 
        /// <returns>Returns a  UpdateConnectivityResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateConnectivity">REST API Reference for UpdateConnectivity Operation</seealso>
        UpdateConnectivityResponse EndUpdateConnectivity(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMonitoring


        /// <summary>
        /// Updates the monitoring settings for the cluster. You can use this operation to specify
        /// which Apache Kafka metrics you want Amazon MSK to send to Amazon CloudWatch. You can
        /// also specify settings for open monitoring with Prometheus.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitoring service method.</param>
        /// 
        /// <returns>The response from the UpdateMonitoring service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateMonitoring">REST API Reference for UpdateMonitoring Operation</seealso>
        UpdateMonitoringResponse UpdateMonitoring(UpdateMonitoringRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMonitoring operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitoring operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMonitoring
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateMonitoring">REST API Reference for UpdateMonitoring Operation</seealso>
        IAsyncResult BeginUpdateMonitoring(UpdateMonitoringRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMonitoring operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMonitoring.</param>
        /// 
        /// <returns>Returns a  UpdateMonitoringResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateMonitoring">REST API Reference for UpdateMonitoring Operation</seealso>
        UpdateMonitoringResponse EndUpdateMonitoring(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRebalancing


        /// <summary>
        /// Use this resource to update the intelligent rebalancing status of an Amazon MSK Provisioned
        /// cluster with Express brokers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRebalancing service method.</param>
        /// 
        /// <returns>The response from the UpdateRebalancing service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateRebalancing">REST API Reference for UpdateRebalancing Operation</seealso>
        UpdateRebalancingResponse UpdateRebalancing(UpdateRebalancingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRebalancing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRebalancing operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRebalancing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateRebalancing">REST API Reference for UpdateRebalancing Operation</seealso>
        IAsyncResult BeginUpdateRebalancing(UpdateRebalancingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRebalancing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRebalancing.</param>
        /// 
        /// <returns>Returns a  UpdateRebalancingResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateRebalancing">REST API Reference for UpdateRebalancing Operation</seealso>
        UpdateRebalancingResponse EndUpdateRebalancing(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateReplicationInfo


        /// <summary>
        /// Updates replication info of a replicator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationInfo service method.</param>
        /// 
        /// <returns>The response from the UpdateReplicationInfo service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateReplicationInfo">REST API Reference for UpdateReplicationInfo Operation</seealso>
        UpdateReplicationInfoResponse UpdateReplicationInfo(UpdateReplicationInfoRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReplicationInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationInfo operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReplicationInfo
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateReplicationInfo">REST API Reference for UpdateReplicationInfo Operation</seealso>
        IAsyncResult BeginUpdateReplicationInfo(UpdateReplicationInfoRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReplicationInfo operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReplicationInfo.</param>
        /// 
        /// <returns>Returns a  UpdateReplicationInfoResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateReplicationInfo">REST API Reference for UpdateReplicationInfo Operation</seealso>
        UpdateReplicationInfoResponse EndUpdateReplicationInfo(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSecurity


        /// <summary>
        /// Updates the security settings for the cluster. You can use this operation to specify
        /// encryption and authentication on existing clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurity service method.</param>
        /// 
        /// <returns>The response from the UpdateSecurity service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateSecurity">REST API Reference for UpdateSecurity Operation</seealso>
        UpdateSecurityResponse UpdateSecurity(UpdateSecurityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecurity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurity operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSecurity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateSecurity">REST API Reference for UpdateSecurity Operation</seealso>
        IAsyncResult BeginUpdateSecurity(UpdateSecurityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSecurity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSecurity.</param>
        /// 
        /// <returns>Returns a  UpdateSecurityResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateSecurity">REST API Reference for UpdateSecurity Operation</seealso>
        UpdateSecurityResponse EndUpdateSecurity(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateStorage


        /// <summary>
        /// Updates cluster broker volume size (or) sets cluster storage mode to TIERED.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStorage service method.</param>
        /// 
        /// <returns>The response from the UpdateStorage service method, as returned by Kafka.</returns>
        /// <exception cref="Amazon.Kafka.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.ServiceUnavailableException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.TooManyRequestsException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.Kafka.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateStorage">REST API Reference for UpdateStorage Operation</seealso>
        UpdateStorageResponse UpdateStorage(UpdateStorageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStorage operation on AmazonKafkaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateStorage">REST API Reference for UpdateStorage Operation</seealso>
        IAsyncResult BeginUpdateStorage(UpdateStorageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStorage.</param>
        /// 
        /// <returns>Returns a  UpdateStorageResult from Kafka.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafka-2018-11-14/UpdateStorage">REST API Reference for UpdateStorage Operation</seealso>
        UpdateStorageResponse EndUpdateStorage(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}