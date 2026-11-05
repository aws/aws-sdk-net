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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the ListComponentBuildVersions operation. Returns
    /// a list of component build versions for the specified component version ARN. You can
    /// only list build versions for components that your account owns. Deprecated build versions
    /// aren't included in the results.
    /// </summary>
    public partial class ListComponentBuildVersionsRequest : AmazonImagebuilderRequest
    {
        /// <summary>
        /// Gets and sets the property ComponentVersionArn. 
        /// <para>
        /// The component version ARN whose build versions you want to list. The ARN must specify
        /// an exact version, without a build number suffix. If you don't specify an ARN, Image
        /// Builder returns build versions for the components that your account owns.
        /// </para>
        /// </summary>
        public string ComponentVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ComponentVersionArn property is set.
        /// </summary>
        internal bool IsSetComponentVersionArn() => this.ComponentVersionArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return in a single request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to specify where to start paginating. Use the <c>nextToken</c> value from
        /// a previously truncated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65535)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
