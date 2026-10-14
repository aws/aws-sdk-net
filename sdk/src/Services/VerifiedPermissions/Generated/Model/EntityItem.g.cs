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

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Contains information about an entity that can be referenced in a Cedar policy.
    /// 
    ///  
    /// <para>
    /// This data type is used as one of the fields in the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_EntitiesDefinition.html">EntitiesDefinition</a>
    /// structure.
    /// </para>
    ///  
    /// <para>
    ///  <c>{ "identifier": { "entityType": "Photo", "entityId": "VacationPhoto94.jpg" },
    /// "attributes": {}, "parents": [ { "entityType": "Album", "entityId": "alice_folder"
    /// } ] }</c> 
    /// </para>
    /// </summary>
    public partial class EntityItem
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A list of attributes for the entity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeValue> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EntityIdentifier Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property Parents. 
        /// <para>
        /// The parent entities in the hierarchy that contains the entity. A principal or resource
        /// entity can be defined with at most 99 <i>transitive parents</i> per authorization
        /// request. 
        /// </para>
        ///  
        /// <para>
        /// A transitive parent is an entity in the hierarchy of entities including all direct
        /// parents, and parents of parents. For example, a user can be a member of 91 groups
        /// if one of those groups is a member of eight groups, for a total of 100: one entity,
        /// 91 entity parents, and eight parents of parents. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EntityIdentifier> Parents { get; set; } = AWSConfigs.InitializeCollections ? new List<EntityIdentifier>() : null;

        /// <summary>
        /// Checks to see if the Parents property is set.
        /// </summary>
        internal bool IsSetParents() => this.Parents != null && (this.Parents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of cedar tags for the entity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, CedarTagValue> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, CedarTagValue>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
