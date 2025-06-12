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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// A single query suggestion.
    /// </summary>
    public partial class Suggestion
    {
        private string _id;
        private List<SourceDocument> _sourceDocuments = AWSConfigs.InitializeCollections ? new List<SourceDocument>() : null;
        private SuggestionValue _value;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The UUID (universally unique identifier) of a single query suggestion.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=73)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDocuments. 
        /// <para>
        /// The list of document IDs and their fields/attributes that are used for a single query
        /// suggestion, if document fields set to use for query suggestions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SourceDocument> SourceDocuments
        {
            get { return this._sourceDocuments; }
            set { this._sourceDocuments = value; }
        }

        // Check to see if SourceDocuments property is set
        internal bool IsSetSourceDocuments()
        {
            return this._sourceDocuments != null && (this._sourceDocuments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value for the UUID (universally unique identifier) of a single query suggestion.
        /// </para>
        ///  
        /// <para>
        /// The value is the text string of a suggestion.
        /// </para>
        /// </summary>
        public SuggestionValue Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}