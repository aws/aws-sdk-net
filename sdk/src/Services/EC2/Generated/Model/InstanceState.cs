/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-09-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the current state of the instance.
    /// </summary>
    public partial class InstanceState
    {
        private int? _code;
        private InstanceStateName _name;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The low byte represents the state. The high byte is an opaque internal value and should
        /// be ignored.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>0</code> : <code>pending</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>16</code> : <code>running</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>32</code> : <code>shutting-down</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>48</code> : <code>terminated</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>64</code> : <code>stopping</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>80</code> : <code>stopped</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int Code
        {
            get { return this._code.GetValueOrDefault(); }
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