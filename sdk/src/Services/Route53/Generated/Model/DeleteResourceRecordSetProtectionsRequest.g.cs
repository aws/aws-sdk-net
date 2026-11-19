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
    /// Container for the parameters to the DeleteResourceRecordSetProtections operation.
    /// Deletes one or more resource record set protections from a hosted zone. After a protection
    /// is deleted, you can change the resource record sets that have that name and type by
    /// using <c>ChangeResourceRecordSets</c>. <para> The request is atomic. Route 53 either
    /// deletes all of the protections in the request or none of them. If one or more entries
    /// fail, for example because no protection exists for the specified name and type, Route
    /// 53 returns an <c>InvalidResourceRecordSetProtectionBatch</c> error that lists the
    /// failing entries and the reason that each one failed. </para> <para> You can specify
    /// up to 100 protections in one request. </para>
    /// </summary>
    public partial class DeleteResourceRecordSetProtectionsRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone that contains the protections that you want to delete.
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
        /// The name and type of each protection to delete. The list must contain at least one
        /// entry and can contain up to 100 entries. Each name and type can appear only once in
        /// the list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<ResourceRecordSetProtectionKey> Protections { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceRecordSetProtectionKey>() : null;

        /// <summary>
        /// Checks to see if the Protections property is set.
        /// </summary>
        internal bool IsSetProtections() => this.Protections != null && (this.Protections.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
