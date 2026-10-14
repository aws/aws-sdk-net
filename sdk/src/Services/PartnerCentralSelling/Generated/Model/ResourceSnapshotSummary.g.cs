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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Provides a concise summary of a resource snapshot, including its unique identifier
    /// and version information. This structure is used to quickly reference and identify
    /// specific versions of resource snapshots.
    /// </summary>
    public partial class ResourceSnapshotSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the snapshot. This globally unique identifier can
        /// be used for cross-service references and in IAM policies. 
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The AWS account ID of the entity that owns the resource from which the snapshot was
        /// created.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier of the specific resource snapshotted. The format might vary depending
        /// on the ResourceType. 
        /// </para>
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceSnapshotTemplateName. 
        /// <para>
        /// The name of the template used to create the snapshot.
        /// </para>
        /// </summary>
        public string ResourceSnapshotTemplateName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSnapshotTemplateName property is set.
        /// </summary>
        internal bool IsSetResourceSnapshotTemplateName() => this.ResourceSnapshotTemplateName != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource snapshotted.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision number of the snapshot. This integer value is incremented each time the
        /// snapshot is updated, allowing for version tracking of the resource snapshot. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision.HasValue;
    }
}
