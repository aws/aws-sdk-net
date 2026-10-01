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

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForStream operation. Returns a list of
    /// tags associated with the specified stream. <para> In the request, you must specify
    /// either the <c>StreamName</c> or the <c>StreamARN</c>. </para>
    /// </summary>
    public partial class ListTagsForStreamRequest : AmazonKinesisVideoRequest
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you specify this parameter and the result of a <c>ListTagsForStream</c> call is
        /// truncated, the response includes a token that you can use in the next request to fetch
        /// the next batch of tags.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream that you want to list tags for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string StreamARN { get; set; }

        /// <summary>
        /// Checks to see if the StreamARN property is set.
        /// </summary>
        internal bool IsSetStreamARN() => this.StreamARN != null;

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream that you want to list tags for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;
    }
}
