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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Specifies the security analytics configuration for the web ACL. Security analytics
    /// shows the web ACL's request log data from multiple Amazon Web Services Regions in
    /// a single dashboard in the WAF console. 
    /// 
    ///  
    /// <para>
    /// When you enable security analytics, you authorize Amazon Web Services to transfer
    /// and store full request logs outside the Amazon Web Services Region where the web ACL
    /// is hosted. For regional web ACLs, security analytics is disabled by default when you
    /// omit this configuration. For web ACLs that protect CloudFront distributions (global
    /// web ACLs), security analytics is enabled by default. For more information, see <a
    /// href="https://docs.aws.amazon.com/waf/latest/developerguide/web-acl-security-analytics-enabling.html">Enabling
    /// security analytics for a protection pack (web ACL)</a> in the <i>WAF Developer Guide</i>.
    /// 
    /// </para>
    /// </summary>
    public partial class AnalyticsConfig
    {
        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The security analytics mode for the web ACL. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CROSS_REGION</c> - Enables security analytics. WAF transfers and stores the web
        /// ACL's request logs outside the Amazon Web Services Region where the web ACL is hosted,
        /// for aggregation and processing. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> - Disables security analytics. WAF stops transferring the web ACL's
        /// request logs. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnalyticsMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;
    }
}
