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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the DeleteRegistry operation.
    /// </summary>
    public partial class DeleteRegistryResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property RegistryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the registry being deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10240)]
        public string RegistryArn { get; set; }

        /// <summary>
        /// Checks to see if the RegistryArn property is set.
        /// </summary>
        internal bool IsSetRegistryArn() => this.RegistryArn != null;

        /// <summary>
        /// Gets and sets the property RegistryName. 
        /// <para>
        /// The name of the registry being deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RegistryName { get; set; }

        /// <summary>
        /// Checks to see if the RegistryName property is set.
        /// </summary>
        internal bool IsSetRegistryName() => this.RegistryName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the registry. A successful operation will return the <c>Deleting</c>
        /// status.
        /// </para>
        /// </summary>
        public RegistryStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
