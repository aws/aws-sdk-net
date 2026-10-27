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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container definitions are used in task definitions to describe the different containers
    /// that are launched as part of a task.
    /// </summary>
    public partial class ContainerDefinition
    {
        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command that's passed to the container. This parameter maps to <c>Cmd</c> in the
        /// docker container create command and the <c>COMMAND</c> parameter to docker run. If
        /// there are multiple arguments, each argument is a separated string in the array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Command { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Command property is set.
        /// </summary>
        internal bool IsSetCommand() => this.Command != null && (this.Command.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of <c>cpu</c> units reserved for the container. This parameter maps to
        /// <c>CpuShares</c> in the docker container create command and the <c>--cpu-shares</c>
        /// option to docker run.
        /// </para>
        ///  
        /// <para>
        /// This field is optional for tasks using the Fargate launch type, and the only requirement
        /// is that the total amount of CPU reserved for all containers within a task be lower
        /// than the task-level <c>cpu</c> value.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can determine the number of CPU units that are available per EC2 instance type
        /// by multiplying the vCPUs listed for that instance type on the <a href="http://aws.amazon.com/ec2/instance-types/">Amazon
        /// EC2 Instances</a> detail page by 1,024.
        /// </para>
        ///  </note> 
        /// <para>
        /// Linux containers share unallocated CPU units with other containers on the container
        /// instance with the same ratio as their allocated amount. For example, if you run a
        /// single-container task on a single-core instance type with 512 CPU units specified
        /// for that container, and that's the only task running on the container instance, that
        /// container could use the full 1,024 CPU unit share at any given time. However, if you
        /// launched another copy of the same task on that container instance, each task is guaranteed
        /// a minimum of 512 CPU units when needed. Moreover, each container could float to higher
        /// CPU usage if the other container was not using it. If both tasks were 100% active
        /// all of the time, they would be limited to 512 CPU units.
        /// </para>
        ///  
        /// <para>
        /// On Linux container instances, the Docker daemon on the container instance uses the
        /// CPU value to calculate the relative CPU share ratios for running containers. The minimum
        /// valid CPU share value that the Linux kernel allows is 2, and the maximum valid CPU
        /// share value that the Linux kernel allows is 262144. However, the CPU parameter isn't
        /// required, and you can use CPU values below 2 or above 262144 in your container definitions.
        /// For CPU values below 2 (including null) or above 262144, the behavior varies based
        /// on your Amazon ECS container agent version:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Agent versions less than or equal to 1.1.0:</b> Null and zero CPU values are passed
        /// to Docker as 0, which Docker then converts to 1,024 CPU shares. CPU values of 1 are
        /// passed to Docker as 1, which the Linux kernel converts to two CPU shares.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Agent versions greater than or equal to 1.2.0:</b> Null, zero, and CPU values
        /// of 1 are passed to Docker as 2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Agent versions greater than or equal to 1.84.0:</b> CPU values greater than 256
        /// vCPU are passed to Docker as 256, which is equivalent to 262144 CPU shares.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// On Windows container instances, the CPU limit is enforced as an absolute limit, or
        /// a quota. Windows containers only have access to the specified amount of CPU that's
        /// described in the task definition. A null or zero CPU value is passed to Docker as
        /// <c>0</c>, which Windows interprets as 1% of one CPU.
        /// </para>
        /// </summary>
        public int? Cpu { get; set; }

        /// <summary>
        /// Checks to see if the Cpu property is set.
        /// </summary>
        internal bool IsSetCpu() => this.Cpu.HasValue;

        /// <summary>
        /// Gets and sets the property CredentialSpecs. 
        /// <para>
        /// A list of ARNs in SSM or Amazon S3 to a credential spec (<c>CredSpec</c>) file that
        /// configures the container for Active Directory authentication. We recommend that you
        /// use this parameter instead of the <c>dockerSecurityOptions</c>. The maximum number
        /// of ARNs is 1.
        /// </para>
        ///  
        /// <para>
        /// There are two formats for each ARN.
        /// </para>
        ///  <dl> <dt>credentialspecdomainless:MyARN</dt> <dd> 
        /// <para>
        /// You use <c>credentialspecdomainless:MyARN</c> to provide a <c>CredSpec</c> with an
        /// additional section for a secret in Secrets Manager. You provide the login credentials
        /// to the domain in the secret.
        /// </para>
        ///  
        /// <para>
        /// Each task that runs on any container instance can join different domains.
        /// </para>
        ///  
        /// <para>
        /// You can use this format without joining the container instance to a domain.
        /// </para>
        ///  </dd> <dt>credentialspec:MyARN</dt> <dd> 
        /// <para>
        /// You use <c>credentialspec:MyARN</c> to provide a <c>CredSpec</c> for a single domain.
        /// </para>
        ///  
        /// <para>
        /// You must join the container instance to the domain before you start any tasks that
        /// use this task definition.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// In both formats, replace <c>MyARN</c> with the ARN in SSM or Amazon S3.
        /// </para>
        ///  
        /// <para>
        /// If you provide a <c>credentialspecdomainless:MyARN</c>, the <c>credspec</c> must provide
        /// a ARN in Secrets Manager for a secret containing the username, password, and the domain
        /// to connect to. For better security, the instance isn't joined to the domain for domainless
        /// authentication. Other applications on the instance can't use the domainless credentials.
        /// You can use this parameter to run tasks on the same instance, even it the tasks need
        /// to join different domains. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/windows-gmsa.html">Using
        /// gMSAs for Windows Containers</a> and <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/linux-gmsa.html">Using
        /// gMSAs for Linux Containers</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CredentialSpecs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CredentialSpecs property is set.
        /// </summary>
        internal bool IsSetCredentialSpecs() => this.CredentialSpecs != null && (this.CredentialSpecs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// The dependencies defined for container startup and shutdown. A container can contain
        /// multiple dependencies on other containers in a task definition. When a dependency
        /// is defined for container startup, for container shutdown it is reversed.
        /// </para>
        ///  
        /// <para>
        /// For tasks using the EC2 launch type, the container instances require at least version
        /// 1.26.0 of the container agent to turn on container dependencies. However, we recommend
        /// using the latest container agent version. For information about checking your agent
        /// version and updating to the latest version, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-update.html">Updating
        /// the Amazon ECS Container Agent</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>. If you're using an Amazon ECS-optimized Linux AMI, your instance needs
        /// at least version 1.26.0-1 of the <c>ecs-init</c> package. If your container instances
        /// are launched from version <c>20190301</c> or later, then they contain the required
        /// versions of the container agent and <c>ecs-init</c>. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html">Amazon
        /// ECS-optimized Linux AMI</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For tasks using the Fargate launch type, the task or service requires the following
        /// platforms:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Linux platform version <c>1.3.0</c> or later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Windows platform version <c>1.0.0</c> or later.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ContainerDependency> DependsOn { get; set; } = AWSConfigs.InitializeCollections ? new List<ContainerDependency>() : null;

        /// <summary>
        /// Checks to see if the DependsOn property is set.
        /// </summary>
        internal bool IsSetDependsOn() => this.DependsOn != null && (this.DependsOn.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DisableNetworking. 
        /// <para>
        /// When this parameter is true, networking is off within the container. This parameter
        /// maps to <c>NetworkDisabled</c> in the docker container create command.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? DisableNetworking { get; set; }

        /// <summary>
        /// Checks to see if the DisableNetworking property is set.
        /// </summary>
        internal bool IsSetDisableNetworking() => this.DisableNetworking.HasValue;

        /// <summary>
        /// Gets and sets the property DnsSearchDomains. 
        /// <para>
        /// A list of DNS search domains that are presented to the container. This parameter maps
        /// to <c>DnsSearch</c> in the docker container create command and the <c>--dns-search</c>
        /// option to docker run.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsSearchDomains { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DnsSearchDomains property is set.
        /// </summary>
        internal bool IsSetDnsSearchDomains() => this.DnsSearchDomains != null && (this.DnsSearchDomains.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DnsServers. 
        /// <para>
        /// A list of DNS servers that are presented to the container. This parameter maps to
        /// <c>Dns</c> in the docker container create command and the <c>--dns</c> option to docker
        /// run.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsServers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DnsServers property is set.
        /// </summary>
        internal bool IsSetDnsServers() => this.DnsServers != null && (this.DnsServers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DockerLabels. 
        /// <para>
        /// A key/value map of labels to add to the container. This parameter maps to <c>Labels</c>
        /// in the docker container create command and the <c>--label</c> option to docker run.
        /// This parameter requires version 1.18 of the Docker Remote API or greater on your container
        /// instance. To check the Docker Remote API version on your container instance, log in
        /// to your container instance and run the following command: <c>sudo docker version --format
        /// '{{.Server.APIVersion}}'</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> DockerLabels { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the DockerLabels property is set.
        /// </summary>
        internal bool IsSetDockerLabels() => this.DockerLabels != null && (this.DockerLabels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DockerSecurityOptions. 
        /// <para>
        /// A list of strings to provide custom configuration for multiple security systems. This
        /// field isn't valid for containers in tasks using the Fargate launch type.
        /// </para>
        ///  
        /// <para>
        /// For Linux tasks on EC2, this parameter can be used to reference custom labels for
        /// SELinux and AppArmor multi-level security systems.
        /// </para>
        ///  
        /// <para>
        /// For any tasks on EC2, this parameter can be used to reference a credential spec file
        /// that configures a container for Active Directory authentication. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/windows-gmsa.html">Using
        /// gMSAs for Windows Containers</a> and <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/linux-gmsa.html">Using
        /// gMSAs for Linux Containers</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This parameter maps to <c>SecurityOpt</c> in the docker container create command and
        /// the <c>--security-opt</c> option to docker run.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon ECS container agent running on a container instance must register with
        /// the <c>ECS_SELINUX_CAPABLE=true</c> or <c>ECS_APPARMOR_CAPABLE=true</c> environment
        /// variables before containers placed on that instance can use these security options.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-config.html">Amazon
        /// ECS Container Agent Configuration</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid values: "no-new-privileges" | "apparmor:PROFILE" | "label:value" | "credentialspec:CredentialSpecFilePath"
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DockerSecurityOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DockerSecurityOptions property is set.
        /// </summary>
        internal bool IsSetDockerSecurityOptions() => this.DockerSecurityOptions != null && (this.DockerSecurityOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EntryPoint. <important> 
        /// <para>
        /// Early versions of the Amazon ECS container agent don't properly handle <c>entryPoint</c>
        /// parameters. If you have problems using <c>entryPoint</c>, update your container agent
        /// or enter your commands and arguments as <c>command</c> array items instead.
        /// </para>
        ///  </important> 
        /// <para>
        /// The entry point that's passed to the container. This parameter maps to <c>Entrypoint</c>
        /// in the docker container create command and the <c>--entrypoint</c> option to docker
        /// run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EntryPoint { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EntryPoint property is set.
        /// </summary>
        internal bool IsSetEntryPoint() => this.EntryPoint != null && (this.EntryPoint.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to pass to a container. This parameter maps to <c>Env</c>
        /// in the docker container create command and the <c>--env</c> option to docker run.
        /// </para>
        ///  <important> 
        /// <para>
        /// We don't recommend that you use plaintext environment variables for sensitive information,
        /// such as credential data.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public List<KeyValuePair> Environment { get; set; } = AWSConfigs.InitializeCollections ? new List<KeyValuePair>() : null;

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null && (this.Environment.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnvironmentFiles. 
        /// <para>
        /// A list of files containing the environment variables to pass to a container. This
        /// parameter maps to the <c>--env-file</c> option to docker run.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to ten environment files. The file must have a <c>.env</c> file
        /// extension. Each line in an environment file contains an environment variable in <c>VARIABLE=VALUE</c>
        /// format. Lines beginning with <c>#</c> are treated as comments and are ignored.
        /// </para>
        ///  
        /// <para>
        /// If there are environment variables specified using the <c>environment</c> parameter
        /// in a container definition, they take precedence over the variables contained within
        /// an environment file. If multiple environment files are specified that contain the
        /// same variable, they're processed from the top down. We recommend that you use unique
        /// variable names. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/taskdef-envfiles.html">Specifying
        /// Environment Variables</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnvironmentFile> EnvironmentFiles { get; set; } = AWSConfigs.InitializeCollections ? new List<EnvironmentFile>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentFiles property is set.
        /// </summary>
        internal bool IsSetEnvironmentFiles() => this.EnvironmentFiles != null && (this.EnvironmentFiles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Essential. 
        /// <para>
        /// If the <c>essential</c> parameter of a container is marked as <c>true</c>, and that
        /// container fails or stops for any reason, all other containers that are part of the
        /// task are stopped. If the <c>essential</c> parameter of a container is marked as <c>false</c>,
        /// its failure doesn't affect the rest of the containers in a task. If this parameter
        /// is omitted, a container is assumed to be essential.
        /// </para>
        ///  
        /// <para>
        /// All tasks must have at least one essential container. If you have an application that's
        /// composed of multiple containers, group containers that are used for a common purpose
        /// into components, and separate the different components into multiple task definitions.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/application_architecture.html">Application
        /// Architecture</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool? Essential { get; set; }

        /// <summary>
        /// Checks to see if the Essential property is set.
        /// </summary>
        internal bool IsSetEssential() => this.Essential.HasValue;

        /// <summary>
        /// Gets and sets the property ExtraHosts. 
        /// <para>
        /// A list of hostnames and IP address mappings to append to the <c>/etc/hosts</c> file
        /// on the container. This parameter maps to <c>ExtraHosts</c> in the docker container
        /// create command and the <c>--add-host</c> option to docker run.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't supported for Windows containers or tasks that use the <c>awsvpc</c>
        /// network mode.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HostEntry> ExtraHosts { get; set; } = AWSConfigs.InitializeCollections ? new List<HostEntry>() : null;

        /// <summary>
        /// Checks to see if the ExtraHosts property is set.
        /// </summary>
        internal bool IsSetExtraHosts() => this.ExtraHosts != null && (this.ExtraHosts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FirelensConfiguration. 
        /// <para>
        /// The FireLens configuration for the container. This is used to specify and configure
        /// a log router for container logs. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_firelens.html">Custom
        /// Log Routing</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public FirelensConfiguration FirelensConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FirelensConfiguration property is set.
        /// </summary>
        internal bool IsSetFirelensConfiguration() => this.FirelensConfiguration != null;

        /// <summary>
        /// Gets and sets the property HealthCheck. 
        /// <para>
        /// The container health check command and associated configuration parameters for the
        /// container. This parameter maps to <c>HealthCheck</c> in the docker container create
        /// command and the <c>HEALTHCHECK</c> parameter of docker run.
        /// </para>
        /// </summary>
        public HealthCheck HealthCheck { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheck property is set.
        /// </summary>
        internal bool IsSetHealthCheck() => this.HealthCheck != null;

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The hostname to use for your container. This parameter maps to <c>Hostname</c> in
        /// the docker container create command and the <c>--hostname</c> option to docker run.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>hostname</c> parameter is not supported if you're using the <c>awsvpc</c> network
        /// mode.
        /// </para>
        ///  </note>
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        /// Checks to see if the Hostname property is set.
        /// </summary>
        internal bool IsSetHostname() => this.Hostname != null;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The image used to start a container. This string is passed directly to the Docker
        /// daemon. By default, images in the Docker Hub registry are available. Other repositories
        /// are specified with either <c> <i>repository-url</i>/<i>image</i>:<i>tag</i> </c> or
        /// <c> <i>repository-url</i>/<i>image</i>@<i>digest</i> </c>. For images using tags (repository-url/image:tag),
        /// up to 255 characters total are allowed, including letters (uppercase and lowercase),
        /// numbers, hyphens, underscores, colons, periods, forward slashes, and number signs
        /// (#). For images using digests (repository-url/image@digest), the 255 character limit
        /// applies only to the repository URL and image name (everything before the @ sign).
        /// The only supported hash function is sha256, and the hash value after sha256: must
        /// be exactly 64 characters (only letters A-F, a-f, and numbers 0-9 are allowed). This
        /// parameter maps to <c>Image</c> in the docker container create command and the <c>IMAGE</c>
        /// parameter of docker run.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When a new task starts, the Amazon ECS container agent pulls the latest version of
        /// the specified image and tag for the container to use. However, subsequent updates
        /// to a repository image aren't propagated to already running tasks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Images in Amazon ECR repositories can be specified by either using the full <c>registry/repository:tag</c>
        /// or <c>registry/repository@digest</c>. For example, <c>012345678910.dkr.ecr.&lt;region-name&gt;.amazonaws.com/&lt;repository-name&gt;:latest</c>
        /// or <c>012345678910.dkr.ecr.&lt;region-name&gt;.amazonaws.com/&lt;repository-name&gt;@sha256:94afd1f2e64d908bc90dbca0035a5b567EXAMPLE</c>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Images in official repositories on Docker Hub use a single name (for example, <c>ubuntu</c>
        /// or <c>mongo</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Images in other repositories on Docker Hub are qualified with an organization name
        /// (for example, <c>amazon/amazon-ecs-agent</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Images in other online repositories are qualified further by a domain name (for example,
        /// <c>quay.io/assemblyline/ubuntu</c>).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property Interactive. 
        /// <para>
        /// When this parameter is <c>true</c>, you can deploy containerized applications that
        /// require <c>stdin</c> or a <c>tty</c> to be allocated. This parameter maps to <c>OpenStdin</c>
        /// in the docker container create command and the <c>--interactive</c> option to docker
        /// run.
        /// </para>
        /// </summary>
        public bool? Interactive { get; set; }

        /// <summary>
        /// Checks to see if the Interactive property is set.
        /// </summary>
        internal bool IsSetInteractive() => this.Interactive.HasValue;

        /// <summary>
        /// Gets and sets the property Links. 
        /// <para>
        /// The <c>links</c> parameter allows containers to communicate with each other without
        /// the need for port mappings. This parameter is only supported if the network mode of
        /// a task definition is <c>bridge</c>. The <c>name:internalName</c> construct is analogous
        /// to <c>name:alias</c> in Docker links. Up to 255 letters (uppercase and lowercase),
        /// numbers, underscores, and hyphens are allowed.. This parameter maps to <c>Links</c>
        /// in the docker container create command and the <c>--link</c> option to docker run.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// Containers that are collocated on a single container instance may be able to communicate
        /// with each other without requiring links or host port mappings. Network isolation is
        /// achieved on the container instance using security groups and VPC settings.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Links { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Links property is set.
        /// </summary>
        internal bool IsSetLinks() => this.Links != null && (this.Links.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LinuxParameters. 
        /// <para>
        /// Linux-specific modifications that are applied to the default Docker container configuration,
        /// such as Linux kernel capabilities. For more information see <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_KernelCapabilities.html">KernelCapabilities</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note>
        /// </summary>
        public LinuxParameters LinuxParameters { get; set; }

        /// <summary>
        /// Checks to see if the LinuxParameters property is set.
        /// </summary>
        internal bool IsSetLinuxParameters() => this.LinuxParameters != null;

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The log configuration specification for the container.
        /// </para>
        ///  
        /// <para>
        /// This parameter maps to <c>LogConfig</c> in the docker container create command and
        /// the <c>--log-driver</c> option to docker run. By default, containers use the same
        /// logging driver that the Docker daemon uses. However the container can use a different
        /// logging driver than the Docker daemon by specifying a log driver with this parameter
        /// in the container definition. To use a different logging driver for a container, the
        /// log system must be configured properly on the container instance (or on a different
        /// log server for remote logging options). 
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon ECS currently supports a subset of the logging drivers available to the Docker
        /// daemon (shown in the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_LogConfiguration.html">LogConfiguration</a>
        /// data type). Additional log drivers may be available in future releases of the Amazon
        /// ECS container agent.
        /// </para>
        ///  </note> 
        /// <para>
        /// This parameter requires version 1.18 of the Docker Remote API or greater on your container
        /// instance. To check the Docker Remote API version on your container instance, log in
        /// to your container instance and run the following command: <c>sudo docker version --format
        /// '{{.Server.APIVersion}}'</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon ECS container agent running on a container instance must register the logging
        /// drivers available on that instance with the <c>ECS_AVAILABLE_LOGGING_DRIVERS</c> environment
        /// variable before containers placed on that instance can use these log configuration
        /// options. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-config.html">Amazon
        /// ECS Container Agent Configuration</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogConfiguration property is set.
        /// </summary>
        internal bool IsSetLogConfiguration() => this.LogConfiguration != null;

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The amount (in MiB) of memory to present to the container. If your container attempts
        /// to exceed the memory specified here, the container is killed. The total amount of
        /// memory reserved for all containers within a task must be lower than the task <c>memory</c>
        /// value, if one is specified. This parameter maps to <c>Memory</c> in the docker container
        /// create command and the <c>--memory</c> option to docker run.
        /// </para>
        ///  
        /// <para>
        /// If using the Fargate launch type, this parameter is optional.
        /// </para>
        ///  
        /// <para>
        /// If using the EC2 launch type, you must specify either a task-level memory value or
        /// a container-level memory value. If you specify both a container-level <c>memory</c>
        /// and <c>memoryReservation</c> value, <c>memory</c> must be greater than <c>memoryReservation</c>.
        /// If you specify <c>memoryReservation</c>, then that value is subtracted from the available
        /// memory resources for the container instance where the container is placed. Otherwise,
        /// the value of <c>memory</c> is used.
        /// </para>
        ///  
        /// <para>
        /// The Docker 20.10.0 or later daemon reserves a minimum of 6 MiB of memory for a container.
        /// So, don't specify less than 6 MiB of memory for your containers. 
        /// </para>
        ///  
        /// <para>
        /// The Docker 19.03.13-ce or earlier daemon reserves a minimum of 4 MiB of memory for
        /// a container. So, don't specify less than 4 MiB of memory for your containers.
        /// </para>
        /// </summary>
        public int? Memory { get; set; }

        /// <summary>
        /// Checks to see if the Memory property is set.
        /// </summary>
        internal bool IsSetMemory() => this.Memory.HasValue;

        /// <summary>
        /// Gets and sets the property MemoryReservation. 
        /// <para>
        /// The soft limit (in MiB) of memory to reserve for the container. When system memory
        /// is under heavy contention, Docker attempts to keep the container memory to this soft
        /// limit. However, your container can consume more memory when it needs to, up to either
        /// the hard limit specified with the <c>memory</c> parameter (if applicable), or all
        /// of the available memory on the container instance, whichever comes first. This parameter
        /// maps to <c>MemoryReservation</c> in the docker container create command and the <c>--memory-reservation</c>
        /// option to docker run.
        /// </para>
        ///  
        /// <para>
        /// If a task-level memory value is not specified, you must specify a non-zero integer
        /// for one or both of <c>memory</c> or <c>memoryReservation</c> in a container definition.
        /// If you specify both, <c>memory</c> must be greater than <c>memoryReservation</c>.
        /// If you specify <c>memoryReservation</c>, then that value is subtracted from the available
        /// memory resources for the container instance where the container is placed. Otherwise,
        /// the value of <c>memory</c> is used.
        /// </para>
        ///  
        /// <para>
        /// For example, if your container normally uses 128 MiB of memory, but occasionally bursts
        /// to 256 MiB of memory for short periods of time, you can set a <c>memoryReservation</c>
        /// of 128 MiB, and a <c>memory</c> hard limit of 300 MiB. This configuration would allow
        /// the container to only reserve 128 MiB of memory from the remaining resources on the
        /// container instance, but also allow the container to consume more memory resources
        /// when needed.
        /// </para>
        ///  
        /// <para>
        /// The Docker 20.10.0 or later daemon reserves a minimum of 6 MiB of memory for a container.
        /// So, don't specify less than 6 MiB of memory for your containers. 
        /// </para>
        ///  
        /// <para>
        /// The Docker 19.03.13-ce or earlier daemon reserves a minimum of 4 MiB of memory for
        /// a container. So, don't specify less than 4 MiB of memory for your containers.
        /// </para>
        /// </summary>
        public int? MemoryReservation { get; set; }

        /// <summary>
        /// Checks to see if the MemoryReservation property is set.
        /// </summary>
        internal bool IsSetMemoryReservation() => this.MemoryReservation.HasValue;

        /// <summary>
        /// Gets and sets the property MountPoints. 
        /// <para>
        /// The mount points for data volumes in your container.
        /// </para>
        ///  
        /// <para>
        /// This parameter maps to <c>Volumes</c> in the docker container create command and the
        /// <c>--volume</c> option to docker run.
        /// </para>
        ///  
        /// <para>
        /// Windows containers can mount whole directories on the same drive as <c>$env:ProgramData</c>.
        /// Windows containers can't mount directories on a different drive, and mount point can't
        /// be across drives.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MountPoint> MountPoints { get; set; } = AWSConfigs.InitializeCollections ? new List<MountPoint>() : null;

        /// <summary>
        /// Checks to see if the MountPoints property is set.
        /// </summary>
        internal bool IsSetMountPoints() => this.MountPoints != null && (this.MountPoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a container. If you're linking multiple containers together in a task
        /// definition, the <c>name</c> of one container can be entered in the <c>links</c> of
        /// another container to connect the containers. Up to 255 letters (uppercase and lowercase),
        /// numbers, underscores, and hyphens are allowed. This parameter maps to <c>name</c>
        /// in the docker container create command and the <c>--name</c> option to docker run.
        /// 
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PortMappings. 
        /// <para>
        /// The list of port mappings for the container. Port mappings allow containers to access
        /// ports on the host container instance to send or receive traffic.
        /// </para>
        ///  
        /// <para>
        /// For task definitions that use the <c>awsvpc</c> network mode, only specify the <c>containerPort</c>.
        /// The <c>hostPort</c> can be left blank or it must be the same value as the <c>containerPort</c>.
        /// </para>
        ///  
        /// <para>
        /// Port mappings on Windows use the <c>NetNAT</c> gateway address rather than <c>localhost</c>.
        /// There's no loopback for port mappings on Windows, so you can't access a container's
        /// mapped port from the host itself. 
        /// </para>
        ///  
        /// <para>
        /// This parameter maps to <c>PortBindings</c> in the docker container create command
        /// and the <c>--publish</c> option to docker run. If the network mode of a task definition
        /// is set to <c>none</c>, then you can't specify port mappings. If the network mode of
        /// a task definition is set to <c>host</c>, then host ports must either be undefined
        /// or they must match the container port in the port mapping.
        /// </para>
        ///  <note> 
        /// <para>
        /// After a task reaches the <c>RUNNING</c> status, manual and automatic host and container
        /// port assignments are visible in the <b>Network Bindings</b> section of a container
        /// description for a selected task in the Amazon ECS console. The assignments are also
        /// visible in the <c>networkBindings</c> section <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_DescribeTasks.html">DescribeTasks</a>
        /// responses.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PortMapping> PortMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<PortMapping>() : null;

        /// <summary>
        /// Checks to see if the PortMappings property is set.
        /// </summary>
        internal bool IsSetPortMappings() => this.PortMappings != null && (this.PortMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Privileged. 
        /// <para>
        /// When this parameter is true, the container is given elevated privileges on the host
        /// container instance (similar to the <c>root</c> user). This parameter maps to <c>Privileged</c>
        /// in the docker container create command and the <c>--privileged</c> option to docker
        /// run
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers or tasks run on Fargate.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? Privileged { get; set; }

        /// <summary>
        /// Checks to see if the Privileged property is set.
        /// </summary>
        internal bool IsSetPrivileged() => this.Privileged.HasValue;

        /// <summary>
        /// Gets and sets the property PseudoTerminal. 
        /// <para>
        /// When this parameter is <c>true</c>, a TTY is allocated. This parameter maps to <c>Tty</c>
        /// in the docker container create command and the <c>--tty</c> option to docker run.
        /// </para>
        /// </summary>
        public bool? PseudoTerminal { get; set; }

        /// <summary>
        /// Checks to see if the PseudoTerminal property is set.
        /// </summary>
        internal bool IsSetPseudoTerminal() => this.PseudoTerminal.HasValue;

        /// <summary>
        /// Gets and sets the property ReadonlyRootFilesystem. 
        /// <para>
        /// When this parameter is true, the container is given read-only access to its root file
        /// system. This parameter maps to <c>ReadonlyRootfs</c> in the docker container create
        /// command and the <c>--read-only</c> option to docker run.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? ReadonlyRootFilesystem { get; set; }

        /// <summary>
        /// Checks to see if the ReadonlyRootFilesystem property is set.
        /// </summary>
        internal bool IsSetReadonlyRootFilesystem() => this.ReadonlyRootFilesystem.HasValue;

        /// <summary>
        /// Gets and sets the property RepositoryCredentials. 
        /// <para>
        /// The private repository authentication credentials to use.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public RepositoryCredentials RepositoryCredentials { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryCredentials property is set.
        /// </summary>
        internal bool IsSetRepositoryCredentials() => this.RepositoryCredentials != null;

        /// <summary>
        /// Gets and sets the property ResourceRequirements. 
        /// <para>
        /// The type and amount of a resource to assign to a container. The supported resources
        /// are GPUs and Neuron devices.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceRequirement> ResourceRequirements { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceRequirement>() : null;

        /// <summary>
        /// Checks to see if the ResourceRequirements property is set.
        /// </summary>
        internal bool IsSetResourceRequirements() => this.ResourceRequirements != null && (this.ResourceRequirements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RestartPolicy. 
        /// <para>
        /// The restart policy for a container. When you set up a restart policy, Amazon ECS can
        /// restart the container without needing to replace the task. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/container-restart-policy.html">Restart
        /// individual containers in Amazon ECS tasks with container restart policies</a> in the
        /// <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public ContainerRestartPolicy RestartPolicy { get; set; }

        /// <summary>
        /// Checks to see if the RestartPolicy property is set.
        /// </summary>
        internal bool IsSetRestartPolicy() => this.RestartPolicy != null;

        /// <summary>
        /// Gets and sets the property Secrets. 
        /// <para>
        /// The secrets to pass to the container. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/specifying-sensitive-data.html">Specifying
        /// Sensitive Data</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Secret> Secrets { get; set; } = AWSConfigs.InitializeCollections ? new List<Secret>() : null;

        /// <summary>
        /// Checks to see if the Secrets property is set.
        /// </summary>
        internal bool IsSetSecrets() => this.Secrets != null && (this.Secrets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTimeout. 
        /// <para>
        /// Time duration (in seconds) to wait before giving up on resolving dependencies for
        /// a container. For example, you specify two containers in a task definition with containerA
        /// having a dependency on containerB reaching a <c>COMPLETE</c>, <c>SUCCESS</c>, or <c>HEALTHY</c>
        /// status. If a <c>startTimeout</c> value is specified for containerB and it doesn't
        /// reach the desired status within that time then containerA gives up and not start.
        /// This results in the task transitioning to a <c>STOPPED</c> state.
        /// </para>
        ///  <note> 
        /// <para>
        /// When the <c>ECS_CONTAINER_START_TIMEOUT</c> container agent configuration variable
        /// is used, it's enforced independently from this start timeout value.
        /// </para>
        ///  </note> 
        /// <para>
        /// For tasks using the Fargate launch type, the task or service requires the following
        /// platforms:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Linux platform version <c>1.3.0</c> or later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Windows platform version <c>1.0.0</c> or later.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For tasks using the EC2 launch type, your container instances require at least version
        /// <c>1.26.0</c> of the container agent to use a container start timeout value. However,
        /// we recommend using the latest container agent version. For information about checking
        /// your agent version and updating to the latest version, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-update.html">Updating
        /// the Amazon ECS Container Agent</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>. If you're using an Amazon ECS-optimized Linux AMI, your instance needs
        /// at least version <c>1.26.0-1</c> of the <c>ecs-init</c> package. If your container
        /// instances are launched from version <c>20190301</c> or later, then they contain the
        /// required versions of the container agent and <c>ecs-init</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html">Amazon
        /// ECS-optimized Linux AMI</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The valid values for Fargate are 2-120 seconds.
        /// </para>
        /// </summary>
        public int? StartTimeout { get; set; }

        /// <summary>
        /// Checks to see if the StartTimeout property is set.
        /// </summary>
        internal bool IsSetStartTimeout() => this.StartTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property StopTimeout. 
        /// <para>
        /// Time duration (in seconds) to wait before the container is forcefully killed if it
        /// doesn't exit normally on its own.
        /// </para>
        ///  
        /// <para>
        /// For tasks using the Fargate launch type, the task or service requires the following
        /// platforms:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Linux platform version <c>1.3.0</c> or later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Windows platform version <c>1.0.0</c> or later.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For tasks that use the Fargate launch type, the max stop timeout value is 120 seconds
        /// and if the parameter is not specified, the default value of 30 seconds is used.
        /// </para>
        ///  
        /// <para>
        /// For tasks that use the EC2 launch type, if the <c>stopTimeout</c> parameter isn't
        /// specified, the value set for the Amazon ECS container agent configuration variable
        /// <c>ECS_CONTAINER_STOP_TIMEOUT</c> is used. If neither the <c>stopTimeout</c> parameter
        /// or the <c>ECS_CONTAINER_STOP_TIMEOUT</c> agent configuration variable are set, then
        /// the default values of 30 seconds for Linux containers and 30 seconds on Windows containers
        /// are used. Your container instances require at least version 1.26.0 of the container
        /// agent to use a container stop timeout value. However, we recommend using the latest
        /// container agent version. For information about checking your agent version and updating
        /// to the latest version, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-agent-update.html">Updating
        /// the Amazon ECS Container Agent</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>. If you're using an Amazon ECS-optimized Linux AMI, your instance needs
        /// at least version 1.26.0-1 of the <c>ecs-init</c> package. If your container instances
        /// are launched from version <c>20190301</c> or later, then they contain the required
        /// versions of the container agent and <c>ecs-init</c>. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html">Amazon
        /// ECS-optimized Linux AMI</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The valid values for Fargate are 2-120 seconds.
        /// </para>
        /// </summary>
        public int? StopTimeout { get; set; }

        /// <summary>
        /// Checks to see if the StopTimeout property is set.
        /// </summary>
        internal bool IsSetStopTimeout() => this.StopTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property SystemControls. 
        /// <para>
        /// A list of namespaced kernel parameters to set in the container. This parameter maps
        /// to <c>Sysctls</c> in the docker container create command and the <c>--sysctl</c> option
        /// to docker run. For example, you can configure <c>net.ipv4.tcp_keepalive_time</c> setting
        /// to maintain longer lived connections.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SystemControl> SystemControls { get; set; } = AWSConfigs.InitializeCollections ? new List<SystemControl>() : null;

        /// <summary>
        /// Checks to see if the SystemControls property is set.
        /// </summary>
        internal bool IsSetSystemControls() => this.SystemControls != null && (this.SystemControls.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ulimits. 
        /// <para>
        /// A list of <c>ulimits</c> to set in the container. If a <c>ulimit</c> value is specified
        /// in a task definition, it overrides the default values set by Docker. This parameter
        /// maps to <c>Ulimits</c> in the docker container create command and the <c>--ulimit</c>
        /// option to docker run. Valid naming values are displayed in the <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_Ulimit.html">Ulimit</a>
        /// data type.
        /// </para>
        ///  
        /// <para>
        /// Amazon ECS tasks hosted on Fargate use the default resource limit values set by the
        /// operating system with the exception of the <c>nofile</c> resource limit parameter
        /// which Fargate overrides. The <c>nofile</c> resource limit sets a restriction on the
        /// number of open files that a container can use. The default <c>nofile</c> soft limit
        /// is <c> 65535</c> and the default hard limit is <c>65535</c>.
        /// </para>
        ///  
        /// <para>
        /// This parameter requires version 1.18 of the Docker Remote API or greater on your container
        /// instance. To check the Docker Remote API version on your container instance, log in
        /// to your container instance and run the following command: <c>sudo docker version --format
        /// '{{.Server.APIVersion}}'</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Ulimit> Ulimits { get; set; } = AWSConfigs.InitializeCollections ? new List<Ulimit>() : null;

        /// <summary>
        /// Checks to see if the Ulimits property is set.
        /// </summary>
        internal bool IsSetUlimits() => this.Ulimits != null && (this.Ulimits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// The user to use inside the container. This parameter maps to <c>User</c> in the docker
        /// container create command and the <c>--user</c> option to docker run.
        /// </para>
        ///  <important> 
        /// <para>
        /// When running tasks using the <c>host</c> network mode, don't run containers using
        /// the root user (UID 0). We recommend using a non-root user for better security.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can specify the <c>user</c> using the following formats. If specifying a UID or
        /// GID, you must specify it as a positive integer.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>user</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>user:group</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>uid</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>uid:gid</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>user:gid</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>uid:group</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// This parameter is not supported for Windows containers.
        /// </para>
        ///  </note>
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;

        /// <summary>
        /// Gets and sets the property VersionConsistency. 
        /// <para>
        /// Specifies whether Amazon ECS will resolve the container image tag provided in the
        /// container definition to an image digest. By default, the value is <c>enabled</c>.
        /// If you set the value for a container as <c>disabled</c>, Amazon ECS will not resolve
        /// the provided container image tag to a digest and will use the original image URI specified
        /// in the container definition for deployment. For more information about container image
        /// resolution, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-type-ecs.html#deployment-container-image-stability">Container
        /// image resolution</a> in the <i>Amazon ECS Developer Guide</i>.
        /// </para>
        /// </summary>
        public VersionConsistency VersionConsistency { get; set; }

        /// <summary>
        /// Checks to see if the VersionConsistency property is set.
        /// </summary>
        internal bool IsSetVersionConsistency() => this.VersionConsistency != null;

        /// <summary>
        /// Gets and sets the property VolumesFrom. 
        /// <para>
        /// Data volumes to mount from another container. This parameter maps to <c>VolumesFrom</c>
        /// in the docker container create command and the <c>--volumes-from</c> option to docker
        /// run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VolumeFrom> VolumesFrom { get; set; } = AWSConfigs.InitializeCollections ? new List<VolumeFrom>() : null;

        /// <summary>
        /// Checks to see if the VolumesFrom property is set.
        /// </summary>
        internal bool IsSetVolumesFrom() => this.VolumesFrom != null && (this.VolumesFrom.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// The working directory to run commands inside the container in. This parameter maps
        /// to <c>WorkingDir</c> in the docker container create command and the <c>--workdir</c>
        /// option to docker run.
        /// </para>
        /// </summary>
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// Checks to see if the WorkingDirectory property is set.
        /// </summary>
        internal bool IsSetWorkingDirectory() => this.WorkingDirectory != null;
    }
}
