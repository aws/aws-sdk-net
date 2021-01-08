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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The log configuration for the container. This parameter maps to <code>LogConfig</code>
    /// in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
    /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
    /// Remote API</a> and the <code>--log-driver</code> option to <a href="https://docs.docker.com/engine/reference/commandline/run/">
    /// <code>docker run</code> </a>.
    /// 
    ///  
    /// <para>
    /// By default, containers use the same logging driver that the Docker daemon uses; however
    /// the container may use a different logging driver than the Docker daemon by specifying
    /// a log driver configuration in the container definition. For more information on the
    /// options for different supported log drivers, see <a href="https://docs.docker.com/engine/admin/logging/overview/">Configure
    /// logging drivers</a> in the Docker documentation.
    /// </para>
    ///  
    /// <para>
    /// The following should be noted when specifying a log configuration for your containers:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon ECS currently supports a subset of the logging drivers available to the Docker
    /// daemon (shown in the valid values below). Additional log drivers may be available
    /// in future releases of the Amazon ECS container agent.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// This parameter requires version 1.18 of the Docker Remote API or greater on your container
    /// instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For tasks hosted on Amazon EC2 instances, the Amazon ECS container agent must register
    /// the available logging drivers with the <code>ECS_AVAILABLE_LOGGING_DRIVERS</code>
    /// environment variable before containers placed on that instance can use these log configuration
    /// options. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-config.html">Amazon
    /// ECS container agent configuration</a> in the <i>Amazon Elastic Container Service Developer
    /// Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For tasks on AWS Fargate, because you do not have access to the underlying infrastructure
    /// your tasks are hosted on, any additional software needed will have to be installed
    /// outside of the task. For example, the Fluentd output aggregators or a remote host
    /// running Logstash to send Gelf logs to.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class LogConfiguration
    {
        private LogDriver _logDriver;
        private Dictionary<string, string> _options = new Dictionary<string, string>();
        private List<Secret> _secretOptions = new List<Secret>();

        /// <summary>
        /// Gets and sets the property LogDriver. 
        /// <para>
        /// The log driver to use for the container.
        /// </para>
        ///  
        /// <para>
        /// For tasks on AWS Fargate, the supported log drivers are <code>awslogs</code>, <code>splunk</code>,
        /// and <code>awsfirelens</code>.
        /// </para>
        ///  
        /// <para>
        /// For tasks hosted on Amazon EC2 instances, the supported log drivers are <code>awslogs</code>,
        /// <code>fluentd</code>, <code>gelf</code>, <code>json-file</code>, <code>journald</code>,
        /// <code>logentries</code>,<code>syslog</code>, <code>splunk</code>, and <code>awsfirelens</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information about using the <code>awslogs</code> log driver, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_awslogs.html">Using
        /// the awslogs log driver</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about using the <code>awsfirelens</code> log driver, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_firelens.html">Custom
        /// log routing</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you have a custom driver that is not listed, you can fork the Amazon ECS container
        /// agent project that is <a href="https://github.com/aws/amazon-ecs-agent">available
        /// on GitHub</a> and customize it to work with that driver. We encourage you to submit
        /// pull requests for changes that you would like to have included. However, we do not
        /// currently provide support for running modified copies of this software.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public LogDriver LogDriver
        {
            get { return this._logDriver; }
            set { this._logDriver = value; }
        }

        // Check to see if LogDriver property is set
        internal bool IsSetLogDriver()
        {
            return this._logDriver != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The configuration options to send to the log driver. This parameter requires version
        /// 1.19 of the Docker Remote API or greater on your container instance. To check the
        /// Docker Remote API version on your container instance, log in to your container instance
        /// and run the following command: <code>sudo docker version --format '{{.Server.APIVersion}}'</code>
        /// 
        /// </para>
        /// </summary>
        public Dictionary<string, string> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && this._options.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecretOptions. 
        /// <para>
        /// The secrets to pass to the log configuration. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/specifying-sensitive-data.html">Specifying
        /// Sensitive Data</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public List<Secret> SecretOptions
        {
            get { return this._secretOptions; }
            set { this._secretOptions = value; }
        }

        // Check to see if SecretOptions property is set
        internal bool IsSetSecretOptions()
        {
            return this._secretOptions != null && this._secretOptions.Count > 0; 
        }

    }
}