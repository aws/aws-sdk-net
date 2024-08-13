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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// This is the response object from the GetPartnerAccount operation.
    /// </summary>
    public partial class GetPartnerAccountResponse : AmazonWebServiceResponse
    {
        private bool? _accountLinked;
        private SidewalkAccountInfoWithFingerprint _sidewalk;

        /// <summary>
        /// Gets and sets the property AccountLinked. 
        /// <para>
        /// Whether the partner account is linked to the AWS account.
        /// </para>
        /// </summary>
        public bool? AccountLinked
        {
            get { return this._accountLinked; }
            set { this._accountLinked = value; }
        }

        // Check to see if AccountLinked property is set
        internal bool IsSetAccountLinked()
        {
            return this._accountLinked.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sidewalk. 
        /// <para>
        /// The Sidewalk account credentials.
        /// </para>
        /// </summary>
        public SidewalkAccountInfoWithFingerprint Sidewalk
        {
            get { return this._sidewalk; }
            set { this._sidewalk = value; }
        }

        // Check to see if Sidewalk property is set
        internal bool IsSetSidewalk()
        {
            return this._sidewalk != null;
        }

    }
}