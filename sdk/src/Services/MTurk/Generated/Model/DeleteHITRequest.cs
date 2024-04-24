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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
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
namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteHIT operation.
    /// The <c>DeleteHIT</c> operation is used to delete HIT that is no longer needed. Only
    /// the Requester who created the HIT can delete it. 
    /// 
    ///  
    /// <para>
    ///  You can only dispose of HITs that are in the <c>Reviewable</c> state, with all of
    /// their submitted assignments already either approved or rejected. If you call the DeleteHIT
    /// operation on a HIT that is not in the <c>Reviewable</c> state (for example, that has
    /// not expired, or still has active assignments), or on a HIT that is Reviewable but
    /// without all of its submitted assignments already approved or rejected, the service
    /// will return an error. 
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    ///  HITs are automatically disposed of after 120 days. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  After you dispose of a HIT, you can no longer approve the HIT's rejected assignments.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Disposed HITs are not returned in results for the ListHITs operation. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Disposing HITs can improve the performance of operations such as ListReviewableHITs
    /// and ListHITs. 
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class DeleteHITRequest : AmazonMTurkRequest
    {
        private string _hitId;

        /// <summary>
        /// Gets and sets the property HITId. 
        /// <para>
        /// The ID of the HIT to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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

    }
}