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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MQ.Model;

namespace Amazon.MQ
{
    /// <summary>
    /// Interface for accessing MQ
    ///
    /// Amazon MQ is a managed message broker service for Apache ActiveMQ that makes it easy
    /// to set up and operate message brokers in the cloud. A message broker allows software
    /// applications and components to communicate using various programming languages, operating
    /// systems, and formal messaging protocols.
    /// </summary>
    public partial interface IAmazonMQ : IAmazonService, IDisposable
    {

        
        #region  CreateBroker


        /// <summary>
        /// Creates a broker. Note: This API is asynchronous.
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
        /// Initiates the asynchronous execution of the CreateBroker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBroker operation on AmazonMQClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBroker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateBroker">REST API Reference for CreateBroker Operation</seealso>
        IAsyncResult BeginCreateBroker(CreateBrokerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBroker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBroker.</param>
        /// 
        /// <returns>Returns a  CreateBrokerResult from MQ.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateBroker">REST API Reference for CreateBroker Operation</seealso>
        CreateBrokerResponse EndCreateBroker(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguration operation on AmazonMQClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateConfiguration">REST API Reference for CreateConfiguration Operation</seealso>
        IAsyncResult BeginCreateConfiguration(CreateConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateConfigurationResult from MQ.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateConfiguration">REST API Reference for CreateConfiguration Operation</seealso>
        CreateConfigurationResponse EndCreateConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUser


        /// <summary>
        /// Creates an ActiveMQ user.
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
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonMQClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateUser">REST API Reference for CreateUser Operation</seealso>
        IAsyncResult BeginCreateUser(CreateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a  CreateUserResult from MQ.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse EndCreateUser(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteBroker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBroker operation on AmazonMQClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBroker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DeleteBroker">REST API Reference for DeleteBroker Operation</seealso>
        IAsyncResult BeginDeleteBroker(DeleteBrokerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBroker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBroker.</param>
        /// 
        /// <returns>Returns a  DeleteBrokerResult from MQ.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DeleteBroker">REST API Reference for DeleteBroker Operation</seealso>
        DeleteBrokerResponse EndDeleteBroker(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonMQClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from MQ.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeBroker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBroker operation on AmazonMQClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBroker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeBroker">REST API Reference for DescribeBroker Operation</seealso>
        IAsyncResult BeginDescribeBroker(DescribeBrokerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBroker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBroker.</param>
        /// 
        /// <returns>Returns a  DescribeBrokerResult from MQ.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeBroker">REST API Reference for DescribeBroker Operation</seealso>
        DescribeBrokerResponse EndDescribeBroker(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfiguration operation on AmazonMQClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeConfiguration">REST API Reference for DescribeConfiguration Operation</seealso>
        IAsyncResult BeginDescribeConfiguration(DescribeConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationResult from MQ.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeConfiguration">REST API Reference for DescribeConfiguration Operation</seealso>
        DescribeConfigurationResponse EndDescribeConfiguration(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeConfigurationRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRevision operation on AmazonMQClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigurationRevision
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeConfigurationRevision">REST API Reference for DescribeConfigurationRevision Operation</seealso>
        IAsyncResult BeginDescribeConfigurationRevision(DescribeConfigurationRevisionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigurationRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationRevision.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationRevisionResult from MQ.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeConfigurationRevision">REST API Reference for DescribeConfigurationRevision Operation</seealso>
        DescribeConfigurationRevisionResponse EndDescribeConfigurationRevision(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser operation on AmazonMQClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        IAsyncResult BeginDescribeUser(DescribeUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUser.</param>
        /// 
        /// <returns>Returns a  DescribeUserResult from MQ.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        DescribeUserResponse EndDescribeUser(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListBrokers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBrokers operation on AmazonMQClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBrokers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListBrokers">REST API Reference for ListBrokers Operation</seealso>
        IAsyncResult BeginListBrokers(ListBrokersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBrokers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBrokers.</param>
        /// 
        /// <returns>Returns a  ListBrokersResult from MQ.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListBrokers">REST API Reference for ListBrokers Operation</seealso>
        ListBrokersResponse EndListBrokers(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListConfigurationRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationRevisions operation on AmazonMQClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurationRevisions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListConfigurationRevisions">REST API Reference for ListConfigurationRevisions Operation</seealso>
        IAsyncResult BeginListConfigurationRevisions(ListConfigurationRevisionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurationRevisions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurationRevisions.</param>
        /// 
        /// <returns>Returns a  ListConfigurationRevisionsResult from MQ.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListConfigurationRevisions">REST API Reference for ListConfigurationRevisions Operation</seealso>
        ListConfigurationRevisionsResponse EndListConfigurationRevisions(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations operation on AmazonMQClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        IAsyncResult BeginListConfigurations(ListConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfigurations.</param>
        /// 
        /// <returns>Returns a  ListConfigurationsResult from MQ.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListConfigurations">REST API Reference for ListConfigurations Operation</seealso>
        ListConfigurationsResponse EndListConfigurations(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonMQClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListUsers">REST API Reference for ListUsers Operation</seealso>
        IAsyncResult BeginListUsers(ListUsersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a  ListUsersResult from MQ.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse EndListUsers(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the RebootBroker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootBroker operation on AmazonMQClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootBroker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/RebootBroker">REST API Reference for RebootBroker Operation</seealso>
        IAsyncResult BeginRebootBroker(RebootBrokerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RebootBroker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootBroker.</param>
        /// 
        /// <returns>Returns a  RebootBrokerResult from MQ.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/RebootBroker">REST API Reference for RebootBroker Operation</seealso>
        RebootBrokerResponse EndRebootBroker(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateBroker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBroker operation on AmazonMQClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBroker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/UpdateBroker">REST API Reference for UpdateBroker Operation</seealso>
        IAsyncResult BeginUpdateBroker(UpdateBrokerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBroker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBroker.</param>
        /// 
        /// <returns>Returns a  UpdateBrokerResult from MQ.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/UpdateBroker">REST API Reference for UpdateBroker Operation</seealso>
        UpdateBrokerResponse EndUpdateBroker(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguration operation on AmazonMQClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/UpdateConfiguration">REST API Reference for UpdateConfiguration Operation</seealso>
        IAsyncResult BeginUpdateConfiguration(UpdateConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateConfigurationResult from MQ.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/UpdateConfiguration">REST API Reference for UpdateConfiguration Operation</seealso>
        UpdateConfigurationResponse EndUpdateConfiguration(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonMQClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        IAsyncResult BeginUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        /// 
        /// <returns>Returns a  UpdateUserResult from MQ.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mq-2017-11-27/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult);

        #endregion
        
    }
}