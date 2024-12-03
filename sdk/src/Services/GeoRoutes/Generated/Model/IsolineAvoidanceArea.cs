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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// The area to be avoided.
    /// </summary>
    public partial class IsolineAvoidanceArea
    {
        private List<IsolineAvoidanceAreaGeometry> _except = AWSConfigs.InitializeCollections ? new List<IsolineAvoidanceAreaGeometry>() : null;
        private IsolineAvoidanceAreaGeometry _geometry;

        /// <summary>
        /// Gets and sets the property Except. 
        /// <para>
        /// Exceptions to the provided avoidance geometry, to be included while calculating the
        /// route.
        /// </para>
        /// </summary>
        public List<IsolineAvoidanceAreaGeometry> Except
        {
            get { return this._except; }
            set { this._except = value; }
        }

        // Check to see if Except property is set
        internal bool IsSetExcept()
        {
            return this._except != null && (this._except.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Geometry. 
        /// <para>
        /// Geometry of the area to be avoided.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IsolineAvoidanceAreaGeometry Geometry
        {
            get { return this._geometry; }
            set { this._geometry = value; }
        }

        // Check to see if Geometry property is set
        internal bool IsSetGeometry()
        {
            return this._geometry != null;
        }

    }
}