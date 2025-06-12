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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
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
namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBatchPredictionJob operation.
    /// Creates a batch prediction job.
    /// </summary>
    public partial class CreateBatchPredictionJobRequest : AmazonFraudDetectorRequest
    {
        private string _detectorName;
        private string _detectorVersion;
        private string _eventTypeName;
        private string _iamRoleArn;
        private string _inputPath;
        private string _jobId;
        private string _outputPath;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DetectorName. 
        /// <para>
        /// The name of the detector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DetectorName
        {
            get { return this._detectorName; }
            set { this._detectorName = value; }
        }

        // Check to see if DetectorName property is set
        internal bool IsSetDetectorName()
        {
            return this._detectorName != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorVersion. 
        /// <para>
        /// The detector version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public string DetectorVersion
        {
            get { return this._detectorVersion; }
            set { this._detectorVersion = value; }
        }

        // Check to see if DetectorVersion property is set
        internal bool IsSetDetectorVersion()
        {
            return this._detectorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property EventTypeName. 
        /// <para>
        /// The name of the event type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string EventTypeName
        {
            get { return this._eventTypeName; }
            set { this._eventTypeName = value; }
        }

        // Check to see if EventTypeName property is set
        internal bool IsSetEventTypeName()
        {
            return this._eventTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The ARN of the IAM role to use for this job request.
        /// </para>
        ///  
        /// <para>
        /// The IAM Role must have read permissions to your input S3 bucket and write permissions
        /// to your output S3 bucket. For more information about bucket permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/example-policies-s3.html">User
        /// policy examples</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property InputPath. 
        /// <para>
        /// The Amazon S3 location of your training file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string InputPath
        {
            get { return this._inputPath; }
            set { this._inputPath = value; }
        }

        // Check to see if InputPath property is set
        internal bool IsSetInputPath()
        {
            return this._inputPath != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the batch prediction job.
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
        /// Gets and sets the property OutputPath. 
        /// <para>
        /// The Amazon S3 location of your output file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string OutputPath
        {
            get { return this._outputPath; }
            set { this._outputPath = value; }
        }

        // Check to see if OutputPath property is set
        internal bool IsSetOutputPath()
        {
            return this._outputPath != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A collection of key and value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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

    }
}