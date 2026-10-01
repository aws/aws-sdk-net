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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about the reasoning why a check for access passed or failed.
    /// </summary>
    public partial class ReasonSummary
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the reasoning of a result of checking for access.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property StatementId. 
        /// <para>
        /// The identifier for the reason statement.
        /// </para>
        /// </summary>
        public string StatementId { get; set; }

        /// <summary>
        /// Checks to see if the StatementId property is set.
        /// </summary>
        internal bool IsSetStatementId() => this.StatementId != null;

        /// <summary>
        /// Gets and sets the property StatementIndex. 
        /// <para>
        /// The index number of the reason statement.
        /// </para>
        /// </summary>
        public int? StatementIndex { get; set; }

        /// <summary>
        /// Checks to see if the StatementIndex property is set.
        /// </summary>
        internal bool IsSetStatementIndex() => this.StatementIndex.HasValue;
    }
}
