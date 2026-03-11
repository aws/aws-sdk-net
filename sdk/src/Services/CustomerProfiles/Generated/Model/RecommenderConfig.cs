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
    /// Configuration settings that define the behavior and parameters of a recommender.
    /// </summary>
    public partial class RecommenderConfig
    {
        private EventsConfig _eventsConfig;
        private int? _trainingFrequency;

        /// <summary>
        /// Gets and sets the property EventsConfig. 
        /// <para>
        /// Configuration settings for how the recommender processes and uses events.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventsConfig EventsConfig
        {
            get { return this._eventsConfig; }
            set { this._eventsConfig = value; }
        }

        // Check to see if EventsConfig property is set
        internal bool IsSetEventsConfig()
        {
            return this._eventsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingFrequency. 
        /// <para>
        /// How often the recommender should retrain its model with new data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=7)]
        public int? TrainingFrequency
        {
            get { return this._trainingFrequency; }
            set { this._trainingFrequency = value; }
        }

        // Check to see if TrainingFrequency property is set
        internal bool IsSetTrainingFrequency()
        {
            return this._trainingFrequency.HasValue; 
        }

    }
}