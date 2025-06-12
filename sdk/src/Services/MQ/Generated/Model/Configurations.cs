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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
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
namespace Amazon.MQ.Model
{
    /// <summary>
    /// Broker configuration information
    /// </summary>
    public partial class Configurations
    {
        private ConfigurationId _current;
        private List<ConfigurationId> _history = AWSConfigs.InitializeCollections ? new List<ConfigurationId>() : null;
        private ConfigurationId _pending;

        /// <summary>
        /// Gets and sets the property Current. 
        /// <para>
        /// The broker's current configuration.
        /// </para>
        /// </summary>
        public ConfigurationId Current
        {
            get { return this._current; }
            set { this._current = value; }
        }

        // Check to see if Current property is set
        internal bool IsSetCurrent()
        {
            return this._current != null;
        }

        /// <summary>
        /// Gets and sets the property History. 
        /// <para>
        /// The history of configurations applied to the broker.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConfigurationId> History
        {
            get { return this._history; }
            set { this._history = value; }
        }

        // Check to see if History property is set
        internal bool IsSetHistory()
        {
            return this._history != null && (this._history.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Pending. 
        /// <para>
        /// The broker's pending configuration.
        /// </para>
        /// </summary>
        public ConfigurationId Pending
        {
            get { return this._pending; }
            set { this._pending = value; }
        }

        // Check to see if Pending property is set
        internal bool IsSetPending()
        {
            return this._pending != null;
        }

    }
}