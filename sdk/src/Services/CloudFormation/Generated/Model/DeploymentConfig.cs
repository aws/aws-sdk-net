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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The deployment configuration for a stack operation, including the deployment mode.
    /// </summary>
    public partial class DeploymentConfig
    {
        private bool? _disableRollback;
        private DeploymentConfigMode _mode;

        /// <summary>
        /// Gets and sets the property DisableRollback. 
        /// <para>
        /// Specifies whether to disable rollback of the stack if the stack operation fails.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? DisableRollback
        {
            get { return this._disableRollback; }
            set { this._disableRollback = value; }
        }

        // Check to see if DisableRollback property is set
        internal bool IsSetDisableRollback()
        {
            return this._disableRollback.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Specifies the deployment mode for the stack operation. Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>STANDARD</c> - Use the standard deployment behavior, ensuring resources are ready
        /// to serve traffic before completing the operation. This is the default. You do not
        /// need to specify this value explicitly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPRESS</c> - Complete the stack operation when resource configuration is applied,
        /// without waiting for resources to become ready to serve traffic. Resources continue
        /// becoming ready in the background.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeploymentConfigMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}