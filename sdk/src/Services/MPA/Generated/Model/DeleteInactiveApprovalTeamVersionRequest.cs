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
    /// Container for the parameters to the DeleteInactiveApprovalTeamVersion operation.
    /// Deletes an inactive approval team. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-health.html">Team
    /// health</a> in the <i>Multi-party approval User Guide</i>.
    /// 
    ///  
    /// <para>
    /// You can also use this operation to delete a team draft. For more information, see
    /// <a href="https://docs.aws.amazon.com/mpa/latest/userguide/update-team.html#update-team-draft-status">Interacting
    /// with drafts</a> in the <i>Multi-party approval User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeleteInactiveApprovalTeamVersionRequest : AmazonMPARequest
    {
        private string _arn;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Amaazon Resource Name (ARN) for the team.
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
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version ID for the team.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}