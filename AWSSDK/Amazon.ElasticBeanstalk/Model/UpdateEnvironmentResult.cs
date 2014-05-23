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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Describes the properties of an environment.
    /// </summary>
    public partial class UpdateEnvironmentResult
    {
        private string _applicationName;
        private string _cNAME;
        private DateTime? _dateCreated;
        private DateTime? _dateUpdated;
        private string _description;
        private string _endpointURL;
        private string _environmentId;
        private string _environmentName;
        private string _health;
        private EnvironmentResourcesDescription _resources;
        private string _solutionStackName;
        private string _status;
        private string _templateName;
        private EnvironmentTier _tier;
        private string _versionLabel;


        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application associated with this environment.
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }


        /// <summary>
        /// Sets the ApplicationName property
        /// </summary>
        /// <param name="applicationName">The value to set for the ApplicationName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateEnvironmentResult WithApplicationName(string applicationName)
        {
            this._applicationName = applicationName;
            return this;
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }


        /// <summary>
        /// Gets and sets the property CNAME. 
        /// <para>
        ///          The URL to the CNAME for this environment.      
        /// </para>
        /// </summary>
        public string CNAME
        {
            get { return this._cNAME; }
            set { this._cNAME = value; }
        }


        /// <summary>
        /// Sets the CNAME property
        /// </summary>
        /// <param name="cNAME">The value to set for the CNAME property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateEnvironmentResult WithCNAME(string cNAME)
        {
            this._cNAME = cNAME;
            return this;
        }

        // Check to see if CNAME property is set
        internal bool IsSetCNAME()
        {
            return this._cNAME != null;
        }


        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The creation date for this environment.
        /// </para>
        /// </summary>
        public DateTime DateCreated
        {
            get { return this._dateCreated.GetValueOrDefault(); }
            set { this._dateCreated = value; }
        }


        /// <summary>
        /// Sets the DateCreated property
        /// </summary>
        /// <param name="dateCreated">The value to set for the DateCreated property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateEnvironmentResult WithDateCreated(DateTime dateCreated)
        {
            this._dateCreated = dateCreated;
            return this;
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property DateUpdated. 
        /// <para>
        /// The last modified date for this environment.
        /// </para>
        /// </summary>
        public DateTime DateUpdated
        {
            get { return this._dateUpdated.GetValueOrDefault(); }
            set { this._dateUpdated = value; }
        }


        /// <summary>
        /// Sets the DateUpdated property
        /// </summary>
        /// <param name="dateUpdated">The value to set for the DateUpdated property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateEnvironmentResult WithDateUpdated(DateTime dateUpdated)
        {
            this._dateUpdated = dateUpdated;
            return this;
        }

        // Check to see if DateUpdated property is set
        internal bool IsSetDateUpdated()
        {
            return this._dateUpdated.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Describes this environment.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }


        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateEnvironmentResult WithDescription(string description)
        {
            this._description = description;
            return this;
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }


        /// <summary>
        /// Gets and sets the property EndpointURL. 
        /// <para>
        /// For load-balanced, autoscaling environments, the URL to the LoadBalancer. For single-instance
        /// environments, the IP address of the instance.
        /// </para>
        /// </summary>
        public string EndpointURL
        {
            get { return this._endpointURL; }
            set { this._endpointURL = value; }
        }


        /// <summary>
        /// Sets the EndpointURL property
        /// </summary>
        /// <param name="endpointURL">The value to set for the EndpointURL property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateEnvironmentResult WithEndpointURL(string endpointURL)
        {
            this._endpointURL = endpointURL;
            return this;
        }

        // Check to see if EndpointURL property is set
        internal bool IsSetEndpointURL()
        {
            return this._endpointURL != null;
        }


        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        ///          The ID of this environment.      
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }


        /// <summary>
        /// Sets the EnvironmentId property
        /// </summary>
        /// <param name="environmentId">The value to set for the EnvironmentId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateEnvironmentResult WithEnvironmentId(string environmentId)
        {
            this._environmentId = environmentId;
            return this;
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }


        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of this environment.
        /// </para>
        /// </summary>
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }


        /// <summary>
        /// Sets the EnvironmentName property
        /// </summary>
        /// <param name="environmentName">The value to set for the EnvironmentName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateEnvironmentResult WithEnvironmentName(string environmentName)
        {
            this._environmentName = environmentName;
            return this;
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }


        /// <summary>
        /// Gets and sets the property Health. 
        /// <para>
        ///          Describes the health status of the environment.             AWS Elastic Beanstalk
        ///         indicates the failure levels for a running environment:      
        /// </para>
        ///       <enumValues>         <value name="Red">            
        /// <para>
        ///                <code>Red</code>               : Indicates the environment is not working.
        ///            
        /// </para>
        ///          </value>         <value name="Yellow">            
        /// <para>
        ///                <code>Yellow</code>: Indicates that something is wrong, the application
        ///               might not be available, but the instances appear running.          
        ///  
        /// </para>
        ///          </value>         <value name="Green">            
        /// <para>
        ///                <code>Green</code>: Indicates the environment is               healthy
        /// and fully functional.            
        /// </para>
        ///          </value>      </enumValues>      <ul>         <li>            <code>Red</code>:
        /// Indicates the environment is not responsive. Occurs when three or            more
        ///            consecutive failures occur for an environment.         </li>         <li>
        ///            <code>Yellow</code>: Indicates that something is wrong. Occurs when two
        ///            consecutive failures occur for an environment.         </li>         <li>
        ///            <code>Green</code>: Indicates the environment is            healthy and
        /// fully functional.         </li>         <li>              <code>Grey</code>: Default
        /// health for a new environment. The environment            is not fully launched and
        /// health checks have not started or health checks            are suspended during an
        ///            <code>UpdateEnvironment</code>            or            <code>RestartEnvironement</code>
        ///            request.         </li>      </ul>      
        /// <para>
        ///          Default: <code>Grey</code>      
        /// </para>
        /// </summary>
        public string Health
        {
            get { return this._health; }
            set { this._health = value; }
        }


        /// <summary>
        /// Sets the Health property
        /// </summary>
        /// <param name="health">The value to set for the Health property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateEnvironmentResult WithHealth(string health)
        {
            this._health = health;
            return this;
        }

        // Check to see if Health property is set
        internal bool IsSetHealth()
        {
            return this._health != null;
        }


        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The description of the AWS resources used by this environment.
        /// </para>
        /// </summary>
        public EnvironmentResourcesDescription Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }


        /// <summary>
        /// Sets the Resources property
        /// </summary>
        /// <param name="resources">The value to set for the Resources property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateEnvironmentResult WithResources(EnvironmentResourcesDescription resources)
        {
            this._resources = resources;
            return this;
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null;
        }


        /// <summary>
        /// Gets and sets the property SolutionStackName. 
        /// <para>
        ///          The name of the         <code>SolutionStack</code>         deployed with
        /// this environment.      
        /// </para>
        /// </summary>
        public string SolutionStackName
        {
            get { return this._solutionStackName; }
            set { this._solutionStackName = value; }
        }


        /// <summary>
        /// Sets the SolutionStackName property
        /// </summary>
        /// <param name="solutionStackName">The value to set for the SolutionStackName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateEnvironmentResult WithSolutionStackName(string solutionStackName)
        {
            this._solutionStackName = solutionStackName;
            return this;
        }

        // Check to see if SolutionStackName property is set
        internal bool IsSetSolutionStackName()
        {
            return this._solutionStackName != null;
        }


        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///          The current operational status of the environment:        
        /// </para>
        ///       <ul>         <li>            <code>Launching</code>: Environment is in the process
        /// of            initial deployment.         </li>         <li>            <code>Updating</code>:
        /// Environment is in the process of            updating its configuration settings or
        ///            application version.         </li>         <li>            <code>Ready</code>:
        /// Environment is available to have an action            performed on it, such as update
        /// or terminate.         </li>         <li>            <code>Terminating</code>: Environment
        /// is in the shut-down process.         </li>         <li>            <code>Terminated</code>:
        /// Environment is not running.         </li>      </ul>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }


        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateEnvironmentResult WithStatus(string status)
        {
            this._status = status;
            return this;
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }


        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        ///          The name of the configuration template used to         originally launch
        /// this         environment.      
        /// </para>
        /// </summary>
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }


        /// <summary>
        /// Sets the TemplateName property
        /// </summary>
        /// <param name="templateName">The value to set for the TemplateName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateEnvironmentResult WithTemplateName(string templateName)
        {
            this._templateName = templateName;
            return this;
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }


        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// Describes the current tier of this environment.
        /// </para>
        /// </summary>
        public EnvironmentTier Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }


        /// <summary>
        /// Sets the Tier property
        /// </summary>
        /// <param name="tier">The value to set for the Tier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateEnvironmentResult WithTier(EnvironmentTier tier)
        {
            this._tier = tier;
            return this;
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }


        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// The application version deployed in this environment.
        /// </para>
        /// </summary>
        public string VersionLabel
        {
            get { return this._versionLabel; }
            set { this._versionLabel = value; }
        }


        /// <summary>
        /// Sets the VersionLabel property
        /// </summary>
        /// <param name="versionLabel">The value to set for the VersionLabel property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateEnvironmentResult WithVersionLabel(string versionLabel)
        {
            this._versionLabel = versionLabel;
            return this;
        }

        // Check to see if VersionLabel property is set
        internal bool IsSetVersionLabel()
        {
            return this._versionLabel != null;
        }

    }
}