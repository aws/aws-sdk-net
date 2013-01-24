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
        private int? port;
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

        /// <summary>
        /// Sets the OptionName property
        /// </summary>
        /// <param name="optionName">The value to set for the OptionName property </param>
        /// <returns>this instance</returns>
        public Option WithOptionName(string optionName)
        {
            this.optionName = optionName;
            return this;
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

        /// <summary>
        /// Sets the OptionDescription property
        /// </summary>
        /// <param name="optionDescription">The value to set for the OptionDescription property </param>
        /// <returns>this instance</returns>
        public Option WithOptionDescription(string optionDescription)
        {
            this.optionDescription = optionDescription;
            return this;
        }
            

        // Check to see if OptionDescription property is set
        internal bool IsSetOptionDescription()
        {
            return this.optionDescription != null;
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

        /// <summary>
        /// Sets the Port property
        /// </summary>
        /// <param name="port">The value to set for the Port property </param>
        /// <returns>this instance</returns>
        public Option WithPort(int port)
        {
            this.port = port;
            return this;
        }
            

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this.port.HasValue;
        }

        /// <summary>
        /// If the Option requires access to a port, then this DB Security Group allows access to the port.
        ///  
        /// </summary>
        public List<DBSecurityGroupMembership> DBSecurityGroupMemberships
        {
            get { return this.dBSecurityGroupMemberships; }
            set { this.dBSecurityGroupMemberships = value; }
        }
        /// <summary>
        /// Adds elements to the DBSecurityGroupMemberships collection
        /// </summary>
        /// <param name="dBSecurityGroupMemberships">The values to add to the DBSecurityGroupMemberships collection </param>
        /// <returns>this instance</returns>
        public Option WithDBSecurityGroupMemberships(params DBSecurityGroupMembership[] dBSecurityGroupMemberships)
        {
            foreach (DBSecurityGroupMembership element in dBSecurityGroupMemberships)
            {
                this.dBSecurityGroupMemberships.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the DBSecurityGroupMemberships collection
        /// </summary>
        /// <param name="dBSecurityGroupMemberships">The values to add to the DBSecurityGroupMemberships collection </param>
        /// <returns>this instance</returns>
        public Option WithDBSecurityGroupMemberships(IEnumerable<DBSecurityGroupMembership> dBSecurityGroupMemberships)
        {
            foreach (DBSecurityGroupMembership element in dBSecurityGroupMemberships)
            {
                this.dBSecurityGroupMemberships.Add(element);
            }

            return this;
        }

        // Check to see if DBSecurityGroupMemberships property is set
        internal bool IsSetDBSecurityGroupMemberships()
        {
            return this.dBSecurityGroupMemberships.Count > 0;
        }

        /// <summary>
        /// If the Option requires access to a port, then this VPC Security Group allows access to the port.
        ///  
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroupMemberships
        {
            get { return this.vpcSecurityGroupMemberships; }
            set { this.vpcSecurityGroupMemberships = value; }
        }
        /// <summary>
        /// Adds elements to the VpcSecurityGroupMemberships collection
        /// </summary>
        /// <param name="vpcSecurityGroupMemberships">The values to add to the VpcSecurityGroupMemberships collection </param>
        /// <returns>this instance</returns>
        public Option WithVpcSecurityGroupMemberships(params VpcSecurityGroupMembership[] vpcSecurityGroupMemberships)
        {
            foreach (VpcSecurityGroupMembership element in vpcSecurityGroupMemberships)
            {
                this.vpcSecurityGroupMemberships.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the VpcSecurityGroupMemberships collection
        /// </summary>
        /// <param name="vpcSecurityGroupMemberships">The values to add to the VpcSecurityGroupMemberships collection </param>
        /// <returns>this instance</returns>
        public Option WithVpcSecurityGroupMemberships(IEnumerable<VpcSecurityGroupMembership> vpcSecurityGroupMemberships)
        {
            foreach (VpcSecurityGroupMembership element in vpcSecurityGroupMemberships)
            {
                this.vpcSecurityGroupMemberships.Add(element);
            }

            return this;
        }

        // Check to see if VpcSecurityGroupMemberships property is set
        internal bool IsSetVpcSecurityGroupMemberships()
        {
            return this.vpcSecurityGroupMemberships.Count > 0;
        }
    }
}
