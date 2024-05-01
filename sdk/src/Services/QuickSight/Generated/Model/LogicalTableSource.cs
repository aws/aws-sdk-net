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
    /// Information about the source of a logical table. This is a variant type structure.
    /// For this structure to be valid, only one of the attributes can be non-null.
    /// </summary>
    public partial class LogicalTableSource
    {
        private string _dataSetArn;
        private JoinInstruction _joinInstruction;
        private string _physicalTableId;

        /// <summary>
        /// Gets and sets the property DataSetArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the parent dataset.
        /// </para>
        /// </summary>
        public string DataSetArn
        {
            get { return this._dataSetArn; }
            set { this._dataSetArn = value; }
        }

        // Check to see if DataSetArn property is set
        internal bool IsSetDataSetArn()
        {
            return this._dataSetArn != null;
        }

        /// <summary>
        /// Gets and sets the property JoinInstruction. 
        /// <para>
        /// Specifies the result of a join of two logical tables.
        /// </para>
        /// </summary>
        public JoinInstruction JoinInstruction
        {
            get { return this._joinInstruction; }
            set { this._joinInstruction = value; }
        }

        // Check to see if JoinInstruction property is set
        internal bool IsSetJoinInstruction()
        {
            return this._joinInstruction != null;
        }

        /// <summary>
        /// Gets and sets the property PhysicalTableId. 
        /// <para>
        /// Physical table ID.
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