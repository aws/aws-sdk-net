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
 * Do not modify this file. This file is generated from the lambda-2014-11-11.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Lambda.Model;

namespace Amazon.Lambda
{
    /// <summary>
    /// Interface for accessing Lambda
    ///
    /// AWS Lambda 
    /// <para>
    /// <b>Overview</b>
    /// </para>
    ///  
    /// <para>
    /// This is the AWS Lambda API Reference. The AWS Lambda Developer Guide provides additional
    /// information. For the service overview, go to <a href="http://docs.aws.amazon.com/lambda/latest/dg/welcome.html">What
    /// is AWS Lambda</a>, and for information about how the service works, go to <a href="http://docs.aws.amazon.com/lambda/latest/dg/lambda-introduction.html">AWS
    /// LambdaL How it Works</a> in the AWS Lambda Developer Guide.
    /// </para>
    /// </summary>
    public partial interface IAmazonLambda : IDisposable
    {

        
        #region  AddEventSource

        /// <summary>
        /// Identifies an Amazon Kinesis stream as the event source for an AWS Lambda function.
        /// AWS Lambda invokes the specified function when records are posted to the stream.
        /// 
        ///  
        /// <para>
        /// This is the pull model, where AWS Lambda invokes the function. For more information,
        /// go to <a href="http://docs.aws.amazon.com/lambda/latest/dg/lambda-introduction.html">AWS
        /// LambdaL How it Works</a> in the AWS Lambda Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// This association between an Amazon Kinesis stream and an AWS Lambda function is called
        /// the event source mapping. You provide the configuration information (for example,
        /// which stream to read from and which AWS Lambda function to invoke) for the event source
        /// mapping in the request body.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>iam:PassRole</code> action for the
        /// IAM role. It also requires permission for the <code>lambda:AddEventSource</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddEventSource service method.</param>
        /// 
        /// <returns>The response from the AddEventSource service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>UploadFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        AddEventSourceResponse AddEventSource(AddEventSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddEventSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddEventSource operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddEventSource
        ///         operation.</returns>
        IAsyncResult BeginAddEventSource(AddEventSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddEventSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddEventSource.</param>
        /// 
        /// <returns>Returns a  AddEventSourceResult from Lambda.</returns>
        AddEventSourceResponse EndAddEventSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFunction

        /// <summary>
        /// Deletes the specified Lambda function code and configuration.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:DeleteFunction</code> action.
        /// </para>
        /// </summary>
        /// <param name="functionName">The Lambda function to delete.</param>
        /// 
        /// <returns>The response from the DeleteFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The function or the event source specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        DeleteFunctionResponse DeleteFunction(string functionName);

        /// <summary>
        /// Deletes the specified Lambda function code and configuration.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:DeleteFunction</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction service method.</param>
        /// 
        /// <returns>The response from the DeleteFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The function or the event source specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        DeleteFunctionResponse DeleteFunction(DeleteFunctionRequest request);

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
        IAsyncResult BeginDeleteFunction(DeleteFunctionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFunction.</param>
        /// 
        /// <returns>Returns a  DeleteFunctionResult from Lambda.</returns>
        DeleteFunctionResponse EndDeleteFunction(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEventSource

        /// <summary>
        /// Returns configuration information for the specified event source mapping (see <a>AddEventSource</a>).
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:GetEventSource</code> action.
        /// </para>
        /// </summary>
        /// <param name="uuid">The AWS Lambda assigned ID of the event source mapping.</param>
        /// 
        /// <returns>The response from the GetEventSource service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>UploadFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The function or the event source specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        GetEventSourceResponse GetEventSource(string uuid);

        /// <summary>
        /// Returns configuration information for the specified event source mapping (see <a>AddEventSource</a>).
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:GetEventSource</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventSource service method.</param>
        /// 
        /// <returns>The response from the GetEventSource service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>UploadFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The function or the event source specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        GetEventSourceResponse GetEventSource(GetEventSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventSource operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventSource
        ///         operation.</returns>
        IAsyncResult BeginGetEventSource(GetEventSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventSource.</param>
        /// 
        /// <returns>Returns a  GetEventSourceResult from Lambda.</returns>
        GetEventSourceResponse EndGetEventSource(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFunction

        /// <summary>
        /// Returns the configuration information of the Lambda function and a presigned URL link
        /// to the .zip file you uploaded with <a>UploadFunction</a> so you can download the .zip
        /// file. Note that the URL is valid for up to 10 minutes. The configuration information
        /// is the same information you provided as parameters when uploading the function.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:GetFunction</code> action.
        /// </para>
        /// </summary>
        /// <param name="functionName">The Lambda function name.</param>
        /// 
        /// <returns>The response from the GetFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The function or the event source specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        GetFunctionResponse GetFunction(string functionName);

        /// <summary>
        /// Returns the configuration information of the Lambda function and a presigned URL link
        /// to the .zip file you uploaded with <a>UploadFunction</a> so you can download the .zip
        /// file. Note that the URL is valid for up to 10 minutes. The configuration information
        /// is the same information you provided as parameters when uploading the function.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:GetFunction</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunction service method.</param>
        /// 
        /// <returns>The response from the GetFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The function or the event source specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        GetFunctionResponse GetFunction(GetFunctionRequest request);

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
        IAsyncResult BeginGetFunction(GetFunctionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFunction.</param>
        /// 
        /// <returns>Returns a  GetFunctionResult from Lambda.</returns>
        GetFunctionResponse EndGetFunction(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFunctionConfiguration

        /// <summary>
        /// Returns the configuration information of the Lambda function. This the same information
        /// you provided as parameters when uploading the function by using <a>UploadFunction</a>.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:GetFunctionConfiguration</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="functionName">The name of the Lambda function for which you want to retrieve the configuration information.</param>
        /// 
        /// <returns>The response from the GetFunctionConfiguration service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The function or the event source specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        GetFunctionConfigurationResponse GetFunctionConfiguration(string functionName);

        /// <summary>
        /// Returns the configuration information of the Lambda function. This the same information
        /// you provided as parameters when uploading the function by using <a>UploadFunction</a>.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:GetFunctionConfiguration</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetFunctionConfiguration service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The function or the event source specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        GetFunctionConfigurationResponse GetFunctionConfiguration(GetFunctionConfigurationRequest request);

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
        IAsyncResult BeginGetFunctionConfiguration(GetFunctionConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFunctionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFunctionConfiguration.</param>
        /// 
        /// <returns>Returns a  GetFunctionConfigurationResult from Lambda.</returns>
        GetFunctionConfigurationResponse EndGetFunctionConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  InvokeAsync

        /// <summary>
        /// Submits an invocation request to AWS Lambda. Upon receiving the request, Lambda executes
        /// the specified function asynchronously. To see the logs generated by the Lambda function
        /// execution, see the CloudWatch logs console.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:InvokeAsync</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeAsync service method.</param>
        /// 
        /// <returns>The response from the InvokeAsync service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidRequestContentException">
        /// The request body could not be parsed as JSON.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The function or the event source specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        InvokeAsyncResponse InvokeAsync(InvokeAsyncRequest request);

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
        IAsyncResult BeginInvokeAsync(InvokeAsyncRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeAsync operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeAsync.</param>
        /// 
        /// <returns>Returns a  InvokeAsyncResult from Lambda.</returns>
        InvokeAsyncResponse EndInvokeAsync(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEventSources

        /// <summary>
        /// Returns a list of event source mappings. For each mapping, the API returns configuration
        /// information (see <a>AddEventSource</a>). You can optionally specify filters to retrieve
        /// specific event source mappings.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:ListEventSources</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventSources service method.</param>
        /// 
        /// <returns>The response from the ListEventSources service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>UploadFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The function or the event source specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        ListEventSourcesResponse ListEventSources(ListEventSourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventSources operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventSources
        ///         operation.</returns>
        IAsyncResult BeginListEventSources(ListEventSourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventSources.</param>
        /// 
        /// <returns>Returns a  ListEventSourcesResult from Lambda.</returns>
        ListEventSourcesResponse EndListEventSources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFunctions

        /// <summary>
        /// Returns a list of your Lambda functions. For each function, the response includes
        /// the function configuration information. You must use <a>GetFunction</a> to retrieve
        /// the code for your function.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:ListFunctions</code> action.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListFunctions service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        ListFunctionsResponse ListFunctions();

        /// <summary>
        /// Returns a list of your Lambda functions. For each function, the response includes
        /// the function configuration information. You must use <a>GetFunction</a> to retrieve
        /// the code for your function.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:ListFunctions</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions service method.</param>
        /// 
        /// <returns>The response from the ListFunctions service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        ListFunctionsResponse ListFunctions(ListFunctionsRequest request);

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
        IAsyncResult BeginListFunctions(ListFunctionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFunctions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFunctions.</param>
        /// 
        /// <returns>Returns a  ListFunctionsResult from Lambda.</returns>
        ListFunctionsResponse EndListFunctions(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveEventSource

        /// <summary>
        /// Removes an event source mapping. This means AWS Lambda will no longer invoke the function
        /// for events in the associated source.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:RemoveEventSource</code> action.
        /// </para>
        /// </summary>
        /// <param name="uuid">The event source mapping ID.</param>
        /// 
        /// <returns>The response from the RemoveEventSource service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>UploadFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The function or the event source specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        RemoveEventSourceResponse RemoveEventSource(string uuid);

        /// <summary>
        /// Removes an event source mapping. This means AWS Lambda will no longer invoke the function
        /// for events in the associated source.
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:RemoveEventSource</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveEventSource service method.</param>
        /// 
        /// <returns>The response from the RemoveEventSource service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>UploadFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The function or the event source specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        RemoveEventSourceResponse RemoveEventSource(RemoveEventSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveEventSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveEventSource operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveEventSource
        ///         operation.</returns>
        IAsyncResult BeginRemoveEventSource(RemoveEventSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveEventSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveEventSource.</param>
        /// 
        /// <returns>Returns a  RemoveEventSourceResult from Lambda.</returns>
        RemoveEventSourceResponse EndRemoveEventSource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFunctionConfiguration

        /// <summary>
        /// Updates the configuration parameters for the specified Lambda function by using the
        /// values provided in the request. You provide only the parameters you want to change.
        /// This operation must only be used on an existing Lambda function and cannot be used
        /// to update the function's code. 
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:UpdateFunctionConfiguration</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateFunctionConfiguration service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>UploadFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The function or the event source specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        UpdateFunctionConfigurationResponse UpdateFunctionConfiguration(UpdateFunctionConfigurationRequest request);

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
        IAsyncResult BeginUpdateFunctionConfiguration(UpdateFunctionConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFunctionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFunctionConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateFunctionConfigurationResult from Lambda.</returns>
        UpdateFunctionConfigurationResponse EndUpdateFunctionConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UploadFunction

        /// <summary>
        /// Creates a new Lambda function or updates an existing function. The function metadata
        /// is created from the request parameters, and the code for the function is provided
        /// by a .zip file in the request body. If the function name already exists, the existing
        /// Lambda function is updated with the new code and metadata. 
        /// 
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:UploadFunction</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadFunction service method.</param>
        /// 
        /// <returns>The response from the UploadFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>UploadFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The function or the event source specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        UploadFunctionResponse UploadFunction(UploadFunctionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UploadFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadFunction operation on AmazonLambdaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUploadFunction
        ///         operation.</returns>
        IAsyncResult BeginUploadFunction(UploadFunctionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UploadFunction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadFunction.</param>
        /// 
        /// <returns>Returns a  UploadFunctionResult from Lambda.</returns>
        UploadFunctionResponse EndUploadFunction(IAsyncResult asyncResult);

        #endregion
        
    }
}