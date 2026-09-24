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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the GetUserProfile operation. Gets a user profile
    /// in Amazon DataZone.
    /// </summary>
    public partial class GetUserProfileRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// the ID of the Amazon DataZone domain the data portal of which you want to get.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property SessionName. 
        /// <para>
        /// The session name for IAM role sessions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 64)]
        public string SessionName { get; set; }

        /// <summary>
        /// Checks to see if the SessionName property is set.
        /// </summary>
        internal bool IsSetSessionName() => this.SessionName != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the user profile.
        /// </para>
        /// </summary>
        public UserProfileType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UserIdentifier. 
        /// <para>
        /// The identifier of the user for which you want to get the user profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UserIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the UserIdentifier property is set.
        /// </summary>
        internal bool IsSetUserIdentifier() => this.UserIdentifier != null;
    }
}
