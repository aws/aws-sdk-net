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

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// This is the response object from the GetSyncJob operation.
    /// </summary>
    public partial class GetSyncJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The sync job ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The creation date and time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The SyncJob response status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SyncJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SyncRole. 
        /// <para>
        /// The sync IAM role.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string SyncRole { get; set; }

        /// <summary>
        /// Checks to see if the SyncRole property is set.
        /// </summary>
        internal bool IsSetSyncRole() => this.SyncRole != null;

        /// <summary>
        /// Gets and sets the property SyncSource. 
        /// <para>
        /// The sync soucre.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently the only supported syncSource is <c>SITEWISE </c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SyncSource { get; set; }

        /// <summary>
        /// Checks to see if the SyncSource property is set.
        /// </summary>
        internal bool IsSetSyncSource() => this.SyncSource != null;

        /// <summary>
        /// Gets and sets the property UpdateDateTime. 
        /// <para>
        /// The update date and time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateDateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDateTime property is set.
        /// </summary>
        internal bool IsSetUpdateDateTime() => this.UpdateDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace that contains the sync job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceId property is set.
        /// </summary>
        internal bool IsSetWorkspaceId() => this.WorkspaceId != null;
    }
}
