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
    /// This is the response object from the UpdateGroupProfile operation.
    /// </summary>
    public partial class UpdateGroupProfileResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which a group profile is updated.
        /// </para>
        /// </summary>
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the group profile that is updated.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the group profile that is updated.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property RolePrincipalArn. 
        /// <para>
        /// The ARN of the IAM role principal. This role is associated with the updated group
        /// profile.
        /// </para>
        /// </summary>
        public string RolePrincipalArn { get; set; }

        /// <summary>
        /// Checks to see if the RolePrincipalArn property is set.
        /// </summary>
        internal bool IsSetRolePrincipalArn() => this.RolePrincipalArn != null;

        /// <summary>
        /// Gets and sets the property RolePrincipalId. 
        /// <para>
        /// The unique identifier of the IAM role principal. This principal is associated with
        /// the updated group profile.
        /// </para>
        /// </summary>
        public string RolePrincipalId { get; set; }

        /// <summary>
        /// Checks to see if the RolePrincipalId property is set.
        /// </summary>
        internal bool IsSetRolePrincipalId() => this.RolePrincipalId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the group profile that is updated.
        /// </para>
        /// </summary>
        public GroupProfileStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
