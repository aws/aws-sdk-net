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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about a deployment's policy that defines when components are
    /// safe to update.
    /// 
    ///  
    /// <para>
    /// Each component on a device can report whether or not it's ready to update. After a
    /// component and its dependencies are ready, they can apply the update in the deployment.
    /// You can configure whether or not the deployment notifies components of an update and
    /// waits for a response. You specify the amount of time each component has to respond
    /// to the update notification.
    /// </para>
    /// </summary>
    public partial class DeploymentComponentUpdatePolicy
    {
        private DeploymentComponentUpdatePolicyAction _action;
        private int? _timeoutInSeconds;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Whether or not to notify components and wait for components to become safe to update.
        /// Choose from the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NOTIFY_COMPONENTS</c> – The deployment notifies each component before it stops
        /// and updates that component. Components can use the <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/interprocess-communication.html#ipc-operation-subscribetocomponentupdates">SubscribeToComponentUpdates</a>
        /// IPC operation to receive these notifications. Then, components can respond with the
        /// <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/interprocess-communication.html#ipc-operation-defercomponentupdate">DeferComponentUpdate</a>
        /// IPC operation. For more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/create-deployments.html">Create
        /// deployments</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SKIP_NOTIFY_COMPONENTS</c> – The deployment doesn't notify components or wait
        /// for them to be safe to update.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>NOTIFY_COMPONENTS</c> 
        /// </para>
        /// </summary>
        public DeploymentComponentUpdatePolicyAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// The amount of time in seconds that each component on a device has to report that it's
        /// safe to update. If the component waits for longer than this timeout, then the deployment
        /// proceeds on the device.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>60</c> 
        /// </para>
        /// </summary>
        public int? TimeoutInSeconds
        {
            get { return this._timeoutInSeconds; }
            set { this._timeoutInSeconds = value; }
        }

        // Check to see if TimeoutInSeconds property is set
        internal bool IsSetTimeoutInSeconds()
        {
            return this._timeoutInSeconds.HasValue; 
        }

    }
}