/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> Represents the state of an Amazon EC2 instance. </para>
    /// </summary>
    public class InstanceState
    {
        
        private int? code;
        private InstanceStateName name;


        /// <summary>
        /// A 16-bit unsigned integer. The high byte is an opaque internal value and should be ignored. The low byte is set based on the state
        /// represented.
        ///  
        /// </summary>
        public int Code
        {
            get { return this.code ?? default(int); }
            set { this.code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this.code.HasValue;
        }

        /// <summary>
        /// The current state of the instance.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>pending, running, shutting-down, terminated, stopping, stopped</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public InstanceStateName Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }
    }
}
