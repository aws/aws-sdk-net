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
    /// Contains details about a request to disassociate a code repository from a scan configuration.
    /// </summary>
    public partial class DisassociateConfigurationRequest
    {
        private CodeSecurityResource _resource;
        private string _scanConfigurationArn;

        /// <summary>
        /// Gets and sets the property Resource.
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
        /// Gets and sets the property ScanConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the scan configuration to disassociate from a code
        /// repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScanConfigurationArn
        {
            get { return this._scanConfigurationArn; }
            set { this._scanConfigurationArn = value; }
        }

        // Check to see if ScanConfigurationArn property is set
        internal bool IsSetScanConfigurationArn()
        {
            return this._scanConfigurationArn != null;
        }

    }
}