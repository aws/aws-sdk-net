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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
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
namespace Amazon.Tnb.Model
{
    /// <summary>
    /// Metadata related to the configuration properties used during update of a specific
    /// network function in a network instance.
    /// </summary>
    public partial class ModifyVnfInfoMetadata
    {
        private Amazon.Runtime.Documents.Document _vnfConfigurableProperties;
        private string _vnfInstanceId;

        /// <summary>
        /// Gets and sets the property VnfConfigurableProperties. 
        /// <para>
        /// The configurable properties used during update of the network function instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amazon.Runtime.Documents.Document VnfConfigurableProperties
        {
            get { return this._vnfConfigurableProperties; }
            set { this._vnfConfigurableProperties = value; }
        }

        // Check to see if VnfConfigurableProperties property is set
        internal bool IsSetVnfConfigurableProperties()
        {
            return !this._vnfConfigurableProperties.IsNull();
        }

        /// <summary>
        /// Gets and sets the property VnfInstanceId. 
        /// <para>
        /// The network function instance that was updated in the network instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VnfInstanceId
        {
            get { return this._vnfInstanceId; }
            set { this._vnfInstanceId = value; }
        }

        // Check to see if VnfInstanceId property is set
        internal bool IsSetVnfInstanceId()
        {
            return this._vnfInstanceId != null;
        }

    }
}