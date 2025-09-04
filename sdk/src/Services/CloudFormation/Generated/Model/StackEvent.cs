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
    /// The StackEvent data type.
    /// </summary>
    public partial class StackEvent
    {
        private string _clientRequestToken;
        private DetailedStatus _detailedStatus;
        private string _eventId;
        private HookFailureMode _hookFailureMode;
        private string _hookInvocationId;
        private HookInvocationPoint _hookInvocationPoint;
        private HookStatus _hookStatus;
        private string _hookStatusReason;
        private string _hookType;
        private string _logicalResourceId;
        private string _physicalResourceId;
        private string _resourceProperties;
        private ResourceStatus _resourceStatus;
        private string _resourceStatusReason;
        private string _resourceType;
        private string _stackId;
        private string _stackName;
        private DateTime? _timestamp;

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
        [AWSProperty(Min=1, Max=128)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

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
        public DetailedStatus DetailedStatus
        {
            get { return this._detailedStatus; }
            set { this._detailedStatus = value; }
        }

        // Check to see if DetailedStatus property is set
        internal bool IsSetDetailedStatus()
        {
            return this._detailedStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The unique identifier of this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

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
        public HookFailureMode HookFailureMode
        {
            get { return this._hookFailureMode; }
            set { this._hookFailureMode = value; }
        }

        // Check to see if HookFailureMode property is set
        internal bool IsSetHookFailureMode()
        {
            return this._hookFailureMode != null;
        }

        /// <summary>
        /// Gets and sets the property HookInvocationId. 
        /// <para>
        /// The unique identifier of the Hook invocation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string HookInvocationId
        {
            get { return this._hookInvocationId; }
            set { this._hookInvocationId = value; }
        }

        // Check to see if HookInvocationId property is set
        internal bool IsSetHookInvocationId()
        {
            return this._hookInvocationId != null;
        }

        /// <summary>
        /// Gets and sets the property HookInvocationPoint. 
        /// <para>
        /// The specific point in the provisioning process where the Hook is invoked.
        /// </para>
        /// </summary>
        public HookInvocationPoint HookInvocationPoint
        {
            get { return this._hookInvocationPoint; }
            set { this._hookInvocationPoint = value; }
        }

        // Check to see if HookInvocationPoint property is set
        internal bool IsSetHookInvocationPoint()
        {
            return this._hookInvocationPoint != null;
        }

        /// <summary>
        /// Gets and sets the property HookStatus. 
        /// <para>
        /// Provides the status of the change set Hook.
        /// </para>
        /// </summary>
        public HookStatus HookStatus
        {
            get { return this._hookStatus; }
            set { this._hookStatus = value; }
        }

        // Check to see if HookStatus property is set
        internal bool IsSetHookStatus()
        {
            return this._hookStatus != null;
        }

        /// <summary>
        /// Gets and sets the property HookStatusReason. 
        /// <para>
        /// Provides the reason for the Hook status.
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
        /// Gets and sets the property HookType. 
        /// <para>
        /// The name of the Hook.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string HookType
        {
            get { return this._hookType; }
            set { this._hookType = value; }
        }

        // Check to see if HookType property is set
        internal bool IsSetHookType()
        {
            return this._hookType != null;
        }

        /// <summary>
        /// Gets and sets the property LogicalResourceId. 
        /// <para>
        /// The logical name of the resource specified in the template.
        /// </para>
        /// </summary>
        public string LogicalResourceId
        {
            get { return this._logicalResourceId; }
            set { this._logicalResourceId = value; }
        }

        // Check to see if LogicalResourceId property is set
        internal bool IsSetLogicalResourceId()
        {
            return this._logicalResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property PhysicalResourceId. 
        /// <para>
        /// The name or unique identifier associated with the physical instance of the resource.
        /// </para>
        /// </summary>
        public string PhysicalResourceId
        {
            get { return this._physicalResourceId; }
            set { this._physicalResourceId = value; }
        }

        // Check to see if PhysicalResourceId property is set
        internal bool IsSetPhysicalResourceId()
        {
            return this._physicalResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceProperties. 
        /// <para>
        /// BLOB of the properties used to create the resource.
        /// </para>
        /// </summary>
        public string ResourceProperties
        {
            get { return this._resourceProperties; }
            set { this._resourceProperties = value; }
        }

        // Check to see if ResourceProperties property is set
        internal bool IsSetResourceProperties()
        {
            return this._resourceProperties != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceStatus. 
        /// <para>
        /// Current status of the resource.
        /// </para>
        /// </summary>
        public ResourceStatus ResourceStatus
        {
            get { return this._resourceStatus; }
            set { this._resourceStatus = value; }
        }

        // Check to see if ResourceStatus property is set
        internal bool IsSetResourceStatus()
        {
            return this._resourceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceStatusReason. 
        /// <para>
        /// Success/failure message associated with the resource.
        /// </para>
        /// </summary>
        public string ResourceStatusReason
        {
            get { return this._resourceStatusReason; }
            set { this._resourceStatusReason = value; }
        }

        // Check to see if ResourceStatusReason property is set
        internal bool IsSetResourceStatusReason()
        {
            return this._resourceStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Type of resource. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">Amazon
        /// Web Services resource and property types reference</a> in the <i>CloudFormation User
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The unique ID name of the instance of the stack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name associated with a stack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Time the status was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}