/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDevEndpoint operation.
    /// Creates a new development endpoint.
    /// </summary>
    public partial class CreateDevEndpointRequest : AmazonGlueRequest
    {
        private Dictionary<string, string> _arguments = new Dictionary<string, string>();
        private string _endpointName;
        private string _extraJarsS3Path;
        private string _extraPythonLibsS3Path;
        private int? _numberOfNodes;
        private int? _numberOfWorkers;
        private string _publicKey;
        private List<string> _publicKeys = new List<string>();
        private string _roleArn;
        private string _securityConfiguration;
        private List<string> _securityGroupIds = new List<string>();
        private string _subnetId;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private WorkerType _workerType;

        /// <summary>
        /// Gets and sets the property Arguments. 
        /// <para>
        /// A map of arguments used to configure the <code>DevEndpoint</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public Dictionary<string, string> Arguments
        {
            get { return this._arguments; }
            set { this._arguments = value; }
        }

        // Check to see if Arguments property is set
        internal bool IsSetArguments()
        {
            return this._arguments != null && this._arguments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name to be assigned to the new <code>DevEndpoint</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property ExtraJarsS3Path. 
        /// <para>
        /// The path to one or more Java <code>.jar</code> files in an S3 bucket that should be
        /// loaded in your <code>DevEndpoint</code>.
        /// </para>
        /// </summary>
        public string ExtraJarsS3Path
        {
            get { return this._extraJarsS3Path; }
            set { this._extraJarsS3Path = value; }
        }

        // Check to see if ExtraJarsS3Path property is set
        internal bool IsSetExtraJarsS3Path()
        {
            return this._extraJarsS3Path != null;
        }

        /// <summary>
        /// Gets and sets the property ExtraPythonLibsS3Path. 
        /// <para>
        /// The paths to one or more Python libraries in an Amazon S3 bucket that should be loaded
        /// in your <code>DevEndpoint</code>. Multiple values must be complete paths separated
        /// by a comma.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can only use pure Python libraries with a <code>DevEndpoint</code>. Libraries
        /// that rely on C extensions, such as the <a href="http://pandas.pydata.org/">pandas</a>
        /// Python data analysis library, are not yet supported.
        /// </para>
        ///  </note>
        /// </summary>
        public string ExtraPythonLibsS3Path
        {
            get { return this._extraPythonLibsS3Path; }
            set { this._extraPythonLibsS3Path = value; }
        }

        // Check to see if ExtraPythonLibsS3Path property is set
        internal bool IsSetExtraPythonLibsS3Path()
        {
            return this._extraPythonLibsS3Path != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfNodes. 
        /// <para>
        /// The number of AWS Glue Data Processing Units (DPUs) to allocate to this <code>DevEndpoint</code>.
        /// </para>
        /// </summary>
        public int NumberOfNodes
        {
            get { return this._numberOfNodes.GetValueOrDefault(); }
            set { this._numberOfNodes = value; }
        }

        // Check to see if NumberOfNodes property is set
        internal bool IsSetNumberOfNodes()
        {
            return this._numberOfNodes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfWorkers. 
        /// <para>
        /// The number of workers of a defined <code>workerType</code> that are allocated to the
        /// development endpoint.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of workers you can define are 299 for <code>G.1X</code>, and 149
        /// for <code>G.2X</code>. 
        /// </para>
        /// </summary>
        public int NumberOfWorkers
        {
            get { return this._numberOfWorkers.GetValueOrDefault(); }
            set { this._numberOfWorkers = value; }
        }

        // Check to see if NumberOfWorkers property is set
        internal bool IsSetNumberOfWorkers()
        {
            return this._numberOfWorkers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// The public key to be used by this <code>DevEndpoint</code> for authentication. This
        /// attribute is provided for backward compatibility because the recommended attribute
        /// to use is public keys.
        /// </para>
        /// </summary>
        public string PublicKey
        {
            get { return this._publicKey; }
            set { this._publicKey = value; }
        }

        // Check to see if PublicKey property is set
        internal bool IsSetPublicKey()
        {
            return this._publicKey != null;
        }

        /// <summary>
        /// Gets and sets the property PublicKeys. 
        /// <para>
        /// A list of public keys to be used by the development endpoints for authentication.
        /// The use of this attribute is preferred over a single public key because the public
        /// keys allow you to have a different private key per client.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you previously created an endpoint with a public key, you must remove that key
        /// to be able to set a list of public keys. Call the <code>UpdateDevEndpoint</code> API
        /// with the public key content in the <code>deletePublicKeys</code> attribute, and the
        /// list of new keys in the <code>addPublicKeys</code> attribute.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> PublicKeys
        {
            get { return this._publicKeys; }
            set { this._publicKeys = value; }
        }

        // Check to see if PublicKeys property is set
        internal bool IsSetPublicKeys()
        {
            return this._publicKeys != null && this._publicKeys.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role for the <code>DevEndpoint</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// The name of the <code>SecurityConfiguration</code> structure to be used with this
        /// <code>DevEndpoint</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SecurityConfiguration
        {
            get { return this._securityConfiguration; }
            set { this._securityConfiguration = value; }
        }

        // Check to see if SecurityConfiguration property is set
        internal bool IsSetSecurityConfiguration()
        {
            return this._securityConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// Security group IDs for the security groups to be used by the new <code>DevEndpoint</code>.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The subnet ID for the new <code>DevEndpoint</code> to use.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to use with this DevEndpoint. You may use tags to limit access to the DevEndpoint.
        /// For more information about tags in AWS Glue, see <a href="https://docs.aws.amazon.com/glue/latest/dg/monitor-tags.html">AWS
        /// Tags in AWS Glue</a> in the developer guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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
        /// Gets and sets the property WorkerType. 
        /// <para>
        /// The type of predefined worker that is allocated to the development endpoint. Accepts
        /// a value of Standard, G.1X, or G.2X.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For the <code>Standard</code> worker type, each worker provides 4 vCPU, 16 GB of memory
        /// and a 50GB disk, and 2 executors per worker.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>G.1X</code> worker type, each worker maps to 1 DPU (4 vCPU, 16 GB of
        /// memory, 64 GB disk), and provides 1 executor per worker. We recommend this worker
        /// type for memory-intensive jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>G.2X</code> worker type, each worker maps to 2 DPU (8 vCPU, 32 GB of
        /// memory, 128 GB disk), and provides 1 executor per worker. We recommend this worker
        /// type for memory-intensive jobs.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WorkerType WorkerType
        {
            get { return this._workerType; }
            set { this._workerType = value; }
        }

        // Check to see if WorkerType property is set
        internal bool IsSetWorkerType()
        {
            return this._workerType != null;
        }

    }
}