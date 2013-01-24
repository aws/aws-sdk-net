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
    /// <para> The response of calling DeleteVirtualInterface. </para>
    /// </summary>
    public class DeleteVirtualInterfaceResult  
    {
        
        private string virtualInterfaceState;

        /// <summary>
        /// State of the virtual interface. <ul> <li><b>Verifying</b>: This state only applies to public virtual interfaces. Each public virtual
        /// interface need validation before the virtual interface can be created.</li> <li><b>Pending</b>: A virtual interface is in this state from
        /// the time that it is created until the virtual interface is ready to forward traffic.</li> <li><b>Available</b>: A virtual interface that is
        /// able to forward traffic.</li> <li><b>Deleting</b>: A virtual interface is in this state immediately after calling
        /// <i>DeleteVirtualInterface</i> until it can no longer forward traffic.</li> <li><b>Deleted</b>: A virtual interface that cannot forward
        /// traffic.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>verifying, pending, available, deleting, deleted</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string VirtualInterfaceState
        {
            get { return this.virtualInterfaceState; }
            set { this.virtualInterfaceState = value; }
        }

        /// <summary>
        /// Sets the VirtualInterfaceState property
        /// </summary>
        /// <param name="virtualInterfaceState">The value to set for the VirtualInterfaceState property </param>
        /// <returns>this instance</returns>
        public DeleteVirtualInterfaceResult WithVirtualInterfaceState(string virtualInterfaceState)
        {
            this.virtualInterfaceState = virtualInterfaceState;
            return this;
        }
            

        // Check to see if VirtualInterfaceState property is set
        internal bool IsSetVirtualInterfaceState()
        {
            return this.virtualInterfaceState != null;       
        }
    }
}
