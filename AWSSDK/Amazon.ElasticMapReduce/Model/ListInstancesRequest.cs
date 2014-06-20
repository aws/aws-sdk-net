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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the ListInstances operation.
    /// Provides information about the cluster instances that Amazon EMR provisions on behalf
    /// of a user when it creates the cluster.          For example, this operation indicates
    /// when the EC2 instances reach the Ready state, when instances become available to Amazon
    /// EMR to use for jobs, and the IP addresses for cluster instances, etc.
    /// </summary>
    public partial class ListInstancesRequest : AmazonWebServiceRequest
    {
        private string _clusterId;
        private string _instanceGroupId;
        private List<string> _instanceGroupTypes = new List<string>();
        private string _marker;


        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The identifier of the cluster for which to list the instances.
        /// </para>
        /// </summary>
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }


        /// <summary>
        /// Sets the ClusterId property
        /// </summary>
        /// <param name="clusterId">The value to set for the ClusterId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListInstancesRequest WithClusterId(string clusterId)
        {
            this._clusterId = clusterId;
            return this;
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }


        /// <summary>
        /// Gets and sets the property InstanceGroupId. 
        /// <para>
        /// The identifier of the instance group for which to list the instances.
        /// </para>
        /// </summary>
        public string InstanceGroupId
        {
            get { return this._instanceGroupId; }
            set { this._instanceGroupId = value; }
        }


        /// <summary>
        /// Sets the InstanceGroupId property
        /// </summary>
        /// <param name="instanceGroupId">The value to set for the InstanceGroupId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListInstancesRequest WithInstanceGroupId(string instanceGroupId)
        {
            this._instanceGroupId = instanceGroupId;
            return this;
        }

        // Check to see if InstanceGroupId property is set
        internal bool IsSetInstanceGroupId()
        {
            return this._instanceGroupId != null;
        }


        /// <summary>
        /// Gets and sets the property InstanceGroupTypes. 
        /// <para>
        /// The type of instance group for which to list the instances.
        /// </para>
        /// </summary>
        public List<string> InstanceGroupTypes
        {
            get { return this._instanceGroupTypes; }
            set { this._instanceGroupTypes = value; }
        }

        /// <summary>
        /// Sets the InstanceGroupTypes property
        /// </summary>
        /// <param name="instanceGroupTypes">The values to add to the InstanceGroupTypes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListInstancesRequest WithInstanceGroupTypes(params string[] instanceGroupTypes)
        {
            foreach (var element in instanceGroupTypes)
            {
                this._instanceGroupTypes.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the InstanceGroupTypes property
        /// </summary>
        /// <param name="instanceGroupTypes">The values to add to the InstanceGroupTypes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListInstancesRequest WithInstanceGroupTypes(IEnumerable<string> instanceGroupTypes)
        {
            foreach (var element in instanceGroupTypes)
            {
                this._instanceGroupTypes.Add(element);
            }
            return this;
        }
        // Check to see if InstanceGroupTypes property is set
        internal bool IsSetInstanceGroupTypes()
        {
            return this._instanceGroupTypes != null && this._instanceGroupTypes.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The pagination token that indicates the next set of results to retrieve.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }


        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListInstancesRequest WithMarker(string marker)
        {
            this._marker = marker;
            return this;
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}