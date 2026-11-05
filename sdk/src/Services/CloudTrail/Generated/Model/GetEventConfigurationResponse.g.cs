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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// This is the response object from the GetEventConfiguration operation.
    /// </summary>
    public partial class GetEventConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AggregationConfigurations. 
        /// <para>
        /// The list of aggregation configurations that are configured for the trail.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<AggregationConfiguration> AggregationConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<AggregationConfiguration>() : null;

        /// <summary>
        /// Checks to see if the AggregationConfigurations property is set.
        /// </summary>
        internal bool IsSetAggregationConfigurations() => this.AggregationConfigurations != null && (this.AggregationConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContextKeySelectors. 
        /// <para>
        /// The list of context key selectors that are configured for the event data store.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<ContextKeySelector> ContextKeySelectors { get; set; } = AWSConfigs.InitializeCollections ? new List<ContextKeySelector>() : null;

        /// <summary>
        /// Checks to see if the ContextKeySelectors property is set.
        /// </summary>
        internal bool IsSetContextKeySelectors() => this.ContextKeySelectors != null && (this.ContextKeySelectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EventDataStoreArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) or ID suffix of the ARN of the event data store for
        /// which the event configuration settings are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 256)]
        public string EventDataStoreArn { get; set; }

        /// <summary>
        /// Checks to see if the EventDataStoreArn property is set.
        /// </summary>
        internal bool IsSetEventDataStoreArn() => this.EventDataStoreArn != null;

        /// <summary>
        /// Gets and sets the property MaxEventSize. 
        /// <para>
        /// The maximum allowed size for events stored in the specified event data store.
        /// </para>
        /// </summary>
        public MaxEventSize MaxEventSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxEventSize property is set.
        /// </summary>
        internal bool IsSetMaxEventSize() => this.MaxEventSize != null;

        /// <summary>
        /// Gets and sets the property TrailARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trail for which the event configuration settings
        /// are returned.
        /// </para>
        /// </summary>
        public string TrailARN { get; set; }

        /// <summary>
        /// Checks to see if the TrailARN property is set.
        /// </summary>
        internal bool IsSetTrailARN() => this.TrailARN != null;
    }
}
