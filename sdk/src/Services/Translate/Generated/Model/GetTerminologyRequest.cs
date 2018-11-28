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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Translate.Model
{
    /// <summary>
    /// Container for the parameters to the GetTerminology operation.
    /// Retrieves a custom terminology.
    /// </summary>
    public partial class GetTerminologyRequest : AmazonTranslateRequest
    {
        private string _name;
        private TerminologyDataFormat _terminologyDataFormat;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the custom terminology being retrieved.
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
        /// Gets and sets the property TerminologyDataFormat. 
        /// <para>
        /// The data format of the custom terminology being retrieved, either CSV or TMX.
        /// </para>
        /// </summary>
        public TerminologyDataFormat TerminologyDataFormat
        {
            get { return this._terminologyDataFormat; }
            set { this._terminologyDataFormat = value; }
        }

        // Check to see if TerminologyDataFormat property is set
        internal bool IsSetTerminologyDataFormat()
        {
            return this._terminologyDataFormat != null;
        }

    }
}