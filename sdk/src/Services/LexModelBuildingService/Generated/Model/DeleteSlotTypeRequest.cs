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
    /// Container for the parameters to the DeleteSlotType operation.
    /// Deletes all versions of the slot type, including the <c>$LATEST</c> version. To delete
    /// a specific version of the slot type, use the <a>DeleteSlotTypeVersion</a> operation.
    /// 
    ///  
    /// <para>
    ///  You can delete a version of a slot type only if it is not referenced. To delete a
    /// slot type that is referred to in one or more intents, you must remove those references
    /// first. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  If you get the <c>ResourceInUseException</c> exception, the exception provides an
    /// example reference that shows the intent where the slot type is referenced. To remove
    /// the reference to the slot type, either update the intent or delete it. If you get
    /// the same exception when you attempt to delete the slot type again, repeat until the
    /// slot type has no references and the <c>DeleteSlotType</c> call is successful. 
    /// </para>
    ///  </note> 
    /// <para>
    /// This operation requires permission for the <c>lex:DeleteSlotType</c> action.
    /// </para>
    /// </summary>
    public partial class DeleteSlotTypeRequest : AmazonLexModelBuildingServiceRequest
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the slot type. The name is case sensitive. 
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