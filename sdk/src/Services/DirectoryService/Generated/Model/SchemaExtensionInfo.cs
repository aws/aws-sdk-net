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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
        private string _description;
        private string _directoryId;
        private DateTime? _endDateTime;
        private string _schemaExtensionId;
        private SchemaExtensionStatus _schemaExtensionStatus;
        private string _schemaExtensionStatusReason;
        private DateTime? _startDateTime;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the schema extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory to which the schema extension is applied.
        /// </para>
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// The date and time that the schema extension was completed.
        /// </para>
        /// </summary>
        public DateTime? EndDateTime
        {
            get { return this._endDateTime; }
            set { this._endDateTime = value; }
        }

        // Check to see if EndDateTime property is set
        internal bool IsSetEndDateTime()
        {
            return this._endDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SchemaExtensionId. 
        /// <para>
        /// The identifier of the schema extension.
        /// </para>
        /// </summary>
        public string SchemaExtensionId
        {
            get { return this._schemaExtensionId; }
            set { this._schemaExtensionId = value; }
        }

        // Check to see if SchemaExtensionId property is set
        internal bool IsSetSchemaExtensionId()
        {
            return this._schemaExtensionId != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaExtensionStatus. 
        /// <para>
        /// The current status of the schema extension.
        /// </para>
        /// </summary>
        public SchemaExtensionStatus SchemaExtensionStatus
        {
            get { return this._schemaExtensionStatus; }
            set { this._schemaExtensionStatus = value; }
        }

        // Check to see if SchemaExtensionStatus property is set
        internal bool IsSetSchemaExtensionStatus()
        {
            return this._schemaExtensionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaExtensionStatusReason. 
        /// <para>
        /// The reason for the <c>SchemaExtensionStatus</c>.
        /// </para>
        /// </summary>
        public string SchemaExtensionStatusReason
        {
            get { return this._schemaExtensionStatusReason; }
            set { this._schemaExtensionStatusReason = value; }
        }

        // Check to see if SchemaExtensionStatusReason property is set
        internal bool IsSetSchemaExtensionStatusReason()
        {
            return this._schemaExtensionStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// The date and time that the schema extension started being applied to the directory.
        /// </para>
        /// </summary>
        public DateTime? StartDateTime
        {
            get { return this._startDateTime; }
            set { this._startDateTime = value; }
        }

        // Check to see if StartDateTime property is set
        internal bool IsSetStartDateTime()
        {
            return this._startDateTime.HasValue; 
        }

    }
}