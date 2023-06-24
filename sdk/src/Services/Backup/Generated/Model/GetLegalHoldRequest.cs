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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the GetLegalHold operation.
    /// This action returns details for a specified legal hold. The details are the body of
    /// a legal hold in JSON format, in addition to metadata.
    /// </summary>
    public partial class GetLegalHoldRequest : AmazonBackupRequest
    {
        private string _legalHoldId;

        /// <summary>
        /// Gets and sets the property LegalHoldId. 
        /// <para>
        /// This is the ID required to use <code>GetLegalHold</code>. This unique ID is associated
        /// with a specific legal hold.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LegalHoldId
        {
            get { return this._legalHoldId; }
            set { this._legalHoldId = value; }
        }

        // Check to see if LegalHoldId property is set
        internal bool IsSetLegalHoldId()
        {
            return this._legalHoldId != null;
        }

    }
}