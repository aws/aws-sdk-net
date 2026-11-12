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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the CreateResourceRecordSetProtections operation.
    /// Creates one or more resource record set protections in a hosted zone. A protection
    /// applies to every resource record set in the hosted zone that has the specified name
    /// and type. While a protection exists, Route 53 rejects any <c>ChangeResourceRecordSets</c>
    /// request that creates, updates, or deletes a resource record set with that name and
    /// type, and returns an <c>InvalidChangeBatch</c> error. To change a protected resource
    /// record set, first delete its protection by using <c>DeleteResourceRecordSetProtections</c>.
    /// <para> You can create a protection for a name and type that doesn't have a resource
    /// record set yet. In that case, Route 53 also rejects requests to create that resource
    /// record set. </para> <para> You can't delete a hosted zone that has protections. To
    /// delete the hosted zone, first delete all of its protections by using <c>DeleteResourceRecordSetProtections</c>.
    /// </para> <para> The request is atomic. Route 53 either creates all of the protections
    /// in the request or none of them. If one or more entries fail, the response is an error
    /// that lists the failing entries and the reason that each one failed. Route 53 checks
    /// for invalid entries before it checks for existing protections, so if any entry is
    /// invalid, the error lists only the invalid entries. </para> <para> The error that Route
    /// 53 returns depends on the failures: </para> <ul> <li> <para> If every entry already
    /// has a protection, Route 53 returns a <c>ProtectionAlreadyExists</c> error. </para>
    /// </li> <li> <para> For any other combination of failures, Route 53 returns an <c>InvalidResourceRecordSetProtectionBatch</c>
    /// error. </para> </li> </ul> <para> You can specify up to 100 protections in one request.
    /// The number of protections that you can have in a hosted zone is limited by a quota.
    /// If the request would exceed that quota, Route 53 returns a <c>LimitsExceeded</c> error.
    /// </para>
    /// </summary>
    public partial class CreateResourceRecordSetProtectionsRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone that contains the resource record sets that you want to
        /// protect.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string HostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneId property is set.
        /// </summary>
        internal bool IsSetHostedZoneId() => this.HostedZoneId != null;

        /// <summary>
        /// Gets and sets the property Protections. 
        /// <para>
        /// The protections to create. Each entry specifies a resource record set name and type,
        /// and an optional comment. The list must contain at least one entry and can contain
        /// up to 100 entries. Each name and type can appear only once in the list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<ResourceRecordSetProtectionConfig> Protections { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceRecordSetProtectionConfig>() : null;

        /// <summary>
        /// Checks to see if the Protections property is set.
        /// </summary>
        internal bool IsSetProtections() => this.Protections != null && (this.Protections.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
