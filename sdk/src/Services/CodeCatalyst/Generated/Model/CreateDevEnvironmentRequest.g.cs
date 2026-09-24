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
    /// Container for the parameters to the CreateDevEnvironment operation. Creates a Dev
    /// Environment in Amazon CodeCatalyst, a cloud-based development environment that you
    /// can use to quickly work on the code stored in the source repositories of your project.
    /// <note> <para> When created in the Amazon CodeCatalyst console, by default a Dev Environment
    /// is configured to have a 2 core processor, 4GB of RAM, and 16GB of persistent storage.
    /// None of these defaults apply to a Dev Environment created programmatically. </para>
    /// </note>
    /// </summary>
    public partial class CreateDevEnvironmentRequest : AmazonCodeCatalystRequest
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The user-defined alias for a Dev Environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A user-specified idempotency token. Idempotency ensures that an API request completes
        /// only once. With an idempotent request, if the original request completes successfully,
        /// the subsequent retries return the result from the original successful request and
        /// have no additional effect.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Ides. 
        /// <para>
        /// Information about the integrated development environment (IDE) configured for a Dev
        /// Environment.
        /// </para>
        ///  <note> 
        /// <para>
        /// An IDE is required to create a Dev Environment. For Dev Environment creation, this
        /// field contains configuration information and must be provided. 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<IdeConfiguration> Ides { get; set; } = AWSConfigs.InitializeCollections ? new List<IdeConfiguration>() : null;

        /// <summary>
        /// Checks to see if the Ides property is set.
        /// </summary>
        internal bool IsSetIdes() => this.Ides != null && (this.Ides.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InactivityTimeoutMinutes. 
        /// <para>
        /// The amount of time the Dev Environment will run without any activity detected before
        /// stopping, in minutes. Only whole integers are allowed. Dev Environments consume compute
        /// minutes when running.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1200)]
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
        /// Gets and sets the property PersistentStorage. 
        /// <para>
        /// Information about the amount of storage allocated to the Dev Environment. 
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, a Dev Environment is configured to have 16GB of persistent storage when
        /// created from the Amazon CodeCatalyst console, but there is no default when programmatically
        /// creating a Dev Environment. Valid values for persistent storage are based on memory
        /// sizes in 16GB increments. Valid values are 16, 32, and 64.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public PersistentStorageConfiguration PersistentStorage { get; set; }

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
        /// The source repository that contains the branch to clone into the Dev Environment.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RepositoryInput> Repositories { get; set; } = AWSConfigs.InitializeCollections ? new List<RepositoryInput>() : null;

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
        /// Gets and sets the property VpcConnectionName. 
        /// <para>
        /// The name of the connection that will be used to connect to Amazon VPC, if any.
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
