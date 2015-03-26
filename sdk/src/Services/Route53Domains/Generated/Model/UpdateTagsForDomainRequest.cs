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
    /// Container for the parameters to the UpdateTagsForDomain operation.
    /// This operation adds or updates tags for a specified domain.
    /// 
    ///  
    /// <para>
    /// All tag operations are eventually consistent; subsequent operations may not immediately
    /// represent all issued operations.
    /// </para>
    /// </summary>
    public partial class UpdateTagsForDomainRequest : AmazonRoute53DomainsRequest
    {
        private string _domainName;
        private List<Tag> _tagsToUpdate = new List<Tag>();

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain for which you want to add or update tags.
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
        /// Gets and sets the property TagsToUpdate. 
        /// <para>
        /// A list of the tag keys and values that you want to add or update. If you specify a
        /// key that already exists, the corresponding value will be replaced.
        /// </para>
        ///  
        /// <para>
        /// Type: A complex type containing a list of tags
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
        /// <para>
        /// Each tag includes the following elements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key
        /// </para>
        ///  
        /// <para>
        /// The key (name) of a tag.
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
        /// Valid values: Unicode characters including alphanumeric, space, and ".:/=+\-%@"
        /// </para>
        ///  
        /// <para>
        /// Constraints: Each key can be 1-128 characters long.
        /// </para>
        ///  
        /// <para>
        /// Required: Yes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Value
        /// </para>
        ///  
        /// <para>
        /// The value of a tag.
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
        /// Valid values: Unicode characters including alphanumeric, space, and ".:/=+\-%@"
        /// </para>
        ///  
        /// <para>
        /// Constraints: Each value can be 0-256 characters long.
        /// </para>
        ///  
        /// <para>
        /// Required: Yes
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Tag> TagsToUpdate
        {
            get { return this._tagsToUpdate; }
            set { this._tagsToUpdate = value; }
        }

        // Check to see if TagsToUpdate property is set
        internal bool IsSetTagsToUpdate()
        {
            return this._tagsToUpdate != null && this._tagsToUpdate.Count > 0; 
        }

    }
}