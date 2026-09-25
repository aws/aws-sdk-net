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

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Describes the Firewall configuration for a hosted Amplify application. Firewall support
    /// enables you to protect your web applications with a direct integration with WAF. For
    /// more information about using WAF protections for an Amplify application, see <a href="https://docs.aws.amazon.com/amplify/latest/userguide/WAF-integration.html">Firewall
    /// support for hosted sites</a> in the <i>Amplify User Guide</i>.
    /// </summary>
    public partial class WafConfiguration
    {
        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the current status of the Firewall configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property WafStatus. 
        /// <para>
        /// The status of the process to associate or disassociate a web ACL to an Amplify app.
        /// </para>
        /// </summary>
        public WafStatus WafStatus { get; set; }

        /// <summary>
        /// Checks to see if the WafStatus property is set.
        /// </summary>
        internal bool IsSetWafStatus() => this.WafStatus != null;

        /// <summary>
        /// Gets and sets the property WebAclArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the web ACL associated with an Amplify app.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string WebAclArn { get; set; }

        /// <summary>
        /// Checks to see if the WebAclArn property is set.
        /// </summary>
        internal bool IsSetWebAclArn() => this.WebAclArn != null;
    }
}
