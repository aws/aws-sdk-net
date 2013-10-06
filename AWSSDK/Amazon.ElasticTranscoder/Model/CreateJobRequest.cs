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
    /// <para> When you create a job, Elastic Transcoder returns JSON data that includes the values that you specified plus information about the
    /// job that is created. </para> <para>If you have specified more than one output for your jobs (for example, one output for the Kindle Fire and
    /// another output for the Apple iPhone 4s), you currently must use the Elastic Transcoder API to list the jobs (as opposed to the AWS
    /// Console).</para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.CreateJob"/>
    public class CreateJobRequest : AmazonWebServiceRequest
    {
        private string pipelineId;
        private JobInput input;
        private CreateJobOutput output;
        private List<CreateJobOutput> outputs = new List<CreateJobOutput>();
        private string outputKeyPrefix;
        private List<CreateJobPlaylist> playlists = new List<CreateJobPlaylist>();

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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// 
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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

        /// <summary>
        /// A section of the request body that provides information about the transcoded (target) files. We recommend that you use the <c>Outputs</c>
        /// syntax instead of the <c>Output</c> syntax.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 30</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<CreateJobOutput> Outputs
        {
            get { return this.outputs; }
            set { this.outputs = value; }
        }
        /// <summary>
        /// Adds elements to the Outputs collection
        /// </summary>
        /// <param name="outputs">The values to add to the Outputs collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobRequest WithOutputs(params CreateJobOutput[] outputs)
        {
            foreach (CreateJobOutput element in outputs)
            {
                this.outputs.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Outputs collection
        /// </summary>
        /// <param name="outputs">The values to add to the Outputs collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobRequest WithOutputs(IEnumerable<CreateJobOutput> outputs)
        {
            foreach (CreateJobOutput element in outputs)
            {
                this.outputs.Add(element);
            }

            return this;
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this.outputs.Count > 0;
        }

        /// <summary>
        /// The value, if any, that you want Elastic Transcoder to prepend to the names of all files that this job creates, including output files,
        /// thumbnails, and playlists.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string OutputKeyPrefix
        {
            get { return this.outputKeyPrefix; }
            set { this.outputKeyPrefix = value; }
        }

        /// <summary>
        /// Sets the OutputKeyPrefix property
        /// </summary>
        /// <param name="outputKeyPrefix">The value to set for the OutputKeyPrefix property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobRequest WithOutputKeyPrefix(string outputKeyPrefix)
        {
            this.outputKeyPrefix = outputKeyPrefix;
            return this;
        }
            

        // Check to see if OutputKeyPrefix property is set
        internal bool IsSetOutputKeyPrefix()
        {
            return this.outputKeyPrefix != null;
        }

        /// <summary>
        /// If you specify a preset in <c>PresetId</c> for which the value of <c>Container</c> is ts (MPEG-TS), Playlists contains information about the
        /// master playlists that you want Elastic Transcoder to create. We recommend that you create only one master playlist. The maximum number of
        /// master playlists in a job is 30.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 30</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<CreateJobPlaylist> Playlists
        {
            get { return this.playlists; }
            set { this.playlists = value; }
        }
        /// <summary>
        /// Adds elements to the Playlists collection
        /// </summary>
        /// <param name="playlists">The values to add to the Playlists collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobRequest WithPlaylists(params CreateJobPlaylist[] playlists)
        {
            foreach (CreateJobPlaylist element in playlists)
            {
                this.playlists.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Playlists collection
        /// </summary>
        /// <param name="playlists">The values to add to the Playlists collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobRequest WithPlaylists(IEnumerable<CreateJobPlaylist> playlists)
        {
            foreach (CreateJobPlaylist element in playlists)
            {
                this.playlists.Add(element);
            }

            return this;
        }

        // Check to see if Playlists property is set
        internal bool IsSetPlaylists()
        {
            return this.playlists.Count > 0;
        }
    }
}
    
