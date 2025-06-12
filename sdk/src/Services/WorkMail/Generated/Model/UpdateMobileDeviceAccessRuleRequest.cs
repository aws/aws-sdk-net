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
    /// Container for the parameters to the UpdateMobileDeviceAccessRule operation.
    /// Updates a mobile device access rule for the specified WorkMail organization.
    /// </summary>
    public partial class UpdateMobileDeviceAccessRuleRequest : AmazonWorkMailRequest
    {
        private string _description;
        private List<string> _deviceModels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _deviceOperatingSystems = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _deviceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _deviceUserAgents = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private MobileDeviceAccessRuleEffect _effect;
        private string _mobileDeviceAccessRuleId;
        private string _name;
        private List<string> _notDeviceModels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _notDeviceOperatingSystems = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _notDeviceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _notDeviceUserAgents = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _organizationId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated rule description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property DeviceModels. 
        /// <para>
        /// Device models that the updated rule will match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> DeviceModels
        {
            get { return this._deviceModels; }
            set { this._deviceModels = value; }
        }

        // Check to see if DeviceModels property is set
        internal bool IsSetDeviceModels()
        {
            return this._deviceModels != null && (this._deviceModels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeviceOperatingSystems. 
        /// <para>
        /// Device operating systems that the updated rule will match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> DeviceOperatingSystems
        {
            get { return this._deviceOperatingSystems; }
            set { this._deviceOperatingSystems = value; }
        }

        // Check to see if DeviceOperatingSystems property is set
        internal bool IsSetDeviceOperatingSystems()
        {
            return this._deviceOperatingSystems != null && (this._deviceOperatingSystems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeviceTypes. 
        /// <para>
        /// Device types that the updated rule will match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> DeviceTypes
        {
            get { return this._deviceTypes; }
            set { this._deviceTypes = value; }
        }

        // Check to see if DeviceTypes property is set
        internal bool IsSetDeviceTypes()
        {
            return this._deviceTypes != null && (this._deviceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeviceUserAgents. 
        /// <para>
        /// User agents that the updated rule will match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> DeviceUserAgents
        {
            get { return this._deviceUserAgents; }
            set { this._deviceUserAgents = value; }
        }

        // Check to see if DeviceUserAgents property is set
        internal bool IsSetDeviceUserAgents()
        {
            return this._deviceUserAgents != null && (this._deviceUserAgents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Effect. 
        /// <para>
        /// The effect of the rule when it matches. Allowed values are <c>ALLOW</c> or <c>DENY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MobileDeviceAccessRuleEffect Effect
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
        /// Gets and sets the property MobileDeviceAccessRuleId. 
        /// <para>
        /// The identifier of the rule to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string MobileDeviceAccessRuleId
        {
            get { return this._mobileDeviceAccessRuleId; }
            set { this._mobileDeviceAccessRuleId = value; }
        }

        // Check to see if MobileDeviceAccessRuleId property is set
        internal bool IsSetMobileDeviceAccessRuleId()
        {
            return this._mobileDeviceAccessRuleId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated rule name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property NotDeviceModels. 
        /// <para>
        /// Device models that the updated rule <b>will not</b> match. All other device models
        /// will match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> NotDeviceModels
        {
            get { return this._notDeviceModels; }
            set { this._notDeviceModels = value; }
        }

        // Check to see if NotDeviceModels property is set
        internal bool IsSetNotDeviceModels()
        {
            return this._notDeviceModels != null && (this._notDeviceModels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotDeviceOperatingSystems. 
        /// <para>
        /// Device operating systems that the updated rule <b>will not</b> match. All other device
        /// operating systems will match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> NotDeviceOperatingSystems
        {
            get { return this._notDeviceOperatingSystems; }
            set { this._notDeviceOperatingSystems = value; }
        }

        // Check to see if NotDeviceOperatingSystems property is set
        internal bool IsSetNotDeviceOperatingSystems()
        {
            return this._notDeviceOperatingSystems != null && (this._notDeviceOperatingSystems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotDeviceTypes. 
        /// <para>
        /// Device types that the updated rule <b>will not</b> match. All other device types will
        /// match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> NotDeviceTypes
        {
            get { return this._notDeviceTypes; }
            set { this._notDeviceTypes = value; }
        }

        // Check to see if NotDeviceTypes property is set
        internal bool IsSetNotDeviceTypes()
        {
            return this._notDeviceTypes != null && (this._notDeviceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotDeviceUserAgents. 
        /// <para>
        /// User agents that the updated rule <b>will not</b> match. All other user agents will
        /// match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> NotDeviceUserAgents
        {
            get { return this._notDeviceUserAgents; }
            set { this._notDeviceUserAgents = value; }
        }

        // Check to see if NotDeviceUserAgents property is set
        internal bool IsSetNotDeviceUserAgents()
        {
            return this._notDeviceUserAgents != null && (this._notDeviceUserAgents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The WorkMail organization under which the rule will be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

    }
}