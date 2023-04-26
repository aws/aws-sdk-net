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
    /// This is the response object from the DescribeJobTemplate operation.
    /// </summary>
    public partial class DescribeJobTemplateResponse : AmazonWebServiceResponse
    {
        private AbortConfig _abortConfig;
        private DateTime? _createdAt;
        private string _description;
        private string _document;
        private string _documentSource;
        private JobExecutionsRetryConfig _jobExecutionsRetryConfig;
        private JobExecutionsRolloutConfig _jobExecutionsRolloutConfig;
        private string _jobTemplateArn;
        private string _jobTemplateId;
        private List<MaintenanceWindow> _maintenanceWindows = new List<MaintenanceWindow>();
        private PresignedUrlConfig _presignedUrlConfig;
        private TimeoutConfig _timeoutConfig;

        /// <summary>
        /// Gets and sets the property AbortConfig.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time, in seconds since the epoch, when the job template was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the job template.
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
        /// Gets and sets the property JobExecutionsRetryConfig. 
        /// <para>
        /// The configuration that determines how many retries are allowed for each failure type
        /// for a job.
        /// </para>
        /// </summary>
        public JobExecutionsRetryConfig JobExecutionsRetryConfig
        {
            get { return this._jobExecutionsRetryConfig; }
            set { this._jobExecutionsRetryConfig = value; }
        }

        // Check to see if JobExecutionsRetryConfig property is set
        internal bool IsSetJobExecutionsRetryConfig()
        {
            return this._jobExecutionsRetryConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobExecutionsRolloutConfig.
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
        /// Gets and sets the property JobTemplateArn. 
        /// <para>
        /// The ARN of the job template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string JobTemplateArn
        {
            get { return this._jobTemplateArn; }
            set { this._jobTemplateArn = value; }
        }

        // Check to see if JobTemplateArn property is set
        internal bool IsSetJobTemplateArn()
        {
            return this._jobTemplateArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobTemplateId. 
        /// <para>
        /// The unique identifier of the job template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string JobTemplateId
        {
            get { return this._jobTemplateId; }
            set { this._jobTemplateId = value; }
        }

        // Check to see if JobTemplateId property is set
        internal bool IsSetJobTemplateId()
        {
            return this._jobTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceWindows. 
        /// <para>
        /// Allows you to configure an optional maintenance window for the rollout of a job document
        /// to all devices in the target group for a job.
        /// </para>
        /// </summary>
        public List<MaintenanceWindow> MaintenanceWindows
        {
            get { return this._maintenanceWindows; }
            set { this._maintenanceWindows = value; }
        }

        // Check to see if MaintenanceWindows property is set
        internal bool IsSetMaintenanceWindows()
        {
            return this._maintenanceWindows != null && this._maintenanceWindows.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PresignedUrlConfig.
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
        /// Gets and sets the property TimeoutConfig.
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