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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
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
namespace Amazon.Pipes.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePipe operation.
    /// Update an existing pipe. When you call <c>UpdatePipe</c>, EventBridge only the updates
    /// fields you have specified in the request; the rest remain unchanged. The exception
    /// to this is if you modify any Amazon Web Services-service specific fields in the <c>SourceParameters</c>,
    /// <c>EnrichmentParameters</c>, or <c>TargetParameters</c> objects. For example, <c>DynamoDBStreamParameters</c>
    /// or <c>EventBridgeEventBusParameters</c>. EventBridge updates the fields in these objects
    /// atomically as one and overrides existing values. This is by design, and means that
    /// if you don't specify an optional field in one of these <c>Parameters</c> objects,
    /// EventBridge sets that field to its system-default value during the update.
    /// 
    ///  
    /// <para>
    /// For more information about pipes, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes.html">
    /// Amazon EventBridge Pipes</a> in the Amazon EventBridge User Guide.
    /// </para>
    /// </summary>
    public partial class UpdatePipeRequest : AmazonPipesRequest
    {
        private string _description;
        private RequestedPipeState _desiredState;
        private string _enrichment;
        private PipeEnrichmentParameters _enrichmentParameters;
        private string _kmsKeyIdentifier;
        private PipeLogConfigurationParameters _logConfiguration;
        private string _name;
        private string _roleArn;
        private UpdatePipeSourceParameters _sourceParameters;
        private string _target;
        private PipeTargetParameters _targetParameters;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the pipe.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=512)]
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
        /// Gets and sets the property DesiredState. 
        /// <para>
        /// The state the pipe should be in.
        /// </para>
        /// </summary>
        public RequestedPipeState DesiredState
        {
            get { return this._desiredState; }
            set { this._desiredState = value; }
        }

        // Check to see if DesiredState property is set
        internal bool IsSetDesiredState()
        {
            return this._desiredState != null;
        }

        /// <summary>
        /// Gets and sets the property Enrichment. 
        /// <para>
        /// The ARN of the enrichment resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1600)]
        public string Enrichment
        {
            get { return this._enrichment; }
            set { this._enrichment = value; }
        }

        // Check to see if Enrichment property is set
        internal bool IsSetEnrichment()
        {
            return this._enrichment != null;
        }

        /// <summary>
        /// Gets and sets the property EnrichmentParameters. 
        /// <para>
        /// The parameters required to set up enrichment on your pipe.
        /// </para>
        /// </summary>
        public PipeEnrichmentParameters EnrichmentParameters
        {
            get { return this._enrichmentParameters; }
            set { this._enrichmentParameters = value; }
        }

        // Check to see if EnrichmentParameters property is set
        internal bool IsSetEnrichmentParameters()
        {
            return this._enrichmentParameters != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The identifier of the KMS customer managed key for EventBridge to use, if you choose
        /// to use a customer managed key to encrypt pipe data. The identifier can be the key
        /// Amazon Resource Name (ARN), KeyId, key alias, or key alias ARN.
        /// </para>
        ///  
        /// <para>
        /// To update a pipe that is using the default Amazon Web Services owned key to use a
        /// customer managed key instead, or update a pipe that is using a customer managed key
        /// to use a different customer managed key, specify a customer managed key identifier.
        /// </para>
        ///  
        /// <para>
        /// To update a pipe that is using a customer managed key to use the default Amazon Web
        /// Services owned key, specify an empty string.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/getting-started.html">Managing
        /// keys</a> in the <i>Key Management Service Developer Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string KmsKeyIdentifier
        {
            get { return this._kmsKeyIdentifier; }
            set { this._kmsKeyIdentifier = value; }
        }

        // Check to see if KmsKeyIdentifier property is set
        internal bool IsSetKmsKeyIdentifier()
        {
            return this._kmsKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The logging configuration settings for the pipe.
        /// </para>
        /// </summary>
        public PipeLogConfigurationParameters LogConfiguration
        {
            get { return this._logConfiguration; }
            set { this._logConfiguration = value; }
        }

        // Check to see if LogConfiguration property is set
        internal bool IsSetLogConfiguration()
        {
            return this._logConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the pipe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that allows the pipe to send data to the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
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
        /// Gets and sets the property SourceParameters. 
        /// <para>
        /// The parameters required to set up a source for your pipe.
        /// </para>
        /// </summary>
        public UpdatePipeSourceParameters SourceParameters
        {
            get { return this._sourceParameters; }
            set { this._sourceParameters = value; }
        }

        // Check to see if SourceParameters property is set
        internal bool IsSetSourceParameters()
        {
            return this._sourceParameters != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The ARN of the target resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property TargetParameters. 
        /// <para>
        /// The parameters required to set up a target for your pipe.
        /// </para>
        ///  
        /// <para>
        /// For more information about pipe target parameters, including how to use dynamic path
        /// parameters, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes-event-target.html">Target
        /// parameters</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        public PipeTargetParameters TargetParameters
        {
            get { return this._targetParameters; }
            set { this._targetParameters = value; }
        }

        // Check to see if TargetParameters property is set
        internal bool IsSetTargetParameters()
        {
            return this._targetParameters != null;
        }

    }
}