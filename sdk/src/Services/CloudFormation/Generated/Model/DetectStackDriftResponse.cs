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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// This is the response object from the DetectStackDrift operation.
    /// </summary>
    public partial class DetectStackDriftResponse : AmazonWebServiceResponse
    {
        private string _stackDriftDetectionId;

        /// <summary>
        /// Gets and sets the property StackDriftDetectionId. 
        /// <para>
        /// The ID of the drift detection results of this operation.
        /// </para>
        ///  
        /// <para>
        /// CloudFormation generates new results, with a new drift detection ID, each time this
        /// operation is run. However, the number of drift results CloudFormation retains for
        /// any given stack, and for how long, may vary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string StackDriftDetectionId
        {
            get { return this._stackDriftDetectionId; }
            set { this._stackDriftDetectionId = value; }
        }

        // Check to see if StackDriftDetectionId property is set
        internal bool IsSetStackDriftDetectionId()
        {
            return this._stackDriftDetectionId != null;
        }

    }
}