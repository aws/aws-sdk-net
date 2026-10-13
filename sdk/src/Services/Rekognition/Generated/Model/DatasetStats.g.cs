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
    /// Provides statistics about a dataset. For more information, see <a>DescribeDataset</a>.
    /// </summary>
    public partial class DatasetStats
    {
        /// <summary>
        /// Gets and sets the property ErrorEntries. 
        /// <para>
        ///  The total number of entries that contain at least one error. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ErrorEntries { get; set; }

        /// <summary>
        /// Checks to see if the ErrorEntries property is set.
        /// </summary>
        internal bool IsSetErrorEntries() => this.ErrorEntries.HasValue;

        /// <summary>
        /// Gets and sets the property LabeledEntries. 
        /// <para>
        ///  The total number of images in the dataset that have labels. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? LabeledEntries { get; set; }

        /// <summary>
        /// Checks to see if the LabeledEntries property is set.
        /// </summary>
        internal bool IsSetLabeledEntries() => this.LabeledEntries.HasValue;

        /// <summary>
        /// Gets and sets the property TotalEntries. 
        /// <para>
        ///  The total number of images in the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TotalEntries { get; set; }

        /// <summary>
        /// Checks to see if the TotalEntries property is set.
        /// </summary>
        internal bool IsSetTotalEntries() => this.TotalEntries.HasValue;

        /// <summary>
        /// Gets and sets the property TotalLabels. 
        /// <para>
        ///  The total number of labels declared in the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TotalLabels { get; set; }

        /// <summary>
        /// Checks to see if the TotalLabels property is set.
        /// </summary>
        internal bool IsSetTotalLabels() => this.TotalLabels.HasValue;
    }
}
