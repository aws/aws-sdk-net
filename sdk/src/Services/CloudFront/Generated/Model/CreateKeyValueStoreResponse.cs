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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// This is the response object from the CreateKeyValueStore operation.
    /// </summary>
    public partial class CreateKeyValueStoreResponse : AmazonWebServiceResponse
    {
        private string _eTag;
        private KeyValueStore _keyValueStore;
        private string _location;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The <c>ETag</c> in the resulting key value store.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property KeyValueStore. 
        /// <para>
        /// The resulting key value store.
        /// </para>
        /// </summary>
        public KeyValueStore KeyValueStore
        {
            get { return this._keyValueStore; }
            set { this._keyValueStore = value; }
        }

        // Check to see if KeyValueStore property is set
        internal bool IsSetKeyValueStore()
        {
            return this._keyValueStore != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the resulting key value store.
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

    }
}