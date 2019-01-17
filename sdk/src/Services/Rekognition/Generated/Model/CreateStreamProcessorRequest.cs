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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStreamProcessor operation.
    /// Creates an Amazon Rekognition stream processor that you can use to detect and recognize
    /// faces in a streaming video.
    /// 
    ///  
    /// <para>
    /// Amazon Rekognition Video is a consumer of live video from Amazon Kinesis Video Streams.
    /// Amazon Rekognition Video sends analysis results to Amazon Kinesis Data Streams.
    /// </para>
    ///  
    /// <para>
    /// You provide as input a Kinesis video stream (<code>Input</code>) and a Kinesis data
    /// stream (<code>Output</code>) stream. You also specify the face recognition criteria
    /// in <code>Settings</code>. For example, the collection containing faces that you want
    /// to recognize. Use <code>Name</code> to assign an identifier for the stream processor.
    /// You use <code>Name</code> to manage the stream processor. For example, you can start
    /// processing the source video by calling <a>StartStreamProcessor</a> with the <code>Name</code>
    /// field. 
    /// </para>
    ///  
    /// <para>
    /// After you have finished analyzing a streaming video, use <a>StopStreamProcessor</a>
    /// to stop processing. You can delete the stream processor by calling <a>DeleteStreamProcessor</a>.
    /// </para>
    /// </summary>
    public partial class CreateStreamProcessorRequest : AmazonRekognitionRequest
    {
        private StreamProcessorInput _input;
        private string _name;
        private StreamProcessorOutput _output;
        private string _roleArn;
        private StreamProcessorSettings _settings;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Kinesis video stream stream that provides the source streaming video. If you are using
        /// the AWS CLI, the parameter name is <code>StreamProcessorInput</code>.
        /// </para>
        /// </summary>
        public StreamProcessorInput Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An identifier you assign to the stream processor. You can use <code>Name</code> to
        /// manage the stream processor. For example, you can get the current status of the stream
        /// processor by calling <a>DescribeStreamProcessor</a>. <code>Name</code> is idempotent.
        /// 
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// Kinesis data stream stream to which Amazon Rekognition Video puts the analysis results.
        /// If you are using the AWS CLI, the parameter name is <code>StreamProcessorOutput</code>.
        /// </para>
        /// </summary>
        public StreamProcessorOutput Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// ARN of the IAM role that allows access to the stream processor.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// Face recognition input parameters to be used by the stream processor. Includes the
        /// collection to use for face recognition and the face attributes to detect.
        /// </para>
        /// </summary>
        public StreamProcessorSettings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

    }
}