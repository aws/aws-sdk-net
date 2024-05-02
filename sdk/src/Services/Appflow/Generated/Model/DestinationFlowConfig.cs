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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Contains information about the configuration of destination connectors present in
    /// the flow.
    /// </summary>
    public partial class DestinationFlowConfig
    {
        private string _apiVersion;
        private string _connectorProfileName;
        private ConnectorType _connectorType;
        private DestinationConnectorProperties _destinationConnectorProperties;

        /// <summary>
        /// Gets and sets the property ApiVersion. 
        /// <para>
        /// The API version that the destination connector uses.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ApiVersion
        {
            get { return this._apiVersion; }
            set { this._apiVersion = value; }
        }

        // Check to see if ApiVersion property is set
        internal bool IsSetApiVersion()
        {
            return this._apiVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorProfileName. 
        /// <para>
        ///  The name of the connector profile. This name must be unique for each connector profile
        /// in the Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ConnectorProfileName
        {
            get { return this._connectorProfileName; }
            set { this._connectorProfileName = value; }
        }

        // Check to see if ConnectorProfileName property is set
        internal bool IsSetConnectorProfileName()
        {
            return this._connectorProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorType. 
        /// <para>
        ///  The type of connector, such as Salesforce, Amplitude, and so on. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectorType ConnectorType
        {
            get { return this._connectorType; }
            set { this._connectorType = value; }
        }

        // Check to see if ConnectorType property is set
        internal bool IsSetConnectorType()
        {
            return this._connectorType != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationConnectorProperties. 
        /// <para>
        ///  This stores the information that is required to query a particular connector. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DestinationConnectorProperties DestinationConnectorProperties
        {
            get { return this._destinationConnectorProperties; }
            set { this._destinationConnectorProperties = value; }
        }

        // Check to see if DestinationConnectorProperties property is set
        internal bool IsSetDestinationConnectorProperties()
        {
            return this._destinationConnectorProperties != null;
        }

    }
}