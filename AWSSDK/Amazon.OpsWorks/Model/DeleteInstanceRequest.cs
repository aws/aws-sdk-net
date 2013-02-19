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
    /// Container for the parameters to the DeleteInstance operation.
    /// <para>Deletes a specified instance.</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteInstance"/>
    public class DeleteInstanceRequest : AmazonWebServiceRequest
    {
        private string instanceId;
        private bool? deleteElasticIp;
        private bool? deleteVolumes;

        /// <summary>
        /// The instance ID.
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
        public DeleteInstanceRequest WithInstanceId(string instanceId)
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
        /// Whether to delete the instance Elastic IP address.
        ///  
        /// </summary>
        public bool DeleteElasticIp
        {
            get { return this.deleteElasticIp ?? default(bool); }
            set { this.deleteElasticIp = value; }
        }

        /// <summary>
        /// Sets the DeleteElasticIp property
        /// </summary>
        /// <param name="deleteElasticIp">The value to set for the DeleteElasticIp property </param>
        /// <returns>this instance</returns>
        public DeleteInstanceRequest WithDeleteElasticIp(bool deleteElasticIp)
        {
            this.deleteElasticIp = deleteElasticIp;
            return this;
        }
            

        // Check to see if DeleteElasticIp property is set
        internal bool IsSetDeleteElasticIp()
        {
            return this.deleteElasticIp.HasValue;
        }

        /// <summary>
        /// Whether to delete the instance Amazon EBS volumes.
        ///  
        /// </summary>
        public bool DeleteVolumes
        {
            get { return this.deleteVolumes ?? default(bool); }
            set { this.deleteVolumes = value; }
        }

        /// <summary>
        /// Sets the DeleteVolumes property
        /// </summary>
        /// <param name="deleteVolumes">The value to set for the DeleteVolumes property </param>
        /// <returns>this instance</returns>
        public DeleteInstanceRequest WithDeleteVolumes(bool deleteVolumes)
        {
            this.deleteVolumes = deleteVolumes;
            return this;
        }
            

        // Check to see if DeleteVolumes property is set
        internal bool IsSetDeleteVolumes()
        {
            return this.deleteVolumes.HasValue;
        }
    }
}
    
