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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// A configuration bundle reference in a recommendation result.
    /// </summary>
    public partial class RecommendationResultConfigurationBundle
    {
        /// <summary>
        /// Gets and sets the property BundleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configuration bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BundleArn { get; set; }

        /// <summary>
        /// Checks to see if the BundleArn property is set.
        /// </summary>
        internal bool IsSetBundleArn() => this.BundleArn != null;

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The version identifier of the configuration bundle containing the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;
    }
}
