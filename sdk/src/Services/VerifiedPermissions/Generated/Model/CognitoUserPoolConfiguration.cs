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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// The configuration for an identity source that represents a connection to an Amazon
    /// Cognito user pool used as an identity provider for Verified Permissions.
    /// 
    ///  
    /// <para>
    /// This data type part of a <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_Configuration.html">Configuration</a>
    /// structure that is used as a parameter to <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_CreateIdentitySource.html">CreateIdentitySource</a>.
    /// </para>
    ///  
    /// <para>
    /// Example:<c>"CognitoUserPoolConfiguration":{"UserPoolArn":"arn:aws:cognito-idp:us-east-1:123456789012:userpool/us-east-1_1a2b3c4d5","ClientIds":
    /// ["a1b2c3d4e5f6g7h8i9j0kalbmc"],"groupConfiguration": {"groupEntityType": "MyCorp::Group"}}</c>
    /// 
    /// </para>
    /// </summary>
    public partial class CognitoUserPoolConfiguration
    {
        private List<string> _clientIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CognitoGroupConfiguration _groupConfiguration;
        private string _userPoolArn;

        /// <summary>
        /// Gets and sets the property ClientIds. 
        /// <para>
        /// The unique application client IDs that are associated with the specified Amazon Cognito
        /// user pool.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>"ClientIds": ["&amp;ExampleCogClientId;"]</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<string> ClientIds
        {
            get { return this._clientIds; }
            set { this._clientIds = value; }
        }

        // Check to see if ClientIds property is set
        internal bool IsSetClientIds()
        {
            return this._clientIds != null && (this._clientIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GroupConfiguration. 
        /// <para>
        /// The type of entity that a policy store maps to groups from an Amazon Cognito user
        /// pool identity source.
        /// </para>
        /// </summary>
        public CognitoGroupConfiguration GroupConfiguration
        {
            get { return this._groupConfiguration; }
            set { this._groupConfiguration = value; }
        }

        // Check to see if GroupConfiguration property is set
        internal bool IsSetGroupConfiguration()
        {
            return this._groupConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the Amazon Cognito user pool that contains the identities
        /// to be authorized.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>"UserPoolArn": "arn:aws:cognito-idp:us-east-1:123456789012:userpool/us-east-1_1a2b3c4d5"</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string UserPoolArn
        {
            get { return this._userPoolArn; }
            set { this._userPoolArn = value; }
        }

        // Check to see if UserPoolArn property is set
        internal bool IsSetUserPoolArn()
        {
            return this._userPoolArn != null;
        }

    }
}