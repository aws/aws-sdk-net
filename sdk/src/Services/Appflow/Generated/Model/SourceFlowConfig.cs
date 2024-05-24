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
    /// Contains information about the configuration of the source connector used in the
    /// flow.
    /// </summary>
    public partial class SourceFlowConfig
    {
        private string _apiVersion;
        private string _connectorProfileName;
        private ConnectorType _connectorType;
        private IncrementalPullConfig _incrementalPullConfig;
        private SourceConnectorProperties _sourceConnectorProperties;

        /// <summary>
        /// Gets and sets the property ApiVersion. 
        /// <para>
        /// The API version of the connector when it's used as a source in the flow.
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
        /// Gets and sets the property IncrementalPullConfig. 
        /// <para>
        ///  Defines the configuration for a scheduled incremental data pull. If a valid configuration
        /// is provided, the fields specified in the configuration are used when querying for
        /// the incremental data pull. 
        /// </para>
        /// </summary>
        public IncrementalPullConfig IncrementalPullConfig
        {
            get { return this._incrementalPullConfig; }
            set { this._incrementalPullConfig = value; }
        }

        // Check to see if IncrementalPullConfig property is set
        internal bool IsSetIncrementalPullConfig()
        {
            return this._incrementalPullConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SourceConnectorProperties. 
        /// <para>
        ///  Specifies the information that is required to query a particular source connector.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceConnectorProperties SourceConnectorProperties
        {
            get { return this._sourceConnectorProperties; }
            set { this._sourceConnectorProperties = value; }
        }

        // Check to see if SourceConnectorProperties property is set
        internal bool IsSetSourceConnectorProperties()
        {
            return this._sourceConnectorProperties != null;
        }

    }
}