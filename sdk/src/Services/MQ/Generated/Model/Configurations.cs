/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MQ.Model
{
    /// <summary>
    /// Broker configuration information
    /// </summary>
    public partial class Configurations
    {
        private ConfigurationId _current;
        private List<ConfigurationId> _history = new List<ConfigurationId>();
        private ConfigurationId _pending;

        /// <summary>
        /// Gets and sets the property Current. The current configuration of the broker.
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
        /// Gets and sets the property History. The history of configurations applied to the broker.
        /// </summary>
        public List<ConfigurationId> History
        {
            get { return this._history; }
            set { this._history = value; }
        }

        // Check to see if History property is set
        internal bool IsSetHistory()
        {
            return this._history != null && this._history.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Pending. The pending configuration of the broker.
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