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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSubscriber operation. Creates a subscriber
    /// on an event bus, which delivers matching events to the configured target. The bus
    /// must be ACTIVE. Retries carrying the same ClientToken are idempotent.
    /// </summary>
    public partial class CreateSubscriberRequest : AmazonEventBridgeV2Request
    {
        /// <summary>
        /// Gets and sets the property BatchConfiguration.
        /// </summary>
        public BatchConfiguration BatchConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BatchConfiguration property is set.
        /// </summary>
        internal bool IsSetBatchConfiguration() => this.BatchConfiguration != null;

        /// <summary>
        /// Gets and sets the property ClientToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventBusArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string EventBusArn { get; set; }

        /// <summary>
        /// Checks to see if the EventBusArn property is set.
        /// </summary>
        internal bool IsSetEventBusArn() => this.EventBusArn != null;

        /// <summary>
        /// Gets and sets the property FilterConfiguration.
        /// </summary>
        public FilterConfiguration FilterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FilterConfiguration property is set.
        /// </summary>
        internal bool IsSetFilterConfiguration() => this.FilterConfiguration != null;

        /// <summary>
        /// Gets and sets the property InvokeConfiguration.
        /// </summary>
        [AWSProperty(Required = true)]
        public InvokeConfiguration InvokeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InvokeConfiguration property is set.
        /// </summary>
        internal bool IsSetInvokeConfiguration() => this.InvokeConfiguration != null;

        /// <summary>
        /// Gets and sets the property LogConfiguration.
        /// </summary>
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogConfiguration property is set.
        /// </summary>
        internal bool IsSetLogConfiguration() => this.LogConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OnFailureConfiguration.
        /// </summary>
        public OnFailureConfiguration OnFailureConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OnFailureConfiguration property is set.
        /// </summary>
        internal bool IsSetOnFailureConfiguration() => this.OnFailureConfiguration != null;

        /// <summary>
        /// Gets and sets the property PointInTimeConfiguration.
        /// </summary>
        public PointInTimeConfiguration PointInTimeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PointInTimeConfiguration property is set.
        /// </summary>
        internal bool IsSetPointInTimeConfiguration() => this.PointInTimeConfiguration != null;

        /// <summary>
        /// Gets and sets the property RetryPolicy.
        /// </summary>
        public RetryPolicy RetryPolicy { get; set; }

        /// <summary>
        /// Checks to see if the RetryPolicy property is set.
        /// </summary>
        internal bool IsSetRetryPolicy() => this.RetryPolicy != null;

        /// <summary>
        /// Gets and sets the property StartingPosition.
        /// </summary>
        public StartingPosition StartingPosition { get; set; }

        /// <summary>
        /// Checks to see if the StartingPosition property is set.
        /// </summary>
        internal bool IsSetStartingPosition() => this.StartingPosition != null;

        /// <summary>
        /// Gets and sets the property State.
        /// </summary>
        public SubscriberState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Transformer. Not applicable to universal (aws-sdk) targets,
        /// whose input transformation is UniversalTargetParameters.Input; a Transformer on such
        /// a target is rejected.
        /// </summary>
        public Transformer Transformer { get; set; }

        /// <summary>
        /// Checks to see if the Transformer property is set.
        /// </summary>
        internal bool IsSetTransformer() => this.Transformer != null;

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        public OrderingType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
