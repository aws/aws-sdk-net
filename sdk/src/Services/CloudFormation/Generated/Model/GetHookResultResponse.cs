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
    /// This is the response object from the GetHookResult operation.
    /// </summary>
    public partial class GetHookResultResponse : AmazonWebServiceResponse
    {
        private List<Annotation> _annotations = AWSConfigs.InitializeCollections ? new List<Annotation>() : null;
        private HookFailureMode _failureMode;
        private string _hookResultId;
        private string _hookStatusReason;
        private HookInvocationPoint _invocationPoint;
        private DateTime? _invokedAt;
        private string _originalTypeName;
        private HookStatus _status;
        private HookTarget _target;
        private string _typeArn;
        private string _typeConfigurationVersionId;
        private string _typeName;
        private string _typeVersionId;

        /// <summary>
        /// Gets and sets the property Annotations. 
        /// <para>
        /// A list of objects with additional information and guidance that can help you resolve
        /// a failed Hook invocation.
        /// </para>
        /// </summary>
        public List<Annotation> Annotations
        {
            get { return this._annotations; }
            set { this._annotations = value; }
        }

        // Check to see if Annotations property is set
        internal bool IsSetAnnotations()
        {
            return this._annotations != null && (this._annotations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailureMode. 
        /// <para>
        /// The failure mode of the invocation.
        /// </para>
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
        /// Gets and sets the property HookResultId. 
        /// <para>
        /// The unique identifier of the Hook result.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string HookResultId
        {
            get { return this._hookResultId; }
            set { this._hookResultId = value; }
        }

        // Check to see if HookResultId property is set
        internal bool IsSetHookResultId()
        {
            return this._hookResultId != null;
        }

        /// <summary>
        /// Gets and sets the property HookStatusReason. 
        /// <para>
        /// A message that provides additional details about the Hook invocation status.
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
        /// The specific point in the provisioning process where the Hook is invoked.
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
        /// Gets and sets the property InvokedAt. 
        /// <para>
        /// The timestamp when the Hook was invoked.
        /// </para>
        /// </summary>
        public DateTime InvokedAt
        {
            get { return this._invokedAt.GetValueOrDefault(); }
            set { this._invokedAt = value; }
        }

        // Check to see if InvokedAt property is set
        internal bool IsSetInvokedAt()
        {
            return this._invokedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OriginalTypeName. 
        /// <para>
        /// The original public type name of the Hook when an alias is used.
        /// </para>
        ///  
        /// <para>
        /// For example, if you activate <c>AWS::Hooks::GuardHook</c> with alias <c>MyCompany::Custom::GuardHook</c>,
        /// then <c>TypeName</c> will be <c>MyCompany::Custom::GuardHook</c> and <c>OriginalTypeName</c>
        /// will be <c>AWS::Hooks::GuardHook</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=196)]
        public string OriginalTypeName
        {
            get { return this._originalTypeName; }
            set { this._originalTypeName = value; }
        }

        // Check to see if OriginalTypeName property is set
        internal bool IsSetOriginalTypeName()
        {
            return this._originalTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Hook invocation. The following statuses are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HOOK_IN_PROGRESS</c>: The Hook is currently running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOOK_COMPLETE_SUCCEEDED</c>: The Hook completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOOK_COMPLETE_FAILED</c>: The Hook completed but failed validation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOOK_FAILED</c>: The Hook encountered an error during execution.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property Target. 
        /// <para>
        /// Information about the target of the Hook invocation.
        /// </para>
        /// </summary>
        public HookTarget Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property TypeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Hook.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string TypeArn
        {
            get { return this._typeArn; }
            set { this._typeArn = value; }
        }

        // Check to see if TypeArn property is set
        internal bool IsSetTypeArn()
        {
            return this._typeArn != null;
        }

        /// <summary>
        /// Gets and sets the property TypeConfigurationVersionId. 
        /// <para>
        /// The version identifier of the Hook configuration data that was used during invocation.
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
        /// The name of the Hook that was invoked.
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
        /// The version identifier of the Hook that was invoked.
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