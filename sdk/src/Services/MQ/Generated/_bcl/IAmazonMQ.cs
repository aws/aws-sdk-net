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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MQ.Model;

#pragma warning disable CS1570
namespace Amazon.MQ
{
    /// <summary>
    /// <para>Interface for accessing MQ</para>
    ///
    /// Amazon MQ is a managed message broker service for Apache ActiveMQ and RabbitMQ that
    /// makes it easy to set up and operate message brokers in the cloud. A message broker
    /// allows software applications and components to communicate using various programming
    /// languages, operating systems, and formal messaging protocols.
    /// </summary>
    public partial interface IAmazonMQ : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMQPaginatorFactory Paginators { get; }

        
        #region  CreateBroker


        /// <summary>
        /// Creates a broker. Note: This API is asynchronous.
        /// 
        ///  
        /// <para>
        /// To create a broker, you must either use the AmazonMQFullAccess IAM policy or include
        /// the following EC2 permissions in your IAM policy.
        /// </para>
        ///  <ul><li>
        /// <para>
        /// ec2:CreateNetworkInterface
        /// </para>
        ///  
        /// <para>
        /// This permission is required to allow Amazon MQ to create an elastic network interface
        /// (ENI) on behalf of your account.
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:CreateNetworkInterfacePermission
        /// </para>
        ///  
        /// <para>
        /// This permission is required to attach the ENI to the broker instance.
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DeleteNetworkInterface
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DeleteNetworkInterfacePermission
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DetachNetworkInterface
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DescribeInternetGateways
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DescribeNetworkInterfaces
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DescribeNetworkInterfacePermissions
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DescribeRouteTables
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DescribeSecurityGroups
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DescribeSubnets
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DescribeVpcs
        /// </para>
        /// </li></ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/amazon-mq-setting-up.html#create-iam-user">Create
        /// an IAM User and Get Your Amazon Web Services Credentials</a> and <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/connecting-to-amazon-mq.html#never-modify-delete-elastic-network-interface">Never
        /// Modify or Delete the Amazon MQ Elastic Network Interface</a> in the <i>Amazon MQ Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBroker service method.</param>
        /// 
        /// <returns>The response from the CreateBroker service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateBroker">REST API Reference for CreateBroker Operation</seealso>
        CreateBrokerResponse CreateBroker(CreateBrokerRequest request);



