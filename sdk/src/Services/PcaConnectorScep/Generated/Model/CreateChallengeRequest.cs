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
 * Do not modify this file. This file is generated from the pca-connector-scep-2018-05-10.normal.json service model.
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
namespace Amazon.PcaConnectorScep.Model
{
    /// <summary>
    /// Container for the parameters to the CreateChallenge operation.
    /// For general-purpose connectors. Creates a <i>challenge password</i> for the specified
    /// connector. The SCEP protocol uses a challenge password to authenticate a request before
    /// issuing a certificate from a certificate authority (CA). Your SCEP clients include
    /// the challenge password as part of their certificate request to Connector for SCEP.
    /// To retrieve the connector Amazon Resource Names (ARNs) for the connectors in your
    /// account, call <a href="https://docs.aws.amazon.com/C4SCEP_API/pca-connector-scep/latest/APIReference/API_ListConnectors.html">ListConnectors</a>.
    /// 
    ///  
    /// <para>
    /// To create additional challenge passwords for the connector, call <c>CreateChallenge</c>
    /// again. We recommend frequently rotating your challenge passwords.
    /// </para>
    /// </summary>
    public partial class CreateChallengeRequest : AmazonPcaConnectorScepRequest
    {
        private string _clientToken;
        private string _connectorArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Custom string that can be used to distinguish between calls to the <a href="https://docs.aws.amazon.com/C4SCEP_API/pca-connector-scep/latest/APIReference/API_CreateChallenge.html">CreateChallenge</a>
        /// action. Client tokens for <c>CreateChallenge</c> time out after five minutes. Therefore,
        /// if you call <c>CreateChallenge</c> multiple times with the same client token within
        /// five minutes, Connector for SCEP recognizes that you are requesting only one challenge
        /// and will only respond with one. If you change the client token for each call, Connector
        /// for SCEP recognizes that you are requesting multiple challenge passwords.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector that you want to create a challenge
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=200)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pairs to associate with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}