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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDevEnvironment operation.
    /// Creates a Dev Environment in Amazon CodeCatalyst, a cloud-based development Dev Environment
    /// that you can use to quickly work on the code stored in the source repositories of
    /// your project. By default, a Dev Environment is configured to have a 2 core processor,
    /// 4GB of RAM, and 16GB of persistent storage.
    /// </summary>
    public partial class CreateDevEnvironmentRequest : AmazonCodeCatalystRequest
    {
        private string _alias;
        private string _clientToken;
        private List<IdeConfiguration> _ides = new List<IdeConfiguration>();
        private int? _inactivityTimeoutMinutes;
        private InstanceType _instanceType;
        private PersistentStorageConfiguration _persistentStorage;
        private string _projectName;
        private List<RepositoryInput> _repositories = new List<RepositoryInput>();
        private string _spaceName;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The user-defined alias for a Dev Environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A user-specified idempotency token. Idempotency ensures that an API request completes
        /// only once. With an idempotent request, if the original request completes successfully,
        /// the subsequent retries return the result from the original successful request and
        /// have no additional effect.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

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
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<IdeConfiguration> Ides
        {
            get { return this._ides; }
            set { this._ides = value; }
        }

        // Check to see if Ides property is set
        internal bool IsSetIdes()
        {
            return this._ides != null && this._ides.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InactivityTimeoutMinutes. 
        /// <para>
        /// The amount of time the Dev Environment will run without any activity detected before
        /// stopping, in minutes. Only whole integers are allowed. Dev Environments consume compute
        /// minutes when running.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1200)]
        public int InactivityTimeoutMinutes
        {
            get { return this._inactivityTimeoutMinutes.GetValueOrDefault(); }
            set { this._inactivityTimeoutMinutes = value; }
        }

        // Check to see if InactivityTimeoutMinutes property is set
        internal bool IsSetInactivityTimeoutMinutes()
        {
            return this._inactivityTimeoutMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 instace type to use for the Dev Environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property PersistentStorage. 
        /// <para>
        /// Information about the amount of storage allocated to the Dev Environment. By default,
        /// a Dev Environment is configured to have 16GB of persistent storage.
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid values for persistent storage are based on memory sizes in 16GB increments.
        /// Valid values are 16, 32, and 64.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public PersistentStorageConfiguration PersistentStorage
        {
            get { return this._persistentStorage; }
            set { this._persistentStorage = value; }
        }

        // Check to see if PersistentStorage property is set
        internal bool IsSetPersistentStorage()
        {
            return this._persistentStorage != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project in the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

        /// <summary>
        /// Gets and sets the property Repositories. 
        /// <para>
        /// The source repository that contains the branch to clone into the Dev Environment.
        /// 
        /// </para>
        /// </summary>
        public List<RepositoryInput> Repositories
        {
            get { return this._repositories; }
            set { this._repositories = value; }
        }

        // Check to see if Repositories property is set
        internal bool IsSetRepositories()
        {
            return this._repositories != null && this._repositories.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SpaceName. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string SpaceName
        {
            get { return this._spaceName; }
            set { this._spaceName = value; }
        }

        // Check to see if SpaceName property is set
        internal bool IsSetSpaceName()
        {
            return this._spaceName != null;
        }

    }
}