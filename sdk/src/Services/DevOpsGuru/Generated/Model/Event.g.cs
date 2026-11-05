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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// An Amazon Web Services resource event. Amazon Web Services resource events and metrics
    /// are analyzed by DevOps Guru to find anomalous behavior and provide recommendations
    /// to improve your operational solutions.
    /// </summary>
    public partial class Event
    {
        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        ///  The source, <c>AWS_CLOUD_TRAIL</c> or <c>AWS_CODE_DEPLOY</c>, where DevOps Guru analysis
        /// found the event. 
        /// </para>
        /// </summary>
        public EventDataSource DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property EventClass. 
        /// <para>
        ///  The class of the event. The class specifies what the event is related to, such as
        /// an infrastructure change, a deployment, or a schema change. 
        /// </para>
        /// </summary>
        public EventClass EventClass { get; set; }

        /// <summary>
        /// Checks to see if the EventClass property is set.
        /// </summary>
        internal bool IsSetEventClass() => this.EventClass != null;

        /// <summary>
        /// Gets and sets the property EventSource. 
        /// <para>
        ///  The Amazon Web Services source that emitted the event. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 50)]
        public string EventSource { get; set; }

        /// <summary>
        /// Checks to see if the EventSource property is set.
        /// </summary>
        internal bool IsSetEventSource() => this.EventSource != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The ID of the event. 
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the event. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceCollection.
        /// </summary>
        public ResourceCollection ResourceCollection { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCollection property is set.
        /// </summary>
        internal bool IsSetResourceCollection() => this.ResourceCollection != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        ///  An <c>EventResource</c> object that contains information about the resource that
        /// emitted the event. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EventResource> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<EventResource>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        ///  A <c>Timestamp</c> that specifies the time the event occurred. 
        /// </para>
        /// </summary>
        public DateTime? Time { get; set; }

        /// <summary>
        /// Checks to see if the Time property is set.
        /// </summary>
        internal bool IsSetTime() => this.Time.HasValue;
    }
}
