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

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// The parameters for EventBridge to use when invoking the resource endpoint.
    /// </summary>
    public partial class DescribeConnectionResourceParameters
    {
        /// <summary>
        /// Gets and sets the property ResourceAssociationArn. 
        /// <para>
        /// For connections to private APIs, the Amazon Resource Name (ARN) of the resource association
        /// EventBridge created between the connection and the private API's resource configuration.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/connection-private.html#connection-private-snra">
        /// Managing service network resource associations for connections</a> in the <i> <i>Amazon
        /// EventBridge User Guide</i> </i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 2048)]
        public string ResourceAssociationArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceAssociationArn property is set.
        /// </summary>
        internal bool IsSetResourceAssociationArn() => this.ResourceAssociationArn != null;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource configuration for the private API.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string ResourceConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationArn property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationArn() => this.ResourceConfigurationArn != null;
    }
}
