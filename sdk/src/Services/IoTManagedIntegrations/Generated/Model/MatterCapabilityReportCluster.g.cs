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
    /// Capability used in Matter capability report.
    /// </summary>
    public partial class MatterCapabilityReportCluster
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes of the Amazon Web Services Matter capability report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<MatterCapabilityReportAttribute> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new List<MatterCapabilityReportAttribute>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Commands. 
        /// <para>
        /// The commands used with the Amazon Web Services Matter capability report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> Commands { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Commands property is set.
        /// </summary>
        internal bool IsSetCommands() => this.Commands != null && (this.Commands.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The events used with the Amazon Web Services Matter capability report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> Events { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Events property is set.
        /// </summary>
        internal bool IsSetEvents() => this.Events != null && (this.Events.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FabricIndex. 
        /// <para>
        /// The fabric index for the Amazon Web Services Matter capability report.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public int? FabricIndex { get; set; }

        /// <summary>
        /// Checks to see if the FabricIndex property is set.
        /// </summary>
        internal bool IsSetFabricIndex() => this.FabricIndex.HasValue;

        /// <summary>
        /// Gets and sets the property FeatureMap. 
        /// <para>
        /// 32 bit-map used to indicate which features a cluster supports.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4294967295)]
        public long? FeatureMap { get; set; }

        /// <summary>
        /// Checks to see if the FeatureMap property is set.
        /// </summary>
        internal bool IsSetFeatureMap() => this.FeatureMap.HasValue;

        /// <summary>
        /// Gets and sets the property GeneratedCommands. 
        /// <para>
        /// Matter clusters used in capability report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> GeneratedCommands { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GeneratedCommands property is set.
        /// </summary>
        internal bool IsSetGeneratedCommands() => this.GeneratedCommands != null && (this.GeneratedCommands.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The id of the Amazon Web Services Matter capability report cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 24)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The capability name used in the Amazon Web Services Matter capability report.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PublicId. 
        /// <para>
        /// The id of the schema version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 128)]
        public string PublicId { get; set; }

        /// <summary>
        /// Checks to see if the PublicId property is set.
        /// </summary>
        internal bool IsSetPublicId() => this.PublicId != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The id of the revision for the Amazon Web Services Matter capability report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public int? Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision.HasValue;

        /// <summary>
        /// Gets and sets the property SpecVersion. 
        /// <para>
        /// The spec version used in the Amazon Web Services Matter capability report.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SpecVersion { get; set; }

        /// <summary>
        /// Checks to see if the SpecVersion property is set.
        /// </summary>
        internal bool IsSetSpecVersion() => this.SpecVersion != null;
    }
}
