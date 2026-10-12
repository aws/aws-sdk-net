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

namespace Amazon.PartnerCentralBenefits.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateBenefitApplicationResource operation.
    /// Removes the association between an AWS resource and a benefit application.
    /// </summary>
    public partial class DisassociateBenefitApplicationResourceRequest : AmazonPartnerCentralBenefitsRequest
    {
        /// <summary>
        /// Gets and sets the property BenefitApplicationIdentifier. 
        /// <para>
        /// The unique identifier of the benefit application to disassociate the resource from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BenefitApplicationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the BenefitApplicationIdentifier property is set.
        /// </summary>
        internal bool IsSetBenefitApplicationIdentifier() => this.BenefitApplicationIdentifier != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier that specifies which benefit catalog the application belongs
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS resource to disassociate from the benefit
        /// application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1600)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}
