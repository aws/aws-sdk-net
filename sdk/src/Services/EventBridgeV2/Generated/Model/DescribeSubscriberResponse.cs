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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// This is the response object from the DescribeSubscriber operation.
    /// </summary>
    public partial class DescribeSubscriberResponse : AmazonWebServiceResponse
    {
        private BatchConfiguration _batchConfiguration;
        private DateTime? _creationTime;
        private string _description;
        private string _eventBusArn;
        private FilterConfiguration _filterConfiguration;
        private InvokeConfiguration _invokeConfiguration;
        private DateTime? _lastModifiedTime;
        private LogConfiguration _logConfiguration;
        private string _name;
        private OnFailureConfiguration _onFailureConfiguration;
        private PointInTimeConfiguration _pointInTimeConfiguration;
        private RetryPolicy _retryPolicy;
        private bool? _revoked;
        private StartingPosition _startingPosition;
        private SubscriberState _state;
        private string _subscriberArn;
        private Transformer _transformer;
        private OrderingType _type;

        /// <summary>
        /// Gets and sets the property BatchConfiguration.
        /// </summary>
        public BatchConfiguration BatchConfiguration
        {
            get { return this._batchConfiguration; }
            set { this._batchConfiguration = value; }
        }

        // Check to see if BatchConfiguration property is set
        internal bool IsSetBatchConfiguration()
        {
            return this._batchConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the subscriber was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EventBusArn.
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string EventBusArn
        {
            get { return this._eventBusArn; }
            set { this._eventBusArn = value; }
        }

        // Check to see if EventBusArn property is set
        internal bool IsSetEventBusArn()
        {
            return this._eventBusArn != null;
        }

        /// <summary>
        /// Gets and sets the property FilterConfiguration.
        /// </summary>
        public FilterConfiguration FilterConfiguration
        {
            get { return this._filterConfiguration; }
            set { this._filterConfiguration = value; }
        }

        // Check to see if FilterConfiguration property is set
        internal bool IsSetFilterConfiguration()
        {
            return this._filterConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property InvokeConfiguration.
        /// </summary>
        public InvokeConfiguration InvokeConfiguration
        {
            get { return this._invokeConfiguration; }
            set { this._invokeConfiguration = value; }
        }

        // Check to see if InvokeConfiguration property is set
        internal bool IsSetInvokeConfiguration()
        {
            return this._invokeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time the subscriber was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogConfiguration.
        /// </summary>
        public LogConfiguration LogConfiguration
        {
            get { return this._logConfiguration; }
            set { this._logConfiguration = value; }
        }

        // Check to see if LogConfiguration property is set
        internal bool IsSetLogConfiguration()
        {
            return this._logConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OnFailureConfiguration.
        /// </summary>
        public OnFailureConfiguration OnFailureConfiguration
        {
            get { return this._onFailureConfiguration; }
            set { this._onFailureConfiguration = value; }
        }

        // Check to see if OnFailureConfiguration property is set
        internal bool IsSetOnFailureConfiguration()
        {
            return this._onFailureConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PointInTimeConfiguration.
        /// </summary>
        public PointInTimeConfiguration PointInTimeConfiguration
        {
            get { return this._pointInTimeConfiguration; }
            set { this._pointInTimeConfiguration = value; }
        }

        // Check to see if PointInTimeConfiguration property is set
        internal bool IsSetPointInTimeConfiguration()
        {
            return this._pointInTimeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RetryPolicy.
        /// </summary>
        public RetryPolicy RetryPolicy
        {
            get { return this._retryPolicy; }
            set { this._retryPolicy = value; }
        }

        // Check to see if RetryPolicy property is set
        internal bool IsSetRetryPolicy()
        {
            return this._retryPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Revoked. 
        /// <para>
        /// True when the bus owner has revoked this subscriber. Present only when true, so an
        /// absent member means the subscriber is not revoked. Revocation is terminal: it never
        /// returns to false. Mutating operations on a revoked subscriber fail with InvalidStateException,
        /// except DeleteSubscriber, which stays available so a revoked subscriber can still be
        /// cleaned up.
        /// </para>
        /// </summary>
        public bool? Revoked
        {
            get { return this._revoked; }
            set { this._revoked = value; }
        }

        // Check to see if Revoked property is set
        internal bool IsSetRevoked()
        {
            return this._revoked.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartingPosition.
        /// </summary>
        public StartingPosition StartingPosition
        {
            get { return this._startingPosition; }
            set { this._startingPosition = value; }
        }

        // Check to see if StartingPosition property is set
        internal bool IsSetStartingPosition()
        {
            return this._startingPosition != null;
        }

        /// <summary>
        /// Gets and sets the property State.
        /// </summary>
        public SubscriberState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriberArn.
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string SubscriberArn
        {
            get { return this._subscriberArn; }
            set { this._subscriberArn = value; }
        }

        // Check to see if SubscriberArn property is set
        internal bool IsSetSubscriberArn()
        {
            return this._subscriberArn != null;
        }

        /// <summary>
        /// Gets and sets the property Transformer. 
        /// <para>
        /// Absent for universal (aws-sdk) targets, whose input transformation is UniversalTargetParameters.Input.
        /// </para>
        /// </summary>
        public Transformer Transformer
        {
            get { return this._transformer; }
            set { this._transformer = value; }
        }

        // Check to see if Transformer property is set
        internal bool IsSetTransformer()
        {
            return this._transformer != null;
        }

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        public OrderingType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}