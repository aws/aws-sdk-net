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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Describes a large-scale assessment (LSA) analysis run by a Fleet Advisor collector.
    /// </summary>
    public partial class FleetAdvisorLsaAnalysisResponse
    {
        private string _lsaAnalysisId;
        private string _status;

        /// <summary>
        /// Gets and sets the property LsaAnalysisId. 
        /// <para>
        /// The ID of an LSA analysis run by a Fleet Advisor collector.
        /// </para>
        /// </summary>
        public string LsaAnalysisId
        {
            get { return this._lsaAnalysisId; }
            set { this._lsaAnalysisId = value; }
        }

        // Check to see if LsaAnalysisId property is set
        internal bool IsSetLsaAnalysisId()
        {
            return this._lsaAnalysisId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of an LSA analysis run by a Fleet Advisor collector.
        /// </para>
        /// </summary>
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