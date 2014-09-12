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
 * Do not modify this file. This file is generated from the rds-2013-09-09.normal.json service model.
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
    /// Option details.
    /// </summary>
    public partial class Option
    {
        private List<DBSecurityGroupMembership> _dBSecurityGroupMemberships = new List<DBSecurityGroupMembership>();
        private string _optionDescription;
        private string _optionName;
        private List<OptionSetting> _optionSettings = new List<OptionSetting>();
        private bool? _permanent;
        private bool? _persistent;
        private int? _port;
        private List<VpcSecurityGroupMembership> _vpcSecurityGroupMemberships = new List<VpcSecurityGroupMembership>();

        /// <summary>
        /// Gets and sets the property DBSecurityGroupMemberships. 
        /// <para>
        ///  If the option requires access to a port, then this DB security group allows access
        /// to the port. 
        /// </para>
        /// </summary>
        public List<DBSecurityGroupMembership> DBSecurityGroupMemberships
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
        /// Gets and sets the property OptionDescription. 
        /// <para>
        ///  The description of the option. 
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
        ///  The name of the option. 
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
        ///  The option settings for this option. 
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
        /// Gets and sets the property Permanent. 
        /// <para>
        /// Indicate if this option is permanent.
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
        ///  Indicate if this option is persistent. 
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
        /// Gets and sets the property Port. 
        /// <para>
        ///  If required, the port configured for this option to use. 
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
        ///  If the option requires access to a port, then this VPC security group allows access
        /// to the port. 
        /// </para>
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroupMemberships
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