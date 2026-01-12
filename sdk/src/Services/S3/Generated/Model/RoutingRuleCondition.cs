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
    /// A container for describing a condition that must be met for the specified redirect
    /// to apply. For example, 1. If request is for pages in the <c>/docs</c> folder, redirect
    /// to the <c>/documents</c> folder. 2. If request results in HTTP error 4xx, redirect
    /// request to another host where you might process the error.
    /// </summary>
    public partial class RoutingRuleCondition
    {
        private string _httpErrorCodeReturnedEquals;
        private string _keyPrefixEquals;

        /// <summary>
        /// Gets and sets the property HttpErrorCodeReturnedEquals. 
        /// <para>
        /// The HTTP error code when the redirect is applied. In the event of an error, if the
        /// error code equals this value, then the specified redirect is applied. Required when
        /// parent element <c>Condition</c> is specified and sibling <c>KeyPrefixEquals</c> is
        /// not specified. If both are specified, then both must be true for the redirect to be
        /// applied.
        /// </para>
        /// </summary>
        public string HttpErrorCodeReturnedEquals
        {
            get { return this._httpErrorCodeReturnedEquals; }
            set { this._httpErrorCodeReturnedEquals = value; }
        }

        // Check to see if HttpErrorCodeReturnedEquals property is set
        internal bool IsSetHttpErrorCodeReturnedEquals()
        {
            return this._httpErrorCodeReturnedEquals != null;
        }

        /// <summary>
        /// Gets and sets the property KeyPrefixEquals. 
        /// <para>
        /// The object key name prefix when the redirect is applied. For example, to redirect
        /// requests for <c>ExamplePage.html</c>, the key prefix will be <c>ExamplePage.html</c>.
        /// To redirect request for all pages with the prefix <c>docs/</c>, the key prefix will
        /// be <c>/docs</c>, which identifies all objects in the <c>docs/</c> folder. Required
        /// when the parent element <c>Condition</c> is specified and sibling <c>HttpErrorCodeReturnedEquals</c>
        /// is not specified. If both conditions are specified, both must be true for the redirect
        /// to be applied.
        /// </para>
        ///  <important> 
        /// <para>
        /// Replacement must be made for object keys containing special characters (such as carriage
        /// returns) when using XML requests. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-keys.html#object-key-xml-related-constraints">
        /// XML related object key constraints</a>.
        /// </para>
        ///  </important>
        /// </summary>
        public string KeyPrefixEquals
        {
            get { return this._keyPrefixEquals; }
            set { this._keyPrefixEquals = value; }
        }

        // Check to see if KeyPrefixEquals property is set
        internal bool IsSetKeyPrefixEquals()
        {
            return this._keyPrefixEquals != null;
        }

    }
}