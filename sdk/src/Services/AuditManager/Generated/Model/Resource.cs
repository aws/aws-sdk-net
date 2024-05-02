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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
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
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// A system asset that's evaluated in an Audit Manager assessment.
    /// </summary>
    public partial class Resource
    {
        private string _arn;
        private string _complianceCheck;
        private string _value;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for the resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ComplianceCheck. 
        /// <para>
        ///  The evaluation status for a resource that was assessed when collecting compliance
        /// check evidence. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Audit Manager classes the resource as non-compliant if Security Hub reports a <i>Fail</i>
        /// result, or if Config reports a <i>Non-compliant</i> result.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Audit Manager classes the resource as compliant if Security Hub reports a <i>Pass</i>
        /// result, or if Config reports a <i>Compliant</i> result.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a compliance check isn't available or applicable, then no compliance evaluation
        /// can be made for that resource. This is the case if a resource assessment uses Config
        /// or Security Hub as the underlying data source type, but those services aren't enabled.
        /// This is also the case if the resource assessment uses an underlying data source type
        /// that doesn't support compliance checks (such as manual evidence, Amazon Web Services
        /// API calls, or CloudTrail). 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string ComplianceCheck
        {
            get { return this._complianceCheck; }
            set { this._complianceCheck = value; }
        }

        // Check to see if ComplianceCheck property is set
        internal bool IsSetComplianceCheck()
        {
            return this._complianceCheck != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        ///  The value of the resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}