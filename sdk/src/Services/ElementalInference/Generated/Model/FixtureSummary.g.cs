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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// Contains information about one fixture. It is used in the SearchFixtures response.
    /// 
    ///  
    /// <para>
    /// Elemental Inference relays the information in this structure from the data source,
    /// so that you can identify the fixture that matches your source media. 
    /// </para>
    /// </summary>
    public partial class FixtureSummary
    {
        /// <summary>
        /// Gets and sets the property Competitors. 
        /// <para>
        /// An array of the competitors (the teams or individuals) in the fixture.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 30)]
        public List<Competitor> Competitors { get; set; } = AWSConfigs.InitializeCollections ? new List<Competitor>() : null;

        /// <summary>
        /// Checks to see if the Competitors property is set.
        /// </summary>
        internal bool IsSetCompetitors() => this.Competitors != null && (this.Competitors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FixtureGroup. 
        /// <para>
        /// The group that the fixture belongs to, such as the competition, league, or tournament.
        /// The data source doesn't provide this information for every fixture. 
        /// </para>
        /// </summary>
        public string FixtureGroup { get; set; }

        /// <summary>
        /// Checks to see if the FixtureGroup property is set.
        /// </summary>
        internal bool IsSetFixtureGroup() => this.FixtureGroup != null;

        /// <summary>
        /// Gets and sets the property FixtureId. 
        /// <para>
        /// The ID of the fixture. Specify this ID in the clipping output of a feed, to identify
        /// the fixture whose event data you want Elemental Inference to map onto the clipping
        /// metadata. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string FixtureId { get; set; }

        /// <summary>
        /// Checks to see if the FixtureId property is set.
        /// </summary>
        internal bool IsSetFixtureId() => this.FixtureId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the fixture, as provided by the data source. For example, the names of
        /// the two competing teams. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ScheduledStart. 
        /// <para>
        /// The scheduled start time of the fixture, as provided by the data source. The actual
        /// start time might differ. 
        /// </para>
        /// </summary>
        public DateTime? ScheduledStart { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledStart property is set.
        /// </summary>
        internal bool IsSetScheduledStart() => this.ScheduledStart.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the fixture in its lifecycle, as provided by the data source. For example,
        /// Scheduled or Completed. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
