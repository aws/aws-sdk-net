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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property HttpErrorCodeReturnedEquals. 
        /// <para>
        /// Indicates to redirect the request if the HTTP error code matches this value.
        /// </para>
        /// </summary>
        public string HttpErrorCodeReturnedEquals { get; set; }

        /// <summary>
        /// Checks to see if the HttpErrorCodeReturnedEquals property is set.
        /// </summary>
        internal bool IsSetHttpErrorCodeReturnedEquals() => this.HttpErrorCodeReturnedEquals != null;

        /// <summary>
        /// Gets and sets the property KeyPrefixEquals. 
        /// <para>
        /// Indicates to redirect the request if the key prefix matches this value.
        /// </para>
        /// </summary>
        public string KeyPrefixEquals { get; set; }

        /// <summary>
        /// Checks to see if the KeyPrefixEquals property is set.
        /// </summary>
        internal bool IsSetKeyPrefixEquals() => this.KeyPrefixEquals != null;
    }
}
