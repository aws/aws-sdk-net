/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-11-01
 *
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Amazon.CloudFront_2012_03_15.Model
{
    /// <summary>
    /// The origin protocol policy to apply to your origin. If HttpOnly is specified,
    /// CloudFront will use HTTP only to
    /// access the origin. If MatchViewer is specified,
    /// CloudFront will fetch from your origin using HTTP or
    /// HTTPS, based on the protocol of the viewer request.
    /// </summary>
    public enum OriginProtocolPolicy 
    {
        [XmlEnum(Name = "http-only")]
        HttpOnly,
        [XmlEnum(Name = "match-viewer")]
        MatchViewer };

    /// <summary>
    /// Custom origin information to associate with the distribution.
    /// </summary>
    public class CustomOrigin
    {
        string _dnsName;
        int _httpPort = 80;
        int _httpsPort = 443;
        OriginProtocolPolicy? _originProtocolPolicy;


        /// <summary>
        /// Initializes a new instance of the CustomOrigin class.
        /// </summary>
        public CustomOrigin()
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(1024);
            sb.Append("<CustomOrigin>");
            sb.AppendFormat("<DNSName>{0}</DNSName>", this.DNSName);
            sb.AppendFormat("<HTTPPort>{0}</HTTPPort>", this.HttpPort);
            sb.AppendFormat("<HTTPSPort>{0}</HTTPSPort>", this.HttpsPort);

            switch (this.ProtocolPolicy)
            {
                case OriginProtocolPolicy.HttpOnly:
                    sb.Append("<OriginProtocolPolicy>http-only</OriginProtocolPolicy>");
                    break;
                case OriginProtocolPolicy.MatchViewer:
                    sb.Append("<OriginProtocolPolicy>match-viewer</OriginProtocolPolicy>");
                    break;
            }

            sb.Append("</CustomOrigin>");
            return sb.ToString();
        }

        /// <summary>
        /// Initializes a new instance of the CustomOrigin class.
        /// </summary>
        /// <param name="dnsName">The DNS name of your Amazon S3 bucket.</param>
        public CustomOrigin(string dnsName)
        {
            this.DNSName = dnsName;
        }

        /// <summary>
        /// Gets or sets the origin to associate with the distribution. 
        /// For example: www.example.com.
        /// </summary>
        /// <value>The DNSName for the origin.</value>
        public string DNSName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        /// <summary>
        /// Sets the origin to associate with the distribution. 
        /// For example: www.example.com.
        /// 
        /// This instance is returned to allow method chaining.
        /// </summary>
        /// <param name="dnsName">The DNSName for the origin.</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CustomOrigin WithDNSName(string dnsName)
        {
            this.DNSName = dnsName;
            return this;
        }

        internal bool IsSetDNSName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets or sets the HTTP port.
        /// </summary>
        /// <value>The HTTP port.</value>
        [XmlElementAttribute(ElementName = "HTTPPort")]
        public int HttpPort
        {
            get { return this._httpPort; }
            set { this._httpPort = value; }
        }

        /// <summary>
        /// Sets the HTTP port.
        /// This instance is returned to allow method chaining.
        /// </summary>
        /// <param name="httpPort">The HTTP port.</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CustomOrigin WithHttpPort(int httpPort)
        {
            this.HttpPort = httpPort;
            return this;
        }

        /// <summary>
        /// Gets or sets the HTTPS port.
        /// </summary>
        /// <value>The HTTPS port.</value>
        [XmlElementAttribute(ElementName = "HTTPSPort")]
        public int HttpsPort
        {
            get{return this._httpsPort;}
            set{this._httpsPort = value;}
        }

        /// <summary>
        /// Sets the HTTPS port.
        /// This instance is returned to allow method chaining.
        /// </summary>
        /// <param name="httpsPort">The HTTPS port.</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CustomOrigin WithHttpsPort(int httpsPort)
        {
            this.HttpsPort = httpsPort;
            return this;
        }

        /// <summary>
        /// Gets or sets the origin protocol policy to apply to your origin. If HttpOnly is specified,
        /// CloudFront will use HTTP only to
        /// access the origin. If MatchViewer is specified,
        /// CloudFront will fetch from your origin using HTTP or
        /// HTTPS, based on the protocol of the viewer request.
        /// </summary>
        /// <value>The origin protocol policy.</value>
        [XmlElementAttribute(ElementName = "OriginProtocolPolicy")]
        public OriginProtocolPolicy? ProtocolPolicy
        {
            get{return this._originProtocolPolicy;}
            set{this._originProtocolPolicy = value;}
        }

        /// <summary>
        /// Sets the origin protocol policy to apply to your origin. If HttpOnly is specified,
        /// CloudFront will use HTTP only to
        /// access the origin. If MatchViewer is specified,
        /// CloudFront will fetch from your origin using HTTP or
        /// HTTPS, based on the protocol of the viewer request.
        /// This instance is returned to allow method chaining.
        /// </summary>
        /// <param name="protocolPolicy">The origin protocol policy.</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CustomOrigin WithProtocolPolicy(OriginProtocolPolicy protocolPolicy)
        {
            this.ProtocolPolicy = protocolPolicy;
            return this;
        }

        internal bool IsSetProtocolPolicy()
        {
            return this._originProtocolPolicy != null;
        }
    }
}
