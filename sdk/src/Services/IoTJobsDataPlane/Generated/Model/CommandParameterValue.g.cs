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

namespace Amazon.IoTJobsDataPlane.Model
{
    /// <summary>
    /// The list of values used to describe a specific command parameter.
    /// </summary>
    public partial class CommandParameterValue
    {
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
        public bool? B { get; set; }

        /// <summary>
        /// Checks to see if the B property is set.
        /// </summary>
        internal bool IsSetB() => this.B.HasValue;

        /// <summary>
        /// Gets and sets the property BIN. 
        /// <para>
        /// An attribute of type Binary.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public MemoryStream BIN { get; set; }

        /// <summary>
        /// Checks to see if the BIN property is set.
        /// </summary>
        internal bool IsSetBIN() => this.BIN != null;

        /// <summary>
        /// Gets and sets the property D. 
        /// <para>
        /// An attribute of type Double (Sixty-Four Bits).
        /// </para>
        /// </summary>
        public double? D { get; set; }

        /// <summary>
        /// Checks to see if the D property is set.
        /// </summary>
        internal bool IsSetD() => this.D.HasValue;

        /// <summary>
        /// Gets and sets the property I. 
        /// <para>
        /// An attribute of type Integer (Thirty-Two Bits).
        /// </para>
        /// </summary>
        public int? I { get; set; }

        /// <summary>
        /// Checks to see if the I property is set.
        /// </summary>
        internal bool IsSetI() => this.I.HasValue;

        /// <summary>
        /// Gets and sets the property L. 
        /// <para>
        /// An attribute of type Long.
        /// </para>
        /// </summary>
        public long? L { get; set; }

        /// <summary>
        /// Checks to see if the L property is set.
        /// </summary>
        internal bool IsSetL() => this.L.HasValue;

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
        [AWSProperty(Min = 1)]
        public string S { get; set; }

        /// <summary>
        /// Checks to see if the S property is set.
        /// </summary>
        internal bool IsSetS() => this.S != null;

        /// <summary>
        /// Gets and sets the property UL. 
        /// <para>
        /// An attribute of type Unsigned Long.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string UL { get; set; }

        /// <summary>
        /// Checks to see if the UL property is set.
        /// </summary>
        internal bool IsSetUL() => this.UL != null;
    }
}
