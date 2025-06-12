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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes information about the usage report subscription.
    /// </summary>
    public partial class UsageReportSubscription
    {
        private DateTime? _lastGeneratedReportDate;
        private string _s3BucketName;
        private UsageReportSchedule _schedule;
        private List<LastReportGenerationExecutionError> _subscriptionErrors = AWSConfigs.InitializeCollections ? new List<LastReportGenerationExecutionError>() : null;

        /// <summary>
        /// Gets and sets the property LastGeneratedReportDate. 
        /// <para>
        /// The time when the last usage report was generated.
        /// </para>
        /// </summary>
        public DateTime? LastGeneratedReportDate
        {
            get { return this._lastGeneratedReportDate; }
            set { this._lastGeneratedReportDate = value; }
        }

        // Check to see if LastGeneratedReportDate property is set
        internal bool IsSetLastGeneratedReportDate()
        {
            return this._lastGeneratedReportDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The Amazon S3 bucket where generated reports are stored.
        /// </para>
        ///  
        /// <para>
        /// If you enabled on-instance session scripts and Amazon S3 logging for your session
        /// script configuration, AppStream 2.0 created an S3 bucket to store the script output.
        /// The bucket is unique to your account and Region. When you enable usage reporting in
        /// this case, AppStream 2.0 uses the same bucket to store your usage reports. If you
        /// haven't already enabled on-instance session scripts, when you enable usage reports,
        /// AppStream 2.0 creates a new S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule for generating usage reports.
        /// </para>
        /// </summary>
        public UsageReportSchedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionErrors. 
        /// <para>
        /// The errors that were returned if usage reports couldn't be generated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LastReportGenerationExecutionError> SubscriptionErrors
        {
            get { return this._subscriptionErrors; }
            set { this._subscriptionErrors = value; }
        }

        // Check to see if SubscriptionErrors property is set
        internal bool IsSetSubscriptionErrors()
        {
            return this._subscriptionErrors != null && (this._subscriptionErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}