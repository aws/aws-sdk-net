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

namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Describes why a firewall is out of sync. Exactly one of <c>missingFirewall</c>, <c>invalidFirewall</c>,
    /// or <c>invalidResource</c> contains a value.
    /// </summary>
    public partial class FirewallSyncReason
    {
        /// <summary>
        /// Gets and sets the property InvalidFirewall. 
        /// <para>
        /// Details about a firewall whose configuration does not match the intended configuration.
        /// </para>
        /// </summary>
        public InvalidFirewallReasons InvalidFirewall { get; set; }

        /// <summary>
        /// Checks to see if the InvalidFirewall property is set.
        /// </summary>
        internal bool IsSetInvalidFirewall() => this.InvalidFirewall != null;

        /// <summary>
        /// Gets and sets the property InvalidResource. 
        /// <para>
        /// A map of related resources whose configuration does not match the intended configuration,
        /// grouped by resource type. Each entry lists the resources of that type that are out
        /// of sync. For example, subnets whose connectivity type differs from the connectivity
        /// type that the policy specifies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public Dictionary<string, List<InvalidResourceIssue>> InvalidResource { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<InvalidResourceIssue>>() : null;

        /// <summary>
        /// Checks to see if the InvalidResource property is set.
        /// </summary>
        internal bool IsSetInvalidResource() => this.InvalidResource != null && (this.InvalidResource.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MissingFirewall. 
        /// <para>
        /// Indicates that an expected firewall is missing. The value describes the missing firewall.
        /// </para>
        /// </summary>
        public string MissingFirewall { get; set; }

        /// <summary>
        /// Checks to see if the MissingFirewall property is set.
        /// </summary>
        internal bool IsSetMissingFirewall() => this.MissingFirewall != null;
    }
}
