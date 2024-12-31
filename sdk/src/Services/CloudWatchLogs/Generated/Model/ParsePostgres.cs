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
    /// Use this processor to parse RDS for PostgreSQL vended logs, extract fields, and and
    /// convert them into a JSON format. This processor always processes the entire log event
    /// message. For more information about this processor including examples, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-parsePostGres">
    /// parsePostGres</a>.
    /// 
    ///  
    /// <para>
    /// For more information about RDS for PostgreSQL log format, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_LogAccess.Concepts.PostgreSQL.html#USER_LogAccess.Concepts.PostgreSQL.Log_Format.log-line-prefix">
    /// RDS for PostgreSQL database log filesTCP flag sequence</a>.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you use this processor, it must be the first processor in your transformer.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ParsePostgres
    {
        private string _source;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Omit this parameter and the whole log message will be processed by this processor.
        /// No other value than <c>@message</c> is allowed for <c>source</c>.
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