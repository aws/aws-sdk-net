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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Array of up to 10 validators.
    /// </summary>
    public partial class ValidationDataConfig
    {
        private List<Validator> _validators = AWSConfigs.InitializeCollections ? new List<Validator>() : null;

        /// <summary>
        /// Gets and sets the property Validators. 
        /// <para>
        /// Information about the validators.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<Validator> Validators
        {
            get { return this._validators; }
            set { this._validators = value; }
        }

        // Check to see if Validators property is set
        internal bool IsSetValidators()
        {
            return this._validators != null && (this._validators.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}