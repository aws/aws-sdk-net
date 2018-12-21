/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the StopTrainingDocumentClassifier operation.
    /// Stops a document classifier training job while in progress.
    /// 
    ///  
    /// <para>
    /// If the training job state is <code>TRAINING</code>, the job is marked for termination
    /// and put into the <code>STOP_REQUESTED</code> state. If the training job completes
    /// before it can be stopped, it is put into the <code>TRAINED</code>; otherwise the training
    /// job is stopped and put into the <code>STOPPED</code> state and the service sends back
    /// an HTTP 200 response with an empty HTTP body. 
    /// </para>
    /// </summary>
    public partial class StopTrainingDocumentClassifierRequest : AmazonComprehendRequest
    {
        private string _documentClassifierArn;

        /// <summary>
        /// Gets and sets the property DocumentClassifierArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the document classifier currently being
        /// trained.
        /// </para>
        /// </summary>
        public string DocumentClassifierArn
        {
            get { return this._documentClassifierArn; }
            set { this._documentClassifierArn = value; }
        }

        // Check to see if DocumentClassifierArn property is set
        internal bool IsSetDocumentClassifierArn()
        {
            return this._documentClassifierArn != null;
        }

    }
}