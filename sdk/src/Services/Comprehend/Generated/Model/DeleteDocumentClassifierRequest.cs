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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
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
namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDocumentClassifier operation.
    /// Deletes a previously created document classifier
    /// 
    ///  
    /// <para>
    /// Only those classifiers that are in terminated states (IN_ERROR, TRAINED) will be deleted.
    /// If an active inference job is using the model, a <c>ResourceInUseException</c> will
    /// be returned.
    /// </para>
    ///  
    /// <para>
    /// This is an asynchronous action that puts the classifier into a DELETING state, and
    /// it is then removed by a background job. Once removed, the classifier disappears from
    /// your account and is no longer available for use. 
    /// </para>
    /// </summary>
    public partial class DeleteDocumentClassifierRequest : AmazonComprehendRequest
    {
        private string _documentClassifierArn;

        /// <summary>
        /// Gets and sets the property DocumentClassifierArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the document classifier. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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