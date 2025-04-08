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
    /// An object representing the collaboration member's payment responsibilities set by
    /// the collaboration creator for query and job compute costs.
    /// </summary>
    public partial class JobComputePaymentConfig
    {
        private bool? _isResponsible;

        /// <summary>
        /// Gets and sets the property IsResponsible. 
        /// <para>
        /// Indicates whether the collaboration creator has configured the collaboration member
        /// to pay for query and job compute costs (<c>TRUE</c>) or has not configured the collaboration
        /// member to pay for query and job compute costs (<c>FALSE</c>).
        /// </para>
        ///  
        /// <para>
        /// Exactly one member can be configured to pay for query and job compute costs. An error
        /// is returned if the collaboration creator sets a <c>TRUE</c> value for more than one
        /// member in the collaboration. 
        /// </para>
        ///  
        /// <para>
        /// An error is returned if the collaboration creator sets a <c>FALSE</c> value for the
        /// member who can run queries and jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsResponsible
        {
            get { return this._isResponsible; }
            set { this._isResponsible = value; }
        }

        // Check to see if IsResponsible property is set
        internal bool IsSetIsResponsible()
        {
            return this._isResponsible.HasValue; 
        }

    }
}