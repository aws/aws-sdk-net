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
    /// Container for the parameters to the DisableImportFindingsForProduct operation.
    /// Disables the integration of the specified product with Security Hub. After the integration
    /// is disabled, findings from that product are no longer sent to Security Hub.
    /// </summary>
    public partial class DisableImportFindingsForProductRequest : AmazonSecurityHubRequest
    {
        private string _productSubscriptionArn;

        /// <summary>
        /// Gets and sets the property ProductSubscriptionArn. 
        /// <para>
        /// The ARN of the integrated product to disable the integration for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProductSubscriptionArn
        {
            get { return this._productSubscriptionArn; }
            set { this._productSubscriptionArn = value; }
        }

        // Check to see if ProductSubscriptionArn property is set
        internal bool IsSetProductSubscriptionArn()
        {
            return this._productSubscriptionArn != null;
        }

    }
}