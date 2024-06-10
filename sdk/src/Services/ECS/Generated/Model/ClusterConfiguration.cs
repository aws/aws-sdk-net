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
    /// The execute command and managed storage configuration for the cluster.
    /// </summary>
    public partial class ClusterConfiguration
    {
        private ExecuteCommandConfiguration _executeCommandConfiguration;
        private ManagedStorageConfiguration _managedStorageConfiguration;

        /// <summary>
        /// Gets and sets the property ExecuteCommandConfiguration. 
        /// <para>
        /// The details of the execute command configuration.
        /// </para>
        /// </summary>
        public ExecuteCommandConfiguration ExecuteCommandConfiguration
        {
            get { return this._executeCommandConfiguration; }
            set { this._executeCommandConfiguration = value; }
        }

        // Check to see if ExecuteCommandConfiguration property is set
        internal bool IsSetExecuteCommandConfiguration()
        {
            return this._executeCommandConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedStorageConfiguration. 
        /// <para>
        /// The details of the managed storage configuration.
        /// </para>
        /// </summary>
        public ManagedStorageConfiguration ManagedStorageConfiguration
        {
            get { return this._managedStorageConfiguration; }
            set { this._managedStorageConfiguration = value; }
        }

        // Check to see if ManagedStorageConfiguration property is set
        internal bool IsSetManagedStorageConfiguration()
        {
            return this._managedStorageConfiguration != null;
        }

    }
}