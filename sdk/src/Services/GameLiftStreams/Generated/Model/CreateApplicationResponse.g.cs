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

namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// This is the response object from the CreateApplication operation.
    /// </summary>
    public partial class CreateApplicationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationLogOutputUri. 
        /// <para>
        /// An Amazon S3 URI to a bucket where you would like Amazon GameLift Streams to save
        /// application logs. Required if you specify one or more <c>ApplicationLogPaths</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ApplicationLogOutputUri { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationLogOutputUri property is set.
        /// </summary>
        internal bool IsSetApplicationLogOutputUri() => this.ApplicationLogOutputUri != null;

        /// <summary>
        /// Gets and sets the property ApplicationLogPaths. 
        /// <para>
        /// Locations of log files that your content generates during a stream session. Amazon
        /// GameLift Streams uploads log files to the Amazon S3 bucket that you specify in <c>ApplicationLogOutputUri</c>
        /// at the end of a stream session. To retrieve stored log files, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetStreamSession.html">GetStreamSession</a>
        /// and get the <c>LogFileLocationUri</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> ApplicationLogPaths { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ApplicationLogPaths property is set.
        /// </summary>
        internal bool IsSetApplicationLogPaths() => this.ApplicationLogPaths != null && (this.ApplicationLogPaths.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApplicationSourceUri. 
        /// <para>
        /// The original Amazon S3 location of uploaded stream content for the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ApplicationSourceUri { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationSourceUri property is set.
        /// </summary>
        internal bool IsSetApplicationSourceUri() => this.ApplicationSourceUri != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> that's assigned to an application resource and uniquely identifies
        /// it across all Amazon Web Services Regions. Format is <c>arn:aws:gameliftstreams:[AWS
        /// Region]:[AWS account]:application/[resource ID]</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssociatedStreamGroups. 
        /// <para>
        /// A newly created application is not associated to any stream groups. This value is
        /// empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedStreamGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssociatedStreamGroups property is set.
        /// </summary>
        internal bool IsSetAssociatedStreamGroups() => this.AssociatedStreamGroups != null && (this.AssociatedStreamGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// A timestamp that indicates when this resource was created. Timestamps are expressed
        /// using in ISO8601 format, such as: <c>2022-12-27T22:29:40+00:00</c> (UTC).
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable label for the application. You can edit this value. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 80)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExecutablePath. 
        /// <para>
        /// The relative path and file name of the executable file that launches the content for
        /// streaming.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ExecutablePath { get; set; }

        /// <summary>
        /// Checks to see if the ExecutablePath property is set.
        /// </summary>
        internal bool IsSetExecutablePath() => this.ExecutablePath != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique ID value that is assigned to the resource when it's created. Format example:
        /// <c>a-9ZY8X7Wv6</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// A timestamp that indicates when this resource was last updated. Timestamps are expressed
        /// using in ISO8601 format, such as: <c>2022-12-27T22:29:40+00:00</c> (UTC).
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicationStatuses. 
        /// <para>
        /// A set of replication statuses for each location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReplicationStatus> ReplicationStatuses { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicationStatus>() : null;

        /// <summary>
        /// Checks to see if the ReplicationStatuses property is set.
        /// </summary>
        internal bool IsSetReplicationStatuses() => this.ReplicationStatuses != null && (this.ReplicationStatuses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuntimeEnvironment. 
        /// <para>
        ///  Configuration settings that identify the operating system for an application resource.
        /// This can also include a compatibility layer and other drivers. 
        /// </para>
        ///  
        /// <para>
        /// A runtime environment can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For Linux applications 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Ubuntu 22.04 LTS (<c>Type=UBUNTU, Version=22_04_LTS</c>) 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  For Windows applications 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Microsoft Windows Server 2022 Base (<c>Type=WINDOWS, Version=2022</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Proton 10.0-4 (<c>Type=PROTON, Version=20260204</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Proton 9.0-2 (<c>Type=PROTON, Version=20250516</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Proton 8.0-5 (<c>Type=PROTON, Version=20241007</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Proton 8.0-2c (<c>Type=PROTON, Version=20230704</c>)
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public RuntimeEnvironment RuntimeEnvironment { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeEnvironment property is set.
        /// </summary>
        internal bool IsSetRuntimeEnvironment() => this.RuntimeEnvironment != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the application resource. Possible statuses include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INITIALIZED</c>: Amazon GameLift Streams has received the request and is initiating
        /// the work flow to create an application. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PROCESSING</c>: The create application work flow is in process. Amazon GameLift
        /// Streams is copying the content and caching for future deployment in a stream group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READY</c>: The application is ready to deploy in a stream group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c>: An error occurred when setting up the application. See <c>StatusReason</c>
        /// for more information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c>: Amazon GameLift Streams is in the process of deleting the application.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ApplicationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short description of the status reason when the application is in <c>ERROR</c> status.
        /// </para>
        /// </summary>
        public ApplicationStatusReason StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
