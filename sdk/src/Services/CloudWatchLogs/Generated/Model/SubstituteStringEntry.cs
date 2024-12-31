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
    /// This object defines one log field key that will be replaced using the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-substituteString">
    /// substituteString</a> processor.
    /// </summary>
    public partial class SubstituteStringEntry
    {
        private string _from;
        private string _source;
        private string _to;

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The regular expression string to be replaced. Special regex characters such as [ and
        /// ] must be escaped using \\ when using double quotes and with \ when using single quotes.
        /// For more information, see <a href="https://docs.oracle.com/en/java/javase/17/docs/api/java.base/java/util/regex/Pattern.html">
        /// Class Pattern</a> on the Oracle web site.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string From
        {
            get { return this._from; }
            set { this._from = value; }
        }

        // Check to see if From property is set
        internal bool IsSetFrom()
        {
            return this._from != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The key to modify
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// The string to be substituted for each match of <c>from</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string To
        {
            get { return this._to; }
            set { this._to = value; }
        }

        // Check to see if To property is set
        internal bool IsSetTo()
        {
            return this._to != null;
        }

    }
}