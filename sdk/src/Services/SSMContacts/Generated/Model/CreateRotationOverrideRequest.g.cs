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

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRotationOverride operation. Creates an override
    /// for a rotation in an on-call schedule.
    /// </summary>
    public partial class CreateRotationOverrideRequest : AmazonSSMContactsRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time when the override ends.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A token that ensures that the operation is called only once with the specified details.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string IdempotencyToken { get; set; }

        /// <summary>
        /// Checks to see if the IdempotencyToken property is set.
        /// </summary>
        internal bool IsSetIdempotencyToken() => this.IdempotencyToken != null;

        /// <summary>
        /// Gets and sets the property NewContactIds. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the contacts to replace those in the current on-call
        /// rotation with.
        /// </para>
        ///  
        /// <para>
        /// If you want to include any current team members in the override shift, you must include
        /// their ARNs in the new contact ID list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 30)]
        public List<string> NewContactIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NewContactIds property is set.
        /// </summary>
        internal bool IsSetNewContactIds() => this.NewContactIds != null && (this.NewContactIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RotationId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the rotation to create an override for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RotationId { get; set; }

        /// <summary>
        /// Checks to see if the RotationId property is set.
        /// </summary>
        internal bool IsSetRotationId() => this.RotationId != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time when the override goes into effect.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
