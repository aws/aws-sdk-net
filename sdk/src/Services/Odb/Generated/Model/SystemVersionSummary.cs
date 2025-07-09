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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// Information about the compatible system versions that can be used with a specific
    /// Exadata shape and Grid Infrastructure (GI) version.
    /// </summary>
    public partial class SystemVersionSummary
    {
        private string _giVersion;
        private string _shape;
        private List<string> _systemVersions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property GiVersion. 
        /// <para>
        /// The version of GI software.
        /// </para>
        /// </summary>
        public string GiVersion
        {
            get { return this._giVersion; }
            set { this._giVersion = value; }
        }

        // Check to see if GiVersion property is set
        internal bool IsSetGiVersion()
        {
            return this._giVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// The Exadata hardware model.
        /// </para>
        /// </summary>
        public string Shape
        {
            get { return this._shape; }
            set { this._shape = value; }
        }

        // Check to see if Shape property is set
        internal bool IsSetShape()
        {
            return this._shape != null;
        }

        /// <summary>
        /// Gets and sets the property SystemVersions. 
        /// <para>
        /// The Exadata system versions that are compatible with the specified Exadata shape and
        /// GI version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> SystemVersions
        {
            get { return this._systemVersions; }
            set { this._systemVersions = value; }
        }

        // Check to see if SystemVersions property is set
        internal bool IsSetSystemVersions()
        {
            return this._systemVersions != null && (this._systemVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}