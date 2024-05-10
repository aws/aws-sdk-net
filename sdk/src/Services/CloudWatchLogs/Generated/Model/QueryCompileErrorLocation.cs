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
    /// Reserved.
    /// </summary>
    public partial class QueryCompileErrorLocation
    {
        private int? _endCharOffset;
        private int? _startCharOffset;

        /// <summary>
        /// Gets and sets the property EndCharOffset. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public int? EndCharOffset
        {
            get { return this._endCharOffset; }
            set { this._endCharOffset = value; }
        }

        // Check to see if EndCharOffset property is set
        internal bool IsSetEndCharOffset()
        {
            return this._endCharOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartCharOffset. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public int? StartCharOffset
        {
            get { return this._startCharOffset; }
            set { this._startCharOffset = value; }
        }

        // Check to see if StartCharOffset property is set
        internal bool IsSetStartCharOffset()
        {
            return this._startCharOffset.HasValue; 
        }

    }
}