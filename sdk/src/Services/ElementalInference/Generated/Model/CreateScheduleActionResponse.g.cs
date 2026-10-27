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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// This is the response object from the CreateScheduleAction operation.
    /// </summary>
    public partial class CreateScheduleActionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The name that you specified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ActionName { get; set; }

        /// <summary>
        /// Checks to see if the ActionName property is set.
        /// </summary>
        internal bool IsSetActionName() => this.ActionName != null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// A description of why the action failed. Elemental Inference returns this property
        /// only when the status is FAILED. 
        /// </para>
        /// </summary>
        public ScheduleActionError Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property Operations. 
        /// <para>
        /// The configuration changes that the action makes to the feed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<ScheduleActionOperation> Operations { get; set; } = AWSConfigs.InitializeCollections ? new List<ScheduleActionOperation>() : null;

        /// <summary>
        /// Checks to see if the Operations property is set.
        /// </summary>
        internal bool IsSetOperations() => this.Operations != null && (this.Operations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartConfiguration. 
        /// <para>
        /// Specifies when the action runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScheduleActionStartConfiguration StartConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StartConfiguration property is set.
        /// </summary>
        internal bool IsSetStartConfiguration() => this.StartConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the action. After you create the action successfully, Elemental Inference
        /// sets the status to PENDING. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScheduleActionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
