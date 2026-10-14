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
    /// Container for the parameters to the CreateLabel operation. Creates a label for an
    /// event.
    /// </summary>
    public partial class CreateLabelRequest : AmazonLookoutEquipmentRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique identifier for the request to create a label. If you do not set the client
        /// request token, Lookout for Equipment generates one. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  The end time of the labeled event. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        ///  
        /// <para>
        /// Data in this field will be retained for service usage. Follow best practices for the
        /// security of your data.
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
        ///  Provides additional information about the label. The fault code must be defined in
        /// the FaultCodes attribute of the label group.
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
        /// Gets and sets the property LabelGroupName. 
        /// <para>
        ///  The name of a group of labels. 
        /// </para>
        ///  
        /// <para>
        /// Data in this field will be retained for service usage. Follow best practices for the
        /// security of your data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string LabelGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LabelGroupName property is set.
        /// </summary>
        internal bool IsSetLabelGroupName() => this.LabelGroupName != null;

        /// <summary>
        /// Gets and sets the property Notes. 
        /// <para>
        ///  Metadata providing additional information about the label. 
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
        [AWSProperty(Required = true)]
        public LabelRating Rating { get; set; }

        /// <summary>
        /// Checks to see if the Rating property is set.
        /// </summary>
        internal bool IsSetRating() => this.Rating != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The start time of the labeled event. 
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
