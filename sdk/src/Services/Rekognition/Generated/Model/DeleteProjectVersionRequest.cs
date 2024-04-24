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
    /// Container for the parameters to the DeleteProjectVersion operation.
    /// Deletes a Rekognition project model or project version, like a Amazon Rekognition
    /// Custom Labels model or a custom adapter.
    /// 
    ///  
    /// <para>
    /// You can't delete a project version if it is running or if it is training. To check
    /// the status of a project version, use the Status field returned from <a>DescribeProjectVersions</a>.
    /// To stop a project version call <a>StopProjectVersion</a>. If the project version is
    /// training, wait until it finishes.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>rekognition:DeleteProjectVersion</c>
    /// action. 
    /// </para>
    /// </summary>
    public partial class DeleteProjectVersionRequest : AmazonRekognitionRequest
    {
        private string _projectVersionArn;

        /// <summary>
        /// Gets and sets the property ProjectVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the project version that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ProjectVersionArn
        {
            get { return this._projectVersionArn; }
            set { this._projectVersionArn = value; }
        }

        // Check to see if ProjectVersionArn property is set
        internal bool IsSetProjectVersionArn()
        {
            return this._projectVersionArn != null;
        }

    }
}