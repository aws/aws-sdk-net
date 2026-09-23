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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// The full instrumentation configuration, including the instrumentation type, service,
    /// environment, signal type, location details, stable location hash, capture settings,
    /// filters, expiration, creation time, and ARN.
    /// </summary>
    public partial class InstrumentationConfiguration
    {
        /// <summary>
        /// Gets and sets the property ARN. ARN for the instrumentation configuration
        /// </summary>
        [AWSProperty(Required = true)]
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property AttributeFilters. 
        /// <para>
        /// Client-side filters that determine which instances apply this instrumentation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<Dictionary<string, string>> AttributeFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<Dictionary<string, string>>() : null;

        /// <summary>
        /// Checks to see if the AttributeFilters property is set.
        /// </summary>
        internal bool IsSetAttributeFilters() => this.AttributeFilters != null && (this.AttributeFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CaptureConfiguration. 
        /// <para>
        /// The capture settings for this instrumentation configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CaptureConfiguration CaptureConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CaptureConfiguration property is set.
        /// </summary>
        internal bool IsSetCaptureConfiguration() => this.CaptureConfiguration != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when this instrumentation configuration was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional short description of the instrumentation configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment where the service is running.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Environment { get; set; }

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The timestamp when this configuration expires.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property InstrumentationType. 
        /// <para>
        /// The type of instrumentation for this configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstrumentationType InstrumentationType { get; set; }

        /// <summary>
        /// Checks to see if the InstrumentationType property is set.
        /// </summary>
        internal bool IsSetInstrumentationType() => this.InstrumentationType != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location where this instrumentation is applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Location Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property LocationHash. 
        /// <para>
        /// The stable hash derived from the location that uniquely identifies this instrumentation
        /// point within the service and environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 16, Max = 16)]
        public string LocationHash { get; set; }

        /// <summary>
        /// Checks to see if the LocationHash property is set.
        /// </summary>
        internal bool IsSetLocationHash() => this.LocationHash != null;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The service that this instrumentation configuration targets.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property SignalType. 
        /// <para>
        /// The telemetry signal type for this instrumentation configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DynamicInstrumentationSignalType SignalType { get; set; }

        /// <summary>
        /// Checks to see if the SignalType property is set.
        /// </summary>
        internal bool IsSetSignalType() => this.SignalType != null;
    }
}
