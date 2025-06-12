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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Specifies the circumstances under which the event should trigger the destination.
    /// </summary>
    public partial class EventTriggerCondition
    {
        private List<EventTriggerDimension> _eventTriggerDimensions = AWSConfigs.InitializeCollections ? new List<EventTriggerDimension>() : null;
        private EventTriggerLogicalOperator _logicalOperator;

        /// <summary>
        /// Gets and sets the property EventTriggerDimensions. 
        /// <para>
        /// A list of dimensions to be evaluated for the event.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<EventTriggerDimension> EventTriggerDimensions
        {
            get { return this._eventTriggerDimensions; }
            set { this._eventTriggerDimensions = value; }
        }

        // Check to see if EventTriggerDimensions property is set
        internal bool IsSetEventTriggerDimensions()
        {
            return this._eventTriggerDimensions != null && (this._eventTriggerDimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogicalOperator. 
        /// <para>
        /// The operator used to combine multiple dimensions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventTriggerLogicalOperator LogicalOperator
        {
            get { return this._logicalOperator; }
            set { this._logicalOperator = value; }
        }

        // Check to see if LogicalOperator property is set
        internal bool IsSetLogicalOperator()
        {
            return this._logicalOperator != null;
        }

    }
}