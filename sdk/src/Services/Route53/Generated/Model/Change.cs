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
    /// The information for each resource record set that you want to change.
    /// </summary>
    public partial class Change
    {
        private ChangeAction _action;
        private ResourceRecordSet _resourceRecordSet;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Change() { }

        /// <summary>
        /// Instantiates Change with the parameterized properties
        /// </summary>
        /// <param name="action">The action to perform: <ul> <li>  <code>CREATE</code>: Creates a resource record set that has the specified values. </li> <li>  <code>DELETE</code>: Deletes a existing resource record set. <important> To delete the resource record set that is associated with a traffic policy instance, use <code> <a>DeleteTrafficPolicyInstance</a> </code>. Amazon Route 53 will delete the resource record set automatically. If you delete the resource record set by using <code>ChangeResourceRecordSets</code>, Amazon Route 53 doesn't automatically delete the traffic policy instance, and you'll continue to be charged for it even though it's no longer in use.  </important> </li> <li>  <code>UPSERT</code>: If a resource record set doesn't already exist, Amazon Route 53 creates it. If a resource record set does exist, Amazon Route 53 updates it with the values in the request. </li> </ul></param>
        /// <param name="resourceRecordSet">Information about the resource record set to create, delete, or update.</param>
        public Change(ChangeAction action, ResourceRecordSet resourceRecordSet)
        {
            _action = action;
            _resourceRecordSet = resourceRecordSet;
        }

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to perform:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATE</code>: Creates a resource record set that has the specified values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETE</code>: Deletes a existing resource record set.
        /// </para>
        ///  <important> 
        /// <para>
        /// To delete the resource record set that is associated with a traffic policy instance,
        /// use <code> <a>DeleteTrafficPolicyInstance</a> </code>. Amazon Route 53 will delete
        /// the resource record set automatically. If you delete the resource record set by using
        /// <code>ChangeResourceRecordSets</code>, Amazon Route 53 doesn't automatically delete
        /// the traffic policy instance, and you'll continue to be charged for it even though
        /// it's no longer in use. 
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        ///  <code>UPSERT</code>: If a resource record set doesn't already exist, Amazon Route
        /// 53 creates it. If a resource record set does exist, Amazon Route 53 updates it with
        /// the values in the request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ChangeAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceRecordSet. 
        /// <para>
        /// Information about the resource record set to create, delete, or update.
        /// </para>
        /// </summary>
        public ResourceRecordSet ResourceRecordSet
        {
            get { return this._resourceRecordSet; }
            set { this._resourceRecordSet = value; }
        }

        // Check to see if ResourceRecordSet property is set
        internal bool IsSetResourceRecordSet()
        {
            return this._resourceRecordSet != null;
        }

    }
}