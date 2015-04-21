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
    /// A section of the response body that provides information about the job that is created.
    /// </summary>
    public partial class Job
    {
        private string _arn;
        private string _id;
        private JobInput _input;
        private JobOutput _output;
        private string _outputKeyPrefix;
        private List<JobOutput> _outputs = new List<JobOutput>();
        private string _pipelineId;
        private List<Playlist> _playlists = new List<Playlist>();
        private string _status;
        private Timing _timing;
        private Dictionary<string, string> _userMetadata = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the job.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The identifier that Elastic Transcoder assigned to the job. You use this value to
        /// get settings for the job or to delete the job. 
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        ///  A section of the request or response body that provides information about the file
        /// that is being transcoded.
        /// </para>
        /// </summary>
        public JobInput Input
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
        /// Gets and sets the property Output. 
        /// <para>
        /// If you specified one output for a job, information about that output. If you specified
        /// multiple outputs for a job, the Output object lists information about the first output.
        /// This duplicates the information that is listed for the first output in the Outputs
        /// object.
        /// </para>
        ///  
        /// <para>
        /// <important>Outputs recommended instead.</important> A section of the request or response
        /// body that provides information about the transcoded (target) file. 
        /// </para>
        /// </summary>
        public JobOutput Output
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
        /// Gets and sets the property OutputKeyPrefix. 
        /// <para>
        /// The value, if any, that you want Elastic Transcoder to prepend to the names of all
        /// files that this job creates, including output files, thumbnails, and playlists. We
        /// recommend that you add a / or some other delimiter to the end of the <code>OutputKeyPrefix</code>.
        /// </para>
        /// </summary>
        public string OutputKeyPrefix
        {
            get { return this._outputKeyPrefix; }
            set { this._outputKeyPrefix = value; }
        }

        // Check to see if OutputKeyPrefix property is set
        internal bool IsSetOutputKeyPrefix()
        {
            return this._outputKeyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// Information about the output files. We recommend that you use the <code>Outputs</code>
        /// syntax for all jobs, even when you want Elastic Transcoder to transcode a file into
        /// only one format. Do not use both the <code>Outputs</code> and <code>Output</code>
        /// syntaxes in the same request. You can create a maximum of 30 outputs per job. 
        /// </para>
        ///  
        /// <para>
        ///  If you specify more than one output for a job, Elastic Transcoder creates the files
        /// for each output in the order in which you specify them in the job.
        /// </para>
        /// </summary>
        public List<JobOutput> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && this._outputs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PipelineId. 
        /// <para>
        ///  The <code>Id</code> of the pipeline that you want Elastic Transcoder to use for transcoding.
        /// The pipeline determines several settings, including the Amazon S3 bucket from which
        /// Elastic Transcoder gets the files to transcode and the bucket into which Elastic Transcoder
        /// puts the transcoded files. 
        /// </para>
        /// </summary>
        public string PipelineId
        {
            get { return this._pipelineId; }
            set { this._pipelineId = value; }
        }

        // Check to see if PipelineId property is set
        internal bool IsSetPipelineId()
        {
            return this._pipelineId != null;
        }

        /// <summary>
        /// Gets and sets the property Playlists. 
        /// <para>
        /// <important>Outputs in Fragmented MP4 or MPEG-TS format only.</important>If you specify
        /// a preset in <code>PresetId</code> for which the value of <code>Container</code> is
        /// fmp4 (Fragmented MP4) or ts (MPEG-TS), <code>Playlists</code> contains information
        /// about the master playlists that you want Elastic Transcoder to create.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of master playlists in a job is 30. 
        /// </para>
        /// </summary>
        public List<Playlist> Playlists
        {
            get { return this._playlists; }
            set { this._playlists = value; }
        }

        // Check to see if Playlists property is set
        internal bool IsSetPlaylists()
        {
            return this._playlists != null && this._playlists.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the job: <code>Submitted</code>, <code>Progressing</code>, <code>Complete</code>,
        /// <code>Canceled</code>, or <code>Error</code>. 
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Timing. 
        /// <para>
        /// Details about the timing of a job.
        /// </para>
        /// </summary>
        public Timing Timing
        {
            get { return this._timing; }
            set { this._timing = value; }
        }

        // Check to see if Timing property is set
        internal bool IsSetTiming()
        {
            return this._timing != null;
        }

        /// <summary>
        /// Gets and sets the property UserMetadata. 
        /// <para>
        /// User-defined metadata that you want to associate with an Elastic Transcoder job. You
        /// specify metadata in <code>key/value</code> pairs, and you can add up to 10 <code>key/value</code>
        /// pairs per job. Elastic Transcoder does not guarantee that <code>key/value</code> pairs
        /// will be returned in the same order in which you specify them.
        /// </para>
        ///  
        /// <para>
        /// Metadata <code>keys</code> and <code>values</code> must use characters from the following
        /// list:
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// <code>0-9</code>
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>A-Z</code> and <code>a-z</code>
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>Space</code>
        /// </para>
        /// </li> <li>
        /// <para>
        /// The following symbols: <code>_.:/=+-%@</code>
        /// </para>
        /// </li> </ul>
        /// </summary>
        public Dictionary<string, string> UserMetadata
        {
            get { return this._userMetadata; }
            set { this._userMetadata = value; }
        }

        // Check to see if UserMetadata property is set
        internal bool IsSetUserMetadata()
        {
            return this._userMetadata != null && this._userMetadata.Count > 0; 
        }

    }
}