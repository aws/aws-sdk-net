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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// The Amazon Kinesis Data Firehose delivery streams, <code>RedactedFields</code> information,
    /// and the web ACL Amazon Resource Name (ARN).
    /// </summary>
    public partial class LoggingConfiguration
    {
        private List<string> _logDestinationConfigs = new List<string>();
        private List<FieldToMatch> _redactedFields = new List<FieldToMatch>();
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property LogDestinationConfigs. 
        /// <para>
        /// An array of Amazon Kinesis Data Firehose delivery stream ARNs.
        /// </para>
        /// </summary>
        public List<string> LogDestinationConfigs
        {
            get { return this._logDestinationConfigs; }
            set { this._logDestinationConfigs = value; }
        }

        // Check to see if LogDestinationConfigs property is set
        internal bool IsSetLogDestinationConfigs()
        {
            return this._logDestinationConfigs != null && this._logDestinationConfigs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RedactedFields. 
        /// <para>
        /// The parts of the request that you want redacted from the logs. For example, if you
        /// redact the cookie field, the cookie field in the delivery stream will be <code>xxx</code>.
        /// 
        /// </para>
        /// </summary>
        public List<FieldToMatch> RedactedFields
        {
            get { return this._redactedFields; }
            set { this._redactedFields = value; }
        }

        // Check to see if RedactedFields property is set
        internal bool IsSetRedactedFields()
        {
            return this._redactedFields != null && this._redactedFields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the web ACL that you want to associate with <code>LogDestinationConfigs</code>.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}