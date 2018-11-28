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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.KinesisAnalyticsV2.Model;

namespace Amazon.KinesisAnalyticsV2
{
    /// <summary>
    /// Interface for accessing KinesisAnalyticsV2
    ///
    /// Documentation for Kinesis Data Analytics API v2
    /// </summary>
    public partial interface IAmazonKinesisAnalyticsV2 : IAmazonService, IDisposable
    {

        
        #region  AddApplicationCloudWatchLoggingOption


        /// <summary>
        /// Adds an Amazon CloudWatch log stream to monitor application configuration errors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationCloudWatchLoggingOption service method.</param>
        /// 
        /// <returns>The response from the AddApplicationCloudWatchLoggingOption service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationCloudWatchLoggingOption">REST API Reference for AddApplicationCloudWatchLoggingOption Operation</seealso>
        AddApplicationCloudWatchLoggingOptionResponse AddApplicationCloudWatchLoggingOption(AddApplicationCloudWatchLoggingOptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddApplicationCloudWatchLoggingOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationCloudWatchLoggingOption operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddApplicationCloudWatchLoggingOption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationCloudWatchLoggingOption">REST API Reference for AddApplicationCloudWatchLoggingOption Operation</seealso>
        IAsyncResult BeginAddApplicationCloudWatchLoggingOption(AddApplicationCloudWatchLoggingOptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddApplicationCloudWatchLoggingOption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddApplicationCloudWatchLoggingOption.</param>
        /// 
        /// <returns>Returns a  AddApplicationCloudWatchLoggingOptionResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationCloudWatchLoggingOption">REST API Reference for AddApplicationCloudWatchLoggingOption Operation</seealso>
        AddApplicationCloudWatchLoggingOptionResponse EndAddApplicationCloudWatchLoggingOption(IAsyncResult asyncResult);

        #endregion
        
        #region  AddApplicationInput


        /// <summary>
        /// Adds a streaming source to your SQL-based Amazon Kinesis Data Analytics application.
        /// 
        /// 
        ///  
        /// <para>
        /// You can add a streaming source when you create an application, or you can use this
        /// operation to add a streaming source after you create an application. For more information,
        /// see <a>CreateApplication</a>.
        /// </para>
        ///  
        /// <para>
        /// Any configuration update, including adding a streaming source using this operation,
        /// results in a new version of the application. You can use the <a>DescribeApplication</a>
        /// operation to find the current application version. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationInput service method.</param>
        /// 
        /// <returns>The response from the AddApplicationInput service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.CodeValidationException">
        /// The user-provided application code (query) is not valid. This can be a simple syntax
        /// error.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationInput">REST API Reference for AddApplicationInput Operation</seealso>
        AddApplicationInputResponse AddApplicationInput(AddApplicationInputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddApplicationInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationInput operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddApplicationInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationInput">REST API Reference for AddApplicationInput Operation</seealso>
        IAsyncResult BeginAddApplicationInput(AddApplicationInputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddApplicationInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddApplicationInput.</param>
        /// 
        /// <returns>Returns a  AddApplicationInputResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationInput">REST API Reference for AddApplicationInput Operation</seealso>
        AddApplicationInputResponse EndAddApplicationInput(IAsyncResult asyncResult);

        #endregion
        
        #region  AddApplicationInputProcessingConfiguration


        /// <summary>
        /// Adds an <a>InputProcessingConfiguration</a> to an SQL-based Kinesis Data Analytics
        /// application. An input processor pre-processes records on the input stream before the
        /// application's SQL code executes. Currently, the only input processor available is
        /// <a href="https://aws.amazon.com/documentation/lambda/">AWS Lambda</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationInputProcessingConfiguration service method.</param>
        /// 
        /// <returns>The response from the AddApplicationInputProcessingConfiguration service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationInputProcessingConfiguration">REST API Reference for AddApplicationInputProcessingConfiguration Operation</seealso>
        AddApplicationInputProcessingConfigurationResponse AddApplicationInputProcessingConfiguration(AddApplicationInputProcessingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddApplicationInputProcessingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationInputProcessingConfiguration operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddApplicationInputProcessingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationInputProcessingConfiguration">REST API Reference for AddApplicationInputProcessingConfiguration Operation</seealso>
        IAsyncResult BeginAddApplicationInputProcessingConfiguration(AddApplicationInputProcessingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddApplicationInputProcessingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddApplicationInputProcessingConfiguration.</param>
        /// 
        /// <returns>Returns a  AddApplicationInputProcessingConfigurationResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationInputProcessingConfiguration">REST API Reference for AddApplicationInputProcessingConfiguration Operation</seealso>
        AddApplicationInputProcessingConfigurationResponse EndAddApplicationInputProcessingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  AddApplicationOutput


        /// <summary>
        /// Adds an external destination to your SQL-based Amazon Kinesis Data Analytics application.
        /// 
        ///  
        /// <para>
        /// If you want Kinesis Data Analytics to deliver data from an in-application stream within
        /// your application to an external destination (such as an Kinesis data stream, a Kinesis
        /// Data Firehose delivery stream, or an AWS Lambda function), you add the relevant configuration
        /// to your application using this operation. You can configure one or more outputs for
        /// your application. Each output configuration maps an in-application stream and an external
        /// destination.
        /// </para>
        ///  
        /// <para>
        ///  You can use one of the output configurations to deliver data from your in-application
        /// error stream to an external destination so that you can analyze the errors. 
        /// </para>
        ///  
        /// <para>
        ///  Any configuration update, including adding a streaming source using this operation,
        /// results in a new version of the application. You can use the <a>DescribeApplication</a>
        /// operation to find the current application version.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationOutput service method.</param>
        /// 
        /// <returns>The response from the AddApplicationOutput service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationOutput">REST API Reference for AddApplicationOutput Operation</seealso>
        AddApplicationOutputResponse AddApplicationOutput(AddApplicationOutputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddApplicationOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationOutput operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddApplicationOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationOutput">REST API Reference for AddApplicationOutput Operation</seealso>
        IAsyncResult BeginAddApplicationOutput(AddApplicationOutputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddApplicationOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddApplicationOutput.</param>
        /// 
        /// <returns>Returns a  AddApplicationOutputResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationOutput">REST API Reference for AddApplicationOutput Operation</seealso>
        AddApplicationOutputResponse EndAddApplicationOutput(IAsyncResult asyncResult);

        #endregion
        
        #region  AddApplicationReferenceDataSource


        /// <summary>
        /// Adds a reference data source to an existing SQL-based Amazon Kinesis Data Analytics
        /// application.
        /// 
        ///  
        /// <para>
        /// Kinesis Data Analytics reads reference data (that is, an Amazon S3 object) and creates
        /// an in-application table within your application. In the request, you provide the source
        /// (S3 bucket name and object key name), name of the in-application table to create,
        /// and the necessary mapping information that describes how data in an Amazon S3 object
        /// maps to columns in the resulting in-application table.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationReferenceDataSource service method.</param>
        /// 
        /// <returns>The response from the AddApplicationReferenceDataSource service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationReferenceDataSource">REST API Reference for AddApplicationReferenceDataSource Operation</seealso>
        AddApplicationReferenceDataSourceResponse AddApplicationReferenceDataSource(AddApplicationReferenceDataSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddApplicationReferenceDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationReferenceDataSource operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddApplicationReferenceDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationReferenceDataSource">REST API Reference for AddApplicationReferenceDataSource Operation</seealso>
        IAsyncResult BeginAddApplicationReferenceDataSource(AddApplicationReferenceDataSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddApplicationReferenceDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddApplicationReferenceDataSource.</param>
        /// 
        /// <returns>Returns a  AddApplicationReferenceDataSourceResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/AddApplicationReferenceDataSource">REST API Reference for AddApplicationReferenceDataSource Operation</seealso>
        AddApplicationReferenceDataSourceResponse EndAddApplicationReferenceDataSource(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateApplication


        /// <summary>
        /// Creates an Amazon Kinesis Data Analytics application. For information about creating
        /// a Kinesis Data Analytics application, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/Java/creating-app.html">Creating
        /// an Application</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// SQL is not enabled for this private beta release. Using SQL parameters (such as <a>SqlApplicationConfiguration</a>)
        /// will result in an error.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.CodeValidationException">
        /// The user-provided application code (query) is not valid. This can be a simple syntax
        /// error.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.LimitExceededException">
        /// The number of allowed resources has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateApplicationSnapshot


        /// <summary>
        /// Creates a snapshot of the application's state data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateApplicationSnapshot service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.LimitExceededException">
        /// The number of allowed resources has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/CreateApplicationSnapshot">REST API Reference for CreateApplicationSnapshot Operation</seealso>
        CreateApplicationSnapshotResponse CreateApplicationSnapshot(CreateApplicationSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplicationSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationSnapshot operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplicationSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/CreateApplicationSnapshot">REST API Reference for CreateApplicationSnapshot Operation</seealso>
        IAsyncResult BeginCreateApplicationSnapshot(CreateApplicationSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplicationSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplicationSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateApplicationSnapshotResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/CreateApplicationSnapshot">REST API Reference for CreateApplicationSnapshot Operation</seealso>
        CreateApplicationSnapshotResponse EndCreateApplicationSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApplication


        /// <summary>
        /// Deletes the specified application. Kinesis Data Analytics halts application execution
        /// and deletes the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        IAsyncResult BeginDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApplicationCloudWatchLoggingOption


        /// <summary>
        /// Deletes an Amazon CloudWatch log stream from an Amazon Kinesis Data Analytics application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationCloudWatchLoggingOption service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationCloudWatchLoggingOption service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationCloudWatchLoggingOption">REST API Reference for DeleteApplicationCloudWatchLoggingOption Operation</seealso>
        DeleteApplicationCloudWatchLoggingOptionResponse DeleteApplicationCloudWatchLoggingOption(DeleteApplicationCloudWatchLoggingOptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationCloudWatchLoggingOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationCloudWatchLoggingOption operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplicationCloudWatchLoggingOption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationCloudWatchLoggingOption">REST API Reference for DeleteApplicationCloudWatchLoggingOption Operation</seealso>
        IAsyncResult BeginDeleteApplicationCloudWatchLoggingOption(DeleteApplicationCloudWatchLoggingOptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplicationCloudWatchLoggingOption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplicationCloudWatchLoggingOption.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationCloudWatchLoggingOptionResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationCloudWatchLoggingOption">REST API Reference for DeleteApplicationCloudWatchLoggingOption Operation</seealso>
        DeleteApplicationCloudWatchLoggingOptionResponse EndDeleteApplicationCloudWatchLoggingOption(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApplicationInputProcessingConfiguration


        /// <summary>
        /// Deletes an <a>InputProcessingConfiguration</a> from an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationInputProcessingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationInputProcessingConfiguration service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationInputProcessingConfiguration">REST API Reference for DeleteApplicationInputProcessingConfiguration Operation</seealso>
        DeleteApplicationInputProcessingConfigurationResponse DeleteApplicationInputProcessingConfiguration(DeleteApplicationInputProcessingConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationInputProcessingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationInputProcessingConfiguration operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplicationInputProcessingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationInputProcessingConfiguration">REST API Reference for DeleteApplicationInputProcessingConfiguration Operation</seealso>
        IAsyncResult BeginDeleteApplicationInputProcessingConfiguration(DeleteApplicationInputProcessingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplicationInputProcessingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplicationInputProcessingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationInputProcessingConfigurationResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationInputProcessingConfiguration">REST API Reference for DeleteApplicationInputProcessingConfiguration Operation</seealso>
        DeleteApplicationInputProcessingConfigurationResponse EndDeleteApplicationInputProcessingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApplicationOutput


        /// <summary>
        /// Deletes the output destination configuration from your SQL-based Amazon Kinesis Data
        /// Analytics application's configuration. Kinesis Data Analytics will no longer write
        /// data from the corresponding in-application stream to the external output destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationOutput service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationOutput service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationOutput">REST API Reference for DeleteApplicationOutput Operation</seealso>
        DeleteApplicationOutputResponse DeleteApplicationOutput(DeleteApplicationOutputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationOutput operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplicationOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationOutput">REST API Reference for DeleteApplicationOutput Operation</seealso>
        IAsyncResult BeginDeleteApplicationOutput(DeleteApplicationOutputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplicationOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplicationOutput.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationOutputResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationOutput">REST API Reference for DeleteApplicationOutput Operation</seealso>
        DeleteApplicationOutputResponse EndDeleteApplicationOutput(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApplicationReferenceDataSource


        /// <summary>
        /// Deletes a reference data source configuration from the specified SQL-based Amazon
        /// Kinesis Data Analytics application's configuration.
        /// 
        ///  
        /// <para>
        /// If the application is running, Kinesis Data Analytics immediately removes the in-application
        /// table that you created using the <a>AddApplicationReferenceDataSource</a> operation.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationReferenceDataSource service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationReferenceDataSource service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationReferenceDataSource">REST API Reference for DeleteApplicationReferenceDataSource Operation</seealso>
        DeleteApplicationReferenceDataSourceResponse DeleteApplicationReferenceDataSource(DeleteApplicationReferenceDataSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationReferenceDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationReferenceDataSource operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplicationReferenceDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationReferenceDataSource">REST API Reference for DeleteApplicationReferenceDataSource Operation</seealso>
        IAsyncResult BeginDeleteApplicationReferenceDataSource(DeleteApplicationReferenceDataSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplicationReferenceDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplicationReferenceDataSource.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationReferenceDataSourceResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationReferenceDataSource">REST API Reference for DeleteApplicationReferenceDataSource Operation</seealso>
        DeleteApplicationReferenceDataSourceResponse EndDeleteApplicationReferenceDataSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApplicationSnapshot


        /// <summary>
        /// Deletes a snapshot of application state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationSnapshot service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationSnapshot">REST API Reference for DeleteApplicationSnapshot Operation</seealso>
        DeleteApplicationSnapshotResponse DeleteApplicationSnapshot(DeleteApplicationSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationSnapshot operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplicationSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationSnapshot">REST API Reference for DeleteApplicationSnapshot Operation</seealso>
        IAsyncResult BeginDeleteApplicationSnapshot(DeleteApplicationSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplicationSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplicationSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationSnapshotResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DeleteApplicationSnapshot">REST API Reference for DeleteApplicationSnapshot Operation</seealso>
        DeleteApplicationSnapshotResponse EndDeleteApplicationSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeApplication


        /// <summary>
        /// Returns information about a specific Amazon Kinesis Data Analytics application.
        /// 
        ///  
        /// <para>
        /// If you want to retrieve a list of all applications in your account, use the <a>ListApplications</a>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication service method.</param>
        /// 
        /// <returns>The response from the DescribeApplication service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        IAsyncResult BeginDescribeApplication(DescribeApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplication.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        DescribeApplicationResponse EndDescribeApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeApplicationSnapshot


        /// <summary>
        /// Returns information about a snapshot of application state data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationSnapshot service method.</param>
        /// 
        /// <returns>The response from the DescribeApplicationSnapshot service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DescribeApplicationSnapshot">REST API Reference for DescribeApplicationSnapshot Operation</seealso>
        DescribeApplicationSnapshotResponse DescribeApplicationSnapshot(DescribeApplicationSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationSnapshot operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApplicationSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DescribeApplicationSnapshot">REST API Reference for DescribeApplicationSnapshot Operation</seealso>
        IAsyncResult BeginDescribeApplicationSnapshot(DescribeApplicationSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApplicationSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApplicationSnapshot.</param>
        /// 
        /// <returns>Returns a  DescribeApplicationSnapshotResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DescribeApplicationSnapshot">REST API Reference for DescribeApplicationSnapshot Operation</seealso>
        DescribeApplicationSnapshotResponse EndDescribeApplicationSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  DiscoverInputSchema


        /// <summary>
        /// Infers a schema for an SQL-based Amazon Kinesis Data Analytics application by evaluating
        /// sample records on the specified streaming source (Kinesis data stream or Kinesis Data
        /// Firehose delivery stream) or Amazon S3 object. In the response, the operation returns
        /// the inferred schema and also the sample records that the operation used to infer the
        /// schema.
        /// 
        ///  
        /// <para>
        ///  You can use the inferred schema when configuring a streaming source for your application.
        /// When you create an application using the Kinesis Data Analytics console, the console
        /// uses this operation to infer a schema and show it in the console user interface. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DiscoverInputSchema service method.</param>
        /// 
        /// <returns>The response from the DiscoverInputSchema service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceProvisionedThroughputExceededException">
        /// Discovery failed to get a record from the streaming source because of the Amazon Kinesis
        /// Streams <code>ProvisionedThroughputExceededException</code>. For more information,
        /// see <a href="http://docs.aws.amazon.com/kinesis/latest/APIReference/API_GetRecords.html">GetRecords</a>
        /// in the Amazon Kinesis Streams API Reference.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.UnableToDetectSchemaException">
        /// The data format is not valid. Amazon Kinesis Data Analytics cannot detect the schema
        /// for the given streaming source.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DiscoverInputSchema">REST API Reference for DiscoverInputSchema Operation</seealso>
        DiscoverInputSchemaResponse DiscoverInputSchema(DiscoverInputSchemaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DiscoverInputSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DiscoverInputSchema operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDiscoverInputSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DiscoverInputSchema">REST API Reference for DiscoverInputSchema Operation</seealso>
        IAsyncResult BeginDiscoverInputSchema(DiscoverInputSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DiscoverInputSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDiscoverInputSchema.</param>
        /// 
        /// <returns>Returns a  DiscoverInputSchemaResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/DiscoverInputSchema">REST API Reference for DiscoverInputSchema Operation</seealso>
        DiscoverInputSchemaResponse EndDiscoverInputSchema(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplications


        /// <summary>
        /// Returns a list of Amazon Kinesis Data Analytics applications in your account. For
        /// each application, the response includes the application name, Amazon Resource Name
        /// (ARN), and status. 
        /// 
        ///  
        /// <para>
        /// If you want detailed information about a specific application, use <a>DescribeApplication</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/ListApplications">REST API Reference for ListApplications Operation</seealso>
        IAsyncResult BeginListApplications(ListApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplications.</param>
        /// 
        /// <returns>Returns a  ListApplicationsResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse EndListApplications(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplicationSnapshots


        /// <summary>
        /// Lists information about the current application snapshots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationSnapshots service method.</param>
        /// 
        /// <returns>The response from the ListApplicationSnapshots service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/ListApplicationSnapshots">REST API Reference for ListApplicationSnapshots Operation</seealso>
        ListApplicationSnapshotsResponse ListApplicationSnapshots(ListApplicationSnapshotsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplicationSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationSnapshots operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplicationSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/ListApplicationSnapshots">REST API Reference for ListApplicationSnapshots Operation</seealso>
        IAsyncResult BeginListApplicationSnapshots(ListApplicationSnapshotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplicationSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplicationSnapshots.</param>
        /// 
        /// <returns>Returns a  ListApplicationSnapshotsResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/ListApplicationSnapshots">REST API Reference for ListApplicationSnapshots Operation</seealso>
        ListApplicationSnapshotsResponse EndListApplicationSnapshots(IAsyncResult asyncResult);

        #endregion
        
        #region  StartApplication


        /// <summary>
        /// Starts the specified Amazon Kinesis Data Analytics application. After creating an
        /// application, you must exclusively call this operation to start your application.
        /// 
        ///  <note> 
        /// <para>
        /// SQL is not enabled for this private beta. Using SQL parameters (such as <a>RunConfiguration$SqlRunConfigurations</a>)
        /// will result in an error.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartApplication service method.</param>
        /// 
        /// <returns>The response from the StartApplication service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidApplicationConfigurationException">
        /// The user-provided application configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/StartApplication">REST API Reference for StartApplication Operation</seealso>
        StartApplicationResponse StartApplication(StartApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartApplication operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/StartApplication">REST API Reference for StartApplication Operation</seealso>
        IAsyncResult BeginStartApplication(StartApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartApplication.</param>
        /// 
        /// <returns>Returns a  StartApplicationResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/StartApplication">REST API Reference for StartApplication Operation</seealso>
        StartApplicationResponse EndStartApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  StopApplication


        /// <summary>
        /// Stops the application from processing data. You can stop an application only if it
        /// is in the running state. You can use the <a>DescribeApplication</a> operation to find
        /// the application state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopApplication service method.</param>
        /// 
        /// <returns>The response from the StopApplication service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/StopApplication">REST API Reference for StopApplication Operation</seealso>
        StopApplicationResponse StopApplication(StopApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopApplication operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/StopApplication">REST API Reference for StopApplication Operation</seealso>
        IAsyncResult BeginStopApplication(StopApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopApplication.</param>
        /// 
        /// <returns>Returns a  StopApplicationResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/StopApplication">REST API Reference for StopApplication Operation</seealso>
        StopApplicationResponse EndStopApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApplication


        /// <summary>
        /// Updates an existing Amazon Kinesis Data Analytics application. Using this operation,
        /// you can update application code, input configuration, and output configuration. 
        /// 
        ///  
        /// <para>
        /// Kinesis Data Analytics updates the <code>ApplicationVersionId</code> each time you
        /// update your application. 
        /// </para>
        ///  <note> 
        /// <para>
        /// SQL is not enabled for this private beta. Using SQL parameters (such as <a>SqlApplicationConfigurationUpdate</a>)
        /// will result in an error.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by KinesisAnalyticsV2.</returns>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.CodeValidationException">
        /// The user-provided application code (query) is not valid. This can be a simple syntax
        /// error.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modifications to an application. This error
        /// can be the result of attempting to modify an application without using the current
        /// application ID.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidArgumentException">
        /// The specified input parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.InvalidRequestException">
        /// The request JSON is not valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceInUseException">
        /// The application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalyticsV2.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation on AmazonKinesisAnalyticsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        IAsyncResult BeginUpdateApplication(UpdateApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationResult from KinesisAnalyticsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalyticsv2-2018-05-23/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult);

        #endregion
        
    }
}