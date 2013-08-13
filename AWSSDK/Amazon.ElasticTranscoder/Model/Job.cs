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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// <para>A section of the response body that provides information about the job that is created.</para>
    /// </summary>
    public class Job
    {
        
        private string id;
        private string pipelineId;
        private JobInput input;
        private JobOutput output;
        private List<JobOutput> outputs = new List<JobOutput>();
        private string outputKeyPrefix;
        private List<Playlist> playlists = new List<Playlist>();
        private string status;

        /// <summary>
        /// The identifier that Elastic Transcoder assigned to the job. You use this value to get settings for the job or to delete the job.
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
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Job WithId(string id)
        {
            this.id = id;
            return this;
        }
            

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

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
        public Job WithPipelineId(string pipelineId)
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
        /// A section of the request or response body that provides information about the file that is being transcoded.
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
        public Job WithInput(JobInput input)
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
        /// If you specified one output for a job, information about that output. If you specified multiple outputs for a job, the Output object lists
        /// information about the first output. This duplicates the information that is listed for the first output in the Outputs object.
        /// <important>Outputs recommended instead.</important> A section of the request or response body that provides information about the transcoded
        /// (target) file.
        ///  
        /// </summary>
        public JobOutput Output
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
        public Job WithOutput(JobOutput output)
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
        /// Information about the output files. We recommend that you use the <c>Outputs</c> syntax for all jobs, even when you want Elastic Transcoder
        /// to transcode a file into only one format. Do not use both the <c>Outputs</c> and <c>Output</c> syntaxes in the same request. You can create
        /// a maximum of 30 outputs per job. If you specify more than one output for a job, Elastic Transcoder creates the files for each output in the
        /// order in which you specify them in the job.
        ///  
        /// </summary>
        public List<JobOutput> Outputs
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
        public Job WithOutputs(params JobOutput[] outputs)
        {
            foreach (JobOutput element in outputs)
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
        public Job WithOutputs(IEnumerable<JobOutput> outputs)
        {
            foreach (JobOutput element in outputs)
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
        /// thumbnails, and playlists. We recommend that you add a / or some other delimiter to the end of the <c>OutputKeyPrefix</c>.
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
        public Job WithOutputKeyPrefix(string outputKeyPrefix)
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
        /// <important>Outputs in MPEG-TS format only.</important>If you specify a preset in <c>PresetId</c> for which the value of <c>Container</c> is
        /// ts (MPEG-TS), <c>Playlists</c> contains information about the master playlists that you want Elastic Transcoder to create. We recommend that
        /// you create only one master playlist. The maximum number of master playlists in a job is 30.
        ///  
        /// </summary>
        public List<Playlist> Playlists
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
        public Job WithPlaylists(params Playlist[] playlists)
        {
            foreach (Playlist element in playlists)
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
        public Job WithPlaylists(IEnumerable<Playlist> playlists)
        {
            foreach (Playlist element in playlists)
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

        /// <summary>
        /// The status of the job: <c>Submitted</c>, <c>Progressing</c>, <c>l</c>, <c>Canceled</c>, or <c>Error</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^Submitted$)|(^Progressing$)|(^Complete$)|(^Canceled$)|(^Error$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Job WithStatus(string status)
        {
            this.status = status;
            return this;
        }
            

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }
    }
}
