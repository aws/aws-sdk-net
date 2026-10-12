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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Contains detailed information about a training session.
    /// </summary>
    public partial class TrainingSessionDetail
    {
        private BillableTokenUsage _billableTokenUsage;
        private DateTime? _creationTime;
        private DateTime? _endTime;
        private string _errorDetails;
        private DateTime? _lastModifiedTime;
        private int? _lastReceivedSequenceNumber;
        private LoraConfig _loraConfig;
        private TrainingSessionModelConfig _modelConfig;
        private string _modelPackageGroupArn;
        private TrainingSessionOutputConfig _outputConfig;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _trainingSessionArn;
        private string _trainingSessionName;
        private TrainingSessionStatus _trainingSessionStatus;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property BillableTokenUsage. 
        /// <para>
        /// The billable token usage for the training session.
        /// </para>
        /// </summary>
        public BillableTokenUsage BillableTokenUsage
        {
            get { return this._billableTokenUsage; }
            set { this._billableTokenUsage = value; }
        }

        // Check to see if BillableTokenUsage property is set
        internal bool IsSetBillableTokenUsage()
        {
            return this._billableTokenUsage != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the training session was created.
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time that the training session ended.
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
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// If the training session failed or is blocked, detailed error information.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ErrorDetails
        {
            get { return this._errorDetails; }
            set { this._errorDetails = value; }
        }

        // Check to see if ErrorDetails property is set
        internal bool IsSetErrorDetails()
        {
            return this._errorDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the training session was last modified.
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
        /// Gets and sets the property LastReceivedSequenceNumber. 
        /// <para>
        /// The sequence number of the last training operation received by the session.
        /// </para>
        /// </summary>
        public int? LastReceivedSequenceNumber
        {
            get { return this._lastReceivedSequenceNumber; }
            set { this._lastReceivedSequenceNumber = value; }
        }

        // Check to see if LastReceivedSequenceNumber property is set
        internal bool IsSetLastReceivedSequenceNumber()
        {
            return this._lastReceivedSequenceNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoraConfig. 
        /// <para>
        /// The Low-Rank Adaptation (LoRA) configuration for the training session.
        /// </para>
        /// </summary>
        public LoraConfig LoraConfig
        {
            get { return this._loraConfig; }
            set { this._loraConfig = value; }
        }

        // Check to see if LoraConfig property is set
        internal bool IsSetLoraConfig()
        {
            return this._loraConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ModelConfig. 
        /// <para>
        /// The configuration for the base model.
        /// </para>
        /// </summary>
        public TrainingSessionModelConfig ModelConfig
        {
            get { return this._modelConfig; }
            set { this._modelConfig = value; }
        }

        // Check to see if ModelConfig property is set
        internal bool IsSetModelConfig()
        {
            return this._modelConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model package group where checkpoints are published.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ModelPackageGroupArn
        {
            get { return this._modelPackageGroupArn; }
            set { this._modelPackageGroupArn = value; }
        }

        // Check to see if ModelPackageGroupArn property is set
        internal bool IsSetModelPackageGroupArn()
        {
            return this._modelPackageGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The output configuration for the training session.
        /// </para>
        /// </summary>
        public TrainingSessionOutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role associated with the training session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the training session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrainingSessionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the training session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string TrainingSessionArn
        {
            get { return this._trainingSessionArn; }
            set { this._trainingSessionArn = value; }
        }

        // Check to see if TrainingSessionArn property is set
        internal bool IsSetTrainingSessionArn()
        {
            return this._trainingSessionArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingSessionName. 
        /// <para>
        /// The name of the training session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string TrainingSessionName
        {
            get { return this._trainingSessionName; }
            set { this._trainingSessionName = value; }
        }

        // Check to see if TrainingSessionName property is set
        internal bool IsSetTrainingSessionName()
        {
            return this._trainingSessionName != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingSessionStatus. 
        /// <para>
        /// The current status of the training session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrainingSessionStatus TrainingSessionStatus
        {
            get { return this._trainingSessionStatus; }
            set { this._trainingSessionStatus = value; }
        }

        // Check to see if TrainingSessionStatus property is set
        internal bool IsSetTrainingSessionStatus()
        {
            return this._trainingSessionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The Virtual Private Cloud (VPC) configuration for the training session.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}