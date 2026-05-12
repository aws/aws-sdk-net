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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Configuration controls for tax estimation in the agreement request.
    /// </summary>
    public partial class TaxConfiguration
    {
        private TaxEstimation _taxEstimation;

        /// <summary>
        /// Gets and sets the property TaxEstimation. 
        /// <para>
        /// Toggle to estimate tax as part of the response. Values include <c>ENABLED</c> and
        /// <c>DISABLED</c>. Default is <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public TaxEstimation TaxEstimation
        {
            get { return this._taxEstimation; }
            set { this._taxEstimation = value; }
        }

        // Check to see if TaxEstimation property is set
        internal bool IsSetTaxEstimation()
        {
            return this._taxEstimation != null;
        }

    }
}