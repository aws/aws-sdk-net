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
    /// This structure contains information about an operation discovered by Application Signals.
    /// An operation is a specific function performed by a service that was discovered by
    /// Application Signals, and is often an API that is called by an upstream dependent.
    /// </summary>
    public partial class ServiceOperation
    {
        private List<MetricReference> _metricReferences = AWSConfigs.InitializeCollections ? new List<MetricReference>() : null;
        private string _name;

        /// <summary>
        /// Gets and sets the property MetricReferences. 
        /// <para>
        /// An array of structures that each contain information about one metric associated with
        /// this service operation that was discovered by Application Signals.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MetricReference> MetricReferences
        {
            get { return this._metricReferences; }
            set { this._metricReferences = value; }
        }

        // Check to see if MetricReferences property is set
        internal bool IsSetMetricReferences()
        {
            return this._metricReferences != null && (this._metricReferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the operation, discovered by Application Signals.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}