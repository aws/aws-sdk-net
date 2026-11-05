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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the API operation.
    /// </summary>
    public partial class Operation
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the operation was initialized (<c>1479816991.349</c>).
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code.
        /// </para>
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// The error details.
        /// </para>
        /// </summary>
        public string ErrorDetails { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetails property is set.
        /// </summary>
        internal bool IsSetErrorDetails() => this.ErrorDetails != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the operation.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IsTerminal. 
        /// <para>
        /// A Boolean value indicating whether the operation is terminal.
        /// </para>
        /// </summary>
        public bool? IsTerminal { get; set; }

        /// <summary>
        /// Checks to see if the IsTerminal property is set.
        /// </summary>
        internal bool IsSetIsTerminal() => this.IsTerminal.HasValue;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The Amazon Web Services Region and Availability Zone.
        /// </para>
        /// </summary>
        public ResourceLocation Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property OperationDetails. 
        /// <para>
        /// Details about the operation (<c>Debian-1GB-Ohio-1</c>).
        /// </para>
        /// </summary>
        public string OperationDetails { get; set; }

        /// <summary>
        /// Checks to see if the OperationDetails property is set.
        /// </summary>
        internal bool IsSetOperationDetails() => this.OperationDetails != null;

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// The type of operation. 
        /// </para>
        /// </summary>
        public OperationType OperationType { get; set; }

        /// <summary>
        /// Checks to see if the OperationType property is set.
        /// </summary>
        internal bool IsSetOperationType() => this.OperationType != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The resource name.
        /// </para>
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type. 
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the operation. 
        /// </para>
        /// </summary>
        public OperationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusChangedAt. 
        /// <para>
        /// The timestamp when the status was changed (<c>1479816991.349</c>).
        /// </para>
        /// </summary>
        public DateTime? StatusChangedAt { get; set; }

        /// <summary>
        /// Checks to see if the StatusChangedAt property is set.
        /// </summary>
        internal bool IsSetStatusChangedAt() => this.StatusChangedAt.HasValue;
    }
}
