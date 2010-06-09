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
 *  API Version: 2009-10-16
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.RDS.Model
{
    ///<summary>
    ///Information about the IP range.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/admin/2009-10-16/", IsNullable = false)]
    public class IPRange
    {
        private string statusField;
        private string CIDRIPField;

        /// <summary>
        /// Gets and sets the Status property.
        /// The status of this range.
        /// </summary>
        [XmlElementAttribute(ElementName = "Status")]
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The status of this range.</param>
        /// <returns>this instance</returns>
        public IPRange WithStatus(string status)
        {
            this.statusField = status;
            return this;
        }

        /// <summary>
        /// Checks if Status property is set
        /// </summary>
        /// <returns>true if Status property is set</returns>
        public bool IsSetStatus()
        {
            return this.statusField != null;
        }

        /// <summary>
        /// Gets and sets the CIDRIP property.
        /// The IP Range. For an overview of CIDR ranges, go to the Wikipedia Tutorial.
        /// </summary>
        [XmlElementAttribute(ElementName = "CIDRIP")]
        public string CIDRIP
        {
            get { return this.CIDRIPField; }
            set { this.CIDRIPField = value; }
        }

        /// <summary>
        /// Sets the CIDRIP property
        /// </summary>
        /// <param name="CIDRIP">The IP Range. For an overview of CIDR ranges, go to the Wikipedia Tutorial.</param>
        /// <returns>this instance</returns>
        public IPRange WithCIDRIP(string CIDRIP)
        {
            this.CIDRIPField = CIDRIP;
            return this;
        }

        /// <summary>
        /// Checks if CIDRIP property is set
        /// </summary>
        /// <returns>true if CIDRIP property is set</returns>
        public bool IsSetCIDRIP()
        {
            return this.CIDRIPField != null;
        }

    }
}
