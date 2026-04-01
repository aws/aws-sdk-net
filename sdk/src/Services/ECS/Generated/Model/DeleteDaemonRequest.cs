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
    /// Container for the parameters to the DeleteDaemon operation.
    /// Deletes the specified daemon. The daemon must be in an <c>ACTIVE</c> state to be deleted.
    /// Deleting a daemon stops all running daemon tasks on the associated container instances.
    /// Amazon ECS drains existing container instances and provisions new instances without
    /// the deleted daemon. Amazon ECS automatically launches replacement tasks for your Amazon
    /// ECS services.
    /// 
    ///  <note> 
    /// <para>
    /// ECS Managed Daemons is only supported for Amazon ECS Managed Instances Capacity Providers.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteDaemonRequest : AmazonECSRequest
    {
        private string _daemonArn;

        /// <summary>
        /// Gets and sets the property DaemonArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}