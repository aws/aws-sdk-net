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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The static file.
    /// </summary>
    public partial class StaticFile
    {
        private ImageStaticFile _imageStaticFile;
        private SpatialStaticFile _spatialStaticFile;

        /// <summary>
        /// Gets and sets the property ImageStaticFile. 
        /// <para>
        /// The image static file.
        /// </para>
        /// </summary>
        public ImageStaticFile ImageStaticFile
        {
            get { return this._imageStaticFile; }
            set { this._imageStaticFile = value; }
        }

        // Check to see if ImageStaticFile property is set
        internal bool IsSetImageStaticFile()
        {
            return this._imageStaticFile != null;
        }

        /// <summary>
        /// Gets and sets the property SpatialStaticFile. 
        /// <para>
        /// The spacial static file.
        /// </para>
        /// </summary>
        public SpatialStaticFile SpatialStaticFile
        {
            get { return this._spatialStaticFile; }
            set { this._spatialStaticFile = value; }
        }

        // Check to see if SpatialStaticFile property is set
        internal bool IsSetSpatialStaticFile()
        {
            return this._spatialStaticFile != null;
        }

    }
}