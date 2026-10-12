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

namespace Amazon.AWSMarketplaceMetering.Model
{
    /// <summary>
    /// This is the response object from the ResolveCustomer operation.
    /// </summary>
    public partial class ResolveCustomerResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CustomerAWSAccountId. 
        /// <para>
        /// The <c>CustomerAWSAccountId</c> provides the Amazon Web Services account ID associated
        /// with the <c>CustomerIdentifier</c> for the individual customer. Calls to <c>BatchMeterUsage</c>
        /// require <c>CustomerAWSAccountId</c> for each <c>UsageRecord</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CustomerAWSAccountId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerAWSAccountId property is set.
        /// </summary>
        internal bool IsSetCustomerAWSAccountId() => this.CustomerAWSAccountId != null;

        /// <summary>
        /// Gets and sets the property CustomerIdentifier. 
        /// <para>
        /// The <c>CustomerIdentifier</c> is used to identify an individual customer in your application.
        /// </para>
        ///  <important> 
        /// <para>
        /// For new SaaS product integrations, this field is not populated. Use <c>CustomerAWSAccountId</c>
        /// and <c>LicenseArn</c> to identify customers instead.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string CustomerIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CustomerIdentifier property is set.
        /// </summary>
        internal bool IsSetCustomerIdentifier() => this.CustomerIdentifier != null;

        /// <summary>
        /// Gets and sets the property LicenseArn. 
        /// <para>
        /// The <c>LicenseArn</c> is a unique identifier for a specific granted license. These
        /// are typically used for software purchased through Amazon Web Services Marketplace.
        /// Calls to <c>BatchMeterUsage</c> require <c>LicenseArn</c> for each <c>UsageRecord</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Once you receive the <c>CustomerAWSAccountId</c> and <c>LicenseArn</c> in the response,
        /// store that for future purposes/API calls/integrations.
        /// </para>
        ///  </note>
        /// </summary>
        public string LicenseArn { get; set; }

        /// <summary>
        /// Checks to see if the LicenseArn property is set.
        /// </summary>
        internal bool IsSetLicenseArn() => this.LicenseArn != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata associated with the resolved customer, including the <c>AgreementId</c>
        /// of the Amazon Web Services Marketplace agreement the customer accepted.
        /// </para>
        /// </summary>
        public Metadata Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// The product code is returned to confirm that the buyer is registering for your product.
        /// Subsequent <c>BatchMeterUsage</c> calls should be made using this product code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Checks to see if the ProductCode property is set.
        /// </summary>
        internal bool IsSetProductCode() => this.ProductCode != null;
    }
}
