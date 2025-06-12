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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
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
namespace Amazon.IVS.Model
{
    /// <summary>
    /// Object that describes which renditions should be recorded for a stream.
    /// </summary>
    public partial class RenditionConfiguration
    {
        private List<string> _renditions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private RenditionConfigurationRenditionSelection _renditionSelection;

        /// <summary>
        /// Gets and sets the property Renditions. 
        /// <para>
        /// Indicates which renditions are recorded for a stream, if <c>renditionSelection</c>
        /// is <c>CUSTOM</c>; otherwise, this field is irrelevant. The selected renditions are
        /// recorded if they are available during the stream. If a selected rendition is unavailable,
        /// the best available rendition is recorded. For details on the resolution dimensions
        /// of each rendition, see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/record-to-s3.html">Auto-Record
        /// to Amazon S3</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Renditions
        {
            get { return this._renditions; }
            set { this._renditions = value; }
        }

        // Check to see if Renditions property is set
        internal bool IsSetRenditions()
        {
            return this._renditions != null && (this._renditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RenditionSelection. 
        /// <para>
        /// Indicates which set of renditions are recorded for a stream. For <c>BASIC</c> channels,
        /// the <c>CUSTOM</c> value has no effect. If <c>CUSTOM</c> is specified, a set of renditions
        /// must be specified in the <c>renditions</c> field. Default: <c>ALL</c>.
        /// </para>
        /// </summary>
        public RenditionConfigurationRenditionSelection RenditionSelection
        {
            get { return this._renditionSelection; }
            set { this._renditionSelection = value; }
        }

        // Check to see if RenditionSelection property is set
        internal bool IsSetRenditionSelection()
        {
            return this._renditionSelection != null;
        }

    }
}