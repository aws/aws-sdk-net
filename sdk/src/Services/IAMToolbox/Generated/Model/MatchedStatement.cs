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
 * Do not modify this file. This file is generated from the iam-toolbox-2018-05-10.normal.json service model.
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
namespace Amazon.IAMToolbox.Model
{
    /// <summary>
    /// A statement that matched during evaluation.
    /// </summary>
    public partial class MatchedStatement
    {
        private StatementEffect _evaluatedEffect;
        private string _sid;

        /// <summary>
        /// Gets and sets the property EvaluatedEffect. 
        /// <para>
        /// The evaluated effect of this statement. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALLOW</c> - The statement allows the action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DENY</c> - The statement denies the action.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StatementEffect EvaluatedEffect
        {
            get { return this._evaluatedEffect; }
            set { this._evaluatedEffect = value; }
        }

        // Check to see if EvaluatedEffect property is set
        internal bool IsSetEvaluatedEffect()
        {
            return this._evaluatedEffect != null;
        }

        /// <summary>
        /// Gets and sets the property Sid. 
        /// <para>
        /// The statement ID (Sid). If the statement has no Sid, one is generated for reference.
        /// </para>
        /// </summary>
        public string Sid
        {
            get { return this._sid; }
            set { this._sid = value; }
        }

        // Check to see if Sid property is set
        internal bool IsSetSid()
        {
            return this._sid != null;
        }

    }
}