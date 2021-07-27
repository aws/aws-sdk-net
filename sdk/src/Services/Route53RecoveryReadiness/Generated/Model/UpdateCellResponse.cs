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
    /// This is the response object from the UpdateCell operation.
    /// </summary>
    public partial class UpdateCellResponse : AmazonWebServiceResponse
    {
        private string _cellArn;
        private string _cellName;
        private List<string> _cells = new List<string>();
        private List<string> _parentReadinessScopes = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property CellArn. The arn for the Cell
        /// </summary>
        [AWSProperty(Max=256)]
        public string CellArn
        {
            get { return this._cellArn; }
            set { this._cellArn = value; }
        }

        // Check to see if CellArn property is set
        internal bool IsSetCellArn()
        {
            return this._cellArn != null;
        }

        /// <summary>
        /// Gets and sets the property CellName. The name of the Cell
        /// </summary>
        [AWSProperty(Max=64)]
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
        /// Gets and sets the property Cells. A list of Cell arns
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property ParentReadinessScopes. A list of Cell ARNs and/or RecoveryGroup
        /// ARNs
        /// </summary>
        public List<string> ParentReadinessScopes
        {
            get { return this._parentReadinessScopes; }
            set { this._parentReadinessScopes = value; }
        }

        // Check to see if ParentReadinessScopes property is set
        internal bool IsSetParentReadinessScopes()
        {
            return this._parentReadinessScopes != null && this._parentReadinessScopes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}