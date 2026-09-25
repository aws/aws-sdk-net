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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
    /// Container for the parameters to the GetMediaAnalysisJob operation.
    /// <important> 
    /// <para>
    /// Service availability notice: Streaming Video and Bulk Image Analysis is no longer
    /// available to new customers. For more information, see <a href="https://docs.aws.amazon.com/rekognition/latest/dg/rekognition-availability-changes.html">Rekognition
    /// feature availability changes</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>This change does not impact the availability of other Amazon Rekognition features.</b>
    /// 
    /// </para>
    ///  </important> 
    /// <para>
    /// Retrieves the results for a given media analysis job. Takes a <c>JobId</c> returned
    /// by StartMediaAnalysisJob.
    /// </para>
    /// </summary>
    public partial class GetMediaAnalysisJobRequest : AmazonRekognitionRequest
    {
        private string _jobId;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// Unique identifier for the media analysis job for which you want to retrieve results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

    }
}