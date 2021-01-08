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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Log configuration options to send to a custom log driver for the container.
    /// </summary>
    public partial class LogConfiguration
    {
        private LogDriver _logDriver;
        private Dictionary<string, string> _options = new Dictionary<string, string>();
        private List<Secret> _secretOptions = new List<Secret>();

        /// <summary>
        /// Gets and sets the property LogDriver. 
        /// <para>
        /// The log driver to use for the container. The valid values listed for this parameter
        /// are log drivers that the Amazon ECS container agent can communicate with by default.
        /// </para>
        ///  
        /// <para>
        /// The supported log drivers are <code>awslogs</code>, <code>fluentd</code>, <code>gelf</code>,
        /// <code>json-file</code>, <code>journald</code>, <code>logentries</code>, <code>syslog</code>,
        /// and <code>splunk</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Jobs running on Fargate resources are restricted to the <code>awslogs</code> and <code>splunk</code>
        /// log drivers.
        /// </para>
        ///  </note> <dl> <dt>awslogs</dt> <dd> 
        /// <para>
        /// Specifies the Amazon CloudWatch Logs logging driver. For more information, see <a
        /// href="https://docs.aws.amazon.com/batch/latest/userguide/using_awslogs.html">Using
        /// the awslogs Log Driver</a> in the <i>AWS Batch User Guide</i> and <a href="https://docs.docker.com/config/containers/logging/awslogs/">Amazon
        /// CloudWatch Logs logging driver</a> in the Docker documentation.
        /// </para>
        ///  </dd> <dt>fluentd</dt> <dd> 
        /// <para>
        /// Specifies the Fluentd logging driver. For more information, including usage and options,
        /// see <a href="https://docs.docker.com/config/containers/logging/fluentd/">Fluentd logging
        /// driver</a> in the Docker documentation.
        /// </para>
        ///  </dd> <dt>gelf</dt> <dd> 
        /// <para>
        /// Specifies the Graylog Extended Format (GELF) logging driver. For more information,
        /// including usage and options, see <a href="https://docs.docker.com/config/containers/logging/gelf/">Graylog
        /// Extended Format logging driver</a> in the Docker documentation.
        /// </para>
        ///  </dd> <dt>journald</dt> <dd> 
        /// <para>
        /// Specifies the journald logging driver. For more information, including usage and options,
        /// see <a href="https://docs.docker.com/config/containers/logging/journald/">Journald
        /// logging driver</a> in the Docker documentation.
        /// </para>
        ///  </dd> <dt>json-file</dt> <dd> 
        /// <para>
        /// Specifies the JSON file logging driver. For more information, including usage and
        /// options, see <a href="https://docs.docker.com/config/containers/logging/json-file/">JSON
        /// File logging driver</a> in the Docker documentation.
        /// </para>
        ///  </dd> <dt>splunk</dt> <dd> 
        /// <para>
        /// Specifies the Splunk logging driver. For more information, including usage and options,
        /// see <a href="https://docs.docker.com/config/containers/logging/splunk/">Splunk logging
        /// driver</a> in the Docker documentation.
        /// </para>
        ///  </dd> <dt>syslog</dt> <dd> 
        /// <para>
        /// Specifies the syslog logging driver. For more information, including usage and options,
        /// see <a href="https://docs.docker.com/config/containers/logging/syslog/">Syslog logging
        /// driver</a> in the Docker documentation.
        /// </para>
        ///  </dd> </dl> <note> 
        /// <para>
        /// If you have a custom driver that'sn't listed earlier that you want to work with the
        /// Amazon ECS container agent, you can fork the Amazon ECS container agent project that's
        /// <a href="https://github.com/aws/amazon-ecs-agent">available on GitHub</a> and customize
        /// it to work with that driver. We encourage you to submit pull requests for changes
        /// that you want to have included. However, Amazon Web Services doesn't currently support
        /// running modified copies of this software.
        /// </para>
        ///  </note> 
        /// <para>
        /// This parameter requires version 1.18 of the Docker Remote API or greater on your container
        /// instance. To check the Docker Remote API version on your container instance, log into
        /// your container instance and run the following command: <code>sudo docker version |
        /// grep "Server API version"</code> 
        /// </para>
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
        /// Docker Remote API version on your container instance, log into your container instance
        /// and run the following command: <code>sudo docker version | grep "Server API version"</code>
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
        /// The secrets to pass to the log configuration. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/specifying-sensitive-data.html">Specifying
        /// Sensitive Data</a> in the <i>AWS Batch User Guide</i>.
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