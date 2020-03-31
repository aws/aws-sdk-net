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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteProjectVersion operation.
    /// Deletes a version of a model. 
    /// 
    ///  
    /// <para>
    /// You must first stop the model before you can delete it. To check if a model is running,
    /// use the <code>Status</code> field returned from <a>DescribeProjectVersions</a>. To
    /// stop a running model call <a>StopProjectVersion</a>. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>rekognition:DeleteProjectVersion</code>
    /// action. 
    /// </para>
    /// </summary>
    public partial class DeleteProjectVersionRequest : AmazonRekognitionRequest
    {
        private string _projectVersionArn;

        /// <summary>
        /// Gets and sets the property ProjectVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model version that you want to delete.
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