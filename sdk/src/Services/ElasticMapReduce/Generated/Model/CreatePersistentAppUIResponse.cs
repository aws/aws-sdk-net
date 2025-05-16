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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// This is the response object from the CreatePersistentAppUI operation.
    /// </summary>
    public partial class CreatePersistentAppUIResponse : AmazonWebServiceResponse
    {
        private string _persistentAppUIId;
        private bool? _runtimeRoleEnabledCluster;

        /// <summary>
        /// Gets and sets the property PersistentAppUIId. 
        /// <para>
        /// The persistent application user interface identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string PersistentAppUIId
        {
            get { return this._persistentAppUIId; }
            set { this._persistentAppUIId = value; }
        }

        // Check to see if PersistentAppUIId property is set
        internal bool IsSetPersistentAppUIId()
        {
            return this._persistentAppUIId != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeRoleEnabledCluster. 
        /// <para>
        /// Represents if the EMR on EC2 cluster that the persisent application user interface
        /// is created for is a runtime role enabled cluster or not.
        /// </para>
        /// </summary>
        public bool? RuntimeRoleEnabledCluster
        {
            get { return this._runtimeRoleEnabledCluster; }
            set { this._runtimeRoleEnabledCluster = value; }
        }

        // Check to see if RuntimeRoleEnabledCluster property is set
        internal bool IsSetRuntimeRoleEnabledCluster()
        {
            return this._runtimeRoleEnabledCluster.HasValue; 
        }

    }
}