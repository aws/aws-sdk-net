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
    /// Use these settings to insert a DVB Service Description Table (SDT) in the transport
    /// stream of this output.
    /// </summary>
    public partial class DvbSdtSettings
    {
        /// <summary>
        /// Gets and sets the property OutputSdt. Selects method of inserting SDT information
        /// into output stream. "Follow input SDT" copies SDT information from input stream to
        /// output stream. "Follow input SDT if present" copies SDT information from input stream
        /// to output stream if SDT information is present in the input, otherwise it will fall
        /// back on the user-defined values. Enter "SDT Manually" means user will enter the SDT
        /// information. "No SDT" means output stream will not contain SDT information.
        /// </summary>
        public OutputSdt OutputSdt { get; set; }

        /// <summary>
        /// Checks to see if the OutputSdt property is set.
        /// </summary>
        internal bool IsSetOutputSdt() => this.OutputSdt != null;

        /// <summary>
        /// Gets and sets the property SdtInterval. The number of milliseconds between instances
        /// of this table in the output transport stream.
        /// </summary>
        [AWSProperty(Min = 25, Max = 2000)]
        public int? SdtInterval { get; set; }

        /// <summary>
        /// Checks to see if the SdtInterval property is set.
        /// </summary>
        internal bool IsSetSdtInterval() => this.SdtInterval.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceName. The service name placed in the service_descriptor
        /// in the Service Description Table. Maximum length is 256 characters.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property ServiceProviderName. The service provider name placed in
        /// the service_descriptor in the Service Description Table. Maximum length is 256 characters.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ServiceProviderName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceProviderName property is set.
        /// </summary>
        internal bool IsSetServiceProviderName() => this.ServiceProviderName != null;
    }
}
