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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Describes the Amazon CloudWatch logs configuration for a layer.
    /// </summary>
    public partial class CloudWatchLogsConfiguration
    {
        private bool? _enabled;
        private List<CloudWatchLogsLogStream> _logStreams = new List<CloudWatchLogsLogStream>();

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether CloudWatch Logs is enabled for a layer.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LogStreams. 
        /// <para>
        /// A list of configuration options for CloudWatch Logs.
        /// </para>
        /// </summary>
        public List<CloudWatchLogsLogStream> LogStreams
        {
            get { return this._logStreams; }
            set { this._logStreams = value; }
        }

        // Check to see if LogStreams property is set
        internal bool IsSetLogStreams()
        {
            return this._logStreams != null && this._logStreams.Count > 0; 
        }

    }
}