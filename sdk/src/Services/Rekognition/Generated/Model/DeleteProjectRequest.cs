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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteProject operation.
    /// Deletes a Amazon Rekognition project. To delete a project you must first delete all
    /// models or adapters associated with the project. To delete a model or adapter, see
    /// <a>DeleteProjectVersion</a>.
    /// 
    ///  
    /// <para>
    ///  <c>DeleteProject</c> is an asynchronous operation. To check if the project is deleted,
    /// call <a>DescribeProjects</a>. The project is deleted when the project no longer appears
    /// in the response. Be aware that deleting a given project will also delete any <c>ProjectPolicies</c>
    /// associated with that project.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>rekognition:DeleteProject</c>
    /// action. 
    /// </para>
    /// </summary>
    public partial class DeleteProjectRequest : AmazonRekognitionRequest
    {
        private string _projectArn;

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the project that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ProjectArn
        {
            get { return this._projectArn; }
            set { this._projectArn = value; }
        }

        // Check to see if ProjectArn property is set
        internal bool IsSetProjectArn()
        {
            return this._projectArn != null;
        }

    }
}