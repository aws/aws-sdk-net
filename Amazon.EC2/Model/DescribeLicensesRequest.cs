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
 *  API Version: 2010-06-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Provides details of a user's registered licenses.
    /// Zero or more IDs may be specified on the call.
    /// When one or more license IDs are specified,
    /// only data for the specified IDs are returned.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2010-06-15/", IsNullable = false)]
    public class DescribeLicensesRequest
    {    
        private List<string> licenseIdField;

        /// <summary>
        /// Gets and sets the LicenseId property.
        /// Specifies the license registration for which
        /// details are to be returned.
        /// </summary>
        [XmlElementAttribute(ElementName = "LicenseId")]
        public List<string> LicenseId
        {
            get
            {
                if (this.licenseIdField == null)
                {
                    this.licenseIdField = new List<string>();
                }
                return this.licenseIdField;
            }
            set { this.licenseIdField = value; }
        }

        /// <summary>
        /// Sets the LicenseId property
        /// </summary>
        /// <param name="list">Specifies the license registration for which
        /// details are to be returned.</param>
        /// <returns>this instance</returns>
        public DescribeLicensesRequest WithLicenseId(params string[] list)
        {
            foreach (string item in list)
            {
                LicenseId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if LicenseId property is set
        /// </summary>
        /// <returns>true if LicenseId property is set</returns>
        public bool IsSetLicenseId()
        {
            return (LicenseId.Count > 0);
        }

    }
}
