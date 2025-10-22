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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
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
namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Describes the attributes of a link.
    /// </summary>
    public partial class LinkAttributes
    {
        private string _customerProvidedId;
        private List<ResponderErrorMaskingForHttpCode> _responderErrorMasking = AWSConfigs.InitializeCollections ? new List<ResponderErrorMaskingForHttpCode>() : null;

        /// <summary>
        /// Gets and sets the property CustomerProvidedId. 
        /// <para>
        /// The customer-provided unique identifier of the link.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CustomerProvidedId
        {
            get { return this._customerProvidedId; }
            set { this._customerProvidedId = value; }
        }

        // Check to see if CustomerProvidedId property is set
        internal bool IsSetCustomerProvidedId()
        {
            return this._customerProvidedId != null;
        }

        /// <summary>
        /// Gets and sets the property ResponderErrorMasking. 
        /// <para>
        /// Describes the masking for HTTP error codes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<ResponderErrorMaskingForHttpCode> ResponderErrorMasking
        {
            get { return this._responderErrorMasking; }
            set { this._responderErrorMasking = value; }
        }

        // Check to see if ResponderErrorMasking property is set
        internal bool IsSetResponderErrorMasking()
        {
            return this._responderErrorMasking != null && (this._responderErrorMasking.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}