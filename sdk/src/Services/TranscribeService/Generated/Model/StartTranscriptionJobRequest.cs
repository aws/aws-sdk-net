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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the StartTranscriptionJob operation.
    /// Starts an asynchronous job to transcribe speech to text. Note that en-AU, en-UK, and
    /// fr-CA languages are in preview and are only available to whitelisted customers.
    /// </summary>
    public partial class StartTranscriptionJobRequest : AmazonTranscribeServiceRequest
    {
        private LanguageCode _languageCode;
        private Media _media;
        private MediaFormat _mediaFormat;
        private int? _mediaSampleRateHertz;
        private string _outputBucketName;
        private Settings _settings;
        private string _transcriptionJobName;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code for the language used in the input media file.
        /// </para>
        /// </summary>
        public LanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property Media. 
        /// <para>
        /// An object that describes the input media for a transcription job.
        /// </para>
        /// </summary>
        public Media Media
        {
            get { return this._media; }
            set { this._media = value; }
        }

        // Check to see if Media property is set
        internal bool IsSetMedia()
        {
            return this._media != null;
        }

        /// <summary>
        /// Gets and sets the property MediaFormat. 
        /// <para>
        /// The format of the input media file.
        /// </para>
        /// </summary>
        public MediaFormat MediaFormat
        {
            get { return this._mediaFormat; }
            set { this._mediaFormat = value; }
        }

        // Check to see if MediaFormat property is set
        internal bool IsSetMediaFormat()
        {
            return this._mediaFormat != null;
        }

        /// <summary>
        /// Gets and sets the property MediaSampleRateHertz. 
        /// <para>
        /// The sample rate, in Hertz, of the audio track in the input media file. 
        /// </para>
        /// </summary>
        public int MediaSampleRateHertz
        {
            get { return this._mediaSampleRateHertz.GetValueOrDefault(); }
            set { this._mediaSampleRateHertz = value; }
        }

        // Check to see if MediaSampleRateHertz property is set
        internal bool IsSetMediaSampleRateHertz()
        {
            return this._mediaSampleRateHertz.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputBucketName. 
        /// <para>
        /// The location where the transcription is stored.
        /// </para>
        ///  
        /// <para>
        /// If you set the <code>OutputBucketName</code>, Amazon Transcribe puts the transcription
        /// in the specified S3 bucket. When you call the <a>GetTranscriptionJob</a> operation,
        /// the operation returns this location in the <code>TranscriptFileUri</code> field. The
        /// S3 bucket must have permissions that allow Amazon Transcribe to put files in the bucket.
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/access-control-managing-permissions.html#auth-role-iam-user">Permissions
        /// Required for IAM User Roles</a>.
        /// </para>
        ///  
        /// <para>
        /// If you don't set the <code>OutputBucketName</code>, Amazon Transcribe generates a
        /// pre-signed URL, a shareable URL that provides secure access to your transcription,
        /// and returns it in the <code>TranscriptFileUri</code> field. Use this URL to download
        /// the transcription.
        /// </para>
        /// </summary>
        public string OutputBucketName
        {
            get { return this._outputBucketName; }
            set { this._outputBucketName = value; }
        }

        // Check to see if OutputBucketName property is set
        internal bool IsSetOutputBucketName()
        {
            return this._outputBucketName != null;
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// A <code>Settings</code> object that provides optional settings for a transcription
        /// job.
        /// </para>
        /// </summary>
        public Settings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

        /// <summary>
        /// Gets and sets the property TranscriptionJobName. 
        /// <para>
        /// The name of the job. You can't use the strings "." or ".." in the job name. The name
        /// must be unique within an AWS account.
        /// </para>
        /// </summary>
        public string TranscriptionJobName
        {
            get { return this._transcriptionJobName; }
            set { this._transcriptionJobName = value; }
        }

        // Check to see if TranscriptionJobName property is set
        internal bool IsSetTranscriptionJobName()
        {
            return this._transcriptionJobName != null;
        }

    }
}