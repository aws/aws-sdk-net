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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The details of an option.
    /// </summary>
    public partial class Option
    {
        private List<DBSecurityGroupMembership> _dbSecurityGroupMemberships = AWSConfigs.InitializeCollections ? new List<DBSecurityGroupMembership>() : null;
        private string _optionDescription;
        private string _optionName;
        private List<OptionSetting> _optionSettings = AWSConfigs.InitializeCollections ? new List<OptionSetting>() : null;
        private string _optionVersion;
        private bool? _permanent;
        private bool? _persistent;
        private int? _port;
        private List<VpcSecurityGroupMembership> _vpcSecurityGroupMemberships = AWSConfigs.InitializeCollections ? new List<VpcSecurityGroupMembership>() : null;

        /// <summary>
        /// Gets and sets the property DBSecurityGroupMemberships. 
        /// <para>
        /// If the option requires access to a port, then this DB security group allows access
        /// to the port.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBSecurityGroupMembership> DBSecurityGroupMemberships
        {
            get { return this._dbSecurityGroupMemberships; }
            set { this._dbSecurityGroupMemberships = value; }
        }

        // Check to see if DBSecurityGroupMemberships property is set
        internal bool IsSetDBSecurityGroupMemberships()
        {
            return this._dbSecurityGroupMemberships != null && (this._dbSecurityGroupMemberships.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OptionDescription. 
        /// <para>
        /// The description of the option.
        /// </para>
        /// </summary>
        public string OptionDescription
        {
            get { return this._optionDescription; }
            set { this._optionDescription = value; }
        }

        // Check to see if OptionDescription property is set
        internal bool IsSetOptionDescription()
        {
            return this._optionDescription != null;
        }

        /// <summary>
        /// Gets and sets the property OptionName. 
        /// <para>
        /// The name of the option.
        /// </para>
        /// </summary>
        public string OptionName
        {
            get { return this._optionName; }
            set { this._optionName = value; }
        }

        // Check to see if OptionName property is set
        internal bool IsSetOptionName()
        {
            return this._optionName != null;
        }

        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        /// The option settings for this option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OptionSetting> OptionSettings
        {
            get { return this._optionSettings; }
            set { this._optionSettings = value; }
        }

        // Check to see if OptionSettings property is set
        internal bool IsSetOptionSettings()
        {
            return this._optionSettings != null && (this._optionSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OptionVersion. 
        /// <para>
        /// The version of the option.
        /// </para>
        /// </summary>
        public string OptionVersion
        {
            get { return this._optionVersion; }
            set { this._optionVersion = value; }
        }

        // Check to see if OptionVersion property is set
        internal bool IsSetOptionVersion()
        {
            return this._optionVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Permanent. 
        /// <para>
        /// Indicates whether this option is permanent.
        /// </para>
        /// </summary>
        public bool? Permanent
        {
            get { return this._permanent; }
            set { this._permanent = value; }
        }

        // Check to see if Permanent property is set
        internal bool IsSetPermanent()
        {
            return this._permanent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Persistent. 
        /// <para>
        /// Indicates whether this option is persistent.
        /// </para>
        /// </summary>
        public bool? Persistent
        {
            get { return this._persistent; }
            set { this._persistent = value; }
        }

        // Check to see if Persistent property is set
        internal bool IsSetPersistent()
        {
            return this._persistent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// If required, the port configured for this option to use.
        /// </para>
        /// </summary>
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupMemberships. 
        /// <para>
        /// If the option requires access to a port, then this VPC security group allows access
        /// to the port.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroupMemberships
        {
            get { return this._vpcSecurityGroupMemberships; }
            set { this._vpcSecurityGroupMemberships = value; }
        }

        // Check to see if VpcSecurityGroupMemberships property is set
        internal bool IsSetVpcSecurityGroupMemberships()
        {
            return this._vpcSecurityGroupMemberships != null && (this._vpcSecurityGroupMemberships.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}