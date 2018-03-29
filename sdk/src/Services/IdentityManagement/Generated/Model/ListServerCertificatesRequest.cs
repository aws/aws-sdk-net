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
    /// Container for the parameters to the ListServerCertificates operation.
    /// Lists the server certificates stored in IAM that have the specified path prefix. If
    /// none exist, the operation returns an empty list.
    /// 
    ///  
    /// <para>
    ///  You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
    /// parameters.
    /// </para>
    ///  
    /// <para>
    /// For more information about working with server certificates, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
    /// with Server Certificates</a> in the <i>IAM User Guide</i>. This topic also includes
    /// a list of AWS services that can use the server certificates that you manage with IAM.
    /// </para>
    /// </summary>
    public partial class ListServerCertificatesRequest : AmazonIdentityManagementServiceRequest
    {
        private string _marker;
        private int? _maxItems;
        private string _pathPrefix;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ListServerCertificatesRequest() { }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this parameter only when paginating results and only after you receive a response
        /// indicating that the results are truncated. Set it to the value of the <code>Marker</code>
        /// element in the response that you received to indicate where the next call should start.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// (Optional) Use this only when paginating results to indicate the maximum number of
        /// items you want in the response. If additional items exist beyond the maximum you specify,
        /// the <code>IsTruncated</code> response element is <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// If you do not include this parameter, it defaults to 100. Note that IAM might return
        /// fewer results, even when there are more results available. In that case, the <code>IsTruncated</code>
        /// response element returns <code>true</code> and <code>Marker</code> contains a value
        /// to include in the subsequent call that tells the service where to continue from.
        /// </para>
        /// </summary>
        public int MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PathPrefix. 
        /// <para>
        ///  The path prefix for filtering the results. For example: <code>/company/servercerts</code>
        /// would get all server certificates for which the path starts with <code>/company/servercerts</code>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If it is not included, it defaults to a slash (/), listing
        /// all server certificates. This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of either a forward slash (/) by itself
        /// or a string that must begin and end with forward slashes. In addition, it can contain
        /// any ASCII character from the ! (\u0021) through the DEL character (\u007F), including
        /// most punctuation characters, digits, and upper and lowercased letters.
        /// </para>
        /// </summary>
        public string PathPrefix
        {
            get { return this._pathPrefix; }
            set { this._pathPrefix = value; }
        }

        // Check to see if PathPrefix property is set
        internal bool IsSetPathPrefix()
        {
            return this._pathPrefix != null;
        }

    }
}