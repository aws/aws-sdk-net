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
    /// s3:PutObject, s3:getBucketLocation, sns:SetRegion, sns:ListTopics, sns:Publish, iam:GetRolePolicy.
    /// </summary>
    public partial class GenerateDataSetRequest : AmazonAWSMarketplaceCommerceAnalyticsRequest
    {
        private DateTime? _dataSetPublicationDate;
        private DataSetType _dataSetType;
        private string _destinations3BucketName;
        private string _destinations3Prefix;
        private string _roleNameArn;
        private string _snsTopicArn;

        /// <summary>
        /// Gets and sets the property DataSetPublicationDate.
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
        /// Gets and sets the property DestinationS3BucketName.
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
        /// Gets and sets the property DestinationS3Prefix.
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
        /// Gets and sets the property RoleNameArn.
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
        /// Gets and sets the property SnsTopicArn.
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