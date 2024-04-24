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
    /// Container for the parameters to the DeleteIntent operation.
    /// Deletes all versions of the intent, including the <c>$LATEST</c> version. To delete
    /// a specific version of the intent, use the <a>DeleteIntentVersion</a> operation.
    /// 
    ///  
    /// <para>
    ///  You can delete a version of an intent only if it is not referenced. To delete an
    /// intent that is referred to in one or more bots (see <a>how-it-works</a>), you must
    /// remove those references first. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  If you get the <c>ResourceInUseException</c> exception, it provides an example reference
    /// that shows where the intent is referenced. To remove the reference to the intent,
    /// either update the bot or delete it. If you get the same exception when you attempt
    /// to delete the intent again, repeat until the intent has no references and the call
    /// to <c>DeleteIntent</c> is successful. 
    /// </para>
    ///  </note> 
    /// <para>
    ///  This operation requires permission for the <c>lex:DeleteIntent</c> action. 
    /// </para>
    /// </summary>
    public partial class DeleteIntentRequest : AmazonLexModelBuildingServiceRequest
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the intent. The name is case sensitive. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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