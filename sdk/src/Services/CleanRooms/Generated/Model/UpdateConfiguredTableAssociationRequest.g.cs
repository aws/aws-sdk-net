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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConfiguredTableAssociation operation. Updates
    /// a configured table association.
    /// </summary>
    public partial class UpdateConfiguredTableAssociationRequest : AmazonCleanRoomsRequest
    {
        /// <summary>
        /// Gets and sets the property ConfiguredTableAssociationIdentifier. 
        /// <para>
        /// The unique identifier for the configured table association to update. Currently accepts
        /// the configured table association ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ConfiguredTableAssociationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ConfiguredTableAssociationIdentifier property is set.
        /// </summary>
        internal bool IsSetConfiguredTableAssociationIdentifier() => this.ConfiguredTableAssociationIdentifier != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the configured table association.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The unique ID for the membership that the configured table association belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MembershipIdentifier property is set.
        /// </summary>
        internal bool IsSetMembershipIdentifier() => this.MembershipIdentifier != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The service will assume this role to access catalog metadata and query the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 512)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
