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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
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
namespace Amazon.Shield.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateHealthCheck operation.
    /// Removes health-based detection from the Shield Advanced protection for a resource.
    /// Shield Advanced health-based detection uses the health of your Amazon Web Services
    /// resource to improve responsiveness and accuracy in attack detection and response.
    /// 
    /// 
    ///  
    /// <para>
    /// You define the health check in Route 53 and then associate or disassociate it with
    /// your Shield Advanced protection. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/ddos-overview.html#ddos-advanced-health-check-option">Shield
    /// Advanced Health-Based Detection</a> in the <i>WAF Developer Guide</i>. 
    /// </para>
    /// </summary>
    public partial class DisassociateHealthCheckRequest : AmazonShieldRequest
    {
        private string _healthCheckArn;
        private string _protectionId;

        /// <summary>
        /// Gets and sets the property HealthCheckArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the health check that is associated with the protection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string HealthCheckArn
        {
            get { return this._healthCheckArn; }
            set { this._healthCheckArn = value; }
        }

        // Check to see if HealthCheckArn property is set
        internal bool IsSetHealthCheckArn()
        {
            return this._healthCheckArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProtectionId. 
        /// <para>
        /// The unique identifier (ID) for the <a>Protection</a> object to remove the health check
        /// association from. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ProtectionId
        {
            get { return this._protectionId; }
            set { this._protectionId = value; }
        }

        // Check to see if ProtectionId property is set
        internal bool IsSetProtectionId()
        {
            return this._protectionId != null;
        }

    }
}