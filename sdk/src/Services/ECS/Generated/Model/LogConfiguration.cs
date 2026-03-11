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
    /// The log configuration for the container. This parameter maps to <c>LogConfig</c> in
    /// the docker container create command and the <c>--log-driver</c> option to docker run.
    /// 
    ///  
    /// <para>
    /// By default, containers use the same logging driver that the Docker daemon uses. However,
    /// the container might use a different logging driver than the Docker daemon by specifying
    /// a log driver configuration in the container definition.
    /// </para>
    ///  
    /// <para>
    /// Understand the following when specifying a log configuration for your containers.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon ECS currently supports a subset of the logging drivers available to the Docker
    /// daemon. Additional log drivers may be available in future releases of the Amazon ECS
    /// container agent.
    /// </para>
    ///  
    /// <para>
    /// For tasks on Fargate, the supported log drivers are <c>awslogs</c>, <c>splunk</c>,
    /// and <c>awsfirelens</c>.
    /// </para>
    ///  
    /// <para>
    /// For tasks hosted on Amazon EC2 instances, the supported log drivers are <c>awslogs</c>,
    /// <c>fluentd</c>, <c>gelf</c>, <c>json-file</c>, <c>journald</c>,<c>syslog</c>, <c>splunk</c>,
    /// and <c>awsfirelens</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// This parameter requires version 1.18 of the Docker Remote API or greater on your container
    /// instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For tasks that are hosted on Amazon EC2 instances, the Amazon ECS container agent
    /// must register the available logging drivers with the <c>ECS_AVAILABLE_LOGGING_DRIVERS</c>
    /// environment variable before containers placed on that instance can use these log configuration
    /// options. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-config.html">Amazon
    /// ECS container agent configuration</a> in the <i>Amazon Elastic Container Service Developer
    /// Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For tasks that are on Fargate, because you don't have access to the underlying infrastructure
    /// your tasks are hosted on, any additional software needed must be installed outside
    /// of the task. For example, the Fluentd output aggregators or a remote host running
    /// Logstash to send Gelf logs to.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class LogConfiguration
    {
        private LogDriver _logDriver;
        private Dictionary<string, string> _options = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<Secret> _secretOptions = AWSConfigs.InitializeCollections ? new List<Secret>() : null;

        /// <summary>
        /// Gets and sets the property LogDriver. 
        /// <para>
        /// The log driver to use for the container.
        /// </para>
        ///  
        /// <para>
        /// For tasks on Fargate, the supported log drivers are <c>awslogs</c>, <c>splunk</c>,
        /// and <c>awsfirelens</c>.
        /// </para>
        ///  
        /// <para>
        /// For tasks hosted on Amazon EC2 instances, the supported log drivers are <c>awslogs</c>,
        /// <c>fluentd</c>, <c>gelf</c>, <c>json-file</c>, <c>journald</c>, <c>syslog</c>, <c>splunk</c>,
        /// and <c>awsfirelens</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about using the <c>awslogs</c> log driver, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_awslogs.html">Send
        /// Amazon ECS logs to CloudWatch</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about using the <c>awsfirelens</c> log driver, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_firelens.html">Send
        /// Amazon ECS logs to an Amazon Web Services service or Amazon Web Services Partner</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you have a custom driver that isn't listed, you can fork the Amazon ECS container
        /// agent project that's <a href="https://github.com/aws/amazon-ecs-agent">available on
        /// GitHub</a> and customize it to work with that driver. We encourage you to submit pull
        /// requests for changes that you would like to have included. However, we don't currently
        /// provide support for running modified copies of this software.
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
        /// The configuration options to send to the log driver.
        /// </para>
        ///  
        /// <para>
        /// The options you can specify depend on the log driver. Some of the options you can
        /// specify when you use the <c>awslogs</c> log driver to route logs to Amazon CloudWatch
        /// include the following:
        /// </para>
        ///  <dl> <dt>awslogs-create-group</dt> <dd> 
        /// <para>
        /// Required: No
        /// </para>
        ///  
        /// <para>
        /// Specify whether you want the log group to be created automatically. If this option
        /// isn't specified, it defaults to <c>false</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Your IAM policy must include the <c>logs:CreateLogGroup</c> permission before you
        /// attempt to use <c>awslogs-create-group</c>.
        /// </para>
        ///  </note> </dd> <dt>awslogs-region</dt> <dd> 
        /// <para>
        /// Required: Yes
        /// </para>
        ///  
        /// <para>
        /// Specify the Amazon Web Services Region that the <c>awslogs</c> log driver is to send
        /// your Docker logs to. You can choose to send all of your logs from clusters in different
        /// Regions to a single region in CloudWatch Logs. This is so that they're all visible
        /// in one location. Otherwise, you can separate them by Region for more granularity.
        /// Make sure that the specified log group exists in the Region that you specify with
        /// this option.
        /// </para>
        ///  </dd> <dt>awslogs-group</dt> <dd> 
        /// <para>
        /// Required: Yes
        /// </para>
        ///  
        /// <para>
        /// Make sure to specify a log group that the <c>awslogs</c> log driver sends its log
        /// streams to.
        /// </para>
        ///  </dd> <dt>awslogs-stream-prefix</dt> <dd> 
        /// <para>
        /// Required: Yes, when using Fargate.Optional when using EC2.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>awslogs-stream-prefix</c> option to associate a log stream with the specified
        /// prefix, the container name, and the ID of the Amazon ECS task that the container belongs
        /// to. If you specify a prefix with this option, then the log stream takes the format
        /// <c>prefix-name/container-name/ecs-task-id</c>.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a prefix with this option, then the log stream is named after
        /// the container ID that's assigned by the Docker daemon on the container instance. Because
        /// it's difficult to trace logs back to the container that sent them with just the Docker
        /// container ID (which is only available on the container instance), we recommend that
        /// you specify a prefix with this option.
        /// </para>
        ///  
        /// <para>
        /// For Amazon ECS services, you can use the service name as the prefix. Doing so, you
        /// can trace log streams to the service that the container belongs to, the name of the
        /// container that sent them, and the ID of the task that the container belongs to.
        /// </para>
        ///  
        /// <para>
        /// You must specify a stream-prefix for your logs to have your logs appear in the Log
        /// pane when using the Amazon ECS console.
        /// </para>
        ///  </dd> <dt>awslogs-datetime-format</dt> <dd> 
        /// <para>
        /// Required: No
        /// </para>
        ///  
        /// <para>
        /// This option defines a multiline start pattern in Python <c>strftime</c> format. A
        /// log message consists of a line that matches the pattern and any following lines that
        /// don’t match the pattern. The matched line is the delimiter between log messages.
        /// </para>
        ///  
        /// <para>
        /// One example of a use case for using this format is for parsing output such as a stack
        /// dump, which might otherwise be logged in multiple entries. The correct pattern allows
        /// it to be captured in a single entry.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.docker.com/config/containers/logging/awslogs/#awslogs-datetime-format">awslogs-datetime-format</a>.
        /// </para>
        ///  
        /// <para>
        /// You cannot configure both the <c>awslogs-datetime-format</c> and <c>awslogs-multiline-pattern</c>
        /// options.
        /// </para>
        ///  <note> 
        /// <para>
        /// Multiline logging performs regular expression parsing and matching of all log messages.
        /// This might have a negative impact on logging performance.
        /// </para>
        ///  </note> </dd> <dt>awslogs-multiline-pattern</dt> <dd> 
        /// <para>
        /// Required: No
        /// </para>
        ///  
        /// <para>
        /// This option defines a multiline start pattern that uses a regular expression. A log
        /// message consists of a line that matches the pattern and any following lines that don’t
        /// match the pattern. The matched line is the delimiter between log messages.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.docker.com/config/containers/logging/awslogs/#awslogs-multiline-pattern">awslogs-multiline-pattern</a>.
        /// </para>
        ///  
        /// <para>
        /// This option is ignored if <c>awslogs-datetime-format</c> is also configured.
        /// </para>
        ///  
        /// <para>
        /// You cannot configure both the <c>awslogs-datetime-format</c> and <c>awslogs-multiline-pattern</c>
        /// options.
        /// </para>
        ///  <note> 
        /// <para>
        /// Multiline logging performs regular expression parsing and matching of all log messages.
        /// This might have a negative impact on logging performance.
        /// </para>
        ///  </note> </dd> </dl> 
        /// <para>
        /// The following options apply to all supported log drivers.
        /// </para>
        ///  <dl> <dt>mode</dt> <dd> 
        /// <para>
        /// Required: No
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>non-blocking</c> | <c>blocking</c> 
        /// </para>
        ///  
        /// <para>
        /// This option defines the delivery mode of log messages from the container to the log
        /// driver specified using <c>logDriver</c>. The delivery mode you choose affects application
        /// availability when the flow of logs from container is interrupted.
        /// </para>
        ///  
        /// <para>
        /// If you use the <c>blocking</c> mode and the flow of logs is interrupted, calls from
        /// container code to write to the <c>stdout</c> and <c>stderr</c> streams will block.
        /// The logging thread of the application will block as a result. This may cause the application
        /// to become unresponsive and lead to container healthcheck failure. 
        /// </para>
        ///  
        /// <para>
        /// If you use the <c>non-blocking</c> mode, the container's logs are instead stored in
        /// an in-memory intermediate buffer configured with the <c>max-buffer-size</c> option.
        /// This prevents the application from becoming unresponsive when logs cannot be sent.
        /// We recommend using this mode if you want to ensure service availability and are okay
        /// with some log loss. For more information, see <a href="http://aws.amazon.com/blogs/containers/preventing-log-loss-with-non-blocking-mode-in-the-awslogs-container-log-driver/">Preventing
        /// log loss with non-blocking mode in the <c>awslogs</c> container log driver</a>.
        /// </para>
        ///  
        /// <para>
        /// You can set a default <c>mode</c> for all containers in a specific Amazon Web Services
        /// Region by using the <c>defaultLogDriverMode</c> account setting. If you don't specify
        /// the <c>mode</c> option or configure the account setting, Amazon ECS will default to
        /// the <c>non-blocking</c> mode. For more information about the account setting, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-account-settings.html#default-log-driver-mode">Default
        /// log driver mode</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// On June 25, 2025, Amazon ECS changed the default log driver mode from <c>blocking</c>
        /// to <c>non-blocking</c> to prioritize task availability over logging. To continue using
        /// the <c>blocking</c> mode after this change, do one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Set the <c>mode</c> option in your container definition's <c>logConfiguration</c>
        /// as <c>blocking</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set the <c>defaultLogDriverMode</c> account setting to <c>blocking</c>.
        /// </para>
        ///  </li> </ul> </note> </dd> <dt>max-buffer-size</dt> <dd> 
        /// <para>
        /// Required: No
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>10m</c> 
        /// </para>
        ///  
        /// <para>
        /// When <c>non-blocking</c> mode is used, the <c>max-buffer-size</c> log option controls
        /// the size of the buffer that's used for intermediate message storage. Make sure to
        /// specify an adequate buffer size based on your application. When the buffer fills up,
        /// further logs cannot be stored. Logs that cannot be stored are lost. 
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// To route logs using the <c>splunk</c> log router, you need to specify a <c>splunk-token</c>
        /// and a <c>splunk-url</c>.
        /// </para>
        ///  
        /// <para>
        /// When you use the <c>awsfirelens</c> log router to route logs to an Amazon Web Services
        /// Service or Amazon Web Services Partner Network destination for log storage and analytics,
        /// you can set the <c>log-driver-buffer-limit</c> option to limit the number of events
        /// that are buffered in memory, before being sent to the log router container. It can
        /// help to resolve potential log loss issue because high throughput might result in memory
        /// running out for the buffer inside of Docker.
        /// </para>
        ///  
        /// <para>
        /// Other options you can specify when using <c>awsfirelens</c> to route logs depend on
        /// the destination. When you export logs to Amazon Data Firehose, you can specify the
        /// Amazon Web Services Region with <c>region</c> and a name for the log stream with <c>delivery_stream</c>.
        /// </para>
        ///  
        /// <para>
        /// When you export logs to Amazon Kinesis Data Streams, you can specify an Amazon Web
        /// Services Region with <c>region</c> and a data stream name with <c>stream</c>.
        /// </para>
        ///  
        /// <para>
        ///  When you export logs to Amazon OpenSearch Service, you can specify options like <c>Name</c>,
        /// <c>Host</c> (OpenSearch Service endpoint without protocol), <c>Port</c>, <c>Index</c>,
        /// <c>Type</c>, <c>Aws_auth</c>, <c>Aws_region</c>, <c>Suppress_Type_Name</c>, and <c>tls</c>.
        /// For more information, see <a href="http://aws.amazon.com/blogs/containers/under-the-hood-firelens-for-amazon-ecs-tasks/">Under
        /// the hood: FireLens for Amazon ECS Tasks</a>.
        /// </para>
        ///  
        /// <para>
        /// When you export logs to Amazon S3, you can specify the bucket using the <c>bucket</c>
        /// option. You can also specify <c>region</c>, <c>total_file_size</c>, <c>upload_timeout</c>,
        /// and <c>use_put_object</c> as options.
        /// </para>
        ///  
        /// <para>
        /// This parameter requires version 1.19 of the Docker Remote API or greater on your container
        /// instance. To check the Docker Remote API version on your container instance, log in
        /// to your container instance and run the following command: <c>sudo docker version --format
        /// '{{.Server.APIVersion}}'</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && (this._options.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecretOptions. 
        /// <para>
        /// The secrets to pass to the log configuration. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/specifying-sensitive-data.html">Specifying
        /// sensitive data</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Secret> SecretOptions
        {
            get { return this._secretOptions; }
            set { this._secretOptions = value; }
        }

        // Check to see if SecretOptions property is set
        internal bool IsSetSecretOptions()
        {
            return this._secretOptions != null && (this._secretOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}