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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// The optional clustering column portion of your primary key determines how the data
    /// is clustered and sorted within each partition.
    /// </summary>
    public partial class ClusteringKey
    {
        private string _name;
        private SortOrder _orderBy;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name(s) of the clustering column(s).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OrderBy. 
        /// <para>
        /// Sets the ascendant (<code>ASC</code>) or descendant (<code>DESC</code>) order modifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SortOrder OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }

        // Check to see if OrderBy property is set
        internal bool IsSetOrderBy()
        {
            return this._orderBy != null;
        }

    }
}