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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A logical rule statement used to combine other rule statements with AND logic. You
    /// provide more than one <a>Statement</a> within the <c>AndStatement</c>.
    /// </summary>
    public partial class AndStatement
    {
        private List<Statement> _statements = AWSConfigs.InitializeCollections ? new List<Statement>() : null;

        /// <summary>
        /// Gets and sets the property Statements. 
        /// <para>
        /// The statements to combine with AND logic. You can use any statements that can be nested.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Statement> Statements
        {
            get { return this._statements; }
            set { this._statements = value; }
        }

        // Check to see if Statements property is set
        internal bool IsSetStatements()
        {
            return this._statements != null && (this._statements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}