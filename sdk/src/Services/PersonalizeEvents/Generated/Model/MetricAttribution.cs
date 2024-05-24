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
 * Do not modify this file. This file is generated from the personalize-events-2018-03-22.normal.json service model.
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
namespace Amazon.PersonalizeEvents.Model
{
    /// <summary>
    /// Contains information about a metric attribution associated with an event. For more
    /// information about metric attributions, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/measuring-recommendation-impact.html">Measuring
    /// impact of recommendations</a>.
    /// </summary>
    public partial class MetricAttribution
    {
        private string _eventAttributionSource;

        /// <summary>
        /// Gets and sets the property EventAttributionSource. 
        /// <para>
        /// The source of the event, such as a third party.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string EventAttributionSource
        {
            get { return this._eventAttributionSource; }
            set { this._eventAttributionSource = value; }
        }

        // Check to see if EventAttributionSource property is set
        internal bool IsSetEventAttributionSource()
        {
            return this._eventAttributionSource != null;
        }

    }
}