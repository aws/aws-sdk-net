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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Options for CloudWatch Logs as a logging destination.
    /// </summary>
    public partial class VerifiedAccessLogCloudWatchLogsDestinationOptions
    {
        private bool? _enabled;
        private string _logGroup;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether logging is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogGroup. 
        /// <para>
        /// The ID of the CloudWatch Logs log group.
        /// </para>
        /// </summary>
        public string LogGroup
        {
            get { return this._logGroup; }
            set { this._logGroup = value; }
        }

        // Check to see if LogGroup property is set
        internal bool IsSetLogGroup()
        {
            return this._logGroup != null;
        }

    }
}