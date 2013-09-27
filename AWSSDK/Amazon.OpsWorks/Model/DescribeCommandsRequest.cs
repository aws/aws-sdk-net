/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeCommands operation.
    /// <para>Describes the results of specified commands.</para> <para><b>NOTE:</b>You must specify at least one of the parameters.</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeCommands"/>
    public class DescribeCommandsRequest : AmazonWebServiceRequest
    {
        private string deploymentId;
        private string instanceId;
        private List<string> commandIds = new List<string>();

        /// <summary>
        /// The deployment ID. If you include this parameter, <c>DescribeCommands</c> returns a description of the commands associated with the
        /// specified deployment.
        ///  
        /// </summary>
        public string DeploymentId
        {
            get { return this.deploymentId; }
            set { this.deploymentId = value; }
        }

        /// <summary>
        /// Sets the DeploymentId property
        /// </summary>
        /// <param name="deploymentId">The value to set for the DeploymentId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCommandsRequest WithDeploymentId(string deploymentId)
        {
            this.deploymentId = deploymentId;
            return this;
        }
            

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this.deploymentId != null;
        }

        /// <summary>
        /// The instance ID. If you include this parameter, <c>DescribeCommands</c> returns a description of the commands associated with the specified
        /// instance.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The value to set for the InstanceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCommandsRequest WithInstanceId(string instanceId)
        {
            this.instanceId = instanceId;
            return this;
        }
            

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// An array of command IDs. If you include this parameter, <c>DescribeCommands</c> returns a description of the specified commands. Otherwise,
        /// it returns a description of every command.
        ///  
        /// </summary>
        public List<string> CommandIds
        {
            get { return this.commandIds; }
            set { this.commandIds = value; }
        }
        /// <summary>
        /// Adds elements to the CommandIds collection
        /// </summary>
        /// <param name="commandIds">The values to add to the CommandIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCommandsRequest WithCommandIds(params string[] commandIds)
        {
            foreach (string element in commandIds)
            {
                this.commandIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the CommandIds collection
        /// </summary>
        /// <param name="commandIds">The values to add to the CommandIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCommandsRequest WithCommandIds(IEnumerable<string> commandIds)
        {
            foreach (string element in commandIds)
            {
                this.commandIds.Add(element);
            }

            return this;
        }

        // Check to see if CommandIds property is set
        internal bool IsSetCommandIds()
        {
            return this.commandIds.Count > 0;
        }
    }
}
    
