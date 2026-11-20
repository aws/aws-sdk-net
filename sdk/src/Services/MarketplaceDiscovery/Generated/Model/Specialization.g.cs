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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// A specialization earned for the listing, such as an AWS Competency.
    /// </summary>
    public partial class Specialization
    {
        /// <summary>
        /// Gets and sets the property CaseStudyIds. 
        /// <para>
        /// The identifiers of the case studies that this specialization cites. Retrieve the case
        /// studies with the <c>CASE_STUDY</c> attribute type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 25)]
        public List<string> CaseStudyIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CaseStudyIds property is set.
        /// </summary>
        internal bool IsSetCaseStudyIds() => this.CaseStudyIds != null && (this.CaseStudyIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the specialization displayed to you.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property SpecializationId. 
        /// <para>
        /// The unique identifier of the specialization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string SpecializationId { get; set; }

        /// <summary>
        /// Checks to see if the SpecializationId property is set.
        /// </summary>
        internal bool IsSetSpecializationId() => this.SpecializationId != null;

        /// <summary>
        /// Gets and sets the property SpecializationName. 
        /// <para>
        /// The name of the specialization displayed to you.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string SpecializationName { get; set; }

        /// <summary>
        /// Checks to see if the SpecializationName property is set.
        /// </summary>
        internal bool IsSetSpecializationName() => this.SpecializationName != null;

        /// <summary>
        /// Gets and sets the property SpecializationTypes. 
        /// <para>
        /// The types that categorize this specialization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 3)]
        public List<SpecializationTypeDetail> SpecializationTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<SpecializationTypeDetail>() : null;

        /// <summary>
        /// Checks to see if the SpecializationTypes property is set.
        /// </summary>
        internal bool IsSetSpecializationTypes() => this.SpecializationTypes != null && (this.SpecializationTypes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
