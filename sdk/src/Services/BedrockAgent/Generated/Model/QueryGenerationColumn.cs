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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains information about a column in the current table for the query engine to consider.
    /// </summary>
    public partial class QueryGenerationColumn
    {
        private string _description;
        private IncludeExclude _inclusion;
        private string _name;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the column that helps the query engine understand the contents of
        /// the column.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Inclusion. 
        /// <para>
        /// Specifies whether to include or exclude the column during query generation. If you
        /// specify <c>EXCLUDE</c>, the column will be ignored. If you specify <c>INCLUDE</c>,
        /// all other columns in the table will be ignored.
        /// </para>
        /// </summary>
        public IncludeExclude Inclusion
        {
            get { return this._inclusion; }
            set { this._inclusion = value; }
        }

        // Check to see if Inclusion property is set
        internal bool IsSetInclusion()
        {
            return this._inclusion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the column for which the other fields in this object apply.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
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

    }
}