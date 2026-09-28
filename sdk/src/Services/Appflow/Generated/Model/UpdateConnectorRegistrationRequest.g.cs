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
    /// Container for the parameters to the UpdateConnectorRegistration operation. Updates
    /// a custom connector that you've previously registered. This operation updates the connector
    /// with one of the following: <ul> <li> <para> The latest version of the AWS Lambda function
    /// that's assigned to the connector </para> </li> <li> <para> A new AWS Lambda function
    /// that you specify </para> </li> </ul>
    /// </summary>
    public partial class UpdateConnectorRegistrationRequest : AmazonAppflowRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The <c>clientToken</c> parameter is an idempotency token. It ensures that your <c>UpdateConnectorRegistration</c>
        /// request completes only once. You choose the value to pass. For example, if you don't
        /// receive a response from your request, you can safely retry the request with the same
        /// <c>clientToken</c> parameter value.
        /// </para>
        ///  
        /// <para>
        /// If you omit a <c>clientToken</c> value, the Amazon Web Services SDK that you are using
        /// inserts a value for you. This way, the SDK can safely retry requests multiple times
        /// after a network error. You must provide your own value for other use cases.
        /// </para>
        ///  
        /// <para>
        /// If you specify input parameters that differ from your first request, an error occurs.
        /// If you use a different value for <c>clientToken</c>, Amazon AppFlow considers it a
        /// new call to <c>UpdateConnectorRegistration</c>. The token is active for 8 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ConnectorLabel. 
        /// <para>
        /// The name of the connector. The name is unique for each connector registration in your
        /// AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ConnectorLabel { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorLabel property is set.
        /// </summary>
        internal bool IsSetConnectorLabel() => this.ConnectorLabel != null;

        /// <summary>
        /// Gets and sets the property ConnectorProvisioningConfig.
        /// </summary>
        public ConnectorProvisioningConfig ConnectorProvisioningConfig { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorProvisioningConfig property is set.
        /// </summary>
        internal bool IsSetConnectorProvisioningConfig() => this.ConnectorProvisioningConfig != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description about the update that you're applying to the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;
    }
}
