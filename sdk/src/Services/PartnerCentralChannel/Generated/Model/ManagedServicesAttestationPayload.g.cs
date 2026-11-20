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

namespace Amazon.PartnerCentralChannel.Model
{
    /// <summary>
    /// Payload for managed services attestation channel contract requests. Applies only to
    /// managed services attestation channel contracts.
    /// </summary>
    public partial class ManagedServicesAttestationPayload
    {
        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The end date of the attestation, which must be after the start date of the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property LegalEntityAddress. 
        /// <para>
        /// The address of the end customer's legal entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public Address LegalEntityAddress { get; set; }

        /// <summary>
        /// Checks to see if the LegalEntityAddress property is set.
        /// </summary>
        internal bool IsSetLegalEntityAddress() => this.LegalEntityAddress != null;

        /// <summary>
        /// Gets and sets the property LegalEntityName. 
        /// <para>
        /// The legal name of the end customer's legal entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 300)]
        public string LegalEntityName { get; set; }

        /// <summary>
        /// Checks to see if the LegalEntityName property is set.
        /// </summary>
        internal bool IsSetLegalEntityName() => this.LegalEntityName != null;

        /// <summary>
        /// Gets and sets the property MemberAccountIds. 
        /// <para>
        /// The AWS account IDs of the end customer's member accounts to cover, not allowed when
        /// the account scope is the entire organization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MemberAccountIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MemberAccountIds property is set.
        /// </summary>
        internal bool IsSetMemberAccountIds() => this.MemberAccountIds != null && (this.MemberAccountIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProgramManagementAccountIdentifier. 
        /// <para>
        /// The identifier of the program management account for the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 1011)]
        public string ProgramManagementAccountIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProgramManagementAccountIdentifier property is set.
        /// </summary>
        internal bool IsSetProgramManagementAccountIdentifier() => this.ProgramManagementAccountIdentifier != null;

        /// <summary>
        /// Gets and sets the property RelationshipIdentifier. 
        /// <para>
        /// The identifier of the managed services relationship to cover with the attestation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 16, Max = 1011)]
        public string RelationshipIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RelationshipIdentifier property is set.
        /// </summary>
        internal bool IsSetRelationshipIdentifier() => this.RelationshipIdentifier != null;

        /// <summary>
        /// Gets and sets the property SignatoryEmail. 
        /// <para>
        /// The email address to which the attestation is sent for signature.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string SignatoryEmail { get; set; }

        /// <summary>
        /// Checks to see if the SignatoryEmail property is set.
        /// </summary>
        internal bool IsSetSignatoryEmail() => this.SignatoryEmail != null;

        /// <summary>
        /// Gets and sets the property SignatoryName. 
        /// <para>
        /// The name of the person who signs the attestation for the end customer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string SignatoryName { get; set; }

        /// <summary>
        /// Checks to see if the SignatoryName property is set.
        /// </summary>
        internal bool IsSetSignatoryName() => this.SignatoryName != null;

        /// <summary>
        /// Gets and sets the property SupportedServices. 
        /// <para>
        /// The managed services that the partner provides to the end customer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> SupportedServices { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedServices property is set.
        /// </summary>
        internal bool IsSetSupportedServices() => this.SupportedServices != null && (this.SupportedServices.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
