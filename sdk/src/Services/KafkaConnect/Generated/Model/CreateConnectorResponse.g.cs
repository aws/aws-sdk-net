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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the CreateConnector operation.
    /// </summary>
    public partial class CreateConnectorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that Amazon assigned to the connector.
        /// </para>
        /// </summary>
        public string ConnectorArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorArn property is set.
        /// </summary>
        internal bool IsSetConnectorArn() => this.ConnectorArn != null;

        /// <summary>
        /// Gets and sets the property ConnectorName. 
        /// <para>
        /// The name of the connector.
        /// </para>
        /// </summary>
        public string ConnectorName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorName property is set.
        /// </summary>
        internal bool IsSetConnectorName() => this.ConnectorName != null;

        /// <summary>
        /// Gets and sets the property ConnectorState. 
        /// <para>
        /// The state of the connector.
        /// </para>
        /// </summary>
        public ConnectorState ConnectorState { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorState property is set.
        /// </summary>
        internal bool IsSetConnectorState() => this.ConnectorState != null;
    }
}
