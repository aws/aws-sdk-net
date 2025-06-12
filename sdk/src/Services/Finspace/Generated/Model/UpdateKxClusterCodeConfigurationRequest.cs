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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateKxClusterCodeConfiguration operation.
    /// Allows you to update code configuration on a running cluster. By using this API you
    /// can update the code, the initialization script path, and the command line arguments
    /// for a specific cluster. The configuration that you want to update will override any
    /// existing configurations on the cluster.
    /// </summary>
    public partial class UpdateKxClusterCodeConfigurationRequest : AmazonFinspaceRequest
    {
        private string _clientToken;
        private string _clusterName;
        private CodeConfiguration _code;
        private List<KxCommandLineArgument> _commandLineArguments = AWSConfigs.InitializeCollections ? new List<KxCommandLineArgument>() : null;
        private KxClusterCodeDeploymentConfiguration _deploymentConfiguration;
        private string _environmentId;
        private string _initializationScript;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that ensures idempotency. This token expires in 10 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property Code.
        /// </summary>
        [AWSProperty(Required=true)]
        public CodeConfiguration Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property CommandLineArguments. 
        /// <para>
        /// Specifies the key-value pairs to make them available inside the cluster.
        /// </para>
        ///  
        /// <para>
        /// You cannot update this parameter for a <c>NO_RESTART</c> deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KxCommandLineArgument> CommandLineArguments
        {
            get { return this._commandLineArguments; }
            set { this._commandLineArguments = value; }
        }

        // Check to see if CommandLineArguments property is set
        internal bool IsSetCommandLineArguments()
        {
            return this._commandLineArguments != null && (this._commandLineArguments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeploymentConfiguration. 
        /// <para>
        ///  The configuration that allows you to choose how you want to update the code on a
        /// cluster. 
        /// </para>
        /// </summary>
        public KxClusterCodeDeploymentConfiguration DeploymentConfiguration
        {
            get { return this._deploymentConfiguration; }
            set { this._deploymentConfiguration = value; }
        }

        // Check to see if DeploymentConfiguration property is set
        internal bool IsSetDeploymentConfiguration()
        {
            return this._deploymentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        ///  A unique identifier of the kdb environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property InitializationScript. 
        /// <para>
        /// Specifies a Q program that will be run at launch of a cluster. It is a relative path
        /// within <i>.zip</i> file that contains the custom code, which will be loaded on the
        /// cluster. It must include the file name itself. For example, <c>somedir/init.q</c>.
        /// </para>
        ///  
        /// <para>
        /// You cannot update this parameter for a <c>NO_RESTART</c> deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string InitializationScript
        {
            get { return this._initializationScript; }
            set { this._initializationScript = value; }
        }

        // Check to see if InitializationScript property is set
        internal bool IsSetInitializationScript()
        {
            return this._initializationScript != null;
        }

    }
}