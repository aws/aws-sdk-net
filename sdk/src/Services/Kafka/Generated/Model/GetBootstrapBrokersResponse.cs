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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// This is the response object from the GetBootstrapBrokers operation.
    /// </summary>
    public partial class GetBootstrapBrokersResponse : AmazonWebServiceResponse
    {
        private string _bootstrapBrokerString;
        private string _bootstrapBrokerStringIpv6;
        private string _bootstrapBrokerStringPublicSaslIam;
        private string _bootstrapBrokerStringPublicSaslScram;
        private string _bootstrapBrokerStringPublicTls;
        private string _bootstrapBrokerStringSaslIam;
        private string _bootstrapBrokerStringSaslIamIpv6;
        private string _bootstrapBrokerStringSaslScram;
        private string _bootstrapBrokerStringSaslScramIpv6;
        private string _bootstrapBrokerStringTls;
        private string _bootstrapBrokerStringTlsIpv6;
        private string _bootstrapBrokerStringVpcConnectivitySaslIam;
        private string _bootstrapBrokerStringVpcConnectivitySaslScram;
        private string _bootstrapBrokerStringVpcConnectivityTls;

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
        /// Gets and sets the property BootstrapBrokerStringIpv6.             
        /// <para>
        /// A string that contains one or more DNS names (or IP) and port pairs for IPv6 connectivity.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringIpv6
        {
            get { return this._bootstrapBrokerStringIpv6; }
            set { this._bootstrapBrokerStringIpv6 = value; }
        }

        // Check to see if BootstrapBrokerStringIpv6 property is set
        internal bool IsSetBootstrapBrokerStringIpv6()
        {
            return this._bootstrapBrokerStringIpv6 != null;
        }

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringPublicSaslIam.             
        /// <para>
        /// A string that contains one or more DNS names (or IP addresses) and SASL IAM port pairs.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringPublicSaslIam
        {
            get { return this._bootstrapBrokerStringPublicSaslIam; }
            set { this._bootstrapBrokerStringPublicSaslIam = value; }
        }

        // Check to see if BootstrapBrokerStringPublicSaslIam property is set
        internal bool IsSetBootstrapBrokerStringPublicSaslIam()
        {
            return this._bootstrapBrokerStringPublicSaslIam != null;
        }

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringPublicSaslScram.             
        /// <para>
        /// A string containing one or more DNS names (or IP) and Sasl Scram port pairs.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringPublicSaslScram
        {
            get { return this._bootstrapBrokerStringPublicSaslScram; }
            set { this._bootstrapBrokerStringPublicSaslScram = value; }
        }

        // Check to see if BootstrapBrokerStringPublicSaslScram property is set
        internal bool IsSetBootstrapBrokerStringPublicSaslScram()
        {
            return this._bootstrapBrokerStringPublicSaslScram != null;
        }

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringPublicTls.             
        /// <para>
        /// A string containing one or more DNS names (or IP) and TLS port pairs.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringPublicTls
        {
            get { return this._bootstrapBrokerStringPublicTls; }
            set { this._bootstrapBrokerStringPublicTls = value; }
        }

        // Check to see if BootstrapBrokerStringPublicTls property is set
        internal bool IsSetBootstrapBrokerStringPublicTls()
        {
            return this._bootstrapBrokerStringPublicTls != null;
        }

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringSaslIam.             
        /// <para>
        /// A string that contains one or more DNS names (or IP addresses) and SASL IAM port pairs.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringSaslIam
        {
            get { return this._bootstrapBrokerStringSaslIam; }
            set { this._bootstrapBrokerStringSaslIam = value; }
        }

        // Check to see if BootstrapBrokerStringSaslIam property is set
        internal bool IsSetBootstrapBrokerStringSaslIam()
        {
            return this._bootstrapBrokerStringSaslIam != null;
        }

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringSaslIamIpv6.             
        /// <para>
        /// A string that contains one or more DNS names (or IP) and SASL IAM port pairs for IPv6
        /// connectivity.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringSaslIamIpv6
        {
            get { return this._bootstrapBrokerStringSaslIamIpv6; }
            set { this._bootstrapBrokerStringSaslIamIpv6 = value; }
        }

        // Check to see if BootstrapBrokerStringSaslIamIpv6 property is set
        internal bool IsSetBootstrapBrokerStringSaslIamIpv6()
        {
            return this._bootstrapBrokerStringSaslIamIpv6 != null;
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
        /// Gets and sets the property BootstrapBrokerStringSaslScramIpv6.             
        /// <para>
        /// A string that contains one or more DNS names (or IP) and SASL SCRAM port pairs for
        /// IPv6 connectivity.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringSaslScramIpv6
        {
            get { return this._bootstrapBrokerStringSaslScramIpv6; }
            set { this._bootstrapBrokerStringSaslScramIpv6 = value; }
        }

        // Check to see if BootstrapBrokerStringSaslScramIpv6 property is set
        internal bool IsSetBootstrapBrokerStringSaslScramIpv6()
        {
            return this._bootstrapBrokerStringSaslScramIpv6 != null;
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

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringTlsIpv6.             
        /// <para>
        /// A string that contains one or more DNS names (or IP) and TLS port pairs for IPv6 connectivity.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringTlsIpv6
        {
            get { return this._bootstrapBrokerStringTlsIpv6; }
            set { this._bootstrapBrokerStringTlsIpv6 = value; }
        }

        // Check to see if BootstrapBrokerStringTlsIpv6 property is set
        internal bool IsSetBootstrapBrokerStringTlsIpv6()
        {
            return this._bootstrapBrokerStringTlsIpv6 != null;
        }

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringVpcConnectivitySaslIam.          
        ///   
        /// <para>
        /// A string containing one or more DNS names (or IP) and SASL/IAM port pairs for VPC
        /// connectivity.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringVpcConnectivitySaslIam
        {
            get { return this._bootstrapBrokerStringVpcConnectivitySaslIam; }
            set { this._bootstrapBrokerStringVpcConnectivitySaslIam = value; }
        }

        // Check to see if BootstrapBrokerStringVpcConnectivitySaslIam property is set
        internal bool IsSetBootstrapBrokerStringVpcConnectivitySaslIam()
        {
            return this._bootstrapBrokerStringVpcConnectivitySaslIam != null;
        }

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringVpcConnectivitySaslScram.        
        ///     
        /// <para>
        /// A string containing one or more DNS names (or IP) and SASL/SCRAM port pairs for VPC
        /// connectivity.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringVpcConnectivitySaslScram
        {
            get { return this._bootstrapBrokerStringVpcConnectivitySaslScram; }
            set { this._bootstrapBrokerStringVpcConnectivitySaslScram = value; }
        }

        // Check to see if BootstrapBrokerStringVpcConnectivitySaslScram property is set
        internal bool IsSetBootstrapBrokerStringVpcConnectivitySaslScram()
        {
            return this._bootstrapBrokerStringVpcConnectivitySaslScram != null;
        }

        /// <summary>
        /// Gets and sets the property BootstrapBrokerStringVpcConnectivityTls.             
        /// <para>
        /// A string containing one or more DNS names (or IP) and TLS port pairs for VPC connectivity.
        /// </para>
        /// </summary>
        public string BootstrapBrokerStringVpcConnectivityTls
        {
            get { return this._bootstrapBrokerStringVpcConnectivityTls; }
            set { this._bootstrapBrokerStringVpcConnectivityTls = value; }
        }

        // Check to see if BootstrapBrokerStringVpcConnectivityTls property is set
        internal bool IsSetBootstrapBrokerStringVpcConnectivityTls()
        {
            return this._bootstrapBrokerStringVpcConnectivityTls != null;
        }

    }
}