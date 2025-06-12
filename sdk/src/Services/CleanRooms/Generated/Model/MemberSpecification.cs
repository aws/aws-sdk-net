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
    /// Basic metadata used to construct a new member.
    /// </summary>
    public partial class MemberSpecification
    {
        private string _accountId;
        private string _displayName;
        private List<string> _memberAbilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private MLMemberAbilities _mlMemberAbilities;
        private PaymentConfiguration _paymentConfiguration;

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
        /// Gets and sets the property MemberAbilities. 
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
        public List<string> MemberAbilities
        {
            get { return this._memberAbilities; }
            set { this._memberAbilities = value; }
        }

        // Check to see if MemberAbilities property is set
        internal bool IsSetMemberAbilities()
        {
            return this._memberAbilities != null && (this._memberAbilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MlMemberAbilities. 
        /// <para>
        /// The ML abilities granted to the collaboration member.
        /// </para>
        /// </summary>
        public MLMemberAbilities MlMemberAbilities
        {
            get { return this._mlMemberAbilities; }
            set { this._mlMemberAbilities = value; }
        }

        // Check to see if MlMemberAbilities property is set
        internal bool IsSetMlMemberAbilities()
        {
            return this._mlMemberAbilities != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentConfiguration. 
        /// <para>
        /// The collaboration member's payment responsibilities set by the collaboration creator.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If the collaboration creator hasn't speciﬁed anyone as the member paying for query
        /// compute costs, then the member who can query is the default payer.
        /// </para>
        /// </summary>
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

    }
}