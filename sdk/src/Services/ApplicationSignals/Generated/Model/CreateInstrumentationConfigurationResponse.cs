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
    /// This is the response object from the CreateInstrumentationConfiguration operation.
    /// </summary>
    public partial class CreateInstrumentationConfigurationResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private List<Dictionary<string, string>> _attributeFilters = AWSConfigs.InitializeCollections ? new List<Dictionary<string, string>>() : null;
        private CaptureConfiguration _captureConfiguration;
        private DateTime? _createdAt;
        private string _description;
        private string _environment;
        private DateTime? _expiresAt;
        private InstrumentationType _instrumentationType;
        private Location _location;
        private string _locationHash;
        private string _service;
        private DynamicInstrumentationSignalType _signalType;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// ARN for the created instrumentation configuration
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeFilters. 
        /// <para>
        /// The attribute filters returned with the configuration so SDKs can perform client-side
        /// targeting.
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
        /// The capture settings that were stored for this instrumentation configuration.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The server-generated creation timestamp for this instrumentation configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The optional description that was stored with the instrumentation configuration.
        /// </para>
        /// </summary>
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
        /// The environment for the instrumentation configuration, echoed from the request.
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
        /// The timestamp after which this configuration is no longer served to clients. Present
        /// only for <c>BREAKPOINT</c> configurations; <c>PROBE</c> configurations do not expire.
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
        /// The type of instrumentation that was created, echoed from the request.
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
        /// The location where instrumentation is applied, echoed from the request.
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
        /// Gets and sets the property LocationHash. 
        /// <para>
        /// A stable hash computed from the location that uniquely identifies this instrumentation
        /// point within the service, environment, and signal type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=16)]
        public string LocationHash
        {
            get { return this._locationHash; }
            set { this._locationHash = value; }
        }

        // Check to see if LocationHash property is set
        internal bool IsSetLocationHash()
        {
            return this._locationHash != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The service name for the instrumentation configuration, echoed from the request.
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
        /// The telemetry signal type for the instrumentation configuration, echoed from the request.
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

    }
}