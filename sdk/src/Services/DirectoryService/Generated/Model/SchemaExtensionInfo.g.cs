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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Information about a schema extension.
    /// </summary>
    public partial class SchemaExtensionInfo
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the schema extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory to which the schema extension is applied.
        /// </para>
        /// </summary>
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// The date and time that the schema extension was completed.
        /// </para>
        /// </summary>
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Checks to see if the EndDateTime property is set.
        /// </summary>
        internal bool IsSetEndDateTime() => this.EndDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property SchemaExtensionId. 
        /// <para>
        /// The identifier of the schema extension.
        /// </para>
        /// </summary>
        public string SchemaExtensionId { get; set; }

        /// <summary>
        /// Checks to see if the SchemaExtensionId property is set.
        /// </summary>
        internal bool IsSetSchemaExtensionId() => this.SchemaExtensionId != null;

        /// <summary>
        /// Gets and sets the property SchemaExtensionStatus. 
        /// <para>
        /// The current status of the schema extension.
        /// </para>
        /// </summary>
        public SchemaExtensionStatus SchemaExtensionStatus { get; set; }

        /// <summary>
        /// Checks to see if the SchemaExtensionStatus property is set.
        /// </summary>
        internal bool IsSetSchemaExtensionStatus() => this.SchemaExtensionStatus != null;

        /// <summary>
        /// Gets and sets the property SchemaExtensionStatusReason. 
        /// <para>
        /// The reason for the <c>SchemaExtensionStatus</c>.
        /// </para>
        /// </summary>
        public string SchemaExtensionStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the SchemaExtensionStatusReason property is set.
        /// </summary>
        internal bool IsSetSchemaExtensionStatusReason() => this.SchemaExtensionStatusReason != null;

        /// <summary>
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// The date and time that the schema extension started being applied to the directory.
        /// </para>
        /// </summary>
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Checks to see if the StartDateTime property is set.
        /// </summary>
        internal bool IsSetStartDateTime() => this.StartDateTime.HasValue;
    }
}
