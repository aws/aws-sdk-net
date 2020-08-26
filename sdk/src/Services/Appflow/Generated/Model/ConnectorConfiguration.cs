/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The configuration settings related to a given connector.
    /// </summary>
    public partial class ConnectorConfiguration
    {
        private bool? _canUseAsDestination;
        private bool? _canUseAsSource;
        private ConnectorMetadata _connectorMetadata;
        private bool? _isPrivateLinkEnabled;
        private bool? _isPrivateLinkEndpointUrlRequired;
        private List<string> _supportedDestinationConnectors = new List<string>();
        private List<string> _supportedSchedulingFrequencies = new List<string>();
        private List<string> _supportedTriggerTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property CanUseAsDestination. 
        /// <para>
        ///  Specifies whether the connector can be used as a destination. 
        /// </para>
        /// </summary>
        public bool CanUseAsDestination
        {
            get { return this._canUseAsDestination.GetValueOrDefault(); }
            set { this._canUseAsDestination = value; }
        }

        // Check to see if CanUseAsDestination property is set
        internal bool IsSetCanUseAsDestination()
        {
            return this._canUseAsDestination.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CanUseAsSource. 
        /// <para>
        ///  Specifies whether the connector can be used as a source. 
        /// </para>
        /// </summary>
        public bool CanUseAsSource
        {
            get { return this._canUseAsSource.GetValueOrDefault(); }
            set { this._canUseAsSource = value; }
        }

        // Check to see if CanUseAsSource property is set
        internal bool IsSetCanUseAsSource()
        {
            return this._canUseAsSource.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConnectorMetadata. 
        /// <para>
        ///  Specifies connector-specific metadata such as <code>oAuthScopes</code>, <code>supportedRegions</code>,
        /// <code>privateLinkServiceUrl</code>, and so on. 
        /// </para>
        /// </summary>
        public ConnectorMetadata ConnectorMetadata
        {
            get { return this._connectorMetadata; }
            set { this._connectorMetadata = value; }
        }

        // Check to see if ConnectorMetadata property is set
        internal bool IsSetConnectorMetadata()
        {
            return this._connectorMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property IsPrivateLinkEnabled. 
        /// <para>
        ///  Specifies if PrivateLink is enabled for that connector. 
        /// </para>
        /// </summary>
        public bool IsPrivateLinkEnabled
        {
            get { return this._isPrivateLinkEnabled.GetValueOrDefault(); }
            set { this._isPrivateLinkEnabled = value; }
        }

        // Check to see if IsPrivateLinkEnabled property is set
        internal bool IsSetIsPrivateLinkEnabled()
        {
            return this._isPrivateLinkEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsPrivateLinkEndpointUrlRequired. 
        /// <para>
        ///  Specifies if a PrivateLink endpoint URL is required. 
        /// </para>
        /// </summary>
        public bool IsPrivateLinkEndpointUrlRequired
        {
            get { return this._isPrivateLinkEndpointUrlRequired.GetValueOrDefault(); }
            set { this._isPrivateLinkEndpointUrlRequired = value; }
        }

        // Check to see if IsPrivateLinkEndpointUrlRequired property is set
        internal bool IsSetIsPrivateLinkEndpointUrlRequired()
        {
            return this._isPrivateLinkEndpointUrlRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportedDestinationConnectors. 
        /// <para>
        ///  Lists the connectors that are available for use as destinations. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> SupportedDestinationConnectors
        {
            get { return this._supportedDestinationConnectors; }
            set { this._supportedDestinationConnectors = value; }
        }

        // Check to see if SupportedDestinationConnectors property is set
        internal bool IsSetSupportedDestinationConnectors()
        {
            return this._supportedDestinationConnectors != null && this._supportedDestinationConnectors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedSchedulingFrequencies. 
        /// <para>
        ///  Specifies the supported flow frequency for that connector. 
        /// </para>
        /// </summary>
        public List<string> SupportedSchedulingFrequencies
        {
            get { return this._supportedSchedulingFrequencies; }
            set { this._supportedSchedulingFrequencies = value; }
        }

        // Check to see if SupportedSchedulingFrequencies property is set
        internal bool IsSetSupportedSchedulingFrequencies()
        {
            return this._supportedSchedulingFrequencies != null && this._supportedSchedulingFrequencies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedTriggerTypes. 
        /// <para>
        ///  Specifies the supported trigger types for the flow. 
        /// </para>
        /// </summary>
        public List<string> SupportedTriggerTypes
        {
            get { return this._supportedTriggerTypes; }
            set { this._supportedTriggerTypes = value; }
        }

        // Check to see if SupportedTriggerTypes property is set
        internal bool IsSetSupportedTriggerTypes()
        {
            return this._supportedTriggerTypes != null && this._supportedTriggerTypes.Count > 0; 
        }

    }
}