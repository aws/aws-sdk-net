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
    /// A list of all available options
    /// </summary>
    public partial class OptionConfiguration
    {
        private List<string> _dBSecurityGroupMemberships = new List<string>();
        private string _optionName;
        private List<OptionSetting> _optionSettings = new List<OptionSetting>();
        private int? _port;
        private List<string> _vpcSecurityGroupMemberships = new List<string>();

        /// <summary>
        /// Gets and sets the property DBSecurityGroupMemberships. 
        /// <para>
        ///  A list of DBSecurityGroupMemebrship name strings used for this option. 
        /// </para>
        /// </summary>
        public List<string> DBSecurityGroupMemberships
        {
            get { return this._dBSecurityGroupMemberships; }
            set { this._dBSecurityGroupMemberships = value; }
        }

        // Check to see if DBSecurityGroupMemberships property is set
        internal bool IsSetDBSecurityGroupMemberships()
        {
            return this._dBSecurityGroupMemberships != null && this._dBSecurityGroupMemberships.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OptionName. 
        /// <para>
        ///  The configuration of options to include in a group. 
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
        ///  The option settings to include in an option group. 
        /// </para>
        /// </summary>
        public List<OptionSetting> OptionSettings
        {
            get { return this._optionSettings; }
            set { this._optionSettings = value; }
        }

        // Check to see if OptionSettings property is set
        internal bool IsSetOptionSettings()
        {
            return this._optionSettings != null && this._optionSettings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        ///  The optional port for the option. 
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
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
        ///  A list of VpcSecurityGroupMemebrship name strings used for this option. 
        /// </para>
        /// </summary>
        public List<string> VpcSecurityGroupMemberships
        {
            get { return this._vpcSecurityGroupMemberships; }
            set { this._vpcSecurityGroupMemberships = value; }
        }

        // Check to see if VpcSecurityGroupMemberships property is set
        internal bool IsSetVpcSecurityGroupMemberships()
        {
            return this._vpcSecurityGroupMemberships != null && this._vpcSecurityGroupMemberships.Count > 0; 
        }

    }
}