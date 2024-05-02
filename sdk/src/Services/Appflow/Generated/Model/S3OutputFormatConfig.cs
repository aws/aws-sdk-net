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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The configuration that determines how Amazon AppFlow should format the flow output
    /// data when Amazon S3 is used as the destination.
    /// </summary>
    public partial class S3OutputFormatConfig
    {
        private AggregationConfig _aggregationConfig;
        private FileType _fileType;
        private PrefixConfig _prefixConfig;
        private bool? _preserveSourceDataTyping;

        /// <summary>
        /// Gets and sets the property AggregationConfig.
        /// </summary>
        public AggregationConfig AggregationConfig
        {
            get { return this._aggregationConfig; }
            set { this._aggregationConfig = value; }
        }

        // Check to see if AggregationConfig property is set
        internal bool IsSetAggregationConfig()
        {
            return this._aggregationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property FileType. 
        /// <para>
        ///  Indicates the file type that Amazon AppFlow places in the Amazon S3 bucket. 
        /// </para>
        /// </summary>
        public FileType FileType
        {
            get { return this._fileType; }
            set { this._fileType = value; }
        }

        // Check to see if FileType property is set
        internal bool IsSetFileType()
        {
            return this._fileType != null;
        }

        /// <summary>
        /// Gets and sets the property PrefixConfig. 
        /// <para>
        ///  Determines the prefix that Amazon AppFlow applies to the folder name in the Amazon
        /// S3 bucket. You can name folders according to the flow frequency and date. 
        /// </para>
        /// </summary>
        public PrefixConfig PrefixConfig
        {
            get { return this._prefixConfig; }
            set { this._prefixConfig = value; }
        }

        // Check to see if PrefixConfig property is set
        internal bool IsSetPrefixConfig()
        {
            return this._prefixConfig != null;
        }

        /// <summary>
        /// Gets and sets the property PreserveSourceDataTyping. 
        /// <para>
        /// If your file output format is Parquet, use this parameter to set whether Amazon AppFlow
        /// preserves the data types in your source data when it writes the output to Amazon S3.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>true</c>: Amazon AppFlow preserves the data types when it writes to Amazon S3.
        /// For example, an integer or <c>1</c> in your source data is still an integer in your
        /// output.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>false</c>: Amazon AppFlow converts all of the source data into strings when it
        /// writes to Amazon S3. For example, an integer of <c>1</c> in your source data becomes
        /// the string <c>"1"</c> in the output.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? PreserveSourceDataTyping
        {
            get { return this._preserveSourceDataTyping; }
            set { this._preserveSourceDataTyping = value; }
        }

        // Check to see if PreserveSourceDataTyping property is set
        internal bool IsSetPreserveSourceDataTyping()
        {
            return this._preserveSourceDataTyping.HasValue; 
        }

    }
}