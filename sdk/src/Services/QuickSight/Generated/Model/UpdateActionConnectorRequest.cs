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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
    /// Container for the parameters to the UpdateActionConnector operation.
    /// Updates an existing action connector with new configuration details, authentication
    /// settings, or enabled actions. You can modify the connector's name, description, authentication
    /// configuration, and which actions are enabled. For more information, <a href="https://docs.aws.amazon.com/quicksuite/latest/userguide/quick-action-auth.html">https://docs.aws.amazon.com/quicksuite/latest/userguide/quick-action-auth.html</a>.
    /// </summary>
    public partial class UpdateActionConnectorRequest : AmazonQuickSightRequest
    {
        private string _actionConnectorId;
        private AuthConfig _authenticationConfig;
        private string _awsAccountId;
        private string _description;
        private string _name;
        private string _vpcConnectionArn;

        /// <summary>
        /// Gets and sets the property ActionConnectorId. 
        /// <para>
        /// The unique identifier of the action connector to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string ActionConnectorId
        {
            get { return this._actionConnectorId; }
            set { this._actionConnectorId = value; }
        }

        // Check to see if ActionConnectorId property is set
        internal bool IsSetActionConnectorId()
        {
            return this._actionConnectorId != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationConfig. 
        /// <para>
        /// The updated authentication configuration for connecting to the external service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthConfig AuthenticationConfig
        {
            get { return this._authenticationConfig; }
            set { this._authenticationConfig = value; }
        }

        // Check to see if AuthenticationConfig property is set
        internal bool IsSetAuthenticationConfig()
        {
            return this._authenticationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that contains the action connector to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the action connector.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The new name for the action connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConnectionArn. 
        /// <para>
        /// The updated ARN of the VPC connection to use for secure connectivity.
        /// </para>
        /// </summary>
        public string VpcConnectionArn
        {
            get { return this._vpcConnectionArn; }
            set { this._vpcConnectionArn = value; }
        }

        // Check to see if VpcConnectionArn property is set
        internal bool IsSetVpcConnectionArn()
        {
            return this._vpcConnectionArn != null;
        }

    }
}