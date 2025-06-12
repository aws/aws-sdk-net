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
    /// Container for the parameters to the StartSupportDataExport operation.
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
    [Obsolete("This target has been deprecated. As of December 2022 Product Support Connection is no longer supported.")]
    public partial class StartSupportDataExportRequest : AmazonAWSMarketplaceCommerceAnalyticsRequest
    {
        private Dictionary<string, string> _customerDefinedValues = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private SupportDataSetType _dataSetType;
        private string _destinations3BucketName;
        private string _destinations3Prefix;
        private DateTime? _fromDate;
        private string _roleNameArn;
        private string _snsTopicArn;

        /// <summary>
        /// Gets and sets the property CustomerDefinedValues. <i>This target has been deprecated.</i>
        /// (Optional) Key-value pairs which will be returned, unmodified, in the Amazon SNS notification
        /// message and the data set metadata file.
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
        /// Gets and sets the property DataSetType. 
        /// <para>
        ///  <i>This target has been deprecated.</i> Specifies the data set type to be written
        /// to the output csv file. The data set types customer_support_contacts_data and test_customer_support_contacts_data
        /// both result in a csv file containing the following fields: Product Id, Product Code,
        /// Customer Guid, Subscription Guid, Subscription Start Date, Organization, AWS Account
        /// Id, Given Name, Surname, Telephone Number, Email, Title, Country Code, ZIP Code, Operation
        /// Type, and Operation Time. 
        /// </para>
        ///  
        /// <para>
        ///  <ul> <li><i>customer_support_contacts_data</i> Customer support contact data. The
        /// data set will contain all changes (Creates, Updates, and Deletes) to customer support
        /// contact data from the date specified in the from_date parameter.</li> <li><i>test_customer_support_contacts_data</i>
        /// An example data set containing static test data in the same format as customer_support_contacts_data</li>
        /// </ul> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public SupportDataSetType DataSetType
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
        /// Gets and sets the property DestinationS3BucketName. <i>This target has been deprecated.</i>
        /// The name (friendly name, not ARN) of the destination S3 bucket.
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
        /// Gets and sets the property DestinationS3Prefix. <i>This target has been deprecated.</i>
        /// (Optional) The desired S3 prefix for the published data set, similar to a directory
        /// path in standard file systems. For example, if given the bucket name "mybucket" and
        /// the prefix "myprefix/mydatasets", the output file "outputfile" would be published
        /// to "s3://mybucket/myprefix/mydatasets/outputfile". If the prefix directory structure
        /// does not exist, it will be created. If no prefix is provided, the data set will be
        /// published to the S3 bucket root.
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
        /// Gets and sets the property FromDate. <i>This target has been deprecated.</i> The start
        /// date from which to retrieve the data set in UTC. This parameter only affects the customer_support_contacts_data
        /// data set type.
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? FromDate
        {
            get { return this._fromDate; }
            set { this._fromDate = value; }
        }

        // Check to see if FromDate property is set
        internal bool IsSetFromDate()
        {
            return this._fromDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleNameArn. <i>This target has been deprecated.</i> The
        /// Amazon Resource Name (ARN) of the Role with an attached permissions policy to interact
        /// with the provided AWS services.
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
        /// Gets and sets the property SnsTopicArn. <i>This target has been deprecated.</i> Amazon
        /// Resource Name (ARN) for the SNS Topic that will be notified when the data set has
        /// been published or if an error has occurred.
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