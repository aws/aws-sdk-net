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
    /// Contains the project fields (title, AWS Partner Network (APN) programs, and expected
    /// customer spend) returned for an opportunity in search results.
    /// </summary>
    public partial class OpportunitySearchProject
    {
        /// <summary>
        /// Gets and sets the property ApnPrograms. 
        /// <para>
        /// The AWS Partner Network (APN) programs associated with the opportunity's products
        /// or services.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ApnPrograms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ApnPrograms property is set.
        /// </summary>
        internal bool IsSetApnPrograms() => this.ApnPrograms != null && (this.ApnPrograms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExpectedCustomerSpend. 
        /// <para>
        /// The estimated AWS monthly recurring revenue (MRR): amount and currency only.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<OpportunitySearchExpectedCustomerSpend> ExpectedCustomerSpend { get; set; } = AWSConfigs.InitializeCollections ? new List<OpportunitySearchExpectedCustomerSpend>() : null;

        /// <summary>
        /// Checks to see if the ExpectedCustomerSpend property is set.
        /// </summary>
        internal bool IsSetExpectedCustomerSpend() => this.ExpectedCustomerSpend != null && (this.ExpectedCustomerSpend.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The partner opportunity name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
