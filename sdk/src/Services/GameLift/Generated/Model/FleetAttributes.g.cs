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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Describes an Amazon GameLift Servers fleet of game hosting resources. Attributes differ
    /// based on the fleet's compute type, as follows:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// EC2 fleet attributes identify a <c>Build</c> resource (for fleets with customer game
    /// server builds) or a <c>Script</c> resource (for Amazon GameLift Servers Realtime fleets).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon GameLift Servers Anywhere fleets have an abbreviated set of attributes, because
    /// most fleet configurations are set directly on the fleet's computes. Attributes include
    /// fleet identifiers and descriptive properties, creation/termination time, and fleet
    /// status.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Returned by:</b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetAttributes">https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetAttributes</a>
    /// 
    /// </para>
    /// </summary>
    public partial class FleetAttributes
    {
        /// <summary>
        /// Gets and sets the property AnywhereConfiguration. 
        /// <para>
        /// A set of attributes that are specific to an Anywhere fleet.
        /// </para>
        /// </summary>
        public AnywhereConfiguration AnywhereConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AnywhereConfiguration property is set.
        /// </summary>
        internal bool IsSetAnywhereConfiguration() => this.AnywhereConfiguration != null;

        /// <summary>
        /// Gets and sets the property BuildArn. 
        /// <para>
        ///  The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// associated with the Amazon GameLift Servers build resource that is deployed on instances
        /// in this fleet. In a GameLift build ARN, the resource ID matches the <c>BuildId</c>
        /// value. This attribute is used with fleets where <c>ComputeType</c> is "EC2".
        /// </para>
        /// </summary>
        public string BuildArn { get; set; }

        /// <summary>
        /// Checks to see if the BuildArn property is set.
        /// </summary>
        internal bool IsSetBuildArn() => this.BuildArn != null;

        /// <summary>
        /// Gets and sets the property BuildId. 
        /// <para>
        /// A unique identifier for the build resource that is deployed on instances in this fleet.
        /// This attribute is used with fleets where <c>ComputeType</c> is "EC2".
        /// </para>
        /// </summary>
        public string BuildId { get; set; }

        /// <summary>
        /// Checks to see if the BuildId property is set.
        /// </summary>
        internal bool IsSetBuildId() => this.BuildId != null;

        /// <summary>
        /// Gets and sets the property CertificateConfiguration. 
        /// <para>
        /// Determines whether a TLS/SSL certificate is generated for a fleet. This feature must
        /// be enabled when creating the fleet. All instances in a fleet share the same certificate.
        /// </para>
        /// </summary>
        public CertificateConfiguration CertificateConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CertificateConfiguration property is set.
        /// </summary>
        internal bool IsSetCertificateConfiguration() => this.CertificateConfiguration != null;

        /// <summary>
        /// Gets and sets the property ComputeType. 
        /// <para>
        /// The type of compute resource used to host your game servers. You can use your own
        /// compute resources with Amazon GameLift Servers Anywhere or use Amazon EC2 instances
        /// with managed Amazon GameLift Servers.
        /// </para>
        /// </summary>
        public ComputeType ComputeType { get; set; }

        /// <summary>
        /// Checks to see if the ComputeType property is set.
        /// </summary>
        internal bool IsSetComputeType() => this.ComputeType != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FleetArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a Amazon GameLift Servers fleet resource and uniquely identifies
        /// it. ARNs are unique across all Regions. Format is <c>arn:aws:gamelift:&lt;region&gt;::fleet/fleet-a1234567-b8c9-0d1e-2fa3-b45c6d7e8912</c>.
        /// In a GameLift fleet ARN, the resource ID matches the <c>FleetId</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string FleetArn { get; set; }

        /// <summary>
        /// Checks to see if the FleetArn property is set.
        /// </summary>
        internal bool IsSetFleetArn() => this.FleetArn != null;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property FleetType. 
        /// <para>
        /// Indicates whether the fleet uses On-Demand or Spot instances. For more information,
        /// see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-ec2-instances.html#gamelift-ec2-instances-spot">
        /// On-Demand versus Spot Instances</a>. This fleet property can't be changed after the
        /// fleet is created.
        /// </para>
        /// </summary>
        public FleetType FleetType { get; set; }

        /// <summary>
        /// Checks to see if the FleetType property is set.
        /// </summary>
        internal bool IsSetFleetType() => this.FleetType != null;

        /// <summary>
        /// Gets and sets the property InstanceRoleArn. 
        /// <para>
        /// A unique identifier for an IAM role that manages access to your Amazon Web Services
        /// services. With an instance role ARN set, any application that runs on an instance
        /// in this fleet can assume the role, including install scripts, server processes, and
        /// daemons (background processes). Create a role or look up a role's ARN by using the
        /// <a href="https://console.aws.amazon.com/iam/">IAM dashboard</a> in the Amazon Web
        /// Services Management Console. Learn more about using on-box credentials for your game
        /// servers at <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-resources.html">
        /// Access external resources from a game server</a>. This attribute is used with fleets
        /// where <c>ComputeType</c> is <c>EC2</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string InstanceRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRoleArn property is set.
        /// </summary>
        internal bool IsSetInstanceRoleArn() => this.InstanceRoleArn != null;

        /// <summary>
        /// Gets and sets the property InstanceRoleCredentialsProvider. 
        /// <para>
        /// Indicates that fleet instances maintain a shared credentials file for the IAM role
        /// defined in <c>InstanceRoleArn</c>. Shared credentials allow applications that are
        /// deployed with the game server executable to communicate with other Amazon Web Services
        /// resources. This property is used only when the game server is integrated with the
        /// server SDK version 5.x. For more information about using shared credentials, see <a
        /// href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-resources.html">
        /// Communicate with other Amazon Web Services resources from your fleets</a>. This attribute
        /// is used with fleets where <c>ComputeType</c> is <c>EC2</c>.
        /// </para>
        /// </summary>
        public InstanceRoleCredentialsProvider InstanceRoleCredentialsProvider { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRoleCredentialsProvider property is set.
        /// </summary>
        internal bool IsSetInstanceRoleCredentialsProvider() => this.InstanceRoleCredentialsProvider != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 instance type that the fleet uses. Instance type determines the computing
        /// resources of each instance in the fleet, including CPU, memory, storage, and networking
        /// capacity. See <a href="http://aws.amazon.com/ec2/instance-types/">Amazon Elastic Compute
        /// Cloud Instance Types</a> for detailed descriptions. This attribute is used with fleets
        /// where <c>ComputeType</c> is <c>EC2</c>.
        /// </para>
        /// </summary>
        public EC2InstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property LogPaths. 
        /// <para>
        ///  <b>This parameter is no longer used.</b> Game session log paths are now defined using
        /// the Amazon GameLift Servers server API <c>ProcessReady()</c> <c>logParameters</c>.
        /// See more information in the <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api-ref.html#gamelift-sdk-server-api-ref-dataypes-process">Server
        /// API Reference</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LogPaths { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LogPaths property is set.
        /// </summary>
        internal bool IsSetLogPaths() => this.LogPaths != null && (this.LogPaths.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricGroups. 
        /// <para>
        /// Name of a metric group that metrics for this fleet are added to. In Amazon CloudWatch,
        /// you can view aggregated metrics for fleets that are in a metric group. A fleet can
        /// be included in only one metric group at a time. This attribute is used with fleets
        /// where <c>ComputeType</c> is <c>EC2</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> MetricGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MetricGroups property is set.
        /// </summary>
        internal bool IsSetMetricGroups() => this.MetricGroups != null && (this.MetricGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with a fleet. Fleet names do not need to be
        /// unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NewGameSessionProtectionPolicy. 
        /// <para>
        /// The type of game session protection to set on all new instances that are started in
        /// the fleet. This attribute is used with fleets where <c>ComputeType</c> is <c>EC2</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>NoProtection</b> -- The game session can be terminated during a scale-down event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FullProtection</b> -- If the game session is in an <c>ACTIVE</c> status, it cannot
        /// be terminated during a scale-down event.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ProtectionPolicy NewGameSessionProtectionPolicy { get; set; }

        /// <summary>
        /// Checks to see if the NewGameSessionProtectionPolicy property is set.
        /// </summary>
        internal bool IsSetNewGameSessionProtectionPolicy() => this.NewGameSessionProtectionPolicy != null;

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The operating system of the fleet's computing resources. A fleet's operating system
        /// is determined by the OS of the build or script that is deployed on this fleet. This
        /// attribute is used with fleets where <c>ComputeType</c> is <c>EC2</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Linux 2 (AL2) will reach end of support on 6/30/2026. See more details in the
        /// <a href="http://aws.amazon.com/aws.amazon.com/amazon-linux-2/faqs/">Amazon Linux 2
        /// FAQs</a>. For game servers that are hosted on AL2 and use server SDK version 4.x for
        /// Amazon GameLift Servers, first update the game server build to server SDK 5.x, and
        /// then deploy to AL2023 instances. See <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-serversdk5-migration.html">
        /// Migrate to server SDK version 5.</a> 
        /// </para>
        ///  </note>
        /// </summary>
        public OperatingSystem OperatingSystem { get; set; }

        /// <summary>
        /// Checks to see if the OperatingSystem property is set.
        /// </summary>
        internal bool IsSetOperatingSystem() => this.OperatingSystem != null;

        /// <summary>
        /// Gets and sets the property PlayerGatewayConfiguration. 
        /// <para>
        /// Configuration settings for player gateway on this fleet.
        /// </para>
        /// </summary>
        public PlayerGatewayConfiguration PlayerGatewayConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PlayerGatewayConfiguration property is set.
        /// </summary>
        internal bool IsSetPlayerGatewayConfiguration() => this.PlayerGatewayConfiguration != null;

        /// <summary>
        /// Gets and sets the property PlayerGatewayMode. 
        /// <para>
        /// Indicates whether player gateway is enabled for this fleet. Player gateway provides
        /// benefits such as DDoS protection with negligible impact to latency.
        /// </para>
        ///  
        /// <para>
        /// If <c>ENABLED</c> or <c>REQUIRED</c>, game clients can use player gateway to connect
        /// with the game server. If <c>DISABLED</c>, game clients cannot use player gateway.
        /// Instead, they have to directly connect to the game server.
        /// </para>
        /// </summary>
        public PlayerGatewayMode PlayerGatewayMode { get; set; }

        /// <summary>
        /// Checks to see if the PlayerGatewayMode property is set.
        /// </summary>
        internal bool IsSetPlayerGatewayMode() => this.PlayerGatewayMode != null;

        /// <summary>
        /// Gets and sets the property ResourceCreationLimitPolicy.
        /// </summary>
        public ResourceCreationLimitPolicy ResourceCreationLimitPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCreationLimitPolicy property is set.
        /// </summary>
        internal bool IsSetResourceCreationLimitPolicy() => this.ResourceCreationLimitPolicy != null;

        /// <summary>
        /// Gets and sets the property ScriptArn. 
        /// <para>
        ///  The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// associated with the GameLift script resource that is deployed on instances in this
        /// fleet. In a GameLift script ARN, the resource ID matches the <c>ScriptId</c> value.
        /// </para>
        /// </summary>
        public string ScriptArn { get; set; }

        /// <summary>
        /// Checks to see if the ScriptArn property is set.
        /// </summary>
        internal bool IsSetScriptArn() => this.ScriptArn != null;

        /// <summary>
        /// Gets and sets the property ScriptId. 
        /// <para>
        /// A unique identifier for the Realtime script resource that is deployed on instances
        /// in this fleet. This attribute is used with fleets where <c>ComputeType</c> is "EC2".
        /// </para>
        /// </summary>
        public string ScriptId { get; set; }

        /// <summary>
        /// Checks to see if the ScriptId property is set.
        /// </summary>
        internal bool IsSetScriptId() => this.ScriptId != null;

        /// <summary>
        /// Gets and sets the property ServerLaunchParameters. 
        /// <para>
        ///  <b>This parameter is no longer used.</b> Server launch parameters are now defined
        /// using the fleet's runtime configuration. Requests that use this parameter continue
        /// to be valid.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ServerLaunchParameters { get; set; }

        /// <summary>
        /// Checks to see if the ServerLaunchParameters property is set.
        /// </summary>
        internal bool IsSetServerLaunchParameters() => this.ServerLaunchParameters != null;

        /// <summary>
        /// Gets and sets the property ServerLaunchPath. 
        /// <para>
        ///  <b>This parameter is no longer used.</b> Server launch paths are now defined using
        /// the fleet's <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/RuntimeConfiguration.html">RuntimeConfiguration</a>.
        /// Requests that use this parameter continue to be valid.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ServerLaunchPath { get; set; }

        /// <summary>
        /// Checks to see if the ServerLaunchPath property is set.
        /// </summary>
        internal bool IsSetServerLaunchPath() => this.ServerLaunchPath != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the fleet. Possible fleet statuses include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// NEW -- A new fleet resource has been defined and Amazon GameLift Servers has started
        /// creating the fleet. Desired instances is set to 1. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DOWNLOADING/VALIDATING/BUILDING -- Amazon GameLift Servers is downloading the game
        /// server build, running install scripts, and then validating the build files. When complete,
        /// Amazon GameLift Servers launches a fleet instance. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACTIVATING -- Amazon GameLift Servers is launching a game server process and testing
        /// its connectivity with the Amazon GameLift Servers service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACTIVE -- The fleet is now ready to host game sessions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ERROR -- An error occurred when downloading, validating, building, or activating the
        /// fleet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EXPIRED -- The fleet has been expired. The fleet is scaled down to zero instances
        /// and cannot host new game sessions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETING -- Hosts are responding to a delete fleet request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TERMINATED -- The fleet no longer exists.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FleetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StoppedActions. 
        /// <para>
        /// A list of fleet activity that has been suspended using <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_StopFleetActions.html">StopFleetActions</a>.
        /// This includes fleet auto-scaling. This attribute is used with fleets where <c>ComputeType</c>
        /// is <c>EC2</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> StoppedActions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StoppedActions property is set.
        /// </summary>
        internal bool IsSetStoppedActions() => this.StoppedActions != null && (this.StoppedActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TerminationTime. 
        /// <para>
        /// A time stamp indicating when this data object was terminated. Format is a number expressed
        /// in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// </para>
        /// </summary>
        public DateTime? TerminationTime { get; set; }

        /// <summary>
        /// Checks to see if the TerminationTime property is set.
        /// </summary>
        internal bool IsSetTerminationTime() => this.TerminationTime.HasValue;
    }
}
