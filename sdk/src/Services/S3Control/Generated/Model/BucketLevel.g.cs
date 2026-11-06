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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// A container for the bucket-level configuration for Amazon S3 Storage Lens.
    /// 
    ///  
    /// <para>
    /// For more information about S3 Storage Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage_lens.html">Assessing
    /// your storage activity and usage with S3 Storage Lens</a> in the <i>Amazon S3 User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class BucketLevel
    {
        /// <summary>
        /// Gets and sets the property ActivityMetrics. 
        /// <para>
        /// A container for the bucket-level activity metrics for S3 Storage Lens.
        /// </para>
        /// </summary>
        public ActivityMetrics ActivityMetrics { get; set; }

        /// <summary>
        /// Checks to see if the ActivityMetrics property is set.
        /// </summary>
        internal bool IsSetActivityMetrics() => this.ActivityMetrics != null;

        /// <summary>
        /// Gets and sets the property AdvancedCostOptimizationMetrics. 
        /// <para>
        /// A container for bucket-level advanced cost-optimization metrics for S3 Storage Lens.
        /// </para>
        /// </summary>
        public AdvancedCostOptimizationMetrics AdvancedCostOptimizationMetrics { get; set; }

        /// <summary>
        /// Checks to see if the AdvancedCostOptimizationMetrics property is set.
        /// </summary>
        internal bool IsSetAdvancedCostOptimizationMetrics() => this.AdvancedCostOptimizationMetrics != null;

        /// <summary>
        /// Gets and sets the property AdvancedDataProtectionMetrics. 
        /// <para>
        /// A container for bucket-level advanced data-protection metrics for S3 Storage Lens.
        /// </para>
        /// </summary>
        public AdvancedDataProtectionMetrics AdvancedDataProtectionMetrics { get; set; }

        /// <summary>
        /// Checks to see if the AdvancedDataProtectionMetrics property is set.
        /// </summary>
        internal bool IsSetAdvancedDataProtectionMetrics() => this.AdvancedDataProtectionMetrics != null;

        /// <summary>
        /// Gets and sets the property AdvancedPerformanceMetrics. 
        /// <para>
        /// A container for bucket-level advanced performance metrics for S3 Storage Lens.
        /// </para>
        /// </summary>
        public AdvancedPerformanceMetrics AdvancedPerformanceMetrics { get; set; }

        /// <summary>
        /// Checks to see if the AdvancedPerformanceMetrics property is set.
        /// </summary>
        internal bool IsSetAdvancedPerformanceMetrics() => this.AdvancedPerformanceMetrics != null;

        /// <summary>
        /// Gets and sets the property DetailedStatusCodesMetrics. 
        /// <para>
        /// A container for bucket-level detailed status code metrics for S3 Storage Lens.
        /// </para>
        /// </summary>
        public DetailedStatusCodesMetrics DetailedStatusCodesMetrics { get; set; }

        /// <summary>
        /// Checks to see if the DetailedStatusCodesMetrics property is set.
        /// </summary>
        internal bool IsSetDetailedStatusCodesMetrics() => this.DetailedStatusCodesMetrics != null;

        /// <summary>
        /// Gets and sets the property PrefixLevel. 
        /// <para>
        /// A container for the prefix-level metrics for S3 Storage Lens. 
        /// </para>
        /// </summary>
        public PrefixLevel PrefixLevel { get; set; }

        /// <summary>
        /// Checks to see if the PrefixLevel property is set.
        /// </summary>
        internal bool IsSetPrefixLevel() => this.PrefixLevel != null;
    }
}
