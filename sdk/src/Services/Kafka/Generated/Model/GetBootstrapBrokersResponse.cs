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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// This is the response object from the GetBootstrapBrokers operation.
    /// </summary>
    public partial class GetBootstrapBrokersResponse : AmazonWebServiceResponse
    {
        private string _bootstrapBrokerString;
        private string _bootstrapBrokerStringSaslScram;
        private string _bootstrapBrokerStringTls;

        /// <summary>
        /// Gets and sets the property BootstrapBrokerString.             
        /// <para>
        /// A string containing one or more hostname:port pairs.
        /// </para>
        /// </summary>
        public string BootstrapBrokerString
        {
            get { return this._bootstrapBrokerString; }
            set { this._bootstrapBrokerString = value; }
        }

        // Check to see if BootstrapBrokerString property is set
        internal bool IsSetBootstrapBrokerString()
        {
            return this._bootstrapBrokerString != null;
        }

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringSaslScram.             
        /// <para>
        /// A string containing one or more DNS names (or IP) and Sasl Scram port pairs.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringSaslScram
        {
            get { return this._bootstrapBrokerStringSaslScram; }
            set { this._bootstrapBrokerStringSaslScram = value; }
        }

        // Check to see if BootstrapBrokerStringSaslScram property is set
        internal bool IsSetBootstrapBrokerStringSaslScram()
        {
            return this._bootstrapBrokerStringSaslScram != null;
        }

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringTls.             
        /// <para>
        /// A string containing one or more DNS names (or IP) and TLS port pairs.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringTls
        {
            get { return this._bootstrapBrokerStringTls; }
            set { this._bootstrapBrokerStringTls = value; }
        }

        // Check to see if BootstrapBrokerStringTls property is set
        internal bool IsSetBootstrapBrokerStringTls()
        {
            return this._bootstrapBrokerStringTls != null;
        }

    }
}