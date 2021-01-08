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
    /// Specifies the format and location of the input data.
    /// </summary>
    public partial class EntityRecognizerInputDataConfig
    {
        private EntityRecognizerAnnotations _annotations;
        private List<AugmentedManifestsListItem> _augmentedManifests = new List<AugmentedManifestsListItem>();
        private EntityRecognizerDataFormat _dataFormat;
        private EntityRecognizerDocuments _documents;
        private EntityRecognizerEntityList _entityList;
        private List<EntityTypesListItem> _entityTypes = new List<EntityTypesListItem>();

        /// <summary>
        /// Gets and sets the property Annotations. 
        /// <para>
        /// The S3 location of the CSV file that annotates your training documents.
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
        /// Gets and sets the property AugmentedManifests. 
        /// <para>
        /// A list of augmented manifest files that provide training data for your custom model.
        /// An augmented manifest file is a labeled dataset that is produced by Amazon SageMaker
        /// Ground Truth.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required if you set <code>DataFormat</code> to <code>AUGMENTED_MANIFEST</code>.
        /// </para>
        /// </summary>
        public List<AugmentedManifestsListItem> AugmentedManifests
        {
            get { return this._augmentedManifests; }
            set { this._augmentedManifests = value; }
        }

        // Check to see if AugmentedManifests property is set
        internal bool IsSetAugmentedManifests()
        {
            return this._augmentedManifests != null && this._augmentedManifests.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DataFormat. 
        /// <para>
        /// The format of your training data:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>COMPREHEND_CSV</code>: A CSV file that supplements your training documents.
        /// The CSV file contains information about the custom entities that your trained model
        /// will detect. The required format of the file depends on whether you are providing
        /// annotations or an entity list.
        /// </para>
        ///  
        /// <para>
        /// If you use this value, you must provide your CSV file by using either the <code>Annotations</code>
        /// or <code>EntityList</code> parameters. You must provide your training documents by
        /// using the <code>Documents</code> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AUGMENTED_MANIFEST</code>: A labeled dataset that is produced by Amazon SageMaker
        /// Ground Truth. This file is in JSON lines format. Each line is a complete JSON object
        /// that contains a training document and its labels. Each label annotates a named entity
        /// in the training document. 
        /// </para>
        ///  
        /// <para>
        /// If you use this value, you must provide the <code>AugmentedManifests</code> parameter
        /// in your request.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a value, Amazon Comprehend uses <code>COMPREHEND_CSV</code> as
        /// the default.
        /// </para>
        /// </summary>
        public EntityRecognizerDataFormat DataFormat
        {
            get { return this._dataFormat; }
            set { this._dataFormat = value; }
        }

        // Check to see if DataFormat property is set
        internal bool IsSetDataFormat()
        {
            return this._dataFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Documents. 
        /// <para>
        /// The S3 location of the folder that contains the training documents for your custom
        /// entity recognizer.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required if you set <code>DataFormat</code> to <code>COMPREHEND_CSV</code>.
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
        /// The S3 location of the CSV file that has the entity list for your custom entity recognizer.
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
        /// The entity types in the labeled training data that Amazon Comprehend uses to train
        /// the custom entity recognizer. Any entity types that you don't specify are ignored.
        /// </para>
        ///  
        /// <para>
        /// A maximum of 25 entity types can be used at one time to train an entity recognizer.
        /// Entity types must not contain the following invalid characters: \n (line break), \\n
        /// (escaped line break), \r (carriage return), \\r (escaped carriage return), \t (tab),
        /// \\t (escaped tab), space, and , (comma). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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