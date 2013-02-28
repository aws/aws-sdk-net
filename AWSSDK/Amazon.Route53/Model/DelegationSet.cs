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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// <para>A complex type that contains name server information.</para>
    /// </summary>
    public class DelegationSet
    {
        
        private List<string> nameServers = new List<string>();

        /// <summary>
        /// A complex type that contains the authoritative name servers for the hosted zone. Use the method provided by your domain registrar to add an
        /// NS record to your domain for each <c>NameServer</c> that is assigned to your hosted zone.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> NameServers
        {
            get { return this.nameServers; }
            set { this.nameServers = value; }
        }
        /// <summary>
        /// Adds elements to the NameServers collection
        /// </summary>
        /// <param name="nameServers">The values to add to the NameServers collection </param>
        /// <returns>this instance</returns>
        public DelegationSet WithNameServers(params string[] nameServers)
        {
            foreach (string element in nameServers)
            {
                this.nameServers.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the NameServers collection
        /// </summary>
        /// <param name="nameServers">The values to add to the NameServers collection </param>
        /// <returns>this instance</returns>
        public DelegationSet WithNameServers(IEnumerable<string> nameServers)
        {
            foreach (string element in nameServers)
            {
                this.nameServers.Add(element);
            }

            return this;
        }

        // Check to see if NameServers property is set
        internal bool IsSetNameServers()
        {
            return this.nameServers.Count > 0;
        }
    }
}
