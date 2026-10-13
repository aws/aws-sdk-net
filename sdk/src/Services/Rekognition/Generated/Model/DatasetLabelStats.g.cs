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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Statistics about a label used in a dataset. For more information, see <a>DatasetLabelDescription</a>.
    /// </summary>
    public partial class DatasetLabelStats
    {
        /// <summary>
        /// Gets and sets the property BoundingBoxCount. 
        /// <para>
        ///  The total number of images that have the label assigned to a bounding box. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? BoundingBoxCount { get; set; }

        /// <summary>
        /// Checks to see if the BoundingBoxCount property is set.
        /// </summary>
        internal bool IsSetBoundingBoxCount() => this.BoundingBoxCount.HasValue;

        /// <summary>
        /// Gets and sets the property EntryCount. 
        /// <para>
        ///  The total number of images that use the label. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? EntryCount { get; set; }

        /// <summary>
        /// Checks to see if the EntryCount property is set.
        /// </summary>
        internal bool IsSetEntryCount() => this.EntryCount.HasValue;
    }
}
