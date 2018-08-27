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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Signer.Model
{
    /// <summary>
    /// The hash algorithms that are available to an AWS Signer job.
    /// </summary>
    public partial class HashAlgorithmOptions
    {
        private List<string> _allowedValues = new List<string>();
        private HashAlgorithm _defaultValue;

        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// The set of accepted hash algorithms allowed in an AWS Signer job.
        /// </para>
        /// </summary>
        public List<string> AllowedValues
        {
            get { return this._allowedValues; }
            set { this._allowedValues = value; }
        }

        // Check to see if AllowedValues property is set
        internal bool IsSetAllowedValues()
        {
            return this._allowedValues != null && this._allowedValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default hash algorithm that is used in an AWS Signer job.
        /// </para>
        /// </summary>
        public HashAlgorithm DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

    }
}