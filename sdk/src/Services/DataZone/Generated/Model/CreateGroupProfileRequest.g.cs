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
    /// Container for the parameters to the CreateGroupProfile operation. Creates a group
    /// profile in Amazon DataZone.
    /// </summary>
    public partial class CreateGroupProfileRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique, case-sensitive identifier that is provided to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which the group profile is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property GroupIdentifier. 
        /// <para>
        /// The identifier of the group for which the group profile is created.
        /// </para>
        /// </summary>
        public string GroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GroupIdentifier property is set.
        /// </summary>
        internal bool IsSetGroupIdentifier() => this.GroupIdentifier != null;

        /// <summary>
        /// Gets and sets the property RolePrincipalArn. 
        /// <para>
        /// The ARN of the IAM role that will be associated with the group profile. This role
        /// defines the permissions that group members will assume when accessing Amazon DataZone
        /// resources.
        /// </para>
        /// </summary>
        public string RolePrincipalArn { get; set; }

        /// <summary>
        /// Checks to see if the RolePrincipalArn property is set.
        /// </summary>
        internal bool IsSetRolePrincipalArn() => this.RolePrincipalArn != null;
    }
}
