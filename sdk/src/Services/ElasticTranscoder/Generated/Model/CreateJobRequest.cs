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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
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
namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Container for the parameters to the CreateJob operation.
    /// When you create a job, Elastic Transcoder returns JSON data that includes the values
    /// that you specified plus information about the job that is created.
    /// 
    ///  
    /// <para>
    /// If you have specified more than one output for your jobs (for example, one output
    /// for the Kindle Fire and another output for the Apple iPhone 4s), you currently must
    /// use the Elastic Transcoder API to list the jobs (as opposed to the AWS Console).
    /// </para>
    /// </summary>
    public partial class CreateJobRequest : AmazonElasticTranscoderRequest
    {
        private JobInput _input;
        private List<JobInput> _inputs = AWSConfigs.InitializeCollections ? new List<JobInput>() : null;
        private CreateJobOutput _output;
        private string _outputKeyPrefix;
        private List<CreateJobOutput> _outputs = AWSConfigs.InitializeCollections ? new List<CreateJobOutput>() : null;
        private string _pipelineId;
        private List<CreateJobPlaylist> _playlists = AWSConfigs.InitializeCollections ? new List<CreateJobPlaylist>() : null;
        private Dictionary<string, string> _userMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// A section of the request body that provides information about the file that is being
        /// transcoded.
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
        /// Gets and sets the property Inputs. 
        /// <para>
        /// A section of the request body that provides information about the files that are being
        /// transcoded.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=200)]
        public List<JobInput> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }

        // Check to see if Inputs property is set
        internal bool IsSetInputs()
        {
            return this._inputs != null && (this._inputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        ///  A section of the request body that provides information about the transcoded (target)
        /// file. We strongly recommend that you use the <c>Outputs</c> syntax instead of the
        /// <c>Output</c> syntax. 
        /// </para>
        /// </summary>
        public CreateJobOutput Output
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
        /// files that this job creates, including output files, thumbnails, and playlists.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        ///  A section of the request body that provides information about the transcoded (target)
        /// files. We recommend that you use the <c>Outputs</c> syntax instead of the <c>Output</c>
        /// syntax. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=30)]
        public List<CreateJobOutput> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && (this._outputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PipelineId. 
        /// <para>
        /// The <c>Id</c> of the pipeline that you want Elastic Transcoder to use for transcoding.
        /// The pipeline determines several settings, including the Amazon S3 bucket from which
        /// Elastic Transcoder gets the files to transcode and the bucket into which Elastic Transcoder
        /// puts the transcoded files.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// If you specify a preset in <c>PresetId</c> for which the value of <c>Container</c>
        /// is fmp4 (Fragmented MP4) or ts (MPEG-TS), Playlists contains information about the
        /// master playlists that you want Elastic Transcoder to create.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of master playlists in a job is 30.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=30)]
        public List<CreateJobPlaylist> Playlists
        {
            get { return this._playlists; }
            set { this._playlists = value; }
        }

        // Check to see if Playlists property is set
        internal bool IsSetPlaylists()
        {
            return this._playlists != null && (this._playlists.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserMetadata. 
        /// <para>
        /// User-defined metadata that you want to associate with an Elastic Transcoder job. You
        /// specify metadata in <c>key/value</c> pairs, and you can add up to 10 <c>key/value</c>
        /// pairs per job. Elastic Transcoder does not guarantee that <c>key/value</c> pairs are
        /// returned in the same order in which you specify them.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> UserMetadata
        {
            get { return this._userMetadata; }
            set { this._userMetadata = value; }
        }

        // Check to see if UserMetadata property is set
        internal bool IsSetUserMetadata()
        {
            return this._userMetadata != null && (this._userMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}