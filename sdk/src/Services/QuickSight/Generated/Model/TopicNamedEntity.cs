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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private List<NamedEntityDefinition> _definition = AWSConfigs.InitializeCollections ? new List<NamedEntityDefinition>() : null;
        private string _entityDescription;
        private string _entityName;
        private List<string> _entitySynonyms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SemanticEntityType _semanticEntityType;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The definition of a named entity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NamedEntityDefinition> Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null && (this._definition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EntityDescription. 
        /// <para>
        /// The description of the named entity.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string EntityDescription
        {
            get { return this._entityDescription; }
            set { this._entityDescription = value; }
        }

        // Check to see if EntityDescription property is set
        internal bool IsSetEntityDescription()
        {
            return this._entityDescription != null;
        }

        /// <summary>
        /// Gets and sets the property EntityName. 
        /// <para>
        /// The name of the named entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string EntityName
        {
            get { return this._entityName; }
            set { this._entityName = value; }
        }

        // Check to see if EntityName property is set
        internal bool IsSetEntityName()
        {
            return this._entityName != null;
        }

        /// <summary>
        /// Gets and sets the property EntitySynonyms. 
        /// <para>
        /// The other names or aliases for the named entity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EntitySynonyms
        {
            get { return this._entitySynonyms; }
            set { this._entitySynonyms = value; }
        }

        // Check to see if EntitySynonyms property is set
        internal bool IsSetEntitySynonyms()
        {
            return this._entitySynonyms != null && (this._entitySynonyms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SemanticEntityType. 
        /// <para>
        /// The type of named entity that a topic represents.
        /// </para>
        /// </summary>
        public SemanticEntityType SemanticEntityType
        {
            get { return this._semanticEntityType; }
            set { this._semanticEntityType = value; }
        }

        // Check to see if SemanticEntityType property is set
        internal bool IsSetSemanticEntityType()
        {
            return this._semanticEntityType != null;
        }

    }
}