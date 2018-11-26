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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Structure for an execution step for an execution job, for an Amplify App.
    /// </summary>
    public partial class Step
    {
        private string _artifactsUrl;
        private DateTime? _endTime;
        private string _logUrl;
        private Dictionary<string, string> _screenshots = new Dictionary<string, string>();
        private DateTime? _startTime;
        private JobStatus _status;
        private string _stepName;

        /// <summary>
        /// Gets and sets the property ArtifactsUrl. 
        /// <para>
        ///  Url to teh artifact for the execution step. 
        /// </para>
        /// </summary>
        public string ArtifactsUrl
        {
            get { return this._artifactsUrl; }
            set { this._artifactsUrl = value; }
        }

        // Check to see if ArtifactsUrl property is set
        internal bool IsSetArtifactsUrl()
        {
            return this._artifactsUrl != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  End date/ time of the execution step. 
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogUrl. 
        /// <para>
        ///  Url to the logs for the execution step. 
        /// </para>
        /// </summary>
        public string LogUrl
        {
            get { return this._logUrl; }
            set { this._logUrl = value; }
        }

        // Check to see if LogUrl property is set
        internal bool IsSetLogUrl()
        {
            return this._logUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Screenshots. 
        /// <para>
        ///  List of screenshot Urls for the execution step, if relevant. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> Screenshots
        {
            get { return this._screenshots; }
            set { this._screenshots = value; }
        }

        // Check to see if Screenshots property is set
        internal bool IsSetScreenshots()
        {
            return this._screenshots != null && this._screenshots.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  Start date/ time of the execution step. 
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  Status of the execution step. 
        /// </para>
        /// </summary>
        public JobStatus Status
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
        /// Gets and sets the property StepName. 
        /// <para>
        ///  Name of the execution step. 
        /// </para>
        /// </summary>
        public string StepName
        {
            get { return this._stepName; }
            set { this._stepName = value; }
        }

        // Check to see if StepName property is set
        internal bool IsSetStepName()
        {
            return this._stepName != null;
        }

    }
}