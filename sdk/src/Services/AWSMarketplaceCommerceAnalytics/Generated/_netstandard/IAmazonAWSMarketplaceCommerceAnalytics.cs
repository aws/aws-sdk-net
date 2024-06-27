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
 * Do not modify this file. This file is generated from the marketplacecommerceanalytics-2015-07-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AWSMarketplaceCommerceAnalytics.Model;

#pragma warning disable CS1570
namespace Amazon.AWSMarketplaceCommerceAnalytics
{
    /// <summary>
    /// <para>Interface for accessing AWSMarketplaceCommerceAnalytics</para>
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateDataSet service method, as returned by AWSMarketplaceCommerceAnalytics.</returns>
        /// <exception cref="Amazon.AWSMarketplaceCommerceAnalytics.Model.MarketplaceCommerceAnalyticsException">
        /// This exception is thrown when an internal service error occurs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplacecommerceanalytics-2015-07-01/GenerateDataSet">REST API Reference for GenerateDataSet Operation</seealso>
        Task<GenerateDataSetResponse> GenerateDataSetAsync(GenerateDataSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartSupportDataExport



        /// <summary>
        /// <i>This target has been deprecated.</i> Given a data set type and a from date, asynchronously
        /// publishes the requested customer support data to the specified S3 bucket and notifies
        /// the specified SNS topic once the data is available. Returns a unique request identifier
        /// that can be used to correlate requests with notifications from the SNS topic. Data
        /// sets will be published in comma-separated values (CSV) format with the file name {data_set_type}_YYYY-MM-DD'T'HH-mm-ss'Z'.csv.
        /// If a file with the same name already exists (e.g. if the same data set is requested
        /// twice), the original file will be overwritten by the new file. Requires a Role with
        /// an attached permissions policy providing Allow permissions for the following actions:
        /// s3:PutObject, s3:GetBucketLocation, sns:GetTopicAttributes, sns:Publish, iam:GetRolePolicy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSupportDataExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSupportDataExport service method, as returned by AWSMarketplaceCommerceAnalytics.</returns>
        /// <exception cref="Amazon.AWSMarketplaceCommerceAnalytics.Model.MarketplaceCommerceAnalyticsException">
        /// This exception is thrown when an internal service error occurs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplacecommerceanalytics-2015-07-01/StartSupportDataExport">REST API Reference for StartSupportDataExport Operation</seealso>
        [Obsolete("This target has been deprecated. As of December 2022 Product Support Connection is no longer supported.")]
        Task<StartSupportDataExportResponse> StartSupportDataExportAsync(StartSupportDataExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonAWSMarketplaceCommerceAnalyticsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonAWSMarketplaceCommerceAnalyticsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonAWSMarketplaceCommerceAnalyticsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonAWSMarketplaceCommerceAnalyticsConfig to create AmazonAWSMarketplaceCommerceAnalyticsClient");
            }

            return awsCredentials == null ? 
                    new AmazonAWSMarketplaceCommerceAnalyticsClient(serviceClientConfig) :
                    new AmazonAWSMarketplaceCommerceAnalyticsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}