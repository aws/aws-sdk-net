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

namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// An item of the periodontal chart that needs the clinician's confirmation.
    /// </summary>
    public partial class PeriodontalReview
    {
        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for review. The following values are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SITE_NOT_CHARTED</c>: One or more sites have no reading.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VALUE_NOT_CHARTED</c>: A dictated value or charting instruction was not charted,
        /// for example because the value was out of range or not valid at its position.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READING_COUNT_MISMATCH</c>: The number of dictated values did not match the number
        /// of open sites. The values were charted as dictated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LINE_UNCLEAR</c>: A line of dictation could not be interpreted and was not charted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TOOTH_UNCLEAR</c>: A line of dictation did not identify the tooth and was not
        /// charted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MISSING_TOOTH_CONFLICT</c>: The dictation conflicts with a tooth marked as missing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MEASUREMENT_NOT_CHARTED</c>: The dictation included a measurement that the chart
        /// does not record, such as plaque, calculus, or the mucogingival junction.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SESSION_ISSUE</c>: The exam setup could not be used and all teeth were assumed
        /// to be present, or the earlier chart could not be restored and charting restarted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public PeriodontalReviewReason Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property Sites. 
        /// <para>
        /// The probing sites of that tooth that the item refers to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 6)]
        public List<string> Sites { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Sites property is set.
        /// </summary>
        internal bool IsSetSites() => this.Sites != null && (this.Sites.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ToothNumber. 
        /// <para>
        /// The tooth that the item refers to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public int? ToothNumber { get; set; }

        /// <summary>
        /// Checks to see if the ToothNumber property is set.
        /// </summary>
        internal bool IsSetToothNumber() => this.ToothNumber.HasValue;
    }
}
