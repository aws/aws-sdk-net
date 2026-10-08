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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains information about the DKIM authentication status for an email
    /// identity.
    /// 
    ///  
    /// <para>
    /// Amazon SES determines the authentication status by searching for specific records
    /// in the DNS configuration for the domain. If you used <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Easy
    /// DKIM</a> to set up DKIM authentication, Amazon SES tries to find three unique CNAME
    /// records in the DNS configuration for your domain. If you provided a public key to
    /// perform DKIM authentication, Amazon SES tries to find a TXT record that uses the selector
    /// that you specified. The value of the TXT record must be a public key that's paired
    /// with the private key that you specified in the process of creating the identity
    /// </para>
    /// </summary>
    public partial class DkimAttributes
    {
        /// <summary>
        /// Gets and sets the property CurrentSigningKeyLength. 
        /// <para>
        /// [Easy DKIM] The key length of the DKIM key pair in use.
        /// </para>
        /// </summary>
        public DkimSigningKeyLength CurrentSigningKeyLength { get; set; }

        /// <summary>
        /// Checks to see if the CurrentSigningKeyLength property is set.
        /// </summary>
        internal bool IsSetCurrentSigningKeyLength() => this.CurrentSigningKeyLength != null;

        /// <summary>
        /// Gets and sets the property LastKeyGenerationTimestamp. 
        /// <para>
        /// [Easy DKIM] The last time a key pair was generated for this identity.
        /// </para>
        /// </summary>
        public DateTime? LastKeyGenerationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastKeyGenerationTimestamp property is set.
        /// </summary>
        internal bool IsSetLastKeyGenerationTimestamp() => this.LastKeyGenerationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property NextSigningKeyLength. 
        /// <para>
        /// [Easy DKIM] The key length of the future DKIM key pair to be generated. This can be
        /// changed at most once per day.
        /// </para>
        /// </summary>
        public DkimSigningKeyLength NextSigningKeyLength { get; set; }

        /// <summary>
        /// Checks to see if the NextSigningKeyLength property is set.
        /// </summary>
        internal bool IsSetNextSigningKeyLength() => this.NextSigningKeyLength != null;

        /// <summary>
        /// Gets and sets the property SigningAttributesOrigin. 
        /// <para>
        /// A string that indicates how DKIM was configured for the identity. These are the possible
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS_SES</c> – Indicates that DKIM was configured for the identity by using <a
        /// href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Easy DKIM</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXTERNAL</c> – Indicates that DKIM was configured for the identity by using Bring
        /// Your Own DKIM (BYODKIM).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_&lt;REGION&gt;</c> – Indicates that DKIM was configured for the identity
        /// by replicating the signing attributes of a parent identity in another Amazon Web Services
        /// Region, using <a href="https://docs.aws.amazon.com/ses/latest/dg/send-email-authentication-dkim-deed.html">Deterministic
        /// Easy-DKIM (DEED)</a>. <c>&lt;REGION&gt;</c> is the Amazon Web Services Region of the
        /// parent identity, in uppercase with each hyphen replaced by an underscore. Amazon SES
        /// uses this format for every Amazon Web Services Region in which it supports DEED. For
        /// example, a parent identity in <c>us-east-1</c> is reported as <c>AWS_SES_US_EAST_1</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DkimSigningAttributesOrigin SigningAttributesOrigin { get; set; }

        /// <summary>
        /// Checks to see if the SigningAttributesOrigin property is set.
        /// </summary>
        internal bool IsSetSigningAttributesOrigin() => this.SigningAttributesOrigin != null;

        /// <summary>
        /// Gets and sets the property SigningEnabled. 
        /// <para>
        /// If the value is <c>true</c>, then the messages that you send from the identity are
        /// signed using DKIM. If the value is <c>false</c>, then the messages that you send from
        /// the identity aren't DKIM-signed.
        /// </para>
        /// </summary>
        public bool? SigningEnabled { get; set; }

        /// <summary>
        /// Checks to see if the SigningEnabled property is set.
        /// </summary>
        internal bool IsSetSigningEnabled() => this.SigningEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property SigningHostedZone. 
        /// <para>
        /// The hosted zone where Amazon SES publishes the DKIM public key TXT records for this
        /// email identity. This value indicates the DNS zone that customers must reference when
        /// configuring their CNAME records for DKIM authentication.
        /// </para>
        ///  
        /// <para>
        /// When configuring DKIM for your domain, create CNAME records in your DNS that point
        /// to the selectors in this hosted zone. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c> selector1._domainkey.yourdomain.com CNAME selector1.&lt;SigningHostedZone&gt;
        /// </c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> selector2._domainkey.yourdomain.com CNAME selector2.&lt;SigningHostedZone&gt;
        /// </c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> selector3._domainkey.yourdomain.com CNAME selector3.&lt;SigningHostedZone&gt;
        /// </c> 
        /// </para>
        /// </summary>
        public string SigningHostedZone { get; set; }

        /// <summary>
        /// Checks to see if the SigningHostedZone property is set.
        /// </summary>
        internal bool IsSetSigningHostedZone() => this.SigningHostedZone != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Describes whether or not Amazon SES has successfully located the DKIM records in the
        /// DNS records for the domain. The status can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> – The verification process was initiated, but Amazon SES hasn't yet
        /// detected the DKIM records in the DNS configuration for the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESS</c> – The verification process completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – The verification process failed. This typically occurs when Amazon
        /// SES fails to find the DKIM records in the DNS configuration of the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TEMPORARY_FAILURE</c> – A temporary issue is preventing Amazon SES from determining
        /// the DKIM authentication status of the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_STARTED</c> – The DKIM verification process hasn't been initiated for the
        /// domain.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DkimStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tokens. 
        /// <para>
        /// If you used <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Easy
        /// DKIM</a> to configure DKIM authentication for the domain, then this object contains
        /// a set of unique strings that you use to create a set of CNAME records that you add
        /// to the DNS configuration for your domain. When Amazon SES detects these records in
        /// the DNS configuration for your domain, the DKIM authentication process is complete.
        /// </para>
        ///  
        /// <para>
        /// If you configured DKIM authentication for the domain by providing your own public-private
        /// key pair, then this object contains the selector for the public key.
        /// </para>
        ///  
        /// <para>
        /// Regardless of the DKIM authentication method you use, Amazon SES searches for the
        /// appropriate records in the DNS configuration of the domain for up to 72 hours.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Tokens { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Tokens property is set.
        /// </summary>
        internal bool IsSetTokens() => this.Tokens != null && (this.Tokens.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
