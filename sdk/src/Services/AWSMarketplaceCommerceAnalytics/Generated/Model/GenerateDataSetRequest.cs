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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
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
        private Dictionary<string, string> _customerDefinedValues = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public Dictionary<string, string> CustomerDefinedValues
        {
            get { return this._customerDefinedValues; }
            set { this._customerDefinedValues = value; }
        }

        // Check to see if CustomerDefinedValues property is set
        internal bool IsSetCustomerDefinedValues()
        {
            return this._customerDefinedValues != null && (this._customerDefinedValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataSetPublicationDate. The date a data set was published.
        /// For daily data sets, provide a date with day-level granularity for the desired day.
        /// For monthly data sets except those with prefix disbursed_amount, provide a date with
        /// month-level granularity for the desired month (the day value will be ignored). For
        /// data sets with prefix disbursed_amount, provide a date with day-level granularity
        /// for the desired day. For these data sets we will look backwards in time over the range
        /// of 31 days until the first data set is found (the latest one).
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? DataSetPublicationDate
        {
            get { return this._dataSetPublicationDate; }
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
        ///  <ul> <li> <strong>customer_subscriber_hourly_monthly_subscriptions</strong> 
        /// <para>
        /// From 2017-09-15 to present: Available daily by 24:00 UTC.
        /// </para>
        ///  </li> <li> <strong>customer_subscriber_annual_subscriptions</strong> 
        /// <para>
        /// From 2017-09-15 to present: Available daily by 24:00 UTC.
        /// </para>
        ///  </li> <li> <strong>daily_business_usage_by_instance_type</strong> 
        /// <para>
        /// From 2017-09-15 to present: Available daily by 24:00 UTC.
        /// </para>
        ///  </li> <li> <strong>daily_business_fees</strong> 
        /// <para>
        /// From 2017-09-15 to present: Available daily by 24:00 UTC.
        /// </para>
        ///  </li> <li> <strong>daily_business_free_trial_conversions</strong> 
        /// <para>
        /// From 2017-09-15 to present: Available daily by 24:00 UTC.
        /// </para>
        ///  </li> <li> <strong>daily_business_new_instances</strong> 
        /// <para>
        /// From 2017-09-15 to present: Available daily by 24:00 UTC.
        /// </para>
        ///  </li> <li> <strong>daily_business_new_product_subscribers</strong> 
        /// <para>
        /// From 2017-09-15 to present: Available daily by 24:00 UTC.
        /// </para>
        ///  </li> <li> <strong>daily_business_canceled_product_subscribers</strong> 
        /// <para>
        /// From 2017-09-15 to present: Available daily by 24:00 UTC.
        /// </para>
        ///  </li> <li> <strong>monthly_revenue_billing_and_revenue_data</strong> 
        /// <para>
        /// From 2017-09-15 to present: Available monthly on the 15th day of the month by 24:00
        /// UTC. Data includes metered transactions (e.g. hourly) from one month prior.
        /// </para>
        ///  </li> <li> <strong>monthly_revenue_annual_subscriptions</strong> 
        /// <para>
        /// From 2017-09-15 to present: Available monthly on the 15th day of the month by 24:00
        /// UTC. Data includes up-front software charges (e.g. annual) from one month prior.
        /// </para>
        ///  </li> <li> <strong>monthly_revenue_field_demonstration_usage</strong> 
        /// <para>
        /// From 2018-03-15 to present: Available monthly on the 15th day of the month by 24:00
        /// UTC.
        /// </para>
        ///  </li> <li> <strong>monthly_revenue_flexible_payment_schedule</strong> 
        /// <para>
        /// From 2018-11-15 to present: Available monthly on the 15th day of the month by 24:00
        /// UTC.
        /// </para>
        ///  </li> <li> <strong>disbursed_amount_by_product</strong> 
        /// <para>
        /// From 2017-09-15 to present: Available every 30 days by 24:00 UTC.
        /// </para>
        ///  </li> <li> <strong>disbursed_amount_by_instance_hours</strong> 
        /// <para>
        /// From 2017-09-15 to present: Available every 30 days by 24:00 UTC.
        /// </para>
        ///  </li> <li> <strong>disbursed_amount_by_customer_geo</strong> 
        /// <para>
        /// From 2017-09-15 to present: Available every 30 days by 24:00 UTC.
        /// </para>
        ///  </li> <li> <strong>disbursed_amount_by_age_of_uncollected_funds</strong> 
        /// <para>
        /// From 2017-09-15 to present: Available every 30 days by 24:00 UTC.
        /// </para>
        ///  </li> <li> <strong>disbursed_amount_by_age_of_disbursed_funds</strong> 
        /// <para>
        /// From 2017-09-15 to present: Available every 30 days by 24:00 UTC.
        /// </para>
        ///  </li> <li> <strong>disbursed_amount_by_age_of_past_due_funds</strong> 
        /// <para>
        /// From 2018-04-07 to present: Available every 30 days by 24:00 UTC.
        /// </para>
        ///  </li> <li> <strong>disbursed_amount_by_uncollected_funds_breakdown</strong> 
        /// <para>
        /// From 2019-10-04 to present: Available every 30 days by 24:00 UTC.
        /// </para>
        ///  </li> <li> <strong>sales_compensation_billed_revenue</strong> 
        /// <para>
        /// From 2017-09-15 to present: Available monthly on the 15th day of the month by 24:00
        /// UTC. Data includes metered transactions (e.g. hourly) from one month prior, and up-front
        /// software charges (e.g. annual) from one month prior.
        /// </para>
        ///  </li> <li> <strong>us_sales_and_use_tax_records</strong> 
        /// <para>
        /// From 2017-09-15 to present: Available monthly on the 15th day of the month by 24:00
        /// UTC.
        /// </para>
        ///  </li> <li> <strong>disbursed_amount_by_product_with_uncollected_funds</strong> 
        /// <para>
        /// This data set is deprecated. Download related reports from AMMP instead!
        /// </para>
        ///  </li> <li> <strong>customer_profile_by_industry</strong> 
        /// <para>
        /// This data set is deprecated. Download related reports from AMMP instead!
        /// </para>
        ///  </li> <li> <strong>customer_profile_by_revenue</strong> 
        /// <para>
        /// This data set is deprecated. Download related reports from AMMP instead!
        /// </para>
        ///  </li> <li> <strong>customer_profile_by_geography</strong> 
        /// <para>
        /// This data set is deprecated. Download related reports from AMMP instead!
        /// </para>
        ///  </li> </ul> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        [AWSProperty(Required=true, Min=1, Max=256)]
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