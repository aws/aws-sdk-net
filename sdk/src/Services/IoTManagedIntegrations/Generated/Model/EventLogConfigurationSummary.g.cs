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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// List of event log configurations.
    /// </summary>
    public partial class EventLogConfigurationSummary
    {
        /// <summary>
        /// Gets and sets the property EventLogLevel. 
        /// <para>
        /// The logging level for the event log configuration.
        /// </para>
        /// </summary>
        public LogLevel EventLogLevel { get; set; }

        /// <summary>
        /// Checks to see if the EventLogLevel property is set.
        /// </summary>
        internal bool IsSetEventLogLevel() => this.EventLogLevel != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the event log configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier of the resource for the event log configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource for the event log configuration.
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
