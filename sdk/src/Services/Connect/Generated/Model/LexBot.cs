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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Configuration information of an Amazon Lex bot.
    /// </summary>
    public partial class LexBot
    {
        private string _lexRegion;
        private string _name;

        /// <summary>
        /// Gets and sets the property LexRegion. 
        /// <para>
        /// The Amazon Web Services Region where the Amazon Lex bot was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=60)]
        public string LexRegion
        {
            get { return this._lexRegion; }
            set { this._lexRegion = value; }
        }

        // Check to see if LexRegion property is set
        internal bool IsSetLexRegion()
        {
            return this._lexRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon Lex bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=50)]
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