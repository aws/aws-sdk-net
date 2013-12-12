/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para>Describes the properties of an environment.</para>
    /// </summary>
    public partial class CreateEnvironmentResult : AmazonWebServiceResponse
    {
        
        private string environmentName;
        private string environmentId;
        private string applicationName;
        private string versionLabel;
        private string solutionStackName;
        private string templateName;
        private string description;
        private string endpointURL;
        private string cNAME;
        private DateTime? dateCreated;
        private DateTime? dateUpdated;
        private EnvironmentStatus status;
        private EnvironmentHealth health;
        private EnvironmentResourcesDescription resources;
        private EnvironmentTier tier;


        /// <summary>
        /// The name of this environment.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>4 - 23</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string EnvironmentName
        {
            get { return this.environmentName; }
            set { this.environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this.environmentName != null;
        }

        /// <summary>
        /// The ID of this environment.
        ///  
        /// </summary>
        public string EnvironmentId
        {
            get { return this.environmentId; }
            set { this.environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this.environmentId != null;
        }

        /// <summary>
        /// The name of the application associated with this environment.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this.applicationName; }
            set { this.applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this.applicationName != null;
        }

        /// <summary>
        /// The application version deployed in this environment.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string VersionLabel
        {
            get { return this.versionLabel; }
            set { this.versionLabel = value; }
        }

        // Check to see if VersionLabel property is set
        internal bool IsSetVersionLabel()
        {
            return this.versionLabel != null;
        }

        /// <summary>
        /// The name of the <c>SolutionStack</c> deployed with this environment.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SolutionStackName
        {
            get { return this.solutionStackName; }
            set { this.solutionStackName = value; }
        }

        // Check to see if SolutionStackName property is set
        internal bool IsSetSolutionStackName()
        {
            return this.solutionStackName != null;
        }

        /// <summary>
        /// The name of the configuration template used to originally launch this environment.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TemplateName
        {
            get { return this.templateName; }
            set { this.templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this.templateName != null;
        }

        /// <summary>
        /// Describes this environment.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 200</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// For load-balanced, autoscaling environments, the URL to the LoadBalancer. For single-instance environments, the IP address of the instance.
        ///  
        /// </summary>
        public string EndpointURL
        {
            get { return this.endpointURL; }
            set { this.endpointURL = value; }
        }

        // Check to see if EndpointURL property is set
        internal bool IsSetEndpointURL()
        {
            return this.endpointURL != null;
        }

        /// <summary>
        /// The URL to the CNAME for this environment.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string CNAME
        {
            get { return this.cNAME; }
            set { this.cNAME = value; }
        }

        // Check to see if CNAME property is set
        internal bool IsSetCNAME()
        {
            return this.cNAME != null;
        }

        /// <summary>
        /// The creation date for this environment.
        ///  
        /// </summary>
        public DateTime DateCreated
        {
            get { return this.dateCreated ?? default(DateTime); }
            set { this.dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this.dateCreated.HasValue;
        }

        /// <summary>
        /// The last modified date for this environment.
        ///  
        /// </summary>
        public DateTime DateUpdated
        {
            get { return this.dateUpdated ?? default(DateTime); }
            set { this.dateUpdated = value; }
        }

        // Check to see if DateUpdated property is set
        internal bool IsSetDateUpdated()
        {
            return this.dateUpdated.HasValue;
        }

        /// <summary>
        /// The current operational status of the environment: <ul> <li> <c>Launching</c>: Environment is in the process of initial deployment. </li>
        /// <li> <c>Updating</c>: Environment is in the process of updating its configuration settings or application version. </li> <li> <c>Ready</c>:
        /// Environment is available to have an action performed on it, such as update or terminate. </li> <li> <c>Terminating</c>: Environment is in
        /// the shut-down process. </li> <li> <c>Terminated</c>: Environment is not running. </li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Launching, Updating, Ready, Terminating, Terminated</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public EnvironmentStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// Describes the health status of the environment. AWS Elastic Beanstalk indicates the failure levels for a running environment: <enumValues>
        /// <value name="Red"> <c>Red</c> : Indicates the environment is not working. </value> <value name="Yellow"> <c>Yellow</c>: Indicates that
        /// something is wrong, the application might not be available, but the instances appear running. </value> <value name="Green"> <c>Green</c>:
        /// Indicates the environment is healthy and fully functional. </value> </enumValues> <ul> <li> <c>Red</c>: Indicates the environment is not
        /// responsive. Occurs when three or more consecutive failures occur for an environment. </li> <li> <c>Yellow</c>: Indicates that something is
        /// wrong. Occurs when two consecutive failures occur for an environment. </li> <li> <c>Green</c>: Indicates the environment is healthy and
        /// fully functional. </li> <li> <c>Grey</c>: Default health for a new environment. The environment is not fully launched and health checks have
        /// not started or health checks are suspended during an <c>UpdateEnvironment</c> or <c>RestartEnvironement</c> request. </li> </ul> Default:
        /// <c>Grey</c>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Green, Yellow, Red, Grey</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public EnvironmentHealth Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        // Check to see if Health property is set
        internal bool IsSetHealth()
        {
            return this.health != null;
        }

        /// <summary>
        /// The description of the AWS resources used by this environment.
        ///  
        /// </summary>
        public EnvironmentResourcesDescription Resources
        {
            get { return this.resources; }
            set { this.resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this.resources != null;
        }

        /// <summary>
        /// Describes the current tier of this environment.
        ///  
        /// </summary>
        public EnvironmentTier Tier
        {
            get { return this.tier; }
            set { this.tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this.tier != null;
        }
    }
}
