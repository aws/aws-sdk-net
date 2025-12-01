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
 * Do not modify this file. This file is generated from the partnercentral-account-2025-04-04.normal.json service model.
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
    /// Container for the parameters to the UpdateConnectionPreferences operation.
    /// Updates the connection preferences for a partner account, modifying access settings
    /// and exclusions.
    /// </summary>
    public partial class UpdateConnectionPreferencesRequest : AmazonPartnerCentralAccountRequest
    {
        private AccessType _accessType;
        private string _catalog;
        private List<string> _excludedParticipantIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private long? _revision;

        /// <summary>
        /// Gets and sets the property AccessType. 
        /// <para>
        /// The access type setting for connections (e.g., open, restricted, invitation-only).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccessType AccessType
        {
            get { return this._accessType; }
            set { this._accessType = value; }
        }

        // Check to see if AccessType property is set
        internal bool IsSetAccessType()
        {
            return this._accessType != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier for the partner account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludedParticipantIdentifiers. 
        /// <para>
        /// The updated list of participant identifiers to exclude from connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ExcludedParticipantIdentifiers
        {
            get { return this._excludedParticipantIdentifiers; }
            set { this._excludedParticipantIdentifiers = value; }
        }

        // Check to see if ExcludedParticipantIdentifiers property is set
        internal bool IsSetExcludedParticipantIdentifiers()
        {
            return this._excludedParticipantIdentifiers != null && (this._excludedParticipantIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision number of the connection preferences for optimistic locking.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long Revision
        {
            get { return this._revision.GetValueOrDefault(); }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision.HasValue; 
        }

    }
}