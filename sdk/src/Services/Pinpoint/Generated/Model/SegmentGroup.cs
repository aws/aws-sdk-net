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
    /// Segment group definition.
    /// </summary>
    public partial class SegmentGroup
    {
        private List<SegmentDimensions> _dimensions = new List<SegmentDimensions>();
        private List<SegmentReference> _sourceSegments = new List<SegmentReference>();
        private SourceType _sourceType;
        private Type _type;

        /// <summary>
        /// Gets and sets the property Dimensions. List of dimensions to include or exclude.
        /// </summary>
        public List<SegmentDimensions> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && this._dimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceSegments. Segments that define the source of this
        /// segment. Currently a maximum of 1 import segment is supported.
        /// </summary>
        public List<SegmentReference> SourceSegments
        {
            get { return this._sourceSegments; }
            set { this._sourceSegments = value; }
        }

        // Check to see if SourceSegments property is set
        internal bool IsSetSourceSegments()
        {
            return this._sourceSegments != null && this._sourceSegments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceType. Include or exclude the source.
        /// </summary>
        public SourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Type. How should the dimensions be applied for the result
        /// </summary>
        public Type Type
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