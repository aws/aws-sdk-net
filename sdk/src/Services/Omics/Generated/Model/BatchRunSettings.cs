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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// A union type representing per-run configurations for the batch. Specify exactly one
    /// of the following members.
    /// </summary>
    public partial class BatchRunSettings
    {
        private List<InlineSetting> _inlineSettings = AWSConfigs.InitializeCollections ? new List<InlineSetting>() : null;
        private string _s3UriSettings;

        /// <summary>
        /// Gets and sets the property InlineSettings. 
        /// <para>
        /// A list of per-run configurations provided inline in the request. Each entry must include
        /// a unique <c>runSettingId</c>. Supports up to 100 entries. For batches with more than
        /// 100 runs, use <c>s3UriSettings</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<InlineSetting> InlineSettings
        {
            get { return this._inlineSettings; }
            set { this._inlineSettings = value; }
        }

        // Check to see if InlineSettings property is set
        internal bool IsSetInlineSettings()
        {
            return this._inlineSettings != null && (this._inlineSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3UriSettings. 
        /// <para>
        /// An Amazon S3 URI pointing to a JSON file containing per-run configurations. The file
        /// must be a JSON array in the same format as <c>inlineSettings</c>. Supports up to 100,000
        /// run configurations. The maximum file size is 6 GB.
        /// </para>
        ///  
        /// <para>
        /// The IAM service role in <c>roleArn</c> must have read access to this S3 object. HealthOmics
        /// validates access to the file during the synchronous API call and records the file's
        /// ETag. If the file is modified after submission, the batch fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=750)]
        public string S3UriSettings
        {
            get { return this._s3UriSettings; }
            set { this._s3UriSettings = value; }
        }

        // Check to see if S3UriSettings property is set
        internal bool IsSetS3UriSettings()
        {
            return this._s3UriSettings != null;
        }

    }
}