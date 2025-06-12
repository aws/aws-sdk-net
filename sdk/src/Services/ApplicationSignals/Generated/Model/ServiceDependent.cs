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
    /// This structure contains information about a service dependent that was discovered
    /// by Application Signals. A dependent is an entity that invoked the specified service
    /// during the provided time range. Dependents include other services, CloudWatch Synthetics
    /// canaries, and clients that are instrumented with CloudWatch RUM app monitors.
    /// </summary>
    public partial class ServiceDependent
    {
        private Dictionary<string, string> _dependentKeyAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _dependentOperationName;
        private List<MetricReference> _metricReferences = AWSConfigs.InitializeCollections ? new List<MetricReference>() : null;
        private string _operationName;

        /// <summary>
        /// Gets and sets the property DependentKeyAttributes. 
        /// <para>
        /// This is a string-to-string map. It can include the following fields.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Type</c> designates the type of object this is.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceType</c> specifies the type of the resource. This field is used only when
        /// the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Name</c> specifies the name of the object. This is used only if the value of the
        /// <c>Type</c> field is <c>Service</c>, <c>RemoteService</c>, or <c>AWS::Service</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Identifier</c> identifies the resource objects of this resource. This is used
        /// only if the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Environment</c> specifies the location where this object is hosted, or what it
        /// belongs to.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public Dictionary<string, string> DependentKeyAttributes
        {
            get { return this._dependentKeyAttributes; }
            set { this._dependentKeyAttributes = value; }
        }

        // Check to see if DependentKeyAttributes property is set
        internal bool IsSetDependentKeyAttributes()
        {
            return this._dependentKeyAttributes != null && (this._dependentKeyAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DependentOperationName. 
        /// <para>
        /// If the dependent invoker was a service that invoked it from an operation, the name
        /// of that dependent operation is displayed here.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DependentOperationName
        {
            get { return this._dependentOperationName; }
            set { this._dependentOperationName = value; }
        }

        // Check to see if DependentOperationName property is set
        internal bool IsSetDependentOperationName()
        {
            return this._dependentOperationName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricReferences. 
        /// <para>
        /// An array of structures that each contain information about one metric associated with
        /// this service dependent that was discovered by Application Signals.
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
        /// Gets and sets the property OperationName. 
        /// <para>
        /// If the invoked entity is an operation on an entity, the name of that dependent operation
        /// is displayed here.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string OperationName
        {
            get { return this._operationName; }
            set { this._operationName = value; }
        }

        // Check to see if OperationName property is set
        internal bool IsSetOperationName()
        {
            return this._operationName != null;
        }

    }
}