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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Details about a resource that failed to deploy.
    /// </summary>
    public partial class NetworkMigrationFailedResourceDetails
    {
        /// <summary>
        /// Gets and sets the property LogicalID. 
        /// <para>
        /// The logical ID of the failed resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string LogicalID { get; set; }

        /// <summary>
        /// Checks to see if the LogicalID property is set.
        /// </summary>
        internal bool IsSetLogicalID() => this.LogicalID != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the failed resource.
        /// </para>
        /// </summary>
        public NetworkMigrationFailedResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason why the resource failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65536)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
