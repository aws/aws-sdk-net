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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
    /// Information about a <c>Bounce</c> event.
    /// </summary>
    public partial class Bounce
    {
        private string _bounceSubType;
        private BounceType _bounceType;
        private string _diagnosticCode;

        /// <summary>
        /// Gets and sets the property BounceSubType. 
        /// <para>
        /// The subtype of the bounce, as determined by SES.
        /// </para>
        /// </summary>
        public string BounceSubType
        {
            get { return this._bounceSubType; }
            set { this._bounceSubType = value; }
        }

        // Check to see if BounceSubType property is set
        internal bool IsSetBounceSubType()
        {
            return this._bounceSubType != null;
        }

        /// <summary>
        /// Gets and sets the property BounceType. 
        /// <para>
        /// The type of the bounce, as determined by SES. Can be one of <c>UNDETERMINED</c>, <c>TRANSIENT</c>,
        /// or <c>PERMANENT</c> 
        /// </para>
        /// </summary>
        public BounceType BounceType
        {
            get { return this._bounceType; }
            set { this._bounceType = value; }
        }

        // Check to see if BounceType property is set
        internal bool IsSetBounceType()
        {
            return this._bounceType != null;
        }

        /// <summary>
        /// Gets and sets the property DiagnosticCode. 
        /// <para>
        /// The status code issued by the reporting Message Transfer Authority (MTA). This field
        /// only appears if a delivery status notification (DSN) was attached to the bounce and
        /// the <c>Diagnostic-Code</c> was provided in the DSN. 
        /// </para>
        /// </summary>
        public string DiagnosticCode
        {
            get { return this._diagnosticCode; }
            set { this._diagnosticCode = value; }
        }

        // Check to see if DiagnosticCode property is set
        internal bool IsSetDiagnosticCode()
        {
            return this._diagnosticCode != null;
        }

    }
}