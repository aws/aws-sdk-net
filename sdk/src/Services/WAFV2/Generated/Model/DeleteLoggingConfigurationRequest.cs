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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteLoggingConfiguration operation.
    /// Deletes the <a>LoggingConfiguration</a> from the specified web ACL.
    /// </summary>
    public partial class DeleteLoggingConfigurationRequest : AmazonWAFV2Request
    {
        private LogScope _logScope;
        private LogType _logType;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property LogScope. 
        /// <para>
        /// The owner of the logging configuration, which must be set to <c>CUSTOMER</c> for the
        /// configurations that you manage. 
        /// </para>
        ///  
        /// <para>
        /// The log scope <c>SECURITY_LAKE</c> indicates a configuration that is managed through
        /// Amazon Security Lake. You can use Security Lake to collect log and event data from
        /// various sources for normalization, analysis, and management. For information, see
        /// <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/internal-sources.html">Collecting
        /// data from Amazon Web Services services</a> in the <i>Amazon Security Lake user guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>CUSTOMER</c> 
        /// </para>
        /// </summary>
        public LogScope LogScope
        {
            get { return this._logScope; }
            set { this._logScope = value; }
        }

        // Check to see if LogScope property is set
        internal bool IsSetLogScope()
        {
            return this._logScope != null;
        }

        /// <summary>
        /// Gets and sets the property LogType. 
        /// <para>
        /// Used to distinguish between various logging options. Currently, there is one option.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>WAF_LOGS</c> 
        /// </para>
        /// </summary>
        public LogType LogType
        {
            get { return this._logType; }
            set { this._logType = value; }
        }

        // Check to see if LogType property is set
        internal bool IsSetLogType()
        {
            return this._logType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the web ACL from which you want to delete the <a>LoggingConfiguration</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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