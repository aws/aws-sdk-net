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
    /// Container for the parameters to the ReportInstrumentationConfigurationStatus operation.
    /// Reports the status of one or more instrumentation configurations from SDK instances.
    /// Use this to record when configurations become ready, hit errors, become active, or
    /// are disabled by limits.
    /// 
    ///  
    /// <para>
    /// Report <c>READY</c>, <c>ERROR</c>, and <c>DISABLED</c> when the status changes. Report
    /// <c>ACTIVE</c> periodically (for example, every minute) while instrumentation is running.
    /// </para>
    /// </summary>
    public partial class ReportInstrumentationConfigurationStatusRequest : AmazonApplicationSignalsRequest
    {
        private List<InstrumentationConfigurationStatusReport> _configurations = AWSConfigs.InitializeCollections ? new List<InstrumentationConfigurationStatusReport>() : null;
        private string _environment;
        private string _service;

        /// <summary>
        /// Gets and sets the property Configurations. 
        /// <para>
        /// An array of configuration status reports (up to 100) that include the instrumentation
        /// type, signal type, location hash, status, timestamp, and optional error cause.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<InstrumentationConfigurationStatusReport> Configurations
        {
            get { return this._configurations; }
            set { this._configurations = value; }
        }

        // Check to see if Configurations property is set
        internal bool IsSetConfigurations()
        {
            return this._configurations != null && (this._configurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment that the service is running in.
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
        /// Gets and sets the property Service. 
        /// <para>
        /// The service that the reported configurations belong to.
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

    }
}