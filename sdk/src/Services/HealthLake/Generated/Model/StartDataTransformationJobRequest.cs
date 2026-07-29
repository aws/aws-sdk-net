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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// Container for the parameters to the StartDataTransformationJob operation.
    /// Starts an asynchronous data transformation job that converts source files from Amazon
    /// Simple Storage Service (Amazon S3) and writes the output to Amazon S3 or AWS HealthLake.
    /// </summary>
    public partial class StartDataTransformationJobRequest : AmazonHealthLakeRequest
    {
        private string _clientToken;
        private string _dataAccessRoleArn;
        private bool? _driftDetectionEnabled;
        private TransformationInputDataConfig _inputDataConfig;
        private string _jobName;
        private TransformationOutputDataConfig _outputDataConfig;
        private string _profileId;
        private bool? _provenanceEnabled;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, the service ignores the request
        /// but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role
        /// that AWS HealthLake assumes to read from and write to the specified Amazon S3 locations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string DataAccessRoleArn
        {
            get { return this._dataAccessRoleArn; }
            set { this._dataAccessRoleArn = value; }
        }

        // Check to see if DataAccessRoleArn property is set
        internal bool IsSetDataAccessRoleArn()
        {
            return this._dataAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property DriftDetectionEnabled. 
        /// <para>
        /// Specifies whether drift detection is enabled for this job. When enabled, AWS HealthLake
        /// writes a drift report to the output Amazon S3 location alongside the converted files.
        /// </para>
        /// </summary>
        public bool? DriftDetectionEnabled
        {
            get { return this._driftDetectionEnabled; }
            set { this._driftDetectionEnabled = value; }
        }

        // Check to see if DriftDetectionEnabled property is set
        internal bool IsSetDriftDetectionEnabled()
        {
            return this._driftDetectionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// The Amazon S3 location and format of the source files to transform.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TransformationInputDataConfig InputDataConfig
        {
            get { return this._inputDataConfig; }
            set { this._inputDataConfig = value; }
        }

        // Check to see if InputDataConfig property is set
        internal bool IsSetInputDataConfig()
        {
            return this._inputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// A descriptive name for the data transformation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// The Amazon S3 output location and AWS Key Management Service (AWS KMS) encryption
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TransformationOutputDataConfig OutputDataConfig
        {
            get { return this._outputDataConfig; }
            set { this._outputDataConfig = value; }
        }

        // Check to see if OutputDataConfig property is set
        internal bool IsSetOutputDataConfig()
        {
            return this._outputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of the data transformation profile to use for conversion.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=32)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property ProvenanceEnabled. 
        /// <para>
        /// Specifies whether FHIR R4 Provenance resource generation is enabled for this transformation
        /// job. When provenance is enabled, the service also generates related DocumentReference
        /// and Device resources. If you don't specify a value, the default is <c>true</c>. To
        /// disable provenance output, set this parameter to <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ProvenanceEnabled
        {
            get { return this._provenanceEnabled; }
            set { this._provenanceEnabled = value; }
        }

        // Check to see if ProvenanceEnabled property is set
        internal bool IsSetProvenanceEnabled()
        {
            return this._provenanceEnabled.HasValue; 
        }

    }
}