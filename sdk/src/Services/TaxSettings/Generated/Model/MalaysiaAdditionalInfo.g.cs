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

namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// Additional tax information associated with your TRN in Malaysia.
    /// </summary>
    public partial class MalaysiaAdditionalInfo
    {
        /// <summary>
        /// Gets and sets the property BusinessRegistrationNumber. 
        /// <para>
        /// The tax registration number (TRN) in Malaysia. 
        /// </para>
        ///  
        /// <para>
        /// For individual, you can specify the <c>taxInformationNumber</c> in <c>MalaysiaAdditionalInfo</c>
        /// with NRIC type, and a valid MyKad or NRIC number. For business, you must specify a
        /// <c>businessRegistrationNumber</c> in <c>MalaysiaAdditionalInfo</c> with a TIN type
        /// and tax identification number. For business resellers, you must specify a <c>businessRegistrationNumber</c>
        /// and <c>taxInformationNumber</c> in <c>MalaysiaAdditionalInfo</c> with a sales and
        /// service tax (SST) type and a valid SST number. 
        /// </para>
        ///  
        /// <para>
        /// For business resellers with service codes, you must specify <c>businessRegistrationNumber</c>,
        /// <c>taxInformationNumber</c>, and distinct <c>serviceTaxCodes</c> in <c>MalaysiaAdditionalInfo</c>
        /// with a SST type and valid sales and service tax (SST) number. By using this API operation,
        /// Amazon Web Services registers your self-declaration that you’re an authorized business
        /// reseller registered with the Royal Malaysia Customs Department (RMCD), and have a
        /// valid SST number.
        /// </para>
        /// </summary>
        public string BusinessRegistrationNumber { get; set; }

        /// <summary>
        /// Checks to see if the BusinessRegistrationNumber property is set.
        /// </summary>
        internal bool IsSetBusinessRegistrationNumber() => this.BusinessRegistrationNumber != null;

        /// <summary>
        /// Gets and sets the property ServiceTaxCodes. 
        /// <para>
        /// List of service tax codes for your TRN in Malaysia.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 4)]
        public List<string> ServiceTaxCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ServiceTaxCodes property is set.
        /// </summary>
        internal bool IsSetServiceTaxCodes() => this.ServiceTaxCodes != null && (this.ServiceTaxCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaxInformationNumber. 
        /// <para>
        /// The tax information number in Malaysia. 
        /// </para>
        ///  
        /// <para>
        /// For individual, you can specify the <c>taxInformationNumber</c> in <c>MalaysiaAdditionalInfo</c>
        /// with NRIC type, and a valid MyKad or NRIC number. For business resellers, you must
        /// specify a <c>businessRegistrationNumber</c> and <c>taxInformationNumber</c> in <c>MalaysiaAdditionalInfo</c>
        /// with a sales and service tax (SST) type and a valid SST number. 
        /// </para>
        ///  
        /// <para>
        /// For business resellers with service codes, you must specify <c>businessRegistrationNumber</c>,
        /// <c>taxInformationNumber</c>, and distinct <c>serviceTaxCodes</c> in <c>MalaysiaAdditionalInfo</c>
        /// with a SST type and valid sales and service tax (SST) number. By using this API operation,
        /// Amazon Web Services registers your self-declaration that you’re an authorized business
        /// reseller registered with the Royal Malaysia Customs Department (RMCD), and have a
        /// valid SST number.
        /// </para>
        /// </summary>
        public string TaxInformationNumber { get; set; }

        /// <summary>
        /// Checks to see if the TaxInformationNumber property is set.
        /// </summary>
        internal bool IsSetTaxInformationNumber() => this.TaxInformationNumber != null;
    }
}
