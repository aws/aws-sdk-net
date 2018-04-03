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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */

using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Lambda.Model;

namespace Amazon.Lambda
{
    /// <summary>
    /// Interface for accessing Lambda
    ///
    /// AWS Lambda 
    /// <para>
    ///  <b>Overview</b> 
    /// </para>
    ///  
    /// <para>
    /// This is the <i>AWS Lambda API Reference</i>. The AWS Lambda Developer Guide provides
    /// additional information. For the service overview, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/welcome.html">What
    /// is AWS Lambda</a>, and for information about how the service works, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/lambda-introduction.html">AWS
    /// Lambda: How it Works</a> in the <b>AWS Lambda Developer Guide</b>.
    /// </para>
    /// </summary>
    public partial interface IAmazonLambda : IAmazonService, IDisposable
    {

        
        #region  AddPermission


        /// <summary>
        /// Initiates the asynchronous execution of the AddPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddPermission operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/AddPermission">REST API Reference for AddPermission Operation</seealso>
        void AddPermissionAsync(AddPermissionRequest request, AmazonServiceCallback<AddPermissionRequest, AddPermissionResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateAlias


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        void CreateAliasAsync(CreateAliasRequest request, AmazonServiceCallback<CreateAliasRequest, CreateAliasResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateEventSourceMapping


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSourceMapping operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateEventSourceMapping">REST API Reference for CreateEventSourceMapping Operation</seealso>
        void CreateEventSourceMappingAsync(CreateEventSourceMappingRequest request, AmazonServiceCallback<CreateEventSourceMappingRequest, CreateEventSourceMappingResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateFunction


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFunction operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        void CreateFunctionAsync(CreateFunctionRequest request, AmazonServiceCallback<CreateFunctionRequest, CreateFunctionResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteAlias


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        void DeleteAliasAsync(DeleteAliasRequest request, AmazonServiceCallback<DeleteAliasRequest, DeleteAliasResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteEventSourceMapping


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSourceMapping operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSourceMapping operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteEventSourceMapping">REST API Reference for DeleteEventSourceMapping Operation</seealso>
        void DeleteEventSourceMappingAsync(DeleteEventSourceMappingRequest request, AmazonServiceCallback<DeleteEventSourceMappingRequest, DeleteEventSourceMappingResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteFunction


        /// <summary>
        /// Deletes the specified Lambda function code and configuration.
        /// 
        ///  
        /// <para>
        /// If you are using the versioning feature and you don't specify a function version in
        /// your <code>DeleteFunction</code> request, AWS Lambda will delete the function, including
        /// all its versions, and any aliases pointing to the function versions. To delete a specific
        /// function version, you must provide the function version via the <code>Qualifier</code>
        /// parameter. For information about function versioning, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>. 
        /// </para>
        ///  
        /// <para>
        /// When you delete a function the associated resource policy is also deleted. You will
        /// need to delete the event source mappings explicitly.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:DeleteFunction</code> action.
        /// </para>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="functionName">The Lambda function to delete.  You can specify the function name (for example, <code>Thumbnail</code>) or you can specify Amazon Resource Name (ARN) of the function (for example, <code>arn:aws:lambda:us-west-2:account-id:function:ThumbNail</code>). If you are using versioning, you can also provide a qualified function ARN (ARN that is qualified with function version or alias name as suffix). AWS Lambda also allows you to specify only the function name with the account ID qualifier (for example, <code>account-id:Thumbnail</code>). Note that the length constraint applies only to the ARN. If you specify only the function name, it is limited to 64 characters in length. </param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceConflictException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        void DeleteFunctionAsync(string functionName,  AmazonServiceCallback<DeleteFunctionRequest, DeleteFunctionResponse> callback, AsyncOptions options = null);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFunction operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        void DeleteFunctionAsync(DeleteFunctionRequest request, AmazonServiceCallback<DeleteFunctionRequest, DeleteFunctionResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteFunctionConcurrency


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFunctionConcurrency operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunctionConcurrency operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/DeleteFunctionConcurrency">REST API Reference for DeleteFunctionConcurrency Operation</seealso>
        void DeleteFunctionConcurrencyAsync(DeleteFunctionConcurrencyRequest request, AmazonServiceCallback<DeleteFunctionConcurrencyRequest, DeleteFunctionConcurrencyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetAccountSettings


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        void GetAccountSettingsAsync(GetAccountSettingsRequest request, AmazonServiceCallback<GetAccountSettingsRequest, GetAccountSettingsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetAlias


        /// <summary>
        /// Initiates the asynchronous execution of the GetAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAlias operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetAlias">REST API Reference for GetAlias Operation</seealso>
        void GetAliasAsync(GetAliasRequest request, AmazonServiceCallback<GetAliasRequest, GetAliasResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetEventSourceMapping


        /// <summary>
        /// Initiates the asynchronous execution of the GetEventSourceMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventSourceMapping operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetEventSourceMapping">REST API Reference for GetEventSourceMapping Operation</seealso>
        void GetEventSourceMappingAsync(GetEventSourceMappingRequest request, AmazonServiceCallback<GetEventSourceMappingRequest, GetEventSourceMappingResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetFunction


        /// <summary>
        /// Returns the configuration information of the Lambda function and a presigned URL link
        /// to the .zip file you uploaded with <a>CreateFunction</a> so you can download the .zip
        /// file. Note that the URL is valid for up to 10 minutes. The configuration information
        /// is the same information you provided as parameters when uploading the function.
        /// 
        ///  
        /// <para>
        /// Using the optional <code>Qualifier</code> parameter, you can specify a specific function
        /// version for which you want this information. If you don't specify this parameter,
        /// the API uses unqualified function ARN which return information about the <code>$LATEST</code>
        /// version of the Lambda function. For more information, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:GetFunction</code> action.
        /// </para>
        /// </summary>
        /// <param name="functionName">The Lambda function name.  You can specify a function name (for example, <code>Thumbnail</code>) or you can specify Amazon Resource Name (ARN) of the function (for example, <code>arn:aws:lambda:us-west-2:account-id:function:ThumbNail</code>). AWS Lambda also allows you to specify a partial ARN (for example, <code>account-id:Thumbnail</code>). Note that the length constraint applies only to the ARN. If you specify only the function name, it is limited to 64 characters in length. </param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetFunction service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        void GetFunctionAsync(string functionName,  AmazonServiceCallback<GetFunctionRequest, GetFunctionResponse> callback, AsyncOptions options = null);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunction operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunction">REST API Reference for GetFunction Operation</seealso>
        void GetFunctionAsync(GetFunctionRequest request, AmazonServiceCallback<GetFunctionRequest, GetFunctionResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetFunctionConfiguration


        /// <summary>
        /// Returns the configuration information of the Lambda function. This the same information
        /// you provided as parameters when uploading the function by using <a>CreateFunction</a>.
        /// 
        ///  
        /// <para>
        /// If you are using the versioning feature, you can retrieve this information for a specific
        /// function version by using the optional <code>Qualifier</code> parameter and specifying
        /// the function version or alias that points to it. If you don't provide it, the API
        /// returns information about the $LATEST version of the function. For more information
        /// about versioning, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS
        /// Lambda Function Versioning and Aliases</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>lambda:GetFunctionConfiguration</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="functionName">The name of the Lambda function for which you want to retrieve the configuration information.  You can specify a function name (for example, <code>Thumbnail</code>) or you can specify Amazon Resource Name (ARN) of the function (for example, <code>arn:aws:lambda:us-west-2:account-id:function:ThumbNail</code>). AWS Lambda also allows you to specify a partial ARN (for example, <code>account-id:Thumbnail</code>). Note that the length constraint applies only to the ARN. If you specify only the function name, it is limited to 64 characters in length. </param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetFunctionConfiguration service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ResourceNotFoundException">
        /// The resource (for example, a Lambda function or access policy statement) specified
        /// in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConfiguration">REST API Reference for GetFunctionConfiguration Operation</seealso>
        void GetFunctionConfigurationAsync(string functionName,  AmazonServiceCallback<GetFunctionConfigurationRequest, GetFunctionConfigurationResponse> callback, AsyncOptions options = null);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFunctionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionConfiguration operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetFunctionConfiguration">REST API Reference for GetFunctionConfiguration Operation</seealso>
        void GetFunctionConfigurationAsync(GetFunctionConfigurationRequest request, AmazonServiceCallback<GetFunctionConfigurationRequest, GetFunctionConfigurationResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        void GetPolicyAsync(GetPolicyRequest request, AmazonServiceCallback<GetPolicyRequest, GetPolicyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  Invoke


        /// <summary>
        /// Initiates the asynchronous execution of the Invoke operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Invoke operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/Invoke">REST API Reference for Invoke Operation</seealso>
        void InvokeAsync(InvokeRequest request, AmazonServiceCallback<InvokeRequest, InvokeResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  InvokeAsync


        /// <summary>
        /// Initiates the asynchronous execution of the InvokeAsync operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeAsync operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/InvokeAsync">REST API Reference for InvokeAsync Operation</seealso>
        [Obsolete("This API is deprecated. We recommend that you use Invoke API instead.")]
        void InvokeAsyncAsync(InvokeAsyncRequest request, AmazonServiceCallback<InvokeAsyncRequest, InvokeAsyncResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListAliases


        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListAliases">REST API Reference for ListAliases Operation</seealso>
        void ListAliasesAsync(ListAliasesRequest request, AmazonServiceCallback<ListAliasesRequest, ListAliasesResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListEventSourceMappings


        /// <summary>
        /// Initiates the asynchronous execution of the ListEventSourceMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventSourceMappings operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListEventSourceMappings">REST API Reference for ListEventSourceMappings Operation</seealso>
        void ListEventSourceMappingsAsync(ListEventSourceMappingsRequest request, AmazonServiceCallback<ListEventSourceMappingsRequest, ListEventSourceMappingsResponse> callback, AsyncOptions options = null);


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
        ///  
        /// <para>
        /// If you are using the versioning feature, you can list all of your functions or only
        /// <code>$LATEST</code> versions. For information about the versioning feature, see <a
        /// href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS Lambda
        /// Function Versioning and Aliases</a>. 
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the ListFunctions service method, as returned by Lambda.</returns>
        /// <exception cref="Amazon.Lambda.Model.InvalidParameterValueException">
        /// One of the parameters in the request is invalid. For example, if you provided an IAM
        /// role for AWS Lambda to assume in the <code>CreateFunction</code> or the <code>UpdateFunctionConfiguration</code>
        /// API, that AWS Lambda is unable to assume you will get this exception.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.ServiceException">
        /// The AWS Lambda service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.Lambda.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        void ListFunctionsAsync( AmazonServiceCallback<ListFunctionsRequest, ListFunctionsResponse> callback, AsyncOptions options = null);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFunctions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        void ListFunctionsAsync(ListFunctionsRequest request, AmazonServiceCallback<ListFunctionsRequest, ListFunctionsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListTags


        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListTags">REST API Reference for ListTags Operation</seealso>
        void ListTagsAsync(ListTagsRequest request, AmazonServiceCallback<ListTagsRequest, ListTagsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListVersionsByFunction


        /// <summary>
        /// Initiates the asynchronous execution of the ListVersionsByFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVersionsByFunction operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/ListVersionsByFunction">REST API Reference for ListVersionsByFunction Operation</seealso>
        void ListVersionsByFunctionAsync(ListVersionsByFunctionRequest request, AmazonServiceCallback<ListVersionsByFunctionRequest, ListVersionsByFunctionResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  PublishVersion


        /// <summary>
        /// Initiates the asynchronous execution of the PublishVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PublishVersion operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PublishVersion">REST API Reference for PublishVersion Operation</seealso>
        void PublishVersionAsync(PublishVersionRequest request, AmazonServiceCallback<PublishVersionRequest, PublishVersionResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  PutFunctionConcurrency


        /// <summary>
        /// Initiates the asynchronous execution of the PutFunctionConcurrency operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutFunctionConcurrency operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/PutFunctionConcurrency">REST API Reference for PutFunctionConcurrency Operation</seealso>
        void PutFunctionConcurrencyAsync(PutFunctionConcurrencyRequest request, AmazonServiceCallback<PutFunctionConcurrencyRequest, PutFunctionConcurrencyResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  RemovePermission


        /// <summary>
        /// Initiates the asynchronous execution of the RemovePermission operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        void RemovePermissionAsync(RemovePermissionRequest request, AmazonServiceCallback<RemovePermissionRequest, RemovePermissionResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  TagResource


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        void TagResourceAsync(TagResourceRequest request, AmazonServiceCallback<TagResourceRequest, TagResourceResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        void UntagResourceAsync(UntagResourceRequest request, AmazonServiceCallback<UntagResourceRequest, UntagResourceResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateAlias


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAlias operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        void UpdateAliasAsync(UpdateAliasRequest request, AmazonServiceCallback<UpdateAliasRequest, UpdateAliasResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateEventSourceMapping


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventSourceMapping operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventSourceMapping operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateEventSourceMapping">REST API Reference for UpdateEventSourceMapping Operation</seealso>
        void UpdateEventSourceMappingAsync(UpdateEventSourceMappingRequest request, AmazonServiceCallback<UpdateEventSourceMappingRequest, UpdateEventSourceMappingResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateFunctionCode


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFunctionCode operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionCode operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionCode">REST API Reference for UpdateFunctionCode Operation</seealso>
        void UpdateFunctionCodeAsync(UpdateFunctionCodeRequest request, AmazonServiceCallback<UpdateFunctionCodeRequest, UpdateFunctionCodeResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateFunctionConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFunctionConfiguration operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionConfiguration operation on AmazonLambdaClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-2015-03-31/UpdateFunctionConfiguration">REST API Reference for UpdateFunctionConfiguration Operation</seealso>
        void UpdateFunctionConfigurationAsync(UpdateFunctionConfigurationRequest request, AmazonServiceCallback<UpdateFunctionConfigurationRequest, UpdateFunctionConfigurationResponse> callback, AsyncOptions options = null);


        #endregion
        
    }
}