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

namespace Amazon.PartnerCentralAccount.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConnectionPreferences operation. Updates
    /// the connection preferences for a partner account, modifying access settings and exclusions.
    /// </summary>
    public partial class UpdateConnectionPreferencesRequest : AmazonPartnerCentralAccountRequest
    {
        /// <summary>
        /// Gets and sets the property AccessType. 
        /// <para>
        /// The access type setting for connections (e.g., open, restricted, invitation-only).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccessType AccessType { get; set; }

        /// <summary>
        /// Checks to see if the AccessType property is set.
        /// </summary>
        internal bool IsSetAccessType() => this.AccessType != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier for the partner account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property ExcludedParticipantIdentifiers. 
        /// <para>
        /// The updated list of participant identifiers to exclude from connections.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<string> ExcludedParticipantIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExcludedParticipantIdentifiers property is set.
        /// </summary>
        internal bool IsSetExcludedParticipantIdentifiers() => this.ExcludedParticipantIdentifiers != null && (this.ExcludedParticipantIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision number of the connection preferences for optimistic locking.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision.HasValue;
    }
}
