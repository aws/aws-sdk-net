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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// This is the response object from the BatchGetCollection operation.
    /// </summary>
    public partial class BatchGetCollectionResponse : AmazonWebServiceResponse
    {
        private List<CollectionDetail> _collectionDetails = new List<CollectionDetail>();
        private List<CollectionErrorDetail> _collectionErrorDetails = new List<CollectionErrorDetail>();

        /// <summary>
        /// Gets and sets the property CollectionDetails. 
        /// <para>
        /// Details about each collection.
        /// </para>
        /// </summary>
        public List<CollectionDetail> CollectionDetails
        {
            get { return this._collectionDetails; }
            set { this._collectionDetails = value; }
        }

        // Check to see if CollectionDetails property is set
        internal bool IsSetCollectionDetails()
        {
            return this._collectionDetails != null && this._collectionDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CollectionErrorDetails. 
        /// <para>
        /// Error information for the request.
        /// </para>
        /// </summary>
        public List<CollectionErrorDetail> CollectionErrorDetails
        {
            get { return this._collectionErrorDetails; }
            set { this._collectionErrorDetails = value; }
        }

        // Check to see if CollectionErrorDetails property is set
        internal bool IsSetCollectionErrorDetails()
        {
            return this._collectionErrorDetails != null && this._collectionErrorDetails.Count > 0; 
        }

    }
}