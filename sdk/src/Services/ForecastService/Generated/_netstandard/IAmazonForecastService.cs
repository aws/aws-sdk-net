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
using System.Threading;
using System.Threading.Tasks;
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
#if AWS_ASYNC_ENUMERABLES_API
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateAutoPredictorResponse> CreateAutoPredictorAsync(CreateAutoPredictorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateDatasetGroupResponse> CreateDatasetGroupAsync(CreateDatasetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateDatasetImportJobResponse> CreateDatasetImportJobAsync(CreateDatasetImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateExplainabilityResponse> CreateExplainabilityAsync(CreateExplainabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateExplainabilityExportResponse> CreateExplainabilityExportAsync(CreateExplainabilityExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateForecastResponse> CreateForecastAsync(CreateForecastRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateForecastExportJobResponse> CreateForecastExportJobAsync(CreateForecastExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMonitor



        /// <summary>
        /// Creates a predictor monitor resource for an existing auto predictor. Predictor monitoring
        /// allows you to see how your predictor's performance changes over time. For more information,
        /// see <a href="https://docs.aws.amazon.com/forecast/latest/dg/predictor-monitoring.html">Predictor
        /// Monitoring</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateMonitorResponse> CreateMonitorAsync(CreateMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreatePredictorResponse> CreatePredictorAsync(CreatePredictorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreatePredictorBacktestExportJobResponse> CreatePredictorBacktestExportJobAsync(CreatePredictorBacktestExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateWhatIfAnalysisResponse> CreateWhatIfAnalysisAsync(CreateWhatIfAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWhatIfForecast



        /// <summary>
        /// A what-if forecast is a forecast that is created from a modified version of the baseline
        /// forecast. Each what-if forecast incorporates either a replacement dataset or a set
        /// of transformations to the original dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatIfForecast service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateWhatIfForecastResponse> CreateWhatIfForecastAsync(CreateWhatIfForecastRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateWhatIfForecastExportResponse> CreateWhatIfForecastExportAsync(CreateWhatIfForecastExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteDatasetGroupResponse> DeleteDatasetGroupAsync(DeleteDatasetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDatasetImportJob



        /// <summary>
        /// Deletes a dataset import job created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetImportJob.html">CreateDatasetImportJob</a>
        /// operation. You can delete only dataset import jobs that have a status of <code>ACTIVE</code>
        /// or <code>CREATE_FAILED</code>. To get the status, use the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_DescribeDatasetImportJob.html">DescribeDatasetImportJob</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteDatasetImportJobResponse> DeleteDatasetImportJobAsync(DeleteDatasetImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteExplainabilityResponse> DeleteExplainabilityAsync(DeleteExplainabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteExplainabilityExport



        /// <summary>
        /// Deletes an Explainability export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExplainabilityExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteExplainabilityExportResponse> DeleteExplainabilityExportAsync(DeleteExplainabilityExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteForecastResponse> DeleteForecastAsync(DeleteForecastRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteForecastExportJob



        /// <summary>
        /// Deletes a forecast export job created using the <a>CreateForecastExportJob</a> operation.
        /// You can delete only export jobs that have a status of <code>ACTIVE</code> or <code>CREATE_FAILED</code>.
        /// To get the status, use the <a>DescribeForecastExportJob</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteForecastExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteForecastExportJobResponse> DeleteForecastExportJobAsync(DeleteForecastExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMonitor



        /// <summary>
        /// Deletes a monitor resource. You can only delete a monitor resource with a status of
        /// <code>ACTIVE</code>, <code>ACTIVE_STOPPED</code>, <code>CREATE_FAILED</code>, or <code>CREATE_STOPPED</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteMonitorResponse> DeleteMonitorAsync(DeleteMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePredictor



        /// <summary>
        /// Deletes a predictor created using the <a>DescribePredictor</a> or <a>CreatePredictor</a>
        /// operations. You can delete only predictor that have a status of <code>ACTIVE</code>
        /// or <code>CREATE_FAILED</code>. To get the status, use the <a>DescribePredictor</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePredictor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeletePredictorResponse> DeletePredictorAsync(DeletePredictorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePredictorBacktestExportJob



        /// <summary>
        /// Deletes a predictor backtest export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePredictorBacktestExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeletePredictorBacktestExportJobResponse> DeletePredictorBacktestExportJobAsync(DeletePredictorBacktestExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteResourceTreeResponse> DeleteResourceTreeAsync(DeleteResourceTreeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteWhatIfAnalysisResponse> DeleteWhatIfAnalysisAsync(DeleteWhatIfAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteWhatIfForecastResponse> DeleteWhatIfForecastAsync(DeleteWhatIfForecastRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWhatIfForecastExport



        /// <summary>
        /// Deletes a what-if forecast export created using the <a>CreateWhatIfForecastExport</a>
        /// operation. You can delete only what-if forecast exports that have a status of <code>ACTIVE</code>
        /// or <code>CREATE_FAILED</code>. To get the status, use the <a>DescribeWhatIfForecastExport</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatIfForecastExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteWhatIfForecastExportResponse> DeleteWhatIfForecastExportAsync(DeleteWhatIfForecastExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAutoPredictor



        /// <summary>
        /// Describes a predictor created using the CreateAutoPredictor operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoPredictor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeAutoPredictorResponse> DescribeAutoPredictorAsync(DescribeAutoPredictorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeDatasetGroupResponse> DescribeDatasetGroupAsync(DescribeDatasetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeDatasetImportJobResponse> DescribeDatasetImportJobAsync(DescribeDatasetImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeExplainability



        /// <summary>
        /// Describes an Explainability resource created using the <a>CreateExplainability</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExplainability service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeExplainabilityResponse> DescribeExplainabilityAsync(DescribeExplainabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeExplainabilityExport



        /// <summary>
        /// Describes an Explainability export created using the <a>CreateExplainabilityExport</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExplainabilityExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeExplainabilityExportResponse> DescribeExplainabilityExportAsync(DescribeExplainabilityExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeForecastResponse> DescribeForecastAsync(DescribeForecastRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeForecastExportJobResponse> DescribeForecastExportJobAsync(DescribeForecastExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeMonitorResponse> DescribeMonitorAsync(DescribeMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribePredictorResponse> DescribePredictorAsync(DescribePredictorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribePredictorBacktestExportJobResponse> DescribePredictorBacktestExportJobAsync(DescribePredictorBacktestExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeWhatIfAnalysisResponse> DescribeWhatIfAnalysisAsync(DescribeWhatIfAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeWhatIfForecastResponse> DescribeWhatIfForecastAsync(DescribeWhatIfForecastRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeWhatIfForecastExportResponse> DescribeWhatIfForecastExportAsync(DescribeWhatIfForecastExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAccuracyMetricsResponse> GetAccuracyMetricsAsync(GetAccuracyMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasetGroups service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetGroups">REST API Reference for ListDatasetGroups Operation</seealso>
        Task<ListDatasetGroupsResponse> ListDatasetGroupsAsync(ListDatasetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDatasetImportJobsResponse> ListDatasetImportJobsAsync(ListDatasetImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListExplainabilitiesResponse> ListExplainabilitiesAsync(ListExplainabilitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListExplainabilityExportsResponse> ListExplainabilityExportsAsync(ListExplainabilityExportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListForecastExportJobsResponse> ListForecastExportJobsAsync(ListForecastExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListForecastsResponse> ListForecastsAsync(ListForecastsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListMonitorEvaluationsResponse> ListMonitorEvaluationsAsync(ListMonitorEvaluationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMonitors



        /// <summary>
        /// Returns a list of monitors created with the <a>CreateMonitor</a> operation and <a>CreateAutoPredictor</a>
        /// operation. For each monitor resource, this operation returns of a summary of its properties,
        /// including its Amazon Resource Name (ARN). You can retrieve a complete set of properties
        /// of a monitor resource by specify the monitor's ARN in the <a>DescribeMonitor</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListMonitorsResponse> ListMonitorsAsync(ListMonitorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListPredictorBacktestExportJobsResponse> ListPredictorBacktestExportJobsAsync(ListPredictorBacktestExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListPredictorsResponse> ListPredictorsAsync(ListPredictorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags for an Amazon Forecast resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWhatIfAnalyses



        /// <summary>
        /// Returns a list of what-if analyses created using the <a>CreateWhatIfAnalysis</a> operation.
        /// For each what-if analysis, this operation returns a summary of its properties, including
        /// its Amazon Resource Name (ARN). You can retrieve the complete set of properties by
        /// using the what-if analysis ARN with the <a>DescribeWhatIfAnalysis</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWhatIfAnalyses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListWhatIfAnalysesResponse> ListWhatIfAnalysesAsync(ListWhatIfAnalysesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListWhatIfForecastExportsResponse> ListWhatIfForecastExportsAsync(ListWhatIfForecastExportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWhatIfForecasts



        /// <summary>
        /// Returns a list of what-if forecasts created using the <a>CreateWhatIfForecast</a>
        /// operation. For each what-if forecast, this operation returns a summary of its properties,
        /// including its Amazon Resource Name (ARN). You can retrieve the complete set of properties
        /// by using the what-if forecast ARN with the <a>DescribeWhatIfForecast</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWhatIfForecasts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListWhatIfForecastsResponse> ListWhatIfForecastsAsync(ListWhatIfForecastsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResumeResource



        /// <summary>
        /// Resumes a stopped monitor resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ResumeResourceResponse> ResumeResourceAsync(ResumeResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StopResourceResponse> StopResourceAsync(StopResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Associates the specified tags to a resource with the specified <code>resourceArn</code>.
        /// If existing tags on a resource are not specified in the request parameters, they are
        /// not changed. When a resource is deleted, the tags associated with that resource are
        /// also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Deletes the specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateDatasetGroupResponse> UpdateDatasetGroupAsync(UpdateDatasetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}