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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// The configuration details of the solution update.
    /// </summary>
    public partial class SolutionUpdateConfig
    {
        private AutoTrainingConfig _autoTrainingConfig;
        private EventsConfig _eventsConfig;

        /// <summary>
        /// Gets and sets the property AutoTrainingConfig.
        /// </summary>
        public AutoTrainingConfig AutoTrainingConfig
        {
            get { return this._autoTrainingConfig; }
            set { this._autoTrainingConfig = value; }
        }

        // Check to see if AutoTrainingConfig property is set
        internal bool IsSetAutoTrainingConfig()
        {
            return this._autoTrainingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EventsConfig. 
        /// <para>
        /// Describes the configuration of an event, which includes a list of event parameters.
        /// You can specify up to 10 event parameters. Events are used in solution creation.
        /// </para>
        /// </summary>
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

    }
}