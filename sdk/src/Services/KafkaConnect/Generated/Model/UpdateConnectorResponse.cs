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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
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
namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// This is the response object from the UpdateConnector operation.
    /// </summary>
    public partial class UpdateConnectorResponse : AmazonWebServiceResponse
    {
        private string _connectorArn;
        private string _connectorOperationArn;
        private ConnectorState _connectorState;

        /// <summary>
        /// Gets and sets the property ConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector.
        /// </para>
        /// </summary>
        public string ConnectorArn
        {
            get { return this._connectorArn; }
            set { this._connectorArn = value; }
        }

        // Check to see if ConnectorArn property is set
        internal bool IsSetConnectorArn()
        {
            return this._connectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorOperationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector operation.
        /// </para>
        /// </summary>
        public string ConnectorOperationArn
        {
            get { return this._connectorOperationArn; }
            set { this._connectorOperationArn = value; }
        }

        // Check to see if ConnectorOperationArn property is set
        internal bool IsSetConnectorOperationArn()
        {
            return this._connectorOperationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorState. 
        /// <para>
        /// The state of the connector.
        /// </para>
        /// </summary>
        public ConnectorState ConnectorState
        {
            get { return this._connectorState; }
            set { this._connectorState = value; }
        }

        // Check to see if ConnectorState property is set
        internal bool IsSetConnectorState()
        {
            return this._connectorState != null;
        }

    }
}