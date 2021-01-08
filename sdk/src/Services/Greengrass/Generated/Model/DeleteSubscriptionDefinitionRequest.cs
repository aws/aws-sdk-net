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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteSubscriptionDefinition operation.
    /// Deletes a subscription definition.
    /// </summary>
    public partial class DeleteSubscriptionDefinitionRequest : AmazonGreengrassRequest
    {
        private string _subscriptionDefinitionId;

        /// <summary>
        /// Gets and sets the property SubscriptionDefinitionId. The ID of the subscription definition.
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubscriptionDefinitionId
        {
            get { return this._subscriptionDefinitionId; }
            set { this._subscriptionDefinitionId = value; }
        }

        // Check to see if SubscriptionDefinitionId property is set
        internal bool IsSetSubscriptionDefinitionId()
        {
            return this._subscriptionDefinitionId != null;
        }

    }
}