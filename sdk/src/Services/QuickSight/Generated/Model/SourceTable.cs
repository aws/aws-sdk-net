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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A source table that provides initial data from either a physical table or parent dataset.
    /// </summary>
    public partial class SourceTable
    {
        private ParentDataSet _dataSet;
        private string _physicalTableId;

        /// <summary>
        /// Gets and sets the property DataSet. 
        /// <para>
        /// A parent dataset that serves as the data source instead of a physical table.
        /// </para>
        /// </summary>
        public ParentDataSet DataSet
        {
            get { return this._dataSet; }
            set { this._dataSet = value; }
        }

        // Check to see if DataSet property is set
        internal bool IsSetDataSet()
        {
            return this._dataSet != null;
        }

        /// <summary>
        /// Gets and sets the property PhysicalTableId. 
        /// <para>
        /// The identifier of the physical table that serves as the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string PhysicalTableId
        {
            get { return this._physicalTableId; }
            set { this._physicalTableId = value; }
        }

        // Check to see if PhysicalTableId property is set
        internal bool IsSetPhysicalTableId()
        {
            return this._physicalTableId != null;
        }

    }
}