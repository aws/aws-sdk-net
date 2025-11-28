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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// The File Server Resource Manager (FSRM) configuration that Amazon FSx for Windows
    /// File Server uses for the file system. When FSRM is enabled, you can manage and monitor
    /// storage quotas, file screening, storage reports, and file classification.
    /// </summary>
    public partial class WindowsFsrmConfiguration
    {
        private string _eventLogDestination;
        private bool? _fsrmServiceEnabled;

        /// <summary>
        /// Gets and sets the property EventLogDestination. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the destination of the FSRM event logs. The destination
        /// can be any Amazon CloudWatch Logs log group ARN or Amazon Kinesis Data Firehose delivery
        /// stream ARN.
        /// </para>
        ///  
        /// <para>
        /// The name of the Amazon CloudWatch Logs log group must begin with the <c>/aws/fsx</c>
        /// prefix. The name of the Amazon Kinesis Data Firehose delivery stream must begin with
        /// the <c>aws-fsx</c> prefix.
        /// </para>
        ///  
        /// <para>
        /// The destination ARN (either CloudWatch Logs log group or Kinesis Data Firehose delivery
        /// stream) must be in the same Amazon Web Services partition, Amazon Web Services Region,
        /// and Amazon Web Services account as your Amazon FSx file system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=1024)]
        public string EventLogDestination
        {
            get { return this._eventLogDestination; }
            set { this._eventLogDestination = value; }
        }

        // Check to see if EventLogDestination property is set
        internal bool IsSetEventLogDestination()
        {
            return this._eventLogDestination != null;
        }

        /// <summary>
        /// Gets and sets the property FsrmServiceEnabled. 
        /// <para>
        /// Specifies whether FSRM is enabled or disabled on the file system. When <c>TRUE</c>,
        /// the FSRM service is enabled and monitor file operations according to configured policies.
        /// When <c>FALSE</c> or omitted, FSRM is disabled. The default value is <c>FALSE</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? FsrmServiceEnabled
        {
            get { return this._fsrmServiceEnabled; }
            set { this._fsrmServiceEnabled = value; }
        }

        // Check to see if FsrmServiceEnabled property is set
        internal bool IsSetFsrmServiceEnabled()
        {
            return this._fsrmServiceEnabled.HasValue; 
        }

    }
}