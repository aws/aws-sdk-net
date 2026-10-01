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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The details of an environment.
    /// </summary>
    public partial class EnvironmentSummary
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The identifier of the Amazon Web Services account in which an environment exists.
        /// </para>
        /// </summary>
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property AwsAccountRegion. 
        /// <para>
        /// The Amazon Web Services Region in which an environment exists.
        /// </para>
        /// </summary>
        public string AwsAccountRegion { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountRegion property is set.
        /// </summary>
        internal bool IsSetAwsAccountRegion() => this.AwsAccountRegion != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the environment was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The Amazon DataZone user who created the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which the environment exists.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentConfigurationId. 
        /// <para>
        /// The configuration ID with which the environment is created.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string EnvironmentConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentConfigurationId property is set.
        /// </summary>
        internal bool IsSetEnvironmentConfigurationId() => this.EnvironmentConfigurationId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentConfigurationName. 
        /// <para>
        /// The configuration name with which the environment is created.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string EnvironmentConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentConfigurationName property is set.
        /// </summary>
        internal bool IsSetEnvironmentConfigurationName() => this.EnvironmentConfigurationName != null;

        /// <summary>
        /// Gets and sets the property EnvironmentProfileId. 
        /// <para>
        /// The identifier of the environment profile with which the environment was created.
        /// </para>
        /// </summary>
        public string EnvironmentProfileId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentProfileId property is set.
        /// </summary>
        internal bool IsSetEnvironmentProfileId() => this.EnvironmentProfileId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the environment.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The identifier of the project in which the environment exists.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Checks to see if the ProjectId property is set.
        /// </summary>
        internal bool IsSetProjectId() => this.ProjectId != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the environment.
        /// </para>
        /// </summary>
        public EnvironmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the environment was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
