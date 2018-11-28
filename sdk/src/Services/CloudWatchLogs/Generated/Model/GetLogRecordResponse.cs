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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This is the response object from the GetLogRecord operation.
    /// </summary>
    public partial class GetLogRecordResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _logRecord = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property LogRecord. 
        /// <para>
        /// The requested log event, as a JSON string.
        /// </para>
        /// </summary>
        public Dictionary<string, string> LogRecord
        {
            get { return this._logRecord; }
            set { this._logRecord = value; }
        }

        // Check to see if LogRecord property is set
        internal bool IsSetLogRecord()
        {
            return this._logRecord != null && this._logRecord.Count > 0; 
        }

    }
}