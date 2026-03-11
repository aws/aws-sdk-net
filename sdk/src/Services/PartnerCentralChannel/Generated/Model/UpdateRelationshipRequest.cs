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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
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
    /// Container for the parameters to the UpdateRelationship operation.
    /// Updates the properties of a partner relationship.
    /// </summary>
    public partial class UpdateRelationshipRequest : AmazonPartnerCentralChannelRequest
    {
        private string _catalog;
        private string _displayName;
        private string _identifier;
        private string _programManagementAccountIdentifier;
        private SupportPlan _requestedSupportPlan;
        private string _revision;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier for the relationship.
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The new display name for the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique identifier of the relationship to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=1011)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property ProgramManagementAccountIdentifier. 
        /// <para>
        /// The identifier of the program management account associated with the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=17, Max=1011)]
        public string ProgramManagementAccountIdentifier
        {
            get { return this._programManagementAccountIdentifier; }
            set { this._programManagementAccountIdentifier = value; }
        }

        // Check to see if ProgramManagementAccountIdentifier property is set
        internal bool IsSetProgramManagementAccountIdentifier()
        {
            return this._programManagementAccountIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedSupportPlan. 
        /// <para>
        /// The updated support plan for the relationship.
        /// </para>
        /// </summary>
        public SupportPlan RequestedSupportPlan
        {
            get { return this._requestedSupportPlan; }
            set { this._requestedSupportPlan = value; }
        }

        // Check to see if RequestedSupportPlan property is set
        internal bool IsSetRequestedSupportPlan()
        {
            return this._requestedSupportPlan != null;
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The current revision number of the relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }

    }
}