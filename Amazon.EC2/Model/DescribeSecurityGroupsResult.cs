/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-11-30
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describe Security Groups Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class DescribeSecurityGroupsResult
    {
        private List<SecurityGroup> securityGroupField;
        /// <summary>
        /// Gets and sets the SecurityGroup property.
        /// List of security groups
        /// </summary>
        [XmlElementAttribute(ElementName = "SecurityGroup")]
        public List<SecurityGroup> SecurityGroup
        {
            get
            {
                if (this.securityGroupField == null)
                {
                    this.securityGroupField = new List<SecurityGroup>();
                }
                return this.securityGroupField;
            }
            set { this.securityGroupField = value; }
        }

        /// <summary>
        /// Sets the SecurityGroup property
        /// </summary>
        /// <param name="list">List of security groups</param>
        /// <returns>this instance</returns>
        public DescribeSecurityGroupsResult WithSecurityGroup(params SecurityGroup[] list)
        {
            foreach (SecurityGroup item in list)
            {
                SecurityGroup.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if SecurityGroup property is set
        /// </summary>
        /// <returns>true if SecurityGroup property is set</returns>
        public bool IsSetSecurityGroup()
        {
            return (SecurityGroup.Count > 0);
        }

    }
}
