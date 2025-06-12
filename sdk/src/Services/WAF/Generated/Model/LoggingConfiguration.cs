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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
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
namespace Amazon.WAF.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
    /// WAF Classic</a> in the developer guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
    /// for regional and global use. 
    /// </para>
    ///  </note> 
    /// <para>
    /// The Amazon Kinesis Data Firehose, <c>RedactedFields</c> information, and the web ACL
    /// Amazon Resource Name (ARN).
    /// </para>
    /// </summary>
    public partial class LoggingConfiguration
    {
        private List<string> _logDestinationConfigs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<FieldToMatch> _redactedFields = AWSConfigs.InitializeCollections ? new List<FieldToMatch>() : null;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property LogDestinationConfigs. 
        /// <para>
        /// An array of Amazon Kinesis Data Firehose ARNs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> LogDestinationConfigs
        {
            get { return this._logDestinationConfigs; }
            set { this._logDestinationConfigs = value; }
        }

        // Check to see if LogDestinationConfigs property is set
        internal bool IsSetLogDestinationConfigs()
        {
            return this._logDestinationConfigs != null && (this._logDestinationConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RedactedFields. 
        /// <para>
        /// The parts of the request that you want redacted from the logs. For example, if you
        /// redact the cookie field, the cookie field in the firehose will be <c>xxx</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FieldToMatch> RedactedFields
        {
            get { return this._redactedFields; }
            set { this._redactedFields = value; }
        }

        // Check to see if RedactedFields property is set
        internal bool IsSetRedactedFields()
        {
            return this._redactedFields != null && (this._redactedFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the web ACL that you want to associate with <c>LogDestinationConfigs</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1224)]
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