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
    /// Container for the parameters to the DescribeConnectorEntity operation. Provides details
    /// regarding the entity used with the connector, with a description of the data model
    /// for each field in that entity.
    /// </summary>
    public partial class DescribeConnectorEntityRequest : AmazonAppflowRequest
    {
        /// <summary>
        /// Gets and sets the property ApiVersion. 
        /// <para>
        /// The version of the API that's used by the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Checks to see if the ApiVersion property is set.
        /// </summary>
        internal bool IsSetApiVersion() => this.ApiVersion != null;

        /// <summary>
        /// Gets and sets the property ConnectorEntityName. 
        /// <para>
        ///  The entity name for that connector. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string ConnectorEntityName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorEntityName property is set.
        /// </summary>
        internal bool IsSetConnectorEntityName() => this.ConnectorEntityName != null;

        /// <summary>
        /// Gets and sets the property ConnectorProfileName. 
        /// <para>
        ///  The name of the connector profile. The name is unique for each <c>ConnectorProfile</c>
        /// in the Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ConnectorProfileName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorProfileName property is set.
        /// </summary>
        internal bool IsSetConnectorProfileName() => this.ConnectorProfileName != null;

        /// <summary>
        /// Gets and sets the property ConnectorType. 
        /// <para>
        ///  The type of connector application, such as Salesforce, Amplitude, and so on. 
        /// </para>
        /// </summary>
        public ConnectorType ConnectorType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorType property is set.
        /// </summary>
        internal bool IsSetConnectorType() => this.ConnectorType != null;
    }
}
