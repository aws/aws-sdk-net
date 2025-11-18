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
    /// Contains detailed information about an event that occurred during a CloudFormation
    /// operation.
    /// </summary>
    public partial class OperationEvent
    {
        private string _clientRequestToken;
        private DetailedStatus _detailedStatus;
        private DateTime? _endTime;
        private string _eventId;
        private EventType _eventType;
        private HookFailureMode _hookFailureMode;
        private HookInvocationPoint _hookInvocationPoint;
        private HookStatus _hookStatus;
        private string _hookStatusReason;
        private string _hookType;
        private string _logicalResourceId;
        private string _operationId;
        private BeaconStackOperationStatus _operationStatus;
        private OperationType _operationType;
        private string _physicalResourceId;
        private string _resourceProperties;
        private ResourceStatus _resourceStatus;
        private string _resourceStatusReason;
        private string _resourceType;
        private string _stackId;
        private DateTime? _startTime;
        private DateTime? _timestamp;
        private HookFailureMode _validationFailureMode;
        private string _validationName;
        private string _validationPath;
        private ValidationStatus _validationStatus;
        private string _validationStatusReason;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier for the request that initiated this operation.
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
        /// Additional status information about the operation.
        /// </para>
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when the event ended.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// A unique identifier for this event.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of event.
        /// </para>
        /// </summary>
        public EventType EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property HookFailureMode. 
        /// <para>
        /// Specifies how Hook failures are handled.
        /// </para>
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
        /// Gets and sets the property HookInvocationPoint. 
        /// <para>
        /// The point in the operation lifecycle when the Hook was invoked.
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
        /// The status of the Hook invocation. 
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
        /// Additional information about the Hook status.
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
        /// The type name of the Hook that was invoked.
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
        /// The logical name of the resource as specified in the template.
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
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The unique identifier of the operation this event belongs to.
        /// </para>
        /// </summary>
        public string OperationId
        {
            get { return this._operationId; }
            set { this._operationId = value; }
        }

        // Check to see if OperationId property is set
        internal bool IsSetOperationId()
        {
            return this._operationId != null;
        }

        /// <summary>
        /// Gets and sets the property OperationStatus. 
        /// <para>
        /// The current status of the operation.
        /// </para>
        /// </summary>
        public BeaconStackOperationStatus OperationStatus
        {
            get { return this._operationStatus; }
            set { this._operationStatus = value; }
        }

        // Check to see if OperationStatus property is set
        internal bool IsSetOperationStatus()
        {
            return this._operationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// The type of operation.
        /// </para>
        /// </summary>
        public OperationType OperationType
        {
            get { return this._operationType; }
            set { this._operationType = value; }
        }

        // Check to see if OperationType property is set
        internal bool IsSetOperationType()
        {
            return this._operationType != null;
        }

        /// <summary>
        /// Gets and sets the property PhysicalResourceId. 
        /// <para>
        /// The name or unique identifier that corresponds to a physical instance ID of a resource.
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
        /// The properties used to create the resource.
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
        /// Success or failure message associated with the resource.
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
        /// Type of resource.
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when the event started.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Time the status was updated.
        /// </para>
        /// </summary>
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidationFailureMode. 
        /// <para>
        /// Specifies how validation failures are handled.
        /// </para>
        /// </summary>
        public HookFailureMode ValidationFailureMode
        {
            get { return this._validationFailureMode; }
            set { this._validationFailureMode = value; }
        }

        // Check to see if ValidationFailureMode property is set
        internal bool IsSetValidationFailureMode()
        {
            return this._validationFailureMode != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationName. 
        /// <para>
        /// The name of the validation that was performed.
        /// </para>
        /// </summary>
        public string ValidationName
        {
            get { return this._validationName; }
            set { this._validationName = value; }
        }

        // Check to see if ValidationName property is set
        internal bool IsSetValidationName()
        {
            return this._validationName != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationPath. 
        /// <para>
        /// The path within the resource where the validation was applied.
        /// </para>
        /// </summary>
        public string ValidationPath
        {
            get { return this._validationPath; }
            set { this._validationPath = value; }
        }

        // Check to see if ValidationPath property is set
        internal bool IsSetValidationPath()
        {
            return this._validationPath != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationStatus. 
        /// <para>
        /// The status of the validation.
        /// </para>
        /// </summary>
        public ValidationStatus ValidationStatus
        {
            get { return this._validationStatus; }
            set { this._validationStatus = value; }
        }

        // Check to see if ValidationStatus property is set
        internal bool IsSetValidationStatus()
        {
            return this._validationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationStatusReason. 
        /// <para>
        /// Additional information about the validation status.
        /// </para>
        /// </summary>
        public string ValidationStatusReason
        {
            get { return this._validationStatusReason; }
            set { this._validationStatusReason = value; }
        }

        // Check to see if ValidationStatusReason property is set
        internal bool IsSetValidationStatusReason()
        {
            return this._validationStatusReason != null;
        }

    }
}