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
    /// The option that determines the data label type.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class DataLabelType
    {
        /// <summary>
        /// Gets and sets the property DataPathLabelType. 
        /// <para>
        /// The option that specifies individual data values for labels.
        /// </para>
        /// </summary>
        public DataPathLabelType DataPathLabelType { get; set; }

        /// <summary>
        /// Checks to see if the DataPathLabelType property is set.
        /// </summary>
        internal bool IsSetDataPathLabelType() => this.DataPathLabelType != null;

        /// <summary>
        /// Gets and sets the property FieldLabelType. 
        /// <para>
        /// Determines the label configuration for the entire field.
        /// </para>
        /// </summary>
        public FieldLabelType FieldLabelType { get; set; }

        /// <summary>
        /// Checks to see if the FieldLabelType property is set.
        /// </summary>
        internal bool IsSetFieldLabelType() => this.FieldLabelType != null;

        /// <summary>
        /// Gets and sets the property MaximumLabelType. 
        /// <para>
        /// Determines the label configuration for the maximum value in a visual.
        /// </para>
        /// </summary>
        public MaximumLabelType MaximumLabelType { get; set; }

        /// <summary>
        /// Checks to see if the MaximumLabelType property is set.
        /// </summary>
        internal bool IsSetMaximumLabelType() => this.MaximumLabelType != null;

        /// <summary>
        /// Gets and sets the property MinimumLabelType. 
        /// <para>
        /// Determines the label configuration for the minimum value in a visual.
        /// </para>
        /// </summary>
        public MinimumLabelType MinimumLabelType { get; set; }

        /// <summary>
        /// Checks to see if the MinimumLabelType property is set.
        /// </summary>
        internal bool IsSetMinimumLabelType() => this.MinimumLabelType != null;

        /// <summary>
        /// Gets and sets the property RangeEndsLabelType. 
        /// <para>
        /// Determines the label configuration for range end value in a visual.
        /// </para>
        /// </summary>
        public RangeEndsLabelType RangeEndsLabelType { get; set; }

        /// <summary>
        /// Checks to see if the RangeEndsLabelType property is set.
        /// </summary>
        internal bool IsSetRangeEndsLabelType() => this.RangeEndsLabelType != null;
    }
}
