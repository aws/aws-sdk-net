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
    /// Container for the parameters to the UntagResource operation.
    /// Removes the specified tags from the specified Amazon Transcribe resource.
    /// 
    ///  
    /// <para>
    /// If you include <c>UntagResource</c> in your request, you must also include <c>ResourceArn</c>
    /// and <c>TagKeys</c>.
    /// </para>
    /// </summary>
    public partial class UntagResourceRequest : AmazonTranscribeServiceRequest
    {
        private string _resourceArn;
        private List<string> _tagKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Transcribe resource you want to remove
        /// tags from. ARNs have the format <c>arn:partition:service:region:account-id:resource-type/resource-id</c>.
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

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// Removes the specified tag keys from the specified Amazon Transcribe resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && (this._tagKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}