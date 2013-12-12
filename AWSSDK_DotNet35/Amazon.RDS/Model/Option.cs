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
    /// <para> Option details. </para>
    /// </summary>
    public class Option
    {
        
        private string optionName;
        private string optionDescription;
        private bool? persistent;
        private bool? permanent;
        private int? port;
        private List<OptionSetting> optionSettings = new List<OptionSetting>();
        private List<DBSecurityGroupMembership> dBSecurityGroupMemberships = new List<DBSecurityGroupMembership>();
        private List<VpcSecurityGroupMembership> vpcSecurityGroupMemberships = new List<VpcSecurityGroupMembership>();


        /// <summary>
        /// The name of the option.
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
        /// The description of the option.
        ///  
        /// </summary>
        public string OptionDescription
        {
            get { return this.optionDescription; }
            set { this.optionDescription = value; }
        }

        // Check to see if OptionDescription property is set
        internal bool IsSetOptionDescription()
        {
            return this.optionDescription != null;
        }

        /// <summary>
        /// Indicate if this option is persistent.
        ///  
        /// </summary>
        public bool Persistent
        {
            get { return this.persistent ?? default(bool); }
            set { this.persistent = value; }
        }

        // Check to see if Persistent property is set
        internal bool IsSetPersistent()
        {
            return this.persistent.HasValue;
        }

        /// <summary>
        /// Indicate if this option is permanent.
        ///  
        /// </summary>
        public bool Permanent
        {
            get { return this.permanent ?? default(bool); }
            set { this.permanent = value; }
        }

        // Check to see if Permanent property is set
        internal bool IsSetPermanent()
        {
            return this.permanent.HasValue;
        }

        /// <summary>
        /// If required, the port configured for this option to use.
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
        /// The option settings for this option.
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

        /// <summary>
        /// If the option requires access to a port, then this DB security group allows access to the port.
        ///  
        /// </summary>
        public List<DBSecurityGroupMembership> DBSecurityGroupMemberships
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
        /// If the option requires access to a port, then this VPC security group allows access to the port.
        ///  
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroupMemberships
        {
            get { return this.vpcSecurityGroupMemberships; }
            set { this.vpcSecurityGroupMemberships = value; }
        }

        // Check to see if VpcSecurityGroupMemberships property is set
        internal bool IsSetVpcSecurityGroupMemberships()
        {
            return this.vpcSecurityGroupMemberships.Count > 0;
        }
    }
}
