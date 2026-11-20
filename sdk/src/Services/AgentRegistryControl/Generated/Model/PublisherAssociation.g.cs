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
    /// An association between a registry record and a publisher, including the record's public
    /// identifier.
    /// </summary>
    public partial class PublisherAssociation
    {
        /// <summary>
        /// Gets and sets the property PublicIdentifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string PublicIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the PublicIdentifier property is set.
        /// </summary>
        internal bool IsSetPublicIdentifier() => this.PublicIdentifier != null;

        /// <summary>
        /// Gets and sets the property Publisher.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Publisher { get; set; }

        /// <summary>
        /// Checks to see if the Publisher property is set.
        /// </summary>
        internal bool IsSetPublisher() => this.Publisher != null;

        /// <summary>
        /// Gets and sets the property RecordArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RecordArn { get; set; }

        /// <summary>
        /// Checks to see if the RecordArn property is set.
        /// </summary>
        internal bool IsSetRecordArn() => this.RecordArn != null;

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        [AWSProperty(Required = true)]
        public AssociationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. The reason for the association's current
        /// status, such as why it is suspended. Present only when a reason is available.
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
