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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Contains configuration details for protected query output.
    /// </summary>
    public partial class ProtectedQueryOutputConfiguration
    {
        /// <summary>
        /// Gets and sets the property Distribute. 
        /// <para>
        ///  Required configuration for a protected query with a <c>distribute</c> output type.
        /// </para>
        /// </summary>
        public ProtectedQueryDistributeOutputConfiguration Distribute { get; set; }

        /// <summary>
        /// Checks to see if the Distribute property is set.
        /// </summary>
        internal bool IsSetDistribute() => this.Distribute != null;

        /// <summary>
        /// Gets and sets the property IntermediateTable. 
        /// <para>
        /// The intermediate table output configuration, present when the protected query was
        /// triggered by a populate operation.
        /// </para>
        /// </summary>
        public IntermediateTableOutputConfiguration IntermediateTable { get; set; }

        /// <summary>
        /// Checks to see if the IntermediateTable property is set.
        /// </summary>
        internal bool IsSetIntermediateTable() => this.IntermediateTable != null;

        /// <summary>
        /// Gets and sets the property Member. 
        /// <para>
        ///  Required configuration for a protected query with a <c>member</c> output type.
        /// </para>
        /// </summary>
        public ProtectedQueryMemberOutputConfiguration Member { get; set; }

        /// <summary>
        /// Checks to see if the Member property is set.
        /// </summary>
        internal bool IsSetMember() => this.Member != null;

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// Required configuration for a protected query with an <c>s3</c> output type.
        /// </para>
        /// </summary>
        public ProtectedQueryS3OutputConfiguration S3 { get; set; }

        /// <summary>
        /// Checks to see if the S3 property is set.
        /// </summary>
        internal bool IsSetS3() => this.S3 != null;
    }
}
