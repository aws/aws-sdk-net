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
    /// An object representing the collaboration member's model inference payment responsibilities
    /// set by the collaboration creator.
    /// </summary>
    public partial class MembershipModelInferencePaymentConfig
    {
        private bool? _isResponsible;

        /// <summary>
        /// Gets and sets the property IsResponsible. 
        /// <para>
        /// Indicates whether the collaboration member has accepted to pay for model inference
        /// costs (<c>TRUE</c>) or has not accepted to pay for model inference costs (<c>FALSE</c>).
        /// </para>
        ///  
        /// <para>
        /// If the collaboration creator has not specified anyone to pay for model inference costs,
        /// then the member who can query is the default payer. 
        /// </para>
        ///  
        /// <para>
        /// An error message is returned for the following reasons: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you set the value to <c>FALSE</c> but you are responsible to pay for model inference
        /// costs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you set the value to <c>TRUE</c> but you are not responsible to pay for model inference
        /// costs. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool IsResponsible
        {
            get { return this._isResponsible.GetValueOrDefault(); }
            set { this._isResponsible = value; }
        }

        // Check to see if IsResponsible property is set
        internal bool IsSetIsResponsible()
        {
            return this._isResponsible.HasValue; 
        }

    }
}