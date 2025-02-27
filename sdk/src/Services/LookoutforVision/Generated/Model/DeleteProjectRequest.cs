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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
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
namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteProject operation.
    /// Deletes an Amazon Lookout for Vision project.
    /// 
    ///  
    /// <para>
    /// To delete a project, you must first delete each version of the model associated with
    /// the project. To delete a model use the <a>DeleteModel</a> operation.
    /// </para>
    ///  
    /// <para>
    /// You also have to delete the dataset(s) associated with the model. For more information,
    /// see <a>DeleteDataset</a>. The images referenced by the training and test datasets
    /// aren't deleted. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>lookoutvision:DeleteProject</c>
    /// operation.
    /// </para>
    /// </summary>
    public partial class DeleteProjectRequest : AmazonLookoutforVisionRequest
    {
        private string _clientToken;
        private string _projectName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// ClientToken is an idempotency token that ensures a call to <c>DeleteProject</c> completes
        /// only once. You choose the value to pass. For example, An issue might prevent you from
        /// getting a response from <c>DeleteProject</c>. In this case, safely retry your call
        /// to <c>DeleteProject</c> by using the same <c>ClientToken</c> parameter value. 
        /// </para>
        ///  
        /// <para>
        /// If you don't supply a value for <c>ClientToken</c>, the AWS SDK you are using inserts
        /// a value for you. This prevents retries after a network error from making multiple
        /// project deletion requests. You'll need to provide your own value for other use cases.
        /// 
        /// </para>
        ///  
        /// <para>
        /// An error occurs if the other input parameters are not the same as in the first request.
        /// Using a different value for <c>ClientToken</c> is considered a new call to <c>DeleteProject</c>.
        /// An idempotency token is active for 8 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

    }
}