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
    /// Container for the parameters to the GetLogRecord operation.
    /// Retrieves all the fields and values of a single log event. All fields are retrieved,
    /// even if the original query that produced the <code>logRecordPointer</code> retrieved
    /// only a subset of fields. Fields are returned as field name/field value pairs.
    /// 
    ///  
    /// <para>
    /// Additionally, the entire unparsed log event is returned within <code>@message</code>.
    /// </para>
    /// </summary>
    public partial class GetLogRecordRequest : AmazonCloudWatchLogsRequest
    {
        private string _logRecordPointer;

        /// <summary>
        /// Gets and sets the property LogRecordPointer. 
        /// <para>
        /// The pointer corresponding to the log event record you want to retrieve. You get this
        /// from the response of a <code>GetQueryResults</code> operation. In that response, the
        /// value of the <code>@ptr</code> field for a log event is the value to use as <code>logRecordPointer</code>
        /// to retrieve that complete log event record.
        /// </para>
        /// </summary>
        public string LogRecordPointer
        {
            get { return this._logRecordPointer; }
            set { this._logRecordPointer = value; }
        }

        // Check to see if LogRecordPointer property is set
        internal bool IsSetLogRecordPointer()
        {
            return this._logRecordPointer != null;
        }

    }
}