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
    /// Container for the parameters to the DeleteDaemonTaskDefinition operation.
    /// Deletes the specified daemon task definition. After a daemon task definition is deleted,
    /// no new daemons can be created using this definition. Existing daemons that reference
    /// the deleted daemon task definition continue to run.
    /// 
    ///  
    /// <para>
    /// A daemon task definition must be in an <c>ACTIVE</c> state to be deleted.
    /// </para>
    /// </summary>
    public partial class DeleteDaemonTaskDefinitionRequest : AmazonECSRequest
    {
        private string _daemonTaskDefinition;

        /// <summary>
        /// Gets and sets the property DaemonTaskDefinition. 
        /// <para>
        /// The <c>family</c> and <c>revision</c> (<c>family:revision</c>) or full Amazon Resource
        /// Name (ARN) of the daemon task definition to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DaemonTaskDefinition
        {
            get { return this._daemonTaskDefinition; }
            set { this._daemonTaskDefinition = value; }
        }

        // Check to see if DaemonTaskDefinition property is set
        internal bool IsSetDaemonTaskDefinition()
        {
            return this._daemonTaskDefinition != null;
        }

    }
}