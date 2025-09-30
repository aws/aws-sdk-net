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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// A structure that contains information about the current state of a service, including
    /// its latest change events such as deployments and other state-changing activities.
    /// </summary>
    public partial class ServiceState
    {
        private List<AttributeFilter> _attributeFilters = AWSConfigs.InitializeCollections ? new List<AttributeFilter>() : null;
        private List<ChangeEvent> _latestChangeEvents = AWSConfigs.InitializeCollections ? new List<ChangeEvent>() : null;
        private Dictionary<string, string> _service = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AttributeFilters. 
        /// <para>
        /// The attribute filters that were applied when retrieving this service state information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<AttributeFilter> AttributeFilters
        {
            get { return this._attributeFilters; }
            set { this._attributeFilters = value; }
        }

        // Check to see if AttributeFilters property is set
        internal bool IsSetAttributeFilters()
        {
            return this._attributeFilters != null && (this._attributeFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LatestChangeEvents. 
        /// <para>
        /// An array containing the most recent change events for this service, such as deployments,
        /// with information about when they occurred and who initiated them.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<ChangeEvent> LatestChangeEvents
        {
            get { return this._latestChangeEvents; }
            set { this._latestChangeEvents = value; }
        }

        // Check to see if LatestChangeEvents property is set
        internal bool IsSetLatestChangeEvents()
        {
            return this._latestChangeEvents != null && (this._latestChangeEvents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The key attributes that identify this service, including Type, Name, and Environment
        /// information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public Dictionary<string, string> Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null && (this._service.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}