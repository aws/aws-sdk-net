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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Specifies the SAML Identity Provider's information.
    /// </summary>
    public partial class SAMLIdp
    {
        private string _entityId;
        private string _metadataContent;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The unique Entity ID of the application in SAML Identity Provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=512)]
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataContent. 
        /// <para>
        /// The Metadata of the SAML application in xml format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1048576)]
        public string MetadataContent
        {
            get { return this._metadataContent; }
            set { this._metadataContent = value; }
        }

        // Check to see if MetadataContent property is set
        internal bool IsSetMetadataContent()
        {
            return this._metadataContent != null;
        }

    }
}