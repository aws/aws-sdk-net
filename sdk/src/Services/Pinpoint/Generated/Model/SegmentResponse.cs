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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SegmentResponse
    {
        private string _applicationId;
        private string _creationDate;
        private SegmentDimensions _dimensions;
        private string _id;
        private SegmentImportResource _importDefinition;
        private string _lastModifiedDate;
        private string _name;
        private SegmentType _segmentType;
        private int? _version;

        /// <summary>
        /// Gets and sets the property ApplicationId. The ID of the application to which the segment
        /// applies.
        /// </summary>
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
        /// Gets and sets the property CreationDate. The date the segment was created in ISO 8601
        /// format.
        /// </summary>
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
        /// Gets and sets the property Dimensions. The segment dimensions attributes.
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
        /// Gets and sets the property Id. The unique segment ID.
        /// </summary>
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
        /// Gets and sets the property ImportDefinition. The import job settings.
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
        /// Gets and sets the property LastModifiedDate. The date the segment was last updated
        /// in ISO 8601 format.
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
        /// Gets and sets the property Name. The name of segment
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
        /// Gets and sets the property SegmentType. The segment type:DIMENSIONAL – A dynamic segment
        /// built from selection criteria based on endpoint data reported by your app. You create
        /// this type of segment by using the segment builder in the Amazon Pinpoint console or
        /// by making a POST request to the segments resource.IMPORT – A static segment built
        /// from an imported set of endpoint definitions. You create this type of segment by importing
        /// a segment in the Amazon Pinpoint console or by making a POST request to the jobs/import
        /// resource.
        /// </summary>
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
        /// Gets and sets the property Version. The segment version number.
        /// </summary>
        public int Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}