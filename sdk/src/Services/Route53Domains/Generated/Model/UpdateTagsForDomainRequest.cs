/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTagsForDomain operation.
    /// This operation adds or updates tags for a specified domain.
    /// 
    ///  
    /// <para>
    /// All tag operations are eventually consistent; subsequent operations might not immediately
    /// represent all issued operations.
    /// </para>
    /// </summary>
    public partial class UpdateTagsForDomainRequest : AmazonRoute53DomainsRequest
    {
        private string _domainName;
        private List<Tag> _tagsToUpdate = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain for which you want to add or update tags.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagsToUpdate
        {
            get { return this._tagsToUpdate; }
            set { this._tagsToUpdate = value; }
        }

        // Check to see if TagsToUpdate property is set
        internal bool IsSetTagsToUpdate()
        {
            return this._tagsToUpdate != null && (this._tagsToUpdate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}