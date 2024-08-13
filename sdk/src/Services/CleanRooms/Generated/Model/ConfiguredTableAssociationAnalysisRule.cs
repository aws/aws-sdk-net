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
    /// An analysis rule for a configured table association. This analysis rule specifies
    /// how data from the table can be used within its associated collaboration. In the console,
    /// the <c>ConfiguredTableAssociationAnalysisRule</c> is referred to as the <i>collaboration
    /// analysis rule</i>.
    /// </summary>
    public partial class ConfiguredTableAssociationAnalysisRule
    {
        private string _configuredTableAssociationArn;
        private string _configuredTableAssociationId;
        private DateTime? _createTime;
        private string _membershipIdentifier;
        private ConfiguredTableAssociationAnalysisRulePolicy _policy;
        private ConfiguredTableAssociationAnalysisRuleType _type;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property ConfiguredTableAssociationArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the configured table association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string ConfiguredTableAssociationArn
        {
            get { return this._configuredTableAssociationArn; }
            set { this._configuredTableAssociationArn = value; }
        }

        // Check to see if ConfiguredTableAssociationArn property is set
        internal bool IsSetConfiguredTableAssociationArn()
        {
            return this._configuredTableAssociationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConfiguredTableAssociationId. 
        /// <para>
        ///  The unique identifier for the configured table association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ConfiguredTableAssociationId
        {
            get { return this._configuredTableAssociationId; }
            set { this._configuredTableAssociationId = value; }
        }

        // Check to see if ConfiguredTableAssociationId property is set
        internal bool IsSetConfiguredTableAssociationId()
        {
            return this._configuredTableAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        ///  The creation time of the configured table association analysis rule.
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
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        ///  The membership identifier for the configured table association analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        ///  The policy of the configured table association analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfiguredTableAssociationAnalysisRulePolicy Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of the configured table association analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfiguredTableAssociationAnalysisRuleType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        ///  The update time of the configured table association analysis rule.
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