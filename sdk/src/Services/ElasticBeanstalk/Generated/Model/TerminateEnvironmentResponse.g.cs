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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// This is the response object from the TerminateEnvironment operation.
    /// </summary>
    public partial class TerminateEnvironmentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AbortableOperationInProgress. 
        /// <para>
        /// Indicates if there is an in-progress environment configuration update or application
        /// version deployment that you can cancel.
        /// </para>
        ///  
        /// <para>
        ///  <c>true:</c> There is an update in progress. 
        /// </para>
        ///  
        /// <para>
        ///  <c>false:</c> There are no updates currently in progress. 
        /// </para>
        /// </summary>
        public bool? AbortableOperationInProgress { get; set; }

        /// <summary>
        /// Checks to see if the AbortableOperationInProgress property is set.
        /// </summary>
        internal bool IsSetAbortableOperationInProgress() => this.AbortableOperationInProgress.HasValue;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application associated with this environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property CNAME. 
        /// <para>
        /// The URL to the CNAME for this environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CNAME { get; set; }

        /// <summary>
        /// Checks to see if the CNAME property is set.
        /// </summary>
        internal bool IsSetCNAME() => this.CNAME != null;

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The creation date for this environment.
        /// </para>
        /// </summary>
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Checks to see if the DateCreated property is set.
        /// </summary>
        internal bool IsSetDateCreated() => this.DateCreated.HasValue;

        /// <summary>
        /// Gets and sets the property DateUpdated. 
        /// <para>
        /// The last modified date for this environment.
        /// </para>
        /// </summary>
        public DateTime? DateUpdated { get; set; }

        /// <summary>
        /// Checks to see if the DateUpdated property is set.
        /// </summary>
        internal bool IsSetDateUpdated() => this.DateUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Describes this environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndpointURL. 
        /// <para>
        /// For load-balanced, autoscaling environments, the URL to the LoadBalancer. For single-instance
        /// environments, the IP address of the instance.
        /// </para>
        /// </summary>
        public string EndpointURL { get; set; }

        /// <summary>
        /// Checks to see if the EndpointURL property is set.
        /// </summary>
        internal bool IsSetEndpointURL() => this.EndpointURL != null;

        /// <summary>
        /// Gets and sets the property EnvironmentArn. 
        /// <para>
        /// The environment's Amazon Resource Name (ARN), which can be used in other API requests
        /// that require an ARN.
        /// </para>
        /// </summary>
        public string EnvironmentArn { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentArn property is set.
        /// </summary>
        internal bool IsSetEnvironmentArn() => this.EnvironmentArn != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of this environment.
        /// </para>
        /// </summary>
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentLinks. 
        /// <para>
        /// A list of links to other environments in the same group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnvironmentLink> EnvironmentLinks { get; set; } = AWSConfigs.InitializeCollections ? new List<EnvironmentLink>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentLinks property is set.
        /// </summary>
        internal bool IsSetEnvironmentLinks() => this.EnvironmentLinks != null && (this.EnvironmentLinks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of this environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 40)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property Health. 
        /// <para>
        /// Describes the health status of the environment. Elastic Beanstalk indicates the failure
        /// levels for a running environment:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Red</c>: Indicates the environment is not responsive. Occurs when three or more
        /// consecutive failures occur for an environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Yellow</c>: Indicates that something is wrong. Occurs when two consecutive failures
        /// occur for an environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Green</c>: Indicates the environment is healthy and fully functional.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Grey</c>: Default health for a new environment. The environment is not fully launched
        /// and health checks have not started or health checks are suspended during an <c>UpdateEnvironment</c>
        /// or <c>RestartEnvironment</c> request.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Default: <c>Grey</c> 
        /// </para>
        /// </summary>
        public EnvironmentHealth Health { get; set; }

        /// <summary>
        /// Checks to see if the Health property is set.
        /// </summary>
        internal bool IsSetHealth() => this.Health != null;

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// Returns the health status of the application running in your environment. For more
        /// information, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/health-enhanced-status.html">Health
        /// Colors and Statuses</a>.
        /// </para>
        /// </summary>
        public EnvironmentHealthStatus HealthStatus { get; set; }

        /// <summary>
        /// Checks to see if the HealthStatus property is set.
        /// </summary>
        internal bool IsSetHealthStatus() => this.HealthStatus != null;

        /// <summary>
        /// Gets and sets the property OperationsRole. <important> 
        /// <para>
        /// The operations role feature of Elastic Beanstalk is in beta release and is subject
        /// to change.
        /// </para>
        ///  </important> 
        /// <para>
        /// The Amazon Resource Name (ARN) of the environment's operations role.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string OperationsRole { get; set; }

        /// <summary>
        /// Checks to see if the OperationsRole property is set.
        /// </summary>
        internal bool IsSetOperationsRole() => this.OperationsRole != null;

        /// <summary>
        /// Gets and sets the property PlatformArn. 
        /// <para>
        /// The ARN of the platform version.
        /// </para>
        /// </summary>
        public string PlatformArn { get; set; }

        /// <summary>
        /// Checks to see if the PlatformArn property is set.
        /// </summary>
        internal bool IsSetPlatformArn() => this.PlatformArn != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The description of the Amazon Web Services resources used by this environment.
        /// </para>
        /// </summary>
        public EnvironmentResourcesDescription Resources { get; set; }

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null;

        /// <summary>
        /// Gets and sets the property SolutionStackName. 
        /// <para>
        ///  The name of the <c>SolutionStack</c> deployed with this environment. 
        /// </para>
        /// </summary>
        public string SolutionStackName { get; set; }

        /// <summary>
        /// Checks to see if the SolutionStackName property is set.
        /// </summary>
        internal bool IsSetSolutionStackName() => this.SolutionStackName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current operational status of the environment:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Aborting</c>: Environment is in the process of aborting a deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Launching</c>: Environment is in the process of initial deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LinkingFrom</c>: Environment is in the process of being linked to by another environment.
        /// See <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/environment-cfg-links.html">Environment
        /// links</a> for details.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LinkingTo</c>: Environment is in the process of linking to another environment.
        /// See <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/environment-cfg-links.html">Environment
        /// links</a> for details.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Updating</c>: Environment is in the process of updating its configuration settings
        /// or application version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Ready</c>: Environment is available to have an action performed on it, such as
        /// update or terminate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Terminating</c>: Environment is in the shut-down process.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Terminated</c>: Environment is not running.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EnvironmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the configuration template used to originally launch this environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// Describes the current tier of this environment.
        /// </para>
        /// </summary>
        public EnvironmentTier Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// The application version deployed in this environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string VersionLabel { get; set; }

        /// <summary>
        /// Checks to see if the VersionLabel property is set.
        /// </summary>
        internal bool IsSetVersionLabel() => this.VersionLabel != null;
    }
}
