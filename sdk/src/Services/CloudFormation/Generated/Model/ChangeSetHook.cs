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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Specifies the resource, the hook, and the hook version to be invoked.
    /// </summary>
    public partial class ChangeSetHook
    {
        private HookFailureMode _failureMode;
        private HookInvocationPoint _invocationPoint;
        private ChangeSetHookTargetDetails _targetDetails;
        private string _typeConfigurationVersionId;
        private string _typeName;
        private string _typeVersionId;

        /// <summary>
        /// Gets and sets the property FailureMode. 
        /// <para>
        /// Specify the hook failure mode for non-compliant resources in the followings ways.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>FAIL</code> Stops provisioning resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WARN</code> Allows provisioning to continue with a warning message.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public HookFailureMode FailureMode
        {
            get { return this._failureMode; }
            set { this._failureMode = value; }
        }

        // Check to see if FailureMode property is set
        internal bool IsSetFailureMode()
        {
            return this._failureMode != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationPoint. 
        /// <para>
        /// Specifies the points in provisioning logic where a hook is invoked.
        /// </para>
        /// </summary>
        public HookInvocationPoint InvocationPoint
        {
            get { return this._invocationPoint; }
            set { this._invocationPoint = value; }
        }

        // Check to see if InvocationPoint property is set
        internal bool IsSetInvocationPoint()
        {
            return this._invocationPoint != null;
        }

        /// <summary>
        /// Gets and sets the property TargetDetails. 
        /// <para>
        /// Specifies details about the target that the hook will run against.
        /// </para>
        /// </summary>
        public ChangeSetHookTargetDetails TargetDetails
        {
            get { return this._targetDetails; }
            set { this._targetDetails = value; }
        }

        // Check to see if TargetDetails property is set
        internal bool IsSetTargetDetails()
        {
            return this._targetDetails != null;
        }

        /// <summary>
        /// Gets and sets the property TypeConfigurationVersionId. 
        /// <para>
        /// The version ID of the type configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string TypeConfigurationVersionId
        {
            get { return this._typeConfigurationVersionId; }
            set { this._typeConfigurationVersionId = value; }
        }

        // Check to see if TypeConfigurationVersionId property is set
        internal bool IsSetTypeConfigurationVersionId()
        {
            return this._typeConfigurationVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The unique name for your hook. Specifies a three-part namespace for your hook, with
        /// a recommended pattern of <code>Organization::Service::Hook</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The following organization namespaces are reserved and can't be used in your hook
        /// type names:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Alexa</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AMZN</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Amazon</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ASK</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Custom</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Dev</code> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        [AWSProperty(Min=10, Max=196)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

        /// <summary>
        /// Gets and sets the property TypeVersionId. 
        /// <para>
        /// The version ID of the type specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string TypeVersionId
        {
            get { return this._typeVersionId; }
            set { this._typeVersionId = value; }
        }

        // Check to see if TypeVersionId property is set
        internal bool IsSetTypeVersionId()
        {
            return this._typeVersionId != null;
        }

    }
}