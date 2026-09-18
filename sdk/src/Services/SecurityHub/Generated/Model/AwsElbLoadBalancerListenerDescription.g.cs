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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Lists the policies that are enabled for a load balancer listener.
    /// </summary>
    public partial class AwsElbLoadBalancerListenerDescription
    {
        /// <summary>
        /// Gets and sets the property Listener. 
        /// <para>
        /// Information about the listener.
        /// </para>
        /// </summary>
        public AwsElbLoadBalancerListener Listener { get; set; }

        /// <summary>
        /// Checks to see if the Listener property is set.
        /// </summary>
        internal bool IsSetListener() => this.Listener != null;

        /// <summary>
        /// Gets and sets the property PolicyNames. 
        /// <para>
        /// The policies enabled for the listener.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PolicyNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PolicyNames property is set.
        /// </summary>
        internal bool IsSetPolicyNames() => this.PolicyNames != null && (this.PolicyNames.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
