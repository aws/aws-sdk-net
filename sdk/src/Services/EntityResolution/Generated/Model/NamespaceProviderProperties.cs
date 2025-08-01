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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// An object containing <c>providerConfiguration</c> and <c>providerServiceArn</c>.
    /// </summary>
    public partial class NamespaceProviderProperties
    {
        private Amazon.Runtime.Documents.Document _providerConfiguration;
        private string _providerServiceArn;

        /// <summary>
        /// Gets and sets the property ProviderConfiguration. 
        /// <para>
        /// An object which defines any additional configurations required by the provider service.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document ProviderConfiguration
        {
            get { return this._providerConfiguration; }
            set { this._providerConfiguration = value; }
        }

        // Check to see if ProviderConfiguration property is set
        internal bool IsSetProviderConfiguration()
        {
            return !this._providerConfiguration.IsNull();
        }

        /// <summary>
        /// Gets and sets the property ProviderServiceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the provider service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=255)]
        public string ProviderServiceArn
        {
            get { return this._providerServiceArn; }
            set { this._providerServiceArn = value; }
        }

        // Check to see if ProviderServiceArn property is set
        internal bool IsSetProviderServiceArn()
        {
            return this._providerServiceArn != null;
        }

    }
}