        /// <summary>
        /// Creates a broker. Note: This API is asynchronous.
        /// 
        ///  
        /// <para>
        /// To create a broker, you must either use the AmazonMQFullAccess IAM policy or include
        /// the following EC2 permissions in your IAM policy.
        /// </para>
        ///  <ul><li>
        /// <para>
        /// ec2:CreateNetworkInterface
        /// </para>
        ///  
        /// <para>
        /// This permission is required to allow Amazon MQ to create an elastic network interface
        /// (ENI) on behalf of your account.
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:CreateNetworkInterfacePermission
        /// </para>
        ///  
        /// <para>
        /// This permission is required to attach the ENI to the broker instance.
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DeleteNetworkInterface
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DeleteNetworkInterfacePermission
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DetachNetworkInterface
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DescribeInternetGateways
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DescribeNetworkInterfaces
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DescribeNetworkInterfacePermissions
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DescribeRouteTables
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DescribeSecurityGroups
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DescribeSubnets
        /// </para>
        /// </li> <li>
        /// <para>
        /// ec2:DescribeVpcs
        /// </para>
        /// </li></ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/amazon-mq-setting-up.html#create-iam-user">Create
        /// an IAM User and Get Your Amazon Web Services Credentials</a> and <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/connecting-to-amazon-mq.html#never-modify-delete-elastic-network-interface">Never
        /// Modify or Delete the Amazon MQ Elastic Network Interface</a> in the <i>Amazon MQ Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBroker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBroker service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.UnauthorizedException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateBroker">REST API Reference for CreateBroker Operation</seealso>
        Task<CreateBrokerResponse> CreateBrokerAsync(CreateBrokerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateConfiguration


        /// <summary>
        /// Creates a new configuration for the specified configuration name. Amazon MQ uses the
        /// default configuration (the engine type and version).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateConfiguration service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateConfiguration">REST API Reference for CreateConfiguration Operation</seealso>
        CreateConfigurationResponse CreateConfiguration(CreateConfigurationRequest request);



        /// <summary>
        /// Creates a new configuration for the specified configuration name. Amazon MQ uses the
        /// default configuration (the engine type and version).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfiguration service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateConfiguration">REST API Reference for CreateConfiguration Operation</seealso>
        Task<CreateConfigurationResponse> CreateConfigurationAsync(CreateConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTags


        /// <summary>
        /// Add a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateTags">REST API Reference for CreateTags Operation</seealso>
        CreateTagsResponse CreateTags(CreateTagsRequest request);



        /// <summary>
        /// Add a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateTags">REST API Reference for CreateTags Operation</seealso>
        Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateUser


        /// <summary>
        /// Creates an ActiveMQ user.
        /// 
        ///  <important>
        /// <para>
        /// Do not add personally identifiable information (PII) or other confidential or sensitive
        /// information in broker usernames. Broker usernames are accessible to other Amazon Web
        /// Services services, including CloudWatch Logs. Broker usernames are not intended to
        /// be used for private or sensitive data.
        /// </para>
        /// </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse CreateUser(CreateUserRequest request);



        /// <summary>
        /// Creates an ActiveMQ user.
        /// 
        ///  <important>
        /// <para>
        /// Do not add personally identifiable information (PII) or other confidential or sensitive
        /// information in broker usernames. Broker usernames are accessible to other Amazon Web
        /// Services services, including CloudWatch Logs. Broker usernames are not intended to
        /// be used for private or sensitive data.
        /// </para>
        /// </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateUser">REST API Reference for CreateUser Operation</seealso>
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBroker


        /// <summary>
        /// Deletes a broker. Note: This API is asynchronous.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBroker service method.</param>
        /// 
        /// <returns>The response from the DeleteBroker service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DeleteBroker">REST API Reference for DeleteBroker Operation</seealso>
        DeleteBrokerResponse DeleteBroker(DeleteBrokerRequest request);



        /// <summary>
        /// Deletes a broker. Note: This API is asynchronous.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBroker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBroker service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DeleteBroker">REST API Reference for DeleteBroker Operation</seealso>
        Task<DeleteBrokerResponse> DeleteBrokerAsync(DeleteBrokerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConfiguration


        /// <summary>
        /// Deletes the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteConfiguration service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DeleteConfiguration">REST API Reference for DeleteConfiguration Operation</seealso>
        DeleteConfigurationResponse DeleteConfiguration(DeleteConfigurationRequest request);



        /// <summary>
        /// Deletes the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfiguration service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DeleteConfiguration">REST API Reference for DeleteConfiguration Operation</seealso>
        Task<DeleteConfigurationResponse> DeleteConfigurationAsync(DeleteConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTags


        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        DeleteTagsResponse DeleteTags(DeleteTagsRequest request);



        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes an ActiveMQ user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse DeleteUser(DeleteUserRequest request);



        /// <summary>
        /// Deletes an ActiveMQ user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeBroker


        /// <summary>
        /// Returns information about the specified broker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBroker service method.</param>
        /// 
        /// <returns>The response from the DescribeBroker service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeBroker">REST API Reference for DescribeBroker Operation</seealso>
        DescribeBrokerResponse DescribeBroker(DescribeBrokerRequest request);



        /// <summary>
        /// Returns information about the specified broker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBroker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBroker service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeBroker">REST API Reference for DescribeBroker Operation</seealso>
        Task<DescribeBrokerResponse> DescribeBrokerAsync(DescribeBrokerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeBrokerEngineTypes


        /// <summary>
        /// Describe available engine types and versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBrokerEngineTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeBrokerEngineTypes service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeBrokerEngineTypes">REST API Reference for DescribeBrokerEngineTypes Operation</seealso>
        DescribeBrokerEngineTypesResponse DescribeBrokerEngineTypes(DescribeBrokerEngineTypesRequest request);



        /// <summary>
        /// Describe available engine types and versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBrokerEngineTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBrokerEngineTypes service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeBrokerEngineTypes">REST API Reference for DescribeBrokerEngineTypes Operation</seealso>
        Task<DescribeBrokerEngineTypesResponse> DescribeBrokerEngineTypesAsync(DescribeBrokerEngineTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeBrokerInstanceOptions


        /// <summary>
        /// Describe available broker instance options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBrokerInstanceOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeBrokerInstanceOptions service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeBrokerInstanceOptions">REST API Reference for DescribeBrokerInstanceOptions Operation</seealso>
        DescribeBrokerInstanceOptionsResponse DescribeBrokerInstanceOptions(DescribeBrokerInstanceOptionsRequest request);



        /// <summary>
        /// Describe available broker instance options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBrokerInstanceOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBrokerInstanceOptions service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeBrokerInstanceOptions">REST API Reference for DescribeBrokerInstanceOptions Operation</seealso>
        Task<DescribeBrokerInstanceOptionsResponse> DescribeBrokerInstanceOptionsAsync(DescribeBrokerInstanceOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConfiguration


        /// <summary>
        /// Returns information about the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeConfiguration service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeConfiguration">REST API Reference for DescribeConfiguration Operation</seealso>
        DescribeConfigurationResponse DescribeConfiguration(DescribeConfigurationRequest request);



        /// <summary>
        /// Returns information about the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfiguration service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeConfiguration">REST API Reference for DescribeConfiguration Operation</seealso>
        Task<DescribeConfigurationResponse> DescribeConfigurationAsync(DescribeConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConfigurationRevision


        /// <summary>
        /// Returns the specified configuration revision for the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRevision service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationRevision service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeConfigurationRevision">REST API Reference for DescribeConfigurationRevision Operation</seealso>
        DescribeConfigurationRevisionResponse DescribeConfigurationRevision(DescribeConfigurationRevisionRequest request);



        /// <summary>
        /// Returns the specified configuration revision for the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationRevision service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeConfigurationRevision">REST API Reference for DescribeConfigurationRevision Operation</seealso>
        Task<DescribeConfigurationRevisionResponse> DescribeConfigurationRevisionAsync(DescribeConfigurationRevisionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeUser


        /// <summary>
        /// Returns information about an ActiveMQ user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        DescribeUserResponse DescribeUser(DescribeUserRequest request);



        /// <summary>
        /// Returns information about an ActiveMQ user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBrokers


        /// <summary>
        /// Returns a list of all brokers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrokers service method.</param>
        /// 
        /// <returns>The response from the ListBrokers service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListBrokers">REST API Reference for ListBrokers Operation</seealso>
        ListBrokersResponse ListBrokers(ListBrokersRequest request);



        /// <summary>
        /// Returns a list of all brokers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrokers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBrokers service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListBrokers">REST API Reference for ListBrokers Operation</seealso>
        Task<ListBrokersResponse> ListBrokersAsync(ListBrokersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListConfigurationRevisions


        /// <summary>
        /// Returns a list of all revisions for the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationRevisions service method.</param>
        /// 
        /// <returns>The response from the ListConfigurationRevisions service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListConfigurationRevisions">REST API Reference for ListConfigurationRevisions Operation</seealso>
        ListConfigurationRevisionsResponse ListConfigurationRevisions(ListConfigurationRevisionsRequest request);



        /// <summary>
        /// Returns a list of all revisions for the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationRevisions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigurationRevisions service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListConfigurationRevisions">REST API Reference for ListConfigurationRevisions Operation</seealso>
        Task<ListConfigurationRevisionsResponse> ListConfigurationRevisionsAsync(ListConfigurationRevisionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListConfigurations


        /// <summary>
        /// Returns a list of all configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListConfigurations service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        ListConfigurationsResponse ListConfigurations(ListConfigurationsRequest request);



        /// <summary>
        /// Returns a list of all configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigurations service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        Task<ListConfigurationsResponse> ListConfigurationsAsync(ListConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse ListTags(ListTagsRequest request);



        /// <summary>
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListTags">REST API Reference for ListTags Operation</seealso>
        Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUsers


        /// <summary>
        /// Returns a list of all ActiveMQ users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse ListUsers(ListUsersRequest request);



        /// <summary>
        /// Returns a list of all ActiveMQ users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListUsers">REST API Reference for ListUsers Operation</seealso>
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  Promote


        /// <summary>
        /// Promotes a data replication replica broker to the primary broker role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Promote service method.</param>
        /// 
        /// <returns>The response from the Promote service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/Promote">REST API Reference for Promote Operation</seealso>
        PromoteResponse Promote(PromoteRequest request);



        /// <summary>
        /// Promotes a data replication replica broker to the primary broker role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Promote service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Promote service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/Promote">REST API Reference for Promote Operation</seealso>
        Task<PromoteResponse> PromoteAsync(PromoteRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RebootBroker


        /// <summary>
        /// Reboots a broker. Note: This API is asynchronous.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootBroker service method.</param>
        /// 
        /// <returns>The response from the RebootBroker service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/RebootBroker">REST API Reference for RebootBroker Operation</seealso>
        RebootBrokerResponse RebootBroker(RebootBrokerRequest request);



        /// <summary>
        /// Reboots a broker. Note: This API is asynchronous.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootBroker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootBroker service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/RebootBroker">REST API Reference for RebootBroker Operation</seealso>
        Task<RebootBrokerResponse> RebootBrokerAsync(RebootBrokerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateBroker


        /// <summary>
        /// Adds a pending configuration change to a broker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBroker service method.</param>
        /// 
        /// <returns>The response from the UpdateBroker service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/UpdateBroker">REST API Reference for UpdateBroker Operation</seealso>
        UpdateBrokerResponse UpdateBroker(UpdateBrokerRequest request);



        /// <summary>
        /// Adds a pending configuration change to a broker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBroker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBroker service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/UpdateBroker">REST API Reference for UpdateBroker Operation</seealso>
        Task<UpdateBrokerResponse> UpdateBrokerAsync(UpdateBrokerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateConfiguration


        /// <summary>
        /// Updates the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateConfiguration service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/UpdateConfiguration">REST API Reference for UpdateConfiguration Operation</seealso>
        UpdateConfigurationResponse UpdateConfiguration(UpdateConfigurationRequest request);



        /// <summary>
        /// Updates the specified configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfiguration service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/UpdateConfiguration">REST API Reference for UpdateConfiguration Operation</seealso>
        Task<UpdateConfigurationResponse> UpdateConfigurationAsync(UpdateConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUser


        /// <summary>
        /// Updates the information for an ActiveMQ user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse UpdateUser(UpdateUserRequest request);



        /// <summary>
        /// Updates the information for an ActiveMQ user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by MQ.</returns>
        /// <exception cref="Amazon.MQ.Model.BadRequestException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ConflictException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.ForbiddenException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.InternalServerErrorException">
        /// Returns information about an error.
        /// </exception>
        /// <exception cref="Amazon.MQ.Model.NotFoundException">
        /// Returns information about an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

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