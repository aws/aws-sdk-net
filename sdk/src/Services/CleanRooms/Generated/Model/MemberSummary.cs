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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
    /// The member object listed by the request.
    /// </summary>
    public partial class MemberSummary
    {
        private List<string> _abilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _accountId;
        private DateTime? _createTime;
        private string _displayName;
        private string _membershipArn;
        private string _membershipId;
        private MLMemberAbilities _mlAbilities;
        private PaymentConfiguration _paymentConfiguration;
        private MemberStatus _status;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property Abilities. 
        /// <para>
        /// The abilities granted to the collaboration member.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Abilities
        {
            get { return this._abilities; }
            set { this._abilities = value; }
        }

        // Check to see if Abilities property is set
        internal bool IsSetAbilities()
        {
            return this._abilities != null && (this._abilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The identifier used to reference members of the collaboration. Currently only supports
        /// Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time when the member was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The member's display name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property MembershipArn. 
        /// <para>
        /// The unique ARN for the member's associated membership, if present.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public string MembershipArn
        {
            get { return this._membershipArn; }
            set { this._membershipArn = value; }
        }

        // Check to see if MembershipArn property is set
        internal bool IsSetMembershipArn()
        {
            return this._membershipArn != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipId. 
        /// <para>
        /// The unique ID for the member's associated membership, if present.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string MembershipId
        {
            get { return this._membershipId; }
            set { this._membershipId = value; }
        }

        // Check to see if MembershipId property is set
        internal bool IsSetMembershipId()
        {
            return this._membershipId != null;
        }

        /// <summary>
        /// Gets and sets the property MlAbilities. 
        /// <para>
        /// Provides a summary of the ML abilities for the collaboration member.
        /// </para>
        /// </summary>
        public MLMemberAbilities MlAbilities
        {
            get { return this._mlAbilities; }
            set { this._mlAbilities = value; }
        }

        // Check to see if MlAbilities property is set
        internal bool IsSetMlAbilities()
        {
            return this._mlAbilities != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentConfiguration. 
        /// <para>
        /// The collaboration member's payment responsibilities set by the collaboration creator.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentConfiguration PaymentConfiguration
        {
            get { return this._paymentConfiguration; }
            set { this._paymentConfiguration = value; }
        }

        // Check to see if PaymentConfiguration property is set
        internal bool IsSetPaymentConfiguration()
        {
            return this._paymentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the member. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemberStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time the member metadata was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}