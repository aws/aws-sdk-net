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
    /// A complex type that contains the information for each change in a change batch request.
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
        /// <param name="action">The action to perform. Valid values: <code>CREATE</code> | <code>DELETE</code> | <code>UPSERT</code></param>
        /// <param name="resourceRecordSet">Information about the resource record set to create or delete.</param>
        public Change(ChangeAction action, ResourceRecordSet resourceRecordSet)
        {
            _action = action;
            _resourceRecordSet = resourceRecordSet;
        }

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to perform.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>CREATE</code> | <code>DELETE</code> | <code>UPSERT</code>
        /// </para>
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
        /// Information about the resource record set to create or delete.
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