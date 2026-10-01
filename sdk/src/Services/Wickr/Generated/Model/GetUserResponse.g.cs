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
    /// This is the response object from the GetUser operation.
    /// </summary>
    public partial class GetUserResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The first name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Checks to see if the FirstName property is set.
        /// </summary>
        internal bool IsSetFirstName() => this.FirstName != null;

        /// <summary>
        /// Gets and sets the property IsAdmin. 
        /// <para>
        /// Indicates whether the user has administrator privileges in the network.
        /// </para>
        /// </summary>
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// Checks to see if the IsAdmin property is set.
        /// </summary>
        internal bool IsSetIsAdmin() => this.IsAdmin.HasValue;

        /// <summary>
        /// Gets and sets the property LastActivity. 
        /// <para>
        /// The timestamp of the user's last activity in the network, specified in epoch seconds.
        /// </para>
        /// </summary>
        public int? LastActivity { get; set; }

        /// <summary>
        /// Checks to see if the LastActivity property is set.
        /// </summary>
        internal bool IsSetLastActivity() => this.LastActivity.HasValue;

        /// <summary>
        /// Gets and sets the property LastLogin. 
        /// <para>
        /// The timestamp of the user's last login to the network, specified in epoch seconds.
        /// </para>
        /// </summary>
        public int? LastLogin { get; set; }

        /// <summary>
        /// Checks to see if the LastLogin property is set.
        /// </summary>
        internal bool IsSetLastLogin() => this.LastLogin.HasValue;

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The last name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Checks to see if the LastName property is set.
        /// </summary>
        internal bool IsSetLastName() => this.LastName != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of security group IDs to which the user belongs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the user (1 for pending, 2 for active).
        /// </para>
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status.HasValue;

        /// <summary>
        /// Gets and sets the property Suspended. 
        /// <para>
        /// Indicates whether the user is currently suspended.
        /// </para>
        /// </summary>
        public bool? Suspended { get; set; }

        /// <summary>
        /// Checks to see if the Suspended property is set.
        /// </summary>
        internal bool IsSetSuspended() => this.Suspended.HasValue;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The unique identifier of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The email address or username of the user.
        /// </para>
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
