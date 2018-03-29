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

using Amazon.AWSMarketplaceCommerceAnalytics.Model;
using Amazon.AWSMarketplaceCommerceAnalytics.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AWSMarketplaceCommerceAnalytics
{
    /// <summary>
    /// Implementation for accessing AWSMarketplaceCommerceAnalytics
    ///
    /// Provides AWS Marketplace business intelligence data on-demand.
    /// </summary>
    public partial class AmazonAWSMarketplaceCommerceAnalyticsClient : AmazonServiceClient, IAmazonAWSMarketplaceCommerceAnalytics
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonAWSMarketplaceCommerceAnalyticsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAWSMarketplaceCommerceAnalyticsConfig()) { }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAWSMarketplaceCommerceAnalyticsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonAWSMarketplaceCommerceAnalyticsClient Configuration Object</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(AmazonAWSMarketplaceCommerceAnalyticsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(AWSCredentials credentials)
            : this(credentials, new AmazonAWSMarketplaceCommerceAnalyticsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAWSMarketplaceCommerceAnalyticsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with AWS Credentials and an
        /// AmazonAWSMarketplaceCommerceAnalyticsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAWSMarketplaceCommerceAnalyticsClient Configuration Object</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(AWSCredentials credentials, AmazonAWSMarketplaceCommerceAnalyticsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAWSMarketplaceCommerceAnalyticsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAWSMarketplaceCommerceAnalyticsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAWSMarketplaceCommerceAnalyticsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAWSMarketplaceCommerceAnalyticsClient Configuration Object</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAWSMarketplaceCommerceAnalyticsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAWSMarketplaceCommerceAnalyticsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAWSMarketplaceCommerceAnalyticsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceCommerceAnalyticsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAWSMarketplaceCommerceAnalyticsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAWSMarketplaceCommerceAnalyticsClient Configuration Object</param>
        public AmazonAWSMarketplaceCommerceAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAWSMarketplaceCommerceAnalyticsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplacecommerceanalytics-2015-07-01/GenerateDataSet">REST API Reference for GenerateDataSet Operation</seealso>
        public virtual GenerateDataSetResponse GenerateDataSet(GenerateDataSetRequest request)
        {
            var marshaller = GenerateDataSetRequestMarshaller.Instance;
            var unmarshaller = GenerateDataSetResponseUnmarshaller.Instance;

            return Invoke<GenerateDataSetRequest,GenerateDataSetResponse>(request, marshaller, unmarshaller);
        }

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplacecommerceanalytics-2015-07-01/GenerateDataSet">REST API Reference for GenerateDataSet Operation</seealso>
        public virtual IAsyncResult BeginGenerateDataSet(GenerateDataSetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GenerateDataSetRequestMarshaller.Instance;
            var unmarshaller = GenerateDataSetResponseUnmarshaller.Instance;

            return BeginInvoke<GenerateDataSetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateDataSet.</param>
        /// 
        /// <returns>Returns a  GenerateDataSetResult from AWSMarketplaceCommerceAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplacecommerceanalytics-2015-07-01/GenerateDataSet">REST API Reference for GenerateDataSet Operation</seealso>
        public virtual GenerateDataSetResponse EndGenerateDataSet(IAsyncResult asyncResult)
        {
            return EndInvoke<GenerateDataSetResponse>(asyncResult);
        }

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplacecommerceanalytics-2015-07-01/StartSupportDataExport">REST API Reference for StartSupportDataExport Operation</seealso>
        public virtual StartSupportDataExportResponse StartSupportDataExport(StartSupportDataExportRequest request)
        {
            var marshaller = StartSupportDataExportRequestMarshaller.Instance;
            var unmarshaller = StartSupportDataExportResponseUnmarshaller.Instance;

            return Invoke<StartSupportDataExportRequest,StartSupportDataExportResponse>(request, marshaller, unmarshaller);
        }

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplacecommerceanalytics-2015-07-01/StartSupportDataExport">REST API Reference for StartSupportDataExport Operation</seealso>
        public virtual IAsyncResult BeginStartSupportDataExport(StartSupportDataExportRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StartSupportDataExportRequestMarshaller.Instance;
            var unmarshaller = StartSupportDataExportResponseUnmarshaller.Instance;

            return BeginInvoke<StartSupportDataExportRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartSupportDataExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSupportDataExport.</param>
        /// 
        /// <returns>Returns a  StartSupportDataExportResult from AWSMarketplaceCommerceAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplacecommerceanalytics-2015-07-01/StartSupportDataExport">REST API Reference for StartSupportDataExport Operation</seealso>
        public virtual StartSupportDataExportResponse EndStartSupportDataExport(IAsyncResult asyncResult)
        {
            return EndInvoke<StartSupportDataExportResponse>(asyncResult);
        }

        #endregion
        
    }
}