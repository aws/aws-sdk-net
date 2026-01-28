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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies how requests are redirected. In the event of an error, you can specify a
    /// different error code to return.
    /// </summary>
    public partial class RoutingRuleRedirect
    {
        private string _hostName;
        private string _httpRedirectCode;
        private string _protocol;
        private string _replaceKeyPrefixWith;
        private string _replaceKeyWith;

        /// <summary>
        /// Gets and sets the property HostName. 
        /// <para>
        /// The host name to use in the redirect request.
        /// </para>
        /// </summary>
        public string HostName
        {
            get { return this._hostName; }
            set { this._hostName = value; }
        }

        // Check to see if HostName property is set
        internal bool IsSetHostName()
        {
            return this._hostName != null;
        }

        /// <summary>
        /// Gets and sets the property HttpRedirectCode. 
        /// <para>
        /// The HTTP redirect code to use on the response. Not required if one of the siblings
        /// is present.
        /// </para>
        /// </summary>
        public string HttpRedirectCode
        {
            get { return this._httpRedirectCode; }
            set { this._httpRedirectCode = value; }
        }

        // Check to see if HttpRedirectCode property is set
        internal bool IsSetHttpRedirectCode()
        {
            return this._httpRedirectCode != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// Protocol to use when redirecting requests. The default is the protocol that is used
        /// in the original request.
        /// </para>
        /// </summary>
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property ReplaceKeyPrefixWith. 
        /// <para>
        /// The object key prefix to use in the redirect request. For example, to redirect requests
        /// for all pages with prefix <c>docs/</c> (objects in the <c>docs/</c> folder) to <c>documents/</c>,
        /// you can set a condition block with <c>KeyPrefixEquals</c> set to <c>docs/</c> and
        /// in the Redirect set <c>ReplaceKeyPrefixWith</c> to <c>/documents</c>. Not required
        /// if one of the siblings is present. Can be present only if <c>ReplaceKeyWith</c> is
        /// not provided.
        /// </para>
        ///  <important> 
        /// <para>
        /// Replacement must be made for object keys containing special characters (such as carriage
        /// returns) when using XML requests. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-keys.html#object-key-xml-related-constraints">
        /// XML related object key constraints</a>.
        /// </para>
        ///  </important>
        /// </summary>
        public string ReplaceKeyPrefixWith
        {
            get { return this._replaceKeyPrefixWith; }
            set { this._replaceKeyPrefixWith = value; }
        }

        // Check to see if ReplaceKeyPrefixWith property is set
        internal bool IsSetReplaceKeyPrefixWith()
        {
            return this._replaceKeyPrefixWith != null;
        }

        /// <summary>
        /// Gets and sets the property ReplaceKeyWith. 
        /// <para>
        /// The specific object key to use in the redirect request. For example, redirect request
        /// to <c>error.html</c>. Not required if one of the siblings is present. Can be present
        /// only if <c>ReplaceKeyPrefixWith</c> is not provided.
        /// </para>
        ///  <important> 
        /// <para>
        /// Replacement must be made for object keys containing special characters (such as carriage
        /// returns) when using XML requests. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-keys.html#object-key-xml-related-constraints">
        /// XML related object key constraints</a>.
        /// </para>
        ///  </important>
        /// </summary>
        public string ReplaceKeyWith
        {
            get { return this._replaceKeyWith; }
            set { this._replaceKeyWith = value; }
        }

        // Check to see if ReplaceKeyWith property is set
        internal bool IsSetReplaceKeyWith()
        {
            return this._replaceKeyWith != null;
        }

    }
}