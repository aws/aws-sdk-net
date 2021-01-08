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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the AddTags operation.
    /// Adds or overwrites one or more tags for the specified Amazon SageMaker resource. You
    /// can add tags to notebook instances, training jobs, hyperparameter tuning jobs, batch
    /// transform jobs, models, labeling jobs, work teams, endpoint configurations, and endpoints.
    /// 
    ///  
    /// <para>
    /// Each tag consists of a key and an optional value. Tag keys must be unique per resource.
    /// For more information about tags, see For more information, see <a href="https://aws.amazon.com/answers/account-management/aws-tagging-strategies/">AWS
    /// Tagging Strategies</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Tags that you add to a hyperparameter tuning job by calling this API are also added
    /// to any training jobs that the hyperparameter tuning job launches after you call this
    /// API, but not to training jobs that the hyperparameter tuning job launched before you
    /// called this API. To make sure that the tags associated with a hyperparameter tuning
    /// job are also added to all training jobs that the hyperparameter tuning job launches,
    /// add the tags when you first create the tuning job by specifying them in the <code>Tags</code>
    /// parameter of <a>CreateHyperParameterTuningJob</a> 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AddTagsRequest : AmazonSageMakerRequest
    {
        private string _resourceArn;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource that you want to tag.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. You can use tags to categorize your AWS resources in
        /// different ways, for example, by purpose, owner, or environment. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// AWS Resources</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}