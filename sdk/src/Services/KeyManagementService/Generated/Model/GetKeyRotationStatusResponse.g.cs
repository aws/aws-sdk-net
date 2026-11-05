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

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// This is the response object from the GetKeyRotationStatus operation.
    /// </summary>
    public partial class GetKeyRotationStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Identifies the specified symmetric encryption KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property KeyRotationEnabled. 
        /// <para>
        /// A Boolean value that specifies whether key rotation is enabled.
        /// </para>
        /// </summary>
        public bool? KeyRotationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the KeyRotationEnabled property is set.
        /// </summary>
        internal bool IsSetKeyRotationEnabled() => this.KeyRotationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property NextRotationDate. 
        /// <para>
        /// The next date that KMS will automatically rotate the key material.
        /// </para>
        /// </summary>
        public DateTime? NextRotationDate { get; set; }

        /// <summary>
        /// Checks to see if the NextRotationDate property is set.
        /// </summary>
        internal bool IsSetNextRotationDate() => this.NextRotationDate.HasValue;

        /// <summary>
        /// Gets and sets the property OnDemandRotationStartDate. 
        /// <para>
        /// Identifies the date and time that an in progress on-demand rotation was initiated.
        /// </para>
        ///  
        /// <para>
        /// KMS uses a background process to perform rotations. As a result, there might be a
        /// slight delay between initiating on-demand key rotation and the rotation's completion.
        /// Once the on-demand rotation is complete, KMS removes this field from the response.
        /// You can use <a>ListKeyRotations</a> to view the details of the completed on-demand
        /// rotation.
        /// </para>
        /// </summary>
        public DateTime? OnDemandRotationStartDate { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandRotationStartDate property is set.
        /// </summary>
        internal bool IsSetOnDemandRotationStartDate() => this.OnDemandRotationStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property RotationPeriodInDays. 
        /// <para>
        /// The number of days between each automatic rotation. The default value is 365 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 90, Max = 2560)]
        public int? RotationPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the RotationPeriodInDays property is set.
        /// </summary>
        internal bool IsSetRotationPeriodInDays() => this.RotationPeriodInDays.HasValue;
    }
}
