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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the GetEffectiveHoursOfOperations operation.
    /// </summary>
    public partial class GetEffectiveHoursOfOperationsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EffectiveHoursOfOperationList. 
        /// <para>
        /// Information about the effective hours of operations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EffectiveHoursOfOperations> EffectiveHoursOfOperationList { get; set; } = AWSConfigs.InitializeCollections ? new List<EffectiveHoursOfOperations>() : null;

        /// <summary>
        /// Checks to see if the EffectiveHoursOfOperationList property is set.
        /// </summary>
        internal bool IsSetEffectiveHoursOfOperationList() => this.EffectiveHoursOfOperationList != null && (this.EffectiveHoursOfOperationList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EffectiveOverrideHoursList. 
        /// <para>
        /// Information about override configurations applied to the base hours of operation to
        /// calculate the effective hours.
        /// </para>
        ///  
        /// <para>
        /// For more information about how override types are applied, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/hours-of-operation-overrides.html">Build
        /// your list of overrides</a> in the <i> Administrator Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EffectiveOverrideHours> EffectiveOverrideHoursList { get; set; } = AWSConfigs.InitializeCollections ? new List<EffectiveOverrideHours>() : null;

        /// <summary>
        /// Checks to see if the EffectiveOverrideHoursList property is set.
        /// </summary>
        internal bool IsSetEffectiveOverrideHoursList() => this.EffectiveOverrideHoursList != null && (this.EffectiveOverrideHoursList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The time zone for the hours of operation.
        /// </para>
        /// </summary>
        public string TimeZone { get; set; }

        /// <summary>
        /// Checks to see if the TimeZone property is set.
        /// </summary>
        internal bool IsSetTimeZone() => this.TimeZone != null;
    }
}
