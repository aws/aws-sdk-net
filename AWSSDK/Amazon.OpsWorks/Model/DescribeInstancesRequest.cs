/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the DescribeInstances operation.
    /// Requests a description of a set of instances.
    /// 
    ///         <note>      
    /// <para>
    /// You must specify at least one of the parameters.
    /// </para>
    ///     </note>    
    /// <para>
    /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
    /// or Manage permissions level for the stack, or an attached       policy that explicitly
    /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class DescribeInstancesRequest : AmazonWebServiceRequest
    {
        private List<string> _instanceIds = new List<string>();
        private string _layerId;
        private string _stackId;


        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// An array of instance IDs to be described. If you use this parameter,   <code>DescribeInstances</code>
        /// returns a description of the specified instances. Otherwise, it returns      a description
        /// of every instance.
        /// </para>
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        /// <summary>
        /// Sets the InstanceIds property
        /// </summary>
        /// <param name="instanceIds">The values to add to the InstanceIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeInstancesRequest WithInstanceIds(params string[] instanceIds)
        {
            foreach (var element in instanceIds)
            {
                this._instanceIds.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the InstanceIds property
        /// </summary>
        /// <param name="instanceIds">The values to add to the InstanceIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeInstancesRequest WithInstanceIds(IEnumerable<string> instanceIds)
        {
            foreach (var element in instanceIds)
            {
                this._instanceIds.Add(element);
            }
            return this;
        }
        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && this._instanceIds.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property LayerId. 
        /// <para>
        /// A layer ID. If you use this parameter, <code>DescribeInstances</code> returns    
        ///     descriptions of the instances associated with the specified layer.
        /// </para>
        /// </summary>
        public string LayerId
        {
            get { return this._layerId; }
            set { this._layerId = value; }
        }


        /// <summary>
        /// Sets the LayerId property
        /// </summary>
        /// <param name="layerId">The value to set for the LayerId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeInstancesRequest WithLayerId(string layerId)
        {
            this._layerId = layerId;
            return this;
        }

        // Check to see if LayerId property is set
        internal bool IsSetLayerId()
        {
            return this._layerId != null;
        }


        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// A stack ID. If you use this parameter, <code>DescribeInstances</code> returns    
        ///     descriptions of the instances associated with the specified stack.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }


        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeInstancesRequest WithStackId(string stackId)
        {
            this._stackId = stackId;
            return this;
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

    }
}