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
 * Do not modify this file. This file is generated from the servicecatalog-appregistry-2020-06-24.normal.json service model.
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
namespace Amazon.AppRegistry.Model
{
    /// <summary>
    /// Container for the parameters to the PutConfiguration operation.
    /// Associates a <c>TagKey</c> configuration to an account.
    /// </summary>
    public partial class PutConfigurationRequest : AmazonAppRegistryRequest
    {
        private AppRegistryConfiguration _configuration;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        ///  Associates a <c>TagKey</c> configuration to an account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AppRegistryConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

    }
}