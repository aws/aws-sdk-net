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
    /// The reference that specifies where the axis label is applied to.
    /// </summary>
    public partial class AxisLabelReferenceOptions
    {
        private ColumnIdentifier _column;
        private string _fieldId;

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column that the axis label is targeted to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ColumnIdentifier Column
        {
            get { return this._column; }
            set { this._column = value; }
        }

        // Check to see if Column property is set
        internal bool IsSetColumn()
        {
            return this._column != null;
        }

        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// The field that the axis label is targeted to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string FieldId
        {
            get { return this._fieldId; }
            set { this._fieldId = value; }
        }

        // Check to see if FieldId property is set
        internal bool IsSetFieldId()
        {
            return this._fieldId != null;
        }

    }
}