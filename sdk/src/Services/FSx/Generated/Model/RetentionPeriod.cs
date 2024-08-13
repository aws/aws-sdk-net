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
    /// Specifies the retention period of an FSx for ONTAP SnapLock volume. After it is set,
    /// it can't be changed. Files can't be deleted or modified during the retention period.
    /// 
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/snaplock-retention.html">Working
    /// with the retention period in SnapLock</a>. 
    /// </para>
    /// </summary>
    public partial class RetentionPeriod
    {
        private RetentionPeriodType _type;
        private int? _value;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Defines the type of time for the retention period of an FSx for ONTAP SnapLock volume.
        /// Set it to one of the valid types. If you set it to <c>INFINITE</c>, the files are
        /// retained forever. If you set it to <c>UNSPECIFIED</c>, the files are retained until
        /// you set an explicit retention period. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RetentionPeriodType Type
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
        /// Defines the amount of time for the retention period of an FSx for ONTAP SnapLock volume.
        /// You can't set a value for <c>INFINITE</c> or <c>UNSPECIFIED</c>. For all other options,
        /// the following ranges are valid: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Seconds</c>: 0 - 65,535
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Minutes</c>: 0 - 65,535
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Hours</c>: 0 - 24
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Days</c>: 0 - 365
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Months</c>: 0 - 12
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Years</c>: 0 - 100
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
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