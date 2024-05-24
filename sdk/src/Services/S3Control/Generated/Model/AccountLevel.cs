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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A container element for the account-level Amazon S3 Storage Lens configuration.
    /// 
    ///  
    /// <para>
    /// For more information about S3 Storage Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage_lens.html">Assessing
    /// your storage activity and usage with S3 Storage Lens</a> in the <i>Amazon S3 User
    /// Guide</i>. For a complete list of S3 Storage Lens metrics, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage_lens_metrics_glossary.html">S3
    /// Storage Lens metrics glossary</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AccountLevel
    {
        private ActivityMetrics _activityMetrics;
        private AdvancedCostOptimizationMetrics _advancedCostOptimizationMetrics;
        private AdvancedDataProtectionMetrics _advancedDataProtectionMetrics;
        private BucketLevel _bucketLevel;
        private DetailedStatusCodesMetrics _detailedStatusCodesMetrics;
        private StorageLensGroupLevel _storageLensGroupLevel;

        /// <summary>
        /// Gets and sets the property ActivityMetrics. 
        /// <para>
        /// A container element for S3 Storage Lens activity metrics.
        /// </para>
        /// </summary>
        public ActivityMetrics ActivityMetrics
        {
            get { return this._activityMetrics; }
            set { this._activityMetrics = value; }
        }

        // Check to see if ActivityMetrics property is set
        internal bool IsSetActivityMetrics()
        {
            return this._activityMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property AdvancedCostOptimizationMetrics. 
        /// <para>
        /// A container element for S3 Storage Lens advanced cost-optimization metrics.
        /// </para>
        /// </summary>
        public AdvancedCostOptimizationMetrics AdvancedCostOptimizationMetrics
        {
            get { return this._advancedCostOptimizationMetrics; }
            set { this._advancedCostOptimizationMetrics = value; }
        }

        // Check to see if AdvancedCostOptimizationMetrics property is set
        internal bool IsSetAdvancedCostOptimizationMetrics()
        {
            return this._advancedCostOptimizationMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property AdvancedDataProtectionMetrics. 
        /// <para>
        /// A container element for S3 Storage Lens advanced data-protection metrics.
        /// </para>
        /// </summary>
        public AdvancedDataProtectionMetrics AdvancedDataProtectionMetrics
        {
            get { return this._advancedDataProtectionMetrics; }
            set { this._advancedDataProtectionMetrics = value; }
        }

        // Check to see if AdvancedDataProtectionMetrics property is set
        internal bool IsSetAdvancedDataProtectionMetrics()
        {
            return this._advancedDataProtectionMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property BucketLevel. 
        /// <para>
        /// A container element for the S3 Storage Lens bucket-level configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BucketLevel BucketLevel
        {
            get { return this._bucketLevel; }
            set { this._bucketLevel = value; }
        }

        // Check to see if BucketLevel property is set
        internal bool IsSetBucketLevel()
        {
            return this._bucketLevel != null;
        }

        /// <summary>
        /// Gets and sets the property DetailedStatusCodesMetrics. 
        /// <para>
        /// A container element for detailed status code metrics. 
        /// </para>
        /// </summary>
        public DetailedStatusCodesMetrics DetailedStatusCodesMetrics
        {
            get { return this._detailedStatusCodesMetrics; }
            set { this._detailedStatusCodesMetrics = value; }
        }

        // Check to see if DetailedStatusCodesMetrics property is set
        internal bool IsSetDetailedStatusCodesMetrics()
        {
            return this._detailedStatusCodesMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property StorageLensGroupLevel. 
        /// <para>
        ///  A container element for S3 Storage Lens groups metrics. 
        /// </para>
        /// </summary>
        public StorageLensGroupLevel StorageLensGroupLevel
        {
            get { return this._storageLensGroupLevel; }
            set { this._storageLensGroupLevel = value; }
        }

        // Check to see if StorageLensGroupLevel property is set
        internal bool IsSetStorageLensGroupLevel()
        {
            return this._storageLensGroupLevel != null;
        }

    }
}