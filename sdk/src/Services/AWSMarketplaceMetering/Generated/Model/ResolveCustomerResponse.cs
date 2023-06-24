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

namespace Amazon.AWSMarketplaceMetering.Model
{
    /// <summary>
    /// The result of the <code>ResolveCustomer</code> operation. Contains the <code>CustomerIdentifier</code>
    /// along with the <code>CustomerAWSAccountId</code> and <code>ProductCode</code>.
    /// </summary>
    public partial class ResolveCustomerResponse : AmazonWebServiceResponse
    {
        private string _customerAWSAccountId;
        private string _customerIdentifier;
        private string _productCode;

        /// <summary>
        /// Gets and sets the property CustomerAWSAccountId. 
        /// <para>
        /// The <code>CustomerAWSAccountId</code> provides the AWS account ID associated with
        /// the <code>CustomerIdentifier</code> for the individual customer.
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
        /// The <code>CustomerIdentifier</code> is used to identify an individual customer in
        /// your application. Calls to <code>BatchMeterUsage</code> require <code>CustomerIdentifiers</code>
        /// for each <code>UsageRecord</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// The product code is returned to confirm that the buyer is registering for your product.
        /// Subsequent <code>BatchMeterUsage</code> calls should be made using this product code.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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