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
    /// Contains detailed information about an event that occurred during a CloudFormation
    /// operation.
    /// </summary>
    public partial class OperationEvent
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier for the request that initiated this operation.
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
        /// Additional status information about the operation.
        /// </para>
        /// </summary>
        public DetailedStatus DetailedStatus { get; set; }

        /// <summary>
        /// Checks to see if the DetailedStatus property is set.
        /// </summary>
        internal bool IsSetDetailedStatus() => this.DetailedStatus != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when the event ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// A unique identifier for this event.
        /// </para>
        /// </summary>
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of event.
        /// </para>
        /// </summary>
        public EventType EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property HookFailureMode. 
        /// <para>
        /// Specifies how Hook failures are handled.
        /// </para>
        /// </summary>
        public HookFailureMode HookFailureMode { get; set; }

        /// <summary>
        /// Checks to see if the HookFailureMode property is set.
        /// </summary>
        internal bool IsSetHookFailureMode() => this.HookFailureMode != null;

        /// <summary>
        /// Gets and sets the property HookInvocationPoint. 
        /// <para>
        /// The point in the operation lifecycle when the Hook was invoked.
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
        /// The status of the Hook invocation. 
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
        /// Additional information about the Hook status.
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
        /// The type name of the Hook that was invoked.
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
        /// The logical name of the resource as specified in the template.
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
        /// The unique identifier of the operation this event belongs to.
        /// </para>
        /// </summary>
        public string OperationId { get; set; }

        /// <summary>
        /// Checks to see if the OperationId property is set.
        /// </summary>
        internal bool IsSetOperationId() => this.OperationId != null;

        /// <summary>
        /// Gets and sets the property OperationStatus. 
        /// <para>
        /// The current status of the operation.
        /// </para>
        /// </summary>
        public BeaconStackOperationStatus OperationStatus { get; set; }

        /// <summary>
        /// Checks to see if the OperationStatus property is set.
        /// </summary>
        internal bool IsSetOperationStatus() => this.OperationStatus != null;

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// The type of operation.
        /// </para>
        /// </summary>
        public OperationType OperationType { get; set; }

        /// <summary>
        /// Checks to see if the OperationType property is set.
        /// </summary>
        internal bool IsSetOperationType() => this.OperationType != null;

        /// <summary>
        /// Gets and sets the property PhysicalResourceId. 
        /// <para>
        /// The name or unique identifier that corresponds to a physical instance ID of a resource.
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
        /// The properties used to create the resource.
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
        /// Success or failure message associated with the resource.
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
        /// Type of resource.
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
        public string StackId { get; set; }

        /// <summary>
        /// Checks to see if the StackId property is set.
        /// </summary>
        internal bool IsSetStackId() => this.StackId != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when the event started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Time the status was updated.
        /// </para>
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ValidationFailureMode. 
        /// <para>
        /// Specifies how validation failures are handled.
        /// </para>
        /// </summary>
        public HookFailureMode ValidationFailureMode { get; set; }

        /// <summary>
        /// Checks to see if the ValidationFailureMode property is set.
        /// </summary>
        internal bool IsSetValidationFailureMode() => this.ValidationFailureMode != null;

        /// <summary>
        /// Gets and sets the property ValidationName. 
        /// <para>
        /// The name of the validation that was performed.
        /// </para>
        /// </summary>
        public string ValidationName { get; set; }

        /// <summary>
        /// Checks to see if the ValidationName property is set.
        /// </summary>
        internal bool IsSetValidationName() => this.ValidationName != null;

        /// <summary>
        /// Gets and sets the property ValidationPath. 
        /// <para>
        /// The path within the resource where the validation was applied.
        /// </para>
        /// </summary>
        public string ValidationPath { get; set; }

        /// <summary>
        /// Checks to see if the ValidationPath property is set.
        /// </summary>
        internal bool IsSetValidationPath() => this.ValidationPath != null;

        /// <summary>
        /// Gets and sets the property ValidationStatus. 
        /// <para>
        /// The status of the validation.
        /// </para>
        /// </summary>
        public ValidationStatus ValidationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ValidationStatus property is set.
        /// </summary>
        internal bool IsSetValidationStatus() => this.ValidationStatus != null;

        /// <summary>
        /// Gets and sets the property ValidationStatusReason. 
        /// <para>
        /// Additional information about the validation status.
        /// </para>
        /// </summary>
        public string ValidationStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the ValidationStatusReason property is set.
        /// </summary>
        internal bool IsSetValidationStatusReason() => this.ValidationStatusReason != null;
    }
}
