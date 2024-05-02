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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Contains information about the expected and input values for the user turn.
    /// </summary>
    public partial class UserTurnSpecification
    {
        private UserTurnOutputSpecification _expected;
        private UserTurnInputSpecification _input;

        /// <summary>
        /// Gets and sets the property Expected. 
        /// <para>
        /// Contains results about the expected output for the user turn.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserTurnOutputSpecification Expected
        {
            get { return this._expected; }
            set { this._expected = value; }
        }

        // Check to see if Expected property is set
        internal bool IsSetExpected()
        {
            return this._expected != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Contains information about the user messages in the turn in the input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserTurnInputSpecification Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

    }
}