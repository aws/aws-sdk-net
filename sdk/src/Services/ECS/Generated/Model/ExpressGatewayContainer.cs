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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Defines the configuration for the primary container in an Express service. This container
    /// receives traffic from the Application Load Balancer and runs your application code.
    /// 
    ///  
    /// <para>
    /// The container configuration includes the container image, port mapping, logging settings,
    /// environment variables, and secrets. The container image is the only required parameter,
    /// with sensible defaults provided for other settings.
    /// </para>
    /// </summary>
    public partial class ExpressGatewayContainer
    {
        private ExpressGatewayServiceAwsLogsConfiguration _awsLogsConfiguration;
        private List<string> _command = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _containerPort;
        private List<KeyValuePair> _environment = AWSConfigs.InitializeCollections ? new List<KeyValuePair>() : null;
        private string _image;
        private ExpressGatewayRepositoryCredentials _repositoryCredentials;
        private List<Secret> _secrets = AWSConfigs.InitializeCollections ? new List<Secret>() : null;

        /// <summary>
        /// Gets and sets the property AwsLogsConfiguration. 
        /// <para>
        /// The log configuration for the container.
        /// </para>
        /// </summary>
        public ExpressGatewayServiceAwsLogsConfiguration AwsLogsConfiguration
        {
            get { return this._awsLogsConfiguration; }
            set { this._awsLogsConfiguration = value; }
        }

        // Check to see if AwsLogsConfiguration property is set
        internal bool IsSetAwsLogsConfiguration()
        {
            return this._awsLogsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that is passed to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null && (this._command.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContainerPort. 
        /// <para>
        /// The port number on the container that receives traffic from the load balancer. Default
        /// is 80.
        /// </para>
        /// </summary>
        public int? ContainerPort
        {
            get { return this._containerPort; }
            set { this._containerPort = value; }
        }

        // Check to see if ContainerPort property is set
        internal bool IsSetContainerPort()
        {
            return this._containerPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to pass to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyValuePair> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && (this._environment.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The image used to start a container. This string is passed directly to the Docker
        /// daemon. Images in the Docker Hub registry are available by default. Other repositories
        /// are specified with either <c>repository-url/image:tag</c> or <c>repository-url/image@digest</c>.
        /// </para>
        ///  
        /// <para>
        /// For Express services, the image typically contains a web application that listens
        /// on the specified container port. The image can be stored in Amazon ECR, Docker Hub,
        /// or any other container registry accessible to your execution role.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryCredentials. 
        /// <para>
        /// The configuration for repository credentials for private registry authentication.
        /// </para>
        /// </summary>
        public ExpressGatewayRepositoryCredentials RepositoryCredentials
        {
            get { return this._repositoryCredentials; }
            set { this._repositoryCredentials = value; }
        }

        // Check to see if RepositoryCredentials property is set
        internal bool IsSetRepositoryCredentials()
        {
            return this._repositoryCredentials != null;
        }

        /// <summary>
        /// Gets and sets the property Secrets. 
        /// <para>
        /// The secrets to pass to the container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Secret> Secrets
        {
            get { return this._secrets; }
            set { this._secrets = value; }
        }

        // Check to see if Secrets property is set
        internal bool IsSetSecrets()
        {
            return this._secrets != null && (this._secrets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}