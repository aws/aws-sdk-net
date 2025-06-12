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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// This is the response object from the GetSegmentDefinition operation.
    /// </summary>
    public partial class GetSegmentDefinitionResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _description;
        private string _displayName;
        private string _segmentDefinitionArn;
        private string _segmentDefinitionName;
        private SegmentGroup _segmentGroups;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the segment definition was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the segment definition.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the segment definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentDefinitionArn. 
        /// <para>
        /// The arn of the segment definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string SegmentDefinitionArn
        {
            get { return this._segmentDefinitionArn; }
            set { this._segmentDefinitionArn = value; }
        }

        // Check to see if SegmentDefinitionArn property is set
        internal bool IsSetSegmentDefinitionArn()
        {
            return this._segmentDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentDefinitionName. 
        /// <para>
        /// The name of the segment definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string SegmentDefinitionName
        {
            get { return this._segmentDefinitionName; }
            set { this._segmentDefinitionName = value; }
        }

        // Check to see if SegmentDefinitionName property is set
        internal bool IsSetSegmentDefinitionName()
        {
            return this._segmentDefinitionName != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentGroups. 
        /// <para>
        /// The segment criteria associated with this definition.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public SegmentGroup SegmentGroups
        {
            get { return this._segmentGroups; }
            set { this._segmentGroups = value; }
        }

        // Check to see if SegmentGroups property is set
        internal bool IsSetSegmentGroups()
        {
            return this._segmentGroups != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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

    }
}