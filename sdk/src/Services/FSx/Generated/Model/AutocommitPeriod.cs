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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Sets the autocommit period of files in an FSx for ONTAP SnapLock volume, which determines
    /// how long the files must remain unmodified before they're automatically transitioned
    /// to the write once, read many (WORM) state. 
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/worm-state.html#worm-state-autocommit">Autocommit</a>.
    /// 
    /// </para>
    /// </summary>
    public partial class AutocommitPeriod
    {
        private AutocommitPeriodType _type;
        private int? _value;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Defines the type of time for the autocommit period of a file in an FSx for ONTAP SnapLock
        /// volume. Setting this value to <c>NONE</c> disables autocommit. The default value is
        /// <c>NONE</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutocommitPeriodType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Defines the amount of time for the autocommit period of a file in an FSx for ONTAP
        /// SnapLock volume. The following ranges are valid: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Minutes</c>: 5 - 65,535
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Hours</c>: 1 - 65,535
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Days</c>: 1 - 3,650
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Months</c>: 1 - 120
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Years</c>: 1 - 10
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public int? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}