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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateJob operation.
    /// Creates a job.
    /// </summary>
    public partial class CreateJobRequest : AmazonIoTRequest
    {
        private AbortConfig _abortConfig;
        private string _description;
        private string _document;
        private string _documentSource;
        private JobExecutionsRolloutConfig _jobExecutionsRolloutConfig;
        private string _jobId;
        private string _namespaceId;
        private PresignedUrlConfig _presignedUrlConfig;
        private List<Tag> _tags = new List<Tag>();
        private List<string> _targets = new List<string>();
        private TargetSelection _targetSelection;
        private TimeoutConfig _timeoutConfig;

        /// <summary>
        /// Gets and sets the property AbortConfig. 
        /// <para>
        /// Allows you to create criteria to abort a job.
        /// </para>
        /// </summary>
        public AbortConfig AbortConfig
        {
            get { return this._abortConfig; }
            set { this._abortConfig = value; }
        }

        // Check to see if AbortConfig property is set
        internal bool IsSetAbortConfig()
        {
            return this._abortConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A short text description of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2028)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Document. 
        /// <para>
        /// The job document.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the job document resides in an S3 bucket, you must use a placeholder link when
        /// specifying the document.
        /// </para>
        ///  
        /// <para>
        /// The placeholder link is of the following form:
        /// </para>
        ///  
        /// <para>
        ///  <code>${aws:iot:s3-presigned-url:https://s3.amazonaws.com/<i>bucket</i>/<i>key</i>}</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// where <i>bucket</i> is your bucket name and <i>key</i> is the object in the bucket
        /// to which you are linking.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=32768)]
        public string Document
        {
            get { return this._document; }
            set { this._document = value; }
        }

        // Check to see if Document property is set
        internal bool IsSetDocument()
        {
            return this._document != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentSource. 
        /// <para>
        /// An S3 link to the job document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1350)]
        public string DocumentSource
        {
            get { return this._documentSource; }
            set { this._documentSource = value; }
        }

        // Check to see if DocumentSource property is set
        internal bool IsSetDocumentSource()
        {
            return this._documentSource != null;
        }

        /// <summary>
        /// Gets and sets the property JobExecutionsRolloutConfig. 
        /// <para>
        /// Allows you to create a staged rollout of the job.
        /// </para>
        /// </summary>
        public JobExecutionsRolloutConfig JobExecutionsRolloutConfig
        {
            get { return this._jobExecutionsRolloutConfig; }
            set { this._jobExecutionsRolloutConfig = value; }
        }

        // Check to see if JobExecutionsRolloutConfig property is set
        internal bool IsSetJobExecutionsRolloutConfig()
        {
            return this._jobExecutionsRolloutConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// A job identifier which must be unique for your AWS account. We recommend using a UUID.
        /// Alpha-numeric characters, "-" and "_" are valid for use here.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property NamespaceId. 
        /// <para>
        /// The namespace used to indicate that a job is a customer-managed job.
        /// </para>
        ///  
        /// <para>
        /// When you specify a value for this parameter, AWS IoT Core sends jobs notifications
        /// to MQTT topics that contain the value in the following format.
        /// </para>
        ///  
        /// <para>
        ///  <code>$aws/things/<i>THING_NAME</i>/jobs/<i>JOB_ID</i>/notify-namespace-<i>NAMESPACE_ID</i>/</code>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>namespaceId</code> feature is in public preview.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string NamespaceId
        {
            get { return this._namespaceId; }
            set { this._namespaceId = value; }
        }

        // Check to see if NamespaceId property is set
        internal bool IsSetNamespaceId()
        {
            return this._namespaceId != null;
        }

        /// <summary>
        /// Gets and sets the property PresignedUrlConfig. 
        /// <para>
        /// Configuration information for pre-signed S3 URLs.
        /// </para>
        /// </summary>
        public PresignedUrlConfig PresignedUrlConfig
        {
            get { return this._presignedUrlConfig; }
            set { this._presignedUrlConfig = value; }
        }

        // Check to see if PresignedUrlConfig property is set
        internal bool IsSetPresignedUrlConfig()
        {
            return this._presignedUrlConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata which can be used to manage the job.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// A list of things and thing groups to which the job should be sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && this._targets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetSelection. 
        /// <para>
        /// Specifies whether the job will continue to run (CONTINUOUS), or will be complete after
        /// all those things specified as targets have completed the job (SNAPSHOT). If continuous,
        /// the job may also be run on a thing when a change is detected in a target. For example,
        /// a job will run on a thing when the thing is added to a target group, even after the
        /// job was completed by all things originally in the group.
        /// </para>
        /// </summary>
        public TargetSelection TargetSelection
        {
            get { return this._targetSelection; }
            set { this._targetSelection = value; }
        }

        // Check to see if TargetSelection property is set
        internal bool IsSetTargetSelection()
        {
            return this._targetSelection != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutConfig. 
        /// <para>
        /// Specifies the amount of time each device has to finish its execution of the job. The
        /// timer is started when the job execution status is set to <code>IN_PROGRESS</code>.
        /// If the job execution status is not set to another terminal state before the time expires,
        /// it will be automatically set to <code>TIMED_OUT</code>.
        /// </para>
        /// </summary>
        public TimeoutConfig TimeoutConfig
        {
            get { return this._timeoutConfig; }
            set { this._timeoutConfig = value; }
        }

        // Check to see if TimeoutConfig property is set
        internal bool IsSetTimeoutConfig()
        {
            return this._timeoutConfig != null;
        }

    }
}