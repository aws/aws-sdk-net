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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// A model representing the state of a resource within an account according to telemetry
    /// config.
    /// </summary>
    public partial class TelemetryConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccountIdentifier. 
        /// <para>
        ///  The account ID which contains the resource managed in telemetry configuration. An
        /// example of a valid account ID is <c>012345678901</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the AccountIdentifier property is set.
        /// </summary>
        internal bool IsSetAccountIdentifier() => this.AccountIdentifier != null;

        /// <summary>
        /// Gets and sets the property LastUpdateTimeStamp. 
        /// <para>
        ///  The timestamp of the last change to the telemetry configuration for the resource.
        /// For example, <c>1728679196318</c>. 
        /// </para>
        /// </summary>
        public long? LastUpdateTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTimeStamp property is set.
        /// </summary>
        internal bool IsSetLastUpdateTimeStamp() => this.LastUpdateTimeStamp.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        ///  The identifier of the resource, for example for Amazon VPC, it would be <c>vpc-1a2b3c4d5e6f1a2b3</c>.
        /// 
        /// </para>
        /// </summary>
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        ///  Tags associated with the resource, for example <c>{ Name: "ExampleInstance", Environment:
        /// "Development" }</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        ///  The type of resource, for example <c>Amazon Web Services::EC2::Instance</c>, or <c>Amazon
        /// Web Services::EKS::Cluster</c>, etc. 
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property TelemetryConfigurationState. 
        /// <para>
        ///  The configuration state for the resource, for example <c>{ Logs: NotApplicable; Metrics:
        /// Enabled; Traces: NotApplicable; }</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> TelemetryConfigurationState { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the TelemetryConfigurationState property is set.
        /// </summary>
        internal bool IsSetTelemetryConfigurationState() => this.TelemetryConfigurationState != null && (this.TelemetryConfigurationState.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TelemetrySourceType.
        /// </summary>
        public TelemetrySourceType TelemetrySourceType { get; set; }

        /// <summary>
        /// Checks to see if the TelemetrySourceType property is set.
        /// </summary>
        internal bool IsSetTelemetrySourceType() => this.TelemetrySourceType != null;
    }
}
