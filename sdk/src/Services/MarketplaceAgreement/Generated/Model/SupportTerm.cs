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
    /// Defines the customer support available for the acceptors when they purchase the software.
    /// </summary>
    public partial class SupportTerm
    {
        private string _refundPolicy;
        private string _type;

        /// <summary>
        /// Gets and sets the property RefundPolicy. 
        /// <para>
        /// Free-text field about the refund policy description that will be shown to customers
        /// as is on the website and console.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string RefundPolicy
        {
            get { return this._refundPolicy; }
            set { this._refundPolicy = value; }
        }

        // Check to see if RefundPolicy property is set
        internal bool IsSetRefundPolicy()
        {
            return this._refundPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Category of the term being updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}