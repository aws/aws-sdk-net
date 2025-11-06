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
    /// Properties that control how columns are handled for a join operand, including column
    /// name overrides.
    /// </summary>
    public partial class JoinOperandProperties
    {
        private List<OutputColumnNameOverride> _outputColumnNameOverrides = AWSConfigs.InitializeCollections ? new List<OutputColumnNameOverride>() : null;

        /// <summary>
        /// Gets and sets the property OutputColumnNameOverrides. 
        /// <para>
        /// A list of column name overrides to apply to the join operand's output columns.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public List<OutputColumnNameOverride> OutputColumnNameOverrides
        {
            get { return this._outputColumnNameOverrides; }
            set { this._outputColumnNameOverrides = value; }
        }

        // Check to see if OutputColumnNameOverrides property is set
        internal bool IsSetOutputColumnNameOverrides()
        {
            return this._outputColumnNameOverrides != null && (this._outputColumnNameOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}