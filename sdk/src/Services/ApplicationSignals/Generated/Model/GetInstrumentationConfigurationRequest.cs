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
    /// Container for the parameters to the GetInstrumentationConfiguration operation.
    /// Returns the details of a single instrumentation configuration identified by service,
    /// environment, signal type, and location. Use this to audit or display configuration
    /// details.
    /// </summary>
    public partial class GetInstrumentationConfigurationRequest : AmazonApplicationSignalsRequest
    {
        private string _environment;
        private InstrumentationType _instrumentationType;
        private LocationIdentifier _locationIdentifier;
        private string _service;
        private DynamicInstrumentationSignalType _signalType;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// Environment name for the instrumentation configuration.
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
        /// Gets and sets the property InstrumentationType. 
        /// <para>
        /// Type of instrumentation configuration (BREAKPOINT or PROBE). Required to identify
        /// the configuration to retrieve.
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
        /// Gets and sets the property LocationIdentifier. 
        /// <para>
        /// Location identifier - either full code location or a pre-computed hash.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LocationIdentifier LocationIdentifier
        {
            get { return this._locationIdentifier; }
            set { this._locationIdentifier = value; }
        }

        // Check to see if LocationIdentifier property is set
        internal bool IsSetLocationIdentifier()
        {
            return this._locationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// Service name for the instrumentation configuration.
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
        /// Signal type for the instrumentation configuration.
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