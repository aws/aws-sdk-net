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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
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
namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteIndexField operation.
    /// Removes an <c><a>IndexField</a></c> from the search domain. For more information,
    /// see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-index-fields.html"
    /// target="_blank">Configuring Index Fields</a> in the <i>Amazon CloudSearch Developer
    /// Guide</i>.
    /// </summary>
    public partial class DeleteIndexFieldRequest : AmazonCloudSearchRequest
    {
        private string _domainName;
        private string _indexFieldName;

        /// <summary>
        /// Gets and sets the property DomainName.
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=28)]
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
        /// Gets and sets the property IndexFieldName. 
        /// <para>
        /// The name of the index field your want to remove from the domain's indexing options.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string IndexFieldName
        {
            get { return this._indexFieldName; }
            set { this._indexFieldName = value; }
        }

        // Check to see if IndexFieldName property is set
        internal bool IsSetIndexFieldName()
        {
            return this._indexFieldName != null;
        }

    }
}