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

namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// This is the response object from the DeleteDataTransformationProfile operation.
    /// </summary>
    public partial class DeleteDataTransformationProfileResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DeletionTime. 
        /// <para>
        /// The timestamp when the profile was deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? DeletionTime { get; set; }

        /// <summary>
        /// Checks to see if the DeletionTime property is set.
        /// </summary>
        internal bool IsSetDeletionTime() => this.DeletionTime.HasValue;

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of the deleted profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 32)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of the deleted profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ProfileName { get; set; }

        /// <summary>
        /// Checks to see if the ProfileName property is set.
        /// </summary>
        internal bool IsSetProfileName() => this.ProfileName != null;
    }
}
