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
    /// Container for the parameters to the PutLoggingConfiguration operation.
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
    /// Associates a <a>LoggingConfiguration</a> with a specified web ACL.
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
    /// Create the data firehose with a PUT source and in the region that you are operating.
    /// However, if you are capturing logs for Amazon CloudFront, always create the firehose
    /// in US East (N. Virginia). 
    /// </para>
    ///  <note> 
    /// <para>
    /// Do not create the data firehose using a <c>Kinesis stream</c> as your source.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    /// Associate that firehose to your web ACL using a <c>PutLoggingConfiguration</c> request.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// When you successfully enable logging using a <c>PutLoggingConfiguration</c> request,
    /// AWS WAF will create a service linked role with the necessary permissions to write
    /// logs to the Amazon Kinesis Data Firehose. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging.html">Logging
    /// Web ACL Traffic Information</a> in the <i>AWS WAF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class PutLoggingConfigurationRequest : AmazonWAFRequest
    {
        private LoggingConfiguration _loggingConfiguration;

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The Amazon Kinesis Data Firehose that contains the inspected traffic information,
        /// the redacted fields details, and the Amazon Resource Name (ARN) of the web ACL to
        /// monitor.
        /// </para>
        ///  <note> 
        /// <para>
        /// When specifying <c>Type</c> in <c>RedactedFields</c>, you must use one of the following
        /// values: <c>URI</c>, <c>QUERY_STRING</c>, <c>HEADER</c>, or <c>METHOD</c>.
        /// </para>
        ///  </note>
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