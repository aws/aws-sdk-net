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
    /// This is the response object from the CreateSubscriber operation.
    /// </summary>
    public partial class CreateSubscriberResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _eventBusArn;
        private string _name;
        private PointInTimeConfiguration _pointInTimeConfiguration;
        private StartingPosition _startingPosition;
        private SubscriberState _state;
        private string _subscriberArn;
        private OrderingType _type;

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