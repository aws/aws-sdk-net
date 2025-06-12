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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about the configuration, dimension, and other settings for a
    /// segment.
    /// </summary>
    public partial class SegmentResponse
    {
        private string _applicationId;
        private string _arn;
        private string _creationDate;
        private SegmentDimensions _dimensions;
        private string _id;
        private SegmentImportResource _importDefinition;
        private string _lastModifiedDate;
        private string _name;
        private SegmentGroupList _segmentGroups;
        private SegmentType _segmentType;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _version;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application that the segment is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the segment was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate != null;
        }

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimension settings for the segment.
        /// </para>
        /// </summary>
        public SegmentDimensions Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the segment.
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
        /// Gets and sets the property ImportDefinition. 
        /// <para>
        /// The settings for the import job that's associated with the segment.
        /// </para>
        /// </summary>
        public SegmentImportResource ImportDefinition
        {
            get { return this._importDefinition; }
            set { this._importDefinition = value; }
        }

        // Check to see if ImportDefinition property is set
        internal bool IsSetImportDefinition()
        {
            return this._importDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the segment was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the segment.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentGroups. 
        /// <para>
        /// A list of one or more segment groups that apply to the segment. Each segment group
        /// consists of zero or more base segments and the dimensions that are applied to those
        /// base segments.
        /// </para>
        /// </summary>
        public SegmentGroupList SegmentGroups
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
        /// Gets and sets the property SegmentType. 
        /// <para>
        /// The segment type. Valid values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// DIMENSIONAL - A dynamic segment, which is a segment that uses selection criteria that
        /// you specify and is based on endpoint data that's reported by your app. Dynamic segments
        /// can change over time.
        /// </para>
        /// </li> <li>
        /// <para>
        /// IMPORT - A static segment, which is a segment that uses selection criteria that you
        /// specify and is based on endpoint definitions that you import from a file. Imported
        /// segments are static; they don't change over time.
        /// </para>
        /// </li></ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public SegmentType SegmentType
        {
            get { return this._segmentType; }
            set { this._segmentType = value; }
        }

        // Check to see if SegmentType property is set
        internal bool IsSetSegmentType()
        {
            return this._segmentType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A string-to-string map of key-value pairs that identifies the tags that are associated
        /// with the segment. Each tag consists of a required tag key and an associated tag value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the segment.
        /// </para>
        /// </summary>
        public int? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}