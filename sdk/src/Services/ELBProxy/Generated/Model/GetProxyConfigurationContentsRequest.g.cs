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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ELBProxy.Model
{
    /// <summary>
    /// Container for the parameters to the GetProxyConfigurationContents operation. Retrieves
    /// the configuration file, the configuration archive, or both for the specified proxy.
    /// This operation is separate from GetProxy so that you can grant access to proxy metadata
    /// without granting access to the configuration content.
    /// </summary>
    public partial class GetProxyConfigurationContentsRequest : AmazonELBProxyRequest
    {
        /// <summary>
        /// Gets and sets the property IncludeConfigArchive. Indicates whether to include the
        /// configuration archive contents in the response. The default is `false`.
        /// </summary>
        public bool? IncludeConfigArchive { get; set; }

        /// <summary>
        /// Checks to see if the IncludeConfigArchive property is set.
        /// </summary>
        internal bool IsSetIncludeConfigArchive() => this.IncludeConfigArchive.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeConfigFile. Indicates whether to include the configuration
        /// file contents in the response. The default is `false`.
        /// </summary>
        public bool? IncludeConfigFile { get; set; }

        /// <summary>
        /// Checks to see if the IncludeConfigFile property is set.
        /// </summary>
        internal bool IsSetIncludeConfigFile() => this.IncludeConfigFile.HasValue;

        /// <summary>
        /// Gets and sets the property ProxyIdentifier. The Amazon Resource Name (ARN) of the
        /// proxy.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ProxyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProxyIdentifier property is set.
        /// </summary>
        internal bool IsSetProxyIdentifier() => this.ProxyIdentifier != null;
    }
}
