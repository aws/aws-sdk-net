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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the ListStreamProcessors operation. <important> <para>
    /// Service availability notice: Streaming Video and Bulk Image Analysis is no longer
    /// available to new customers. For more information, see <a href="https://docs.aws.amazon.com/rekognition/latest/dg/rekognition-availability-changes.html">Rekognition
    /// feature availability changes</a>. </para> <para> <b>This change does not impact the
    /// availability of other Amazon Rekognition features.</b> </para> </important> <para>
    /// Gets a list of stream processors that you have created with <a>CreateStreamProcessor</a>.
    /// </para>
    /// </summary>
    public partial class ListStreamProcessorsRequest : AmazonRekognitionRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of stream processors you want Amazon Rekognition Video to return in
        /// the response. The default is 1000. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous response was incomplete (because there are more stream processors
        /// to retrieve), Amazon Rekognition Video returns a pagination token in the response.
        /// You can use this pagination token to retrieve the next set of stream processors. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
