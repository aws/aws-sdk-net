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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Details about the POSIX identity that is used for file system operations.
    /// </summary>
    public partial class CustomPosixUserConfig
    {
        /// <summary>
        /// Gets and sets the property Gid. 
        /// <para>
        /// The POSIX group ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1001, Max = 4000000)]
        public long? Gid { get; set; }

        /// <summary>
        /// Checks to see if the Gid property is set.
        /// </summary>
        internal bool IsSetGid() => this.Gid.HasValue;

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        /// The POSIX user ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10000, Max = 4000000)]
        public long? Uid { get; set; }

        /// <summary>
        /// Checks to see if the Uid property is set.
        /// </summary>
        internal bool IsSetUid() => this.Uid.HasValue;
    }
}
