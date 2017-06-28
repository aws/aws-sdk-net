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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// This is the response object from the ListTagOptions operation.
    /// </summary>
    public partial class ListTagOptionsResponse : AmazonWebServiceResponse
    {
        private string _pageToken;
        private List<TagOptionDetail> _tagOptionDetails = new List<TagOptionDetail>();

        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// The page token of the first page retrieved. If null, this retrieves the first page
        /// of size <code>PageSize</code>.
        /// </para>
        /// </summary>
        public string PageToken
        {
            get { return this._pageToken; }
            set { this._pageToken = value; }
        }

        // Check to see if PageToken property is set
        internal bool IsSetPageToken()
        {
            return this._pageToken != null;
        }

        /// <summary>
        /// Gets and sets the property TagOptionDetails. 
        /// <para>
        /// The resulting detailed TagOption information.
        /// </para>
        /// </summary>
        public List<TagOptionDetail> TagOptionDetails
        {
            get { return this._tagOptionDetails; }
            set { this._tagOptionDetails = value; }
        }

        // Check to see if TagOptionDetails property is set
        internal bool IsSetTagOptionDetails()
        {
            return this._tagOptionDetails != null && this._tagOptionDetails.Count > 0; 
        }

    }
}