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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// A custom action to use in stateless rule actions settings. This is used in <a>CustomAction</a>.
    /// </summary>
    public partial class ActionDefinition
    {
        private PublishMetricAction _publishMetricAction;

        /// <summary>
        /// Gets and sets the property PublishMetricAction. 
        /// <para>
        /// Stateless inspection criteria that publishes the specified metrics to Amazon CloudWatch
        /// for the matching packet. This setting defines a CloudWatch dimension value to be published.
        /// </para>
        ///  
        /// <para>
        /// You can pair this custom action with any of the standard stateless rule actions. For
        /// example, you could pair this in a rule action with the standard action that forwards
        /// the packet for stateful inspection. Then, when a packet matches the rule, Network
        /// Firewall publishes metrics for the packet and forwards it. 
        /// </para>
        /// </summary>
        public PublishMetricAction PublishMetricAction
        {
            get { return this._publishMetricAction; }
            set { this._publishMetricAction = value; }
        }

        // Check to see if PublishMetricAction property is set
        internal bool IsSetPublishMetricAction()
        {
            return this._publishMetricAction != null;
        }

    }
}