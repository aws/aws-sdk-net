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

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePipe operation.
    /// Create a pipe. Amazon EventBridge Pipes connect event sources to targets and reduces
    /// the need for specialized knowledge and integration code.
    /// </summary>
    public partial class CreatePipeRequest : AmazonPipesRequest
    {
        private string _description;
        private RequestedPipeState _desiredState;
        private string _enrichment;
        private PipeEnrichmentParameters _enrichmentParameters;
        private string _name;
        private string _roleArn;
        private string _source;
        private PipeSourceParameters _sourceParameters;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _target;
        private PipeTargetParameters _targetParameters;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the pipe.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
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
        /// Gets and sets the property Source. 
        /// <para>
        /// The ARN of the source resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property SourceParameters. 
        /// <para>
        /// The parameters required to set up a source for your pipe.
        /// </para>
        /// </summary>
        public PipeSourceParameters SourceParameters
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of key-value pairs to associate with the pipe.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property Target. 
        /// <para>
        /// The ARN of the target resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
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