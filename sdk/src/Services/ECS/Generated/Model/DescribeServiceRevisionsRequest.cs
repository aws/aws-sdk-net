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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeServiceRevisions operation.
    /// Describes one or more service revisions.
    /// 
    ///  
    /// <para>
    /// A service revision is a version of the service that includes the values for the Amazon
    /// ECS resources (for example, task definition) and the environment resources (for example,
    /// load balancers, subnets, and security groups). For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-revision.html">Amazon
    /// ECS service revisions</a>.
    /// </para>
    ///  
    /// <para>
    /// You can't describe a service revision that was created before October 25, 2024.
    /// </para>
    /// </summary>
    public partial class DescribeServiceRevisionsRequest : AmazonECSRequest
    {
        private List<string> _serviceRevisionArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ServiceRevisionArns. 
        /// <para>
        /// The ARN of the service revision. 
        /// </para>
        ///  
        /// <para>
        /// You can specify a maximum of 20 ARNs.
        /// </para>
        ///  
        /// <para>
        /// You can call <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ListServiceDeployments.html">ListServiceDeployments</a>
        /// to get the ARNs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ServiceRevisionArns
        {
            get { return this._serviceRevisionArns; }
            set { this._serviceRevisionArns = value; }
        }

        // Check to see if ServiceRevisionArns property is set
        internal bool IsSetServiceRevisionArns()
        {
            return this._serviceRevisionArns != null && (this._serviceRevisionArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}