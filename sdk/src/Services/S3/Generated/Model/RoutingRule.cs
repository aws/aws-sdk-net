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
    /// Specifies the redirect behavior and when a redirect is applied. For more information
    /// about routing rules, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/how-to-page-redirect.html#advanced-conditional-redirects">Configuring
    /// advanced conditional redirects</a> in the <i>Amazon S3 User Guide</i>.
    /// </summary>
    public partial class RoutingRule
    {
        private RoutingRuleCondition _condition;
        private RoutingRuleRedirect _redirect;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// A container for describing a condition that must be met for the specified redirect
        /// to apply. For example, 1. If request is for pages in the <c>/docs</c> folder, redirect
        /// to the <c>/documents</c> folder. 2. If request results in HTTP error 4xx, redirect
        /// request to another host where you might process the error.
        /// </para>
        /// </summary>
        public RoutingRuleCondition Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property Redirect. 
        /// <para>
        /// Container for redirect information. You can redirect requests to another host, to
        /// another page, or with another protocol. In the event of an error, you can specify
        /// a different error code to return.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RoutingRuleRedirect Redirect
        {
            get { return this._redirect; }
            set { this._redirect = value; }
        }

        // Check to see if Redirect property is set
        internal bool IsSetRedirect()
        {
            return this._redirect != null;
        }

    }
}