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
    /// This is the response object from the GetRotationOverride operation.
    /// </summary>
    public partial class GetRotationOverrideResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time when the override was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time when the override ends.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property NewContactIds. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the contacts assigned to the override of the on-call
        /// rotation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 25)]
        public List<string> NewContactIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NewContactIds property is set.
        /// </summary>
        internal bool IsSetNewContactIds() => this.NewContactIds != null && (this.NewContactIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RotationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the on-call rotation that was overridden.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string RotationArn { get; set; }

        /// <summary>
        /// Checks to see if the RotationArn property is set.
        /// </summary>
        internal bool IsSetRotationArn() => this.RotationArn != null;

        /// <summary>
        /// Gets and sets the property RotationOverrideId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the override to an on-call rotation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 39)]
        public string RotationOverrideId { get; set; }

        /// <summary>
        /// Checks to see if the RotationOverrideId property is set.
        /// </summary>
        internal bool IsSetRotationOverrideId() => this.RotationOverrideId != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time when the override goes into effect.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
