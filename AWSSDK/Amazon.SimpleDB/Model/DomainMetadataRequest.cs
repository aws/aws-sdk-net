/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2009-04-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// Returns information about the domain, including when the domain was created, the number of items and
    /// attributes, and the size of attribute names and values.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sdb.amazonaws.com/doc/2009-04-15/", IsNullable = false)]
    public class DomainMetadataRequest : SDBRequest
    {
        private string domainNameField;

        /// <summary>
        /// Gets and sets the DomainName property.
        /// The name of the domain for which to display metadata.
        /// </summary>
        [XmlElementAttribute(ElementName = "DomainName")]
        public string DomainName
        {
            get { return this.domainNameField; }
            set { this.domainNameField = value; }
        }

        /// <summary>
        /// Sets the DomainName property
        /// </summary>
        /// <param name="domainName">The name of the domain for which to display metadata.</param>
        /// <returns>this instance</returns>
        public DomainMetadataRequest WithDomainName(string domainName)
        {
            this.domainNameField = domainName;
            return this;
        }

        /// <summary>
        /// Checks if DomainName property is set
        /// </summary>
        /// <returns>true if DomainName property is set</returns>
        public bool IsSetDomainName()
        {
            return this.domainNameField != null;
        }

    }
}
