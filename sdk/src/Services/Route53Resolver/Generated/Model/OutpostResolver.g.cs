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

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// A complex type that contains settings for an existing Resolver on an Outpost.
    /// </summary>
    public partial class OutpostResolver
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN (Amazon Resource Name) for the Resolver on an Outpost.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the Outpost Resolver was created, in Unix time format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 40)]
        public string CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime != null;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request that created the Resolver endpoint. The
        /// <c>CreatorRequestId</c> allows failed requests to be retried without the risk of running
        /// the operation twice.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CreatorRequestId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorRequestId property is set.
        /// </summary>
        internal bool IsSetCreatorRequestId() => this.CreatorRequestId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the Resolver on Outpost.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// Amazon EC2 instance count for the Resolver on the Outpost.
        /// </para>
        /// </summary>
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property ModificationTime. 
        /// <para>
        /// The date and time that the Outpost Resolver was modified, in Unix time format and
        /// Coordinated Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 40)]
        public string ModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the ModificationTime property is set.
        /// </summary>
        internal bool IsSetModificationTime() => this.ModificationTime != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the Resolver.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) for the Outpost.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string OutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the OutpostArn property is set.
        /// </summary>
        internal bool IsSetOutpostArn() => this.OutpostArn != null;

        /// <summary>
        /// Gets and sets the property PreferredInstanceType. 
        /// <para>
        ///  The Amazon EC2 instance type. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string PreferredInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the PreferredInstanceType property is set.
        /// </summary>
        internal bool IsSetPreferredInstanceType() => this.PreferredInstanceType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the Resolver.
        /// </para>
        /// </summary>
        public OutpostResolverStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A detailed description of the Resolver.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
