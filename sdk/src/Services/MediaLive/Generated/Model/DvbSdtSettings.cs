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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
        private DvbSdtOutputSdt _outputSdt;
        private int? _repInterval;
        private string _serviceName;
        private string _serviceProviderName;

        /// <summary>
        /// Gets and sets the property OutputSdt. Selects method of inserting SDT information
        /// into output stream. The sdtFollow setting copies SDT information from input stream
        /// to output stream. The sdtFollowIfPresent setting copies SDT information from input
        /// stream to output stream if SDT information is present in the input, otherwise it will
        /// fall back on the user-defined values. The sdtManual setting means user will enter
        /// the SDT information. The sdtNone setting means output stream will not contain SDT
        /// information.
        /// </summary>
        public DvbSdtOutputSdt OutputSdt
        {
            get { return this._outputSdt; }
            set { this._outputSdt = value; }
        }

        // Check to see if OutputSdt property is set
        internal bool IsSetOutputSdt()
        {
            return this._outputSdt != null;
        }

        /// <summary>
        /// Gets and sets the property RepInterval. The number of milliseconds between instances
        /// of this table in the output transport stream.
        /// </summary>
        [AWSProperty(Min=25, Max=2000)]
        public int? RepInterval
        {
            get { return this._repInterval; }
            set { this._repInterval = value; }
        }

        // Check to see if RepInterval property is set
        internal bool IsSetRepInterval()
        {
            return this._repInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceName. The service name placed in the serviceDescriptor
        /// in the Service Description Table. Maximum length is 256 characters.
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceProviderName. The service provider name placed in
        /// the serviceDescriptor in the Service Description Table. Maximum length is 256 characters.
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ServiceProviderName
        {
            get { return this._serviceProviderName; }
            set { this._serviceProviderName = value; }
        }

        // Check to see if ServiceProviderName property is set
        internal bool IsSetServiceProviderName()
        {
            return this._serviceProviderName != null;
        }

    }
}