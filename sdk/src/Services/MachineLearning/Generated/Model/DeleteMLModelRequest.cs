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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteMLModel operation.
    /// Assigns the <code>DELETED</code> status to an <code>MLModel</code>, rendering it unusable.
    /// 
    ///  
    /// <para>
    /// After using the <code>DeleteMLModel</code> operation, you can use the <code>GetMLModel</code>
    /// operation to verify that the status of the <code>MLModel</code> changed to DELETED.
    /// </para>
    ///  
    /// <para>
    /// <b>Caution:</b> The result of the <code>DeleteMLModel</code> operation is irreversible.
    /// </para>
    /// </summary>
    public partial class DeleteMLModelRequest : AmazonMachineLearningRequest
    {
        private string _mlModelId;

        /// <summary>
        /// Gets and sets the property MLModelId. 
        /// <para>
        /// A user-supplied ID that uniquely identifies the <code>MLModel</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string MLModelId
        {
            get { return this._mlModelId; }
            set { this._mlModelId = value; }
        }

        // Check to see if MLModelId property is set
        internal bool IsSetMLModelId()
        {
            return this._mlModelId != null;
        }

    }
}