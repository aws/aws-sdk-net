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

namespace Amazon.APIPortal.Model
{
    /// <summary>
    /// Container for the parameters to the StopDiscovery operation. Stops the running API
    /// discovery process.
    /// </summary>
    public partial class StopDiscoveryRequest : AmazonAPIPortalRequest
    {
        /// <summary>
        /// Gets and sets the property Id. Identifier of the discovery configuration to stop.
        /// Required. Today this is the configuration ARN, which carries the owner account id
        /// so a delegated admin or org admin can stop an org-scoped configuration that lives
        /// in a different account.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;
    }
}
