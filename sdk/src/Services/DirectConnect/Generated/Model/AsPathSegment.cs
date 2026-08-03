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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// A segment of an autonomous system (AS) path.
    /// </summary>
    public partial class AsPathSegment
    {
        private List<long> _path = AWSConfigs.InitializeCollections ? new List<long>() : null;
        private AsPathType _pathType;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The autonomous system (AS) numbers in the segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<long> Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null && (this._path.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PathType. 
        /// <para>
        /// The type of the AS path segment.
        /// </para>
        ///  
        /// <para>
        /// The valid values are <c>seq</c> (an ordered <c>AS_SEQUENCE</c>) and <c>set</c> (an
        /// unordered <c>AS_SET</c>).
        /// </para>
        /// </summary>
        public AsPathType PathType
        {
            get { return this._pathType; }
            set { this._pathType = value; }
        }

        // Check to see if PathType property is set
        internal bool IsSetPathType()
        {
            return this._pathType != null;
        }

    }
}