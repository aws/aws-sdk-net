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
    /// Container for the parameters to the ListInstanceGroups operation.
    /// Provides all available details about the instance groups in a cluster.
    /// </summary>
    public partial class ListInstanceGroupsRequest : AmazonWebServiceRequest
    {
        private string _clusterId;
        private string _marker;


        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The identifier of the cluster for which to list the instance groups.
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
        public ListInstanceGroupsRequest WithClusterId(string clusterId)
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
        public ListInstanceGroupsRequest WithMarker(string marker)
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