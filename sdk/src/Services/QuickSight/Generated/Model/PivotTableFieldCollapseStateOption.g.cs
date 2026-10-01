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
    /// The collapse state options for the pivot table field options.
    /// </summary>
    public partial class PivotTableFieldCollapseStateOption
    {
        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the field target of a pivot table. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COLLAPSED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPANDED</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PivotTableFieldCollapseState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// A tagged-union object that sets the collapse state.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PivotTableFieldCollapseStateTarget Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;
    }
}
