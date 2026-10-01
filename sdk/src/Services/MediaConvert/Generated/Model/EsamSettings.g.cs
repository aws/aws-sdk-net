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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for Event Signaling And Messaging (ESAM). If you don't do ad insertion, you
    /// can ignore these settings.
    /// </summary>
    public partial class EsamSettings
    {
        /// <summary>
        /// Gets and sets the property ManifestConfirmConditionNotification. Specifies an ESAM
        /// ManifestConfirmConditionNotification XML as per OC-SP-ESAM-API-I03-131025. The transcoder
        /// uses the manifest conditioning instructions that you provide in the setting MCC XML.
        /// </summary>
        public EsamManifestConfirmConditionNotification ManifestConfirmConditionNotification { get; set; }

        /// <summary>
        /// Checks to see if the ManifestConfirmConditionNotification property is set.
        /// </summary>
        internal bool IsSetManifestConfirmConditionNotification() => this.ManifestConfirmConditionNotification != null;

        /// <summary>
        /// Gets and sets the property ResponseSignalPreroll. Specifies the stream distance, in
        /// milliseconds, between the SCTE 35 messages that the transcoder places and the splice
        /// points that they refer to. If the time between the start of the asset and the SCTE-35
        /// message is less than this value, then the transcoder places the SCTE-35 marker at
        /// the beginning of the stream.
        /// </summary>
        [AWSProperty(Min = 0, Max = 30000)]
        public int? ResponseSignalPreroll { get; set; }

        /// <summary>
        /// Checks to see if the ResponseSignalPreroll property is set.
        /// </summary>
        internal bool IsSetResponseSignalPreroll() => this.ResponseSignalPreroll.HasValue;

        /// <summary>
        /// Gets and sets the property SignalProcessingNotification. Specifies an ESAM SignalProcessingNotification
        /// XML as per OC-SP-ESAM-API-I03-131025. The transcoder uses the signal processing instructions
        /// that you provide in the setting SCC XML.
        /// </summary>
        public EsamSignalProcessingNotification SignalProcessingNotification { get; set; }

        /// <summary>
        /// Checks to see if the SignalProcessingNotification property is set.
        /// </summary>
        internal bool IsSetSignalProcessingNotification() => this.SignalProcessingNotification != null;
    }
}
