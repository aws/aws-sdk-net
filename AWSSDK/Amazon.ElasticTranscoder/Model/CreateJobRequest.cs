/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the CreateJob operation.
    /// <para>To create a job, send a POST request to the <c>/2012-09-25/jobs</c> resource.</para> <para> When you create a job, Elastic Transcoder
    /// returns JSON data that includes the values that you specified plus information about the job that is created. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.CreateJob"/>
    public class CreateJobRequest : AmazonWebServiceRequest
    {
        private string pipelineId;
        private JobInput input;
        private CreateJobOutput output;

        /// <summary>
        /// The <c>Id</c> of the pipeline that you want Elastic Transcoder to use for transcoding. The pipeline determines several settings, including
        /// the Amazon S3 bucket from which Elastic Transcoder gets the files to transcode and the bucket into which Elastic Transcoder puts the
        /// transcoded files.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d{13}-\w{6}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PipelineId
        {
            get { return this.pipelineId; }
            set { this.pipelineId = value; }
        }

        /// <summary>
        /// Sets the PipelineId property
        /// </summary>
        /// <param name="pipelineId">The value to set for the PipelineId property </param>
        /// <returns>this instance</returns>
        public CreateJobRequest WithPipelineId(string pipelineId)
        {
            this.pipelineId = pipelineId;
            return this;
        }
            

        // Check to see if PipelineId property is set
        internal bool IsSetPipelineId()
        {
            return this.pipelineId != null;
        }

        /// <summary>
        /// A section of the request body that provides information about the file that is being transcoded.
        ///  
        /// </summary>
        public JobInput Input
        {
            get { return this.input; }
            set { this.input = value; }
        }

        /// <summary>
        /// Sets the Input property
        /// </summary>
        /// <param name="input">The value to set for the Input property </param>
        /// <returns>this instance</returns>
        public CreateJobRequest WithInput(JobInput input)
        {
            this.input = input;
            return this;
        }
            

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this.input != null;
        }

        /// <summary>
        /// A section of the request body that provides information about the transcoded (target) file.
        ///  
        /// </summary>
        public CreateJobOutput Output
        {
            get { return this.output; }
            set { this.output = value; }
        }

        /// <summary>
        /// Sets the Output property
        /// </summary>
        /// <param name="output">The value to set for the Output property </param>
        /// <returns>this instance</returns>
        public CreateJobRequest WithOutput(CreateJobOutput output)
        {
            this.output = output;
            return this;
        }
            

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this.output != null;
        }
    }
}
    
