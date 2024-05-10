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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// An object representing the payment responsibilities accepted by the collaboration
    /// member.
    /// </summary>
    public partial class MembershipPaymentConfiguration
    {
        private MembershipQueryComputePaymentConfig _queryCompute;

        /// <summary>
        /// Gets and sets the property QueryCompute. 
        /// <para>
        /// The payment responsibilities accepted by the collaboration member for query compute
        /// costs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MembershipQueryComputePaymentConfig QueryCompute
        {
            get { return this._queryCompute; }
            set { this._queryCompute = value; }
        }

        // Check to see if QueryCompute property is set
        internal bool IsSetQueryCompute()
        {
            return this._queryCompute != null;
        }

    }
}