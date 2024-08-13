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
    /// Provides statistics about a dataset. For more information, see <a>DescribeDataset</a>.
    /// </summary>
    public partial class DatasetStats
    {
        private int? _errorEntries;
        private int? _labeledEntries;
        private int? _totalEntries;
        private int? _totalLabels;

        /// <summary>
        /// Gets and sets the property ErrorEntries. 
        /// <para>
        ///  The total number of entries that contain at least one error. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? ErrorEntries
        {
            get { return this._errorEntries; }
            set { this._errorEntries = value; }
        }

        // Check to see if ErrorEntries property is set
        internal bool IsSetErrorEntries()
        {
            return this._errorEntries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LabeledEntries. 
        /// <para>
        ///  The total number of images in the dataset that have labels. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? LabeledEntries
        {
            get { return this._labeledEntries; }
            set { this._labeledEntries = value; }
        }

        // Check to see if LabeledEntries property is set
        internal bool IsSetLabeledEntries()
        {
            return this._labeledEntries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalEntries. 
        /// <para>
        ///  The total number of images in the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? TotalEntries
        {
            get { return this._totalEntries; }
            set { this._totalEntries = value; }
        }

        // Check to see if TotalEntries property is set
        internal bool IsSetTotalEntries()
        {
            return this._totalEntries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalLabels. 
        /// <para>
        ///  The total number of labels declared in the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? TotalLabels
        {
            get { return this._totalLabels; }
            set { this._totalLabels = value; }
        }

        // Check to see if TotalLabels property is set
        internal bool IsSetTotalLabels()
        {
            return this._totalLabels.HasValue; 
        }

    }
}