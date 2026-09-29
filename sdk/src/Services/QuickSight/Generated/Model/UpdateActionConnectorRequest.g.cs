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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateActionConnector operation. Updates an existing
    /// action connector with new configuration details, authentication settings, or enabled
    /// actions. You can modify the connector's name, description, authentication configuration,
    /// and which actions are enabled. For more information, <a href="https://docs.aws.amazon.com/quicksuite/latest/userguide/quick-action-auth.html">https://docs.aws.amazon.com/quicksuite/latest/userguide/quick-action-auth.html</a>.
    /// </summary>
    public partial class UpdateActionConnectorRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property ActionConnectorId. 
        /// <para>
        /// The unique identifier of the action connector to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ActionConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the ActionConnectorId property is set.
        /// </summary>
        internal bool IsSetActionConnectorId() => this.ActionConnectorId != null;

        /// <summary>
        /// Gets and sets the property AuthenticationConfig. 
        /// <para>
        /// The updated authentication configuration for connecting to the external service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthConfig AuthenticationConfig { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationConfig property is set.
        /// </summary>
        internal bool IsSetAuthenticationConfig() => this.AuthenticationConfig != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that contains the action connector to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the action connector.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The new name for the action connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property VpcConnectionArn. 
        /// <para>
        /// The updated ARN of the VPC connection to use for secure connectivity.
        /// </para>
        /// </summary>
        public string VpcConnectionArn { get; set; }

        /// <summary>
        /// Checks to see if the VpcConnectionArn property is set.
        /// </summary>
        internal bool IsSetVpcConnectionArn() => this.VpcConnectionArn != null;
    }
}
