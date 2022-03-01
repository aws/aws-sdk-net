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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.KafkaConnect.Model;

namespace Amazon.KafkaConnect
{
    /// <summary>
    /// Interface for accessing KafkaConnect
    ///
    /// 
    /// </summary>
    public partial interface IAmazonKafkaConnect : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IKafkaConnectPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateConnector


        /// <summary>
        /// Creates a connector using the specified properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector service method.</param>
        /// 
        /// <returns>The response from the CreateConnector service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ConflictException">
        /// HTTP Status Code 409: Conflict. A resource with this name already exists. Retry your
        /// request with another name.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        CreateConnectorResponse CreateConnector(CreateConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector operation on AmazonKafkaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        IAsyncResult BeginCreateConnector(CreateConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnector.</param>
        /// 
        /// <returns>Returns a  CreateConnectorResult from KafkaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        CreateConnectorResponse EndCreateConnector(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCustomPlugin


        /// <summary>
        /// Creates a custom plugin using the specified properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomPlugin service method.</param>
        /// 
        /// <returns>The response from the CreateCustomPlugin service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ConflictException">
        /// HTTP Status Code 409: Conflict. A resource with this name already exists. Retry your
        /// request with another name.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/CreateCustomPlugin">REST API Reference for CreateCustomPlugin Operation</seealso>
        CreateCustomPluginResponse CreateCustomPlugin(CreateCustomPluginRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomPlugin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomPlugin operation on AmazonKafkaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomPlugin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/CreateCustomPlugin">REST API Reference for CreateCustomPlugin Operation</seealso>
        IAsyncResult BeginCreateCustomPlugin(CreateCustomPluginRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomPlugin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomPlugin.</param>
        /// 
        /// <returns>Returns a  CreateCustomPluginResult from KafkaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/CreateCustomPlugin">REST API Reference for CreateCustomPlugin Operation</seealso>
        CreateCustomPluginResponse EndCreateCustomPlugin(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorkerConfiguration


        /// <summary>
        /// Creates a worker configuration using the specified properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkerConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateWorkerConfiguration service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ConflictException">
        /// HTTP Status Code 409: Conflict. A resource with this name already exists. Retry your
        /// request with another name.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/CreateWorkerConfiguration">REST API Reference for CreateWorkerConfiguration Operation</seealso>
        CreateWorkerConfigurationResponse CreateWorkerConfiguration(CreateWorkerConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkerConfiguration operation on AmazonKafkaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkerConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/CreateWorkerConfiguration">REST API Reference for CreateWorkerConfiguration Operation</seealso>
        IAsyncResult BeginCreateWorkerConfiguration(CreateWorkerConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkerConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateWorkerConfigurationResult from KafkaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/CreateWorkerConfiguration">REST API Reference for CreateWorkerConfiguration Operation</seealso>
        CreateWorkerConfigurationResponse EndCreateWorkerConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConnector


        /// <summary>
        /// Deletes the specified connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector service method.</param>
        /// 
        /// <returns>The response from the DeleteConnector service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        DeleteConnectorResponse DeleteConnector(DeleteConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector operation on AmazonKafkaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        IAsyncResult BeginDeleteConnector(DeleteConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnector.</param>
        /// 
        /// <returns>Returns a  DeleteConnectorResult from KafkaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        DeleteConnectorResponse EndDeleteConnector(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCustomPlugin


        /// <summary>
        /// Deletes a custom plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomPlugin service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomPlugin service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DeleteCustomPlugin">REST API Reference for DeleteCustomPlugin Operation</seealso>
        DeleteCustomPluginResponse DeleteCustomPlugin(DeleteCustomPluginRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomPlugin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomPlugin operation on AmazonKafkaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomPlugin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DeleteCustomPlugin">REST API Reference for DeleteCustomPlugin Operation</seealso>
        IAsyncResult BeginDeleteCustomPlugin(DeleteCustomPluginRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomPlugin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomPlugin.</param>
        /// 
        /// <returns>Returns a  DeleteCustomPluginResult from KafkaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DeleteCustomPlugin">REST API Reference for DeleteCustomPlugin Operation</seealso>
        DeleteCustomPluginResponse EndDeleteCustomPlugin(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeConnector


        /// <summary>
        /// Returns summary information about the connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnector service method.</param>
        /// 
        /// <returns>The response from the DescribeConnector service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeConnector">REST API Reference for DescribeConnector Operation</seealso>
        DescribeConnectorResponse DescribeConnector(DescribeConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnector operation on AmazonKafkaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeConnector">REST API Reference for DescribeConnector Operation</seealso>
        IAsyncResult BeginDescribeConnector(DescribeConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnector.</param>
        /// 
        /// <returns>Returns a  DescribeConnectorResult from KafkaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeConnector">REST API Reference for DescribeConnector Operation</seealso>
        DescribeConnectorResponse EndDescribeConnector(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCustomPlugin


        /// <summary>
        /// A summary description of the custom plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomPlugin service method.</param>
        /// 
        /// <returns>The response from the DescribeCustomPlugin service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeCustomPlugin">REST API Reference for DescribeCustomPlugin Operation</seealso>
        DescribeCustomPluginResponse DescribeCustomPlugin(DescribeCustomPluginRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomPlugin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomPlugin operation on AmazonKafkaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCustomPlugin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeCustomPlugin">REST API Reference for DescribeCustomPlugin Operation</seealso>
        IAsyncResult BeginDescribeCustomPlugin(DescribeCustomPluginRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCustomPlugin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCustomPlugin.</param>
        /// 
        /// <returns>Returns a  DescribeCustomPluginResult from KafkaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeCustomPlugin">REST API Reference for DescribeCustomPlugin Operation</seealso>
        DescribeCustomPluginResponse EndDescribeCustomPlugin(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeWorkerConfiguration


        /// <summary>
        /// Returns information about a worker configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkerConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkerConfiguration service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeWorkerConfiguration">REST API Reference for DescribeWorkerConfiguration Operation</seealso>
        DescribeWorkerConfigurationResponse DescribeWorkerConfiguration(DescribeWorkerConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkerConfiguration operation on AmazonKafkaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkerConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeWorkerConfiguration">REST API Reference for DescribeWorkerConfiguration Operation</seealso>
        IAsyncResult BeginDescribeWorkerConfiguration(DescribeWorkerConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkerConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeWorkerConfigurationResult from KafkaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeWorkerConfiguration">REST API Reference for DescribeWorkerConfiguration Operation</seealso>
        DescribeWorkerConfigurationResponse EndDescribeWorkerConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConnectors


        /// <summary>
        /// Returns a list of all the connectors in this account and Region. The list is limited
        /// to connectors whose name starts with the specified prefix. The response also includes
        /// a description of each of the listed connectors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors service method.</param>
        /// 
        /// <returns>The response from the ListConnectors service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        ListConnectorsResponse ListConnectors(ListConnectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConnectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors operation on AmazonKafkaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        IAsyncResult BeginListConnectors(ListConnectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnectors.</param>
        /// 
        /// <returns>Returns a  ListConnectorsResult from KafkaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        ListConnectorsResponse EndListConnectors(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCustomPlugins


        /// <summary>
        /// Returns a list of all of the custom plugins in this account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomPlugins service method.</param>
        /// 
        /// <returns>The response from the ListCustomPlugins service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListCustomPlugins">REST API Reference for ListCustomPlugins Operation</seealso>
        ListCustomPluginsResponse ListCustomPlugins(ListCustomPluginsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomPlugins operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomPlugins operation on AmazonKafkaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomPlugins
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListCustomPlugins">REST API Reference for ListCustomPlugins Operation</seealso>
        IAsyncResult BeginListCustomPlugins(ListCustomPluginsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomPlugins operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomPlugins.</param>
        /// 
        /// <returns>Returns a  ListCustomPluginsResult from KafkaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListCustomPlugins">REST API Reference for ListCustomPlugins Operation</seealso>
        ListCustomPluginsResponse EndListCustomPlugins(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkerConfigurations


        /// <summary>
        /// Returns a list of all of the worker configurations in this account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkerConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListWorkerConfigurations service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListWorkerConfigurations">REST API Reference for ListWorkerConfigurations Operation</seealso>
        ListWorkerConfigurationsResponse ListWorkerConfigurations(ListWorkerConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkerConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkerConfigurations operation on AmazonKafkaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkerConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListWorkerConfigurations">REST API Reference for ListWorkerConfigurations Operation</seealso>
        IAsyncResult BeginListWorkerConfigurations(ListWorkerConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkerConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkerConfigurations.</param>
        /// 
        /// <returns>Returns a  ListWorkerConfigurationsResult from KafkaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListWorkerConfigurations">REST API Reference for ListWorkerConfigurations Operation</seealso>
        ListWorkerConfigurationsResponse EndListWorkerConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConnector


        /// <summary>
        /// Updates the specified connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnector service method.</param>
        /// 
        /// <returns>The response from the UpdateConnector service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/UpdateConnector">REST API Reference for UpdateConnector Operation</seealso>
        UpdateConnectorResponse UpdateConnector(UpdateConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnector operation on AmazonKafkaConnectClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/UpdateConnector">REST API Reference for UpdateConnector Operation</seealso>
        IAsyncResult BeginUpdateConnector(UpdateConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnector.</param>
        /// 
        /// <returns>Returns a  UpdateConnectorResult from KafkaConnect.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/UpdateConnector">REST API Reference for UpdateConnector Operation</seealso>
        UpdateConnectorResponse EndUpdateConnector(IAsyncResult asyncResult);

        #endregion
        
    }
}