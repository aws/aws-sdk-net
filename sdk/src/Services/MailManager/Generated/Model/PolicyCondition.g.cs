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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The email traffic filtering conditions which are contained in a traffic policy resource.
    /// </summary>
    public partial class PolicyCondition
    {
        /// <summary>
        /// Gets and sets the property BooleanExpression. 
        /// <para>
        /// This represents a boolean type condition matching on the incoming mail. It performs
        /// the boolean operation configured in 'Operator' and evaluates the 'Protocol' object
        /// against the 'Value'.
        /// </para>
        /// </summary>
        public IngressBooleanExpression BooleanExpression { get; set; }

        /// <summary>
        /// Checks to see if the BooleanExpression property is set.
        /// </summary>
        internal bool IsSetBooleanExpression() => this.BooleanExpression != null;

        /// <summary>
        /// Gets and sets the property IpExpression. 
        /// <para>
        /// This represents an IP based condition matching on the incoming mail. It performs the
        /// operation configured in 'Operator' and evaluates the 'Protocol' object against the
        /// 'Value'.
        /// </para>
        /// </summary>
        public IngressIpv4Expression IpExpression { get; set; }

        /// <summary>
        /// Checks to see if the IpExpression property is set.
        /// </summary>
        internal bool IsSetIpExpression() => this.IpExpression != null;

        /// <summary>
        /// Gets and sets the property Ipv6Expression. 
        /// <para>
        /// This represents an IPv6 based condition matching on the incoming mail. It performs
        /// the operation configured in 'Operator' and evaluates the 'Protocol' object against
        /// the 'Value'.
        /// </para>
        /// </summary>
        public IngressIpv6Expression Ipv6Expression { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Expression property is set.
        /// </summary>
        internal bool IsSetIpv6Expression() => this.Ipv6Expression != null;

        /// <summary>
        /// Gets and sets the property StringExpression. 
        /// <para>
        /// This represents a string based condition matching on the incoming mail. It performs
        /// the string operation configured in 'Operator' and evaluates the 'Protocol' object
        /// against the 'Value'.
        /// </para>
        /// </summary>
        public IngressStringExpression StringExpression { get; set; }

        /// <summary>
        /// Checks to see if the StringExpression property is set.
        /// </summary>
        internal bool IsSetStringExpression() => this.StringExpression != null;

        /// <summary>
        /// Gets and sets the property TlsExpression. 
        /// <para>
        /// This represents a TLS based condition matching on the incoming mail. It performs the
        /// operation configured in 'Operator' and evaluates the 'Protocol' object against the
        /// 'Value'.
        /// </para>
        /// </summary>
        public IngressTlsProtocolExpression TlsExpression { get; set; }

        /// <summary>
        /// Checks to see if the TlsExpression property is set.
        /// </summary>
        internal bool IsSetTlsExpression() => this.TlsExpression != null;
    }
}
