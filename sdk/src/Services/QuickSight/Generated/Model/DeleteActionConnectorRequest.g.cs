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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteActionConnector operation. Hard deletes
    /// an action connector, making it unrecoverable. This operation removes the connector
    /// and all its associated configurations. Any resources currently using this action connector
    /// will no longer be able to perform actions through it.
    /// </summary>
    public partial class DeleteActionConnectorRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property ActionConnectorId. 
        /// <para>
        /// The unique identifier of the action connector to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ActionConnectorId { get; set; }

        /// <summary>
        /// Checks to see if the ActionConnectorId property is set.
        /// </summary>
        internal bool IsSetActionConnectorId() => this.ActionConnectorId != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that contains the action connector to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;
    }
}
