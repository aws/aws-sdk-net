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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Contains details about an exit from a state during an execution.
    /// </summary>
    public partial class StateExitedEventDetails
    {
        private string _name;
        private string _output;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the state.
        /// </para>
        ///  
        /// <para>
        /// A name must <i>not</i> contain:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// whitespace
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// brackets <code>&lt; &gt; { } [ ]</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// wildcard characters <code>? *</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// special characters <code>" # % \ ^ | ~ ` $ &amp; , ; : /</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// control characters (<code>U+0000-001F</code>, <code>U+007F-009F</code>)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// The JSON output data of the state.
        /// </para>
        /// </summary>
        public string Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null;
        }

    }
}