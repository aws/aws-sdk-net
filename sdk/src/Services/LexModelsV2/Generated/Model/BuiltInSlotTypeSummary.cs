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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Provides summary information about a built-in slot type for the <a href="https://docs.aws.amazon.com/lexv2/latest/APIReference/API_ListBuiltInSlotTypes.html">
    /// ListBuiltInSlotTypes </a> operation.
    /// </summary>
    public partial class BuiltInSlotTypeSummary
    {
        private string _description;
        private string _slotTypeSignature;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the built-in slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property SlotTypeSignature. 
        /// <para>
        /// The signature of the built-in slot type. Use this to specify the parent slot type
        /// of a derived slot type.
        /// </para>
        /// </summary>
        public string SlotTypeSignature
        {
            get { return this._slotTypeSignature; }
            set { this._slotTypeSignature = value; }
        }

        // Check to see if SlotTypeSignature property is set
        internal bool IsSetSlotTypeSignature()
        {
            return this._slotTypeSignature != null;
        }

    }
}