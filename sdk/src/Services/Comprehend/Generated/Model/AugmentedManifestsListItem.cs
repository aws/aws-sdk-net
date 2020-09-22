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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// An augmented manifest file that provides training data for your custom model. An augmented
    /// manifest file is a labeled dataset that is produced by Amazon SageMaker Ground Truth.
    /// </summary>
    public partial class AugmentedManifestsListItem
    {
        private List<string> _attributeNames = new List<string>();
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property AttributeNames. 
        /// <para>
        /// The JSON attribute that contains the annotations for your training documents. The
        /// number of attribute names that you specify depends on whether your augmented manifest
        /// file is the output of a single labeling job or a chained labeling job.
        /// </para>
        ///  
        /// <para>
        /// If your file is the output of a single labeling job, specify the LabelAttributeName
        /// key that was used when the job was created in Ground Truth.
        /// </para>
        ///  
        /// <para>
        /// If your file is the output of a chained labeling job, specify the LabelAttributeName
        /// key for one or more jobs in the chain. Each LabelAttributeName key provides the annotations
        /// from an individual job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AttributeNames
        {
            get { return this._attributeNames; }
            set { this._attributeNames = value; }
        }

        // Check to see if AttributeNames property is set
        internal bool IsSetAttributeNames()
        {
            return this._attributeNames != null && this._attributeNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The Amazon S3 location of the augmented manifest file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string S3Uri
        {
            get { return this._s3Uri; }
            set { this._s3Uri = value; }
        }

        // Check to see if S3Uri property is set
        internal bool IsSetS3Uri()
        {
            return this._s3Uri != null;
        }

    }
}