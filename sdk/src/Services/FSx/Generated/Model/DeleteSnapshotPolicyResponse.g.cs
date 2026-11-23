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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// This is the response object from the DeleteSnapshotPolicy operation.
    /// </summary>
    public partial class DeleteSnapshotPolicyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle state of the snapshot policy being deleted. If the <c>DeleteSnapshotPolicy</c>
        /// operation is successful, this value is <c>DELETING</c>.
        /// </para>
        /// </summary>
        public SnapshotPolicyLifecycle Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property SnapshotPolicyId. 
        /// <para>
        /// The ID of the snapshot policy that's being deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 29, Max = 29)]
        public string SnapshotPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotPolicyId property is set.
        /// </summary>
        internal bool IsSetSnapshotPolicyId() => this.SnapshotPolicyId != null;
    }
}
