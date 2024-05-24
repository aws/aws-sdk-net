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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A dependency that is defined for container startup and shutdown.
    /// </summary>
    public partial class AwsEcsTaskDefinitionContainerDefinitionsDependsOnDetails
    {
        private string _condition;
        private string _containerName;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The dependency condition of the dependent container. Indicates the required status
        /// of the dependent container before the current container can start. Valid values are
        /// as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COMPLETE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HEALTHY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>START</c> 
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
        /// The name of the dependent container.
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