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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about the observed process.
    /// </summary>
    public partial class ProcessDetails
    {
        /// <summary>
        /// Gets and sets the property Euid. 
        /// <para>
        /// The effective user ID of the user that executed the process.
        /// </para>
        /// </summary>
        public int? Euid { get; set; }

        /// <summary>
        /// Checks to see if the Euid property is set.
        /// </summary>
        internal bool IsSetEuid() => this.Euid.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutablePath. 
        /// <para>
        /// The absolute path of the process executable file.
        /// </para>
        /// </summary>
        public string ExecutablePath { get; set; }

        /// <summary>
        /// Checks to see if the ExecutablePath property is set.
        /// </summary>
        internal bool IsSetExecutablePath() => this.ExecutablePath != null;

        /// <summary>
        /// Gets and sets the property ExecutableSha256. 
        /// <para>
        /// The <c>SHA256</c> hash of the process executable.
        /// </para>
        /// </summary>
        public string ExecutableSha256 { get; set; }

        /// <summary>
        /// Checks to see if the ExecutableSha256 property is set.
        /// </summary>
        internal bool IsSetExecutableSha256() => this.ExecutableSha256 != null;

        /// <summary>
        /// Gets and sets the property Lineage. 
        /// <para>
        /// Information about the process's lineage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LineageObject> Lineage { get; set; } = AWSConfigs.InitializeCollections ? new List<LineageObject>() : null;

        /// <summary>
        /// Checks to see if the Lineage property is set.
        /// </summary>
        internal bool IsSetLineage() => this.Lineage != null && (this.Lineage.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the process.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NamespacePid. 
        /// <para>
        /// The ID of the child process.
        /// </para>
        /// </summary>
        public int? NamespacePid { get; set; }

        /// <summary>
        /// Checks to see if the NamespacePid property is set.
        /// </summary>
        internal bool IsSetNamespacePid() => this.NamespacePid.HasValue;

        /// <summary>
        /// Gets and sets the property ParentUuid. 
        /// <para>
        /// The unique ID of the parent process. This ID is assigned to the parent process by
        /// GuardDuty.
        /// </para>
        /// </summary>
        public string ParentUuid { get; set; }

        /// <summary>
        /// Checks to see if the ParentUuid property is set.
        /// </summary>
        internal bool IsSetParentUuid() => this.ParentUuid != null;

        /// <summary>
        /// Gets and sets the property Pid. 
        /// <para>
        /// The ID of the process.
        /// </para>
        /// </summary>
        public int? Pid { get; set; }

        /// <summary>
        /// Checks to see if the Pid property is set.
        /// </summary>
        internal bool IsSetPid() => this.Pid.HasValue;

        /// <summary>
        /// Gets and sets the property Pwd. 
        /// <para>
        /// The present working directory of the process.
        /// </para>
        /// </summary>
        public string Pwd { get; set; }

        /// <summary>
        /// Checks to see if the Pwd property is set.
        /// </summary>
        internal bool IsSetPwd() => this.Pwd != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when the process started. This is in UTC format.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// The user that executed the process.
        /// </para>
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The unique ID of the user that executed the process.
        /// </para>
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId.HasValue;

        /// <summary>
        /// Gets and sets the property Uuid. 
        /// <para>
        /// The unique ID assigned to the process by GuardDuty.
        /// </para>
        /// </summary>
        public string Uuid { get; set; }

        /// <summary>
        /// Checks to see if the Uuid property is set.
        /// </summary>
        internal bool IsSetUuid() => this.Uuid != null;
    }
}
