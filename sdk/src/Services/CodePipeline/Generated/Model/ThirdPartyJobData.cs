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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents information about the job data for a partner action.
    /// </summary>
    public partial class ThirdPartyJobData
    {
        private ActionConfiguration _actionConfiguration;
        private ActionTypeId _actionTypeId;
        private AWSSessionCredentials _artifactCredentials;
        private string _continuationToken;
        private EncryptionKey _encryptionKey;
        private List<Artifact> _inputArtifacts = new List<Artifact>();
        private List<Artifact> _outputArtifacts = new List<Artifact>();
        private PipelineContext _pipelineContext;

        /// <summary>
        /// Gets and sets the property ActionConfiguration. 
        /// <para>
        /// Represents information about an action configuration.
        /// </para>
        /// </summary>
        public ActionConfiguration ActionConfiguration
        {
            get { return this._actionConfiguration; }
            set { this._actionConfiguration = value; }
        }

        // Check to see if ActionConfiguration property is set
        internal bool IsSetActionConfiguration()
        {
            return this._actionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ActionTypeId. 
        /// <para>
        /// Represents information about an action type.
        /// </para>
        /// </summary>
        public ActionTypeId ActionTypeId
        {
            get { return this._actionTypeId; }
            set { this._actionTypeId = value; }
        }

        // Check to see if ActionTypeId property is set
        internal bool IsSetActionTypeId()
        {
            return this._actionTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property ArtifactCredentials. 
        /// <para>
        /// Represents an AWS session credentials object. These credentials are temporary credentials
        /// that are issued by AWS Secure Token Service (STS). They can be used to access input
        /// and output artifacts in the S3 bucket used to store artifact for the pipeline in AWS
        /// CodePipeline. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public AWSSessionCredentials ArtifactCredentials
        {
            get { return this._artifactCredentials; }
            set { this._artifactCredentials = value; }
        }

        // Check to see if ArtifactCredentials property is set
        internal bool IsSetArtifactCredentials()
        {
            return this._artifactCredentials != null;
        }

        /// <summary>
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        /// A system-generated token, such as a AWS CodeDeploy deployment ID, that a job requires
        /// to continue the job asynchronously.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ContinuationToken
        {
            get { return this._continuationToken; }
            set { this._continuationToken = value; }
        }

        // Check to see if ContinuationToken property is set
        internal bool IsSetContinuationToken()
        {
            return this._continuationToken != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The encryption key used to encrypt and decrypt data in the artifact store for the
        /// pipeline, such as an AWS Key Management Service (AWS KMS) key. This is optional and
        /// might not be present.
        /// </para>
        /// </summary>
        public EncryptionKey EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property InputArtifacts. 
        /// <para>
        /// The name of the artifact that is worked on by the action, if any. This name might
        /// be system-generated, such as "MyApp", or it might be defined by the user when the
        /// action is created. The input artifact name must match the name of an output artifact
        /// generated by an action in an earlier action or stage of the pipeline.
        /// </para>
        /// </summary>
        public List<Artifact> InputArtifacts
        {
            get { return this._inputArtifacts; }
            set { this._inputArtifacts = value; }
        }

        // Check to see if InputArtifacts property is set
        internal bool IsSetInputArtifacts()
        {
            return this._inputArtifacts != null && this._inputArtifacts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OutputArtifacts. 
        /// <para>
        /// The name of the artifact that is the result of the action, if any. This name might
        /// be system-generated, such as "MyBuiltApp", or it might be defined by the user when
        /// the action is created.
        /// </para>
        /// </summary>
        public List<Artifact> OutputArtifacts
        {
            get { return this._outputArtifacts; }
            set { this._outputArtifacts = value; }
        }

        // Check to see if OutputArtifacts property is set
        internal bool IsSetOutputArtifacts()
        {
            return this._outputArtifacts != null && this._outputArtifacts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PipelineContext. 
        /// <para>
        /// Represents information about a pipeline to a job worker.
        /// </para>
        ///  <note> 
        /// <para>
        /// Does not include <code>pipelineArn</code> and <code>pipelineExecutionId</code> for
        /// ThirdParty jobs.
        /// </para>
        ///  </note>
        /// </summary>
        public PipelineContext PipelineContext
        {
            get { return this._pipelineContext; }
            set { this._pipelineContext = value; }
        }

        // Check to see if PipelineContext property is set
        internal bool IsSetPipelineContext()
        {
            return this._pipelineContext != null;
        }

    }
}