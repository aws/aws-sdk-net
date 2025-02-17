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
    /// Describes a Hook invocation, its status, and the reason for its status.
    /// </summary>
    public partial class HookResultSummary
    {
        private HookFailureMode _failureMode;
        private string _hookStatusReason;
        private HookInvocationPoint _invocationPoint;
        private HookStatus _status;
        private string _typeConfigurationVersionId;
        private string _typeName;
        private string _typeVersionId;

        /// <summary>
        /// Gets and sets the property FailureMode. 
        /// <para>
        /// The failure mode of the invocation. The following are potential modes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FAIL</c>: If the hook invocation returns a failure, then the requested target
        /// operation should fail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WARN</c>: If the hook invocation returns a failure, then the requested target
        /// operation should warn.
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
        /// Gets and sets the property HookStatusReason. 
        /// <para>
        /// A description of the Hook results status. For example, if the Hook result is in a
        /// <c>FAILED</c> state, this may contain additional information for the <c>FAILED</c>
        /// state.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string HookStatusReason
        {
            get { return this._hookStatusReason; }
            set { this._hookStatusReason = value; }
        }

        // Check to see if HookStatusReason property is set
        internal bool IsSetHookStatusReason()
        {
            return this._hookStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationPoint. 
        /// <para>
        /// The exact point in the provisioning logic where the Hook runs.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The state of the Hook invocation.
        /// </para>
        /// </summary>
        public HookStatus Status
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
        /// Gets and sets the property TypeConfigurationVersionId. 
        /// <para>
        /// The version of the Hook type configuration.
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
        /// The type name of the Hook being invoked.
        /// </para>
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
        /// The version of the Hook being invoked.
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