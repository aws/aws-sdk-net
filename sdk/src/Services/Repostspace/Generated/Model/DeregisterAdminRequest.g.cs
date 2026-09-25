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

namespace Amazon.Repostspace.Model
{
    /// <summary>
    /// Container for the parameters to the DeregisterAdmin operation. Removes the user or
    /// group from the list of administrators of the private re:Post.
    /// </summary>
    public partial class DeregisterAdminRequest : AmazonRepostspaceRequest
    {
        /// <summary>
        /// Gets and sets the property AdminId. 
        /// <para>
        /// The ID of the admin to remove.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AdminId { get; set; }

        /// <summary>
        /// Checks to see if the AdminId property is set.
        /// </summary>
        internal bool IsSetAdminId() => this.AdminId != null;

        /// <summary>
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The ID of the private re:Post to remove the admin from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SpaceId { get; set; }

        /// <summary>
        /// Checks to see if the SpaceId property is set.
        /// </summary>
        internal bool IsSetSpaceId() => this.SpaceId != null;
    }
}
