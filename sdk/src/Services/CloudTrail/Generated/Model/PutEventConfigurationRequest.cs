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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
    /// Container for the parameters to the PutEventConfiguration operation.
    /// Updates the event configuration settings for the specified event data store. You can
    /// update the maximum event size and context key selectors.
    /// </summary>
    public partial class PutEventConfigurationRequest : AmazonCloudTrailRequest
    {
        private List<ContextKeySelector> _contextKeySelectors = AWSConfigs.InitializeCollections ? new List<ContextKeySelector>() : null;
        private string _eventDataStore;
        private MaxEventSize _maxEventSize;

        /// <summary>
        /// Gets and sets the property ContextKeySelectors. 
        /// <para>
        /// A list of context key selectors that will be included to provide enriched event data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Max=2)]
        public List<ContextKeySelector> ContextKeySelectors
        {
            get { return this._contextKeySelectors; }
            set { this._contextKeySelectors = value; }
        }

        // Check to see if ContextKeySelectors property is set
        internal bool IsSetContextKeySelectors()
        {
            return this._contextKeySelectors != null && (this._contextKeySelectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EventDataStore. 
        /// <para>
        /// The Amazon Resource Name (ARN) or ID suffix of the ARN of the event data store for
        /// which you want to update event configuration settings.
        /// </para>
        /// </summary>
        public string EventDataStore
        {
            get { return this._eventDataStore; }
            set { this._eventDataStore = value; }
        }

        // Check to see if EventDataStore property is set
        internal bool IsSetEventDataStore()
        {
            return this._eventDataStore != null;
        }

        /// <summary>
        /// Gets and sets the property MaxEventSize. 
        /// <para>
        /// The maximum allowed size for events to be stored in the specified event data store.
        /// If you are using context key selectors, MaxEventSize must be set to Large.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MaxEventSize MaxEventSize
        {
            get { return this._maxEventSize; }
            set { this._maxEventSize = value; }
        }

        // Check to see if MaxEventSize property is set
        internal bool IsSetMaxEventSize()
        {
            return this._maxEventSize != null;
        }

    }
}