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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
    /// within a service and environment. Configurations are immutable after creation.
    /// 
    ///  
    /// <para>
    /// For <c>BREAKPOINT</c> type configurations, they expire after 24 hours unless a shorter
    /// expiration is provided. For <c>PROBE</c> type configurations, they persist until explicitly
    /// deleted; an expiration cannot be set for <c>PROBE</c> configurations.
    /// </para>
    ///  
    /// <para>
    /// If a configuration already exists for the same service, environment, signal type,
    /// and location, this operation returns a conflict instead of overwriting it. Use attribute
    /// filters and capture settings to control where the instrumentation runs and which data
    /// is collected.
    /// </para>
    /// </summary>
    public partial class CreateInstrumentationConfigurationRequest : AmazonApplicationSignalsRequest
    {
        private List<Dictionary<string, string>> _attributeFilters = AWSConfigs.InitializeCollections ? new List<Dictionary<string, string>>() : null;
        private CaptureConfiguration _captureConfiguration;
        private string _description;
        private string _environment;
        private DateTime? _expiresAt;
        private InstrumentationType _instrumentationType;
        private Location _location;
        private string _service;
        private DynamicInstrumentationSignalType _signalType;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AttributeFilters. 
        /// <para>
        /// Client-side filters that target specific instances. Each object in the array is AND-matched
        /// on its keys, and multiple objects are OR-matched to decide where to apply the instrumentation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<Dictionary<string, string>> AttributeFilters
        {
            get { return this._attributeFilters; }
            set { this._attributeFilters = value; }
        }

        // Check to see if AttributeFilters property is set
        internal bool IsSetAttributeFilters()
        {
            return this._attributeFilters != null && (this._attributeFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CaptureConfiguration. 
        /// <para>
        /// Specifies what to capture when the instrumentation point is hit. Specify <c>CodeCapture</c>
        /// for code-level capture settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CaptureConfiguration CaptureConfiguration
        {
            get { return this._captureConfiguration; }
            set { this._captureConfiguration = value; }
        }

        // Check to see if CaptureConfiguration property is set
        internal bool IsSetCaptureConfiguration()
        {
            return this._captureConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional short description (up to 50 characters) that explains the purpose of this
        /// instrumentation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment that the service is running in, such as <c>eks:cluster-prod/namespace</c>
        /// or <c>ec2:production</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// For BREAKPOINT: optional, defaults to 24 hours, must be between 5 min and 24 hours.
        /// For PROBE: not supported. PROBE configurations are permanent and persist until explicitly
        /// deleted.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt
        {
            get { return this._expiresAt; }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstrumentationType. 
        /// <para>
        /// Type of instrumentation: BREAKPOINT (temporary) or PROBE (permanent)
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstrumentationType InstrumentationType
        {
            get { return this._instrumentationType; }
            set { this._instrumentationType = value; }
        }

        // Check to see if InstrumentationType property is set
        internal bool IsSetInstrumentationType()
        {
            return this._instrumentationType != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location where instrumentation should be applied. Specify a <c>CodeLocation</c>
        /// for code-level instrumentation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Location Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The name of the service to instrument. This should match the <c>service.name</c> resource
        /// attribute reported by the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property SignalType. 
        /// <para>
        /// The telemetry signal type to emit for this instrumentation. The supported value is
        /// <c>SNAPSHOT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DynamicInstrumentationSignalType SignalType
        {
            get { return this._signalType; }
            set { this._signalType = value; }
        }

        // Check to see if SignalType property is set
        internal bool IsSetSignalType()
        {
            return this._signalType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional list of key-value pairs to associate with the instrumentation configuration.
        /// Tags can help you organize and categorize your resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}