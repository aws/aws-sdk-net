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

namespace Amazon.RAM.Model
{
    /// <summary>
    /// Describes an association between a resource share and either a principal or a resource.
    /// </summary>
    public partial class ResourceShareAssociation
    {
        /// <summary>
        /// Gets and sets the property AssociatedEntity. 
        /// <para>
        /// The associated entity. This can be either of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a resource association, this is the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For principal associations, this is one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The ID of an Amazon Web Services account
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of an organization in Organizations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN of an organizational unit (OU) in Organizations
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN of an IAM role
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN of an IAM user
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public string AssociatedEntity { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedEntity property is set.
        /// </summary>
        internal bool IsSetAssociatedEntity() => this.AssociatedEntity != null;

        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        /// The type of entity included in this association.
        /// </para>
        /// </summary>
        public ResourceShareAssociationType AssociationType { get; set; }

        /// <summary>
        /// Checks to see if the AssociationType property is set.
        /// </summary>
        internal bool IsSetAssociationType() => this.AssociationType != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time when the association was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property External. 
        /// <para>
        /// Indicates whether the principal belongs to the same organization in Organizations
        /// as the Amazon Web Services account that owns the resource share.
        /// </para>
        /// </summary>
        public bool? External { get; set; }

        /// <summary>
        /// Checks to see if the External property is set.
        /// </summary>
        internal bool IsSetExternal() => this.External.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The date and time when the association was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceShareArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the resource share.
        /// </para>
        /// </summary>
        public string ResourceShareArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceShareArn property is set.
        /// </summary>
        internal bool IsSetResourceShareArn() => this.ResourceShareArn != null;

        /// <summary>
        /// Gets and sets the property ResourceShareName. 
        /// <para>
        /// The name of the resource share.
        /// </para>
        /// </summary>
        public string ResourceShareName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceShareName property is set.
        /// </summary>
        internal bool IsSetResourceShareName() => this.ResourceShareName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the association.
        /// </para>
        /// </summary>
        public ResourceShareAssociationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message about the status of the association.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
