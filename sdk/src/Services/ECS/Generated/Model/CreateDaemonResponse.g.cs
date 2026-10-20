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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// This is the response object from the CreateDaemon operation.
    /// </summary>
    public partial class CreateDaemonResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp for the time when the daemon was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DaemonArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon.
        /// </para>
        /// </summary>
        public string DaemonArn { get; set; }

        /// <summary>
        /// Checks to see if the DaemonArn property is set.
        /// </summary>
        internal bool IsSetDaemonArn() => this.DaemonArn != null;

        /// <summary>
        /// Gets and sets the property DeploymentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the initial daemon deployment. This deployment places
        /// daemon tasks on each container instance of the specified capacity providers.
        /// </para>
        /// </summary>
        public string DeploymentArn { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentArn property is set.
        /// </summary>
        internal bool IsSetDeploymentArn() => this.DeploymentArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the daemon.
        /// </para>
        /// </summary>
        public DaemonStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
