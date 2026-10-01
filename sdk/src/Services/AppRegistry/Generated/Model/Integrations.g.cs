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

namespace Amazon.AppRegistry.Model
{
    /// <summary>
    /// The information about the service integration.
    /// </summary>
    public partial class Integrations
    {
        /// <summary>
        /// Gets and sets the property ApplicationTagResourceGroup.
        /// </summary>
        public ResourceGroup ApplicationTagResourceGroup { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationTagResourceGroup property is set.
        /// </summary>
        internal bool IsSetApplicationTagResourceGroup() => this.ApplicationTagResourceGroup != null;

        /// <summary>
        /// Gets and sets the property ResourceGroup. 
        /// <para>
        ///  The information about the resource group integration.
        /// </para>
        /// </summary>
        public ResourceGroup ResourceGroup { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGroup property is set.
        /// </summary>
        internal bool IsSetResourceGroup() => this.ResourceGroup != null;
    }
}
