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
    /// Container for the parameters to the CreateInstrumentationConfiguration operation.
    /// Creates a dynamic instrumentation configuration for a specific code or endpoint location
    /// within a service and environment. Configurations are immutable after creation. <para>
    /// For <c>BREAKPOINT</c> type configurations, they expire after 24 hours unless a shorter
    /// expiration is provided. For <c>PROBE</c> type configurations, they persist until explicitly
    /// deleted; an expiration cannot be set for <c>PROBE</c> configurations. </para> <para>
    /// If a configuration already exists for the same service, environment, signal type,
    /// and location, this operation returns a conflict instead of overwriting it. Use attribute
    /// filters and capture settings to control where the instrumentation runs and which data
    /// is collected. </para>
    /// </summary>
    public partial class CreateInstrumentationConfigurationRequest : AmazonApplicationSignalsRequest
    {
        /// <summary>
        /// Gets and sets the property AttributeFilters. 
        /// <para>
        /// Client-side filters that target specific instances. Each object in the array is AND-matched
        /// on its keys, and multiple objects are OR-matched to decide where to apply the instrumentation.
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
        /// Specifies what to capture when the instrumentation point is hit. Specify <c>CodeCapture</c>
        /// for code-level capture settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CaptureConfiguration CaptureConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CaptureConfiguration property is set.
        /// </summary>
        internal bool IsSetCaptureConfiguration() => this.CaptureConfiguration != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional short description (up to 50 characters) that explains the purpose of this
        /// instrumentation.
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
        /// The environment that the service is running in, such as <c>eks:cluster-prod/namespace</c>
        /// or <c>ec2:production</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Environment { get; set; }

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null;

        /// <summary>
        /// Gets and sets the property ExpiresAt. For BREAKPOINT: optional, defaults to 24 hours,
        /// must be between 5 min and 24 hours. For PROBE: not supported. PROBE configurations
        /// are permanent and persist until explicitly deleted.
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property InstrumentationType. Type of instrumentation: BREAKPOINT
        /// (temporary) or PROBE (permanent)
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
        /// The location where instrumentation should be applied. Specify a <c>CodeLocation</c>
        /// for code-level instrumentation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Location Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The name of the service to instrument. This should match the <c>service.name</c> resource
        /// attribute reported by the application.
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
        /// The telemetry signal type to emit for this instrumentation. The supported value is
        /// <c>SNAPSHOT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DynamicInstrumentationSignalType SignalType { get; set; }

        /// <summary>
        /// Checks to see if the SignalType property is set.
        /// </summary>
        internal bool IsSetSignalType() => this.SignalType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional list of key-value pairs to associate with the instrumentation configuration.
        /// Tags can help you organize and categorize your resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
