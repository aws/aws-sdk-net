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

namespace Amazon.CodeStarconnections.Model
{
    /// <summary>
    /// This is the response object from the GetResourceSyncStatus operation.
    /// </summary>
    public partial class GetResourceSyncStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DesiredState. 
        /// <para>
        /// The desired state of the Amazon Web Services resource for the sync status with the
        /// Git repository.
        /// </para>
        /// </summary>
        public Revision DesiredState { get; set; }

        /// <summary>
        /// Checks to see if the DesiredState property is set.
        /// </summary>
        internal bool IsSetDesiredState() => this.DesiredState != null;

        /// <summary>
        /// Gets and sets the property LatestSuccessfulSync. 
        /// <para>
        /// The latest successful sync for the sync status with the Git repository.
        /// </para>
        /// </summary>
        public ResourceSyncAttempt LatestSuccessfulSync { get; set; }

        /// <summary>
        /// Checks to see if the LatestSuccessfulSync property is set.
        /// </summary>
        internal bool IsSetLatestSuccessfulSync() => this.LatestSuccessfulSync != null;

        /// <summary>
        /// Gets and sets the property LatestSync. 
        /// <para>
        /// The latest sync for the sync status with the Git repository, whether successful or
        /// not.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceSyncAttempt LatestSync { get; set; }

        /// <summary>
        /// Checks to see if the LatestSync property is set.
        /// </summary>
        internal bool IsSetLatestSync() => this.LatestSync != null;
    }
}
