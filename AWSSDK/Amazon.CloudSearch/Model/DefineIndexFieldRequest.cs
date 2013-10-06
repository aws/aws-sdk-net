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
    /// Container for the parameters to the DefineIndexField operation.
    /// <para>Configures an <c>IndexField</c> for the search domain. Used to create new fields and modify existing ones. If the field exists, the
    /// new configuration replaces the old one. You can configure a maximum of 200 index fields.</para>
    /// </summary>
    /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DefineIndexField"/>
    public class DefineIndexFieldRequest : AmazonWebServiceRequest
    {
        private string domainName;
        private IndexField indexField;

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
        public DefineIndexFieldRequest WithDomainName(string domainName)
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
        /// Defines a field in the index, including its name, type, and the source of its data. The <c>IndexFieldType</c> indicates which of the options
        /// will be present. It is invalid to specify options for a type other than the <c>IndexFieldType</c>.
        ///  
        /// </summary>
        public IndexField IndexField
        {
            get { return this.indexField; }
            set { this.indexField = value; }
        }

        /// <summary>
        /// Sets the IndexField property
        /// </summary>
        /// <param name="indexField">The value to set for the IndexField property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DefineIndexFieldRequest WithIndexField(IndexField indexField)
        {
            this.indexField = indexField;
            return this;
        }
            

        // Check to see if IndexField property is set
        internal bool IsSetIndexField()
        {
            return this.indexField != null;       
        }
    }
}
    
