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
    /// Container for the parameters to the DeleteHostedZone operation.
    /// This action deletes a hosted zone. To delete a hosted zone, send a <code>DELETE</code>
    /// request to the <code>2013-04-01/hostedzone/<i>hosted zone ID</i></code> resource.
    /// 
    ///  
    /// <para>
    /// For more information about deleting a hosted zone, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DeleteHostedZone.html">Deleting
    /// a Hosted Zone</a> in the <i>Amazon Route 53 Developer Guide</i>.
    /// </para>
    ///  <important> You can delete a hosted zone only if there are no resource record sets
    /// other than the default SOA record and NS resource record sets. If your hosted zone
    /// contains other resource record sets, you must delete them before you can delete your
    /// hosted zone. If you try to delete a hosted zone that contains other resource record
    /// sets, Route 53 will deny your request with a <code>HostedZoneNotEmpty</code> error.
    /// For information about deleting records from your hosted zone, see <a>ChangeResourceRecordSets</a>.</important>
    /// </summary>
    public partial class DeleteHostedZoneRequest : AmazonRoute53Request
    {
        private string _id;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteHostedZoneRequest() { }

        /// <summary>
        /// Instantiates DeleteHostedZoneRequest with the parameterized properties
        /// </summary>
        /// <param name="id"> The ID of the hosted zone you want to delete.</param>
        public DeleteHostedZoneRequest(string id)
        {
            _id = id;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The ID of the hosted zone you want to delete.
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