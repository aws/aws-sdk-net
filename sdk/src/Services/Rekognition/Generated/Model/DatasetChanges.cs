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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Describes updates or additions to a dataset. A Single update or addition is an entry
    /// (JSON Line) that provides information about a single image. To update an existing
    /// entry, you match the <c>source-ref</c> field of the update entry with the <c>source-ref</c>
    /// filed of the entry that you want to update. If the <c>source-ref</c> field doesn't
    /// match an existing entry, the entry is added to dataset as a new entry.
    /// </summary>
    public partial class DatasetChanges
    {
        private MemoryStream _groundTruth;

        /// <summary>
        /// Gets and sets the property GroundTruth. 
        /// <para>
        /// A Base64-encoded binary data object containing one or JSON lines that either update
        /// the dataset or are additions to the dataset. You change a dataset by calling <a>UpdateDatasetEntries</a>.
        /// If you are using an AWS SDK to call <c>UpdateDatasetEntries</c>, you don't need to
        /// encode <c>Changes</c> as the SDK encodes the data for you. 
        /// </para>
        ///  
        /// <para>
        /// For example JSON lines, see Image-Level labels in manifest files and and Object localization
        /// in manifest files in the <i>Amazon Rekognition Custom Labels Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5242880)]
        public MemoryStream GroundTruth
        {
            get { return this._groundTruth; }
            set { this._groundTruth = value; }
        }

        // Check to see if GroundTruth property is set
        internal bool IsSetGroundTruth()
        {
            return this._groundTruth != null;
        }

    }
}