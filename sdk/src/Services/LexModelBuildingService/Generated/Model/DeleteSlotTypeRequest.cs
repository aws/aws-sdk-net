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
    /// Container for the parameters to the DeleteSlotType operation.
    /// Deletes a slot type. If you specify a version in the request, the API deletes the
    /// specific version. If you don't specify a version in the request, the API deletes all
    /// versions of the slot type, including the <code>$LATEST</code> version. 
    /// 
    ///  
    /// <para>
    ///  You can delete a version of a slot type only if it is not referenced. To delete a
    /// slot type that is referred to in one or more intents, you must remove those references
    /// first. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  If you get the <code>SlotTypeInUse</code> exception, the exception provides an example
    /// reference that shows the intent where the slot type is referenced. To remove the reference
    /// to the slot type, either update the intent or delete it. If you get the same exception
    /// when you attempt to delete the intent again, repeat until the intent has no references
    /// and the <code>DeleteSlotType</code> call is successful. 
    /// </para>
    ///  </note> 
    /// <para>
    /// This operation requires permission for the <code>lex:DeleteSlotType</code> action.
    /// </para>
    /// </summary>
    public partial class DeleteSlotTypeRequest : AmazonLexModelBuildingServiceRequest
    {
        private string _name;
        private string _version;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the slot type. The name is case sensitive. 
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the slot type.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}