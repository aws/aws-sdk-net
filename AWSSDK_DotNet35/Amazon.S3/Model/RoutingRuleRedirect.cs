/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>
    /// <para>Container for redirect information. You can redirect requests to another host, to another page, or with another protocol. In the event
    /// of an error, you can can specify a different error code to return.</para>
    /// </summary>
    public class RoutingRuleRedirect
    {
        
        private string hostName;
        private string httpRedirectCode;
        private string protocol;
        private string replaceKeyPrefixWith;
        private string replaceKeyWith;

        /// <summary>
        /// Name of the host where requests will be redirected.
        ///  
        /// </summary>
        public string HostName
        {
            get { return this.hostName; }
            set { this.hostName = value; }
        }

        // Check to see if HostName property is set
        internal bool IsSetHostName()
        {
            return this.hostName != null;
        }

        /// <summary>
        /// The HTTP redirect code to use on the response. Not required if one of the siblings is present.
        ///  
        /// </summary>
        public string HttpRedirectCode
        {
            get { return this.httpRedirectCode; }
            set { this.httpRedirectCode = value; }
        }

        // Check to see if HttpRedirectCode property is set
        internal bool IsSetHttpRedirectCode()
        {
            return this.httpRedirectCode != null;
        }

        /// <summary>
        /// Protocol to use (http, https) when redirecting requests. The default is the protocol that is used in the original request.
        ///  
        /// </summary>
        public string Protocol
        {
            get { return this.protocol; }
            set { this.protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this.protocol != null;
        }

        /// <summary>
        /// The object key prefix to use in the redirect request. For example, to redirect requests for all pages with prefix docs/ (objects in the
        /// docs/ folder) to documents/, you can set a condition block with KeyPrefixEquals set to docs/ and in the Redirect set ReplaceKeyPrefixWith to
        /// /documents. Not required if one of the siblings is present. Can be present only if ReplaceKeyWith is not provided.
        ///  
        /// </summary>
        public string ReplaceKeyPrefixWith
        {
            get { return this.replaceKeyPrefixWith; }
            set { this.replaceKeyPrefixWith = value; }
        }

        // Check to see if ReplaceKeyPrefixWith property is set
        internal bool IsSetReplaceKeyPrefixWith()
        {
            return this.replaceKeyPrefixWith != null;
        }

        /// <summary>
        /// The specific object key to use in the redirect request. For example, redirect request to error.html. Not required if one of the sibling is
        /// present. Can be present only if ReplaceKeyPrefixWith is not provided.
        ///  
        /// </summary>
        public string ReplaceKeyWith
        {
            get { return this.replaceKeyWith; }
            set { this.replaceKeyWith = value; }
        }

        // Check to see if ReplaceKeyWith property is set
        internal bool IsSetReplaceKeyWith()
        {
            return this.replaceKeyWith != null;
        }
    }
}
