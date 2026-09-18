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

namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// Container for the parameters to the ListMicrovms operation. Lists MicroVMs in the
    /// account with optional filtering by image and version. We recommend using pagination
    /// to ensure that the operation returns quickly and successfully.
    /// </summary>
    public partial class ListMicrovmsRequest : AmazonLambdaMicrovmsRequest
    {
        /// <summary>
        /// Gets and sets the property ImageIdentifier. 
        /// <para>
        /// Optional filter to list only MicroVMs running the specified image.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ImageIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ImageIdentifier property is set.
        /// </summary>
        internal bool IsSetImageIdentifier() => this.ImageIdentifier != null;

        /// <summary>
        /// Gets and sets the property ImageVersion. 
        /// <para>
        /// Optional filter to list only MicroVMs running the specified image version.
        /// </para>
        /// </summary>
        public string ImageVersion { get; set; }

        /// <summary>
        /// Checks to see if the ImageVersion property is set.
        /// </summary>
        internal bool IsSetImageVersion() => this.ImageVersion != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token from a previous call. Use this token to retrieve the next page
        /// of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
