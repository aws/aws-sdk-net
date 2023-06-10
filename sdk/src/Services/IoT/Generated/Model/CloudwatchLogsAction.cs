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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes an action that sends data to CloudWatch Logs.
    /// </summary>
    public partial class CloudwatchLogsAction
    {
        private bool? _batchMode;
        private string _logGroupName;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property BatchMode. 
        /// <para>
        /// Indicates whether batches of log records will be extracted and uploaded into CloudWatch.
        /// Values include <code>true</code> or <code>false</code> <i>(default)</i>.
        /// </para>
        /// </summary>
        public bool BatchMode
        {
            get { return this._batchMode.GetValueOrDefault(); }
            set { this._batchMode = value; }
        }

        // Check to see if BatchMode property is set
        internal bool IsSetBatchMode()
        {
            return this._batchMode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The CloudWatch log group to which the action sends data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role that allows access to the CloudWatch log.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}