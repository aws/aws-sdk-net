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
    /// <para>A container for describing a condition that must be met for the specified redirect to apply. For example, 1. If request is for pages
    /// in the /docs folder, redirect to the /documents folder. 2. If request results in HTTP error 4xx, redirect request to another host where you
    /// might process the error.</para>
    /// </summary>
    public class RoutingRuleCondition
    {
        
        private string httpErrorCodeReturnedEquals;
        private string keyPrefixEquals;

        /// <summary>
        /// The HTTP error code when the redirect is applied. In the event of an error, if the error code equals this value, then the specified redirect
        /// is applied. Required when parent element Condition is specified and sibling KeyPrefixEquals is not specified. If both are specified, then
        /// both must be true for the redirect to be applied.
        ///  
        /// </summary>
        public string HttpErrorCodeReturnedEquals
        {
            get { return this.httpErrorCodeReturnedEquals; }
            set { this.httpErrorCodeReturnedEquals = value; }
        }

        // Check to see if HttpErrorCodeReturnedEquals property is set
        internal bool IsSetHttpErrorCodeReturnedEquals()
        {
            return this.httpErrorCodeReturnedEquals != null;
        }

        /// <summary>
        /// The object key name prefix when the redirect is applied. For example, to redirect requests for ExamplePage.html, the key prefix will be
        /// ExamplePage.html. To redirect request for all pages with the prefix docs/, the key prefix will be /docs, which identifies all objects in the
        /// docs/ folder. Required when the parent element Condition is specified and sibling HttpErrorCodeReturnedEquals is not specified. If both
        /// conditions are specified, both must be true for the redirect to be applied.
        ///  
        /// </summary>
        public string KeyPrefixEquals
        {
            get { return this.keyPrefixEquals; }
            set { this.keyPrefixEquals = value; }
        }

        // Check to see if KeyPrefixEquals property is set
        internal bool IsSetKeyPrefixEquals()
        {
            return this.keyPrefixEquals != null;
        }
    }
}
