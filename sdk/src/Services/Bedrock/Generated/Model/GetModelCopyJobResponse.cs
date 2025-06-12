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
    /// This is the response object from the GetModelCopyJob operation.
    /// </summary>
    public partial class GetModelCopyJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _failureMessage;
        private string _jobArn;
        private string _sourceAccountId;
        private string _sourceModelArn;
        private string _sourceModelName;
        private ModelCopyJobStatus _status;
        private string _targetModelArn;
        private string _targetModelKmsKeyArn;
        private string _targetModelName;
        private List<Tag> _targetModelTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the model copy job was created.
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
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// An error message for why the model copy job failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model copy job.
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
        /// Gets and sets the property SourceAccountId. 
        /// <para>
        /// The unique identifier of the account that the model being copied originated from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceAccountId
        {
            get { return this._sourceAccountId; }
            set { this._sourceAccountId = value; }
        }

        // Check to see if SourceAccountId property is set
        internal bool IsSetSourceAccountId()
        {
            return this._sourceAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the original model being copied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1011)]
        public string SourceModelArn
        {
            get { return this._sourceModelArn; }
            set { this._sourceModelArn = value; }
        }

        // Check to see if SourceModelArn property is set
        internal bool IsSetSourceModelArn()
        {
            return this._sourceModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceModelName. 
        /// <para>
        /// The name of the original model being copied.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string SourceModelName
        {
            get { return this._sourceModelName; }
            set { this._sourceModelName = value; }
        }

        // Check to see if SourceModelName property is set
        internal bool IsSetSourceModelName()
        {
            return this._sourceModelName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the model copy job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelCopyJobStatus Status
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
        /// Gets and sets the property TargetModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the copied model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1011)]
        public string TargetModelArn
        {
            get { return this._targetModelArn; }
            set { this._targetModelArn = value; }
        }

        // Check to see if TargetModelArn property is set
        internal bool IsSetTargetModelArn()
        {
            return this._targetModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetModelKmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key encrypting the copied model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string TargetModelKmsKeyArn
        {
            get { return this._targetModelKmsKeyArn; }
            set { this._targetModelKmsKeyArn = value; }
        }

        // Check to see if TargetModelKmsKeyArn property is set
        internal bool IsSetTargetModelKmsKeyArn()
        {
            return this._targetModelKmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetModelName. 
        /// <para>
        /// The name of the copied model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string TargetModelName
        {
            get { return this._targetModelName; }
            set { this._targetModelName = value; }
        }

        // Check to see if TargetModelName property is set
        internal bool IsSetTargetModelName()
        {
            return this._targetModelName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetModelTags. 
        /// <para>
        /// The tags associated with the copied model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> TargetModelTags
        {
            get { return this._targetModelTags; }
            set { this._targetModelTags = value; }
        }

        // Check to see if TargetModelTags property is set
        internal bool IsSetTargetModelTags()
        {
            return this._targetModelTags != null && (this._targetModelTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}