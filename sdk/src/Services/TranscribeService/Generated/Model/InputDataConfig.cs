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

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Contains the Amazon S3 location of the training data you want to use to create a new
    /// custom language model, and permissions to access this location.
    /// 
    ///  
    /// <para>
    /// When using <code>InputDataConfig</code>, you must include these sub-parameters: <code>S3Uri</code>
    /// and <code>DataAccessRoleArn</code>. You can optionally include <code>TuningDataS3Uri</code>.
    /// </para>
    /// </summary>
    public partial class InputDataConfig
    {
        private string _dataAccessRoleArn;
        private string _s3Uri;
        private string _tuningDataS3Uri;

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that has permissions to access the Amazon
        /// S3 bucket that contains your input files. If the role that you specify doesn’t have
        /// the appropriate permissions to access the specified Amazon S3 location, your request
        /// fails.
        /// </para>
        ///  
        /// <para>
        /// IAM role ARNs have the format <code>arn:partition:iam::account:role/role-name-with-path</code>.
        /// For example: <code>arn:aws:iam::111122223333:role/Admin</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-arns">IAM
        /// ARNs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string DataAccessRoleArn
        {
            get { return this._dataAccessRoleArn; }
            set { this._dataAccessRoleArn = value; }
        }

        // Check to see if DataAccessRoleArn property is set
        internal bool IsSetDataAccessRoleArn()
        {
            return this._dataAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The Amazon S3 location (URI) of the text files you want to use to train your custom
        /// language model.
        /// </para>
        ///  
        /// <para>
        /// Here's an example URI path: <code>s3://DOC-EXAMPLE-BUCKET/my-model-training-data/</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2000)]
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

        /// <summary>
        /// Gets and sets the property TuningDataS3Uri. 
        /// <para>
        /// The Amazon S3 location (URI) of the text files you want to use to tune your custom
        /// language model.
        /// </para>
        ///  
        /// <para>
        /// Here's an example URI path: <code>s3://DOC-EXAMPLE-BUCKET/my-model-tuning-data/</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string TuningDataS3Uri
        {
            get { return this._tuningDataS3Uri; }
            set { this._tuningDataS3Uri = value; }
        }

        // Check to see if TuningDataS3Uri property is set
        internal bool IsSetTuningDataS3Uri()
        {
            return this._tuningDataS3Uri != null;
        }

    }
}