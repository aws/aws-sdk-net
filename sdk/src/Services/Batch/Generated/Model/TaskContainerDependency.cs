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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// A list of containers that this task depends on.
    /// </summary>
    public partial class TaskContainerDependency
    {
        private string _condition;
        private string _containerName;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The dependency condition of the container. The following are the available conditions
        /// and their behavior:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>START</c> - This condition emulates the behavior of links and volumes today. It
        /// validates that a dependent container is started before permitting other containers
        /// to start. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETE</c> - This condition validates that a dependent container runs to completion
        /// (exits) before permitting other containers to start. This can be useful for nonessential
        /// containers that run a script and then exit. This condition can't be set on an essential
        /// container. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESS</c> - This condition is the same as <c>COMPLETE</c>, but it also requires
        /// that the container exits with a zero status. This condition can't be set on an essential
        /// container. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// A unique identifier for the container.
        /// </para>
        /// </summary>
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }

        // Check to see if ContainerName property is set
        internal bool IsSetContainerName()
        {
            return this._containerName != null;
        }

    }
}