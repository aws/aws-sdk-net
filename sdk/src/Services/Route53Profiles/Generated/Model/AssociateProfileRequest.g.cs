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
    /// Container for the parameters to the AssociateProfile operation. Associates a Route
    /// 53 Profiles profile with a VPC. A VPC can have up to two Profile associations. A Profile
    /// can be associated with up to 1,000 VPCs, and you can request a higher quota for the
    /// number of VPCs. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html#limits-api-entities-route53-profiles">Quotas
    /// on Route 53 Profiles</a>. <para> Route 53 VPC Resolver evaluates the Profile associations
    /// for a VPC in priority order, starting with the lowest <c>Priority</c> value. If the
    /// VPC has no other Profile associations, you can omit <c>Priority</c>, and the association
    /// gets priority 100. When the VPC already has a Profile association, you must specify
    /// a <c>Priority</c>, and each Profile association for the VPC must have a unique priority.
    /// To change the priority of an existing association, use <c>UpdateProfileAssociation</c>.
    /// </para> <para> The request fails with a <c>ValidationException</c> in these cases:
    /// </para> <ul> <li> <para> You omit <c>Priority</c>, and the VPC already has a Profile
    /// association. </para> </li> <li> <para> Another Profile association for the VPC already
    /// uses the priority that you specify. </para> </li> <li> <para> The priority is outside
    /// the range 100–9900. </para> </li> <li> <para> The Profile is already associated with
    /// the VPC, and you specify a different <c>Name</c> or <c>Priority</c>. To change the
    /// priority, use <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53profiles_UpdateProfileAssociation.html">UpdateProfileAssociation</a>.
    /// </para> </li> </ul> <para> The request fails with a <c>LimitExceededException</c>
    /// if the VPC already has the maximum number of Profile associations. </para>
    /// </summary>
    public partial class AssociateProfileRequest : AmazonRoute53ProfilesRequest
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  A name for the association. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        ///  The priority of the Profile association. Route 53 VPC Resolver evaluates the Profile
        /// associations for a VPC in priority order, starting with the lowest value. 
        /// </para>
        ///  
        /// <para>
        ///  When the VPC already has a Profile association, you must specify a priority that
        /// no other Profile association for the VPC uses. If you omit the priority for the first
        /// association with a VPC, the association gets priority 100. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 100, Max = 9900)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        ///  ID of the Profile. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        ///  The ID of the VPC. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A list of the tag keys and values that you want to identify the Profile association.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
