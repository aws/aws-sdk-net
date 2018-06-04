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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Enable Timed metadata insertion (TimedMetadataInsertion) to include ID3 tags in your
    /// job. To include timed metadata, you must enable it here, enable it in each output
    /// container, and specify tags and timecodes in ID3 insertion (Id3Insertion) objects.
    /// </summary>
    public partial class TimedMetadataInsertion
    {
        private List<Id3Insertion> _id3Insertions = new List<Id3Insertion>();

        /// <summary>
        /// Gets and sets the property Id3Insertions.
        /// </summary>
        public List<Id3Insertion> Id3Insertions
        {
            get { return this._id3Insertions; }
            set { this._id3Insertions = value; }
        }

        // Check to see if Id3Insertions property is set
        internal bool IsSetId3Insertions()
        {
            return this._id3Insertions != null && this._id3Insertions.Count > 0; 
        }

    }
}