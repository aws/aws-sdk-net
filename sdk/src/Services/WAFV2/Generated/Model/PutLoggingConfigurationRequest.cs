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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutLoggingConfiguration operation.
    /// Enables the specified <a>LoggingConfiguration</a>, to start logging from a web ACL,
    /// according to the configuration provided.
    /// 
    ///  
    /// <para>
    /// You can access information about all traffic that WAF inspects using the following
    /// steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create an Amazon Kinesis Data Firehose. 
    /// </para>
    ///  
    /// <para>
    /// Create the data firehose with a PUT source and in the Region that you are operating.
    /// If you are capturing logs for Amazon CloudFront, always create the firehose in US
    /// East (N. Virginia). 
    /// </para>
    ///  
    /// <para>
    /// Give the data firehose a name that starts with the prefix <code>aws-waf-logs-</code>.
    /// For example, <code>aws-waf-logs-us-east-2-analytics</code>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Do not create the data firehose using a <code>Kinesis stream</code> as your source.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    /// Associate that firehose to your web ACL using a <code>PutLoggingConfiguration</code>
    /// request.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// When you successfully enable logging using a <code>PutLoggingConfiguration</code>
    /// request, WAF will create a service linked role with the necessary permissions to write
    /// logs to the Amazon Kinesis Data Firehose. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
    /// Web ACL Traffic Information</a> in the <i>WAF Developer Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation completely replaces the mutable specifications that you already have
    /// for the logging configuration with the ones that you provide to this call. To modify
    /// the logging configuration, retrieve it by calling <a>GetLoggingConfiguration</a>,
    /// update the settings as needed, and then provide the complete logging configuration
    /// specification to this call.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutLoggingConfigurationRequest : AmazonWAFV2Request
    {
        private LoggingConfiguration _loggingConfiguration;

        /// <summary>
        /// Gets and sets the property LoggingConfiguration.
        /// </summary>
        [AWSProperty(Required=true)]
        public LoggingConfiguration LoggingConfiguration
        {
            get { return this._loggingConfiguration; }
            set { this._loggingConfiguration = value; }
        }

        // Check to see if LoggingConfiguration property is set
        internal bool IsSetLoggingConfiguration()
        {
            return this._loggingConfiguration != null;
        }

    }
}