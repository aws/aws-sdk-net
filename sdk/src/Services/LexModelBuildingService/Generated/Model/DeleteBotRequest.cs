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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteBot operation.
    /// Deletes all versions of the bot, including the <c>$LATEST</c> version. To delete a
    /// specific version of the bot, use the <a>DeleteBotVersion</a> operation. The <c>DeleteBot</c>
    /// operation doesn't immediately remove the bot schema. Instead, it is marked for deletion
    /// and removed later.
    /// 
    ///  
    /// <para>
    /// Amazon Lex stores utterances indefinitely for improving the ability of your bot to
    /// respond to user inputs. These utterances are not removed when the bot is deleted.
    /// To remove the utterances, use the <a>DeleteUtterances</a> operation.
    /// </para>
    ///  
    /// <para>
    /// If a bot has an alias, you can't delete it. Instead, the <c>DeleteBot</c> operation
    /// returns a <c>ResourceInUseException</c> exception that includes a reference to the
    /// alias that refers to the bot. To remove the reference to the bot, delete the alias.
    /// If you get the same exception again, delete the referring alias until the <c>DeleteBot</c>
    /// operation is successful.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions for the <c>lex:DeleteBot</c> action.
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
        [AWSProperty(Required=true, Min=2, Max=50)]
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