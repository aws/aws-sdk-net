/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <summary>Option Configuration
    /// </summary>
    public class OptionConfiguration  
    {
        
        private string optionName;
        private int? port;
        private List<string> dBSecurityGroupMemberships = new List<string>();
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
        public OptionConfiguration WithOptionName(string optionName)
        {
            this.optionName = optionName;
            return this;
        }
            

        // Check to see if OptionName property is set
        internal bool IsSetOptionName()
        {
            return this.optionName != null;       
        }
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
        public OptionConfiguration WithPort(int port)
        {
            this.port = port;
            return this;
        }
            

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this.port.HasValue;       
        }
        public List<string> DBSecurityGroupMemberships
        {
            get { return this.dBSecurityGroupMemberships; }
            set { this.dBSecurityGroupMemberships = value; }
        }
        /// <summary>
        /// Adds elements to the DBSecurityGroupMemberships collection
        /// </summary>
        /// <param name="dBSecurityGroupMemberships">The values to add to the DBSecurityGroupMemberships collection </param>
        /// <returns>this instance</returns>
        public OptionConfiguration WithDBSecurityGroupMemberships(params string[] dBSecurityGroupMemberships)
        {
            foreach (string element in dBSecurityGroupMemberships)
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
        public OptionConfiguration WithDBSecurityGroupMemberships(IEnumerable<string> dBSecurityGroupMemberships)
        {
            foreach (string element in dBSecurityGroupMemberships)
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
    }
}
