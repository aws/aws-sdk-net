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
    /// Container for the parameters to the GetAnalysisLogExport operation.
    /// Returns information about an analysis log export, including its current status and,
    /// if the export failed, the reason for the failure.
    /// 
    ///  
    /// <para>
    /// Poll this operation until the <c>status</c> is <c>SUCCESS</c> or <c>FAILED</c>. An
    /// export can't be canceled after it starts.
    /// </para>
    /// </summary>
    public partial class GetAnalysisLogExportRequest : AmazonCleanRoomsRequest
    {
        private string _analysisLogExportIdentifier;
        private string _membershipIdentifier;

        /// <summary>
        /// Gets and sets the property AnalysisLogExportIdentifier. 
        /// <para>
        /// The unique identifier of the analysis log export to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AnalysisLogExportIdentifier
        {
            get { return this._analysisLogExportIdentifier; }
            set { this._analysisLogExportIdentifier = value; }
        }

        // Check to see if AnalysisLogExportIdentifier property is set
        internal bool IsSetAnalysisLogExportIdentifier()
        {
            return this._analysisLogExportIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// A unique identifier for the membership that the analysis log export belongs to. Currently
        /// accepts the membership ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

    }
}