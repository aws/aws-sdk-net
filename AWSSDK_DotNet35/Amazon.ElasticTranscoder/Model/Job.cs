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
        private string arn;
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

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) for the job.
        ///  
        /// </summary>
        public string Arn
        {
            get { return this.arn; }
            set { this.arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this.arn != null;
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

        // Check to see if Playlists property is set
        internal bool IsSetPlaylists()
        {
            return this.playlists.Count > 0;
        }

        /// <summary>
        /// The status of the job: <c>Submitted</c>, <c>Progressing</c>, <c>Complete</c>, <c>Canceled</c>, or <c>Error</c>.
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

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }
    }
}
