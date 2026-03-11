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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMembership operation.
    /// Creates a new membership.
    /// </summary>
    public partial class CreateMembershipRequest : AmazonSecurityIRRequest
    {
        private string _clientToken;
        private bool? _coverEntireOrganization;
        private List<IncidentResponder> _incidentResponseTeam = AWSConfigs.InitializeCollections ? new List<IncidentResponder>() : null;
        private string _membershipName;
        private List<OptInFeature> _optInFeatures = AWSConfigs.InitializeCollections ? new List<OptInFeature>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// <note> 
        /// <para>
        /// The <c>clientToken</c> field is an idempotency key used to ensure that repeated attempts
        /// for a single action will be ignored by the server during retries. A caller supplied
        /// unique ID (typically a UUID) should be provided. 
        /// </para>
        ///  </note>
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CoverEntireOrganization. 
        /// <para>
        /// The <c>coverEntireOrganization</c> parameter is a boolean flag that determines whether
        /// the membership should be applied to the entire Amazon Web Services Organization. When
        /// set to true, the membership will be created for all accounts within the organization.
        /// When set to false, the membership will only be created for specified accounts. 
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If not specified, the default value is false.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If set to <i>true</i>: The membership will automatically include all existing and
        /// future accounts in the Amazon Web Services Organization. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If set to <i>false</i>: The membership will only apply to explicitly specified accounts.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? CoverEntireOrganization
        {
            get { return this._coverEntireOrganization; }
            set { this._coverEntireOrganization = value; }
        }

        // Check to see if CoverEntireOrganization property is set
        internal bool IsSetCoverEntireOrganization()
        {
            return this._coverEntireOrganization.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncidentResponseTeam. 
        /// <para>
        /// Required element used in combination with CreateMembership to add customer incident
        /// response team members and trusted partners to the membership. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=10)]
        public List<IncidentResponder> IncidentResponseTeam
        {
            get { return this._incidentResponseTeam; }
            set { this._incidentResponseTeam = value; }
        }

        // Check to see if IncidentResponseTeam property is set
        internal bool IsSetIncidentResponseTeam()
        {
            return this._incidentResponseTeam != null && (this._incidentResponseTeam.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MembershipName. 
        /// <para>
        /// Required element used in combination with CreateMembership to create a name for the
        /// membership.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=3, Max=50)]
        public string MembershipName
        {
            get { return this._membershipName; }
            set { this._membershipName = value; }
        }

        // Check to see if MembershipName property is set
        internal bool IsSetMembershipName()
        {
            return this._membershipName != null;
        }

        /// <summary>
        /// Gets and sets the property OptInFeatures. 
        /// <para>
        /// Optional element to enable the monitoring and investigation opt-in features for the
        /// service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<OptInFeature> OptInFeatures
        {
            get { return this._optInFeatures; }
            set { this._optInFeatures = value; }
        }

        // Check to see if OptInFeatures property is set
        internal bool IsSetOptInFeatures()
        {
            return this._optInFeatures != null && (this._optInFeatures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional element for customer configured tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}