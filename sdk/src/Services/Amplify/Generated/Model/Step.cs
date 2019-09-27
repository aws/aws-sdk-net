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
        private string _context;
        private DateTime? _endTime;
        private string _logUrl;
        private Dictionary<string, string> _screenshots = new Dictionary<string, string>();
        private DateTime? _startTime;
        private JobStatus _status;
        private string _statusReason;
        private string _stepName;
        private string _testArtifactsUrl;
        private string _testConfigUrl;

        /// <summary>
        /// Gets and sets the property ArtifactsUrl. 
        /// <para>
        ///  URL to the artifact for the execution step. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
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
        /// Gets and sets the property Context. 
        /// <para>
        ///  The context for current step, will include build image if step is build. 
        /// </para>
        /// </summary>
        public string Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  End date/ time of the execution step. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        ///  URL to the logs for the execution step. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
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
        ///  List of screenshot URLs for the execution step, if relevant. 
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
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        ///  The reason for current step status. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property StepName. 
        /// <para>
        ///  Name of the execution step. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
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

        /// <summary>
        /// Gets and sets the property TestArtifactsUrl. 
        /// <para>
        ///  URL to the test artifact for the execution step. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string TestArtifactsUrl
        {
            get { return this._testArtifactsUrl; }
            set { this._testArtifactsUrl = value; }
        }

        // Check to see if TestArtifactsUrl property is set
        internal bool IsSetTestArtifactsUrl()
        {
            return this._testArtifactsUrl != null;
        }

        /// <summary>
        /// Gets and sets the property TestConfigUrl. 
        /// <para>
        ///  URL to the test config for the execution step. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string TestConfigUrl
        {
            get { return this._testConfigUrl; }
            set { this._testConfigUrl = value; }
        }

        // Check to see if TestConfigUrl property is set
        internal bool IsSetTestConfigUrl()
        {
            return this._testConfigUrl != null;
        }

    }
}