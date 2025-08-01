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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// The logging configuration settings for the event bus.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/eb-event-bus-logs.html">Configuring
    /// logs for event buses</a> in the <i>EventBridge User Guide</i>.
    /// </para>
    /// </summary>
    public partial class LogConfig
    {
        private IncludeDetail _includeDetail;
        private Level _level;

        /// <summary>
        /// Gets and sets the property IncludeDetail. 
        /// <para>
        /// Whether EventBridge include detailed event information in the records it generates.
        /// Detailed data can be useful for troubleshooting and debugging. This information includes
        /// details of the event itself, as well as target details.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-event-bus-logs.html#eb-event-logs-data">Including
        /// detail data in event bus logs</a> in the <i>EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        public IncludeDetail IncludeDetail
        {
            get { return this._includeDetail; }
            set { this._includeDetail = value; }
        }

        // Check to see if IncludeDetail property is set
        internal bool IsSetIncludeDetail()
        {
            return this._includeDetail != null;
        }

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// The level of logging detail to include. This applies to all log destinations for the
        /// event bus.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-event-bus-logs.html#eb-event-bus-logs-level">Specifying
        /// event bus log level</a> in the <i>EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        public Level Level
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