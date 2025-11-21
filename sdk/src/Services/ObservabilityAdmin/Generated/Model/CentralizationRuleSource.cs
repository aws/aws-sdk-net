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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
    /// Configuration specifying the source of telemetry data to be centralized.
    /// </summary>
    public partial class CentralizationRuleSource
    {
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _scope;
        private SourceLogsConfiguration _sourceLogsConfiguration;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The list of source regions from which telemetry data should be centralized.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The organizational scope from which telemetry data should be centralized, specified
        /// using organization id, accounts or organizational unit ids.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLogsConfiguration. 
        /// <para>
        /// Log specific configuration for centralization source log groups.
        /// </para>
        /// </summary>
        public SourceLogsConfiguration SourceLogsConfiguration
        {
            get { return this._sourceLogsConfiguration; }
            set { this._sourceLogsConfiguration = value; }
        }

        // Check to see if SourceLogsConfiguration property is set
        internal bool IsSetSourceLogsConfiguration()
        {
            return this._sourceLogsConfiguration != null;
        }

    }
}