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
    /// The automatic application layer DDoS mitigation settings for a <a>Protection</a>.
    /// This configuration determines whether Shield Advanced automatically manages rules
    /// in the web ACL in order to respond to application layer events that Shield Advanced
    /// determines to be DDoS attacks.
    /// </summary>
    public partial class ApplicationLayerAutomaticResponseConfiguration
    {
        private ResponseAction _action;
        private ApplicationLayerAutomaticResponseStatus _status;

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
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates whether automatic application layer DDoS mitigation is enabled for the protection.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApplicationLayerAutomaticResponseStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}