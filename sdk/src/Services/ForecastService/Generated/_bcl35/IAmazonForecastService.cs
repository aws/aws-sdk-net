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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ForecastService.Model;

namespace Amazon.ForecastService
{
    /// <summary>
    /// Interface for accessing ForecastService
    ///
    /// Provides APIs for creating and managing Amazon Forecast resources.
    /// </summary>
    public partial interface IAmazonForecastService : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IForecastServicePaginatorFactory Paginators { get; }
#endif


        
        #region  CreateAutoPredictor


        /// <summary>
        /// Creates an Amazon Forecast predictor.
        /// 
        ///  
        /// <para>
        /// Amazon Forecast creates predictors with AutoPredictor, which involves applying the
        /// optimal combination of algorithms to each time series in your datasets. You can use
        /// <a>CreateAutoPredictor</a> to create new predictors or upgrade/retrain existing predictors.
        /// </para>
        ///  
        /// <para>
        ///  <b>Creating new predictors</b> 
        /// </para>
        ///  
        /// <para>
        /// The following parameters are required when creating a new predictor:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PredictorName</code> - A unique name for the predictor.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DatasetGroupArn</code> - The ARN of the dataset group used to train the predictor.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ForecastFrequency</code> - The granularity of your forecasts (hourly, daily,
        /// weekly, etc).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ForecastHorizon</code> - The number of time-steps that the model predicts.
        /// The forecast horizon is also called the prediction length.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When creating a new predictor, do not specify a value for <code>ReferencePredictorArn</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Upgrading and retraining predictors</b> 
        /// </para>
        ///  
        /// <para>
        /// The following parameters are required when retraining or upgrading a predictor:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PredictorName</code> - A unique name for the predictor.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReferencePredictorArn</code> - The ARN of the predictor to retrain or upgrade.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When upgrading or retraining a predictor, only specify values for the <code>ReferencePredictorArn</code>
        /// and <code>PredictorName</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoPredictor service method.</param>
        /// 
        /// <returns>The response from the CreateAutoPredictor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateAutoPredictor">REST API Reference for CreateAutoPredictor Operation</seealso>
        CreateAutoPredictorResponse CreateAutoPredictor(CreateAutoPredictorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAutoPredictor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoPredictor operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAutoPredictor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateAutoPredictor">REST API Reference for CreateAutoPredictor Operation</seealso>
        IAsyncResult BeginCreateAutoPredictor(CreateAutoPredictorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAutoPredictor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAutoPredictor.</param>
        /// 
        /// <returns>Returns a  CreateAutoPredictorResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateAutoPredictor">REST API Reference for CreateAutoPredictor Operation</seealso>
        CreateAutoPredictorResponse EndCreateAutoPredictor(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataset


        /// <summary>
        /// Creates an Amazon Forecast dataset. The information about the dataset that you provide
        /// helps Forecast understand how to consume the data for model training. This includes
        /// the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <i> <code>DataFrequency</code> </i> - How frequently your historical time-series
        /// data is collected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i> <code>Domain</code> </i> and <i> <code>DatasetType</code> </i> - Each dataset
        /// has an associated dataset domain and a type within the domain. Amazon Forecast provides
        /// a list of predefined domains and types within each domain. For each unique dataset
        /// domain and type within the domain, Amazon Forecast requires your data to include a
        /// minimum set of predefined fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i> <code>Schema</code> </i> - A schema specifies the fields in the dataset, including
        /// the field name and data type.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After creating a dataset, you import your training data into it and add the dataset
        /// to a dataset group. You use the dataset group to create a predictor. For more information,
        /// see <a href="https://docs.aws.amazon.com/forecast/latest/dg/howitworks-datasets-groups.html">Importing
        /// datasets</a>.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your datasets, use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_ListDatasets.html">ListDatasets</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For example Forecast datasets, see the <a href="https://github.com/aws-samples/amazon-forecast-samples">Amazon
        /// Forecast Sample GitHub repository</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of a dataset must be <code>ACTIVE</code> before you can import
        /// training data. Use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDataset.html">DescribeDataset</a>
        /// operation to get the status.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        CreateDatasetResponse CreateDataset(CreateDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        IAsyncResult BeginCreateDataset(CreateDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataset.</param>
        /// 
        /// <returns>Returns a  CreateDatasetResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        CreateDatasetResponse EndCreateDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDatasetGroup


        /// <summary>
        /// Creates a dataset group, which holds a collection of related datasets. You can add
        /// datasets to the dataset group when you create the dataset group, or later by using
        /// the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_UpdateDatasetGroup.html">UpdateDatasetGroup</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// After creating a dataset group and adding datasets, you use the dataset group when
        /// you create a predictor. For more information, see <a href="https://docs.aws.amazon.com/forecast/latest/dg/howitworks-datasets-groups.html">Dataset
        /// groups</a>.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your datasets groups, use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_ListDatasetGroups.html">ListDatasetGroups</a>
        /// operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of a dataset group must be <code>ACTIVE</code> before you
        /// can use the dataset group to create a predictor. To get the status, use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDatasetGroup.html">DescribeDatasetGroup</a>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDatasetGroup service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetGroup">REST API Reference for CreateDatasetGroup Operation</seealso>
        CreateDatasetGroupResponse CreateDatasetGroup(CreateDatasetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetGroup operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatasetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetGroup">REST API Reference for CreateDatasetGroup Operation</seealso>
        IAsyncResult BeginCreateDatasetGroup(CreateDatasetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatasetGroup.</param>
        /// 
        /// <returns>Returns a  CreateDatasetGroupResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetGroup">REST API Reference for CreateDatasetGroup Operation</seealso>
        CreateDatasetGroupResponse EndCreateDatasetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDatasetImportJob


        /// <summary>
        /// Imports your training data to an Amazon Forecast dataset. You provide the location
        /// of your training data in an Amazon Simple Storage Service (Amazon S3) bucket and the
        /// Amazon Resource Name (ARN) of the dataset that you want to import the data to.
        /// 
        ///  
        /// <para>
        /// You must specify a <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DataSource.html">DataSource</a>
        /// object that includes an Identity and Access Management (IAM) role that Amazon Forecast
        /// can assume to access the data, as Amazon Forecast makes a copy of your data and processes
        /// it in an internal Amazon Web Services system. For more information, see <a href="https://docs.aws.amazon.com/forecast/latest/dg/aws-forecast-iam-roles.html">Set
        /// up permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// The training data must be in CSV or Parquet format. The delimiter must be a comma
        /// (,).
        /// </para>
        ///  
        /// <para>
        /// You can specify the path to a specific file, the S3 bucket, or to a folder in the
        /// S3 bucket. For the latter two cases, Amazon Forecast imports all files up to the limit
        /// of 10,000 files.
        /// </para>
        ///  
        /// <para>
        /// Because dataset imports are not aggregated, your most recent dataset import is the
        /// one that is used when training a predictor or generating a forecast. Make sure that
        /// your most recent dataset import contains all of the data you want to model off of,
        /// and not just the new data collected since the previous import.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your dataset import jobs, filtered by specified criteria, use
        /// the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_ListDatasetImportJobs.html">ListDatasetImportJobs</a>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetImportJob service method.</param>
        /// 
        /// <returns>The response from the CreateDatasetImportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetImportJob">REST API Reference for CreateDatasetImportJob Operation</seealso>
        CreateDatasetImportJobResponse CreateDatasetImportJob(CreateDatasetImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetImportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatasetImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetImportJob">REST API Reference for CreateDatasetImportJob Operation</seealso>
        IAsyncResult BeginCreateDatasetImportJob(CreateDatasetImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatasetImportJob.</param>
        /// 
        /// <returns>Returns a  CreateDatasetImportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetImportJob">REST API Reference for CreateDatasetImportJob Operation</seealso>
        CreateDatasetImportJobResponse EndCreateDatasetImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateExplainability


        /// <summary>
        /// <note> 
        /// <para>
        /// Explainability is only available for Forecasts and Predictors generated from an AutoPredictor
        /// (<a>CreateAutoPredictor</a>)
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an Amazon Forecast Explainability.
        /// </para>
        ///  
        /// <para>
        /// Explainability helps you better understand how the attributes in your datasets impact
        /// forecast. Amazon Forecast uses a metric called Impact scores to quantify the relative
        /// impact of each attribute and determine whether they increase or decrease forecast
        /// values.
        /// </para>
        ///  
        /// <para>
        /// To enable Forecast Explainability, your predictor must include at least one of the
        /// following: related time series, item metadata, or additional datasets like Holidays
        /// and the Weather Index.
        /// </para>
        ///  
        /// <para>
        /// CreateExplainability accepts either a Predictor ARN or Forecast ARN. To receive aggregated
        /// Impact scores for all time series and time points in your datasets, provide a Predictor
        /// ARN. To receive Impact scores for specific time series and time points, provide a
        /// Forecast ARN.
        /// </para>
        ///  
        /// <para>
        ///  <b>CreateExplainability with a Predictor ARN</b> 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can only have one Explainability resource per predictor. If you already enabled
        /// <code>ExplainPredictor</code> in <a>CreateAutoPredictor</a>, that predictor already
        /// has an Explainability resource.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following parameters are required when providing a Predictor ARN:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ExplainabilityName</code> - A unique name for the Explainability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ResourceArn</code> - The Arn of the predictor.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TimePointGranularity</code> - Must be set to “ALL”.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TimeSeriesGranularity</code> - Must be set to “ALL”.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Do not specify a value for the following parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DataSource</code> - Only valid when TimeSeriesGranularity is “SPECIFIC”.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Schema</code> - Only valid when TimeSeriesGranularity is “SPECIFIC”.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>StartDateTime</code> - Only valid when TimePointGranularity is “SPECIFIC”.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EndDateTime</code> - Only valid when TimePointGranularity is “SPECIFIC”.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>CreateExplainability with a Forecast ARN</b> 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can specify a maximum of 50 time series and 500 time points.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following parameters are required when providing a Predictor ARN:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ExplainabilityName</code> - A unique name for the Explainability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ResourceArn</code> - The Arn of the forecast.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TimePointGranularity</code> - Either “ALL” or “SPECIFIC”.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TimeSeriesGranularity</code> - Either “ALL” or “SPECIFIC”.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you set TimeSeriesGranularity to “SPECIFIC”, you must also provide the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DataSource</code> - The S3 location of the CSV file specifying your time series.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Schema</code> - The Schema defines the attributes and attribute types listed
        /// in the Data Source.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you set TimePointGranularity to “SPECIFIC”, you must also provide the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>StartDateTime</code> - The first timestamp in the range of time points.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EndDateTime</code> - The last timestamp in the range of time points.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExplainability service method.</param>
        /// 
        /// <returns>The response from the CreateExplainability service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateExplainability">REST API Reference for CreateExplainability Operation</seealso>
        CreateExplainabilityResponse CreateExplainability(CreateExplainabilityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateExplainability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExplainability operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExplainability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateExplainability">REST API Reference for CreateExplainability Operation</seealso>
        IAsyncResult BeginCreateExplainability(CreateExplainabilityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExplainability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExplainability.</param>
        /// 
        /// <returns>Returns a  CreateExplainabilityResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateExplainability">REST API Reference for CreateExplainability Operation</seealso>
        CreateExplainabilityResponse EndCreateExplainability(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateExplainabilityExport


        /// <summary>
        /// Exports an Explainability resource created by the <a>CreateExplainability</a> operation.
        /// Exported files are exported to an Amazon Simple Storage Service (Amazon S3) bucket.
        /// 
        ///  
        /// <para>
        /// You must specify a <a>DataDestination</a> object that includes an Amazon S3 bucket
        /// and an Identity and Access Management (IAM) role that Amazon Forecast can assume to
        /// access the Amazon S3 bucket. For more information, see <a>aws-forecast-iam-roles</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the export job must be <code>ACTIVE</code> before you can
        /// access the export in your Amazon S3 bucket. To get the status, use the <a>DescribeExplainabilityExport</a>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExplainabilityExport service method.</param>
        /// 
        /// <returns>The response from the CreateExplainabilityExport service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateExplainabilityExport">REST API Reference for CreateExplainabilityExport Operation</seealso>
        CreateExplainabilityExportResponse CreateExplainabilityExport(CreateExplainabilityExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateExplainabilityExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExplainabilityExport operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExplainabilityExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateExplainabilityExport">REST API Reference for CreateExplainabilityExport Operation</seealso>
        IAsyncResult BeginCreateExplainabilityExport(CreateExplainabilityExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExplainabilityExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExplainabilityExport.</param>
        /// 
        /// <returns>Returns a  CreateExplainabilityExportResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateExplainabilityExport">REST API Reference for CreateExplainabilityExport Operation</seealso>
        CreateExplainabilityExportResponse EndCreateExplainabilityExport(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateForecast


        /// <summary>
        /// Creates a forecast for each item in the <code>TARGET_TIME_SERIES</code> dataset that
        /// was used to train the predictor. This is known as inference. To retrieve the forecast
        /// for a single item at low latency, use the operation. To export the complete forecast
        /// into your Amazon Simple Storage Service (Amazon S3) bucket, use the <a>CreateForecastExportJob</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// The range of the forecast is determined by the <code>ForecastHorizon</code> value,
        /// which you specify in the <a>CreatePredictor</a> request. When you query a forecast,
        /// you can request a specific date range within the forecast.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your forecasts, use the <a>ListForecasts</a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The forecasts generated by Amazon Forecast are in the same time zone as the dataset
        /// that was used to create the predictor.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a>howitworks-forecast</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the forecast must be <code>ACTIVE</code> before you can
        /// query or export the forecast. Use the <a>DescribeForecast</a> operation to get the
        /// status.
        /// </para>
        ///  </note> 
        /// <para>
        /// By default, a forecast includes predictions for every item (<code>item_id</code>)
        /// in the dataset group that was used to train the predictor. However, you can use the
        /// <code>TimeSeriesSelector</code> object to generate a forecast on a subset of time
        /// series. Forecast creation is skipped for any time series that you specify that are
        /// not in the input dataset. The forecast export file will not contain these time series
        /// or their forecasted values.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateForecast service method.</param>
        /// 
        /// <returns>The response from the CreateForecast service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecast">REST API Reference for CreateForecast Operation</seealso>
        CreateForecastResponse CreateForecast(CreateForecastRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateForecast operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateForecast operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateForecast
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecast">REST API Reference for CreateForecast Operation</seealso>
        IAsyncResult BeginCreateForecast(CreateForecastRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateForecast operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateForecast.</param>
        /// 
        /// <returns>Returns a  CreateForecastResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecast">REST API Reference for CreateForecast Operation</seealso>
        CreateForecastResponse EndCreateForecast(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateForecastExportJob


        /// <summary>
        /// Exports a forecast created by the <a>CreateForecast</a> operation to your Amazon Simple
        /// Storage Service (Amazon S3) bucket. The forecast file name will match the following
        /// conventions:
        /// 
        ///  
        /// <para>
        /// &lt;ForecastExportJobName&gt;_&lt;ExportTimestamp&gt;_&lt;PartNumber&gt;
        /// </para>
        ///  
        /// <para>
        /// where the &lt;ExportTimestamp&gt; component is in Java SimpleDateFormat (yyyy-MM-ddTHH-mm-ssZ).
        /// </para>
        ///  
        /// <para>
        /// You must specify a <a>DataDestination</a> object that includes an Identity and Access
        /// Management (IAM) role that Amazon Forecast can assume to access the Amazon S3 bucket.
        /// For more information, see <a>aws-forecast-iam-roles</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>howitworks-forecast</a>.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your forecast export jobs, use the <a>ListForecastExportJobs</a>
        /// operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the forecast export job must be <code>ACTIVE</code> before
        /// you can access the forecast in your Amazon S3 bucket. To get the status, use the <a>DescribeForecastExportJob</a>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateForecastExportJob service method.</param>
        /// 
        /// <returns>The response from the CreateForecastExportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecastExportJob">REST API Reference for CreateForecastExportJob Operation</seealso>
        CreateForecastExportJobResponse CreateForecastExportJob(CreateForecastExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateForecastExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateForecastExportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateForecastExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecastExportJob">REST API Reference for CreateForecastExportJob Operation</seealso>
        IAsyncResult BeginCreateForecastExportJob(CreateForecastExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateForecastExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateForecastExportJob.</param>
        /// 
        /// <returns>Returns a  CreateForecastExportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecastExportJob">REST API Reference for CreateForecastExportJob Operation</seealso>
        CreateForecastExportJobResponse EndCreateForecastExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMonitor


        /// <summary>
        /// Creates a predictor monitor resource for an existing auto predictor. Predictor monitoring
        /// allows you to see how your predictor's performance changes over time. For more information,
        /// see <a href="https://docs.aws.amazon.com/forecast/latest/dg/predictor-monitoring.html">Predictor
        /// Monitoring</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor service method.</param>
        /// 
        /// <returns>The response from the CreateMonitor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        CreateMonitorResponse CreateMonitor(CreateMonitorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        IAsyncResult BeginCreateMonitor(CreateMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMonitor.</param>
        /// 
        /// <returns>Returns a  CreateMonitorResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        CreateMonitorResponse EndCreateMonitor(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePredictor


        /// <summary>
        /// <note> 
        /// <para>
        ///  This operation creates a legacy predictor that does not include all the predictor
        /// functionalities provided by Amazon Forecast. To create a predictor that is compatible
        /// with all aspects of Forecast, use <a>CreateAutoPredictor</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates an Amazon Forecast predictor.
        /// </para>
        ///  
        /// <para>
        /// In the request, provide a dataset group and either specify an algorithm or let Amazon
        /// Forecast choose an algorithm for you using AutoML. If you specify an algorithm, you
        /// also can override algorithm-specific hyperparameters.
        /// </para>
        ///  
        /// <para>
        /// Amazon Forecast uses the algorithm to train a predictor using the latest version of
        /// the datasets in the specified dataset group. You can then generate a forecast using
        /// the <a>CreateForecast</a> operation.
        /// </para>
        ///  
        /// <para>
        ///  To see the evaluation metrics, use the <a>GetAccuracyMetrics</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// You can specify a featurization configuration to fill and aggregate the data fields
        /// in the <code>TARGET_TIME_SERIES</code> dataset to improve model training. For more
        /// information, see <a>FeaturizationConfig</a>.
        /// </para>
        ///  
        /// <para>
        /// For RELATED_TIME_SERIES datasets, <code>CreatePredictor</code> verifies that the <code>DataFrequency</code>
        /// specified when the dataset was created matches the <code>ForecastFrequency</code>.
        /// TARGET_TIME_SERIES datasets don't have this restriction. Amazon Forecast also verifies
        /// the delimiter and timestamp format. For more information, see <a>howitworks-datasets-groups</a>.
        /// </para>
        ///  
        /// <para>
        /// By default, predictors are trained and evaluated at the 0.1 (P10), 0.5 (P50), and
        /// 0.9 (P90) quantiles. You can choose custom forecast types to train and evaluate your
        /// predictor by setting the <code>ForecastTypes</code>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>AutoML</b> 
        /// </para>
        ///  
        /// <para>
        /// If you want Amazon Forecast to evaluate each algorithm and choose the one that minimizes
        /// the <code>objective function</code>, set <code>PerformAutoML</code> to <code>true</code>.
        /// The <code>objective function</code> is defined as the mean of the weighted losses
        /// over the forecast types. By default, these are the p10, p50, and p90 quantile losses.
        /// For more information, see <a>EvaluationResult</a>.
        /// </para>
        ///  
        /// <para>
        /// When AutoML is enabled, the following properties are disallowed:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AlgorithmArn</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HPOConfig</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PerformHPO</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TrainingParameters</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get a list of all of your predictors, use the <a>ListPredictors</a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before you can use the predictor to create a forecast, the <code>Status</code> of
        /// the predictor must be <code>ACTIVE</code>, signifying that training has completed.
        /// To get the status, use the <a>DescribePredictor</a> operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePredictor service method.</param>
        /// 
        /// <returns>The response from the CreatePredictor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreatePredictor">REST API Reference for CreatePredictor Operation</seealso>
        CreatePredictorResponse CreatePredictor(CreatePredictorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePredictor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePredictor operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePredictor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreatePredictor">REST API Reference for CreatePredictor Operation</seealso>
        IAsyncResult BeginCreatePredictor(CreatePredictorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePredictor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePredictor.</param>
        /// 
        /// <returns>Returns a  CreatePredictorResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreatePredictor">REST API Reference for CreatePredictor Operation</seealso>
        CreatePredictorResponse EndCreatePredictor(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePredictorBacktestExportJob


        /// <summary>
        /// Exports backtest forecasts and accuracy metrics generated by the <a>CreateAutoPredictor</a>
        /// or <a>CreatePredictor</a> operations. Two folders containing CSV or Parquet files
        /// are exported to your specified S3 bucket.
        /// 
        ///  
        /// <para>
        ///  The export file names will match the following conventions:
        /// </para>
        ///  
        /// <para>
        ///  <code>&lt;ExportJobName&gt;_&lt;ExportTimestamp&gt;_&lt;PartNumber&gt;.csv</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The &lt;ExportTimestamp&gt; component is in Java SimpleDate format (yyyy-MM-ddTHH-mm-ssZ).
        /// </para>
        ///  
        /// <para>
        /// You must specify a <a>DataDestination</a> object that includes an Amazon S3 bucket
        /// and an Identity and Access Management (IAM) role that Amazon Forecast can assume to
        /// access the Amazon S3 bucket. For more information, see <a>aws-forecast-iam-roles</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the export job must be <code>ACTIVE</code> before you can
        /// access the export in your Amazon S3 bucket. To get the status, use the <a>DescribePredictorBacktestExportJob</a>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePredictorBacktestExportJob service method.</param>
        /// 
        /// <returns>The response from the CreatePredictorBacktestExportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreatePredictorBacktestExportJob">REST API Reference for CreatePredictorBacktestExportJob Operation</seealso>
        CreatePredictorBacktestExportJobResponse CreatePredictorBacktestExportJob(CreatePredictorBacktestExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePredictorBacktestExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePredictorBacktestExportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePredictorBacktestExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreatePredictorBacktestExportJob">REST API Reference for CreatePredictorBacktestExportJob Operation</seealso>
        IAsyncResult BeginCreatePredictorBacktestExportJob(CreatePredictorBacktestExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePredictorBacktestExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePredictorBacktestExportJob.</param>
        /// 
        /// <returns>Returns a  CreatePredictorBacktestExportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreatePredictorBacktestExportJob">REST API Reference for CreatePredictorBacktestExportJob Operation</seealso>
        CreatePredictorBacktestExportJobResponse EndCreatePredictorBacktestExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWhatIfAnalysis


        /// <summary>
        /// What-if analysis is a scenario modeling technique where you make a hypothetical change
        /// to a time series and compare the forecasts generated by these changes against the
        /// baseline, unchanged time series. It is important to remember that the purpose of a
        /// what-if analysis is to understand how a forecast can change given different modifications
        /// to the baseline time series.
        /// 
        ///  
        /// <para>
        /// For example, imagine you are a clothing retailer who is considering an end of season
        /// sale to clear space for new styles. After creating a baseline forecast, you can use
        /// a what-if analysis to investigate how different sales tactics might affect your goals.
        /// </para>
        ///  
        /// <para>
        /// You could create a scenario where everything is given a 25% markdown, and another
        /// where everything is given a fixed dollar markdown. You could create a scenario where
        /// the sale lasts for one week and another where the sale lasts for one month. With a
        /// what-if analysis, you can compare many different scenarios against each other.
        /// </para>
        ///  
        /// <para>
        /// Note that a what-if analysis is meant to display what the forecasting model has learned
        /// and how it will behave in the scenarios that you are evaluating. Do not blindly use
        /// the results of the what-if analysis to make business decisions. For instance, forecasts
        /// might not be accurate for novel scenarios where there is no reference available to
        /// determine whether a forecast is good.
        /// </para>
        ///  
        /// <para>
        /// The <a>TimeSeriesSelector</a> object defines the items that you want in the what-if
        /// analysis.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatIfAnalysis service method.</param>
        /// 
        /// <returns>The response from the CreateWhatIfAnalysis service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateWhatIfAnalysis">REST API Reference for CreateWhatIfAnalysis Operation</seealso>
        CreateWhatIfAnalysisResponse CreateWhatIfAnalysis(CreateWhatIfAnalysisRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWhatIfAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatIfAnalysis operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWhatIfAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateWhatIfAnalysis">REST API Reference for CreateWhatIfAnalysis Operation</seealso>
        IAsyncResult BeginCreateWhatIfAnalysis(CreateWhatIfAnalysisRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWhatIfAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWhatIfAnalysis.</param>
        /// 
        /// <returns>Returns a  CreateWhatIfAnalysisResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateWhatIfAnalysis">REST API Reference for CreateWhatIfAnalysis Operation</seealso>
        CreateWhatIfAnalysisResponse EndCreateWhatIfAnalysis(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWhatIfForecast


        /// <summary>
        /// A what-if forecast is a forecast that is created from a modified version of the baseline
        /// forecast. Each what-if forecast incorporates either a replacement dataset or a set
        /// of transformations to the original dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatIfForecast service method.</param>
        /// 
        /// <returns>The response from the CreateWhatIfForecast service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateWhatIfForecast">REST API Reference for CreateWhatIfForecast Operation</seealso>
        CreateWhatIfForecastResponse CreateWhatIfForecast(CreateWhatIfForecastRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWhatIfForecast operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatIfForecast operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWhatIfForecast
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateWhatIfForecast">REST API Reference for CreateWhatIfForecast Operation</seealso>
        IAsyncResult BeginCreateWhatIfForecast(CreateWhatIfForecastRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWhatIfForecast operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWhatIfForecast.</param>
        /// 
        /// <returns>Returns a  CreateWhatIfForecastResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateWhatIfForecast">REST API Reference for CreateWhatIfForecast Operation</seealso>
        CreateWhatIfForecastResponse EndCreateWhatIfForecast(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWhatIfForecastExport


        /// <summary>
        /// Exports a forecast created by the <a>CreateWhatIfForecast</a> operation to your Amazon
        /// Simple Storage Service (Amazon S3) bucket. The forecast file name will match the following
        /// conventions:
        /// 
        ///  
        /// <para>
        ///  <code>≈&lt;ForecastExportJobName&gt;_&lt;ExportTimestamp&gt;_&lt;PartNumber&gt;</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The &lt;ExportTimestamp&gt; component is in Java SimpleDateFormat (yyyy-MM-ddTHH-mm-ssZ).
        /// </para>
        ///  
        /// <para>
        /// You must specify a <a>DataDestination</a> object that includes an Identity and Access
        /// Management (IAM) role that Amazon Forecast can assume to access the Amazon S3 bucket.
        /// For more information, see <a>aws-forecast-iam-roles</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>howitworks-forecast</a>.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your what-if forecast export jobs, use the <a>ListWhatIfForecastExports</a>
        /// operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the forecast export job must be <code>ACTIVE</code> before
        /// you can access the forecast in your Amazon S3 bucket. To get the status, use the <a>DescribeWhatIfForecastExport</a>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatIfForecastExport service method.</param>
        /// 
        /// <returns>The response from the CreateWhatIfForecastExport service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with this name. Try again with a different name.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateWhatIfForecastExport">REST API Reference for CreateWhatIfForecastExport Operation</seealso>
        CreateWhatIfForecastExportResponse CreateWhatIfForecastExport(CreateWhatIfForecastExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWhatIfForecastExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatIfForecastExport operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWhatIfForecastExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateWhatIfForecastExport">REST API Reference for CreateWhatIfForecastExport Operation</seealso>
        IAsyncResult BeginCreateWhatIfForecastExport(CreateWhatIfForecastExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWhatIfForecastExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWhatIfForecastExport.</param>
        /// 
        /// <returns>Returns a  CreateWhatIfForecastExportResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateWhatIfForecastExport">REST API Reference for CreateWhatIfForecastExport Operation</seealso>
        CreateWhatIfForecastExportResponse EndCreateWhatIfForecastExport(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataset


        /// <summary>
        /// Deletes an Amazon Forecast dataset that was created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDataset.html">CreateDataset</a>
        /// operation. You can only delete datasets that have a status of <code>ACTIVE</code>
        /// or <code>CREATE_FAILED</code>. To get the status use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDataset.html">DescribeDataset</a>
        /// operation.
        /// 
        ///  <note> 
        /// <para>
        /// Forecast does not automatically update any dataset groups that contain the deleted
        /// dataset. In order to update the dataset group, use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_UpdateDatasetGroup.html">UpdateDatasetGroup</a>
        /// operation, omitting the deleted dataset's ARN.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        IAsyncResult BeginDeleteDataset(DeleteDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataset.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        DeleteDatasetResponse EndDeleteDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDatasetGroup


        /// <summary>
        /// Deletes a dataset group created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetGroup.html">CreateDatasetGroup</a>
        /// operation. You can only delete dataset groups that have a status of <code>ACTIVE</code>,
        /// <code>CREATE_FAILED</code>, or <code>UPDATE_FAILED</code>. To get the status, use
        /// the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDatasetGroup.html">DescribeDatasetGroup</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// This operation deletes only the dataset group, not the datasets in the group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDatasetGroup service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetGroup">REST API Reference for DeleteDatasetGroup Operation</seealso>
        DeleteDatasetGroupResponse DeleteDatasetGroup(DeleteDatasetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetGroup operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDatasetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetGroup">REST API Reference for DeleteDatasetGroup Operation</seealso>
        IAsyncResult BeginDeleteDatasetGroup(DeleteDatasetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatasetGroup.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetGroupResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetGroup">REST API Reference for DeleteDatasetGroup Operation</seealso>
        DeleteDatasetGroupResponse EndDeleteDatasetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDatasetImportJob


        /// <summary>
        /// Deletes a dataset import job created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetImportJob.html">CreateDatasetImportJob</a>
        /// operation. You can delete only dataset import jobs that have a status of <code>ACTIVE</code>
        /// or <code>CREATE_FAILED</code>. To get the status, use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDatasetImportJob.html">DescribeDatasetImportJob</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetImportJob service method.</param>
        /// 
        /// <returns>The response from the DeleteDatasetImportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetImportJob">REST API Reference for DeleteDatasetImportJob Operation</seealso>
        DeleteDatasetImportJobResponse DeleteDatasetImportJob(DeleteDatasetImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetImportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDatasetImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetImportJob">REST API Reference for DeleteDatasetImportJob Operation</seealso>
        IAsyncResult BeginDeleteDatasetImportJob(DeleteDatasetImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatasetImportJob.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetImportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetImportJob">REST API Reference for DeleteDatasetImportJob Operation</seealso>
        DeleteDatasetImportJobResponse EndDeleteDatasetImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteExplainability


        /// <summary>
        /// Deletes an Explainability resource.
        /// 
        ///  
        /// <para>
        /// You can delete only predictor that have a status of <code>ACTIVE</code> or <code>CREATE_FAILED</code>.
        /// To get the status, use the <a>DescribeExplainability</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExplainability service method.</param>
        /// 
        /// <returns>The response from the DeleteExplainability service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteExplainability">REST API Reference for DeleteExplainability Operation</seealso>
        DeleteExplainabilityResponse DeleteExplainability(DeleteExplainabilityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteExplainability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteExplainability operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteExplainability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteExplainability">REST API Reference for DeleteExplainability Operation</seealso>
        IAsyncResult BeginDeleteExplainability(DeleteExplainabilityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteExplainability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteExplainability.</param>
        /// 
        /// <returns>Returns a  DeleteExplainabilityResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteExplainability">REST API Reference for DeleteExplainability Operation</seealso>
        DeleteExplainabilityResponse EndDeleteExplainability(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteExplainabilityExport


        /// <summary>
        /// Deletes an Explainability export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExplainabilityExport service method.</param>
        /// 
        /// <returns>The response from the DeleteExplainabilityExport service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteExplainabilityExport">REST API Reference for DeleteExplainabilityExport Operation</seealso>
        DeleteExplainabilityExportResponse DeleteExplainabilityExport(DeleteExplainabilityExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteExplainabilityExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteExplainabilityExport operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteExplainabilityExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteExplainabilityExport">REST API Reference for DeleteExplainabilityExport Operation</seealso>
        IAsyncResult BeginDeleteExplainabilityExport(DeleteExplainabilityExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteExplainabilityExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteExplainabilityExport.</param>
        /// 
        /// <returns>Returns a  DeleteExplainabilityExportResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteExplainabilityExport">REST API Reference for DeleteExplainabilityExport Operation</seealso>
        DeleteExplainabilityExportResponse EndDeleteExplainabilityExport(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteForecast


        /// <summary>
        /// Deletes a forecast created using the <a>CreateForecast</a> operation. You can delete
        /// only forecasts that have a status of <code>ACTIVE</code> or <code>CREATE_FAILED</code>.
        /// To get the status, use the <a>DescribeForecast</a> operation.
        /// 
        ///  
        /// <para>
        /// You can't delete a forecast while it is being exported. After a forecast is deleted,
        /// you can no longer query the forecast.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteForecast service method.</param>
        /// 
        /// <returns>The response from the DeleteForecast service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecast">REST API Reference for DeleteForecast Operation</seealso>
        DeleteForecastResponse DeleteForecast(DeleteForecastRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteForecast operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteForecast operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteForecast
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecast">REST API Reference for DeleteForecast Operation</seealso>
        IAsyncResult BeginDeleteForecast(DeleteForecastRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteForecast operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteForecast.</param>
        /// 
        /// <returns>Returns a  DeleteForecastResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecast">REST API Reference for DeleteForecast Operation</seealso>
        DeleteForecastResponse EndDeleteForecast(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteForecastExportJob


        /// <summary>
        /// Deletes a forecast export job created using the <a>CreateForecastExportJob</a> operation.
        /// You can delete only export jobs that have a status of <code>ACTIVE</code> or <code>CREATE_FAILED</code>.
        /// To get the status, use the <a>DescribeForecastExportJob</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteForecastExportJob service method.</param>
        /// 
        /// <returns>The response from the DeleteForecastExportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecastExportJob">REST API Reference for DeleteForecastExportJob Operation</seealso>
        DeleteForecastExportJobResponse DeleteForecastExportJob(DeleteForecastExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteForecastExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteForecastExportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteForecastExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecastExportJob">REST API Reference for DeleteForecastExportJob Operation</seealso>
        IAsyncResult BeginDeleteForecastExportJob(DeleteForecastExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteForecastExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteForecastExportJob.</param>
        /// 
        /// <returns>Returns a  DeleteForecastExportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecastExportJob">REST API Reference for DeleteForecastExportJob Operation</seealso>
        DeleteForecastExportJobResponse EndDeleteForecastExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMonitor


        /// <summary>
        /// Deletes a monitor resource. You can only delete a monitor resource with a status of
        /// <code>ACTIVE</code>, <code>ACTIVE_STOPPED</code>, <code>CREATE_FAILED</code>, or <code>CREATE_STOPPED</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor service method.</param>
        /// 
        /// <returns>The response from the DeleteMonitor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        DeleteMonitorResponse DeleteMonitor(DeleteMonitorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        IAsyncResult BeginDeleteMonitor(DeleteMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMonitor.</param>
        /// 
        /// <returns>Returns a  DeleteMonitorResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        DeleteMonitorResponse EndDeleteMonitor(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePredictor


        /// <summary>
        /// Deletes a predictor created using the <a>DescribePredictor</a> or <a>CreatePredictor</a>
        /// operations. You can delete only predictor that have a status of <code>ACTIVE</code>
        /// or <code>CREATE_FAILED</code>. To get the status, use the <a>DescribePredictor</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePredictor service method.</param>
        /// 
        /// <returns>The response from the DeletePredictor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeletePredictor">REST API Reference for DeletePredictor Operation</seealso>
        DeletePredictorResponse DeletePredictor(DeletePredictorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePredictor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePredictor operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePredictor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeletePredictor">REST API Reference for DeletePredictor Operation</seealso>
        IAsyncResult BeginDeletePredictor(DeletePredictorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePredictor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePredictor.</param>
        /// 
        /// <returns>Returns a  DeletePredictorResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeletePredictor">REST API Reference for DeletePredictor Operation</seealso>
        DeletePredictorResponse EndDeletePredictor(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePredictorBacktestExportJob


        /// <summary>
        /// Deletes a predictor backtest export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePredictorBacktestExportJob service method.</param>
        /// 
        /// <returns>The response from the DeletePredictorBacktestExportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeletePredictorBacktestExportJob">REST API Reference for DeletePredictorBacktestExportJob Operation</seealso>
        DeletePredictorBacktestExportJobResponse DeletePredictorBacktestExportJob(DeletePredictorBacktestExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePredictorBacktestExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePredictorBacktestExportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePredictorBacktestExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeletePredictorBacktestExportJob">REST API Reference for DeletePredictorBacktestExportJob Operation</seealso>
        IAsyncResult BeginDeletePredictorBacktestExportJob(DeletePredictorBacktestExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePredictorBacktestExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePredictorBacktestExportJob.</param>
        /// 
        /// <returns>Returns a  DeletePredictorBacktestExportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeletePredictorBacktestExportJob">REST API Reference for DeletePredictorBacktestExportJob Operation</seealso>
        DeletePredictorBacktestExportJobResponse EndDeletePredictorBacktestExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResourceTree


        /// <summary>
        /// Deletes an entire resource tree. This operation will delete the parent resource and
        /// its child resources.
        /// 
        ///  
        /// <para>
        /// Child resources are resources that were created from another resource. For example,
        /// when a forecast is generated from a predictor, the forecast is the child resource
        /// and the predictor is the parent resource.
        /// </para>
        ///  
        /// <para>
        /// Amazon Forecast resources possess the following parent-child resource hierarchies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Dataset</b>: dataset import jobs
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Dataset Group</b>: predictors, predictor backtest export jobs, forecasts, forecast
        /// export jobs
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Predictor</b>: predictor backtest export jobs, forecasts, forecast export jobs
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Forecast</b>: forecast export jobs
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  <code>DeleteResourceTree</code> will only delete Amazon Forecast resources, and will
        /// not delete datasets or exported files stored in Amazon S3. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceTree service method.</param>
        /// 
        /// <returns>The response from the DeleteResourceTree service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteResourceTree">REST API Reference for DeleteResourceTree Operation</seealso>
        DeleteResourceTreeResponse DeleteResourceTree(DeleteResourceTreeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourceTree operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceTree operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourceTree
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteResourceTree">REST API Reference for DeleteResourceTree Operation</seealso>
        IAsyncResult BeginDeleteResourceTree(DeleteResourceTreeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourceTree operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourceTree.</param>
        /// 
        /// <returns>Returns a  DeleteResourceTreeResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteResourceTree">REST API Reference for DeleteResourceTree Operation</seealso>
        DeleteResourceTreeResponse EndDeleteResourceTree(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWhatIfAnalysis


        /// <summary>
        /// Deletes a what-if analysis created using the <a>CreateWhatIfAnalysis</a> operation.
        /// You can delete only what-if analyses that have a status of <code>ACTIVE</code> or
        /// <code>CREATE_FAILED</code>. To get the status, use the <a>DescribeWhatIfAnalysis</a>
        /// operation. 
        /// 
        ///  
        /// <para>
        /// You can't delete a what-if analysis while any of its forecasts are being exported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatIfAnalysis service method.</param>
        /// 
        /// <returns>The response from the DeleteWhatIfAnalysis service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteWhatIfAnalysis">REST API Reference for DeleteWhatIfAnalysis Operation</seealso>
        DeleteWhatIfAnalysisResponse DeleteWhatIfAnalysis(DeleteWhatIfAnalysisRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWhatIfAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatIfAnalysis operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWhatIfAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteWhatIfAnalysis">REST API Reference for DeleteWhatIfAnalysis Operation</seealso>
        IAsyncResult BeginDeleteWhatIfAnalysis(DeleteWhatIfAnalysisRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWhatIfAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWhatIfAnalysis.</param>
        /// 
        /// <returns>Returns a  DeleteWhatIfAnalysisResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteWhatIfAnalysis">REST API Reference for DeleteWhatIfAnalysis Operation</seealso>
        DeleteWhatIfAnalysisResponse EndDeleteWhatIfAnalysis(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWhatIfForecast


        /// <summary>
        /// Deletes a what-if forecast created using the <a>CreateWhatIfForecast</a> operation.
        /// You can delete only what-if forecasts that have a status of <code>ACTIVE</code> or
        /// <code>CREATE_FAILED</code>. To get the status, use the <a>DescribeWhatIfForecast</a>
        /// operation. 
        /// 
        ///  
        /// <para>
        /// You can't delete a what-if forecast while it is being exported. After a what-if forecast
        /// is deleted, you can no longer query the what-if analysis.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatIfForecast service method.</param>
        /// 
        /// <returns>The response from the DeleteWhatIfForecast service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteWhatIfForecast">REST API Reference for DeleteWhatIfForecast Operation</seealso>
        DeleteWhatIfForecastResponse DeleteWhatIfForecast(DeleteWhatIfForecastRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWhatIfForecast operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatIfForecast operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWhatIfForecast
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteWhatIfForecast">REST API Reference for DeleteWhatIfForecast Operation</seealso>
        IAsyncResult BeginDeleteWhatIfForecast(DeleteWhatIfForecastRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWhatIfForecast operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWhatIfForecast.</param>
        /// 
        /// <returns>Returns a  DeleteWhatIfForecastResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteWhatIfForecast">REST API Reference for DeleteWhatIfForecast Operation</seealso>
        DeleteWhatIfForecastResponse EndDeleteWhatIfForecast(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWhatIfForecastExport


        /// <summary>
        /// Deletes a what-if forecast export created using the <a>CreateWhatIfForecastExport</a>
        /// operation. You can delete only what-if forecast exports that have a status of <code>ACTIVE</code>
        /// or <code>CREATE_FAILED</code>. To get the status, use the <a>DescribeWhatIfForecastExport</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatIfForecastExport service method.</param>
        /// 
        /// <returns>The response from the DeleteWhatIfForecastExport service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteWhatIfForecastExport">REST API Reference for DeleteWhatIfForecastExport Operation</seealso>
        DeleteWhatIfForecastExportResponse DeleteWhatIfForecastExport(DeleteWhatIfForecastExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWhatIfForecastExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatIfForecastExport operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWhatIfForecastExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteWhatIfForecastExport">REST API Reference for DeleteWhatIfForecastExport Operation</seealso>
        IAsyncResult BeginDeleteWhatIfForecastExport(DeleteWhatIfForecastExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWhatIfForecastExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWhatIfForecastExport.</param>
        /// 
        /// <returns>Returns a  DeleteWhatIfForecastExportResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteWhatIfForecastExport">REST API Reference for DeleteWhatIfForecastExport Operation</seealso>
        DeleteWhatIfForecastExportResponse EndDeleteWhatIfForecastExport(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAutoPredictor


        /// <summary>
        /// Describes a predictor created using the CreateAutoPredictor operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoPredictor service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoPredictor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeAutoPredictor">REST API Reference for DescribeAutoPredictor Operation</seealso>
        DescribeAutoPredictorResponse DescribeAutoPredictor(DescribeAutoPredictorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoPredictor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoPredictor operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAutoPredictor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeAutoPredictor">REST API Reference for DescribeAutoPredictor Operation</seealso>
        IAsyncResult BeginDescribeAutoPredictor(DescribeAutoPredictorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAutoPredictor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoPredictor.</param>
        /// 
        /// <returns>Returns a  DescribeAutoPredictorResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeAutoPredictor">REST API Reference for DescribeAutoPredictor Operation</seealso>
        DescribeAutoPredictorResponse EndDescribeAutoPredictor(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataset


        /// <summary>
        /// Describes an Amazon Forecast dataset created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDataset.html">CreateDataset</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the parameters specified in the <code>CreateDataset</code>
        /// request, this operation includes the following dataset properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        IAsyncResult BeginDescribeDataset(DescribeDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataset.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        DescribeDatasetResponse EndDescribeDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDatasetGroup


        /// <summary>
        /// Describes a dataset group created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetGroup.html">CreateDatasetGroup</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the parameters provided in the <code>CreateDatasetGroup</code>
        /// request, this operation includes the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DatasetArns</code> - The datasets belonging to the group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeDatasetGroup service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetGroup">REST API Reference for DescribeDatasetGroup Operation</seealso>
        DescribeDatasetGroupResponse DescribeDatasetGroup(DescribeDatasetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetGroup operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDatasetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetGroup">REST API Reference for DescribeDatasetGroup Operation</seealso>
        IAsyncResult BeginDescribeDatasetGroup(DescribeDatasetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDatasetGroup.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetGroupResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetGroup">REST API Reference for DescribeDatasetGroup Operation</seealso>
        DescribeDatasetGroupResponse EndDescribeDatasetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDatasetImportJob


        /// <summary>
        /// Describes a dataset import job created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetImportJob.html">CreateDatasetImportJob</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the parameters provided in the <code>CreateDatasetImportJob</code>
        /// request, this operation includes the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DataSize</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FieldStatistics</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetImportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeDatasetImportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetImportJob">REST API Reference for DescribeDatasetImportJob Operation</seealso>
        DescribeDatasetImportJobResponse DescribeDatasetImportJob(DescribeDatasetImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetImportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDatasetImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetImportJob">REST API Reference for DescribeDatasetImportJob Operation</seealso>
        IAsyncResult BeginDescribeDatasetImportJob(DescribeDatasetImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDatasetImportJob.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetImportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetImportJob">REST API Reference for DescribeDatasetImportJob Operation</seealso>
        DescribeDatasetImportJobResponse EndDescribeDatasetImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeExplainability


        /// <summary>
        /// Describes an Explainability resource created using the <a>CreateExplainability</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExplainability service method.</param>
        /// 
        /// <returns>The response from the DescribeExplainability service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeExplainability">REST API Reference for DescribeExplainability Operation</seealso>
        DescribeExplainabilityResponse DescribeExplainability(DescribeExplainabilityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExplainability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExplainability operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExplainability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeExplainability">REST API Reference for DescribeExplainability Operation</seealso>
        IAsyncResult BeginDescribeExplainability(DescribeExplainabilityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExplainability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExplainability.</param>
        /// 
        /// <returns>Returns a  DescribeExplainabilityResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeExplainability">REST API Reference for DescribeExplainability Operation</seealso>
        DescribeExplainabilityResponse EndDescribeExplainability(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeExplainabilityExport


        /// <summary>
        /// Describes an Explainability export created using the <a>CreateExplainabilityExport</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExplainabilityExport service method.</param>
        /// 
        /// <returns>The response from the DescribeExplainabilityExport service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeExplainabilityExport">REST API Reference for DescribeExplainabilityExport Operation</seealso>
        DescribeExplainabilityExportResponse DescribeExplainabilityExport(DescribeExplainabilityExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExplainabilityExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExplainabilityExport operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExplainabilityExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeExplainabilityExport">REST API Reference for DescribeExplainabilityExport Operation</seealso>
        IAsyncResult BeginDescribeExplainabilityExport(DescribeExplainabilityExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExplainabilityExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExplainabilityExport.</param>
        /// 
        /// <returns>Returns a  DescribeExplainabilityExportResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeExplainabilityExport">REST API Reference for DescribeExplainabilityExport Operation</seealso>
        DescribeExplainabilityExportResponse EndDescribeExplainabilityExport(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeForecast


        /// <summary>
        /// Describes a forecast created using the <a>CreateForecast</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided in the <code>CreateForecast</code>
        /// request, this operation lists the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DatasetGroupArn</code> - The dataset group that provided the training data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeForecast service method.</param>
        /// 
        /// <returns>The response from the DescribeForecast service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecast">REST API Reference for DescribeForecast Operation</seealso>
        DescribeForecastResponse DescribeForecast(DescribeForecastRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeForecast operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeForecast operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeForecast
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecast">REST API Reference for DescribeForecast Operation</seealso>
        IAsyncResult BeginDescribeForecast(DescribeForecastRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeForecast operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeForecast.</param>
        /// 
        /// <returns>Returns a  DescribeForecastResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecast">REST API Reference for DescribeForecast Operation</seealso>
        DescribeForecastResponse EndDescribeForecast(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeForecastExportJob


        /// <summary>
        /// Describes a forecast export job created using the <a>CreateForecastExportJob</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided by the user in the <code>CreateForecastExportJob</code>
        /// request, this operation lists the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeForecastExportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeForecastExportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecastExportJob">REST API Reference for DescribeForecastExportJob Operation</seealso>
        DescribeForecastExportJobResponse DescribeForecastExportJob(DescribeForecastExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeForecastExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeForecastExportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeForecastExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecastExportJob">REST API Reference for DescribeForecastExportJob Operation</seealso>
        IAsyncResult BeginDescribeForecastExportJob(DescribeForecastExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeForecastExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeForecastExportJob.</param>
        /// 
        /// <returns>Returns a  DescribeForecastExportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecastExportJob">REST API Reference for DescribeForecastExportJob Operation</seealso>
        DescribeForecastExportJobResponse EndDescribeForecastExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeMonitor


        /// <summary>
        /// Describes a monitor resource. In addition to listing the properties provided in the
        /// <a>CreateMonitor</a> request, this operation lists the following properties:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>Baseline</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastEvaluationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastEvaluationState</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMonitor service method.</param>
        /// 
        /// <returns>The response from the DescribeMonitor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeMonitor">REST API Reference for DescribeMonitor Operation</seealso>
        DescribeMonitorResponse DescribeMonitor(DescribeMonitorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMonitor operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeMonitor">REST API Reference for DescribeMonitor Operation</seealso>
        IAsyncResult BeginDescribeMonitor(DescribeMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMonitor.</param>
        /// 
        /// <returns>Returns a  DescribeMonitorResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeMonitor">REST API Reference for DescribeMonitor Operation</seealso>
        DescribeMonitorResponse EndDescribeMonitor(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePredictor


        /// <summary>
        /// <note> 
        /// <para>
        ///  This operation is only valid for legacy predictors created with CreatePredictor.
        /// If you are not using a legacy predictor, use <a>DescribeAutoPredictor</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Describes a predictor created using the <a>CreatePredictor</a> operation.
        /// </para>
        ///  
        /// <para>
        /// In addition to listing the properties provided in the <code>CreatePredictor</code>
        /// request, this operation lists the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DatasetImportJobArns</code> - The dataset import jobs used to import training
        /// data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AutoMLAlgorithmArns</code> - If AutoML is performed, the algorithms that were
        /// evaluated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePredictor service method.</param>
        /// 
        /// <returns>The response from the DescribePredictor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribePredictor">REST API Reference for DescribePredictor Operation</seealso>
        DescribePredictorResponse DescribePredictor(DescribePredictorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePredictor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePredictor operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePredictor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribePredictor">REST API Reference for DescribePredictor Operation</seealso>
        IAsyncResult BeginDescribePredictor(DescribePredictorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePredictor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePredictor.</param>
        /// 
        /// <returns>Returns a  DescribePredictorResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribePredictor">REST API Reference for DescribePredictor Operation</seealso>
        DescribePredictorResponse EndDescribePredictor(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePredictorBacktestExportJob


        /// <summary>
        /// Describes a predictor backtest export job created using the <a>CreatePredictorBacktestExportJob</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided by the user in the <code>CreatePredictorBacktestExportJob</code>
        /// request, this operation lists the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> (if an error occurred)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePredictorBacktestExportJob service method.</param>
        /// 
        /// <returns>The response from the DescribePredictorBacktestExportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribePredictorBacktestExportJob">REST API Reference for DescribePredictorBacktestExportJob Operation</seealso>
        DescribePredictorBacktestExportJobResponse DescribePredictorBacktestExportJob(DescribePredictorBacktestExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePredictorBacktestExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePredictorBacktestExportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePredictorBacktestExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribePredictorBacktestExportJob">REST API Reference for DescribePredictorBacktestExportJob Operation</seealso>
        IAsyncResult BeginDescribePredictorBacktestExportJob(DescribePredictorBacktestExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePredictorBacktestExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePredictorBacktestExportJob.</param>
        /// 
        /// <returns>Returns a  DescribePredictorBacktestExportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribePredictorBacktestExportJob">REST API Reference for DescribePredictorBacktestExportJob Operation</seealso>
        DescribePredictorBacktestExportJobResponse EndDescribePredictorBacktestExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeWhatIfAnalysis


        /// <summary>
        /// Describes the what-if analysis created using the <a>CreateWhatIfAnalysis</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided in the <code>CreateWhatIfAnalysis</code>
        /// request, this operation lists the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWhatIfAnalysis service method.</param>
        /// 
        /// <returns>The response from the DescribeWhatIfAnalysis service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeWhatIfAnalysis">REST API Reference for DescribeWhatIfAnalysis Operation</seealso>
        DescribeWhatIfAnalysisResponse DescribeWhatIfAnalysis(DescribeWhatIfAnalysisRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWhatIfAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWhatIfAnalysis operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWhatIfAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeWhatIfAnalysis">REST API Reference for DescribeWhatIfAnalysis Operation</seealso>
        IAsyncResult BeginDescribeWhatIfAnalysis(DescribeWhatIfAnalysisRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWhatIfAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWhatIfAnalysis.</param>
        /// 
        /// <returns>Returns a  DescribeWhatIfAnalysisResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeWhatIfAnalysis">REST API Reference for DescribeWhatIfAnalysis Operation</seealso>
        DescribeWhatIfAnalysisResponse EndDescribeWhatIfAnalysis(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeWhatIfForecast


        /// <summary>
        /// Describes the what-if forecast created using the <a>CreateWhatIfForecast</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided in the <code>CreateWhatIfForecast</code>
        /// request, this operation lists the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWhatIfForecast service method.</param>
        /// 
        /// <returns>The response from the DescribeWhatIfForecast service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeWhatIfForecast">REST API Reference for DescribeWhatIfForecast Operation</seealso>
        DescribeWhatIfForecastResponse DescribeWhatIfForecast(DescribeWhatIfForecastRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWhatIfForecast operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWhatIfForecast operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWhatIfForecast
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeWhatIfForecast">REST API Reference for DescribeWhatIfForecast Operation</seealso>
        IAsyncResult BeginDescribeWhatIfForecast(DescribeWhatIfForecastRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWhatIfForecast operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWhatIfForecast.</param>
        /// 
        /// <returns>Returns a  DescribeWhatIfForecastResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeWhatIfForecast">REST API Reference for DescribeWhatIfForecast Operation</seealso>
        DescribeWhatIfForecastResponse EndDescribeWhatIfForecast(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeWhatIfForecastExport


        /// <summary>
        /// Describes the what-if forecast export created using the <a>CreateWhatIfForecastExport</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided in the <code>CreateWhatIfForecastExport</code>
        /// request, this operation lists the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWhatIfForecastExport service method.</param>
        /// 
        /// <returns>The response from the DescribeWhatIfForecastExport service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeWhatIfForecastExport">REST API Reference for DescribeWhatIfForecastExport Operation</seealso>
        DescribeWhatIfForecastExportResponse DescribeWhatIfForecastExport(DescribeWhatIfForecastExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWhatIfForecastExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWhatIfForecastExport operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWhatIfForecastExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeWhatIfForecastExport">REST API Reference for DescribeWhatIfForecastExport Operation</seealso>
        IAsyncResult BeginDescribeWhatIfForecastExport(DescribeWhatIfForecastExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWhatIfForecastExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWhatIfForecastExport.</param>
        /// 
        /// <returns>Returns a  DescribeWhatIfForecastExportResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeWhatIfForecastExport">REST API Reference for DescribeWhatIfForecastExport Operation</seealso>
        DescribeWhatIfForecastExportResponse EndDescribeWhatIfForecastExport(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccuracyMetrics


        /// <summary>
        /// Provides metrics on the accuracy of the models that were trained by the <a>CreatePredictor</a>
        /// operation. Use metrics to see how well the model performed and to decide whether to
        /// use the predictor to generate a forecast. For more information, see <a href="https://docs.aws.amazon.com/forecast/latest/dg/metrics.html">Predictor
        /// Metrics</a>.
        /// 
        ///  
        /// <para>
        /// This operation generates metrics for each backtest window that was evaluated. The
        /// number of backtest windows (<code>NumberOfBacktestWindows</code>) is specified using
        /// the <a>EvaluationParameters</a> object, which is optionally included in the <code>CreatePredictor</code>
        /// request. If <code>NumberOfBacktestWindows</code> isn't specified, the number defaults
        /// to one.
        /// </para>
        ///  
        /// <para>
        /// The parameters of the <code>filling</code> method determine which items contribute
        /// to the metrics. If you want all items to contribute, specify <code>zero</code>. If
        /// you want only those items that have complete data in the range being evaluated to
        /// contribute, specify <code>nan</code>. For more information, see <a>FeaturizationMethod</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before you can get accuracy metrics, the <code>Status</code> of the predictor must
        /// be <code>ACTIVE</code>, signifying that training has completed. To get the status,
        /// use the <a>DescribePredictor</a> operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccuracyMetrics service method.</param>
        /// 
        /// <returns>The response from the GetAccuracyMetrics service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/GetAccuracyMetrics">REST API Reference for GetAccuracyMetrics Operation</seealso>
        GetAccuracyMetricsResponse GetAccuracyMetrics(GetAccuracyMetricsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccuracyMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccuracyMetrics operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccuracyMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/GetAccuracyMetrics">REST API Reference for GetAccuracyMetrics Operation</seealso>
        IAsyncResult BeginGetAccuracyMetrics(GetAccuracyMetricsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccuracyMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccuracyMetrics.</param>
        /// 
        /// <returns>Returns a  GetAccuracyMetricsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/GetAccuracyMetrics">REST API Reference for GetAccuracyMetrics Operation</seealso>
        GetAccuracyMetricsResponse EndGetAccuracyMetrics(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatasetGroups


        /// <summary>
        /// Returns a list of dataset groups created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetGroup.html">CreateDatasetGroup</a>
        /// operation. For each dataset group, this operation returns a summary of its properties,
        /// including its Amazon Resource Name (ARN). You can retrieve the complete set of properties
        /// by using the dataset group ARN with the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDatasetGroup.html">DescribeDatasetGroup</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetGroups service method.</param>
        /// 
        /// <returns>The response from the ListDatasetGroups service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetGroups">REST API Reference for ListDatasetGroups Operation</seealso>
        ListDatasetGroupsResponse ListDatasetGroups(ListDatasetGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetGroups operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasetGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetGroups">REST API Reference for ListDatasetGroups Operation</seealso>
        IAsyncResult BeginListDatasetGroups(ListDatasetGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasetGroups.</param>
        /// 
        /// <returns>Returns a  ListDatasetGroupsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetGroups">REST API Reference for ListDatasetGroups Operation</seealso>
        ListDatasetGroupsResponse EndListDatasetGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatasetImportJobs


        /// <summary>
        /// Returns a list of dataset import jobs created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetImportJob.html">CreateDatasetImportJob</a>
        /// operation. For each import job, this operation returns a summary of its properties,
        /// including its Amazon Resource Name (ARN). You can retrieve the complete set of properties
        /// by using the ARN with the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDatasetImportJob.html">DescribeDatasetImportJob</a>
        /// operation. You can filter the list by providing an array of <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_Filter.html">Filter</a>
        /// objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListDatasetImportJobs service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetImportJobs">REST API Reference for ListDatasetImportJobs Operation</seealso>
        ListDatasetImportJobsResponse ListDatasetImportJobs(ListDatasetImportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetImportJobs operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasetImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetImportJobs">REST API Reference for ListDatasetImportJobs Operation</seealso>
        IAsyncResult BeginListDatasetImportJobs(ListDatasetImportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasetImportJobs.</param>
        /// 
        /// <returns>Returns a  ListDatasetImportJobsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetImportJobs">REST API Reference for ListDatasetImportJobs Operation</seealso>
        ListDatasetImportJobsResponse EndListDatasetImportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatasets


        /// <summary>
        /// Returns a list of datasets created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDataset.html">CreateDataset</a>
        /// operation. For each dataset, a summary of its properties, including its Amazon Resource
        /// Name (ARN), is returned. To retrieve the complete set of properties, use the ARN with
        /// the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDataset.html">DescribeDataset</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        ListDatasetsResponse ListDatasets(ListDatasetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        IAsyncResult BeginListDatasets(ListDatasetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasets.</param>
        /// 
        /// <returns>Returns a  ListDatasetsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        ListDatasetsResponse EndListDatasets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListExplainabilities


        /// <summary>
        /// Returns a list of Explainability resources created using the <a>CreateExplainability</a>
        /// operation. This operation returns a summary for each Explainability. You can filter
        /// the list using an array of <a>Filter</a> objects.
        /// 
        ///  
        /// <para>
        /// To retrieve the complete set of properties for a particular Explainability resource,
        /// use the ARN with the <a>DescribeExplainability</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExplainabilities service method.</param>
        /// 
        /// <returns>The response from the ListExplainabilities service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListExplainabilities">REST API Reference for ListExplainabilities Operation</seealso>
        ListExplainabilitiesResponse ListExplainabilities(ListExplainabilitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListExplainabilities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExplainabilities operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExplainabilities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListExplainabilities">REST API Reference for ListExplainabilities Operation</seealso>
        IAsyncResult BeginListExplainabilities(ListExplainabilitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListExplainabilities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExplainabilities.</param>
        /// 
        /// <returns>Returns a  ListExplainabilitiesResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListExplainabilities">REST API Reference for ListExplainabilities Operation</seealso>
        ListExplainabilitiesResponse EndListExplainabilities(IAsyncResult asyncResult);

        #endregion
        
        #region  ListExplainabilityExports


        /// <summary>
        /// Returns a list of Explainability exports created using the <a>CreateExplainabilityExport</a>
        /// operation. This operation returns a summary for each Explainability export. You can
        /// filter the list using an array of <a>Filter</a> objects.
        /// 
        ///  
        /// <para>
        /// To retrieve the complete set of properties for a particular Explainability export,
        /// use the ARN with the <a>DescribeExplainability</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExplainabilityExports service method.</param>
        /// 
        /// <returns>The response from the ListExplainabilityExports service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListExplainabilityExports">REST API Reference for ListExplainabilityExports Operation</seealso>
        ListExplainabilityExportsResponse ListExplainabilityExports(ListExplainabilityExportsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListExplainabilityExports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExplainabilityExports operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExplainabilityExports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListExplainabilityExports">REST API Reference for ListExplainabilityExports Operation</seealso>
        IAsyncResult BeginListExplainabilityExports(ListExplainabilityExportsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListExplainabilityExports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExplainabilityExports.</param>
        /// 
        /// <returns>Returns a  ListExplainabilityExportsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListExplainabilityExports">REST API Reference for ListExplainabilityExports Operation</seealso>
        ListExplainabilityExportsResponse EndListExplainabilityExports(IAsyncResult asyncResult);

        #endregion
        
        #region  ListForecastExportJobs


        /// <summary>
        /// Returns a list of forecast export jobs created using the <a>CreateForecastExportJob</a>
        /// operation. For each forecast export job, this operation returns a summary of its properties,
        /// including its Amazon Resource Name (ARN). To retrieve the complete set of properties,
        /// use the ARN with the <a>DescribeForecastExportJob</a> operation. You can filter the
        /// list using an array of <a>Filter</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListForecastExportJobs service method.</param>
        /// 
        /// <returns>The response from the ListForecastExportJobs service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecastExportJobs">REST API Reference for ListForecastExportJobs Operation</seealso>
        ListForecastExportJobsResponse ListForecastExportJobs(ListForecastExportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListForecastExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListForecastExportJobs operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListForecastExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecastExportJobs">REST API Reference for ListForecastExportJobs Operation</seealso>
        IAsyncResult BeginListForecastExportJobs(ListForecastExportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListForecastExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListForecastExportJobs.</param>
        /// 
        /// <returns>Returns a  ListForecastExportJobsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecastExportJobs">REST API Reference for ListForecastExportJobs Operation</seealso>
        ListForecastExportJobsResponse EndListForecastExportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListForecasts


        /// <summary>
        /// Returns a list of forecasts created using the <a>CreateForecast</a> operation. For
        /// each forecast, this operation returns a summary of its properties, including its Amazon
        /// Resource Name (ARN). To retrieve the complete set of properties, specify the ARN with
        /// the <a>DescribeForecast</a> operation. You can filter the list using an array of <a>Filter</a>
        /// objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListForecasts service method.</param>
        /// 
        /// <returns>The response from the ListForecasts service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecasts">REST API Reference for ListForecasts Operation</seealso>
        ListForecastsResponse ListForecasts(ListForecastsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListForecasts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListForecasts operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListForecasts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecasts">REST API Reference for ListForecasts Operation</seealso>
        IAsyncResult BeginListForecasts(ListForecastsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListForecasts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListForecasts.</param>
        /// 
        /// <returns>Returns a  ListForecastsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecasts">REST API Reference for ListForecasts Operation</seealso>
        ListForecastsResponse EndListForecasts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMonitorEvaluations


        /// <summary>
        /// Returns a list of the monitoring evaluation results and predictor events collected
        /// by the monitor resource during different windows of time.
        /// 
        ///  
        /// <para>
        /// For information about monitoring see <a>predictor-monitoring</a>. For more information
        /// about retrieving monitoring results see <a href="https://docs.aws.amazon.com/forecast/latest/dg/predictor-monitoring-results.html">Viewing
        /// Monitoring Results</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitorEvaluations service method.</param>
        /// 
        /// <returns>The response from the ListMonitorEvaluations service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListMonitorEvaluations">REST API Reference for ListMonitorEvaluations Operation</seealso>
        ListMonitorEvaluationsResponse ListMonitorEvaluations(ListMonitorEvaluationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMonitorEvaluations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMonitorEvaluations operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMonitorEvaluations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListMonitorEvaluations">REST API Reference for ListMonitorEvaluations Operation</seealso>
        IAsyncResult BeginListMonitorEvaluations(ListMonitorEvaluationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMonitorEvaluations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMonitorEvaluations.</param>
        /// 
        /// <returns>Returns a  ListMonitorEvaluationsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListMonitorEvaluations">REST API Reference for ListMonitorEvaluations Operation</seealso>
        ListMonitorEvaluationsResponse EndListMonitorEvaluations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMonitors


        /// <summary>
        /// Returns a list of monitors created with the <a>CreateMonitor</a> operation and <a>CreateAutoPredictor</a>
        /// operation. For each monitor resource, this operation returns of a summary of its properties,
        /// including its Amazon Resource Name (ARN). You can retrieve a complete set of properties
        /// of a monitor resource by specify the monitor's ARN in the <a>DescribeMonitor</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors service method.</param>
        /// 
        /// <returns>The response from the ListMonitors service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        ListMonitorsResponse ListMonitors(ListMonitorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMonitors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMonitors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        IAsyncResult BeginListMonitors(ListMonitorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMonitors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMonitors.</param>
        /// 
        /// <returns>Returns a  ListMonitorsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        ListMonitorsResponse EndListMonitors(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPredictorBacktestExportJobs


        /// <summary>
        /// Returns a list of predictor backtest export jobs created using the <a>CreatePredictorBacktestExportJob</a>
        /// operation. This operation returns a summary for each backtest export job. You can
        /// filter the list using an array of <a>Filter</a> objects.
        /// 
        ///  
        /// <para>
        /// To retrieve the complete set of properties for a particular backtest export job, use
        /// the ARN with the <a>DescribePredictorBacktestExportJob</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPredictorBacktestExportJobs service method.</param>
        /// 
        /// <returns>The response from the ListPredictorBacktestExportJobs service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListPredictorBacktestExportJobs">REST API Reference for ListPredictorBacktestExportJobs Operation</seealso>
        ListPredictorBacktestExportJobsResponse ListPredictorBacktestExportJobs(ListPredictorBacktestExportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPredictorBacktestExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPredictorBacktestExportJobs operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPredictorBacktestExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListPredictorBacktestExportJobs">REST API Reference for ListPredictorBacktestExportJobs Operation</seealso>
        IAsyncResult BeginListPredictorBacktestExportJobs(ListPredictorBacktestExportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPredictorBacktestExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPredictorBacktestExportJobs.</param>
        /// 
        /// <returns>Returns a  ListPredictorBacktestExportJobsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListPredictorBacktestExportJobs">REST API Reference for ListPredictorBacktestExportJobs Operation</seealso>
        ListPredictorBacktestExportJobsResponse EndListPredictorBacktestExportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPredictors


        /// <summary>
        /// Returns a list of predictors created using the <a>CreateAutoPredictor</a> or <a>CreatePredictor</a>
        /// operations. For each predictor, this operation returns a summary of its properties,
        /// including its Amazon Resource Name (ARN). 
        /// 
        ///  
        /// <para>
        /// You can retrieve the complete set of properties by using the ARN with the <a>DescribeAutoPredictor</a>
        /// and <a>DescribePredictor</a> operations. You can filter the list using an array of
        /// <a>Filter</a> objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPredictors service method.</param>
        /// 
        /// <returns>The response from the ListPredictors service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListPredictors">REST API Reference for ListPredictors Operation</seealso>
        ListPredictorsResponse ListPredictors(ListPredictorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPredictors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPredictors operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPredictors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListPredictors">REST API Reference for ListPredictors Operation</seealso>
        IAsyncResult BeginListPredictors(ListPredictorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPredictors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPredictors.</param>
        /// 
        /// <returns>Returns a  ListPredictorsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListPredictors">REST API Reference for ListPredictors Operation</seealso>
        ListPredictorsResponse EndListPredictors(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for an Amazon Forecast resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWhatIfAnalyses


        /// <summary>
        /// Returns a list of what-if analyses created using the <a>CreateWhatIfAnalysis</a> operation.
        /// For each what-if analysis, this operation returns a summary of its properties, including
        /// its Amazon Resource Name (ARN). You can retrieve the complete set of properties by
        /// using the what-if analysis ARN with the <a>DescribeWhatIfAnalysis</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWhatIfAnalyses service method.</param>
        /// 
        /// <returns>The response from the ListWhatIfAnalyses service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListWhatIfAnalyses">REST API Reference for ListWhatIfAnalyses Operation</seealso>
        ListWhatIfAnalysesResponse ListWhatIfAnalyses(ListWhatIfAnalysesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWhatIfAnalyses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWhatIfAnalyses operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWhatIfAnalyses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListWhatIfAnalyses">REST API Reference for ListWhatIfAnalyses Operation</seealso>
        IAsyncResult BeginListWhatIfAnalyses(ListWhatIfAnalysesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWhatIfAnalyses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWhatIfAnalyses.</param>
        /// 
        /// <returns>Returns a  ListWhatIfAnalysesResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListWhatIfAnalyses">REST API Reference for ListWhatIfAnalyses Operation</seealso>
        ListWhatIfAnalysesResponse EndListWhatIfAnalyses(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWhatIfForecastExports


        /// <summary>
        /// Returns a list of what-if forecast exports created using the <a>CreateWhatIfForecastExport</a>
        /// operation. For each what-if forecast export, this operation returns a summary of its
        /// properties, including its Amazon Resource Name (ARN). You can retrieve the complete
        /// set of properties by using the what-if forecast export ARN with the <a>DescribeWhatIfForecastExport</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWhatIfForecastExports service method.</param>
        /// 
        /// <returns>The response from the ListWhatIfForecastExports service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListWhatIfForecastExports">REST API Reference for ListWhatIfForecastExports Operation</seealso>
        ListWhatIfForecastExportsResponse ListWhatIfForecastExports(ListWhatIfForecastExportsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWhatIfForecastExports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWhatIfForecastExports operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWhatIfForecastExports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListWhatIfForecastExports">REST API Reference for ListWhatIfForecastExports Operation</seealso>
        IAsyncResult BeginListWhatIfForecastExports(ListWhatIfForecastExportsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWhatIfForecastExports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWhatIfForecastExports.</param>
        /// 
        /// <returns>Returns a  ListWhatIfForecastExportsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListWhatIfForecastExports">REST API Reference for ListWhatIfForecastExports Operation</seealso>
        ListWhatIfForecastExportsResponse EndListWhatIfForecastExports(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWhatIfForecasts


        /// <summary>
        /// Returns a list of what-if forecasts created using the <a>CreateWhatIfForecast</a>
        /// operation. For each what-if forecast, this operation returns a summary of its properties,
        /// including its Amazon Resource Name (ARN). You can retrieve the complete set of properties
        /// by using the what-if forecast ARN with the <a>DescribeWhatIfForecast</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWhatIfForecasts service method.</param>
        /// 
        /// <returns>The response from the ListWhatIfForecasts service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListWhatIfForecasts">REST API Reference for ListWhatIfForecasts Operation</seealso>
        ListWhatIfForecastsResponse ListWhatIfForecasts(ListWhatIfForecastsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWhatIfForecasts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWhatIfForecasts operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWhatIfForecasts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListWhatIfForecasts">REST API Reference for ListWhatIfForecasts Operation</seealso>
        IAsyncResult BeginListWhatIfForecasts(ListWhatIfForecastsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWhatIfForecasts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWhatIfForecasts.</param>
        /// 
        /// <returns>Returns a  ListWhatIfForecastsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListWhatIfForecasts">REST API Reference for ListWhatIfForecasts Operation</seealso>
        ListWhatIfForecastsResponse EndListWhatIfForecasts(IAsyncResult asyncResult);

        #endregion
        
        #region  ResumeResource


        /// <summary>
        /// Resumes a stopped monitor resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeResource service method.</param>
        /// 
        /// <returns>The response from the ResumeResource service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ResumeResource">REST API Reference for ResumeResource Operation</seealso>
        ResumeResourceResponse ResumeResource(ResumeResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResumeResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeResource operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResumeResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ResumeResource">REST API Reference for ResumeResource Operation</seealso>
        IAsyncResult BeginResumeResource(ResumeResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResumeResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResumeResource.</param>
        /// 
        /// <returns>Returns a  ResumeResourceResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ResumeResource">REST API Reference for ResumeResource Operation</seealso>
        ResumeResourceResponse EndResumeResource(IAsyncResult asyncResult);

        #endregion
        
        #region  StopResource


        /// <summary>
        /// Stops a resource.
        /// 
        ///  
        /// <para>
        /// The resource undergoes the following states: <code>CREATE_STOPPING</code> and <code>CREATE_STOPPED</code>.
        /// You cannot resume a resource once it has been stopped.
        /// </para>
        ///  
        /// <para>
        /// This operation can be applied to the following resources (and their corresponding
        /// child resources):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Dataset Import Job
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Predictor Job
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Forecast Job
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Forecast Export Job
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Predictor Backtest Export Job
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Explainability Job
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Explainability Export Job
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopResource service method.</param>
        /// 
        /// <returns>The response from the StopResource service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/StopResource">REST API Reference for StopResource Operation</seealso>
        StopResourceResponse StopResource(StopResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopResource operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/StopResource">REST API Reference for StopResource Operation</seealso>
        IAsyncResult BeginStopResource(StopResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopResource.</param>
        /// 
        /// <returns>Returns a  StopResourceResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/StopResource">REST API Reference for StopResource Operation</seealso>
        StopResourceResponse EndStopResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates the specified tags to a resource with the specified <code>resourceArn</code>.
        /// If existing tags on a resource are not specified in the request parameters, they are
        /// not changed. When a resource is deleted, the tags associated with that resource are
        /// also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of resources per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes the specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDatasetGroup


        /// <summary>
        /// Replaces the datasets in a dataset group with the specified datasets.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the dataset group must be <code>ACTIVE</code> before you
        /// can use the dataset group to create a predictor. Use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDatasetGroup.html">DescribeDatasetGroup</a>
        /// operation to get the status.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatasetGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateDatasetGroup service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/UpdateDatasetGroup">REST API Reference for UpdateDatasetGroup Operation</seealso>
        UpdateDatasetGroupResponse UpdateDatasetGroup(UpdateDatasetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatasetGroup operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDatasetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/UpdateDatasetGroup">REST API Reference for UpdateDatasetGroup Operation</seealso>
        IAsyncResult BeginUpdateDatasetGroup(UpdateDatasetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDatasetGroup.</param>
        /// 
        /// <returns>Returns a  UpdateDatasetGroupResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/UpdateDatasetGroup">REST API Reference for UpdateDatasetGroup Operation</seealso>
        UpdateDatasetGroupResponse EndUpdateDatasetGroup(IAsyncResult asyncResult);

        #endregion
        
    }
}