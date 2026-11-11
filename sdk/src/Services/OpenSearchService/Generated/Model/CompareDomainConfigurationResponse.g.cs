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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// This is the response object from the CompareDomainConfiguration operation.
    /// </summary>
    public partial class CompareDomainConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// The comparison result for each category you requested, keyed by category name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public Dictionary<string, CategoryDiffResult> Categories { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, CategoryDiffResult>() : null;

        /// <summary>
        /// Checks to see if the Categories property is set.
        /// </summary>
        internal bool IsSetCategories() => this.Categories != null && (this.Categories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceDomainArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the domain that was compared from.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string SourceDomainArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceDomainArn property is set.
        /// </summary>
        internal bool IsSetSourceDomainArn() => this.SourceDomainArn != null;

        /// <summary>
        /// Gets and sets the property TargetDomainArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the domain that was compared against.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string TargetDomainArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetDomainArn property is set.
        /// </summary>
        internal bool IsSetTargetDomainArn() => this.TargetDomainArn != null;
    }
}
