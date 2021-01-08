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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// This is the response object from the DeleteLicense operation.
    /// </summary>
    public partial class DeleteLicenseResponse : AmazonWebServiceResponse
    {
        private string _deletionDate;
        private LicenseDeletionStatus _status;

        /// <summary>
        /// Gets and sets the property DeletionDate. 
        /// <para>
        /// Date on which the license is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public string DeletionDate
        {
            get { return this._deletionDate; }
            set { this._deletionDate = value; }
        }

        // Check to see if DeletionDate property is set
        internal bool IsSetDeletionDate()
        {
            return this._deletionDate != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// License status.
        /// </para>
        /// </summary>
        public LicenseDeletionStatus Status
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