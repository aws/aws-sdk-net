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
    /// Additional tax information associated with your TRN in Turkey.
    /// </summary>
    public partial class TurkeyAdditionalInfo
    {
        /// <summary>
        /// Gets and sets the property Industries. 
        /// <para>
        /// The industry information that tells the Tax Settings API if you're subject to additional
        /// withholding taxes. This information required for business-to-business (B2B) customers.
        /// This information is conditionally mandatory for B2B customers who are subject to KDV
        /// tax.
        /// </para>
        /// </summary>
        public Industries Industries { get; set; }

        /// <summary>
        /// Checks to see if the Industries property is set.
        /// </summary>
        internal bool IsSetIndustries() => this.Industries != null;

        /// <summary>
        /// Gets and sets the property KepEmailId. 
        /// <para>
        /// The Registered Electronic Mail (REM) that is used to send notarized communication.
        /// This parameter is optional for business-to-business (B2B) and business-to-government
        /// (B2G) customers. It's not required for business-to-consumer (B2C) customers.
        /// </para>
        /// </summary>
        public string KepEmailId { get; set; }

        /// <summary>
        /// Checks to see if the KepEmailId property is set.
        /// </summary>
        internal bool IsSetKepEmailId() => this.KepEmailId != null;

        /// <summary>
        /// Gets and sets the property SecondaryTaxId. 
        /// <para>
        ///  Secondary tax ID (“harcama birimi VKN”si”). If one isn't provided, we will use your
        /// VKN as the secondary ID. 
        /// </para>
        /// </summary>
        public string SecondaryTaxId { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryTaxId property is set.
        /// </summary>
        internal bool IsSetSecondaryTaxId() => this.SecondaryTaxId != null;

        /// <summary>
        /// Gets and sets the property TaxOffice. 
        /// <para>
        /// The tax office where you're registered. You can enter this information as a string.
        /// The Tax Settings API will add this information to your invoice. This parameter is
        /// required for business-to-business (B2B) and business-to-government customers. It's
        /// not required for business-to-consumer (B2C) customers.
        /// </para>
        /// </summary>
        public string TaxOffice { get; set; }

        /// <summary>
        /// Checks to see if the TaxOffice property is set.
        /// </summary>
        internal bool IsSetTaxOffice() => this.TaxOffice != null;
    }
}
