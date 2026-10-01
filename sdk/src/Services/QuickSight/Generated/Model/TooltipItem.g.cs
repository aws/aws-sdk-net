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
    /// The tooltip.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class TooltipItem
    {
        /// <summary>
        /// Gets and sets the property ColumnTooltipItem. 
        /// <para>
        /// The tooltip item for the columns that are not part of a field well.
        /// </para>
        /// </summary>
        public ColumnTooltipItem ColumnTooltipItem { get; set; }

        /// <summary>
        /// Checks to see if the ColumnTooltipItem property is set.
        /// </summary>
        internal bool IsSetColumnTooltipItem() => this.ColumnTooltipItem != null;

        /// <summary>
        /// Gets and sets the property FieldTooltipItem. 
        /// <para>
        /// The tooltip item for the fields.
        /// </para>
        /// </summary>
        public FieldTooltipItem FieldTooltipItem { get; set; }

        /// <summary>
        /// Checks to see if the FieldTooltipItem property is set.
        /// </summary>
        internal bool IsSetFieldTooltipItem() => this.FieldTooltipItem != null;
    }
}
