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
    /// This is the response object from the GetBuiltinIntent operation.
    /// </summary>
    public partial class GetBuiltinIntentResponse : AmazonWebServiceResponse
    {
        private string _signature;
        private List<BuiltinIntentSlot> _slots = new List<BuiltinIntentSlot>();
        private List<string> _supportedLocales = new List<string>();

        /// <summary>
        /// Gets and sets the property Signature. 
        /// <para>
        /// The unique identifier for a built-in intent.
        /// </para>
        /// </summary>
        public string Signature
        {
            get { return this._signature; }
            set { this._signature = value; }
        }

        // Check to see if Signature property is set
        internal bool IsSetSignature()
        {
            return this._signature != null;
        }

        /// <summary>
        /// Gets and sets the property Slots. 
        /// <para>
        /// An array of <code>BuiltinIntentSlot</code> objects, one entry for each slot type in
        /// the intent.
        /// </para>
        /// </summary>
        public List<BuiltinIntentSlot> Slots
        {
            get { return this._slots; }
            set { this._slots = value; }
        }

        // Check to see if Slots property is set
        internal bool IsSetSlots()
        {
            return this._slots != null && this._slots.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedLocales. 
        /// <para>
        /// A list of locales that the intent supports.
        /// </para>
        /// </summary>
        public List<string> SupportedLocales
        {
            get { return this._supportedLocales; }
            set { this._supportedLocales = value; }
        }

        // Check to see if SupportedLocales property is set
        internal bool IsSetSupportedLocales()
        {
            return this._supportedLocales != null && this._supportedLocales.Count > 0; 
        }

    }
}