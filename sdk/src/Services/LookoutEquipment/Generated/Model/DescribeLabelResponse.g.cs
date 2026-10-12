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
    /// This is the response object from the DescribeLabel operation.
    /// </summary>
    public partial class DescribeLabelResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The time at which the label was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  The end time of the requested label. 
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Equipment. 
        /// <para>
        ///  Indicates that a label pertains to a particular piece of equipment. 
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
        ///  Indicates the type of anomaly associated with the label. 
        /// </para>
        ///  
        /// <para>
        /// Data in this field will be retained for service usage. Follow best practices for the
        /// security of your data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string FaultCode { get; set; }

        /// <summary>
        /// Checks to see if the FaultCode property is set.
        /// </summary>
        internal bool IsSetFaultCode() => this.FaultCode != null;

        /// <summary>
        /// Gets and sets the property LabelGroupArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the requested label group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string LabelGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the LabelGroupArn property is set.
        /// </summary>
        internal bool IsSetLabelGroupArn() => this.LabelGroupArn != null;

        /// <summary>
        /// Gets and sets the property LabelGroupName. 
        /// <para>
        ///  The name of the requested label group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string LabelGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LabelGroupName property is set.
        /// </summary>
        internal bool IsSetLabelGroupName() => this.LabelGroupName != null;

        /// <summary>
        /// Gets and sets the property LabelId. 
        /// <para>
        ///  The ID of the requested label. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public string LabelId { get; set; }

        /// <summary>
        /// Checks to see if the LabelId property is set.
        /// </summary>
        internal bool IsSetLabelId() => this.LabelId != null;

        /// <summary>
        /// Gets and sets the property Notes. 
        /// <para>
        /// Metadata providing additional information about the label.
        /// </para>
        ///  
        /// <para>
        /// Data in this field will be retained for service usage. Follow best practices for the
        /// security of your data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2560)]
        public string Notes { get; set; }

        /// <summary>
        /// Checks to see if the Notes property is set.
        /// </summary>
        internal bool IsSetNotes() => this.Notes != null;

        /// <summary>
        /// Gets and sets the property Rating. 
        /// <para>
        ///  Indicates whether a labeled event represents an anomaly. 
        /// </para>
        /// </summary>
        public LabelRating Rating { get; set; }

        /// <summary>
        /// Checks to see if the Rating property is set.
        /// </summary>
        internal bool IsSetRating() => this.Rating != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The start time of the requested label. 
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
