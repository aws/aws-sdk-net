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

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// This is the response object from the GetDevEnvironment operation.
    /// </summary>
    public partial class GetDevEnvironmentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The user-specified alias for the Dev Environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Max = 128)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property CreatorId. 
        /// <para>
        /// The system-generated unique ID of the user who created the Dev Environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1024)]
        public string CreatorId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorId property is set.
        /// </summary>
        internal bool IsSetCreatorId() => this.CreatorId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The system-generated unique ID of the Dev Environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Ides. 
        /// <para>
        /// Information about the integrated development environment (IDE) configured for the
        /// Dev Environment. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<Ide> Ides { get; set; } = AWSConfigs.InitializeCollections ? new List<Ide>() : null;

        /// <summary>
        /// Checks to see if the Ides property is set.
        /// </summary>
        internal bool IsSetIdes() => this.Ides != null && (this.Ides.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InactivityTimeoutMinutes. 
        /// <para>
        /// The amount of time the Dev Environment will run without any activity detected before
        /// stopping, in minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1200)]
        public int? InactivityTimeoutMinutes { get; set; }

        /// <summary>
        /// Checks to see if the InactivityTimeoutMinutes property is set.
        /// </summary>
        internal bool IsSetInactivityTimeoutMinutes() => this.InactivityTimeoutMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 instace type to use for the Dev Environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time when the Dev Environment was last updated, in coordinated universal time
        /// (UTC) timestamp format as specified in <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property PersistentStorage. 
        /// <para>
        /// Information about the amount of storage allocated to the Dev Environment. By default,
        /// a Dev Environment is configured to have 16GB of persistent storage.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PersistentStorage PersistentStorage { get; set; }

        /// <summary>
        /// Checks to see if the PersistentStorage property is set.
        /// </summary>
        internal bool IsSetPersistentStorage() => this.PersistentStorage != null;

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project in the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 63)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Checks to see if the ProjectName property is set.
        /// </summary>
        internal bool IsSetProjectName() => this.ProjectName != null;

        /// <summary>
        /// Gets and sets the property Repositories. 
        /// <para>
        /// The source repository that contains the branch cloned into the Dev Environment. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<DevEnvironmentRepositorySummary> Repositories { get; set; } = AWSConfigs.InitializeCollections ? new List<DevEnvironmentRepositorySummary>() : null;

        /// <summary>
        /// Checks to see if the Repositories property is set.
        /// </summary>
        internal bool IsSetRepositories() => this.Repositories != null && (this.Repositories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 63)]
        public string SpaceName { get; set; }

        /// <summary>
        /// Checks to see if the SpaceName property is set.
        /// </summary>
        internal bool IsSetSpaceName() => this.SpaceName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Dev Environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DevEnvironmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the status.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property VpcConnectionName. 
        /// <para>
        /// The name of the connection used to connect to Amazon VPC used when the Dev Environment
        /// was created, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string VpcConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the VpcConnectionName property is set.
        /// </summary>
        internal bool IsSetVpcConnectionName() => this.VpcConnectionName != null;
    }
}
