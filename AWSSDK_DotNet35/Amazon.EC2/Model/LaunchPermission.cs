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
    /// <para>Describes a launch permission.</para>
    /// </summary>
    public class LaunchPermission
    {
        
        private string userId;
        private PermissionGroup group;


        /// <summary>
        /// The AWS account ID.
        ///  
        /// </summary>
        public string UserId
        {
            get { return this.userId; }
            set { this.userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this.userId != null;
        }

        /// <summary>
        /// The name of the group.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>all</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public PermissionGroup Group
        {
            get { return this.group; }
            set { this.group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this.group != null;
        }
    }
}
