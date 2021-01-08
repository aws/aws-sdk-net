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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// This is the response object from the DetectEntities operation.
    /// </summary>
    public partial class DetectEntitiesResponse : AmazonWebServiceResponse
    {
        private List<Entity> _entities = new List<Entity>();

        /// <summary>
        /// Gets and sets the property Entities. 
        /// <para>
        /// A collection of entities identified in the input text. For each entity, the response
        /// provides the entity text, entity type, where the entity text begins and ends, and
        /// the level of confidence that Amazon Comprehend has in the detection. 
        /// </para>
        ///  
        /// <para>
        /// If your request uses a custom entity recognition model, Amazon Comprehend detects
        /// the entities that the model is trained to recognize. Otherwise, it detects the default
        /// entity types. For a list of default entity types, see <a>how-entities</a>.
        /// </para>
        /// </summary>
        public List<Entity> Entities
        {
            get { return this._entities; }
            set { this._entities = value; }
        }

        // Check to see if Entities property is set
        internal bool IsSetEntities()
        {
            return this._entities != null && this._entities.Count > 0; 
        }

    }
}