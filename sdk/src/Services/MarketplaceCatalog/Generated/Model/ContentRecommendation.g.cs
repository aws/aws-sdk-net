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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// A recommendation for a listing field.
    /// </summary>
    public partial class ContentRecommendation
    {
        /// <summary>
        /// Gets and sets the property Alternatives. 
        /// <para>
        /// The proposed values for the field, in ranked order.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContentAlternatives Alternatives { get; set; }

        /// <summary>
        /// Checks to see if the Alternatives property is set.
        /// </summary>
        internal bool IsSetAlternatives() => this.Alternatives != null;

        /// <summary>
        /// Gets and sets the property Findings. 
        /// <para>
        /// The checklist of criteria for the field, in ranked order. It includes the criteria
        /// that the field passes and the criteria that it fails. The list is empty if there are
        /// none.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 30)]
        public List<ListingFinding> Findings { get; set; } = AWSConfigs.InitializeCollections ? new List<ListingFinding>() : null;

        /// <summary>
        /// Checks to see if the Findings property is set.
        /// </summary>
        internal bool IsSetFindings() => this.Findings != null && (this.Findings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FollowUpQuestions. 
        /// <para>
        /// Questions that you can answer to get a better recommendation. The list is empty if
        /// there are none.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 25)]
        public List<FollowUpQuestion> FollowUpQuestions { get; set; } = AWSConfigs.InitializeCollections ? new List<FollowUpQuestion>() : null;

        /// <summary>
        /// Checks to see if the FollowUpQuestions property is set.
        /// </summary>
        internal bool IsSetFollowUpQuestions() => this.FollowUpQuestions != null && (this.FollowUpQuestions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the recommendation. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>GENERATED</c> - The service proposed values for the field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSUFFICIENT_CONTEXT</c> - The service couldn't propose a value. The follow-up
        /// questions say what is missing.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContentRecommendationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
