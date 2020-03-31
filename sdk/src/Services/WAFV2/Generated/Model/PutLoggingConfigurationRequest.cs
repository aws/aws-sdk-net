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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutLoggingConfiguration operation.
    /// <note> 
    /// <para>
    /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
    /// 2019. For information, including how to migrate your AWS WAF resources from the prior
    /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Enables the specified <a>LoggingConfiguration</a>, to start logging from a web ACL,
    /// according to the configuration provided.
    /// </para>
    ///  
    /// <para>
    /// You can access information about all traffic that AWS WAF inspects using the following
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
    /// request, AWS WAF will create a service linked role with the necessary permissions
    /// to write logs to the Amazon Kinesis Data Firehose. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
    /// Web ACL Traffic Information</a> in the <i>AWS WAF Developer Guide</i>.
    /// </para>
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