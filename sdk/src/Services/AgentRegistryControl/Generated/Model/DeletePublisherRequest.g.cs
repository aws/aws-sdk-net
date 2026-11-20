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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// Container for the parameters to the DeletePublisher operation. Delete a publisher.
    /// A successful call returns an empty response. You can't delete a publisher that has
    /// registry record associations; disassociate every registry record from it first. The
    /// request fails with ConflictException while the publisher has associations or another
    /// delete is in progress. Association removals can take a few seconds to be reflected,
    /// so a delete that follows a disassociation can briefly fail with ConflictException;
    /// retry after a short wait. If the publisher ARN names your account and the publisher
    /// doesn't exist, the request fails with ResourceNotFoundException.
    /// </summary>
    public partial class DeletePublisherRequest : AmazonAgentRegistryControlRequest
    {
        /// <summary>
        /// Gets and sets the property PublisherArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PublisherArn { get; set; }

        /// <summary>
        /// Checks to see if the PublisherArn property is set.
        /// </summary>
        internal bool IsSetPublisherArn() => this.PublisherArn != null;
    }
}
