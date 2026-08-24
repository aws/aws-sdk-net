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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Summary of an agent recommendation item, representing an Amazon Web Services resource
    /// or recommendation affected by the optimization recommendation.
    /// </summary>
    public partial class AgentRecommendationItemSummary
    {
        private DateTime? _createdAt;
        private string _createdBy;
        private string _id;
        private DateTime? _lastModifiedAt;
        private string _lastModifiedBy;
        private Amazon.Runtime.Documents.Document _metadata;
        private string _recommendationArn;
        private RecommendationItemType _type;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the recommendation item was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The identifier of the user or system that created this recommendation item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the recommendation item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The timestamp when the recommendation item was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedAt
        {
            get { return this._lastModifiedAt; }
            set { this._lastModifiedAt = value; }
        }

        // Check to see if LastModifiedAt property is set
        internal bool IsSetLastModifiedAt()
        {
            return this._lastModifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The identifier of the user or system that last modified this recommendation item.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata containing a snapshot of the resource or recommendation at the time of generation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amazon.Runtime.Documents.Document Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return !this._metadata.IsNull();
        }

        /// <summary>
        /// Gets and sets the property RecommendationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the associated recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string RecommendationArn
        {
            get { return this._recommendationArn; }
            set { this._recommendationArn = value; }
        }

        // Check to see if RecommendationArn property is set
        internal bool IsSetRecommendationArn()
        {
            return this._recommendationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the recommendation item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationItemType Type
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