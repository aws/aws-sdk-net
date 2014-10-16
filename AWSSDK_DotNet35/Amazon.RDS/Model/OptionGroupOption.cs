/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the rds-2014-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Available option.
    /// </summary>
    public partial class OptionGroupOption
    {
        private int? _defaultPort;
        private string _description;
        private string _engineName;
        private string _majorEngineVersion;
        private string _minimumRequiredMinorEngineVersion;
        private string _name;
        private List<OptionGroupOptionSetting> _optionGroupOptionSettings = new List<OptionGroupOptionSetting>();
        private List<string> _optionsDependedOn = new List<string>();
        private bool? _permanent;
        private bool? _persistent;
        private bool? _portRequired;

        /// <summary>
        /// Gets and sets the property DefaultPort. 
        /// <para>
        ///  If the option requires a port, specifies the default port for the option. 
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
        ///  The description of the option. 
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
        ///  Engine name that this option can be applied to. 
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
        ///  Indicates the major engine version that the option is available for. 
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
        ///  The minimum required engine version for the option to be applied. 
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
        ///  The name of the option. 
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
        ///  Specifies the option settings that are available (and the default value) for each
        /// option in an option group. 
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
        /// Gets and sets the property OptionsDependedOn. 
        /// <para>
        ///  List of all options that are prerequisites for this option. 
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
        ///  A permanent option cannot be removed from the option group once the option group
        /// is used, and it cannot be removed from the db instance after assigning an option group
        /// with this permanent option. 
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
        ///  A persistent option cannot be removed from the option group once the option group
        /// is used, but this option can be removed from the db instance while modifying the related
        /// data and assigning another option group without this option. 
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
        ///  Specifies whether the option requires a port. 
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

    }
}