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
    /// Container for the parameters to the EnableImportFindingsForProduct operation.
    /// Enables the integration of a partner product with Security Hub. Integrated products
    /// send findings to Security Hub.
    /// 
    ///  
    /// <para>
    /// When you enable a product integration, a permissions policy that grants permission
    /// for the product to send findings to Security Hub is applied.
    /// </para>
    /// </summary>
    public partial class EnableImportFindingsForProductRequest : AmazonSecurityHubRequest
    {
        private string _productArn;

        /// <summary>
        /// Gets and sets the property ProductArn. 
        /// <para>
        /// The ARN of the product to enable the integration for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProductArn
        {
            get { return this._productArn; }
            set { this._productArn = value; }
        }

        // Check to see if ProductArn property is set
        internal bool IsSetProductArn()
        {
            return this._productArn != null;
        }

    }
}