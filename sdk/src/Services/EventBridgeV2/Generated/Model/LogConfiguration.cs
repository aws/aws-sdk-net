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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Log configuration for a subscriber.
    /// </summary>
    public partial class LogConfiguration
    {
        private IncludePayload _includePayload;
        private LogLevel _level;

        /// <summary>
        /// Gets and sets the property IncludePayload. 
        /// <para>
        /// Whether the customer event payload is embedded in log records. Defaults to ON_ERROR_ONLY.
        /// </para>
        /// </summary>
        public IncludePayload IncludePayload
        {
            get { return this._includePayload; }
            set { this._includePayload = value; }
        }

        // Check to see if IncludePayload property is set
        internal bool IsSetIncludePayload()
        {
            return this._includePayload != null;
        }

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// Minimum log level. Records below this level are not emitted. Defaults to OFF.
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