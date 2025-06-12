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
    /// Specifies the base segments and dimensions for a segment, and the relationships between
    /// these base segments and dimensions.
    /// </summary>
    public partial class SegmentGroup
    {
        private List<SegmentDimensions> _dimensions = AWSConfigs.InitializeCollections ? new List<SegmentDimensions>() : null;
        private List<SegmentReference> _sourceSegments = AWSConfigs.InitializeCollections ? new List<SegmentReference>() : null;
        private SourceType _sourceType;
        private Type _type;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// An array that defines the dimensions for the segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SegmentDimensions> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && (this._dimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceSegments. 
        /// <para>
        /// The base segment to build the segment on. A base segment, also referred to as a <i>source
        /// segment</i>, defines the initial population of endpoints for a segment. When you add
        /// dimensions to a segment, Amazon Pinpoint filters the base segment by using the dimensions
        /// that you specify.
        /// </para>
        ///  
        /// <para>
        /// You can specify more than one dimensional segment or only one imported segment. If
        /// you specify an imported segment, the Amazon Pinpoint console displays a segment size
        /// estimate that indicates the size of the imported segment without any filters applied
        /// to it.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SegmentReference> SourceSegments
        {
            get { return this._sourceSegments; }
            set { this._sourceSegments = value; }
        }

        // Check to see if SourceSegments property is set
        internal bool IsSetSourceSegments()
        {
            return this._sourceSegments != null && (this._sourceSegments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// Specifies how to handle multiple base segments for the segment. For example, if you
        /// specify three base segments for the segment, whether the resulting segment is based
        /// on all, any, or none of the base segments.
        /// </para>
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
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies how to handle multiple dimensions for the segment. For example, if you specify
        /// three dimensions for the segment, whether the resulting segment includes endpoints
        /// that match all, any, or none of the dimensions.
        /// </para>
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