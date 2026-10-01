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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// This is the response object from the GetBootstrapBrokers operation.
    /// </summary>
    public partial class GetBootstrapBrokersResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BootstrapBrokerString. 
        /// <para>
        /// A string containing one or more hostname:port pairs.
        /// </para>
        /// </summary>
        public string BootstrapBrokerString { get; set; }

        /// <summary>
        /// Checks to see if the BootstrapBrokerString property is set.
        /// </summary>
        internal bool IsSetBootstrapBrokerString() => this.BootstrapBrokerString != null;

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringIpv6. 
        /// <para>
        /// A string that contains one or more DNS names (or IP) and port pairs for IPv6 connectivity.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the BootstrapBrokerStringIpv6 property is set.
        /// </summary>
        internal bool IsSetBootstrapBrokerStringIpv6() => this.BootstrapBrokerStringIpv6 != null;

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringPublicSaslIam. 
        /// <para>
        /// A string that contains one or more DNS names (or IP addresses) and SASL IAM port pairs.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringPublicSaslIam { get; set; }

        /// <summary>
        /// Checks to see if the BootstrapBrokerStringPublicSaslIam property is set.
        /// </summary>
        internal bool IsSetBootstrapBrokerStringPublicSaslIam() => this.BootstrapBrokerStringPublicSaslIam != null;

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringPublicSaslScram. 
        /// <para>
        /// A string containing one or more DNS names (or IP) and Sasl Scram port pairs.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringPublicSaslScram { get; set; }

        /// <summary>
        /// Checks to see if the BootstrapBrokerStringPublicSaslScram property is set.
        /// </summary>
        internal bool IsSetBootstrapBrokerStringPublicSaslScram() => this.BootstrapBrokerStringPublicSaslScram != null;

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringPublicTls. 
        /// <para>
        /// A string containing one or more DNS names (or IP) and TLS port pairs.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringPublicTls { get; set; }

        /// <summary>
        /// Checks to see if the BootstrapBrokerStringPublicTls property is set.
        /// </summary>
        internal bool IsSetBootstrapBrokerStringPublicTls() => this.BootstrapBrokerStringPublicTls != null;

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringSaslIam. 
        /// <para>
        /// A string that contains one or more DNS names (or IP addresses) and SASL IAM port pairs.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringSaslIam { get; set; }

        /// <summary>
        /// Checks to see if the BootstrapBrokerStringSaslIam property is set.
        /// </summary>
        internal bool IsSetBootstrapBrokerStringSaslIam() => this.BootstrapBrokerStringSaslIam != null;

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringSaslIamIpv6. 
        /// <para>
        /// A string that contains one or more DNS names (or IP) and SASL IAM port pairs for IPv6
        /// connectivity.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringSaslIamIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the BootstrapBrokerStringSaslIamIpv6 property is set.
        /// </summary>
        internal bool IsSetBootstrapBrokerStringSaslIamIpv6() => this.BootstrapBrokerStringSaslIamIpv6 != null;

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringSaslScram. 
        /// <para>
        /// A string containing one or more DNS names (or IP) and Sasl Scram port pairs.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringSaslScram { get; set; }

        /// <summary>
        /// Checks to see if the BootstrapBrokerStringSaslScram property is set.
        /// </summary>
        internal bool IsSetBootstrapBrokerStringSaslScram() => this.BootstrapBrokerStringSaslScram != null;

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringSaslScramIpv6. 
        /// <para>
        /// A string that contains one or more DNS names (or IP) and SASL SCRAM port pairs for
        /// IPv6 connectivity.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringSaslScramIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the BootstrapBrokerStringSaslScramIpv6 property is set.
        /// </summary>
        internal bool IsSetBootstrapBrokerStringSaslScramIpv6() => this.BootstrapBrokerStringSaslScramIpv6 != null;

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringTls. 
        /// <para>
        /// A string containing one or more DNS names (or IP) and TLS port pairs.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringTls { get; set; }

        /// <summary>
        /// Checks to see if the BootstrapBrokerStringTls property is set.
        /// </summary>
        internal bool IsSetBootstrapBrokerStringTls() => this.BootstrapBrokerStringTls != null;

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringTlsIpv6. 
        /// <para>
        /// A string that contains one or more DNS names (or IP) and TLS port pairs for IPv6 connectivity.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringTlsIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the BootstrapBrokerStringTlsIpv6 property is set.
        /// </summary>
        internal bool IsSetBootstrapBrokerStringTlsIpv6() => this.BootstrapBrokerStringTlsIpv6 != null;

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringVpcConnectivitySaslIam. 
        /// <para>
        /// A string containing one or more DNS names (or IP) and SASL/IAM port pairs for VPC
        /// connectivity.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringVpcConnectivitySaslIam { get; set; }

        /// <summary>
        /// Checks to see if the BootstrapBrokerStringVpcConnectivitySaslIam property is set.
        /// </summary>
        internal bool IsSetBootstrapBrokerStringVpcConnectivitySaslIam() => this.BootstrapBrokerStringVpcConnectivitySaslIam != null;

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringVpcConnectivitySaslScram. 
        /// <para>
        /// A string containing one or more DNS names (or IP) and SASL/SCRAM port pairs for VPC
        /// connectivity.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringVpcConnectivitySaslScram { get; set; }

        /// <summary>
        /// Checks to see if the BootstrapBrokerStringVpcConnectivitySaslScram property is set.
        /// </summary>
        internal bool IsSetBootstrapBrokerStringVpcConnectivitySaslScram() => this.BootstrapBrokerStringVpcConnectivitySaslScram != null;

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringVpcConnectivityTls. 
        /// <para>
        /// A string containing one or more DNS names (or IP) and TLS port pairs for VPC connectivity.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringVpcConnectivityTls { get; set; }

        /// <summary>
        /// Checks to see if the BootstrapBrokerStringVpcConnectivityTls property is set.
        /// </summary>
        internal bool IsSetBootstrapBrokerStringVpcConnectivityTls() => this.BootstrapBrokerStringVpcConnectivityTls != null;
    }
}
