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
    /// This processor parses log events that are in JSON format. It can extract JSON key-value
    /// pairs and place them under a destination that you specify.
    /// 
    ///  
    /// <para>
    /// Additionally, because you must have at least one parse-type processor in a transformer,
    /// you can use <c>ParseJSON</c> as that processor for JSON-format logs, so that you can
    /// also apply other processors, such as mutate processors, to these logs.
    /// </para>
    ///  
    /// <para>
    /// For more information about this processor including examples, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-parseJSON">
    /// parseJSON</a> in the <i>CloudWatch Logs User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ParseJSON
    {
        private string _destination;
        private string _source;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The location to put the parsed key value pair into. If you omit this parameter, it
        /// is placed under the root node.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Path to the field in the log event that will be parsed. Use dot notation to access
        /// child fields. For example, <c>store.book</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}