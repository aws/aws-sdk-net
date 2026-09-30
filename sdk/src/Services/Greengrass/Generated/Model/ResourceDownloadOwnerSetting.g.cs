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
    /// The owner setting for downloaded machine learning resources.
    /// </summary>
    public partial class ResourceDownloadOwnerSetting
    {
        /// <summary>
        /// Gets and sets the property GroupOwner. The group owner of the resource. This is the
        /// name of an existing Linux OS group on the system or a GID. The group's permissions
        /// are added to the Lambda process.
        /// </summary>
        [AWSProperty(Required = true)]
        public string GroupOwner { get; set; }

        /// <summary>
        /// Checks to see if the GroupOwner property is set.
        /// </summary>
        internal bool IsSetGroupOwner() => this.GroupOwner != null;

        /// <summary>
        /// Gets and sets the property GroupPermission. The permissions that the group owner has
        /// to the resource. Valid values are ''rw'' (read/write) or ''ro'' (read-only).
        /// </summary>
        [AWSProperty(Required = true)]
        public Permission GroupPermission { get; set; }

        /// <summary>
        /// Checks to see if the GroupPermission property is set.
        /// </summary>
        internal bool IsSetGroupPermission() => this.GroupPermission != null;
    }
}
