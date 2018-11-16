/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Specifies the format and location of the input data.
    /// </summary>
    public partial class EntityRecognizerInputDataConfig
    {
        private EntityRecognizerAnnotations _annotations;
        private EntityRecognizerDocuments _documents;
        private EntityRecognizerEntityList _entityList;
        private List<EntityTypesListItem> _entityTypes = new List<EntityTypesListItem>();

        /// <summary>
        /// Gets and sets the property Annotations. 
        /// <para>
        /// S3 location of the annotations file for an entity recognizer.
        /// </para>
        /// </summary>
        public EntityRecognizerAnnotations Annotations
        {
            get { return this._annotations; }
            set { this._annotations = value; }
        }

        // Check to see if Annotations property is set
        internal bool IsSetAnnotations()
        {
            return this._annotations != null;
        }

        /// <summary>
        /// Gets and sets the property Documents. 
        /// <para>
        /// S3 location of the documents folder for an entity recognizer
        /// </para>
        /// </summary>
        public EntityRecognizerDocuments Documents
        {
            get { return this._documents; }
            set { this._documents = value; }
        }

        // Check to see if Documents property is set
        internal bool IsSetDocuments()
        {
            return this._documents != null;
        }

        /// <summary>
        /// Gets and sets the property EntityList. 
        /// <para>
        /// S3 location of the entity list for an entity recognizer.
        /// </para>
        /// </summary>
        public EntityRecognizerEntityList EntityList
        {
            get { return this._entityList; }
            set { this._entityList = value; }
        }

        // Check to see if EntityList property is set
        internal bool IsSetEntityList()
        {
            return this._entityList != null;
        }

        /// <summary>
        /// Gets and sets the property EntityTypes. 
        /// <para>
        /// The entity types in the input data for an entity recognizer.
        /// </para>
        /// </summary>
        public List<EntityTypesListItem> EntityTypes
        {
            get { return this._entityTypes; }
            set { this._entityTypes = value; }
        }

        // Check to see if EntityTypes property is set
        internal bool IsSetEntityTypes()
        {
            return this._entityTypes != null && this._entityTypes.Count > 0; 
        }

    }
}