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
    /// <para>Describes a tag.</para>
    /// </summary>
    public class TagDescription
    {
        
        private string resourceId;
        private ResourceType resourceType;
        private string key;
        private string value;


        /// <summary>
        /// The ID of the resource. For example, <c>ami-1a2b3c4d</c>.
        ///  
        /// </summary>
        public string ResourceId
        {
            get { return this.resourceId; }
            set { this.resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this.resourceId != null;
        }

        /// <summary>
        /// The type of resource.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>customer-gateway, dhcp-options, image, instance, internet-gateway, network-acl, network-interface, reserved-instances, route-table, snapshot, spot-instances-request, subnet, security-group, volume, vpc, vpn-connection, vpn-gateway</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this.resourceType; }
            set { this.resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this.resourceType != null;
        }

        /// <summary>
        /// The key of the tag.
        ///  
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// The value of the tag.
        ///  
        /// </summary>
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this.value != null;
        }
    }
}
