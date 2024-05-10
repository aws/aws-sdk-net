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
    /// Container for the parameters to the PutLoggingConfiguration operation.
    /// Enables the specified <a>LoggingConfiguration</a>, to start logging from a web ACL,
    /// according to the configuration provided. 
    /// 
    ///  <note> 
    /// <para>
    /// This operation completely replaces any mutable specifications that you already have
    /// for a logging configuration with the ones that you provide to this call. 
    /// </para>
    ///  
    /// <para>
    /// To modify an existing logging configuration, do the following: 
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Retrieve it by calling <a>GetLoggingConfiguration</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Update its settings as needed
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Provide the complete logging configuration specification to this call
    /// </para>
    ///  </li> </ol> </note> <note> 
    /// <para>
    /// You can define one logging destination per web ACL.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can access information about the traffic that WAF inspects using the following
    /// steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create your logging destination. You can use an Amazon CloudWatch Logs log group,
    /// an Amazon Simple Storage Service (Amazon S3) bucket, or an Amazon Kinesis Data Firehose.
    /// 
    /// </para>
    ///  
    /// <para>
    /// The name that you give the destination must start with <c>aws-waf-logs-</c>. Depending
    /// on the type of destination, you might need to configure additional settings or permissions.
    /// 
    /// </para>
    ///  
    /// <para>
    /// For configuration requirements and pricing information for each destination type,
    /// see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
    /// web ACL traffic</a> in the <i>WAF Developer Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Associate your logging destination to your web ACL using a <c>PutLoggingConfiguration</c>
    /// request.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// When you successfully enable logging using a <c>PutLoggingConfiguration</c> request,
    /// WAF creates an additional role or policy that is required to write logs to the logging
    /// destination. For an Amazon CloudWatch Logs log group, WAF creates a resource policy
    /// on the log group. For an Amazon S3 bucket, WAF creates a bucket policy. For an Amazon
    /// Kinesis Data Firehose, WAF creates a service-linked role.
    /// </para>
    ///  
    /// <para>
    /// For additional information about web ACL logging, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
    /// web ACL traffic information</a> in the <i>WAF Developer Guide</i>.
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