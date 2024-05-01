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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the current state of an instance.
    /// </summary>
    public partial class InstanceState
    {
        private int? _code;
        private InstanceStateName _name;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The state of the instance as a 16-bit unsigned integer. 
        /// </para>
        ///  
        /// <para>
        /// The high byte is all of the bits between 2^8 and (2^16)-1, which equals decimal values
        /// between 256 and 65,535. These numerical values are used for internal purposes and
        /// should be ignored.
        /// </para>
        ///  
        /// <para>
        /// The low byte is all of the bits between 2^0 and (2^8)-1, which equals decimal values
        /// between 0 and 255. 
        /// </para>
        ///  
        /// <para>
        /// The valid values for instance-state-code will all be in the range of the low byte
        /// and they are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>0</c> : <c>pending</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>16</c> : <c>running</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>32</c> : <c>shutting-down</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>48</c> : <c>terminated</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>64</c> : <c>stopping</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>80</c> : <c>stopped</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can ignore the high byte value by zeroing out all of the bits above 2^8 or 256
        /// in decimal.
        /// </para>
        /// </summary>
        public int? Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The current state of the instance.
        /// </para>
        /// </summary>
        public InstanceStateName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}