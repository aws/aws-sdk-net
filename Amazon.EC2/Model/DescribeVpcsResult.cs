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
    /// Describe Vpcs Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class DescribeVpcsResult
    {
        private List<Vpc> vpcField;
        /// <summary>
        /// Gets and sets the Vpc property.
        /// List of VPCs
        /// </summary>
        [XmlElementAttribute(ElementName = "Vpc")]
        public List<Vpc> Vpc
        {
            get
            {
                if (this.vpcField == null)
                {
                    this.vpcField = new List<Vpc>();
                }
                return this.vpcField;
            }
            set { this.vpcField = value; }
        }

        /// <summary>
        /// Sets the Vpc property
        /// </summary>
        /// <param name="list">List of VPCs</param>
        /// <returns>this instance</returns>
        public DescribeVpcsResult WithVpc(params Vpc[] list)
        {
            foreach (Vpc item in list)
            {
                Vpc.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Vpc property is set
        /// </summary>
        /// <returns>true if Vpc property is set</returns>
        public bool IsSetVpc()
        {
            return (Vpc.Count > 0);
        }

    }
}
