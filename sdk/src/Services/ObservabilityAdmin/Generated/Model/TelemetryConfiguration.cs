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
    /// A model representing the state of a resource within an account according to telemetry
    /// config.
    /// </summary>
    public partial class TelemetryConfiguration
    {
        private string _accountIdentifier;
        private long? _lastUpdateTimeStamp;
        private string _resourceIdentifier;
        private Dictionary<string, string> _resourceTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ResourceType _resourceType;
        private Dictionary<string, string> _telemetryConfigurationState = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AccountIdentifier. 
        /// <para>
        ///  The account ID which contains the resource managed in telemetry configuration. An
        /// example of a valid account ID is <c>012345678901</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountIdentifier
        {
            get { return this._accountIdentifier; }
            set { this._accountIdentifier = value; }
        }

        // Check to see if AccountIdentifier property is set
        internal bool IsSetAccountIdentifier()
        {
            return this._accountIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTimeStamp. 
        /// <para>
        ///  The timestamp of the last change to the telemetry configuration for the resource.
        /// For example, <c>1728679196318</c>. 
        /// </para>
        /// </summary>
        public long? LastUpdateTimeStamp
        {
            get { return this._lastUpdateTimeStamp; }
            set { this._lastUpdateTimeStamp = value; }
        }

        // Check to see if LastUpdateTimeStamp property is set
        internal bool IsSetLastUpdateTimeStamp()
        {
            return this._lastUpdateTimeStamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        ///  The identifier of the resource, for example <c>i-0b22a22eec53b9321</c>. 
        /// </para>
        /// </summary>
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        ///  Tags associated with the resource, for example <c>{ Name: "ExampleInstance", Environment:
        /// "Development" }</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && (this._resourceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        ///  The type of resource, for example <c>Amazon Web Services::EC2::Instance</c>. 
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
        /// Gets and sets the property TelemetryConfigurationState. 
        /// <para>
        ///  The configuration state for the resource, for example <c>{ Logs: NotApplicable; Metrics:
        /// Enabled; Traces: NotApplicable; }</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> TelemetryConfigurationState
        {
            get { return this._telemetryConfigurationState; }
            set { this._telemetryConfigurationState = value; }
        }

        // Check to see if TelemetryConfigurationState property is set
        internal bool IsSetTelemetryConfigurationState()
        {
            return this._telemetryConfigurationState != null && (this._telemetryConfigurationState.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}