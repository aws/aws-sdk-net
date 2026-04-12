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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
    /// This is the response object from the DeleteDaemon operation.
    /// </summary>
    public partial class DeleteDaemonResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _daemonArn;
        private string _deploymentArn;
        private DaemonStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp for the time when the daemon was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DaemonArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon.
        /// </para>
        /// </summary>
        public string DaemonArn
        {
            get { return this._daemonArn; }
            set { this._daemonArn = value; }
        }

        // Check to see if DaemonArn property is set
        internal bool IsSetDaemonArn()
        {
            return this._daemonArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon deployment that was triggered by the
        /// delete operation. This deployment drains existing daemon tasks from the container
        /// instances.
        /// </para>
        /// </summary>
        public string DeploymentArn
        {
            get { return this._deploymentArn; }
            set { this._deploymentArn = value; }
        }

        // Check to see if DeploymentArn property is set
        internal bool IsSetDeploymentArn()
        {
            return this._deploymentArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the daemon. After you call <c>DeleteDaemon</c>, the status changes to
        /// <c>DELETE_IN_PROGRESS</c>.
        /// </para>
        /// </summary>
        public DaemonStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp for the time when the daemon was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}