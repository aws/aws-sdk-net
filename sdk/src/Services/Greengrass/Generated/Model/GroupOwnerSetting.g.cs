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

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Group owner related settings for local resources.
    /// </summary>
    public partial class GroupOwnerSetting
    {
        /// <summary>
        /// Gets and sets the property AutoAddGroupOwner. If true, AWS IoT Greengrass automatically
        /// adds the specified Linux OS group owner of the resource to the Lambda process privileges.
        /// Thus the Lambda process will have the file access permissions of the added Linux group.
        /// </summary>
        public bool? AutoAddGroupOwner { get; set; }

        /// <summary>
        /// Checks to see if the AutoAddGroupOwner property is set.
        /// </summary>
        internal bool IsSetAutoAddGroupOwner() => this.AutoAddGroupOwner.HasValue;

        /// <summary>
        /// Gets and sets the property GroupOwner. The name of the Linux OS group whose privileges
        /// will be added to the Lambda process. This field is optional.
        /// </summary>
        public string GroupOwner { get; set; }

        /// <summary>
        /// Checks to see if the GroupOwner property is set.
        /// </summary>
        internal bool IsSetGroupOwner() => this.GroupOwner != null;
    }
}
