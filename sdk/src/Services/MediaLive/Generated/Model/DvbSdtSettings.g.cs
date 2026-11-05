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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// DVB Service Description Table (SDT)
    /// </summary>
    public partial class DvbSdtSettings
    {
        /// <summary>
        /// Gets and sets the property OutputSdt. Selects method of inserting SDT information
        /// into output stream. The sdtFollow setting copies SDT information from input stream
        /// to output stream. The sdtFollowIfPresent setting copies SDT information from input
        /// stream to output stream if SDT information is present in the input, otherwise it will
        /// fall back on the user-defined values. The sdtManual setting means user will enter
        /// the SDT information. The sdtNone setting means output stream will not contain SDT
        /// information.
        /// </summary>
        public DvbSdtOutputSdt OutputSdt { get; set; }

        /// <summary>
        /// Checks to see if the OutputSdt property is set.
        /// </summary>
        internal bool IsSetOutputSdt() => this.OutputSdt != null;

        /// <summary>
        /// Gets and sets the property RepInterval. The number of milliseconds between instances
        /// of this table in the output transport stream.
        /// </summary>
        public int? RepInterval { get; set; }

        /// <summary>
        /// Checks to see if the RepInterval property is set.
        /// </summary>
        internal bool IsSetRepInterval() => this.RepInterval.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceName. The service name placed in the serviceDescriptor
        /// in the Service Description Table. Maximum length is 256 characters.
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property ServiceProviderName. The service provider name placed in
        /// the serviceDescriptor in the Service Description Table. Maximum length is 256 characters.
        /// </summary>
        public string ServiceProviderName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceProviderName property is set.
        /// </summary>
        internal bool IsSetServiceProviderName() => this.ServiceProviderName != null;
    }
}
