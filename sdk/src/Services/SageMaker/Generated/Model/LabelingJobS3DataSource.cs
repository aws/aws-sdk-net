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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The Amazon S3 location of the input data objects.
    /// </summary>
    public partial class LabelingJobS3DataSource
    {
        private string _manifestS3Uri;

        /// <summary>
        /// Gets and sets the property ManifestS3Uri. 
        /// <para>
        /// The Amazon S3 location of the manifest file that describes the input data objects.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The input manifest file referenced in <c>ManifestS3Uri</c> must contain one of the
        /// following keys: <c>source-ref</c> or <c>source</c>. The value of the keys are interpreted
        /// as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>source-ref</c>: The source of the object is the Amazon S3 object specified in
        /// the value. Use this value when the object is a binary object, such as an image.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>source</c>: The source of the object is the value. Use this value when the object
        /// is a text value.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you are a new user of Ground Truth, it is recommended you review <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-input-data-input-manifest.html">Use
        /// an Input Manifest File </a> in the Amazon SageMaker Developer Guide to learn how to
        /// create an input manifest file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string ManifestS3Uri
        {
            get { return this._manifestS3Uri; }
            set { this._manifestS3Uri = value; }
        }

        // Check to see if ManifestS3Uri property is set
        internal bool IsSetManifestS3Uri()
        {
            return this._manifestS3Uri != null;
        }

    }
}