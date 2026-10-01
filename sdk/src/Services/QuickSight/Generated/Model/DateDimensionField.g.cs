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
    /// The dimension type field with date type columns.
    /// </summary>
    public partial class DateDimensionField
    {
        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column that is used in the <c>DateDimensionField</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ColumnIdentifier Column { get; set; }

        /// <summary>
        /// Checks to see if the Column property is set.
        /// </summary>
        internal bool IsSetColumn() => this.Column != null;

        /// <summary>
        /// Gets and sets the property DateGranularity. 
        /// <para>
        /// The date granularity of the <c>DateDimensionField</c>. Choose one of the following
        /// options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>YEAR</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>QUARTER</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MONTH</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WEEK</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DAY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOUR</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MINUTE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SECOND</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MILLISECOND</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TimeGranularity DateGranularity { get; set; }

        /// <summary>
        /// Checks to see if the DateGranularity property is set.
        /// </summary>
        internal bool IsSetDateGranularity() => this.DateGranularity != null;

        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// The custom field ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string FieldId { get; set; }

        /// <summary>
        /// Checks to see if the FieldId property is set.
        /// </summary>
        internal bool IsSetFieldId() => this.FieldId != null;

        /// <summary>
        /// Gets and sets the property FormatConfiguration. 
        /// <para>
        /// The format configuration of the field.
        /// </para>
        /// </summary>
        public DateTimeFormatConfiguration FormatConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FormatConfiguration property is set.
        /// </summary>
        internal bool IsSetFormatConfiguration() => this.FormatConfiguration != null;

        /// <summary>
        /// Gets and sets the property HierarchyId. 
        /// <para>
        /// The custom hierarchy ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string HierarchyId { get; set; }

        /// <summary>
        /// Checks to see if the HierarchyId property is set.
        /// </summary>
        internal bool IsSetHierarchyId() => this.HierarchyId != null;
    }
}
