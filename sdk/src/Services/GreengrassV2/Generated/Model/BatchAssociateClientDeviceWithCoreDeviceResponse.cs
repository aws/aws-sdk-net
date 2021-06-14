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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// This is the response object from the BatchAssociateClientDeviceWithCoreDevice operation.
    /// </summary>
    public partial class BatchAssociateClientDeviceWithCoreDeviceResponse : AmazonWebServiceResponse
    {
        private List<AssociateClientDeviceWithCoreDeviceErrorEntry> _errorEntries = new List<AssociateClientDeviceWithCoreDeviceErrorEntry>();

        /// <summary>
        /// Gets and sets the property ErrorEntries. 
        /// <para>
        /// The list of any errors for the entries in the request. Each error entry contains the
        /// name of the AWS IoT thing that failed to associate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<AssociateClientDeviceWithCoreDeviceErrorEntry> ErrorEntries
        {
            get { return this._errorEntries; }
            set { this._errorEntries = value; }
        }

        // Check to see if ErrorEntries property is set
        internal bool IsSetErrorEntries()
        {
            return this._errorEntries != null && this._errorEntries.Count > 0; 
        }

    }
}