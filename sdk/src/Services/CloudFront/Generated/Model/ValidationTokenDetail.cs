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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Contains details about the validation token.
    /// </summary>
    public partial class ValidationTokenDetail
    {
        private string _domain;
        private string _redirectFrom;
        private string _redirectTo;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property RedirectFrom. 
        /// <para>
        /// The domain to redirect from.
        /// </para>
        /// </summary>
        public string RedirectFrom
        {
            get { return this._redirectFrom; }
            set { this._redirectFrom = value; }
        }

        // Check to see if RedirectFrom property is set
        internal bool IsSetRedirectFrom()
        {
            return this._redirectFrom != null;
        }

        /// <summary>
        /// Gets and sets the property RedirectTo. 
        /// <para>
        /// The domain to redirect to.
        /// </para>
        /// </summary>
        public string RedirectTo
        {
            get { return this._redirectTo; }
            set { this._redirectTo = value; }
        }

        // Check to see if RedirectTo property is set
        internal bool IsSetRedirectTo()
        {
            return this._redirectTo != null;
        }

    }
}