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
    /// Container for the parameters to the GetEventConfiguration operation.
    /// Retrieves the current event configuration settings for the specified event data store
    /// or trail. The response includes maximum event size configuration, the context key
    /// selectors configured for the event data store, and any aggregation settings configured
    /// for the trail.
    /// </summary>
    public partial class GetEventConfigurationRequest : AmazonCloudTrailRequest
    {
        private string _eventDataStore;
        private string _trailName;

        /// <summary>
        /// Gets and sets the property EventDataStore. 
        /// <para>
        /// The Amazon Resource Name (ARN) or ID suffix of the ARN of the event data store for
        /// which you want to retrieve event configuration settings.
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
        /// Gets and sets the property TrailName. 
        /// <para>
        /// The name of the trail for which you want to retrieve event configuration settings.
        /// </para>
        /// </summary>
        public string TrailName
        {
            get { return this._trailName; }
            set { this._trailName = value; }
        }

        // Check to see if TrailName property is set
        internal bool IsSetTrailName()
        {
            return this._trailName != null;
        }

    }
}