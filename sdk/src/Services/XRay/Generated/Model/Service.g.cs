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

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Information about an application that processed requests, users that made requests,
    /// or downstream services, resources, and applications that an application used.
    /// </summary>
    public partial class Service
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Identifier of the Amazon Web Services account in which the service runs.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property DurationHistogram. 
        /// <para>
        /// A histogram that maps the spread of service durations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HistogramEntry> DurationHistogram { get; set; } = AWSConfigs.InitializeCollections ? new List<HistogramEntry>() : null;

        /// <summary>
        /// Checks to see if the DurationHistogram property is set.
        /// </summary>
        internal bool IsSetDurationHistogram() => this.DurationHistogram != null && (this.DurationHistogram.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Edges. 
        /// <para>
        /// Connections to downstream services.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Edge> Edges { get; set; } = AWSConfigs.InitializeCollections ? new List<Edge>() : null;

        /// <summary>
        /// Checks to see if the Edges property is set.
        /// </summary>
        internal bool IsSetEdges() => this.Edges != null && (this.Edges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the last segment that the service generated.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The canonical name of the service.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        /// A list of names for the service, including the canonical name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Names { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Names property is set.
        /// </summary>
        internal bool IsSetNames() => this.Names != null && (this.Names.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// Identifier for the service. Unique within the service map.
        /// </para>
        /// </summary>
        public int? ReferenceId { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceId property is set.
        /// </summary>
        internal bool IsSetReferenceId() => this.ReferenceId.HasValue;

        /// <summary>
        /// Gets and sets the property ResponseTimeHistogram. 
        /// <para>
        /// A histogram that maps the spread of service response times.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HistogramEntry> ResponseTimeHistogram { get; set; } = AWSConfigs.InitializeCollections ? new List<HistogramEntry>() : null;

        /// <summary>
        /// Checks to see if the ResponseTimeHistogram property is set.
        /// </summary>
        internal bool IsSetResponseTimeHistogram() => this.ResponseTimeHistogram != null && (this.ResponseTimeHistogram.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Root. 
        /// <para>
        /// Indicates that the service was the first service to process a request.
        /// </para>
        /// </summary>
        public bool? Root { get; set; }

        /// <summary>
        /// Checks to see if the Root property is set.
        /// </summary>
        internal bool IsSetRoot() => this.Root.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the first segment that the service generated.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The service's state.
        /// </para>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SummaryStatistics. 
        /// <para>
        /// Aggregated statistics for the service.
        /// </para>
        /// </summary>
        public ServiceStatistics SummaryStatistics { get; set; }

        /// <summary>
        /// Checks to see if the SummaryStatistics property is set.
        /// </summary>
        internal bool IsSetSummaryStatistics() => this.SummaryStatistics != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of service.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Web Services Resource - The type of an Amazon Web Services resource. For example,
        /// <c>AWS::EC2::Instance</c> for an application running on Amazon EC2 or <c>AWS::DynamoDB::Table</c>
        /// for an Amazon DynamoDB table that the application used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Service - The type of an Amazon Web Services service. For example,
        /// <c>AWS::DynamoDB</c> for downstream calls to Amazon DynamoDB that didn't target a
        /// specific table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>client</c> - Represents the clients that sent requests to a root service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>remote</c> - A downstream service of indeterminate type.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
