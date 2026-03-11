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
    /// Specifies a mapping to override the name of an output column from a transform operation.
    /// </summary>
    public partial class OutputColumnNameOverride
    {
        private string _outputColumnName;
        private string _sourceColumnName;

        /// <summary>
        /// Gets and sets the property OutputColumnName. 
        /// <para>
        /// The new name to assign to the column in the output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string OutputColumnName
        {
            get { return this._outputColumnName; }
            set { this._outputColumnName = value; }
        }

        // Check to see if OutputColumnName property is set
        internal bool IsSetOutputColumnName()
        {
            return this._outputColumnName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceColumnName. 
        /// <para>
        /// The original name of the column from the source transform operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SourceColumnName
        {
            get { return this._sourceColumnName; }
            set { this._sourceColumnName = value; }
        }

        // Check to see if SourceColumnName property is set
        internal bool IsSetSourceColumnName()
        {
            return this._sourceColumnName != null;
        }

    }
}