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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Filtering options for <i>ListGroups</i> operation. This is only used as input to
    /// Operation.
    /// </summary>
    public partial class ListGroupsFilters
    {
        private string _namePrefix;
        private string _primaryEmailPrefix;
        private EntityState _state;

        /// <summary>
        /// Gets and sets the property NamePrefix. 
        /// <para>
        /// Filters only groups with the provided name prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string NamePrefix
        {
            get { return this._namePrefix; }
            set { this._namePrefix = value; }
        }

        // Check to see if NamePrefix property is set
        internal bool IsSetNamePrefix()
        {
            return this._namePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryEmailPrefix. 
        /// <para>
        /// Filters only groups with the provided primary email prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string PrimaryEmailPrefix
        {
            get { return this._primaryEmailPrefix; }
            set { this._primaryEmailPrefix = value; }
        }

        // Check to see if PrimaryEmailPrefix property is set
        internal bool IsSetPrimaryEmailPrefix()
        {
            return this._primaryEmailPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Filters only groups with the provided state.
        /// </para>
        /// </summary>
        public EntityState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}