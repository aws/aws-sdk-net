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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Operational metadata for an application in Application Manager.
    /// </summary>
    public partial class OpsMetadata
    {
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the OpsMetadata objects was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date the OpsMetadata object was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedUser. 
        /// <para>
        /// The user name who last updated the OpsMetadata object.
        /// </para>
        /// </summary>
        public string LastModifiedUser { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedUser property is set.
        /// </summary>
        internal bool IsSetLastModifiedUser() => this.LastModifiedUser != null;

        /// <summary>
        /// Gets and sets the property OpsMetadataArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the OpsMetadata Object or blob.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string OpsMetadataArn { get; set; }

        /// <summary>
        /// Checks to see if the OpsMetadataArn property is set.
        /// </summary>
        internal bool IsSetOpsMetadataArn() => this.OpsMetadataArn != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the Application Manager application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;
    }
}
