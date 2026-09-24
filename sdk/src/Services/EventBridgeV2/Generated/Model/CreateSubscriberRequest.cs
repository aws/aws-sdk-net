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
    /// Container for the parameters to the CreateSubscriber operation.
    /// Creates a subscriber on an event bus, which delivers matching events to the configured
    /// target. The bus must be ACTIVE. Retries carrying the same ClientToken are idempotent.
    /// </summary>
    public partial class CreateSubscriberRequest : AmazonEventBridgeV2Request
    {
        private BatchConfiguration _batchConfiguration;
        private string _clientToken;
        private string _description;
        private string _eventBusArn;
        private FilterConfiguration _filterConfiguration;
        private InvokeConfiguration _invokeConfiguration;
        private LogConfiguration _logConfiguration;
        private string _name;
        private OnFailureConfiguration _onFailureConfiguration;
        private PointInTimeConfiguration _pointInTimeConfiguration;
        private RetryPolicy _retryPolicy;
        private StartingPosition _startingPosition;
        private SubscriberState _state;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
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
        /// Gets and sets the property ClientToken.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
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
        [AWSProperty(Required=true, Min=1, Max=1011)]
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
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Transformer. 
        /// <para>
        /// Not applicable to universal (aws-sdk) targets, whose input transformation is UniversalTargetParameters.Input;
        /// a Transformer on such a target is rejected.
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