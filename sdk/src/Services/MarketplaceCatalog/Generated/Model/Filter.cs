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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// A filter object, used to optionally filter results from calls to the <code>ListEntities</code>
    /// and <code>ListChangeSets</code> actions.
    /// </summary>
    public partial class Filter
    {
        private string _name;
        private List<string> _valueList = new List<string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// For <code>ListEntities</code>, the supported value for this is an <code>EntityId</code>.
        /// </para>
        ///  
        /// <para>
        /// For <code>ListChangeSets</code>, the supported values are as follows:
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property ValueList. 
        /// <para>
        ///  <code>ListEntities</code> - This is a list of unique <code>EntityId</code>s.
        /// </para>
        ///  
        /// <para>
        ///  <code>ListChangeSets</code> - The supported filter names and associated <code>ValueList</code>s
        /// is as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ChangeSetName</code> - The supported <code>ValueList</code> is a list of non-unique
        /// <code>ChangeSetName</code>s. These are defined when you call the <code>StartChangeSet</code>
        /// action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> - The supported <code>ValueList</code> is a list of statuses
        /// for all change set requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EntityId</code> - The supported <code>ValueList</code> is a list of unique
        /// <code>EntityId</code>s.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BeforeStartTime</code> - The supported <code>ValueList</code> is a list of
        /// all change sets that started before the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AfterStartTime</code> - The supported <code>ValueList</code> is a list of all
        /// change sets that started after the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BeforeEndTime</code> - The supported <code>ValueList</code> is a list of all
        /// change sets that ended before the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AfterEndTime</code> - The supported <code>ValueList</code> is a list of all
        /// change sets that ended after the filter value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> ValueList
        {
            get { return this._valueList; }
            set { this._valueList = value; }
        }

        // Check to see if ValueList property is set
        internal bool IsSetValueList()
        {
            return this._valueList != null && this._valueList.Count > 0; 
        }

    }
}