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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Container for the parameters to the GetCodeSecurityScan operation.
    /// Retrieves information about a specific code security scan.
    /// </summary>
    public partial class GetCodeSecurityScanRequest : AmazonInspector2Request
    {
        private CodeSecurityResource _resource;
        private string _scanId;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource identifier for the code repository that was scanned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CodeSecurityResource Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property ScanId. 
        /// <para>
        /// The unique identifier of the scan to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScanId
        {
            get { return this._scanId; }
            set { this._scanId = value; }
        }

        // Check to see if ScanId property is set
        internal bool IsSetScanId()
        {
            return this._scanId != null;
        }

    }
}