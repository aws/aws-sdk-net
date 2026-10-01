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
    /// The tax exemption details.
    /// </summary>
    public partial class TaxExemptionDetails
    {
        /// <summary>
        /// Gets and sets the property HeritageObtainedDetails. 
        /// <para>
        /// The indicator if the tax exemption is inherited from the consolidated billing family
        /// management account. 
        /// </para>
        /// </summary>
        public bool? HeritageObtainedDetails { get; set; }

        /// <summary>
        /// Checks to see if the HeritageObtainedDetails property is set.
        /// </summary>
        internal bool IsSetHeritageObtainedDetails() => this.HeritageObtainedDetails.HasValue;

        /// <summary>
        /// Gets and sets the property HeritageObtainedParentEntity. 
        /// <para>
        /// The consolidated billing family management account the tax exemption inherited from.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string HeritageObtainedParentEntity { get; set; }

        /// <summary>
        /// Checks to see if the HeritageObtainedParentEntity property is set.
        /// </summary>
        internal bool IsSetHeritageObtainedParentEntity() => this.HeritageObtainedParentEntity != null;

        /// <summary>
        /// Gets and sets the property HeritageObtainedReason. 
        /// <para>
        /// The reason of the heritage inheritance. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string HeritageObtainedReason { get; set; }

        /// <summary>
        /// Checks to see if the HeritageObtainedReason property is set.
        /// </summary>
        internal bool IsSetHeritageObtainedReason() => this.HeritageObtainedReason != null;

        /// <summary>
        /// Gets and sets the property TaxExemptions. 
        /// <para>
        /// Tax exemptions. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TaxExemption> TaxExemptions { get; set; } = AWSConfigs.InitializeCollections ? new List<TaxExemption>() : null;

        /// <summary>
        /// Checks to see if the TaxExemptions property is set.
        /// </summary>
        internal bool IsSetTaxExemptions() => this.TaxExemptions != null && (this.TaxExemptions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
