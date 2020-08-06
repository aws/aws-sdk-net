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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// The values of the AWS IoT Events logging options.
    /// </summary>
    public partial class LoggingOptions
    {
        private List<DetectorDebugOption> _detectorDebugOptions = new List<DetectorDebugOption>();
        private bool? _enabled;
        private LoggingLevel _level;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property DetectorDebugOptions. 
        /// <para>
        /// Information that identifies those detector models and their detectors (instances)
        /// for which the logging level is given.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<DetectorDebugOption> DetectorDebugOptions
        {
            get { return this._detectorDebugOptions; }
            set { this._detectorDebugOptions = value; }
        }

        // Check to see if DetectorDebugOptions property is set
        internal bool IsSetDetectorDebugOptions()
        {
            return this._detectorDebugOptions != null && this._detectorDebugOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// If TRUE, logging is enabled for AWS IoT Events.
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
        /// Gets and sets the property Level. 
        /// <para>
        /// The logging level.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LoggingLevel Level
        {
            get { return this._level; }
            set { this._level = value; }
        }

        // Check to see if Level property is set
        internal bool IsSetLevel()
        {
            return this._level != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that grants permission to AWS IoT Events to perform logging.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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