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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a payer responsibility setting for a VPC endpoint.
    /// </summary>
    public partial class PayerResponsibilityEntry
    {
        private PayerResponsibilityType _payerResponsibilityType;
        private PayerResponsibilityScope _scope;

        /// <summary>
        /// Gets and sets the property PayerResponsibilityType. 
        /// <para>
        /// The Amazon Web Services account to which the usage is charged.
        /// </para>
        /// </summary>
        public PayerResponsibilityType PayerResponsibilityType
        {
            get { return this._payerResponsibilityType; }
            set { this._payerResponsibilityType = value; }
        }

        // Check to see if PayerResponsibilityType property is set
        internal bool IsSetPayerResponsibilityType()
        {
            return this._payerResponsibilityType != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope of usage/charges.
        /// </para>
        /// </summary>
        public PayerResponsibilityScope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}