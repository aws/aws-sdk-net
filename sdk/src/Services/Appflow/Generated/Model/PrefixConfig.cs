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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Determines the prefix that Amazon AppFlow applies to the destination folder name.
    /// You can name your destination folders according to the flow frequency and date.
    /// </summary>
    public partial class PrefixConfig
    {
        private PrefixFormat _prefixFormat;
        private PrefixType _prefixType;

        /// <summary>
        /// Gets and sets the property PrefixFormat. 
        /// <para>
        ///  Determines the level of granularity that's included in the prefix. 
        /// </para>
        /// </summary>
        public PrefixFormat PrefixFormat
        {
            get { return this._prefixFormat; }
            set { this._prefixFormat = value; }
        }

        // Check to see if PrefixFormat property is set
        internal bool IsSetPrefixFormat()
        {
            return this._prefixFormat != null;
        }

        /// <summary>
        /// Gets and sets the property PrefixType. 
        /// <para>
        ///  Determines the format of the prefix, and whether it applies to the file name, file
        /// path, or both. 
        /// </para>
        /// </summary>
        public PrefixType PrefixType
        {
            get { return this._prefixType; }
            set { this._prefixType = value; }
        }

        // Check to see if PrefixType property is set
        internal bool IsSetPrefixType()
        {
            return this._prefixType != null;
        }

    }
}