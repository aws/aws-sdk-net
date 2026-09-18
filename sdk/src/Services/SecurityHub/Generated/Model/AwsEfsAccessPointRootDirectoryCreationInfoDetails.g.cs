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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about the settings that Amazon EFS uses to create the root directory
    /// when a client connects to an access point.
    /// </summary>
    public partial class AwsEfsAccessPointRootDirectoryCreationInfoDetails
    {
        /// <summary>
        /// Gets and sets the property OwnerGid. 
        /// <para>
        /// Specifies the POSIX group ID to apply to the root directory. 
        /// </para>
        /// </summary>
        public string OwnerGid { get; set; }

        /// <summary>
        /// Checks to see if the OwnerGid property is set.
        /// </summary>
        internal bool IsSetOwnerGid() => this.OwnerGid != null;

        /// <summary>
        /// Gets and sets the property OwnerUid. 
        /// <para>
        /// Specifies the POSIX user ID to apply to the root directory. 
        /// </para>
        /// </summary>
        public string OwnerUid { get; set; }

        /// <summary>
        /// Checks to see if the OwnerUid property is set.
        /// </summary>
        internal bool IsSetOwnerUid() => this.OwnerUid != null;

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// Specifies the POSIX permissions to apply to the root directory, in the format of an
        /// octal number representing the file's mode bits. 
        /// </para>
        /// </summary>
        public string Permissions { get; set; }

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null;
    }
}
