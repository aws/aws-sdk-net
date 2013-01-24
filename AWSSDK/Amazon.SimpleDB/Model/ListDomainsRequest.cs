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
    /// Lists all domains associated with the account. It returns domain names up to the limit set by MaxNumberOfDomains.
    /// A NextToken is returned if there are more than MaxNumberOfDomains domains. Calling ListDomains successive times
    /// with the NextToken returns up to MaxNumberOfDomains more domain names each time.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sdb.amazonaws.com/doc/2009-04-15/", IsNullable = false)]
    public class ListDomainsRequest : SDBRequest
    {
        private Decimal? maxNumberOfDomainsField;
        private string nextTokenField;

        /// <summary>
        /// Gets and sets the MaxNumberOfDomains property.
        /// The maximum number of domain names you want returned. The range is 1 to 100. The default setting is 100.
        /// </summary>
        [XmlElementAttribute(ElementName = "MaxNumberOfDomains")]
        public Decimal MaxNumberOfDomains
        {
            get { return this.maxNumberOfDomainsField.GetValueOrDefault(); }
            set { this.maxNumberOfDomainsField = value; }
        }

        /// <summary>
        /// Sets the MaxNumberOfDomains property
        /// </summary>
        /// <param name="maxNumberOfDomains">The maximum number of domain names you want returned. The range is 1 to 100. The default setting is 100.</param>
        /// <returns>this instance</returns>
        public ListDomainsRequest WithMaxNumberOfDomains(Decimal maxNumberOfDomains)
        {
            this.maxNumberOfDomainsField = maxNumberOfDomains;
            return this;
        }

        /// <summary>
        /// Checks if MaxNumberOfDomains property is set
        /// </summary>
        /// <returns>true if MaxNumberOfDomains property is set</returns>
        public bool IsSetMaxNumberOfDomains()
        {
            return this.maxNumberOfDomainsField.HasValue;
        }

        /// <summary>
        /// Gets and sets the NextToken property.
        /// String that tells Amazon SimpleDB where to start the next list of domain names.
        /// </summary>
        [XmlElementAttribute(ElementName = "NextToken")]
        public string NextToken
        {
            get { return this.nextTokenField; }
            set { this.nextTokenField = value; }
        }

        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">String that tells Amazon SimpleDB where to start the next list of domain names.</param>
        /// <returns>this instance</returns>
        public ListDomainsRequest WithNextToken(string nextToken)
        {
            this.nextTokenField = nextToken;
            return this;
        }

        /// <summary>
        /// Checks if NextToken property is set
        /// </summary>
        /// <returns>true if NextToken property is set</returns>
        public bool IsSetNextToken()
        {
            return this.nextTokenField != null;
        }

    }
}
