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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSMarketplaceCommerceAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the GenerateDataSet operation.
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
    public partial class GenerateDataSetRequest : AmazonAWSMarketplaceCommerceAnalyticsRequest
    {
        private Dictionary<string, string> _customerDefinedValues = new Dictionary<string, string>();
        private DateTime? _dataSetPublicationDate;
        private DataSetType _dataSetType;
        private string _destinations3BucketName;
        private string _destinations3Prefix;
        private string _roleNameArn;
        private string _snsTopicArn;

        /// <summary>
        /// Gets and sets the property CustomerDefinedValues. (Optional) Key-value pairs which
        /// will be returned, unmodified, in the Amazon SNS notification message and the data
        /// set metadata file. These key-value pairs can be used to correlated responses with
        /// tracking information from other systems.
        /// </summary>
        public Dictionary<string, string> CustomerDefinedValues
        {
            get { return this._customerDefinedValues; }
            set { this._customerDefinedValues = value; }
        }

        // Check to see if CustomerDefinedValues property is set
        internal bool IsSetCustomerDefinedValues()
        {
            return this._customerDefinedValues != null && this._customerDefinedValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DataSetPublicationDate. The date a data set was published.
        /// For daily data sets, provide a date with day-level granularity for the desired day.
        /// For weekly data sets, provide a date with day-level granularity within the desired
        /// week (the day value will be ignored). For monthly data sets, provide a date with month-level
        /// granularity for the desired month (the day value will be ignored).
        /// </summary>
        public DateTime DataSetPublicationDate
        {
            get { return this._dataSetPublicationDate.GetValueOrDefault(); }
            set { this._dataSetPublicationDate = value; }
        }

        // Check to see if DataSetPublicationDate property is set
        internal bool IsSetDataSetPublicationDate()
        {
            return this._dataSetPublicationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSetType. 
        /// <para>
        /// The desired data set type.
        /// </para>
        ///  
        /// <para>
        ///  <ul> <li><i>customer_subscriber_hourly_monthly_subscriptions</i> - Available daily
        /// by 5:00 PM Pacific Time since 2014-07-21.</li> <li><i>customer_subscriber_annual_subscriptions</i>
        /// - Available daily by 5:00 PM Pacific Time since 2014-07-21.</li> <li><i>daily_business_usage_by_instance_type</i>
        /// - Available daily by 5:00 PM Pacific Time since 2015-01-26.</li> <li><i>daily_business_fees</i>
        /// - Available daily by 5:00 PM Pacific Time since 2015-01-26.</li> <li><i>daily_business_free_trial_conversions</i>
        /// - Available daily by 5:00 PM Pacific Time since 2015-01-26.</li> <li><i>daily_business_new_instances</i>
        /// - Available daily by 5:00 PM Pacific Time since 2015-01-26.</li> <li><i>daily_business_new_product_subscribers</i>
        /// - Available daily by 5:00 PM Pacific Time since 2015-01-26.</li> <li><i>daily_business_canceled_product_subscribers</i>
        /// - Available daily by 5:00 PM Pacific Time since 2015-01-26.</li> <li><i>monthly_revenue_billing_and_revenue_data</i>
        /// - Available monthly on the 4th day of the month by 5:00 PM Pacific Time since 2015-02.</li>
        /// <li><i>monthly_revenue_annual_subscriptions</i> - Available monthly on the 4th day
        /// of the month by 5:00 PM Pacific Time since 2015-02.</li> <li><i>disbursed_amount_by_product</i>
        /// - Available every 30 days by 5:00 PM Pacific Time since 2015-01-26.</li> <li><i>disbursed_amount_by_product_with_uncollected_funds</i>
        /// -This data set is only available from 2012-04-19 until 2015-01-25. After 2015-01-25,
        /// this data set was split into three data sets: disbursed_amount_by_product, disbursed_amount_by_age_of_uncollected_funds,
        /// and disbursed_amount_by_age_of_disbursed_funds. </li> <li><i>disbursed_amount_by_customer_geo</i>
        /// - Available every 30 days by 5:00 PM Pacific Time since 2012-04-19.</li> <li><i>disbursed_amount_by_age_of_uncollected_funds</i>
        /// - Available every 30 days by 5:00 PM Pacific Time since 2015-01-26.</li> <li><i>disbursed_amount_by_age_of_disbursed_funds</i>
        /// - Available every 30 days by 5:00 PM Pacific Time since 2015-01-26.</li> <li><i>customer_profile_by_industry</i>
        /// - Available daily by 5:00 PM Pacific Time since 2015-10-01.</li> <li><i>customer_profile_by_revenue</i>
        /// - Available daily by 5:00 PM Pacific Time since 2015-10-01.</li> <li><i>customer_profile_by_geography</i>
        /// - Available daily by 5:00 PM Pacific Time since 2015-10-01.</li> <li><i>sales_compensation_billed_revenue</i>
        /// - Available monthly on the 4th day of the month by 5:00 PM Pacific Time since 2016-12.</li>
        /// </ul> 
        /// </para>
        /// </summary>
        public DataSetType DataSetType
        {
            get { return this._dataSetType; }
            set { this._dataSetType = value; }
        }

        // Check to see if DataSetType property is set
        internal bool IsSetDataSetType()
        {
            return this._dataSetType != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationS3BucketName. The name (friendly name, not ARN)
        /// of the destination S3 bucket.
        /// </summary>
        public string DestinationS3BucketName
        {
            get { return this._destinations3BucketName; }
            set { this._destinations3BucketName = value; }
        }

        // Check to see if DestinationS3BucketName property is set
        internal bool IsSetDestinationS3BucketName()
        {
            return this._destinations3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationS3Prefix. (Optional) The desired S3 prefix for
        /// the published data set, similar to a directory path in standard file systems. For
        /// example, if given the bucket name "mybucket" and the prefix "myprefix/mydatasets",
        /// the output file "outputfile" would be published to "s3://mybucket/myprefix/mydatasets/outputfile".
        /// If the prefix directory structure does not exist, it will be created. If no prefix
        /// is provided, the data set will be published to the S3 bucket root.
        /// </summary>
        public string DestinationS3Prefix
        {
            get { return this._destinations3Prefix; }
            set { this._destinations3Prefix = value; }
        }

        // Check to see if DestinationS3Prefix property is set
        internal bool IsSetDestinationS3Prefix()
        {
            return this._destinations3Prefix != null;
        }

        /// <summary>
        /// Gets and sets the property RoleNameArn. The Amazon Resource Name (ARN) of the Role
        /// with an attached permissions policy to interact with the provided AWS services.
        /// </summary>
        public string RoleNameArn
        {
            get { return this._roleNameArn; }
            set { this._roleNameArn = value; }
        }

        // Check to see if RoleNameArn property is set
        internal bool IsSetRoleNameArn()
        {
            return this._roleNameArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. Amazon Resource Name (ARN) for the SNS Topic
        /// that will be notified when the data set has been published or if an error has occurred.
        /// </summary>
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }

    }
}