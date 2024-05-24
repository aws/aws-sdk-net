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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the GetMasterAccount operation.
    /// </summary>
    public partial class GetMasterAccountResponse : AmazonWebServiceResponse
    {
        private Invitation _master;

        /// <summary>
        /// Gets and sets the property Master. 
        /// <para>
        /// (Deprecated) The Amazon Web Services account ID for the administrator account. If
        /// the accounts are associated by a Macie membership invitation, this object also provides
        /// details about the invitation that was sent to establish the relationship between the
        /// accounts.
        /// </para>
        /// </summary>
        public Invitation Master
        {
            get { return this._master; }
            set { this._master = value; }
        }

        // Check to see if Master property is set
        internal bool IsSetMaster()
        {
            return this._master != null;
        }

    }
}