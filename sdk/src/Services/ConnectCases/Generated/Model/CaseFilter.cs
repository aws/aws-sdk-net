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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// A filter for cases. Only one value can be provided.
    /// </summary>
    public partial class CaseFilter
    {
        private List<CaseFilter> _andAll = new List<CaseFilter>();
        private FieldFilter _field;
        private CaseFilter _not;

        /// <summary>
        /// Gets and sets the property AndAll. 
        /// <para>
        /// Provides "and all" filtering.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<CaseFilter> AndAll
        {
            get { return this._andAll; }
            set { this._andAll = value; }
        }

        // Check to see if AndAll property is set
        internal bool IsSetAndAll()
        {
            return this._andAll != null && this._andAll.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// A list of fields to filter on.
        /// </para>
        /// </summary>
        public FieldFilter Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

        /// <summary>
        /// Gets and sets the property Not.
        /// </summary>
        public CaseFilter Not
        {
            get { return this._not; }
            set { this._not = value; }
        }

        // Check to see if Not property is set
        internal bool IsSetNot()
        {
            return this._not != null;
        }

    }
}