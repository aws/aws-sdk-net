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
    /// Container for the parameters to the DescribeIndexFields operation.
    /// <para>Gets information about the index fields configured for the search domain. Can be limited to specific fields by name. Shows all fields
    /// by default.</para>
    /// </summary>
    /// <seealso cref="Amazon.CloudSearch.AmazonCloudSearch.DescribeIndexFields"/>
    public class DescribeIndexFieldsRequest : AmazonWebServiceRequest
    {
        private string domainName;
        private List<string> fieldNames = new List<string>();

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
        public DescribeIndexFieldsRequest WithDomainName(string domainName)
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
        /// Limits the <c>DescribeIndexFields</c> response to the specified fields.
        ///  
        /// </summary>
        public List<string> FieldNames
        {
            get { return this.fieldNames; }
            set { this.fieldNames = value; }
        }
        /// <summary>
        /// Adds elements to the FieldNames collection
        /// </summary>
        /// <param name="fieldNames">The values to add to the FieldNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeIndexFieldsRequest WithFieldNames(params string[] fieldNames)
        {
            foreach (string element in fieldNames)
            {
                this.fieldNames.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the FieldNames collection
        /// </summary>
        /// <param name="fieldNames">The values to add to the FieldNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeIndexFieldsRequest WithFieldNames(IEnumerable<string> fieldNames)
        {
            foreach (string element in fieldNames)
            {
                this.fieldNames.Add(element);
            }

            return this;
        }

        // Check to see if FieldNames property is set
        internal bool IsSetFieldNames()
        {
            return this.fieldNames.Count > 0;       
        }
    }
}
    
