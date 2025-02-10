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
    /// Grants permissions to create a new membership.
    /// </summary>
    public partial class CreateMembershipRequest : AmazonSecurityIRRequest
    {
        private string _clientToken;
        private List<IncidentResponder> _incidentResponseTeam = AWSConfigs.InitializeCollections ? new List<IncidentResponder>() : null;
        private string _membershipName;
        private List<OptInFeature> _optInFeatures = AWSConfigs.InitializeCollections ? new List<OptInFeature>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// An optional element used in combination with CreateMembership.
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
        /// Gets and sets the property IncidentResponseTeam. 
        /// <para>
        /// Required element use in combination with CreateMembership to add customer incident
        /// response team members and trusted partners to the membership. 
        /// </para>
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
        /// Required element use in combination with CreateMembership to create a name for the
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