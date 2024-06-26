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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The structure of a traffic policy resource which is a container for policy statements.
    /// </summary>
    public partial class TrafficPolicy
    {
        private AcceptAction _defaultAction;
        private string _trafficPolicyId;
        private string _trafficPolicyName;

        /// <summary>
        /// Gets and sets the property DefaultAction. 
        /// <para>
        /// Default action instructs the traﬃc policy to either Allow or Deny (block) messages
        /// that fall outside of (or not addressed by) the conditions of your policy statements
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AcceptAction DefaultAction
        {
            get { return this._defaultAction; }
            set { this._defaultAction = value; }
        }

        // Check to see if DefaultAction property is set
        internal bool IsSetDefaultAction()
        {
            return this._defaultAction != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyId. 
        /// <para>
        /// The identifier of the traffic policy resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TrafficPolicyId
        {
            get { return this._trafficPolicyId; }
            set { this._trafficPolicyId = value; }
        }

        // Check to see if TrafficPolicyId property is set
        internal bool IsSetTrafficPolicyId()
        {
            return this._trafficPolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyName. 
        /// <para>
        /// A user-friendly name of the traffic policy resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string TrafficPolicyName
        {
            get { return this._trafficPolicyName; }
            set { this._trafficPolicyName = value; }
        }

        // Check to see if TrafficPolicyName property is set
        internal bool IsSetTrafficPolicyName()
        {
            return this._trafficPolicyName != null;
        }

    }
}