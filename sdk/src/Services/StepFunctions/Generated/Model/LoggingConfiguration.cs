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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// The <code>LoggingConfiguration</code> data type is used to set CloudWatch Logs options.
    /// </summary>
    public partial class LoggingConfiguration
    {
        private List<LogDestination> _destinations = new List<LogDestination>();
        private bool? _includeExecutionData;
        private LogLevel _level;

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// An array of objects that describes where your execution history events will be logged.
        /// Limited to size 1. Required, if your log level is not set to <code>OFF</code>.
        /// </para>
        /// </summary>
        public List<LogDestination> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && this._destinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IncludeExecutionData. 
        /// <para>
        /// Determines whether execution data is included in your log. When set to <code>false</code>,
        /// data is excluded.
        /// </para>
        /// </summary>
        public bool IncludeExecutionData
        {
            get { return this._includeExecutionData.GetValueOrDefault(); }
            set { this._includeExecutionData = value; }
        }

        // Check to see if IncludeExecutionData property is set
        internal bool IsSetIncludeExecutionData()
        {
            return this._includeExecutionData.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// Defines which category of execution history events are logged.
        /// </para>
        /// </summary>
        public LogLevel Level
        {
            get { return this._level; }
            set { this._level = value; }
        }

        // Check to see if Level property is set
        internal bool IsSetLevel()
        {
            return this._level != null;
        }

    }
}