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
 * Do not modify this file. This file is generated from the meteringmarketplace-2016-01-14.normal.json service model.
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
    /// The result of the <c>ResolveCustomer</c> operation. Contains the <c>CustomerIdentifier</c>
    /// along with the <c>CustomerAWSAccountId</c>, <c>ProductCode</c>, and <c>LicenseArn</c>.
    /// </summary>
    public partial class ResolveCustomerResponse : AmazonWebServiceResponse
    {
        private string _customerAWSAccountId;
        private string _customerIdentifier;
        private string _licenseArn;
        private string _productCode;

        /// <summary>
        /// Gets and sets the property CustomerAWSAccountId. 
        /// <para>
        /// The <c>CustomerAWSAccountId</c> provides the Amazon Web Services account ID associated
        /// with the <c>CustomerIdentifier</c> for the individual customer. Calls to <c>BatchMeterUsage</c>
        /// require <c>CustomerAWSAccountId</c> for each <c>UsageRecord</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CustomerAWSAccountId
        {
            get { return this._customerAWSAccountId; }
            set { this._customerAWSAccountId = value; }
        }

        // Check to see if CustomerAWSAccountId property is set
        internal bool IsSetCustomerAWSAccountId()
        {
            return this._customerAWSAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerIdentifier. 
        /// <para>
        /// The <c>CustomerIdentifier</c> is used to identify an individual customer in your application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string CustomerIdentifier
        {
            get { return this._customerIdentifier; }
            set { this._customerIdentifier = value; }
        }

        // Check to see if CustomerIdentifier property is set
        internal bool IsSetCustomerIdentifier()
        {
            return this._customerIdentifier != null;
        }

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
        public string LicenseArn
        {
            get { return this._licenseArn; }
            set { this._licenseArn = value; }
        }

        // Check to see if LicenseArn property is set
        internal bool IsSetLicenseArn()
        {
            return this._licenseArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// The product code is returned to confirm that the buyer is registering for your product.
        /// Subsequent <c>BatchMeterUsage</c> calls should be made using this product code.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string ProductCode
        {
            get { return this._productCode; }
            set { this._productCode = value; }
        }

        // Check to see if ProductCode property is set
        internal bool IsSetProductCode()
        {
            return this._productCode != null;
        }

    }
}