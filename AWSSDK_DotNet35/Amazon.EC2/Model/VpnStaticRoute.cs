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
    /// <para>Describes a static route for a VPN connection.</para>
    /// </summary>
    public class VpnStaticRoute
    {
        
        private string destinationCidrBlock;
        private VpnStaticRouteSource source;
        private VpnState state;


        /// <summary>
        /// The CIDR block associated with the local subnet of the customer data center.
        ///  
        /// </summary>
        public string DestinationCidrBlock
        {
            get { return this.destinationCidrBlock; }
            set { this.destinationCidrBlock = value; }
        }

        // Check to see if DestinationCidrBlock property is set
        internal bool IsSetDestinationCidrBlock()
        {
            return this.destinationCidrBlock != null;
        }

        /// <summary>
        /// Indicates how the routes were provided.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Static</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public VpnStaticRouteSource Source
        {
            get { return this.source; }
            set { this.source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this.source != null;
        }

        /// <summary>
        /// The current state of the static route.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>pending, available, deleting, deleted</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public VpnState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }
    }
}
