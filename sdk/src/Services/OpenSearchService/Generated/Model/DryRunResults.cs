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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Results of a dry run performed in an update domain request.
    /// </summary>
    public partial class DryRunResults
    {
        private string _deploymentType;
        private string _message;

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        ///  Specifies the way in which OpenSearch Service will apply an update. Possible values
        /// are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Blue/Green</b> - The update requires a blue/green deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DynamicUpdate</b> - No blue/green deployment required
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Undetermined</b> - The domain is in the middle of an update and can't predict
        /// the deployment type. Try again after the update is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>None</b> - The request doesn't include any configuration changes.
        /// </para>
        ///  </li> </ul>
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
        /// A message corresponding to the deployment type.
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