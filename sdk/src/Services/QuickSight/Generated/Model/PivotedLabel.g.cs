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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Specifies a label value to be pivoted into a separate column, including the new column
    /// name and identifier.
    /// </summary>
    public partial class PivotedLabel
    {
        /// <summary>
        /// Gets and sets the property LabelName. 
        /// <para>
        /// The label value from the source data to be pivoted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2047)]
        public string LabelName { get; set; }

        /// <summary>
        /// Checks to see if the LabelName property is set.
        /// </summary>
        internal bool IsSetLabelName() => this.LabelName != null;

        /// <summary>
        /// Gets and sets the property NewColumnId. 
        /// <para>
        /// A unique identifier for the new column created from this pivoted label.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string NewColumnId { get; set; }

        /// <summary>
        /// Checks to see if the NewColumnId property is set.
        /// </summary>
        internal bool IsSetNewColumnId() => this.NewColumnId != null;

        /// <summary>
        /// Gets and sets the property NewColumnName. 
        /// <para>
        /// The name for the new column created from this pivoted label.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string NewColumnName { get; set; }

        /// <summary>
        /// Checks to see if the NewColumnName property is set.
        /// </summary>
        internal bool IsSetNewColumnName() => this.NewColumnName != null;
    }
}
