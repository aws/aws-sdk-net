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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.KinesisAnalytics.Model;

namespace Amazon.KinesisAnalytics
{
    /// <summary>
    /// Interface for accessing KinesisAnalytics
    ///
    /// 
    /// </summary>
    public partial interface IAmazonKinesisAnalytics : IAmazonService, IDisposable
    {

        
        #region  AddApplicationCloudWatchLoggingOption


        /// <summary>
        /// Adds a CloudWatch log stream to monitor application configuration errors. For more
        /// information about using CloudWatch log streams with Amazon Kinesis Analytics applications,
        /// see <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/cloudwatch-logs.html">Working
        /// with Amazon CloudWatch Logs</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationCloudWatchLoggingOption service method.</param>
        /// 
        /// <returns>The response from the AddApplicationCloudWatchLoggingOption service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationCloudWatchLoggingOption">REST API Reference for AddApplicationCloudWatchLoggingOption Operation</seealso>
        AddApplicationCloudWatchLoggingOptionResponse AddApplicationCloudWatchLoggingOption(AddApplicationCloudWatchLoggingOptionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AddApplicationCloudWatchLoggingOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationCloudWatchLoggingOption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationCloudWatchLoggingOption">REST API Reference for AddApplicationCloudWatchLoggingOption Operation</seealso>
        Task<AddApplicationCloudWatchLoggingOptionResponse> AddApplicationCloudWatchLoggingOptionAsync(AddApplicationCloudWatchLoggingOptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddApplicationInput


        /// <summary>
        /// Adds a streaming source to your Amazon Kinesis application. For conceptual information,
        /// see <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-input.html">Configuring
        /// Application Input</a>. 
        /// 
        ///  
        /// <para>
        /// You can add a streaming source either when you create an application or you can use
        /// this operation to add a streaming source after you create an application. For more
        /// information, see <a>CreateApplication</a>.
        /// </para>
        ///  
        /// <para>
        /// Any configuration update, including adding a streaming source using this operation,
        /// results in a new version of the application. You can use the <a>DescribeApplication</a>
        /// operation to find the current application version. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>kinesisanalytics:AddApplicationInput</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationInput service method.</param>
        /// 
        /// <returns>The response from the AddApplicationInput service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.CodeValidationException">
        /// User-provided application code (query) is invalid. This can be a simple syntax error.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationInput">REST API Reference for AddApplicationInput Operation</seealso>
        AddApplicationInputResponse AddApplicationInput(AddApplicationInputRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AddApplicationInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationInput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationInput">REST API Reference for AddApplicationInput Operation</seealso>
        Task<AddApplicationInputResponse> AddApplicationInputAsync(AddApplicationInputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddApplicationInputProcessingConfiguration


        /// <summary>
        /// Adds an <a>InputProcessingConfiguration</a> to an application. An input processor
        /// preprocesses records on the input stream before the application's SQL code executes.
        /// Currently, the only input processor available is <a href="https://aws.amazon.com/documentation/lambda/">AWS
        /// Lambda</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationInputProcessingConfiguration service method.</param>
        /// 
        /// <returns>The response from the AddApplicationInputProcessingConfiguration service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationInputProcessingConfiguration">REST API Reference for AddApplicationInputProcessingConfiguration Operation</seealso>
        AddApplicationInputProcessingConfigurationResponse AddApplicationInputProcessingConfiguration(AddApplicationInputProcessingConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AddApplicationInputProcessingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationInputProcessingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationInputProcessingConfiguration">REST API Reference for AddApplicationInputProcessingConfiguration Operation</seealso>
        Task<AddApplicationInputProcessingConfigurationResponse> AddApplicationInputProcessingConfigurationAsync(AddApplicationInputProcessingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddApplicationOutput


        /// <summary>
        /// Adds an external destination to your Amazon Kinesis Analytics application.
        /// 
        ///  
        /// <para>
        /// If you want Amazon Kinesis Analytics to deliver data from an in-application stream
        /// within your application to an external destination (such as an Amazon Kinesis stream,
        /// an Amazon Kinesis Firehose delivery stream, or an AWS Lambda function), you add the
        /// relevant configuration to your application using this operation. You can configure
        /// one or more outputs for your application. Each output configuration maps an in-application
        /// stream and an external destination.
        /// </para>
        ///  
        /// <para>
        ///  You can use one of the output configurations to deliver data from your in-application
        /// error stream to an external destination so that you can analyze the errors. For more
        /// information, see <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-output.html">Understanding
        /// Application Output (Destination)</a>. 
        /// </para>
        ///  
        /// <para>
        ///  Any configuration update, including adding a streaming source using this operation,
        /// results in a new version of the application. You can use the <a>DescribeApplication</a>
        /// operation to find the current application version.
        /// </para>
        ///  
        /// <para>
        /// For the limits on the number of application inputs and outputs you can configure,
        /// see <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/limits.html">Limits</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>kinesisanalytics:AddApplicationOutput</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationOutput service method.</param>
        /// 
        /// <returns>The response from the AddApplicationOutput service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationOutput">REST API Reference for AddApplicationOutput Operation</seealso>
        AddApplicationOutputResponse AddApplicationOutput(AddApplicationOutputRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AddApplicationOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationOutput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationOutput">REST API Reference for AddApplicationOutput Operation</seealso>
        Task<AddApplicationOutputResponse> AddApplicationOutputAsync(AddApplicationOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddApplicationReferenceDataSource


        /// <summary>
        /// Adds a reference data source to an existing application.
        /// 
        ///  
        /// <para>
        /// Amazon Kinesis Analytics reads reference data (that is, an Amazon S3 object) and creates
        /// an in-application table within your application. In the request, you provide the source
        /// (S3 bucket name and object key name), name of the in-application table to create,
        /// and the necessary mapping information that describes how data in Amazon S3 object
        /// maps to columns in the resulting in-application table.
        /// </para>
        ///  
        /// <para>
        ///  For conceptual information, see <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-input.html">Configuring
        /// Application Input</a>. For the limits on data sources you can add to your application,
        /// see <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/limits.html">Limits</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permissions to perform the <code>kinesisanalytics:AddApplicationOutput</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationReferenceDataSource service method.</param>
        /// 
        /// <returns>The response from the AddApplicationReferenceDataSource service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationReferenceDataSource">REST API Reference for AddApplicationReferenceDataSource Operation</seealso>
        AddApplicationReferenceDataSourceResponse AddApplicationReferenceDataSource(AddApplicationReferenceDataSourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AddApplicationReferenceDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddApplicationReferenceDataSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/AddApplicationReferenceDataSource">REST API Reference for AddApplicationReferenceDataSource Operation</seealso>
        Task<AddApplicationReferenceDataSourceResponse> AddApplicationReferenceDataSourceAsync(AddApplicationReferenceDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateApplication


        /// <summary>
        /// Creates an Amazon Kinesis Analytics application. You can configure each application
        /// with one streaming source as input, application code to process the input, and up
        /// to three destinations where you want Amazon Kinesis Analytics to write the output
        /// data from your application. For an overview, see <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works.html">How
        /// it Works</a>. 
        /// 
        ///  
        /// <para>
        /// In the input configuration, you map the streaming source to an in-application stream,
        /// which you can think of as a constantly updating table. In the mapping, you must provide
        /// a schema for the in-application stream and map each data column in the in-application
        /// stream to a data element in the streaming source.
        /// </para>
        ///  
        /// <para>
        /// Your application code is one or more SQL statements that read input data, transform
        /// it, and generate output. Your application code can create one or more SQL artifacts
        /// like SQL streams or pumps.
        /// </para>
        ///  
        /// <para>
        /// In the output configuration, you can configure the application to write data from
        /// in-application streams created in your applications to up to three destinations.
        /// </para>
        ///  
        /// <para>
        ///  To read data from your source stream or write data to destination streams, Amazon
        /// Kinesis Analytics needs your permissions. You grant these permissions by creating
        /// IAM roles. This operation requires permissions to perform the <code>kinesisanalytics:CreateApplication</code>
        /// action. 
        /// </para>
        ///  
        /// <para>
        ///  For introductory exercises to create an Amazon Kinesis Analytics application, see
        /// <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/getting-started.html">Getting
        /// Started</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.CodeValidationException">
        /// User-provided application code (query) is invalid. This can be a simple syntax error.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.LimitExceededException">
        /// Exceeded the number of applications allowed.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteApplication


        /// <summary>
        /// Deletes the specified application. Amazon Kinesis Analytics halts application execution
        /// and deletes the application, including any application artifacts (such as in-application
        /// streams, reference table, and application code).
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>kinesisanalytics:DeleteApplication</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteApplicationCloudWatchLoggingOption


        /// <summary>
        /// Deletes a CloudWatch log stream from an application. For more information about using
        /// CloudWatch log streams with Amazon Kinesis Analytics applications, see <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/cloudwatch-logs.html">Working
        /// with Amazon CloudWatch Logs</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationCloudWatchLoggingOption service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationCloudWatchLoggingOption service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplicationCloudWatchLoggingOption">REST API Reference for DeleteApplicationCloudWatchLoggingOption Operation</seealso>
        DeleteApplicationCloudWatchLoggingOptionResponse DeleteApplicationCloudWatchLoggingOption(DeleteApplicationCloudWatchLoggingOptionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationCloudWatchLoggingOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationCloudWatchLoggingOption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplicationCloudWatchLoggingOption">REST API Reference for DeleteApplicationCloudWatchLoggingOption Operation</seealso>
        Task<DeleteApplicationCloudWatchLoggingOptionResponse> DeleteApplicationCloudWatchLoggingOptionAsync(DeleteApplicationCloudWatchLoggingOptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteApplicationInputProcessingConfiguration


        /// <summary>
        /// Deletes an <a>InputProcessingConfiguration</a> from an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationInputProcessingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationInputProcessingConfiguration service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplicationInputProcessingConfiguration">REST API Reference for DeleteApplicationInputProcessingConfiguration Operation</seealso>
        DeleteApplicationInputProcessingConfigurationResponse DeleteApplicationInputProcessingConfiguration(DeleteApplicationInputProcessingConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationInputProcessingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationInputProcessingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplicationInputProcessingConfiguration">REST API Reference for DeleteApplicationInputProcessingConfiguration Operation</seealso>
        Task<DeleteApplicationInputProcessingConfigurationResponse> DeleteApplicationInputProcessingConfigurationAsync(DeleteApplicationInputProcessingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteApplicationOutput


        /// <summary>
        /// Deletes output destination configuration from your application configuration. Amazon
        /// Kinesis Analytics will no longer write data from the corresponding in-application
        /// stream to the external output destination.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>kinesisanalytics:DeleteApplicationOutput</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationOutput service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationOutput service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplicationOutput">REST API Reference for DeleteApplicationOutput Operation</seealso>
        DeleteApplicationOutputResponse DeleteApplicationOutput(DeleteApplicationOutputRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationOutput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplicationOutput">REST API Reference for DeleteApplicationOutput Operation</seealso>
        Task<DeleteApplicationOutputResponse> DeleteApplicationOutputAsync(DeleteApplicationOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteApplicationReferenceDataSource


        /// <summary>
        /// Deletes a reference data source configuration from the specified application configuration.
        /// 
        ///  
        /// <para>
        /// If the application is running, Amazon Kinesis Analytics immediately removes the in-application
        /// table that you created using the <a>AddApplicationReferenceDataSource</a> operation.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>kinesisanalytics.DeleteApplicationReferenceDataSource</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationReferenceDataSource service method.</param>
        /// 
        /// <returns>The response from the DeleteApplicationReferenceDataSource service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplicationReferenceDataSource">REST API Reference for DeleteApplicationReferenceDataSource Operation</seealso>
        DeleteApplicationReferenceDataSourceResponse DeleteApplicationReferenceDataSource(DeleteApplicationReferenceDataSourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationReferenceDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationReferenceDataSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DeleteApplicationReferenceDataSource">REST API Reference for DeleteApplicationReferenceDataSource Operation</seealso>
        Task<DeleteApplicationReferenceDataSourceResponse> DeleteApplicationReferenceDataSourceAsync(DeleteApplicationReferenceDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeApplication


        /// <summary>
        /// Returns information about a specific Amazon Kinesis Analytics application.
        /// 
        ///  
        /// <para>
        /// If you want to retrieve a list of all applications in your account, use the <a>ListApplications</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>kinesisanalytics:DescribeApplication</code>
        /// action. You can use <code>DescribeApplication</code> to get the current application
        /// versionId, which you need to call other operations such as <code>Update</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication service method.</param>
        /// 
        /// <returns>The response from the DescribeApplication service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        Task<DescribeApplicationResponse> DescribeApplicationAsync(DescribeApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DiscoverInputSchema


        /// <summary>
        /// Infers a schema by evaluating sample records on the specified streaming source (Amazon
        /// Kinesis stream or Amazon Kinesis Firehose delivery stream) or S3 object. In the response,
        /// the operation returns the inferred schema and also the sample records that the operation
        /// used to infer the schema.
        /// 
        ///  
        /// <para>
        ///  You can use the inferred schema when configuring a streaming source for your application.
        /// For conceptual information, see <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-input.html">Configuring
        /// Application Input</a>. Note that when you create an application using the Amazon Kinesis
        /// Analytics console, the console uses this operation to infer a schema and show it in
        /// the console user interface. 
        /// </para>
        ///  
        /// <para>
        ///  This operation requires permissions to perform the <code>kinesisanalytics:DiscoverInputSchema</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DiscoverInputSchema service method.</param>
        /// 
        /// <returns>The response from the DiscoverInputSchema service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceProvisionedThroughputExceededException">
        /// Discovery failed to get a record from the streaming source because of the Amazon Kinesis
        /// Streams ProvisionedThroughputExceededException. For more information, see <a href="http://docs.aws.amazon.com/kinesis/latest/APIReference/API_GetRecords.html">GetRecords</a>
        /// in the Amazon Kinesis Streams API Reference.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ServiceUnavailableException">
        /// The service is unavailable. Back off and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnableToDetectSchemaException">
        /// Data format is not valid. Amazon Kinesis Analytics is not able to detect schema for
        /// the given streaming source.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DiscoverInputSchema">REST API Reference for DiscoverInputSchema Operation</seealso>
        DiscoverInputSchemaResponse DiscoverInputSchema(DiscoverInputSchemaRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DiscoverInputSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DiscoverInputSchema operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/DiscoverInputSchema">REST API Reference for DiscoverInputSchema Operation</seealso>
        Task<DiscoverInputSchemaResponse> DiscoverInputSchemaAsync(DiscoverInputSchemaRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListApplications


        /// <summary>
        /// Returns a list of Amazon Kinesis Analytics applications in your account. For each
        /// application, the response includes the application name, Amazon Resource Name (ARN),
        /// and status. If the response returns the <code>HasMoreApplications</code> value as
        /// true, you can send another request by adding the <code>ExclusiveStartApplicationName</code>
        /// in the request body, and set the value of this to the last application name from the
        /// previous response. 
        /// 
        ///  
        /// <para>
        /// If you want detailed information about a specific application, use <a>DescribeApplication</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>kinesisanalytics:ListApplications</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by KinesisAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse ListApplications(ListApplicationsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/ListApplications">REST API Reference for ListApplications Operation</seealso>
        Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartApplication


        /// <summary>
        /// Starts the specified Amazon Kinesis Analytics application. After creating an application,
        /// you must exclusively call this operation to start your application.
        /// 
        ///  
        /// <para>
        /// After the application starts, it begins consuming the input data, processes it, and
        /// writes the output to the configured destination.
        /// </para>
        ///  
        /// <para>
        ///  The application status must be <code>READY</code> for you to start an application.
        /// You can get the application status in the console or using the <a>DescribeApplication</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// After you start the application, you can stop the application from processing the
        /// input by calling the <a>StopApplication</a> operation.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>kinesisanalytics:StartApplication</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartApplication service method.</param>
        /// 
        /// <returns>The response from the StartApplication service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidApplicationConfigurationException">
        /// User-provided application configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/StartApplication">REST API Reference for StartApplication Operation</seealso>
        StartApplicationResponse StartApplication(StartApplicationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/StartApplication">REST API Reference for StartApplication Operation</seealso>
        Task<StartApplicationResponse> StartApplicationAsync(StartApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopApplication


        /// <summary>
        /// Stops the application from processing input data. You can stop an application only
        /// if it is in the running state. You can use the <a>DescribeApplication</a> operation
        /// to find the application state. After the application is stopped, Amazon Kinesis Analytics
        /// stops reading data from the input, the application stops processing data, and there
        /// is no output written to the destination. 
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>kinesisanalytics:StopApplication</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopApplication service method.</param>
        /// 
        /// <returns>The response from the StopApplication service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/StopApplication">REST API Reference for StopApplication Operation</seealso>
        StopApplicationResponse StopApplication(StopApplicationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StopApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/StopApplication">REST API Reference for StopApplication Operation</seealso>
        Task<StopApplicationResponse> StopApplicationAsync(StopApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateApplication


        /// <summary>
        /// Updates an existing Amazon Kinesis Analytics application. Using this API, you can
        /// update application code, input configuration, and output configuration. 
        /// 
        ///  
        /// <para>
        /// Note that Amazon Kinesis Analytics updates the <code>CurrentApplicationVersionId</code>
        /// each time you update your application. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>kinesisanalytics:UpdateApplication</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by KinesisAnalytics.</returns>
        /// <exception cref="Amazon.KinesisAnalytics.Model.CodeValidationException">
        /// User-provided application code (query) is invalid. This can be a simple syntax error.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ConcurrentModificationException">
        /// Exception thrown as a result of concurrent modification to an application. For example,
        /// two individuals attempting to edit the same application at the same time.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.InvalidArgumentException">
        /// Specified input parameter value is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceInUseException">
        /// Application is not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.ResourceNotFoundException">
        /// Specified application can't be found.
        /// </exception>
        /// <exception cref="Amazon.KinesisAnalytics.Model.UnsupportedOperationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisanalytics-2015-08-14/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}