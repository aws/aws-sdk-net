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
    /// Container for the parameters to the DescribeConnectorEntity operation.
    /// Provides details regarding the entity used with the connector, with a description
    /// of the data model for each entity.
    /// </summary>
    public partial class DescribeConnectorEntityRequest : AmazonAppflowRequest
    {
        private string _connectorEntityName;
        private string _connectorProfileName;
        private ConnectorType _connectorType;

        /// <summary>
        /// Gets and sets the property ConnectorEntityName. 
        /// <para>
        ///  The entity name for that connector. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string ConnectorEntityName
        {
            get { return this._connectorEntityName; }
            set { this._connectorEntityName = value; }
        }

        // Check to see if ConnectorEntityName property is set
        internal bool IsSetConnectorEntityName()
        {
            return this._connectorEntityName != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorProfileName. 
        /// <para>
        ///  The name of the connector profile. The name is unique for each <code>ConnectorProfile</code>
        /// in the AWS account. 
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
        ///  The type of connector application, such as Salesforce, Amplitude, and so on. 
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

    }
}