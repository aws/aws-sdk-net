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
 * Do not modify this file. This file is generated from the comprehendmedical-2018-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComprehendMedical.Model
{
    /// <summary>
    /// This is the response object from the DetectPHI operation.
    /// </summary>
    public partial class DetectPHIResponse : AmazonWebServiceResponse
    {
        private List<Entity> _entities = new List<Entity>();
        private string _paginationToken;

        /// <summary>
        /// Gets and sets the property Entities. 
        /// <para>
        ///  The collection of PHI entities extracted from the input text and their associated
        /// information. For each entity, the response provides the entity text, the entity category,
        /// where the entity text begins and ends, and the level of confidence that Comprehend
        /// Medical has in its detection. 
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

        /// <summary>
        /// Gets and sets the property PaginationToken. 
        /// <para>
        ///  If the result of the previous request to DetectPHI was truncated, include the Paginationtoken
        /// to fetch the next page of PHI entities. 
        /// </para>
        /// </summary>
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

    }
}