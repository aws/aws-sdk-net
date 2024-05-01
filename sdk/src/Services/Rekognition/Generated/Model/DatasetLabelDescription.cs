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
    /// Describes a dataset label. For more information, see <a>ListDatasetLabels</a>.
    /// </summary>
    public partial class DatasetLabelDescription
    {
        private string _labelName;
        private DatasetLabelStats _labelStats;

        /// <summary>
        /// Gets and sets the property LabelName. 
        /// <para>
        ///  The name of the label. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string LabelName
        {
            get { return this._labelName; }
            set { this._labelName = value; }
        }

        // Check to see if LabelName property is set
        internal bool IsSetLabelName()
        {
            return this._labelName != null;
        }

        /// <summary>
        /// Gets and sets the property LabelStats. 
        /// <para>
        ///  Statistics about the label. 
        /// </para>
        /// </summary>
        public DatasetLabelStats LabelStats
        {
            get { return this._labelStats; }
            set { this._labelStats = value; }
        }

        // Check to see if LabelStats property is set
        internal bool IsSetLabelStats()
        {
            return this._labelStats != null;
        }

    }
}