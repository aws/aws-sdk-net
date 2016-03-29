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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The <code>Change</code> structure describes the changes AWS CloudFormation will perform
    /// if you execute the change set.
    /// </summary>
    public partial class Change
    {
        private ResourceChange _resourceChange;
        private ChangeType _type;

        /// <summary>
        /// Gets and sets the property ResourceChange. 
        /// <para>
        /// A <code>ResourceChange</code> structure that describes the resource and action that
        /// AWS CloudFormation will perform.
        /// </para>
        /// </summary>
        public ResourceChange ResourceChange
        {
            get { return this._resourceChange; }
            set { this._resourceChange = value; }
        }

        // Check to see if ResourceChange property is set
        internal bool IsSetResourceChange()
        {
            return this._resourceChange != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of entity that AWS CloudFormation changes. Currently, the only entity type
        /// is <code>Resource</code>.
        /// </para>
        /// </summary>
        public ChangeType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}