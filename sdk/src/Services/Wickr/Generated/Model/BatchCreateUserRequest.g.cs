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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Container for the parameters to the BatchCreateUser operation. Creates multiple users
    /// in a specified Wickr network. This operation allows you to provision multiple user
    /// accounts simultaneously, optionally specifying security groups, and validation requirements
    /// for each user. <note> <para> <c>codeValidation</c>, <c>inviteCode</c>, and <c>inviteCodeTtl</c>
    /// are restricted to networks under preview only. </para> </note>
    /// </summary>
    public partial class BatchCreateUserRequest : AmazonWickrRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier for this request to ensure idempotency. If you retry a request
        /// with the same client token, the service will return the same response without creating
        /// duplicate users.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The ID of the Wickr network where users will be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 8)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId != null;

        /// <summary>
        /// Gets and sets the property Users. 
        /// <para>
        /// A list of user objects containing the details for each user to be created, including
        /// username, name, security groups, and optional invite codes. Maximum 50 users per batch
        /// request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<BatchCreateUserRequestItem> Users { get; set; } = AWSConfigs.InitializeCollections ? new List<BatchCreateUserRequestItem>() : null;

        /// <summary>
        /// Checks to see if the Users property is set.
        /// </summary>
        internal bool IsSetUsers() => this.Users != null && (this.Users.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
