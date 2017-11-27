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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Container for the parameters to the CreateJob operation.
    /// Create a new transcoding job. For information about jobs and job settings, see the
    /// User Guide at http://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html
    /// </summary>
    public partial class CreateJobRequest : AmazonMediaConvertRequest
    {
        private string _clientRequestToken;
        private string _jobTemplate;
        private string _queue;
        private string _role;
        private JobSettings _settings;
        private Dictionary<string, string> _userMetadata = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken. Idempotency token for CreateJob operation.
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property JobTemplate. When you create a job, you can either specify
        /// a job template or specify the transcoding settings individually
        /// </summary>
        public string JobTemplate
        {
            get { return this._jobTemplate; }
            set { this._jobTemplate = value; }
        }

        // Check to see if JobTemplate property is set
        internal bool IsSetJobTemplate()
        {
            return this._jobTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property Queue. Optional. When you create a job, you can specify
        /// a queue to send it to. If you don't specify, the job will go to the default queue.
        /// For more about queues, see the User Guide topic at http://docs.aws.amazon.com/mediaconvert/latest/ug/what-is.html.
        /// </summary>
        public string Queue
        {
            get { return this._queue; }
            set { this._queue = value; }
        }

        // Check to see if Queue property is set
        internal bool IsSetQueue()
        {
            return this._queue != null;
        }

        /// <summary>
        /// Gets and sets the property Role. Required. The IAM role you use for creating this
        /// job. For details about permissions, see the User Guide topic at the User Guide at
        /// http://docs.aws.amazon.com/mediaconvert/latest/ug/iam-role.html.
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
        /// Gets and sets the property Settings.
        /// </summary>
        public JobSettings Settings
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
        /// Gets and sets the property UserMetadata. User-defined metadata that you want to associate
        /// with an MediaConvert job. You specify metadata in key/value pairs.
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