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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the ArchiveProject operation.
    /// </summary>
    public partial class ArchiveProjectResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ArchivedAt. 
        /// <para>
        /// The time the project was archived.
        /// </para>
        /// </summary>
        public DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Checks to see if the ArchivedAt property is set.
        /// </summary>
        internal bool IsSetArchivedAt() => this.ArchivedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time the project was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataRetention. 
        /// <para>
        /// The project's data retention setting. A mode of <c>inherit</c> defers to the account
        /// setting or model default.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProjectDataRetention DataRetention { get; set; }

        /// <summary>
        /// Checks to see if the DataRetention property is set.
        /// </summary>
        internal bool IsSetDataRetention() => this.DataRetention != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The project ID. The account's default project uses <c>default</c>; a named project's
        /// generated ID starts with <c>proj_</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The project's display name. Project names do not have to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 127)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The project's lifecycle status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProjectStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
