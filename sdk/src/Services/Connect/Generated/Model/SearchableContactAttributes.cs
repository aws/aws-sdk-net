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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// A structure that defines search criteria based on user-defined contact attributes
    /// that are configured for contact search.
    /// </summary>
    public partial class SearchableContactAttributes
    {
        private List<SearchableContactAttributesCriteria> _criteria = AWSConfigs.InitializeCollections ? new List<SearchableContactAttributesCriteria>() : null;
        private SearchContactsMatchType _matchType;

        /// <summary>
        /// Gets and sets the property Criteria. 
        /// <para>
        /// The list of criteria based on user-defined contact attributes that are configured
        /// for contact search.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=15)]
        public List<SearchableContactAttributesCriteria> Criteria
        {
            get { return this._criteria; }
            set { this._criteria = value; }
        }

        // Check to see if Criteria property is set
        internal bool IsSetCriteria()
        {
            return this._criteria != null && (this._criteria.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MatchType. 
        /// <para>
        /// The match type combining search criteria using multiple searchable contact attributes.
        /// </para>
        /// </summary>
        public SearchContactsMatchType MatchType
        {
            get { return this._matchType; }
            set { this._matchType = value; }
        }

        // Check to see if MatchType property is set
        internal bool IsSetMatchType()
        {
            return this._matchType != null;
        }

    }
}