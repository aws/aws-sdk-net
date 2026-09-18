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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Job.
    /// </summary>
    public partial class Job
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// the ARN of the specific Job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// Job creation time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime != null;

        /// <summary>
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// Job end time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string EndDateTime { get; set; }

        /// <summary>
        /// Checks to see if the EndDateTime property is set.
        /// </summary>
        internal bool IsSetEndDateTime() => this.EndDateTime != null;

        /// <summary>
        /// Gets and sets the property InitiatedBy. 
        /// <para>
        /// Job initiated by field.
        /// </para>
        /// </summary>
        public InitiatedBy InitiatedBy { get; set; }

        /// <summary>
        /// Checks to see if the InitiatedBy property is set.
        /// </summary>
        internal bool IsSetInitiatedBy() => this.InitiatedBy != null;

        /// <summary>
        /// Gets and sets the property JobID. 
        /// <para>
        /// Job ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 24, Max = 24)]
        public string JobID { get; set; }

        /// <summary>
        /// Checks to see if the JobID property is set.
        /// </summary>
        internal bool IsSetJobID() => this.JobID != null;

        /// <summary>
        /// Gets and sets the property ParticipatingServers. 
        /// <para>
        /// Servers participating in a specific Job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ParticipatingServer> ParticipatingServers { get; set; } = AWSConfigs.InitializeCollections ? new List<ParticipatingServer>() : null;

        /// <summary>
        /// Checks to see if the ParticipatingServers property is set.
        /// </summary>
        internal bool IsSetParticipatingServers() => this.ParticipatingServers != null && (this.ParticipatingServers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Job status.
        /// </para>
        /// </summary>
        public JobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with specific Job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Job type.
        /// </para>
        /// </summary>
        public JobType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
