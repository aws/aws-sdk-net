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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateStemmingOptions operation.
    /// <para>Configures a stemming dictionary for the search domain. The stemming dictionary is used during indexing and when processing search
    /// requests. The maximum size of the stemming dictionary is 500KB.</para>
    /// </summary>
    /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.UpdateStemmingOptions"/>
    public class UpdateStemmingOptionsRequest : AmazonWebServiceRequest
    {
        private string domainName;
        private string stems;

        /// <summary>
        /// A string that represents the name of a domain. Domain names must be unique across the domains owned by an account within an AWS region.
        /// Domain names must start with a letter or number and can contain the following characters: a-z (lowercase), 0-9, and - (hyphen). Uppercase
        /// letters and underscores are not allowed.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 28</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-z][a-z0-9\-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this.domainName; }
            set { this.domainName = value; }
        }

        /// <summary>
        /// Sets the DomainName property
        /// </summary>
        /// <param name="domainName">The value to set for the DomainName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateStemmingOptionsRequest WithDomainName(string domainName)
        {
            this.domainName = domainName;
            return this;
        }
            

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this.domainName != null;       
        }

        /// <summary>
        /// Maps terms to their stems, serialized as a JSON document. The document has a single object with one property "stems" whose value is an
        /// object mapping terms to their stems. The maximum size of a stemming document is 500KB. Example: <c>{ "stems": {"people": "person",
        /// "walking": "walk"} }</c>
        ///  
        /// </summary>
        public string Stems
        {
            get { return this.stems; }
            set { this.stems = value; }
        }

        /// <summary>
        /// Sets the Stems property
        /// </summary>
        /// <param name="stems">The value to set for the Stems property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateStemmingOptionsRequest WithStems(string stems)
        {
            this.stems = stems;
            return this;
        }
            

        // Check to see if Stems property is set
        internal bool IsSetStems()
        {
            return this.stems != null;       
        }
    }
}
    
