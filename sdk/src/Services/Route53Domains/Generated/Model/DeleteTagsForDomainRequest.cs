/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteTagsForDomain operation.
    /// This operation deletes the specified tags for a domain.
    /// 
    ///  
    /// <para>
    /// All tag operations are eventually consistent; subsequent operations may not immediately
    /// represent all issued operations.
    /// </para>
    /// </summary>
    public partial class DeleteTagsForDomainRequest : AmazonRoute53DomainsRequest
    {
        private string _domainName;
        private List<string> _tagsToDelete = new List<string>();

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain for which you want to delete one or more tags.
        /// </para>
        ///  
        /// <para>
        /// The name of a domain.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  
        /// <para>
        /// Default: None
        /// </para>
        ///  
        /// <para>
        /// Constraints: The domain name can contain only the letters a through z, the numbers
        /// 0 through 9, and hyphen (-). Hyphens are allowed only when theyaposre surrounded by
        /// letters, numbers, or other hyphens. You canapost specify a hyphen at the beginning
        /// or end of a label. To specify an Internationalized Domain Name, you must convert the
        /// name to Punycode.
        /// </para>
        ///  
        /// <para>
        /// Required: Yes
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property TagsToDelete. 
        /// <para>
        /// A list of tag keys to delete.
        /// </para>
        ///  
        /// <para>
        /// Type: A list that contains the keys of the tags that you want to delete.
        /// </para>
        ///  
        /// <para>
        /// Default: None
        /// </para>
        ///  
        /// <para>
        /// Required: No
        /// </para>
        /// '&gt;
        /// </summary>
        public List<string> TagsToDelete
        {
            get { return this._tagsToDelete; }
            set { this._tagsToDelete = value; }
        }

        // Check to see if TagsToDelete property is set
        internal bool IsSetTagsToDelete()
        {
            return this._tagsToDelete != null && this._tagsToDelete.Count > 0; 
        }

    }
}