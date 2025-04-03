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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
        private IngressBooleanExpression _booleanExpression;
        private IngressIpv4Expression _ipExpression;
        private IngressIpv6Expression _ipv6Expression;
        private IngressStringExpression _stringExpression;
        private IngressTlsProtocolExpression _tlsExpression;

        /// <summary>
        /// Gets and sets the property BooleanExpression. 
        /// <para>
        /// This represents a boolean type condition matching on the incoming mail. It performs
        /// the boolean operation configured in 'Operator' and evaluates the 'Protocol' object
        /// against the 'Value'.
        /// </para>
        /// </summary>
        public IngressBooleanExpression BooleanExpression
        {
            get { return this._booleanExpression; }
            set { this._booleanExpression = value; }
        }

        // Check to see if BooleanExpression property is set
        internal bool IsSetBooleanExpression()
        {
            return this._booleanExpression != null;
        }

        /// <summary>
        /// Gets and sets the property IpExpression. 
        /// <para>
        /// This represents an IP based condition matching on the incoming mail. It performs the
        /// operation configured in 'Operator' and evaluates the 'Protocol' object against the
        /// 'Value'.
        /// </para>
        /// </summary>
        public IngressIpv4Expression IpExpression
        {
            get { return this._ipExpression; }
            set { this._ipExpression = value; }
        }

        // Check to see if IpExpression property is set
        internal bool IsSetIpExpression()
        {
            return this._ipExpression != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6Expression. 
        /// <para>
        /// This represents an IPv6 based condition matching on the incoming mail. It performs
        /// the operation configured in 'Operator' and evaluates the 'Protocol' object against
        /// the 'Value'.
        /// </para>
        /// </summary>
        public IngressIpv6Expression Ipv6Expression
        {
            get { return this._ipv6Expression; }
            set { this._ipv6Expression = value; }
        }

        // Check to see if Ipv6Expression property is set
        internal bool IsSetIpv6Expression()
        {
            return this._ipv6Expression != null;
        }

        /// <summary>
        /// Gets and sets the property StringExpression. 
        /// <para>
        /// This represents a string based condition matching on the incoming mail. It performs
        /// the string operation configured in 'Operator' and evaluates the 'Protocol' object
        /// against the 'Value'.
        /// </para>
        /// </summary>
        public IngressStringExpression StringExpression
        {
            get { return this._stringExpression; }
            set { this._stringExpression = value; }
        }

        // Check to see if StringExpression property is set
        internal bool IsSetStringExpression()
        {
            return this._stringExpression != null;
        }

        /// <summary>
        /// Gets and sets the property TlsExpression. 
        /// <para>
        /// This represents a TLS based condition matching on the incoming mail. It performs the
        /// operation configured in 'Operator' and evaluates the 'Protocol' object against the
        /// 'Value'.
        /// </para>
        /// </summary>
        public IngressTlsProtocolExpression TlsExpression
        {
            get { return this._tlsExpression; }
            set { this._tlsExpression = value; }
        }

        // Check to see if TlsExpression property is set
        internal bool IsSetTlsExpression()
        {
            return this._tlsExpression != null;
        }

    }
}