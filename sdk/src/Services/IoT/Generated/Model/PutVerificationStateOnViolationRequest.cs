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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the PutVerificationStateOnViolation operation.
    /// Set a verification state and provide a description of that verification state on a
    /// violation (detect alarm).
    /// </summary>
    public partial class PutVerificationStateOnViolationRequest : AmazonIoTRequest
    {
        private VerificationState _verificationState;
        private string _verificationStateDescription;
        private string _violationId;

        /// <summary>
        /// Gets and sets the property VerificationState. 
        /// <para>
        /// The verification state of the violation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VerificationState VerificationState
        {
            get { return this._verificationState; }
            set { this._verificationState = value; }
        }

        // Check to see if VerificationState property is set
        internal bool IsSetVerificationState()
        {
            return this._verificationState != null;
        }

        /// <summary>
        /// Gets and sets the property VerificationStateDescription. 
        /// <para>
        /// The description of the verification state of the violation (detect alarm).
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string VerificationStateDescription
        {
            get { return this._verificationStateDescription; }
            set { this._verificationStateDescription = value; }
        }

        // Check to see if VerificationStateDescription property is set
        internal bool IsSetVerificationStateDescription()
        {
            return this._verificationStateDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ViolationId. 
        /// <para>
        /// The violation ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ViolationId
        {
            get { return this._violationId; }
            set { this._violationId = value; }
        }

        // Check to see if ViolationId property is set
        internal bool IsSetViolationId()
        {
            return this._violationId != null;
        }

    }
}