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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that represents a named entity.
    /// </summary>
    public partial class TopicNamedEntity
    {
        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The definition of a named entity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NamedEntityDefinition> Definition { get; set; } = AWSConfigs.InitializeCollections ? new List<NamedEntityDefinition>() : null;

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null && (this.Definition.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EntityDescription. 
        /// <para>
        /// The description of the named entity.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 500)]
        public string EntityDescription { get; set; }

        /// <summary>
        /// Checks to see if the EntityDescription property is set.
        /// </summary>
        internal bool IsSetEntityDescription() => this.EntityDescription != null;

        /// <summary>
        /// Gets and sets the property EntityName. 
        /// <para>
        /// The name of the named entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string EntityName { get; set; }

        /// <summary>
        /// Checks to see if the EntityName property is set.
        /// </summary>
        internal bool IsSetEntityName() => this.EntityName != null;

        /// <summary>
        /// Gets and sets the property EntitySynonyms. 
        /// <para>
        /// The other names or aliases for the named entity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EntitySynonyms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EntitySynonyms property is set.
        /// </summary>
        internal bool IsSetEntitySynonyms() => this.EntitySynonyms != null && (this.EntitySynonyms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PresentationOrder. 
        /// <para>
        /// The presentation order of the named entity.
        /// </para>
        /// </summary>
        public int? PresentationOrder { get; set; }

        /// <summary>
        /// Checks to see if the PresentationOrder property is set.
        /// </summary>
        internal bool IsSetPresentationOrder() => this.PresentationOrder.HasValue;

        /// <summary>
        /// Gets and sets the property RankOrder. 
        /// <para>
        /// The rank order of the named entity.
        /// </para>
        /// </summary>
        public int? RankOrder { get; set; }

        /// <summary>
        /// Checks to see if the RankOrder property is set.
        /// </summary>
        internal bool IsSetRankOrder() => this.RankOrder.HasValue;

        /// <summary>
        /// Gets and sets the property SemanticEntityType. 
        /// <para>
        /// The type of named entity that a topic represents.
        /// </para>
        /// </summary>
        public SemanticEntityType SemanticEntityType { get; set; }

        /// <summary>
        /// Checks to see if the SemanticEntityType property is set.
        /// </summary>
        internal bool IsSetSemanticEntityType() => this.SemanticEntityType != null;

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// The sort configuration of the named entity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<NamedEntitySort> Sort { get; set; } = AWSConfigs.InitializeCollections ? new List<NamedEntitySort>() : null;

        /// <summary>
        /// Checks to see if the Sort property is set.
        /// </summary>
        internal bool IsSetSort() => this.Sort != null && (this.Sort.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
