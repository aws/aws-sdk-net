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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Contains docker server information.
    /// </summary>
    public partial class DockerServer
    {
        private ComputeType _computeType;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DockerServerStatus _status;

        /// <summary>
        /// Gets and sets the property ComputeType. 
        /// <para>
        /// Information about the compute resources the docker server uses. Available values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_SMALL</c>: Use up to 4 GiB memory and 2 vCPUs for your docker server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_MEDIUM</c>: Use up to 8 GiB memory and 4 vCPUs for your docker
        /// server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_LARGE</c>: Use up to 16 GiB memory and 8 vCPUs for your docker
        /// server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_XLARGE</c>: Use up to 64 GiB memory and 32 vCPUs for your docker
        /// server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_2XLARGE</c>: Use up to 128 GiB memory and 64 vCPUs for your docker
        /// server.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComputeType ComputeType
        {
            get { return this._computeType; }
            set { this._computeType = value; }
        }

        // Check to see if ComputeType property is set
        internal bool IsSetComputeType()
        {
            return this._computeType != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of one or more security groups IDs.
        /// </para>
        ///  <note> 
        /// <para>
        /// Security groups configured for Docker servers should allow ingress network traffic
        /// from the VPC configured in the project. They should allow ingress on port 9876.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A DockerServerStatus object to use for this docker server.
        /// </para>
        /// </summary>
        public DockerServerStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}