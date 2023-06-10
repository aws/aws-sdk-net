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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// This is the response object from the GetServiceInstanceSyncStatus operation.
    /// </summary>
    public partial class GetServiceInstanceSyncStatusResponse : AmazonWebServiceResponse
    {
        private Revision _desiredState;
        private ResourceSyncAttempt _latestSuccessfulSync;
        private ResourceSyncAttempt _latestSync;

        /// <summary>
        /// Gets and sets the property DesiredState. 
        /// <para>
        /// The service instance sync desired state that's returned by Proton
        /// </para>
        /// </summary>
        public Revision DesiredState
        {
            get { return this._desiredState; }
            set { this._desiredState = value; }
        }

        // Check to see if DesiredState property is set
        internal bool IsSetDesiredState()
        {
            return this._desiredState != null;
        }

        /// <summary>
        /// Gets and sets the property LatestSuccessfulSync. 
        /// <para>
        /// The detailed data of the latest successful sync with the service instance.
        /// </para>
        /// </summary>
        public ResourceSyncAttempt LatestSuccessfulSync
        {
            get { return this._latestSuccessfulSync; }
            set { this._latestSuccessfulSync = value; }
        }

        // Check to see if LatestSuccessfulSync property is set
        internal bool IsSetLatestSuccessfulSync()
        {
            return this._latestSuccessfulSync != null;
        }

        /// <summary>
        /// Gets and sets the property LatestSync. 
        /// <para>
        /// The detailed data of the latest sync with the service instance.
        /// </para>
        /// </summary>
        public ResourceSyncAttempt LatestSync
        {
            get { return this._latestSync; }
            set { this._latestSync = value; }
        }

        // Check to see if LatestSync property is set
        internal bool IsSetLatestSync()
        {
            return this._latestSync != null;
        }

    }
}