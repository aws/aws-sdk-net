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

namespace Amazon.OpenSearchMemory.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteSpace operation. Deletes a space and its
    /// memories. Deletion can't be undone. After you delete the space, you can't retrieve
    /// its events, and the service removes them when they reach their expiry. <para> The
    /// operation returns with <c>status</c> <c>DELETING</c>. When deletion finishes, <c>GetSpace</c>
    /// returns <c>ResourceNotFoundException</c>. If deletion fails, the status becomes <c>FAILED</c>.
    /// A space that is <c>CREATING</c> or <c>UPDATING</c> can't be deleted until that finishes:
    /// the request fails with <c>ConflictException</c>. Deleting a space that is already
    /// <c>DELETING</c> returns <c>DELETING</c> again. </para>
    /// </summary>
    public partial class DeleteSpaceRequest : AmazonOpenSearchMemoryRequest
    {
        /// <summary>
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The ID of the space to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SpaceId { get; set; }

        /// <summary>
        /// Checks to see if the SpaceId property is set.
        /// </summary>
        internal bool IsSetSpaceId() => this.SpaceId != null;
    }
}
