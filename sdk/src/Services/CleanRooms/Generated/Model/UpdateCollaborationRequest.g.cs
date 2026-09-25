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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCollaboration operation. Updates collaboration
    /// metadata and can only be called by the collaboration owner.
    /// </summary>
    public partial class UpdateCollaborationRequest : AmazonCleanRoomsRequest
    {
        /// <summary>
        /// Gets and sets the property AnalyticsEngine. 
        /// <para>
        /// The analytics engine.
        /// </para>
        ///  <note> 
        /// <para>
        /// After July 16, 2025, the <c>CLEAN_ROOMS_SQL</c> parameter will no longer be available.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public AnalyticsEngine AnalyticsEngine { get; set; }

        /// <summary>
        /// Checks to see if the AnalyticsEngine property is set.
        /// </summary>
        internal bool IsSetAnalyticsEngine() => this.AnalyticsEngine != null;

        /// <summary>
        /// Gets and sets the property CollaborationIdentifier. 
        /// <para>
        /// The identifier for the collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string CollaborationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationIdentifier property is set.
        /// </summary>
        internal bool IsSetCollaborationIdentifier() => this.CollaborationIdentifier != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A human-readable identifier provided by the collaboration owner. Display names are
        /// not unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
