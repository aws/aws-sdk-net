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
    /// The <c>StackEvent</c> data type.
    /// </summary>
    public partial class StackEvent
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The token passed to the operation that generated this event.
        /// </para>
        ///  
        /// <para>
        /// All events triggered by a given stack operation are assigned the same client request
        /// token, which you can use to track operations. For example, if you execute a <c>CreateStack</c>
        /// operation with the token <c>token1</c>, then all the <c>StackEvents</c> generated
        /// by that operation will have <c>ClientRequestToken</c> set as <c>token1</c>.
        /// </para>
        ///  
        /// <para>
        /// In the console, stack operations display the client request token on the Events tab.
        /// Stack operations that are initiated from the console use the token format <i>Console-StackOperation-ID</i>,
        /// which helps you easily identify the stack operation . For example, if you create a
        /// stack using the console, each stack event would be assigned the same token in the
        /// following format: <c>Console-CreateStack-7f59c3cf-00d2-40c7-b2ff-e75db0987002</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property DetailedStatus. 
        /// <para>
        /// An optional field that contains information about the detailed status of the stack
        /// event.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CONFIGURATION_COMPLETE</c> - all of the resources in the stack have reached that
        /// event. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stack-resource-configuration-complete.html">Understand
        /// CloudFormation stack creation events</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>VALIDATION_FAILED</c> - template validation failed because of invalid properties
        /// in the template. The <c>ResourceStatusReason</c> field shows what properties are defined
        /// incorrectly.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DetailedStatus DetailedStatus { get; set; }

        /// <summary>
        /// Checks to see if the DetailedStatus property is set.
        /// </summary>
        internal bool IsSetDetailedStatus() => this.DetailedStatus != null;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The unique identifier of this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property HookFailureMode. 
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
        public HookFailureMode HookFailureMode { get; set; }

        /// <summary>
        /// Checks to see if the HookFailureMode property is set.
        /// </summary>
        internal bool IsSetHookFailureMode() => this.HookFailureMode != null;

        /// <summary>
        /// Gets and sets the property HookInvocationId. 
        /// <para>
        /// The unique identifier of the Hook invocation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string HookInvocationId { get; set; }

        /// <summary>
        /// Checks to see if the HookInvocationId property is set.
        /// </summary>
        internal bool IsSetHookInvocationId() => this.HookInvocationId != null;

        /// <summary>
        /// Gets and sets the property HookInvocationPoint. 
        /// <para>
        /// The specific point in the provisioning process where the Hook is invoked.
        /// </para>
        /// </summary>
        public HookInvocationPoint HookInvocationPoint { get; set; }

        /// <summary>
        /// Checks to see if the HookInvocationPoint property is set.
        /// </summary>
        internal bool IsSetHookInvocationPoint() => this.HookInvocationPoint != null;

        /// <summary>
        /// Gets and sets the property HookStatus. 
        /// <para>
        /// Provides the status of the change set Hook.
        /// </para>
        /// </summary>
        public HookStatus HookStatus { get; set; }

        /// <summary>
        /// Checks to see if the HookStatus property is set.
        /// </summary>
        internal bool IsSetHookStatus() => this.HookStatus != null;

        /// <summary>
        /// Gets and sets the property HookStatusReason. 
        /// <para>
        /// Provides the reason for the Hook status.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string HookStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the HookStatusReason property is set.
        /// </summary>
        internal bool IsSetHookStatusReason() => this.HookStatusReason != null;

        /// <summary>
        /// Gets and sets the property HookType. 
        /// <para>
        /// The name of the Hook.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string HookType { get; set; }

        /// <summary>
        /// Checks to see if the HookType property is set.
        /// </summary>
        internal bool IsSetHookType() => this.HookType != null;

        /// <summary>
        /// Gets and sets the property LogicalResourceId. 
        /// <para>
        /// The logical name of the resource specified in the template.
        /// </para>
        /// </summary>
        public string LogicalResourceId { get; set; }

        /// <summary>
        /// Checks to see if the LogicalResourceId property is set.
        /// </summary>
        internal bool IsSetLogicalResourceId() => this.LogicalResourceId != null;

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The unique identifier of the operation that generated this stack event.
        /// </para>
        /// </summary>
        public string OperationId { get; set; }

        /// <summary>
        /// Checks to see if the OperationId property is set.
        /// </summary>
        internal bool IsSetOperationId() => this.OperationId != null;

        /// <summary>
        /// Gets and sets the property PhysicalResourceId. 
        /// <para>
        /// The name or unique identifier associated with the physical instance of the resource.
        /// </para>
        /// </summary>
        public string PhysicalResourceId { get; set; }

        /// <summary>
        /// Checks to see if the PhysicalResourceId property is set.
        /// </summary>
        internal bool IsSetPhysicalResourceId() => this.PhysicalResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceProperties. 
        /// <para>
        /// BLOB of the properties used to create the resource.
        /// </para>
        /// </summary>
        public string ResourceProperties { get; set; }

        /// <summary>
        /// Checks to see if the ResourceProperties property is set.
        /// </summary>
        internal bool IsSetResourceProperties() => this.ResourceProperties != null;

        /// <summary>
        /// Gets and sets the property ResourceStatus. 
        /// <para>
        /// Current status of the resource.
        /// </para>
        /// </summary>
        public ResourceStatus ResourceStatus { get; set; }

        /// <summary>
        /// Checks to see if the ResourceStatus property is set.
        /// </summary>
        internal bool IsSetResourceStatus() => this.ResourceStatus != null;

        /// <summary>
        /// Gets and sets the property ResourceStatusReason. 
        /// <para>
        /// Success/failure message associated with the resource.
        /// </para>
        /// </summary>
        public string ResourceStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the ResourceStatusReason property is set.
        /// </summary>
        internal bool IsSetResourceStatusReason() => this.ResourceStatusReason != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Type of resource. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Amazon
        /// Web Services resource and property types reference</a> in the <i>CloudFormation User
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The unique ID name of the instance of the stack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StackId { get; set; }

        /// <summary>
        /// Checks to see if the StackId property is set.
        /// </summary>
        internal bool IsSetStackId() => this.StackId != null;

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name associated with a stack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StackName { get; set; }

        /// <summary>
        /// Checks to see if the StackName property is set.
        /// </summary>
        internal bool IsSetStackName() => this.StackName != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Time the status was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
