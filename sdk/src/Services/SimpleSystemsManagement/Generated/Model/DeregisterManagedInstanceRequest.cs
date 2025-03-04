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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DeregisterManagedInstance operation.
    /// Removes the server or virtual machine from the list of registered servers.
    /// 
    ///  
    /// <para>
    /// If you want to reregister an on-premises server, edge device, or VM, you must use
    /// a different Activation Code and Activation ID than used to register the machine previously.
    /// The Activation Code and Activation ID must not have already been used on the maximum
    /// number of activations specified when they were created. For more information, see
    /// <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/fleet-manager-deregister-hybrid-nodes.html">Deregistering
    /// managed nodes in a hybrid and multicloud environment</a> in the <i>Amazon Web Services
    /// Systems Manager User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeregisterManagedInstanceRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID assigned to the managed node when you registered it using the activation process.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=124)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}