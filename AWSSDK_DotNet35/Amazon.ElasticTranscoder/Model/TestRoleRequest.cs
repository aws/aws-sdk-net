/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Container for the parameters to the TestRole operation.
    /// The TestRole operation tests the IAM role used to create the pipeline.
    /// 
    ///         
    /// <para>
    /// The <code>TestRole</code> action lets you determine whether the IAM role you are using
    ///            has sufficient permissions to let Elastic Transcoder perform tasks associated
    /// with the transcoding            process. The action attempts to assume the specified
    /// IAM role, checks read access to the            input and output buckets, and tries
    /// to send a test notification to Amazon SNS topics            that you specify.
    /// </para>
    /// </summary>
    public partial class TestRoleRequest : AmazonElasticTranscoderRequest
    {
        private string _inputBucket;
        private string _outputBucket;
        private string _role;
        private List<string> _topics = new List<string>();

        /// <summary>
        /// Gets and sets the property InputBucket. 
        /// <para>
        /// The Amazon S3 bucket that contains media files to be transcoded. The action attempts
        /// to read            from this bucket.
        /// </para>
        /// </summary>
        public string InputBucket
        {
            get { return this._inputBucket; }
            set { this._inputBucket = value; }
        }

        // Check to see if InputBucket property is set
        internal bool IsSetInputBucket()
        {
            return this._inputBucket != null;
        }

        /// <summary>
        /// Gets and sets the property OutputBucket. 
        /// <para>
        /// The Amazon S3 bucket that Elastic Transcoder will write transcoded media files to.
        /// The action attempts to            read from this bucket.
        /// </para>
        /// </summary>
        public string OutputBucket
        {
            get { return this._outputBucket; }
            set { this._outputBucket = value; }
        }

        // Check to see if OutputBucket property is set
        internal bool IsSetOutputBucket()
        {
            return this._outputBucket != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The IAM Amazon Resource Name (ARN) for the role that you want Elastic Transcoder to
        ///            test.
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property Topics. 
        /// <para>
        /// The ARNs of one or more Amazon Simple Notification Service (Amazon SNS) topics that
        /// you want the action to send a test            notification to.
        /// </para>
        /// </summary>
        public List<string> Topics
        {
            get { return this._topics; }
            set { this._topics = value; }
        }

        // Check to see if Topics property is set
        internal bool IsSetTopics()
        {
            return this._topics != null && this._topics.Count > 0; 
        }

    }
}