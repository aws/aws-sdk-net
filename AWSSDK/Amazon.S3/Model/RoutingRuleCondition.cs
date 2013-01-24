/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// A container for describing a condition that must be met for the specified redirect to apply. 
    /// For example if request is for pages in the /docs folder, redirect to the /documents folder or
    /// if request results in HTTP error 4xx, redirect request to another host where you might process the error.
    /// </summary>
    public class RoutingRuleCondition
    {
        string _keyPrefixEquals;
        string _httpErrorCodeReturnedEquals;

        #region KeyPrefixEquals

        /// <summary>
        /// The object key name prefix when the redirect is applied. For example, to redirect requests for 
        /// ExamplePage.html, the key prefix will be ExamplePage.html. To redirect request for all pages with the 
        /// prefix docs/, the key prefix will be /docs, which identifies all objects in the docs/ folder.
        /// </summary>
        public string KeyPrefixEquals
        {
            get { return this._keyPrefixEquals; }
            set { this._keyPrefixEquals = value; }
        }

        /// <summary>
        /// The object key name prefix when the redirect is applied. For example, to redirect requests for 
        /// ExamplePage.html, the key prefix will be ExamplePage.html. To redirect request for all pages with the 
        /// prefix docs/, the key prefix will be /docs, which identifies all objects in the docs/ folder.
        /// </summary>
        /// <param name="keyPrefixEquals">The object key name prefix</param>
        /// <returns>the RoutingRuleCondition with the KeyPrefixEquals set</returns>
        public RoutingRuleCondition WithKeyPrefixEquals(string keyPrefixEquals)
        {
            this._keyPrefixEquals = keyPrefixEquals;
            return this;
        }

        /// <summary>
        /// Checks if the KeyPrefixEquals property is set.
        /// </summary>
        /// <returns>true if KeyPrefixEquals property is set.</returns>
        internal bool IsSetKeyPrefixEquals()
        {
            return !System.String.IsNullOrEmpty(this._keyPrefixEquals);
        }

        #endregion

        #region HttpErrorCodeReturnedEquals

        /// <summary>
        /// The HTTP error code when the redirect is applied. In the event of an error, 
        /// if the error code equals this value, then the specified redirect is applied.
        /// </summary>
        public string HttpErrorCodeReturnedEquals
        {
            get { return this._httpErrorCodeReturnedEquals; }
            set { this._httpErrorCodeReturnedEquals = value; }
        }

        /// <summary>
        /// The HTTP error code when the redirect is applied. In the event of an error, 
        /// if the error code equals this value, then the specified redirect is applied.
        /// </summary>
        /// <param name="httpErrorCodeReturnedEquals">The HTTP error code when the redirect is applied</param>
        /// <returns>the RoutingRuleCondition with the HttpErrorCodeReturnedEquals set</returns>
        public RoutingRuleCondition WithHttpErrorCodeReturnedEquals(string httpErrorCodeReturnedEquals)
        {
            this._httpErrorCodeReturnedEquals = httpErrorCodeReturnedEquals;
            return this;
        }

        /// <summary>
        /// Checks if the HttpErrorCodeReturnedEquals property is set.
        /// </summary>
        /// <returns>true if HttpErrorCodeReturnedEquals property is set.</returns>
        internal bool IsSetHttpErrorCodeReturnedEquals()
        {
            return !System.String.IsNullOrEmpty(this._httpErrorCodeReturnedEquals);
        }

        #endregion
    }
}
