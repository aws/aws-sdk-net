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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Source-separated spend insights that provide independent analysis for AWS recommendations
    /// and partner estimates.
    /// </summary>
    public partial class AwsProductsSpendInsightsBySource
    {
        /// <summary>
        /// Gets and sets the property AWS. 
        /// <para>
        /// AI-generated insights including recommended products from AWS.
        /// </para>
        /// </summary>
        public AwsProductInsights AWS { get; set; }

        /// <summary>
        /// Checks to see if the AWS property is set.
        /// </summary>
        internal bool IsSetAWS() => this.AWS != null;

        /// <summary>
        /// Gets and sets the property Partner. 
        /// <para>
        /// Partner-sourced insights derived from Pricing Calculator URLs.
        /// </para>
        /// </summary>
        public AwsProductInsights Partner { get; set; }

        /// <summary>
        /// Checks to see if the Partner property is set.
        /// </summary>
        internal bool IsSetPartner() => this.Partner != null;
    }
}
