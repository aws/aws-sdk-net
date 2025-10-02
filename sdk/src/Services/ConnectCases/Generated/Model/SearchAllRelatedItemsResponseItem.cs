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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// A list of items that represent RelatedItems. This data type is similar to <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_SearchRelatedItemsResponseItem.html">SearchRelatedItemsResponseItem</a>
    /// except Search<b>All</b>RelatedItemsResponseItem has a caseId field.
    /// </summary>
    public partial class SearchAllRelatedItemsResponseItem
    {
        private DateTime? _associationTime;
        private string _caseId;
        private RelatedItemContent _content;
        private UserUnion _performedBy;
        private string _relatedItemId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private RelatedItemType _type;

        /// <summary>
        /// Gets and sets the property AssociationTime. 
        /// <para>
        /// Time at which a related item was associated with a case.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime AssociationTime
        {
            get { return this._associationTime.GetValueOrDefault(); }
            set { this._associationTime = value; }
        }

        // Check to see if AssociationTime property is set
        internal bool IsSetAssociationTime()
        {
            return this._associationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// A unique identifier of the case.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string CaseId
        {
            get { return this._caseId; }
            set { this._caseId = value; }
        }

        // Check to see if CaseId property is set
        internal bool IsSetCaseId()
        {
            return this._caseId != null;
        }

        /// <summary>
        /// Gets and sets the property Content.
        /// </summary>
        [AWSProperty(Required=true)]
        public RelatedItemContent Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property PerformedBy.
        /// </summary>
        public UserUnion PerformedBy
        {
            get { return this._performedBy; }
            set { this._performedBy = value; }
        }

        // Check to see if PerformedBy property is set
        internal bool IsSetPerformedBy()
        {
            return this._performedBy != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedItemId. 
        /// <para>
        /// Unique identifier of a related item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string RelatedItemId
        {
            get { return this._relatedItemId; }
            set { this._relatedItemId = value; }
        }

        // Check to see if RelatedItemId property is set
        internal bool IsSetRelatedItemId()
        {
            return this._relatedItemId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of of key-value pairs that represent tags on a resource. Tags are used to organize,
        /// track, or control access for this resource.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of a related item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RelatedItemType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}