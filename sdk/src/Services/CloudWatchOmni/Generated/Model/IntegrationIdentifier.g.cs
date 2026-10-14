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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Identifies a single integration by exactly one of its unique keys: the integration
    /// id, the integration ARN, or the integration name.
    /// </summary>
    public partial class IntegrationIdentifier
    {
        /// <summary>
        /// Gets and sets the property IntegrationArn. The Amazon Resource Name of the integration.
        /// </summary>
        public string IntegrationArn { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationArn property is set.
        /// </summary>
        internal bool IsSetIntegrationArn() => this.IntegrationArn != null;

        /// <summary>
        /// Gets and sets the property IntegrationId. The unique identifier of the integration.
        /// </summary>
        public string IntegrationId { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationId property is set.
        /// </summary>
        internal bool IsSetIntegrationId() => this.IntegrationId != null;

        /// <summary>
        /// Gets and sets the property IntegrationName. The name of the integration; unique within
        /// the account.
        /// </summary>
        public string IntegrationName { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationName property is set.
        /// </summary>
        internal bool IsSetIntegrationName() => this.IntegrationName != null;
    }
}
