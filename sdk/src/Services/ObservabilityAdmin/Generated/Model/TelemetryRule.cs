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
    /// Defines how telemetry should be configured for specific Amazon Web Services resources.
    /// </summary>
    public partial class TelemetryRule
    {
        private TelemetryDestinationConfiguration _destinationConfiguration;
        private ResourceType _resourceType;
        private string _scope;
        private string _selectionCriteria;
        private TelemetryType _telemetryType;

        /// <summary>
        /// Gets and sets the property DestinationConfiguration. 
        /// <para>
        ///  Configuration specifying where and how the telemetry data should be delivered. 
        /// </para>
        /// </summary>
        public TelemetryDestinationConfiguration DestinationConfiguration
        {
            get { return this._destinationConfiguration; }
            set { this._destinationConfiguration = value; }
        }

        // Check to see if DestinationConfiguration property is set
        internal bool IsSetDestinationConfiguration()
        {
            return this._destinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        ///  The type of Amazon Web Services resource to configure telemetry for (e.g., "AWS::EC2::VPC").
        /// 
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        ///  The organizational scope to which the rule applies, specified using accounts or organizational
        /// units. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SelectionCriteria. 
        /// <para>
        ///  Criteria for selecting which resources the rule applies to, such as resource tags.
        /// 
        /// </para>
        /// </summary>
        public string SelectionCriteria
        {
            get { return this._selectionCriteria; }
            set { this._selectionCriteria = value; }
        }

        // Check to see if SelectionCriteria property is set
        internal bool IsSetSelectionCriteria()
        {
            return this._selectionCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property TelemetryType. 
        /// <para>
        ///  The type of telemetry to collect (Logs, Metrics, or Traces). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TelemetryType TelemetryType
        {
            get { return this._telemetryType; }
            set { this._telemetryType = value; }
        }

        // Check to see if TelemetryType property is set
        internal bool IsSetTelemetryType()
        {
            return this._telemetryType != null;
        }

    }
}