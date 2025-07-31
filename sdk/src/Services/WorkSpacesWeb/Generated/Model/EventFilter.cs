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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// The filter that specifies the events to monitor.
    /// </summary>
    public partial class EventFilter
    {
        private Unit _all;
        private List<string> _include = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property All. 
        /// <para>
        /// The filter that monitors all of the available events, including any new events emitted
        /// in the future.
        /// </para>
        /// </summary>
        public Unit All
        {
            get { return this._all; }
            set { this._all = value; }
        }

        // Check to see if All property is set
        internal bool IsSetAll()
        {
            return this._all != null;
        }

        /// <summary>
        /// Gets and sets the property Include. 
        /// <para>
        /// The filter that monitors only the listed set of events. New events are not auto-monitored.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> Include
        {
            get { return this._include; }
            set { this._include = value; }
        }

        // Check to see if Include property is set
        internal bool IsSetInclude()
        {
            return this._include != null && (this._include.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}