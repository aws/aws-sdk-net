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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// The name and status of a customer agreement.
    /// </summary>
    public partial class CustomerAgreement
    {
        private string _agreementName;
        private string _status;

        /// <summary>
        /// Gets and sets the property AgreementName. 
        /// <para>
        /// The name of the agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public string AgreementName
        {
            get { return this._agreementName; }
            set { this._agreementName = value; }
        }

        // Check to see if AgreementName property is set
        internal bool IsSetAgreementName()
        {
            return this._agreementName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the customer agreement. This will be either <c>signed</c> or <c>unsigned</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=30)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}