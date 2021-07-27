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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCell operation.
    /// Updates an existing Cell.
    /// </summary>
    public partial class UpdateCellRequest : AmazonRoute53RecoveryReadinessRequest
    {
        private string _cellName;
        private List<string> _cells = new List<string>();

        /// <summary>
        /// Gets and sets the property CellName. The Cell to update
        /// </summary>
        [AWSProperty(Required=true)]
        public string CellName
        {
            get { return this._cellName; }
            set { this._cellName = value; }
        }

        // Check to see if CellName property is set
        internal bool IsSetCellName()
        {
            return this._cellName != null;
        }

        /// <summary>
        /// Gets and sets the property Cells. A list of Cell arns, completely replaces previous
        /// list
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Cells
        {
            get { return this._cells; }
            set { this._cells = value; }
        }

        // Check to see if Cells property is set
        internal bool IsSetCells()
        {
            return this._cells != null && this._cells.Count > 0; 
        }

    }
}