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
    /// Container for the parameters to the DescribeDaemonRevisions operation.
    /// Describes one or more of your daemon revisions.
    /// 
    ///  
    /// <para>
    /// A daemon revision is a snapshot of a daemon's configuration at the time a deployment
    /// was initiated. It captures the daemon task definition, container images, tag propagation,
    /// and execute command settings. Daemon revisions are immutable.
    /// </para>
    /// </summary>
    public partial class DescribeDaemonRevisionsRequest : AmazonECSRequest
    {
        private List<string> _daemonRevisionArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DaemonRevisionArns. 
        /// <para>
        /// The ARN of the daemon revisions to describe. You can specify up to 20 ARNs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> DaemonRevisionArns
        {
            get { return this._daemonRevisionArns; }
            set { this._daemonRevisionArns = value; }
        }

        // Check to see if DaemonRevisionArns property is set
        internal bool IsSetDaemonRevisionArns()
        {
            return this._daemonRevisionArns != null && (this._daemonRevisionArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}