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
    /// Use this processor to rename keys in a log event.
    /// 
    ///  
    /// <para>
    /// For more information about this processor including examples, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-renameKeys">
    /// renameKeys</a> in the <i>CloudWatch Logs User Guide</i>.
    /// </para>
    /// </summary>
    public partial class RenameKeys
    {
        private List<RenameKeyEntry> _entries = AWSConfigs.InitializeCollections ? new List<RenameKeyEntry>() : null;

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// An array of <c>RenameKeyEntry</c> objects, where each object contains the information
        /// about a single key to rename. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<RenameKeyEntry> Entries
        {
            get { return this._entries; }
            set { this._entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this._entries != null && (this._entries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}