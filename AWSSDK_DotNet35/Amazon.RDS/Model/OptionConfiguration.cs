/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para> A list of all available options </para>
    /// </summary>
    public class OptionConfiguration
    {
        
        private string optionName;
        private int? port;
        private List<string> dBSecurityGroupMemberships = new List<string>();
        private List<string> vpcSecurityGroupMemberships = new List<string>();
        private List<OptionSetting> optionSettings = new List<OptionSetting>();


        /// <summary>
        /// The configuration of options to include in a group.
        ///  
        /// </summary>
        public string OptionName
        {
            get { return this.optionName; }
            set { this.optionName = value; }
        }

        // Check to see if OptionName property is set
        internal bool IsSetOptionName()
        {
            return this.optionName != null;
        }

        /// <summary>
        /// The optional port for the option.
        ///  
        /// </summary>
        public int Port
        {
            get { return this.port ?? default(int); }
            set { this.port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this.port.HasValue;
        }

        /// <summary>
        /// A list of DBSecurityGroupMemebrship name strings used for this option.
        ///  
        /// </summary>
        public List<string> DBSecurityGroupMemberships
        {
            get { return this.dBSecurityGroupMemberships; }
            set { this.dBSecurityGroupMemberships = value; }
        }

        // Check to see if DBSecurityGroupMemberships property is set
        internal bool IsSetDBSecurityGroupMemberships()
        {
            return this.dBSecurityGroupMemberships.Count > 0;
        }

        /// <summary>
        /// A list of VpcSecurityGroupMemebrship name strings used for this option.
        ///  
        /// </summary>
        public List<string> VpcSecurityGroupMemberships
        {
            get { return this.vpcSecurityGroupMemberships; }
            set { this.vpcSecurityGroupMemberships = value; }
        }

        // Check to see if VpcSecurityGroupMemberships property is set
        internal bool IsSetVpcSecurityGroupMemberships()
        {
            return this.vpcSecurityGroupMemberships.Count > 0;
        }

        /// <summary>
        /// The option settings to include in an option group.
        ///  
        /// </summary>
        public List<OptionSetting> OptionSettings
        {
            get { return this.optionSettings; }
            set { this.optionSettings = value; }
        }

        // Check to see if OptionSettings property is set
        internal bool IsSetOptionSettings()
        {
            return this.optionSettings.Count > 0;
        }
    }
}
