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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the PutStoredQuery operation.
    /// Saves a new query or updates an existing saved query. The <c>QueryName</c> must be
    /// unique for a single Amazon Web Services account and a single Amazon Web Services Region.
    /// You can create upto 300 queries in a single Amazon Web Services account and a single
    /// Amazon Web Services Region.
    /// 
    ///  <note> 
    /// <para>
    ///  <b>Tags are added at creation and cannot be updated</b> 
    /// </para>
    ///  
    /// <para>
    ///  <c>PutStoredQuery</c> is an idempotent API. Subsequent requests won’t create a duplicate
    /// resource if one was already created. If a following request has different <c>tags</c>
    /// values, Config will ignore these differences and treat it as an idempotent request
    /// of the previous. In this case, <c>tags</c> will not be updated, even if they are different.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutStoredQueryRequest : AmazonConfigServiceRequest
    {
        private StoredQuery _storedQuery;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property StoredQuery. 
        /// <para>
        /// A list of <c>StoredQuery</c> objects. The mandatory fields are <c>QueryName</c> and
        /// <c>Expression</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you are creating a query, you must provide a query name and an expression. When
        /// you are updating a query, you must provide a query name but updating the description
        /// is optional.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public StoredQuery StoredQuery
        {
            get { return this._storedQuery; }
            set { this._storedQuery = value; }
        }

        // Check to see if StoredQuery property is set
        internal bool IsSetStoredQuery()
        {
            return this._storedQuery != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of <c>Tags</c> object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}