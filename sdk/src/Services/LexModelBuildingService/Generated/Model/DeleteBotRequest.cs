/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteBot operation.
    /// Deletes all versions of the bot, including the <code>$LATEST</code> version. To delete
    /// a specific version of the bot, use the <a>DeleteBotVersion</a> operation.
    /// 
    ///  
    /// <para>
    /// If a bot has an alias, you can't delete it. Instead, the <code>DeleteBot</code> operation
    /// returns a <code>ResourceInUseException</code> exception that includes a reference
    /// to the alias that refers to the bot. To remove the reference to the bot, delete the
    /// alias. If you get the same exception again, delete the referring alias until the <code>DeleteBot</code>
    /// operation is successful.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions for the <code>lex:DeleteBot</code> action.
    /// </para>
    /// </summary>
    public partial class DeleteBotRequest : AmazonLexModelBuildingServiceRequest
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the bot. The name is case sensitive. 
        /// </para>
        /// </summary>
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