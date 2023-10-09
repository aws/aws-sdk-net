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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the GetProvisionedModelThroughput operation.
    /// </summary>
    public partial class GetProvisionedModelThroughputResponse : AmazonWebServiceResponse
    {
        private CommitmentDuration _commitmentDuration;
        private DateTime? _commitmentExpirationTime;
        private DateTime? _creationTime;
        private string _desiredModelArn;
        private int? _desiredModelUnits;
        private string _failureMessage;
        private string _foundationModelArn;
        private DateTime? _lastModifiedTime;
        private string _modelArn;
        private int? _modelUnits;
        private string _provisionedModelArn;
        private string _provisionedModelName;
        private ProvisionedModelStatus _status;

        /// <summary>
        /// Gets and sets the property CommitmentDuration. 
        /// <para>
        /// Commitment duration of the provisioned throughput.
        /// </para>
        /// </summary>
        public CommitmentDuration CommitmentDuration
        {
            get { return this._commitmentDuration; }
            set { this._commitmentDuration = value; }
        }

        // Check to see if CommitmentDuration property is set
        internal bool IsSetCommitmentDuration()
        {
            return this._commitmentDuration != null;
        }

        /// <summary>
        /// Gets and sets the property CommitmentExpirationTime. 
        /// <para>
        /// Commitment expiration time for the provisioned throughput.
        /// </para>
        /// </summary>
        public DateTime CommitmentExpirationTime
        {
            get { return this._commitmentExpirationTime.GetValueOrDefault(); }
            set { this._commitmentExpirationTime = value; }
        }

        // Check to see if CommitmentExpirationTime property is set
        internal bool IsSetCommitmentExpirationTime()
        {
            return this._commitmentExpirationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp of the creation time for this provisioned throughput. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredModelArn. 
        /// <para>
        /// The ARN of the new model to asssociate with this provisioned throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1011)]
        public string DesiredModelArn
        {
            get { return this._desiredModelArn; }
            set { this._desiredModelArn = value; }
        }

        // Check to see if DesiredModelArn property is set
        internal bool IsSetDesiredModelArn()
        {
            return this._desiredModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property DesiredModelUnits. 
        /// <para>
        /// The desired number of model units that was requested to be available for this provisioned
        /// throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int DesiredModelUnits
        {
            get { return this._desiredModelUnits.GetValueOrDefault(); }
            set { this._desiredModelUnits = value; }
        }

        // Check to see if DesiredModelUnits property is set
        internal bool IsSetDesiredModelUnits()
        {
            return this._desiredModelUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// Failure message for any issues that the create operation encounters.
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
        /// Gets and sets the property FoundationModelArn. 
        /// <para>
        /// ARN of the foundation model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FoundationModelArn
        {
            get { return this._foundationModelArn; }
            set { this._foundationModelArn = value; }
        }

        // Check to see if FoundationModelArn property is set
        internal bool IsSetFoundationModelArn()
        {
            return this._foundationModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp of the last modified time of this provisioned throughput. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The ARN or name of the model associated with this provisioned throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1011)]
        public string ModelArn
        {
            get { return this._modelArn; }
            set { this._modelArn = value; }
        }

        // Check to see if ModelArn property is set
        internal bool IsSetModelArn()
        {
            return this._modelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelUnits. 
        /// <para>
        /// The current number of model units requested to be available for this provisioned throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int ModelUnits
        {
            get { return this._modelUnits.GetValueOrDefault(); }
            set { this._modelUnits = value; }
        }

        // Check to see if ModelUnits property is set
        internal bool IsSetModelUnits()
        {
            return this._modelUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProvisionedModelArn. 
        /// <para>
        /// The ARN of the provisioned throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProvisionedModelArn
        {
            get { return this._provisionedModelArn; }
            set { this._provisionedModelArn = value; }
        }

        // Check to see if ProvisionedModelArn property is set
        internal bool IsSetProvisionedModelArn()
        {
            return this._provisionedModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedModelName. 
        /// <para>
        /// The name of the provisioned throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ProvisionedModelName
        {
            get { return this._provisionedModelName; }
            set { this._provisionedModelName = value; }
        }

        // Check to see if ProvisionedModelName property is set
        internal bool IsSetProvisionedModelName()
        {
            return this._provisionedModelName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the provisioned throughput. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProvisionedModelStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}