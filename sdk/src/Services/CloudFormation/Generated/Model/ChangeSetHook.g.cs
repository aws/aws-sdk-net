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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Specifies the resource, the Hook, and the Hook version to be invoked.
    /// </summary>
    public partial class ChangeSetHook
    {
        /// <summary>
        /// Gets and sets the property FailureMode. 
        /// <para>
        /// Specify the Hook failure mode for non-compliant resources in the followings ways.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FAIL</c> Stops provisioning resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WARN</c> Allows provisioning to continue with a warning message.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public HookFailureMode FailureMode { get; set; }

        /// <summary>
        /// Checks to see if the FailureMode property is set.
        /// </summary>
        internal bool IsSetFailureMode() => this.FailureMode != null;

        /// <summary>
        /// Gets and sets the property InvocationPoint. 
        /// <para>
        /// The specific point in the provisioning process where the Hook is invoked.
        /// </para>
        /// </summary>
        public HookInvocationPoint InvocationPoint { get; set; }

        /// <summary>
        /// Checks to see if the InvocationPoint property is set.
        /// </summary>
        internal bool IsSetInvocationPoint() => this.InvocationPoint != null;

        /// <summary>
        /// Gets and sets the property TargetDetails. 
        /// <para>
        /// Specifies details about the target that the Hook will run against.
        /// </para>
        /// </summary>
        public ChangeSetHookTargetDetails TargetDetails { get; set; }

        /// <summary>
        /// Checks to see if the TargetDetails property is set.
        /// </summary>
        internal bool IsSetTargetDetails() => this.TargetDetails != null;

        /// <summary>
        /// Gets and sets the property TypeConfigurationVersionId. 
        /// <para>
        /// The version ID of the type configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TypeConfigurationVersionId { get; set; }

        /// <summary>
        /// Checks to see if the TypeConfigurationVersionId property is set.
        /// </summary>
        internal bool IsSetTypeConfigurationVersionId() => this.TypeConfigurationVersionId != null;

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The unique name for your Hook. Specifies a three-part namespace for your Hook, with
        /// a recommended pattern of <c>Organization::Service::Hook</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The following organization namespaces are reserved and can't be used in your Hook
        /// type names:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Alexa</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AMZN</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Amazon</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ASK</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Custom</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Dev</c> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        [AWSProperty(Min = 10, Max = 196)]
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;

        /// <summary>
        /// Gets and sets the property TypeVersionId. 
        /// <para>
        /// The version ID of the type specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TypeVersionId { get; set; }

        /// <summary>
        /// Checks to see if the TypeVersionId property is set.
        /// </summary>
        internal bool IsSetTypeVersionId() => this.TypeVersionId != null;
    }
}
