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
 * Do not modify this file. This file is generated from the partnercentral-benefits-2018-05-10.normal.json service model.
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
namespace Amazon.PartnerCentralBenefits.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateBenefitApplicationResource operation.
    /// Removes the association between an AWS resource and a benefit application.
    /// </summary>
    public partial class DisassociateBenefitApplicationResourceRequest : AmazonPartnerCentralBenefitsRequest
    {
        private string _benefitApplicationIdentifier;
        private string _catalog;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property BenefitApplicationIdentifier. 
        /// <para>
        /// The unique identifier of the benefit application to disassociate the resource from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BenefitApplicationIdentifier
        {
            get { return this._benefitApplicationIdentifier; }
            set { this._benefitApplicationIdentifier = value; }
        }

        // Check to see if BenefitApplicationIdentifier property is set
        internal bool IsSetBenefitApplicationIdentifier()
        {
            return this._benefitApplicationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier that specifies which benefit catalog the application belongs
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS resource to disassociate from the benefit
        /// application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1600)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}