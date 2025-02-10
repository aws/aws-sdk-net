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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// The range of possible values that's used to describe a specific command parameter.
    /// 
    ///  <note> 
    /// <para>
    /// The <c>commandParameterValue</c> can only have one of the below fields listed.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CommandParameterValue
    {
        private bool? _b;
        private MemoryStream _bin;
        private double? _d;
        private int? _i;
        private long? _l;
        private string _s;
        private string _ul;

        /// <summary>
        /// Gets and sets the property B. 
        /// <para>
        /// An attribute of type Boolean. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"BOOL": true</c> 
        /// </para>
        /// </summary>
        public bool? B
        {
            get { return this._b; }
            set { this._b = value; }
        }

        // Check to see if B property is set
        internal bool IsSetB()
        {
            return this._b.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BIN. 
        /// <para>
        /// An attribute of type Binary. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"B": "dGhpcyB0ZXh0IGlzIGJhc2U2NC1lbmNvZGVk"</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public MemoryStream BIN
        {
            get { return this._bin; }
            set { this._bin = value; }
        }

        // Check to see if BIN property is set
        internal bool IsSetBIN()
        {
            return this._bin != null;
        }

        /// <summary>
        /// Gets and sets the property D. 
        /// <para>
        /// An attribute of type Double (Sixty-Four Bits).
        /// </para>
        /// </summary>
        public double? D
        {
            get { return this._d; }
            set { this._d = value; }
        }

        // Check to see if D property is set
        internal bool IsSetD()
        {
            return this._d.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property I. 
        /// <para>
        /// An attribute of type Integer (Thirty-Two Bits).
        /// </para>
        /// </summary>
        public int? I
        {
            get { return this._i; }
            set { this._i = value; }
        }

        // Check to see if I property is set
        internal bool IsSetI()
        {
            return this._i.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property L. 
        /// <para>
        /// An attribute of type Long.
        /// </para>
        /// </summary>
        public long? L
        {
            get { return this._l; }
            set { this._l = value; }
        }

        // Check to see if L property is set
        internal bool IsSetL()
        {
            return this._l.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S. 
        /// <para>
        /// An attribute of type String. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"S": "Hello"</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string S
        {
            get { return this._s; }
            set { this._s = value; }
        }

        // Check to see if S property is set
        internal bool IsSetS()
        {
            return this._s != null;
        }

        /// <summary>
        /// Gets and sets the property UL. 
        /// <para>
        /// An attribute of type unsigned long.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string UL
        {
            get { return this._ul; }
            set { this._ul = value; }
        }

        // Check to see if UL property is set
        internal bool IsSetUL()
        {
            return this._ul != null;
        }

    }
}