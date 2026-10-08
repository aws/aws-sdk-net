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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// Container for the parameters to the GetResourceDashboard operation. Returns a URL
    /// that you can use to access the application UIs for a specified resource, such as a
    /// session. <para> For resources in a running state, the application UI is a live user
    /// interface such as the Spark web UI. For terminated resources, the application UI is
    /// a persistent application user interface such as the Spark History Server. </para>
    /// <note> <para> The URL is valid for one hour after you generate it. To access the application
    /// UI after that hour elapses, you must invoke the API again to generate a new URL. </para>
    /// </note>
    /// </summary>
    public partial class GetResourceDashboardRequest : AmazonEMRServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property AccessSystemProfileLogs. 
        /// <para>
        /// Allows access to system profile logs for Lake Formation-enabled sessions. Default
        /// is false.
        /// </para>
        /// </summary>
        public bool? AccessSystemProfileLogs { get; set; }

        /// <summary>
        /// Checks to see if the AccessSystemProfileLogs property is set.
        /// </summary>
        internal bool IsSetAccessSystemProfileLogs() => this.AccessSystemProfileLogs.HasValue;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application that the resource belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource to access the dashboard for. Currently, only <c>Session</c> is
        /// supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
