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
    /// Container for the parameters to the GetLogRecord operation.
    /// Retrieves all of the fields and values of a single log event. All fields are retrieved,
    /// even if the original query that produced the <c>logRecordPointer</c> retrieved only
    /// a subset of fields. Fields are returned as field name/field value pairs.
    /// 
    ///  
    /// <para>
    /// The full unparsed log event is returned within <c>@message</c>.
    /// </para>
    /// </summary>
    public partial class GetLogRecordRequest : AmazonCloudWatchLogsRequest
    {
        private string _logRecordPointer;
        private bool? _unmask;

        /// <summary>
        /// Gets and sets the property LogRecordPointer. 
        /// <para>
        /// The pointer corresponding to the log event record you want to retrieve. You get this
        /// from the response of a <c>GetQueryResults</c> operation. In that response, the value
        /// of the <c>@ptr</c> field for a log event is the value to use as <c>logRecordPointer</c>
        /// to retrieve that complete log event record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Unmask. 
        /// <para>
        /// Specify <c>true</c> to display the log event fields with all sensitive data unmasked
        /// and visible. The default is <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// To use this operation with this parameter, you must be signed into an account with
        /// the <c>logs:Unmask</c> permission.
        /// </para>
        /// </summary>
        public bool? Unmask
        {
            get { return this._unmask; }
            set { this._unmask = value; }
        }

        // Check to see if Unmask property is set
        internal bool IsSetUnmask()
        {
            return this._unmask.HasValue; 
        }

    }
}