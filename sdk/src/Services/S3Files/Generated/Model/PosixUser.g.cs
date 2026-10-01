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
    /// Specifies the POSIX identity with uid, gid, and secondary group IDs for user enforcement.
    /// </summary>
    public partial class PosixUser
    {
        /// <summary>
        /// Gets and sets the property Gid. 
        /// <para>
        /// The POSIX group ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 4294967295)]
        public long? Gid { get; set; }

        /// <summary>
        /// Checks to see if the Gid property is set.
        /// </summary>
        internal bool IsSetGid() => this.Gid.HasValue;

        /// <summary>
        /// Gets and sets the property SecondaryGids. 
        /// <para>
        /// An array of secondary POSIX group IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<long> SecondaryGids { get; set; } = AWSConfigs.InitializeCollections ? new List<long>() : null;

        /// <summary>
        /// Checks to see if the SecondaryGids property is set.
        /// </summary>
        internal bool IsSetSecondaryGids() => this.SecondaryGids != null && (this.SecondaryGids.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        /// The POSIX user ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 4294967295)]
        public long? Uid { get; set; }

        /// <summary>
        /// Checks to see if the Uid property is set.
        /// </summary>
        internal bool IsSetUid() => this.Uid.HasValue;
    }
}
