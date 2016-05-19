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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the response to a successful <a>GetOpenIDConnectProvider</a> request.
    /// </summary>
    public partial class GetOpenIDConnectProviderResponse : AmazonWebServiceResponse
    {
        private List<string> _clientIDList = new List<string>();
        private DateTime? _createDate;
        private List<string> _thumbprintList = new List<string>();
        private string _url;

        /// <summary>
        /// Gets and sets the property ClientIDList. 
        /// <para>
        /// A list of client IDs (also known as audiences) that are associated with the specified
        /// IAM OIDC provider resource object. For more information, see <a>CreateOpenIDConnectProvider</a>.
        /// </para>
        /// </summary>
        public List<string> ClientIDList
        {
            get { return this._clientIDList; }
            set { this._clientIDList = value; }
        }

        // Check to see if ClientIDList property is set
        internal bool IsSetClientIDList()
        {
            return this._clientIDList != null && this._clientIDList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time when the IAM OIDC provider resource object was created in the AWS
        /// account.
        /// </para>
        /// </summary>
        public DateTime CreateDate
        {
            get { return this._createDate.GetValueOrDefault(); }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThumbprintList. 
        /// <para>
        /// A list of certificate thumbprints that are associated with the specified IAM OIDC
        /// provider resource object. For more information, see <a>CreateOpenIDConnectProvider</a>.
        /// 
        /// </para>
        /// </summary>
        public List<string> ThumbprintList
        {
            get { return this._thumbprintList; }
            set { this._thumbprintList = value; }
        }

        // Check to see if ThumbprintList property is set
        internal bool IsSetThumbprintList()
        {
            return this._thumbprintList != null && this._thumbprintList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL that the IAM OIDC provider resource object is associated with. For more information,
        /// see <a>CreateOpenIDConnectProvider</a>.
        /// </para>
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}