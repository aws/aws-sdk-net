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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DryRunResults
    {
        private string _deploymentType;
        private string _message;

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        ///  Specifies the deployment mechanism through which the update shall be applied on the
        /// domain. Possible responses are <c>Blue/Green</c> (The update will require a blue/green
        /// deployment.) <c>DynamicUpdate</c> (The update can be applied in-place without a Blue/Green
        /// deployment required.) <c>Undetermined</c> (The domain is undergoing an update which
        /// needs to complete before the deployment type can be predicted.) <c>None</c> (The configuration
        /// change matches the current configuration and will not result in any update.) 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=128)]
        public string DeploymentType
        {
            get { return this._deploymentType; }
            set { this._deploymentType = value; }
        }

        // Check to see if DeploymentType property is set
        internal bool IsSetDeploymentType()
        {
            return this._deploymentType != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Contains an optional message associated with the DryRunResults.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}