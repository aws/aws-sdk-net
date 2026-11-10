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

namespace Amazon.Route53Profiles.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProfileAssociation operation. Updates the
    /// name or priority of the specified Route 53 Profile association with a VPC. Route 53
    /// VPC Resolver evaluates the Profile associations for a VPC in priority order, starting
    /// with the lowest value. Only the account that created the association can update it.
    /// <para> When you change the priority, the association status is <c>UPDATING</c> until
    /// the change propagates, and then <c>COMPLETE</c>. While the status is <c>UPDATING</c>,
    /// Route 53 VPC Resolver might still use the previous priority for some queries. When
    /// the status is <c>COMPLETE</c>, the new priority applies to all queries from the VPC.
    /// </para> <para> The request fails with a <c>ValidationException</c> if another Profile
    /// association for the VPC already uses the priority that you specify, or if the priority
    /// is outside the range 100–9900. </para> <para> You can update an association whose
    /// status is <c>CREATING</c>, <c>UPDATING</c>, or <c>COMPLETE</c>. The request fails
    /// with a <c>ConflictException</c> if the association status is <c>DELETING</c>, <c>DELETED</c>,
    /// or <c>FAILED</c>, or if the account that owns the association is inactive. </para>
    /// </summary>
    public partial class UpdateProfileAssociationRequest : AmazonRoute53ProfilesRequest
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the Profile association. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        ///  The new priority of the Profile association. Route 53 VPC Resolver evaluates the
        /// Profile associations for a VPC in priority order, starting with the lowest value.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The priority must be unique among the Profile associations for the VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 100, Max = 9900)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property ProfileAssociationId. 
        /// <para>
        ///  The ID of the Profile association to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ProfileAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileAssociationId property is set.
        /// </summary>
        internal bool IsSetProfileAssociationId() => this.ProfileAssociationId != null;
    }
}
