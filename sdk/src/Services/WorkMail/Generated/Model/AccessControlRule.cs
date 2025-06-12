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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// A rule that controls access to an WorkMail organization.
    /// </summary>
    public partial class AccessControlRule
    {
        private List<string> _actions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _dateCreated;
        private DateTime? _dateModified;
        private string _description;
        private AccessControlRuleEffect _effect;
        private List<string> _impersonationRoleIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _ipRanges = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private List<string> _notActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _notImpersonationRoleIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _notIpRanges = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _notUserIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _userIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// Access protocol actions to include in the rule. Valid values include <c>ActiveSync</c>,
        /// <c>AutoDiscover</c>, <c>EWS</c>, <c>IMAP</c>, <c>SMTP</c>, <c>WindowsOutlook</c>,
        /// and <c>WebMail</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date that the rule was created.
        /// </para>
        /// </summary>
        public DateTime? DateCreated
        {
            get { return this._dateCreated; }
            set { this._dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DateModified. 
        /// <para>
        /// The date that the rule was modified.
        /// </para>
        /// </summary>
        public DateTime? DateModified
        {
            get { return this._dateModified; }
            set { this._dateModified = value; }
        }

        // Check to see if DateModified property is set
        internal bool IsSetDateModified()
        {
            return this._dateModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The rule description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Effect. 
        /// <para>
        /// The rule effect.
        /// </para>
        /// </summary>
        public AccessControlRuleEffect Effect
        {
            get { return this._effect; }
            set { this._effect = value; }
        }

        // Check to see if Effect property is set
        internal bool IsSetEffect()
        {
            return this._effect != null;
        }

        /// <summary>
        /// Gets and sets the property ImpersonationRoleIds. 
        /// <para>
        /// Impersonation role IDs to include in the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> ImpersonationRoleIds
        {
            get { return this._impersonationRoleIds; }
            set { this._impersonationRoleIds = value; }
        }

        // Check to see if ImpersonationRoleIds property is set
        internal bool IsSetImpersonationRoleIds()
        {
            return this._impersonationRoleIds != null && (this._impersonationRoleIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpRanges. 
        /// <para>
        /// IPv4 CIDR ranges to include in the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public List<string> IpRanges
        {
            get { return this._ipRanges; }
            set { this._ipRanges = value; }
        }

        // Check to see if IpRanges property is set
        internal bool IsSetIpRanges()
        {
            return this._ipRanges != null && (this._ipRanges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The rule name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NotActions. 
        /// <para>
        /// Access protocol actions to exclude from the rule. Valid values include <c>ActiveSync</c>,
        /// <c>AutoDiscover</c>, <c>EWS</c>, <c>IMAP</c>, <c>SMTP</c>, <c>WindowsOutlook</c>,
        /// and <c>WebMail</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> NotActions
        {
            get { return this._notActions; }
            set { this._notActions = value; }
        }

        // Check to see if NotActions property is set
        internal bool IsSetNotActions()
        {
            return this._notActions != null && (this._notActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotImpersonationRoleIds. 
        /// <para>
        /// Impersonation role IDs to exclude from the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> NotImpersonationRoleIds
        {
            get { return this._notImpersonationRoleIds; }
            set { this._notImpersonationRoleIds = value; }
        }

        // Check to see if NotImpersonationRoleIds property is set
        internal bool IsSetNotImpersonationRoleIds()
        {
            return this._notImpersonationRoleIds != null && (this._notImpersonationRoleIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotIpRanges. 
        /// <para>
        /// IPv4 CIDR ranges to exclude from the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public List<string> NotIpRanges
        {
            get { return this._notIpRanges; }
            set { this._notIpRanges = value; }
        }

        // Check to see if NotIpRanges property is set
        internal bool IsSetNotIpRanges()
        {
            return this._notIpRanges != null && (this._notIpRanges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotUserIds. 
        /// <para>
        /// User IDs to exclude from the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> NotUserIds
        {
            get { return this._notUserIds; }
            set { this._notUserIds = value; }
        }

        // Check to see if NotUserIds property is set
        internal bool IsSetNotUserIds()
        {
            return this._notUserIds != null && (this._notUserIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserIds. 
        /// <para>
        /// User IDs to include in the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> UserIds
        {
            get { return this._userIds; }
            set { this._userIds = value; }
        }

        // Check to see if UserIds property is set
        internal bool IsSetUserIds()
        {
            return this._userIds != null && (this._userIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}