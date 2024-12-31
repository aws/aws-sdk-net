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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This object defines one key that will be renamed with the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-renameKey">
    /// renameKey</a> processor.
    /// </summary>
    public partial class RenameKeyEntry
    {
        private string _key;
        private bool? _overwriteIfExists;
        private string _renameTo;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key to rename
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property OverwriteIfExists. 
        /// <para>
        /// Specifies whether to overwrite the existing value if the destination key already exists.
        /// The default is <c>false</c> 
        /// </para>
        /// </summary>
        public bool? OverwriteIfExists
        {
            get { return this._overwriteIfExists; }
            set { this._overwriteIfExists = value; }
        }

        // Check to see if OverwriteIfExists property is set
        internal bool IsSetOverwriteIfExists()
        {
            return this._overwriteIfExists.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RenameTo. 
        /// <para>
        /// The string to use for the new key name
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string RenameTo
        {
            get { return this._renameTo; }
            set { this._renameTo = value; }
        }

        // Check to see if RenameTo property is set
        internal bool IsSetRenameTo()
        {
            return this._renameTo != null;
        }

    }
}