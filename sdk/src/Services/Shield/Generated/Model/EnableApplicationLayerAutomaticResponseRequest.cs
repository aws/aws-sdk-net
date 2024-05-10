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
    /// Container for the parameters to the EnableApplicationLayerAutomaticResponse operation.
    /// Enable the Shield Advanced automatic application layer DDoS mitigation for the protected
    /// resource. 
    /// 
    ///  <note> 
    /// <para>
    /// This feature is available for Amazon CloudFront distributions and Application Load
    /// Balancers only.
    /// </para>
    ///  </note> 
    /// <para>
    /// This causes Shield Advanced to create, verify, and apply WAF rules for DDoS attacks
    /// that it detects for the resource. Shield Advanced applies the rules in a Shield rule
    /// group inside the web ACL that you've associated with the resource. For information
    /// about how automatic mitigation works and the requirements for using it, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/ddos-advanced-automatic-app-layer-response.html">Shield
    /// Advanced automatic application layer DDoS mitigation</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Don't use this action to make changes to automatic mitigation settings when it's already
    /// enabled for a resource. Instead, use <a>UpdateApplicationLayerAutomaticResponse</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// To use this feature, you must associate a web ACL with the protected resource. The
    /// web ACL must be created using the latest version of WAF (v2). You can associate the
    /// web ACL through the Shield Advanced console at <a href="https://console.aws.amazon.com/wafv2/shieldv2#/">https://console.aws.amazon.com/wafv2/shieldv2#/</a>.
    /// For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/getting-started-ddos.html">Getting
    /// Started with Shield Advanced</a>. You can also associate the web ACL to the resource
    /// through the WAF console or the WAF API, but you must manage Shield Advanced automatic
    /// mitigation through Shield Advanced. For information about WAF, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">WAF
    /// Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class EnableApplicationLayerAutomaticResponseRequest : AmazonShieldRequest
    {
        private ResponseAction _action;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies the action setting that Shield Advanced should use in the WAF rules that
        /// it creates on behalf of the protected resource in response to DDoS attacks. You specify
        /// this as part of the configuration for the automatic application layer DDoS mitigation
        /// feature, when you enable or update automatic mitigation. Shield Advanced creates the
        /// WAF rules in a Shield Advanced-managed rule group, inside the web ACL that you have
        /// associated with the resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResponseAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the protected resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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