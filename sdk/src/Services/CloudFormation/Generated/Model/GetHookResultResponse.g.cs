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
    /// This is the response object from the GetHookResult operation.
    /// </summary>
    public partial class GetHookResultResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Annotations. 
        /// <para>
        /// A list of objects with additional information and guidance that can help you resolve
        /// a failed Hook invocation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Annotation> Annotations { get; set; } = AWSConfigs.InitializeCollections ? new List<Annotation>() : null;

        /// <summary>
        /// Checks to see if the Annotations property is set.
        /// </summary>
        internal bool IsSetAnnotations() => this.Annotations != null && (this.Annotations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailureMode. 
        /// <para>
        /// The failure mode of the invocation.
        /// </para>
        /// </summary>
        public HookFailureMode FailureMode { get; set; }

        /// <summary>
        /// Checks to see if the FailureMode property is set.
        /// </summary>
        internal bool IsSetFailureMode() => this.FailureMode != null;

        /// <summary>
        /// Gets and sets the property HookResultId. 
        /// <para>
        /// The unique identifier of the Hook result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string HookResultId { get; set; }

        /// <summary>
        /// Checks to see if the HookResultId property is set.
        /// </summary>
        internal bool IsSetHookResultId() => this.HookResultId != null;

        /// <summary>
        /// Gets and sets the property HookStatusReason. 
        /// <para>
        /// A message that provides additional details about the Hook invocation status.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string HookStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the HookStatusReason property is set.
        /// </summary>
        internal bool IsSetHookStatusReason() => this.HookStatusReason != null;

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
        /// Gets and sets the property InvokedAt. 
        /// <para>
        /// The timestamp when the Hook was invoked.
        /// </para>
        /// </summary>
        public DateTime? InvokedAt { get; set; }

        /// <summary>
        /// Checks to see if the InvokedAt property is set.
        /// </summary>
        internal bool IsSetInvokedAt() => this.InvokedAt.HasValue;

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
        [AWSProperty(Min = 10, Max = 196)]
        public string OriginalTypeName { get; set; }

        /// <summary>
        /// Checks to see if the OriginalTypeName property is set.
        /// </summary>
        internal bool IsSetOriginalTypeName() => this.OriginalTypeName != null;

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
        public HookStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// Information about the target of the Hook invocation.
        /// </para>
        /// </summary>
        public HookTarget Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

        /// <summary>
        /// Gets and sets the property TypeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Hook.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TypeArn { get; set; }

        /// <summary>
        /// Checks to see if the TypeArn property is set.
        /// </summary>
        internal bool IsSetTypeArn() => this.TypeArn != null;

        /// <summary>
        /// Gets and sets the property TypeConfigurationVersionId. 
        /// <para>
        /// The version identifier of the Hook configuration data that was used during invocation.
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
        /// The name of the Hook that was invoked.
        /// </para>
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
        /// The version identifier of the Hook that was invoked.
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
