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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// <para> A step in the connection order process. </para>
    /// </summary>
    public class ConnectionOrderStep
    {
        
        private string number;
        private string name;
        private string description;
        private string owner;
        private int? sla;
        private StepState stepState;

        /// <summary>
        /// Number of an order step. Example: 1
        ///  
        /// </summary>
        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        // Check to see if Number property is set
        internal bool IsSetNumber()
        {
            return this.number != null;
        }

        /// <summary>
        /// Name of the order step. Example: Authorize cross connect
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// More detailed description of the order step. Example: "<i>AWS will prepare your connection and send you an email with an LOA to provide to
        /// the colocation provider</i>"
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The entity who owns the completion of the order step. Example: AWS, Customer
        ///  
        /// </summary>
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this.owner != null;
        }

        /// <summary>
        /// Time to complete the order step in minutes. Example: 60
        ///  
        /// </summary>
        public int Sla
        {
            get { return this.sla ?? default(int); }
            set { this.sla = value; }
        }

        // Check to see if Sla property is set
        internal bool IsSetSla()
        {
            return this.sla.HasValue;
        }

        /// <summary>
        /// State of the connection step. <ul> <li><b>Pending</b>: This step is not yet completed.</li> <li><b>Completed</b>: This step has been
        /// completed</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>pending, completed</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public StepState StepState
        {
            get { return this.stepState; }
            set { this.stepState = value; }
        }

        // Check to see if StepState property is set
        internal bool IsSetStepState()
        {
            return this.stepState != null;
        }
    }
}
