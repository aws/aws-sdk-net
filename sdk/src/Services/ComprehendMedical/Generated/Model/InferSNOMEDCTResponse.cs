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
 * Do not modify this file. This file is generated from the comprehendmedical-2018-10-30.normal.json service model.
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
namespace Amazon.ComprehendMedical.Model
{
    /// <summary>
    /// This is the response object from the InferSNOMEDCT operation.
    /// </summary>
    public partial class InferSNOMEDCTResponse : AmazonWebServiceResponse
    {
        private Characters _characters;
        private List<SNOMEDCTEntity> _entities = AWSConfigs.InitializeCollections ? new List<SNOMEDCTEntity>() : null;
        private string _modelVersion;
        private string _paginationToken;
        private SNOMEDCTDetails _snomedctDetails;

        /// <summary>
        /// Gets and sets the property Characters. 
        /// <para>
        ///  The number of characters in the input request documentation. 
        /// </para>
        /// </summary>
        public Characters Characters
        {
            get { return this._characters; }
            set { this._characters = value; }
        }

        // Check to see if Characters property is set
        internal bool IsSetCharacters()
        {
            return this._characters != null;
        }

        /// <summary>
        /// Gets and sets the property Entities. 
        /// <para>
        ///  The collection of medical concept entities extracted from the input text and their
        /// associated information. For each entity, the response provides the entity text, the
        /// entity category, where the entity text begins and ends, and the level of confidence
        /// that Amazon Comprehend Medical has in the detection and analysis. Attributes and traits
        /// of the entity are also returned. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SNOMEDCTEntity> Entities
        {
            get { return this._entities; }
            set { this._entities = value; }
        }

        // Check to see if Entities property is set
        internal bool IsSetEntities()
        {
            return this._entities != null && (this._entities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        ///  The version of the model used to analyze the documents, in the format n.n.n You can
        /// use this information to track the model used for a particular batch of documents.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ModelVersion
        {
            get { return this._modelVersion; }
            set { this._modelVersion = value; }
        }

        // Check to see if ModelVersion property is set
        internal bool IsSetModelVersion()
        {
            return this._modelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PaginationToken. 
        /// <para>
        ///  If the result of the request is truncated, the pagination token can be used to fetch
        /// the next page of entities. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string PaginationToken
        {
            get { return this._paginationToken; }
            set { this._paginationToken = value; }
        }

        // Check to see if PaginationToken property is set
        internal bool IsSetPaginationToken()
        {
            return this._paginationToken != null;
        }

        /// <summary>
        /// Gets and sets the property SNOMEDCTDetails. 
        /// <para>
        ///  The details of the SNOMED-CT revision, including the edition, language, and version
        /// date. 
        /// </para>
        /// </summary>
        public SNOMEDCTDetails SNOMEDCTDetails
        {
            get { return this._snomedctDetails; }
            set { this._snomedctDetails = value; }
        }

        // Check to see if SNOMEDCTDetails property is set
        internal bool IsSetSNOMEDCTDetails()
        {
            return this._snomedctDetails != null;
        }

    }
}