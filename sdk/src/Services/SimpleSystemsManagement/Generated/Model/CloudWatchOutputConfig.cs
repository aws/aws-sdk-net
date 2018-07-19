/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Configuration options for sending command output to CloudWatch Logs.
    /// </summary>
    public partial class CloudWatchOutputConfig
    {
        private string _cloudWatchLogGroupName;
        private bool? _cloudWatchOutputEnabled;

        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupName. 
        /// <para>
        /// The name of the CloudWatch log group where you want to send command output. If you
        /// don't specify a group name, Systems Manager automatically creates a log group for
        /// you. The log group uses the following naming format: aws/ssm/<i>SystemsManagerDocumentName</i>.
        /// </para>
        /// </summary>
        public string CloudWatchLogGroupName
        {
            get { return this._cloudWatchLogGroupName; }
            set { this._cloudWatchLogGroupName = value; }
        }

        // Check to see if CloudWatchLogGroupName property is set
        internal bool IsSetCloudWatchLogGroupName()
        {
            return this._cloudWatchLogGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchOutputEnabled. 
        /// <para>
        /// Enables Systems Manager to send command output to CloudWatch Logs.
        /// </para>
        /// </summary>
        public bool CloudWatchOutputEnabled
        {
            get { return this._cloudWatchOutputEnabled.GetValueOrDefault(); }
            set { this._cloudWatchOutputEnabled = value; }
        }

        // Check to see if CloudWatchOutputEnabled property is set
        internal bool IsSetCloudWatchOutputEnabled()
        {
            return this._cloudWatchOutputEnabled.HasValue; 
        }

    }
}