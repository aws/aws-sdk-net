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
    /// Container for the parameters to the PutLoggingConfiguration operation.
    /// Associates a <a>LoggingConfiguration</a> with a specified web ACL.
    /// 
    ///  
    /// <para>
    /// You can access information about all traffic that AWS WAF inspects using the following
    /// steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create an Amazon Kinesis Data Firehose delivery stream. For more information, see
    /// <a href="https://docs.aws.amazon.com/firehose/latest/dev/what-is-this-service.html">Creating
    /// an Amazon Kinesis Data Firehose Delivery Stream</a>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Associate that delivery stream to your web ACL using a <code>PutLoggingConfiguration</code>
    /// request.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// When you successfully enable logging using a <code>PutLoggingConfiguration</code>
    /// request, AWS WAF will create a service linked role with the necessary permissions
    /// to write logs to the Amazon Kinesis Data Firehose delivery stream. For more information,
    /// see <a href="http://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
    /// Web ACL Traffic Information</a> in the <i>AWS WAF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class PutLoggingConfigurationRequest : AmazonWAFRegionalRequest
    {
        private LoggingConfiguration _loggingConfiguration;

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The Amazon Kinesis Data Firehose delivery streams that contains the inspected traffic
        /// information, the redacted fields details, and the Amazon Resource Name (ARN) of the
        /// web ACL to monitor.
        /// </para>
        /// </summary>
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