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
    /// Container for the parameters to the UpdateConfiguredAudienceModelAssociation operation.
    /// Provides the details necessary to update a configured audience model association.
    /// </summary>
    public partial class UpdateConfiguredAudienceModelAssociationRequest : AmazonCleanRoomsRequest
    {
        /// <summary>
        /// Gets and sets the property ConfiguredAudienceModelAssociationIdentifier. 
        /// <para>
        /// A unique identifier for the configured audience model association that you want to
        /// update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ConfiguredAudienceModelAssociationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ConfiguredAudienceModelAssociationIdentifier property is set.
        /// </summary>
        internal bool IsSetConfiguredAudienceModelAssociationIdentifier() => this.ConfiguredAudienceModelAssociationIdentifier != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the configured audience model association.
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
        /// A unique identifier of the membership that contains the configured audience model
        /// association that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MembershipIdentifier property is set.
        /// </summary>
        internal bool IsSetMembershipIdentifier() => this.MembershipIdentifier != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A new name for the configured audience model association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
