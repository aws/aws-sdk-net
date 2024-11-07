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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Container for the parameters to the CancelTrainedModelInferenceJob operation.
    /// Submits a request to cancel a trained model inference job.
    /// </summary>
    public partial class CancelTrainedModelInferenceJobRequest : AmazonCleanRoomsMLRequest
    {
        private string _membershipIdentifier;
        private string _trainedModelInferenceJobArn;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The membership ID of the trained model inference job that you want to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TrainedModelInferenceJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trained model inference job that you want to
        /// cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string TrainedModelInferenceJobArn
        {
            get { return this._trainedModelInferenceJobArn; }
            set { this._trainedModelInferenceJobArn = value; }
        }

        // Check to see if TrainedModelInferenceJobArn property is set
        internal bool IsSetTrainedModelInferenceJobArn()
        {
            return this._trainedModelInferenceJobArn != null;
        }

    }
}