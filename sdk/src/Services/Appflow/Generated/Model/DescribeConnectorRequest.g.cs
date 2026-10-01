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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeConnector operation. Describes the given
    /// custom connector registered in your Amazon Web Services account. This API can be used
    /// for custom connectors that are registered in your account and also for Amazon authored
    /// connectors.
    /// </summary>
    public partial class DescribeConnectorRequest : AmazonAppflowRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectorLabel. 
        /// <para>
        /// The label of the connector. The label is unique for each <c>ConnectorRegistration</c>
        /// in your Amazon Web Services account. Only needed if calling for CUSTOMCONNECTOR connector
        /// type/.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ConnectorLabel { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorLabel property is set.
        /// </summary>
        internal bool IsSetConnectorLabel() => this.ConnectorLabel != null;

        /// <summary>
        /// Gets and sets the property ConnectorType. 
        /// <para>
        /// The connector type, such as CUSTOMCONNECTOR, Saleforce, Marketo. Please choose CUSTOMCONNECTOR
        /// for Lambda based custom connectors.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConnectorType ConnectorType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorType property is set.
        /// </summary>
        internal bool IsSetConnectorType() => this.ConnectorType != null;
    }
}
