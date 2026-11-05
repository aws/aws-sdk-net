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

namespace Amazon.QApps.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLibraryItemMetadata operation. Updates the
    /// verification status of a library item for an Amazon Q App.
    /// </summary>
    public partial class UpdateLibraryItemMetadataRequest : AmazonQAppsRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The unique identifier of the Amazon Q Business application environment instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property IsVerified. 
        /// <para>
        /// The verification status of the library item
        /// </para>
        /// </summary>
        public bool? IsVerified { get; set; }

        /// <summary>
        /// Checks to see if the IsVerified property is set.
        /// </summary>
        internal bool IsSetIsVerified() => this.IsVerified.HasValue;

        /// <summary>
        /// Gets and sets the property LibraryItemId. 
        /// <para>
        /// The unique identifier of the updated library item.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LibraryItemId { get; set; }

        /// <summary>
        /// Checks to see if the LibraryItemId property is set.
        /// </summary>
        internal bool IsSetLibraryItemId() => this.LibraryItemId != null;
    }
}
