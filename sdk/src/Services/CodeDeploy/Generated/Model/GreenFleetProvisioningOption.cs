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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about the instances that belong to the replacement environment in a blue/green
    /// deployment.
    /// </summary>
    public partial class GreenFleetProvisioningOption
    {
        private GreenFleetProvisioningAction _action;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The method used to add instances to a replacement environment.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DISCOVER_EXISTING</c>: Use instances that already exist or will be created manually.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COPY_AUTO_SCALING_GROUP</c>: Use settings from a specified Auto Scaling group
        /// to define and create instances in a new Auto Scaling group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GreenFleetProvisioningAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

    }
}