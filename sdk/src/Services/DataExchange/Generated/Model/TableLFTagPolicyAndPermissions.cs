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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// The LF-tag policy and permissions that apply to table resources.
    /// </summary>
    public partial class TableLFTagPolicyAndPermissions
    {
        private List<LFTag> _expression = new List<LFTag>();
        private List<string> _permissions = new List<string>();

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// A list of LF-tag conditions that apply to table resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<LFTag> Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null && this._expression.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The permissions granted to subscribers on table resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && this._permissions.Count > 0; 
        }

    }
}