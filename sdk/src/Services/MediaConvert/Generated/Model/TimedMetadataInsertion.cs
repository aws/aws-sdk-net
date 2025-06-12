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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Insert user-defined custom ID3 metadata at timecodes that you specify. In each output
    /// that you want to include this metadata, you must set ID3 metadata to Passthrough.
    /// </summary>
    public partial class TimedMetadataInsertion
    {
        private List<Id3Insertion> _id3Insertions = AWSConfigs.InitializeCollections ? new List<Id3Insertion>() : null;

        /// <summary>
        /// Gets and sets the property Id3Insertions. Id3Insertions contains the array of Id3Insertion
        /// instances.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Id3Insertion> Id3Insertions
        {
            get { return this._id3Insertions; }
            set { this._id3Insertions = value; }
        }

        // Check to see if Id3Insertions property is set
        internal bool IsSetId3Insertions()
        {
            return this._id3Insertions != null && (this._id3Insertions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}