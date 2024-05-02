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
    /// The container element for Amazon S3 Storage Lens advanced cost-optimization metrics.
    /// Advanced cost-optimization metrics provide insights that you can use to manage and
    /// optimize your storage costs, for example, lifecycle rule counts for transitions, expirations,
    /// and incomplete multipart uploads.
    /// 
    ///  
    /// <para>
    /// For more information about S3 Storage Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage_lens.html">Assessing
    /// your storage activity and usage with S3 Storage Lens</a> in the <i>Amazon S3 User
    /// Guide</i>. For a complete list of S3 Storage Lens metrics, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage_lens_metrics_glossary.html">S3
    /// Storage Lens metrics glossary</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AdvancedCostOptimizationMetrics
    {
        private bool? _isEnabled;

        /// <summary>
        /// Gets and sets the property IsEnabled. 
        /// <para>
        /// A container that indicates whether advanced cost-optimization metrics are enabled.
        /// </para>
        /// </summary>
        public bool? IsEnabled
        {
            get { return this._isEnabled; }
            set { this._isEnabled = value; }
        }

        // Check to see if IsEnabled property is set
        internal bool IsSetIsEnabled()
        {
            return this._isEnabled.HasValue; 
        }

    }
}