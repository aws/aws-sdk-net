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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateReviewTemplate operation. Update a review
    /// template.
    /// </summary>
    public partial class UpdateReviewTemplateRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The review template description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 250)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LensesToAssociate. 
        /// <para>
        /// A list of lens aliases or ARNs to apply to the review template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> LensesToAssociate { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LensesToAssociate property is set.
        /// </summary>
        internal bool IsSetLensesToAssociate() => this.LensesToAssociate != null && (this.LensesToAssociate.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LensesToDisassociate. 
        /// <para>
        /// A list of lens aliases or ARNs to unapply to the review template. The <c>wellarchitected</c>
        /// lens cannot be unapplied.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> LensesToDisassociate { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LensesToDisassociate property is set.
        /// </summary>
        internal bool IsSetLensesToDisassociate() => this.LensesToDisassociate != null && (this.LensesToDisassociate.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Notes.
        /// </summary>
        [AWSProperty(Max = 2084)]
        public string Notes { get; set; }

        /// <summary>
        /// Checks to see if the Notes property is set.
        /// </summary>
        internal bool IsSetNotes() => this.Notes != null;

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The review template ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 50, Max = 250)]
        public string TemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the TemplateArn property is set.
        /// </summary>
        internal bool IsSetTemplateArn() => this.TemplateArn != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The review template name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 100)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;
    }
}
