/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateHITReviewStatus operation.
    /// The <code>UpdateHITReviewStatus</code> operation updates the status of a HIT. If
    /// the status is Reviewable, this operation can update the status to Reviewing, or it
    /// can revert a Reviewing HIT back to the Reviewable status.
    /// </summary>
    public partial class UpdateHITReviewStatusRequest : AmazonMTurkRequest
    {
        private string _hitId;
        private bool? _revert;

        /// <summary>
        /// Gets and sets the property HITId. 
        /// <para>
        ///  The ID of the HIT to update. 
        /// </para>
        /// </summary>
        public string HITId
        {
            get { return this._hitId; }
            set { this._hitId = value; }
        }

        // Check to see if HITId property is set
        internal bool IsSetHITId()
        {
            return this._hitId != null;
        }

        /// <summary>
        /// Gets and sets the property Revert. 
        /// <para>
        ///  Specifies how to update the HIT status. Default is <code>False</code>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Setting this to false will only transition a HIT from <code>Reviewable</code> to
        /// <code>Reviewing</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Setting this to true will only transition a HIT from <code>Reviewing</code> to <code>Reviewable</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool Revert
        {
            get { return this._revert.GetValueOrDefault(); }
            set { this._revert = value; }
        }

        // Check to see if Revert property is set
        internal bool IsSetRevert()
        {
            return this._revert.HasValue; 
        }

    }
}