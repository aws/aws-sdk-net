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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEventSourcesConfig operation.
    /// Enables or disables integration with a service that can be integrated with DevOps
    /// Guru. The one service that can be integrated with DevOps Guru is Amazon CodeGuru Profiler,
    /// which can produce proactive recommendations which can be stored and viewed in DevOps
    /// Guru.
    /// </summary>
    public partial class UpdateEventSourcesConfigRequest : AmazonDevOpsGuruRequest
    {
        private EventSourcesConfig _eventSources;

        /// <summary>
        /// Gets and sets the property EventSources. 
        /// <para>
        /// Configuration information about the integration of DevOps Guru as the Consumer via
        /// EventBridge with another AWS Service.
        /// </para>
        /// </summary>
        public EventSourcesConfig EventSources
        {
            get { return this._eventSources; }
            set { this._eventSources = value; }
        }

        // Check to see if EventSources property is set
        internal bool IsSetEventSources()
        {
            return this._eventSources != null;
        }

    }
}