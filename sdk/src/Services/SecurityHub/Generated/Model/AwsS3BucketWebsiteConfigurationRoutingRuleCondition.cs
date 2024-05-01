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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The condition that must be met in order to apply the routing rule.
    /// </summary>
    public partial class AwsS3BucketWebsiteConfigurationRoutingRuleCondition
    {
        private string _httpErrorCodeReturnedEquals;
        private string _keyPrefixEquals;

        /// <summary>
        /// Gets and sets the property HttpErrorCodeReturnedEquals. 
        /// <para>
        /// Indicates to redirect the request if the HTTP error code matches this value.
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
        /// Indicates to redirect the request if the key prefix matches this value.
        /// </para>
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