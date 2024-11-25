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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeContainerGroupDefinition operation.
    /// Retrieves the properties of a container group definition, including all container
    /// definitions in the group. 
    /// 
    ///  
    /// <para>
    ///  <b>Request options:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Retrieve the latest version of a container group definition. Specify the container
    /// group definition name only, or use an ARN value without a version number.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Retrieve a particular version. Specify the container group definition name and a version
    /// number, or use an ARN value that includes the version number.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Results:</b> 
    /// </para>
    ///  
    /// <para>
    /// If successful, this operation returns the complete properties of a container group
    /// definition version.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/containers-create-groups.html">Manage
    /// a container group definition</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeContainerGroupDefinitionRequest : AmazonGameLiftRequest
    {
        private string _name;
        private int? _versionNumber;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique identifier for the container group definition to retrieve properties for.
        /// You can use either the <c>Name</c> or <c>ARN</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The specific version to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? VersionNumber
        {
            get { return this._versionNumber; }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}