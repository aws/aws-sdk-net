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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
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
namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForResource operation.
    /// Lists all tags associated with the specified transcription job, vocabulary, model,
    /// or resource.
    /// 
    ///  
    /// <para>
    /// To learn more about using tags with Amazon Transcribe, refer to <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tagging.html">Tagging
    /// resources</a>.
    /// </para>
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonTranscribeServiceRequest
    {
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Returns a list of all tags associated with the specified Amazon Resource Name (ARN).
        /// ARNs have the format <c>arn:partition:service:region:account-id:resource-type/resource-id</c>.
        /// </para>
        ///  
        /// <para>
        /// For example, <c>arn:aws:transcribe:us-west-2:111122223333:transcription-job/transcription-job-name</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values for <c>resource-type</c> are: <c>transcription-job</c>, <c>medical-transcription-job</c>,
        /// <c>vocabulary</c>, <c>medical-vocabulary</c>, <c>vocabulary-filter</c>, and <c>language-model</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}