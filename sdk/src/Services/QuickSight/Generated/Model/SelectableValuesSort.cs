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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
    /// The sort configuration for selectable values in a control.
    /// </summary>
    public partial class SelectableValuesSort
    {
        private ControlSortDirection _direction;

        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// The sort direction for the selectable values. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ASC</c>: Sort in ascending order.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DESC</c>: Sort in descending order.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>USER_DEFINED_ORDER</c>: Preserve the order in which the values were entered.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ControlSortDirection Direction
        {
            get { return this._direction; }
            set { this._direction = value; }
        }

        // Check to see if Direction property is set
        internal bool IsSetDirection()
        {
            return this._direction != null;
        }

    }
}