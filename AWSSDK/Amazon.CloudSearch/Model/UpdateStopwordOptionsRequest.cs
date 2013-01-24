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
    /// Container for the parameters to the UpdateStopwordOptions operation.
    /// <para>Configures stopwords for the search domain. Stopwords are used during indexing and when processing search requests. The maximum size
    /// of the stopwords dictionary is 10KB.</para>
    /// </summary>
    /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.UpdateStopwordOptions"/>
    public class UpdateStopwordOptionsRequest : AmazonWebServiceRequest
    {
        private string domainName;
        private string stopwords;

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
        public UpdateStopwordOptionsRequest WithDomainName(string domainName)
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
        /// Lists stopwords serialized as a JSON document. The document has a single object with one property "stopwords" whose value is an array of
        /// strings. The maximum size of a stopwords document is 10KB. Example: <c>{ "stopwords": ["a", "an", "the", "of"] }</c>
        ///  
        /// </summary>
        public string Stopwords
        {
            get { return this.stopwords; }
            set { this.stopwords = value; }
        }

        /// <summary>
        /// Sets the Stopwords property
        /// </summary>
        /// <param name="stopwords">The value to set for the Stopwords property </param>
        /// <returns>this instance</returns>
        public UpdateStopwordOptionsRequest WithStopwords(string stopwords)
        {
            this.stopwords = stopwords;
            return this;
        }
            

        // Check to see if Stopwords property is set
        internal bool IsSetStopwords()
        {
            return this.stopwords != null;       
        }
    }
}
    
