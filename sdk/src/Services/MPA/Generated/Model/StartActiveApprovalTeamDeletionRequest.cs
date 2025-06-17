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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
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
namespace Amazon.MPA.Model
{
    /// <summary>
    /// Container for the parameters to the StartActiveApprovalTeamDeletion operation.
    /// Starts the deletion process for an active approval team.
    /// 
    ///  <note> 
    /// <para>
    ///  <b>Deletions require team approval</b> 
    /// </para>
    ///  
    /// <para>
    /// Requests to delete an active team must be approved by the team.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StartActiveApprovalTeamDeletionRequest : AmazonMPARequest
    {
        private string _arn;
        private int? _pendingWindowDays;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the team.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property PendingWindowDays. 
        /// <para>
        /// Number of days between when the team approves the delete request and when the team
        /// is deleted.
        /// </para>
        /// </summary>
        public int? PendingWindowDays
        {
            get { return this._pendingWindowDays; }
            set { this._pendingWindowDays = value; }
        }

        // Check to see if PendingWindowDays property is set
        internal bool IsSetPendingWindowDays()
        {
            return this._pendingWindowDays.HasValue; 
        }

    }
}