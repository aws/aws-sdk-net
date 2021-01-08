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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// This is the response object from the UpdateAcceleratorAttributes operation.
    /// </summary>
    public partial class UpdateAcceleratorAttributesResponse : AmazonWebServiceResponse
    {
        private AcceleratorAttributes _acceleratorAttributes;

        /// <summary>
        /// Gets and sets the property AcceleratorAttributes. 
        /// <para>
        /// Updated attributes for the accelerator.
        /// </para>
        /// </summary>
        public AcceleratorAttributes AcceleratorAttributes
        {
            get { return this._acceleratorAttributes; }
            set { this._acceleratorAttributes = value; }
        }

        // Check to see if AcceleratorAttributes property is set
        internal bool IsSetAcceleratorAttributes()
        {
            return this._acceleratorAttributes != null;
        }

    }
}