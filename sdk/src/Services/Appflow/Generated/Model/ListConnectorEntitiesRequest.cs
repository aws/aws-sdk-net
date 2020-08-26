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
    /// Container for the parameters to the ListConnectorEntities operation.
    /// Returns the list of available connector entities supported by Amazon AppFlow. For
    /// example, you can query Salesforce for <i>Account</i> and <i>Opportunity</i> entities,
    /// or query ServiceNow for the <i>Incident</i> entity.
    /// </summary>
    public partial class ListConnectorEntitiesRequest : AmazonAppflowRequest
    {
        private string _connectorProfileName;
        private ConnectorType _connectorType;
        private string _entitiesPath;

        /// <summary>
        /// Gets and sets the property ConnectorProfileName. 
        /// <para>
        ///  The name of the connector profile. The name is unique for each <code>ConnectorProfile</code>
        /// in the AWS account, and is used to query the downstream connector. 
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
        /// Gets and sets the property EntitiesPath. 
        /// <para>
        ///  This optional parameter is specific to connector implementation. Some connectors
        /// support multiple levels or categories of entities. You can find out the list of roots
        /// for such providers by sending a request without the <code>entitiesPath</code> parameter.
        /// If the connector supports entities at different roots, this initial request returns
        /// the list of roots. Otherwise, this request returns all entities supported by the provider.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string EntitiesPath
        {
            get { return this._entitiesPath; }
            set { this._entitiesPath = value; }
        }

        // Check to see if EntitiesPath property is set
        internal bool IsSetEntitiesPath()
        {
            return this._entitiesPath != null;
        }

    }
}