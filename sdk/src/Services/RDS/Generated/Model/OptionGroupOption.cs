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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Available option.
    /// </summary>
    public partial class OptionGroupOption
    {
        private bool? _copyableCrossAccount;
        private int? _defaultPort;
        private string _description;
        private string _engineName;
        private string _majorEngineVersion;
        private string _minimumRequiredMinorEngineVersion;
        private string _name;
        private List<OptionGroupOptionSetting> _optionGroupOptionSettings = new List<OptionGroupOptionSetting>();
        private List<OptionVersion> _optionGroupOptionVersions = new List<OptionVersion>();
        private List<string> _optionsConflictsWith = new List<string>();
        private List<string> _optionsDependedOn = new List<string>();
        private bool? _permanent;
        private bool? _persistent;
        private bool? _portRequired;
        private bool? _requiresAutoMinorEngineVersionUpgrade;
        private bool? _supportsOptionVersionDowngrade;
        private bool? _vpcOnly;

        /// <summary>
        /// Gets and sets the property CopyableCrossAccount. 
        /// <para>
        /// Specifies whether the option can be copied across Amazon Web Services accounts.
        /// </para>
        /// </summary>
        public bool CopyableCrossAccount
        {
            get { return this._copyableCrossAccount.GetValueOrDefault(); }
            set { this._copyableCrossAccount = value; }
        }

        // Check to see if CopyableCrossAccount property is set
        internal bool IsSetCopyableCrossAccount()
        {
            return this._copyableCrossAccount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultPort. 
        /// <para>
        /// If the option requires a port, specifies the default port for the option.
        /// </para>
        /// </summary>
        public int DefaultPort
        {
            get { return this._defaultPort.GetValueOrDefault(); }
            set { this._defaultPort = value; }
        }

        // Check to see if DefaultPort property is set
        internal bool IsSetDefaultPort()
        {
            return this._defaultPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the option.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EngineName. 
        /// <para>
        /// The name of the engine that this option can be applied to.
        /// </para>
        /// </summary>
        public string EngineName
        {
            get { return this._engineName; }
            set { this._engineName = value; }
        }

        // Check to see if EngineName property is set
        internal bool IsSetEngineName()
        {
            return this._engineName != null;
        }

        /// <summary>
        /// Gets and sets the property MajorEngineVersion. 
        /// <para>
        /// Indicates the major engine version that the option is available for.
        /// </para>
        /// </summary>
        public string MajorEngineVersion
        {
            get { return this._majorEngineVersion; }
            set { this._majorEngineVersion = value; }
        }

        // Check to see if MajorEngineVersion property is set
        internal bool IsSetMajorEngineVersion()
        {
            return this._majorEngineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumRequiredMinorEngineVersion. 
        /// <para>
        /// The minimum required engine version for the option to be applied.
        /// </para>
        /// </summary>
        public string MinimumRequiredMinorEngineVersion
        {
            get { return this._minimumRequiredMinorEngineVersion; }
            set { this._minimumRequiredMinorEngineVersion = value; }
        }

        // Check to see if MinimumRequiredMinorEngineVersion property is set
        internal bool IsSetMinimumRequiredMinorEngineVersion()
        {
            return this._minimumRequiredMinorEngineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the option.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OptionGroupOptionSettings. 
        /// <para>
        /// The option settings that are available (and the default value) for each option in
        /// an option group.
        /// </para>
        /// </summary>
        public List<OptionGroupOptionSetting> OptionGroupOptionSettings
        {
            get { return this._optionGroupOptionSettings; }
            set { this._optionGroupOptionSettings = value; }
        }

        // Check to see if OptionGroupOptionSettings property is set
        internal bool IsSetOptionGroupOptionSettings()
        {
            return this._optionGroupOptionSettings != null && this._optionGroupOptionSettings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OptionGroupOptionVersions. 
        /// <para>
        /// The versions that are available for the option.
        /// </para>
        /// </summary>
        public List<OptionVersion> OptionGroupOptionVersions
        {
            get { return this._optionGroupOptionVersions; }
            set { this._optionGroupOptionVersions = value; }
        }

        // Check to see if OptionGroupOptionVersions property is set
        internal bool IsSetOptionGroupOptionVersions()
        {
            return this._optionGroupOptionVersions != null && this._optionGroupOptionVersions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OptionsConflictsWith. 
        /// <para>
        /// The options that conflict with this option.
        /// </para>
        /// </summary>
        public List<string> OptionsConflictsWith
        {
            get { return this._optionsConflictsWith; }
            set { this._optionsConflictsWith = value; }
        }

        // Check to see if OptionsConflictsWith property is set
        internal bool IsSetOptionsConflictsWith()
        {
            return this._optionsConflictsWith != null && this._optionsConflictsWith.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OptionsDependedOn. 
        /// <para>
        /// The options that are prerequisites for this option.
        /// </para>
        /// </summary>
        public List<string> OptionsDependedOn
        {
            get { return this._optionsDependedOn; }
            set { this._optionsDependedOn = value; }
        }

        // Check to see if OptionsDependedOn property is set
        internal bool IsSetOptionsDependedOn()
        {
            return this._optionsDependedOn != null && this._optionsDependedOn.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Permanent. 
        /// <para>
        /// Permanent options can never be removed from an option group. An option group containing
        /// a permanent option can't be removed from a DB instance.
        /// </para>
        /// </summary>
        public bool Permanent
        {
            get { return this._permanent.GetValueOrDefault(); }
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
        /// Persistent options can't be removed from an option group while DB instances are associated
        /// with the option group. If you disassociate all DB instances from the option group,
        /// your can remove the persistent option from the option group.
        /// </para>
        /// </summary>
        public bool Persistent
        {
            get { return this._persistent.GetValueOrDefault(); }
            set { this._persistent = value; }
        }

        // Check to see if Persistent property is set
        internal bool IsSetPersistent()
        {
            return this._persistent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PortRequired. 
        /// <para>
        /// Specifies whether the option requires a port.
        /// </para>
        /// </summary>
        public bool PortRequired
        {
            get { return this._portRequired.GetValueOrDefault(); }
            set { this._portRequired = value; }
        }

        // Check to see if PortRequired property is set
        internal bool IsSetPortRequired()
        {
            return this._portRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequiresAutoMinorEngineVersionUpgrade. 
        /// <para>
        /// If true, you must enable the Auto Minor Version Upgrade setting for your DB instance
        /// before you can use this option. You can enable Auto Minor Version Upgrade when you
        /// first create your DB instance, or by modifying your DB instance later.
        /// </para>
        /// </summary>
        public bool RequiresAutoMinorEngineVersionUpgrade
        {
            get { return this._requiresAutoMinorEngineVersionUpgrade.GetValueOrDefault(); }
            set { this._requiresAutoMinorEngineVersionUpgrade = value; }
        }

        // Check to see if RequiresAutoMinorEngineVersionUpgrade property is set
        internal bool IsSetRequiresAutoMinorEngineVersionUpgrade()
        {
            return this._requiresAutoMinorEngineVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportsOptionVersionDowngrade. 
        /// <para>
        /// If true, you can change the option to an earlier version of the option. This only
        /// applies to options that have different versions available.
        /// </para>
        /// </summary>
        public bool SupportsOptionVersionDowngrade
        {
            get { return this._supportsOptionVersionDowngrade.GetValueOrDefault(); }
            set { this._supportsOptionVersionDowngrade = value; }
        }

        // Check to see if SupportsOptionVersionDowngrade property is set
        internal bool IsSetSupportsOptionVersionDowngrade()
        {
            return this._supportsOptionVersionDowngrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcOnly. 
        /// <para>
        /// If true, you can only use this option with a DB instance that is in a VPC.
        /// </para>
        /// </summary>
        public bool VpcOnly
        {
            get { return this._vpcOnly.GetValueOrDefault(); }
            set { this._vpcOnly = value; }
        }

        // Check to see if VpcOnly property is set
        internal bool IsSetVpcOnly()
        {
            return this._vpcOnly.HasValue; 
        }

    }
}