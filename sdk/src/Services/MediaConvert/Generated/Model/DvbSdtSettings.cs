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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Use these settings to insert a DVB Service Description Table (SDT) in the transport
    /// stream of this output. When you work directly in your JSON job specification, include
    /// this object only when your job has a transport stream output and the container settings
    /// contain the object M2tsSettings.
    /// </summary>
    public partial class DvbSdtSettings
    {
        private OutputSdt _outputSdt;
        private int? _sdtInterval;
        private string _serviceName;
        private string _serviceProviderName;

        /// <summary>
        /// Gets and sets the property OutputSdt. Selects method of inserting SDT information
        /// into output stream. "Follow input SDT" copies SDT information from input stream to
        /// output stream. "Follow input SDT if present" copies SDT information from input stream
        /// to output stream if SDT information is present in the input, otherwise it will fall
        /// back on the user-defined values. Enter "SDT Manually" means user will enter the SDT
        /// information. "No SDT" means output stream will not contain SDT information.
        /// </summary>
        public OutputSdt OutputSdt
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
        /// Gets and sets the property SdtInterval. The number of milliseconds between instances
        /// of this table in the output transport stream.
        /// </summary>
        [AWSProperty(Min=25, Max=2000)]
        public int SdtInterval
        {
            get { return this._sdtInterval.GetValueOrDefault(); }
            set { this._sdtInterval = value; }
        }

        // Check to see if SdtInterval property is set
        internal bool IsSetSdtInterval()
        {
            return this._sdtInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceName. The service name placed in the service_descriptor
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
        /// the service_descriptor in the Service Description Table. Maximum length is 256 characters.
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