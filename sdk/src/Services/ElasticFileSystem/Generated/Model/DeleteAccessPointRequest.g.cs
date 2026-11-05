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

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAccessPoint operation. Deletes the specified
    /// access point. After deletion is complete, new clients can no longer connect to the
    /// access points. Clients connected to the access point at the time of deletion will
    /// continue to function until they terminate their connection. <para> This operation
    /// requires permissions for the <c>elasticfilesystem:DeleteAccessPoint</c> action. </para>
    /// </summary>
    public partial class DeleteAccessPointRequest : AmazonElasticFileSystemRequest
    {
        /// <summary>
        /// Gets and sets the property AccessPointId. 
        /// <para>
        /// The ID of the access point that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// Checks to see if the AccessPointId property is set.
        /// </summary>
        internal bool IsSetAccessPointId() => this.AccessPointId != null;
    }
}
