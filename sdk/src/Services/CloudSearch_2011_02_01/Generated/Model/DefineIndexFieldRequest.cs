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
 * Do not modify this file. This file is generated from the cloudsearch-2011-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch_2011_02_01.Model
{
    /// <summary>
    /// Container for the parameters to the DefineIndexField operation.
    /// Configures an <code>IndexField</code> for the search domain. Used to create new fields
    /// and modify existing ones. If the field exists, the new configuration replaces the
    /// old one. You can configure a maximum of 200 index fields.
    /// </summary>
    public partial class DefineIndexFieldRequest : AmazonCloudSearchRequest
    {
        private string _domainName;
        private IndexField _indexField;

        /// <summary>
        /// Gets and sets the property DomainName.
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
        /// Gets and sets the property IndexField.
        /// </summary>
        public IndexField IndexField
        {
            get { return this._indexField; }
            set { this._indexField = value; }
        }

        // Check to see if IndexField property is set
        internal bool IsSetIndexField()
        {
            return this._indexField != null;
        }

    }
}