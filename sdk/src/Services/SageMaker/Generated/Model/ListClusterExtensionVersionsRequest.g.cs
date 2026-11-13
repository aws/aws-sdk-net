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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListClusterExtensionVersions operation. Lists
    /// the versions of an extension that you can install on a SageMaker HyperPod cluster,
    /// from the highest version to the lowest. Use a version from this list as the <c>ExtensionVersion</c>
    /// in <c>CreateClusterExtension</c> or <c>UpdateClusterExtension</c>. <para> The list
    /// contains only versions that you can install. Versions that SageMaker HyperPod no longer
    /// offers for new installations don't appear. If SageMaker HyperPod doesn't offer an
    /// extension with the name that you specify, the response contains an empty list. </para>
    /// </summary>
    public partial class ListClusterExtensionVersionsRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ExtensionName. 
        /// <para>
        /// The name of the extension whose versions you want to list, for example <c>sagemaker-observability</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ExtensionName { get; set; }

        /// <summary>
        /// Checks to see if the ExtensionName property is set.
        /// </summary>
        internal bool IsSetExtensionName() => this.ExtensionName != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of versions to return in the response. If you don't specify a value,
        /// SageMaker HyperPod returns up to 100 versions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the result of the previous <c>ListClusterExtensionVersions</c> request was truncated,
        /// the response includes a <c>NextToken</c>. To retrieve the next set of versions, use
        /// the token in the next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
