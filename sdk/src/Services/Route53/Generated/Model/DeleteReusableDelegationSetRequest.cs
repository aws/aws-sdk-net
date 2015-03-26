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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteReusableDelegationSet operation.
    /// This action deletes a reusable delegation set. To delete a reusable delegation set,
    /// send a <code>DELETE</code> request to the <code>2013-04-01/delegationset/<i>delegation
    /// set ID</i></code> resource.
    /// 
    ///  <important> You can delete a reusable delegation set only if there are no associated
    /// hosted zones. If your reusable delegation set contains associated hosted zones, you
    /// must delete them before you can delete your reusable delegation set. If you try to
    /// delete a reusable delegation set that contains associated hosted zones, Route 53 will
    /// deny your request with a <code>DelegationSetInUse</code> error.</important>
    /// </summary>
    public partial class DeleteReusableDelegationSetRequest : AmazonRoute53Request
    {
        private string _id;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The ID of the reusable delegation set you want to delete.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}