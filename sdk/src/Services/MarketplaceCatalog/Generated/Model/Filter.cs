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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// A filter object, used to optionally filter results from calls to the <c>ListEntities</c>
    /// and <c>ListChangeSets</c> actions.
    /// </summary>
    public partial class Filter
    {
        private string _name;
        private List<string> _valueList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// For <c>ListEntities</c>, the supported value for this is an <c>EntityId</c>.
        /// </para>
        ///  
        /// <para>
        /// For <c>ListChangeSets</c>, the supported values are as follows:
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
        ///  <c>ListEntities</c> - This is a list of unique <c>EntityId</c>s.
        /// </para>
        ///  
        /// <para>
        ///  <c>ListChangeSets</c> - The supported filter names and associated <c>ValueList</c>s
        /// is as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ChangeSetName</c> - The supported <c>ValueList</c> is a list of non-unique <c>ChangeSetName</c>s.
        /// These are defined when you call the <c>StartChangeSet</c> action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Status</c> - The supported <c>ValueList</c> is a list of statuses for all change
        /// set requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EntityId</c> - The supported <c>ValueList</c> is a list of unique <c>EntityId</c>s.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BeforeStartTime</c> - The supported <c>ValueList</c> is a list of all change sets
        /// that started before the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AfterStartTime</c> - The supported <c>ValueList</c> is a list of all change sets
        /// that started after the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BeforeEndTime</c> - The supported <c>ValueList</c> is a list of all change sets
        /// that ended before the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AfterEndTime</c> - The supported <c>ValueList</c> is a list of all change sets
        /// that ended after the filter value.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._valueList != null && (this._valueList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}