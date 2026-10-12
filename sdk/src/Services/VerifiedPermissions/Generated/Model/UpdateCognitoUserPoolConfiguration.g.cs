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

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Contains configuration details of a Amazon Cognito user pool for use with an identity
    /// source.
    /// </summary>
    public partial class UpdateCognitoUserPoolConfiguration
    {
        /// <summary>
        /// Gets and sets the property ClientIds. 
        /// <para>
        /// The client ID of an app client that is configured for the specified Amazon Cognito
        /// user pool.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public List<string> ClientIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ClientIds property is set.
        /// </summary>
        internal bool IsSetClientIds() => this.ClientIds != null && (this.ClientIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GroupConfiguration. 
        /// <para>
        /// The configuration of the user groups from an Amazon Cognito user pool identity source.
        /// </para>
        /// </summary>
        public UpdateCognitoGroupConfiguration GroupConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GroupConfiguration property is set.
        /// </summary>
        internal bool IsSetGroupConfiguration() => this.GroupConfiguration != null;

        /// <summary>
        /// Gets and sets the property UserPoolArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the Amazon Cognito user pool associated with this identity
        /// source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string UserPoolArn { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolArn property is set.
        /// </summary>
        internal bool IsSetUserPoolArn() => this.UserPoolArn != null;
    }
}
