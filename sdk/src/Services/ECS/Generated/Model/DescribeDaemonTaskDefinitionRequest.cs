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
    /// Container for the parameters to the DescribeDaemonTaskDefinition operation.
    /// Describes a daemon task definition. You can specify a <c>family</c> and <c>revision</c>
    /// to find information about a specific daemon task definition, or you can simply specify
    /// the family to find the latest <c>ACTIVE</c> revision in that family.
    /// </summary>
    public partial class DescribeDaemonTaskDefinitionRequest : AmazonECSRequest
    {
        private string _daemonTaskDefinition;

        /// <summary>
        /// Gets and sets the property DaemonTaskDefinition. 
        /// <para>
        /// The <c>family</c> for the latest <c>ACTIVE</c> revision, <c>family</c> and <c>revision</c>
        /// (<c>family:revision</c>) for a specific revision in the family, or full Amazon Resource
        /// Name (ARN) of the daemon task definition to describe.
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