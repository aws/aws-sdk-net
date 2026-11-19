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

namespace Amazon.Billing.Model
{
    /// <summary>
    /// This is the response object from the SplitCredit operation.
    /// </summary>
    public partial class SplitCreditResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ChildCredits. 
        /// <para>
        /// The new credits, in the order of the requested portions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 99)]
        public List<ChildCredit> ChildCredits { get; set; } = AWSConfigs.InitializeCollections ? new List<ChildCredit>() : null;

        /// <summary>
        /// Checks to see if the ChildCredits property is set.
        /// </summary>
        internal bool IsSetChildCredits() => this.ChildCredits != null && (this.ChildCredits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Specifies whether the request was a dry run. If <c>true</c>, the operation didn't
        /// change any credit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property ParentCreditId. 
        /// <para>
        /// The ID of the credit that was split.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string ParentCreditId { get; set; }

        /// <summary>
        /// Checks to see if the ParentCreditId property is set.
        /// </summary>
        internal bool IsSetParentCreditId() => this.ParentCreditId != null;
    }
}
