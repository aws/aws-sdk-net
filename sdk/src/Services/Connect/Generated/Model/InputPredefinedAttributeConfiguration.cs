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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Custom metadata that is associated to predefined attributes to control behavior in
    /// upstream services, such as controlling how a predefined attribute should be displayed
    /// in the Amazon Connect admin website.
    /// </summary>
    public partial class InputPredefinedAttributeConfiguration
    {
        private bool? _enableValueValidationOnAssociation;

        /// <summary>
        /// Gets and sets the property EnableValueValidationOnAssociation. 
        /// <para>
        /// When this parameter is set to true, Amazon Connect enforces strict validation on the
        /// specific values, if the values are predefined in attributes. The contact will store
        /// only valid and predefined values for the predefined attribute key.
        /// </para>
        /// </summary>
        public bool EnableValueValidationOnAssociation
        {
            get { return this._enableValueValidationOnAssociation.GetValueOrDefault(); }
            set { this._enableValueValidationOnAssociation = value; }
        }

        // Check to see if EnableValueValidationOnAssociation property is set
        internal bool IsSetEnableValueValidationOnAssociation()
        {
            return this._enableValueValidationOnAssociation.HasValue; 
        }

    }
}