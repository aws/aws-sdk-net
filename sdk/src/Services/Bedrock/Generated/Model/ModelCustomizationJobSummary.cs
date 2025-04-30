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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Information about one customization job
    /// </summary>
    public partial class ModelCustomizationJobSummary
    {
        private string _baseModelArn;
        private DateTime? _creationTime;
        private CustomizationType _customizationType;
        private string _customModelArn;
        private string _customModelName;
        private DateTime? _endTime;
        private string _jobArn;
        private string _jobName;
        private DateTime? _lastModifiedTime;
        private ModelCustomizationJobStatus _status;
        private StatusDetails _statusDetails;

        /// <summary>
        /// Gets and sets the property BaseModelArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the base model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1011)]
        public string BaseModelArn
        {
            get { return this._baseModelArn; }
            set { this._baseModelArn = value; }
        }

        // Check to see if BaseModelArn property is set
        internal bool IsSetBaseModelArn()
        {
            return this._baseModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Creation time of the custom model. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomizationType. 
        /// <para>
        /// Specifies whether to carry out continued pre-training of a model or whether to fine-tune
        /// it. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a>.
        /// </para>
        /// </summary>
        public CustomizationType CustomizationType
        {
            get { return this._customizationType; }
            set { this._customizationType = value; }
        }

        // Check to see if CustomizationType property is set
        internal bool IsSetCustomizationType()
        {
            return this._customizationType != null;
        }

        /// <summary>
        /// Gets and sets the property CustomModelArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the custom model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=1011)]
        public string CustomModelArn
        {
            get { return this._customModelArn; }
            set { this._customModelArn = value; }
        }

        // Check to see if CustomModelArn property is set
        internal bool IsSetCustomModelArn()
        {
            return this._customModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property CustomModelName. 
        /// <para>
        /// Name of the custom model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string CustomModelName
        {
            get { return this._customModelName; }
            set { this._customModelName = value; }
        }

        // Check to see if CustomModelName property is set
        internal bool IsSetCustomModelName()
        {
            return this._customModelName != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Time that the customization job ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the customization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1011)]
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// Name of the customization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Time that the customization job was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the customization job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelCustomizationJobStatus Status
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
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// Details about the status of the data processing sub-task of the job.
        /// </para>
        /// </summary>
        public StatusDetails StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null;
        }

    }
}