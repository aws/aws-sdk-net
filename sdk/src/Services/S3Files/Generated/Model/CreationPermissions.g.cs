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

namespace Amazon.S3Files.Model
{
    /// <summary>
    /// Specifies the permissions to set on newly created directories within the file system.
    /// </summary>
    public partial class CreationPermissions
    {
        /// <summary>
        /// Gets and sets the property OwnerGid. 
        /// <para>
        /// The POSIX group ID to assign to newly created directories.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 4294967295)]
        public long? OwnerGid { get; set; }

        /// <summary>
        /// Checks to see if the OwnerGid property is set.
        /// </summary>
        internal bool IsSetOwnerGid() => this.OwnerGid.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerUid. 
        /// <para>
        /// The POSIX user ID to assign to newly created directories.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 4294967295)]
        public long? OwnerUid { get; set; }

        /// <summary>
        /// Checks to see if the OwnerUid property is set.
        /// </summary>
        internal bool IsSetOwnerUid() => this.OwnerUid.HasValue;

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The octal permissions to assign to newly created directories.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 4)]
        public string Permissions { get; set; }

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null;
    }
}
