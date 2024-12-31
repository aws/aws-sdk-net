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
    /// The result value of the command execution. The device can use the result field to
    /// share additional details about the execution such as a return value of a remote function
    /// call.
    /// 
    ///  <note> 
    /// <para>
    /// This field is not applicable if you use the <c>AWS-IoT-FleetWise</c> namespace.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CommandExecutionResult
    {
        private bool? _b;
        private MemoryStream _bin;
        private string _s;

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
        /// An attribute of type Binary.
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

    }
}