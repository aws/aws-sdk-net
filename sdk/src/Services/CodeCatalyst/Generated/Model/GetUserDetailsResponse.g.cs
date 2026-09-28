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

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// This is the response object from the GetUserDetails operation.
    /// </summary>
    public partial class GetUserDetailsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The friendly name displayed for the user in Amazon CodeCatalyst.
        /// </para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property PrimaryEmail. 
        /// <para>
        /// The email address provided by the user when they signed up.
        /// </para>
        /// </summary>
        public EmailAddress PrimaryEmail { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryEmail property is set.
        /// </summary>
        internal bool IsSetPrimaryEmail() => this.PrimaryEmail != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The system-generated unique ID of the user.
        /// </para>
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user as displayed in Amazon CodeCatalyst.
        /// </para>
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;

        /// <summary>
        /// Gets and sets the property Version.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
