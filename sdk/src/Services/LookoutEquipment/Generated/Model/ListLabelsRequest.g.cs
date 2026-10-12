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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Container for the parameters to the ListLabels operation. Provides a list of labels.
    /// </summary>
    public partial class ListLabelsRequest : AmazonLookoutEquipmentRequest
    {
        /// <summary>
        /// Gets and sets the property Equipment. 
        /// <para>
        ///  Lists the labels that pertain to a particular piece of equipment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Equipment { get; set; }

        /// <summary>
        /// Checks to see if the Equipment property is set.
        /// </summary>
        internal bool IsSetEquipment() => this.Equipment != null;

        /// <summary>
        /// Gets and sets the property FaultCode. 
        /// <para>
        ///  Returns labels with a particular fault code. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string FaultCode { get; set; }

        /// <summary>
        /// Checks to see if the FaultCode property is set.
        /// </summary>
        internal bool IsSetFaultCode() => this.FaultCode != null;

        /// <summary>
        /// Gets and sets the property IntervalEndTime. 
        /// <para>
        ///  Returns all labels with a start time earlier than the end time given. 
        /// </para>
        /// </summary>
        public DateTime? IntervalEndTime { get; set; }

        /// <summary>
        /// Checks to see if the IntervalEndTime property is set.
        /// </summary>
        internal bool IsSetIntervalEndTime() => this.IntervalEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property IntervalStartTime. 
        /// <para>
        ///  Returns all the labels with a end time equal to or later than the start time given.
        /// 
        /// </para>
        /// </summary>
        public DateTime? IntervalStartTime { get; set; }

        /// <summary>
        /// Checks to see if the IntervalStartTime property is set.
        /// </summary>
        internal bool IsSetIntervalStartTime() => this.IntervalStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property LabelGroupName. 
        /// <para>
        ///  Returns the name of the label group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string LabelGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LabelGroupName property is set.
        /// </summary>
        internal bool IsSetLabelGroupName() => this.LabelGroupName != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  Specifies the maximum number of labels to list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  An opaque pagination token indicating where to continue the listing of label groups.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
