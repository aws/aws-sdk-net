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
 * Do not modify this file. This file is generated from the marketplacecommerceanalytics-2015-07-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AWSMarketplaceCommerceAnalytics.Model;

namespace Amazon.AWSMarketplaceCommerceAnalytics
{
    /// <summary>
    /// Interface for accessing AWSMarketplaceCommerceAnalytics
    ///
    /// Provides AWS Marketplace business intelligence data on-demand.
    /// </summary>
    public partial interface IAmazonAWSMarketplaceCommerceAnalytics : IAmazonService, IDisposable
    {

        
        #region  GenerateDataSet


        /// <summary>
        /// Given a data set type and data set publication date, asynchronously publishes the
        /// requested data set to the specified S3 bucket and notifies the specified SNS topic
        /// once the data is available. Returns a unique request identifier that can be used to
        /// correlate requests with notifications from the SNS topic. Data sets will be published
        /// in comma-separated values (CSV) format with the file name {data_set_type}_YYYY-MM-DD.csv.
        /// If a file with the same name already exists (e.g. if the same data set is requested
        /// twice), the original file will be overwritten by the new file. Requires a Role with
        /// an attached permissions policy providing Allow permissions for the following actions:
        /// s3:PutObject, s3:GetBucketLocation, sns:GetTopicAttributes, sns:Publish, iam:GetRolePolicy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataSet service method.</param>
        /// 
        /// <returns>The response from the GenerateDataSet service method, as returned by AWSMarketplaceCommerceAnalytics.</returns>
        /// <exception cref="Amazon.AWSMarketplaceCommerceAnalytics.Model.MarketplaceCommerceAnalyticsException">
        /// This exception is thrown when an internal service error occurs.
        /// </exception>
        GenerateDataSetResponse GenerateDataSet(GenerateDataSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataSet operation on AmazonAWSMarketplaceCommerceAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateDataSet
        ///         operation.</returns>
        IAsyncResult BeginGenerateDataSet(GenerateDataSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateDataSet.</param>
        /// 
        /// <returns>Returns a  GenerateDataSetResult from AWSMarketplaceCommerceAnalytics.</returns>
        GenerateDataSetResponse EndGenerateDataSet(IAsyncResult asyncResult);

        #endregion
        
        #region  StartSupportDataExport


        /// <summary>
        /// Given a data set type and a from date, asynchronously publishes the requested customer
        /// support data to the specified S3 bucket and notifies the specified SNS topic once
        /// the data is available. Returns a unique request identifier that can be used to correlate
        /// requests with notifications from the SNS topic. Data sets will be published in comma-separated
        /// values (CSV) format with the file name {data_set_type}_YYYY-MM-DD'T'HH-mm-ss'Z'.csv.
        /// If a file with the same name already exists (e.g. if the same data set is requested
        /// twice), the original file will be overwritten by the new file. Requires a Role with
        /// an attached permissions policy providing Allow permissions for the following actions:
        /// s3:PutObject, s3:GetBucketLocation, sns:GetTopicAttributes, sns:Publish, iam:GetRolePolicy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSupportDataExport service method.</param>
        /// 
        /// <returns>The response from the StartSupportDataExport service method, as returned by AWSMarketplaceCommerceAnalytics.</returns>
        /// <exception cref="Amazon.AWSMarketplaceCommerceAnalytics.Model.MarketplaceCommerceAnalyticsException">
        /// This exception is thrown when an internal service error occurs.
        /// </exception>
        StartSupportDataExportResponse StartSupportDataExport(StartSupportDataExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartSupportDataExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSupportDataExport operation on AmazonAWSMarketplaceCommerceAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSupportDataExport
        ///         operation.</returns>
        IAsyncResult BeginStartSupportDataExport(StartSupportDataExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartSupportDataExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSupportDataExport.</param>
        /// 
        /// <returns>Returns a  StartSupportDataExportResult from AWSMarketplaceCommerceAnalytics.</returns>
        StartSupportDataExportResponse EndStartSupportDataExport(IAsyncResult asyncResult);

        #endregion
        
    }
}