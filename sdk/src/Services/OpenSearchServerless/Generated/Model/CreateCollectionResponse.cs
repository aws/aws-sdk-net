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
    /// This is the response object from the CreateCollection operation.
    /// </summary>
    public partial class CreateCollectionResponse : AmazonWebServiceResponse
    {
        private CreateCollectionDetail _createCollectionDetail;

        /// <summary>
        /// Gets and sets the property CreateCollectionDetail. 
        /// <para>
        /// Details about the collection.
        /// </para>
        /// </summary>
        public CreateCollectionDetail CreateCollectionDetail
        {
            get { return this._createCollectionDetail; }
            set { this._createCollectionDetail = value; }
        }

        // Check to see if CreateCollectionDetail property is set
        internal bool IsSetCreateCollectionDetail()
        {
            return this._createCollectionDetail != null;
        }

    }
}