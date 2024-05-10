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
    /// Provides information about the location of input data.
    /// 
    ///  
    /// <para>
    /// You must specify at least one of the following: <c>S3DataSource</c> or <c>SnsDataSource</c>.
    /// </para>
    ///  
    /// <para>
    /// Use <c>SnsDataSource</c> to specify an SNS input topic for a streaming labeling job.
    /// If you do not specify and SNS input topic ARN, Ground Truth will create a one-time
    /// labeling job.
    /// </para>
    ///  
    /// <para>
    /// Use <c>S3DataSource</c> to specify an input manifest file for both streaming and one-time
    /// labeling jobs. Adding an <c>S3DataSource</c> is optional if you use <c>SnsDataSource</c>
    /// to create a streaming labeling job.
    /// </para>
    /// </summary>
    public partial class LabelingJobDataSource
    {
        private LabelingJobS3DataSource _s3DataSource;
        private LabelingJobSnsDataSource _snsDataSource;

        /// <summary>
        /// Gets and sets the property S3DataSource. 
        /// <para>
        /// The Amazon S3 location of the input data objects.
        /// </para>
        /// </summary>
        public LabelingJobS3DataSource S3DataSource
        {
            get { return this._s3DataSource; }
            set { this._s3DataSource = value; }
        }

        // Check to see if S3DataSource property is set
        internal bool IsSetS3DataSource()
        {
            return this._s3DataSource != null;
        }

        /// <summary>
        /// Gets and sets the property SnsDataSource. 
        /// <para>
        /// An Amazon SNS data source used for streaming labeling jobs. To learn more, see <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-streaming-labeling-job.html#sms-streaming-how-it-works-send-data">Send
        /// Data to a Streaming Labeling Job</a>. 
        /// </para>
        /// </summary>
        public LabelingJobSnsDataSource SnsDataSource
        {
            get { return this._snsDataSource; }
            set { this._snsDataSource = value; }
        }

        // Check to see if SnsDataSource property is set
        internal bool IsSetSnsDataSource()
        {
            return this._snsDataSource != null;
        }

    }
}